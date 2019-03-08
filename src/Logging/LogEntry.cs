// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Lib;
using Grpc.Core;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Text;

namespace Google.Ads.GoogleAds.Logging
{
    /// <summary>
    /// Represents an entry that gets written to the logs.
    /// </summary>
    public class LogEntry
    {
        private readonly HashSet<string> REQUEST_HEADERS_TO_MASK =
            new HashSet<string>() { GoogleAdsConfig.DEVELOPER_TOKEN_KEYNAME };

        private readonly HashSet<string> RESPONSE_HEADERS_TO_MASK =
            new HashSet<string>() { };

        /// <summary>
        /// The max length of a summary log error message.
        /// </summary>
        private const int MAX_SUMMARY_ERROR_LENGTH = 16000;

        /// <summary>
        /// The string to use when truncating a summary log error.
        /// </summary>
        private const string ELLIPSIS = "...";

        /// <summary>
        /// Gets or sets the host.
        /// </summary>
        public string Host
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the method.
        /// </summary>
        public string Method
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the request.
        /// </summary>
        public object Request
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        public object Response
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the response.
        /// </summary>
        public RpcException Exception
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the request headers.
        /// </summary>
        public Metadata RequestHeaders
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the response headers.
        /// </summary>
        public Metadata ResponseHeaders
        {
            get;
            set;
        }

        /// <summary>
        /// The flag to indicate whether this request is a failure or not.
        /// </summary>
        public bool IsFailure
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the request ID for logging.
        /// </summary>
        private string RequestId
        {
            get
            {
                return new GoogleAdsResponseMetadata(ResponseHeaders).RequestId;
            }
        }

        /// <summary>
        /// Gets or sets the customer ID for logging.
        /// </summary>
        public string CustomerId
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="LogEntry"/> class.
        /// </summary>
        public LogEntry()
        {
        }

        /// <summary>
        /// Gets the detailed log.
        /// </summary>
        public string DetailedLog
        {
            get
            {
                return this.DetailedRequestLog + this.DetailedResponseLog;
            }
        }

        /// <summary>
        /// Gets the summary log.
        /// </summary>
        public string SummaryLog
        {
            get
            {
                return $"Request made: Host: {Host}, Method: {Method}, ClientCustomerID: " +
                    $"{CustomerId},  RequestID: {RequestId}, IsFault: {IsFailure}, " +
                    $"FaultMessage: {Exception?.Message}";
            }
        }

        /// <summary>
        /// Gets or sets the detailed request log.
        /// </summary>
        private string DetailedRequestLog
        {
            get
            {
                TraceFormatter formatter = new JsonBodyFormatter();

                StringBuilder builder = new StringBuilder();
                builder.AppendFormat("\r\n---------------BEGIN API CALL---------------\r\n");
                builder.AppendFormat("\r\nRequest\r\n");
                builder.AppendFormat("-------\r\n\r\n");

                builder.AppendFormat($"Method Name: {Method}\r\n");
                builder.AppendFormat($"Host: {Host}\r\n");
                builder.Append("Headers: " + formatter.MaskContents(FormatHeaders(RequestHeaders),
                    REQUEST_HEADERS_TO_MASK));
                builder.AppendFormat("\r\n\r\n{0}\r\n", formatter.MaskContents(Request.ToString(),
                    null));
                return builder.ToString();
            }
        }

        /// <summary>
        /// Gets or sets the detailed response log.
        /// </summary>
        private string DetailedResponseLog
        {
            get
            {
                TraceFormatter formatter = new JsonBodyFormatter();

                StringBuilder builder = new StringBuilder();
                builder.AppendFormat("\r\nResponse\r\n");
                builder.AppendFormat("--------\r\n");

                builder.Append("Headers: " + formatter.MaskContents(FormatHeaders(ResponseHeaders),
                    RESPONSE_HEADERS_TO_MASK));

                if (IsFailure)
                {
                    builder.AppendFormat("\r\n\r\nFault: {0}\r\n",
                        formatter.MaskContents(Exception.ToString(), null));
                }
                else
                {
                    builder.AppendFormat("\r\n\r\n{0}\r\n",
                        formatter.MaskContents(Response.ToString(), null));
                }

                builder.AppendFormat("----------------END API CALL----------------\r\n");
                return builder.ToString();
            }
        }

        /// <summary>
        /// Formats the metadata headers.
        /// </summary>
        /// <param name="metadata">The metadata.</param>
        /// <returns>The formatted text.</returns>
        private static string FormatHeaders(Metadata metadata)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            if (metadata != null)
            {
                foreach (Metadata.Entry entry in metadata)
                {
                    headers.Add(entry.Key, entry.Value);
                }
            }
            return JsonConvert.SerializeObject(headers);
        }
    }
}

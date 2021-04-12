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

using Google.Ads.GoogleAds.Lib;
using Google.Protobuf.WellKnownTypes;
using Grpc.Core;
using Microsoft.CSharp.RuntimeBinder;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Google.Ads.GoogleAds.Logging
{
    /// <summary>
    /// Represents an entry that gets written to the logs.
    /// </summary>
    public class LogEntry
    {
        private static readonly HashSet<string> REQUEST_HEADERS_TO_MASK =
            new HashSet<string>() { MetadataKeyNames.DeveloperToken };

        private static readonly HashSet<string> RESPONSE_HEADERS_TO_MASK =
            new HashSet<string>() { };

        private static readonly HashSet<string> REQUEST_RESPONSE_BODY_FIELDS_TO_MASK =
            new HashSet<string>() {
                MetadataKeyNames.CustomerUserAccessInviterEmailAddress,
                MetadataKeyNames.CustomerUserAccessEmailAddress,
                MetadataKeyNames.ChangeEventUserEmail,
                MetadataKeyNames.FeedPlaceholderEmailAddress,
                MetadataKeyNames.CustomerUserAccessInvitationEmailAddress,
            };

        private static readonly Regex GAQL_REDACTION_MATCHER =
            new Regex(string.Join("|", REQUEST_RESPONSE_BODY_FIELDS_TO_MASK));

        private const string MASK_PATTERN = "REDACTED";

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
        /// Gets or sets the partial failures text.
        /// </summary>
        public string PartialFailures
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
                StringBuilder builder = new StringBuilder();
                builder.Append("\r\n---------------BEGIN API CALL---------------\r\n");
                builder.Append("\r\nRequest\r\n");
                builder.Append("-------\r\n\r\n");

                builder.Append($"Method Name: {Method}\r\n");
                builder.Append($"Host: {Host}\r\n");
                builder.Append("Headers: " + FormatHeaders(RequestHeaders, REQUEST_HEADERS_TO_MASK));
                builder.Append($"\r\n\r\n{FormatBody(Request, REQUEST_RESPONSE_BODY_FIELDS_TO_MASK)}\r\n");
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
                StringBuilder builder = new StringBuilder();
                builder.Append("\r\nResponse\r\n");
                builder.Append("--------\r\n");

                builder.Append("Headers: " + FormatHeaders(
                    ResponseHeaders, RESPONSE_HEADERS_TO_MASK));

                if (IsFailure)
                {
                    builder.Append($"\r\n\r\nFault: {Exception}\r\n");
                }
                else
                {
                    builder.Append(
                        $"\r\n\r\n{FormatBody(Response, REQUEST_RESPONSE_BODY_FIELDS_TO_MASK)}\r\n");

                    if (!string.IsNullOrEmpty(PartialFailures))
                    {
                        builder.Append($"\r\nPartial failures: {PartialFailures}\r\n");
                    }
                }

                builder.AppendFormat("----------------END API CALL----------------\r\n");
                return builder.ToString();
            }
        }

        /// <summary>
        /// Formats the response body.
        /// </summary>
        /// <param name="body">The response body.</param>
        /// <param name="keysToMask">The keys to mask.</param>
        /// <returns>The formatted body.</returns>
        private static string FormatBody(object body, HashSet<string> keysToMask)
        {
            string bodyTypeName = body.GetType().Name;

            switch (bodyTypeName)
            {
                // Handle masking for GoogleAdsService::Search and GoogleAdsService::SearchStream
                // requests.
                // Note: We are proactively masking the whole query if we find a match of the
                // field we are interested in. We can make this more restrictive in the future
                // by masking only relevant section of the query.
                case "SearchGoogleAdsRequest":
                case "SearchGoogleAdsStreamRequest":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskQueryInSearchRequest(clonedMessage);
                        return clonedMessage.ToString();
                    }
                // Handle masking for GoogleAdsService::Search and GoogleAdsService::SearchStream
                // responses.
                // Note: We are taking advantage of the fact that when using the above methods,
                // the response contains the read field masks. We can examine them and skip
                // masking if the fields of interest aren't present in the list.
                // Note: It is important to clone the object first, or we will rewrite the response
                // returned to the user.
                // Note: We use the dynamic keyword in this code. This saves us a lot of reflection
                // code by having the compiler generate it for us.
                case "SearchGoogleAdsResponse":
                case "SearchGoogleAdsStreamResponse":
                    {
                        FieldMask fieldMask = GetFieldMask(body);
                        foreach (string mask in fieldMask.Paths)
                        {
                            if (keysToMask.Contains(mask))
                            {
                                object clonedMessage = CloneMessage(body);
                                MaskFieldsInSearchResponse(clonedMessage);
                                return clonedMessage.ToString();
                            }
                        }
                        return body.ToString();
                    }

                // Handle masking for CustomerUserAccessService::GetCustomerUserAccess.
                case "CustomerUserAccess":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskCustomerUserAccess(clonedMessage);
                        return clonedMessage.ToString();
                    }

                // Handle masking for FeedService::GetFeed.
                case "Feed":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskFeed(clonedMessage);
                        return clonedMessage.ToString();
                    }

                // Handle masking for FeedService::MutateFeeds.
                case "MutateFeedsRequest":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskMutateFeedsRequest(clonedMessage);
                        return clonedMessage.ToString();
                    }

                // Handle masking for CustomerUserAccessService::MutateCustomerUserAccess.
                case "MutateCustomerUserAccessRequest":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskMutateCustomerUserAccessRequest(clonedMessage);
                        return clonedMessage.ToString();
                    }

                // Handle masking for CustomerUserAccessService::MutateCustomerUserAccess.
                case "CreateCustomerClientRequest":
                    {
                        object clonedMessage = CloneMessage(body);
                        MaskCreateCustomerClientRequest(clonedMessage);
                        return clonedMessage.ToString();
                    }

                default:
                    return body.ToString();
            }
        }

        /// <summary>
        /// Masks the query in search request within a <code>SearchGoogleAdsRequest</code> or
        /// <code>SearchGoogleAdsStreamRequest</code> object when making
        /// <code>GoogleAdsService::Search</code> or <code>GoogleAdsService::SearchStream</code>
        /// call and privacy-sensitive fields are requested.
        /// </summary>
        /// <param name="body">The request body.</param>
        private static void MaskQueryInSearchRequest(dynamic body)
        {
            string query = body.Query;
            Match match = GAQL_REDACTION_MATCHER.Match(query);
            if (match.Success)
            {
                body.Query = MASK_PATTERN;
            }
        }

        /// <summary>
        /// Masks the email address fields within a <code>MutateFeedsRequest</code>
        /// object when making an <code>FeedService::MutateFeeds</code> API call.
        /// </summary>
        /// <param name="body">The request body.</param>
        private static void MaskMutateFeedsRequest(dynamic body)
        {
            try
            {
                if (body.Operations != null)
                {
                    foreach (var operation in body.Operations)
                    {
                        if (operation.Create != null)
                        {
                            MaskFeed(operation.Create);
                        }
                        if (operation.Update != null)
                        {
                            MaskFeed(operation.Update);
                        }
                    }
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the email address fields within a <code>CreateCustomerClientRequest</code>
        /// object.
        /// </summary>
        /// <param name="body">The request body.</param>
        private static void MaskCreateCustomerClientRequest(dynamic body)
        {
            try
            {
                if (body != null)
                {
                    body.EmailAddress = MASK_PATTERN;
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user access fields within a <code>MutateCustomerUserAccessRequest</code>
        /// object.
        /// </summary>
        /// <param name="body">The request body.</param>
        private static void MaskMutateCustomerUserAccessRequest(dynamic body)
        {
            try
            {
                if (body != null && body.Operation != null && body.Operation.Update != null)
                {
                    MaskCustomerUserAccess(body.Operation.Update);
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user access invitation fields within a
        /// <code>MutateCustomerUserAccessInvitationRequest</code> object.
        /// </summary>
        /// <param name="body">The request body.</param>
        private static void MaskMutateCustomerUserAccessInvitation(dynamic body)
        {
            try
            {
                if (body != null && body.Operation != null && body.Operation.Create != null)
                {
                    MaskCustomerUserAccessInvitation(body.Operation.Create);
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user access fields within a <code>SearchGoogleAdsResponse</code> or
        /// <code>SearchGoogleAdsStreamResponse</code> object when making
        /// <code>GoogleAdsService::Search</code> or <code>GoogleAdsService::SearchStream</code>
        /// call.
        /// </summary>
        /// <param name="response">The response object.</param>
        private static void MaskFieldsInSearchResponse(dynamic response)
        {
            try
            {
                if (response != null)
                {
                    foreach (var row in response.Results)
                    {
                        MaskCustomerUserAccess(row.CustomerUserAccess);
                        MaskCustomerUserAccessInvitation(row.CustomerUserAccessInvitation);
                        MaskChangeEvent(row.ChangeEvent);
                        MaskFeed(row.Feed);
                    }
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user email field within a <code>Feed</code> object.
        /// </summary>
        /// <param name="body">The <code>Feed</code> object.</param>
        private static void MaskFeed(dynamic body)
        {
            try
            {
                if (body != null && body.PlacesLocationFeedData != null)
                {
                    body.PlacesLocationFeedData.EmailAddress = MASK_PATTERN;
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user email field within a <code>ChangeEvent</code> object.
        /// </summary>
        /// <param name="body">The <code>ChangeEvent</code> object.</param>
        private static void MaskChangeEvent(dynamic body)
        {
            try
            {
                if (body != null)
                {
                    body.UserEmail = MASK_PATTERN;
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the user access fields within a <code>CustomerUserAccess</code> object.
        /// </summary>
        /// <param name="body">The <code>CustomerUserAccess</code> object.</param>
        private static void MaskCustomerUserAccess(dynamic body)
        {
            try
            {
                if (body != null)
                {
                    body.InviterUserEmailAddress = MASK_PATTERN;
                    body.EmailAddress = MASK_PATTERN;
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Masks the email field within a <code>CustomerUserAccessInvitation</code> object.
        /// </summary>
        /// <param name="body">The <code>CustomerUserAccessInvitation</code> object.</param>
        private static void MaskCustomerUserAccessInvitation(dynamic body)
        {
            try
            {
                if (body != null)
                {
                    body.EmailAddress = MASK_PATTERN;
                }
            }
            catch (RuntimeBinderException)
            {
            }
        }

        /// <summary>
        /// Clones the message.
        /// </summary>
        /// <param name="message">The message object.</param>
        /// <returns>The cloned message.</returns>
        private static object CloneMessage(dynamic message)
        {
            return message.Clone();
        }

        /// <summary>
        /// Gets the value of the field mask property of an object.
        /// </summary>
        /// <param name="response">The response object.</param>
        /// <returns>The value of the FieldMask property, or null if the value cannot be
        /// retrieved.</returns>
        private static FieldMask GetFieldMask(dynamic response)
        {
            try
            {
                return response.FieldMask;
            }
            catch (RuntimeBinderException)
            {
                return null;
            }
        }

        /// <summary>
        /// Formats the metadata headers.
        /// </summary>
        /// <param name="metadata">The header metadata.</param>
        /// <param name="keysToMask">The keys to mask.</param>
        /// <returns>The formatted text.</returns>
        private static string FormatHeaders(Metadata metadata, HashSet<string> keysToMask)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            if (metadata != null)
            {
                foreach (Metadata.Entry entry in metadata)
                {
                    if (keysToMask.Contains(entry.Key))
                    {
                        headers[entry.Key] = MASK_PATTERN;
                    }
                    else
                    {
                        if (entry.IsBinary)
                        {
                            headers[entry.Key] = Convert.ToBase64String(entry.ValueBytes);
                        }
                        else
                        {
                            headers[entry.Key] = entry.Value;
                        }
                    }
                }
            }
            return JsonConvert.SerializeObject(headers, Formatting.Indented);
        }
    }
}

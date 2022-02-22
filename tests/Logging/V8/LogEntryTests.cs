// Copyright 2021 Google LLC
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
using Google.Ads.GoogleAds.Logging;
using Google.Ads.GoogleAds.Tests.V8;
using Google.Ads.GoogleAds.V8.Errors;
using Grpc.Core;
using NUnit.Framework;

namespace Google.Ads.GoogleAds.Tests
{
    public sealed partial class HelloStreamResponse : IResponseMetadata
    {
    }
}

namespace Google.Ads.GoogleAds.Tests.Logging.V8
{
    /// <summary>
    /// Tests for <see cref="LogEntry"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class LogEntryTests
    {
        #region constants related to summary logs

        /// <summary>
        /// The host name.
        /// </summary>
        private const string TEST_HOST = "TEST_HOST";

        /// <summary>
        /// The method name.
        /// </summary>
        private const string TEST_METHOD = "TEST_METHOD";

        /// <summary>
        /// The developer token.
        /// </summary>
        private const string TEST_DEVELOPER_TOKEN = "TEST_DEVELOPER_TOKEN";

        /// <summary>
        /// The request ID.
        /// </summary>
        private const string TEST_REQUEST_ID = "TEST_REQUEST_ID";

        /// <summary>
        /// The customer ID.
        /// </summary>
        private const string TEST_CUSTOMER_ID = "1234567890";

        /// <summary>
        /// The partial failures.
        /// </summary>
        private const string TEST_PARTIAL_FAILURES = "PARTIAL_FAILURES";

        #endregion constants related to summary logs

        #region miscellaneous keys for metadata.

        private const string TEST_KEY1 = "TEST_KEY1";
        private const string TEST_VALUE1 = "TEST_VALUE1";
        private const string TEST_KEY2 = "TEST_KEY2";
        private const string TEST_VALUE2 = "TEST_VALUE2";

        #endregion miscellaneous keys for metadata.

        #region constants for request and response data.

        /// <summary>
        /// The request metadata headers.
        /// </summary>
        private readonly Metadata TEST_REQUEST_METADATA;

        /// <summary>
        /// The response metadata headers.
        /// </summary>
        private readonly Metadata TEST_RESPONSE_METADATA;

        /// <summary>
        /// The response metadata headers for streaming calls.
        /// </summary>
        private readonly Metadata TEST_STREAMING_RESPONSE_METADATA;

        /// <summary>
        /// The request sent to the server for method call.
        /// </summary>
        private readonly HelloRequest TEST_REQUEST = new HelloRequest()
        {
            CustomerId = TEST_CUSTOMER_ID,
            Name = "API",
            Age = 25,
            Address = new Address()
            {
                Line1 = "111 8th Ave",
                City = "New York",
                Zipcode = 10011,
                State = "NY"
            }
        };

        /// <summary>
        /// The response from the server for successful method call.
        /// </summary>
        private readonly HelloResponse TEST_RESPONSE = new HelloResponse()
        {
            Name = "API",
        };

        /// <summary>
        /// The request sent to the server for streaming method call.
        /// </summary>
        private readonly HelloStreamRequest TEST_STREAM_REQUEST = new HelloStreamRequest()
        {
            CustomerId = TEST_CUSTOMER_ID,
            Name = "API",
            Age = 25,
            Address = new Address()
            {
                Line1 = "111 8th Ave",
                City = "New York",
                Zipcode = 10011,
                State = "NY"
            }
        };

        /// <summary>
        /// The response from the server for successful streaming method call.
        /// </summary>
        private readonly HelloStreamResponse TEST_STREAM_RESPONSE = new HelloStreamResponse()
        {
            Name = "API",
            RequestId = TEST_REQUEST_ID
        };

        #endregion constants for request and response data.

        #region constants for constructing a test exception.

        /// <summary>
        /// The exception thrown by the server for a failed method call.
        /// </summary>
        private GoogleAdsException TEST_EXCEPTION;

        /// <summary>
        /// The error message when test exception is thrown.
        /// </summary>
        private const string TEST_ERROR_MESSAGE = "TEST_ERROR_MESSAGE";

        /// <summary>
        /// The error trigger when test exception is thrown.
        /// </summary>
        private const string TEST_ERROR_TRIGGER = "TEST_ERROR_TRIGGER";

        #endregion constants for constructing a test exception.

        /// <summary>
        /// The log formatter for running tests.
        /// </summary>
        ILogFormatter logFormatter = new LogFormatter();

        /// <summary>
        /// Initializes a new instance of the <see cref="LogEntryTests"/> class.
        /// </summary>
        public LogEntryTests()
        {
            // Initialize request metadata.
            TEST_REQUEST_METADATA = new Metadata();
            TEST_REQUEST_METADATA.Add(MetadataKeyNames.DeveloperToken, TEST_DEVELOPER_TOKEN);
            TEST_REQUEST_METADATA.Add(TEST_KEY1, TEST_VALUE1);

            // Initialize response metadata.
            TEST_RESPONSE_METADATA = new Metadata();
            TEST_RESPONSE_METADATA.Add(MetadataKeyNames.RequestId, TEST_REQUEST_ID);
            TEST_RESPONSE_METADATA.Add(TEST_KEY2, TEST_VALUE2);

            // Create an exception for testing purposes.

            TEST_EXCEPTION = TestUtils.CreateException(TEST_ERROR_MESSAGE, TEST_ERROR_TRIGGER,
                TEST_REQUEST_ID);

            TEST_STREAMING_RESPONSE_METADATA = new Metadata();
            TEST_STREAMING_RESPONSE_METADATA.Add(TEST_KEY2, TEST_VALUE2);
        }

        /// <summary>
        /// Test for Log entry files for a successful API call.
        /// </summary>
        [Test]
        public void TestSuccessLogs()
        {
            LogEntry logEntry = new LogEntry(logFormatter)
            {
                Host = TEST_HOST,
                Method = TEST_METHOD,
                RequestHeaders = TEST_REQUEST_METADATA,
                Request = TEST_REQUEST,
                ResponseHeaders = TEST_RESPONSE_METADATA,
                Response = TEST_RESPONSE,
                Exception = TEST_EXCEPTION,
                IsFailure = false,
                CustomerId = TEST_CUSTOMER_ID
            };

            AssertExtensions.AreMultiLineEqual(TestResources.DetailedSuccessLog,
                logEntry.DetailedLog);
            AssertExtensions.AreMultiLineEqual(TestResources.SummarySuccessLog,
                logEntry.SummaryLog);
        }

        /// <summary>
        /// Test for Log entry files for a successful streaming API call.
        /// </summary>
        /// <remarks>RequestId comes from the response object and not response
        /// headers.</remarks>
        [Test]
        public void TestSuccessStreamingLogs()
        {
            LogEntry logEntry = new LogEntry(logFormatter)
            {
                Host = TEST_HOST,
                Method = TEST_METHOD,
                RequestHeaders = TEST_REQUEST_METADATA,
                Request = TEST_STREAM_REQUEST,
                ResponseHeaders = TEST_STREAMING_RESPONSE_METADATA,
                Response = TEST_STREAM_RESPONSE,
                Exception = TEST_EXCEPTION,
                IsFailure = false,
                CustomerId = TEST_CUSTOMER_ID
            };

            AssertExtensions.AreMultiLineEqual(TestResources.DetailedStreamSuccessLog,
                logEntry.DetailedLog);
            AssertExtensions.AreMultiLineEqual(TestResources.SummaryStreamSuccessLog,
                logEntry.SummaryLog);
        }

        /// <summary>
        /// Test for Log entry files for a failed API call.
        /// </summary>
        [Test]
        public void TestFailureLogs()
        {
            LogEntry logEntry = new LogEntry(logFormatter)
            {
                Host = TEST_HOST,
                Method = TEST_METHOD,
                RequestHeaders = TEST_REQUEST_METADATA,
                Request = TEST_REQUEST,
                ResponseHeaders = TEST_RESPONSE_METADATA,
                Response = TEST_RESPONSE,
                Exception = TEST_EXCEPTION,
                IsFailure = true,
                CustomerId = TEST_CUSTOMER_ID
            };

            AssertExtensions.AreMultiLineEqual(TestResources.DetailedFailureLog,
                logEntry.DetailedLog);
            AssertExtensions.AreMultiLineEqual(TestResources.SummaryFailureLog,
                logEntry.SummaryLog);
        }

        /// <summary>
        /// Test for Log entry files for a successful API call with partial failures.
        /// </summary>
        [Test]
        public void TestPartialFailureLogs()
        {
            LogEntry logEntry = new LogEntry(logFormatter)
            {
                Host = TEST_HOST,
                Method = TEST_METHOD,
                RequestHeaders = TEST_REQUEST_METADATA,
                Request = TEST_REQUEST,
                ResponseHeaders = TEST_RESPONSE_METADATA,
                Response = TEST_RESPONSE,
                Exception = TEST_EXCEPTION,
                IsFailure = false,
                CustomerId = TEST_CUSTOMER_ID,
                PartialFailures = TEST_PARTIAL_FAILURES
            };

            AssertExtensions.AreMultiLineEqual(TestResources.DetailedPartialFailureLog,
                logEntry.DetailedLog);
            AssertExtensions.AreMultiLineEqual(TestResources.SummarySuccessLog,
                logEntry.SummaryLog);
        }
    }
}

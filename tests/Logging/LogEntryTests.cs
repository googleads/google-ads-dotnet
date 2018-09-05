﻿// Copyright 2018 Google LLC
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
using Google.Ads.GoogleAds.Logging;
using Grpc.Core;
using NUnit.Framework;

namespace Google.Ads.GoogleAds.Tests.Logging
{
    [TestFixture]
    public class LogEntryTests
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
        /// The request sent to the server for method call.
        /// </summary>
        private readonly HelloRequest TEST_REQUEST = new HelloRequest()
        {
            CustomerId = TEST_CUSTOMER_ID,
            Name = "API"
        };

        /// <summary>
        /// The response from the server for successful method call.
        /// </summary>
        private readonly HelloResponse TEST_RESPONSE = new HelloResponse()
        {
            Name = "API"
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
        /// Initializes a new instance of the <see cref="LogEntryTests"/> class.
        /// </summary>
        public LogEntryTests()
        {
            // Initialize request metadata.
            TEST_REQUEST_METADATA = new Metadata();
            TEST_REQUEST_METADATA.Add(GoogleAdsConfig.DEVELOPER_TOKEN_KEYNAME,
                TEST_DEVELOPER_TOKEN);
            TEST_REQUEST_METADATA.Add(TEST_KEY1, TEST_VALUE1);

            // Initialize response metadata.
            TEST_RESPONSE_METADATA = new Metadata();
            TEST_RESPONSE_METADATA.Add(GoogleAdsException.REQUEST_ID_KEY, TEST_REQUEST_ID);
            TEST_RESPONSE_METADATA.Add(TEST_KEY2, TEST_VALUE2);

            // Create an exception for testing purposes.

            TEST_EXCEPTION = TestUtils.CreateException(TEST_ERROR_MESSAGE, TEST_ERROR_TRIGGER,
                TEST_RESPONSE_METADATA);
        }

        /// <summary>
        /// Test for Log entry files for a successful API call.
        /// </summary>
        [Test]
        public void TestSuccessLogs()
        {
            LogEntry logEntry = new LogEntry()
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

            Assert.AreEqual(TestResources.DetailedSuccessLog.Trim(), logEntry.DetailedLog.Trim());
            Assert.AreEqual(TestResources.SummarySuccessLog.Trim(), logEntry.SummaryLog.Trim());
        }

        /// <summary>
        /// Test for Log entry files for a failed API call.
        /// </summary>
        [Test]
        public void TestFailureLogs()
        {
            LogEntry logEntry = new LogEntry()
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

            Assert.AreEqual(TestResources.DetailedFailureLog.Trim(), logEntry.DetailedLog.Trim());
            Assert.AreEqual(TestResources.SummaryFailureLog.Trim(), logEntry.SummaryLog.Trim());
        }
    }
}

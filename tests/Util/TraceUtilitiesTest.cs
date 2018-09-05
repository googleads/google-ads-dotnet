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

using Google.Ads.GoogleAds.Util;

using NUnit.Framework;

using System;
using System.Diagnostics;
using System.IO;
using System.Text;

namespace Google.Ads.GoogleAds.Tests.Util
{
    /// <summary>
    /// UnitTests for <see cref="TraceUtilities"/> class.
    /// </summary>
    [TestFixture]
    public class TraceUtilitiesTest
    {
        /// <summary>
        /// A test log message that is guaranteed to not contain any value that would cause false
        /// positives when testing.
        /// </summary>
        private const string TEST_LOG_MESSAGE = "test log message";

        private const string ERROR_MARKER = "Error: 1";
        private const string INFO_MARKER = "Information: 1";
        private const string WARNING_MARKER = "Warning: 1";
        private const string VERBOSE_MARKER = "Verbose: 1";

        /// <summary>
        /// Tests that deprecation warnings are written to the correct logs source at the expected
        /// log level.
        /// </summary>
        [Test]
        [Category("Small")]
        public void WriteDeprecationWarnings()
        {
            VerifyLog(TraceUtilities.DEPRECATION_MESSAGES_SOURCE, delegate ()
            {
                // Ensure deprecation warnings are logged at the warning level.
                TraceUtilities.WriteDeprecationWarnings(TEST_LOG_MESSAGE);
            }, WARNING_MARKER);
        }

        /// <summary>
        /// Tests that general warnings are written to the correct logs source at the expected log
        /// level.
        /// </summary>
        [Test]
        [Category("Small")]
        public void WriteGeneralWarnings()
        {
            VerifyLog(TraceUtilities.GENERAL_WARNING_MESSAGES_SOURCE, delegate ()
            {
                // Ensure general warnings are logged at the warning level.
                TraceUtilities.WriteGeneralWarnings(TEST_LOG_MESSAGE);
            }, WARNING_MARKER);
        }

        /// <summary>
        /// Tests that general errors are written to the correct logs source at the expected log
        /// level.
        /// </summary>
        [Test]
        [Category("Small")]
        public void WriteGeneralErrors()
        {
            VerifyLog(TraceUtilities.GENERAL_WARNING_MESSAGES_SOURCE, delegate ()
            {
                // Ensure general errors are logged at the error level.
                TraceUtilities.WriteGeneralErrors(TEST_LOG_MESSAGE);
            }, ERROR_MARKER);
        }

        /// <summary>
        /// Tests that summary success logs are written to the correct logs source at the expected
        /// log level.
        /// </summary>
        [Test]
        [Category("Small")]
        public void TestWriteSummaryRequestLogsSuccess()
        {
            VerifyLog(TraceUtilities.SUMMARY_REQUEST_LOGS_SOURCE, delegate ()
            {
                // Ensure success summaries are logged at the info level.
                TraceUtilities.WriteSummaryRequestLogs(TEST_LOG_MESSAGE, false);
            }, INFO_MARKER);
        }

        /// <summary>
        /// Tests that summary failure logs are written to the correct logs source at the expected
        /// log level.
        /// </summary>
        [Test]
        [Category("Small")]
        public void TestWriteSummaryRequestLogsFailure()
        {
            VerifyLog(TraceUtilities.SUMMARY_REQUEST_LOGS_SOURCE, delegate ()
            {
                // Ensure failure summaries are logged at the warning level.
                TraceUtilities.WriteSummaryRequestLogs(TEST_LOG_MESSAGE, true);
            }, WARNING_MARKER);
        }


        /// <summary>
        /// Tests that detailed success logs are written to the correct logs source at the
        /// expected log level.
        /// </summary>
        [Test]
        [Category("Small")]
        public void TestWriteDetailedRequestLogsSuccess()
        {
            VerifyLog(TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE, delegate ()
            {
                // Ensure success details are logged at the verbose level.
                TraceUtilities.WriteDetailedRequestLogs(TEST_LOG_MESSAGE, false);
            }, VERBOSE_MARKER);
        }

        /// <summary>
        /// Tests that detailed failure logs are written to the correct logs source at the
        /// expected log level.
        /// </summary>
        [Test]
        [Category("Small")]
        public void TestWriteDetailedRequestLogsFailure()
        {
            VerifyLog(TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE, delegate ()
            {
                // Ensure failure details are logged at the warning level.
                TraceUtilities.WriteDetailedRequestLogs(TEST_LOG_MESSAGE, true);
            }, INFO_MARKER);
        }

        /// <summary>
        /// Verifies that the text logged by <paramref name="loggingAction"/> contains
        /// <paramref name="markerToVerify"/> text.
        /// </summary>
        /// <param name="logSource">The log source.</param>
        /// <param name="loggingAction">The logging action.</param>
        /// <param name="markerToVerify">The marker to verify.</param>
        private void VerifyLog(string logSource, Action loggingAction, string markerToVerify)
        {
            using (var stream = new MemoryStream())
            {
                TraceUtilities.Configure(logSource, new StreamWriter(stream), SourceLevels.All);

                loggingAction();
                // Ensure failure summaries are logged at the warning level.
                TraceUtilities.WriteSummaryRequestLogs(TEST_LOG_MESSAGE, true);

                string logFromMemStream = Encoding.UTF8.GetString(stream.ToArray());
                StringAssert.Contains(markerToVerify, logFromMemStream);
            }

        }

    }
}

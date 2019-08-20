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
using Google.Ads.GoogleAds.Logging;
using Google.Ads.GoogleAds.Tests.V2;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V2.Errors;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Core.Interceptors;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Tests.Logging.V2
{
    /// <summary>
    /// Tests for <see cref="LoggingInterceptor"/> class.
    /// </summary>
    [TestFixture]
    internal class LoggingInterceptorTests : LoggingInterceptor
    {
        /// <summary>
        /// Request metadata for testing.
        /// </summary>
        private readonly Metadata TEST_REQUEST_METADATA;

        /// <summary>
        /// Response metadata for testing.
        /// </summary>
        private readonly Metadata TEST_RESPONSE_METADATA;

        /// <summary>
        /// The host name.
        /// </summary>
        private const string TEST_HOST = "TEST_HOST";

        /// <summary>
        /// The service name.
        /// </summary>
        private const string TEST_SERVICE = "TestService";

        /// <summary>
        /// The method name.
        /// </summary>
        private const string TEST_METHOD = "TestMethod";

        /// <summary>
        /// The method name, as it appears in the logs.
        /// </summary>
        private readonly string TEST_METHOD_IN_LOGS = $"/{TEST_SERVICE}/{TEST_METHOD}";

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
        /// The customer ID.
        /// </summary>
        private const string TEST_PARTIAL_FAILURE_TEXT = "TEST_PARTIAL_FAILURE_TEXT";

        /// <summary>
        /// The request object to send to the service.
        /// </summary>
        private readonly HelloRequest TEST_REQUEST = new HelloRequest()
        {
            CustomerId = TEST_CUSTOMER_ID,
            Name = "API"
        };

        /// <summary>
        /// The response to be returned by the service.
        /// </summary>
        private readonly HelloResponse TEST_RESPONSE = new HelloResponse()
        {
            Name = "API"
        };

        /// <summary>
        /// The response to be returned by the service for partial failures.
        /// </summary>
        private readonly HelloResponse TEST_RESPONSE_PARTIAL_FAILURES = new HelloResponse()
        {
            Name = "API",
            PartialFailure = "TEST_PARTIAL_FAILURE_TEXT"
        };

        /// <summary>
        /// The exception to be thrown by the service.
        /// </summary>
        private RpcException TEST_EXCEPTION;

        /// <summary>
        /// The error message to be used when creating the exception.
        /// </summary>
        private const string TEST_ERROR_MESSAGE = "TEST_ERROR_MESSAGE";

        /// <summary>
        /// The error trigger to be used when creating the exception.
        /// </summary>
        private const string TEST_ERROR_TRIGGER = "TEST_ERROR_TRIGGER";

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingInterceptorTests"/> class.
        /// </summary>
        public LoggingInterceptorTests() : base(new GoogleAdsConfig())
        {
            // Initialize request metadata.
            TEST_REQUEST_METADATA = new Metadata();
            TEST_REQUEST_METADATA.Add(GoogleAdsConfig.DEVELOPER_TOKEN_KEYNAME,
                TEST_DEVELOPER_TOKEN);

            // Initialize response metadata.
            TEST_RESPONSE_METADATA = new Metadata();
            TEST_RESPONSE_METADATA.Add(GoogleAdsException.REQUEST_ID_KEY, TEST_REQUEST_ID);

            // Create the test exception.
            TEST_EXCEPTION = TestUtils.CreateRpcException(TEST_ERROR_MESSAGE, TEST_ERROR_TRIGGER,
                TEST_REQUEST_ID);
            TraceUtilities.Configure(TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE,
                new StringWriter(), SourceLevels.All);
        }

        /// <summary>
        /// Tests whether an asynchronous unary call with successful response
        /// is intercepted correctly and logged.
        /// </summary>
        [Test]
        public void TestAsyncUnaryCallWithResponse()
        {
            ClientInterceptorContext<HelloRequest, HelloResponse> context =
                GetClientInterceptorContext();

            this.OnLogEventAvailable += delegate (object sender, LogEntry logEntry)
            {
                Assert.AreEqual(this.Config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                Assert.AreSame(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                Assert.AreSame(TEST_RESPONSE_METADATA, logEntry.ResponseHeaders);
                Assert.AreSame(TEST_REQUEST, logEntry.Request);
                Assert.AreSame(TEST_RESPONSE, logEntry.Response);
                Assert.AreEqual(TEST_CUSTOMER_ID, logEntry.CustomerId);
                Assert.False(logEntry.IsFailure);
            };
            this.AsyncUnaryCall(TEST_REQUEST, context, ContinuationWithResults);
            this.OnLogEventAvailable = null;
        }

        /// <summary>
        /// Tests whether an asynchronous unary call with failed response
        /// is intercepted correctly and exceptions are logged.
        /// </summary>
        [Test]
        public void TestAsyncUnaryCallWithException()
        {
            ClientInterceptorContext<HelloRequest, HelloResponse> context =
                GetClientInterceptorContext();
            this.OnLogEventAvailable += delegate (object sender, LogEntry logEntry)
            {
                Assert.AreEqual(this.Config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                Assert.AreSame(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                Assert.AreSame(TEST_RESPONSE_METADATA, logEntry.ResponseHeaders);
                Assert.AreSame(TEST_REQUEST, logEntry.Request);

                // Response is null if there's an exception.
                Assert.IsNull(logEntry.Response);

                Assert.AreEqual(TEST_CUSTOMER_ID, logEntry.CustomerId);
                Assert.True(logEntry.IsFailure);
                GoogleAdsException googleAdsException = logEntry.Exception as GoogleAdsException;
                Assert.NotNull(googleAdsException);

                Assert.AreEqual(TEST_REQUEST_ID, googleAdsException.RequestId);

                Assert.NotNull(googleAdsException.Failure);
                Assert.AreEqual(1, googleAdsException.Failure.Errors.Count);
                Assert.NotNull(googleAdsException.Failure.Errors[0].ErrorCode);
                Assert.NotNull(googleAdsException.Failure.Errors[0].ErrorCode.DistinctError);
            };
            this.AsyncUnaryCall(TEST_REQUEST, context, ContinuationWithException);
            this.OnLogEventAvailable = null;
        }

        /// <summary>
        /// Tests whether an asynchronous unary call with partial failure response
        /// is intercepted correctly and partial failures are logged.
        /// </summary>
        [Test]
        public void TestAsyncUnaryCallWithPartialFailure()
        {
            ClientInterceptorContext<HelloRequest, HelloResponse> context =
                GetClientInterceptorContext();

            this.OnLogEventAvailable += delegate (object sender, LogEntry logEntry)
            {
                Assert.AreEqual(this.Config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                Assert.AreSame(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                Assert.AreSame(TEST_RESPONSE_METADATA, logEntry.ResponseHeaders);
                Assert.AreSame(TEST_REQUEST, logEntry.Request);
                Assert.AreSame(TEST_RESPONSE_PARTIAL_FAILURES, logEntry.Response);
                Assert.AreEqual(TEST_CUSTOMER_ID, logEntry.CustomerId);
                Assert.False(logEntry.IsFailure);
                Assert.AreEqual(TEST_PARTIAL_FAILURE_TEXT, logEntry.PartialFailures);
            };
            this.AsyncUnaryCall(TEST_REQUEST, context, ContinuationWithPartialFailures);
            this.OnLogEventAvailable = null;
        }

        /// <summary>
        /// Gets the client interceptor context for testing purposes.
        /// </summary>
        /// <returns>The client interceptor context.</returns>
        private ClientInterceptorContext<HelloRequest, HelloResponse> GetClientInterceptorContext()
        {
            Marshaller<HelloRequest> requestMarshaller = Marshallers.Create(
                (arg) => MessageExtensions.ToByteArray(arg),
                HelloRequest.Parser.ParseFrom);

            Marshaller<HelloResponse> responseMarshaller = Marshallers.Create(
                (arg) => MessageExtensions.ToByteArray(arg),
                HelloResponse.Parser.ParseFrom);

            Method<HelloRequest, HelloResponse> unaryMethod =
                new Method<HelloRequest, HelloResponse>(
                    MethodType.Unary, TEST_SERVICE, TEST_METHOD, requestMarshaller,
                        responseMarshaller);

            ClientInterceptorContext<HelloRequest, HelloResponse> context =
                new ClientInterceptorContext<HelloRequest, HelloResponse>(
                    unaryMethod, TEST_HOST, new CallOptions(TEST_REQUEST_METADATA));
            return context;
        }

        /// <summary>
        /// Creates a continuation with test results.
        /// </summary>
        /// <param name="request">The test request.</param>
        /// <param name="context">The client interceptor context.</param>
        /// <returns>An async unary call that returns test response and metadata upon completion.
        /// </returns>
        private AsyncUnaryCall<HelloResponse> ContinuationWithResults(HelloRequest request,
            ClientInterceptorContext<HelloRequest, HelloResponse> context)
        {
            Task<HelloResponse> responseTask = Task.FromResult(TEST_RESPONSE);
            Task<Metadata> responseHeadersTask = Task.FromResult(TEST_RESPONSE_METADATA);
            return new AsyncUnaryCall<HelloResponse>(responseTask, responseHeadersTask,
                null, null, null);
        }

        /// <summary>
        /// Creates a continuation with test partial failure results.
        /// </summary>
        /// <param name="request">The test request.</param>
        /// <param name="context">The client interceptor context.</param>
        /// <returns>An async unary call that returns test response and metadata upon completion.
        /// </returns>
        private AsyncUnaryCall<HelloResponse> ContinuationWithPartialFailures(HelloRequest request,
            ClientInterceptorContext<HelloRequest, HelloResponse> context)
        {
            Task<HelloResponse> responseTask = Task.FromResult(TEST_RESPONSE_PARTIAL_FAILURES);
            Task<Metadata> responseHeadersTask = Task.FromResult(TEST_RESPONSE_METADATA);
            return new AsyncUnaryCall<HelloResponse>(responseTask, responseHeadersTask,
                null, null, null);
        }

        /// <summary>
        /// Creates a continuation with test exception.
        /// </summary>
        /// <param name="request">The test request.</param>
        /// <param name="context">The client interceptor context.</param>
        /// <returns>An async unary call that throws a test exception and returns test metadata
        /// upon completion.
        /// </returns>
        private AsyncUnaryCall<HelloResponse> ContinuationWithException(HelloRequest request,
            ClientInterceptorContext<HelloRequest, HelloResponse> context)
        {
            Task<Metadata> responseHeadersTask = Task.FromResult(TEST_RESPONSE_METADATA);
            Task<HelloResponse> responseTask = FromException<HelloResponse>(TEST_EXCEPTION);
            return new AsyncUnaryCall<HelloResponse>(responseTask, responseHeadersTask,
                null, null, null);
        }

        /// <summary>
        /// Utility method that creates a task from an exception.
        /// </summary>
        /// <typeparam name="T">The task return type.</typeparam>
        /// <param name="ex">The exception to throw.</param>
        /// <returns>The task.</returns>
        /// <remarks>Task.FromException is not available in .NET 452.</remarks>
        private static Task<T> FromException<T>(Exception ex)
        {
            Task<T> responseTask = new Task<T>(() =>
            {
                throw ex;
            });
            responseTask.RunSynchronously();
            return responseTask;
        }
    }
}

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

using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Logging;
using Google.Ads.GoogleAds.Tests.V8;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V8.Errors;
using Grpc.Core;
using Grpc.Core.Interceptors;
using NUnit.Framework;
using System;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Tests.Logging.V8
{
    /// <summary>
    /// Tests for <see cref="LoggingHandler"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class LoggingHandlerTests
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
        /// Response metadata for testing.
        /// </summary>
        private readonly Metadata TEST_TRAILERS_METADATA;

        /// <summary>
        /// The host name.
        /// </summary>
        private const string TEST_HOST = "TEST_HOST";

        /// <summary>
        /// The service name.
        /// </summary>
        private const string TEST_SERVICE = "TEST_SERVICE";

        /// <summary>
        /// The method name.
        /// </summary>
        private const string TEST_METHOD = "TEST_METHOD";

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
        /// Initializes a new instance of the <see cref="LoggingHandlerTests"/> class.
        /// </summary>
        public LoggingHandlerTests()
        {
            // Initialize request metadata.
            TEST_REQUEST_METADATA = new Metadata();
            TEST_REQUEST_METADATA.Add(MetadataKeyNames.DeveloperToken, TEST_DEVELOPER_TOKEN);

            // Initialize response metadata.
            TEST_RESPONSE_METADATA = new Metadata();
            TEST_RESPONSE_METADATA.Add(MetadataKeyNames.RequestId, TEST_REQUEST_ID);

            // Initialize trailers metadata.
            TEST_TRAILERS_METADATA = new Metadata();

            // Create the test exception.
            TEST_EXCEPTION = TestUtils.CreateRpcException(TEST_ERROR_MESSAGE, TEST_ERROR_TRIGGER,
                TEST_REQUEST_ID);
            TraceUtilities.Configure(TraceUtilities.SUMMARY_REQUEST_LOGS_SOURCE,
                new StringWriter(), SourceLevels.All);
            TraceUtilities.Configure(TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE,
                new StringWriter(), SourceLevels.All);
        }

        /// <summary>
        /// Tests whether an asynchronous unary call with successful response is logged correctly.
        /// </summary>
        [Test]
        public void TestAsyncUnaryCallWithResponse()
        {
            GoogleAdsConfig config = new GoogleAdsConfig();
            LoggingHandler handler = new LoggingHandler(config);
            handler.WriteSummaryLogs = delegate (LogEntry logEntry)
            {
                Assert.AreEqual(config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                Assert.AreSame(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                CompareMetadata(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                Assert.False(logEntry.IsFailure);
            };
            handler.WriteDetailedLogs = delegate (LogEntry logEntry)
            {
                Assert.AreEqual(config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                Assert.AreSame(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                CompareMetadata(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                CompareMetadata(TEST_RESPONSE_METADATA, logEntry.ResponseHeaders);
                Assert.AreSame(TEST_REQUEST, logEntry.Request);
                Assert.AreSame(TEST_RESPONSE, logEntry.Response);
                Assert.AreEqual(TEST_CUSTOMER_ID, logEntry.CustomerId);
                Assert.False(logEntry.IsFailure);
            };
            ClientInterceptorContext<HelloRequest, HelloResponse> context =
                GetClientInterceptorContext();
            AsyncUnaryCall<HelloResponse> call = ContinuationWithResults(TEST_REQUEST, context);
            handler.HandleAsyncUnaryLogging(TEST_REQUEST, context, call.ResponseAsync, call);
        }

        /// <summary>
        /// Tests whether an asynchronous unary call with failed response is logged correctly.
        /// </summary>
        [Test]
        public void TestAsyncUnaryCallWithException()
        {
            GoogleAdsConfig config = new GoogleAdsConfig();
            LoggingHandler handler = new LoggingHandler(config);
            handler.WriteSummaryLogs = delegate (LogEntry logEntry)
            {
                Assert.AreEqual(config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                CompareMetadata(TEST_REQUEST_METADATA, logEntry.RequestHeaders);

                Assert.True(logEntry.IsFailure);
                GoogleAdsException googleAdsException = logEntry.Exception as GoogleAdsException;
                Assert.NotNull(googleAdsException);

                Assert.AreEqual(TEST_REQUEST_ID, googleAdsException.RequestId);

                Assert.NotNull(googleAdsException.Failure);
                Assert.AreEqual(1, googleAdsException.Failure.Errors.Count);
                Assert.NotNull(googleAdsException.Failure.Errors[0].ErrorCode);
                Assert.NotNull(googleAdsException.Failure.Errors[0].ErrorCode.DistinctError);
            };
            handler.WriteDetailedLogs = delegate (LogEntry logEntry)
            {
                Assert.AreEqual(config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                CompareMetadata(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                CompareMetadata(TEST_RESPONSE_METADATA, logEntry.ResponseHeaders);
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

            ClientInterceptorContext<HelloRequest, HelloResponse> context =
                GetClientInterceptorContext();
            AsyncUnaryCall<HelloResponse> call = ContinuationWithException(TEST_REQUEST, context);
            handler.HandleAsyncUnaryLogging(TEST_REQUEST, context, call.ResponseAsync, call);
        }

        /// <summary>
        /// Tests whether an asynchronous unary call with partial failure response is logged
        /// correctly.
        /// </summary>
        [Test]
        public void TestAsyncUnaryCallWithPartialFailure()
        {
            GoogleAdsConfig config = new GoogleAdsConfig();
            LoggingHandler handler = new LoggingHandler(config);
            handler.WriteSummaryLogs = delegate (LogEntry logEntry)
            {
                Assert.AreEqual(config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                CompareMetadata(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                Assert.False(logEntry.IsFailure);
            };
            handler.WriteDetailedLogs = delegate (LogEntry logEntry)
            {
                Assert.AreEqual(config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                CompareMetadata(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                CompareMetadata(TEST_RESPONSE_METADATA, logEntry.ResponseHeaders);
                Assert.AreSame(TEST_REQUEST, logEntry.Request);
                Assert.AreSame(TEST_RESPONSE_PARTIAL_FAILURES, logEntry.Response);
                Assert.AreEqual(TEST_CUSTOMER_ID, logEntry.CustomerId);
                Assert.False(logEntry.IsFailure);
                Assert.AreEqual(TEST_PARTIAL_FAILURE_TEXT, logEntry.PartialFailures);
            };
            ClientInterceptorContext<HelloRequest, HelloResponse> context =
                GetClientInterceptorContext();
            AsyncUnaryCall<HelloResponse> call =
                ContinuationWithPartialFailures(TEST_REQUEST, context);
            handler.HandleAsyncUnaryLogging(TEST_REQUEST, context, call.ResponseAsync, call);
        }

        /// <summary>
        /// Tests if logs are generated correctly for a streaming call that returns results.
        /// </summary>
        [Test]
        public void TestServerStreamingWithResult()
        {
            GoogleAdsConfig config = new GoogleAdsConfig();
            LoggingHandler handler = new LoggingHandler(config);
            handler.WriteSummaryLogs = delegate (LogEntry logEntry)
            {
                Assert.AreEqual(config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                CompareMetadata(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                Assert.False(logEntry.IsFailure);
            };
            handler.WriteDetailedLogs = delegate (LogEntry logEntry)
            {
                Assert.AreEqual(config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                CompareMetadata(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                CompareMetadata(TEST_RESPONSE_METADATA, logEntry.ResponseHeaders);
                Assert.AreSame(TEST_REQUEST, logEntry.Request);
                Assert.AreSame(TEST_RESPONSE, logEntry.Response);
                Assert.AreEqual(TEST_CUSTOMER_ID, logEntry.CustomerId);
                Assert.False(logEntry.IsFailure);
            };

            ClientInterceptorContext<HelloRequest, HelloResponse> context =
                GetClientInterceptorContext();
            AsyncServerStreamingCall<HelloResponse> call =
                StreamingContinuationWithResult<HelloResponse>();
            handler.HandleAsyncServerStreamingLogging(TEST_REQUEST,
                TEST_RESPONSE, context, null, call);
        }

        /// <summary>
        /// Tests if logs are generated correctly for a streaming call that throws exceptions.
        /// </summary>
        [Test]
        public void TestServerStreamingWithException()
        {
            GoogleAdsConfig config = new GoogleAdsConfig();
            LoggingHandler handler = new LoggingHandler(config);
            handler.WriteSummaryLogs = delegate (LogEntry logEntry)
            {
                Assert.AreEqual(config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                CompareMetadata(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                Assert.True(logEntry.IsFailure);
                GoogleAdsException googleAdsException = logEntry.Exception as GoogleAdsException;
                Assert.NotNull(googleAdsException);

                Assert.AreEqual(TEST_REQUEST_ID, googleAdsException.RequestId);

                Assert.NotNull(googleAdsException.Failure);
                Assert.AreEqual(1, googleAdsException.Failure.Errors.Count);
                Assert.NotNull(googleAdsException.Failure.Errors[0].ErrorCode);
                Assert.NotNull(googleAdsException.Failure.Errors[0].ErrorCode.DistinctError);
            };
            handler.WriteDetailedLogs = delegate (LogEntry logEntry)
            {
                Assert.AreEqual(config.ServerUrl, logEntry.Host);
                Assert.AreEqual(TEST_METHOD_IN_LOGS, logEntry.Method);
                CompareMetadata(TEST_REQUEST_METADATA, logEntry.RequestHeaders);
                CompareMetadata(TEST_RESPONSE_METADATA, logEntry.ResponseHeaders);
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

            ClientInterceptorContext<HelloRequest, HelloResponse> context =
                GetClientInterceptorContext();
            AsyncServerStreamingCall<HelloResponse> call =
                StreamingContinuationWithException<HelloResponse>();
            handler.HandleAsyncServerStreamingLogging(TEST_REQUEST,
                null, context, new AggregateException(TEST_EXCEPTION),
                call);
        }

        /// <summary>
        /// Creates a server streaming call continuation with test results.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <returns>The streaming continuation.</returns>
        private AsyncServerStreamingCall<HelloResponse> StreamingContinuationWithResult<TResponse>()
            where TResponse : class
        {
            Task<HelloResponse> responseTask = Task.FromResult(TEST_RESPONSE);
            Task<Metadata> responseHeadersTask = Task.FromResult(TEST_RESPONSE_METADATA);
            Func<Metadata> trailersTask = () => TEST_TRAILERS_METADATA;
            TestStreamReader<HelloResponse> responseStream =
                new TestStreamReader<HelloResponse>(new[] { TEST_RESPONSE }, null);

            AsyncServerStreamingCall<HelloResponse> call =
                new AsyncServerStreamingCall<HelloResponse>(responseStream, responseHeadersTask,
                null, trailersTask, null);
            return call;
        }

        /// <summary>
        /// Creates a server streaming call continuation with test exception.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <returns>The streaming continuation.</returns>
        private AsyncServerStreamingCall<HelloResponse> StreamingContinuationWithException<TResponse>()
            where TResponse : class
        {
            Task<Metadata> responseHeadersTask = Task.FromResult(TEST_RESPONSE_METADATA);
            Task<HelloResponse> responseTask =
                TestStreamReader<object>.FromException<HelloResponse>(TEST_EXCEPTION);
            Func<Metadata> trailersTask = () => TEST_TRAILERS_METADATA;

            TestStreamReader<HelloResponse> responseStream =
                new TestStreamReader<HelloResponse>(new HelloResponse[] { }, TEST_EXCEPTION);

            AsyncServerStreamingCall<HelloResponse> call =
                new AsyncServerStreamingCall<HelloResponse>(responseStream, responseHeadersTask,
                null, trailersTask, null);
            return call;
        }

        /// <summary>
        /// Compares two metadata objects.
        /// </summary>
        /// <param name="first">The first metadata.</param>
        /// <param name="second">The second metadata.</param>
        private void CompareMetadata(Metadata first, Metadata second)
        {
            Assert.AreEqual(first.Count, second.Count);
            foreach (Metadata.Entry entry in first)
            {
                Assert.That(second.Contains(entry));
            }
        }

        /// <summary>
        /// Gets the client interceptor context for testing purposes.
        /// </summary>
        /// <returns>The client interceptor context.</returns>
        private ClientInterceptorContext<HelloRequest, HelloResponse> GetClientInterceptorContext()
        {
            Marshaller<HelloRequest> requestMarshaller = Marshallers.Create(
                (arg) => Google.Protobuf.MessageExtensions.ToByteArray(arg),
                HelloRequest.Parser.ParseFrom);

            Marshaller<HelloResponse> responseMarshaller = Marshallers.Create(
                (arg) => Google.Protobuf.MessageExtensions.ToByteArray(arg),
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
        /// Creates an async unary call continuation with test results.
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
            Func<Metadata> trailersTask = () => TEST_TRAILERS_METADATA;
            return new AsyncUnaryCall<HelloResponse>(responseTask, responseHeadersTask,
                null, trailersTask, null);
        }

        /// <summary>
        /// Creates an async unary call continuation with test partial failure results.
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
            Func<Metadata> trailersTask = () => TEST_TRAILERS_METADATA;
            return new AsyncUnaryCall<HelloResponse>(responseTask, responseHeadersTask,
                null, trailersTask, null);
        }

        /// <summary>
        /// Creates an async unary call continuation with test exception.
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
            Task<HelloResponse> responseTask =
                TestStreamReader<object>.FromException<HelloResponse>(TEST_EXCEPTION);
            Func<Metadata> trailersTask = () => TEST_TRAILERS_METADATA;
            return new AsyncUnaryCall<HelloResponse>(responseTask, responseHeadersTask,
                null, trailersTask, null);
        }
    }
}

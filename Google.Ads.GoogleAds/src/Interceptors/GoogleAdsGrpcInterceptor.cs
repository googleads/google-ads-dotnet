// Copyright 2020 Google LLC
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

using Google.Ads.Gax.Interceptors;
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Logging;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Interceptors
{
    /// <summary>
    /// Interceptor for logging requests and responses.
    /// </summary>
    internal class GoogleAdsGrpcInterceptor : Interceptor
    {
        /// <summary>
        /// The logging handler.
        /// </summary>
        private LoggingHandler loggingHandler;

        /// <summary>
        /// The configuration.
        /// </summary>
        private GoogleAdsConfig config;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsGrpcInterceptor"/> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        internal GoogleAdsGrpcInterceptor(GoogleAdsConfig config) : base()
        {
            this.config = config;
            this.loggingHandler = new LoggingHandler(config);
        }

        /// <summary>
        /// Intercepts an asynchronous invocation of a simple remote call.
        /// </summary>
        /// <param name="request">The request message of the invocation.</param>
        /// <param name="context">The <see cref="ClientInterceptorContext{TRequest, TResponse}" />
        /// associated with the current invocation.</param>
        /// <param name="continuationCallback">The callback that continues the invocation process.
        /// This can be invoked zero or more times by the interceptor.
        /// The interceptor can invoke the continuation passing the given
        /// request value and context arguments, or substitute them as it sees fit.</param>
        /// <returns>
        /// An instance of <see cref="AsyncUnaryCall{TResponse}" />
        /// representing an asynchronous unary invocation.
        /// The interceptor can simply return the return value of the
        /// <paramref name="continuationCallback"/> delegate passed to it intact, or construct its
        /// own substitute.
        /// </returns>
        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request, ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuationCallback)
        {
            AsyncUnaryCall<TResponse> call = continuationCallback(request, context);

            Task t = call.ResponseAsync.ContinueWith(
                delegate (Task<TResponse> oldTask)
                {
                    loggingHandler.HandleAsyncUnaryLogging(request, context, oldTask, call);
                });
            t.Wait();

            return UnaryRpcInterceptor.Intercept(call);
        }

        /// <summary>
        /// Intercepts an asynchronous invocation of a streaming remote call.
        /// </summary>
        /// <typeparam name="TRequest"></typeparam>
        /// <typeparam name="TResponse"></typeparam>
        /// <param name="request">The request message of the invocation.</param>
        /// <param name="context">The <see cref="T:Grpc.Core.Interceptors.ClientInterceptorContext`2" />
        /// associated with the current invocation.</param>
        /// <param name="continuation">The callback that continues the invocation process.
        /// This can be invoked zero or more times by the interceptor.
        /// The interceptor can invoke the continuation passing the given
        /// request value and context arguments, or substitute them as it sees fit.</param>
        /// <returns>
        /// An instance of <see cref="T:Grpc.Core.AsyncServerStreamingCall`1" />
        /// representing an asynchronous server-streaming invocation.
        /// The interceptor can simply return the return value of the
        /// continuation delegate passed to it intact, or construct its
        /// own substitute as it sees fit.
        /// </returns>
        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(
            TRequest request, ClientInterceptorContext<TRequest, TResponse> context,
            AsyncServerStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            AsyncServerStreamingCall<TResponse> call = continuation(request, context);
            StreamingRpcInterceptor<TResponse> responseStream = null;

            responseStream = new StreamingRpcInterceptor<TResponse>(call.ResponseStream,
                delegate (TResponse response, AggregateException rpcException)
                {
                    loggingHandler.HandleAsyncServerStreamingLogging(request, response,
                        context, rpcException, call);
                });

            return new AsyncServerStreamingCall<TResponse>(
                responseStream,
                call.ResponseHeadersAsync,
                call.GetStatus,
                call.GetTrailers,
                call.Dispose
            );
        }
    }
}

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

using Google.Ads.Gax.Config;
using Grpc.Core;

namespace Google.Ads.Gax.Profiling
{
    /// <summary>
    /// A call invoker that profiles the call timing.
    /// </summary>
    /// <seealso cref="Grpc.Core.CallInvoker" />
    internal class ProfilingCallInvoker : CallInvoker
    {
        /// <summary>
        /// The invoker that this instance wraps.
        /// </summary>
        private CallInvoker invoker;

        /// <summary>
        /// The configuration.
        /// </summary>
        private AdsConfig config;

        /// <summary>
        /// Initializes a new instance of the <see cref="ProfilingCallInvoker"/> class.
        /// </summary>
        /// <param name="invoker">The invoker.</param>
        /// <param name="config">The library configuration.</param>
        internal ProfilingCallInvoker(CallInvoker invoker, AdsConfig config)
        {
            this.invoker = invoker;
            this.config = config;
        }

        /// <summary>
        /// Invokes a client streaming call asynchronously.
        /// In client streaming scenario, client sends a stream of requests and server responds
        /// with a single response.
        /// </summary>
        /// <typeparam name="TRequest">Request message type for this call.</typeparam>
        /// <typeparam name="TResponse">Request message type for this call.</typeparam>
        /// <param name="method">The method details such as service and method names, marshallers
        /// for request and response, etc.</param>
        /// <param name="host">The host to which the call is made.</param>
        /// <param name="options">The call options.</param>
        /// <returns>The client streaming call instance.</returns>
        /// <remarks>This method is not profiled and is passthru.</remarks>
        public override AsyncClientStreamingCall<TRequest, TResponse>
            AsyncClientStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method,
                string host, CallOptions options)
        {
            return invoker.AsyncClientStreamingCall(method, host, options);
        }

        /// <summary>
        /// Invokes a duplex streaming call asynchronously.
        /// In duplex streaming scenario, client sends a stream of requests and server responds
        /// with a stream of responses. The response stream is completely independent and both side
        /// can be sending messages at the same time.
        /// </summary>
        /// <typeparam name="TRequest">Request message type for this call.</typeparam>
        /// <typeparam name="TResponse">Request message type for this call.</typeparam>
        /// <param name="method">The method details such as service and method names, marshallers
        /// for request and response, etc.</param>
        /// <param name="host">The host to which the call is made.</param>
        /// <param name="options">The call options.</param>
        /// <returns>The duplex streaming call instance.</returns>
        /// <remarks>This method is not profiled and is passthru.</remarks>
        public override AsyncDuplexStreamingCall<TRequest, TResponse>
            AsyncDuplexStreamingCall<TRequest, TResponse>(Method<TRequest, TResponse> method,
                string host, CallOptions options)
        {
            return invoker.AsyncDuplexStreamingCall(method, host, options);
        }

        /// <summary>
        /// Invokes a server streaming call asynchronously.
        /// In server streaming scenario, client sends on request and server responds with a
        /// stream of responses.
        /// </summary>
        /// <typeparam name="TRequest">Request message type for this call.</typeparam>
        /// <typeparam name="TResponse">Request message type for this call.</typeparam>
        /// <param name="method">The method details such as service and method names, marshallers
        /// for request and response, etc.</param>
        /// <param name="host">The host to which the call is made.</param>
        /// <param name="options">The call options.</param>
        /// <param name="request">The request object.</param>
        /// <returns>The server streaming call instance.</returns>
        /// <remarks>This method is profiled.</remarks>
        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(
            Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            if (config.EnableProfiling)
            {
                ProfiledMethod<TRequest, TResponse> profiledMethod =
                    new ProfiledMethod<TRequest, TResponse>(method, config.EnableProfiling);
                var retval = invoker.AsyncServerStreamingCall(profiledMethod.Method, host,
                    options, request);
                profiledMethod.SetMetadataChecker(retval.GetTrailers);
                profiledMethod.SetStatusChecker(retval.GetStatus);
                return retval;
            }
            return invoker.AsyncServerStreamingCall(method, host, options, request);
        }

        /// <summary>
        /// Invokes a simple remote call asynchronously.
        /// </summary>
        /// <typeparam name="TRequest">Request message type for this call.</typeparam>
        /// <typeparam name="TResponse">Request message type for this call.</typeparam>
        /// <param name="method">The method details such as service and method names, marshallers
        /// for request and response, etc.</param>
        /// <param name="host">The host to which the call is made.</param>
        /// <param name="options">The call options.</param>
        /// <param name="request">The request object.</param>
        /// <returns>The async unary call instance.</returns>
        /// <remarks>This method is profiled.</remarks>
        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            if (config.EnableProfiling)
            {
                ProfiledMethod<TRequest, TResponse> profiledMethod =
                new ProfiledMethod<TRequest, TResponse>(method, config.EnableProfiling);

                var retval = invoker.AsyncUnaryCall(profiledMethod.Method, host, options, request);
                profiledMethod.SetMetadataChecker(delegate ()
                {
                    retval.ResponseHeadersAsync.Wait();
                    return retval.ResponseHeadersAsync.Result;
                });
                profiledMethod.SetStatusChecker(retval.GetStatus);
                return retval;
            }
            return invoker.AsyncUnaryCall(method, host, options, request);
        }

        /// <summary>
        /// Invokes a simple remote call in a blocking fashion.
        /// </summary>
        /// <typeparam name="TRequest">Request message type for this call.</typeparam>
        /// <typeparam name="TResponse">Request message type for this call.</typeparam>
        /// <param name="method">The method details such as service and method names, marshallers
        /// for request and response, etc.</param>
        /// <param name="host">The host to which the call is made.</param>
        /// <param name="options">The call options.</param>
        /// <param name="request">The request object.</param>
        /// <returns>The response.</returns>
        /// <remarks>This method is not profiled and is passthru.</remarks>
        public override TResponse BlockingUnaryCall<TRequest, TResponse>(
            Method<TRequest, TResponse> method, string host, CallOptions options, TRequest request)
        {
            return invoker.BlockingUnaryCall(method, host, options, request);
        }
    }
}

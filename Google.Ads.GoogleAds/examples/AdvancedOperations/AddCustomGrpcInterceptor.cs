// Copyright 2024 Google LLC
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
using CommandLine;
using Google.Api.Gax;
using Google.Ads.Gax.Examples;
using Google.Ads.Gax.Interceptors;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V20.Errors;
using Google.Ads.GoogleAds.V20.Services;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System;

using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Examples.V20
{
    /// <summary>
    /// This code example shows how to add a custom gRPC interceptor.
    /// </summary>
    public class AddCustomGrpcInterceptor : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddCustomGrpcInterceptor"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddCustomGrpcInterceptor codeExample = new AddCustomGrpcInterceptor();
            Console.WriteLine(codeExample.Description);
            GoogleAdsClient client = new GoogleAdsClient();
            // Add a custom interceptor.
            client.AddInterceptor(new CustomInterceptor());
            codeExample.Run(client,
                options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example shows how to add a custom gRPC interceptor.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V20.GoogleAdsService);

            // Create a query that will retrieve all campaigns, just to demonstrate usage of the
            // custom interceptor.
            string query = @"SELECT
                            campaign.id,
                        FROM campaign
                        ORDER BY campaign.id";

            try
            {
                // Issue a streaming search request; we don't need to do anything with the response
                // here, we just want to demonstrate usage of the interceptor.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp){}
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
            try
            {
                // Issue a non-streaming call.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> response =
                    googleAdsService.Search(customerId.ToString(), query);
                foreach (GoogleAdsRow googleAdsRow in response)
                {
                    // The response for Search is lazy, meaning that the actual gRPC call will be
                    // sent only when the response is actually accessed; to demonstrate usage of
                    // the interceptor, then, we need to ensure the call is sent by looping
                    // through the response results.
                    Console.WriteLine("Campaign with ID {0} was found.",
                        googleAdsRow.Campaign.Id, googleAdsRow.Campaign.Name);
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }
    }

    /// <summary>
    /// A custom interceptor for both streaming and non-streaming gRPC calls.
    /// </summary>
    internal class CustomInterceptor : Interceptor
    {

        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request, ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuationCallback)
        {
            AsyncUnaryCall<TResponse> call = continuationCallback(request, context);

            Action<Task<TResponse>> callback = delegate (Task<TResponse> oldTask)
            {
                Console.WriteLine($"Intercepted a non-streaming call to {context.Method.Name}");
            };

            return UnaryRpcInterceptor.Intercept(call, callback);
        }

        public override AsyncServerStreamingCall<TResponse> AsyncServerStreamingCall<TRequest, TResponse>(
            TRequest request, ClientInterceptorContext<TRequest, TResponse> context,
            AsyncServerStreamingCallContinuation<TRequest, TResponse> continuation)
        {
            AsyncServerStreamingCall<TResponse> call = continuation(request, context);
            StreamingRpcInterceptor<TResponse> responseStream = null;

            responseStream = new StreamingRpcInterceptor<TResponse>(call.ResponseStream,
                delegate (TResponse response, AggregateException rpcException)
                {
                    Console.WriteLine($"Intercepted a streaming call to {context.Method.Name}");
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

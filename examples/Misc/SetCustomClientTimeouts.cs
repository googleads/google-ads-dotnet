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
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Services;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Grpc.Core;
using System;
using System.IO;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example illustrates the use of custom client timeouts in the context
    /// of server streaming and unary calls. This is useful in Cloud environments that
    /// enforce an upper bound on the time available to service an HTTP request.
    ///
    /// For more information about the concepts, see this documentation:
    /// https://grpc.io/docs/what-is-grpc/core-concepts/#rpc-life-cycle.
    /// </summary>
    public class SetCustomClientTimeouts : ExampleBase
    {
        /// <summary>
        /// The client timeout millis to use for making API calls.
        /// </summary>
        /// <remarks>5 minutes in milliseconds.</remarks>
        private const int CLIENT_TIMEOUT_MILLIS = 5 * 60 * 1000;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            SetCustomClientTimeouts codeExample = new SetCustomClientTimeouts();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example illustrates the use of custom " +
            "client timeouts in the context of server streaming and unary calls. This is useful " +
            "in Cloud environments that enforce an upper bound on the time available to service " +
            "an HTTP request.For more information about the concepts, see this documentation: " +
            "https://grpc.io/docs/what-is-grpc/core-concepts/#rpc-life-cycle.</p>";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                MakeServerStreamingCall(client, customerId);
                MakeUnaryCall(client, customerId);
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

        /// <summary>
        /// Makes a server streaming call using a custom client timeout.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        // [START set_custom_client_timeouts]
        private void MakeServerStreamingCall(GoogleAdsClient client, long customerId)
        {
            StringWriter writer = new StringWriter();

            // Set a custom timeout.
            CallSettings callSettings = CallSettings.FromExpiration(
                  Expiration.FromTimeout(TimeSpan.FromMilliseconds(CLIENT_TIMEOUT_MILLIS)));
            try
            {
                // Get the GoogleAdsService.
                GoogleAdsServiceClient googleAdsService = client.GetService(
                    Services.V7.GoogleAdsService);

                string query = "SELECT campaign.id FROM campaign";
                SearchGoogleAdsStreamRequest request = new SearchGoogleAdsStreamRequest()
                {
                    CustomerId = customerId.ToString(),
                    Query = query
                };
                // Issue a search request.
                googleAdsService.SearchStream(request,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        // Iterates over all rows in all messages and collects the campaign IDs.
                        foreach (GoogleAdsRow googleAdsRow in resp.Results)
                        {
                            writer.WriteLine(googleAdsRow.Campaign.Id);
                        }
                    },
                    callSettings
                );
                Console.WriteLine("The server streaming call completed before the timeout");
            }
            catch (GoogleAdsException ex)
            {
                if (ex.StatusCode == StatusCode.DeadlineExceeded)
                {
                    Console.WriteLine("The server streaming call did not complete before the " +
                        "timeout.");
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                Console.WriteLine($"All campaign IDs retrieved: {writer}.");
            }
        }

        // [END set_custom_client_timeouts]

        /// <summary>
        /// Makes an unary call using a custom client timeout.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        // [START set_custom_client_timeouts_1]
        private void MakeUnaryCall(GoogleAdsClient client, long customerId)
        {
            StringWriter writer = new StringWriter();

            // Set a custom timeout.
            CallSettings callSettings = CallSettings.FromExpiration(
                  Expiration.FromTimeout(TimeSpan.FromMilliseconds(CLIENT_TIMEOUT_MILLIS)));
            try

            {
                // Get the GoogleAdsService.
                GoogleAdsServiceClient googleAdsService = client.GetService(
                    Services.V7.GoogleAdsService);

                string query = "SELECT campaign.id FROM campaign";
                SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
                {
                    CustomerId = customerId.ToString(),
                    Query = query
                };

                // Issue a search request.
                var googleAdsRows = googleAdsService.Search(request, callSettings);
                foreach (GoogleAdsRow googleAdsRow in googleAdsRows)
                {
                    // Iterates over all rows in all messages and collects the campaign IDs.
                    writer.WriteLine(googleAdsRow.Campaign.Id);
                }
                Console.WriteLine("The search paged call completed before the timeout.");
            }
            catch (GoogleAdsException ex)
            {
                if (ex.StatusCode == StatusCode.DeadlineExceeded)
                {
                    Console.WriteLine("The search paged call did not complete before the timeout.");
                }
                else
                {
                    throw;
                }
            }
            finally
            {
                Console.WriteLine($"All campaign IDs retrieved: {writer}.");
            }
        }

        // [END set_custom_client_timeouts_1]
    }
}

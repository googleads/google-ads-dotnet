// Copyright 2022 Google LLC
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
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V11.Errors;
using Google.Ads.GoogleAds.V11.Services;
using System;
using System.Collections.Generic;
using System.Threading;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    /// The auto-apply feature, which automatically applies recommendations as they become
    /// eligible, is currently supported by the Google Ads UI but not by the Google Ads API. See
    /// https://support.google.com/google-ads/answer/10279006 for more information on
    /// using auto-apply in the Google Ads UI.
    ///
    /// This code example demonstrates how an alternative can be implemented with the features that
    /// are currently supported by the Google Ads API. It periodically retrieves and applies
    /// <code>KEYWORD</code> recommendations with default parameters.
    /// </summary>
    public class DetectAndApplyRecommendations : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="DetectAndApplyRecommendations"/>
        /// example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// The maximum number of recommendations to periodically retrieve and apply. In a real
        /// application, such a limit would typically not be used.
        /// </summary>
        private const int MAX_RESULT_SIZE = 2;

        /// <summary>
        /// The number of times to retrieve and apply recommendations. In a real application, such
        /// a limit would typically not be used.
        /// </summary>
        private const int NUMBER_OF_RUNS = 3;

        /// <summary>
        /// The time to wait between two runs. In a real application, this would typically be set
        /// to minutes or hours instead of seconds.
        /// </summary>
        private const int WAIT_TIME_IN_SECONDS = 5;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            DetectAndApplyRecommendations codeExample = new DetectAndApplyRecommendations();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "The auto-apply feature, which automatically applies recommendations as they become " +
            "eligible, is currently supported by the Google Ads UI but not by the Google Ads " +
            "API. See https://support.google.com/google-ads/answer/10279006 for more " +
            "information on using auto-apply in the Google Ads UI. " +
            "This code example demonstrates how an alternative can be implemented with the " +
            "features that are currently supported by the Google Ads API. It periodically " +
            "retrieves and applies <code>KEYWORD</code> recommendations with default parameters.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the RecommendationServiceClient.
            RecommendationServiceClient recommendationService = client.GetService(
                Services.V11.RecommendationService);

            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V11.GoogleAdsService);

            // Creates a query that retrieves keyword recommendations.
            string query = "SELECT recommendation.resource_name FROM recommendation WHERE " +
                $"recommendation.type = KEYWORD LIMIT {MAX_RESULT_SIZE}";

            try
            {
                // Creates apply operations for all the recommendations found.
                for (int i = 0; i < NUMBER_OF_RUNS; i++)
                {
                    List<ApplyRecommendationOperation> operations =
                        new List<ApplyRecommendationOperation>();
                    // Issue a search request.
                    googleAdsService.SearchStream(customerId.ToString(), query,
                        delegate (SearchGoogleAdsStreamResponse resp)
                        {
                            foreach (GoogleAdsRow googleAdsRow in resp.Results)
                            {
                                operations.Add(new ApplyRecommendationOperation()
                                {
                                    ResourceName = googleAdsRow.Recommendation.ResourceName
                                });
                            }
                        }
                    );

                    // Sends the apply recommendation request and prints information.
                    ApplyRecommendationResponse response =
                        recommendationService.ApplyRecommendation(
                            customerId.ToString(), operations);
                    Console.WriteLine($"Applied {0} recommendation(s):", response.Results.Count);
                    foreach (ApplyRecommendationResult result in response.Results)
                    {
                        Console.WriteLine($"- {result.ResourceName}");
                    }
                    if (i < NUMBER_OF_RUNS - 1)
                    {
                        Console.WriteLine($"Waiting {WAIT_TIME_IN_SECONDS} seconds before " +
                            $"applying recommendations.");
                        Thread.Sleep(WAIT_TIME_IN_SECONDS * 1000);
                    }
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
}
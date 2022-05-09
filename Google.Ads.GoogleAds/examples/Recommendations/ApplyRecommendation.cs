// Copyright 2019 Google LLC
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
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example applies a given recommendation. To retrieve recommendations for text ads,
    /// run GetTextAdRecommendations.cs.
    /// </summary>
    public class ApplyRecommendation : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="ApplyRecommendation"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// ID of the recommendation to apply.
            /// </summary>
            [Option("recommendationId", Required = true, HelpText =
                "ID of the recommendation to apply.")]
            public long RecommendationId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = new Options();
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // ID of the recommendation to apply.
                    options.RecommendationId = long.Parse("INSERT_RECOMMENDATION_ID_HERE");

                    return 0;
                });

            ApplyRecommendation codeExample = new ApplyRecommendation();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.RecommendationId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example applies a given recommendation. To retrieve recommendations for " +
            "text ads, run GetTextAdRecommendations.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="recommendationId">ID of the recommendation to apply.</param>
        // [START apply_recommendation]
        public void Run(GoogleAdsClient client, long customerId, long recommendationId)
        {
            // Get the RecommendationServiceClient.
            RecommendationServiceClient service = client.GetService(
                Services.V10.RecommendationService);

            ApplyRecommendationOperation operation = new ApplyRecommendationOperation()
            {
                ResourceName = ResourceNames.Recommendation(customerId, recommendationId),

                // Each recommendation types has optional parameters to override the recommended
                // values. For example, you can override a recommended ad when a
                // TextAdRecommendation is applied, as shown below.
                // Please read https://developers.google.com/google-ads/api/reference/rpc/latest/ApplyRecommendationOperation
                // for details.
                // TextAd = new TextAdParameters() {
                //   Ad = new Ad() {
                //     Id = long.Parse("INSERT_AD_ID_HERE")
                //   }
                // }
            };

            try
            {
                ApplyRecommendationResponse response = service.ApplyRecommendation(
                    customerId.ToString(), new ApplyRecommendationOperation[] {
                        operation
                    });
                Console.WriteLine($"Applied {0} recommendation(s):", response.Results.Count);
                foreach (ApplyRecommendationResult result in response.Results)
                {
                    Console.WriteLine($"- {result.ResourceName}");
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
        // [END apply_recommendation]
    }
}

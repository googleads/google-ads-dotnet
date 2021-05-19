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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V7.Services.DismissRecommendationRequest.Types;
using static Google.Ads.GoogleAds.V7.Services.DismissRecommendationResponse.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example dismisses a given recommendation. To retrieve recommendations for text
    /// ads, run GetTextAdRecommendations.cs.
    /// </summary>
    public class DismissRecommendation : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="DismissRecommendation"/> example.
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
            /// ID of the recommendation to dismiss.
            /// </summary>
            [Option("recommendationId", Required = true, HelpText =
                "ID of the recommendation to dismiss.")]
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

                    // ID of the recommendation to dismiss.
                    options.RecommendationId = long.Parse("INSERT_RECOMMENDATION_ID_HERE");

                    return 0;
                });

            DismissRecommendation codeExample = new DismissRecommendation();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.RecommendationId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example dismisses a given recommendation. To retrieve recommendations for " +
            "text ads, run GetTextAdRecommendations.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="recommendationId">ID of the recommendation to dismiss.</param>
        public void Run(GoogleAdsClient client, long customerId, long recommendationId)
        {
            // Get the RecommendationServiceClient.
            RecommendationServiceClient service = client.GetService(
                Services.V7.RecommendationService);

            DismissRecommendationOperation operation = new DismissRecommendationOperation()
            {
                ResourceName = ResourceNames.Recommendation(customerId, recommendationId),
            };

            try
            {
                DismissRecommendationResponse response = service.DismissRecommendation(
                    customerId.ToString(), new DismissRecommendationOperation[] {
                        operation
                    });
                foreach (DismissRecommendationResult result in response.Results)
                {
                    Console.WriteLine($"Dismissed recommendation with resource name = " +
                        $"'{result.ResourceName}'.");
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

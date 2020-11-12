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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Services;

using System;
using static Google.Ads.GoogleAds.V6.Services.DismissRecommendationRequest.Types;
using static Google.Ads.GoogleAds.V6.Services.DismissRecommendationResponse.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example dismisses a given recommendation. To retrieve recommendations for text
    /// ads, run GetTextAdRecommendations.cs.
    /// </summary>
    public class DismissRecommendation : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            DismissRecommendation codeExample = new DismissRecommendation();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the recommendation to be dismissed.
            int recommendationId = int.Parse("INSERT_RECOMMENDATION_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, recommendationId);
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
                Services.V6.RecommendationService);

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

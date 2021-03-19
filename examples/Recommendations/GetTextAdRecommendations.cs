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
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;
using Google.Api.Gax;
using System;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example gets all TEXT_AD recommendations.
    /// </summary>
    public class GetTextAdRecommendations : ExampleBase
    {
        /// <summary>
        /// The page size of results.
        /// </summary>
        private const int PAGE_SIZE = 1_000;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetTextAdRecommendations codeExample = new GetTextAdRecommendations();
            Console.WriteLine(codeExample.Description);

            //The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example gets all TEXT_AD recommendations.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        // [START get_text_ad_recommendations]
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsServiceClient .
            GoogleAdsServiceClient service = client.GetService(Services.V6.GoogleAdsService);

            string query =
                @"SELECT
                recommendation.type,
                recommendation.campaign,
                recommendation.text_ad_recommendation
            FROM
                recommendation
            WHERE
                recommendation.type = TEXT_AD";

            // Create a request that will retrieve all recommendations using pages of the
            // specified page size.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                PageSize = PAGE_SIZE,
                Query = query
            };

            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    service.Search(customerId.ToString(), query);

                // Iterates over all rows in all pages and prints the requested field values
                // for the recommendation in each row.
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    Recommendation recommendation = googleAdsRow.Recommendation;
                    // [START_EXCLUDE]
                    Ad recommendedAd = recommendation.TextAdRecommendation.Ad;

                    Console.WriteLine($"Recommendation ({recommendation.ResourceName}) was " +
                        $"found for campaign {recommendation.Campaign}:");
                    if (recommendedAd.ExpandedTextAd != null)
                    {
                        ExpandedTextAdInfo eta = recommendedAd.ExpandedTextAd;
                        Console.WriteLine("\tHeadline 1 = {0}\n\tHeadline 2 = {1}\t" +
                            "Description = {2}",
                            eta.HeadlinePart1, eta.HeadlinePart2, eta.Description);
                    }
                    Console.WriteLine($"\tDisplay URL = {recommendedAd.DisplayUrl}");
                    foreach (string url in recommendedAd.FinalUrls)
                    {
                        Console.WriteLine($"\tFinal URL = {url}");
                    }
                    foreach (string url in recommendedAd.FinalMobileUrls)
                    {
                        Console.WriteLine($"\tFinal Mobile URL = {url}");
                    }
                    // [END_EXCLUDE]
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
        // [END get_text_ad_recommendations]
    }
}

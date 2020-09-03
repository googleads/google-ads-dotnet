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
using Google.Ads.GoogleAds.V5.Errors;
using Google.Ads.GoogleAds.V5.Common;
using Google.Ads.GoogleAds.V5.Services;

using System;
using static Google.Ads.GoogleAds.V5.Enums.KeywordPlanNetworkEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V5
{
    /// <summary>
    /// This code example generates keyword ideas from a list of seed keywords or a seed page URL.
    /// </summary>
    public class GenerateKeywordIdeas : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GenerateKeywordIdeas codeExample = new GenerateKeywordIdeas();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // Location criteria IDs. For example, specify 21167 for New York. For more information
            // on determining this value, see
            // https://developers.google.com/adwords/api/docs/appendix/geotargeting.
            long[] locationIds = new long[] {
                long.Parse("INSERT_LOCATION_ID_1_HERE"),
                long.Parse("INSERT_LOCATION_ID_2_HERE")
            };

            // A language criterion ID. For example, specify 1000 for English. For more information
            // on determining this value, see
            // https://developers.google.com/adwords/api/docs/appendix/codes-formats#languages.
            long languageId = long.Parse("INSERT_LANGUAGE_ID_HERE");

            // List of seed keywords.
            string[] keywordTexts = new string[] {
                "INSERT_KEYWORD_TEXT_1_HERE",
                "INSERT_KEYWORD_TEXT_2_HERE"
            };

            // Optional: Specify a URL string related to your business to generate ideas.
            string pageUrl = null;

            codeExample.Run(new GoogleAdsClient(), customerId, locationIds, languageId,
                keywordTexts, pageUrl);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example generates keyword ideas from a list of seed keywords or a seed " +
            "page URL";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="locationIds">The list of location IDs to restrict the search.</param>
        /// <param name="languageId">The language to restrict the search.</param>
        /// <param name="keywordTexts">The list of seed keywords.</param>
        /// <param name="pageUrl">The seed page URL.</param>
        public void Run(GoogleAdsClient client, long customerId, long[] locationIds,
            long languageId, string[] keywordTexts, string pageUrl)
        {
            KeywordPlanIdeaServiceClient keywordPlanIdeaService =
                client.GetService(Services.V5.KeywordPlanIdeaService);

            // Make sure that keywords and/or page URL were specified. The request must have
            // exactly one of urlSeed, keywordSeed, or keywordAndUrlSeed set.
            if (keywordTexts.Length == 0 && string.IsNullOrEmpty(pageUrl))
            {
                throw new ArgumentException("At least one of keywords or page URL is required, " +
                    "but neither was specified.");
            }

            // Specify the optional arguments of the request as a keywordSeed, UrlSeed,
            // or KeywordAndUrlSeed.
            GenerateKeywordIdeasRequest request = new GenerateKeywordIdeasRequest()
            {
                CustomerId = customerId.ToString(),
            };

            if (keywordTexts.Length == 0)
            {
                // Only page URL was specified, so use a UrlSeed.
                request.UrlSeed = new UrlSeed()
                {
                    Url = pageUrl
                };
            }
            else if (string.IsNullOrEmpty(pageUrl))
            {
                // Only keywords were specified, so use a KeywordSeed.
                request.KeywordSeed = new KeywordSeed();
                request.KeywordSeed.Keywords.AddRange(keywordTexts);
            }
            else
            {
                // Both page URL and keywords were specified, so use a KeywordAndUrlSeed.
                request.KeywordAndUrlSeed = new KeywordAndUrlSeed();
                request.KeywordAndUrlSeed.Url = pageUrl;
                request.KeywordAndUrlSeed.Keywords.AddRange(keywordTexts);
            }


            // Create a list of geo target constants based on the resource name of specified
            // location IDs.
            foreach (long locationId in locationIds)
            {
                request.GeoTargetConstants.Add(ResourceNames.GeoTargetConstant(locationId));
            }

            request.Language = ResourceNames.LanguageConstant(languageId);
            // Set the network. To restrict to only Google Search, change the parameter below to
            // KeywordPlanNetwork.GoogleSearch.
            request.KeywordPlanNetwork = KeywordPlanNetwork.GoogleSearchAndPartners;

            try
            {
                // Generate keyword ideas based on the specified parameters.
                var response =
                    keywordPlanIdeaService.GenerateKeywordIdeas(request);

                // Iterate over the results and print its detail.
                foreach (GenerateKeywordIdeaResult result in response)
                {
                    KeywordPlanHistoricalMetrics metrics = result.KeywordIdeaMetrics;
                    Console.WriteLine($"Keyword idea text '{result.Text}' has " +
                        $"{metrics.AvgMonthlySearches} average monthly searches and competition " +
                        $"is {metrics.Competition}.");
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

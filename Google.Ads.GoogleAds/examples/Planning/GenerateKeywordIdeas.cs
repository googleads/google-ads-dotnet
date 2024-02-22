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
using Google.Ads.GoogleAds.V16.Common;
using Google.Ads.GoogleAds.V16.Errors;
using Google.Ads.GoogleAds.V16.Resources;
using Google.Ads.GoogleAds.V16.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V16.Enums.KeywordPlanNetworkEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V16
{
    /// <summary>
    /// This code example generates keyword ideas from a list of seed keywords or a seed page URL.
    /// </summary>
    public class GenerateKeywordIdeas : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GenerateKeywordIdeas"/> example.
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
            /// Location criteria IDs. For example, specify 21167 for New York. For more
            /// information on determining this value, see
            /// https://developers.google.com/google-ads/api/reference/data/geotargets.
            /// </summary>
            [Option("locationIds", Required = true, HelpText =
                "Location criteria IDs. For example, specify 21167 for New York. For more " +
                "information on determining this value, see " +
                "https://developers.google.com/google-ads/api/reference/data/geotargets.")]
            public IEnumerable<long> LocationIds { get; set; }

            /// <summary>
            /// A language criterion ID. For example, specify 1000 for English. For more information
            /// on determining this value, see
            /// https://developers.google.com/google-ads/api/reference/data/codes-formats#languages.
            /// </summary>
            [Option("languageId", Required = true, HelpText =
                "A language criterion ID. For example, specify 1000 for English. For more " +
                "information on determining this value, see " +
                "https://developers.google.com/google-ads/api/reference/data/codes-formats#languages.")]
            public long LanguageId { get; set; }

            /// <summary>
            /// The list of seed keywords.
            /// </summary>
            [Option("keywordTexts", Required = false, HelpText =
                "The list of seed keywords.", Default = new string[] { })]
            public IEnumerable<string> KeywordTexts { get; set; }

            /// <summary>
            /// Specify a URL string related to your business to generate ideas.
            /// </summary>
            [Option("pageUrl", Required = false, HelpText =
                "Specify a URL string related to your business to generate ideas.")]
            public string PageUrl { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GenerateKeywordIdeas codeExample = new GenerateKeywordIdeas();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.LocationIds.ToArray(), options.LanguageId, options.KeywordTexts.ToArray(),
                options.PageUrl);
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
        /// <param name="locationIds">Location criteria IDs. For example, specify 21167 for
        /// New York. For more information on determining this value, see
        /// https://developers.google.com/google-ads/api/reference/data/geotargets.
        /// </param>
        /// <param name="languageId">A language criterion ID. For example, specify 1000 for
        /// English. For more information on determining this value, see
        /// https://developers.google.com/google-ads/api/reference/data/codes-formats#languages.
        /// </param>
        /// <param name="keywordTexts">The list of seed keywords.</param>
        /// <param name="pageUrl">A URL string related to your business to generate ideas.</param>
        // [START generate_keyword_ideas]
        public void Run(GoogleAdsClient client, long customerId, long[] locationIds,
            long languageId, string[] keywordTexts, string pageUrl)
        {
            KeywordPlanIdeaServiceClient keywordPlanIdeaService =
                client.GetService(Services.V16.KeywordPlanIdeaService);

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
        // [END generate_keyword_ideas]
    }
}

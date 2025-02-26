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
using Google.Ads.GoogleAds.V19.Common;
using Google.Ads.GoogleAds.V19.Resources;
using Google.Ads.GoogleAds.V19.Errors;
using Google.Ads.GoogleAds.V19.Services;
using System;
using System.Threading;
using System.Collections.Generic;
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Extensions.Config;

namespace Google.Ads.GoogleAds.Examples.V19
{
    /// <summary>
    /// This example shows how to retrieve recommendations and apply them in a batch.
    /// Recommendations should be applied shortly after they're retrieved. Depending on the
    /// recommendation type, a recommendation can become obsolete quickly, and obsolete
    /// recommendations throw an error when applied. For more details, see:
    /// https://developers.google.com/google-ads/api/docs/recommendations#take_action
    ///
    /// As of Google Ads API V15, users can subscribe to certain recommendation types to apply
    /// them automatically. For more details, see:
    /// https://developers.google.com/google-ads/api/docs/recommendations#auto-apply
    ///
    /// As of Google Ads API V16, users can proactively generate certain recommendation types
    /// during the campaign construction process. For more details, see:
    /// https://developers.google.com/google-ads/api/docs/recommendations#recommendations-in-campaign-construction
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
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            DetectAndApplyRecommendations codeExample = new DetectAndApplyRecommendations();
            Console.WriteLine(codeExample.Description);
            GoogleAdsConfig config = new GoogleAdsConfig();
            config.LoadFromEnvironmentVariables();
            codeExample.Run(new GoogleAdsClient(config), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example shows how to retrieve recommendations and apply them in a batch.\n" +
            "Recommendations should be applied shortly after they're retrieved. Depending on the " +
            "recommendation type, a recommendation can become obsolete quickly, and obsolete " +
            "recommendations throw an error when applied. For more details, see: " +
            "https://developers.google.com/google-ads/api/docs/recommendations#take_action\n" +
            "As of Google Ads API V15, users can subscribe to certain recommendation types to " +
            "apply them automatically. For more details, see: " +
            "https://developers.google.com/google-ads/api/docs/recommendations#auto-apply\n" +
            "As of Google Ads API V16, users can proactively generate certain recommendation " +
            "types during the campaign construction process. For more details, see: " +
            "https://developers.google.com/google-ads/api/docs/recommendations#recommendations-in-campaign-construction";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // [START detect_keyword_recommendations]
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V19.GoogleAdsService);

            // Creates a query that retrieves keyword recommendations.
            string query = "SELECT recommendation.resource_name, " +
                "recommendation.campaign, recommendation.keyword_recommendation " +
                "FROM recommendation WHERE " +
                $"recommendation.type = KEYWORD";

            List<ApplyRecommendationOperation> operations =
                new List<ApplyRecommendationOperation>();

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        Console.WriteLine($"Found {resp.Results.Count} recommendations.");
                        foreach (GoogleAdsRow googleAdsRow in resp.Results)
                        {
                            Recommendation recommendation = googleAdsRow.Recommendation;
                            Console.WriteLine("Keyword recommendation " +
                                $"{recommendation.ResourceName} was found for campaign " +
                                $"{recommendation.Campaign}.");

                            if (recommendation.KeywordRecommendation != null)
                            {
                                KeywordInfo keyword =
                                    recommendation.KeywordRecommendation.Keyword;
                                Console.WriteLine($"Keyword = {keyword.Text}, type = " +
                                    "{keyword.MatchType}");
                            }

                            operations.Add(
                                BuildApplyRecommendationOperation(recommendation.ResourceName)
                            );
                        }
                    }
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
            // [END detect_keyword_recommendations]
        }

        // [START build_apply_recommendation_operation]
        private ApplyRecommendationOperation BuildApplyRecommendationOperation(
            string recommendationResourceName
        )
        {
            // If you have a recommendation_id instead of the resource_name you can create a
            // resource name from it like this:
            // string recommendationResourceName =
            //    ResourceNames.Recommendation(customerId, recommendationId)

            // Each recommendation type has optional parameters to override the recommended values.
            // This is an example to override a recommended ad when a TextAdRecommendation is
            // applied.
            // For details, please read
            // https://developers.google.com/google-ads/api/reference/rpc/latest/ApplyRecommendationOperation.
            /*
            Ad overridingAd = new Ad()
            {
                Id = "INSERT_AD_ID_AS_LONG_HERE"
            };
            applyRecommendationOperation.TextAd = new TextAdParameters()
            {
                Ad = overridingAd
            };
            */

            ApplyRecommendationOperation applyRecommendationOperation =
            new ApplyRecommendationOperation()
            {
                ResourceName = recommendationResourceName
            };

            return applyRecommendationOperation;
        }
        // [END build_apply_recommendation_operation]

        /// <summary>
        /// Applies a list of recommendations.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="operations">The recommendations to apply.</param>
        // [START apply_recommendation]
        private void ApplyRecommendation(GoogleAdsClient client, long customerId,
            List<ApplyRecommendationOperation> operations)
        {
            // Get the RecommendationServiceClient.
            RecommendationServiceClient recommendationService = client.GetService(
                Services.V19.RecommendationService);

            ApplyRecommendationRequest applyRecommendationRequest = new ApplyRecommendationRequest()
            {
                CustomerId = customerId.ToString(),
            };

            applyRecommendationRequest.Operations.AddRange(operations);

            ApplyRecommendationResponse response =
                recommendationService.ApplyRecommendation(applyRecommendationRequest);
            foreach (ApplyRecommendationResult result in response.Results)
            {
                Console.WriteLine("Applied a recommendation with resource name: " +
                    result.ResourceName);
            }
        }
        // [END apply_recommendation]
    }
}

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
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;

using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V6.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.KeywordPlanForecastIntervalEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.KeywordPlanNetworkEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example creates a keyword plan, which can be reused for retrieving forecast
    /// metrics and historic metrics.
    /// </summary>
    public class AddKeywordPlan : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddKeywordPlan codeExample = new AddKeywordPlan();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a keyword plan, which can be reused for retrieving " +
            "forecast metrics and historic metrics.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        // [START add_keyword_plan]
        public void Run(GoogleAdsClient client, long customerId)
        {
            try
            {
                string keywordPlanResource = CreateKeywordPlan(client, customerId);
                string planCampaignResource = CreateKeywordPlanCampaign(client, customerId,
                    keywordPlanResource);
                string planAdGroupResource = CreateKeywordPlanAdGroup(client, customerId,
                    planCampaignResource);
                CreateKeywordPlanAdGroupKeywords(client, customerId, planAdGroupResource);
                CreateKeywordPlanCampaignNegativeKeywords(client, customerId, planCampaignResource);
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
        /// Creates the keyword plan.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The newly created keyword plan resource.</returns>
        private string CreateKeywordPlan(GoogleAdsClient client, long customerId)
        {
            // Get the KeywordPlanService.
            KeywordPlanServiceClient serviceClient = client.GetService(
                Services.V6.KeywordPlanService);

            // Create a keyword plan for next quarter forecast.
            KeywordPlan keywordPlan = new KeywordPlan()
            {
                Name = "Keyword plan for traffic estimate #" + ExampleUtilities.GetRandomString(),
                ForecastPeriod = new KeywordPlanForecastPeriod()
                {
                    DateInterval = KeywordPlanForecastInterval.NextQuarter
                }
            };

            KeywordPlanOperation operation = new KeywordPlanOperation()
            {
                Create = keywordPlan
            };

            // Add the keyword plan.
            MutateKeywordPlansResponse response = serviceClient.MutateKeywordPlans(
                customerId.ToString(), new KeywordPlanOperation[] { operation });

            // Display the results.
            String planResource = response.Results[0].ResourceName;
            Console.WriteLine($"Created keyword plan: {planResource}.");
            return planResource;
        }

        /// <summary>
        /// Creates the campaign for the keyword plan.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="keywordPlanResource">The keyword plan resource.</param>
        /// <returns>The newly created campaign resource.</returns>
        private string CreateKeywordPlanCampaign(GoogleAdsClient client, long customerId,
            String keywordPlanResource)
        {
            // Get the KeywordPlanCampaignService.
            KeywordPlanCampaignServiceClient serviceClient = client.GetService(
                Services.V6.KeywordPlanCampaignService);

            // Create a keyword plan campaign.
            KeywordPlanCampaign campaign = new KeywordPlanCampaign()
            {
                Name = "Keyword plan campaign #" + ExampleUtilities.GetRandomString(),
                CpcBidMicros = 1_000_000L,
                KeywordPlanNetwork = KeywordPlanNetwork.GoogleSearch,
                KeywordPlan = keywordPlanResource
            };

            // See https://developers.google.com/adwords/api/docs/appendix/geotargeting
            // for the list of geo target IDs.
            campaign.GeoTargets.Add(new KeywordPlanGeoTarget()
            {
                GeoTargetConstant = ResourceNames.GeoTargetConstant(2840) /* USA */
            });

            // See https://developers.google.com/adwords/api/docs/appendix/codes-formats#languages
            // for the list of language criteria IDs.
            campaign.LanguageConstants.Add(ResourceNames.LanguageConstant(1000)); /* English */

            KeywordPlanCampaignOperation operation = new KeywordPlanCampaignOperation()
            {
                Create = campaign
            };

            // Add the campaign.
            MutateKeywordPlanCampaignsResponse response =
                serviceClient.MutateKeywordPlanCampaigns(customerId.ToString(),
                    new KeywordPlanCampaignOperation[] { operation });

            // Display the result.
            String planCampaignResource = response.Results[0].ResourceName;
            Console.WriteLine($"Created campaign for keyword plan: {planCampaignResource}.");
            return planCampaignResource;
        }

        /// <summary>
        /// Creates the ad group for the keyword plan.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="planCampaignResource">The resource name of the campaign under which the
        /// ad group is created.</param>
        /// <returns>The newly created ad group resource.</returns>
        private string CreateKeywordPlanAdGroup(GoogleAdsClient client, long customerId,
            string planCampaignResource)
        {
            // Get the KeywordPlanAdGroupService.
            KeywordPlanAdGroupServiceClient serviceClient = client.GetService(
                Services.V6.KeywordPlanAdGroupService);

            // Create the keyword plan ad group.
            KeywordPlanAdGroup adGroup = new KeywordPlanAdGroup()
            {
                KeywordPlanCampaign = planCampaignResource,
                Name = "Keyword plan ad group #" + ExampleUtilities.GetRandomString(),
                CpcBidMicros = 2_500_000L
            };

            KeywordPlanAdGroupOperation operation = new KeywordPlanAdGroupOperation()
            {
                Create = adGroup
            };

            // Add the ad group.
            MutateKeywordPlanAdGroupsResponse response =
                serviceClient.MutateKeywordPlanAdGroups(
                    customerId.ToString(), new KeywordPlanAdGroupOperation[] { operation });

            // Display the result.
            String planAdGroupResource = response.Results[0].ResourceName;
            Console.WriteLine($"Created ad group for keyword plan: {planAdGroupResource}.");
            return planAdGroupResource;
        }

        /// <summary>
        /// Creates keywords for the keyword plan.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="planAdGroupResource">The resource name of the ad group under which the
        /// keyword is created.</param>
        private static void CreateKeywordPlanAdGroupKeywords(GoogleAdsClient client,
            long customerId, string planAdGroupResource)
        {
            // Get the KeywordPlanAdGroupKeywordService.
            KeywordPlanAdGroupKeywordServiceClient serviceClient = client.GetService(
                Services.V6.KeywordPlanAdGroupKeywordService);

            // Create the adgroup level keywords for keyword plan.
            KeywordPlanAdGroupKeyword kpAdGroupKeyword1 = new KeywordPlanAdGroupKeyword()
            {
                KeywordPlanAdGroup = planAdGroupResource,
                CpcBidMicros = 2_000_000L,
                MatchType = KeywordMatchType.Broad,
                Text = "mars cruise"
            };

            KeywordPlanAdGroupKeyword kpAdGroupKeyword2 = new KeywordPlanAdGroupKeyword()
            {
                KeywordPlanAdGroup = planAdGroupResource,
                CpcBidMicros = 1_500_000L,
                MatchType = KeywordMatchType.Phrase,
                Text = "cheap cruise"
            };

            KeywordPlanAdGroupKeyword kpAdGroupKeyword3 = new KeywordPlanAdGroupKeyword()
            {
                KeywordPlanAdGroup = planAdGroupResource,
                CpcBidMicros = 1_990_000L,
                MatchType = KeywordMatchType.Exact,
                Text = "jupiter cruise"
            };

            KeywordPlanAdGroupKeyword[] kpAdGroupKeywords = new KeywordPlanAdGroupKeyword[]
            {
                kpAdGroupKeyword1,
                kpAdGroupKeyword2,
                kpAdGroupKeyword3
            };

            // Create an operation for each plan keyword.
            List<KeywordPlanAdGroupKeywordOperation> operations =
                new List<KeywordPlanAdGroupKeywordOperation>();

            foreach (KeywordPlanAdGroupKeyword kpAdGroupKeyword in kpAdGroupKeywords)
            {
                operations.Add(new KeywordPlanAdGroupKeywordOperation
                {
                    Create = kpAdGroupKeyword
                });
            }

            // Add the keywords.
            MutateKeywordPlanAdGroupKeywordsResponse response =
                serviceClient.MutateKeywordPlanAdGroupKeywords(customerId.ToString(), operations);

            // Display the results.
            foreach (MutateKeywordPlanAdGroupKeywordResult result in response.Results)
            {
                Console.WriteLine(
                    $"Created ad group keyword for keyword plan: {result.ResourceName}.");
            }
            return;
        }

        /// <summary>
        /// Creates campaign negative keywords for the keyword plan.
        /// </summary>
        /// <param name="client">he Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="planCampaignResource">The resource name of the campaign under which the
        /// negative keyword is created.</param>
        private static void CreateKeywordPlanCampaignNegativeKeywords(GoogleAdsClient client,
            long customerId, string planCampaignResource)
        {
            // Get the KeywordPlanCampaignKeywordService.
            KeywordPlanCampaignKeywordServiceClient service = client.GetService(
                Services.V6.KeywordPlanCampaignKeywordService);

            // Create the campaign negative keyword for the keyword plan.
            KeywordPlanCampaignKeyword kpCampaignNegativeKeyword = new KeywordPlanCampaignKeyword()
            {
                KeywordPlanCampaign = planCampaignResource,
                MatchType = KeywordMatchType.Broad,
                Text = "moon walk",
                Negative = true
            };

            KeywordPlanCampaignKeywordOperation operation = new KeywordPlanCampaignKeywordOperation
            {
                Create = kpCampaignNegativeKeyword
            };

            // Add the campaign negative keyword.
            MutateKeywordPlanCampaignKeywordsResponse response =
                service.MutateKeywordPlanCampaignKeywords(customerId.ToString(),
                    new KeywordPlanCampaignKeywordOperation[] { operation });

            // Display the result.
            MutateKeywordPlanCampaignKeywordResult result = response.Results[0];
            Console.WriteLine("Created campaign negative keyword for keyword plan: " +
                $"{result.ResourceName}.");
            return;
        }
    }
    // [END add_keyword_plan]
}

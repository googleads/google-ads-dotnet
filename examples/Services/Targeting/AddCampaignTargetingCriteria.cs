// Copyright 2018 Google LLC
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
using Google.Ads.GoogleAds.V0.Common;
using Google.Ads.GoogleAds.V0.Resources;
using Google.Ads.GoogleAds.V0.Services;

using System;

using static Google.Ads.GoogleAds.V0.Enums.KeywordMatchTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V0
{
    /// <summary>
    /// This code example illustrates adding campaign targeting criteria.
    /// </summary>
    public class AddCampaignTargetingCriteria : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddCampaignTargetingCriteria codeExample = new AddCampaignTargetingCriteria();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to which targeting criteria are added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example illustrates adding campaign targeting criteria.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which targeting criteria are added.
        /// </param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the CampaignCriterionService.
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V0.CampaignCriterionService);

            // Add a campaign level negative keyword.
            CampaignCriterion campaignCriterion = new CampaignCriterion()
            {
                Campaign = ResourceNames.Campaign(customerId, campaignId),
                Negative = true,
                Keyword = new KeywordInfo()
                {
                    MatchType = KeywordMatchType.Broad,
                    Text = "jupiter cruise"
                }
            };

            // Create the operation.
            CampaignCriterionOperation negativeCriterionOperation =
                new CampaignCriterionOperation()
            {
                Create = campaignCriterion
            };

            try
            {
                // Create the campaign criterion.
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        new CampaignCriterionOperation[] { negativeCriterionOperation });

                // Display the results.
                foreach (MutateCampaignCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"New campaign criterion with resource name = " +
                        $"'{criterionResult.ResourceName}' was added to campaign " +
                        "ID {campaignId}.");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
            }
        }
    }
}

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
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V6.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.SharedSetTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example creates a shared list of negative broad match keywords. It then
    /// attaches them to a campaign.
    /// </summary>
    public class CreateAndAttachSharedKeywordSet : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            CreateAndAttachSharedKeywordSet codeExample =
                new CreateAndAttachSharedKeywordSet();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The ID of the campaign for which shared criterion is updated.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a shared list of negative broad match keywords. It then " +
            "attaches them to a campaign.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">The ID of the campaign for which shared criterion is updated.
        /// </param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            SharedSetServiceClient sharedSetService = client.GetService(
                Services.V6.SharedSetService);
            SharedCriterionServiceClient sharedCriterionService =
                client.GetService(Services.V6.SharedCriterionService);
            CampaignSharedSetServiceClient campaignSharedSetService =
                client.GetService(Services.V6.CampaignSharedSetService);

            try
            {
                // Keywords to create a shared set of.
                string[] keywords = new string[] { "mars cruise", "mars hotels" };

                // Create shared negative keyword set.
                SharedSet sharedSet = new SharedSet()
                {
                    Name = "API Negative keyword list - " + ExampleUtilities.GetRandomString(),
                    Type = SharedSetType.NegativeKeywords,
                };
                SharedSetOperation operation = new SharedSetOperation()
                {
                    Create = sharedSet
                };

                MutateSharedSetsResponse sharedSetResponse = sharedSetService.MutateSharedSets(
                    customerId.ToString(), new SharedSetOperation[] { operation });

                string sharedSetResourceName = sharedSetResponse.Results[0].ResourceName;
                Console.WriteLine($"Created shared set {sharedSetResourceName}.");

                // Create negative keywords in the shared set.
                List<SharedCriterionOperation> criterionOperations =
                    new List<SharedCriterionOperation>();

                foreach (string keyword in keywords)
                {
                    SharedCriterion sharedCriterion = new SharedCriterion()
                    {
                        Keyword = new KeywordInfo()
                        {
                            Text = keyword,
                            MatchType = KeywordMatchType.Broad
                        },
                        SharedSet = sharedSetResourceName
                    };
                    criterionOperations.Add(new SharedCriterionOperation()
                    {
                        Create = sharedCriterion
                    });
                }

                MutateSharedCriteriaResponse criteriaResponse =
                    sharedCriterionService.MutateSharedCriteria(
                        customerId.ToString(), criterionOperations);

                foreach (MutateSharedCriterionResult result in criteriaResponse.Results)
                {
                    Console.WriteLine($"Created shared criterion {result.ResourceName}.");
                }

                // Attach shared set to campaign.
                CampaignSharedSet campaignSet = new CampaignSharedSet()
                {
                    Campaign = ResourceNames.Campaign(customerId, campaignId),
                    SharedSet = sharedSetResourceName
                };

                CampaignSharedSetOperation sharedSetoperation = new CampaignSharedSetOperation()
                {
                    Create = campaignSet
                };
                MutateCampaignSharedSetsResponse response =
                    campaignSharedSetService.MutateCampaignSharedSets(customerId.ToString(),
                        new CampaignSharedSetOperation[] { sharedSetoperation });

                Console.WriteLine("Created campaign shared set {0}.",
                    response.Results[0].ResourceName);
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

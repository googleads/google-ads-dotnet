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
using Google.Ads.GoogleAds.V2.Common;
using Google.Ads.GoogleAds.V2.Errors;
using Google.Ads.GoogleAds.V2.Resources;
using Google.Ads.GoogleAds.V2.Services;
using System;
using System.Collections.Generic;

using static Google.Ads.GoogleAds.V2.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V2.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V2.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V2.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Examples.V2
{
    /// <summary>
    /// This code example adds campaigns.
    /// </summary>
    public class AddCampaigns : ExampleBase
    {
        /// <summary>
        /// Number of campaigns to create.
        /// </summary>
        private const int NUM_CAMPAIGNS_TO_CREATE = 5;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddCampaigns codeExample = new AddCampaigns();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example adds campaigns. To get campaigns, run GetCampaign.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(Services.V2.CampaignService);

            // Create a budget to be used for the campaign.
            string budget = CreateBudget(client, customerId);

            List<CampaignOperation> operations = new List<CampaignOperation>();

            for (int i = 0; i < NUM_CAMPAIGNS_TO_CREATE; i++)
            {
                // Create the campaign.
                Campaign campaign = new Campaign()
                {
                    Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),
                    AdvertisingChannelType = AdvertisingChannelType.Search,

                    // Recommendation: Set the campaign to PAUSED when creating it to prevent
                    // the ads from immediately serving. Set to ENABLED once you've added
                    // targeting and the ads are ready to serve
                    Status = CampaignStatus.Paused,

                    // Set the bidding strategy and budget.
                    ManualCpc = new ManualCpc(),
                    CampaignBudget = budget,

                    // Set the campaign network options.
                    NetworkSettings = new NetworkSettings
                    {
                        TargetGoogleSearch = true,
                        TargetSearchNetwork = true,
                        TargetContentNetwork = false,
                        TargetPartnerSearchNetwork = false
                    },

                    // Optional: Set the start date.
                    StartDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd"),

                    // Optional: Set the end date.
                    EndDate = DateTime.Now.AddYears(1).ToString("yyyyMMdd"),
                };

                // Create the operation.
                operations.Add(new CampaignOperation() { Create = campaign });
            }
            try
            {
                // Add the campaigns.
                MutateCampaignsResponse retVal = campaignService.MutateCampaigns(
                    customerId.ToString(), operations);

                // Display the results.
                if (retVal.Results.Count > 0)
                {
                    foreach (MutateCampaignResult newCampaign in retVal.Results)
                    {
                        Console.WriteLine("Campaign with resource ID = '{0}' was added.",
                            newCampaign.ResourceName);
                    }
                }
                else
                {
                    Console.WriteLine("No campaigns were added.");
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

        /// <summary>
        /// Creates the budget for the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The resource name of the newly created campaign budget.</returns>
        private static string CreateBudget(GoogleAdsClient client, long customerId)
        {
            // Get the BudgetService.
            CampaignBudgetServiceClient budgetService = client.GetService(
                Services.V2.CampaignBudgetService);

            // Create the campaign budget.
            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 500000
            };

            // Create the operation.
            CampaignBudgetOperation budgetOperation = new CampaignBudgetOperation()
            {
                Create = budget
            };

            // Create the campaign budget.
            MutateCampaignBudgetsResponse response = budgetService.MutateCampaignBudgets(
                customerId.ToString(), new CampaignBudgetOperation[] { budgetOperation });
            return response.Results[0].ResourceName;
        }
    }
}

// Copyright 2020 Google LLC
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
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;
using System;
using static Google.Ads.GoogleAds.V7.Enums.BudgetDeliveryMethodEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example illustrates how to graduate a campaign experiment.
    /// </summary>
    public class GraduateCampaignExperiment : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GraduateCampaignExperiment codeExample = new GraduateCampaignExperiment();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign experiment to graduate.
            long campaignExperimentId = long.Parse("INSERT_CAMPAIGN_EXPERIMENT_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignExperimentId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example illustrates how to graduate a campaign experiment.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignExperimentId">ID of the campaign experiment to graduate.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignExperimentId)
        {
            // Get the CampaignExperimentService.
            CampaignExperimentServiceClient campaignExperimentService = client.GetService(
                Services.V7.CampaignExperimentService);

            try
            {
                // Graduating a campaign experiment requires a new budget. Since the budget for
                // the base campaign has explicitly_shared set to false, the budget cannot
                // be shared with the campaign after it is made independent by graduation.
                string budgetResourceName = CreateBudget(client, customerId);

                // Prints out some information about the created campaign budget.
                Console.WriteLine($"Created new budget with resource name '{budgetResourceName}' " +
                    $"for adding to the experiment campaign during graduation.");

                // Graduates the experiment campaign using the campaign budget created above.
                GraduateCampaignExperimentResponse response =
                    campaignExperimentService.GraduateCampaignExperiment(
                        ResourceNames.CampaignExperiment(customerId, campaignExperimentId),
                            budgetResourceName);
                Console.WriteLine($"Campaign with resource name '{response.GraduatedCampaign}' " +
                    $"is now graduated.");
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
        /// Creates the budget for the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The resource name of the newly created campaign budget.</returns>
        private static string CreateBudget(GoogleAdsClient client, long customerId)
        {
            // Get the BudgetService.
            CampaignBudgetServiceClient budgetService = client.GetService(
                Services.V7.CampaignBudgetService);

            // Create the campaign budget.
            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 5000000
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

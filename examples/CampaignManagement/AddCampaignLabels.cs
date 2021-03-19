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
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;

using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example adds a campaign label to a list of campaigns.
    /// </summary>
    public class AddCampaignLabels : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddCampaignLabels codeExample = new AddCampaignLabels();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // IDs of the campaigns where the campaign labels will be added.
            long[] campaignIds = new long[] {
                long.Parse("INSERT_CAMPAIGN_ID_HERE"),
                long.Parse("INSERT_CAMPAIGN_ID_HERE")
            };

            // IDs of the label that is applied to campaign labels.
            long labelId = long.Parse("INSERT_LABEL_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignIds, labelId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a campaign label to a list of campaigns.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignIds">IDs of the campaigns where the campaign labels will be added.
        /// </param>
        /// <param name="labelId">The ID of the label to attach to campaigns.</param>
        // [START add_campaign_labels]
        public void Run(GoogleAdsClient client, long customerId, long[] campaignIds, long labelId)
        {
            // Get the CampaignLabelServiceClient.
            CampaignLabelServiceClient campaignLabelService =
                client.GetService(Services.V6.CampaignLabelService);

            // Gets the resource name of the label to be added across all given campaigns.
            string labelResourceName = ResourceNames.Label(customerId, labelId);

            List<CampaignLabelOperation> operations = new List<CampaignLabelOperation>();
            // Creates a campaign label operation for each campaign.
            foreach (long campaignId in campaignIds)
            {
                // Gets the resource name of the given campaign.
                string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);
                // Creates the campaign label.
                CampaignLabel campaignLabel = new CampaignLabel()
                {
                    Campaign = campaignResourceName,
                    Label = labelResourceName
                };

                operations.Add(new CampaignLabelOperation()
                {
                    Create = campaignLabel
                });
            }

            // Send the operation in a mutate request.
            try
            {
                MutateCampaignLabelsResponse response =
                    campaignLabelService.MutateCampaignLabels(customerId.ToString(), operations);
                Console.WriteLine($"Added {response.Results} campaign labels:");

                foreach (MutateCampaignLabelResult result in response.Results)
                {
                    Console.WriteLine(result.ResourceName);
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
        // [END add_campaign_labels]
    }
}

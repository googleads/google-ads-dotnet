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
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;

using System;
using static Google.Ads.GoogleAds.V3.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V3.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example updates a campaign. To get campaigns, run GetCampaigns.cs.
    /// </summary>
    public class UpdateCampaign : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UpdateCampaign codeExample = new UpdateCampaign();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to be updated.
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
                return "This code example updates a campaign. To get campaigns, run " +
                    "GetCampaign.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to be updated.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(Services.V3.CampaignService);

            // Update campaign by setting its status to paused, and "Search network" to false.
            Campaign campaignToUpdate = new Campaign()
            {
                ResourceName = ResourceNames.Campaign(customerId, campaignId),
                Status = CampaignStatus.Paused,
                NetworkSettings = new NetworkSettings()
                {
                    TargetSearchNetwork = false
                }
            };

            // Create the operation.
            CampaignOperation operation = new CampaignOperation()
            {
                Update = campaignToUpdate,
                UpdateMask = FieldMasks.AllSetFieldsOf(campaignToUpdate)
            };
            try
            {
                // Update the campaign.
                MutateCampaignsResponse response = campaignService.MutateCampaigns(
                    customerId.ToString(), new CampaignOperation[] { operation });

                // Display the results.
                foreach (MutateCampaignResult updatedCampaign in response.Results)
                {
                    Console.WriteLine($"Campaign with resource ID = " +
                        $"'{updatedCampaign.ResourceName}' was updated.");
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

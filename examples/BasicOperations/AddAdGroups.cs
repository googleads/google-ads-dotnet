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
using Google.Ads.GoogleAds.V7.Enums;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;

using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example illustrates how to create ad groups. To create campaigns, run
    /// AddCampaigns.cs.
    /// </summary>
    public class AddAdGroups : ExampleBase
    {
        /// <summary>
        /// Number of ad groups to create.
        /// </summary>
        private const int NUM_ADGROUPS_TO_CREATE = 5;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddAdGroups codeExample = new AddAdGroups();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to which ad groups are added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example illustrates how to create ad groups. To create campaigns, run " +
            "AddCampaigns.cs";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which ad groups are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the AdGroupService.
            AdGroupServiceClient adGroupService = client.GetService(Services.V7.AdGroupService);

            List<AdGroupOperation> operations = new List<AdGroupOperation>();

            for (int i = 0; i < NUM_ADGROUPS_TO_CREATE; i++)
            {
                // Create the ad group.
                AdGroup adGroup = new AdGroup()
                {
                    Name = $"Earth to Mars Cruises #{ExampleUtilities.GetRandomString()}",
                    Status = AdGroupStatusEnum.Types.AdGroupStatus.Enabled,
                    Campaign = ResourceNames.Campaign(customerId, campaignId),

                    // Set the ad group bids.
                    CpcBidMicros = 10000000
                };

                // Create the operation.
                AdGroupOperation operation = new AdGroupOperation()
                {
                    Create = adGroup
                };
                operations.Add(operation);
            }

            try
            {
                // Create the ad groups.
                MutateAdGroupsResponse response = adGroupService.MutateAdGroups(
                    customerId.ToString(), operations);

                // Display the results.
                foreach (MutateAdGroupResult newAdGroup in response.Results)
                {
                    Console.WriteLine("Ad group with resource name '{0}' was created.",
                        newAdGroup.ResourceName);
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

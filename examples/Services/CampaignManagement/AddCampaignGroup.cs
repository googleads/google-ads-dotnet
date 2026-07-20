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
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V0.Resources;
using Google.Ads.GoogleAds.V0.Services;

using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V0
{
    /// <summary>
    /// This code example adds a campaign group and then adds campaigns to the group. To get
    /// campaigns, run GetCampaigns.cs.
    /// </summary>
    public class AddCampaignGroup : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddCampaignGroup codeExample = new AddCampaignGroup();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign to add to the campign group..
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, new long[] { campaignId });
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example adds a campaign group and then adds campaigns to " +
                    "the group. To get campaigns, run GetCampaigns.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignIds">ID of the campaign to add to the campign group.</param>
        public void Run(GoogleAdsClient client, long customerId, long[] campaignIds)
        {
            // Get the AdGroupService.
            AdGroupServiceClient adGroupService = client.GetService(Services.V0.AdGroupService);

            try
            {
                String campaignGroupResourceName = CreateCampaignGroup(client, customerId);
                AddCampaignsToGroup(client, customerId, campaignGroupResourceName,
                    campaignIds);
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
        /// Creates a new CampaignGroup in the specified client account.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>resource name of the newly created campaign group.</returns>
        private static String CreateCampaignGroup(GoogleAdsClient client, long customerId)
        {
            CampaignGroupServiceClient campaignGroupService = client.GetService(
                Services.V0.CampaignGroupService);

            CampaignGroup campaignGroup = new CampaignGroup()
            {
                Name = "Mars campaign group #" + ExampleUtilities.GetRandomString()
            };

            CampaignGroupOperation op = new CampaignGroupOperation()
            {
                Create = campaignGroup
            };

            MutateCampaignGroupsResponse response =
                campaignGroupService.MutateCampaignGroups(
                    customerId.ToString(), new CampaignGroupOperation[] { op });
            String groupResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Added campaign group with resource name: {groupResourceName}");
            return groupResourceName;
        }

        /// <summary>
        ///  Adds campaigns to a CampaignGroup in the specified client account.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignGroupResourceName">The resource name of the campaign
        /// group.</param>
        /// <param name="campaignIds">The IDs of the campaigns to add to the campaign
        /// group.</param>
        private static void AddCampaignsToGroup(GoogleAdsClient client, long customerId,
            String campaignGroupResourceName, long[] campaignIds)
        {
            CampaignServiceClient campaignServiceClient = client.GetService(
                Services.V0.CampaignService);
            List<CampaignOperation> operations = new List<CampaignOperation>();
            foreach (long campaignId in campaignIds)
            {
                Campaign campaign = new Campaign()
                {
                    ResourceName = ResourceNames.Campaign(customerId, campaignId),
                    CampaignGroup = campaignGroupResourceName
                };

                CampaignOperation op = new CampaignOperation()
                {
                    Update = campaign,
                    UpdateMask = FieldMasks.AllSetFieldsOf(campaign)
                };
                operations.Add(op);
            }

            MutateCampaignsResponse response =
                campaignServiceClient.MutateCampaigns(customerId.ToString(), operations);
            Console.WriteLine($"Added {response.Results.Count} campaigns to campaign group " +
                $"with resource name {campaignGroupResourceName}:");
            foreach (MutateCampaignResult campaignResponse in response.Results)
            {
                Console.WriteLine($"\t{campaignResponse.ResourceName}");
            }
        }
    }
}

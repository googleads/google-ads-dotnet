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
using Google.Ads.GoogleAds.V1.Errors;
using Google.Ads.GoogleAds.V1.Common;
using Google.Ads.GoogleAds.V1.Resources;
using Google.Ads.GoogleAds.V1.Services;

using System;
using static Google.Ads.GoogleAds.V1.Enums.InteractionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V1
{
    /// <summary>
    /// This code example demonstrates how to add a campaign-level bid modifier for call
    /// interactions.
    /// </summary>
    public class AddCampaignBidModifier : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddCampaignBidModifier codeExample = new AddCampaignBidModifier();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign where the bid modifier will be added.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            // The value of the bid modifier to add.
            double bidModifier = double.Parse("INSERT_BID_MODIFIER_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId, bidModifier);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example demonstrates how to add a campaign-level bid modifier " +
                    "for call interactions.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign where the bid modifier will be added.
        /// </param>
        /// <param name="bidModifier">The value of the bid modifier to add.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId,
            double bidModifier)
        {
            // Get the CampaignBidModifierService.
            CampaignBidModifierServiceClient campaignBidModifierService =
                client.GetService(Services.V1.CampaignBidModifierService);

            String campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            // Construct a campaign bid modifier.
            CampaignBidModifier campaignBidModifier = new CampaignBidModifier()
            {
                Campaign = campaignResourceName,
                InteractionType = new InteractionTypeInfo()
                {
                    Type = InteractionType.Calls
                },
                BidModifier = bidModifier
            };

            // Construct an operation to create the campaign bid modifier.
            CampaignBidModifierOperation op = new CampaignBidModifierOperation()
            {
                Create = campaignBidModifier
            };

            // Send the operation in a mutate request.
            try
            {
                MutateCampaignBidModifiersResponse response =
                    campaignBidModifierService.MutateCampaignBidModifiers(customerId.ToString(),
                        new CampaignBidModifierOperation[] { op });
                Console.WriteLine("Added {0} campaign bid modifiers:", response.Results.Count);
                foreach (MutateCampaignBidModifierResult result in response.Results)
                {
                    Console.WriteLine($"\t{result.ResourceName}");
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

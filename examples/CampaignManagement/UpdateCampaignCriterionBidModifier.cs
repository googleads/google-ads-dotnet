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
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;
using System;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example updates a campaign criterion with a new bid modifier.
    /// </summary>
    public class UpdateCampaignCriterionBidModifier : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UpdateCampaignCriterionBidModifier codeExample =
                new UpdateCampaignCriterionBidModifier();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the campaign that contains the criterion.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            // ID of the criterion for which bid modifier is updated.
            long criterionId = long.Parse("INSERT_CRITERION_ID_HERE");

            // The new value of the bid modifier to update.
            float bidModifierValue = float.Parse("INSERT_BID_MODIFIER_VALUE_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId, criterionId,
                bidModifierValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example updates a campaign criterion with a new bid modifier.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign that contains the criterion.</param>
        /// <param name="criterionId">ID of the criterion for which bid modifier is updated.</param>
        /// <param name="bidModifierValue">The new value of the bid modifier to update.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId, long criterionId,
            float? bidModifierValue)
        {
            // Get the CampaignCriterionServiceClient .
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V4.CampaignCriterionService);

            string criterionResourceName = ResourceNames.CampaignCriteria(customerId,
                campaignId, criterionId);

            // Construct a campaign bid modifier.
            CampaignCriterion campaignCriterion = new CampaignCriterion()
            {
                ResourceName = criterionResourceName,
                BidModifier = (bidModifierValue != null) ? bidModifierValue.Value : 1.5f,
            };

            // Construct an operation to create the campaign criterion.
            CampaignCriterionOperation op = new CampaignCriterionOperation()
            {
                Update = campaignCriterion,
                UpdateMask = FieldMasks.AllSetFieldsOf(campaignCriterion)
            };

            // Send the operation in a mutate request.
            try
            {
                MutateCampaignCriteriaResponse response =
                    campaignCriterionService.MutateCampaignCriteria(customerId.ToString(),
                        new CampaignCriterionOperation[] { op });
                foreach (MutateCampaignCriterionResult result in response.Results)
                {
                    Console.WriteLine($"Campaign criterion with resource name" +
                        $" '{result.ResourceName}' was modified.");
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

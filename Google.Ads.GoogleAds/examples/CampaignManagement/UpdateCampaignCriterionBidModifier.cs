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

using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V16.Errors;
using Google.Ads.GoogleAds.V16.Resources;
using Google.Ads.GoogleAds.V16.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V16
{
    /// <summary>
    /// This code example updates a campaign criterion with a new bid modifier.
    /// </summary>
    public class UpdateCampaignCriterionBidModifier : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UpdateCampaignCriterionBidModifier"/>
        /// example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// ID of the campaign that contains the criterion.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "ID of the campaign that contains the criterion.")]
            public long CampaignId { get; set; }

            /// <summary>
            /// ID of the criterion for which bid modifier is updated.
            /// </summary>
            [Option("criterionId", Required = true, HelpText =
                "ID of the criterion for which bid modifier is updated.")]
            public long CriterionId { get; set; }

            /// <summary>
            /// The new value of the bid modifier to update.
            /// </summary>
            [Option("bidModifierValue", Required = false, HelpText =
                "The new value of the bid modifier to update.")]
            public float? BidModifierValue { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UpdateCampaignCriterionBidModifier codeExample = new UpdateCampaignCriterionBidModifier();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId,
                options.CriterionId, options.BidModifierValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example updates a campaign criterion with a new bid modifier.";

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
                client.GetService(Services.V16.CampaignCriterionService);

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

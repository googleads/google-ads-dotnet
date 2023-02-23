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

using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V13.Common;
using Google.Ads.GoogleAds.V13.Errors;
using Google.Ads.GoogleAds.V13.Resources;
using Google.Ads.GoogleAds.V13.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V13.Enums.InteractionTypeEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.ResponseContentTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V13
{
    /// <summary>
    /// This code example demonstrates how to add a campaign-level bid modifier for call
    /// interactions.
    /// </summary>
    public class AddCampaignBidModifier : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddCampaignBidModifier"/> example.
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
            /// ID of the campaign where the bid modifier will be added.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "ID of the campaign where the bid modifier will be added.")]
            public long CampaignId { get; set; }

            /// <summary>
            /// The value of the bid modifier to add.
            /// </summary>
            [Option("bidModifierValue", Required = true, HelpText =
                "The value of the bid modifier to add.")]
            public double BidModifierValue { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddCampaignBidModifier codeExample = new AddCampaignBidModifier();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId,
                options.BidModifierValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example demonstrates how to add a campaign-level bid modifier for call " +
            "interactions.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign where the bid modifier will be added.
        /// </param>
        /// <param name="bidModifierValue">The value of the bid modifier to add.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId,
            double bidModifierValue)
        {
            // Get the CampaignBidModifierService.
            CampaignBidModifierServiceClient campaignBidModifierService =
                client.GetService(Services.V13.CampaignBidModifierService);

            String campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            // Construct a campaign bid modifier.
            CampaignBidModifier campaignBidModifier = new CampaignBidModifier()
            {
                Campaign = campaignResourceName,
                InteractionType = new InteractionTypeInfo()
                {
                    Type = InteractionType.Calls
                },
                BidModifier = bidModifierValue
            };
            // [START mutable_resource]
            // Construct an operation to create the campaign bid modifier.
            CampaignBidModifierOperation op = new CampaignBidModifierOperation()
            {
                Create = campaignBidModifier
            };

            // Construct a request, and set the ResponseContentType field to
            // ResponseContentType.MutableResource, so that the response contains
            // the mutated object and not just its resource name.
            MutateCampaignBidModifiersRequest request = new MutateCampaignBidModifiersRequest()
            {
                CustomerId = customerId.ToString(),
                ResponseContentType = ResponseContentType.MutableResource,
                Operations = { op }
            };

            // Send the operation in a mutate request.
            try
            {
                MutateCampaignBidModifiersResponse response =
                    campaignBidModifierService.MutateCampaignBidModifiers(request);
                Console.WriteLine("Added {0} campaign bid modifiers:", response.Results.Count);

                // The resource returned in the response can be accessed directly in the
                // results list. Its fields can be read directly, and it can also be mutated
                // further and used in subsequent requests, without needing to make
                // additional Get or Search requests.
                foreach (MutateCampaignBidModifierResult result in response.Results)
                {
                    Console.WriteLine($"\tCreated campaign bid modifier with " +
                        $"resource name '{result.ResourceName}', " +
                        $"criterion ID '{result.CampaignBidModifier.CriterionId}', " +
                        $"and bid modifier value {result.CampaignBidModifier.BidModifier}, " +
                        $"under the campaign with resource_name " +
                        $"'{result.CampaignBidModifier.Campaign}'");
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
            // [END mutable_resource]
        }
    }
}

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
using Google.Ads.GoogleAds.V12.Common;
using Google.Ads.GoogleAds.V12.Errors;
using Google.Ads.GoogleAds.V12.Resources;
using Google.Ads.GoogleAds.V12.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V12.Enums.DeviceEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V12
{
    /// <summary>
    /// This code example demonstrates how to add an ad group bid modifier for mobile devices.
    /// To get ad group bid modifiers, see GetAdGroupBidModifiers.cs.
    /// </summary>
    public class AddAdGroupBidModifier : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddAdGroupBidModifier"/> example.
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
            /// ID of the ad group where the bid modifier will be added.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "ID of the ad group where the bid modifier will be added.")]
            public long AdGroupId { get; set; }

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

            AddAdGroupBidModifier codeExample = new AddAdGroupBidModifier();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId,
                options.BidModifierValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example demonstrates how to add an ad group bid modifier for mobile " +
            "devices. To get ad group bid modifiers, see GetAdGroupBidModifiers.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group where the bid modifier will be added.
        /// </param>
        /// <param name="bidModifierValue">The value of the bid modifier to add.</param>
        // [START add_ad_group_bid_modifier]
        public void Run(GoogleAdsClient client, long customerId, long adGroupId,
            double bidModifierValue)
        {
            // Get the AdGroupBidModifierService.
            AdGroupBidModifierServiceClient adGroupBidModifierService =
                client.GetService(Services.V12.AdGroupBidModifierService);

            // Creates an ad group bid modifier for mobile devices with the specified ad group
            // ID and bid modifier value.
            AdGroupBidModifier adGroupBidModifier = new AdGroupBidModifier()
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                BidModifier = bidModifierValue,
                Device = new DeviceInfo()
                {
                    Type = Device.Mobile
                }
            };

            // Creates an ad group bid modifier operation for creating an ad group bid modifier.
            AdGroupBidModifierOperation adGroupBidModifierOperation =
                new AdGroupBidModifierOperation()
                {
                    Create = adGroupBidModifier
                };

            // Send the operation in a mutate request.
            try
            {
                MutateAdGroupBidModifiersResponse response =
                    adGroupBidModifierService.MutateAdGroupBidModifiers(customerId.ToString(),
                        new AdGroupBidModifierOperation[] { adGroupBidModifierOperation });
                Console.WriteLine("Added {0} ad group bid modifiers:", response.Results.Count);
                foreach (MutateAdGroupBidModifierResult result in response.Results)
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
                throw;
            }
        }
        // [END add_ad_group_bid_modifier]
    }
}

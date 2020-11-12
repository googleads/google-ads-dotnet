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
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;

using System;
using static Google.Ads.GoogleAds.V6.Enums.DeviceEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example demonstrates how to add an ad group bid modifier for mobile devices.
    /// To get ad group bid modifiers, see GetAdGroupBidModifiers.cs.
    /// </summary>
    public class AddAdGroupBidModifier : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddAdGroupBidModifier codeExample = new AddAdGroupBidModifier();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the ad group where the bid modifier will be added.
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            // The value of the bid modifier to add.
            double bidModifierValue = double.Parse("INSERT_BID_MODIFIER_VALUE_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId, bidModifierValue);
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
        public void Run(GoogleAdsClient client, long customerId, long adGroupId,
            double bidModifierValue)
        {
            // Get the AdGroupBidModifierService.
            AdGroupBidModifierServiceClient adGroupBidModifierService =
                client.GetService(Services.V6.AdGroupBidModifierService);

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
    }
}

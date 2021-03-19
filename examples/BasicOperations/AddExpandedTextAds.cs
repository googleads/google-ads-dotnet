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
using System.Collections.Generic;

using static Google.Ads.GoogleAds.V6.Enums.AdGroupAdStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example adds expanded text ads to a given ad group. To list
    /// ad groups, run GetAdGroups.cs.
    /// </summary>
    public class AddExpandedTextAds : ExampleBase
    {
        /// <summary>
        /// Number of ads being added / updated in this code example.
        /// </summary>
        private const int NUMBER_OF_ADS = 5;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddExpandedTextAds codeExample = new AddExpandedTextAds();

            Console.WriteLine(codeExample.Description);

            //The customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            //ID of the ad group to which ads are added.
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds expanded text ads to a given ad group. To list ad groups, " +
            "run GetAdGroups.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group to which ads are added.</param>
        // [START add_expanded_text_ads]
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdService = client.GetService(
                Services.V6.AdGroupAdService);

            List<AdGroupAdOperation> operations = new List<AdGroupAdOperation>();
            for (int i = 0; i < NUMBER_OF_ADS; i++)
            {
                // Create the ad group ad object.
                AdGroupAd adGroupAd = new AdGroupAd
                {
                    AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                    // Optional: Set the status.
                    Status = AdGroupAdStatus.Paused,
                    Ad = new Ad
                    {
                        FinalUrls = { "http://www.example.com/" + i },
                        ExpandedTextAd = new ExpandedTextAdInfo
                        {
                            Description = "Buy your tickets now!",
                            HeadlinePart1 = "Cruise #" + i.ToString() + " to Mars",
                            HeadlinePart2 = "Best Space Cruise Line",
                            Path1 = "path1",
                            Path2 = "path2"
                        }
                    }
                };

                // Create the operation.
                operations.Add(new AdGroupAdOperation
                {
                    Create = adGroupAd
                });
            }

            try
            {
                // Create the ads.
                MutateAdGroupAdsResponse response = adGroupAdService.MutateAdGroupAds(
                    customerId.ToString(), operations);

                // Display the results.
                foreach (MutateAdGroupAdResult result in response.Results)
                {
                    Console.WriteLine("Expanded text ad created with resource name: {0}",
                        result.ResourceName);
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
        // [END add_expanded_text_ads]
    }
}

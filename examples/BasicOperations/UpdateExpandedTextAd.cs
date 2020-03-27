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
using Google.Ads.GoogleAds.V3.Common;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;
using System;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example updates an expanded text ad. To get expanded text ads,
    /// run GetExpandedTextAds.cs.
    /// </summary>
    public class UpdateExpandedTextAd : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UpdateExpandedTextAd codeExample = new UpdateExpandedTextAd();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // Optional: ID of the ad group to restrict search to.
            long adGroupId = long.Parse("INSERT_ADGROUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example updates an expanded text ad. To get expanded text " +
                    "ads, run GetExpandedTextAds.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adId"> ID of the ad to update.</param>
        public void Run(GoogleAdsClient client, long customerId, long adId)
        {
            // Get the AdService.
            AdServiceClient adService = client.GetService(Services.V3.AdService);

            Ad ad = new Ad()
            {
                ResourceName = ResourceNames.Ad(customerId, adId),
                ExpandedTextAd = new ExpandedTextAdInfo()
                {
                    // Update some properties of the expanded text ad.
                    HeadlinePart1 = "Cruise to Pluto #" + ExampleUtilities.GetShortRandomString(),
                    HeadlinePart2 = "Tickets on sale now",
                    Description = "Best space cruise ever.",
                },
                FinalUrls = { "http://www.example.com/" },
                FinalMobileUrls = { "http://www.example.com/mobile" }
            };

            AdOperation operation = new AdOperation()
            {
                Update = ad,
                UpdateMask = FieldMasks.AllSetFieldsOf(ad)
            };

            try
            {
                // Issue the update request.
                MutateAdsResponse response = adService.MutateAds(customerId.ToString(),
                    new[] { operation });

                // Display the results.
                foreach (MutateAdResult updatedAd in response.Results)
                {
                    Console.WriteLine($"Ad with resource ID = '{updatedAd.ResourceName}' was " +
                        $"updated.");
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

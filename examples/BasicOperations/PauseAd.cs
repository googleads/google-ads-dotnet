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
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;

using System;

using static Google.Ads.GoogleAds.V3.Enums.AdGroupAdStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example pauses a given ad. To list all ads, run GetExpandedTextAds.cs.
    /// </summary>
    public class PauseAd : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            PauseAd codeExample = new PauseAd();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the ad group that contains the ad.
            long adGroupId = long.Parse("INSERT_ADGROUP_ID_HERE");

            // ID of the ad to be paused.
            long adId = long.Parse("INSERT_AD_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId, adId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example pauses a given ad. To list all ads, run " +
                    "GetExpandedTextAds.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group ID that contains the ad.</param>
        /// <param name="adId">AdGroupAdService</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId, long adId)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdService = client.GetService(
                Services.V3.AdGroupAdService);

            // Create the ad group ad.
            AdGroupAd adGroupAd = new AdGroupAd
            {
                ResourceName = ResourceNames.AdGroupAd(customerId, adGroupId, adId),
                Status = AdGroupAdStatus.Paused
            };

            // Create the operation.
            AdGroupAdOperation operation = new AdGroupAdOperation
            {
                // Set the Update field to the ad group ad object.
                Update = adGroupAd,

                // Use the FieldMasks utility to set the UpdateMask field to  a list of all
                // modified fields of the ad group ad.
                UpdateMask = FieldMasks.AllSetFieldsOf(adGroupAd)
            };
            try
            {
                // Update the ad.
                MutateAdGroupAdsResponse response =
                    adGroupAdService.MutateAdGroupAds(customerId.ToString(),
                        new AdGroupAdOperation[] { operation });

                // Display the results.
                foreach (MutateAdGroupAdResult result in response.Results)
                {
                    Console.WriteLine($"Ad with resource name = {result.ResourceName} was " +
                        "paused.");
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

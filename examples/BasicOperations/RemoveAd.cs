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
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example removes an ad. To list ads, run GetExpandedTextAds.cs.
    /// </summary>
    public class RemoveAd : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            RemoveAd codeExample = new RemoveAd();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The ad group ID that contains the ad.
            long adGroupId = long.Parse("INSERT_ADGROUP_ID_HERE");

            // ID of the ad to remove.
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
                return "This code example removes an ad. To list ads, run GetExpandedTextAds.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group ID that contains the ad.</param>
        /// <param name="adId">ID of the ad to remove.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId, long adId)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient service = client.GetService(Services.V3.AdGroupAdService);

            // Create a new operation.
            AdGroupAdOperation operation = new AdGroupAdOperation
            {
                // Set the Remove field to the name of the resource to be removed.
                Remove = ResourceNames.AdGroupAd(customerId, adGroupId, adId)
            };

            try
            {
                // Remove the ad.
                MutateAdGroupAdsResponse response = service.MutateAdGroupAds(customerId.ToString(),
                    new AdGroupAdOperation[] { operation });

                // Display the results.
                foreach (MutateAdGroupAdResult result in response.Results)
                {
                    Console.WriteLine($"Ad with resource name = {result.ResourceName} " +
                        "was removed.");
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

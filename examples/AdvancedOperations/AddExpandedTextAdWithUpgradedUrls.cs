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
using Google.Ads.GoogleAds.V1.Common;
using Google.Ads.GoogleAds.V1.Errors;
using Google.Ads.GoogleAds.V1.Resources;
using Google.Ads.GoogleAds.V1.Services;

using System;

using static Google.Ads.GoogleAds.V1.Enums.AdGroupAdStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V1
{
    /// <summary>
    /// This code example adds expanded text ads to a given ad group. To list
    /// ad groups, run GetAdGroups.cs.
    /// </summary>
    public class AddExpandedTextAdWithUpgradedUrls : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddExpandedTextAdWithUpgradedUrls codeExample =
                new AddExpandedTextAdWithUpgradedUrls();
            Console.WriteLine(codeExample.Description);

            //The customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            //The ad group ID that contains the ad.
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
                return "This code example adds an expanded text ad that uses advanced features " +
                    "of upgraded URLs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group ID to which ads are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient service = client.GetService(Services.V1.AdGroupAdService);

            // Create the expanded text ad.
            AdGroupAd ad = new AdGroupAd
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                Ad = new Ad
                {
                    ExpandedTextAd = new ExpandedTextAdInfo
                    {
                        Description = "Low-gravity fun for everyone!",
                        HeadlinePart1 = "Luxury Cruise to Mars",
                        HeadlinePart2 = "Visit the Red Planet in style.",
                    },

                    // Specify a tracking URL for 3rd party tracking provider. You may
                    // specify one at customer, campaign, ad group, ad, criterion or
                    // feed item levels.
                    TrackingUrlTemplate =
                  "http://tracker.example.com/?season={_season}&promocode={_promocode}&u={lpurl}",

                    // Since your tracking URL has two custom parameters, provide their
                    // values too. This can be provided at campaign, ad group, ad, criterion
                    // or feed item levels.
                    UrlCustomParameters = {
            new CustomParameter { Key = "season", Value = "christmas" },
            new CustomParameter { Key = "promocode", Value = "NY123" }
          },

                    // Specify a list of final URLs. This field cannot be set if URL field is
                    // set. This may be specified at ad, criterion and feed item levels.
                    FinalUrls = {
            "http://www.example.com/cruise/space/",
            "http://www.example.com/locations/mars/"
          },

                    // Specify a list of final mobile URLs. This field cannot be set if URL
                    // field is set, or finalUrls is unset. This may be specified at ad,
                    // criterion and feed item levels.
                    FinalMobileUrls = {
            "http://mobile.example.com/cruise/space/",
            "http://mobile.example.com/locations/mars/"
          }
                },
                // Optional: Set the status.
                Status = AdGroupAdStatus.Paused
            };

            // Create the operation.
            AdGroupAdOperation operation = new AdGroupAdOperation
            {
                Create = ad
            };

            try
            {
                // Create the ad.
                MutateAdGroupAdsResponse response = service.MutateAdGroupAds(customerId.ToString(),
                    new AdGroupAdOperation[] { operation });

                // Display the results.
                foreach (MutateAdGroupAdResult result in response.Results)
                {
                    Console.WriteLine($"Expanded text ad created with resource name: " +
                        $"{result.ResourceName}.");
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

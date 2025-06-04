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
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V20.Common;
using Google.Ads.GoogleAds.V20.Errors;
using Google.Ads.GoogleAds.V20.Resources;
using Google.Ads.GoogleAds.V20.Services;
using System;
using Google.Ads.GoogleAds.V20.Enums;

namespace Google.Ads.GoogleAds.Examples.V20
{
    /// <summary>
    /// This code example updates a responsive search ad. To get responsive search ads,
    /// run GetResponsiveSearchAds.cs.
    /// </summary>
    public class UpdateResponsiveSearchAd : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UpdateResponsiveSearchAd"/> example.
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
            /// ID of the ad to update.
            /// </summary>
            [Option("adId", Required = true, HelpText =
                "ID of the ad to update.")]
            public long AdId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UpdateResponsiveSearchAd codeExample = new UpdateResponsiveSearchAd();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.AdId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example updates a responsive search ad. To get responsive search ads, run " +
            "GetResponsiveSearchAds.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adId"> ID of the ad to update.</param>
        // [START update_responsive_search_ad]
        public void Run(GoogleAdsClient client, long customerId, long adId)
        {
            // Get the AdService.
            AdServiceClient adService = client.GetService(Services.V20.AdService);

            Ad ad = new Ad()
            {
                ResourceName = ResourceNames.Ad(customerId, adId),
                ResponsiveSearchAd = new ResponsiveSearchAdInfo()
                {
                    // Update some properties of the responsive search ad.
                    Headlines =
                    {
                        new AdTextAsset()
                        {
                            Text = "Cruise to Pluto #" + ExampleUtilities.GetShortRandomString(),
                            PinnedField = ServedAssetFieldTypeEnum.Types.ServedAssetFieldType.Headline1
                        },
                        new AdTextAsset() { Text = "Tickets on sale now" },
                        new AdTextAsset() { Text = "Buy your ticket now" }
                    },
                    Descriptions =
                    {
                        new AdTextAsset() { Text = "Best space cruise ever." },
                        new AdTextAsset() { Text = "The most wonderful space experience you will ever have." },
                    }
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
        // [END update_responsive_search_ad]
    }
}

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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V10.Common;
using Google.Ads.GoogleAds.V10.Enums;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V10.Enums.ServedAssetFieldTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example adds a responsive search ad to a given ad group. To get ad groups,
    /// run GetAdGroups.cs.
    /// </summary>
    public class AddResponsiveSearchAd : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddResponsiveSearchAd"/> example.
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
            /// ID of the ad group to which ads are added.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "ID of the ad group to which ads are added.")]
            public long AdGroupId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = new Options();
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // ID of the ad group to which ads are added.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    return 0;
                });

            AddResponsiveSearchAd codeExample = new AddResponsiveSearchAd();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.AdGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a responsive search ad to a given ad group. To get ad " +
            "groups, run GetAdGroups.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group to which ads are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdService =
                client.GetService(Services.V10.AdGroupAdService);

            // Create the ad.
            Ad ad = new Ad()
            {
                ResponsiveSearchAd = new ResponsiveSearchAdInfo()
                {
                    Headlines =
                    {
                        // Sets a pinning to always choose this asset for HEADLINE_1. Pinning is
                        // optional; if no pinning is set, then headlines and descriptions will be
                        // rotated and the ones that perform best will be used more often.
                        new AdTextAsset() {
                            Text = "Cruise to Mars #" + ExampleUtilities.GetShortRandomString(),
                            PinnedField = ServedAssetFieldType.Headline1
                        },
                        new AdTextAsset() { Text = "Best Space Cruise Line" },
                        new AdTextAsset() { Text = "Experience the Stars" }
                    },
                    Descriptions =
                    {
                        new AdTextAsset() { Text = "Buy your tickets now" },
                        new AdTextAsset() { Text = "Visit the Red Planet" },
                    },
                    Path1 = "all-inclusive",
                    Path2 = "deals"
                },
                FinalUrls = { "http://www.example.com" }
            };

            // Builds the final ad group ad representation.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                Status = AdGroupAdStatusEnum.Types.AdGroupAdStatus.Paused,
                Ad = ad
            };

            // Creates the operation.
            AdGroupAdOperation operation = new AdGroupAdOperation()
            {
                Create = adGroupAd
            };

            try
            {
                MutateAdGroupAdsResponse response =
                    adGroupAdService.MutateAdGroupAds(customerId.ToString(), new[] { operation });
                foreach (MutateAdGroupAdResult result in response.Results)
                {
                    Console.WriteLine($"Responsive search ad created with resource name:" +
                        $" '{result.ResourceName}'.");
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

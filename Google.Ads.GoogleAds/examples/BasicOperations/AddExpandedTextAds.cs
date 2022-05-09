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
using Google.Ads.GoogleAds.V10.Common;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V10.Enums.AdGroupAdStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example adds expanded text ads to a given ad group. To list
    /// ad groups, run GetAdGroups.cs.
    /// </summary>
    public class AddExpandedTextAds : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddExpandedTextAds"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
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
                    // The customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // ID of the ad group to which ads are added.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    return 0;
                });

            AddExpandedTextAds codeExample = new AddExpandedTextAds();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.AdGroupId);
        }

        /// <summary>
        /// Number of ads being added / updated in this code example.
        /// </summary>
        private const int NUMBER_OF_ADS = 5;

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
                Services.V10.AdGroupAdService);

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

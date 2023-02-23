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
using Google.Ads.GoogleAds.V13.Common;
using Google.Ads.GoogleAds.V13.Errors;
using Google.Ads.GoogleAds.V13.Resources;
using Google.Ads.GoogleAds.V13.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V13.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.ServedAssetFieldTypeEnum.Types;
using static Google.Ads.GoogleAds.V13.Errors.PolicyFindingErrorEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V13
{
    /// <summary>
    /// This code example shows how to use the validateOnly request parameter to validate a
    /// responsive search ad.
    /// No objects will be created, but exceptions will still be thrown.
    /// </summary>
    public class ValidateAd : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="ValidateAd"/> example.
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
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            ValidateAd codeExample = new ValidateAd();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example shows how to use the validateOnly request parameter to validate " +
            "a responsive search ad. No objects will be created, but exceptions will still be thrown.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group to which ads are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdService = client.GetService(
                Services.V13.AdGroupAdService);

            // Create the ad group ad object.
            AdGroupAd adGroupAd = new AdGroupAd
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                // Optional: Set the status.
                Status = AdGroupAdStatus.Paused,
                Ad = new Ad
                {
                    ResponsiveSearchAd = new ResponsiveSearchAdInfo
                    {
                        Headlines =
                        {
                            new AdTextAsset() {
                                Text = "Visit the Red Planet in style.",
                                PinnedField = ServedAssetFieldType.Headline1
                            },
                            new AdTextAsset() { Text = "Low-gravity fun for everyone!!" },
                            new AdTextAsset() { Text = "Book your Cruise to Mars now" }
                        },
                        Descriptions =
                        {
                            new AdTextAsset() { Text = "Luxury Cruise to Mars" },
                            new AdTextAsset() { Text = "Book your ticket now" }
                        }
                    },
                    FinalUrls = { "https://www.example.com/" },
                }
            };

            // Create the operation.
            AdGroupAdOperation operation = new AdGroupAdOperation
            {
                Create = adGroupAd
            };

            try
            {
                // Create the ads, while setting validateOnly = true.
                MutateAdGroupAdsResponse response = adGroupAdService.MutateAdGroupAds(
                    new MutateAdGroupAdsRequest()
                    {
                        CustomerId = customerId.ToString(),
                        Operations = { operation },
                        PartialFailure = false,
                        ValidateOnly = true
                    });

                // This line will not be executed since the ad will fail validation.
                Console.WriteLine("Responsive search ad validated successfully.");
            }
            catch (GoogleAdsException e)
            {
                // This block will be hit if there is a validation error from the server.
                Console.WriteLine(
                    "There were validation error(s) while adding a responsive search ad.");

                // Note: Policy violation errors are returned as PolicyFindingErrors. See
                // https://developers.google.com/google-ads/api/docs/policy-exemption/overview
                // for additional details.
                List<GoogleAdsError> policyFindingErrors = e.Failure.Errors
                    .Where(
                        err => err.ErrorCode.PolicyFindingError == PolicyFindingError.PolicyFinding)
                    .ToList();

                if (policyFindingErrors.Any())
                {
                    policyFindingErrors.ForEach(delegate (GoogleAdsError err)
                    {
                        int count = 1;
                        if (err.Details.PolicyFindingDetails != null)
                        {
                            foreach (PolicyTopicEntry entry in
                                err.Details.PolicyFindingDetails.PolicyTopicEntries)
                            {
                                Console.WriteLine($"{count}) Policy topic entry with topic = " +
                                    $"\"{entry.Topic}\" and type = \"{entry.Type}\" " +
                                    $"found.");
                                count++;
                            }
                        }
                    });
                }
                else
                {
                    // There were unexpected validation errors, rethrowing the exception
                    throw;
                }
            }
        }
    }
}

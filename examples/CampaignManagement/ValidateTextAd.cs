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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;

using System;
using System.Linq;
using static Google.Ads.GoogleAds.V6.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V6.Errors.PolicyFindingErrorEnum.Types;
using static Google.Ads.GoogleAds.V6.Errors.PolicyViolationErrorEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example shows how to use the validateOnly header to validate
    /// an expanded text ad. No objects will be created, but exceptions will
    /// still be thrown.
    /// </summary>
    public class ValidateTextAd : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            ValidateTextAd codeExample = new ValidateTextAd();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the ad group to which ads are added.
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example shows how to use the validateOnly header to validate an expanded " +
            "text ad. No objects will be created, but exceptions will still be thrown.";

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
                Services.V6.AdGroupAdService);

            // Create the ad group ad object.
            AdGroupAd adGroupAd = new AdGroupAd
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                // Optional: Set the status.
                Status = AdGroupAdStatus.Paused,
                Ad = new Ad
                {
                    ExpandedTextAd = new ExpandedTextAdInfo
                    {
                        Description = "Luxury Cruise to Mars",
                        HeadlinePart1 = "Visit the Red Planet in style.",
                        HeadlinePart2 = "Low-gravity fun for everyone!!",
                    },
                    FinalUrls = { "http://www.example.com/" },
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

                // Since validation is ON, result will be null.
                Console.WriteLine("Expanded text ad validated successfully.");
            }
            catch (GoogleAdsException e)
            {
                // This block will be hit if there is a validation error from the server.
                Console.WriteLine(
                    "There were validation error(s) while adding expanded text ad.");

                if (e.Failure != null)
                {
                    // Note: Depending on the ad type, you may get back policy violation errors as
                    // either PolicyFindingError or PolicyViolationError. ExpandedTextAds return
                    // errors as PolicyFindingError, so only this case is illustrated here. See
                    // https://developers.google.com/google-ads/api/docs/policy-exemption/overview
                    // for additional details.
                    e.Failure.Errors
                        .Where(err =>
                            err.ErrorCode.PolicyFindingError == PolicyFindingError.PolicyFinding)
                        .ToList()
                        .ForEach(delegate (GoogleAdsError err)
                        {
                            int count = 1;
                            if (err.Details.PolicyFindingDetails != null)
                            {
                                foreach (PolicyTopicEntry entry in
                                    err.Details.PolicyFindingDetails.PolicyTopicEntries)
                                {
                                    Console.WriteLine($"{count}) Policy topic entry with topic = " +
                                        $"\"{entry.Topic}\" and type = \"{entry.Type}\" " +
                                        $"was found.");
                                }
                            }
                            count++;
                        });
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
            }
        }
    }
}

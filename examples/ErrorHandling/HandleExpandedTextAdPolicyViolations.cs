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
using Google.Ads.GoogleAds.V4.Common;
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V4.Enums.AdGroupAdStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example demonstrates how to request an exemption for policy violations of an
    /// expanded text ad. If the request somehow fails with exceptions that are not policy finding
    /// errors, the code example will stop instead of trying to send an exemption request.
    /// </summary>
    public class HandleExpandedTextAdPolicyViolations : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            HandleExpandedTextAdPolicyViolations codeExample =
                new HandleExpandedTextAdPolicyViolations();
            Console.WriteLine(codeExample.Description);
            try
            {
                // The Google Ads customer ID for which the call is made.
                long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                // ID of the ad group to which ads are added.
                long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                codeExample.Run(new GoogleAdsClient(), customerId, adGroupId);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred while running this code example. {0}",
                    ExampleUtilities.FormatException(e));
            }
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example demonstrates how to request an exemption for policy violations of " +
            "an expanded text ad. If the request somehow fails with exceptions that are not " +
            "policy finding  errors, the code example will stop instead of trying to send an " +
            "exemption request.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group to which ads are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            // Get the AdGroupAdServiceClient.
            AdGroupAdServiceClient adGroupAdService = client.GetService(
                Services.V4.AdGroupAdService);

            string adGroupResourceName = ResourceNames.AdGroup(customerId, adGroupId);
            // Creates an expanded text ad info object.
            ExpandedTextAdInfo expandedTextAdInfo = new ExpandedTextAdInfo()
            {
                HeadlinePart1 = $"Cruise to Mars #{ExampleUtilities.GetShortRandomString()}",
                HeadlinePart2 = "Best Space Cruise Line",
                // Intentionally use an ad text that violates policy -- having too many exclamation
                // marks.
                Description = "Buy your tickets now!!!!!!!"
            };

            // Creates an ad group ad to hold the above ad.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                AdGroup = adGroupResourceName,
                // Set the ad group ad to PAUSED to prevent it from immediately serving.
                // Set to ENABLED once you've added targeting and the ad are ready to serve.
                Status = AdGroupAdStatus.Paused,
                // Sets the expanded text ad info on an Ad.
                Ad = new Ad()
                {
                    ExpandedTextAd = expandedTextAdInfo,
                    FinalUrls = { "http://www.example.com" }
                }
            };

            // Creates an ad group ad operation.
            AdGroupAdOperation operation = new AdGroupAdOperation()
            {
                Create = adGroupAd
            };

            try
            {
                try
                {
                    // Try sending a mutate request to add the ad group ad.
                    adGroupAdService.MutateAdGroupAds(customerId.ToString(), new [] { operation });
                }
                catch (GoogleAdsException ex)
                {
                    // The request will always fail because of the policy violation in the
                    // description of the ad.
                    var ignorablePolicyTopics = FetchIgnorablePolicyTopics(ex);
                    // Try sending exemption requests for creating an expanded text ad.
                    RequestExemption(customerId, adGroupAdService, operation, ignorablePolicyTopics);
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

        /// <summary>
        /// Collects all ignorable policy topics that will be sent for exemption request later.
        /// </summary>
        /// <param name="ex">The API exception from a previous call to add ad group ads.</param>
        /// <returns>The ignorable policy topics</returns>
        private static string[] FetchIgnorablePolicyTopics(GoogleAdsException ex)
        {
            List<string> ignorablePolicyTopics = new List<string>(); ;

            Console.WriteLine("Google Ads failure details:");
            foreach (GoogleAdsError error in ex.Failure.Errors)
            {
                if (error.ErrorCode.ErrorCodeCase != ErrorCode.ErrorCodeOneofCase.PolicyFindingError)
                {
                    throw ex;
                }
                if (error.Details != null && error.Details.PolicyFindingDetails != null)
                {
                    PolicyFindingDetails details = error.Details.PolicyFindingDetails;
                    Console.WriteLine($"- Policy finding details:");

                    foreach (PolicyTopicEntry entry in details.PolicyTopicEntries)
                    {
                        ignorablePolicyTopics.Add(entry.Topic);
                        Console.WriteLine($"  - Policy topic name: '{entry.Topic}");
                        Console.WriteLine($"  - Policy topic entry type: '{entry.Type}");
                        // For the sake of brevity, we exclude printing "policy topic evidences"
                        // and "policy topic constraints" here. You can fetch those data by
                        // calling:
                        // - entry.Evidences
                        // - entry.Constraints
                    }
                }
            }
            return ignorablePolicyTopics.ToArray();
        }

        /// <summary>
        /// Sends exemption requests for creating an expanded text ad.
        /// </summary>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="service">The ad group ad service.</param>
        /// <param name="operation">The ad group ad operation to request exemption for.</param>
        /// <param name="ignorablePolicyTopics">The ignorable policy topics.</param>
        private static void RequestExemption(long customerId, AdGroupAdServiceClient service,
            AdGroupAdOperation operation, string[] ignorablePolicyTopics)
        {
            Console.WriteLine("Try adding an expanded text ad again by requesting exemption for " +
                "its policy violations.");
            PolicyValidationParameter validationParameter = new PolicyValidationParameter();
            validationParameter.IgnorablePolicyTopics.AddRange(ignorablePolicyTopics);
            operation.PolicyValidationParameter = validationParameter;

            MutateAdGroupAdsResponse response = service.MutateAdGroupAds(
                customerId.ToString(), new[] { operation });
            Console.WriteLine($"Successfully added an expanded text ad with resource name " +
                $"'{response.Results[0].ResourceName}' by requesting for policy violation " +
                $"exemption.");
        }
    }
}

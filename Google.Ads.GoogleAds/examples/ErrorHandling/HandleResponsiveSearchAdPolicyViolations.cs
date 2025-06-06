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
using Google.Ads.GoogleAds.V20.Common;
using Google.Ads.GoogleAds.V20.Errors;
using Google.Ads.GoogleAds.V20.Resources;
using Google.Ads.GoogleAds.V20.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V20.Enums.AdGroupAdStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V20
{
    /// <summary>
    /// This code example demonstrates how to request an exemption for policy violations of a
    /// responsive search ad. If the request somehow fails with exceptions that are not policy finding
    /// errors, the code example will stop instead of trying to send an exemption request.
    /// </summary>
    public class HandleResponsiveSearchAdPolicyViolations : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="HandleResponsiveSearchAdPolicyViolations"/>
        /// example.
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
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            HandleResponsiveSearchAdPolicyViolations codeExample =
                new HandleResponsiveSearchAdPolicyViolations();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example demonstrates how to request an exemption for policy violations of " +
            "a responsive search ad. If the request somehow fails with exceptions that are not " +
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
                Services.V20.AdGroupAdService);

            string adGroupResourceName = ResourceNames.AdGroup(customerId, adGroupId);
            ResponsiveSearchAdInfo responsiveSearchAdInfo = new ResponsiveSearchAdInfo()
            {
                Headlines = {
                    new AdTextAsset() { Text = $"Cruise to Mars #{ExampleUtilities.GetShortRandomString()}" },
                    new AdTextAsset() { Text = "Best Space Cruise Line" },
                    new AdTextAsset() { Text = "Experience the Stars" }
                },
                Descriptions = {
                    // Intentionally use an ad text that violates policy -- having too many exclamation
                    // marks.
                    new AdTextAsset() { Text = "Buy your tickets now!!!!!!!" },
                    new AdTextAsset() { Text = "Visit the Red Planet" }
                }
            };

            // Creates an ad group ad to hold the above ad.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                AdGroup = adGroupResourceName,
                // Set the ad group ad to PAUSED to prevent it from immediately serving.
                // Set to ENABLED once you've added targeting and the ad are ready to serve.
                Status = AdGroupAdStatus.Paused,
                // Sets the responsive search ad info on an Ad.
                Ad = new Ad()
                {
                    ResponsiveSearchAd = responsiveSearchAdInfo,
                    FinalUrls = { "https://www.example.com" }
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
                    adGroupAdService.MutateAdGroupAds(customerId.ToString(), new[] { operation });
                }
                catch (GoogleAdsException ex)
                {
                    // The request will always fail because of the policy violation in the
                    // description of the ad.
                    var ignorablePolicyTopics = FetchIgnorablePolicyTopics(ex);
                    // Try sending exemption requests for creating a responsive search ad.
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
        // [START handle_responsive_search_ad_policy_violations]
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
                        Console.WriteLine($"  - Policy topic name: '{entry.Topic}'");
                        Console.WriteLine($"  - Policy topic entry type: '{entry.Type}'");
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
        // [END handle_responsive_search_ad_policy_violations]

        /// <summary>
        /// Sends exemption requests for creating a responsive search ad.
        /// </summary>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="service">The ad group ad service.</param>
        /// <param name="operation">The ad group ad operation to request exemption for.</param>
        /// <param name="ignorablePolicyTopics">The ignorable policy topics.</param>
        // [START handle_responsive_search_ad_policy_violations_1]
        private static void RequestExemption(long customerId, AdGroupAdServiceClient service,
            AdGroupAdOperation operation, string[] ignorablePolicyTopics)
        {
            Console.WriteLine("Try adding a responsive search ad again by requesting exemption for " +
                "its policy violations.");
            PolicyValidationParameter validationParameter = new PolicyValidationParameter();
            validationParameter.IgnorablePolicyTopics.AddRange(ignorablePolicyTopics);
            operation.PolicyValidationParameter = validationParameter;

            MutateAdGroupAdsResponse response = service.MutateAdGroupAds(
                customerId.ToString(), new[] { operation });
            Console.WriteLine($"Successfully added a responsive search ad with resource name " +
                $"'{response.Results[0].ResourceName}' by requesting for policy violation " +
                $"exemption.");
        }
        // [END handle_responsive_search_ad_policy_violations_1]
    }
}

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
using Google.Ads.GoogleAds.V19.Common;
using Google.Ads.GoogleAds.V19.Errors;
using Google.Ads.GoogleAds.V19.Resources;
using Google.Ads.GoogleAds.V19.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V19.Enums.AgeRangeTypeEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.GenderTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V19
{
    /// <summary>
    /// This code example adds demographic criteria to an ad group. To get ad groups,
    /// run GetAdGroups.cs.
    /// </summary>
    public class AddDemographicTargetingCriteria : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddDemographicTargetingCriteria"/>
        /// example.
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
            /// ID of the ad group to which targeting criteria are added.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "ID of the ad group to which targeting criteria are added.")]
            public long AdGroupId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddDemographicTargetingCriteria codeExample = new AddDemographicTargetingCriteria();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds demographic criteria to an ad group. To get ad groups, run " +
            "GetAdGroups.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group to which targeting criteria are added.
        /// </param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V19.AdGroupCriterionService);

            string adGroupResourceName = ResourceNames.AdGroup(customerId, adGroupId);

            // Creates a positive ad group criterion for gender.
            AdGroupCriterion genderAdGroupCriterion = new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                // Targets male.
                Gender = new GenderInfo()
                {
                    Type = GenderType.Male
                }
            };

            // Creates a negative ad group criterion for age range.
            AdGroupCriterion ageRangeNegativeAdGroupCriterion = new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                // Makes this ad group criterion negative.
                Negative = true,
                // Targets the age range of 18 to 24.
                AgeRange = new AgeRangeInfo()
                {
                    Type = AgeRangeType.AgeRange1824
                }
            };

            // Creates ad group criterion operations for both ad group criteria.
            AdGroupCriterionOperation[] operations = new AdGroupCriterionOperation[]
            {
                new AdGroupCriterionOperation()
                {
                    Create = genderAdGroupCriterion
                },
                new AdGroupCriterionOperation()
                {
                    Create = ageRangeNegativeAdGroupCriterion
                }
            };

            try
            {
                // Issues a mutate request to add the ad group criteria and print out some
                // information.
                MutateAdGroupCriteriaResponse response =
                    adGroupCriterionService.MutateAdGroupCriteria(
                        customerId.ToString(), operations);

                Console.WriteLine($"Added {response.Results.Count} demographic ad group" +
                    $" criteria:");

                foreach (MutateAdGroupCriterionResult result in response.Results)
                {
                    Console.WriteLine(result.ResourceName);
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

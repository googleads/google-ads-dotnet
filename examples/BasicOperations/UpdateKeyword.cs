// Copyright 2019 Google LLC.
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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V10.Enums.AdGroupCriterionStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example illustrates udating a keyword.
    /// </summary>
    public class UpdateKeyword : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UpdateKeyword"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The Google Ads ad group ID.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "The Google Ads ad group ID.")]
            public long AdGroupId { get; set; }

            /// <summary>
            /// The Google Ads keyword criterion ID.
            /// </summary>
            [Option("criterionId", Required = true, HelpText =
                "The Google Ads keyword criterion ID.")]
            public long CriterionId { get; set; }
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
                    // The Google Ads customer ID.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // The Google Ads ad group ID.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    // The Google Ads keyword criterion ID.
                    options.CriterionId = long.Parse("INSERT_CRITERION_ID_HERE");

                    return 0;
                });

            UpdateKeyword codeExample = new UpdateKeyword();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.AdGroupId,
                options.CriterionId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example illustrates updating a keyword.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="adGroupId">The Google Ads ad group ID.</param>
        /// <param name="criterionId">The Google Ads keyword criterion ID.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId, long criterionId)
        {
            // Get the CampaignCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V10.AdGroupCriterionService);

            // Create the keyword for update.
            AdGroupCriterion keyword = new AdGroupCriterion()
            {
                ResourceName = ResourceNames.AdGroupCriterion(customerId, adGroupId, criterionId),
                CriterionId = criterionId,
                Status = AdGroupCriterionStatus.Enabled,
                FinalUrls = { "https://www.example.com" }
            };

            AdGroupCriterionOperation keywordOperation = new AdGroupCriterionOperation()
            {
                Update = keyword,
                UpdateMask = FieldMasks.AllSetFieldsOf(keyword)
            };

            try
            {
                // Update the keyword.
                MutateAdGroupCriteriaResponse response =
                    adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        new AdGroupCriterionOperation[] { keywordOperation });

                // Display the results.
                foreach (MutateAdGroupCriterionResult criterionResult in response.Results)
                {
                    Console.WriteLine($"Keyword with resource name = " +
                        $"'{criterionResult.ResourceName}' was updated.");
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

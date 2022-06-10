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
using Google.Ads.GoogleAds.V11.Common;
using Google.Ads.GoogleAds.V11.Errors;
using Google.Ads.GoogleAds.V11.Resources;
using Google.Ads.GoogleAds.V11.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V11.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V11.Enums.KeywordMatchTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    /// This code example demonstrates how to add a keyword into an ad group.
    /// </summary>
    public class AddKeywords : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddKeywords"/> example.
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
            /// The ad group to which new keyword ia added.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "The ad group to which new keyword ia added.")]
            public long AdGroupId { get; set; }

            /// <summary>
            /// The new keyword text.
            /// </summary>
            [Option("keywordText", Required = true, HelpText =
                "The new keyword text.")]
            public string KeywordText { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddKeywords codeExample = new AddKeywords();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.AdGroupId,
                options.KeywordText);
        }

        /// <summary>
        /// The default keyword text.
        /// </summary>
        private const string KEYWORD_TEXT = "mars cruise";

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example demonstrates how to add " +
            "a keyword into an ad group.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group to which new keyword ia added.</param>
        /// <param name="keywordText">The new keyword text.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId,
            string keywordText)
        {
            if (string.IsNullOrEmpty(keywordText))
            {
                keywordText = KEYWORD_TEXT;
            }
            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V11.AdGroupCriterionService);

            // Create a keyword.
            AdGroupCriterion criterion = new AdGroupCriterion()
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                Status = AdGroupCriterionStatus.Enabled,
                Keyword = new KeywordInfo()
                {
                    Text = keywordText,
                    MatchType = KeywordMatchType.Exact
                }
            };

            // Create the operation.
            AdGroupCriterionOperation operation = new AdGroupCriterionOperation()
            {
                Create = criterion,
            };

            try
            {
                // Add the keywords.
                MutateAdGroupCriteriaResponse retVal =
                    adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        new AdGroupCriterionOperation[] { operation });

                // Display the results.
                if (retVal.Results.Count > 0)
                {
                    foreach (MutateAdGroupCriterionResult newCriterion in retVal.Results)
                    {
                        Console.WriteLine($"Created keyword with resource ID = " +
                            "'{newCriterion.ResourceName}'.");
                    }
                }
                else
                {
                    Console.WriteLine("No keywords were added.");
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

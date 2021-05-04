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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V7.Common;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;

using System;

using static Google.Ads.GoogleAds.V7.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.KeywordMatchTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example demonstrates how to add keyword into an ad group.
    /// </summary>
    public class AddKeywords : ExampleBase
    {
        /// <summary>
        /// The default keyword text.
        /// </summary>
        private const string KEYWORD_TEXT = "mars cruise";

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddKeywords codeExample = new AddKeywords();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The ad group to which new keyword is added.
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            // The new keyword text.
            string keywordText = "INSERT_KEYWORD_TEXT_HERE";

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId, keywordText);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example demonstrates how to add keyword " +
            "into an ad group.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group to which new keyword ia added.</param>
        /// <param name="keywordText">The new keyword text.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId, string keywordText)
        {
            if (string.IsNullOrEmpty(keywordText))
            {
                keywordText = KEYWORD_TEXT;
            }
            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V7.AdGroupCriterionService);

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

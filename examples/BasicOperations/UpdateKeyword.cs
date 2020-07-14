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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;

using System;

using static Google.Ads.GoogleAds.V4.Enums.AdGroupCriterionStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example illustrates udating a keyword.
    /// </summary>
    public class UpdateKeyword : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UpdateKeyword codeExample = new UpdateKeyword();
            Console.WriteLine(codeExample.Description);

            // the Google Ads Customer Id
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");
            // the Google Ads adgroup Id
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");
            // the Google Ads adgroup criterion Id
            long keywordId = long.Parse("INSERT_ADGROUP_CRITERION_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId, keywordId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example illustrates updating a keyword.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer Id.</param>
        /// <param name="adGroupId">The Google Ads ad group Id.</param>
        /// <param name="keywordId">The Google Ads keyword Id.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId, long keywordId)
        {
            // Get the CampaignCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V4.AdGroupCriterionService);

            // Create the keyword for update.
            AdGroupCriterion keyword = new AdGroupCriterion()
            {
                ResourceName = ResourceNames.AdGroupCriterion(customerId, adGroupId, keywordId),
                CriterionId = keywordId,
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

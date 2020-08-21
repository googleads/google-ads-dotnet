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
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example removes a keyword. To get keywords, run GetKeywords.cs.
    /// </summary>
    public class RemoveKeyword : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            RemoveKeyword codeExample = new RemoveKeyword();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // Id of the ad group that contains the keyword.
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            // Id of the keyword to be removed.
            long criterionId = long.Parse("INSERT_CRITERION_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId, criterionId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example removes a keyword using the 'REMOVE' operator. To get keywords, " +
            "run GetKeywords.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer account ID.</param>
        /// <param name="adGroupId">Id of the ad group that contains the keyword.</param>
        /// <param name="criterionId">Id of the keyword to be removed.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId, long criterionId)
        {
            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService = client.GetService(
                Services.V4.AdGroupCriterionService);

            // Create the operation.
            AdGroupCriterionOperation operation = new AdGroupCriterionOperation();
            operation.Remove = ResourceNames.AdGroupCriterion(customerId, adGroupId, criterionId);

            try
            {
                // Remove the keyword.
                MutateAdGroupCriteriaResponse retVal =
                    adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        new AdGroupCriterionOperation[] { operation });

                // Display the results.
                MutateAdGroupCriterionResult removedKeyword = retVal.Results[0];
                Console.WriteLine($"Keyword with resource name = "+
                    $"'{removedKeyword.ResourceName}' was removed.");
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

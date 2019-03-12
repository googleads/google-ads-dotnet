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
using Google.Ads.GoogleAds.V1.Common;
using Google.Ads.GoogleAds.V1.Errors;
using Google.Ads.GoogleAds.V1.Resources;
using Google.Ads.GoogleAds.V1.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V1.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V1.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V1.Errors.ErrorLocation.Types;

namespace Google.Ads.GoogleAds.Examples.V1
{
    /// <summary>
    /// This code example demonstrates how to handle partial failures.
    /// </summary>
    public class HandlePartialFailures : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            HandlePartialFailures codeExample = new HandlePartialFailures();
            Console.WriteLine(codeExample.Description);
            try
            {
                long adGroupId = long.Parse("INSERT_ADGROUP_ID_HERE");

                // The Google Ads customer ID for which the call is made.
                long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

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
        public override string Description
        {
            get
            {
                return "This code example demonstrates how to handle partial failures.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="adGroupId">Id of the ad group to which keywords are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V1.AdGroupCriterionService);

            // Create the keywords. The second and fourth keywords have policy violation, and will
            // fail with errors.
            string[] keywords = new string[]
            {
                "mars cruise",
                "inv@lid cruise",
                "venus cruise",
                "b(a)d keyword cruise"
            };

            List<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();
            for (int i = 0; i < keywords.Length; i++)
            {
                // Create a keyword.
                AdGroupCriterion criterion = new AdGroupCriterion()
                {
                    AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                    Status = AdGroupCriterionStatus.Enabled,
                    Keyword = new KeywordInfo()
                    {
                        Text = keywords[i],
                        MatchType = KeywordMatchType.Exact
                    }
                };

                // Create the operation.
                AdGroupCriterionOperation operation = new AdGroupCriterionOperation()
                {
                    Create = criterion,
                };
                operations.Add(operation);
            }

            try
            {
                // Add the keywords.
                MutateAdGroupCriteriaResponse result =
                    adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(),
                        operations, true, false);

                // Display the results.
                if (result.Results.Count > 0)
                {
                    foreach (MutateAdGroupCriterionResult newCriterion in result.Results)
                    {
                        // If an operation failed, the result would be empty.
                        if (!newCriterion.IsEmpty())
                        {
                            Console.WriteLine($"Created keyword with resource ID = " +
                                $"'{newCriterion.ResourceName}'.");
                        }
                    }
                }

                // Display the partial failure errors.
                foreach (GoogleAdsFailure failure in result.PartialFailures)
                {
                    foreach (GoogleAdsError error in failure.Errors)
                    {
                        List<string> fieldPaths = new List<string>();
                        long? operationIndex = null;
                        foreach (FieldPathElement fpElement in error.Location.FieldPathElements)
                        {
                            if (fpElement.FieldName == "operation")
                            {
                                operationIndex = fpElement.Index.Value;
                            }
                            if (fpElement.Index.HasValue)
                            {
                                fieldPaths.Add($"{fpElement.FieldName}[{fpElement.Index}]");
                            }
                            else
                            {
                                fieldPaths.Add(fpElement.FieldName);
                            }
                        }

                        if (operationIndex.HasValue)
                        {
                            AdGroupCriterionOperation failedOperation =
                                operations[(int) operationIndex.Value];
                            Console.WriteLine($"Keyword with ad group resource " +
                                $"'{failedOperation.Create.AdGroup}' and text " +
                                $"'{failedOperation.Create.Keyword.Text}' triggered a failure " +
                                $"for the following reason:");

                        }
                        else
                        {
                            Console.WriteLine("A failure for the following reason:");

                        }
                        Console.WriteLine($"-- Error: {error.Message}({error.ErrorCode}) @ " +
                            $"{string.Join(".", fieldPaths)}, Trigger: {error.Trigger}");
                    }
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
            }
        }
    }
}

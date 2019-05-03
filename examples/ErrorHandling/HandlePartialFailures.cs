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
using System.Linq;
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
                long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

                // The Google Ads customer ID for which the call is made.
                long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
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
        /// <param name="campaignId">Id of the campaign to which ad groups are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the AdGroupServiceClient.
            AdGroupServiceClient adGroupService = client.GetService(Services.V1.AdGroupService);


            // This ad group should be created successfully - assuming the campaign in the params
            // exists.
            AdGroup adgroup1 = new AdGroup()
            {
                Campaign = ResourceNames.Campaign(customerId, campaignId),
                Name = "Valid AdGroup: " + ExampleUtilities.GetRandomString()
            };

            // This ad group will always fail - campaign ID 0 in resource names is never valid.
            AdGroup adgroup2 = new AdGroup()
            {
                Campaign = ResourceNames.Campaign(customerId, 0),
                Name = "Broken AdGroup: " + ExampleUtilities.GetRandomString()
            };

            // This ad group will always fail - duplicate ad group names are not allowed.
            AdGroup adgroup3 = new AdGroup()
            {
                Campaign = ResourceNames.Campaign(customerId, 0),
                Name = adgroup1.Name
            };

            // Create the operations.
            AdGroupOperation op1 = new AdGroupOperation()
            {
                Create = adgroup1
            };

            AdGroupOperation op2 = new AdGroupOperation()
            {
                Create = adgroup2
            };

            AdGroupOperation op3 = new AdGroupOperation()
            {
                Create = adgroup3
            };
            
            try
            {
                // Add the ad groups.
                MutateAdGroupsResponse response =
                    adGroupService.MutateAdGroups(customerId.ToString(),
                        new AdGroupOperation[] { op1 }, true, false);

                // Display the results.
                if (response.PartialFailureError == null)
                {
                    Console.WriteLine("All operations completed successfully. No partial " +
                        "failures to show.");
                    return;
                }
                else
                {
                    // Finds the failed operations by looping through the results.
                    int operationIndex = 0;
                    foreach (MutateAdGroupResult result in response.Results)
                    {
                        if (result.IsEmpty())
                        {
                            List<GoogleAdsError> errors =
                                response.PartialFailure.GetErrorsByOperationIndex(operationIndex);
                            foreach (GoogleAdsError error in errors)
                            {
                                Console.WriteLine($"Operation {operationIndex} failed with " +
                                    $"error: {error}.");
                            }
                        }
                        else
                        {
                            Console.WriteLine($"Operation {operationIndex} succeeded.", operationIndex);
                        }
                        operationIndex++;
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

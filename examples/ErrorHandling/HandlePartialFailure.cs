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
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example demonstrates how to handle partial failures.
    /// </summary>
    public class HandlePartialFailure : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            HandlePartialFailure codeExample = new HandlePartialFailure();
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
        /// <param name="campaignId">ID of the campaign to which ad groups are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            try
            {
                MutateAdGroupsResponse response = CreateAdGroups(client, customerId, campaignId);

                // Checks for existence of any partial failures in the response.
                if (CheckIfPartialFailureErrorExists(response))
                {
                    Console.WriteLine("Partial failures occurred. Details will be shown below.");
                }
                else
                {
                    Console.WriteLine("All operations completed successfully. No partial " +
                        "failures to show.");
                    return;
                }

                // Finds the failed operations by looping through the results.
                PrintResults(response);

                // Display the results.
                if (response.PartialFailureError == null)
                {
                    Console.WriteLine("Partial failures occurred. Details will be shown below.");
                }
                else
                {
                    Console.WriteLine("All operations completed successfully. No partial " +
                        "failures to show.");
                    return;
                }

                // Finds the failed operations by looping through the results.
                PrintResults(response);
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
        /// Displays the result from the mutate operation.
        /// </summary>
        /// <param name="response">The mutate response from the Google Ads API server..</param>
        private void PrintResults(MutateAdGroupsResponse response)
        {
            // Finds the failed operations by looping through the results.
            int operationIndex = 0;
            foreach (MutateAdGroupResult result in response.Results)
            {
                // This represents the result of a failed operation.
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
                    Console.WriteLine($"Operation {operationIndex} succeeded.",
                        operationIndex);
                }
                operationIndex++;
            }
        }

        /// <summary>
        /// Inspects a response to check for presence of partial failure errors.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns>True if there are partial failures, false otherwise.</returns>
        private static bool CheckIfPartialFailureErrorExists(MutateAdGroupsResponse response)
        {
            return response.PartialFailureError == null;
        }

        /// <summary>
        /// Attempts to create 3 ad groups with partial failure enabled. One of the ad groups
        /// will succeed, while the other will fail.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which ad groups are added.</param>
        /// <returns>The mutate response from the Google Ads server.</returns>
        private static MutateAdGroupsResponse CreateAdGroups(GoogleAdsClient client,
            long customerId, long campaignId)
        {
            // Get the AdGroupServiceClient.
            AdGroupServiceClient adGroupService = client.GetService(Services.V3.AdGroupService);

            string validAdGroupName = "Valid AdGroup: " + ExampleUtilities.GetRandomString();

            AdGroupOperation[] operations = new AdGroupOperation[]
            {
                // This operation will be successful, assuming the campaign specified in
                // campaignId parameter is correct.
                new AdGroupOperation()
                {
                    Create = new AdGroup()
                    {
                        Campaign = ResourceNames.Campaign(customerId, campaignId),
                        Name = validAdGroupName
                    }
                },
                // This operation will fail since we are using campaign ID = 0, which results
                // in an invalid resource name.
                new AdGroupOperation()
                {
                    Create = new AdGroup()
                    {
                        Campaign = ResourceNames.Campaign(customerId, 0),
                        Name = "Broken AdGroup: " + ExampleUtilities.GetRandomString()
                    },
                },
                // This operation will fail since the ad group is using the same name as the ad
                // group from the first operation. Duplicate ad group names are not allowed.
                new AdGroupOperation()
                {
                    Create = new AdGroup()
                    {
                        Campaign = ResourceNames.Campaign(customerId, campaignId),
                        Name = validAdGroupName
                    }
                }
            };

            // Add the ad groups.
            MutateAdGroupsResponse response =
                adGroupService.MutateAdGroups(new MutateAdGroupsRequest()
                {
                    CustomerId = customerId.ToString(),
                    Operations = { operations },
                    PartialFailure = true,
                    ValidateOnly = false
                });
            return response;
        }
    }
}

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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V3.Common;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;
using System;
using static Google.Ads.GoogleAds.V3.Enums.ContentLabelTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example adds various types of negative criteria as exclusions at the customer
    /// level. These criteria will be applied to all campaigns for the customer.
    /// </summary>
    public class AddCustomerNegativeCriteria : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddCustomerNegativeCriteria codeExample = new AddCustomerNegativeCriteria();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example adds various types of negative criteria as exclusions " +
                    "at the customer level. These criteria will be applied to all campaigns " +
                    "for the customer.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the CustomerNegativeCriterionServiceClient .
            CustomerNegativeCriterionServiceClient customerNegativeCriterionService =
                client.GetService(Services.V3.CustomerNegativeCriterionService);

            // Creates a negative customer criterion excluding the content label type of 'TRAGEDY'.
            CustomerNegativeCriterion tragedyCriterion = new CustomerNegativeCriterion()
            {
                ContentLabel = new ContentLabelInfo()
                {
                    Type = ContentLabelType.Tragedy
                }
            };

            // Creates a negative customer criterion excluding the placement with URL
            // 'http://www.example.com'.
            CustomerNegativeCriterion placementCriterion = new CustomerNegativeCriterion()
            {
                Placement = new PlacementInfo()
                {
                    Url = "http://www.example.com"
                }
            };

            // Creates the operations.
            CustomerNegativeCriterionOperation tragedyCriterionOperation =
                new CustomerNegativeCriterionOperation()
                {
                    Create = tragedyCriterion
                };

            CustomerNegativeCriterionOperation placementCriterionOperation =
                new CustomerNegativeCriterionOperation()
                {
                    Create = placementCriterion
                };

            try
            {
                // Adds the negative customer criteria.
                MutateCustomerNegativeCriteriaResponse response =
                    customerNegativeCriterionService.MutateCustomerNegativeCriteria(
                        customerId.ToString(), new CustomerNegativeCriterionOperation[]
                        { tragedyCriterionOperation, placementCriterionOperation });

                // Displays the results.
                Console.WriteLine($"Created {response.Results.Count} new negative customer " +
                    $"criteria.");

                foreach (MutateCustomerNegativeCriteriaResult result in response.Results)
                {
                    Console.WriteLine($"Created new negative customer criteria with resource " +
                        $"name '{result.ResourceName}'.");
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

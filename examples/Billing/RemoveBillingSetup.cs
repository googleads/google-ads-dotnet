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
    /// This code example removes a billing setup, specified by ID. To get available billing setup,
    /// run GetBillingSetups.cs.
    /// </summary>
    public class RemoveBillingSetup : ExampleBase
    {
        /// <summary>
        /// The page size to be used by default.
        /// </summary>
        private const int PAGE_SIZE = 1_000;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            RemoveBillingSetup codeExample = new RemoveBillingSetup();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the billing setup to remove.
            long billingSetupId = long.Parse("INSERT_BILLING_SETUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, billingSetupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example removes a billing setup, specified by ID. To get " +
                    "available billing setup, run GetBillingSetups.cs";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="billingSetupId">ID of the billing setup to remove.</param>
        public void Run(GoogleAdsClient client, long customerId, long billingSetupId)
        {
            // Get the BillingSetupServiceClient.
            BillingSetupServiceClient billingSetupService = client.GetService(
                Services.V4.BillingSetupService);

            // Create the billing setup resource.
            String billingSetupResource = ResourceNames.BillingSetup(customerId, billingSetupId);

            // Construct an operation that will remove the billing setup.
            BillingSetupOperation operation = new BillingSetupOperation()
            {
                Remove = billingSetupResource
            };

            try
            {
                // Send the operation in a mutate request.
                MutateBillingSetupResponse response =
                    billingSetupService.MutateBillingSetup(customerId.ToString(), operation);

                Console.WriteLine("Removed billing setup with resource name '{0}'.",
                    response.Result.ResourceName);
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

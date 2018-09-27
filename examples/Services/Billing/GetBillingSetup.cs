// Copyright 2018 Google LLC
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
using Google.Ads.GoogleAds.V0.Resources;
using Google.Ads.GoogleAds.V0.Services;
using Google.Api.Gax;
using System;

namespace Google.Ads.GoogleAds.Examples.V0
{
    /// <summary>
    /// This code example gets all BillingSetup objects available for the specified customer ID.
    /// </summary>
    public class GetBillingSetup : ExampleBase
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
            GetBillingSetup codeExample = new GetBillingSetup();
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
                return "This code example gets all BillingSetup objects available for the " +
                    "specified customer ID.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V0.GoogleAdsService);

            // Define a GAQL query to retrieve all billing setup information.
            String searchQuery = "SELECT billing_setup.id, billing_setup.status, " +
                "billing_setup.payments_account_id, billing_setup.payments_account_name, " +
                "billing_setup.payments_profile_id, billing_setup.payments_profile_name, " +
                "billing_setup.secondary_payments_profile_id FROM billing_setup";

            // Creates a request that will retrieve all billing setups using pages of the specified
            // page size.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                PageSize = PAGE_SIZE,
                Query = searchQuery,
                CustomerId = customerId.ToString()
            };

            try
            {
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                foreach (SearchGoogleAdsResponse response in searchPagedResponse.AsRawResponses())
                {
                    foreach (GoogleAdsRow googleAdsRow in response.Results)
                    {
                        BillingSetup billingSetup = googleAdsRow.BillingSetup;
                        Console.WriteLine("Billing setup with ID '{0}', status '{1}', " +
                            "payments_account_id '{2}', payments_account_name '{3}', " +
                            "payments_profile_id '{4}', payments_profile_name '{5}', " +
                            "secondary_payments_profile_id '{6}'.",
                            billingSetup.Id, billingSetup.Status, billingSetup.PaymentsAccountId,
                            billingSetup.PaymentsAccountName, billingSetup.PaymentsProfileId,
                            billingSetup.PaymentsProfileName,
                            billingSetup.SecondaryPaymentsProfileId);
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

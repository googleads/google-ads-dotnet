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
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;
using Google.Api.Gax;
using System;

namespace Google.Ads.GoogleAds.Examples.V4
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
        public override string Description =>
            "This code example gets all BillingSetup objects available for the specified " +
            "customer ID.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V4.GoogleAdsService);

            // Define a GAQL query to retrieve all billing setup information.
            string searchQuery = @"
                SELECT
                    billing_setup.id,
                    billing_setup.status,
                    billing_setup.payments_account,
                    billing_setup.payments_account_info.payments_account_id,
                    billing_setup.payments_account_info.payments_account_name,
                    billing_setup.payments_account_info.payments_profile_id,
                    billing_setup.payments_account_info.payments_profile_name,
                    billing_setup.payments_account_info.secondary_payments_profile_id
                FROM billing_setup";

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
                            "payments account '{2}', payments account Id '{3}', " +
                            "payments account name '{4}', payments profile id '{5}', " +
                            "payments profile name '{6}', secondary payments profile id '{7}'.",
                            billingSetup.Id,
                            billingSetup.Status,
                            billingSetup.PaymentsAccount,
                            billingSetup.PaymentsAccountInfo.PaymentsAccountId,
                            billingSetup.PaymentsAccountInfo.PaymentsAccountName,
                            billingSetup.PaymentsAccountInfo.PaymentsProfileId,
                            billingSetup.PaymentsAccountInfo.PaymentsProfileName,
                            billingSetup.PaymentsAccountInfo.SecondaryPaymentsProfileId);
                    }
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

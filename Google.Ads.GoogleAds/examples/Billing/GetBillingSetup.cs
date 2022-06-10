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

using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V11.Errors;
using Google.Ads.GoogleAds.V11.Resources;
using Google.Ads.GoogleAds.V11.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V11.Enums.BillingSetupStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    /// This code example gets all BillingSetup objects available for the specified customer ID.
    /// </summary>
    public class GetBillingSetup : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetBillingSetup"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GetBillingSetup codeExample = new GetBillingSetup();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// The page size to be used by default.
        /// </summary>
        private const int PAGE_SIZE = 1_000;

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
        // [START get_billing_setup]
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V11.GoogleAdsService);

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

                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    BillingSetup billingSetup = googleAdsRow.BillingSetup;
                    Console.WriteLine($"Billing setup with ID '{billingSetup.Id}'has status " +
                        $"'{billingSetup.Status}'.");

                    // A missing billing setup will have no payments account information.
                    if (billingSetup.HasPaymentsAccount)
                    {
                        Console.WriteLine(
                            $"\tPayments account: {billingSetup.PaymentsAccount}\n" +
                            "\tPayments account Id: " +
                            $"{billingSetup.PaymentsAccountInfo.PaymentsAccountId}\n" +
                            "\tPayments profile id: " +
                            $"{billingSetup.PaymentsAccountInfo.PaymentsProfileId}\n");

                        // A pending billing setup will not have values for certain fields.
                        if (billingSetup.Status != BillingSetupStatus.Pending)
                        {
                            Console.WriteLine(
                                "\tPayments account name: " +
                                $"{billingSetup.PaymentsAccountInfo.PaymentsAccountName}\n" +
                                "\tPayments profile name: " +
                                $"{billingSetup.PaymentsAccountInfo.PaymentsProfileName}\n" +
                                "\tSecondary payments profile id: " +
                                $"{billingSetup.PaymentsAccountInfo.SecondaryPaymentsProfileId}");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Payments account details missing or incomplete.");
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
        // [END get_billing_setup]
    }
}

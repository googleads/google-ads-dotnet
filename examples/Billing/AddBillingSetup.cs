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
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;
using Google.Api.Gax;
using System;
using System.Linq;
using static Google.Ads.GoogleAds.V3.Enums.TimeTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This example creates a billing setup for a customer. A billing setup is a link between
    /// payment account and customer. The new billing setup can either reuse an existing payments
    /// account, or create a new payments account with a given payments profile.
    /// In the case of consolidated billing, a payments account is linked to the manager account and
    /// is linked to a customer account via a billing setup.
    /// </summary>
    public class AddBillingSetup : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddBillingSetup codeExample = new AddBillingSetup();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // Either a payments account ID or a payments profile ID must be provided for the example
            // to run successfully. If both are provided, only the payments account ID will be used.
            // See: https://developers.google.com/google-ads/api/docs/billing/billing-setups#creating_new_billing_setups
            // Provide an existing payments account ID to link to the new billing setup. Must be
            // formatted as "1234-5678-9012-3456".
            string paymentsAccountId = "INSERT_PAYMENTS_ACCOUNT_ID_HERE";
            // Alternatively, provide a payments profile ID, which will be linked to a new payments
            // account and the new billing setup. Must be formatted as "1234-5678-9012".
            string paymentsProfileId = "INSERT_PAYMENTS_PROFILE_ID_HERE";

            codeExample.Run(new GoogleAdsClient(), customerId, paymentsAccountId, paymentsProfileId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This example creates a billing setup for a customer. A billing setup is " +
                       "a link between payment account and customer. The new billing setup can " +
                       "either reuse an existing payments account, or create a new payments " +
                       "account with a given payments profile.\n" +
                       "In the case of consolidated billing, a payments account is linked to the " +
                       "manager account and is linked to a customer account via a billing setup.";
            }
        }

        /// <summary>
        /// Runs the code example. Either a payments account ID or a payments profile ID
        /// must be provided for the example to run successfully. If both are provided, only the
        /// payments account ID will be used.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="paymentsAccountId">Optional payments account ID to attach to the new
        ///     billing setup. Must be formatted as "1234-5678-9012-3456".</param>
        /// <param name="paymentsProfileId">Optional payments profile ID to attach to a new payments
        ///     account and to the new billing setup. Must be formatted as "1234-5678-9012".</param>
        public void Run(GoogleAdsClient client, long customerId, string paymentsAccountId,
            string paymentsProfileId)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V3.GoogleAdsService);

            // Get the BillingSetupServiceClient.
            BillingSetupServiceClient billingSetupServiceClient =
                client.GetService(Services.V3.BillingSetupService);

            try
            {
                // Create a new billing setup.
                BillingSetup billingSetup =
                    CreateBillingSetup(customerId, paymentsAccountId, paymentsProfileId);

                SetBillingSetupStartDateTime(customerId, googleAdsService, billingSetup);

                // Create the billing setup operation and send it to the BillingSetupService.
                BillingSetupOperation operation = new BillingSetupOperation()
                {
                    Create = billingSetup
                };

                MutateBillingSetupResponse billingResponse =
                    billingSetupServiceClient.MutateBillingSetup(customerId.ToString(), operation);

                Console.WriteLine("Added new billing setup with resource name: " +
                                  $"{billingResponse.Result.ResourceName}");
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
        /// Creates and returns a new Billing Setup instance with complete payment details. One of
        /// paymentsAccountId or paymentsProfileId must be provided.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="paymentsAccountId">Optional payments account ID to attach to the new
        ///     billing setup. Must be formatted as "1234-5678-9012-3456".</param>
        /// <param name="paymentsProfileId">Optional payments profile ID to attach to a new payments
        ///     account and to the new billing setup. Must be formatted as "1234-5678-9012".</param>
        /// <returns>A new BillingSetup instance with complete payment details.</returns>
        /// <exception cref="Exception">Generic exception if no payment details have been
        ///     provided.</exception>
        private BillingSetup CreateBillingSetup(long customerId, string paymentsAccountId,
            string paymentsProfileId)
        {
            BillingSetup billingSetup = new BillingSetup();

            // Set the appropriate payments account field.
            if (paymentsAccountId != null)
            {
                // If a payments account id has been provided, set PaymentsAccount to its resource
                // name. You can list available payments accounts via the PaymentsAccountService's
                // ListPaymentsAccounts method.
                billingSetup.PaymentsAccount =
                    ResourceNames.PaymentsAccount(customerId, paymentsAccountId);
            }
            else if (paymentsProfileId != null)
            {
                // Otherwise, create a new payments account by setting the PaymentsAccountInfo
                // field. See https://support.google.com/google-ads/answer/7268503 for information
                // about payments profiles.
                billingSetup.PaymentsAccountInfo = new BillingSetup.Types.PaymentsAccountInfo()
                {
                    PaymentsAccountName = "Payments Account #" + ExampleUtilities.GetRandomString(),
                    PaymentsProfileId = paymentsProfileId
                };
            }
            else
            {
                throw new Exception("No paymentsAccountId or paymentsProfileId provided.");
            }

            return billingSetup;
        }

        /// <summary>
        /// Sets the starting date time for the new billing setup. Queries the customer's account
        /// to see if there are any approved billing setups. If there are any, the new billing setup
        /// may have a starting date time of any day in the future. If not, the billing setup must
        /// be set to start immediately.
        /// </summary>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="googleAdsService">The Google Ads service client.</param>
        /// <param name="billingSetup">The instance of BillingSetup whose starting date time will
        ///     be set.</param>
        private void SetBillingSetupStartDateTime(long customerId, GoogleAdsServiceClient
            googleAdsService, BillingSetup billingSetup)
        {
            // Query to see if there are any existing approved billing setups. See
            // GetBillingSetup.cs for a more detailed example of requesting billing setup
            // information.
            string query = @"
                SELECT billing_setup.end_date_time
                FROM billing_setup
                WHERE billing_setup.status = 'APPROVED'
                ORDER BY billing_setup.end_date_time DESC";

            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchResponse =
                googleAdsService.Search(customerId.ToString(), query);

            if (searchResponse.Any())
            {
                // If there are any existing approved billing setups, the new billing setup can
                // start immediately after the last.
                string lastEndingDateTimeString = searchResponse.First().BillingSetup.EndDateTime;

                // Check if the existing billing setup has no end date (i.e., is set to run
                // indefinitely).
                DateTime lastEndingDateTime = lastEndingDateTimeString == null ? DateTime.Today :
                    DateTime.Parse(lastEndingDateTimeString);

                billingSetup.StartDateTime = lastEndingDateTime.AddDays(1).ToString("yyyy-MM-dd");
                billingSetup.EndDateTime = lastEndingDateTime.AddDays(2).ToString("yyyy-MM-dd");
            }
            else
            {
                // If there are no existing approved billing setups, the only acceptable start time
                // is TimeType.Now.
                billingSetup.StartTimeType = TimeType.Now;
            }
        }
    }
}

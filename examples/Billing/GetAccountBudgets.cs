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
using Google.Ads.GoogleAds.V2.Errors;
using Google.Ads.GoogleAds.V2.Resources;
using Google.Ads.GoogleAds.V2.Services;
using Google.Api.Gax;
using System;

namespace Google.Ads.GoogleAds.Examples.V2
{
    /// <summary>
    /// This example retrieves all account budgets for a Google Ads customer.
    /// </summary>
    public class GetAccountBudgets : ExampleBase
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
            GetAccountBudgets codeExample = new GetAccountBudgets();
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
                return "This example retrieves all account budgets for a Google Ads customer.";
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
                Services.V2.GoogleAdsService);

            // Construct a GAQL query which will retrieve AccountBudgetProposals.
            String searchQuery =
                @"SELECT
                    account_budget.status,
                    account_budget.billing_setup,
                    account_budget.approved_spending_limit_micros,
                    account_budget.approved_spending_limit_type,
                    account_budget.proposed_spending_limit_micros,
                    account_budget.proposed_spending_limit_type,
                    account_budget.approved_start_date_time,
                    account_budget.proposed_start_date_time,
                    account_budget.approved_end_date_time,
                    account_budget.approved_end_time_type,
                    account_budget.proposed_end_date_time,
                    account_budget.proposed_end_time_type
                 FROM
                     account_budget";

            // Creates a request that will retrieve all account budgets using pages of the
            // specified page size.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                PageSize = PAGE_SIZE,
                Query = searchQuery,
                CustomerId = customerId.ToString()
            };

            try
            {
                // Issues the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                // Iterates over all rows in all pages and prints the requested field values for
                // the account budget in each row.
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    AccountBudget budget = googleAdsRow.AccountBudget;

                    Console.WriteLine(String.Format("Account budget '{0}' with status '{1}', " +
                        "billing setup '{2}', amount served {3:0.00}, total adjustments " +
                        "{4:0.00}, approved spending limit '{5}' (proposed '{6}'), approved " +
                        "start time '{7}' (proposed '{8}'), approved end time '{9}' " +
                        "(proposed '{10}')",
                        budget.ResourceName,
                        budget.Status,
                        budget.BillingSetup,
                        budget.AmountServedMicros.Value / 1_000_000.0,
                        budget.TotalAdjustmentsMicros.Value / 1_000_000.0,
                        budget.ApprovedSpendingLimitMicros.HasValue
                            ? String.Format(
                                "%.2f", budget.ApprovedSpendingLimitMicros.Value / 1_000_000.0)
                            : budget.ApprovedSpendingLimitType.ToString(),
                        budget.ProposedSpendingLimitMicros.HasValue
                            ? String.Format(
                                "%.2f", budget.ProposedSpendingLimitMicros.Value / 1_000_000.0)
                            : budget.ProposedSpendingLimitType.ToString(),
                        budget.ApprovedStartDateTime,
                        budget.ProposedStartDateTime,
                        String.IsNullOrEmpty(budget.ApprovedEndDateTime)
                            ? budget.ApprovedEndTimeType.ToString()
                            : budget.ApprovedEndDateTime,
                        String.IsNullOrEmpty(budget.ProposedEndDateTime)
                            ? budget.ProposedEndTimeType.ToString()
                            : budget.ProposedEndDateTime));
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

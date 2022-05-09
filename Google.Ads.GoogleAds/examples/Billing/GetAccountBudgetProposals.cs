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
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example gets all account budget proposals. To add an account budget proposal, run
    /// AddAccountBudgetProposal.cs.
    /// </summary>
    public class GetAccountBudgetProposals : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetAccountBudgetProposals"/> example.
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
            Options options = new Options();
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    return 0;
                });

            GetAccountBudgetProposals codeExample = new GetAccountBudgetProposals();
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
            "This code example gets all account budget proposals. To add an account budget " +
            "proposal, run AddAccountBudgetProposal.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V10.GoogleAdsService);

            // Construct a GAQL query which will retrieve AccountBudgetProposals.
            String searchQuery =
                @"SELECT account_budget_proposal.id,
                     account_budget_proposal.account_budget,
                     account_budget_proposal.billing_setup,
                     account_budget_proposal.status,
                     account_budget_proposal.proposed_name,
                     account_budget_proposal.proposed_notes,
                     account_budget_proposal.proposed_purchase_order_number,
                     account_budget_proposal.proposal_type,
                     account_budget_proposal.approval_date_time,
                     account_budget_proposal.creation_date_time
                 FROM
                     account_budget_proposal";

            // Creates a request that will retrieve all account budget proposals using pages of the
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

                // Iterates over all rows in all pages and prints the requested field values for the
                // account budget in each row.
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    AccountBudgetProposal proposal = googleAdsRow.AccountBudgetProposal;
                    Console.WriteLine($"Account budget proposal with ID '{proposal.Id}' " +
                        $"status '{proposal.Status}', account_budget '{proposal.AccountBudget}' " +
                        $"billing_setup '{proposal.BillingSetup}', " +
                        $"proposed_name '{proposal.ProposedName}', " +
                        $"proposed_notes '{proposal.ProposedNotes}', " +
                        $"proposed_po_number '{proposal.ProposedPurchaseOrderNumber}', " +
                        $"proposal_type '{proposal.ProposalType}', " +
                        $"approval_date_time '{proposal.ApprovalDateTime}', " +
                        $"creation_date_time '{proposal.CreationDateTime}'.");
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

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
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;
using static Google.Ads.GoogleAds.V6.Enums.AccountBudgetProposalTypeEnum.Types;
using static Google.Ads.GoogleAds.V6.Enums.TimeTypeEnum.Types;

using System;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example creates an account budget proposal using the 'CREATE' operation. To get
    /// account budget proposals, run GetAccountBudgetProposals.cs.
    /// </summary>
    public class AddAccountBudgetProposal : ExampleBase
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
            AddAccountBudgetProposal codeExample = new AddAccountBudgetProposal();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The Billing Setup ID for which the call is made.
            long billingSetupId = long.Parse("INSERT_BILLING_SETUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, billingSetupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates an account budget proposal using the 'CREATE' operation. " +
            "To get account budget proposals, run GetAccountBudgetProposals.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="billingSetupId">The Billing Setup ID for which the call is made.</param>
        // [START add_account_budget_proposal]
        public void Run(GoogleAdsClient client, long customerId, long billingSetupId)
        {
            // Get the AccountBudgetProposalServiceClient.
            AccountBudgetProposalServiceClient proposalService =
                client.GetService(Services.V6.AccountBudgetProposalService);

            // Create an AccountBudgetProposal.
            // The proposal will be reviewed offline by Google Ads, and if approved will
            // become an AccountBudget.
            AccountBudgetProposal proposal = new AccountBudgetProposal()
            {
                BillingSetup = ResourceNames.BillingSetup(customerId, billingSetupId),
                ProposalType = AccountBudgetProposalType.Create,
                ProposedName = "Account Budget (example)",

                // Specify the account budget starts immediately
                ProposedStartTimeType = TimeType.Now,
                // Alternatively, you can specify a specific start time. Refer to the
                // AccountBudgetProposal resource documentation for allowed formats.
                //
                //ProposedStartDateTime = "2020-01-02 03:04:05",

                // Specify that the budget runs forever.
                ProposedEndTimeType = TimeType.Forever,
                // Alternatively you can specify a specific end time. Allowed formats are as above.
                //ProposedEndDateTime = "2021-02-03 04:05:06",

                // Optional: set notes for the budget. These are free text and do not effect budget
                // delivery.
                //ProposedNotes = "Received prepayment of $0.01",

                // Set the spending limit to 0.01, measured in the Google Ads account currency.
                ProposedSpendingLimitMicros = 10_000

                // Optional: set PO number for record keeping. This value is at the user's
                // discretion, and has no effect on Google Billing & Payments.
                //ProposedPurchaseOrderNumber = "PO number 12345"
            };

            // Create an operation which will add the new AccountBudgetProposal
            AccountBudgetProposalOperation operation = new AccountBudgetProposalOperation()
            {
                Create = proposal
            };

            try
            {
                // Send the request to the Account Budget Proposal Service.
                MutateAccountBudgetProposalResponse response = proposalService.
                    MutateAccountBudgetProposal(customerId.ToString(), operation);

                // Display the results.
                Console.WriteLine($"Account budget proposal '{response.Result.ResourceName}' " +
                    "was created.");
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
        // [END add_account_budget_proposal]
    }
}

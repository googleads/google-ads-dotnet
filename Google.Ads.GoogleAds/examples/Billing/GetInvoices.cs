// Copyright 2021 Google LLC
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
using Google.Ads.GoogleAds.V12.Errors;
using Google.Ads.GoogleAds.V12.Resources;
using Google.Ads.GoogleAds.V12.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V12.Enums.MonthOfYearEnum.Types;
using static Google.Ads.GoogleAds.V12.Resources.Invoice.Types;

namespace Google.Ads.GoogleAds.Examples.V12
{
    /// <summary>
    /// This code example retrieves the invoices issued last month for a given billing setup.
    /// </summary>
    public class GetInvoices : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetInvoices"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The billing setup ID for which to request invoices.
            /// </summary>
            [Option("billingSetupId", Required = true, HelpText =
                "The billing setup ID for which to request invoices.")]
            public long BillingSetupId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GetInvoices codeExample = new GetInvoices();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.BillingSetupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example retrieves the invoices issued last month for a given billing setup.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="billingSetupId">The billing setup ID for which to request invoices.</param>
        public void Run(GoogleAdsClient client, long customerId, long billingSetupId)
        {
            // Get the InvoiceService client.
            InvoiceServiceClient invoiceServiceClient =
                client.GetService(Services.V12.InvoiceService);

            // Get the last month before today.
            DateTime lastMonthDateTime = DateTime.Today.AddMonths(-1);

            // Convert the desired month to its representation in the MonthOfYear enum.
            MonthOfYear lastMonth =
                (MonthOfYear) Enum.Parse(typeof(MonthOfYear), lastMonthDateTime.ToString("MMMM"));

            // [START get_invoices]
            ListInvoicesResponse response = invoiceServiceClient.ListInvoices(customerId.ToString(),
                ResourceNames.BillingSetup(customerId, billingSetupId),
                // Year must be 2019 or later.
                lastMonthDateTime.Year.ToString("yyyy"),
                lastMonth);
            // [END get_invoices]

            // [START get_invoices_1] Iterate over all retrieved invoices and print their
            // information.
            foreach (Invoice invoice in response.Invoices)
            {
                Console.WriteLine(
                    "- Found the invoice '{0}':\n" +
                    "  ID (also known as Invoice Number): '{1}'\n" +
                    "  Type: {2}\n" +
                    "  Billing setup ID: '{3}'\n" +
                    "  Payments account ID (also known as Billing Account Number): '{4}'\n" +
                    "  Payments profile ID (also known as Billing ID): '{5}'\n" +
                    "  Issue date (also known as Invoice Date): {6}\n" +
                    "  Due date: {7}\n" +
                    "  Currency code: {8}\n" +
                    "  Service date range (inclusive): from {9} to {10}\n" +
                    "  Adjustments: subtotal '{11}', tax '{12}', total '{13}'\n" +
                    "  Regulatory costs: subtotal '{14}', tax '{15}', total '{16}'\n" +
                    "  Replaced invoices: '{17}'\n" +
                    "  Amounts: subtotal '{18}', tax '{19}', total '{20}'\n" +
                    "  Corrected invoice: '{21}'\n" +
                    "  PDF URL: '{22}'\n" +
                    "  Account budgets:\n",
                    invoice.ResourceName,
                    invoice.Id,
                    invoice.Type.ToString(),
                    invoice.BillingSetup,
                    invoice.PaymentsAccountId,
                    invoice.PaymentsProfileId,
                    invoice.IssueDate,
                    invoice.DueDate,
                    invoice.CurrencyCode,
                    invoice.ServiceDateRange.StartDate,
                    invoice.ServiceDateRange.EndDate,
                    FormatMicros(invoice.AdjustmentsSubtotalAmountMicros),
                    FormatMicros(invoice.AdjustmentsTaxAmountMicros),
                    FormatMicros(invoice.AdjustmentsTotalAmountMicros),
                    FormatMicros(invoice.RegulatoryCostsSubtotalAmountMicros),
                    FormatMicros(invoice.RegulatoryCostsTaxAmountMicros),
                    FormatMicros(invoice.RegulatoryCostsTotalAmountMicros),
                    invoice.ReplacedInvoices.Count > 0
                        ? string.Join("', '", invoice.ReplacedInvoices)
                        : "none",
                    FormatMicros(invoice.SubtotalAmountMicros),
                    FormatMicros(invoice.TaxAmountMicros),
                    FormatMicros(invoice.TotalAmountMicros),
                    string.IsNullOrEmpty(invoice.CorrectedInvoice)
                        ? invoice.CorrectedInvoice
                        : "none",
                    invoice.PdfUrl);
                foreach (AccountBudgetSummary accountBudgetSummary in
                    invoice.AccountBudgetSummaries)
                {
                    Console.WriteLine(
                        "\t- Account budget '{0}':\n" +
                        "\t  Name (also known as Account Budget): '{1}'\n" +
                        "\t  Customer (also known as Account ID): '{2}'\n" +
                        "\t  Customer descriptive name (also known as Account): '{3}'\n" +
                        "\t  Purchase order number (also known as Purchase Order): '{4}'\n" +
                        "\t  Billing activity date range (inclusive): from {5} to {6}\n" +
                        "\t  Amounts: subtotal '{7}', tax '{8}', total '{9}'\n",
                        accountBudgetSummary.AccountBudget,
                        accountBudgetSummary.AccountBudgetName ?? "none",
                        accountBudgetSummary.Customer,
                        accountBudgetSummary.CustomerDescriptiveName ?? "none",
                        accountBudgetSummary.PurchaseOrderNumber ?? "none",
                        accountBudgetSummary.BillableActivityDateRange.StartDate,
                        accountBudgetSummary.BillableActivityDateRange.EndDate,
                        FormatMicros(accountBudgetSummary.SubtotalAmountMicros),
                        FormatMicros(accountBudgetSummary.TaxAmountMicros),
                        FormatMicros(accountBudgetSummary.TotalAmountMicros));
                }
            }
            // [END get_invoices_1]
        }

        /// <summary>
        /// Format an amount in micros to a more readable, currency-like form.
        /// </summary>
        /// <param name="amountMicros">The amount in micros.</param>
        /// <returns>String representation of the original amount in "X.YY" form.</returns>
        private string FormatMicros(long amountMicros)
        {
            return (amountMicros / 1000000.0).ToString("0.##");
        }
    }
}

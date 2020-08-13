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

using System;
using System.Collections.Generic;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;
using Google.Api.Gax;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    ///     This example gets the account hierarchy of the specified manager account. If you don't
    ///     specify manager customer ID, the example will instead print the hierarchies of all
    ///     accessible customer accounts for your authenticated Google account.
    ///     Note that if the list of accessible customers for your authenticated Google account
    ///     includes accounts within the same hierarchy, this example will retrieve and print
    ///     the overlapping portions of the hierarchy for each accessible customer.
    /// </summary>
    public class GetAccountHierarchy : ExampleBase
    {
        private const int PAGE_SIZE = 1000;

        /// <summary>
        ///     Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example gets the account hierarchy of a specified manager " +
            "account. If you don't specify a manager customer ID, the example will " +
            "instead print " + "the hierarchies of all accessible customer accounts " +
            "for your authenticated Google account.";

        /// <summary>
        ///     Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetAccountHierarchy codeExample = new GetAccountHierarchy();

            Console.WriteLine(codeExample.Description);

            long managerId = long.Parse("INSERT_MANAGER_ID_HERE");
            long loginCustomerId = long.Parse("INSERT_LOGIN_CUSTOMER_ID_HERE");

            try
            {
                codeExample.Run(new GoogleAdsClient(), managerId, loginCustomerId);
            }
            catch (GoogleAdsException adsException)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {adsException.Message}");
                Console.WriteLine($"Failure: {adsException.Failure}");
                Console.WriteLine($"Request ID: {adsException.RequestId}");
                throw;
            }
        }

        /// <summary>
        ///     Runs the code example.
        /// </summary>
        /// <param name="googleAdsClient">The Google Ads client instance.</param>
        /// <param name="managerCustomerId">Optional manager account ID. If none provided, this method
        /// will instead list the accounts accessible from the authenticated Google Ads account.
        /// </param>
        /// <param name="loginCustomerId">The login customer ID used to create the GoogleAdsClient.
        /// </param>
        public void Run(GoogleAdsClient googleAdsClient, long? managerCustomerId = null,
            long? loginCustomerId = null)
        {
            if (loginCustomerId.HasValue)
            {
                googleAdsClient.Config.LoginCustomerId = loginCustomerId.Value.ToString();
            }

            GoogleAdsServiceClient googleAdsServiceClient =
                googleAdsClient.GetService(Services.V4.GoogleAdsService);

            CustomerServiceClient customerServiceClient =
                googleAdsClient.GetService(Services.V4.CustomerService);

            // List of Customer IDs to handle.
            List<long> seedCustomerIds = new List<long>();

            // If a Manager ID was provided in the customerId parameter, it will be the only ID
            // in the list. Otherwise, we will issue a request for all customers accessible by
            // this authenticated Google account.
            if (managerCustomerId.HasValue)
            {
                seedCustomerIds.Add(managerCustomerId.Value);
            }
            else
            {
                Console.WriteLine(
                    "No manager customer ID is specified. The example will print the hierarchies " +
                    " of all accessible customer IDs:");

                string[] customerResourceNames = customerServiceClient.ListAccessibleCustomers();

                foreach (string customerResourceName in customerResourceNames)
                {
                    Customer customer = customerServiceClient.GetCustomer(customerResourceName);
                    Console.WriteLine(customer.Id.Value);
                    seedCustomerIds.Add(customer.Id.Value);
                }

                Console.WriteLine();
            }

            // Creates a query that retrieves all child accounts of the manager specified in
            // search calls below.
            const string query = @"SELECT
                                    customer_client.client_customer,
                                    customer_client.level,
                                    customer_client.manager,
                                    customer_client.descriptive_name,
                                    customer_client.currency_code,
                                    customer_client.time_zone,
                                    customer_client.id
                                FROM customer_client
                                WHERE
                                    customer_client.level <= 1";

            foreach (long seedCustomerId in seedCustomerIds)
            {
                // Performs a breadth-first search to build a Dictionary that maps managers to their
                // child accounts (customerIdsToChildAccounts).
                Queue<long> unprocessedCustomerIds = new Queue<long>();
                unprocessedCustomerIds.Enqueue(seedCustomerId);
                Dictionary<long, List<CustomerClient>> customerIdsToChildAccounts =
                    new Dictionary<long, List<CustomerClient>>();
                CustomerClient rootCustomerClient = null;

                while (unprocessedCustomerIds.Count > 0)
                {
                    managerCustomerId = unprocessedCustomerIds.Dequeue();
                    PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> response =
                        googleAdsServiceClient.Search(
                            managerCustomerId.ToString(),
                            query,
                            pageSize: PAGE_SIZE
                        );

                    // Iterates over all rows in all pages to get all customer clients under the
                    // specified customer's hierarchy.
                    foreach (GoogleAdsRow googleAdsRow in response)
                    {
                        CustomerClient customerClient = googleAdsRow.CustomerClient;

                        // The customer client that with level 0 is the specified customer.
                        if (customerClient.Level == 0)
                        {
                            if (rootCustomerClient == null) rootCustomerClient = customerClient;

                            continue;
                        }

                        // For all level-1 (direct child) accounts that are a manager account,
                        // the above query will be run against them to create a Dictionary of
                        // managers mapped to their child accounts for printing the hierarchy
                        // afterwards.
                        if (!customerIdsToChildAccounts.ContainsKey(managerCustomerId.Value))
                            customerIdsToChildAccounts.Add(managerCustomerId.Value,
                                new List<CustomerClient>());

                        customerIdsToChildAccounts[managerCustomerId.Value].Add(customerClient);

                        if (customerClient.Manager.HasValue && customerClient.Manager.Value)
                            // A customer can be managed by multiple managers, so to prevent
                            // visiting the same customer many times, we need to check if it's
                            // already in the Dictionary.
                            if (!customerIdsToChildAccounts.ContainsKey(customerClient.Id.Value) &&
                                customerClient.Level == 1)
                                unprocessedCustomerIds.Enqueue(customerClient.Id.Value);
                    }
                }

                if (rootCustomerClient != null)
                {
                    Console.WriteLine("The hierarchy of customer ID {0} is printed below:",
                        rootCustomerClient.Id);
                    PrintAccountHierarchy(rootCustomerClient, customerIdsToChildAccounts, 0);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine(
                        "Customer ID {0} is likely a test account, so its customer client " +
                        " information cannot be retrieved.", managerCustomerId);
                }
            }
        }

        /// <summary>
        ///     Prints the specified account's hierarchy using recursion.
        ///     <param name="customerClient">
        ///         the customer client whose info will be printed and
        ///         its child accounts will be processed if it's a manager
        ///     </param>
        ///     <param name="customerIdsToChildAccounts"> a Dictionary mapping customer IDs to
        ///                 child accounts</param>
        ///     <param name="depth"> the current integer depth we are printing from in the
        ///                 account hierarchy</param>
        /// </summary>
        private void PrintAccountHierarchy(CustomerClient customerClient,
            Dictionary<long, List<CustomerClient>> customerIdsToChildAccounts, int depth)
        {
            if (depth == 0)
                Console.WriteLine("Customer ID (Descriptive Name, Currency Code, Time Zone)");

            long customerId = customerClient.Id.Value;
            Console.Write(new string('-', depth * 2));
            Console.WriteLine("{0} ({1}, {2}, {3})",
                customerId, customerClient.DescriptiveName, customerClient.CurrencyCode,
                customerClient.TimeZone);

            // Recursively call this function for all child accounts of $customerClient.
            if (customerIdsToChildAccounts.ContainsKey(customerId))
                foreach (CustomerClient childAccount in customerIdsToChildAccounts[customerId])
                    PrintAccountHierarchy(childAccount, customerIdsToChildAccounts,
                        depth + 1);
        }
    }
}

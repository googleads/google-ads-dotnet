// Copyright 2020 Google LLC.
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
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Services;
using static Google.Ads.GoogleAds.V3.Services.GoogleAdsServiceClient;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// Shows how to download a set of reports from a list of accounts in parallel. If you need
    /// to obtain a list of accounts, please see the GetAccountHierarchy or
    /// ListAccessibleCustomers examples.";
    /// </summary>
    public class ParallelReportDownload : ExampleBase
    {
        // Defines the Google Ads Query Language (GAQL) query strings to run for each customer ID.
        private readonly string[] GAQL_QUERY_STRINGS =
        {
            @"SELECT campaign.id, metrics.impressions, metrics.clicks
                FROM campaign
                WHERE segments.date DURING LAST_30_DAYS",
            @"SELECT campaign.id, ad_group.id, metrics.impressions, metrics.clicks
                FROM ad_group
                WHERE segments.date DURING LAST_30_DAYS"
        };

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            ParallelReportDownload codeExample = new ParallelReportDownload();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer IDs for which the call is made.
            long[] customerIds = new long[]
            {
                long.Parse("INSERT_CUSTOMER_ID_1_HERE"),
                long.Parse("INSERT_CUSTOMER_ID_2_HERE")
            };

            // Optional login customer ID if your access to the CIDs is via a manager account.
            long loginCustomerId = long.Parse("INSERT_MANAGER_ACCOUNT_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerIds, loginCustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "Shows how to download a set of reports from a list of accounts in " +
                       "parallel. If you need to obtain a list of accounts, please see the " +
                       "GetAccountHierarchy or ListAccessibleCustomers examples.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerIds">The Google Ads customer Id.</param>
        /// <param name="loginCustomerId">Optional login customer ID if your access to the CIDs
        ///     is via a manager account.</param>
        public void Run(GoogleAdsClient client, long[] customerIds, long? loginCustomerId)
        {
            // If a manager ID is supplied, update the login credentials.
            if (loginCustomerId.HasValue)
            {
                client.Config.LoginCustomerId = loginCustomerId.ToString();
            }

            // Get the GoogleAdsService. A single client can be shared by all threads.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V3.GoogleAdsService);

            try
            {
                // Begin downloading reports and block program termination until complete.
                Task task = RunDownloadParallelAsync(googleAdsService, customerIds);
                task.Wait();
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
        /// Initiate all download requests, wait for their completion, and report the results.
        /// </summary>
        /// <param name="googleAdsService">The Google Ads service.</param>
        /// <param name="customerIds">The list of customer IDs from which to request data.</param>
        /// <returns>The asynchronous operation.</returns>
        private async Task RunDownloadParallelAsync(
            GoogleAdsServiceClient googleAdsService, long[] customerIds)
        {
            // List of all requests to ensure that we wait for the reports to complete on all
            // customer IDs before proceeding.
            List<Task<SearchStreamStream>> tasks = new List<Task<SearchStreamStream>>();

            // Collection of downloaded responses.
            ConcurrentBag<ReportDownload> responses = new ConcurrentBag<ReportDownload>();

            // Helpful identifier for active tasks.
            //int reportId = 1;

            // IMPORTANT: You should avoid hitting the same customer ID in parallel. There are rate
            // limits at the customer ID level which are much stricter than limits at the developer
            // token level. Hitting these limits frequently enough will significantly reduce
            // throughput as the client library will automatically retry with exponential back-off
            // before failing the request.
            Parallel.ForEach(GAQL_QUERY_STRINGS, (query, outerState, outerIndex) =>

                    // foreach (string query in GAQL_QUERY_STRINGS)
                {
                    Console.WriteLine($"Query: {query}");

                    Parallel.ForEach(customerIds, (customerId, innerState, innerIndex) =>
                        // foreach (long customerId in customerIds)
                    {
                        int reportId = (int) (outerIndex * GAQL_QUERY_STRINGS.Length + innerIndex);
                        Console.WriteLine($"\tReport {reportId} requested " +
                            $"for CID {customerId}.");

                        // Issue an asynchronous search request and add it to the list of requests
                        // in progress.
                        tasks.Add(DownloadReportAsync(googleAdsService, customerId, query,
                            reportId, responses));
                    });
                }
            );

            Console.WriteLine($"Awaiting results from {tasks.Count} requests...\n");

            // Proceed only when all requests have completed.
            await Task.WhenAll(tasks);

            foreach (ReportDownload reportDownload in responses)
            {
                // Give a summary report for each successful download.
                Console.WriteLine(reportDownload);
            }
        }

        /// <summary>
        /// Initiates one asynchronous report download.
        /// </summary>
        /// <param name="googleAdsService">The Google Ads service client.</param>
        /// <param name="customerId">The customer ID from which data is requested.</param>
        /// <param name="query">The query for the download request.</param>
        /// <param name="reportId">Integer identifier for this request.</param>
        /// <param name="responses">Collection of all successful report downloads.</param>
        /// <returns>The asynchronous operation.</returns>
        /// <exception cref="GoogleAdsException">Thrown if errors encountered in the execution of
        ///     the request.</exception>
        private async Task<SearchStreamStream> DownloadReportAsync(
            GoogleAdsServiceClient googleAdsService, long customerId, string query, int reportId,
            ConcurrentBag<ReportDownload> responses)
        {
            try
            {
                // Issue an asynchronous download request.
                return await googleAdsService.SearchStreamAsync(
                    customerId.ToString(), query,
                    delegate(SearchGoogleAdsStreamResponse resp)
                    {
                        // Store the results.
                        responses.Add(new ReportDownload()
                        {
                            CustomerId = customerId,
                            ReportId = reportId,
                            Response = resp
                        });
                    }
                );
            }
            catch (AggregateException ae)
            {
                Console.WriteLine($"Download failed for report {reportId}!");

                GoogleAdsException gae = GoogleAdsException.FromTaskException(ae);

                if (gae != null)
                {
                    Console.WriteLine($"Message: {gae.Message}");
                    Console.WriteLine($"Failure: {gae.Failure}");
                    Console.WriteLine($"Request ID: {gae.RequestId}");
                    throw gae;
                }

                throw;
            }
        }

        /// <summary>
        /// Stores a result from a reporting API call. In this case we simply report a count of
        /// the responses, but one could also write the response to a database/file, pass the
        /// response on to another method for further processing, etc.
        /// </summary>
        private class ReportDownload
        {
            internal long CustomerId { get; set; }
            internal long ReportId { get; set; }
            internal SearchGoogleAdsStreamResponse Response { get; set; }

            public override string ToString()
            {
                return $"Results for report {ReportId} (CID {CustomerId}): " +
                       $"{Response.Results.Count} rows returned.";
            }
        }
    }
}

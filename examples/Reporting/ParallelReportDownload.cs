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

using CommandLine;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Services;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// Shows how to download a set of reports from a list of accounts in parallel. If you need
    /// to obtain a list of accounts, please see the GetAccountHierarchy or
    /// ListAccessibleCustomers examples.";
    /// </summary>
    public class ParallelReportDownload : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="ParallelReportDownload"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer Id.
            /// </summary>
            [Option("customerIds", Required = true, HelpText =
                "The Google Ads customer IDs for which the call is made.")]
            public IEnumerable<long> CustomerIds { get; set; }

            /// <summary>
            /// Optional login customer ID if your access to the CIDs is via a manager account.
            /// </summary>
            [Option("loginCustomerId", Required = false, HelpText =
                "Optional login customer ID if your access to the CIDs is via a manager account.")]
            public long? LoginCustomerId { get; set; }
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
                    // The Google Ads customer IDs for which the call is made.
                    // Add more items to the array as desired.
                    options.CustomerIds = new long[]
                    {
                        long.Parse("INSERT_CUSTOMER_ID_1_HERE"),
                        long.Parse("INSERT_CUSTOMER_ID_2_HERE")
                    };

                    // Optional login customer ID if your access to the CIDs is via a manager
                    // account.
                    options.LoginCustomerId = long.Parse("INSERT_LOGIN_CUSTOMER_ID_HERE");

                    return 0;
                });

            ParallelReportDownload codeExample = new ParallelReportDownload();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerIds.ToArray(),
                options.LoginCustomerId);
        }

        // Defines the Google Ads Query Language (GAQL) query strings to run for each customer ID.
        private readonly Dictionary<string, string> GAQL_QUERY_STRINGS =
            new Dictionary<string, string>()
            {
                {
                    "Campaign Query",
                    @"SELECT campaign.id, metrics.impressions, metrics.clicks
                    FROM campaign
                    WHERE segments.date DURING LAST_30_DAYS"
                },
                {
                    "Ad Group Query",
                    @"SELECT campaign.id, ad_group.id, metrics.impressions, metrics.clicks
                    FROM ad_group
                    WHERE segments.date DURING LAST_30_DAYS"
                }
            };

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Shows how to download a set of reports from a list of accounts in parallel. If you " +
            "need to obtain a list of accounts, please see the GetAccountHierarchy or " +
            "ListAccessibleCustomers examples.";

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
                Services.V7.GoogleAdsService);

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
            ConcurrentBag<Task<bool>> tasks =
                new ConcurrentBag<Task<bool>>();

            // Collection of downloaded responses.
            ConcurrentBag<ReportDownload> responses = new ConcurrentBag<ReportDownload>();

            // IMPORTANT: You should avoid hitting the same customer ID in parallel. There are rate
            // limits at the customer ID level which are much stricter than limits at the developer
            // token level. Hitting these limits frequently enough will significantly reduce
            // throughput as the client library will automatically retry with exponential back-off
            // before failing the request.
            Parallel.ForEach(GAQL_QUERY_STRINGS, query =>
                {
                    Parallel.ForEach(customerIds, customerId =>
                    {
                        Console.WriteLine($"Requesting {query.Key} for CID {customerId}.");

                        // Issue an asynchronous search request and add it to the list of requests
                        // in progress.
                        tasks.Add(DownloadReportAsync(googleAdsService, customerId, query.Key,
                            query.Value, responses));
                    });
                }
            );

            Console.WriteLine($"Awaiting results from {tasks.Count} requests...\n");

            // Proceed only when all requests have completed.
            await Task.WhenAll(tasks);

            // Give a summary report for each successful download.
            foreach (ReportDownload reportDownload in responses)
            {
                Console.WriteLine(reportDownload);
            }
        }

        /// <summary>
        /// Initiates one asynchronous report download.
        /// </summary>
        /// <param name="googleAdsService">The Google Ads service client.</param>
        /// <param name="customerId">The customer ID from which data is requested.</param>
        /// <param name="queryKey">The name of the query to be downloaded.</param>
        /// <param name="queryValue">The query for the download request.</param>
        /// <param name="responses">Collection of all successful report downloads.</param>
        /// <returns>The asynchronous operation.</returns>
        /// <exception cref="GoogleAdsException">Thrown if errors encountered in the execution of
        ///     the request.</exception>
        private Task<bool> DownloadReportAsync(
            GoogleAdsServiceClient googleAdsService, long customerId, string queryKey,
            string queryValue, ConcurrentBag<ReportDownload> responses)
        {
            try
            {
                // Issue an asynchronous download request.
                googleAdsService.SearchStream(
                    customerId.ToString(), queryValue,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        // Store the results.
                        responses.Add(new ReportDownload()
                        {
                            CustomerId = customerId,
                            QueryKey = queryKey,
                            Response = resp
                        });
                    }
                );
                return Task.FromResult(true);
            }
            catch (AggregateException ae)
            {
                Console.WriteLine($"Download failed for {queryKey} and CID {customerId}!");

                GoogleAdsException gae = GoogleAdsException.FromTaskException(ae);

                var download = new ReportDownload()
                {
                    CustomerId = customerId,
                    QueryKey = queryKey,
                    Exception = gae
                };
                if (gae != null)
                {
                    Console.WriteLine($"Message: {gae.Message}");
                    Console.WriteLine($"Failure: {gae.Failure}");
                    Console.WriteLine($"Request ID: {gae.RequestId}");
                    download.Exception = gae;
                }
                else
                {
                    download.Exception = ae;
                }

                responses.Add(download);
                return Task.FromResult(false);
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
            internal string QueryKey { get; set; }
            internal SearchGoogleAdsStreamResponse Response { get; set; }
            internal Exception Exception { get; set; }

            public override string ToString()
            {
                if (Exception != null)
                {
                    return $"Download failed for {QueryKey} and CID {CustomerId}. " +
                        $"Exception: {Exception}";
                }
                else
                {
                    return $"{QueryKey} downloaded for CID {CustomerId}: " +
                        $"{Response.Results.Count} rows returned.";
                }
            }
        }
    }
}

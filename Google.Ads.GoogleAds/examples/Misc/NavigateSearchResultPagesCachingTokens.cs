// Copyright 2022 Google LLC
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
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    /// GoogleAdsService.Search results are paginated but they can only be retrieved in sequence
    /// starting by the first page. More details at
    /// https://developers.google.com/google-ads/api/docs/reporting/paging.
    ///
    /// This code example searches campaigns illustrating how GoogleAdsService.Search result page
    /// tokens can be cached and reused to retrieve previous pages. This is useful when you need
    /// to request pages that were already requested in the past without starting over from the
    /// first page. For example, it can be used to implement an interactive application that
    /// displays a page of results at a time without caching all the results first.
    /// </summary>
    public class NavigateSearchResultPagesCachingTokens : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="NavigateSearchResultPagesCachingTokens"/> example.
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
        /// The maximum number of results to retrieve.
        /// </summary>
        private const long RESULTS_LIMIT = 11;

        /// <summary>
        /// The size of the paginated search result pages.
        /// </summary>
        private const int PAGE_SIZE = 3;

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            NavigateSearchResultPagesCachingTokens codeExample =
                new NavigateSearchResultPagesCachingTokens();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "GoogleAdsService.Search results are paginated but " +
            "they can only be retrieved in sequence starting by the first page. More details " +
            "at https://developers.google.com/google-ads/api/docs/reporting/paging. This code " +
            "example searches campaigns illustrating how GoogleAdsService.Search result page " +
            "tokens can be cached and reused to retrieve previous pages. This is useful when " +
            "you need to request pages that were already requested in the past without starting " +
            "over from the first page. For example, it can be used to implement an interactive " +
            "application that displays a page of results at a time without caching all the " +
            "results first.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V11.GoogleAdsService);

            // The cache of page tokens. The first page's token is always an empty string.
            Dictionary<int, string> pageTokens = new Dictionary<int, string>();
            CacheNextPageToken(pageTokens, null, 0);

            Console.WriteLine("---0. Fetch page #1 to get metadata");

            // Creates a query that retrieves the campaigns.
            string query = $"SELECT campaign.id, campaign.name FROM campaign ORDER BY " +
                $"campaign.name LIMIT {RESULTS_LIMIT}";

            // Issues a paginated search request.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                Query = query,
                CustomerId = customerId.ToString(),
                // Sets the number of results to return per page.
                PageSize = PAGE_SIZE,
                // Requests to return the total results count. This is necessary to determine
                // how many pages of results there are.
                ReturnTotalResultsCount = true
            };

            try
            {
                SearchGoogleAdsResponse response = googleAdsService.Search(request)
                    .AsRawResponses().First();
                CacheNextPageToken(pageTokens, response, 1);

                // Determines the total number of results and prints it.
                // The total results count does not take into consideration the LIMIT clause of
                // the query so we need to find the minimal value between the limit and the total
                // results count.
                long totalNumberOfResults = Math.Min(RESULTS_LIMIT, response.TotalResultsCount);
                Console.WriteLine($"Total number of campaigns found: {totalNumberOfResults}.");

                // Determines the total number of pages and prints it.
                int totalNumberOfPages =
                    (int)Math.Ceiling((double)totalNumberOfResults / PAGE_SIZE);
                Console.WriteLine($"Total number of pages: {totalNumberOfPages}.");
                if (totalNumberOfResults == 0)
                {
                    Console.WriteLine("Could not find any campaigns.");
                    return;
                }

                // Demonstrates how the logic works when iterating pages forward. We select a
                // page that is in the middle of the result set so that only a subset of the page
                // tokens will be cached.
                int middlePageNumber = (int)Math.Ceiling((double)totalNumberOfPages / 2);
                Console.WriteLine($"--- 1. Print results of the page #{middlePageNumber}");
                FetchAndPrintPageResults(googleAdsService, request, middlePageNumber, pageTokens);

                // Demonstrates how the logic works when iterating pages backward with some page
                // tokens that are not already cached.
                Console.WriteLine("--- 2. Print results from the last page to the first");
                for (int i = totalNumberOfPages; i > 0; i--)
                {
                    Console.WriteLine($"--- Printing results for page #{i}");
                    FetchAndPrintPageResults(googleAdsService, request, i, pageTokens);
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

        // [START navigate_search_result_pages_caching_tokens]
        /// <summary>
        /// Fetches and prints the results of a page of a search using a cache of page tokens.
        /// </summary>
        /// <param name="googleAdsService">The Google Ads API Service client.</param>
        /// <param name="request">The request.</param>
        /// <param name="pageNumber">The number of the page to fetch and print results for.</param>
        /// <param name="pageTokens">The cache of page tokens to use and update.</param>
        /// <returns></returns>
        private static void FetchAndPrintPageResults(GoogleAdsServiceClient googleAdsService,
            SearchGoogleAdsRequest request, int pageNumber, Dictionary<int, string> pageTokens)
        {
            int currentPageNumber = pageNumber;

            // There is no need to fetch the pages we already know the page tokens for.
            if (pageTokens.ContainsKey(pageNumber - 1))
            {
                Console.WriteLine("The token of the requested page was cached, we will use it " +
                    "to get the results.");
                currentPageNumber = pageNumber;
            }
            else
            {
                Console.WriteLine("The token of the requested page was never cached, we will " +
                    $"use the closest page we know the token for (page #{pageNumber}) and " +
                    $"sequentially get pages from there.");
                currentPageNumber = pageNumber;
                while (!pageTokens.ContainsKey(currentPageNumber))
                {
                    currentPageNumber--;
                }
            }

            SearchGoogleAdsResponse response = null;
            // Fetches next pages in sequence and caches their tokens until the requested page
            // results are returned.
            while (currentPageNumber <= pageNumber)
            {
                // Fetches the next page.
                Console.WriteLine($"Fetching page #{currentPageNumber}...");
                request.PageToken = pageTokens[currentPageNumber - 1];
                response = googleAdsService.Search(request)
                    .AsRawResponses().First();
                CacheNextPageToken(pageTokens, response, currentPageNumber);
                currentPageNumber++;
            }

            // Prints the results of the requested page.
            Console.WriteLine($"Printing results found for the page #{pageNumber}");
            foreach (GoogleAdsRow row in response.Results)
            {
                Campaign c = row.Campaign;
                Console.WriteLine($" - Campaign with ID {c.Id} and name '{c.Name}'");
            }
        }

        // [END navigate_search_result_pages_caching_tokens]

        /// <summary>
        /// Updates the cache of page tokens based on a page that was retrieved.
        /// </summary>
        /// <param name="pageTokens">The cache of page tokens to update.</param>
        /// <param name="response">The response that was retrieved.</param>
        /// <param name="pageNumber">The number of the page that was retrieved.</param>
        /// <returns></returns>
        private static void CacheNextPageToken(Dictionary<int, string> pageTokens,
            SearchGoogleAdsResponse response, int pageNumber)
        {
            if (pageNumber == 0)
            {
                pageTokens[0] = "";
                return;
            }
            if (string.IsNullOrEmpty(response.NextPageToken) || pageTokens.ContainsKey(pageNumber))
            {
                return;
            }
            // Updates the cache with the next page token if it is not set yet.
            pageTokens[pageNumber] = response.NextPageToken;
            Console.WriteLine($"Cached token for page #{pageNumber + 1}.");
        }
    }
}
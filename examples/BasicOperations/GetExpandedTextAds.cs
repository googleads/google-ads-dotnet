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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V8.Common;
using Google.Ads.GoogleAds.V8.Errors;
using Google.Ads.GoogleAds.V8.Resources;
using Google.Ads.GoogleAds.V8.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V8
{
    /// <summary>
    /// This code example gets expanded text ads.
    /// </summary>
    public class GetExpandedTextAds : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetExpandedTextAds"/> example.
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
            /// Optional: ID of the ad group to restrict search to.
            /// </summary>
            [Option("adGroupId", Required = false, HelpText =
                "Optional: ID of the ad group to restrict search to.")]
            public long? AdGroupId { get; set; }
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

                    // Optional: ID of the ad group to restrict search to.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    return 0;
                });

            GetExpandedTextAds codeExample = new GetExpandedTextAds();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.AdGroupId);
        }

        /// <summary>
        /// The page size to be used by default.
        /// </summary>
        private const int PAGE_SIZE = 1_000;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This example gets expanded text ads.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">Optional: ID of the ad group to restrict search to.</param>
        public void Run(GoogleAdsClient client, long customerId, long? adGroupId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V8.GoogleAdsService);

            string searchQuery =
                $@"SELECT
                 ad_group.id,
                 ad_group_ad.ad.id,
                 ad_group_ad.ad.expanded_text_ad.headline_part1,
                 ad_group_ad.ad.expanded_text_ad.headline_part2,
                 ad_group_ad.status
             FROM ad_group_ad
             WHERE
                 ad_group_ad.ad.type = EXPANDED_TEXT_AD ";

            if (adGroupId != null)
            {
                searchQuery += $" AND ad_group.id = {adGroupId}";
            }

            // Create a request that will retrieve all ads using pages of the specified page size.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                PageSize = PAGE_SIZE,
                Query = searchQuery
            };

            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                // Iterate over all rows in all pages and prints the requested field values for
                // the ad in each row.
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    Ad ad = googleAdsRow.AdGroupAd.Ad;
                    ExpandedTextAdInfo expandedTextAdInfo = ad.ExpandedTextAd;
                    Console.WriteLine("Expanded text ad with ID {0}, status '{1}', and headline " +
                        "'{2} - {3}' was found in ad group with ID {4}.",
                        ad.Id, googleAdsRow.AdGroupAd.Status, expandedTextAdInfo.HeadlinePart1,
                        expandedTextAdInfo.HeadlinePart2, googleAdsRow.AdGroup.Id);
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

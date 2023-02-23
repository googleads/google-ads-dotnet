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

using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V13.Common;
using Google.Ads.GoogleAds.V13.Errors;
using Google.Ads.GoogleAds.V13.Resources;
using Google.Ads.GoogleAds.V13.Services;
using Google.Api.Gax;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V13
{
    /// <summary>
    /// This code example gets non-removed responsive search ads in a specified ad group.
    /// To add responsive search ads, run AddResponsiveSearchAd.cs. To get ad groups, run
    /// GetAdGroups.cs.
    /// </summary>
    public class GetResponsiveSearchAds : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetResponsiveSearchAds"/> example.
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
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GetResponsiveSearchAds codeExample = new GetResponsiveSearchAds();
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
        public override string Description =>
            "This code example gets non-removed responsive search ads in a specified ad group. " +
            "To add responsive search ads, run AddResponsiveSearchAd.cs. To get ad groups, run " +
            "GetAdGroups.cs.";

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
                Services.V13.GoogleAdsService);

            string searchQuery =
                $@"SELECT
                 ad_group.id,
                 ad_group_ad.ad.id,
                 ad_group_ad.ad.responsive_search_ad.headlines,
                 ad_group_ad.ad.responsive_search_ad.descriptions,
                 ad_group_ad.status
            FROM ad_group_ad
            WHERE
                ad_group_ad.ad.type = RESPONSIVE_SEARCH_AD
                AND ad_group_ad.status != 'REMOVED'";

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

                // Iterates over all rows in all pages and prints the requested field values for
                // the ad in each row.
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    Ad ad = googleAdsRow.AdGroupAd.Ad;

                    Console.WriteLine($"Responsive search ad with resource name '{ad.ResourceName}'," +
                        $"status '{googleAdsRow.AdGroupAd.Status}' was found.");
                    // Prints the ad text asset detail.
                    ResponsiveSearchAdInfo responsiveSearchAdInfo = ad.ResponsiveSearchAd;
                    Console.WriteLine("Headlines:{0},\nDescriptions:{1}",
                        FormatAdTextAssetsAsString(responsiveSearchAdInfo.Headlines),
                        FormatAdTextAssetsAsString(responsiveSearchAdInfo.Descriptions));
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

        /// <summary>Formats the text assets to a string format for display.</summary>
        /// <param name="adTextAssets">The ad text assets.</param>
        /// <returns>The string representation of the provided list of AdTextAsset
        /// objects.</returns>
        private static string FormatAdTextAssetsAsString(RepeatedField<AdTextAsset> adTextAssets)
        {
            return string.Join(",", adTextAssets.Select(delegate (AdTextAsset asset)
            {
                return asset.Text + " pinned to " + asset.PinnedField;
            }).ToArray());
        }
    }
}

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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;
using Google.Api.Gax;
using System;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example gets all image assets.
    /// </summary>
    public class GetAllImageAssets : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetAllImageAssets codeExample = new GetAllImageAssets();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            int customerId = int.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example gets all image assets.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V6.GoogleAdsService);

            // Creates the search query.
            string searchQuery = "SELECT asset.name, asset.image_asset.file_size, " +
                "asset.image_asset.full_size.width_pixels, " +
                "asset.image_asset.full_size.height_pixels, " +
                "asset.image_asset.full_size.url FROM asset WHERE asset.type = 'IMAGE'";

            // Creates the request.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = searchQuery,
                ReturnTotalResultsCount = true
            };

            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                long totalImageAssetCount = searchPagedResponse.AsRawResponses()
                    .First().TotalResultsCount;

                foreach (GoogleAdsRow row in searchPagedResponse)
                {
                    Asset asset = row.Asset;
                    ImageAsset imageAsset = asset.ImageAsset;
                    // Displays the results.
                    Console.WriteLine($"Image with name '{asset.Name}', file size " +
                        $"{imageAsset.FileSize} bytes, width {imageAsset.FullSize.WidthPixels}px," +
                        $" height {imageAsset.FullSize.HeightPixels}px, and url " +
                        $"'{imageAsset.FullSize.Url}' found.");
                }

                Console.WriteLine($"Total image assets found: {totalImageAssetCount}");
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

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
using Google.Ads.GoogleAds.V3.Common;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V3
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
        public override string Description
        {
            get
            {
                return "This code example gets all image assets.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V3.GoogleAdsService);

            // Creates the search query.
            string searchQuery = "SELECT asset.name, asset.image_asset.file_size, " +
                "asset.image_asset.full_size.width_pixels, " +
                "asset.image_asset.full_size.height_pixels, " +
                "asset.image_asset.full_size.url FROM asset WHERE asset.type = 'IMAGE'";

            // Creates the request.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = searchQuery
            };

            try
            {
                // Issues the search request and prints the results.
                int count = 0;
                foreach (GoogleAdsRow row in googleAdsService.Search(request))
                {
                    Asset asset = row.Asset;
                    ImageAsset imageAsset = asset.ImageAsset;
                    // Displays the results.
                    Console.WriteLine($"Image with name '{asset.Name}', file size " +
                        $"{imageAsset.FileSize} bytes, width {imageAsset.FullSize.WidthPixels}px," +
                        $" height {imageAsset.FullSize.HeightPixels}px, and url " +
                        $"'{imageAsset.FullSize.Url}' found.");
                    count++;
                }
                if (count == 0)
                {
                    // Displays a response if no images are found.
                    if (count == 0)
                    {
                        Console.WriteLine("No image assets found.");
                    }
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
            }
        }
    }
}

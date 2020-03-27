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
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V3.Common;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;
using Google.Protobuf;
using System;
using System.Linq;
using static Google.Ads.GoogleAds.V3.Enums.AssetTypeEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.MimeTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example uploads an image asset. To get image assets, run GetAllImageAssets.cs.
    /// </summary>
    public class UploadImageAsset : ExampleBase
    {
        /// <summary>
        /// The image URL to upload as asset.
        /// </summary>
        private const string IMAGE_URL = "https://goo.gl/3b9Wfh";

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UploadImageAsset codeExample = new UploadImageAsset();
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
                return "This code example uploads an image asset. To get image assets, run " +
                    "GetAllImageAssets.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the AssetServiceClient.
            AssetServiceClient assetService =
                client.GetService(Services.V3.AssetService);

            // Creates an image content.
            byte[] imageContent = MediaUtilities.GetAssetDataFromUrl(IMAGE_URL, client.Config);

            // Creates an image asset.
            ImageAsset imageAsset = new ImageAsset()
            {
                Data = ByteString.CopyFrom(imageContent),
                FileSize = imageContent.Length,
                MimeType = MimeType.ImageJpeg,
                FullSize = new ImageDimension()
                {
                    HeightPixels = 315,
                    WidthPixels = 600,
                    Url = IMAGE_URL
                }
            };

            // Creates an asset.
            Asset asset = new Asset()
            {
                // Optional: Provide a unique friendly name to identify your asset.
                // If you specify the name field, then both the asset name and the image being
                // uploaded should be unique, and should not match another ACTIVE asset in this
                // customer account.
                // Name = 'Jupiter Trip #' + ExampleUtilities.GetRandomString(),
                Type = AssetType.Image,
                ImageAsset = imageAsset
            };

            // Creates an asset operation.
            AssetOperation operation = new AssetOperation()
            {
                Create = asset
            };

            try
            {
                // Issues a mutate request to add the asset.
                MutateAssetsResponse response =
                    assetService.MutateAssets(customerId.ToString(), new[] { operation });

                // Displays the result.
                Console.WriteLine($"Image asset with resource name: " +
                    $"'{response.Results.First().ResourceName}' is created.");
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

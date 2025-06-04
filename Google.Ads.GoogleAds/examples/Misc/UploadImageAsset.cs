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
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V20.Common;
using Google.Ads.GoogleAds.V20.Errors;
using Google.Ads.GoogleAds.V20.Resources;
using Google.Ads.GoogleAds.V20.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V20.Enums.AssetTypeEnum.Types;
using static Google.Ads.GoogleAds.V20.Enums.MimeTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V20
{
    /// <summary>
    /// This code example uploads an image asset. To get image assets, run GetAllImageAssets.cs.
    /// </summary>
    public class UploadImageAsset : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadImageAsset"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UploadImageAsset codeExample = new UploadImageAsset();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// The image URL to upload as asset.
        /// </summary>
        private const string IMAGE_URL = "https://gaagl.page.link/Eit5";

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example uploads an image asset. To get image assets, run " +
            "GetAllImageAssets.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        // [START upload_image_asset]
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the AssetServiceClient.
            AssetServiceClient assetService =
                client.GetService(Services.V20.AssetService);

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
                ImageAsset = imageAsset,
                // Provide a unique friendly name to identify your asset.
                // When there is an existing image asset with the same content but a different
                // name, the new name will be dropped silently.
                Name = "Marketing Image"
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
        // [END upload_image_asset]
    }
}

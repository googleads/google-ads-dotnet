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
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Resources;
using Google.Ads.GoogleAds.V14.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V14.Enums.MediaTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This code example uploads an image.
    /// </summary>
    /// <remarks>This code example uses version v14 of the Google Ads API. Google Ads is migrating
    /// from individual media files to assets, and version v15 of the API removed support for
    /// MediaFileService as part of this migration. Once your Ads account is migrated, this code
    /// example will stop working, and you should use UploadImageAsset.cs instead. This code
    /// example will be removed once the migration completes. See
    /// https://ads-developers.googleblog.com/2023/07/image-and-location-auto-migration.html for
    /// more details.
    /// </remarks>
    public class UploadImage : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadImage"/> example.
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

            UploadImage codeExample = new UploadImage();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example uploads an image.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the MediaFileServiceClient.
            MediaFileServiceClient mediaFileService =
                client.GetService(Services.V14.MediaFileService);

            const string URL = "https://gaagl.page.link/Eit5";

            MediaFile file = new MediaFile()
            {
                Name = "Ad Image",
                Type = MediaType.Image,
                SourceUrl = URL,
                Image = new MediaImage()
                {
                    Data = ByteString.CopyFrom(MediaUtilities.GetAssetDataFromUrl(
                        URL, client.Config))
                }
            };
            MediaFileOperation operation = new MediaFileOperation()
            {
                Create = file
            };

            try
            {
                MutateMediaFilesResponse response =
                    mediaFileService.MutateMediaFiles(customerId.ToString(), new[] { operation });
                Console.WriteLine($"Added {response.Results} images:");
                foreach (MutateMediaFileResult result in response.Results)
                {
                    Console.WriteLine(result.ResourceName);
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

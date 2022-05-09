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
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V10.Enums.MediaTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example uploads an image.
    /// </summary>
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
            Options options = new Options();
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    return 0;
                });

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
                client.GetService(Services.V10.MediaFileService);

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

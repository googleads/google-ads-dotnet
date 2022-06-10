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
using Google.Ads.GoogleAds.V11.Errors;
using Google.Ads.GoogleAds.V11.Resources;
using Google.Ads.GoogleAds.V11.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V11.Enums.MediaTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V11
{
    /// <summary>
    /// This code example uploads an HTML5 zip file as a media bundle.
    /// </summary>
    public class UploadMediaBundle : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadMediaBundle"/> example.
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

            UploadMediaBundle codeExample = new UploadMediaBundle();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// The asset bundle to upload.
        /// </summary>
        private const string BUNDLE_URL = "https://gaagl.page.link/ib87";

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example uploads an HTML5 zip file as a media bundle.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the MediaFileServiceClient.
            MediaFileServiceClient mediaFileService = client.GetService(
                Services.V11.MediaFileService);

            // Creates an HTML5 zip file media bundle content.
            byte[] bundleContent = MediaUtilities.GetAssetDataFromUrl(BUNDLE_URL, client.Config);

            // Creates a media file.
            MediaFile mediaFile = new MediaFile()
            {
                Name = "Ad Media Bundle",
                Type = MediaType.MediaBundle,
                MediaBundle = new MediaBundle()
                {
                    Data = ByteString.CopyFrom(bundleContent),
                }
            };

            // Creates a media file operation.
            MediaFileOperation operation = new MediaFileOperation()
            {
                Create = mediaFile
            };

            try
            {
                // Issues a mutate request to add the media file.
                MutateMediaFilesResponse response =
                    mediaFileService.MutateMediaFiles(customerId.ToString(), new[] { operation });

                // Displays the result.
                Console.WriteLine($"The media bundle with resource name " +
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

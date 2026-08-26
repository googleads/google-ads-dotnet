// Copyright 2026 Google LLC
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
using Google.Ads.GoogleAds.V25.Errors;
using Google.Ads.GoogleAds.V25.Resources;
using Google.Ads.GoogleAds.V25.Services;
using Google.Api.Gax.Grpc.Rest;
using System;
using System.IO;
using static Google.Ads.GoogleAds.V25.Enums.YouTubeVideoPrivacyEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V25
{
    /// <summary>
    /// This code example illustrates how to upload videos to YouTube.
    /// </summary>
    public class UploadVideo : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadVideo"/> example.
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
            /// The path to a video file to upload to YouTube.
            /// </summary>
            [Option("videoFilePath", Required = true, HelpText =
                "The path to a video file to upload to YouTube.")]
            public string VideoFilePath { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UploadVideo codeExample = new UploadVideo();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.VideoFilePath);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example illustrates how to upload videos to YouTube.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="videoFilePath">The path to a video file to upload to YouTube.</param>
        public void Run(GoogleAdsClient client, long customerId, string videoFilePath)
        {
            try
            {
                // [START upload_video_1]
                YouTubeVideoUploadServiceClient ytService = client.GetService(
                    Services.V25.YouTubeVideoUploadService);

                CreateYouTubeVideoUploadRequest createUploadRequest =
                    new CreateYouTubeVideoUploadRequest()
                    {
                        CustomerId = customerId.ToString(),
                        YouTubeVideoUpload = new YouTubeVideoUpload()
                        {
                            VideoTitle = "Test Video",
                            VideoDescription = "Test Video Description",
                            VideoPrivacy = YouTubeVideoPrivacy.Unlisted
                        }
                    };

                string videoUploadResourceName;
                using (FileStream stream = File.OpenRead(videoFilePath))
                {
                    ResumableUploadSession<CreateYouTubeVideoUploadRequest, CreateYouTubeVideoUploadResponse> session =
                        ytService.CreateYouTubeVideoUpload();
                    CreateYouTubeVideoUploadResponse response =
                        session.BeginUploadAsync(createUploadRequest, stream).Result;

                    videoUploadResourceName = response.ResourceName;
                    Console.WriteLine($"Created YouTube video upload: {videoUploadResourceName}");
                }
                // [END upload_video_1]

                // [START upload_video_3]
                // Retrieve the metadata of the newly uploaded video.
                string query = $@"
                    SELECT
                      you_tube_video_upload.resource_name,
                      you_tube_video_upload.video_id,
                      you_tube_video_upload.state
                    FROM you_tube_video_upload
                    WHERE you_tube_video_upload.resource_name = '{videoUploadResourceName}'";

                GoogleAdsServiceClient gaService = client.GetService(
                    Services.V25.GoogleAdsService);

                gaService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow row in resp.Results)
                        {
                            Console.WriteLine(
                                $"Video with ID {row.YouTubeVideoUpload.VideoId} was found in " +
                                $"state {row.YouTubeVideoUpload.State}.");
                        }
                    }
                );
                // [END upload_video_3]
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

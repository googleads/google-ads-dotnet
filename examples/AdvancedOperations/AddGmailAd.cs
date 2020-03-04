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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V3.Common;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V3.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.DeviceEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.MediaTypeEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.MimeTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example adds a Gmail ad to a given ad group. The ad group's campaign needs to
    /// have an AdvertisingChannelType of DISPLAY and AdvertisingChannelSubType of
    /// DISPLAY_GMAIL_AD.
    /// </summary>
    public class AddGmailAd : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddGmailAd codeExample = new AddGmailAd();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the ad group to which GMail ads are added.
            long adGroupId = long.Parse("INSERT_ADGROUP_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example adds a Gmail ad to a given ad group. The ad group's " +
                    "campaign needs to have an AdvertisingChannelType of DISPLAY and " +
                    "AdvertisingChannelSubType of DISPLAY_GMAIL_AD.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group to which GMail ads are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            try
            {
                Dictionary<string, string> mediaFiles = AddMediaFiles(client, customerId);
                AddAd(client, customerId, adGroupId, mediaFiles);
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
            }
        }


        /// <summary>
        /// Adds the media files.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>A map with key as image name, and value as image bytes.</returns>
        private Dictionary<string, string> AddMediaFiles(GoogleAdsClient client, long customerId)
        {
            // Get the MediaFileService.
            MediaFileServiceClient mediaFileService =
                client.GetService(Services.V3.MediaFileService);

            // Creates a bytes array from the logo image data.
            byte[] logoImageData = MediaUtilities.GetAssetDataFromUrl(
                "https://goo.gl/mtt54n", client.Config);

            // Creates the logo image.
            MediaFile mediaFileLogo = new MediaFile()
            {
                Type = MediaType.Image,
                Image = new MediaImage()
                {
                    Data = ByteString.CopyFrom(logoImageData)
                },
                MimeType = MimeType.ImagePng
            };

            // Creates the operation for the logo image.
            MediaFileOperation mediaFileLogoOperation = new MediaFileOperation()
            {
                Create = mediaFileLogo
            };

            // Creates a bytes array from the marketing image data.
            byte[] marketingImageData = MediaUtilities.GetAssetDataFromUrl(
                "https://goo.gl/3b9Wfh", client.Config);

            // Creates the marketing image.
            MediaFile mediaFileMarketing = new MediaFile()
            {
                Type = MediaType.Image,
                Image = new MediaImage()
                {
                    Data = ByteString.CopyFrom(marketingImageData)
                },
                MimeType = MimeType.ImageJpeg
            };

            // Creates the operation for the marketing image.
            MediaFileOperation mediaFileMarketingOperation = new MediaFileOperation()
            {
                Create = mediaFileMarketing
            };

            // Adds the media files.
            MutateMediaFilesResponse response =
                mediaFileService.MutateMediaFiles(customerId.ToString(),
                    new[] { mediaFileLogoOperation, mediaFileMarketingOperation });

            // Display the results.
            foreach (MutateMediaFileResult result in response.Results)
            {
                Console.WriteLine($"Created media file with resource name " +
                    $"'{result.ResourceName}'.");
            }

            return new Dictionary<string, string>()
            {
                { "logoResourceName", response.Results[0].ResourceName},
                { "marketingImageResourceName", response.Results[1].ResourceName},
            };
        }

        /// <summary>
        /// Adds the gmail ad.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group to which ads are added.</param>
        /// <param name="mediaFiles">The media files.</param>
        private void AddAd(GoogleAdsClient client, long customerId, long adGroupId,
            Dictionary<string, string> mediaFiles)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdService =
                client.GetService(Services.V3.AdGroupAdService);

            // Creates the Gmail ad info.
            GmailAdInfo gmailAdInfo = new GmailAdInfo()
            {
                Teaser = new GmailTeaser()
                {
                    Headline = "Dream",
                    Description = "Create your own adventure",
                    BusinessName = "Interplanetary Ships",
                    LogoImage = mediaFiles["logoResourceName"]
                },
                MarketingImage = mediaFiles["marketingImageResourceName"],
                MarketingImageHeadline = "Travel",
                MarketingImageDescription = "Take to the skies!"
            };

            // Creates the ad.
            Ad ad = new Ad()
            {
                Name = "Gmail Ad #" + ExampleUtilities.GetRandomString(),
                FinalUrls = { "http://www.example.com" },
                GmailAd = gmailAdInfo
            };

            // Creates the ad group ad.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                Ad = ad,
                Status = AdGroupAdStatus.Paused,
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId)
            };

            // Create the operation.
            AdGroupAdOperation operation = new AdGroupAdOperation()
            {
                Create = adGroupAd
            };


            // Create the ad group ad.
            MutateAdGroupAdsResponse response =
                adGroupAdService.MutateAdGroupAds(customerId.ToString(), new[] { operation });

            // Display the results.
            Console.WriteLine($"Created ad group ad with resource name " +
                $"'{response.Results[0].ResourceName}'.");
        }
    }
}
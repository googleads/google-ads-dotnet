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
using Google.Ads.GoogleAds.V10.Common;
using Google.Ads.GoogleAds.V10.Enums;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V10.Enums.DisplayUploadProductTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example adds a display upload ad to a given ad group. To get ad groups,
    /// run GetAdGroups.cs.
    /// </summary>
    public class AddDisplayUploadAd : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddDisplayUploadAd"/> example.
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
            /// The ID of the ad group to which the new ad will be added.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "The ID of the ad group to which the new ad will be added.")]
            public long AdGroupId { get; set; }
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
                    // The Google Ads customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // The ID of the ad group to which the new ad will be added.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    return 0;
                });

            AddDisplayUploadAd codeExample = new AddDisplayUploadAd();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a display upload ad to a given ad group. To get ad groups, " +
            "run GetAdGroups.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ID of the ad group to which the new ad will be
        ///     added.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            try
            {
                // There are several types of display upload ads. For this example, we will create
                // an HTML5 upload ad, which requires a media bundle.
                // This feature is only available to allowlisted accounts.
                // See https://support.google.com/google-ads/answer/1722096 for more details.
                // The DisplayUploadProductType field lists the available display upload types:
                // https://developers.google.com/google-ads/api/reference/rpc/latest/DisplayUploadAdInfo
                // Creates a new media bundle asset and returns the resource name.
                string adAssetResourceName = CreateMediaBundleAsset(client, customerId);

                // Creates a new display upload ad and associates it with the specified ad group.
                CreateDisplayUploadAdGroupAd(client, customerId, adGroupId, adAssetResourceName);
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

        /// <summary>
        /// Creates a media bundle from the assets in a zip file. The zip file contains the
        /// HTML5 components.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The string resource name of the newly uploaded media bundle.</returns>
        private string CreateMediaBundleAsset(GoogleAdsClient client, long customerId)
        {
            // Gets the AssetService.
            AssetServiceClient assetServiceClient = client.GetService(Services.V10.AssetService);

            // The HTML5 zip file contains all the HTML, CSS, and images needed for the
            // HTML5 ad. For help on creating an HTML5 zip file, check out Google Web
            // Designer (https://www.google.com/webdesigner/).
            byte[] html5Zip = MediaUtilities.GetAssetDataFromUrl("https://gaagl.page.link/ib87",
                client.Config);

            // Creates the media bundle asset.
            Asset mediaBundleAsset = new Asset()
            {
                Type = AssetTypeEnum.Types.AssetType.MediaBundle,
                MediaBundleAsset = new MediaBundleAsset()
                {
                    Data = ByteString.CopyFrom(html5Zip)
                },
                Name = "Ad Media Bundle"
            };

            // Creates the asset operation.
            AssetOperation operation = new AssetOperation()
            {
                Create = mediaBundleAsset
            };

            // Adds the asset to the client account.
            MutateAssetsResponse response = assetServiceClient.MutateAssets(customerId.ToString(),
                new[] { operation });

            // Displays the resulting resource name.
            string uploadedAssetResourceName = response.Results.First().ResourceName;
            Console.WriteLine($"Uploaded media bundle: {uploadedAssetResourceName}");

            return uploadedAssetResourceName;
        }

        /// <summary>
        /// Creates a new HTML5 display upload ad and adds it to the specified ad group.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ID of the ad group to which the new ad will be
        ///     added.</param>
        /// <param name="adAssetResourceName">The resource name of the media bundle containing
        ///     the HTML5 components.</param>
        private void CreateDisplayUploadAdGroupAd(GoogleAdsClient client, long customerId,
            long adGroupId, string adAssetResourceName)
        {
            // Get the AdGroupAdService.
            AdGroupAdServiceClient adGroupAdServiceClient =
                client.GetService(Services.V10.AdGroupAdService);

            // Creates the ad with the required fields.
            Ad displayUploadAd = new Ad()
            {
                Name = "Ad for HTML5",
                FinalUrls = { "http://example.com/html5" },
                // Exactly one ad data field must be included to specify the ad type. See
                // https://developers.google.com/google-ads/api/reference/rpc/latest/Ad for the
                // full list of available types.
                DisplayUploadAd = new DisplayUploadAdInfo()
                {
                    DisplayUploadProductType = DisplayUploadProductType.Html5UploadAd,
                    MediaBundle = new AdMediaBundleAsset()
                    {
                        Asset = adAssetResourceName
                    }
                }
            };

            // Creates an ad group ad for the new ad.
            AdGroupAd adGroupAd = new AdGroupAd()
            {
                Ad = displayUploadAd,
                Status = AdGroupAdStatusEnum.Types.AdGroupAdStatus.Paused,
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
            };

            // Creates the ad group ad operation.
            AdGroupAdOperation operation = new AdGroupAdOperation()
            {
                Create = adGroupAd
            };

            // Adds the ad group ad to the client account.
            MutateAdGroupAdsResponse response = adGroupAdServiceClient.MutateAdGroupAds
                (customerId.ToString(), new[] { operation });

            // Displays the resulting ad group ad's resource name.
            Console.WriteLine($"Created new ad group ad{response.Results.First().ResourceName}.");
        }
    }
}

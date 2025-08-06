// Copyright 2022 Google LLC
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
using Google.Ads.GoogleAds.V21.Common;
using Google.Ads.GoogleAds.V21.Errors;
using Google.Ads.GoogleAds.V21.Resources;
using Google.Ads.GoogleAds.V21.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V21.Enums.AssetSetTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V21
{
    /// <summary>
    /// This code example adds an asset for use in dynamic remarketing and links it to a campaign.
    /// </summary>
    public class AddDynamicRemarketingAsset : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddDynamicRemarketingAsset"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// ID of the campaign to which the asset is linked.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "ID of the campaign to which the asset is linked. Specify a campaign type which " +
                "supports dynamic remarketing, such as Display.")]
            public long CampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddDynamicRemarketingAsset codeExample = new AddDynamicRemarketingAsset();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds an asset for use in dynamic remarketing and links it to " +
            "a campaign.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="campaignId">ID of the campaign to which the asset is linked. Specify a
        /// campaign type which supports dynamic remarketing, such as Display.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            try
            {
                // Creates an Asset.
                string assetResourceName = CreateAsset(client, customerId);
                // Creates an AssetSet - this is a collection of assets that can be associated
                // with a campaign.
                // Note: do not confuse this with an AssetGroup. An AssetGroup replaces AdGroups
                // in some types of campaigns.
                string assetSetResourceName = CreateAssetSet(client, customerId);
                // Adds the Asset to the AssetSet.
                AddAssetsToAssetSet(client, customerId, assetResourceName, assetSetResourceName);
                // Finally links the AssetSet to the Campaign.
                LinkAssetSetToCampaign(client, customerId, campaignId, assetSetResourceName);
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

        // [START add_asset]
        /// <summary>
        /// Creates an Asset to use in dynamic remarketing.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <returns>The resource name of the newly created asset.</returns>
        private string CreateAsset(GoogleAdsClient client, long customerId)
        {
            AssetServiceClient assetService = client.GetService(Services.V21.AssetService);

            // Creates a DynamicEducationAsset.
            // See https://support.google.com/google-ads/answer/6053288?#zippy=%2Ceducation for a
            // detailed explanation of the field format.
            DynamicEducationAsset educationAsset = new DynamicEducationAsset()
            {
                // Defines meta-information about the school and program.
                SchoolName = "The University of Unknown",
                Address = "Building 1, New York, 12345, USA",
                ProgramName = "BSc. Computer Science",
                Subject = "Computer Science",
                ProgramDescription = "Slinging code for fun and profit!",
                // Sets up the program ID which is the ID that should be specified in
                // the tracking pixel.
                ProgramId = "bsc-cs-uofu",
                // Sets up the location ID which may additionally be specified in the
                // tracking pixel.
                LocationId = "nyc",
                ImageUrl = "https://gaagl.page.link/Eit5",
                AndroidAppLink = "android-app://com.example.android/http/example.com/gizmos?1234",
                IosAppLink = "exampleApp://content/page",
                IosAppStoreId = 123L
            };
            Asset asset = new Asset()
            {
                DynamicEducationAsset = educationAsset,
                // The final_urls list must not be empty
                FinalUrls = { "https://www.example.com" }
            };

            // Creates an operation to add the asset.
            AssetOperation operation = new AssetOperation()
            {
                Create = asset
            };

            // Sends the mutate request.
            MutateAssetsResponse response =
                assetService.MutateAssets(customerId.ToString(), new[] { operation });
            // Prints some information about the response.
            string resourceName = response.Results[0].ResourceName;
            Console.Write($"Created a dynamic education asset with resource name {resourceName}.");
            return resourceName;
        }
        // [END add_asset]

        // [START add_asset_set]
        /// <summary>
        /// Creates the asset set.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <returns>The resource name of the asset set.</returns>
        private string CreateAssetSet(GoogleAdsClient client, long customerId)
        {
            AssetSetServiceClient assetSetService = client.GetService(
                Services.V21.AssetSetService);

            // Creates an AssetSet which will be used to link the dynamic remarketing assets
            // to a campaign.
            AssetSet assetSet = new AssetSet()
            {
                Name = "My dynamic remarketing assets " + ExampleUtilities.GetRandomString(),
                Type = AssetSetType.DynamicEducation
            };

            // Creates an operation to add the link.
            AssetSetOperation operation = new AssetSetOperation()
            {
                Create = assetSet
            };
            // Sends the mutate request.
            MutateAssetSetsResponse response = assetSetService.MutateAssetSets(
                customerId.ToString(), new[] { operation });
            // Prints some information about the response.
            string resourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Created asset set with resource name {resourceName}.");
            return resourceName;
        }
        // [END add_asset_set]

        // [START add_asset_set_asset]
        /// <summary>
        /// Adds an Asset to an AssetSet by creating an AssetSetAsset link.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="assetResourceName">Name of the asset resource.</param>
        /// <param name="assetSetResourceName">Name of the asset set resource.</param>
        private void AddAssetsToAssetSet(GoogleAdsClient client, long customerId,
            string assetResourceName, string assetSetResourceName)
        {
            AssetSetAssetServiceClient assetSetAssetService = client.GetService(
                Services.V21.AssetSetAssetService);

            AssetSetAsset assetSetAsset = new AssetSetAsset()
            {
                Asset = assetResourceName,
                AssetSet = assetSetResourceName
            };

            // Creates an operation to add the link.
            AssetSetAssetOperation operation = new AssetSetAssetOperation()
            {
                Create = assetSetAsset
            };
            // Sends the mutate request.
            // Note this is the point that the API will enforce uniqueness of the
            // DynamicEducationAsset.program_id field. You can have any number of
            // assets with the same program_id, however, only one Asset is allowed
            // per AssetSet with the same program ID.
            MutateAssetSetAssetsResponse response =
                assetSetAssetService.MutateAssetSetAssets(
                    customerId.ToString(), new[] { operation });
            // Prints some information about the response.
            string resourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Created AssetSetAsset link with resource name {resourceName}.");
        }
        // [END add_asset_set_asset]

        // [START add_campaign_asset_set]
        /// <summary>
        /// Links an AssetSet to Campaign by creating a CampaignAssetSet.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="campaignId">ID of the campaign to which the asset is linked. Specify a
        /// campaign type which supports dynamic remarketing, such as Display.</param>
        /// <param name="assetSetResourceName">Name of the asset set resource.</param>
        private void LinkAssetSetToCampaign(GoogleAdsClient client, long customerId,
            long campaignId, string assetSetResourceName)
        {
            CampaignAssetSetServiceClient campaignAssetSetService = client.GetService(
                Services.V21.CampaignAssetSetService);

            // Creates a CampaignAssetSet representing the link between an AssetSet and a Campaign.
            CampaignAssetSet campaignAssetSet = new CampaignAssetSet()
            {
                Campaign = ResourceNames.Campaign(customerId, campaignId),
                AssetSet = assetSetResourceName
            };

            // Creates an operation to add the CampaignAssetSet.
            CampaignAssetSetOperation operation = new CampaignAssetSetOperation()
            {
                Create = campaignAssetSet
            };

            // Issues the mutate request.
            MutateCampaignAssetSetsResponse response =
                campaignAssetSetService.MutateCampaignAssetSets(
                    customerId.ToString(), new[] { operation });
            string resourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Created a CampaignAssetSet with resource name {resourceName}.");
        }
        // [END add_campaign_asset_set]
    }
}
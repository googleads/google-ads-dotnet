// Copyright 2021 Google LLC
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
using Google.Ads.GoogleAds.V19.Common;
using Google.Ads.GoogleAds.V19.Errors;
using Google.Ads.GoogleAds.V19.Resources;
using Google.Ads.GoogleAds.V19.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V19.Enums.AssetFieldTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V19
{
    /// <summary>
    /// This code example adds sitelinks to a campaign using assets. Run AddCampaigns.cs to
    /// create a campaign.
    /// </summary>
    public class AddSitelinks : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddSitelinks"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// ID of the campaign to which sitelinks are added.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "ID of the campaign to which sitelinks are added.")]
            public long CampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddSitelinks codeExample = new AddSitelinks();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds sitelinks to a campaign using assets. Run AddCampaigns.cs " +
                "to create a campaign.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which sitelinks are added.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            try
            {
                // Creates a sitelink asset.
                List<string> siteLinkResourceNames = CreateSitelinkAssets(client, customerId);

                // Associates the sitelinks at the campaign level.
                LinkSitelinksToCampaign(client, customerId, campaignId, siteLinkResourceNames);
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
        /// Creates a list of <see cref="SitelinkAsset"/> objects which can then be added
        /// to campaigns.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <returns>The list of sitelink resource names.</returns>
        private List<string> CreateSitelinkAssets(GoogleAdsClient client, long customerId)
        {
            AssetServiceClient assetService = client.GetService(Services.V19.AssetService);

            // Creates some sitelink assets.
            SitelinkAsset storeLocatorAsset = new SitelinkAsset()
            {
                Description1 = "Get in touch",
                Description2 = "Find your local store",
                LinkText = "Store locator"
            };

            SitelinkAsset storeAsset = new SitelinkAsset()
            {
                Description1 = "Buy some stuff",
                Description2 = "It's really good",
                LinkText = "Store"
            };

            SitelinkAsset storeAdditionalAsset = new SitelinkAsset()
            {
                Description1 = "Even more stuff",
                Description2 = "There's never enough",
                LinkText = "Store for more"
            };

            // Wraps the sitelinks in an Asset and sets the URLs.
            List<Asset> assets = new List<Asset>()
            {
                new Asset()
                {
                    SitelinkAsset = storeLocatorAsset,
                    FinalUrls = { "http://example.com/contact/store-finder" },
                    // Optionally sets a different URL for mobile.
                    FinalMobileUrls = { "http://example.com/mobile/contact/store-finder" }
                },
                new Asset()
                {
                    SitelinkAsset = storeAsset,
                    FinalUrls = { "http://example.com/store" },
                    // Optionally sets a different URL for mobile.
                    FinalMobileUrls = {"http://example.com/mobile/store" }
                },
                new Asset()
                {
                    SitelinkAsset = storeAdditionalAsset,
                    FinalUrls = { "http://example.com/store/more" },
                    // Optionally sets a different URL for mobile.
                    FinalMobileUrls = { "http://example.com/mobile/store/more" }
                }
            };

            // Creates an operation to add each asset.
            List<AssetOperation> operations = assets.Select(
                asset => new AssetOperation()
                {
                    Create = asset,
                }).ToList();

            // Sends the mutate request.
            MutateAssetsResponse response = assetService.MutateAssets(
                customerId.ToString(), operations);

            // Prints some information about the result.

            List<string> resourceNames = response.Results.Select(
                result => result.ResourceName).ToList();
            foreach (string resourceName in resourceNames)
            {
                Console.WriteLine($"Created sitelink asset with resource name '{resourceNames}'.");
            }
            return resourceNames;
        }

        /** Links the assets to a campaign. */

        /// <summary>
        /// Links the sitelinks to campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which sitelinks are added.
        /// </param>
        /// <param name="sitelinkAssetResourceNames">The sitelink asset resource names.</param>
        private void LinkSitelinksToCampaign(GoogleAdsClient client, long customerId,
            long campaignId, List<string> sitelinkAssetResourceNames)
        {
            CampaignAssetServiceClient campaignAssetService = client.GetService(
                Services.V19.CampaignAssetService);

            string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);

            // Creates operations.
            List<CampaignAssetOperation> campaignAssetOperations =
                sitelinkAssetResourceNames.Select(resourceName =>
                    new CampaignAssetOperation()
                    {
                        // Creates CampaignAsset representing the association between sitelinks
                        // and campaign.
                        Create = new CampaignAsset()
                        {
                            Asset = resourceName,
                            Campaign = campaignResourceName,
                            FieldType = AssetFieldType.Sitelink
                        }
                    }).ToList();

            // Sends the mutate request.
            MutateCampaignAssetsResponse response = campaignAssetService.MutateCampaignAssets(
                customerId.ToString(), campaignAssetOperations);
            // Prints some information about the result.
            foreach (MutateCampaignAssetResult result in response.Results)
            {
                Console.WriteLine($"Linked sitelink to campaign with resource " +
                    $"name '{result.ResourceName}'.");
            }
        }
    }
}
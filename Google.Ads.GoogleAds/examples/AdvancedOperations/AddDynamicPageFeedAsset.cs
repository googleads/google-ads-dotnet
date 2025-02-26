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
using Google.Ads.GoogleAds.V19.Common;
using Google.Ads.GoogleAds.V19.Errors;
using Google.Ads.GoogleAds.V19.Resources;
using Google.Ads.GoogleAds.V19.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V19.Enums.AssetSetTypeEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.WebpageConditionOperandEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V19
{
    /// <summary>
    /// This code example adds a page feed with URLs for a Dynamic Search Ads campaign.
    /// </summary>
    public class AddDynamicPageFeedAsset : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddDynamicPageFeedAsset"/> example.
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
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "ID of the campaign to which the asset is linked.")]
            public long CampaignId { get; set; }

            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "ID of the ad group to which DSA label targeting is added.")]
            public long AdGroupId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddDynamicPageFeedAsset codeExample = new AddDynamicPageFeedAsset();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId,
                options.AdGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a page feed with URLs for a Dynamic Search Ads campaign.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which the asset is linked.</param>
        /// <param name="adGroupId">ID of the ad group to which DSA label targeting is
        /// added.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId, long adGroupId)
        {
            // The label for the DSA page URLs.
            String dsaPageUrlLabel = "discounts";
            try
            {
                // Creates an Asset.
                List<string> assetResourceNames = CreateAssets(client, customerId,
                    dsaPageUrlLabel);
                // Creates an AssetSet - this is a collection of assets that can be associated
                // with a campaign.
                // Note: do not confuse this with an AssetGroup. An AssetGroup replaces
                // AdGroups in some types of campaigns.
                string assetSetResourceName = CreateAssetSet(client, customerId);
                // Adds the Assets to the AssetSet.
                AddAssetsToAssetSet(client, customerId, assetResourceNames, assetSetResourceName);
                // Links the AssetSet to the Campaign.
                LinkAssetSetToCampaign(client, customerId, campaignId, assetSetResourceName);
                // Optional: Targets web pages matching the feed's label in the ad group.
                AddDsaTarget(client, customerId, adGroupId, dsaPageUrlLabel);
                Console.WriteLine($"Dynamic page feed setup is complete for campaign with " +
                    $"ID {campaignId}.");
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
        /// Creates Assets to be used in a DSA page feed.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="dsaPageUrlLabel">The DSA page URL label.</param>
        /// <returns>The list of asset resource names.</returns>
        private static List<string> CreateAssets(GoogleAdsClient client, long customerId,
            string dsaPageUrlLabel)
        {
            AssetServiceClient assetService = client.GetService(Services.V19.AssetService);

            string[] urls = new[]
            {
                "http://www.example.com/discounts/rental-cars",
                "http://www.example.com/discounts/hotel-deals",
                "http://www.example.com/discounts/flight-deals"
            };

            // Creates one operation per URL.
            List<AssetOperation> assetOperations = new List<AssetOperation>();
            foreach (string url in urls)
            {
                PageFeedAsset pageFeedAsset = new PageFeedAsset()
                {
                    // Sets the URL of the page to include.
                    PageUrl = url,

                    // Recommended: adds labels to the asset. These labels can be used later in
                    // ad group targeting to restrict the set of pages that can serve.
                    Labels = { dsaPageUrlLabel }
                };

                assetOperations.Add(
                    new AssetOperation()
                    {
                        Create = new Asset()
                        {
                            PageFeedAsset = pageFeedAsset
                        }
                    });
            }

            // Adds the assets.
            MutateAssetsResponse response =
                assetService.MutateAssets(customerId.ToString(), assetOperations);

            // Prints some information about the result.
            List<string> resourceNames = response.Results.Select(
                assetResult => assetResult.ResourceName).ToList();
            foreach (string resourceName in resourceNames)
            {
                Console.Write($"Created asset with resource name {resourceName}.");
            }
            return resourceNames;
        }
        // [END add_asset]

        // [START add_asset_set]
        /// <summary>
        /// Creates an AssetSet.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The resource name of the asset set.</returns>
        private string CreateAssetSet(GoogleAdsClient client, long customerId)
        {
            AssetSetServiceClient assetSetService = client.GetService(
                Services.V19.AssetSetService);

            // Creates an AssetSet which will be used to link the dynamic page feed assets
            // to a campaign.
            AssetSet assetSet = new AssetSet()
            {
                Name = "My dynamic page feed " + ExampleUtilities.GetRandomString(),
                Type = AssetSetType.PageFeed
            };

            // Creates an operation to add the AssetSet.
            AssetSetOperation operation = new AssetSetOperation()
            {
                Create = assetSet
            };

            // Sends the mutate request.
            MutateAssetSetsResponse response =
                assetSetService.MutateAssetSets(
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
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="assetResourceNames">The asset resource names.</param>
        /// <param name="assetSetResourceName">Resource name of the asset set.</param>
        private void AddAssetsToAssetSet(GoogleAdsClient client, long customerId,
            List<string> assetResourceNames, string assetSetResourceName)
        {
            AssetSetAssetServiceClient assetSetAssetService = client.GetService(
                Services.V19.AssetSetAssetService);

            List<AssetSetAssetOperation> operations = new List<AssetSetAssetOperation>();
            foreach (string assetResourceName in assetResourceNames)
            {
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

                operations.Add(operation);
            }
            // Sends the mutate request.
            MutateAssetSetAssetsResponse response =
                assetSetAssetService.MutateAssetSetAssets(customerId.ToString(), operations);
            // Prints some information about the response.
            string resourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Created AssetSetAsset link with resource name {resourceName}.");
        }
        // [END add_asset_set_asset]

        // [START add_campaign_asset_set]
        /// <summary>
        /// Links an AssetSet to a Campaign by creating a CampaignAssetSet.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to which the asset is linked.</param>
        /// <param name="assetSetResourceName">Resource name of the asset set.</param>
        private void LinkAssetSetToCampaign(GoogleAdsClient client, long customerId,
            long campaignId, string assetSetResourceName)
        {
            CampaignAssetSetServiceClient campaignAssetSetService = client.GetService(
                Services.V19.CampaignAssetSetService);

            // Creates a CampaignAssetSet representing the link between an AssetSet and a Campaign.
            CampaignAssetSet campaignAssetSet = new CampaignAssetSet()
            {
                Campaign = ResourceNames.Campaign(customerId, campaignId),
                AssetSet = assetSetResourceName,
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

        // [START add_dsa_target]
        /// <summary>
        /// Adds the DSA target.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group to which DSA label targeting is added.</param>
        /// <param name="dsaPageUrlLabel">The DSA page URL label.</param>
        private static void AddDsaTarget(
            GoogleAdsClient client, long customerId, long adGroupId, string dsaPageUrlLabel)
        {
            AdGroupCriterionServiceClient adGroupCriterionService = client.GetService(
                Services.V19.AdGroupCriterionService);

            string adGroupResourceName = ResourceNames.AdGroup(customerId, adGroupId);

            // Creates the webpage condition info that targets an advertiser's webpages
            // based on the custom label specified by the dsaPageUrlLabel (e.g. "discounts").
            WebpageConditionInfo webpageConditionInfo = new WebpageConditionInfo()
            {
                Operand = WebpageConditionOperand.CustomLabel,
                Argument = dsaPageUrlLabel
            };

            // Creates the webpage info, or criterion for targeting webpages of an
            // advertiser's website.
            WebpageInfo webpageInfo = new WebpageInfo()
            {
                CriterionName = "Test Criterion",
                Conditions = { webpageConditionInfo }
            };

            // Creates the ad group criterion.
            AdGroupCriterion adGroupCriterion = new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                Webpage = webpageInfo,
                CpcBidMicros = 1_500_000
            };

            // Creates the operation.
            AdGroupCriterionOperation operation = new AdGroupCriterionOperation()
            {
                Create = adGroupCriterion
            };

            // Adds the ad group criterion.
            MutateAdGroupCriteriaResponse response =
                adGroupCriterionService.MutateAdGroupCriteria(
                    customerId.ToString(), new[] { operation });

            string resourceName = response.Results[0].ResourceName;
            // Displays the results.
            Console.WriteLine($"Created ad group criterion with resource " +
                $"name '{resourceName}'.");
        }
        // [END add_dsa_target]
    }
}

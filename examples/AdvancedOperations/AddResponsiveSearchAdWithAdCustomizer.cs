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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V10.Common;
using Google.Ads.GoogleAds.V10.Enums;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using Google.Protobuf;
using System.Collections.Generic;
using System.Linq;
using System;
using static Google.Ads.GoogleAds.V10.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AdvertisingChannelSubTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AssetFieldTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AssetGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.AssetTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.BiddingStrategyTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.BudgetTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.CriterionTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.CustomizerAttributeTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Enums.MediaTypeEnum.Types;
using static Google.Ads.GoogleAds.V10.Services.SmartCampaignSuggestionInfo.Types;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// Adds a customizer attribute, links the customizer attribute to a customer, and then adds
    /// a responsive search ad with a description using the ad customizer to the specified ad group.
    /// </summary>
    public class AddResponsiveSearchAdWithAdCustomizer : ExampleBase
    {
        /// <summary>
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
            /// The Google Ads ad group ID.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "The Google Ads ad group ID.")]
            public long AdGroupId { get; set; }

            /// <summary>
            /// The Google Ads customizer attribute name ID.
            /// </summary>
            [Option("customizerAttributeName", Required = false, HelpText =
                "The Google Ads customizer attribute name.", Default = CUSTOMIZER_ATTRIBUTE_NAME)]
            public string CustomizerAttributeName { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = new Options();
            Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // ID of the ad group to which ads are added.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    // The name of the customizer attribute
                    options.CustomizerAttributeName = "INSERT_CUSTOMIZER_ATTRIBUTE_NAME_HERE";

                    return 0;
                });

            AddResponsiveSearchAdWithAdCustomizer codeExample =
                new AddResponsiveSearchAdWithAdCustomizer();

            Console.WriteLine(codeExample.Description);

            codeExample.Run(
                new GoogleAdsClient(),
                options.CustomerId,
                options.AdGroupId,
                options.CustomizerAttributeName
            );
        }

        // The name of the customizer attribute to be used in the ad customizer must be unique for a
        // given client account. To run this example multiple times, change this value or specify its
        // corresponding argument. Note that there is a limit for the number of enabled customizer
        // attributes in one account, so you shouldn't run this example more than necessary.
        //
        // Visit the following link for more details:
        // https://developers.google.com/google-ads/api/docs/ads/customize-responsive-search-ads#rules_and_limitations
        private const string CUSTOMIZER_ATTRIBUTE_NAME = "Price";

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Adds a customizer attribute, links the customizer attribute to a customer, and then " +
            "adds a responsive search ad with a description using the ad customizer to the " +
            "specified ad group.";

        /// <summary>
        /// Runs the example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="adGroupId">The Google Ads ad group ID.</param>
        /// <param name="customizerAttributeName">The customizer attribute name.</param>
        public void Run(
                GoogleAdsClient client,
                long customerId,
                long adGroupId,
                string customizerAttributeName)
        {
            string customizerAttributeResourceName = CreateCustomizerAttribute(
                client,
                customerId,
                customizerAttributeName
            );

            LinkCustomizerAttributeToCustomer(client, customerId, customizerAttributeResourceName);

            CreateResponsiveSearchAdWithCustomization(
                client,
                customerId,
                adGroupId,
                customizerAttributeName
            );
        }

        // [START add_responsive_search_ad_with_ad_customizer_1]
        /// <summary>
        /// Creates a customizer attribute with the specified customizer attribute name.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="customizerAttributeName">The name of the customizer attribute.</param>
        /// <returns>The created customizer attribute resource name.</returns>
        private string CreateCustomizerAttribute(
            GoogleAdsClient client,
            long customerId,
            string customizerAttributeName)
        {
            // Creates a customizer attribute operation for creating a customizer attribute.
            CustomizerAttributeOperation operation = new CustomizerAttributeOperation() {
                // Creates a customizer attribute with the specified name.
                Create = new CustomizerAttribute() {
                    Name = customizerAttributeName,

                    // Specifies the type to be 'PRICE' so that we can dynamically customize the part of
                    // the ad's description that is a price of a product/service we advertise.
                    Type = CustomizerAttributeType.Price
                }
            };

            CustomizerAttributeServiceClient serviceClient =
                client.GetService(Services.V10.CustomizerAttributeService);

            // Issues a mutate request to add the customizer attribute and prints its information.
            MutateCustomizerAttributesResponse response =
                serviceClient.MutateCustomizerAttributes(
                    customerId.ToString(),
                    new [] { operation }.ToList()
                );

            string resourceName = response.Results[0].ResourceName;

            Console.WriteLine($"Added a customizer attribute with resource name '{resourceName}'.");

            return resourceName;
        }
        // [END add_responsive_search_ad_with_ad_customizer_1]

        // [START add_responsive_search_ad_with_ad_customizer_2]
        /// <summary>
        /// Links the customizer attribute to the customer by providing a value to be used in a
        /// responsive search ad that will be created in a later step.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="customizerAttributeResourceName">The resource name of the customizer
        /// attribute.</param>
        private void LinkCustomizerAttributeToCustomer(
            GoogleAdsClient client,
            long customerId,
            string customizerAttributeResourceName)
        {
            // Creates a customer customizer operation.
            CustomerCustomizerOperation operation = new CustomerCustomizerOperation() {
                // Creates a customer customizer with the value to be used in the responsive search
                // ad.
                Create = new CustomerCustomizer() {
                    CustomizerAttribute = customizerAttributeResourceName,

                    Value = new CustomizerValue() {
                        Type = CustomizerAttributeType.Price,

                        // Specify '100USD' as a text value. The ad customizer will dynamically
                        // replace the placeholder with this value when the ad serves.
                        StringValue = "100USD"
                    }
                }
            };

            CustomerCustomizerServiceClient serviceClient =
                client.GetService(Services.V10.CustomerCustomizerService);

            // Issues a mutate request to add the customer customizer and prints its information.
            MutateCustomerCustomizersResponse response =
                serviceClient.MutateCustomerCustomizers(
                    customerId.ToString(),
                    new [] { operation }.ToList()
                );

            string resourceName = response.Results[0].ResourceName;

            Console.WriteLine($"Added a customer customizer with resource name '{resourceName}'.");
        }
        // [END add_responsive_search_ad_with_ad_customizer_2]

        // [START add_responsive_search_ad_with_ad_customizer_3]
        /// <summary>
        /// Creates a responsive search ad that uses the specified customizer attribute.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="adGroupId">The ad group ID.</param>
        /// <param name="customizerAttributeName">The name of the customizer attribute.</param>
        private void CreateResponsiveSearchAdWithCustomization(
            GoogleAdsClient client,
            long customerId,
            long adGroupId,
            string customizerAttributeName)
        {
            // Creates an ad group ad operation.
            AdGroupAdOperation operation = new AdGroupAdOperation() {

                // Creates an ad group ad to hold the ad.
                Create = new AdGroupAd() {

                    AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                    Status = AdGroupAdStatus.Paused,

                    // Creates an ad and sets responsive search ad info.
                    Ad = new Ad() {

                        ResponsiveSearchAd = new ResponsiveSearchAdInfo() {
                            Headlines =
                            {
                                // Sets a pinning to always choose this asset for HEADLINE_1. Pinning is
                                // optional; if no pinning is set, then headlines and descriptions will be
                                // rotated and the ones that perform best will be used more often.
                                new AdTextAsset() { Text = "Cruise to Mars" },
                                new AdTextAsset() { Text = "Best Space Cruise Line" },
                                new AdTextAsset() { Text = "Experience the Stars" }
                            },

                            Descriptions =
                            {
                                new AdTextAsset() { Text = "Buy your tickets now" },

                                // Creates this particular description using the ad customizer. For
                                // details about the placeholder format, visit the following:
                                // https://developers.google.com/google-ads/api/docs/ads/customize-responsive-search-ads#ad_customizers_in_responsive_search_ads
                                //
                                // The ad customizer replaces the placeholder with the value we
                                // previously created and linked to the customer using
                                // `CustomerCustomizer`.
                                new AdTextAsset()
                                {
                                    Text = $"Just {{CUSTOMIZER.{customizerAttributeName}:10USD}}"
                                }
                            },

                            Path1 = "all-inclusive",
                            Path2 = "deals"
                        },

                        FinalUrls = { "http://www.example.com" }
                    }
                }
            };

            // Issues a mutate request to add the ad group ad and prints its information.
            AdGroupAdServiceClient serviceClient = client.GetService(Services.V10.AdGroupAdService);

            MutateAdGroupAdsResponse response = serviceClient.MutateAdGroupAds(
                customerId.ToString(),
                new [] { operation }.ToList()
            );

            string resourceName = response.Results[0].ResourceName;

            Console.WriteLine($"Created responsive search ad with resource name '{resourceName}'.");
        }
        // [END add_responsive_search_ad_with_ad_customizer_3]
    }
}

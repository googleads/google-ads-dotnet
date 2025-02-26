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
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V19.Common;
using Google.Ads.GoogleAds.V19.Resources;
using Google.Ads.GoogleAds.V19.Services;
using System.Collections.Generic;
using System.Linq;
using System;
using static Google.Ads.GoogleAds.V19.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.CustomizerAttributeTypeEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V19.Services.SuggestGeoTargetConstantsRequest.Types;
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Extensions.Config;

namespace Google.Ads.GoogleAds.Examples.V19
{
    /// <summary>
    /// Adds a customizer attribute, links the customizer attribute to a customer, and then adds
    /// a responsive search ad with a description using the ad customizer to the specified ad group.
    /// </summary>
    public class AddResponsiveSearchAdFull : ExampleBase
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
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddResponsiveSearchAdFull codeExample =
                new AddResponsiveSearchAdFull();

            Console.WriteLine(codeExample.Description);

            codeExample.Run(
                new GoogleAdsClient(),
                options.CustomerId,
                options.CustomizerAttributeName
            );
        }

        // The name of the customizer attribute to be used in the ad customizer must be unique for a
        // given client account. To run this example multiple times, change this value or specify
        // its corresponding argument. Note that there is a limit for the number of enabled
        // customizer attributes in one account, so you shouldn't run this example more than
        // necessary.
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
        /// <param name="customizerAttributeName">The customizer attribute name.</param>
        public void Run(
                GoogleAdsClient client,
                long customerId,
                string customizerAttributeName)
        {
            string customizerAttributeResourceName = CreateCustomizerAttribute(
                client,
                customerId,
                customizerAttributeName
            );

            LinkCustomizerAttributeToCustomer(client, customerId, customizerAttributeResourceName);

            string campaignBudgetResourceName = AddCampaignBudget(client, customerId);

            string campaignResourceName = AddCampaign(client, customerId,
                campaignBudgetResourceName);

            string adGroupResourceName = AddAdGroup(client, customerId, campaignResourceName);

            CreateResponsiveSearchAdWithCustomization(
                client,
                customerId,
                adGroupResourceName,
                customizerAttributeName
            );

            AddKeywords(client, customerId, adGroupResourceName);

            AddGeoTargeting(client, customerId, campaignResourceName);
        }

        // [START add_responsive_search_ad_full_customizer_1]
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
                client.GetService(Services.V19.CustomizerAttributeService);

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
        // [END add_responsive_search_ad_full_customizer_1]

        // [START add_responsive_search_ad_full_customizer_2]
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
                client.GetService(Services.V19.CustomerCustomizerService);

            // Issues a mutate request to add the customer customizer and prints its information.
            MutateCustomerCustomizersResponse response =
                serviceClient.MutateCustomerCustomizers(
                    customerId.ToString(),
                    new [] { operation }.ToList()
                );

            string resourceName = response.Results[0].ResourceName;

            Console.WriteLine($"Added a customer customizer with resource name '{resourceName}'.");
        }
        // [END add_responsive_search_ad_full_customizer_2]

        /// <summary>
        /// Adds a campaign budget.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The campaign budget resource name.</returns>
        private static string AddCampaignBudget(GoogleAdsClient client, long customerId)
        {
            // Get the CampaignBudgetService.
            CampaignBudgetServiceClient campaignBudgetService =
                client.GetService(Services.V19.CampaignBudgetService);

            // Create the budget.
            CampaignBudget campaignBudget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                AmountMicros = 3_000_000,
                DeliveryMethod = BudgetDeliveryMethod.Standard
            };

            // Create the operation.
            CampaignBudgetOperation operation = new CampaignBudgetOperation()
            {
                Create = campaignBudget
            };

            // Add the campaign budget.
            MutateCampaignBudgetsResponse response =
                campaignBudgetService.MutateCampaignBudgets(customerId.ToString(),
                    new CampaignBudgetOperation[] { operation });
            // Display the result.

            string budgetResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Added budget with resource name '{budgetResourceName}'.");
            return budgetResourceName;
        }

        /// <summary>
        /// Adds a campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="budgetResourceName">The campaign budget resource name.</param>
        /// <returns>The campaign resource name.</returns>
        private static string AddCampaign(GoogleAdsClient client, long customerId,
            string budgetResourceName)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(Services.V19.CampaignService);

            // Create the campaign.
            Campaign campaign = new Campaign()
            {
                Name = "Testing RSA via API #" + ExampleUtilities.GetRandomString(),
                AdvertisingChannelType = AdvertisingChannelType.Search,
                Status = CampaignStatus.Paused,
                ManualCpc = new ManualCpc(),
                NetworkSettings = new Campaign.Types.NetworkSettings()
                {
                    TargetGoogleSearch = true,
                    TargetSearchNetwork = true,
                    TargetPartnerSearchNetwork = false,
                    // Enable Display Expansion on Search campaigns. For more details see:
                    // https://support.google.com/google-ads/answer/7193800
                    TargetContentNetwork = true
                },
                CampaignBudget = budgetResourceName,

                StartDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd"),
                EndDate = DateTime.Now.AddDays(30).ToString("yyyyMMdd")
            };

            // Create the operation.
            CampaignOperation operation = new CampaignOperation()
            {
                Create = campaign
            };

            // Add the campaign.
            MutateCampaignsResponse response =
                campaignService.MutateCampaigns(customerId.ToString(),
                    new CampaignOperation[] { operation });

            // Displays the result.
            string campaignResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Added campaign with resource name '{campaignResourceName}'.");
            return campaignResourceName;
        }

        /// <summary>Adds an ad group.</summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignResourceName">The campaign resource name.</param>
        /// <returns>The ad group resource name.</returns>
        // [START add_dynamic_search_ads_1]
        private static string AddAdGroup(GoogleAdsClient client, long customerId,
            string campaignResourceName)
        {
            // Get the AdGroupService.
            AdGroupServiceClient adGroupService = client.GetService(Services.V19.AdGroupService);

            // Create the ad group.
            AdGroup adGroup = new AdGroup()
            {
                Name = "Testing RSA via API #" + ExampleUtilities.GetRandomString(),
                Campaign = campaignResourceName,
                Type = AdGroupType.SearchStandard,
                Status = AdGroupStatus.Enabled,

                // If you want to set up a max CPC bid, uncomment the line below.
                // CpcBidMicros = 50_000
            };

            // Create the operation.
            AdGroupOperation operation = new AdGroupOperation()
            {
                Create = adGroup
            };

            // Add the ad group.
            MutateAdGroupsResponse response =
                adGroupService.MutateAdGroups(customerId.ToString(),
                    new AdGroupOperation[] { operation });

            // Display the results.
            string adGroupResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Added ad group with resource name '{adGroupResourceName}'.");

            return adGroupResourceName;
        }

         // [START add_responsive_search_ad_with_ad_customizer_3]
        /// <summary>
        /// Creates a responsive search ad that uses the specified customizer attribute.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group.</param>
        /// <param name="customizerAttributeName">The name of the customizer attribute.</param>
        private void CreateResponsiveSearchAdWithCustomization(
            GoogleAdsClient client,
            long customerId,
            string adGroupResourceName,
            string customizerAttributeName)
        {
            // Creates an ad group ad operation.
            AdGroupAdOperation operation = new AdGroupAdOperation() {

                // Creates an ad group ad to hold the ad.
                Create = new AdGroupAd() {

                    AdGroup = adGroupResourceName,
                    Status = AdGroupAdStatus.Enabled,

                    // Creates an ad and sets responsive search ad info.
                    Ad = new Ad() {

                        ResponsiveSearchAd = new ResponsiveSearchAdInfo() {
                            Headlines =
                            {
                                // Sets a pinning to always choose this asset for HEADLINE_1.
                                // Pinning is optional; if no pinning is set, then headlines and
                                // descriptions will be rotated and the ones that perform best will
                                //be used more often.
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
            AdGroupAdServiceClient serviceClient = client.GetService(Services.V19.AdGroupAdService);

            MutateAdGroupAdsResponse response = serviceClient.MutateAdGroupAds(
                customerId.ToString(),
                new [] { operation }.ToList()
            );

            string resourceName = response.Results[0].ResourceName;

            Console.WriteLine($"Created responsive search ad with resource name '{resourceName}'.");
        }
        // [END add_responsive_search_ad_with_ad_customizer_3]

        /// <summary>
        /// Creates 3 keyword match types: EXACT, PHRASE, and BROAD.
        /// EXACT: ads may show on searches that ARE the same meaning as your keyword.
        /// PHRASE: ads may show on searches that INCLUDE the meaning of your keyword.
        /// BROAD: ads may show on searches that RELATE to your keyword.
        /// For smart bidding, BROAD is the recommended one.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group.</param>
        private void AddKeywords(GoogleAdsClient client, long customerId,
            string adGroupResourceName)
        {
            // Get the AdGroupCriterionService.
            AdGroupCriterionServiceClient adGroupCriterionService =
                client.GetService(Services.V19.AdGroupCriterionService);

            List<AdGroupCriterionOperation> operations = new List<AdGroupCriterionOperation>();

            AdGroupCriterionOperation exactMatchOperation = new AdGroupCriterionOperation()
            {
                Create = new AdGroupCriterion()
                {
                    AdGroup = adGroupResourceName,
                    Status = AdGroupCriterionStatus.Enabled,
                    Keyword = new KeywordInfo()
                    {
                        Text = "example of exact match",
                        MatchType = KeywordMatchType.Exact
                    },
                    // Uncomment the line below if you want to change this keyword to a negative
                    // target.
                    // Negative = true
                }
            };
            // Optional repeated field
            // exactMatchOperation.Create.FinalUrls.Add("https://www.example.com");
            operations.Add(exactMatchOperation);

            AdGroupCriterionOperation phraseMatchOperation = new AdGroupCriterionOperation()
            {
                Create = new AdGroupCriterion()
                {
                    AdGroup = adGroupResourceName,
                    Status = AdGroupCriterionStatus.Enabled,
                    Keyword = new KeywordInfo()
                    {
                        Text = "example of phrase match",
                        MatchType = KeywordMatchType.Phrase
                    },
                    // Uncomment the line below if you want to change this keyword to a negative
                    // target.
                    // Negative = true
                }
            };
            // Optional repeated field
            // phraseMatchOperation.Create.FinalUrls.Add("https://www.example.com");
            operations.Add(phraseMatchOperation);

            AdGroupCriterionOperation broadMatchOperation = new AdGroupCriterionOperation()
            {
                Create = new AdGroupCriterion()
                {
                    AdGroup = adGroupResourceName,
                    Status = AdGroupCriterionStatus.Enabled,
                    Keyword = new KeywordInfo()
                    {
                        Text = "example of broad match",
                        MatchType = KeywordMatchType.Broad
                    },
                    // Uncomment the line below if you want to change this keyword to a negative
                    // target.
                    // Negative = true
                }
            };
            // Optional repeated field
            // broadMatchOperation.Create.FinalUrls.Add("https://www.example.com");
            operations.Add(broadMatchOperation);

            MutateAdGroupCriteriaResponse response =
                adGroupCriterionService.MutateAdGroupCriteria(customerId.ToString(), operations);

             // Display the results.
            foreach (MutateAdGroupCriterionResult newAdGroupCriterion in response.Results)
            {
                Console.WriteLine("Keyword with resource name '{0}' was created.",
                    newAdGroupCriterion.ResourceName);
            }
        }

        /// <summary>
        /// Creates geo targets.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="campaignResourceName">The resource name of the campaign.</param>
        private void AddGeoTargeting(GoogleAdsClient client, long customerId,
            string campaignResourceName)
        {
            GeoTargetConstantServiceClient geoTargetConstantService =
                client.GetService(Services.V19.GeoTargetConstantService);

            SuggestGeoTargetConstantsRequest suggestGeoTargetConstantsRequest =
                new SuggestGeoTargetConstantsRequest()
            {
                // Locale uses the ISO 639-1 format.
                Locale = "es",
                // A list of available country codes can be referenced here:
                // https://developers.google.com/google-ads/api/reference/data/geotargets
                CountryCode = "AR",
                LocationNames = new LocationNames()
                {
                    Names = {"Buenos aires", "San Isidro", "Mar del Plata"}
                }
            };

            SuggestGeoTargetConstantsResponse suggestGeoTargetConstantsResponse =
                geoTargetConstantService.SuggestGeoTargetConstants(
                    suggestGeoTargetConstantsRequest);

            List<CampaignCriterionOperation> operations = new List<CampaignCriterionOperation>();
            foreach (GeoTargetConstantSuggestion suggestion in
                suggestGeoTargetConstantsResponse.GeoTargetConstantSuggestions)
            {
                Console.WriteLine($"Geo target constant: {suggestion.GeoTargetConstant.Name} was " +
                $"found in locale ({suggestion.Locale}) with reach ({suggestion.Reach}) from " +
                $"search term ({suggestion.SearchTerm})");

                CampaignCriterionOperation operation = new CampaignCriterionOperation()
                {
                    Create = new CampaignCriterion()
                    {
                        Campaign = campaignResourceName,
                        Location = new LocationInfo()
                        {
                            GeoTargetConstant = suggestion.GeoTargetConstant.ResourceName
                        }
                    }
                };
                operations.Add(operation);
            }

            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V19.CampaignCriterionService);

            MutateCampaignCriteriaResponse mutateCampaignCriteriaResponse =
                campaignCriterionService.MutateCampaignCriteria(customerId.ToString(), operations);

            foreach (MutateCampaignCriterionResult result in mutateCampaignCriteriaResponse.Results)
            {
                Console.WriteLine($"Added campaign criterion {result.ResourceName}");
            }
        }
    }
}

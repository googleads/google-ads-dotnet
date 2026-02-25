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
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V23.Common;
using Google.Ads.GoogleAds.V23.Errors;
using Google.Ads.GoogleAds.V23.Resources;
using Google.Ads.GoogleAds.V23.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Threading;
using static Google.Ads.GoogleAds.V23.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V23.Enums.AssetAutomationStatusEnum.Types;
using static Google.Ads.GoogleAds.V23.Enums.AssetAutomationTypeEnum.Types;
using static Google.Ads.GoogleAds.V23.Enums.AssetFieldTypeEnum.Types;
using static Google.Ads.GoogleAds.V23.Enums.AssetGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V23.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V23.Enums.EuPoliticalAdvertisingStatusEnum.Types;
using static Google.Ads.GoogleAds.V23.Enums.MessagingRestrictionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V23
{
    /// <summary>
    /// This example shows how to create a Performance Max campaign.
    ///
    /// For more information about Performance Max campaigns, see
    /// https://developers.google.com/google-ads/api/docs/performance-max/overview
    ///
    /// Prerequisites:
    /// - You must have at least one conversion action in the account. For
    /// more about conversion actions, see
    /// https://developers.google.com/google-ads/api/docs/conversions/overview#conversion_actions
    ///
    /// This example uses the default customer conversion goals. For an example
    /// of setting campaign-specific conversion goals, see
    /// ShoppingAds/AddPerformanceMaxRetailCampaign.cs
    /// </summary>
    public class AddPerformanceMaxCampaign : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddPerformanceMaxCampaign"/> example.
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
            /// Optional: An audience ID to use to improve the targeting of the Performance Max
            /// campaign.
            /// </summary>
            [Option("audienceId", Required = false, HelpText = "The ID of an audience.")]
            public long? AudienceId { get; set; }

            /// <summary>
            /// Optional: A boolean value indicating if the campaign is enabled for brand
            /// guidelines.
            /// </summary>
            [Option("brandGuidelinesEnabled", Required = false, HelpText =
                "A boolean value indicating if the campaign is enabled for brand guidelines.")]
            public bool BrandGuidelinesEnabled { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddPerformanceMaxCampaign codeExample = new AddPerformanceMaxCampaign();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(
                new GoogleAdsClient(),
                options.CustomerId,
                options.AudienceId,
                options.BrandGuidelinesEnabled
            );
        }

        // We specify temporary IDs that are specific to a single mutate request. Temporary IDs are
        // always negative and unique within one mutate request.
        //
        // See https://developers.google.com/google-ads/api/docs/mutating/best-practices for further
        // details.
        //
        // These temporary IDs are fixed because they are used in multiple places.
        private const int TEMPORARY_ID_BUDGET = -1;

        private const int TEMPORARY_ID_CAMPAIGN = -2;
        private const int TEMPORARY_ID_ASSET_GROUP = -3;

        // There are also entities that will be created in the same request but do not need to be
        // fixed temporary IDs because they are referenced only once.
        private class AssetTemporaryResourceNameGenerator
        {
            private long customerId;
            private long next;

            public AssetTemporaryResourceNameGenerator(long customerId, long assetGroupId)
            {
                this.customerId = customerId;
                this.next = assetGroupId - 1;
            }

            public string Next()
            {
                long i = next;
                Interlocked.Decrement(ref next);
                return ResourceNames.Asset(customerId, i);
            }
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example shows how to create a Performance Max campaign.";

        // [START add_performance_max_campaign_1]
        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="audienceId">The optional audience ID.</param>
        /// <param name="brandGuidelinesEnabled">Whether or not to enable brand guidelines.</param>
        public void Run(GoogleAdsClient client, long customerId, long? audienceId,
            bool brandGuidelinesEnabled)
        {
            try
            {
                // [START add_performance_max_campaign_1]
                GoogleAdsServiceClient googleAdsServiceClient =
                    client.GetService(Services.V23.GoogleAdsService);

                // Performance Max campaigns require that repeated assets such as headlines and
                // descriptions be created before the campaign.
                //
                // For the list of required assets for a Performance Max campaign, see
                // https://developers.google.com/google-ads/api/docs/performance-max/assets
                //
                // Create the headlines.
                List<string> headlineAssetResourceNames = CreateMultipleTextAssets(
                    client,
                    customerId,
                    new[] {
                    "Travel",
                    "Travel Reviews",
                    "Book travel"
                    }
                );

                // Create the descriptions.
                List<string> descriptionAssetResourceNames = CreateMultipleTextAssets(
                    client,
                    customerId,
                    new[] {
                    "Take to the air!",
                    "Fly to the sky!"
                    }
                );

                string tempResourceNameCampaignBudget = ResourceNames.CampaignBudget(
                    customerId,
                    TEMPORARY_ID_BUDGET
                );

                // The below methods create and return MutateOperations that we later provide to
                // the GoogleAdsService.Mutate method in order to create the entities in a single
                // request. Since the entities for a Performance Max campaign are closely tied to
                // one-another, it is considered a best practice to create them in a single Mutate
                // request so they all complete successfully or fail entirely, leaving no
                // orphaned entities.
                //
                // See: https://developers.google.com/google-ads/api/docs/mutating/overview
                MutateOperation campaignBudgetOperation = CreateCampaignBudgetOperation(
                    tempResourceNameCampaignBudget
                );

                string tempResourceNameCampaign = ResourceNames.Campaign(
                    customerId,
                    TEMPORARY_ID_CAMPAIGN
                );

                MutateOperation performanceMaxCampaignOperation =
                    CreatePerformanceMaxCampaignOperation(
                        tempResourceNameCampaign,
                        tempResourceNameCampaignBudget,
                        brandGuidelinesEnabled
                    );

                List<MutateOperation> campaignCriterionOperations =
                    CreateCampaignCriterionOperations(tempResourceNameCampaign);

                List<MutateOperation> assetGroupOperations =
                    CreateAssetGroupOperations(
                        tempResourceNameCampaign,
                        ResourceNames.AssetGroup(customerId, TEMPORARY_ID_ASSET_GROUP),
                        headlineAssetResourceNames,
                        descriptionAssetResourceNames,
                        new AssetTemporaryResourceNameGenerator(
                            customerId,
                            TEMPORARY_ID_ASSET_GROUP
                        ),
                        client.Config,
                        brandGuidelinesEnabled
                    );

                List<MutateOperation> assetGroupSignalOperations =
                    CreateAssetGroupSignalOperations(
                        customerId,
                        ResourceNames.AssetGroup(customerId, TEMPORARY_ID_ASSET_GROUP),
                        audienceId
                    );

                MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
                {
                    CustomerId = customerId.ToString()
                };

                // It's important to create these entities in this order because they depend on
                // each other.
                //
                // Additionally, we take several lists of operations and flatten them into one
                // large list.
                request.MutateOperations.Add(campaignBudgetOperation);
                request.MutateOperations.Add(performanceMaxCampaignOperation);
                request.MutateOperations.AddRange(campaignCriterionOperations);
                request.MutateOperations.AddRange(assetGroupOperations);
                request.MutateOperations.AddRange(assetGroupSignalOperations);

                MutateGoogleAdsResponse response = googleAdsServiceClient.Mutate(request);

                PrintResponseDetails(response);
                // [END add_performance_max_campaign_1]
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

        // [START add_performance_max_campaign_2]
        /// <summary>
        /// Creates a MutateOperation that creates a new CampaignBudget.
        ///
        /// A temporary ID will be assigned to this campaign budget so that it can be
        /// referenced by other objects being created in the same Mutate request.
        /// </summary>
        /// <param name="budgetResourceName">The temporary resource name of the budget to
        /// create.</param>
        /// <returns>A MutateOperation that creates a CampaignBudget.</returns>
        private MutateOperation CreateCampaignBudgetOperation(string budgetResourceName)
        {
            MutateOperation operation = new MutateOperation
            {
                CampaignBudgetOperation = new CampaignBudgetOperation
                {
                    Create = new CampaignBudget
                    {
                        Name = "Performance Max campaign budget #"
                          + ExampleUtilities.GetRandomString(),

                        // The budget period already defaults to DAILY.
                        AmountMicros = 50000000,

                        // A Performance Max campaign cannot use a shared campaign budget.
                        ExplicitlyShared = false,

                        // Set a temporary ID in the budget's resource name so it can be referenced
                        // by the campaign in later steps.
                        ResourceName = budgetResourceName
                    }
                }
            };

            return operation;
        }

        // [END add_performance_max_campaign_2]

        // [START add_performance_max_campaign_3]
        /// Creates a MutateOperation that creates a new Performance Max campaign.
        /// <param name="campaignResourceName">The campaign resource name.</param>
        /// <param name="campaignBudgetResourceName">The campaign budget resource name.</param>
        /// <param name="brandGuidelinesEnabled">Whether or not to enable brand guidelines.</param>
        /// <returns>A MutateOperations that will create this new campaign.</returns>
        private MutateOperation CreatePerformanceMaxCampaignOperation(
            string campaignResourceName,
            string campaignBudgetResourceName,
            bool brandGuidelinesEnabled)
        {
            // [START add_performance_max_text_guidelines]
            Campaign.Types.TextGuidelines textGuidelines =
                new Campaign.Types.TextGuidelines();
            textGuidelines.TermExclusions.AddRange(["cheap", "free"]);
            textGuidelines.MessagingRestrictions.Add(
                new Campaign.Types.MessagingRestriction()
                {
                    RestrictionText = "Don't mention competitor names",
                    RestrictionType = MessagingRestrictionType.RestrictionBasedExclusion
                }
            );

            // [END add_performance_max_text_guidelines]
            Campaign campaign = new Campaign()
            {
                Name = "Performance Max campaign #" + ExampleUtilities.GetRandomString(),

                // Set the campaign status as PAUSED. The campaign is the only entity in
                // the mutate request that should have its status set.
                Status = CampaignStatus.Paused,

                // All Performance Max campaigns have an AdvertisingChannelType of
                // PerformanceMax. The AdvertisingChannelSubType should not be set.
                AdvertisingChannelType = AdvertisingChannelType.PerformanceMax,

                // Bidding strategy must be set directly on the campaign. Setting a
                // portfolio bidding strategy by resource name is not supported. Max
                // Conversion and Maximize Conversion Value are the only strategies
                // supported for Performance Max campaigns. BiddingStrategyType is
                // read-only and cannot be set by the API. An optional ROAS (Return on
                // Advertising Spend) can be set to enable the MaximizeConversionValue
                // bidding strategy. The ROAS value must be specified as a ratio in the API.
                // It is calculated by dividing "total value" by "total spend".
                //
                // For more information on Maximize Conversion Value, see the support
                // article:
                // http://support.google.com/google-ads/answer/7684216.
                //
                // A target_roas of 3.5 corresponds to a 350% return on ad spend.
                MaximizeConversionValue = new MaximizeConversionValue()
                {
                    TargetRoas = 3.5
                },

                // Use the temporary resource name created earlier
                ResourceName = campaignResourceName,

                // Set the budget using the given budget resource name.
                CampaignBudget = campaignBudgetResourceName,

                // Set if the campaign is enabled for brand guidelines. For more information
                // on brand guidelines, see https://support.google.com/google-ads/answer/14934472.
                BrandGuidelinesEnabled = brandGuidelinesEnabled,

                // Declare whether or not this campaign contains political ads targeting the EU.
                ContainsEuPoliticalAdvertising = EuPoliticalAdvertisingStatus.DoesNotContainEuPoliticalAdvertising,

                TextGuidelines = textGuidelines,

                // Optional fields
                StartDateTime = DateTime.Now.AddDays(1).ToString("yyyyMMdd 00:00:00"),
                EndDateTime = DateTime.Now.AddDays(365).ToString("yyyyMMdd 23:59:59")
            };

            // [START add_pmax_asset_automation_settings]
            campaign.AssetAutomationSettings.AddRange(new[]{
                new Campaign.Types.AssetAutomationSetting
                {
                    AssetAutomationType = AssetAutomationType.GenerateImageExtraction,
                    AssetAutomationStatus = AssetAutomationStatus.OptedIn
                },
                new Campaign.Types.AssetAutomationSetting
                {
                    AssetAutomationType = AssetAutomationType.FinalUrlExpansionTextAssetAutomation,
                    AssetAutomationStatus = AssetAutomationStatus.OptedIn
                },
                new Campaign.Types.AssetAutomationSetting
                {
                    AssetAutomationType = AssetAutomationType.TextAssetAutomation,
                    AssetAutomationStatus = AssetAutomationStatus.OptedIn
                },
                new Campaign.Types.AssetAutomationSetting
                {
                    AssetAutomationType = AssetAutomationType.GenerateEnhancedYoutubeVideos,
                    AssetAutomationStatus = AssetAutomationStatus.OptedIn
                },
                new Campaign.Types.AssetAutomationSetting
                {
                    AssetAutomationType = AssetAutomationType.GenerateImageEnhancement,
                    AssetAutomationStatus = AssetAutomationStatus.OptedIn
                },
            });
            // [END add_pmax_asset_automation_settings]

            MutateOperation operation = new MutateOperation()
            {
                CampaignOperation = new CampaignOperation()
                {
                    Create = campaign
                }
            };

            return operation;
        }

        // [END add_performance_max_campaign_3]

        // [START add_performance_max_campaign_4]
        /// <summary>
        /// Creates a list of MutateOperations that create new campaign criteria.
        /// </summary>
        /// <param name="campaignResourceName">The campaign resource name.</param>
        /// <returns>A list of MutateOperations that create new campaign criteria.</returns>
        private List<MutateOperation> CreateCampaignCriterionOperations(
            string campaignResourceName)
        {
            List<MutateOperation> operations = new List<MutateOperation>();

            // Set the LOCATION campaign criteria.
            // Target all of New York City except Brooklyn.
            // Location IDs are listed here:
            // https://developers.google.com/google-ads/api/reference/data/geotargets
            // and they can also be retrieved using the GeoTargetConstantService as shown
            // here: https://developers.google.com/google-ads/api/docs/targeting/location-targeting
            //
            // We will add one positive location target for New York City (ID=1023191)
            // and one negative location target for Brooklyn (ID=1022762).
            // First, add the positive (negative = False) for New York City.
            MutateOperation operation1 = new MutateOperation()
            {
                CampaignCriterionOperation = new CampaignCriterionOperation()
                {
                    Create = new CampaignCriterion()
                    {
                        Campaign = campaignResourceName,
                        Location = new LocationInfo()
                        {
                            GeoTargetConstant = ResourceNames.GeoTargetConstant(1023191)
                        },

                        Negative = false
                    }
                }
            };

            operations.Add(operation1);

            // Next add the negative target for Brooklyn.
            MutateOperation operation2 = new MutateOperation()
            {
                CampaignCriterionOperation = new CampaignCriterionOperation()
                {
                    Create = new CampaignCriterion()
                    {
                        Campaign = campaignResourceName,
                        Location = new LocationInfo()
                        {
                            GeoTargetConstant = ResourceNames.GeoTargetConstant(1022762)
                        },

                        Negative = true
                    }
                }
            };

            operations.Add(operation2);

            // Set the LANGUAGE campaign criterion.
            MutateOperation operation3 = new MutateOperation()
            {
                CampaignCriterionOperation = new CampaignCriterionOperation()
                {
                    Create = new CampaignCriterion()
                    {
                        Campaign = campaignResourceName,

                        // Set the language.
                        // For a list of all language codes, see:
                        // https://developers.google.com/google-ads/api/reference/data/codes-formats#expandable-7
                        Language = new LanguageInfo()
                        {
                            LanguageConstant = ResourceNames.LanguageConstant(1000) // English
                        },
                    }
                }
            };

            operations.Add(operation3);

            return operations;
        }

        // [END add_performance_max_campaign_4]

        // [START add_performance_max_campaign_5]
        /// <summary>
        /// Creates multiple text assets and returns the list of resource names.
        /// </summary>
        /// <param name="client">The Google Ads Client.</param>
        /// <param name="customerId">The customer's ID.</param>
        /// <param name="texts">The texts to add.</param>
        /// <returns>A list of asset resource names.</returns>
        private List<string> CreateMultipleTextAssets(
            GoogleAdsClient client,
            long customerId,
            string[] texts)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V23.GoogleAdsService);

            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest()
            {
                CustomerId = customerId.ToString()
            };

            foreach (string text in texts)
            {
                request.MutateOperations.Add(
                    new MutateOperation()
                    {
                        AssetOperation = new AssetOperation()
                        {
                            Create = new Asset()
                            {
                                TextAsset = new TextAsset()
                                {
                                    Text = text
                                }
                            }
                        }
                    }
                );
            }

            // Send the operations in a single Mutate request.
            MutateGoogleAdsResponse response = googleAdsServiceClient.Mutate(request);

            List<string> assetResourceNames = new List<string>();

            foreach (MutateOperationResponse operationResponse in response.MutateOperationResponses)
            {
                MutateAssetResult assetResult = operationResponse.AssetResult;
                assetResourceNames.Add(assetResult.ResourceName);
            }

            PrintResponseDetails(response);

            return assetResourceNames;
        }

        // [END add_performance_max_campaign_5]

        // [START add_performance_max_campaign_6]
        /// <summary>
        /// Creates a list of MutateOperations that create a new asset_group.
        /// </summary>
        /// <param name="campaignResourceName">The campaign resource name.</param>
        /// <param name="assetGroupResourceName">The asset group resource name.</param>
        /// <param name="headlineAssetResourceNames">The headline asset resource names.</param>
        /// <param name="descriptionAssetResourceNames">The description asset resource
        /// names.</param>
        /// <param name="resourceNameGenerator">A generator for unique temporary ID's.</param>
        /// <param name="config">The Google Ads config.</param>
        /// <param name="brandGuidelinesEnabled">Whether or not to enable brand guidelines.</param>
        /// <returns>A list of MutateOperations that create the new asset group.</returns>
        private List<MutateOperation> CreateAssetGroupOperations(
            string campaignResourceName,
            string assetGroupResourceName,
            List<string> headlineAssetResourceNames,
            List<string> descriptionAssetResourceNames,
            AssetTemporaryResourceNameGenerator resourceNameGenerator,
            GoogleAdsConfig config,
            bool brandGuidelinesEnabled)
        {
            List<MutateOperation> operations = new List<MutateOperation>();

            // Create the AssetGroup
            operations.Add(
                new MutateOperation()
                {
                    AssetGroupOperation = new AssetGroupOperation()
                    {
                        Create = new AssetGroup()
                        {
                            Name = "Performance Max asset group #" +
                                ExampleUtilities.GetRandomString(),
                            Campaign = campaignResourceName,
                            FinalUrls = { "http://www.example.com" },
                            FinalMobileUrls = { "http://www.example.com" },
                            Status = AssetGroupStatus.Paused,
                            ResourceName = assetGroupResourceName
                        }
                    }
                }
            );

            // For the list of required assets for a Performance Max campaign, see
            // https://developers.google.com/google-ads/api/docs/performance-max/assets

            // An AssetGroup is linked to an Asset by creating a new AssetGroupAsset
            // and providing:
            //   the resource name of the AssetGroup
            //   the resource name of the Asset
            //   the field_type of the Asset in this AssetGroup.
            //
            // To learn more about AssetGroups, see
            // https://developers.google.com/google-ads/api/docs/performance-max/asset-groups

            // Link the previously created multiple text assets.

            // Link the headline assets.
            foreach (string resourceName in headlineAssetResourceNames)
            {
                operations.Add(
                    new MutateOperation()
                    {
                        AssetGroupAssetOperation = new AssetGroupAssetOperation()
                        {
                            Create = new AssetGroupAsset()
                            {
                                FieldType = AssetFieldType.Headline,
                                AssetGroup = assetGroupResourceName,
                                Asset = resourceName
                            }
                        }
                    }
                );
            }

            // Link the description assets.
            foreach (string resourceName in descriptionAssetResourceNames)
            {
                operations.Add(
                    new MutateOperation()
                    {
                        AssetGroupAssetOperation = new AssetGroupAssetOperation()
                        {
                            Create = new AssetGroupAsset()
                            {
                                FieldType = AssetFieldType.Description,
                                AssetGroup = assetGroupResourceName,
                                Asset = resourceName
                            }
                        }
                    }
                );
            }

            // Create and link the brand assets.
            operations.AddRange(
                CreateAndLinkBrandAssets(
                    assetGroupResourceName,
                    campaignResourceName,
                    resourceNameGenerator,
                    "Interplanetary Cruises",
                    "https://gaagl.page.link/bjYi",
                    "Marketing Logo",
                    config,
                    brandGuidelinesEnabled
                )
            );

            // Create and link the long headline text asset.
            operations.AddRange(
                CreateAndLinkTextAsset(
                    assetGroupResourceName,
                    resourceNameGenerator.Next(),
                    "Travel the World",
                    AssetFieldType.LongHeadline
                )
            );

            // Create and link the image assets.

            // Create and link the Marketing Image Asset.
            operations.AddRange(
                CreateAndLinkImageAsset(
                    assetGroupResourceName,
                    resourceNameGenerator.Next(),
                    "https://gaagl.page.link/Eit5",
                    AssetFieldType.MarketingImage,
                    "Marketing Image",
                    config
                )
            );

            // Create and link the Square Marketing Image Asset.
            operations.AddRange(
                CreateAndLinkImageAsset(
                    assetGroupResourceName,
                    resourceNameGenerator.Next(),
                    "https://gaagl.page.link/bjYi",
                    AssetFieldType.SquareMarketingImage,
                    "Square Marketing Image",
                    config
                )
            );

            return operations;
        }

        // [END add_performance_max_campaign_6]

        // [START add_performance_max_campaign_7]
        /// <summary>
        /// Creates a list of MutateOperations that create a new linked text asset.
        /// </summary>
        /// <param name="assetGroupResourceName">The resource name of the asset group to be
        /// created.</param>
        /// <param name="assetResourceName">The resource name of the text asset to be
        /// created.</param>
        /// <param name="text">The text of the asset to be created.</param>
        /// <param name="fieldType">The field type of the asset to be created.</param>
        /// <returns>A list of MutateOperations that create the new linked text asset.</returns>
        private List<MutateOperation> CreateAndLinkTextAsset(
            string assetGroupResourceName,
            string assetResourceName,
            string text,
            AssetFieldType fieldType)
        {
            List<MutateOperation> operations = new List<MutateOperation>();

            // Create the Text Asset.
            operations.Add(
                new MutateOperation()
                {
                    AssetOperation = new AssetOperation()
                    {
                        Create = new Asset()
                        {
                            ResourceName = assetResourceName,
                            TextAsset = new TextAsset()
                            {
                                Text = text
                            }
                        }
                    }
                }
            );

            // Create an AssetGroupAsset to link the Asset to the AssetGroup.
            operations.Add(
                new MutateOperation()
                {
                    AssetGroupAssetOperation = new AssetGroupAssetOperation()
                    {
                        Create = new AssetGroupAsset()
                        {
                            FieldType = fieldType,
                            AssetGroup = assetGroupResourceName,
                            Asset = assetResourceName
                        }
                    }
                }
            );

            return operations;
        }

        // [END add_performance_max_campaign_7]

        // [START add_performance_max_campaign_8]
        /// <summary>
        /// Creates a list of MutateOperations that create a new linked image asset.
        /// </summary>
        /// <param name="assetGroupResourceName">The resource name of the asset group to be
        /// created.</param>
        /// <param name="assetResourceName">The resource name of the text asset to be
        /// created.</param>
        /// <param name="url">The url of the image to be retrieved and put into an asset.</param>
        /// <param name="fieldType">The field type of the asset to be created.</param>
        /// <param name="assetName">The asset name.</param>
        /// <param name="config">The Google Ads Config.</param>
        /// <returns>A list of MutateOperations that create a new linked image asset.</returns>
        private List<MutateOperation> CreateAndLinkImageAsset(
            string assetGroupResourceName,
            string assetResourceName,
            string url,
            AssetFieldType fieldType,
            string assetName, GoogleAdsConfig config)
        {
            List<MutateOperation> operations = new List<MutateOperation>();

            // Create the Image Asset.
            operations.Add(
                new MutateOperation()
                {
                    AssetOperation = new AssetOperation()
                    {
                        Create = new Asset()
                        {
                            ResourceName = assetResourceName,
                            ImageAsset = new ImageAsset()
                            {
                                Data =
                                    ByteString.CopyFrom(
                                        MediaUtilities.GetAssetDataFromUrl(url, config)
                                    )
                            },
                            // Provide a unique friendly name to identify your asset.
                            // When there is an existing image asset with the same content but a
                            // different name, the new name will be dropped silently.
                            Name = assetName
                        }
                    }
                }
            );

            // Create an AssetGroupAsset to link the Asset to the AssetGroup.
            operations.Add(
                new MutateOperation()
                {
                    AssetGroupAssetOperation = new AssetGroupAssetOperation()
                    {
                        Create = new AssetGroupAsset()
                        {
                            FieldType = fieldType,
                            AssetGroup = assetGroupResourceName,
                            Asset = assetResourceName
                        }
                    }
                }
            );

            return operations;
        }

        // [END add_performance_max_campaign_8]

        /// <summary>
        /// Creates a list of MutateOperations that create and link the brand assets.
        /// </summary>
        /// <param name="assetGroupResourceName">The resource name of the asset group to link assets
        /// to.</param>
        /// <param name="campaignResourceName">The resource name of the campaign to link assets
        /// to.</param>
        /// <param name="assetResourceNameGenerator">The resource name generator of the assets to be
        /// created.</param>
        /// <param name="businessName">The business name text to be put into an asset.</param>
        /// <param name="logoUrl">The url of the logo to be retrieved and put into an asset.</param>
        /// <param name="logoName">The asset name of the logo.</param>
        /// <param name="config">The Google Ads Config.</param>
        /// <param name="brandGuidelinesEnabled">Whether or not to enable brand guidelines.</param>
        /// <returns>A list of MutateOperations that create a new linked image asset.</returns>
        // [START create_and_link_brand_assets]
        private List<MutateOperation> CreateAndLinkBrandAssets(
            string assetGroupResourceName,
            string campaignResourceName,
            AssetTemporaryResourceNameGenerator assetResourceNameGenerator,
            string businessName,
            string logoUrl,
            string logoName,
            GoogleAdsConfig config,
            bool brandGuidelinesEnabled)
        {
            List<MutateOperation> operations = new List<MutateOperation>();

            string logoAssetResourceName = assetResourceNameGenerator.Next();
            string businessNameAssetResourceName = assetResourceNameGenerator.Next();

            // Create the Image Asset.
            operations.Add(
                new MutateOperation()
                {
                    AssetOperation = new AssetOperation()
                    {
                        Create = new Asset()
                        {
                            ResourceName = logoAssetResourceName,
                            ImageAsset = new ImageAsset()
                            {
                                Data =
                                    ByteString.CopyFrom(
                                        MediaUtilities.GetAssetDataFromUrl(logoUrl, config)
                                    )
                            },
                            // Provide a unique friendly name to identify your asset.
                            // When there is an existing image asset with the same content but a
                            // different name, the new name will be dropped silently.
                            Name = logoName
                        }
                    }
                }
            );

            // Create the business name asset.
            operations.Add(
                new MutateOperation()
                {
                    AssetOperation = new AssetOperation()
                    {
                        Create = new Asset()
                        {
                            ResourceName = businessNameAssetResourceName,
                            TextAsset = new TextAsset()
                            {
                                Text = businessName,
                            }
                        }
                    }
                }
            );

            if (brandGuidelinesEnabled)
            {
                // Create CampaignAssets to link the Assets to the Campaign.
                operations.Add(
                    new MutateOperation()
                    {
                        CampaignAssetOperation = new CampaignAssetOperation()
                        {
                            Create = new CampaignAsset()
                            {
                                FieldType = AssetFieldType.Logo,
                                Campaign = campaignResourceName,
                                Asset = logoAssetResourceName
                            }
                        }
                    }
                );

                operations.Add(
                    new MutateOperation()
                    {
                        CampaignAssetOperation = new CampaignAssetOperation()
                        {
                            Create = new CampaignAsset()
                            {
                                FieldType = AssetFieldType.BusinessName,
                                Campaign = campaignResourceName,
                                Asset = businessNameAssetResourceName
                            }
                        }
                    }
                );
            } else {
                // Create AssetGroupAssets to link the Assets to the AssetGroup.
                operations.Add(
                    new MutateOperation()
                    {
                        AssetGroupAssetOperation = new AssetGroupAssetOperation()
                        {
                            Create = new AssetGroupAsset()
                            {
                                FieldType = AssetFieldType.Logo,
                                AssetGroup = assetGroupResourceName,
                                Asset = logoAssetResourceName
                            }
                        }
                    }
                );

                operations.Add(
                    new MutateOperation()
                    {
                        AssetGroupAssetOperation = new AssetGroupAssetOperation()
                        {
                            Create = new AssetGroupAsset()
                            {
                                FieldType = AssetFieldType.BusinessName,
                                AssetGroup = assetGroupResourceName,
                                Asset = businessNameAssetResourceName
                            }
                        }
                    }
                );

            }


            return operations;
        }
        // [END create_and_link_brand_assets]

        /// <summary>
        /// Creates a list of MutateOperations that may create AssetGroupSignals
        /// </summary>
        /// <param name="customerId">The customer ID.</param>
        /// <param name="assetGroupResourceName">The resource name of the asset group to be
        /// created.</param>
        /// <param name="audienceId">The optional audience ID.</param>
        /// <returns>A list of MutateOperations that create may create AssetGroupSignals.</returns>
        private List<MutateOperation> CreateAssetGroupSignalOperations(
            long customerId,
            string assetGroupResourceName,
            long? audienceId)
        {
            List<MutateOperation> operations = new List<MutateOperation>();

            if (audienceId.HasValue)
            {
                // Create an audience asset group signal.
                // To learn more about Audience Signals, see
                // https://developers.google.com/google-ads/api/docs/performance-max/asset-groups#audience_signals
                // [START add_performance_max_campaign_9]
                operations.Add(
                    new MutateOperation()
                    {
                        AssetGroupSignalOperation = new AssetGroupSignalOperation()
                        {
                            Create = new AssetGroupSignal()
                            {
                                AssetGroup = assetGroupResourceName,
                                Audience = new AudienceInfo()
                                {
                                    Audience = ResourceNames.Audience(customerId, audienceId.Value)
                                }
                            }
                        }
                    }
                );
                // [END add_performance_max_campaign_9]
            }

            // Create a search theme asset group signal.
            // To learn more about Search Themes Signals, see:
            // https://developers.google.com/google-ads/api/performance-max/asset-group-signals#search_themes
            // [START add_performance_max_campaign_10]
            operations.Add(
                new MutateOperation()
                {
                    AssetGroupSignalOperation = new AssetGroupSignalOperation()
                    {
                        Create = new AssetGroupSignal()
                        {
                            AssetGroup = assetGroupResourceName,
                            SearchTheme = new SearchThemeInfo()
                            {
                                Text = "travel"
                            }
                        }
                    }
                }
            );
            // [END add_performance_max_campaign_10]

            return operations;
        }

        /// <summary>
        /// Prints the details of a MutateGoogleAdsResponse. Parses the "response" oneof field name
        /// and uses it to extract the new entity's name and resource name.
        /// </summary>
        /// <param name="response">A MutateGoogleAdsResponse instance.</param>
        private void PrintResponseDetails(MutateGoogleAdsResponse response)
        {
            // Parse the Mutate response to print details about the entities that were created
            // in the request.
            foreach (MutateOperationResponse operationResponse in response.MutateOperationResponses)
            {
                string entityName = operationResponse.ResponseCase.ToString();
                // Trim the substring "Result" from the end of the entity name.
                entityName = entityName.Remove(entityName.Length - 6);

                string resourceName;
                switch (operationResponse.ResponseCase)
                {
                    case MutateOperationResponse.ResponseOneofCase.AdGroupResult:
                        resourceName = operationResponse.AdGroupResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.AdGroupAdResult:
                        resourceName = operationResponse.AdGroupAdResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.CampaignResult:
                        resourceName = operationResponse.CampaignResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.CampaignBudgetResult:
                        resourceName = operationResponse.CampaignBudgetResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.CampaignCriterionResult:
                        resourceName = operationResponse.CampaignCriterionResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.SmartCampaignSettingResult:
                        resourceName = operationResponse.SmartCampaignSettingResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.AssetResult:
                        resourceName = operationResponse.AssetResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.AssetGroupResult:
                        resourceName = operationResponse.AssetGroupResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.AssetGroupAssetResult:
                        resourceName = operationResponse.AssetGroupAssetResult.ResourceName;
                        break;

                    default:
                        resourceName = "<not found>";
                        break;
                }

                Console.WriteLine(
                    $"Created a(n) {entityName} with resource name: '{resourceName}'.");
            }
        }
    }
}
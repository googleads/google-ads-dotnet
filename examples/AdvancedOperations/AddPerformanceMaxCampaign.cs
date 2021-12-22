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
using Google.Ads.GoogleAds.V9.Common;
using Google.Ads.GoogleAds.V9.Enums;
using Google.Ads.GoogleAds.V9.Errors;
using Google.Ads.GoogleAds.V9.Resources;
using Google.Ads.GoogleAds.V9.Services;
using Google.Protobuf;
using System.Collections.Generic;
using System.Linq;
using System;
using static Google.Ads.GoogleAds.V9.Enums.AdGroupTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AdvertisingChannelSubTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AssetFieldTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AssetGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.AssetTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.BiddingStrategyTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.BudgetTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.CriterionTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.MediaTypeEnum.Types;
using static Google.Ads.GoogleAds.V9.Services.SmartCampaignSuggestionInfo.Types;

namespace Google.Ads.GoogleAds.Examples.V9
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

                    return 0;
                });

            AddPerformanceMaxCampaign codeExample = new AddPerformanceMaxCampaign();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(
                new GoogleAdsClient(),
                options.CustomerId
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
        private class AssetGroupAssetTemporaryResourceNameGenerator {
            private long customerId;
            private long assetGroupId;
            private long next;

            public AssetGroupAssetTemporaryResourceNameGenerator(long customerId, long assetGroupId)
            {
                this.customerId = customerId;
                this.assetGroupId = assetGroupId;
                this.next = assetGroupId - 1;
            }

            public string Next(AssetFieldType fieldType) {
                lock (this)
                {
                    long i = next;
                    next -= 1;
                    return ResourceNames.AssetGroupAsset(customerId, assetGroupId, i, fieldType);
                }
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
        public void Run(GoogleAdsClient client, long customerId)
        {
            // [START add_performance_max_campaign_1]
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V9.GoogleAdsService);

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

            // The below methods create and return MutateOperations that we later provide to the
            // GoogleAdsService.Mutate method in order to create the entities in a single request.
            // Since the entities for a Performance Max campaign are closely tied to one-another,
            // it's considered a best practice to create them in a single Mutate request so they all
            // complete successfully or fail entirely, leaving no orphaned entities.
            //
            // See: https://developers.google.com/google-ads/api/docs/mutating/overview
            MutateOperation campaignBudgetOperation = CreateCampaignBudgetOperation(
                client,
                tempResourceNameCampaignBudget
            );

            string tempResourceNameCampaign = ResourceNames.Campaign(
                customerId,
                TEMPORARY_ID_CAMPAIGN
            );

            MutateOperation performanceMaxCampaignOperation =
                CreatePerformanceMaxCampaignOperation(
                        client,
                        tempResourceNameCampaign,
                        tempResourceNameCampaignBudget
                    );

            List<MutateOperation> campaignCriterionOperations =
                CreateCampaignCriterionOperations(client, tempResourceNameCampaign);

            List<MutateOperation> assetGroupOperations =
                CreateAssetGroupOperations(
                    client,
                    tempResourceNameCampaign,
                    ResourceNames.AssetGroup(customerId, TEMPORARY_ID_ASSET_GROUP),
                    headlineAssetResourceNames,
                    descriptionAssetResourceNames,
                    new AssetGroupAssetTemporaryResourceNameGenerator(
                        customerId,
                        TEMPORARY_ID_ASSET_GROUP
                    )
                );

            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest
            {
                CustomerId = customerId.ToString()
            };

            // It's important to create these entities in this order because they depend on each
            // other.
            //
            // Additionally, we take several lists of operations and flatten them into one large
            // list.
            request.MutateOperations.Add(campaignBudgetOperation);
            request.MutateOperations.Add(performanceMaxCampaignOperation);
            request.MutateOperations.AddRange(campaignCriterionOperations);
            request.MutateOperations.AddRange(assetGroupOperations);

            MutateGoogleAdsResponse response = googleAdsServiceClient.Mutate(request);

            PrintResponseDetails(response);
            // [END add_performance_max_campaign_1]
        }

        // [START add_performance_max_campaign_2]
        /// <summary>
        /// Creates a MutateOperation that creates a new CampaignBudget.
        ///
        /// A temporary ID will be assigned to this campaign budget so that it can be
        /// referenced by other objects being created in the same Mutate request.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="budgetResourceName">The temporary resource name of the budget to
        /// create.</param>
        /// <returns>A MutateOperation that creates a CampaignBudget.</returns>
        private MutateOperation CreateCampaignBudgetOperation(
            GoogleAdsClient client,
            string budgetResourceName)
        {
            // Get the BudgetService.
            CampaignBudgetServiceClient budgetService =
              client.GetService(Services.V9.CampaignBudgetService);

            MutateOperation operation = new MutateOperation
            {
                CampaignBudgetOperation = new CampaignBudgetOperation
                {
                    Create = new CampaignBudget {
                        Name = "Performance Max campaign budget #"
                          + ExampleUtilities.GetRandomString(),

                        // The budget period already defaults to DAILY.
                        AmountMicros = 50000000,
                        DeliveryMethod = BudgetDeliveryMethod.Standard,

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
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="campaignResourceName">The campaign resource name.</param>
        /// <param name="campaignBudgetResourceName">The campaign budget resource name.</param>
        /// <returns>A MutateOperations that will create this new campaign.</returns>
        private MutateOperation CreatePerformanceMaxCampaignOperation(
            GoogleAdsClient client,
            string campaignResourceName,
            string campaignBudgetResourceName)
        {
            MutateOperation operation = new MutateOperation() {
                CampaignOperation = new CampaignOperation() {
                    Create = new Campaign() {
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
                        // supported for Performance Max campaigns. BiddingStrategyTYpe is
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

                        // Set the Final URL expansion opt out. This flag is specific to
                        // Performance Max campaigns. If opted out (True), only the final URLs in
                        // the asset group or URLs specified in the advertiser's Google Merchant
                        // Center or business data feeds are targeted.
                        // If opted in (False), the entire domain will be targeted. For best
                        // results, set this value to false to opt in and allow URL expansions. You
                        // can optionally add exclusions to limit traffic to parts of your website.
                        UrlExpansionOptOut = false,

                        // Use the temporary resource name created earlier
                        ResourceName = campaignResourceName,

                        // Set the budget using the given budget resource name.
                        CampaignBudget = campaignBudgetResourceName,

                        // Optional fields
                        StartDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd"),
                        EndDate = DateTime.Now.AddDays(365).ToString("yyyyMMdd")
                    }
                }
            };

            return operation;
        }
        // [END add_performance_max_campaign_3]

        // [START add_performance_max_campaign_4]
        /// <summary>
        /// Creates a list of MutateOperations that create new campaign criteria.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="campaignResourceName">The campaign resource name.</param>
        /// <returns>A list of MutateOperations that create new campaign criteria.</returns>
        private List<MutateOperation> CreateCampaignCriterionOperations(
            GoogleAdsClient client,
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
            MutateOperation operation1 = new MutateOperation() {
                CampaignCriterionOperation = new CampaignCriterionOperation() {
                    Create = new CampaignCriterion() {
                        Campaign = campaignResourceName,
                        Location = new LocationInfo() {
                            GeoTargetConstant = ResourceNames.GeoTargetConstant(1023191)
                        },

                        Negative = false
                    }
                }
            };

            operations.Add(operation1);

            // Next add the negative target for Brooklyn.
            MutateOperation operation2 = new MutateOperation() {
                CampaignCriterionOperation = new CampaignCriterionOperation() {
                    Create = new CampaignCriterion() {
                        Campaign = campaignResourceName,
                        Location = new LocationInfo() {
                            GeoTargetConstant = ResourceNames.GeoTargetConstant(1022762)
                        },

                        Negative = true
                    }
                }
            };

            operations.Add(operation2);

            // Set the LANGUAGE campaign criterion.
            MutateOperation operation3 = new MutateOperation() {
                CampaignCriterionOperation = new CampaignCriterionOperation() {
                    Create = new CampaignCriterion() {
                        Campaign = campaignResourceName,

                        // Set the language.
                        // For a list of all language codes, see:
                        // https://developers.google.com/google-ads/api/reference/data/codes-formats#expandable-7
                        Language = new LanguageInfo() {
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
            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest() {
                CustomerId = customerId.ToString()
            };

            foreach (string text in texts)
            {
                request.MutateOperations.Add(
                    new MutateOperation() {
                        AssetOperation = new AssetOperation() {
                            Create = new Asset() {
                                TextAsset = new TextAsset()
                                {
                                    Text = text
                                }
                            }
                        }
                    }
                );
            }

            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V9.GoogleAdsService);

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
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="campaignResourceName">The campaign resource name.</param>
        /// <param name="assetGroupResourceName">The asset group resource name.</param>
        /// <param name="headlineAssetResourceNames">The headline asset resource names.</param>
        /// <param name="descriptionAssetResourceNames">The description asset resource
        /// names.</param>
        /// <param name="resourceNameGenerator">A generator for unique temporary ID's.</param>
        /// <returns>A list of MutateOperations that create the new asset group.</returns>
        private List<MutateOperation> CreateAssetGroupOperations(
            GoogleAdsClient client,
            string campaignResourceName,
            string assetGroupResourceName,
            List<string> headlineAssetResourceNames,
            List<string> descriptionAssetResourceNames,
            AssetGroupAssetTemporaryResourceNameGenerator resourceNameGenerator)
        {
            List<MutateOperation> operations = new List<MutateOperation>();

            // Create the AssetGroup
            operations.Add(
                new MutateOperation() {
                    AssetGroupOperation = new AssetGroupOperation() {
                        Create = new AssetGroup() {
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
                    new MutateOperation() {
                        AssetGroupAssetOperation = new AssetGroupAssetOperation() {
                            Create = new AssetGroupAsset() {
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
                    new MutateOperation() {
                        AssetGroupAssetOperation = new AssetGroupAssetOperation() {
                            Create = new AssetGroupAsset() {
                                FieldType = AssetFieldType.Description,
                                AssetGroup = assetGroupResourceName,
                                Asset = resourceName
                            }
                        }
                    }
                );
            }

            // Create and link the long headline text asset.
            operations.AddRange(
                CreateAndLinkTextAsset(
                    client,
                    assetGroupResourceName,
                    resourceNameGenerator.Next(AssetFieldType.LongHeadline),
                    "Travel the World",
                    AssetFieldType.LongHeadline
                )
            );

            // Create and link the business name text asset.
            operations.AddRange(
                CreateAndLinkTextAsset(
                    client,
                    assetGroupResourceName,
                    resourceNameGenerator.Next(AssetFieldType.BusinessName),
                    "Interplanetary Cruises",
                    AssetFieldType.BusinessName
                )
            );

            // Create and link the image assets.

            // Create and link the Logo Asset.
            operations.AddRange(
                CreateAndLinkImageAsset(
                    client,
                    assetGroupResourceName,
                    resourceNameGenerator.Next(AssetFieldType.Logo),
                    "https://gaagl.page.link/bjYi",
                    AssetFieldType.Logo
                )
            );

            // Create and link the Marketing Image Asset.
            operations.AddRange(
                CreateAndLinkImageAsset(
                    client,
                    assetGroupResourceName,
                    resourceNameGenerator.Next(AssetFieldType.MarketingImage),
                    "https://gaagl.page.link/Eit5",
                    AssetFieldType.MarketingImage
                )
            );

            // Create and link the Square Marketing Image Asset.
            operations.AddRange(
                CreateAndLinkImageAsset(
                    client,
                    assetGroupResourceName,
                    resourceNameGenerator.Next(AssetFieldType.SquareMarketingImage),
                    "https://gaagl.page.link/bjYi",
                    AssetFieldType.SquareMarketingImage
                )
            );

            return operations;
        }
        // [END add_performance_max_campaign_6]

        // [START add_performance_max_campaign_7]
        /// <summary>
        /// Creates a list of MutateOperations that create a new linked text asset.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="assetGroupResourceName">The resource name of the asset group to be
        /// created.</param>
        /// <param name="assetResourceName">The resource name of the text asset to be
        /// created.</param>
        /// <param name="text">The text of the asset to be created.</param>
        /// <param name="fieldType">The field type of the asset to be created.</param>
        /// <returns>A list of MutateOperations that create the new linked text asset.</returns>
        private List<MutateOperation> CreateAndLinkTextAsset(
            GoogleAdsClient client,
            string assetGroupResourceName,
            string assetResourceName,
            string text,
            AssetFieldType fieldType)
        {
            List<MutateOperation> operations = new List<MutateOperation>();

            // Create the Text Asset.
            operations.Add(
                new MutateOperation() {
                    AssetOperation = new AssetOperation() {
                        Create = new Asset() {
                            ResourceName = assetResourceName,
                            TextAsset = new TextAsset() {
                                Text = text
                            }
                        }
                    }
                }
            );

            // Create an AssetGroupAsset to link the Asset to the AssetGroup.
            operations.Add(
                new MutateOperation() {
                    AssetGroupAssetOperation = new AssetGroupAssetOperation() {
                        Create = new AssetGroupAsset() {
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
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="assetGroupResourceName">The resource name of the asset group to be
        /// created.</param>
        /// <param name="assetResourceName">The resource name of the text asset to be
        /// created.</param>
        /// <param name="url">The url of the image to be retrieved and put into an asset.</param>
        /// <param name="fieldType">The field type of the asset to be created.</param>
        /// <returns>A list of MutateOperations that create a new linked image asset.</returns>
        private List<MutateOperation> CreateAndLinkImageAsset(
            GoogleAdsClient client,
            string assetGroupResourceName,
            string assetResourceName,
            string url,
            AssetFieldType fieldType)
        {
            List<MutateOperation> operations = new List<MutateOperation>();

            // Create the Image Asset.
            operations.Add(
                new MutateOperation() {
                    AssetOperation = new AssetOperation() {
                        Create = new Asset() {
                            ResourceName = assetResourceName,
                            ImageAsset = new ImageAsset() {
                                Data =
                                    ByteString.CopyFrom(
                                        MediaUtilities.GetAssetDataFromUrl(url, client.Config)
                                    )
                            }
                        }
                    }
                }
            );

            // Create an AssetGroupAsset to link the Asset to the AssetGroup.
            operations.Add(
                new MutateOperation() {
                    AssetGroupAssetOperation = new AssetGroupAssetOperation() {
                        Create = new AssetGroupAsset() {
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
                string resourceName = "<not found>";

                string entityName = operationResponse.ResponseCase.ToString();
                // Trim the substring "Result" from the end of the entity name.
                entityName = entityName.Remove(entityName.Length - 6);

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
                }

                Console.WriteLine(
                    $"Created a(n) {entityName} with resource name: '{resourceName}'.");
            }
        }
    }
}

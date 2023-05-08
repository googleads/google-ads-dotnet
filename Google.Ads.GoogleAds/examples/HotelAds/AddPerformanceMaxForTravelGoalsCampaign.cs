// Copyright 2023 Google LLC
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
using Google.Ads.GoogleAds.V13.Common;
using Google.Ads.GoogleAds.V13.Errors;
using Google.Ads.GoogleAds.V13.Resources;
using Google.Ads.GoogleAds.V13.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V13.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.AssetFieldTypeEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.AssetGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.AssetSetTypeEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.HotelAssetSuggestionStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V13
{
    /// <summary>
    /// This example shows how to create a Performance Max for travel goals campaign. It also uses
    /// TravelAssetSuggestionService to fetch suggested assets for creating an asset group. In case
    /// there are not enough assets for the asset group (required by Performance Max), this example
    /// will create more assets to fulfill the requirements.
    ///
    /// <p>For more information about Performance Max campaigns, see
    /// https://developers.google.com/google-ads/api/docs/performance-max/overview.</p>
    /// <p>Prerequisites:</p>
    ///
    /// <ul>
    ///   <li>You must have at least one conversion action in the account. For more about conversion
    ///       actions, see
    ///       https://developers.google.com/google-ads/api/docs/conversions/overview#conversion_actions.
    ///   </li>
    /// </ul>
    ///
    /// <p>Notes:</p>
    ///
    /// <ul>
    ///   <li>This example uses the default customer conversion goals. For an example of setting
    ///       campaign-specific conversion goals, see AddPerformanceMaxRetailCampaign.cs.</li>
    ///   <li>To learn how to create asset group signals, see AddPerformanceMaxCampaign.cs.</li>
    /// </ul>
    /// </summary>
    public class AddPerformanceMaxForTravelGoalsCampaign : ExampleBase
    {
        /// <summary>
        /// Command line options for running the
        /// <see cref="AddPerformanceMaxForTravelGoalsCampaign"/> example.
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
            /// The Google Ads customer ID.
            /// </summary>
            [Option("placeId", Required = true, HelpText =
                "The place ID of a hotel property. A place ID uniquely identifies a place in the" +
                "Google Places database. See " +
                "https://developers.google.com/places/web-service-place-id to learn more.")]
            public string PlaceId { get; set; }
        }

         /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddPerformanceMaxForTravelGoalsCampaign codeExample =
                new AddPerformanceMaxForTravelGoalsCampaign();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.PlaceId);
        }

        // Minimum requirements of assets required in a Performance Max asset group.
        // See https://developers.google.com/google-ads/api/docs/performance-max/assets for details.
        private Dictionary<AssetFieldType, int> MIN_REQUIRED_TEXT_ASSET_COUNTS =
            new Dictionary<AssetFieldType, int>()
            {
                { AssetFieldType.Headline, 3 },
                { AssetFieldType.LongHeadline, 1 },
                { AssetFieldType.Description, 2 },
                { AssetFieldType.BusinessName, 1 },
            };

        private Dictionary<AssetFieldType, int> MIN_REQUIRED_IMAGE_ASSET_COUNTS =
            new Dictionary<AssetFieldType, int>()
            {
                { AssetFieldType.MarketingImage, 1 },
                { AssetFieldType.SquareMarketingImage, 1 },
                { AssetFieldType.Logo, 1 },
            };


        // Texts and URLs used to create text and image assets when the TravelAssetSuggestionService
        // doesn't return enough assets required for creating an asset group.
        private Dictionary<AssetFieldType, List<string>> DEFAULT_TEXT_ASSETS_INFO =
            new Dictionary<AssetFieldType, List<string>>()
            {
                { AssetFieldType.Headline, new List<string>()
                    {
                        "Hotel", "Travel Reviews", "Book travel"
                    }
                },
                { AssetFieldType.LongHeadline, new List<string>() { "Travel the World" } },
                { AssetFieldType.Description, new List<string>()
                    {
                        "Great deal for your beloved hotel",
                        "Best rate guaranteed"
                    }
                },
                { AssetFieldType.BusinessName, new List<string>() { "Interplanetary cruises" } },
            };

        private Dictionary<AssetFieldType, List<string>> DEFAULT_IMAGE_ASSETS_INFO =
            new Dictionary<AssetFieldType, List<string>>()
            {
                { AssetFieldType.MarketingImage, new List<string>()
                    {
                        "https://gaagl.page.link/Eit5"
                    }
                },
                { AssetFieldType.SquareMarketingImage, new List<string>()
                    {
                        "https://gaagl.page.link/bjYi"
                    }
                },
                { AssetFieldType.Logo, new List<string>()
                    {
                        "https://gaagl.page.link/bjYi"
                    }
                },
            };

        // We specify temporary IDs that are specific to a single mutate request. Temporary IDs are always
        // negative and unique within one mutate request.
        //
        // <p>See https://developers.google.com/google-ads/api/docs/mutating/best-practices for
        // further details.
        //
        // <p>These temporary IDs are fixed because they are used in multiple places.
        private int ASSET_TEMPORARY_ID = -1;
        private int BUDGET_TEMPORARY_ID = -2;
        private int CAMPAIGN_TEMPORARY_ID = -3;
        private int ASSET_GROUP_TEMPORARY_ID = -4;

        // There are also entities that will be created in the same request but do not
        // need to be fixed temporary IDs because they are referenced only once.
        private long temporaryId = -5;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This example shows how to create a Performance " +
            " Max for travel goals campaign. It also uses TravelAssetSuggestionService to fetch " +
            "suggested assets for creating an asset group. In case there are not enough assets " +
            "for the asset group (required by Performance Max), this example will create more " +
            "assets to fulfill the requirements.\n" +
            "For more information about Performance Max campaigns, see " +
            "https://developers.google.com/google-ads/api/docs/performance-max/overview.\n" +
            "Prerequisites:\n" +
            "You must have at least one conversion action in the account. For more about " +
            "conversion actions, see " +
            "https://developers.google.com/google-ads/api/docs/conversions/overview#conversion_actions.\n" +
            "Notes:\n" +
            "- This example uses the default customer conversion goals. For an example of " +
            "setting campaign-specific conversion goals, see AddPerformanceMaxRetailCampaign.cs.\n" +
            "- To learn how to create asset group signals, see AddPerformanceMaxCampaign.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="placeId">The place ID of a hotel property.</param>
        public void Run(GoogleAdsClient client, long customerId, string placeId)
        {
            HotelAssetSuggestion hotelAssetSuggestion =
                GetHotelAssetSuggestion(client, customerId, placeId);

            // Performance Max campaigns require that repeated assets such as headlines and
            // descriptions be created before the campaign. For the list of required assets for a
            // Performance Max campaign, see
            // https://developers.google.com/google-ads/api/docs/performance-max/assets.
            // This step is the same for any type of Performance Max campaign.

            // Creates the headlines using the hotel asset suggestion.
            List<string> headlineAssetResourceNames = CreateMultipleTextAssets(
                client, customerId, AssetFieldType.Headline, hotelAssetSuggestion);

            // Creates the descriptions using the hotel asset suggestion.
            List<string> descriptionAssetResourceNames = CreateMultipleTextAssets(
                client, customerId, AssetFieldType.Description, hotelAssetSuggestion);

            // Creates a hotel property asset set, which will be used later to link with a newly
            // created campaign.
            string hotelPropertyAssetSetResourceName = CreateHotelAssetSet(client, customerId);

            // Creates a hotel property asset and link it with the previously created hotel property
            // asset set. This asset will also be linked to an asset group in the later steps.
            // In the real-world scenario, you'd need to create many assets for all your hotel
            // properties. We use one hotel property here for simplicity.
            // Both asset and asset set need to be created before creating a campaign, so we cannot
            // bundle them with other mutate operations below.
            string hotelPropertyAssetResourceName = CreateHotelAsset(
                client, customerId, placeId, hotelPropertyAssetSetResourceName);

            // It's important to create the entities below in this order because they depend on
            // each other.
            // The methods below create and return mutate operations that we later provide to the
            // GoogleAdsService.Mutate method in order to create the entities in a single request.
            // Since the entities for a Performance Max campaign are closely tied to one-another,
            // it's considered a best practice to create them in a single Mutate request so they
            // all complete successfully or fail entirely, leaving no orphaned entities. See:
            // https://developers.google.com/google-ads/api/docs/mutating/overview.
            List<MutateOperation> mutateOperations = new List<MutateOperation>();
            mutateOperations.Add(CreateCampaignBudgetOperation(customerId));
            mutateOperations.Add(CreateCampaignOperation(customerId,
                hotelPropertyAssetSetResourceName));
            mutateOperations.AddRange(
                CreateAssetGroupOperations(
                    customerId,
                    hotelPropertyAssetResourceName,
                    headlineAssetResourceNames,
                    descriptionAssetResourceNames,
                    hotelAssetSuggestion,
                    client.Config
                )
            );

            // Issues a mutate request to create everything and prints the results.
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V13.GoogleAdsService);
            MutateGoogleAdsResponse response =
                googleAdsServiceClient.Mutate(customerId.ToString(), mutateOperations);
            Console.WriteLine("Created the following entities for a campaign budget, a campaign, " +
                "and an asset group for Performance Max for travel goals:");
            PrintResponseDetails(response);
        }

        /// <summary>
        /// Returns hotel asset suggestion obtained from TravelAssetsSuggestionService.
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="placeId">The place ID of a hotel property.</param>
        /// <returns>The hotel asset suggestion.</returns>
        /// </summary>
        // [START get_hotel_asset_suggestion]
        private HotelAssetSuggestion GetHotelAssetSuggestion(GoogleAdsClient client,
            long customerId, string placeId)
        {
            // Get the TravelAssetSuggestionService client.
            TravelAssetSuggestionServiceClient travelAssetSuggestionService =
                client.GetService(Services.V13.TravelAssetSuggestionService);

            SuggestTravelAssetsRequest request = new SuggestTravelAssetsRequest
            {
                CustomerId = customerId.ToString(),
                LanguageOption = "en-US",
            };

            request.PlaceId.Add(placeId);

            SuggestTravelAssetsResponse response = travelAssetSuggestionService.SuggestTravelAssets(
                request
            );

            Console.WriteLine($"Fetched a hotel asset suggestion for the place ID {placeId}");
            return response.HotelAssetSuggestions[0];
        }
        // [END get_hotel_asset_suggestion]


        ///<summary>
        /// Creates multiple text assets and returns the list of resource names. The hotel asset
        /// suggestion is used to create a text asset first. If the number of created text assets is
        /// still fewer than the minimum required number of assets of the specified asset field
        /// type, adds more text assets  to fulfill the requirement.
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="assetFieldType">The asset field type that the text assets will be created
        /// for.</param>
        /// <param name="hotelAssetSuggestion">The hotel asset suggestion.</param>
        /// <returns>The resource names of the created text assets.</returns>
        /// </summary>
        private List<string> CreateMultipleTextAssets(GoogleAdsClient client, long customerId,
            AssetFieldType assetFieldType, HotelAssetSuggestion hotelAssetSuggestion)
        {
            // Uses the GoogleAdService to create multiple text assets in a single request.
            List<MutateOperation> mutateOperations = new List<MutateOperation>();

            // First, adds all the text assets of the specified asset field type.
            // Filters to only the specified asset field type.
            // Constructs a mutate operation to create the asset.
            // Adds the operation to the list.
            if (hotelAssetSuggestion.Status == HotelAssetSuggestionStatus.Success)
            {
                foreach (HotelTextAsset asset in hotelAssetSuggestion.TextAssets)
                {
                    if (asset.AssetFieldType == assetFieldType)
                    {
                        MutateOperation operation = new MutateOperation
                        {
                            AssetOperation = new AssetOperation
                            {
                                Create = new Asset
                                {
                                    TextAsset = new TextAsset
                                    {
                                        Text = asset.Text
                                    }
                                }
                            }
                        };
                        mutateOperations.Add(operation);
                    }
                }
            }

            // If the added assets are still less than the minimum required assets for the asset
            // field type, add more text assets using the default texts.
            int i = 0;
            while (mutateOperations.Count < MIN_REQUIRED_TEXT_ASSET_COUNTS[assetFieldType])
            {
                string text = DEFAULT_TEXT_ASSETS_INFO[assetFieldType][i++];
                MutateOperation operation = new MutateOperation
                {
                    AssetOperation = new AssetOperation {
                        Create = new Asset {
                            TextAsset = new TextAsset {
                                Text = text
                            }
                        }
                    }
                };
                mutateOperations.Add(operation);
            }

            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V13.GoogleAdsService);

            MutateGoogleAdsResponse response =
                googleAdsService.Mutate(customerId.ToString(), mutateOperations);

            List<string> assetResourceNames = new List<string>();

            foreach (MutateOperationResponse operationResponse in response.MutateOperationResponses)
            {
                MutateAssetResult assetResult = operationResponse.AssetResult;
                assetResourceNames.Add(assetResult.ResourceName);
            }

            Console.WriteLine($"The following assets were created for the asset field type " +
                $"{assetFieldType}");
            PrintResponseDetails(response);

            return assetResourceNames;
        }

        /// <summary>
        /// Creates a hotel property asset set.
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <returns> The created hotel property asset set resource name.</returns>
        /// </summary>
        // [START create_hotel_asset_set]
        private string CreateHotelAssetSet(GoogleAdsClient client, long customerId)
        {
            AssetSetOperation operation = new AssetSetOperation()
            {
                Create = new AssetSet {
                    Name = "My Hotel property asset set #" + ExampleUtilities.GetRandomString(),
                    Type = AssetSetType.HotelProperty
                }
            };

            AssetSetServiceClient assetSetService = client.GetService(Services.V13.AssetSetService);

            MutateAssetSetsResponse response = assetSetService.MutateAssetSets(
                customerId.ToString(),
                new List<AssetSetOperation> { operation }
            );

            string assetResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Created an asset set with resource name: {assetResourceName}");
            return assetResourceName;
        }
        // [END create_hotel_asset_set]

        /// <summary>
        /// Creates a hotel property asset using the specified place ID. The place ID must belong
        /// to a hotel property. Then, links it to the specified asset set.
        ///
        /// <p>See https://developers.google.com/places/web-service/place-id to search for a hotel
        /// place ID.</p>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="placeId">The place ID for a hotel.</param>
        /// <param name="hotelPropertyAssetSetResourceName">The hotel asset set resource
        /// name.</param>
        /// <returns>The created hotel property asset resource name.</returns>
        /// </summary>
        // [START create_hotel_asset]
        private string CreateHotelAsset(
            GoogleAdsClient client, long customerId, string placeId,
            string hotelPropertyAssetSetResourceName)
        {
            // Uses the GoogleAdService to create an asset and asset set asset in a single request.
            List<MutateOperation> mutateOperations = new List<MutateOperation>();
            string assetResourceName = ResourceNames.Asset(customerId, ASSET_TEMPORARY_ID);

            // Creates a mutate operation for a hotel property asset.
            Asset hotelPropertyAsset = new Asset()
            {
                ResourceName = assetResourceName,
                HotelPropertyAsset = new HotelPropertyAsset
                {
                    PlaceId = placeId
                }
            };
            mutateOperations.Add(new MutateOperation
            {
                AssetOperation = new AssetOperation
                {
                   Create = hotelPropertyAsset
                }
            });

            // Creates a mutate operation for an asset set asset.
            AssetSetAsset assetSetAsset = new AssetSetAsset
            {
                Asset = assetResourceName,
                AssetSet = hotelPropertyAssetSetResourceName
            };
            mutateOperations.Add(new MutateOperation
            {
                AssetSetAssetOperation = new AssetSetAssetOperation
                {
                    Create = assetSetAsset
                }
            });

            // Issues a mutate request to create all entities.
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V13.GoogleAdsService);

            MutateGoogleAdsResponse response =
                googleAdsServiceClient.Mutate(customerId.ToString(), mutateOperations);
            Console.WriteLine("Created the following entities for the hotel asset:");
            PrintResponseDetails(response);

            return response.MutateOperationResponses[0].AssetResult.ResourceName;
        }
        // [END create_hotel_asset]

        /// <summary>
        /// Creates a mutate operation that creates a new campaign budget.
        /// <p>A temporary ID will be assigned to this campaign budget so that it can be referenced
        /// by other objects being created in the same mutate request.</p>
        /// <param name="customerId">The client customer ID.</param>
        /// <returns>A mutate operation that creates a campaign budget.</returns>
        /// </summary>
        private MutateOperation CreateCampaignBudgetOperation(long customerId)
        {
            CampaignBudget campaignBudget = new CampaignBudget
            {
                Name = "Performance Max for travel goals campaign budget #" +
                    ExampleUtilities.GetRandomString(),
                // The budget period already defaults to DAILY.
                AmountMicros = 500000,
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                // A Performance Max campaign cannot use a shared campaign budget.
                ExplicitlyShared = false,
                // Sets a temporary ID in the budget's resource name, so it can be referenced
                // by the campaign in later steps.
                ResourceName = ResourceNames.CampaignBudget(customerId, BUDGET_TEMPORARY_ID)
            };

            return new MutateOperation
            {
                CampaignBudgetOperation = new CampaignBudgetOperation
                {
                    Create = campaignBudget
                }
            };
        }

        /// <summary>
        /// Creates a mutate operation that creates a new Performance Max campaign. Links the
        /// specified hotel property asset set to this campaign.
        /// <p>A temporary ID will be assigned to this campaign so that it can be referenced by
        /// other objects being created in the same mutate request.</p>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="hotelPropertyAssetSetResourceName"> The resource name of the hotel property
        /// asset set.</param>
        /// <returns>A mutate operation that creates a campaign.</returns>
        /// </summary>
        // [START create_campaign]
        private MutateOperation CreateCampaignOperation(long customerId,
            string hotelPropertyAssetSetResourceName)
        {
            Campaign performanceMaxCampaign = new Campaign
            {
                Name = "Performance Max for travel goals campaign #" +
                    ExampleUtilities.GetRandomString(),
                // Sets the campaign status as PAUSED. The campaign is the only entity in
                // the mutate request that should have its status set.
                Status = CampaignStatus.Paused,
                // All Performance Max campaigns have an advertising_channel_type of
                // PERFORMANCE_MAX. The advertising_channel_sub_type should not be set.
                AdvertisingChannelType = AdvertisingChannelType.PerformanceMax,
                // To create a Performance Max for travel goals campaign, you need to set
                // `hotel_property_asset_set`.
                HotelPropertyAssetSet = hotelPropertyAssetSetResourceName,
                // Bidding strategy must be set directly on the campaign.
                // Setting a portfolio bidding strategy by resource name is not supported.
                // Max Conversion and Maximize Conversion Value are the only strategies
                // supported for Performance Max campaigns.
                // An optional ROAS (Return on Advertising Spend) can be set for
                // maximize_conversion_value. The ROAS value must be specified as a ratio in
                // the API. It is calculated by dividing "total value" by "total spend".
                // For more information on Maximize Conversion Value, see the support
                // article: http://support.google.com/google-ads/answer/7684216.
                // A targetRoas of 3.5 corresponds to a 350% return on ad spend.
                MaximizeConversionValue = new MaximizeConversionValue
                {
                    TargetRoas = 3.5
                },
                // Assigns the resource name with a temporary ID.
                ResourceName = ResourceNames.Campaign(customerId, CAMPAIGN_TEMPORARY_ID),
                // Sets the budget using the given budget resource name.
                CampaignBudget = ResourceNames.CampaignBudget(customerId, BUDGET_TEMPORARY_ID)
            };

            return new MutateOperation
            {
                CampaignOperation = new CampaignOperation
                {
                    Create = performanceMaxCampaign
                }
            };
        }
        // [END create_campaign]

        /// <summary>
        /// Creates a mutate operation that creates a new asset group.
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="hotelPropertyAssetResourceName"> The resource name of the hotel property
        /// asset.</param>
        /// <param name="headlineAssetResourceNames">The resource names for headline
        /// assets.</param>
        /// <param name="descriptionAssetResourceNames">The resource names for description
        /// assets.</param>
        /// <param name="hotelAssetSuggestion">The hotel asset suggestion.</param>
        /// <param name="config">The Google Ads configuration.</param>
        /// <returns>A mutate operation that creates an asset group.</returns>
        /// </summary>
        private List<MutateOperation> CreateAssetGroupOperations(
            long customerId,
            string hotelPropertyAssetResourceName,
            List<string> headlineAssetResourceNames,
            List<string> descriptionAssetResourceNames,
            HotelAssetSuggestion hotelAssetSuggestion,
            GoogleAdsConfig config
        )
        {
            List<MutateOperation> mutateOperations = new List<MutateOperation>();

            // Creates a new mutate operation that creates an asset group using suggested
            // information when available.
            string assetGroupName;
            List<string> assetGroupFinalUrls = new List<string>();
            if (hotelAssetSuggestion.Status == HotelAssetSuggestionStatus.Success)
            {
                assetGroupName = hotelAssetSuggestion.HotelName;
                assetGroupFinalUrls.Add(hotelAssetSuggestion.FinalUrl);
            }
            else
            {
                assetGroupName = "Performance Max for travel goals asset group #"
                    + ExampleUtilities.GetRandomString();
                assetGroupFinalUrls.Add("https://www.example.com");
            }

            string assetGroupResourceName = ResourceNames.AssetGroup(customerId,
                ASSET_GROUP_TEMPORARY_ID);

            AssetGroup assetGroup = new AssetGroup
            {
                ResourceName = assetGroupResourceName,
                Name = assetGroupName,
                Campaign = ResourceNames.Campaign(customerId, CAMPAIGN_TEMPORARY_ID),
                Status = AssetGroupStatus.Paused
            };

            assetGroup.FinalUrls.AddRange(assetGroupFinalUrls);

            mutateOperations.Add(new MutateOperation
            {
                AssetGroupOperation = new AssetGroupOperation
                {
                    Create = assetGroup
                }
            });

            // An asset group is linked to an asset by creating a new asset group asset
            // and providing:
            // -  the resource name of the asset group
            // -  the resource name of the asset
            // -  the field_type of the asset in this asset group
            //
            // To learn more about asset groups, see
            // https://developers.google.com/google-ads/api/docs/performance-max/asset-groups.

            // Headline and description assets were created at the first step of this example.
            // So, we just need to link them with the created asset group.
            List<AssetGroupAsset> assetGroupAssets = new List<AssetGroupAsset>();
            foreach (string headlineAssetResourceName in headlineAssetResourceNames)
            {
                assetGroupAssets.Add(new AssetGroupAsset
                {
                    Asset = headlineAssetResourceName,
                    AssetGroup = assetGroupResourceName,
                    FieldType = AssetFieldType.Headline
                });
            }

            foreach (string descriptionAssetResourceName in descriptionAssetResourceNames)
            {
                assetGroupAssets.Add(new AssetGroupAsset
                {
                    Asset = descriptionAssetResourceName,
                    AssetGroup = assetGroupResourceName,
                    FieldType = AssetFieldType.Description
                });
            }

            foreach (AssetGroupAsset assetGroupAsset in assetGroupAssets)
            {
                mutateOperations.Add(new MutateOperation
                {
                    AssetGroupAssetOperation = new AssetGroupAssetOperation
                    {
                        Create = assetGroupAsset
                    }
                });
            }

            // [START link_hotel_asset]
            // Link the previously created hotel property asset to the asset group. In the
            // real-world scenario, you'd need to do this step several times for each hotel property
            // asset.
            AssetGroupAsset hotelPropertyAssetGroupAsset = new AssetGroupAsset
            {
                Asset = hotelPropertyAssetResourceName,
                AssetGroup = assetGroupResourceName,
                FieldType = AssetFieldType.HotelProperty
            };

            // Adds an operation to link the hotel property asset to the asset group.
            mutateOperations.Add(new MutateOperation
            {
                AssetGroupAssetOperation = new AssetGroupAssetOperation
                {
                    Create = hotelPropertyAssetGroupAsset
                }
            });
            // [END link_hotel_asset]

            // Creates the rest of the required text assets and links them to the asset group.
            mutateOperations.AddRange(
                CreateOperationsForTextAssetsAndAssetGroupAssets(
                    customerId, hotelAssetSuggestion, assetGroupResourceName
                )
            );

            // Creates the image assets and links them to the asset group. Some optional image
            // assets suggested by the TravelAssetSuggestionService might be created too.
            mutateOperations.AddRange(
                CreateOperationsForImageAssetsAndAssetGroupAssets(
                   customerId, hotelAssetSuggestion, assetGroupResourceName, config
                )
            );

            if (hotelAssetSuggestion.Status == HotelAssetSuggestionStatus.Success)
            {
                // Creates a new mutate operation for a suggested call-to-action asset and links it
                // to the asset group.
                Asset callToActionAsset = new Asset
                {
                    ResourceName = ResourceNames.Asset(customerId, temporaryId),
                    Name = "Suggested call-to-action asset #" + ExampleUtilities.GetRandomString(),
                    CallToActionAsset = new CallToActionAsset
                    {
                        CallToAction = hotelAssetSuggestion.CallToAction
                    }
                };
                // Adds an operation to create the call-to-action asset.
                mutateOperations.Add(new MutateOperation
                {
                    AssetOperation = new AssetOperation
                    {
                        Create = callToActionAsset
                    }
                });

                AssetGroupAsset callToActionAssetGroupAsset = new AssetGroupAsset
                {
                    Asset = callToActionAsset.ResourceName,
                    AssetGroup = assetGroupResourceName,
                    FieldType = AssetFieldType.CallToActionSelection
                };
                // Adds an operation to link the call-to-action asset to the asset group.
                mutateOperations.Add(new MutateOperation
                {
                    AssetGroupAssetOperation = new AssetGroupAssetOperation
                    {
                        Create = callToActionAssetGroupAsset
                    }
                });
                temporaryId--;
            }

            return mutateOperations;
        }

        /// <summary>
        /// Creates text assets required for an asset group using the suggested hotel text assets.
        /// It adds  more text assets to fulfill the requirements if the suggested hotel text assets
        /// are not enough.
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="hotelAssetSuggestion">The hotel asset suggestion.</param>
        /// <param name="assetGroupResourceName">The resource name of the asset group.</param>
        /// <returns>A list of mutate operations that create text assets and asset group
        /// assets.</returns>
        /// </summary>
        private List<MutateOperation> CreateOperationsForTextAssetsAndAssetGroupAssets(
            long customerId,
            HotelAssetSuggestion hotelAssetSuggestion,
            string assetGroupResourceName
        )
        {
            // Creates mutate operations for the suggested text assets except for headlines and
            // descriptions, which were created previously.
            List<MutateOperation> mutateOperations = new List<MutateOperation>();
            // Creates a map of asset field type to list of text values to create.
            Dictionary<AssetFieldType, List<string>> textByFieldType =
                new Dictionary<AssetFieldType, List<string>>();

            if (hotelAssetSuggestion.Status == HotelAssetSuggestionStatus.Success)
            {
                // Adds text values of suggested text assets.
                foreach (HotelTextAsset hotelTextAsset in hotelAssetSuggestion.TextAssets)
                {
                    AssetFieldType assetFieldType = hotelTextAsset.AssetFieldType;
                    if (assetFieldType == AssetFieldType.Headline ||
                        assetFieldType == AssetFieldType.Description)
                    {
                        // Headlines and descriptions were already created at the first step of this
                        // code example.
                        continue;
                    }
                    Console.WriteLine($"A text asset with text {hotelTextAsset.Text} is " +
                        $"suggested for the asset field type {assetFieldType}");
                    List<string> existingTexts = null;
                    if (!textByFieldType.TryGetValue(assetFieldType, out existingTexts))
                    {
                        existingTexts = textByFieldType[assetFieldType] = new List<string>();
                    }

                    existingTexts.Add(hotelTextAsset.Text);
                }
            }

            // Collects more text values by field type to fulfill the requirements.
            foreach (AssetFieldType assetFieldType in MIN_REQUIRED_TEXT_ASSET_COUNTS.Keys)
            {
                if (assetFieldType == AssetFieldType.Headline ||
                        assetFieldType == AssetFieldType.Description)
                {
                    // Headlines and descriptions were already created at the first step of
                    // this code example.
                    continue;
                }

                List<string> existingTexts = null;
                if (!textByFieldType.TryGetValue(assetFieldType, out existingTexts))
                {
                    existingTexts = textByFieldType[assetFieldType] = new List<string>();
                }

                int i = 0;
                while (textByFieldType[assetFieldType].Count <
                    MIN_REQUIRED_TEXT_ASSET_COUNTS[assetFieldType])
                {
                    string textFromDefaults = DEFAULT_TEXT_ASSETS_INFO[assetFieldType][i++];
                    Console.WriteLine($"A default text '{textFromDefaults}' is used to create a " +
                        $"text asset for the asset field type '{assetFieldType}'");
                    existingTexts.Add(textFromDefaults);
                }
            }

            // Converts the list of text values by field type into AssetOperations and
            // AssetGroupAssetOperations.
            foreach (AssetFieldType assetFieldType in textByFieldType.Keys)
            {
                foreach (string text in textByFieldType[assetFieldType])
                {
                    // Builds the asset.
                    Asset asset = new Asset
                    {
                        ResourceName = ResourceNames.Asset(customerId, temporaryId--),
                        TextAsset = new TextAsset
                        {
                            Text = text
                        }
                    };
                    // Adds an operation to create the Asset.
                    mutateOperations.Add(new MutateOperation
                    {
                        AssetOperation = new AssetOperation
                        {
                            Create = asset
                        }
                    });

                    //Builds the AssetGroupAsset.
                    AssetGroupAsset assetGroupAsset = new AssetGroupAsset
                    {
                        Asset = asset.ResourceName,
                        AssetGroup = assetGroupResourceName,
                        FieldType = assetFieldType
                    };
                    // Adds an operation to link the Asset to the AssetGroup.
                    mutateOperations.Add(new MutateOperation
                    {
                        AssetGroupAssetOperation = new AssetGroupAssetOperation
                        {
                            Create = assetGroupAsset
                        }
                    });
                }
            }

            return mutateOperations;
        }

        /// <summary>
        /// Creates image assets required for an asset group using the suggested hotel image assets.
        /// It adds more image assets to fulfill the requirements if the suggested hotel image
        /// assets are not enough.
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="hotelAssetSuggestion">The hotel asset suggestion.</param>
        /// <param name="assetGroupResourceName">The resource name of the asset group.</param>
        /// <param name="config">The Google Ads config.</param>
        /// <returns>A list of mutate operations that create image assets and asset group
        /// assets.</returns>
        /// </summary>
        private List<MutateOperation> CreateOperationsForImageAssetsAndAssetGroupAssets(
            long customerId,
            HotelAssetSuggestion hotelAssetSuggestion,
            string assetGroupResourceName,
            GoogleAdsConfig config
        )
        {
            // Creates mutate operations for the suggested image assets.
            List<MutateOperation> mutateOperations = new List<MutateOperation>();
            // Creates a map of asset field type to list of image URLs for which this method will
            // create assets and asset group assets.
            Dictionary<AssetFieldType, List<string>> imageUrlsByFieldType =
                new Dictionary<AssetFieldType, List<string>>();

            if (hotelAssetSuggestion.Status == HotelAssetSuggestionStatus.Success)
            {
                // Adds URLs of suggested image assets.
                foreach (HotelImageAsset hotelImageAsset in hotelAssetSuggestion.ImageAssets)
                {
                    AssetFieldType assetFieldType = hotelImageAsset.AssetFieldType;
                    Console.WriteLine($"An image asset with URL '{hotelImageAsset.Uri} is " +
                        $"suggested for the asset field type {assetFieldType}");

                    List<string> existingImageUrls = null;
                    if (!imageUrlsByFieldType.TryGetValue(assetFieldType, out existingImageUrls))
                    {
                        existingImageUrls = imageUrlsByFieldType[assetFieldType] =
                            new List<string>();
                    }
                    existingImageUrls.Add(hotelImageAsset.Uri);
                }
            }

            // Collects more image URLs by field type to fulfill the requirements.
            foreach (AssetFieldType assetFieldType in MIN_REQUIRED_IMAGE_ASSET_COUNTS.Keys)
            {
                List<string> existingImageUrls = null;
                if (!imageUrlsByFieldType.TryGetValue(assetFieldType, out existingImageUrls))
                {
                    existingImageUrls = imageUrlsByFieldType[assetFieldType] =
                        new List<string>();
                }

                int i = 0;
                while (imageUrlsByFieldType[assetFieldType].Count <
                    MIN_REQUIRED_IMAGE_ASSET_COUNTS[assetFieldType])
                {
                    string imageUrlFromDefaults = DEFAULT_IMAGE_ASSETS_INFO[assetFieldType][i++];
                    Console.WriteLine($"A default image URL '{imageUrlFromDefaults} is used to " +
                        $"create an image asset for the asset field type {assetFieldType}");
                    existingImageUrls.Add(imageUrlFromDefaults);
                }
            }

            // Converts the list of URLs by field type into AssetOperations and
            // AssetGroupAssetOperations.
            foreach (AssetFieldType assetFieldType in imageUrlsByFieldType.Keys)
            {
                foreach (string imageUrl in imageUrlsByFieldType[assetFieldType])
                {
                    // Builds the image asset.
                    Asset asset = new Asset
                    {
                        ResourceName = ResourceNames.Asset(customerId, temporaryId--),
                        // Provide a unique friendly name to identify your asset.
                        // When there is an existing image asset with the same content but a
                        // different name, the new name will be dropped silently.
                        Name = $"{assetFieldType}{ExampleUtilities.GetRandomString()}",
                        ImageAsset = new ImageAsset
                        {
                            Data = ByteString.CopyFrom(
                                    MediaUtilities.GetAssetDataFromUrl(imageUrl, config)
                            )
                        }
                    };

                    // Adds an operation to create the asset.
                    mutateOperations.Add(new MutateOperation
                    {
                        AssetOperation = new AssetOperation
                        {
                            Create = asset
                        }
                    });

                    // Builds the AssetGroupAsset
                    AssetGroupAsset assetGroupAsset = new AssetGroupAsset
                    {
                        Asset = asset.ResourceName,
                        AssetGroup = assetGroupResourceName,
                        FieldType = assetFieldType
                    };

                    // Adds an operation to link the Asset to the AssetGroup.
                    mutateOperations.Add(new MutateOperation
                    {
                        AssetGroupAssetOperation = new AssetGroupAssetOperation
                        {
                            Create = assetGroupAsset
                        }
                    });
                }

            }

            return mutateOperations;
        }

        /// <summary>
        /// Prints the details of a MutateGoogleAdsResponse. Parses the "response" field name and
        /// uses it to extract the new entity's name and resource name.
        /// <param name="response">The mutate Google Ads response.</param>
        /// </summary>
        private void PrintResponseDetails(MutateGoogleAdsResponse response) {
            foreach (MutateOperationResponse operationResponse in response.MutateOperationResponses)
            {
                string resourceName;

                string entityName = operationResponse.ResponseCase.ToString();
                // Trim the substring "Result" from the end of the entity name.
                entityName = entityName.Remove(entityName.Length - 6);
                switch (operationResponse.ResponseCase)
                {
                    case MutateOperationResponse.ResponseOneofCase.AssetResult:
                        resourceName = operationResponse.AssetResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.AssetGroupResult:
                        resourceName = operationResponse.AssetGroupResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.AssetGroupAssetResult:
                        resourceName = operationResponse.AssetGroupAssetResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.AssetSetAssetResult:
                        resourceName = operationResponse.AssetSetAssetResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.CampaignBudgetResult:
                        resourceName = operationResponse.CampaignBudgetResult.ResourceName;
                        break;

                    case MutateOperationResponse.ResponseOneofCase.CampaignResult:
                        resourceName = operationResponse.CampaignResult.ResourceName;
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
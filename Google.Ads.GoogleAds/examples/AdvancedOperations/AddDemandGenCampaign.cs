// Copyright 2025 Google LLC
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
using static Google.Ads.GoogleAds.V23.Enums.AdGroupStatusEnum.Types;
using static Google.Ads.GoogleAds.V23.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V23.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V23.Resources.AdGroup.Types;
using static Google.Ads.GoogleAds.V23.Resources.AdGroup.Types.DemandGenAdGroupSettings.Types;
using static Google.Ads.GoogleAds.V23.Resources.AdGroup.Types.DemandGenAdGroupSettings.Types.DemandGenChannelControls.Types;
using static Google.Ads.GoogleAds.V23.Enums.EuPoliticalAdvertisingStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V23
{
    /// <summary>
    /// This example shows how to create a Demand Gen campaign with a video ad.
    ///
    /// For more information about Demand Gen campaigns, see
    /// https://developers.google.com/google-ads/api/docs/demand-gen/overview
    ///
    /// </summary>
    public class AddDemandGenCampaign : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddDemandGenCampaign"/> example.
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
            /// The YouTube ID of a video to use in an ad.
            /// </summary>
            [Option("videoId", Required = true, HelpText =
                "The YouTube ID of a video to use in an ad.")]
            public string VideoId { get; set;}
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddDemandGenCampaign codeExample = new AddDemandGenCampaign();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(
                new GoogleAdsClient(),
                options.CustomerId,
                options.VideoId
            );
        }

        private const long BUDGET_TEMPORARY_ID = -1;
        private const long CAMPAIGN_TEMPORARY_ID = -2;
        private const long AD_GROUP_TEMPORARY_ID = -3;
        private const long VIDEO_ASSET_TEMPORARY_ID = -4;
        private const long LOGO_ASSET_TEMPORARY_ID = -5;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example shows how to create a Demand Gen campaign.";


        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="videoId">The YouTube ID of a video to use in an ad.</param>
        public void Run(GoogleAdsClient client, long customerId, string videoId)
        {

            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V23.GoogleAdsService);

            try
            {
                string budgetResourceName = ResourceNames.CampaignBudget(
                    customerId, BUDGET_TEMPORARY_ID);
                string campaignResourceName = ResourceNames.Campaign(
                    customerId, CAMPAIGN_TEMPORARY_ID);
                string adGroupResourceName = ResourceNames.AdGroup(
                    customerId, AD_GROUP_TEMPORARY_ID);
                string videoAssetResourceName = ResourceNames.Asset(
                    customerId, VIDEO_ASSET_TEMPORARY_ID);
                string logoResourceName = ResourceNames.Asset(
                    customerId, LOGO_ASSET_TEMPORARY_ID);

                // [START add_demand_gen_campaign_1]
                // The below methods create and return MutateOperations that we later provide to
                // the GoogleAdsService.Mutate method in order to create the entities in a single
                // request. Since the entities for a Demand Gen campaign are closely tied to one-another
                // it's considered a best practice to create them in a single Mutate request; the
                // entities will either all complete successfully or fail entirely, leaving no
                // orphaned entities. See:
                // https://developers.google.com/google-ads/api/docs/mutating/overview
                MutateOperation campaignBudgetOperation =
                    CreateCampaignBudgetOperation(budgetResourceName);
                MutateOperation campaignOperation =
                    CreateDemandGenCampaignOperation(campaignResourceName, budgetResourceName);
                MutateOperation adGroupOperation =
                    CreateAdGroupOperation(adGroupResourceName, campaignResourceName);

                // Send the operations in a single mutate request.
                MutateGoogleAdsRequest mutateGoogleAdsRequest = new MutateGoogleAdsRequest
                {
                    CustomerId = customerId.ToString()
                };
                // It's important to create these entities in this order because they depend on
                // each other, for example the ad group depends on the
                // campaign, and the ad group ad depends on the ad group.
                mutateGoogleAdsRequest.MutateOperations.Add(campaignBudgetOperation);
                mutateGoogleAdsRequest.MutateOperations.Add(campaignOperation);
                mutateGoogleAdsRequest.MutateOperations.Add(adGroupOperation);

                mutateGoogleAdsRequest.MutateOperations.AddRange(
                    CreateAssetOperations(
                        videoAssetResourceName,
                        videoId,
                        logoResourceName,
                        client.Config
                    )
                );

                mutateGoogleAdsRequest.MutateOperations.Add(
                    CreateDemandGenAdOperation(
                        adGroupResourceName,
                        videoAssetResourceName,
                        logoResourceName
                    )
                );

                MutateGoogleAdsResponse response =
                        googleAdsServiceClient.Mutate(mutateGoogleAdsRequest);
                // [END add_demand_gen_campaign_1]
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
        /// Creates a MutateOperation that creates a new CampaignBudget.
        /// A temporary ID will be assigned to this campaign budget so that it can be referenced by
        /// other objects being created in the same Mutate request.
        /// </summary>
        /// <param name="budgetResourceName">The temporary resource name of the budget to
        /// create.</param>
        /// <returns>A MutateOperation that creates a CampaignBudget</returns>
        private MutateOperation CreateCampaignBudgetOperation(string budgetResourceName)
        {
            return new MutateOperation
            {
                CampaignBudgetOperation = new CampaignBudgetOperation
                {
                    Create = new CampaignBudget
                    {
                        Name = $"Demand Gen campaign budget {ExampleUtilities.GetRandomString()}",

                        // The budget period already defaults to DAILY.
                        AmountMicros = 50000000,

                        // A Demand Gen campaign cannot use a shared campaign budget.
                        ExplicitlyShared = false,

                        // Set a temporary ID in the budget's resource name so it can be referenced
                        // by the campaign in later steps.
                        ResourceName = budgetResourceName
                    }
                }
            };
        }

        /// <summary>
        /// Creates a MutateOperation that creates a new Campaign.
        /// A temporary ID will be assigned to this campaign so that it can be referenced by
        /// other objects being created in the same Mutate request.
        /// </summary>
        /// <param name="campaignResourceName">The temporary resource name of the campaign to
        /// create.</param>
        /// <param name="budgetResourceName">The temporary resource name of the budget to
        /// assign to the campaign.</param>
        /// <returns>A MutateOperation that creates a Campaign</returns>
        // [START add_demand_gen_campaign_2]
        private MutateOperation CreateDemandGenCampaignOperation(
            string campaignResourceName, string budgetResourceName)
        {
            return new MutateOperation
            {
                CampaignOperation = new CampaignOperation
                {
                    Create = new Campaign
                    {
                        Name = $"Demand Gen #{ExampleUtilities.GetRandomString()}",
                        // Set the campaign status as PAUSED.
                        Status = CampaignStatus.Paused,

                        // AdvertisingChannelType must be DEMAND_GEN.
                        AdvertisingChannelType = AdvertisingChannelType.DemandGen,

                        // Assign the resource name with a temporary ID.
                        ResourceName = campaignResourceName,

                        // Set the budget using the given budget resource name.
                        CampaignBudget = budgetResourceName,

                        // Use the Target CPA bidding strategy.
                        TargetCpa = new TargetCpa()
                        {
                            TargetCpaMicros = 1_000_000,
                        },

                        ContainsEuPoliticalAdvertising =
                            EuPoliticalAdvertisingStatus.DoesNotContainEuPoliticalAdvertising
                    }
                }
            };
        }
        // [END add_demand_gen_campaign_2]

        /// <summary>
        /// Creates a MutateOperation that creates a new AdGroup.
        /// </summary>
        /// <param name="adGroupResourceName">The temporary resource name of the ad group.</param>
        /// <param name="campaignResourceName">The temporary resource name of the campaign the ad
        /// group will belong to.</param>
        /// <returns>A MutateOperation that creates an AdGroup</returns>
        // [START add_demand_gen_campaign_3]
        private MutateOperation CreateAdGroupOperation(
            string adGroupResourceName,
            string campaignResourceName
        )
        {
            return new MutateOperation
            {
                AdGroupOperation = new AdGroupOperation
                {
                    // Creates an ad group.
                    Create = new AdGroup
                    {
                        ResourceName = adGroupResourceName,
                        Name = $"Earth to Mars Cruises #{ExampleUtilities.GetRandomString()}",
                        Status = AdGroupStatus.Enabled,
                        Campaign = campaignResourceName,

                        // [START add_demand_gen_campaign_5]
                        // Select the specific channels for the ad group.
                        // For further information on Demand Gen channel controls, see
                        // https://developers.google.com/google-ads/api/docs/demand-gen/channel-controls
                        DemandGenAdGroupSettings = new DemandGenAdGroupSettings
                        {
                            ChannelControls = new DemandGenChannelControls
                            {
                                SelectedChannels = new DemandGenSelectedChannels
                                {
                                    Gmail = false,
                                    Discover = false,
                                    Display = false,
                                    YoutubeInFeed = true,
                                    YoutubeInStream = true,
                                    YoutubeShorts = true,
                                }
                            }
                        }
                        // [END add_demand_gen_campaign_5]
                    }
                }
            };
        }
        // [END add_demand_gen_campaign_3]

        /// <summary>
        /// Creates a list of MutateOperations that create new Assets.
        /// </summary>
        /// <param name="videoAssetResourceName">The temporary resource name to use for the
        /// video asset.</param>
        /// <param name="videoId">The YouTube ID of the video asset.</param>
        /// <param name="logoResourceName">The temporary resource name to use for the
        /// logo asset.</param>
        /// <param name="config">The Google Ads Configuration.</param>
        /// <returns>A list of MutateOperations that create Assets</returns>

        private List<MutateOperation> CreateAssetOperations(
            string videoAssetResourceName,
            string videoId,
            string logoResourceName,
            GoogleAdsConfig config
        )
        {

            List<MutateOperation> operations =
            [
                CreateVideoAssetOperation(
                    videoAssetResourceName,
                    videoId,
                    "Video"
                ),

                // Create the logo image asset.
                CreateImageAssetOperation(
                    logoResourceName,
                    "https://gaagl.page.link/bjYi",
                    "Logo Image",
                    config
                ),
            ];

            return operations;
        }

         /// <summary>
        /// Creates a MutateOperation that creates a new Demand Gen Ad.
        /// </summary>
        /// <param name="adGroupResourceName">The temporary resource name of the ad group
        /// the ad will belong to.</param>
        /// <param name="videoAssetResourceName">The YouTube ID of the video asset.</param>
        /// <param name="logoResourceName">The temporary resource name of the
        /// logo asset.</param>
        /// <returns>A MutateOperation that creates an AdGroup</returns>
        // [START add_demand_gen_campaign_4]
        private MutateOperation CreateDemandGenAdOperation(
            string adGroupResourceName,
            string videoAssetResourceName,
            string logoResourceName
        )
        {

            Ad ad = new Ad
            {
                Name = "Demand gen video responsive ad",
                FinalUrls = { "http://example.com" },
                DemandGenVideoResponsiveAd = new DemandGenVideoResponsiveAdInfo
                {
                    BusinessName = new AdTextAsset
                    {
                        Text = "Interplanetary Cruises"
                    },

                }
            };

            ad.DemandGenVideoResponsiveAd.Videos.Add(new AdVideoAsset
            {
                Asset = videoAssetResourceName
            });

            ad.DemandGenVideoResponsiveAd.LogoImages.Add(new AdImageAsset
            {
                Asset = logoResourceName
            });

            ad.DemandGenVideoResponsiveAd.Headlines.Add(new AdTextAsset
            {
                Text = "Interplanetary cruises"
            });

            ad.DemandGenVideoResponsiveAd.LongHeadlines.Add(new AdTextAsset
            {
                Text = "Travel the World"
            });

            ad.DemandGenVideoResponsiveAd.Descriptions.Add(new AdTextAsset
            {
                Text = "Book now for an extra discount"
            });


            return new MutateOperation
            {
                AdGroupAdOperation = new AdGroupAdOperation
                {
                    Create = new AdGroupAd
                    {
                        AdGroup = adGroupResourceName,
                        Ad = ad
                    }
                }
            };
        }
        // [END add_demand_gen_campaign_4]

        /// <summary>
        /// Creates a MutateOperation that creates a new image asset.
        /// </summary>
        /// <param name="assetResourceName">The resource name of the text asset to be
        /// created.</param>
        /// <param name="url">The url of the image to be retrieved and put into an asset.</param>
        /// <param name="assetName">The asset name.</param>
        /// <param name="config">The Google Ads config.</param>
        /// <returns>A MutateOperation that creates a new image asset.</returns>
        private MutateOperation CreateImageAssetOperation(
            string assetResourceName,
            string url,
            string assetName,
            GoogleAdsConfig config)
            {
                return new MutateOperation
                {
                    AssetOperation = new AssetOperation()
                    {
                        Create = new Asset
                        {
                            ResourceName = assetResourceName,
                            ImageAsset = new ImageAsset
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
                };
            }

        /// <summary>
        /// Creates a MutateOperation that creates a new video asset.
        /// </summary>
        /// <param name="assetResourceName">The resource name of the text asset to be
        /// created.</param>
        /// <param name="videoId">The YouTube id of the video.</param>
        /// <param name="assetName">The asset name.</param>
        /// <returns>A MutateOperation that creates a new video asset.</returns>
        private MutateOperation CreateVideoAssetOperation(
            string assetResourceName,
            string videoId,
            string assetName
        )
        {
            return new MutateOperation
            {
                AssetOperation = new AssetOperation
                {
                    Create = new Asset
                    {
                        ResourceName = assetResourceName,
                        Name = assetName,
                        YoutubeVideoAsset = new YoutubeVideoAsset
                        {
                            YoutubeVideoId = videoId
                        }
                    }
                }
            };
        }
    }
}
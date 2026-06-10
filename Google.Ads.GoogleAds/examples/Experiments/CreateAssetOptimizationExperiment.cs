// Copyright 2026 Google LLC
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
using Google.Ads.GoogleAds.V24.Common;
using Google.Ads.GoogleAds.V24.Errors;
using Google.Ads.GoogleAds.V24.Resources;
using Google.Ads.GoogleAds.V24.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V24.Enums.AssetFieldTypeEnum.Types;
using static Google.Ads.GoogleAds.V24.Enums.AssetTypeEnum.Types;
using static Google.Ads.GoogleAds.V24.Enums.ExperimentTypeEnum.Types;
using static Google.Ads.GoogleAds.V24.Enums.OptimizeAssetsExperimentSubtypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V24
{
    /// <summary>
    /// This example shows how to create an OPTIMIZE_ASSETS experiment.
    /// Asset optimization experiments are used to test different asset combinations
    /// within Performance Max campaigns.
    /// </summary>
    public class CreateAssetOptimizationExperiment : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="CreateAssetOptimizationExperiment"/> example.
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
            /// The base asset group ID to run the experiment on.
            /// </summary>
            [Option("assetGroupId", Required = true, HelpText =
                "The base asset group ID to run the experiment on.")]
            public long AssetGroupId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            CreateAssetOptimizationExperiment codeExample = new CreateAssetOptimizationExperiment();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AssetGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example shows how to create an OPTIMIZE_ASSETS experiment. " +
            "Asset optimization experiments are used to test different asset combinations " +
            "within Performance Max campaigns.";

        // Temp IDs
        private const long ASSET_1_TEMP_ID = -1;
        private const long EXPERIMENT_TEMP_ID = -2;
        private const long ASSET_2_TEMP_ID = -3;

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="assetGroupId">The base asset group ID to run the experiment on.</param>
        public void Run(GoogleAdsClient client, long customerId, long assetGroupId)
        {
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V24.GoogleAdsService);

            try
            {
                // Query the asset group to find the associated campaign resource name.
                string query = $@"
                    SELECT asset_group.campaign
                    FROM asset_group
                    WHERE asset_group.id = {assetGroupId}";

                // Issue a search request.
                var searchPagedResponse = googleAdsService.Search(customerId.ToString(), query);
                string campaignResourceName = null;

                foreach (GoogleAdsRow row in searchPagedResponse)
                {
                    campaignResourceName = row.AssetGroup.Campaign;
                    break;
                }

                if (string.IsNullOrEmpty(campaignResourceName))
                {
                    Console.WriteLine($"Asset group with ID {assetGroupId} not found.");
                    return;
                }

                // [START create_asset_optimization_experiment_1]
                // 1. Create Assets with temporary resource names.
                // We create a text asset and an image asset to showcase different types.
                MutateOperation assetOperation1 = CreateTextAssetOperation(
                    customerId,
                    ASSET_1_TEMP_ID,
                    "Fly to Mars!"
                );
                MutateOperation assetOperation2 = CreateImageAssetOperation(
                    customerId,
                    ASSET_2_TEMP_ID,
                    "https://gaagl.page.link/Eit5",
                    "Mars Landscape View",
                    client.Config
                );

                // 2. Create an Experiment with a temporary resource name.
                MutateOperation experimentOperation = new MutateOperation()
                {
                    ExperimentOperation = new ExperimentOperation()
                    {
                        Create = new Experiment()
                        {
                            ResourceName = ResourceNames.Experiment(customerId, EXPERIMENT_TEMP_ID),
                            Name = $"Interstellar Asset Experiment #{ExampleUtilities.GetRandomString()}",
                            Type = ExperimentType.OptimizeAssets,
                            OptimizeAssetsExperiment = new OptimizeAssetsExperimentInfo()
                            {
                                OptimizeAssetsExperimentSubtype = OptimizeAssetsExperimentSubtype.CompareAssets
                            }
                        }
                    }
                };

                // 3. Create two ExperimentArm resources.
                List<Tuple<long, AssetFieldType>> treatmentAssets = new List<Tuple<long, AssetFieldType>>
                {
                    Tuple.Create(ASSET_1_TEMP_ID, AssetFieldType.Headline),
                    Tuple.Create(ASSET_2_TEMP_ID, AssetFieldType.MarketingImage)
                };
                List<MutateOperation> armOperations = CreateArmsOperations(
                    customerId,
                    EXPERIMENT_TEMP_ID,
                    campaignResourceName,
                    assetGroupId,
                    treatmentAssets
                );

                // 4. Create AssetGroupAssets linking the assets to the asset group.
                MutateOperation assetGroupAssetOperation1 = CreateAssetGroupAssetOperation(
                    customerId,
                    assetGroupId,
                    ASSET_1_TEMP_ID,
                    AssetFieldType.Headline
                );
                MutateOperation assetGroupAssetOperation2 = CreateAssetGroupAssetOperation(
                    customerId,
                    assetGroupId,
                    ASSET_2_TEMP_ID,
                    AssetFieldType.MarketingImage
                );

                // Send all operations in a single Mutate request.
                // The operations must be in this specific order.
                List<MutateOperation> mutateOperations = new List<MutateOperation>
                {
                    assetOperation1,
                    assetOperation2,
                    experimentOperation,
                    assetGroupAssetOperation1,
                    assetGroupAssetOperation2
                };
                mutateOperations.AddRange(armOperations);

                MutateGoogleAdsResponse response = googleAdsService.Mutate(
                    customerId.ToString(), mutateOperations);
                // [END create_asset_optimization_experiment_1]

                // Print the results.
                Console.WriteLine($"Created headline asset: '{response.MutateOperationResponses[0].AssetResult.ResourceName}'.");
                Console.WriteLine($"Created image asset: '{response.MutateOperationResponses[1].AssetResult.ResourceName}'.");
                Console.WriteLine($"Created experiment: '{response.MutateOperationResponses[2].ExperimentResult.ResourceName}'.");
                Console.WriteLine($"Created asset group asset for headline: '{response.MutateOperationResponses[3].AssetGroupAssetResult.ResourceName}'.");
                Console.WriteLine($"Created asset group asset for image: '{response.MutateOperationResponses[4].AssetGroupAssetResult.ResourceName}'.");
                Console.WriteLine($"Created control arm: '{response.MutateOperationResponses[5].ExperimentArmResult.ResourceName}'.");
                Console.WriteLine($"Created treatment arm: '{response.MutateOperationResponses[6].ExperimentArmResult.ResourceName}'.");
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
        /// Creates a mutate operation for a text asset.
        /// </summary>
        private static MutateOperation CreateTextAssetOperation(long customerId, long tempId, string text)
        {
            return new MutateOperation()
            {
                AssetOperation = new AssetOperation()
                {
                    Create = new Asset()
                    {
                        ResourceName = ResourceNames.Asset(customerId, tempId),
                        TextAsset = new TextAsset()
                        {
                            Text = text
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Creates a mutate operation for an image asset.
        /// </summary>
        private static MutateOperation CreateImageAssetOperation(long customerId, long tempId, string url, string name, GoogleAdsConfig config)
        {
            return new MutateOperation()
            {
                AssetOperation = new AssetOperation()
                {
                    Create = new Asset()
                    {
                        ResourceName = ResourceNames.Asset(customerId, tempId),
                        Name = name,
                        Type = AssetType.Image,
                        ImageAsset = new ImageAsset()
                        {
                            Data = ByteString.CopyFrom(MediaUtilities.GetAssetDataFromUrl(url, config))
                        }
                    }
                }
            };
        }

        /// <summary>
        /// Creates mutate operations for control and treatment arms.
        /// </summary>
        private static List<MutateOperation> CreateArmsOperations(
            long customerId,
            long experimentTempId,
            string campaignResourceName,
            long assetGroupId,
            List<Tuple<long, AssetFieldType>> treatmentAssets)
        {
            List<MutateOperation> operations = new List<MutateOperation>();

            // Control arm
            ExperimentArm controlArm = new ExperimentArm()
            {
                Experiment = ResourceNames.Experiment(customerId, experimentTempId),
                Name = "Base Assets (Control)",
                Control = true,
                TrafficSplit = 50,
                Campaigns = { campaignResourceName }
            };

            ExperimentArm.Types.AssetGroupInfo assetGroupInfoControl = new ExperimentArm.Types.AssetGroupInfo()
            {
                AssetGroup = ResourceNames.AssetGroup(customerId, assetGroupId)
            };
            controlArm.AssetGroups.Add(assetGroupInfoControl);

            operations.Add(new MutateOperation()
            {
                ExperimentArmOperation = new ExperimentArmOperation()
                {
                    Create = controlArm
                }
            });

            // Treatment arm
            ExperimentArm treatmentArm = new ExperimentArm()
            {
                Experiment = ResourceNames.Experiment(customerId, experimentTempId),
                Name = "New Assets (Treatment)",
                Control = false,
                TrafficSplit = 50,
                Campaigns = { campaignResourceName }
            };

            ExperimentArm.Types.AssetGroupInfo assetGroupInfoTreatment = new ExperimentArm.Types.AssetGroupInfo()
            {
                AssetGroup = ResourceNames.AssetGroup(customerId, assetGroupId)
            };

            foreach (var asset in treatmentAssets)
            {
                assetGroupInfoTreatment.AssetGroupAssets.Add(new ExperimentArm.Types.AssetGroupAssetInfo()
                {
                    Asset = ResourceNames.Asset(customerId, asset.Item1),
                    FieldType = asset.Item2
                });
            }
            treatmentArm.AssetGroups.Add(assetGroupInfoTreatment);

            operations.Add(new MutateOperation()
            {
                ExperimentArmOperation = new ExperimentArmOperation()
                {
                    Create = treatmentArm
                }
            });

            return operations;
        }

        /// <summary>
        /// Creates a mutate operation for an asset group asset.
        /// </summary>
        private static MutateOperation CreateAssetGroupAssetOperation(
            long customerId,
            long assetGroupId,
            long assetTempId,
            AssetFieldType fieldType)
        {
            return new MutateOperation()
            {
                AssetGroupAssetOperation = new AssetGroupAssetOperation()
                {
                    Create = new AssetGroupAsset()
                    {
                        AssetGroup = ResourceNames.AssetGroup(customerId, assetGroupId),
                        Asset = ResourceNames.Asset(customerId, assetTempId),
                        FieldType = fieldType
                    }
                }
            };
        }
    }
}

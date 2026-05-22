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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V24.Errors;
using Google.Ads.GoogleAds.V24.Resources;
using Google.Ads.GoogleAds.V24.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V24.Enums.AssetAutomationStatusEnum.Types;
using static Google.Ads.GoogleAds.V24.Enums.AssetAutomationTypeEnum.Types;
using static Google.Ads.GoogleAds.V24.Enums.ExperimentTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V24
{
    /// <summary>
    /// This example shows how to create an ADOPT_AI_MAX intra-campaign experiment for a Search campaign.
    /// Intra-campaign experiments split traffic within the campaign, based on whether
    /// the feature (in this case, AI Max) is enabled or not.
    /// </summary>
    public class CreateSearchAdoptAiMaxExperiment : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="CreateSearchAdoptAiMaxExperiment"/> example.
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
            /// The campaign ID to run the experiment on.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "The campaign ID to run the experiment on.")]
            public long CampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            CreateSearchAdoptAiMaxExperiment codeExample = new CreateSearchAdoptAiMaxExperiment();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.CampaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example shows how to create an ADOPT_AI_MAX intra-campaign experiment for a Search campaign. " +
            "Intra-campaign experiments split traffic within the campaign, based on whether " +
            "the feature (in this case, AI Max) is enabled or not.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="campaignId">The campaign ID to run the experiment on.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V24.GoogleAdsService);

            try
            {
                // [START create_search_adopt_ai_max_experiment_1]
                // Create the experiment resource name using a temporary ID.
                string experimentResourceName = ResourceNames.Experiment(customerId, -1);

                // Create the experiment.
                MutateOperation experimentOperation = new MutateOperation()
                {
                    ExperimentOperation = new ExperimentOperation()
                    {
                        Create = new Experiment()
                        {
                            ResourceName = experimentResourceName,
                            Name = $"ADOPT_AI_MAX Experiment #{ExampleUtilities.GetRandomString()}",
                            Type = ExperimentType.AdoptAiMax
                        }
                    }
                };

                // Create the control arm. Both arms in an intra-campaign experiment
                // reference the same base campaign.
                MutateOperation controlArmOperation = new MutateOperation()
                {
                    ExperimentArmOperation = new ExperimentArmOperation()
                    {
                        Create = new ExperimentArm()
                        {
                            Experiment = experimentResourceName,
                            Name = "Control Arm",
                            Control = true,
                            TrafficSplit = 50,
                            Campaigns = { ResourceNames.Campaign(customerId, campaignId) }
                        }
                    }
                };

                // Create the treatment arm.
                MutateOperation treatmentArmOperation = new MutateOperation()
                {
                    ExperimentArmOperation = new ExperimentArmOperation()
                    {
                        Create = new ExperimentArm()
                        {
                            Experiment = experimentResourceName,
                            Name = "Treatment Arm",
                            Control = false,
                            TrafficSplit = 50,
                            Campaigns = { ResourceNames.Campaign(customerId, campaignId) }
                        }
                    }
                };

                // Create a campaign operation with an update mask to enable AI Max and
                // configure asset automation settings.
                Campaign campaign = new Campaign()
                {
                    ResourceName = ResourceNames.Campaign(customerId, campaignId),
                    AiMaxSetting = new Campaign.Types.AiMaxSetting { EnableAiMax = true }
                };

                campaign.AssetAutomationSettings.Add(new Campaign.Types.AssetAutomationSetting
                {
                    AssetAutomationType = AssetAutomationType.TextAssetAutomation,
                    AssetAutomationStatus = AssetAutomationStatus.OptedIn
                });

                campaign.AssetAutomationSettings.Add(new Campaign.Types.AssetAutomationSetting
                {
                    AssetAutomationType = AssetAutomationType.FinalUrlExpansionTextAssetAutomation,
                    AssetAutomationStatus = AssetAutomationStatus.OptedIn
                });

                MutateOperation campaignOperation = new MutateOperation()
                {
                    CampaignOperation = new CampaignOperation()
                    {
                        Update = campaign,
                        UpdateMask = FieldMasks.AllSetFieldsOf(campaign)
                    }
                };

                // Send all mutate operations in a single Mutate request.
                List<MutateOperation> mutateOperations = new List<MutateOperation>
                {
                    experimentOperation,
                    controlArmOperation,
                    treatmentArmOperation,
                    campaignOperation
                };

                MutateGoogleAdsResponse response = googleAdsService.Mutate(
                    customerId.ToString(), mutateOperations);
                // [END create_search_adopt_ai_max_experiment_1]

                // Print the results.
                // The results will be returned in the same order as the mutate operations.
                var experimentResult = response.MutateOperationResponses[0].ExperimentResult;
                var controlArmResult = response.MutateOperationResponses[1].ExperimentArmResult;
                var treatmentArmResult = response.MutateOperationResponses[2].ExperimentArmResult;
                var campaignResult = response.MutateOperationResponses[3].CampaignResult;

                Console.WriteLine($"Created experiment: '{experimentResult.ResourceName}'.");
                Console.WriteLine($"Created control arm: '{controlArmResult.ResourceName}'.");
                Console.WriteLine($"Created treatment arm: '{treatmentArmResult.ResourceName}'.");
                Console.WriteLine($"Updated campaign to enable AI Max: '{campaignResult.ResourceName}'.");
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
    }
}

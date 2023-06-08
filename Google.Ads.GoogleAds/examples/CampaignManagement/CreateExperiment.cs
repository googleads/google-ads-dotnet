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
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Resources;
using Google.Ads.GoogleAds.V14.Services;
using System;
using System.Linq;
using static Google.Ads.GoogleAds.V14.Enums.ExperimentStatusEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.ExperimentTypeEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.ResponseContentTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This code example creates a new experiment, experiment arms, and demonstrates
    /// how to modify the draft campaign as well as begin the experiment.
    /// </summary>
    public class CreateExperiment : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="CreateExperiment"/> example.
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
            /// Id of the campaign for which the control arm is created.
            /// </summary>
            [Option("baseCampaignId", Required = true, HelpText =
                "Id of the campaign for which the control arm is created.")]
            public long BaseCampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            CreateExperiment codeExample = new CreateExperiment();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.BaseCampaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a new experiment, experiment arms, and demonstrates how " +
            "to modify the draft campaign as well as begin the experiment.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="baseCampaignId">Id of the campaign for which the control arm is created.</param>
        public void Run(GoogleAdsClient client, long customerId, long baseCampaignId)
        {
            // Get the ExperimentService.
            ExperimentServiceClient experimentService = client.GetService(
                Services.V14.ExperimentService);

            try
            {
                string experimentResourceName = CreateAnExperiment(client, customerId);
                MutateExperimentArmResult controlArm, treatmentArm;

                (controlArm, treatmentArm) = CreateExperimentArms(
                    client, customerId, baseCampaignId, experimentResourceName);

                ModifyDraftCampaign(client, customerId,
                    treatmentArm.ExperimentArm.InDesignCampaigns.First());

                // When you're done setting up the experiment and arms and modifying the draft
                // campaign, this will begin the experiment.
                experimentService.ScheduleExperiment(experimentResourceName);
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

        // [START create_experiment_1]
        /// <summary>
        /// Creates the experiment.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <returns>The resource name of the newly created experiment.</returns>
        private static string CreateAnExperiment(GoogleAdsClient client, long customerId)
        {
            // Get the ExperimentService.
            ExperimentServiceClient experimentService = client.GetService(
                Services.V14.ExperimentService);

            // Creates the experiment.
            Experiment experiment = new Experiment()
            {
                // Name must be unique.
                Name = $"Example Experiment #{ExampleUtilities.GetRandomString()}",
                Type = ExperimentType.SearchCustom,
                Suffix = "[experiment]",
                Status = ExperimentStatus.Setup
            };

            // Creates the operation.
            ExperimentOperation operation = new ExperimentOperation()
            {
                Create = experiment
            };

            // Makes the API call.
            MutateExperimentsResponse response = experimentService.MutateExperiments(
                customerId.ToString(), new[] { operation });

            // Displays the result.
            string experimentResourceName = response.Results.First().ResourceName;

            Console.WriteLine($"Created experiment with resource name " +
                $"'{experimentResourceName}'.");
            return experimentResourceName;
        }

        // [END create_experiment_1]

        // [START create_experiment_2]
        /// <summary>
        /// Creates the experiment arms.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="baseCampaignId">ID of the campaign for which the control arm is
        /// created.</param>
        /// <param name="experimentResourceName">Resource name of the experiment.</param>
        /// <returns>The control and treatment arms.</returns>
        private static (MutateExperimentArmResult, MutateExperimentArmResult)
            CreateExperimentArms(GoogleAdsClient client, long customerId, long baseCampaignId,
                string experimentResourceName)
        {
            // Get the ExperimentArmService.
            ExperimentArmServiceClient experimentService = client.GetService(
                Services.V14.ExperimentArmService);

            // Create the control arm. The control arm references an already-existing campaign.
            ExperimentArmOperation controlArmOperation = new ExperimentArmOperation()
            {
                Create = new ExperimentArm()
                {
                    Control = true,
                    Campaigns = {
                        ResourceNames.Campaign(customerId, baseCampaignId)
                    },
                    Experiment = experimentResourceName,
                    Name = "Control Arm",
                    TrafficSplit = 40
                }
            };

            // Create the non-control arm. The non-"control" arm, also called a "treatment" arm,
            // will automatically generate draft campaigns that you can modify before starting the
            // experiment.
            ExperimentArmOperation treatmentArmOperation = new ExperimentArmOperation()
            {
                Create = new ExperimentArm()
                {
                    Control = false,
                    Experiment = experimentResourceName,
                    Name = "Experiment Arm",
                    TrafficSplit = 60
                }
            };

            // We want to fetch the draft campaign IDs from the treatment arm, so the
            // easiest way to do that is to have the response return the newly created
            // entities.
            MutateExperimentArmsRequest request = new MutateExperimentArmsRequest
            {
                CustomerId = customerId.ToString(),
                Operations = { controlArmOperation, treatmentArmOperation },
                ResponseContentType = ResponseContentType.MutableResource
            };


            MutateExperimentArmsResponse response = experimentService.MutateExperimentArms(
                request
            );

            // Results always return in the order that you specify them in the request.
            // Since we created the treatment arm last, it will be the last result.
            MutateExperimentArmResult controlArm = response.Results.First();
            MutateExperimentArmResult treatmentArm = response.Results.Last();

            Console.WriteLine($"Created control arm with resource name " +
                $"'{controlArm.ResourceName}.");
            Console.WriteLine($"Created treatment arm with resource name" +
              $" '{treatmentArm.ResourceName}'.");
            return (controlArm, treatmentArm);
        }

        // [END create_experiment_2]

        /// <summary>
        /// Modifies the draft campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="draftCampaignResourceName">Resource name of the draft campaign.</param>
        private static void ModifyDraftCampaign(GoogleAdsClient client, long customerId,
            string draftCampaignResourceName)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(
                Services.V14.CampaignService);

            // You can change anything you like about the campaign. These are the changes you're
            // testing by doing this experiment. Here we just change the name for illustrative
            // purposes, but generally you may want to change more meaningful parts of the campaign.
            //
            // You can also change underlying resources, such as ad groups and keywords, just as
            // you would for any other campaign. When searching with the GoogleAdsService, be sure
            // to include a PARAMETERS clause with `include_drafts = true` when searching for
            // these draft entities.
            Campaign campaign = new Campaign()
            {
                ResourceName = draftCampaignResourceName,
                Name = $"Modified Campaign Name #{ExampleUtilities.GetRandomString()}"
            };

            // Creates an operation.
            CampaignOperation operation = new CampaignOperation()
            {
                Update = campaign,
                UpdateMask = FieldMasks.AllSetFieldsOf(campaign)
            };

            // Makes the API call.
            MutateCampaignsResponse response = campaignService.MutateCampaigns(
                customerId.ToString(), new[] { operation });

            // Displays the result.
            Console.WriteLine($"Updated the name for campaign {draftCampaignResourceName}.");
        }
    }
}
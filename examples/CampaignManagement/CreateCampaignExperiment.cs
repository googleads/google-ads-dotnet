// Copyright 2019 Google LLC
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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V2.Errors;
using Google.Ads.GoogleAds.V2.Resources;
using Google.Ads.GoogleAds.V2.Services;
using Google.LongRunning;
using Google.Protobuf.WellKnownTypes;
using System;
using System.Linq;
using static Google.Ads.GoogleAds.V2.Enums.CampaignExperimentTrafficSplitTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V2
{
    /// <summary>
    /// This code example adds a campaign draft for a campaign. Make sure you specify a
    /// campaign that has a budget with explicitly_shared set to false.
    /// </summary>
    public class CreateCampaignExperiment : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            CreateCampaignExperiment codeExample = new CreateCampaignExperiment();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the base campaign.
            string campaignDraftResourceName = "INSERT_CAMPAIGN_DRAFT_RESOURCE_ID_HERE";

            codeExample.Run(new GoogleAdsClient(), customerId, campaignDraftResourceName);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example adds a campaign draft for a campaign. Make sure you " +
                    "specify a campaign that has a budget with explicitly_shared set to false.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignDraftResourceName">ID of the base campaign</param>
        public void Run(GoogleAdsClient client, long customerId, string campaignDraftResourceName)
        {
            try
            {
                Operation<Empty, CreateCampaignExperimentMetadata> operation =
                    CreateExperiment(client, customerId, campaignDraftResourceName);

                Console.WriteLine("Waiting until operation completes...");
                operation.PollUntilCompleted();

                DisplayExperimentDetails(client, customerId, operation.Metadata.CampaignExperiment);
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
            }
        }

        /// <summary>
        /// Creates an experiment.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignDraftResourceName">The resource name Name of the campaign
        /// draft.</param>
        /// <returns>The long running operation for experiment creation.</returns>
        private static Operation<Empty, CreateCampaignExperimentMetadata>
            CreateExperiment(GoogleAdsClient client, long customerId,
                string campaignDraftResourceName)
        {
            // Get the CampaignExperimentService.
            CampaignExperimentServiceClient campaignExperimentService =
                client.GetService(Services.V2.CampaignExperimentService);

            CampaignExperiment experiment = new CampaignExperiment()
            {
                CampaignDraft = campaignDraftResourceName,
                Name = "Campaign Experiment - " + ExampleUtilities.GetRandomString(),
                TrafficSplitPercent = 50,
                TrafficSplitType = CampaignExperimentTrafficSplitType.RandomQuery
            };

            Operation<Empty, CreateCampaignExperimentMetadata> operation =
                campaignExperimentService.CreateCampaignExperiment(
                    customerId.ToString(), experiment);

            string experimentResourceName = operation.Metadata.CampaignExperiment;
            Console.WriteLine($"Created campaign experiment with resource name " +
                $"{experimentResourceName}");

            return operation;
        }

        /// <summary>
        /// Fetches an experiment and display its details.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="experimentResourceName">Resource name of the experiment.</param>
        /// <returns></returns>
        private static void DisplayExperimentDetails(GoogleAdsClient client, long customerId,
            string experimentResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V2.GoogleAdsService);

            // Once the draft is created, you can modify the draft campaign as if it were
            // a real campaign. For example, you may add criteria, adjust bids, or even
            // include additional ads. Adding a criterion is shown here.
            string query = $@"
                SELECT
                    campaign_experiment.experiment_campaign
                FROM
                    campaign_experiment
                WHERE
                    campaign_experiment.resource_name = '{experimentResourceName}'";

            // Get the expriment campaign resource name.
            string experimentCampaignResourceName = googleAdsService.Search(
                customerId.ToString(), query).First().CampaignExperiment.ExperimentCampaign;

            Console.WriteLine($"Experiment campaign with resource ID =" +
                $" '{experimentCampaignResourceName}' finished creating.");
        }
    }
}

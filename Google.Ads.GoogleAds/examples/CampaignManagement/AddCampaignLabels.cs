// Copyright 2020 Google LLC
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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V17.Errors;
using Google.Ads.GoogleAds.V17.Resources;
using Google.Ads.GoogleAds.V17.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V17
{
    /// <summary>
    /// This code example adds a campaign label to a list of campaigns.
    /// </summary>
    public class AddCampaignLabels : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddCampaignLabels"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// IDs of the campaigns where the campaign labels will be added.
            /// </summary>
            [Option("campaignIds", Required = true, HelpText =
                "IDs of the campaigns where the campaign labels will be added.")]
            public IEnumerable<long> CampaignIds { get; set; }

            /// <summary>
            /// The ID of the label to attach to campaigns.
            /// </summary>
            [Option("labelId", Required = true, HelpText =
                "The ID of the label to attach to campaigns.")]
            public long LabelId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddCampaignLabels codeExample = new AddCampaignLabels();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.CampaignIds.ToArray(), options.LabelId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a campaign label to a list of campaigns.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignIds">IDs of the campaigns where the campaign labels will be added.
        /// </param>
        /// <param name="labelId">The ID of the label to attach to campaigns.</param>
        // [START add_campaign_labels]
        public void Run(GoogleAdsClient client, long customerId, long[] campaignIds, long labelId)
        {
            // Get the CampaignLabelServiceClient.
            CampaignLabelServiceClient campaignLabelService =
                client.GetService(Services.V17.CampaignLabelService);

            // Gets the resource name of the label to be added across all given campaigns.
            string labelResourceName = ResourceNames.Label(customerId, labelId);

            List<CampaignLabelOperation> operations = new List<CampaignLabelOperation>();
            // Creates a campaign label operation for each campaign.
            foreach (long campaignId in campaignIds)
            {
                // Gets the resource name of the given campaign.
                string campaignResourceName = ResourceNames.Campaign(customerId, campaignId);
                // Creates the campaign label.
                CampaignLabel campaignLabel = new CampaignLabel()
                {
                    Campaign = campaignResourceName,
                    Label = labelResourceName
                };

                operations.Add(new CampaignLabelOperation()
                {
                    Create = campaignLabel
                });
            }

            // Send the operation in a mutate request.
            try
            {
                MutateCampaignLabelsResponse response =
                    campaignLabelService.MutateCampaignLabels(customerId.ToString(), operations);
                Console.WriteLine($"Added {response.Results} campaign labels:");

                foreach (MutateCampaignLabelResult result in response.Results)
                {
                    Console.WriteLine(result.ResourceName);
                }
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
        // [END add_campaign_labels]
    }
}

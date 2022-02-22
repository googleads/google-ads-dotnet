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

using CommandLine;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example removes a campaign. To get campaigns, run GetCampaigns.cs.
    /// </summary>
    public class RemoveCampaign : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="RemoveCampaign"/> example.
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
            /// ID of the campaign to be removed.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "ID of the campaign to be removed.")]
            public long CampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = new Options();
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // ID of the campaign to be removed.
                    options.CampaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

                    return 0;
                });

            RemoveCampaign codeExample = new RemoveCampaign();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.CampaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example removes a campaign. To get campaigns, run GetCampaign.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">ID of the campaign to be removed.</param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the CampaignService.
            CampaignServiceClient campaignService = client.GetService(Services.V10.CampaignService);

            // Create the operation, and set the Remove field to the resource name of the
            // campaign to be removed.
            CampaignOperation operation = new CampaignOperation()
            {
                Remove = ResourceNames.Campaign(customerId, campaignId)
            };

            try
            {
                // Remove the campaign.
                MutateCampaignsResponse retVal = campaignService.MutateCampaigns(
                    customerId.ToString(), new CampaignOperation[] { operation });

                // Display the results.
                foreach (MutateCampaignResult removedCampaign in retVal.Results)
                {
                    Console.WriteLine($"Campaign with resource name = '{0}' was removed.",
                        removedCampaign.ResourceName);
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
    }
}

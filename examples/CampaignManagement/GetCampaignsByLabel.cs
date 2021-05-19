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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example gets all campaigns with a specific label.
    /// </summary>
    public class GetCampaignsByLabel : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetCampaignsByLabel"/> example.
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
            /// ID of the label for which campaigns are retrieved.
            /// </summary>
            [Option("labelId", Required = true, HelpText =
                "ID of the label for which campaigns are retrieved.")]
            public long LabelId { get; set; }
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

                    // ID of the label for which campaigns are retrieved.
                    options.LabelId = long.Parse("INSERT_LABEL_ID_HERE");

                    return 0;
                });

            GetCampaignsByLabel codeExample = new GetCampaignsByLabel();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.LabelId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example gets all campaigns with a specific label.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="labelId">ID of the label for which campaigns are retrieved.</param>
        // [START get_campaigns_by_label]
        public void Run(GoogleAdsClient client, long customerId, long labelId)
        {
            // Get the GoogleAdsServiceClient.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V7.GoogleAdsService);

            // Creates a request that will retrieve all campaign labels with the specified
            // labelId using pages of the specified page size.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = "SELECT campaign.id, campaign.name, label.id, label.name " +
                    $"FROM campaign_label WHERE label.id = {labelId} ORDER BY campaign.id",
            };

            try
            {
                int count = 0;
                // Issues the search request and prints the result.
                foreach (GoogleAdsRow googleAdsRow in googleAdsService.Search(request))
                {
                    count++;
                    Console.WriteLine($"Campaign found with name '{googleAdsRow.Campaign.Name}'" +
                        $", ID {googleAdsRow.Campaign.Id}, and label: " +
                        $"'${googleAdsRow.Label.Name}'.");
                }
                if (count == 0)
                {
                    Console.WriteLine("No campaigns were found.");
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
        // [END get_campaigns_by_label]
    }
}

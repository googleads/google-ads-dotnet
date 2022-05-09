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
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V10.Services;
using Google.Api.Ads.Common.Util;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example illustrates how to use Google Ads API to get metrics about a campaign and
    /// serialize the result as a CSV file.
    /// </summary>
    public class CampaignReportToCsv : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="CampaignReportToCsv"/> example.
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
            /// Optional output file path. If left null, a file `CampaignReportToCsv.csv` will
            /// be created in the user's home directory.
            /// </summary>
            [Option("OutputFilePath", Required = false, HelpText =
                "Optional output file path. If left null, a file `CampaignReportToCsv.csv` will " +
                "be created in the user's home directory.")]
            public string OutputFilePath { get; set; }
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example illustrates how to get metrics about a campaign and serialize the " +
            "result as a CSV file.";

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

                    // ID of the Merchant center whose link request is to be approved.
                    options.OutputFilePath = null;

                    return 0;
                });

            CampaignReportToCsv codeExample = new CampaignReportToCsv();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.OutputFilePath);
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="outputFilePath">The path to which the CSV file is written.</param>
        public void Run(GoogleAdsClient client, long customerId, string outputFilePath)
        {
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V10.GoogleAdsService);

            // Create a query that retrieves campaigns.
            string query = @"
                SELECT
                    campaign.id,
                    campaign.name,
                    segments.date,
                    metrics.impressions,
                    metrics.clicks,
                    metrics.cost_micros
                FROM campaign
                WHERE segments.date DURING LAST_30_DAYS
                    AND campaign.status = 'ENABLED'
                ORDER BY segments.date DESC";

            // Issues a search request.
            googleAdsServiceClient.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse response)
                {
                    if (response.Results.Count() == 0)
                    {
                        Console.WriteLine("No results found!");
                        return;
                    }

                    CsvFile csvFile = new CsvFile();

                    // Set the header for the CSV file.
                    csvFile.Headers.AddRange(response.FieldMask.Paths);

                    // Iterate over all returned rows and extract the information.
                    foreach (GoogleAdsRow googleAdsRow in response.Results)
                    {
                        csvFile.Records.Add(new string[]
                        {
                            googleAdsRow.Campaign.Id.ToString(),
                            googleAdsRow.Campaign.Name,
                            googleAdsRow.Segments.Date,
                            googleAdsRow.Metrics.Impressions.ToString(),
                            googleAdsRow.Metrics.Clicks.ToString(),
                            googleAdsRow.Metrics.CostMicros.ToString()
                        });
                    }

                    if (outputFilePath == null)
                    {
                        outputFilePath =
                            Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) +
                            Path.DirectorySeparatorChar +
                            GetType().Name +
                            DateTime.Now.ToString("-yyyyMMMMdd-HHmmss") + ".csv";
                    }
                    else if (!outputFilePath.EndsWith(".csv"))
                    {
                        outputFilePath += ".csv";
                    }

                    // Create the file with the specified path, write all lines, and close it.
                    csvFile.Write(outputFilePath);

                    Console.WriteLine(
                        $"Successfully wrote {response.Results.Count()} entries to {outputFilePath}.");
                }
            );
        }
    }
}
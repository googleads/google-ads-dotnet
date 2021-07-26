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

using System;
using System.IO;
using System.Linq;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V8.Services;
using Google.Api.Ads.Common.Util;

namespace Google.Ads.GoogleAds.Examples.V8.Migration
{
    /// <summary>
    /// This code example illustrates how to use Google Ads API to get metrics about a campaign and
    /// serialize the result as a CSV file.
    /// </summary>
    public class CampaignReportToCsv : ExampleBase
    {
        // Optional output file path. If left null, a file `CampaignReportToCsv.csv` will be created
        // in the user's home directory.
        private const string OUTPUT_FILE_PATH = null;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example illustrates how to get metrics about a campaign and serialize the " +
            "result as a CSV file.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId,
            string outputFilePath = OUTPUT_FILE_PATH)
        {
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V8.GoogleAdsService);

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
                delegate(SearchGoogleAdsStreamResponse response)
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
                    // File.WriteAllText(outputFilePath, csvRows.ToString());
                    csvFile.Write(outputFilePath);

                    Console.WriteLine(
                        $"Successfully wrote {response.Results.Count()} entries to {outputFilePath}.");
                }
            );
        }
    }
}

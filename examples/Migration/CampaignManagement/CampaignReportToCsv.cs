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
using System.Reflection;
using System.Text;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V8.Services;
using Google.Api.Gax;

namespace Google.Ads.GoogleAds.Examples.V8.Migration.CampaignManagement
{
    /// <summary>
    /// This code example illustrates how to use Google Ads API to get metrics about a campaign and
    /// serialize the result as a CSV file.
    /// </summary>
    public class CampaignReportToCsv : ExampleBase
    {
        private const int PAGE_SIZE = 1000;

        // Optional output file path. If left null, a file `CampaignReportToCsv.csv` will be created
        // in the executing assembly folder.
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

            // Issues a search request with a specified page size.
            SearchGoogleAdsRequest searchGoogleAdsRequest = new SearchGoogleAdsRequest
            {
                CustomerId = customerId.ToString(),
                Query = query,
                PageSize = PAGE_SIZE
            };
            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> pagedResponse =
                googleAdsServiceClient.Search(searchGoogleAdsRequest);

            if (pagedResponse.Count() == 0)
            {
                Console.WriteLine("No results found!");
                return;
            }

            StringBuilder csvRows = new StringBuilder();

            // Set the header for the CSV file.
            csvRows.AppendLine("Campaign.Id,Campaign.Name,Segments.Date,Metrics.Impressions," +
                "Metrics.Clicks,Metrics.CostMicros");

            // Iterate over all returned rows in all pages and extract the information.
            foreach (GoogleAdsRow googleAdsRow in pagedResponse)
            {
                csvRows.AppendLine(string.Format("{0},{1},{2},{3},{4},{5}",
                    googleAdsRow.Campaign.Id,
                    googleAdsRow.Campaign.Name,
                    googleAdsRow.Segments.Date,
                    googleAdsRow.Metrics.Impressions,
                    googleAdsRow.Metrics.Clicks,
                    googleAdsRow.Metrics.CostMicros));
            }

            if (outputFilePath == null)
            {
                outputFilePath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) +
                    "/" + GetType().Name + ".csv";
            }

            // Create the file with the specified path, write all lines, and close it.
            File.WriteAllText(outputFilePath, csvRows.ToString());

            Console.WriteLine(
                $"Successfully wrote {pagedResponse.Count()} entries to {outputFilePath}.");
        }
    }
}

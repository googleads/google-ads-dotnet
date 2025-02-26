// Copyright 2023 Google LLC
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
using Google.Ads.GoogleAds.V19.Common;
using Google.Ads.GoogleAds.V19.Errors;
using Google.Ads.GoogleAds.V19.Resources;
using Google.Ads.GoogleAds.V19.Services;
using System;
using static Google.Ads.GoogleAds.V19.Enums.KeywordPlanNetworkEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V19;

/// <summary>
/// This code example generates historical metrics for keyword planning.
/// Guide: https://developers.google.com/google-ads/api/docs/keyword-planning/generate-historical-metrics
/// </summary>
public class GenerateHistoricalMetrics : ExampleBase
{
    /// <summary>
    /// Command line options for running the <see cref="GenerateHistoricalMetrics"/> example.
    /// </summary>
    public class Options : OptionsBase
    {
        /// <summary>
        /// The customer ID for which the call is made.
        /// </summary>
        [Option("customerId", Required = true, HelpText =
            "The customer ID for which the call is made.")]
        public long CustomerId { get; set; }
    }

    /// <summary>
    /// Main method, to run this code example as a standalone application.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args)
    {
        Options options = ExampleUtilities.ParseCommandLine<Options>(args);

        GenerateHistoricalMetrics codeExample = new GenerateHistoricalMetrics();
        Console.WriteLine(codeExample.Description);
        codeExample.Run(new GoogleAdsClient(), options.CustomerId);
    }

    /// <summary>
    /// Returns a description about the code example.
    /// </summary>
    public override string Description =>
        "This code example generates historical metrics for keyword planning.";

    /// <summary>
    /// Runs the code example.
    /// </summary>
    /// <param name="client">The Google Ads client.</param>
    /// <param name="customerId">The customer ID for which the call is made.</param>
    // [START generate_historical_metrics]
    public void Run(GoogleAdsClient client, long customerId)
    {
        KeywordPlanIdeaServiceClient keywordPlanIdeaService =
                client.GetService(Services.V19.KeywordPlanIdeaService);

        GenerateKeywordHistoricalMetricsRequest request =
            new GenerateKeywordHistoricalMetricsRequest()
        {
            CustomerId = customerId.ToString(),
            Keywords = { "mars cruise", "cheap cruise", "jupiter cruise" },
            // See https://developers.google.com/google-ads/api/reference/data/geotargets
            // for the list of geo target IDs.
            // Geo target constant 2840 is for USA.
            GeoTargetConstants = { ResourceNames.GeoTargetConstant(2840) },
            KeywordPlanNetwork = KeywordPlanNetwork.GoogleSearch,
            // See  https://developers.google.com/google-ads/api/reference/data/codes-formats#languages
            // for the list of language constant IDs.
            // Language constant 1000 is for English.
            Language = ResourceNames.LanguageConstant(1000)
        };

        try
        {
            GenerateKeywordHistoricalMetricsResponse response =
                keywordPlanIdeaService.GenerateKeywordHistoricalMetrics(request);

            foreach (GenerateKeywordHistoricalMetricsResult result in response.Results)
            {
                KeywordPlanHistoricalMetrics metrics = result.KeywordMetrics;

                Console.WriteLine($"The search query {result.Text}");
                Console.WriteLine("and the following variants: " +
                    $"{String.Join(",", result.CloseVariants)}");
                Console.WriteLine("Generated the following historical metrics:");

                // Approximate number of monthly searches on this query averaged for the past 12
                // months.
                Console.WriteLine($"Approximate monthly searches: {metrics.AvgMonthlySearches}");

                // The competition level for this search query.
                Console.WriteLine($"Competition level: {metrics.Competition}");

                // The competition index for the query in the range [0,100]. This shows how
                // competitive ad placement is for a keyword. The level of competition from 0-100 is
                // determined by the number of ad slots filled divided by the total number of slots
                // available. If not enough data is available, null will be returned.
                Console.WriteLine($"Competition index: {metrics.CompetitionIndex}");

                // Top of page bid low range (20th percentile) in micros for the keyword.
                Console.WriteLine($"Top of page bid low range: {metrics.LowTopOfPageBidMicros}");

                // Top of page bid high range (80th percentile) in micros for the keyword.
                Console.WriteLine($"Top of page bid high range: {metrics.HighTopOfPageBidMicros}");

                // Approximate number of searches on this query for the past twelve months.
                foreach (MonthlySearchVolume month in metrics.MonthlySearchVolumes)
                {
                    Console.WriteLine($"Approximately {month.MonthlySearches} searches in " +
                        $"{month.Month}, {month.Year}");
                }
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
    // [END generate_historical_metrics]
}
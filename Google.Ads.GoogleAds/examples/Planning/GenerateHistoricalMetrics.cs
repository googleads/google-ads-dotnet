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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V12.Common;
using Google.Ads.GoogleAds.V12.Errors;
using Google.Ads.GoogleAds.V12.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V12
{
    /// <summary>
    /// This code example generates historical metrics for a keyword plan. To create a keyword
    /// plan, run the AddKeywordPlan example.
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

            /// <summary>
            /// The keyword plan ID.
            /// </summary>
            [Option("keywordPlanId", Required = true, HelpText =
                "The keyword plan ID.")]
            public long KeywordPlanId { get; set; }
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
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.KeywordPlanId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example generates historical metrics for a keyword plan. To create a " +
                "keyword plan, run the AddKeywordPlan example.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="planId">The plan ID.</param>
        // [START generate_historical_metrics]
        public void Run(GoogleAdsClient client, long customerId, long planId)
        {
            KeywordPlanServiceClient keywordPlanIdeaServiceClient =
                client.GetService(Services.V12.KeywordPlanService);

            string resourceName = ResourceNames.KeywordPlan(customerId, planId);

            try
            {
                GenerateHistoricalMetricsResponse response =
                    keywordPlanIdeaServiceClient.GenerateHistoricalMetrics(resourceName);

                foreach (KeywordPlanKeywordHistoricalMetrics metric in response.Metrics)
                {
                    // These metrics include those for both the search query and any close
                    // variants included in the response.

                    List<string> variants = metric.CloseVariants.ToList();
                    string variantsList = (variants.Count == 0) ? "" :
                        $" (and the following variants: {string.Join(", ", variants)})";

                    Console.Write($"The search query '{metric.SearchQuery}'{variantsList} " +
                        $"generated the following historical metrics:");

                    var kwdMetric = metric.KeywordMetrics;

                    // Approximate number of monthly searches on this query averaged for the
                    // past 12 months.
                    Console.WriteLine(
                        $"\tApproximate monthly searches: {kwdMetric.AvgMonthlySearches}.");

                    // The competition level for this search query.
                    Console.WriteLine($"\tCompetition level: {kwdMetric.Competition}.");

                    // The competition index for the query in the range [0, 100]. This shows how
                    // competitive ad placement is for a keyword. The level of competition from
                    // 0-100 is determined by the number of ad slots filled divided by the total
                    // number of ad slots available. If not enough data is available, None will
                    // be returned.
                    if (metric.KeywordMetrics.HasCompetitionIndex)
                    {
                        Console.WriteLine($"\tCompetition index: {kwdMetric.CompetitionIndex}.");
                    }

                    // Top of page bid low range (20th percentile) in micros for the keyword.
                    if (kwdMetric.HasLowTopOfPageBidMicros)
                    {
                        Console.WriteLine(
                            $"\tTop of page bid low range {kwdMetric.LowTopOfPageBidMicros}.");
                    }

                    // Top of page bid high range (80th percentile) in micros for the keyword.
                    if (kwdMetric.HasHighTopOfPageBidMicros)
                    {
                        Console.WriteLine(
                            $"\tTop of page bid high range {kwdMetric.HighTopOfPageBidMicros}.");
                    }

                    // Approximate number of searches on this query for the past twelve months.
                    foreach (MonthlySearchVolume month in kwdMetric.MonthlySearchVolumes)
                    {
                        Console.WriteLine($"\tApproximately {month.MonthlySearches} searches in" +
                            $" {month.Month}, {month.Year}");
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
}
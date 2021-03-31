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
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example generates forecast metrics for a keyword plan. To create a keyword plan,
    /// run AddKeywordPlan.cs.
    /// </summary>
    public class GenerateForecastMetrics : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GenerateForecastMetrics codeExample = new GenerateForecastMetrics();
            Console.WriteLine(codeExample.Description);

            // The customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The keyword plan ID.
            long keywordPlanId = long.Parse("INSERT_KEYWORD_PLAN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, keywordPlanId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example generates forecast metrics for a keyword plan. To create a " +
            "keyword plan, run AddKeywordPlan.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The customer ID for which the call is made.</param>
        /// <param name="keywordPlanId">The keyword plan ID.</param>
        // [START generate_forecast_metrics]
        public void Run(GoogleAdsClient client, long customerId, long keywordPlanId)
        {
            KeywordPlanServiceClient kpServiceClient =
                client.GetService(Services.V6.KeywordPlanService);
            string keywordPlanResource = ResourceNames.KeywordPlan(customerId, keywordPlanId);

            try
            {
                GenerateForecastMetricsResponse response = kpServiceClient.GenerateForecastMetrics(
                    keywordPlanResource);
                int i = 0;
                foreach (KeywordPlanKeywordForecast forecast in response.KeywordForecasts)
                {
                    ForecastMetrics metrics = forecast.KeywordForecast;
                    Console.WriteLine($"{++i}) Keyword ID: {forecast.KeywordPlanAdGroupKeyword}");
                    Console.WriteLine($"Estimated daily clicks: {metrics.Clicks}");
                    Console.WriteLine($"Estimated daily impressions: {metrics.Impressions}");
                    Console.WriteLine($"Estimated average cpc (micros): {metrics.AverageCpc}\n");
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
        // [END generate_forecast_metrics]
    }
}

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
using Google.Ads.GoogleAds.V9.Errors;
using Google.Ads.GoogleAds.V9.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example gets Hotel-ads performance statistics for the 50 Hotel ad groups with
    /// the most impressions over the last 7 days.
    /// </summary>
    public class GetHotelAdsPerformance : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetHotelAdsPerformance"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }
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

                    return 0;
                });

            GetHotelAdsPerformance codeExample = new GetHotelAdsPerformance();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example gets Hotel-ads performance statistics for the 50 Hotel ad groups " +
            "with the most impressions over the last 7 days.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V9.GoogleAdsService);

            // Creates a query that retrieves hotel-ads statistics for each campaign and ad group.
            // Returned statistics will be segmented by the check-in day of week and length of
            // stay.
            String query =
                $@"SELECT
                      campaign.id,
                      campaign.advertising_channel_type,
                      ad_group.id,
                      ad_group.status,
                      metrics.impressions,
                      metrics.hotel_average_lead_value_micros,
                      segments.hotel_check_in_day_of_week,
                      segments.hotel_length_of_stay
                  FROM hotel_performance_view
                  WHERE
                      segments.date DURING LAST_7_DAYS
                    AND campaign.advertising_channel_type = 'HOTEL'
                    AND ad_group.status = 'ENABLED'
                 ORDER BY metrics.impressions DESC
                 LIMIT 50";

            try
            {
                // Issue a search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> result =
                    googleAdsService.Search(customerId.ToString(), query);

                // Display the results.
                foreach (GoogleAdsRow row in result)
                {
                    Console.WriteLine(
                        $"Ad group ID {row.AdGroup.Id} in campaign ID {row.Campaign.Id} " +
                        $"with hotel check-in on {row.Segments.HotelCheckInDayOfWeek} and " +
                        $"{row.Segments.HotelLengthOfStay} day(s) of stay had " +
                        $"{row.Metrics.Impressions} impression(s) and " +
                        $"{row.Metrics.HotelAverageLeadValueMicros:0.00} average lead value " +
                        "(in micros) during the last 7 days.");
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

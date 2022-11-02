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
using Google.Ads.GoogleAds.V12.Errors;
using Google.Ads.GoogleAds.V12.Resources;
using Google.Ads.GoogleAds.V12.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V12.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.SeasonalityEventScopeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V12
{
    /// <summary>
    /// This code example adds a channel-level seasonality adjustment that adjusts Smart Bidding
    /// behavior by the expected change in conversion rate for the given future time interval.
    ///
    /// For more information on using seasonality adjustments, see
    /// https://developers.google.com/google-ads/api/docs/campaigns/bidding/seasonality-adjustments.
    /// </summary>
    public class AddBiddingSeasonalityAdjustment : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddBiddingSeasonalityAdjustment"/> example.
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
            /// The start time of the seasonality adjustment (in yyyy-MM-dd HH:mm:ss format) in
            /// the account's timezone.
            /// </summary>
            [Option("startDateTime", Required = true, HelpText =
                "The start time of the seasonality adjustment (in yyyy-MM-dd HH:mm:ss format) " +
                "in the account's timezone.")]
            public string StartDateTime { get; set; }

            /// <summary>
            /// The end time of the seasonality adjustment (in yyyy-MM-dd HH:mm:ss format) in
            /// the account's timezone.
            /// </summary>
            [Option("endDateTime", Required = true, HelpText =
                "The end time of the seasonality adjustment (in yyyy-MM-dd HH:mm:ss format) in " +
                "the account's timezone.")]
            public string EndDateTime { get; set; }

            /// <summary>
            /// The conversion rate adjustment (an increase or a decrease), which accounts for
            /// estimated changes in conversion rate due to a future event.
            /// </summary>
            [Option("conversionRateModifier", Required = true, HelpText =
                "The conversion rate adjustment (an increase or a decrease), which accounts for " +
                "estimated changes in conversion rate due to a future event.")]
            public double ConversionRateModifier { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddBiddingSeasonalityAdjustment codeExample = new AddBiddingSeasonalityAdjustment();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.StartDateTime,
                options.EndDateTime, options.ConversionRateModifier);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a channel-level seasonality adjustment that adjusts Smart " +
            "Bidding behavior by the expected change in conversion rate for the given future " +
            "time interval. For more information on using seasonality adjustments, see " +
            "https://developers.google.com/google-ads/api/docs/campaigns/bidding/seasonality-adjustments.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="startDateTime">The start time of the data exclusion (in
        /// yyyy-MM-dd HH:mm:ss format) in the account's timezone.</param>
        /// <param name="endDateTime">The end time of the data exclusion (in
        /// yyyy-MM-dd HH:mm:ss format) in the account's timezone.</param>
        /// <param name="conversionRateModifier">The conversion rate adjustment (an increase or a
        /// decrease), which accounts for estimated changes in conversion rate due to a future
        /// event.</param>
        public void Run(GoogleAdsClient client, long customerId, string startDateTime,
            string endDateTime, double conversionRateModifier)
        {
            // Get the BiddingSeasonalityAdjustmentServiceClient.
            BiddingSeasonalityAdjustmentServiceClient biddingSeasonalityAdjustmentService =
                client.GetService(Services.V12.BiddingSeasonalityAdjustmentService);


            // [START add_bidding_seasonality_adjustment]
            BiddingSeasonalityAdjustment seasonalityAdjustment =
                new BiddingSeasonalityAdjustment()
                {
                    // A unique name is required for every seasonality adjustment.
                    Name = "Seasonality adjustment #" + ExampleUtilities.GetRandomString(),
                    // The CHANNEL scope applies the conversionRateModifier to all campaigns of
                    // specific advertising channel types. In this example, the
                    // conversionRateModifier will only apply to Search campaigns. Use the
                    // CAMPAIGN scope to instead limit the scope to specific campaigns.
                    Scope = SeasonalityEventScope.Channel,
                    AdvertisingChannelTypes = { AdvertisingChannelType.Search },
                    // If setting scope CAMPAIGN, add individual campaign resource name(s)
                    // according to the commented out line below.
                    // Campaigns = { "INSERT_CAMPAIGN_RESOURCE_NAME_HERE" },
                    // The date range should be less than 14 days.
                    StartDateTime = startDateTime,
                    EndDateTime = endDateTime,
                    // The conversionRateModifier is the expected future conversion rate change.
                    // When this field is unset or set to 1.0, no adjustment will be applied to
                    // traffic. The allowed range is 0.1 to 10.0.
                    ConversionRateModifier = conversionRateModifier
                };

            BiddingSeasonalityAdjustmentOperation operation =
                new BiddingSeasonalityAdjustmentOperation()
                {
                    Create = seasonalityAdjustment
                };

            try
            {
                MutateBiddingSeasonalityAdjustmentsResponse response =
                    biddingSeasonalityAdjustmentService.MutateBiddingSeasonalityAdjustments(
                        customerId.ToString(), new[] { operation });
                Console.WriteLine($"Added seasonality adjustment with resource name: " +
                    $"{response.Results[0].ResourceName}");
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
            // [END add_bidding_seasonality_adjustment]
        }
    }
}
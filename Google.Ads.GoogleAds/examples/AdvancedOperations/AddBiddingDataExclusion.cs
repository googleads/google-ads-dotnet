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
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Resources;
using Google.Ads.GoogleAds.V14.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V14.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V14.Enums.SeasonalityEventScopeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This code example adds a channel-level data exclusion that excludes conversions from
    /// being used by Smart Bidding for the time interval specified.
    ///
    /// For more information on using data exclusions, see
    /// https://developers.google.com/google-ads/api/docs/campaigns/bidding/data-exclusions.
    /// </summary>
    public class AddBiddingDataExclusion : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddBiddingDataExclusion"/> example.
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
            /// The start date time in yyyy-MM-dd HH:mm:ss format of the data exclusion period.
            /// </summary>
            [Option("startDateTime", Required = true, HelpText =
                "The start date time in yyyy-MM-dd HH:mm:ss format of the data exclusion period.")]
            public string StartDateTime { get; set; }

            /// <summary>
            /// The end date time in yyyy-MM-dd HH:mm:ss format of the data exclusion period.
            /// </summary>
            [Option("endDateTime", Required = true, HelpText =
                "The end date time in yyyy-MM-dd HH:mm:ss format of the data exclusion period.")]
            public string EndDateTime { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddBiddingDataExclusion codeExample = new AddBiddingDataExclusion();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.StartDateTime,
                options.EndDateTime);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a channel-level data exclusion that excludes conversions " +
            "from being used by Smart Bidding for the time interval specified. For more " +
            "information on using data exclusions, see " +
            "https://developers.google.com/google-ads/api/docs/campaigns/bidding/data-exclusions.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="startDateTime">The start time of the data exclusion (in
        /// yyyy-MM-dd HH:mm:ss format) in the account's timezone.</param>
        /// <param name="endDateTime">The end time of the data exclusion (in
        /// yyyy-MM-dd HH:mm:ss format) in the account's timezone.</param>
        public void Run(GoogleAdsClient client, long customerId, string startDateTime,
            string endDateTime)
        {
            // Get the BiddingDataExclusionServiceClient.
            BiddingDataExclusionServiceClient biddingDataExclusionService =
                client.GetService(Services.V14.BiddingDataExclusionService);

            // [START add_bidding_data_exclusion]
            BiddingDataExclusion dataExclusion = new BiddingDataExclusion()
            {
                // A unique name is required for every data exclusion.
                Name = "Data exclusion #" + ExampleUtilities.GetRandomString(),
                // The CHANNEL scope applies the data exclusion to all campaigns of specific
                // advertising channel types. In this example, the the exclusion will only apply to
                // Search campaigns. Use the CAMPAIGN scope to instead limit the scope to specific
                // campaigns.
                Scope = SeasonalityEventScope.Channel,
                AdvertisingChannelTypes = { AdvertisingChannelType.Search },
                // The date range should be less than 14 days.
                StartDateTime = startDateTime,
                EndDateTime = endDateTime,
            };
            BiddingDataExclusionOperation operation = new BiddingDataExclusionOperation()
            {
                Create = dataExclusion
            };

            try
            {
                MutateBiddingDataExclusionsResponse response =
                    biddingDataExclusionService.MutateBiddingDataExclusions(
                        customerId.ToString(), new[] { operation });
                Console.WriteLine($"Added data exclusion with resource name: " +
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
            // [END add_bidding_data_exclusion]
        }
    }
}

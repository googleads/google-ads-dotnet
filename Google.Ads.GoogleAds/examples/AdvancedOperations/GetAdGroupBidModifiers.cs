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
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V17.Errors;
using Google.Ads.GoogleAds.V17.Resources;
using Google.Ads.GoogleAds.V17.Services;
using Google.Api.Gax;
using System;
using static Google.Ads.GoogleAds.V17.Resources.AdGroupBidModifier;

namespace Google.Ads.GoogleAds.Examples.V17
{
    /// <summary>
    /// This code example gets ad group bid modifiers.
    /// </summary>
    public class GetAdGroupBidModifiers : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetAdGroupBidModifiers"/> example.
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
            /// The ad group ID for which ad group bid modiifers will be retrieved.
            /// </summary>
            [Option("adGroupId", Required = false, HelpText =
                "The ad group ID for which ad group bid modiifers will be retrieved.")]
            public long? AdGroupId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GetAdGroupBidModifiers codeExample = new GetAdGroupBidModifiers();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example gets ad group bid modifiers.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group ID for which ad group bid modiifers will
        /// be retrieved.</param>
        public void Run(GoogleAdsClient client, long customerId, long? adGroupId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V17.GoogleAdsService);

            string searchQuery = @"
                SELECT
                    ad_group.id,
                    ad_group_bid_modifier.criterion_id,
                    campaign.id,
                    ad_group_bid_modifier.bid_modifier,
                    ad_group_bid_modifier.device.type,
                    ad_group_bid_modifier.hotel_date_selection_type.type,
                    ad_group_bid_modifier.hotel_advance_booking_window.min_days,
                    ad_group_bid_modifier.hotel_advance_booking_window.max_days,
                    ad_group_bid_modifier.hotel_length_of_stay.min_nights,
                    ad_group_bid_modifier.hotel_length_of_stay.max_nights,
                    ad_group_bid_modifier.hotel_check_in_day.day_of_week,
                    ad_group_bid_modifier.hotel_check_in_date_range.start_date,
                    ad_group_bid_modifier.hotel_check_in_date_range.end_date
                FROM
                    ad_group_bid_modifier";

            if (adGroupId != null)
            {
                searchQuery += $" WHERE ad_group.id = {adGroupId}";
            }

            searchQuery += " LIMIT 10000";
            // Creates a request that will retrieve ad group bid modifiers.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = searchQuery
            };
            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                // Iterates over all rows in all pages and prints the requested field values for
                // the ad group bid modifiers in each row.
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    AdGroupBidModifier agBidModifier = googleAdsRow.AdGroupBidModifier;
                    AdGroup adGroup = googleAdsRow.AdGroup;
                    Campaign campaign = googleAdsRow.Campaign;
                    Console.Write("Ad group bid modifier with criterion ID {0} in ad group " +
                        "with ID {1} of campaign ID {2} ",
                        agBidModifier.CriterionId,
                        adGroup.Id, campaign.Id);

                    // When working with an 'optional' protocol buffer field such as
                    // AdGroup.bidModifier, use HasXX to check if the field is set, and only
                    // retrieve the value if HasXX returns true. See the protocol buffer
                    // documentation on field presence for more information:
                    // https://protobuf.dev/programming-guides/field_presence/#presence-in-proto3-apis
                    if (agBidModifier.HasBidModifier)
                    {
                        // Prints the bid modifier value since it is set.
                        Console.WriteLine("has a bid modifier value of {0:0.00}.",
                            agBidModifier.BidModifier);
                    }
                    else
                    {
                        // Does not print the bid modifier value since it is not set. Printing the
                        // result of agBidModifier.BidModifier in this case would be misleading,
                        // since it will be 0.
                        Console.WriteLine("does NOT have a bid modifier value.");
                    }

                    string criterionDetails = "  - Criterion type: " +
                        $"{agBidModifier.CriterionCase}, ";
                    switch (agBidModifier.CriterionCase)
                    {
                        case CriterionOneofCase.Device:
                            criterionDetails += $"Type: {agBidModifier.Device.Type}";
                            break;

                        case CriterionOneofCase.HotelAdvanceBookingWindow:
                            criterionDetails +=
                                $"Min Days: {agBidModifier.HotelAdvanceBookingWindow.MinDays}," +
                                $"Max Days: {agBidModifier.HotelAdvanceBookingWindow.MaxDays}";
                            break;

                        case CriterionOneofCase.HotelCheckInDay:
                            criterionDetails += $"Day of the week: " +
                                $"{agBidModifier.HotelCheckInDay.DayOfWeek}";
                            break;

                        case CriterionOneofCase.HotelDateSelectionType:
                            criterionDetails += $"Date selection type: " +
                                $"{agBidModifier.HotelDateSelectionType.Type}";
                            break;

                        case CriterionOneofCase.HotelLengthOfStay:
                            criterionDetails +=
                                $"Min Nights: {agBidModifier.HotelLengthOfStay.MinNights}," +
                                $"Max Nights: {agBidModifier.HotelLengthOfStay.MaxNights}";
                            break;

                        case CriterionOneofCase.HotelCheckInDateRange:
                            criterionDetails +=
                                $"Start Date: {agBidModifier.HotelCheckInDateRange.StartDate}," +
                                $"End Date: {agBidModifier.HotelCheckInDateRange.EndDate}";
                            break;
                    }
                    Console.WriteLine(criterionDetails);
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

// Copyright 2018 Google LLC
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
using Google.Ads.GoogleAds.V0.Common;
using Google.Ads.GoogleAds.V0.Resources;
using Google.Ads.GoogleAds.V0.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V0 {

  /// <summary>
  /// This code example shows how to add ad group bid modifiers to a hotel ad group.
  /// </summary>
  /// <remarks>
  /// Ad group bid modifiers based on hotel check-in day and hotel length of stay will be added.
  ///
  /// For hotel check-in day, you need to specify the resource name, which includes the fixed
  /// criterion ID of the check-in day you want to set. In addition, you don't set
  /// <see cref="AdGroupBidModifier.AdGroup"/> for this bid modifier type.
  ///
  /// For hotel length of stay, you don't need to specify the resource name, but need to set
  /// <see cref="AdGroupBidModifier.AdGroup"/> instead.
  /// </remarks>
  public class AddHotelAdGroupBidModifiers : ExampleBase {

    // Specify the check-in day criterion ID here (in this example, 60, which represents Monday,
    // is used). See the table of check-in days and criterion IDs at:
    // https://developers.google.com/google-ads/api/docs/hotel-ads/create-ad-group-bid-modifier#hotelcheckindayinfo.
    private const int HOTEL_CHECK_IN_DAY_CRITERION_ID = 60;

    /// <summary>
    /// Main method, to run this code example as a standalone application.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args) {
      AddHotelAdGroupBidModifiers codeExample = new AddHotelAdGroupBidModifiers();
      Console.WriteLine(codeExample.Description);

      // The AdWords customer ID for which the call is made.
      long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

      // The ad group to which bid modifiers are set.
      long adGroupId = long.Parse("INSERT_ADGROUP_ID_HERE");

      codeExample.Run(new GoogleAdsClient(), customerId, adGroupId);
    }

    /// <summary>
    /// Returns a description about the code example.
    /// </summary>
    public override string Description {
      get {
        return "This code example shows how to add ad group bid modifiers to a hotel ad group.";
      }
    }

    /// <summary>
    /// Runs the code example.
    /// </summary>
    /// <param name="client">The Google Ads client.</param>
    /// <param name="customerId">The AdWords customer ID for which the call is made.</param>
    /// <param name="adGroupId">The ad group to which bid modifiers are set.</param>
    public void Run(GoogleAdsClient client, long customerId, long adGroupId) {
      // Get the AdGroupBidModifierService.
      AdGroupBidModifierServiceClient service = client.GetService(
          Services.V0.AdGroupBidModifierService);

      // 1) Create an ad group bid modifier based on the hotel check-in day.
      AdGroupBidModifier checkInDayAdGroupBidModifier = new AdGroupBidModifier() {
        ResourceName = ResourceNames.AdGroupBidModifier(customerId, adGroupId,
            HOTEL_CHECK_IN_DAY_CRITERION_ID),

        // Set the bid modifier value to 150%.
        BidModifier = 1.5,
        HotelCheckInDay = new HotelCheckInDayInfo()
      };

      // Creates an ad group bid modifier operation.
      var checkInDayAdGroupBidModifierOperation = new AdGroupBidModifierOperation() {
        Create = checkInDayAdGroupBidModifier
      };

      // 2) Create an ad group bid modifier based on the hotel length of stay.
      AdGroupBidModifier lengthOfStayAdGroupBidModifier = new AdGroupBidModifier() {
        // Set the ad group.
        AdGroup = ResourceNames.AdGroup(customerId, adGroupId),

        // Set the hotel length of stay info.
        HotelLengthOfStay = new HotelLengthOfStayInfo() {
          MinNights = 3,
          MaxNights = 7
        },

        // Set the bid modifier value to 170%.
        BidModifier = 1.7
      };

      // Create an ad group bid modifier operation.
      var lengthOfStayAdGroupBidModifierOperation = new AdGroupBidModifierOperation() {
        Create = lengthOfStayAdGroupBidModifier
      };

      try {
        // Issue a mutate request to add an ad group bid modifiers.
        MutateAdGroupBidModifiersResponse response = service.MutateAdGroupBidModifiers(
            customerId.ToString(),
            new AdGroupBidModifierOperation[] {
              checkInDayAdGroupBidModifierOperation,
              lengthOfStayAdGroupBidModifierOperation
            }
        );

        // Display the resource names of the added ad group bid modifiers.
        Console.WriteLine($"Added {response.Results.Count} hotel ad group bid modifiers:");

        foreach (MutateAdGroupBidModifierResult result in response.Results) {
          Console.WriteLine($"- {result.ResourceName}");
        }
      } catch (GoogleAdsException e) {
        Console.WriteLine("Failure:");
        Console.WriteLine($"Message: {e.Message}");
        Console.WriteLine($"Failure: {e.Failure}");
        Console.WriteLine($"Request ID: {e.RequestId}");
      }
    }
  }
}

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
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Enums;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;
using System;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example illustrates how to update an ad group, setting its status to 'PAUSED',
    /// and its CPC bid to a new value if specified. To create an ad group, run AddAdGroup.cs.
    /// </summary>
    public class UpdateAdGroup : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UpdateAdGroup codeExample = new UpdateAdGroup();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the ad group to be updated.
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            // Optional: Provide a cpc bid for the ad group, in micro amounts.
            long? cpcBidMicroAmount = null;

            long tempVal = 0;
            if (long.TryParse("INSERT_CPC_BID_IN_MICROS_HERE", out tempVal))
            {
                cpcBidMicroAmount = tempVal;
            }

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId, cpcBidMicroAmount);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            " This code example illustrates how to update an ad group, setting its status to " +
            "'PAUSED', and its CPC bid to a new value if specified. To create an ad group, run " +
            "AddAdGroup.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">Id of the ad group to be updated.</param>
        /// <param name="cpcBidMicroAmount">The CPC bid amount for the ad group in micros.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId,
            long? cpcBidMicroAmount)
        {
            AdGroupServiceClient adGroupService = client.GetService(Services.V4.AdGroupService);

            // Create an ad group with the specified ID.
            AdGroup adGroup = new AdGroup();
            adGroup.ResourceName = ResourceNames.AdGroup(customerId, adGroupId);

            // Pause the ad group.
            adGroup.Status = AdGroupStatusEnum.Types.AdGroupStatus.Paused;

            // Update the CPC bid if specified.
            if (cpcBidMicroAmount != null)
            {
                adGroup.CpcBidMicros = cpcBidMicroAmount;
            }

            // Create the operation.
            AdGroupOperation operation = new AdGroupOperation()
            {
                Update = adGroup,
                UpdateMask = FieldMasks.AllSetFieldsOf(adGroup)
            };

            try
            {
                // Update the ad group.
                MutateAdGroupsResponse retVal = adGroupService.MutateAdGroups(
                    customerId.ToString(), new AdGroupOperation[] { operation });

                // Display the results.
                MutateAdGroupResult adGroupResult = retVal.Results[0];

                Console.WriteLine($"Ad group with resource name '{adGroupResult.ResourceName}' " +
                    "was updated.");
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

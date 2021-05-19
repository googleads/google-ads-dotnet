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
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V7.Enums;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example illustrates how to update an ad group, setting its status to 'PAUSED',
    /// and its CPC bid to a new value if specified. To create an ad group, run AddAdGroup.cs.
    /// </summary>
    public class UpdateAdGroup : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UpdateAdGroup"/> example.
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
            /// Id of the ad group to be updated.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "Id of the ad group to be updated.")]
            public long AdGroupId { get; set; }

            /// <summary>
            /// The CPC bid amount for the ad group in micros.
            /// </summary>
            [Option("cpcBidMicroAmount", Required = false, HelpText =
                "The CPC bid amount for the ad group in micros.")]
            public long? CpcBidMicroAmount { get; set; }
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

                    // Id of the ad group to be updated.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    // The CPC bid amount for the ad group in micros.
                    long tempVal = 0;
                    if (long.TryParse("INSERT_CPC_BID_MICRO_AMOUNT_HERE", out tempVal))
                    {
                        options.CpcBidMicroAmount = tempVal;
                    }

                    return 0;
                });

            UpdateAdGroup codeExample = new UpdateAdGroup();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.AdGroupId,
                options.CpcBidMicroAmount);
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
        // [START update_ad_group]
        public void Run(GoogleAdsClient client, long customerId, long adGroupId,
            long? cpcBidMicroAmount)
        {
            AdGroupServiceClient adGroupService = client.GetService(Services.V7.AdGroupService);

            // Create an ad group with the specified ID.
            AdGroup adGroup = new AdGroup();
            adGroup.ResourceName = ResourceNames.AdGroup(customerId, adGroupId);

            // Pause the ad group.
            adGroup.Status = AdGroupStatusEnum.Types.AdGroupStatus.Paused;

            // Update the CPC bid if specified.
            if (cpcBidMicroAmount != null)
            {
                adGroup.CpcBidMicros = cpcBidMicroAmount.Value;
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
        // [END update_ad_group]
    }
}

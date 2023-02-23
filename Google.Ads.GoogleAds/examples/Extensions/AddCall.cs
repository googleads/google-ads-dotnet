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
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V13.Common;
using Google.Ads.GoogleAds.V13.Enums;
using Google.Ads.GoogleAds.V13.Errors;
using Google.Ads.GoogleAds.V13.Resources;
using Google.Ads.GoogleAds.V13.Services;
using Google.Protobuf;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading;
using static Google.Ads.GoogleAds.V13.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.AssetFieldTypeEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.CallConversionReportingStateEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.DayOfWeekEnum.Types;
using static Google.Ads.GoogleAds.V13.Enums.MinuteOfHourEnum.Types;

using SystemDayOfWeek = System.DayOfWeek;
using DayOfWeek = Google.Ads.GoogleAds.V13.Enums.DayOfWeekEnum.Types.DayOfWeek;

namespace Google.Ads.GoogleAds.Examples.V13
{
    /// <summary>
    /// This example adds a call extension to a specific account.
    /// </summary>
    public class AddCall : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddCall"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// Optional: The phone number country.
            ///
            /// Specifies the phone country code here or the default specified in <see cref="Main"/>
            /// will be used. See supported codes at:
            /// https://developers.google.com/google-ads/api/reference/data/codes-formats#expandable-17
            /// </summary>
            [Option("phoneCountry", Required = false, HelpText =
                "The phone number country.")]
            public string PhoneCountry { get; set; }

            /// <summary>
            /// The phone number itself.
            /// </summary>
            [Option("phoneNumber", Required = true, HelpText =
                "The phone number itself.")]
            public string PhoneNumber { get; set; }

            /// <summary>
            /// Optional: Specifies the conversion action ID to attribute call conversions to. If not set,
            /// the default conversion action is used.
            /// </summary>
            [Option("conversionActionId", Required = false, HelpText =
                "The conversion action ID.")]
            public long? ConversionActionId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddCall codeExample = new AddCall();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(
                new GoogleAdsClient(),
                options.CustomerId,
                options.PhoneCountry,
                options.PhoneNumber,
                options.ConversionActionId
            );
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example adds a call ad to a given ad group.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="phoneCountry">The phone number country.</param>
        /// <param name="phoneNumber">The phone number itself.</param>
        /// <param name="conversionActionId">The conversion action ID or null.</param>
        public void Run(
            GoogleAdsClient client,
            long customerId,
            string phoneCountry,
            string phoneNumber,
            long? conversionActionId)
        {
            try
            {
                // Creates the asset for the call extensions.
                string assetResourceName = AddExtensionAsset(
                    client,
                    customerId,
                    phoneCountry,
                    phoneNumber,
                    conversionActionId
                );

                // Adds the extensions at the account level, so these will serve in all eligible
                // campaigns.
                LinkAssetToAccount(client, customerId, assetResourceName);
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

        /// <summary>
        /// Creates a new asset for the call.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="phoneCountry">The phone number country.</param>
        /// <param name="phoneNumber">The phone number itself.</param>
        /// <param name="conversionActionId">The conversion action ID or null.</param>
        /// <returns>The resource name of the created call asset</returns>
        private string AddExtensionAsset(
            GoogleAdsClient client,
            long customerId,
            string phoneCountry,
            string phoneNumber,
            long? conversionActionId)
        {
            // Creates the call asset.
            CallAsset callAsset = new CallAsset()
            {
                // Sets the country code and phone number of the business to call.
                CountryCode = phoneCountry,
                PhoneNumber = phoneNumber,

                // Optional: Specifies all day and time intervals for which the asset may serve.
                AdScheduleTargets = {
                    new AdScheduleInfo()
                    {
                        // Sets the day of this schedule as Monday.
                        DayOfWeek = DayOfWeek.Monday,

                        // Sets the start hour to 9am.
                        StartHour = 9,

                        // Sets the end hour to 5pm.
                        EndHour = 17,

                        // Sets the start and end minute of zero, for example: 9:00 and 5:00.
                        StartMinute = MinuteOfHour.Zero,
                        EndMinute = MinuteOfHour.Zero
                    }
                }
            };

            // Sets the conversion action ID to the one provided if any.
            if (conversionActionId.HasValue)
            {
                callAsset.CallConversionAction =
                    ResourceNames.ConversionAction(customerId, conversionActionId.Value);

                callAsset.CallConversionReportingState =
                    CallConversionReportingState.UseResourceLevelCallConversionAction;
            }

            // Creates an asset operation wrapping the call asset in an asset.
            AssetOperation assetOperation = new AssetOperation()
            {
                Create = new Asset()
                {
                    CallAsset = callAsset
                }
            };

            AssetServiceClient assetServiceClient =
                client.GetService(Services.V13.AssetService);

            // Issues a mutate request to add the asset and prints its information.
            MutateAssetsResponse response = assetServiceClient.MutateAssets(
                customerId.ToString(),
                new[] { assetOperation }
            );

            string createdAssetResourceName = response.Results.First().ResourceName;

            Console.WriteLine(
                $"Created a call asset with resource name: '{createdAssetResourceName}'."
            );

            return createdAssetResourceName;
        }

        /// <summary>
        /// Links the call asset at the account level to serve in all eligible campaigns.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="assetResourceName">The resource name of the call asset.</param>
        private void LinkAssetToAccount(
            GoogleAdsClient client,
            long customerId,
            string assetResourceName)
        {
            // Creates a customer asset operation wrapping the call asset in a customer asset.
            CustomerAssetOperation customerAssetOperation = new CustomerAssetOperation()
            {
                Create = new CustomerAsset()
                {
                    Asset = assetResourceName,
                    FieldType = AssetFieldType.Call
                }
            };

            CustomerAssetServiceClient customerAssetServiceClient =
                client.GetService(Services.V13.CustomerAssetService);

            // Issues a mutate request to add the customer asset and prints its information.
            MutateCustomerAssetsResponse response = customerAssetServiceClient.MutateCustomerAssets(
                customerId.ToString(),
                new[] { customerAssetOperation }
            );

            string resourceName = response.Results.First().ResourceName;

            Console.WriteLine(
                $"Created a customer asset with resource name: '{resourceName}'."
            );
        }
    }
}

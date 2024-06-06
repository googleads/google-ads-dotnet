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
using Google.Ads.GoogleAds.V17.Common;
using Google.Ads.GoogleAds.V17.Errors;
using Google.Ads.GoogleAds.V17.Resources;
using Google.Ads.GoogleAds.V17.Services;
using System.Linq;
using System;
using static Google.Ads.GoogleAds.V17.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V17.Enums.CallConversionReportingStateEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V17
{
    /// <summary>
    /// This example adds a call ad to a given ad group. More information about call ads can be
    /// found at https://support.google.com/google-ads/answer/6341403.
    /// To get ad groups, run GetAdGroups.cs.
    /// </summary>
    public class AddCallAd : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddCallAd"/> example.
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
            /// The ad group ID.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "The ad group ID.")]
            public long AdGroupId { get; set; }

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
            /// Optional: Specifies the conversion action ID to attribute call conversions
            /// to. If not set, the default conversion action is used.
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

            AddCallAd codeExample = new AddCallAd();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(
                new GoogleAdsClient(),
                options.CustomerId,
                options.AdGroupId,
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
        /// <param name="adGroupId">The ad group ID.</param>
        /// <param name="phoneCountry">The phone number country.</param>
        /// <param name="phoneNumber">The phone number itself.</param>
        /// <param name="conversionActionId">The conversion action ID or null.</param>
        public void Run(
            GoogleAdsClient client,
            long customerId,
            long adGroupId,
            string phoneCountry,
            string phoneNumber,
            long? conversionActionId)
        {
            try
            {
                // Creates an ad group ad for the new ad.
                AdGroupAd adGroupAd = new AdGroupAd()
                {
                    AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                    Status = AdGroupAdStatus.Paused,
                    Ad = new Ad()
                    {
                        // The URL of the webpage to refer to.
                        FinalUrls = { "https://www.example.com" },
                        CallAd = new CallAdInfo()
                        {
                            BusinessName = "Google",
                            Headline1 = "Travel",
                            Headline2 = "Discover",
                            Description1 = "Travel the World",
                            Description2 = "Travel the Universe",

                            // Sets the country code and phone number of the business to call.
                            CountryCode = phoneCountry,
                            PhoneNumber = phoneNumber,

                            // Sets the verification URL to a webpage that includes the phone
                            // number.
                            PhoneNumberVerificationUrl = "https://www.example.com/contact",

                            // The fields below are optional.

                            // Configures call tracking and reporting.
                            CallTracked = true,
                            DisableCallConversion = false,

                            // Sets path parts to append for display.
                            Path1 = "services",
                            Path2 = "travels",
                        }
                    }
                };

                // Sets the conversion action ID to the one provided if any.
                if (conversionActionId.HasValue)
                {
                    adGroupAd.Ad.CallAd.ConversionAction =
                        ResourceNames.ConversionAction(customerId, conversionActionId.Value);

                    adGroupAd.Ad.CallAd.ConversionReportingState =
                        CallConversionReportingState.UseResourceLevelCallConversionAction;
                }

                // Creates an ad group ad operation.
                AdGroupAdOperation adGroupAdOperation = new AdGroupAdOperation()
                {
                    Create = adGroupAd
                };

                // Issues a mutate request to add the ad group ad.
                AdGroupAdServiceClient adGroupAdServiceClient =
                    client.GetService(Services.V17.AdGroupAdService);

                MutateAdGroupAdsResponse adGroupAdResponse =
                    adGroupAdServiceClient.MutateAdGroupAds(
                        customerId.ToString(),
                        new[] { adGroupAdOperation }
                    );

                string adGroupAdResourceName = adGroupAdResponse.Results.First().ResourceName;

                Console.WriteLine(
                    $"Created ad group ad with resource name: '{adGroupAdResourceName}'."
                );
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

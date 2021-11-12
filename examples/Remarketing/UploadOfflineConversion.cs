// Copyright 2020 Google LLC
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
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example imports offline conversion values for specific clicks to your account.
    /// To get Google Click ID for a click, use the "click_view" resource:
    /// https://developers.google.com/google-ads/api/fields/latest/click_view.
    /// To set up a conversion action, run the AddConversionAction.cs example.
    /// </summary>
    public class UploadOfflineConversion : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadOfflineConversion"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for the conversion action is added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for the conversion action is added.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The conversion action ID.
            /// </summary>
            [Option("conversionActionId", Required = true, HelpText =
                "The conversion action ID.")]
            public long ConversionActionId { get; set; }

            /// <summary>
            /// The conversion time in "yyyy-mm-dd hh:mm:ss+|-hh:mm" format.
            /// </summary>
            [Option("conversionTime", Required = true, HelpText =
                "The conversion time.")]
            public string ConversionTime { get; set; }

            /// <summary>
            /// The click ID.
            /// </summary>
            [Option("gclid", Required = true, HelpText =
                "The click ID.")]
            public string Gclid { get; set; }

            /// <summary>
            /// The convsersion value.
            /// </summary>
            [Option("conversionValue", Required = true, HelpText =
                "The convsersion value.")]
            public double ConversionValue { get; set; }
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
                    // The Google Ads customer ID for the conversion action is added.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // The conversion action ID.
                    options.ConversionActionId = long.Parse("INSERT_CONVERSION_ACTION_ID_HERE");

                    // The conversion time in "yyyy-mm-dd hh:mm:ss+|-hh:mm" format.
                    options.ConversionTime = "INSERT_CONVERSION_TIME_HERE";

                    // The Google Click ID for which conversions are uploaded.
                    options.Gclid = "INSERT_GCLID_HERE";

                    // The convsersion value.
                    options.ConversionValue = double.Parse("INSERT_CONVERSION_VALUE_HERE");

                    return 0;
                });

            UploadOfflineConversion codeExample = new UploadOfflineConversion();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ConversionActionId,
                options.ConversionTime, options.Gclid, options.ConversionValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example imports offline conversion values for specific clicks to your " +
            "account. To get Google Click ID for a click, use the 'click_view' resource: " +
            "https://developers.google.com/google-ads/api/fields/latest/click_view. To set up a " +
            "conversion action, run the AddConversionAction.cs example.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for the conversion action is
        /// added.</param>
        /// <param name="conversionActionId">The conversion action ID.</param>
        /// <param name="conversionTime">The conversion time in "yyyy-mm-dd hh:mm:ss+|-hh:mm"
        /// format.</param>
        /// <param name="gclid">The Google Click ID for which conversions are uploaded.</param>
        /// <param name="conversionValue">The convsersion value.</param>
        // [START upload_offline_conversion]
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            string gclid, string conversionTime, double conversionValue)
        {
            // Get the ConversionActionService.
            ConversionUploadServiceClient conversionUploadService =
                client.GetService(Services.V9.ConversionUploadService);

            // Creates a click conversion by specifying currency as USD.
            ClickConversion clickConversion = new ClickConversion()
            {
                ConversionAction = ResourceNames.ConversionAction(customerId, conversionActionId),
                Gclid = gclid,
                ConversionValue = conversionValue,
                ConversionDateTime = conversionTime,
                CurrencyCode = "USD"
            };

            try
            {
                // Issues a request to upload the click conversion.
                UploadClickConversionsResponse response =
                    conversionUploadService.UploadClickConversions(
                        new UploadClickConversionsRequest()
                        {
                            CustomerId = customerId.ToString(),
                            Conversions = { clickConversion },
                            PartialFailure = true,
                            ValidateOnly = false
                        });

                // Prints the result.
                ClickConversionResult uploadedClickConversion = response.Results[0];
                Console.WriteLine($"Uploaded conversion that occurred at " +
                    $"'{uploadedClickConversion.ConversionDateTime}' from Google " +
                    $"Click ID '{uploadedClickConversion.Gclid}' to " +
                    $"'{uploadedClickConversion.ConversionAction}'.");
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
        // [END upload_offline_conversion]
    }
}

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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V3.Errors;
using Google.Ads.GoogleAds.V3.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V3
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
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UploadOfflineConversion codeExample = new UploadOfflineConversion();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The conversion action ID.
            long conversionActionId = long.Parse("INSERT_CONVERSION_ACTION_ID_HERE");

            // The Click ID.
            string gclid = "INSERT_GCLID_HERE";

            // The conversion time.
            string conversionTime = "INSERT_CONVERSION_TIME_HERE";

            // The conversion value.
            double conversionValue = double.Parse("CONVERSION_VALUE");

            codeExample.Run(new GoogleAdsClient(), customerId, conversionActionId, gclid,
                conversionTime, conversionValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example imports offline conversion values for specific " +
                    "clicks to your account. To get Google Click ID for a click, use the " +
                    "'click_view' resource: " +
                    "https://developers.google.com/google-ads/api/fields/latest/click_view. " +
                    "To set up a conversion action, run the AddConversionAction.cs example.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for the conversion action is
        /// added.</param>
        /// <param name="conversionActionId">The conversion action ID.</param>
        /// <param name="conversionTime">The conversion time.</param>
        /// <param name="gclid">The click ID.</param>
        /// <param name="conversionValue">The convsersion value.</param>
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            string gclid, string conversionTime, double conversionValue)
        {
            // Get the ConversionActionService.
            ConversionUploadServiceClient conversionUploadService =
                client.GetService(Services.V3.ConversionUploadService);

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
    }
}

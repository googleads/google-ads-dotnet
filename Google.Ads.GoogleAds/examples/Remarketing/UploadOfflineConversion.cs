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
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V16.Common;
using Google.Ads.GoogleAds.V16.Errors;
using Google.Ads.GoogleAds.V16.Services;
using System;
using System.Linq;
using static Google.Ads.GoogleAds.V16.Enums.ConsentStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V16
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
            [Option("gclid", Required = false, HelpText =
                "The Google Click identifier. If setting this value, do not set gbraid or " +
                "wbraid parameters.")]
            public string Gclid { get; set; }

            /// <summary>
            /// The click ID.
            /// </summary>
            [Option("wbraid", Required = false, HelpText =
                "The WBRAID identifer for an iOS web conversion. If setting this value, do not " +
                "set gclid or gbraid parameters.")]
            public string Wbraid { get; set; }

            /// <summary>
            /// The click ID.
            /// </summary>
            [Option("gbraid", Required = false, HelpText =
                "The GBRAID identifier for an iOS app conversion. If setting this value, do " +
                "not set gclid or wbraid parameters.")]
            public string Gbraid { get; set; }

            /// <summary>
            /// The convsersion value.
            /// </summary>
            [Option("conversionValue", Required = true, HelpText =
                "The convsersion value.")]
            public double ConversionValue { get; set; }

            /// <summary>
            ///  The consent status for ad user data.
            /// </summary>
            [Option("adUserDataConsent", Required = false, HelpText =
                "The ad user data consent for the click.")]
            public ConsentStatus? AdUserDataConsent { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UploadOfflineConversion codeExample = new UploadOfflineConversion();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ConversionActionId,
                options.ConversionTime, options.Gclid, options.Gbraid, options.Wbraid,
                options.ConversionValue, options.AdUserDataConsent);
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
        /// <param name="gclid">The GCLID for the conversion. If set, <code>gbraid</code> and
        /// <code>wbraid</code> must be null.</param>
        /// <param name="gbraid">The GBRAID for the iOS app conversion. If set, <code>gclid</code>
        /// and <code>wbraid</code> must be null.</param>
        /// <param name="wbraid">The WBRAID for the iOS web conversion. If set, <code>gclid</code>
        /// and <code>gbraid</code> must be null.</param>
        /// <param name="conversionValue">The convsersion value.</param>
        /// <param name="adUserDataConsent">The ad user data consent for the click.</param>
        // [START upload_offline_conversion]
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            string gclid, string gbraid, string wbraid, string conversionTime,
            double conversionValue, ConsentStatus? adUserDataConsent)
        {
            // Get the ConversionActionService.
            ConversionUploadServiceClient conversionUploadService =
                client.GetService(Services.V16.ConversionUploadService);

            // Creates a click conversion by specifying currency as USD.
            ClickConversion clickConversion = new ClickConversion()
            {
                ConversionAction = ResourceNames.ConversionAction(customerId, conversionActionId),
                ConversionValue = conversionValue,
                ConversionDateTime = conversionTime,
                CurrencyCode = "USD",
            };

            // Sets the consent information, if provided.
            if (adUserDataConsent != null)
            {
                // Specifies whether user consent was obtained for the data you are uploading. See
                // https://www.google.com/about/company/user-consent-policy
                // for details.
                clickConversion.Consent = new Consent()
                {
                    AdUserData = (ConsentStatus)adUserDataConsent
                };
            }

            // Verifies that exactly one of gclid, gbraid, and wbraid is specified, as required.
            // See https://developers.google.com/google-ads/api/docs/conversions/upload-clicks
            // for details.
            string[] ids = { gclid, gbraid, wbraid };
            int idCount = ids.Where(id => !string.IsNullOrEmpty(id)).Count();

            if (idCount != 1)
            {
                throw new ArgumentException($"Exactly 1 of gclid, gbraid, or wbraid is " +
                    $"required, but {idCount} ID values were provided");
            }

            // Sets the single specified ID field.
            if (!string.IsNullOrEmpty(gclid))
            {
                clickConversion.Gclid = gclid;
            }
            else if (!string.IsNullOrEmpty(wbraid))
            {
                clickConversion.Wbraid = wbraid;
            }
            else if (!string.IsNullOrEmpty(gbraid))
            {
                clickConversion.Gbraid = gbraid;
            }

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

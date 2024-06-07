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
using Google.Ads.GoogleAds.V17.Common;
using Google.Ads.GoogleAds.V17.Errors;
using Google.Ads.GoogleAds.V17.Services;
using System;
using System.Security.Cryptography;
using System.Text;
using static Google.Ads.GoogleAds.V17.Enums.ConsentStatusEnum.Types;
using static Google.Ads.GoogleAds.V17.Enums.UserIdentifierSourceEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V17
{
    /// <summary>
    /// This code example uploads an enhanced conversion for leads by uploading a ClickConversion
    /// with user identifiers, and optionally a click ID and order ID, so Google can more accurately
    /// tie the conversion to the ad that drove the lead.
    /// </summary>
    public class UploadEnhancedConversionsForLeads : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadEnhancedConversionsForLeads"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which conversions are uploaded.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which conversions are uploaded.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// ID of the conversion action for which conversions are uploaded.
            /// </summary>
            [Option("conversionActionId", Required = true, HelpText =
                "ID of the conversion action for which conversions are uploaded.")]
            public long ConversionActionId { get; set; }

            /// <summary>
            /// The date time at which the conversion occurred. Must be after the click time,
            /// and must include the time zone offset. The format is
            /// 'yyyy-mm-dd hh:mm:ss+|-hh:mm', e.g. '2019-01-01 12:32:45-08:00'.
            /// </summary>
            [Option("conversionDateTime", Required = true, HelpText =
                "The date time at which the conversion occurred. Must be after the click time, " +
                "and must include the time zone offset. The format is " +
                "'yyyy-mm-dd hh:mm:ss+|-hh:mm', e.g. '2019-01-01 12:32:45-08:00'.")]
            public string ConversionDateTime { get; set; }

            /// <summary>
            /// The conversion value.
            /// </summary>
            [Option("conversionValue", Required = true, HelpText =
                "The conversion value.")]
            public double ConversionValue { get; set; }

            /// <summary>
            /// The unique order ID (transaction ID) of the conversion.
            /// </summary>
            [Option("orderId", Required = false, HelpText =
                "The unique order ID (transaction ID) of the conversion.")]
            public string OrderId { get; set; }

            /// <summary>
            /// The Google click ID.
            /// </summary>
            [Option("gclid", Required = false, HelpText =
                "The Google click ID.")]
            public string Gclid { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UploadEnhancedConversionsForLeads codeExample = new UploadEnhancedConversionsForLeads();
            Console.WriteLine(codeExample.Description);

            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ConversionActionId,
                options.ConversionDateTime, options.ConversionValue,
                options.OrderId, options.Gclid);
        }

        private static SHA256 digest = SHA256.Create();

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example uploads an enhanced conversion for leads by uploading a " +
            "ClickConversion with user identifiers, and optionally a click ID and order ID, so " +
            "Google can more accurately tie the conversion to the ad that drove the lead.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which conversions are uploaded.
        /// </param>
        /// <param name="conversionActionId">ID of the conversion action for which conversions are
        /// uploaded.</param>
        /// <param name="conversionDateTime">The date time at which the conversion occurred.</param>
        /// <param name="conversionValue">The conversion value.</param>
        /// <param name="orderId">The unique order ID (transaction ID) of the conversion.</param>
        /// <param name="gclid">The Google click ID</param>
        // [START upload_enhanced_conversions_for_leads]
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            string conversionDateTime, double conversionValue, string orderId, string gclid)
        {
            // Get the ConversionUploadService.
            ConversionUploadServiceClient conversionUploadService =
                client.GetService(Services.V17.ConversionUploadService);

            // [START create_conversion]
            // Creates an empty click conversion.
            ClickConversion clickConversion = new ClickConversion();

            // Gets the conversion action resource name.
            /*string conversionActionResourceName =


            // Creates a builder for constructing the click conversion.
            ClickConversion clickConversion = new ClickConversion()
            {
                ConversionAction = conversionActionResourceName,
                ConversionDateTime = conversionDateTime,
                ConversionValue = conversionValue,
                CurrencyCode = "USD",
                // Specifies whether user consent was obtained for the data you are uploading. See
                // https://www.google.com/about/company/user-consent-policy
                // for details.
                Consent = new Consent()
                {
                    AdPersonalization = ConsentStatus.Granted,
                    AdUserData = ConsentStatus.Denied
                }
            };

            // Sets the order ID if provided.
            if (!string.IsNullOrEmpty(orderId))
            {
                clickConversion.OrderId = orderId;
            }*/

            // [START add_user_identifiers]
            // Adds a user identifier using the hashed email address, using the normalize
            // and hash method specifically for email addresses.
            clickConversion.UserIdentifiers.Add(new UserIdentifier()
            {
                HashedEmail = NormalizeAndHashEmailAddress("alex.2@example.com"),
                // Optional: Specifies the user identifier source.
                UserIdentifierSource = UserIdentifierSource.FirstParty
            });

            // Adds a user identifier using normalized and hashed phone info.
            clickConversion.UserIdentifiers.Add(new UserIdentifier()
            {
                HashedPhoneNumber = NormalizeAndHash("+1 800 5550102"),
                // Optional: Specifies the user identifier source.
                UserIdentifierSource = UserIdentifierSource.FirstParty
            });

            // Adds a user identifier with all the required mailing address elements.
            clickConversion.UserIdentifiers.Add(new UserIdentifier()
            {
                AddressInfo = new OfflineUserAddressInfo()
                {
                    // FirstName and LastName must be normalized and hashed.
                    HashedFirstName = NormalizeAndHash("Alex"),
                    HashedLastName = NormalizeAndHash("Quinn"),
                    // CountryCode and PostalCode are sent in plain text.
                    CountryCode = "US",
                    PostalCode = "94045"
                }
            });
            // [END add_user_identifiers]

            // [START add_conversion_details]

            // Adds details of the conversion.
            clickConversion.ConversionAction =
                ResourceNames.ConversionAction(customerId, conversionActionId);
            clickConversion.ConversionDateTime = conversionDateTime;
            clickConversion.ConversionValue = conversionValue;
            clickConversion.CurrencyCode = "USD";

            // Sets the order ID if provided.
            if (!string.IsNullOrEmpty(orderId))
            {
                clickConversion.OrderId = orderId;
            }

            // Sets the Google click ID (gclid) if provided.
            if (!string.IsNullOrEmpty(gclid))
            {
                clickConversion.Gclid = gclid;
            }

            // [END add_conversion_details]
            // [END create_conversion]

            try
            {
                // [START upload_conversion]
                // Uploads the click conversion. Partial failure should always be set to true.
                // NOTE: This request contains a single conversion as a demonstration.
                // However, if you have multiple conversions to upload, it's best to upload multiple
                // conversions per request instead of sending a separate request per conversion.
                // See the following for per-request limits:
                // https://developers.google.com/google-ads/api/docs/best-practices/quotas#conversion_upload
                UploadClickConversionsResponse response =
                    conversionUploadService.UploadClickConversions(
                        new UploadClickConversionsRequest()
                        {
                            CustomerId = customerId.ToString(),
                            Conversions = { clickConversion },
                            // Enables partial failure (must be true).
                            PartialFailure = true
                        });

                // [END upload_conversion]

                // Prints any partial errors returned.
                // To review the overall health of your recent uploads, see:
                // https://developers.google.com/google-ads/api/docs/conversions/upload-summaries
                if (response.PartialFailureError != null)
                {
                    // Extracts the partial failure from the response status.
                    GoogleAdsFailure partialFailure = response.PartialFailure;
                    Console.WriteLine($"{partialFailure.Errors.Count} partial failure error(s) " +
                        $"occurred");
                }
                else
                {
                    ClickConversionResult result = response.Results[0];
                    // Prints the result.
                    Console.WriteLine($"Uploaded conversion that occurred at" +
                        $" {result.ConversionDateTime} to {result.ConversionAction}.");
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
        // [END upload_enhanced_conversions_for_leads]

        // [START normalize_and_hash]
        /// <summary>
        /// Normalizes the email address and hashes it. For this use case, Google Ads requires
        /// removal of any '.' characters preceding <code>gmail.com</code> or
        /// <code>googlemail.com</code>.
        /// </summary>
        /// <param name="emailAddress">The email address.</param>
        /// <returns>The hash code.</returns>
        private string NormalizeAndHashEmailAddress(string emailAddress)
        {
            string normalizedEmail = emailAddress.ToLower();
            string[] emailParts = normalizedEmail.Split('@');
            if (emailParts.Length > 1 && (emailParts[1] == "gmail.com" ||
                emailParts[1] == "googlemail.com"))
            {
                // Removes any '.' characters from the portion of the email address before
                // the domain if the domain is gmail.com or googlemail.com.
                emailParts[0] = emailParts[0].Replace(".", "");
                normalizedEmail = $"{emailParts[0]}@{emailParts[1]}";
            }
            return NormalizeAndHash(normalizedEmail);
        }

        /// <summary>
        /// Normalizes and hashes a string value.
        /// </summary>
        /// <param name="value">The value to normalize and hash.</param>
        /// <returns>The normalized and hashed value.</returns>
        private static string NormalizeAndHash(string value)
        {
            return ToSha256String(digest, ToNormalizedValue(value));
        }

        /// <summary>
        /// Hash a string value using SHA-256 hashing algorithm.
        /// </summary>
        /// <param name="digest">Provides the algorithm for SHA-256.</param>
        /// <param name="value">The string value (e.g. an email address) to hash.</param>
        /// <returns>The hashed value.</returns>
        private static string ToSha256String(SHA256 digest, string value)
        {
            byte[] digestBytes = digest.ComputeHash(Encoding.UTF8.GetBytes(value));
            // Convert the byte array into an unhyphenated hexadecimal string.
            return BitConverter.ToString(digestBytes).Replace("-", string.Empty);
        }

        /// <summary>
        /// Removes leading and trailing whitespace and converts all characters to
        /// lower case.
        /// </summary>
        /// <param name="value">The value to normalize.</param>
        /// <returns>The normalized value.</returns>
        private static string ToNormalizedValue(string value)
        {
            return value.Trim().ToLower();
        }
        // [END normalize_and_hash]
    }
}
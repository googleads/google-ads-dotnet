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
using Google.Ads.GoogleAds.V12.Common;
using Google.Ads.GoogleAds.V12.Errors;
using Google.Ads.GoogleAds.V12.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using static Google.Ads.GoogleAds.V12.Enums.ConversionAdjustmentTypeEnum.Types;
using static Google.Ads.GoogleAds.V12.Enums.UserIdentifierSourceEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V12
{
    /// <summary>
    /// This code example adjusts an existing conversion by supplying user identifiers so
    /// Google can enhance the conversion value.
    /// </summary>
    public class UploadConversionEnhancement : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadConversionEnhancement"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the conversion action is added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the conversion action is added.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// ID of the conversion action for which adjustments are uploaded.
            /// </summary>
            [Option("conversionActionId", Required = true, HelpText =
                "ID of the conversion action for which adjustments are uploaded.")]
            public long ConversionActionId { get; set; }

            /// <summary>
            /// The unique order ID (transaction ID) of the conversion.
            /// </summary>
            [Option("orderId", Required = true, HelpText =
                "The unique order ID (transaction ID) of the conversion.")]
            public string OrderId { get; set; }

            /// <summary>
            /// The date time at which the conversion with the specified order ID occurred. Must
            /// be after the click time, and must include the time zone offset. The format is
            /// 'yyyy-mm-dd hh:mm:ss+|-hh:mm', e.g. '2019-01-01 12:32:45-08:00'. Setting this
            /// field is optional, but recommended.
            /// </summary>
            [Option("conversionDateTime", Required = false, HelpText =
                "The date time at which the conversion with the specified order ID occurred. " +
                "Must be after the click time, and must include the time zone offset. The " +
                "format is 'yyyy-mm-dd hh:mm:ss+|-hh:mm', e.g. '2019-01-01 12:32:45-08:00'. " +
                "Setting this field is optional, but recommended.")]
            public string ConversionDateTime { get; set; }

            /// <summary>
            /// The HTTP user agent of the conversion.
            /// </summary>
            [Option("userAgent", Required = true, HelpText =
                "The HTTP user agent of the conversion.")]
            public string UserAgent { get; set; }

            /// <summary>
            /// The restatement value.
            /// </summary>
            [Option("restatementValue", Required = true, HelpText = "The restatement value.")]
            public double? RestatementValue { get; set; }

            /// <summary>
            /// The currency of the restatement value.
            /// </summary>
            [Option("currencyCode", Required = false, HelpText =
                "The currency of the restatement value.")]
            public string CurrencyCode { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UploadConversionEnhancement codeExample = new UploadConversionEnhancement();
            Console.WriteLine(codeExample.Description);

            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ConversionActionId,
                options.OrderId, options.ConversionDateTime, options.UserAgent,
                options.RestatementValue, options.CurrencyCode);
        }

        private static SHA256 digest = SHA256.Create();

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adjusts an existing conversion by supplying user identifiers so " +
                "Google can enhance the conversion value.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the conversion
        /// enhancement is uploaded.</param>
        /// <param name="conversionActionId">ID of the conversion action for which adjustments are
        /// uploaded.</param>
        /// <param name="orderId">The unique order ID (transaction ID) of the conversion.</param>
        /// <param name="conversionDateTime">The date time at which the conversion with the
        /// specified order ID occurred.</param>
        /// <param name="userAgent">The HTTP user agent of the conversion.</param>
        /// <param name="restatementValue">The restatement value.</param>
        /// <param name="restatementCurrencyCode">The currency of the restatement value.</param>
        // [START upload_conversion_enhancement]
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            string orderId, string conversionDateTime, string userAgent, double? restatementValue,
            string restatementCurrencyCode)
        {
            // Get the ConversionAdjustmentUploadService.
            ConversionAdjustmentUploadServiceClient conversionAdjustmentUploadService =
                client.GetService(Services.V12.ConversionAdjustmentUploadService);

            // [START create_adjustment]
            // Creates the enhancement adjustment.
            ConversionAdjustment enhancement = new ConversionAdjustment()
            {
                ConversionAction = ResourceNames.ConversionAction(customerId, conversionActionId),
                AdjustmentType = ConversionAdjustmentType.Enhancement,

                // Enhancements MUST use order ID instead of GCLID date/time pair.
                OrderId = orderId
            };

            // Sets the conversion date and time if provided. Providing this value is optional but
            // recommended.
            if (string.IsNullOrEmpty(conversionDateTime))
            {
                enhancement.GclidDateTimePair = new GclidDateTimePair()
                {
                    ConversionDateTime = conversionDateTime
                };
            }

            // Adds user identifiers, hashing where required.

            // Creates a user identifier using sample values for the user address.
            UserIdentifier addressIdentifier = new UserIdentifier()
            {
                AddressInfo = new OfflineUserAddressInfo()
                {
                    HashedFirstName = NormalizeAndHash("Joanna"),
                    HashedLastName = NormalizeAndHash("Smith"),
                    HashedStreetAddress = NormalizeAndHash("1600 Amphitheatre Pkwy"),
                    City = "Mountain View",
                    State = "CA",
                    PostalCode = "94043",
                    CountryCode = "US"
                },
                // Optional: Specifies the user identifier source.
                UserIdentifierSource = UserIdentifierSource.FirstParty
            };

            // Creates a user identifier using the hashed email address.
            UserIdentifier emailIdentifier = new UserIdentifier()
            {
                UserIdentifierSource = UserIdentifierSource.FirstParty,
                // Uses the normalize and hash method specifically for email addresses.
                HashedEmail = NormalizeAndHashEmailAddress("joannasmith@example.com")
            };

            // Adds the user identifiers to the enhancement adjustment.
            enhancement.UserIdentifiers.AddRange(new[] { addressIdentifier, emailIdentifier });

            // Sets optional fields where a value was provided.
            if (!string.IsNullOrEmpty(userAgent))
            {
                // Sets the user agent. This should match the user agent of the request that
                // sent the original conversion so the conversion and its enhancement are either
                // both attributed as same-device or both attributed as cross-device.
                enhancement.UserAgent = userAgent;
            }

            if (restatementValue != null)
            {
                enhancement.RestatementValue = new RestatementValue()
                {
                    // Sets the new value of the conversion.
                    AdjustedValue = restatementValue.Value
                };
                // Sets the currency of the new value, if provided. Otherwise, the default currency
                // from the conversion action is used, and if that is not set then the account
                // currency is used.
                if (restatementCurrencyCode != null)
                {
                    enhancement.RestatementValue.CurrencyCode = restatementCurrencyCode;
                }
            }
            // [END create_adjustment]
            try
            {
                // Uploads the enhancement adjustment. Partial failure should always be set to true.
                UploadConversionAdjustmentsResponse response =
                    conversionAdjustmentUploadService.UploadConversionAdjustments(
                        new UploadConversionAdjustmentsRequest()
                        {
                            CustomerId = customerId.ToString(),
                            ConversionAdjustments = { enhancement },
                            // Enables partial failure (must be true).
                            PartialFailure = true,
                        });

                // Prints the status message if any partial failure error is returned.
                // Note: The details of each partial failure error are not printed here,
                // you can refer to the example HandlePartialFailure.cs to learn more.
                if (response.PartialFailureError != null)
                {
                    // Extracts the partial failure from the response status.
                    GoogleAdsFailure partialFailure = response.PartialFailure;
                    Console.WriteLine($"{partialFailure.Errors.Count} partial failure error(s) " +
                        $"occurred");
                }
                else
                {
                    // Prints the result.
                    ConversionAdjustmentResult result = response.Results[0];
                    Console.WriteLine($"Uploaded conversion adjustment of " +
                        $"'{result.ConversionAction}' for order ID '{result.OrderId}'.");
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
        // [END upload_conversion_enhancement]

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
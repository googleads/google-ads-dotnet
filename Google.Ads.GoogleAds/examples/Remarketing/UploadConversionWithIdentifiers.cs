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
using Google.Ads.GoogleAds.V14.Common;
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using static Google.Ads.GoogleAds.V14.Enums.UserIdentifierSourceEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This code example uploads a conversion using hashed email address instead of GCLID.
    /// </summary>
    public class UploadConversionWithIdentifiers : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadConversionWithIdentifiers"/> example.
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
            /// The email address.
            /// </summary>
            [Option("emailAddress", Required = true, HelpText = "The email address.")]
            public string EmailAddress { get; set; }

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
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UploadConversionWithIdentifiers codeExample = new UploadConversionWithIdentifiers();
            Console.WriteLine(codeExample.Description);

            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ConversionActionId,
                options.EmailAddress, options.ConversionDateTime, options.ConversionValue,
                options.OrderId);
        }

        private static SHA256 digest = SHA256.Create();

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example uploads a conversion using hashed email address instead of GCLID.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which conversions are uploaded.
        /// </param>
        /// <param name="conversionActionId">ID of the conversion action for which conversions are
        /// uploaded.</param>
        /// <param name="emailAddress">The email address.</param>
        /// <param name="conversionDateTime">The date time at which the conversion occurred.</param>
        /// <param name="conversionValue">The conversion value.</param>
        /// <param name="orderId">The unique order ID (transaction ID) of the conversion.</param>
        // [START upload_conversion_with_identifiers]
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            string emailAddress, string conversionDateTime, double conversionValue,
            string orderId)
        {
            // Get the ConversionUploadService.
            ConversionUploadServiceClient conversionUploadService =
                client.GetService(Services.V14.ConversionUploadService);

            // [START create_conversion]
            // Gets the conversion action resource name.
            string conversionActionResourceName =
                ResourceNames.ConversionAction(customerId, conversionActionId);

            // Creates a builder for constructing the click conversion.
            ClickConversion clickConversion = new ClickConversion()
            {
                ConversionAction = conversionActionResourceName,
                ConversionDateTime = conversionDateTime,
                ConversionValue = conversionValue,
                CurrencyCode = "USD"
            };

            // Sets the order ID if provided.
            if (!string.IsNullOrEmpty(orderId))
            {
                clickConversion.OrderId = orderId;
            }

            // Optional: Specifies the user identifier source.
            clickConversion.UserIdentifiers.Add(new UserIdentifier()
            {
                // Creates a user identifier using the hashed email address, using the normalize
                // and hash method specifically for email addresses.
                // If using a phone number, use the NormalizeAndHash(String) method instead.
                HashedEmail = NormalizeAndHashEmailAddress(emailAddress),
                // Optional: Specifies the user identifier source.
                UserIdentifierSource = UserIdentifierSource.FirstParty
            });
            // [END create_conversion]

            try
            {
                // Uploads the click conversion. Partial failure should always be set to true.
                UploadClickConversionsResponse response =
                    conversionUploadService.UploadClickConversions(
                        new UploadClickConversionsRequest()
                        {
                            CustomerId = customerId.ToString(),
                            Conversions = { clickConversion },
                            // Enables partial failure (must be true).
                            PartialFailure = true
                        });

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
        // [END upload_conversion_with_identifiers]

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
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
using Google.Ads.GoogleAds.V22.Common;
using Google.Ads.GoogleAds.V22.Errors;
using Google.Ads.GoogleAds.V22.Resources;
using Google.Ads.GoogleAds.V22.Services;
using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using static Google.Ads.GoogleAds.V22.Enums.ConversionAdjustmentTypeEnum.Types;
using static Google.Ads.GoogleAds.V22.Enums.UserIdentifierSourceEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V22
{
    /// <summary>
    /// This code example enhances a web conversion by uploading a {@link ConversionAdjustment}
    /// containing hashed user identifiers and an order ID.
    /// </summary>
    public class UploadEnhancedConversionsForWeb : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadEnhancedConversionsForWeb"/> example.
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
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UploadEnhancedConversionsForWeb codeExample = new UploadEnhancedConversionsForWeb();
            Console.WriteLine(codeExample.Description);

            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ConversionActionId,
                options.OrderId, options.ConversionDateTime, options.UserAgent);
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
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="conversionActionId">ID of the conversion action associated with this
        /// conversion.</param>
        /// <param name="orderId">The unique order ID (transaction ID) of the conversion.</param>
        /// <param name="conversionDateTime">The date time at which the conversion with the
        /// specified order ID occurred.</param>
        /// <param name="userAgent">The HTTP user agent of the conversion.</param>
        // [START upload_enhanced_conversions_for_web]
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            string orderId, string conversionDateTime, string userAgent)
        {
            // Get the ConversionAdjustmentUploadService.
            ConversionAdjustmentUploadServiceClient conversionAdjustmentUploadService =
                client.GetService(Services.V22.ConversionAdjustmentUploadService);

            // [START create_adjustment]
            // Creates the enhancement adjustment.
            ConversionAdjustment enhancement = new ConversionAdjustment()
            {
                AdjustmentType = ConversionAdjustmentType.Enhancement
            };

            // [START add_user_identifiers]
            // Normalize and hash the raw data, then wrap it in UserIdentifier objects.
            // Create a separate UserIdentifier object for each. The data in this example is
            // hardcoded, but in your application you might read the raw data from an input file.
            //
            // IMPORTANT: Since the identifier attribute of UserIdentifier
            // (https://developers.google.com/google-ads/api/reference/rpc/latest/UserIdentifier)
            // is a oneof
            // (https://protobuf.dev/programming-guides/proto3/#oneof-features), you must set
            // only ONE of hashed_email, hashed_phone_number, mobile_id, third_party_user_id,
            // or address-info. Setting more than one of these attributes on the same UserIdentifier
            // will clear all the other members of the oneof. For example, the following code is
            // INCORRECT and will result in a UserIdentifier with ONLY a hashed_phone_number:
            // UserIdentifier incorrectlyPopulatedUserIdentifier = new UserIdentifier()
            // {
            //         HashedEmail = "..."
            //         HashedPhoneNumber = "..."
            // }
            UserIdentifier addressIdentifier = new UserIdentifier()
            {
                AddressInfo = new OfflineUserAddressInfo()
                {
                    HashedFirstName = NormalizeAndHash("Dana"),
                    HashedLastName = NormalizeAndHash("Quinn"),
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
                HashedEmail = NormalizeAndHashEmailAddress("dana@example.com")
            };

            // Adds the user identifiers to the enhancement adjustment.
            enhancement.UserIdentifiers.AddRange(new[] { addressIdentifier, emailIdentifier });
            // [END add_user_identifiers]

            // [START add_conversion_details]
            // Set the conversion action.
            enhancement.ConversionAction =
                ResourceNames.ConversionAction(customerId, conversionActionId);

            // Set the order ID. Enhancements MUST use order ID instead of GCLID date/time pair.
            enhancement.OrderId = orderId;

            // Sets the conversion date and time if provided. Providing this value is optional but
            // recommended.
            if (string.IsNullOrEmpty(conversionDateTime))
            {
                enhancement.GclidDateTimePair = new GclidDateTimePair()
                {
                    ConversionDateTime = conversionDateTime
                };
            }

            // Sets optional fields where a value was provided.
            if (!string.IsNullOrEmpty(userAgent))
            {
                // Sets the user agent. This should match the user agent of the request that
                // sent the original conversion so the conversion and its enhancement are either
                // both attributed as same-device or both attributed as cross-device.
                enhancement.UserAgent = userAgent;
            }

            // [END add_conversion_details]
            // [END create_adjustment]

            try
            {
                // [START upload_enhancement]
                // Uploads the enhancement adjustment. Partial failure should always be set to true.
                //
                // NOTE: This request contains a single adjustment as a demonstration.
                // However, if you have multiple adjustments to upload, it's best to upload
                // multiple adjustmenst per request instead of sending a separate request per
                // adjustment. See the following for per-request limits:
                // https://developers.google.com/google-ads/api/docs/best-practices/quotas#conversion_adjust
                UploadConversionAdjustmentsResponse response =
                    conversionAdjustmentUploadService.UploadConversionAdjustments(
                        new UploadConversionAdjustmentsRequest()
                        {
                            CustomerId = customerId.ToString(),
                            ConversionAdjustments = { enhancement },
                            // Enables partial failure (must be true).
                            PartialFailure = true,
                        });
                // [END upload_enhancement]

                // Prints the status message if any partial failure error is returned.
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
        // [END upload_enhanced_conversions_for_web]

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
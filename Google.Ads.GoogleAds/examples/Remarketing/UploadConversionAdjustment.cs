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
using Google.Ads.GoogleAds.V20.Errors;
using Google.Ads.GoogleAds.V20.Resources;
using Google.Ads.GoogleAds.V20.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V20.Enums.ConversionAdjustmentTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V20
{
    /// <summary>
    /// This code example imports conversion adjustments for conversions that already exist.
    /// To set up a conversion action, run AddConversionAction.cs.
    /// </summary>
    public class UploadConversionAdjustment : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadConversionAdjustment"/> example.
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
            /// The type of adjustment.
            /// </summary>
            [Option("adjustmentType", Required = true, HelpText =
                "The type of adjustment.")]
            public ConversionAdjustmentType AdjustmentType { get; set; }

            /// <summary>
            /// The transaction ID of the conversion to adjust. Required if the conversion being
            /// adjusted meets the criteria described at
            /// https://developers.google.com/google-ads/api/docs/conversions/upload-adjustments#requirements.
            /// </summary>
            [Option("orderId", Required = true, HelpText =
                "The transaction ID of the conversion to adjust. Required if the conversion " +
                "being adjusted meets the criteria described at " +
                "https://developers.google.com/google-ads/api/docs/conversions/upload-adjustments#requirements."
            )]
            public string OrderId { get; set; }

            /// <summary>
            /// The adjustment date and time.
            /// </summary>
            [Option("adjustmentDateTime", Required = true, HelpText =
                "The adjustment date and time.")]
            public string AdjustmentDateTime { get; set; }

            /// <summary>
            /// The restatement value.
            /// </summary>
            [Option("restatementValue", Required = true, HelpText =
                "The restatement value.")]
            public double? RestatementValue { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UploadConversionAdjustment codeExample = new UploadConversionAdjustment();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.ConversionActionId,
                options.OrderId, options.AdjustmentDateTime,
                options.AdjustmentType, options.RestatementValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example imports conversion adjustments for conversions that already " +
            "exist. To set up a conversion action, run AddConversionAction.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the conversion action is
        /// added.</param>
        /// <param name="conversionActionId">ID of the conversion action for which adjustments are
        /// uploaded.</param>
        /// <param name="adjustmentType">The type of adjustment.</param>
        /// <param name="orderId">The order ID for the conversion. Strongly recommended instead
        /// of using GCLID and conversionDateTime.</param>
        /// <param name="adjustmentDateTime">The adjustment date and time.</param>
        /// <param name="restatementValue">The restatement value.</param>
        // [START upload_conversion_adjustment]
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            string orderId, string adjustmentDateTime,
            ConversionAdjustmentType adjustmentType,
            double? restatementValue)
        {
            // Get the ConversionAdjustmentUploadService.
            ConversionAdjustmentUploadServiceClient conversionAdjustmentUploadService =
                client.GetService(Services.V20.ConversionAdjustmentUploadService);

            // Associate conversion adjustments with the existing conversion action.
            ConversionAdjustment conversionAdjustment = new ConversionAdjustment()
            {
                ConversionAction = ResourceNames.ConversionAction(customerId, conversionActionId),
                AdjustmentType = adjustmentType,
                // Sets the orderId to identify the conversion to adjust.
                OrderId = orderId,
                // As an alternative to setting orderId, you can provide a GclidDateTimePair,
                // but setting orderId instead is strongly recommended.
                //GclidDateTimePair = new GclidDateTimePair()
                //{
                //    Gclid = gclid,
                //    ConversionDateTime = conversionDateTime,
                //},
                AdjustmentDateTime = adjustmentDateTime,
            };

            // Set adjusted value for adjustment type RESTATEMENT.
            if (adjustmentType == ConversionAdjustmentType.Restatement)
            {
                conversionAdjustment.RestatementValue = new RestatementValue()
                {
                    AdjustedValue = restatementValue.Value
                };
            }

            try
            {
                // Issue a request to upload the conversion adjustment.
                UploadConversionAdjustmentsResponse response =
                    conversionAdjustmentUploadService.UploadConversionAdjustments(
                        new UploadConversionAdjustmentsRequest()
                        {
                            CustomerId = customerId.ToString(),
                            ConversionAdjustments = { conversionAdjustment },
                            // Enables partial failure (must be true).
                            PartialFailure = true,
                            ValidateOnly = false
                        });

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
                    ConversionAdjustmentResult result = response.Results[0];
                    // Print the result.
                    Console.WriteLine($"Uploaded conversion adjustment value of" +
                        $" '{result.ConversionAction}' for Google Click ID " +
                        $"'{result.GclidDateTimePair.Gclid}'");
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
        // [END upload_conversion_adjustment]
    }
}

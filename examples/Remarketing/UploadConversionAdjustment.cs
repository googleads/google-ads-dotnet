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
using static Google.Ads.GoogleAds.V3.Enums.ConversionAdjustmentTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V3
{
    /// <summary>
    /// This code example imports conversion adjustments for conversions that already exist.
    /// To set up a conversion action, run AddConversionAction.cs.
    /// </summary>
    public class UploadConversionAdjustment : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UploadConversionAdjustment codeExample = new UploadConversionAdjustment();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the conversion action for which adjustments are uploaded.
            long conversionActionId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The type of adjustment.
            ConversionAdjustmentType adjustmentType =
                (ConversionAdjustmentType) Enum.Parse(
                    typeof(ConversionAdjustmentType), "INSERT_ADJUSTMENT_TYPE_HERE");

            // The original conversion time.
            string conversionDateTime = "INSERT_CONVERSION_DATE_TIME_HERE";

            // The Google Click ID for which adjustments are uploaded.
            string gclid = "INSERT_GCLID_HERE";

            // The adjustment date and time.
            string adjustmentDateTime = "INSERT_ADJUSTMENT_DATE_TIME_HERE";

            // The restatement value.
            double? restatementValue = double.Parse("INSERT_RESTATEMENT_VALUE_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, conversionActionId, gclid,
                conversionDateTime, adjustmentDateTime, adjustmentType, restatementValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example imports conversion adjustments for conversions that " +
                    "already exist. To set up a conversion action, run AddConversionAction.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for the conversion action is
        /// added.</param>
        /// <param name="conversionActionId">ID of the conversion action for which adjustments are
        /// uploaded.</param>
        /// <param name="adjustmentType">The type of adjustment.</param>
        /// <param name="conversionDateTime">The original conversion time.</param>
        /// <param name="gclid">The Google Click ID for which adjustments are uploaded.</param>
        /// <param name="adjustmentDateTime">The adjustment date and time.</param>
        /// <param name="restatementValue">The restatement value.</param>
        public void Run(GoogleAdsClient client, long customerId, long conversionActionId,
            string gclid, string conversionDateTime, string adjustmentDateTime,
            ConversionAdjustmentType adjustmentType,
            double? restatementValue)
        {
            // Get the ConversionAdjustmentUploadService.
            ConversionAdjustmentUploadServiceClient conversionAdjustmentUploadService =
                client.GetService(Services.V3.ConversionAdjustmentUploadService);

            // Associate conversion adjustments with the existing conversion action.
            // The GCLID should have been uploaded before with a conversion.
            ConversionAdjustment conversionAdjustment = new ConversionAdjustment()
            {
                ConversionAction = ResourceNames.ConversionAction(customerId, conversionActionId),
                AdjustmentType = adjustmentType,
                GclidDateTimePair = new GclidDateTimePair()
                {
                    Gclid = gclid,
                    ConversionDateTime = conversionDateTime,
                },
                AdjustmentDateTime = adjustmentDateTime,
            };

            // Set adjusted value for adjustment type RESTATEMENT.
            if (adjustmentType == ConversionAdjustmentType.Restatement)
            {
                conversionAdjustment.RestatementValue = new RestatementValue()
                {
                    AdjustedValue = restatementValue
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
                            PartialFailure = true,
                            ValidateOnly = false
                        });

                ConversionAdjustmentResult result = response.Results[0];
                // Print the result.
                Console.WriteLine($"Uploaded conversion adjustment value of" +
                    $" '{result.ConversionAction}' for Google Click ID " +
                    $"'{result.GclidDateTimePair.Gclid}'");
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

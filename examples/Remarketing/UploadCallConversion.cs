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
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example imports offline call conversion values for calls related to the
    /// ads in your account. To set up a conversion action, run the AddConversionAction.cs example.
    /// </summary>
    public class UploadCallConversion : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            UploadCallConversion codeExample = new UploadCallConversion();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The caller ID in E.164 format with preceding '+' sign. e.g. "+16502531234".
            string callerId = "INSERT_CALLER_ID_HERE";

            // The call start time in "yyyy-mm-dd hh:mm:ss+|-hh:mm" format.
            string callStartTime = "INSERT_CALL_START_TIME_HERE";

            // The conversion time in "yyyy-mm-dd hh:mm:ss+|-hh:mm" format.
            string conversionTime = "INSERT_CONVERSION_TIME_HERE";

            // The conversion value.
            double conversionValue = double.Parse("CONVERSION_VALUE");

            codeExample.Run(new GoogleAdsClient(), customerId, callerId, callStartTime,
                conversionTime, conversionValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example imports offline call conversion values for calls related to the " +
            "ads in your account. To set up a conversion action, run the AddConversionAction.cs " +
            "example.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for whom the conversion action will
        /// be added.</param>
        /// <param name="callerId">The caller ID.</param>
        /// <param name="callStartTime">The call start time.</param>
        /// <param name="conversionTime">The call conversion time.</param>
        /// <param name="conversionValue">The convsersion value.</param>
        public void Run(GoogleAdsClient client, long customerId, string callerId,
            string callStartTime, string conversionTime, double conversionValue)
        {
            // Get the ConversionUploadService.
            ConversionUploadServiceClient conversionUploadService =
                client.GetService(Services.V6.ConversionUploadService);

            // Create a call conversion by specifying currency as USD.
            CallConversion callConversion = new CallConversion()
            {
                CallerId = callerId,
                CallStartDateTime = callStartTime,
                ConversionDateTime = conversionTime,
                ConversionValue = conversionValue,
                CurrencyCode = "USD"
            };

            UploadCallConversionsRequest request = new UploadCallConversionsRequest()
            {
                CustomerId = customerId.ToString(),
                Conversions = { callConversion },
                PartialFailure = true
            };

            try
            {
                // Issues a request to upload the call conversion. The partialFailure parameter
                // is set to true, and validateOnly parameter to false as required by this method
                // call.
                UploadCallConversionsResponse response =
                    conversionUploadService.UploadCallConversions(request);

                // Prints the result.
                CallConversionResult uploadedCallConversion = response.Results[0];
                Console.WriteLine($"Uploaded call conversion that occurred at " +
                    $"'{uploadedCallConversion.CallStartDateTime}' for caller ID " +
                    $"'{uploadedCallConversion.CallerId}' to the conversion action with " +
                    $"resource name '{uploadedCallConversion.ConversionAction}'.");
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

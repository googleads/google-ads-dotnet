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
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This code example imports offline call conversion values for calls related to the
    /// ads in your account. To set up a conversion action, run the AddConversionAction.cs example.
    /// </summary>
    public class UploadCallConversion : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UploadCallConversion"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for whom the conversion will be imported.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for whom the conversion will be imported.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The conversion action ID.
            /// </summary>
            [Option("conversionActionId", Required = true, HelpText =
                "The conversion action ID.")]
            public long ConversionActionId { get; set; }

            /// <summary>
            /// The caller ID in E.164 format with preceding '+' sign. e.g. "+18005550100".
            /// </summary>
            [Option("callerId", Required = true, HelpText =
                "The caller ID in E.164 format with preceding '+' sign. e.g. '+18005550100'.")]
            public string CallerId { get; set; }

            /// <summary>
            /// The call start time in 'yyyy-mm-dd hh:mm:ss +|-hh:mm' format.
            /// </summary>
            [Option("callStartTime", Required = true, HelpText =
                "The call start time in 'yyyy-mm-dd hh:mm:ss+|-hh:mm' format.")]
            public string CallStartTime { get; set; }

            /// <summary>
            /// The call conversion time.
            /// </summary>
            [Option("conversionTime", Required = true, HelpText =
                "The conversion time in 'yyyy-mm-dd hh:mm:ss+|-hh:mm' format.")]
            public string ConversionTime { get; set; }

            /// <summary>
            /// The conversion value.
            /// </summary>
            [Option("conversionValue", Required = true, HelpText =
                "The conversion value.")]
            public double ConversionValue { get; set; }

            /// <summary>
            /// The ID of the conversion custom variable to associate with the upload.
            /// </summary>
            [Option("conversionCustomVariableId", Required = false, HelpText =
                "The ID of the conversion custom variable to associate with the upload.")]
            public long? ConversionCustomVariableId { get; set; }

            /// <summary>
            /// The value of the conversion custom variable to associate with the upload.
            /// </summary>
            [Option("conversionCustomVariableValue", Required = false, HelpText =
                "The value of the conversion custom variable to associate with the upload.")]
            public string ConversionCustomVariableValue { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            UploadCallConversion codeExample = new UploadCallConversion();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.ConversionActionId, options.CallerId, options.CallStartTime,
                options.ConversionTime, options.ConversionValue,
                options.ConversionCustomVariableId, options.ConversionCustomVariableValue);
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
        /// <param name="customerId">The Google Ads customer ID for whom the conversion will
        /// be imported.</param>
        /// <param name="callerId">The caller ID in E.164 format with preceding '+' sign. e.g.
        /// "+18005550100".</param>
        /// <param name="conversionActionId">The ID of the conversion action</param>
        /// <param name="callStartTime">The call start time in "yyyy-mm-dd hh:mm:ss+|-hh:mm"
        /// format.</param>
        /// <param name="conversionTime">The conversion time in "yyyy-mm-dd hh:mm:ss+|-hh:mm"
        /// format.</param>
        /// <param name="conversionValue">The conversion value.</param>
        /// <param name="conversionCustomVariableId">The ID of the conversion custom variable to
        /// associate with the upload.</param>
        /// <param name="conversionCustomVariableValue">The value of the conversion custom variable
        /// to associate with the upload.</param>
        // [START upload_call_conversion]
        public void Run(GoogleAdsClient client, long customerId,
            long conversionActionId, string callerId, string callStartTime,
            string conversionTime, double conversionValue,
            long? conversionCustomVariableId, string conversionCustomVariableValue)
        {
            // Get the ConversionUploadService.
            ConversionUploadServiceClient conversionUploadService =
                client.GetService(Services.V14.ConversionUploadService);

            // Create a call conversion by specifying currency as USD.
            CallConversion callConversion = new CallConversion()
            {
                ConversionAction = ResourceNames.ConversionAction(customerId, conversionActionId),
                CallerId = callerId,
                CallStartDateTime = callStartTime,
                ConversionDateTime = conversionTime,
                ConversionValue = conversionValue,
                CurrencyCode = "USD"
            };

            if (conversionCustomVariableId != null &&
                !string.IsNullOrEmpty(conversionCustomVariableValue))
            {
                callConversion.CustomVariables.Add(new CustomVariable()
                {
                    ConversionCustomVariable = ResourceNames.ConversionCustomVariable(
                        customerId, conversionCustomVariableId.Value),
                    Value = conversionCustomVariableValue
                });
            }

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

                // Since we set partialFailure = true, we can retrieve error messages (if any) from
                // the operation response.
                if (response.PartialFailureError != null)
                {
                    Console.WriteLine("Call conversion upload failed.");

                    // Retrieves the errors from the partial failure and prints them.
                    List<GoogleAdsError> errors =
                        response.PartialFailure.GetErrorsByOperationIndex(0);
                    foreach (GoogleAdsError error in errors)
                    {
                        Console.WriteLine($"Operation failed with error: {error}.");
                    }
                }
                else
                {
                    // Prints the result.
                    CallConversionResult uploadedCallConversion = response.Results[0];
                    Console.WriteLine($"Uploaded call conversion that occurred at " +
                        $"'{uploadedCallConversion.CallStartDateTime}' for caller ID " +
                        $"'{uploadedCallConversion.CallerId}' to the conversion action with " +
                        $"resource name '{uploadedCallConversion.ConversionAction}'.");
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
        // [END upload_call_conversion]
    }
}

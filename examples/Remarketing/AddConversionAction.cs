// Copyright 2019 Google LLC
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
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;

using System;
using static Google.Ads.GoogleAds.V4.Enums.ConversionActionCategoryEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.ConversionActionStatusEnum.Types;
using static Google.Ads.GoogleAds.V4.Enums.ConversionActionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example illustrates adding a conversion action.
    /// </summary>
    public class AddConversionAction : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddConversionAction codeExample = new AddConversionAction();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example illustrates adding a conversion action.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the conversion action is
        /// added.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the ConversionActionService.
            ConversionActionServiceClient conversionActionService =
                client.GetService(Services.V4.ConversionActionService);

            // Add a conversion action.
            ConversionAction conversionAction = new ConversionAction()
            {
                Name = "Earth to Mars Cruises Conversion #" + ExampleUtilities.GetRandomString(),
                Category = ConversionActionCategory.Default,
                Type = ConversionActionType.Webpage,
                Status = ConversionActionStatus.Enabled,
                ViewThroughLookbackWindowDays = 15,
                ValueSettings = new ConversionAction.Types.ValueSettings()
                {
                    DefaultValue = 23.41,
                    AlwaysUseDefaultValue = true
                }
            };

            // Create the operation.
            ConversionActionOperation operation = new ConversionActionOperation()
            {
                Create = conversionAction
            };

            try
            {
                // Create the conversion action.
                MutateConversionActionsResponse response =
                    conversionActionService.MutateConversionActions(customerId.ToString(),
                            new ConversionActionOperation[] { operation });

                // Display the results.
                foreach (MutateConversionActionResult newConversionAction in response.Results)
                {
                    Console.WriteLine($"New conversion action with resource name = " +
                        $"'{newConversionAction.ResourceName}' was added.");
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
    }
}

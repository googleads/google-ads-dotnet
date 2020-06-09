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
using Google.Ads.GoogleAds.V4.Errors;
using Google.Ads.GoogleAds.V4.Resources;
using Google.Ads.GoogleAds.V4.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V4
{
    /// <summary>
    /// This code example sets ad parameters for a keyword. To get ad group criteria,
    /// run GetKeywords.cs.
    /// </summary>
    public class SetAdParameters : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            SetAdParameters codeExample = new SetAdParameters();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // ID of the ad group that contains the keyword.
            long adGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

            // ID of the keyword to which ad parametes are attached.
            long keywordId = long.Parse("INSERT_KEYWORD_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, adGroupId, keywordId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example sets ad parameters for a keyword. To get ad group " +
                    "criteria, run GetKeywords.cs.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group that contains the keywrd.
        /// </param>
        /// <param name="keywordId">ID of the keyword to which ad parameters are attached.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId, long keywordId)
        {
            // Get the AdParameterServiceClient.
            AdParameterServiceClient adParameterService =
                client.GetService(Services.V4.AdParameterService);

            // Creates ad parameters.
            // There can be a maximum of two AdParameters per ad group criterion.
            // (One with parameter_index = 1 and one with parameter_index = 2.)
            AdParameter adParameter1 = new AdParameter()
            {
                AdGroupCriterion = ResourceNames.AdGroupCriterion(
                    customerId, adGroupId, keywordId),

                // The unique index of this ad parameter. Must be either 1 or 2.
                ParameterIndex = 1,

                // String containing a numeric value to insert into the ad text.
                // The following restrictions apply: (a) can use comma or period as a separator,
                // with an optional period or comma (respectively) for fractional values,
                // (b) can be prepended or appended with a currency code, (c) can use plus or minus,
                // (d) can use '/' between two numbers.
                InsertionText = "100"
            };

            AdParameter adParameter2 = new AdParameter()
            {
                AdGroupCriterion = ResourceNames.AdGroupCriterion(
                    customerId, adGroupId, keywordId),
                ParameterIndex = 2,
                InsertionText = "$40"
            };

            AdParameterOperation[] operations = new AdParameterOperation[]
            {
                new AdParameterOperation() { Create = adParameter1 },
                new AdParameterOperation() { Create = adParameter2 },
            };

            try
            {
                MutateAdParametersResponse response =
                    adParameterService.MutateAdParameters(customerId.ToString(), operations);

                Console.WriteLine($"Set {response.Results.Count} ad params:");
                foreach (MutateAdParameterResult result in response.Results)
                {
                    Console.WriteLine(result.ResourceName);
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

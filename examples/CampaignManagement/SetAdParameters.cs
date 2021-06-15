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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V8.Errors;
using Google.Ads.GoogleAds.V8.Resources;
using Google.Ads.GoogleAds.V8.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V8
{
    /// <summary>
    /// This code example sets ad parameters for a keyword. To get ad group criteria,
    /// run GetKeywords.cs.
    /// </summary>
    public class SetAdParameters : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="SetAdParameters"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// ID of the ad group that contains the keywrd.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "ID of the ad group that contains the keywrd.")]
            public long AdGroupId { get; set; }

            /// <summary>
            /// ID of the keyword to which ad parameters are attached.
            /// </summary>
            [Option("criterionId", Required = true, HelpText =
                "ID of the keyword to which ad parameters are attached.")]
            public long CriterionId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = new Options();
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // ID of the ad group that contains the keywrd.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    // ID of the keyword to which ad parameters are attached.
                    options.CriterionId = long.Parse("INSERT_CRITERION_ID_HERE");

                    return 0;
                });

            SetAdParameters codeExample = new SetAdParameters();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId,
                options.CriterionId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example sets ad parameters for a keyword. To get ad group criteria, run " +
            "GetKeywords.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group that contains the keywrd.
        /// </param>
        /// <param name="criterionId">ID of the keyword to which ad parameters are attached.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId, long criterionId)
        {
            // Get the AdParameterServiceClient.
            AdParameterServiceClient adParameterService =
                client.GetService(Services.V8.AdParameterService);

            // Creates ad parameters.
            // There can be a maximum of two AdParameters per ad group criterion.
            // (One with parameter_index = 1 and one with parameter_index = 2.)
            AdParameter adParameter1 = new AdParameter()
            {
                AdGroupCriterion = ResourceNames.AdGroupCriterion(
                    customerId, adGroupId, criterionId),

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
                    customerId, adGroupId, criterionId),
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

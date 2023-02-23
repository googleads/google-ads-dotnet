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

using CommandLine;
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V13.Errors;
using Google.Ads.GoogleAds.V13.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V13
{
    /// <summary>
    /// This code example deletes an ad group. To get ad groups, run GetAdGroups.cs.
    /// </summary>
    public class RemoveAdGroup : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="RemoveAdGroup"/> example.
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
            /// ID of the ad group to remove.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "ID of the ad group to remove.")]
            public long AdGroupId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            RemoveAdGroup codeExample = new RemoveAdGroup();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.AdGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example deletes an ad group. To get ad groups, run GetAdGroups.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">ID of the ad group to remove.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            // Get the AdGroupService.
            AdGroupServiceClient service = client.GetService(Services.V13.AdGroupService);

            // Construct an operation that will remove the ad group with the specified
            // resource name.
            AdGroupOperation operation = new AdGroupOperation
            {
                Remove = ResourceNames.AdGroup(customerId, adGroupId)
            };

            try
            {
                // Send the operation in a mutate request.
                MutateAdGroupsResponse response = service.MutateAdGroups(customerId.ToString(),
                    new AdGroupOperation[] { operation });

                // Display the result.
                foreach (MutateAdGroupResult result in response.Results)
                {
                    Console.WriteLine($"Removed ad group with resourceName: " +
                        $"{result.ResourceName}.");
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

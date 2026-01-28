// Copyright 2026 Google LLC
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
using Google.Ads.Gax.Lib;
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Extensions.Config;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V23.Errors;
using Google.Ads.GoogleAds.V23.Services;
using System;

namespace Google.Ads.GoogleAds.Examples.V23
{
    /// <summary>
    /// This code example applies an incentive to a user's account.
    /// </summary>
    public class ApplyIncentive : ExampleBase
    {
         /// <summary>
        /// Command line options for running the <see cref="FetchIncentives"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The customer ID for which the call is made.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The ID of the incentive to apply.
            /// </summary>
            [Option("incentiveId", Required = true, HelpText =
                "The ID of the incentive to apply.")]
            public long IncentiveId { get; set; }

            /// <summary>
            /// The country for the incentive to apply.
            /// </summary>
            [Option("countryCode", Required = true, HelpText =
                "The country for the incentive to apply.")]
            public string CountryCode { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            ApplyIncentive codeExample = new ApplyIncentive();
            Console.WriteLine(codeExample.Description);              
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
            options.IncentiveId, options.CountryCode);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example applies an incentive to a user's account.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="incentiveId">The ID of the incentive to apply.</param>
        /// <param name="countryCode">The country for the returned incentive.</param>
        public void Run(GoogleAdsClient client, long customerId,
            long incentiveId, string countryCode)
        {
            IncentiveServiceClient incentiveService = client.GetService(
                Services.V23.IncentiveService);

            ApplyIncentiveRequest request = new ApplyIncentiveRequest()
            {
                CustomerId = customerId.ToString(),
                SelectedIncentiveId = incentiveId,
                CountryCode = countryCode
            };

            try
            {
                ApplyIncentiveResponse response =
                    incentiveService.ApplyIncentive(request);

                Console.WriteLine("===========================================");
                Console.WriteLine($"Applied incentive with coupon code: {response.CouponCode}");
                Console.WriteLine($"Incentive was created at: {response.CreationTime}");
                Console.WriteLine("===========================================");

            } catch  (GoogleAdsException e)
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
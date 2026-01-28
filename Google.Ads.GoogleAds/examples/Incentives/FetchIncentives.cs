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
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V23.Errors;
using Google.Ads.GoogleAds.V23.Services;
using System;

using static Google.Ads.GoogleAds.V23.Services.FetchIncentiveRequest.Types;

namespace Google.Ads.GoogleAds.Examples.V23
{
    /// <summary>
    /// This code example fetches the available incentives for a user.
    /// </summary>
    public class FetchIncentives : ExampleBase
    {
         /// <summary>
        /// Command line options for running the <see cref="FetchIncentives"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The email of the user to fetch incentives for.
            /// </summary>
            [Option("email", Required = true, HelpText =
                "The email of the user to fetch incentives for.")]
            public string Email { get; set; }

            /// <summary>
            /// The language for the returned incentive.
            /// </summary>
            [Option("languageCode", Required = true, HelpText =
                "The language for the returned incentive.")]
            public string LanguageCode { get; set; }

            /// <summary>
            /// The country for the returned incentive.
            /// </summary>
            [Option("countryCode", Required = true, HelpText =
                "The country for the returned incentive.")]
            public string CountryCode { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            FetchIncentives codeExample = new FetchIncentives();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.Email,
            options.LanguageCode, options.CountryCode);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example fetches the available incentives for a user.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="email">The email of the user to fetch incentives for.</param>
        /// <param name="languageCode">The language for the returned incentive.</param>
        /// <param name="countryCode">The country for the returned incentive.</param>
        public void Run(GoogleAdsClient client, string email, string languageCode,
            string countryCode)
        {
            IncentiveServiceClient incentiveService = client.GetService(
                Services.V23.IncentiveService);

            FetchIncentiveRequest request = new FetchIncentiveRequest()
            {
                CountryCode = countryCode,
                LanguageCode = languageCode,
                Email = email,
                Type = IncentiveType.Acquisition
            };

            try
            {
                FetchIncentiveResponse response =
                    incentiveService.FetchIncentive(request);

                if (response.IncentiveOffer.IsEmpty())
                {
                    Console.WriteLine("No incentive offer was found.");
                    return;
                }

                if (!response.IncentiveOffer.CyoIncentives.IsEmpty())
                {
                    CyoIncentives cyoIncentives = response.IncentiveOffer.CyoIncentives;
                    printIncentiveDetails(cyoIncentives.LowOffer);
                }

            } catch  (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
        }

        private void printIncentiveDetails(Incentive incentive)
        {
            Console.WriteLine("===========================================");
            Console.WriteLine($"Incentive ID: {incentive.IncentiveId}");
            Console.WriteLine($"Incentive requirement: {incentive.Requirement}");
            Console.WriteLine($"Incentive terms and conditions: {incentive.IncentiveTermsAndConditionsUrl}");
            Console.WriteLine("===========================================");
        }
    
    }
}
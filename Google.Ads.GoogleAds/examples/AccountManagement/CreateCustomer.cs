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
using Google.Ads.GoogleAds.V14.Errors;
using Google.Ads.GoogleAds.V14.Resources;
using Google.Ads.GoogleAds.V14.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This code example illustrates how to create a new customer under a given manager account.
    ///
    /// Note: this example must be run using the credentials of a Google Ads manager account.
    /// By default, the new account will only be accessible via the manager account.
    /// </summary>
    public class CreateCustomer : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="CreateCustomer"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The manager customer ID.
            /// </summary>
            [Option("managerCustomerId", Required = true, HelpText =
                "The manager customer ID.")]
            public long ManagerCustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            CreateCustomer codeExample = new CreateCustomer();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.ManagerCustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example illustrates how to create a new customer under a given manager " +
            "account.\nNote: this example must be run using the credentials of a Google Ads " +
            "manager account. By default, the new account will only be accessible via the " +
            "manager account.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="managerCustomerId">The manager customer ID.</param>
        // [START create_customer]
        public void Run(GoogleAdsClient client, long managerCustomerId)
        {
            // Get the CustomerService.
            CustomerServiceClient customerService = client.GetService(Services.V14.CustomerService);

            Customer customer = new Customer()
            {
                DescriptiveName = $"Account created with CustomerService on '{DateTime.Now}'",

                // For a list of valid currency codes and time zones see this documentation:
                // https://developers.google.com/google-ads/api/reference/data/codes-formats#codes_formats.
                CurrencyCode = "USD",
                TimeZone = "America/New_York",

                // The below values are optional. For more information about URL
                // options see: https://support.google.com/google-ads/answer/6305348.
                TrackingUrlTemplate = "{lpurl}?device={device}",
                FinalUrlSuffix = "keyword={keyword}&matchtype={matchtype}&adgroupid={adgroupid}"
            };

            try
            {
                // Create the account.
                CreateCustomerClientResponse response = customerService.CreateCustomerClient(
                    managerCustomerId.ToString(), customer);

                // Display the result.
                Console.WriteLine($"Created a customer with resource name " +
                    $"'{response.ResourceName}' under the manager account with customer " +
                    $"ID '{managerCustomerId}'");
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
        // [END create_customer]
    }
}

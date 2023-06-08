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
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V14
{
    /// <summary>
    /// This code example lists basic information about an advertising account, like the name,
    /// currency and time zone.
    /// </summary>
    public class GetAccountInformation : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetAccountInformation"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the call is made.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the call is made.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GetAccountInformation codeExample = new GetAccountInformation();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example lists basic information about an advertising account, like the " +
            "name, currency and time zone.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V14.GoogleAdsService);

            // Construct a query to retrieve the customer.
            // Add a limit of 1 row to clarify that selecting from the customer resource
            // will always return only one row, which will be for the customer
            // ID specified in the request.
            string query = "SELECT customer.id, customer.descriptive_name, " +
                "customer.currency_code, customer.time_zone, customer.tracking_url_template, " +
                "customer.auto_tagging_enabled FROM customer LIMIT 1";

            // Executes the query and gets the Customer object from the single row of the response.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                CustomerId = customerId.ToString(),
                Query = query
            };

            try
            {
                // Issue the search request.
                Customer customer = googleAdsService.Search(request).First().Customer;

                // Print account information.
                Console.WriteLine("Customer with ID {0}, descriptive name '{1}', currency " +
                    "code '{2}', timezone '{3}', tracking URL template '{4}' and auto tagging " +
                    "enabled '{5}' was retrieved.", customer.Id, customer.DescriptiveName,
                    customer.CurrencyCode, customer.TimeZone, customer.TrackingUrlTemplate,
                    customer.AutoTaggingEnabled);
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

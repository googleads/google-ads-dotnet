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
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example lists basic information about an advertising account, like the name,
    /// currency and time zone.
    /// </summary>
    public class GetAccountInformation : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetAccountInformation codeExample = new GetAccountInformation();

            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId);
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
            // Get the CustomerService.
            CustomerServiceClient customerService = client.GetService(Services.V7.CustomerService);

            try
            {
                string customerResourceName = ResourceNames.Customer(customerId);
                Customer customer = customerService.GetCustomer(customerResourceName);

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

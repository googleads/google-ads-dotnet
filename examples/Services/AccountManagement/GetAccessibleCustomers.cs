// Copyright 2018 Google LLC
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
using Google.Ads.GoogleAds.V0.Resources;
using Google.Ads.GoogleAds.V0.Services;

using System;

namespace Google.Ads.GoogleAds.Examples.V0
{
    /// <summary>
    /// This code example lists the resource names for the customers that the authenticating user
    /// has access to. This example may can be used to display a list of customer IDs that can be
    /// selected by the user for setting the login-customer-id in a subsequent call. See
    /// https://developers.google.com/google-ads/api/docs/concepts/call-structure#login-customer-id
    /// to learn more about the login-customer-id header.
    /// </summary>
    public class GetAccessibleCustomers : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            GetAccessibleCustomers codeExample = new GetAccessibleCustomers();

            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient());
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example lists the resource names for the customers that the " +
                    "authenticating user has access to. This example may be used to display a " +
                    "list of customer IDs that can be selected by the user for setting the " +
                    "login-customer-id in a subsequent call. See "+
                    "https://developers.google.com/google-ads/api/docs/concepts/call-structure#login-customer-id "+
                    "to learn more about the login-customer-id header.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        public void Run(GoogleAdsClient client)
        {
            // Get the CustomerService.
            CustomerServiceClient customerService = client.GetService(Services.V0.CustomerService);

            try
            {
                // Retrieve the list of customer resources.
                string[] customerResourceNames = customerService.ListAccessibleCustomers();

                // Display the result.
                foreach (string customerResourceName in customerResourceNames)
                {
                    Console.WriteLine(
                        $"Found customer with resource name = '{customerResourceName}'.");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
            }
        }
    }
}

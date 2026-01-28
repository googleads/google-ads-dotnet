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
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V23.Errors;
using Google.Ads.GoogleAds.V23.Resources;
using Google.Ads.GoogleAds.V23.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V23.Enums.ManagerLinkStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V23
{
    /// <summary>
    ///  This code example demonstrates how to link an existing Google Ads manager customer
    ///  account to an existing Google Ads client customer account.
    /// </summary>
    public class LinkManagerToClient : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="LinkManagerToClient"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// ID of the client customer being linked.
            /// </summary>
            [Option("clientCustomerId", Required = true, HelpText =
                "ID of the client customer being linked.")]
            public long ClientCustomerId { get; set; }

            /// <summary>
            /// ID of the manager customer that is being linked to.
            /// </summary>
            [Option("managerCustomerId", Required = true, HelpText =
                "ID of the manager customer that is being linked to.")]
            public long ManagerCustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            LinkManagerToClient codeExample = new LinkManagerToClient();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.ClientCustomerId,
                options.ManagerCustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example demonstrates how to link an existing Google Ads manager customer " +
            "account to an existing Google Ads client customer account.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="clientCustomerId">ID of the client customer being linked.</param>
        /// <param name="managerCustomerId">ID of the manager customer that is being linked to.
        /// </param>
        // [START link_manager_to_client]
        public void Run(GoogleAdsClient client, long managerCustomerId, long clientCustomerId)
        {
            // Remarks: For ease of understanding, this code example assumes that managerCustomerId
            // and clientCustomerId have the login email (and hence the same credentials work for
            // both accounts). In real life, this might not be the case, so you'd have a separate
            // GoogleAdsClient for managerCustomerId and clientCustomerId.
            try
            {
                // Extend an invitation to the client while authenticating as the manager.
                string customerClientLinkResourceName = CreateInvitation(client, managerCustomerId,
                    clientCustomerId);

                // Retrieve the manager link information.
                string managerLinkResourceName = GetManagerLinkResourceName(client,
                    managerCustomerId, clientCustomerId,
                    customerClientLinkResourceName);

                // Accept the manager's invitation while authenticating as the client.
                AcceptInvitation(client, clientCustomerId, managerLinkResourceName);
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

        /// <summary>
        /// Extends an invitation from a manager customer to a client customer.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="managerCustomerId">The manager customer ID.</param>
        /// <param name="clientCustomerId">The client customer ID.</param>
        /// <returns>The invitation resource name.</returns>
        private string CreateInvitation(GoogleAdsClient client, long managerCustomerId,
            long clientCustomerId)
        {
            // Get the CustomerClientLinkService.
            CustomerClientLinkServiceClient customerClientLinkService =
                client.GetService(Services.V23.CustomerClientLinkService);

            // Create a client with the manager customer ID as login customer ID.
            client.Config.LoginCustomerId = managerCustomerId.ToString();

            // Create a customer client link.
            CustomerClientLink customerClientLink = new CustomerClientLink()
            {
                ClientCustomer = ResourceNames.Customer(clientCustomerId),

                // Sets the client customer to invite.
                Status = ManagerLinkStatus.Pending
            };

            // Creates a customer client link operation for creating the one above.
            CustomerClientLinkOperation customerClientLinkOperation =
                new CustomerClientLinkOperation()
                {
                    Create = customerClientLink
                };

            // Issue a mutate request to create the customer client link.
            MutateCustomerClientLinkResponse response =
                customerClientLinkService.MutateCustomerClientLink(
                    managerCustomerId.ToString(), customerClientLinkOperation);

            // Prints the result.
            string customerClientLinkResourceName = response.Result.ResourceName;
            Console.WriteLine($"An invitation has been extended from the manager " +
                $"customer {managerCustomerId} to the client customer {clientCustomerId} with " +
                $"the customer client link resource name '{customerClientLinkResourceName}'.");

            // Returns the resource name of the created customer client link.
            return customerClientLinkResourceName;
        }

        /// <summary>
        /// Retrieves the manager link resource name of a customer client link given its resource
        /// name.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="managerCustomerId">The manager customer ID.</param>
        /// <param name="clientCustomerId">The client customer ID.</param>
        /// <param name="customerClientLinkResourceName">The customer client link resource
        /// name.</param>
        /// <returns>The manager link resource name.</returns>
        private string GetManagerLinkResourceName(GoogleAdsClient client, long managerCustomerId,
            long clientCustomerId, string customerClientLinkResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V23.GoogleAdsService);

            // Create a client with the manager customer ID as login customer ID.
            client.Config.LoginCustomerId = managerCustomerId.ToString();

            // Creates the query.
            string query = "SELECT customer_client_link.manager_link_id FROM " +
                "customer_client_link WHERE customer_client_link.resource_name = " +
                $"'{customerClientLinkResourceName}'";

            // Issue a search request by specifying the page size.
            GoogleAdsRow result = googleAdsService.Search(
                managerCustomerId.ToString(), query).First();

            // Gets the ID and resource name associated to the manager link found.
            long managerLinkId = result.CustomerClientLink.ManagerLinkId;
            string managerLinkResourceName = ResourceNames.CustomerManagerLink(
                clientCustomerId, managerCustomerId, managerLinkId);
            // Prints the result.
            Console.WriteLine($"Retrieved the manager link of the customer client link: its ID " +
                $"is {managerLinkId} and its resource name is '{managerLinkResourceName}'.");
            // Returns the resource name of the manager link found.
            return managerLinkResourceName;
        }

        /// <summary>
        /// Accepts the invitation.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="clientCustomerId">The client customer ID.</param>
        /// <param name="managerLinkResourceName">The manager link resource name.</param>
        private void AcceptInvitation(GoogleAdsClient client, long clientCustomerId,
            string managerLinkResourceName)
        {
            // Get the CustomerManagerLinkService.
            CustomerManagerLinkServiceClient customerManagerLinkService =
                client.GetService(Services.V23.CustomerManagerLinkService);

            // Create a client with the client customer ID as login customer ID.
            client.Config.LoginCustomerId = clientCustomerId.ToString();

            // Creates the customer manager link with the updated status.
            CustomerManagerLink customerManagerLink = new CustomerManagerLink()
            {
                ResourceName = managerLinkResourceName,
                Status = ManagerLinkStatus.Active
            };

            // Creates a customer manager link operation for updating the one above.
            CustomerManagerLinkOperation customerManagerLinkOperation =
                new CustomerManagerLinkOperation()
                {
                    Update = customerManagerLink,
                    UpdateMask = FieldMasks.AllSetFieldsOf(customerManagerLink)
                };

            // Issue a mutate request to update the customer manager link.
            MutateCustomerManagerLinkResponse response =
                    customerManagerLinkService.MutateCustomerManagerLink(
                clientCustomerId.ToString(), new[] { customerManagerLinkOperation }
            );

            // Prints the result.
            Console.WriteLine($"The client {clientCustomerId} accepted the invitation with " +
                $"the resource name '{response.Results[0].ResourceName}");
        }
        // [END link_manager_to_client]
    }
}

// Copyright 2021 Google LLC
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
using static Google.Ads.GoogleAds.V7.Enums.AccessRoleEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example sends an invitation email to a user to manage a customer
    /// account with a desired access role.
    /// </summary>
    public class InviteUserWithAccessRole : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            InviteUserWithAccessRole codeExample = new InviteUserWithAccessRole();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // Email address of the user to send the invitation to.
            string emailAddress = "INSERT_EMAIL_ADDRESS_HERE";

            // The access role for which the user is invited.
            AccessRole accessRole = (AccessRole)Enum.Parse(typeof(AccessRole),
                "INSERT_ACCESS_ROLE_HERE");
            codeExample.Run(new GoogleAdsClient(), customerId, emailAddress, accessRole);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example sends an invitation email to a user to manage a customer account " +
            "with a desired access role.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="emailAddress">Email address of the user to send the invitation to.</param>
        /// <param name="accessRole">The access role for which the user is invited.</param>
        public void Run(GoogleAdsClient client, long customerId, string emailAddress,
            AccessRole accessRole)
        {
            // Get the CustomerUserAccessInvitationService.
            CustomerUserAccessInvitationServiceClient service = client.GetService(
                Services.V7.CustomerUserAccessInvitationService);

            // [START invite_user_with_access_role]
            MutateCustomerUserAccessInvitationRequest invitationRequest =
                new MutateCustomerUserAccessInvitationRequest()
                {
                    CustomerId = customerId.ToString(),
                    Operation = new CustomerUserAccessInvitationOperation()
                    {
                        Create = new CustomerUserAccessInvitation()
                        {
                            EmailAddress = emailAddress,
                            AccessRole = accessRole
                        },
                    }
                };
            try
            {
                var response = service.MutateCustomerUserAccessInvitation(invitationRequest);

                Console.WriteLine("Customer user access invitation was sent for customerId = " +
                    "{0} to email address = {1} and access role = {2}. The invitation resource " +
                    "name is {3}.", customerId, emailAddress, accessRole,
                    response.Result.ResourceName);
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
            // [END invite_user_with_access_role]
        }
    }
}
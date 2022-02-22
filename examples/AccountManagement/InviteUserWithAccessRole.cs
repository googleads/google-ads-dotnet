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

using CommandLine;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Resources;
using Google.Ads.GoogleAds.V10.Services;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V10.Enums.AccessRoleEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example sends an invitation email to a user to manage a customer
    /// account with a desired access role.
    /// </summary>
    public class InviteUserWithAccessRole : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="InviteUserWithAccessRole"/> example.
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
            /// Email address of the user to send the invitation to.
            /// </summary>
            [Option("emailAddress", Required = true, HelpText =
                "Email address of the user to send the invitation to.")]
            public string EmailAddress { get; set; }

            /// <summary>
            /// The access role for which the user is invited.
            /// </summary>
            [Option("accessRole", Required = true, HelpText =
                "The access role for which the user is invited.")]
            public AccessRole AccessRole { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = new Options();
            Parser parser = new Parser(settings =>
            {
                settings.CaseInsensitiveEnumValues = true;
            });
            parser.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // Email address of the user to send the invitation to.
                    options.EmailAddress = "INSERT_EMAIL_ADDRESS_HERE";

                    // The access role for which the user is invited.
                    options.AccessRole = (AccessRole) Enum.Parse(typeof(AccessRole),
                        "INSERT_ACCESS_ROLE_HERE");

                    return 0;
                });

            InviteUserWithAccessRole codeExample = new InviteUserWithAccessRole();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId,
                options.EmailAddress,
                options.AccessRole);
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
                Services.V10.CustomerUserAccessInvitationService);

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

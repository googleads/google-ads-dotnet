// Copyright 2020 Google LLC
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
using Google.Ads.GoogleAds.Util;
using Google.Ads.GoogleAds.V9.Errors;
using Google.Ads.GoogleAds.V9.Resources;
using Google.Ads.GoogleAds.V9.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V9.Enums.AccessRoleEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// This code example updates the access role of a user, given the email address.
    /// Note: This code example should be run as a user who is an Administrator on the Google Ads
    /// account with the specified customer ID. See
    /// https://support.google.com/google-ads/answer/9978556 to learn more about account access
    /// levels.
    /// </summary>
    public class UpdateUserAccess : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UpdateUserAccess"/> example.
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
            /// Email address of the user whose access role should be updated.
            /// </summary>
            [Option("emailAddress", Required = true, HelpText =
                "Email address of the user whose access role should be updated.")]
            public string EmailAddress { get; set; }

            /// <summary>
            /// The updated access role.
            /// </summary>
            [Option("accessRole", Required = true, HelpText =
                "The updated access role.")]
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

                    // Email address of the user whose access role should be updated.
                    options.EmailAddress = "INSERT_EMAIL_ADDRESS_HERE";

                    // The updated user access role.
                    options.AccessRole = (AccessRole) Enum.Parse(typeof(AccessRole),
                        "INSERT_ACCESS_ROLE_HERE");
                    return 0;
                });

            UpdateUserAccess codeExample = new UpdateUserAccess();
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
            "This code example updates the access of a user, given the email " +
            "address. Note: This code example should be run as a user who is an Administrator" +
            " on the Google Ads account with the specified customer ID. See " +
            "https://support.google.com/google-ads/answer/9978556 to learn more about account " +
            "access levels.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="emailAddress">Email address of the user whose access role should be
        /// updated.</param>
        /// <param name="accessRole">The updated access role.</param>
        public void Run(GoogleAdsClient client, long customerId, string emailAddress,
            AccessRole accessRole)
        {
            try
            {
                long? userId = GetUserAccess(client, customerId, emailAddress);
                if (userId != null)
                {
                    ModifyUserAccess(client, customerId, userId.Value, accessRole);
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

        /// <summary>
        /// Gets the customer user access given an email address.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="emailAddress">Email address of the user whose access role should be
        /// retrieved.</param>
        /// <returns>The user ID if a customer is found, or null if no matching customers were
        /// found.</returns>
        private long? GetUserAccess(GoogleAdsClient client, long customerId, string emailAddress)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V9.GoogleAdsService);

            // Create the search query. Use the LIKE query for filtering to ignore the text case
            // for email address when searching for a match.
            string searchQuery = "Select customer_user_access.user_id, " +
                "customer_user_access.email_address, customer_user_access.access_role," +
                "customer_user_access.access_creation_date_time from customer_user_access " +
                $"where customer_user_access.email_address LIKE '{emailAddress}'";

            // Retrieves the user accesses.
            PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                googleAdsService.Search(customerId.ToString(), searchQuery);

            GoogleAdsRow result = searchPagedResponse.FirstOrDefault();

            // Displays the results.
            if (result != null)
            {
                CustomerUserAccess access = result.CustomerUserAccess;
                Console.WriteLine("Customer user access with User ID = {0}, Email Address = " +
                    "{1}, Access Role = {2} and Creation Time = {3} was found in " +
                    "Customer ID: {4}.", access.UserId, access.EmailAddress, access.AccessRole,
                    access.AccessCreationDateTime, customerId);
                return access.UserId;
            }
            else
            {
                Console.WriteLine("No customer user access with requested email was found.");
                return null;
            }
        }

        /// <summary>
        /// Modifies the user access role to a specified value.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="userId">ID of the user whose access role is modified.</param>
        /// <param name="accessRole">The updated access role.</param>
        private void ModifyUserAccess(GoogleAdsClient client, long customerId, long userId,
            AccessRole accessRole)
        {
            // Get the CustomerUserAccessService.
            CustomerUserAccessServiceClient userAccessService = client.GetService(
                Services.V9.CustomerUserAccessService);

            // Creates the modified user access.
            CustomerUserAccess userAccess = new CustomerUserAccess()
            {
                ResourceName = ResourceNames.CustomerUserAccess(customerId, userId),
                AccessRole = accessRole
            };

            // Creates the operation.
            CustomerUserAccessOperation operation = new CustomerUserAccessOperation()
            {
                Update = userAccess,
                UpdateMask = FieldMasks.AllSetFieldsOf(userAccess)
            };

            // Updates the user access.
            MutateCustomerUserAccessResponse response =
                userAccessService.MutateCustomerUserAccess(
                    customerId.ToString(), operation);

            // Displays the result.
            Console.WriteLine($"Successfully modified customer user access with " +
                $"resource name '{response.Result.ResourceName}'.");
        }
    }
}

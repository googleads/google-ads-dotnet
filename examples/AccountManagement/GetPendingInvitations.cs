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
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Services;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example retrieves pending invitations for a customer account. To create a pending
    /// invitation, see InviteUserWithAccessRole.cs.
    /// </summary>
    public class GetPendingInvitations : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetPendingInvitations"/> example.
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
            Options options = new Options();
            CommandLine.Parser.Default.ParseArguments<Options>(args).MapResult(
                delegate (Options o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // The Google Ads customer ID for which the call is made.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    return 0;
                });

            GetPendingInvitations codeExample = new GetPendingInvitations();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example retrieves pending invitations for a customer account. To create " +
            "a pending invitation, see InviteUserWithAccessRole.cs.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the AdGroupService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V7.GoogleAdsService);

            // [START get_pending_invitations]
            // Create the search query.
            string query =
                @"SELECT
                    customer_user_access_invitation.invitation_id,
                    customer_user_access_invitation.email_address,
                    customer_user_access_invitation.access_role,
                    customer_user_access_invitation.creation_date_time
                  FROM
                    customer_user_access_invitation
                  WHERE
                    customer_user_access_invitation.invitation_status=PENDING";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), query,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        foreach (GoogleAdsRow googleAdsRow in resp.Results)
                        {
                            Console.WriteLine("A pending invitation with invitation ID = {0}, " +
                                "email address = '{1}', access role = '{2}' and created on {3}" +
                                " was found.",
                                googleAdsRow.CustomerUserAccessInvitation.InvitationId,
                                googleAdsRow.CustomerUserAccessInvitation.EmailAddress,
                                googleAdsRow.CustomerUserAccessInvitation.AccessRole,
                                googleAdsRow.CustomerUserAccessInvitation.CreationDateTime
                            );
                        }
                    }
                );
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                throw;
            }
            // [END get_pending_invitations]
        }
    }
}

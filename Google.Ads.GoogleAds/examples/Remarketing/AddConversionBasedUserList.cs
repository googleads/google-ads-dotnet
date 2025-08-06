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
using Google.Ads.Gax.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V21.Common;
using Google.Ads.GoogleAds.V21.Errors;
using Google.Ads.GoogleAds.V21.Resources;
using Google.Ads.GoogleAds.V21.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V21.Enums.UserListMembershipStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V21
{
    /// <summary>
    /// This code example creates a basic user list consisting of people who triggered one or more
    /// conversion actions.
    /// </summary>
    public class AddConversionBasedUserList : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddConversionBasedUserList"/> example.
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
            /// The IDs of the conversion actions for the basic user list.
            /// </summary>
            [Option("conversionActionIds", Required = true, HelpText =
                "The IDs of the conversion actions for the basic user list.")]
            public IEnumerable<long> ConversionActionIds { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddConversionBasedUserList codeExample = new AddConversionBasedUserList();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId,
                options.ConversionActionIds.ToArray());
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a basic user list consisting of people who triggered one " +
            "or more conversion actions.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="conversionActionIds">The IDs of the conversion actions for the basic user
        /// list.</param>
        // [START add_conversion_based_user_list]
        public void Run(GoogleAdsClient client, long customerId, long[] conversionActionIds)
        {
            // Creates the service client.
            UserListServiceClient userListServiceClient =
                client.GetService(Services.V21.UserListService);

            List<UserListActionInfo> userListActionInfoList = new List<UserListActionInfo>();
            foreach (long conversionActionId in conversionActionIds)
            {
                // Creates the UserListActionInfo object for a given conversion action. This
                // specifies the conversion action that, when triggered, will cause a user to be
                // added to a UserList.
                userListActionInfoList.Add(new UserListActionInfo
                {
                    ConversionAction =
                        ResourceNames.ConversionAction(customerId, conversionActionId)
                });
            }

            // Creates a basic user list info object with all of the conversion actions.
            BasicUserListInfo basicUserListInfo = new BasicUserListInfo();
            basicUserListInfo.Actions.Add(userListActionInfoList);

            // Creates the basic user list.
            UserList basicUserList = new UserList
            {
                Name = $"Example BasicUserList #{ExampleUtilities.GetShortRandomString()}",
                Description = "A list of people who have triggered one or more conversion actions",
                MembershipLifeSpan = 365L,
                BasicUserList = basicUserListInfo,
                MembershipStatus = UserListMembershipStatus.Open
            };

            // Creates the operation.
            UserListOperation operation = new UserListOperation
            {
                Create = basicUserList
            };

            try
            {
                // Adds the new user list.
                MutateUserListsResponse response = userListServiceClient.MutateUserLists
                    (customerId.ToString(), new[] { operation });

                // Prints the result.
                Console.WriteLine("Created basic user list with resource name: " +
                    $"{response.Results.First().ResourceName}");
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
        // [END add_conversion_based_user_list]
    }
}

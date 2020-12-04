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

using System;
using System.Collections.Generic;
using System.Linq;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;
using static Google.Ads.GoogleAds.V6.Enums.UserListMembershipStatusEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example creates a basic user list consisting of people who triggered one or more
    /// conversion actions.
    /// </summary>
    public class AddConversionBasedUserList : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddConversionBasedUserList codeExample = new AddConversionBasedUserList();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The IDs of the conversion actions for the basic user list.
            long[] conversionActionIds =
            {
                long.Parse("INSERT_FIRST_CONVERSION_ACTION_ID_HERE"),
                long.Parse("INSERT_SECOND_CONVERSION_ACTION_ID_HERE"),
            };

            codeExample.Run(new GoogleAdsClient(), customerId, conversionActionIds);
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
        /// <param name="customerId">The client customer ID.</param>
        /// <param name="conversionActionIds">The IDs of the conversion actions for the basic user
        ///     list.</param>
        // [START AddConversionBasedUserList]
        public void Run(GoogleAdsClient client, long customerId, long[] conversionActionIds)
        {
            // Creates the service client.
            UserListServiceClient userListServiceClient =
                client.GetService(Services.V6.UserListService);

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
                    (customerId.ToString(), new[] {operation});

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
        // [END AddConversionBasedUserList]
    }
}

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
using Google.Ads.GoogleAds.V6.Enums;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Ads.GoogleAds.V6.Resources;
using Google.Ads.GoogleAds.V6.Services;

namespace Google.Ads.GoogleAds.Examples.V6
{
    /// <summary>
    /// This code example creates a combination user list containing users that are present on any
    /// one of the provided user lists.
    /// </summary>
    public class AddLogicalUserList : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            AddLogicalUserList codeExample = new AddLogicalUserList();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The IDs of the lists to be used for the new combination user list.
            long[] userListIds =
            {
                long.Parse("INSERT_USER_LIST_ID_HERE"),
                long.Parse("INSERT_USER_LIST_ID_HERE")
            };

            codeExample.Run(new GoogleAdsClient(), customerId, userListIds);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a combination user list containing users that are present " +
            "on any one of the provided user lists.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="userListIds">The IDs of the lists to be used for the new combination user
        ///     list.</param>
        // [START add_logical_user_list]
        public void Run(GoogleAdsClient client, long customerId, long[] userListIds)
        {
            // Gets the UserListService client.
            UserListServiceClient userListServiceClient =
                client.GetService(Services.V6.UserListService);

            // Adds each of the provided list IDs to a list of rule operands specifying which lists
            // the operator should target.
            List<LogicalUserListOperandInfo> logicalUserListOperandInfoList =
                userListIds.Select(userListId => new LogicalUserListOperandInfo
                    {UserList = ResourceNames.UserList(customerId, userListId)}).ToList();

            // Creates the UserListLogicalRuleInfo specifying that a user should be added to the new
            // list if they are present in any of the provided lists.
            UserListLogicalRuleInfo userListLogicalRuleInfo = new UserListLogicalRuleInfo
            {
                // Using ANY means that a user should be added to the combined list if they are
                // present on any of the lists targeted in the LogicalUserListOperandInfo. Use ALL
                // to add users present on all of the provided lists or NONE to add users that
                // aren't present on any of the targeted lists.
                Operator = UserListLogicalRuleOperatorEnum.Types.UserListLogicalRuleOperator.Any,
            };
            userListLogicalRuleInfo.RuleOperands.Add(logicalUserListOperandInfoList);

            LogicalUserListInfo logicalUserListInfo = new LogicalUserListInfo();
            logicalUserListInfo.Rules.Add(userListLogicalRuleInfo);

            // Creates the new combination user list.
            UserList userList = new UserList
            {
                Name = "My combination list of other user lists " +
                       $"#{ExampleUtilities.GetRandomString()}",
                LogicalUserList = logicalUserListInfo
            };

            // Creates the operation.
            UserListOperation operation = new UserListOperation
            {
                Create = userList
            };

            try
            {
                // Sends the request to add the user list and prints the response.
                MutateUserListsResponse response = userListServiceClient.MutateUserLists
                    (customerId.ToString(), new[] {operation});
                Console.WriteLine("Created combination user list with resource name: " +
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
        // [END add_logical_user_list]
    }
}

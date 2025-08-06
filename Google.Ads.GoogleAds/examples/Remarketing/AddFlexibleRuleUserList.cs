// Copyright 2023 Google LLC
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
using static Google.Ads.GoogleAds.V21.Enums.UserListFlexibleRuleOperatorEnum.Types;
using static Google.Ads.GoogleAds.V21.Enums.UserListMembershipStatusEnum.Types;
using static Google.Ads.GoogleAds.V21.Enums.UserListPrepopulationStatusEnum.Types;
using static Google.Ads.GoogleAds.V21.Enums.UserListStringRuleItemOperatorEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V21
{
    /// <summary>
    /// Creates a rule-based user list defined by a combination of rules for users who have visited
    /// two different pages of a website.
    /// </summary>
    public class AddFlexibleRuleUserList : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddFlexibleRuleUserList"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the user list is added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the user list is added.")]
            public long CustomerId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddFlexibleRuleUserList codeExample = new AddFlexibleRuleUserList();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        private const string URL_STRING = "url__";

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example creates a rule-based user list defined by a combination of rules " +
            "for users who have visited two different pages of a website.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the user list is
        /// added.</param>
        // [START add_combined_rule_user_list]
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Creates a UserListRuleInfo object containing the first rule.
            UserListRuleInfo userVisitedSite1Rule =
                CreateUserListRuleInfoFromUrl("http://example.com/example1");

            // Creates a UserListRuleInfo object containing the second rule.
            UserListRuleInfo userVisitedSite2Rule =
                CreateUserListRuleInfoFromUrl("http://example.com/example2");

            // Creates a UserListRuleInfo object containing the third rule.
            UserListRuleInfo userVisitedSite3Rule =
                CreateUserListRuleInfoFromUrl("http://example.com/example3");

            // Create the user list "Visitors of page 1 AND page 2, but not page 3". To create the
            // user list "Visitors of page 1 *OR* page 2, but not page 3", change the
            // UserListFlexibleRuleOperator from And to Or.
            FlexibleRuleUserListInfo flexibleRuleUserListInfo = new FlexibleRuleUserListInfo
            {
                InclusiveRuleOperator = UserListFlexibleRuleOperator.And
            };

            // Inclusive operands are joined together with the specified inclusiveRuleOperator. This
            // represents the set of users that should be included in the user list.
            flexibleRuleUserListInfo.InclusiveOperands.Add(new FlexibleRuleOperandInfo
            {
                Rule = userVisitedSite1Rule,
                // Optional: adds a lookback window for this rule, in days.
                LookbackWindowDays = 7
            });
            flexibleRuleUserListInfo.InclusiveOperands.Add(new FlexibleRuleOperandInfo
            {
                Rule = userVisitedSite2Rule,
                // Optional: adds a lookback window for this rule, in days.
                LookbackWindowDays = 7
            });

            // Exclusive operands are joined together with OR. This represents the set of users
            // to be excluded from the user list.
            flexibleRuleUserListInfo.InclusiveOperands.Add(new FlexibleRuleOperandInfo
            {
                Rule = userVisitedSite3Rule
            });

            // Defines a representation of a user list that is generated by a rule.
            RuleBasedUserListInfo ruleBasedUserListInfo = new RuleBasedUserListInfo
            {
                // Optional: To include past users in the user list, set the prepopulation_status to
                // REQUESTED.
                PrepopulationStatus = UserListPrepopulationStatus.Requested,
                FlexibleRuleUserList = flexibleRuleUserListInfo
            };

            // Creates a user list.
            UserList userList = new UserList
            {
                Name = $"Flexible rule user list example.com #{ExampleUtilities.GetRandomString()}",
                Description = "Visitors of both https://example.com/example1 AND " +
                    "https://example.com/example2 but NOT https://example.com/example3",
                MembershipStatus = UserListMembershipStatus.Open,
                RuleBasedUserList = ruleBasedUserListInfo
            };

            // Creates the operation.
            UserListOperation operation = new UserListOperation
            {
                Create = userList
            };

            try
            {
                UserListServiceClient userListServiceClient =
                    client.GetService(Services.V21.UserListService);
                MutateUserListsResponse response =
                    userListServiceClient.MutateUserLists(customerId.ToString(),
                        new[] { operation });

                string userListResourceName = response.Results[0].ResourceName;
                Console.WriteLine($"Created user list with resource name '{userListResourceName}'.");
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
        /// Creates a UserListRuleInfo object containing a rule targeting any user that visited the
        /// provided URL.
        /// </summary>
        private UserListRuleInfo CreateUserListRuleInfoFromUrl(string urlString)
        {
            // Creates a rule targeting any user that visited a URL that equals the given urlString.
            UserListRuleItemInfo userVisitedSiteRule = new UserListRuleItemInfo
            {
                Name = URL_STRING,
                StringRuleItem = new UserListStringRuleItemInfo
                {
                    Operator = UserListStringRuleItemOperator.Equals,
                    Value = urlString
                }
            };

            // Returns a UserListRuleInfo object containing the rule.
            UserListRuleInfo userListRuleInfo = new UserListRuleInfo();
            UserListRuleItemGroupInfo userListRuleItemGroupInfo = new UserListRuleItemGroupInfo();
            userListRuleItemGroupInfo.RuleItems.Add(userVisitedSiteRule);
            userListRuleInfo.RuleItemGroups.Add(userListRuleItemGroupInfo);

            return userListRuleInfo;
        }
        // [END add_combined_rule_user_list]
    }
}
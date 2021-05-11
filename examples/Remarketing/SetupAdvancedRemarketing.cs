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
using Google.Ads.GoogleAds.V7.Common;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V7.Enums.UserListDateRuleItemOperatorEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.UserListMembershipStatusEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.UserListNumberRuleItemOperatorEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.UserListPrepopulationStatusEnum.Types;
using static Google.Ads.GoogleAds.V7.Enums.UserListStringRuleItemOperatorEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// Creates a rule-based user list defined by an expression rule for users who have either
    /// checked out in November or December OR visited the checkout page with more than one item
    /// in their cart.
    /// </summary>
    public class SetupAdvancedRemarketing : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="SetupAdvancedRemarketing"/> example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for which the conversion action is added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for which the conversion action is added.")]
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
                    // The Google Ads customer ID for which the conversion action is added.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    return 0;
                });

            SetupAdvancedRemarketing codeExample = new SetupAdvancedRemarketing();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Creates a rule-based user list defined by an expression rule for users who have " +
            "either checked out in November or December OR visited the checkout page with more " +
            "than one item in their cart.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the conversion action is
        /// added.</param>
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the user list service client.
            UserListServiceClient userListServiceClient =
                client.GetService(Services.V7.UserListService);

            try
            {
                // Create a rule targeting any user that visited the checkout page.
                // [START setup_advanced_remarketing]
                UserListRuleItemInfo checkoutRule = new UserListRuleItemInfo
                {
                    // The rule variable name must match a corresponding key name fired from a pixel.
                    // To learn more about setting up remarketing tags, visit
                    // https://support.google.com/google-ads/answer/2476688.
                    // To learn more about remarketing events and parameters, visit
                    // https://support.google.com/google-ads/answer/7305793.
                    Name = "ecomm_pagetype",
                    StringRuleItem = new UserListStringRuleItemInfo
                    {
                        Operator = UserListStringRuleItemOperator.Equals,
                        Value = "checkout"
                    }
                };
                // [END setup_advanced_remarketing]

                // Create a rule targeting any user that had more than one item in their cart.
                // [START setup_advanced_remarketing_1]
                UserListRuleItemInfo cartSizeRule = new UserListRuleItemInfo
                {
                    // The rule variable name must match a corresponding key name fired from a pixel.
                    Name = "cart_size",
                    NumberRuleItem = new UserListNumberRuleItemInfo
                    {
                        Operator = UserListNumberRuleItemOperator.GreaterThan,
                        Value = 1.0
                    }
                };
                // [END setup_advanced_remarketing_1]

                // Create a rule group that includes the checkout and cart size rules. Combining the
                // two rule items into a UserListRuleItemGroupInfo object causes Google Ads to AND
                // their rules together. To instead OR the rules together, each rule should be
                // placed in its own rule item group.
                // [START setup_advanced_remarketing_2]
                UserListRuleItemGroupInfo checkoutAndCartSizeRuleGroup =
                    new UserListRuleItemGroupInfo();
                checkoutAndCartSizeRuleGroup.RuleItems.Add(checkoutRule);
                checkoutAndCartSizeRuleGroup.RuleItems.Add(cartSizeRule);
                // [END setup_advanced_remarketing_2]

                // Create the RuleItem for checkout start date.
                // The tags and keys used below must have been in place in the past for the date
                // range specified in the rules.
                // [START setup_advanced_remarketing_3]
                UserListRuleItemInfo startDateRule = new UserListRuleItemInfo
                {
                    // The rule variable name must match a corresponding key name fired from a pixel.
                    Name = "checkoutdate",
                    DateRuleItem = new UserListDateRuleItemInfo
                    {
                        // Available UserListDateRuleItemOperators can be found at
                        // https://developers.google.com/google-ads/api/reference/rpc/latest/UserListDateRuleItemOperatorEnum.UserListDateRuleItemOperator
                        Operator = UserListDateRuleItemOperator.After,
                        Value = "20191031"
                    }
                };
                // [END setup_advanced_remarketing_3]

                // Create the RuleItem for checkout end date.
                // [START setup_advanced_remarketing_4]
                UserListRuleItemInfo endDateRule = new UserListRuleItemInfo
                {
                    // The rule variable name must match a corresponding key name fired from a pixel.
                    Name = "checkoutdate",
                    DateRuleItem = new UserListDateRuleItemInfo
                    {
                        Operator = UserListDateRuleItemOperator.Before,
                        Value = "20200101"
                    }
                };
                // [END setup_advanced_remarketing_4]

                // Create a rule group targeting users who checked out between November and December
                // by using the start and end date rules. Combining the two rule items into a
                // UserListRuleItemGroupInfo object causes Google Ads to AND their rules together.
                // To instead OR the rules together, each rule should be placed in its own rule item
                // group.
                // [START setup_advanced_remarketing_5]
                UserListRuleItemGroupInfo checkoutDateRuleGroup = new UserListRuleItemGroupInfo();
                checkoutDateRuleGroup.RuleItems.Add(startDateRule);
                checkoutDateRuleGroup.RuleItems.Add(endDateRule);
                // [END setup_advanced_remarketing_5]

                // Create an ExpressionRuleUserListInfo object, or a boolean rule that defines this
                // user list. The default rule_type for a UserListRuleInfo object is OR of ANDs
                // (disjunctive normal form). That is, rule items will be ANDed together within rule
                // item groups and the groups themselves will be ORed together.
                // [START setup_advanced_remarketing_6]
                ExpressionRuleUserListInfo expressionRuleUserListInfo =
                    new ExpressionRuleUserListInfo
                    {
                        Rule = new UserListRuleInfo()
                    };
                expressionRuleUserListInfo.Rule.RuleItemGroups.Add(checkoutAndCartSizeRuleGroup);
                expressionRuleUserListInfo.Rule.RuleItemGroups.Add(checkoutDateRuleGroup);
                // [END setup_advanced_remarketing_6]

                // Defines a representation of a user list that is generated by a rule.
                RuleBasedUserListInfo ruleBasedUserListInfo = new RuleBasedUserListInfo
                {
                    // Optional: To include past users in the user list, set the
                    // prepopulation status to REQUESTED.
                    PrepopulationStatus = UserListPrepopulationStatus.Requested,
                    ExpressionRuleUserList = expressionRuleUserListInfo
                };

                // Create a user list.
                UserList userList = new UserList
                {
                    Name = $"My expression rule user list #{ExampleUtilities.GetRandomString()}",
                    Description =
                        "Users who checked out in November or December OR visited the checkout " +
                        "page with more than one item in their cart",
                    MembershipLifeSpan = 90L,
                    MembershipStatus = UserListMembershipStatus.Open,
                    RuleBasedUserList = ruleBasedUserListInfo
                };

                // Create the operation.
                UserListOperation userListOperation = new UserListOperation
                {
                    Create = userList
                };

                // Add the user list and print the results.
                MutateUserListsResponse response =
                    userListServiceClient.MutateUserLists(customerId.ToString(),
                        new[] { userListOperation });

                string userListResourceName = response.Results.First().ResourceName;
                Console.WriteLine(
                    $"Created user list with resource name '{userListResourceName}'.");
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
    }
}

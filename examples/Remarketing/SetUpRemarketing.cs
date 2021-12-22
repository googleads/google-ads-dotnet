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
using Google.Ads.GoogleAds.V9.Common;
using Google.Ads.GoogleAds.V9.Errors;
using Google.Ads.GoogleAds.V9.Resources;
using Google.Ads.GoogleAds.V9.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V9.Enums.UserListMembershipStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.UserListPrepopulationStatusEnum.Types;
using static Google.Ads.GoogleAds.V9.Enums.UserListStringRuleItemOperatorEnum.Types;
using static Google.Ads.GoogleAds.V9.Errors.CriterionErrorEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V9
{
    /// <summary>
    /// Demonstrates various operations involved in remarketing, including:
    ///   (a) creating a user list based on visitors to a website,
    ///   (b) targeting a user list with an ad group criterion,
    ///   (c) updating the bid modifier on an ad group criterion,
    ///   (d) finding and removing all ad group criteria under a given campaign,
    ///   (e) targeting a user list with a campaign criterion, and
    ///   (f) updating the bid modifier on a campaign criterion.
    /// It is unlikely that users will need to perform all of these operations consecutively, and
    /// all of the operations contained herein are meant of for illustrative purposes.
    /// Note: you can use user lists to target at the campaign or ad group level, but not both
    /// simultaneously. Consider removing or disabling any existing user lists at the campaign level
    /// before running this example.
    /// </summary>
    public class SetUpRemarketing : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="SetUpRemarketing"/> example.
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
            /// The ad group ID on which criteria will be targeted.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "The ad group ID on which criteria will be targeted.")]
            public long AdGroupId { get; set; }

            /// <summary>
            /// The campaign ID on which criteria will be targeted.
            /// </summary>
            [Option("campaignId", Required = true, HelpText =
                "The campaign ID on which criteria will be targeted.")]
            public long CampaignId { get; set; }

            /// <summary>
            /// The bid modifier value.
            /// </summary>
            [Option("bidModifierValue", Required = true, HelpText =
                "The bid modifier value.")]
            public double BidModifierValue { get; set; }
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

                    // The ad group ID on which criteria will be targeted.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    // The campaign ID on which criteria will be targeted.
                    options.CampaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

                    // The bid modifier value.
                    options.BidModifierValue = double.Parse("INSERT_BID_MODIFIER_VALUE_HERE");

                    return 0;
                });

            SetUpRemarketing codeExample = new SetUpRemarketing();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId,
                options.CampaignId, options.BidModifierValue);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "Demonstrates various operations involved in remarketing, including:\n" +
            "\t(a) creating a user list based on visitors to a website,\n" +
            "\t(b) targeting a user list with an ad group criterion,\n" +
            "\t(c) updating the bid modifier on an ad group criterion,\n" +
            "\t(d) finding and removing all ad group criteria under a given campaign,\n" +
            "\t(e) targeting a user list with a campaign criterion, and\n" +
            "\t(f) updating the bid modifier on a campaign criterion.\n" +
            "It is unlikely that users will need to perform all of these operations " +
            "consecutively, and all of the operations contained herein are meant of for " +
            "illustrative purposes.\n" +
            "Note: you can use user lists to target at the campaign or ad group level, but not " +
            "both simultaneously. Consider removing or disabling any existing user lists at the " +
            "campaign level before running this example.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group ID on which criteria will be targeted.</param>
        /// <param name="campaignId">The campaign ID on which criteria will be targeted.</param>
        /// <param name="bidModifierValue">The bid modifier value.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId, long campaignId,
            double bidModifierValue)
        {
            try
            {
                // Create a new example user list.
                string userListResourceName = CreateUserList(client, customerId);

                // Target an ad group to the new user list.
                string adGroupCriterionResourceName =
                    TargetAdsInAdGroupToUserList(client, customerId, adGroupId,
                        userListResourceName);
                ModifyAdGroupBids(client, customerId, adGroupCriterionResourceName,
                    bidModifierValue);

                // Remove any existing user lists at the ad group level.
                RemoveExistingListCriteriaFromAdGroup(client, customerId, campaignId);

                // Target the campaign to the new user list.
                string campaignCriterionResourceName =
                    TargetAdsInCampaignToUserList(client, customerId, campaignId,
                        userListResourceName);
                ModifyCampaignBids(client, customerId, campaignCriterionResourceName,
                    bidModifierValue);
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
                if (e.Failure.Errors.First().ErrorCode.CriterionError ==
                    CriterionError.CannotAttachCriteriaAtCampaignAndAdgroup)
                {
                    Console.WriteLine("This error can occur when user lists are already targeted " +
                        "at the campaign level. You can use user lists to target at the campaign " +
                        "or ad group level, but not both simultaneously. Consider removing or " +
                        "disabling any existing user lists at the campaign level before running " +
                        "this example.");
                }

                throw;
            }
        }

        /// <summary>
        /// Creates a user list targeting users that have visited a given url.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <returns>The resource name of the newly created user list.</returns>
        // [START setup_remarketing]
        private string CreateUserList(GoogleAdsClient client, long customerId)
        {
            // Get the UserListService client.
            UserListServiceClient userListServiceClient =
                client.GetService(Services.V9.UserListService);

            // Create a rule targeting any user that visited a url containing 'example.com'.
            UserListRuleItemInfo rule = new UserListRuleItemInfo
            {
                // Use a built-in parameter to create a domain URL rule.
                Name = "url__",
                StringRuleItem = new UserListStringRuleItemInfo
                {
                    Operator = UserListStringRuleItemOperator.Contains,
                    Value = "example.com"
                }
            };

            // Specify that the user list targets visitors of a page based on the provided rule.
            ExpressionRuleUserListInfo expressionRuleUserListInfo = new ExpressionRuleUserListInfo
            {
                Rule = new UserListRuleInfo()
            };
            UserListRuleItemGroupInfo userListRuleItemGroupInfo = new UserListRuleItemGroupInfo();
            userListRuleItemGroupInfo.RuleItems.Add(rule);
            expressionRuleUserListInfo.Rule.RuleItemGroups.Add(userListRuleItemGroupInfo);

            // Define a representation of a user list that is generated by a rule.
            RuleBasedUserListInfo ruleBasedUserListInfo = new RuleBasedUserListInfo
            {
                // Optional: To include past users in the user list, set the prepopulation_status to
                // REQUESTED.
                PrepopulationStatus = UserListPrepopulationStatus.Requested,
                ExpressionRuleUserList = expressionRuleUserListInfo
            };

            // Create the user list.
            UserList userList = new UserList
            {
                Name = $"All visitors to example.com #{ExampleUtilities.GetRandomString()}",
                Description = "Any visitor to any page of example.com",
                MembershipStatus = UserListMembershipStatus.Open,
                MembershipLifeSpan = 365L,
                RuleBasedUserList = ruleBasedUserListInfo
            };

            // Create the operation.
            UserListOperation userListOperation = new UserListOperation
            {
                Create = userList
            };

            // Add the user list, then print and return the new list's resource name.
            MutateUserListsResponse mutateUserListsResponse = userListServiceClient
                .MutateUserLists(customerId.ToString(), new[] { userListOperation });
            string userListResourceName = mutateUserListsResponse.Results.First().ResourceName;
            Console.WriteLine($"Created user list with resource name '{userListResourceName}'.");

            return userListResourceName;
        }
        // [END setup_remarketing]

        /// <summary>
        /// Creates an ad group criterion that targets a user list with an ad group.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupId">The ad group on which the user list will be targeted.</param>
        /// <param name="userListResourceName">The resource name of the user list to be
        /// targeted.</param>
        /// <returns>The resource name of the newly created ad group criterion.</returns>
        // [START setup_remarketing_1]
        private string TargetAdsInAdGroupToUserList(
            GoogleAdsClient client, long customerId, long adGroupId, string userListResourceName)
        {
            // Get the AdGroupCriterionService client.
            AdGroupCriterionServiceClient adGroupCriterionServiceClient = client.GetService
                (Services.V9.AdGroupCriterionService);

            // Create the ad group criterion targeting members of the user list.
            AdGroupCriterion adGroupCriterion = new AdGroupCriterion
            {
                AdGroup = ResourceNames.AdGroup(customerId, adGroupId),
                UserList = new UserListInfo
                {
                    UserList = userListResourceName
                }
            };

            // Create the operation.
            AdGroupCriterionOperation adGroupCriterionOperation = new AdGroupCriterionOperation
            {
                Create = adGroupCriterion
            };

            // Add the ad group criterion, then print and return the new criterion's resource name.
            MutateAdGroupCriteriaResponse mutateAdGroupCriteriaResponse =
                adGroupCriterionServiceClient.MutateAdGroupCriteria(customerId.ToString(),
                    new[] { adGroupCriterionOperation });

            string adGroupCriterionResourceName =
                mutateAdGroupCriteriaResponse.Results.First().ResourceName;
            Console.WriteLine("Successfully created ad group criterion with resource name " +
                $"'{adGroupCriterionResourceName}' targeting user list with resource name " +
                $"'{userListResourceName}' with ad group with ID {adGroupId}.");
            return adGroupCriterionResourceName;
        }
        // [END setup_remarketing_1]

        /// <summary>
        /// Updates the bid modifier on an ad group criterion.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="adGroupCriterionResourceName">The resource name of the ad group criterion to update.</param>
        /// <param name="bidModifierValue">The bid modifier value.</param>
        private void ModifyAdGroupBids(
            GoogleAdsClient client,
            long customerId,
            string adGroupCriterionResourceName,
            double bidModifierValue)
        {
            // Get the AdGroupCriterionService client.
            AdGroupCriterionServiceClient adGroupCriterionServiceClient =
                client.GetService(Services.V9.AdGroupCriterionService);

            // Create the ad group criterion with a bid modifier. You may alternatively set the bid
            // for the ad group criterion directly.
            AdGroupCriterion adGroupCriterion = new AdGroupCriterion
            {
                ResourceName = adGroupCriterionResourceName,
                BidModifier = bidModifierValue
            };

            // Create the update operation.
            AdGroupCriterionOperation adGroupCriterionOperation = new AdGroupCriterionOperation
            {
                Update = adGroupCriterion,
                UpdateMask = FieldMasks.AllSetFieldsOf(adGroupCriterion)
            };

            // Update the ad group criterion and print the results.
            MutateAdGroupCriteriaResponse mutateAdGroupCriteriaResponse =
                adGroupCriterionServiceClient.MutateAdGroupCriteria(customerId.ToString(),
                    new[] { adGroupCriterionOperation });
            Console.WriteLine("Successfully updated the bid for ad group criterion with resource " +
                $"name '{mutateAdGroupCriteriaResponse.Results.First().ResourceName}'.");
        }

        /// <summary>
        /// Removes all ad group criteria targeting a user list under a given campaign. This is a
        /// necessary step before targeting a user list at the campaign level.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">The campaign from which to remove the ad group criteria.</param>
        // [START setup_remarketing_3]
        private void RemoveExistingListCriteriaFromAdGroup(GoogleAdsClient client, long customerId,
            long campaignId)
        {
            // Get the AdGroupCriterionService client.
            AdGroupCriterionServiceClient adGroupCriterionServiceClient =
                client.GetService(Services.V9.AdGroupCriterionService);

            // Retrieve all of the ad group criteria under a campaign.
            List<string> adGroupCriteria =
                GetUserListAdGroupCriteria(client, customerId, campaignId);

            // Create a list of remove operations.
            List<AdGroupCriterionOperation> operations = adGroupCriteria.Select(adGroupCriterion =>
                new AdGroupCriterionOperation { Remove = adGroupCriterion }).ToList();

            // Remove the ad group criteria and print the resource names of the removed criteria.
            MutateAdGroupCriteriaResponse mutateAdGroupCriteriaResponse =
                adGroupCriterionServiceClient.MutateAdGroupCriteria(customerId.ToString(),
                    operations);

            Console.WriteLine($"Removed {mutateAdGroupCriteriaResponse.Results.Count} ad group " +
                "criteria.");
            foreach (MutateAdGroupCriterionResult result in mutateAdGroupCriteriaResponse.Results)
            {
                Console.WriteLine("Successfully removed ad group criterion with resource name " +
                    $"'{result.ResourceName}'.");
            }
        }
        // [END setup_remarketing_3]

        /// <summary>
        /// Finds all of user list ad group criteria under a campaign.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">The campaign in which to search the ad group criteria.</param>
        /// <returns>A list of ad group criteria resource names.</returns>
        // [START setup_remarketing_2]
        private List<string> GetUserListAdGroupCriteria(
            GoogleAdsClient client, long customerId, long campaignId)
        {
            // Get the GoogleAdsService client.
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V9.GoogleAdsService);

            List<string> userListCriteriaResourceNames = new List<string>();

            // Create a query that will retrieve all of the ad group criteria under a campaign.
            string query = $@"
                SELECT ad_group_criterion.criterion_id
                FROM ad_group_criterion
                WHERE
                  campaign.id = {campaignId}
                  AND ad_group_criterion.type = 'USER_LIST'";

            // Issue the search request.
            googleAdsServiceClient.SearchStream(customerId.ToString(), query,
                delegate (SearchGoogleAdsStreamResponse resp)
                {
                    // Display the results and add the resource names to the list.
                    foreach (GoogleAdsRow googleAdsRow in resp.Results)
                    {
                        string adGroupCriterionResourceName =
                            googleAdsRow.AdGroupCriterion.ResourceName;
                        Console.WriteLine("Ad group criterion with resource name " +
                            $"{adGroupCriterionResourceName} was found.");
                        userListCriteriaResourceNames.Add(adGroupCriterionResourceName);
                    }
                });

            return userListCriteriaResourceNames;
        }
        // [END setup_remarketing_2]

        /// <summary>
        /// Creates a campaign criterion that targets a user list with a campaign.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">The campaign on which the user list will be targeted.</param>
        /// <param name="userListResourceName">The resource name of the user list to be
        /// targeted.</param>
        /// <returns>The resource name of the newly created campaign criterion.</returns>
        // [START setup_remarketing_4]
        private string TargetAdsInCampaignToUserList(
            GoogleAdsClient client, long customerId, long campaignId, string userListResourceName)
        {
            // Get the CampaignCriterionService client.
            CampaignCriterionServiceClient campaignCriterionServiceClient =
                client.GetService(Services.V9.CampaignCriterionService);

            // Create the campaign criterion.
            CampaignCriterion campaignCriterion = new CampaignCriterion
            {
                Campaign = ResourceNames.Campaign(customerId, campaignId),
                UserList = new UserListInfo
                {
                    UserList = userListResourceName
                }
            };

            // Create the operation.
            CampaignCriterionOperation campaignCriterionOperation = new CampaignCriterionOperation
            {
                Create = campaignCriterion
            };

            // Add the campaign criterion and print the resulting criterion's resource name.
            MutateCampaignCriteriaResponse mutateCampaignCriteriaResponse =
                campaignCriterionServiceClient.MutateCampaignCriteria(customerId.ToString(),
                    new[] { campaignCriterionOperation });

            string campaignCriterionResourceName =
                mutateCampaignCriteriaResponse.Results.First().ResourceName;
            Console.WriteLine("Successfully created campaign criterion with resource name " +
                $"'{campaignCriterionResourceName}' targeting user list with resource name " +
                $"'{userListResourceName}' with campaign with ID {campaignId}.");

            return campaignCriterionResourceName;
        }
        // [END setup_remarketing_4]

        /// <summary>
        /// Updates the bid modifier on a campaign criterion.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignCriterionResourceName">The resource name of the campaign criterion to update.</param>
        /// <param name="bidModifierValue">The bid modifier value.</param>
        private void ModifyCampaignBids(
            GoogleAdsClient client,
            long customerId,
            string campaignCriterionResourceName,
            double bidModifierValue)
        {
            // Get the CampaignCriterionService client.
            CampaignCriterionServiceClient campaignCriterionServiceClient =
                client.GetService(Services.V9.CampaignCriterionService);

            // Create the campaign criterion to update.
            CampaignCriterion campaignCriterion = new CampaignCriterion
            {
                ResourceName = campaignCriterionResourceName,
                BidModifier = (float) bidModifierValue
            };

            // Create the update operation.
            CampaignCriterionOperation campaignCriterionOperation = new CampaignCriterionOperation
            {
                Update = campaignCriterion,
                UpdateMask = FieldMasks.AllSetFieldsOf(campaignCriterion)
            };

            // Update the campaign criterion and print the results.
            MutateCampaignCriteriaResponse mutateCampaignCriteriaResponse =
                campaignCriterionServiceClient.MutateCampaignCriteria(customerId.ToString(),
                    new[] { campaignCriterionOperation });
            Console.WriteLine("Successfully updated the bid for campaign criterion with resource " +
                $"name '{mutateCampaignCriteriaResponse.Results.First().CampaignCriterion}'.");
        }
    }
}

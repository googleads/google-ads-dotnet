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
using Google.Ads.GoogleAds.V7.Common;
using Google.Ads.GoogleAds.V7.Errors;
using Google.Ads.GoogleAds.V7.Resources;
using Google.Ads.GoogleAds.V7.Services;
using Google.Api.Gax;
using Google.Protobuf.Collections;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V7.Enums.TargetingDimensionEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V7
{
    /// <summary>
    /// This code example updates the AUDIENCE target restriction of a given ad group to bid only.
    /// </summary>
    public class UpdateAudienceTargetRestriction : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="UpdateAudienceTargetRestriction"/>
        /// example.
        /// </summary>
        public class Options : OptionsBase
        {
            /// <summary>
            /// The Google Ads customer ID for the conversion action is added.
            /// </summary>
            [Option("customerId", Required = true, HelpText =
                "The Google Ads customer ID for the conversion action is added.")]
            public long CustomerId { get; set; }

            /// <summary>
            /// The ad group ID for which to update the audience targeting restriction.
            /// </summary>
            [Option("adGroupId", Required = true, HelpText =
                "The ad group ID for which to update the audience targeting restriction.")]
            public long AdGroupId { get; set; }
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
                    // The Google Ads customer ID for the conversion action is added.
                    options.CustomerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

                    // The ad group ID for which to update the audience targeting restriction.
                    options.AdGroupId = long.Parse("INSERT_AD_GROUP_ID_HERE");

                    return 0;
                });

            UpdateAudienceTargetRestriction codeExample = new UpdateAudienceTargetRestriction();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.AdGroupId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example updates the AUDIENCE target restriction of a given ad group to " +
            "bid only.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for the conversion action is
        ///     added.</param>
        /// <param name="adGroupId">The ad group ID for which to update the audience targeting
        ///     restriction.</param>
        public void Run(GoogleAdsClient client, long customerId, long adGroupId)
        {
            // Get the GoogleAdsService client.
            GoogleAdsServiceClient googleAdsServiceClient =
                client.GetService(Services.V7.GoogleAdsService);

            // Create a search request that retrieves the targeting settings from a given ad group.
            // [START update_audience_target_restriction]
            string query = $@"
                SELECT ad_group.id, ad_group.name, ad_group.targeting_setting.target_restrictions
                FROM ad_group
                WHERE ad_group.id = {adGroupId}";
            // [END update_audience_target_restriction]

            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchResponse =
                    googleAdsServiceClient.Search(customerId.ToString(), query);

                // Create an empty TargetingSetting instance.
                TargetingSetting targetingSetting = new TargetingSetting();

                // Create a flag that specifies whether or not we should update the targeting
                // setting. We should only do this if we find an AUDIENCE target restriction with
                // bid_only set to false.
                bool shouldUpdateTargetingSetting = false;

                // Iterate over all rows in all pages and prints the requested field values for the
                // ad group in each row.
                foreach (GoogleAdsRow googleAdsRow in searchResponse)
                {
                    AdGroup adGroup = googleAdsRow.AdGroup;

                    Console.WriteLine($"Ad group with ID {adGroup.Id} and name '{adGroup.Name}' " +
                        "was found with the following targeting restrictions:");

                    RepeatedField<TargetRestriction> targetRestrictions =
                        adGroup.TargetingSetting.TargetRestrictions;

                    // Loop through and print each of the target restrictions. Reconstruct the
                    // TargetingSetting object with the updated audience target restriction because
                    // Google will overwrite the entire targeting_setting field of the ad group when
                    // the field mask includes targeting_setting in an update operation.
                    // [START update_audience_target_restriction_1]
                    foreach (TargetRestriction targetRestriction in targetRestrictions)
                    {
                        TargetingDimension targetingDimension =
                            targetRestriction.TargetingDimension;
                        bool bidOnly = targetRestriction.BidOnly;

                        Console.WriteLine("\tTargeting restriction with targeting dimension " +
                            $"'{targetingDimension}' and bid only set to '{bidOnly}'.");

                        // Add the target restriction to the TargetingSetting object as is if the
                        // targeting dimension has a value other than AUDIENCE because those should
                        // not change.
                        if (targetingDimension != TargetingDimension.Audience)
                        {
                            targetingSetting.TargetRestrictions.Add(targetRestriction);
                        }
                        else if (!bidOnly)
                        {
                            shouldUpdateTargetingSetting = true;

                            // Add an AUDIENCE target restriction with bid_only set to true to the
                            // targeting setting object. This has the effect of setting the AUDIENCE
                            // target restriction to "Observation". For more details about the
                            // targeting setting, visit
                            // https://support.google.com/google-ads/answer/7365594.
                            targetingSetting.TargetRestrictions.Add(new TargetRestriction
                            {
                                TargetingDimension = TargetingDimension.Audience,
                                BidOnly = true
                            });
                        }
                    }
                    // [END update_audience_target_restriction_1]
                }

                // Only update the TargetSetting on the ad group if there is an AUDIENCE
                // TargetRestriction with bid_only set to false.
                if (shouldUpdateTargetingSetting)
                {
                    UpdateTargetingSetting(client, customerId, adGroupId, targetingSetting);
                }
                else
                {
                    Console.WriteLine("No target restrictions to update.");
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
        /// Updates the given TargetingSetting of an ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID.</param>
        /// <param name="adGroupId">The ad group ID for which to update the audience targeting
        ///     restriction.</param>
        /// <param name="targetingSetting">The updated targeting setting.</param>
        // [START update_audience_target_restriction_2]
        private void UpdateTargetingSetting(GoogleAdsClient client, long customerId, long
            adGroupId, TargetingSetting targetingSetting)
        {
            // Get the AdGroupService client.
            AdGroupServiceClient adGroupServiceClient =
                client.GetService(Services.V7.AdGroupService);

            // Create an ad group object with the updated targeting setting.
            AdGroup adGroup = new AdGroup
            {
                ResourceName = ResourceNames.AdGroup(customerId, adGroupId),
                TargetingSetting = targetingSetting
            };

            // Construct an operation that will update the ad group, using the FieldMasks utility
            // to derive the update mask. This mask tells the Google Ads API which attributes of the
            // ad group you want to change.
            AdGroupOperation operation = new AdGroupOperation
            {
                Update = adGroup,
                UpdateMask = FieldMasks.AllSetFieldsOf(adGroup)
            };

            // Send the operation in a mutate request.
            MutateAdGroupsResponse response =
                adGroupServiceClient.MutateAdGroups(customerId.ToString(), new[] { operation });
            // Print the resource name of the updated object.
            Console.WriteLine("Updated targeting setting of ad group with resource name " +
                $"'{response.Results.First().ResourceName}'; set the AUDIENCE target restriction " +
                "to 'Observation'.");
        }
        // [END update_audience_target_restriction_2]
    }
}

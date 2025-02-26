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
using Google.Ads.Gax.Util;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V19.Errors;
using Google.Ads.GoogleAds.V19.Resources;
using Google.Ads.GoogleAds.V19.Services;
using Google.Protobuf;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V19.Enums.ChangeEventResourceTypeEnum.Types;
using static Google.Ads.GoogleAds.V19.Enums.ResourceChangeOperationEnum.Types;
using static Google.Ads.GoogleAds.V19.Resources.ChangeEvent.Types;

namespace Google.Ads.GoogleAds.Examples.V19
{
    /// <summary>
    /// This code example gets the changes in an account during the last 25 days.
    /// </summary>
    public class GetChangeDetails : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetChangeDetails"/> example.
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
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            GetChangeDetails codeExample = new GetChangeDetails();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description => "This code example gets the changes in an account " +
            "during the last 25 days.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        // [START get_change_details]
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V19.GoogleAdsService);

            // Construct a query to find details for recent changes in your account.
            // The LIMIT clause is required for the change_event resource.
            // The maximum size is 10000, but a low limit was set here for demonstrative
            // purposes.
            // The WHERE clause on change_date_time is also required. It must specify a
            // window of at most 30 days within the past 30 days.

            string startDate = DateTime.Today.Subtract(TimeSpan.FromDays(25)).ToString("yyyyMMdd");
            string endDate = DateTime.Today.Add(TimeSpan.FromDays(1)).ToString("yyyyMMdd");
            string searchQuery = $@"
                SELECT
                    change_event.resource_name,
                    change_event.change_date_time,
                    change_event.change_resource_name,
                    change_event.user_email,
                    change_event.client_type,
                    change_event.change_resource_type,
                    change_event.old_resource,
                    change_event.new_resource,
                    change_event.resource_change_operation,
                    change_event.changed_fields
                FROM
                    change_event
                WHERE
                    change_event.change_date_time >= '{startDate}' AND
                    change_event.change_date_time <= '{endDate}'
                ORDER BY
                    change_event.change_date_time DESC
                LIMIT 5";

            try
            {
                // Issue a search request.
                googleAdsService.SearchStream(customerId.ToString(), searchQuery,
                    delegate (SearchGoogleAdsStreamResponse resp)
                    {
                        // Display the results.
                        foreach (GoogleAdsRow googleAdsRow in resp.Results)
                        {
                            ChangeEvent changeEvent = googleAdsRow.ChangeEvent;
                            ChangedResource oldResource = changeEvent.OldResource;
                            ChangedResource newResource = changeEvent.NewResource;

                            bool knownResourceType = true;
                            IMessage oldResourceEntity = null;
                            IMessage newResourceEntity = null;
                            switch (changeEvent.ChangeResourceType)
                            {
                                case ChangeEventResourceType.Ad:
                                    oldResourceEntity = oldResource.Ad;
                                    newResourceEntity = newResource.Ad;
                                    break;

                                case ChangeEventResourceType.AdGroup:
                                    oldResourceEntity = oldResource.AdGroup;
                                    newResourceEntity = newResource.AdGroup;
                                    break;

                                case ChangeEventResourceType.AdGroupAd:
                                    oldResourceEntity = oldResource.AdGroupAd;
                                    newResourceEntity = newResource.AdGroupAd;
                                    break;

                                case ChangeEventResourceType.AdGroupAsset:
                                    oldResourceEntity = oldResource.AdGroupAsset;
                                    newResourceEntity = newResource.AdGroupAsset;
                                    break;

                                case ChangeEventResourceType.AdGroupBidModifier:
                                    oldResourceEntity = oldResource.AdGroupBidModifier;
                                    newResourceEntity = newResource.AdGroupBidModifier;
                                    break;

                                case ChangeEventResourceType.AdGroupCriterion:
                                    oldResourceEntity = oldResource.AdGroupCriterion;
                                    newResourceEntity = newResource.AdGroupCriterion;
                                    break;

                                case ChangeEventResourceType.Asset:
                                    oldResourceEntity = oldResource.Asset;
                                    newResourceEntity = newResource.Asset;
                                    break;

                                case ChangeEventResourceType.AssetSet:
                                    oldResourceEntity = oldResource.AssetSet;
                                    newResourceEntity = newResource.AssetSet;
                                    break;

                                case ChangeEventResourceType.AssetSetAsset:
                                    oldResourceEntity = oldResource.AssetSetAsset;
                                    newResourceEntity = newResource.AssetSetAsset;
                                    break;

                                case ChangeEventResourceType.Campaign:
                                    oldResourceEntity = oldResource.Campaign;
                                    newResourceEntity = newResource.Campaign;
                                    break;

                                case ChangeEventResourceType.CampaignAsset:
                                    oldResourceEntity = oldResource.CampaignAsset;
                                    newResourceEntity = newResource.CampaignAsset;
                                    break;

                                case ChangeEventResourceType.CampaignAssetSet:
                                    oldResourceEntity = oldResource.CampaignAssetSet;
                                    newResourceEntity = newResource.CampaignAssetSet;
                                    break;

                                case ChangeEventResourceType.CampaignBudget:
                                    oldResourceEntity = oldResource.CampaignBudget;
                                    newResourceEntity = newResource.CampaignBudget;
                                    break;

                                case ChangeEventResourceType.CampaignCriterion:
                                    oldResourceEntity = oldResource.CampaignCriterion;
                                    newResourceEntity = newResource.CampaignCriterion;
                                    break;

                                case ChangeEventResourceType.CustomerAsset:
                                    oldResourceEntity = oldResource.CustomerAsset;
                                    newResourceEntity = newResource.CustomerAsset;
                                    break;

                                default:
                                    knownResourceType = false;
                                    break;
                            }

                            if (!knownResourceType)
                            {
                                Console.WriteLine($"Unknown change_resource_type " +
                                    $"'{changeEvent.ChangeResourceType}'.");
                                continue;
                            }

                            Console.WriteLine($"On #{changeEvent.ChangeDateTime}, user " +
                                $"{changeEvent.UserEmail} used interface {changeEvent.ClientType} " +
                                $"to perform a(n) '{changeEvent.ResourceChangeOperation}' " +
                                $"operation on a '{changeEvent.ChangeResourceType}' with " +
                                $"resource name {changeEvent.ChangeResourceName}.");

                            foreach (string fieldMaskPath in changeEvent.ChangedFields.Paths)
                            {
                                if (changeEvent.ResourceChangeOperation ==
                                    ResourceChangeOperation.Create)
                                {
                                    object newValue = FieldMasks.GetFieldValue(
                                        fieldMaskPath, newResourceEntity);
                                    Console.WriteLine($"\t{fieldMaskPath} set to '{newValue}'.");
                                }
                                else if (changeEvent.ResourceChangeOperation ==
                                    ResourceChangeOperation.Update)
                                {
                                    object oldValue = FieldMasks.GetFieldValue(fieldMaskPath,
                                        oldResourceEntity);
                                    object newValue = FieldMasks.GetFieldValue(fieldMaskPath,
                                        newResourceEntity);

                                    Console.WriteLine($"\t{fieldMaskPath} changed from " +
                                        $"'{oldValue}' to '{newValue}'.");
                                }
                            }
                        }
                    });
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
        // [END get_change_details]
    }
}

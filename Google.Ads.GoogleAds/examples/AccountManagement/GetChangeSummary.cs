// Copyright 2019 Google LLC
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
using Google.Ads.GoogleAds.V10.Errors;
using Google.Ads.GoogleAds.V10.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V10.Enums.ChangeStatusResourceTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V10
{
    /// <summary>
    /// This code example gets a list of which resources have been changed in your account
    /// in the last 14 days.
    /// </summary>
    public class GetChangeSummary : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="GetChangeSummary"/> example.
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

            GetChangeSummary codeExample = new GetChangeSummary();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(),
                options.CustomerId);
        }

        /// <summary>
        /// The page size to be used by default.
        /// </summary>
        private const int PAGE_SIZE = 1_000;

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This example gets a list of which resources have been changed in your account.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        // [START get_change_summary]
        public void Run(GoogleAdsClient client, long customerId)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V10.GoogleAdsService);

            string searchQuery = @"
                SELECT
                    change_status.resource_name,
                    change_status.last_change_date_time,
                    change_status.resource_type,
                    change_status.campaign,
                    change_status.ad_group,
                    change_status.resource_status,
                    change_status.ad_group_ad,
                    change_status.ad_group_criterion,
                    change_status.campaign_criterion
                FROM change_status
                WHERE
                    change_status.last_change_date_time DURING LAST_14_DAYS
                ORDER BY change_status.last_change_date_time
                LIMIT 10000";

            // Create a request that will retrieve all changes using pages of the specified
            // page size.
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                PageSize = PAGE_SIZE,
                Query = searchQuery,
                CustomerId = customerId.ToString()
            };

            try
            {
                // Issue the search request.
                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> searchPagedResponse =
                    googleAdsService.Search(request);

                // Iterate over all rows in all pages and prints the requested field values for the
                // campaign in each row.
                foreach (GoogleAdsRow googleAdsRow in searchPagedResponse)
                {
                    Console.WriteLine("Last change: {0}, Resource type: {1}, " +
                        "Resource name: {2}, Resource status: {3}, Specific resource name: {4}",
                        googleAdsRow.ChangeStatus.LastChangeDateTime,
                        googleAdsRow.ChangeStatus.ResourceType,
                        googleAdsRow.ChangeStatus.ResourceName,
                        googleAdsRow.ChangeStatus.ResourceStatus,
                        SpecificResourceName(googleAdsRow.ChangeStatus.ResourceType,
                            googleAdsRow));
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
        /// Return the name of the most specific resource that changed.
        /// </summary>
        /// <param name="resourceType">Type of the resource.</param>
        /// <param name="row">Each returned row contains all possible changed fields</param>
        /// <returns>The resource name of the changed field based on the resource type.
        /// The changed field's parent is also populated, but is not used.</returns>
        private string SpecificResourceName(ChangeStatusResourceType resourceType, GoogleAdsRow row)
        {
            string resourceName;
            switch (resourceType)
            {
                case ChangeStatusResourceType.AdGroup:
                    resourceName = row.ChangeStatus.AdGroup;
                    break;

                case ChangeStatusResourceType.AdGroupAd:
                    resourceName = row.ChangeStatus.AdGroupAd;
                    break;

                case ChangeStatusResourceType.AdGroupCriterion:
                    resourceName = row.ChangeStatus.AdGroupCriterion;
                    break;

                case ChangeStatusResourceType.Campaign:
                    resourceName = row.ChangeStatus.Campaign;
                    break;

                case ChangeStatusResourceType.CampaignCriterion:
                    resourceName = row.ChangeStatus.CampaignCriterion;
                    break;

                case ChangeStatusResourceType.Unknown:
                case ChangeStatusResourceType.Unspecified:
                default:
                    resourceName = "";
                    break;
            }
            return resourceName;
        }
        // [END get_change_summary]
    }
}

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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V2.Errors;
using Google.Ads.GoogleAds.V2.Resources;
using Google.Ads.GoogleAds.V2.Services;
using Google.Api.Gax;
using System;
using System.Collections.Generic;
using static Google.Ads.GoogleAds.V2.Enums.CriterionTypeEnum.Types;

namespace Google.Ads.GoogleAds.Examples.V2
{
    /// <summary>
    /// This code example demonstrates how to find shared sets, shared set criteria, and
    /// how to remove them.
    /// </summary>
    public class FindAndRemoveCriteriaFromSharedSet : ExampleBase
    {
        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            FindAndRemoveCriteriaFromSharedSet codeExample =
                new FindAndRemoveCriteriaFromSharedSet();
            Console.WriteLine(codeExample.Description);

            // The Google Ads customer ID for which the call is made.
            long customerId = long.Parse("INSERT_CUSTOMER_ID_HERE");

            // The ID of the campaign for which shared criterion is updated.
            long campaignId = long.Parse("INSERT_CAMPAIGN_ID_HERE");

            codeExample.Run(new GoogleAdsClient(), customerId, campaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return "This code example demonstrates how to find shared sets, shared set " +
                    "criteria, and how to remove them.";
            }
        }

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="campaignId">The ID of the campaign for which shared criterion is updated.
        /// </param>
        public void Run(GoogleAdsClient client, long customerId, long campaignId)
        {
            try
            {
                SharedCriterionServiceClient sharedCriterionService = client.GetService(
                    Services.V2.SharedCriterionService);

                GoogleAdsServiceClient googleAdsService = client.GetService(
                    Services.V2.GoogleAdsService);

                List<long?> sharedSetIds = new List<long?>();
                List<string> criterionResources = new List<string>();

                // First, retrieve all shared sets associated with the campaign.
                string sharedSetQuery = $"SELECT shared_set.id, shared_set.name FROM " +
                    $"campaign_shared_set WHERE campaign.id = {campaignId}";

                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> sharedSetResponse =
                    googleAdsService.Search(customerId.ToString(), sharedSetQuery);

                // Display the results.
                foreach (GoogleAdsRow googleAdsRow in sharedSetResponse)
                {
                    SharedSet sharedSet = googleAdsRow.SharedSet;
                    Console.WriteLine("Campaign shared set ID {0} and name '{1}' was found.",
                        sharedSet.Id, sharedSet.Name);

                    sharedSetIds.Add(sharedSet.Id);
                }

                // Next, retrieve shared criteria for all found shared sets.
                string sharedCriterionQuery =
                    "SELECT shared_criterion.type, shared_criterion.keyword.text, " +
                    "shared_criterion.keyword.match_type, shared_set.id FROM shared_criterion " +
                    $"WHERE shared_set.id IN(" +
                    string.Join(",", sharedSetIds.ConvertAll(x => x.ToString())) + ")";

                PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> sharedCriterionResponse =
                    googleAdsService.Search(customerId.ToString(), sharedCriterionQuery);

                // Display the results.
                foreach (GoogleAdsRow googleAdsRow in sharedCriterionResponse)
                {
                    SharedCriterion sharedCriterion = googleAdsRow.SharedCriterion;
                    if (sharedCriterion.Type == CriterionType.Keyword)
                    {
                        Console.WriteLine("Shared criterion with resource name '{0}' for " +
                            "negative keyword with text '{1}' and match type '{2}' was found.",
                            sharedCriterion.ResourceName,
                            sharedCriterion.Keyword.Text,
                            sharedCriterion.Keyword.MatchType);
                    }
                    else
                    {
                        Console.WriteLine("Shared criterion with resource name '{0}' was found.",
                            sharedCriterion.ResourceName);
                    }
                    criterionResources.Add(sharedCriterion.ResourceName);
                }

                // Finally, remove the criteria.
                List<SharedCriterionOperation> operations = new List<SharedCriterionOperation>();
                foreach (string criterionResource in criterionResources)
                {
                    SharedCriterionOperation operation = new SharedCriterionOperation()
                    {
                        Remove = criterionResource
                    };
                    operations.Add(operation);
                }

                MutateSharedCriteriaResponse response =
                    sharedCriterionService.MutateSharedCriteria(
                        customerId.ToString(), operations);

                foreach (MutateSharedCriterionResult result in response.Results)
                {
                    Console.WriteLine($"Removed shared criterion {result.ResourceName}.");
                }
            }
            catch (GoogleAdsException e)
            {
                Console.WriteLine("Failure:");
                Console.WriteLine($"Message: {e.Message}");
                Console.WriteLine($"Failure: {e.Failure}");
                Console.WriteLine($"Request ID: {e.RequestId}");
            }
        }
    }
}

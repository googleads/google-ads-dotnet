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
using Google.Ads.GoogleAds.V12.Common;
using Google.Ads.GoogleAds.V12.Errors;
using Google.Ads.GoogleAds.V12.Resources;
using Google.Ads.GoogleAds.V12.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.Examples.V12
{
    /// <summary>
    /// This code example adds a campaign draft for a campaign. Make sure you specify a
    /// campaign that has a budget with explicitly_shared set to false.
    /// </summary>
    public class AddCampaignDraft : ExampleBase
    {
        /// <summary>
        /// Command line options for running the <see cref="AddCampaignDraft"/> example.
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
            /// ID of the base campaign.
            /// </summary>
            [Option("baseCampaignId", Required = true, HelpText =
                "ID of the base campaign.")]
            public long BaseCampaignId { get; set; }
        }

        /// <summary>
        /// Main method, to run this code example as a standalone application.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            Options options = ExampleUtilities.ParseCommandLine<Options>(args);

            AddCampaignDraft codeExample = new AddCampaignDraft();
            Console.WriteLine(codeExample.Description);
            codeExample.Run(new GoogleAdsClient(), options.CustomerId, options.BaseCampaignId);
        }

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description =>
            "This code example adds a campaign draft for a campaign. Make sure you specify a " +
            "campaign that has a budget with explicitly_shared set to false.";

        /// <summary>
        /// Runs the code example.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="baseCampaignId">ID of the base campaign</param>
        public void Run(GoogleAdsClient client, long customerId, long baseCampaignId)
        {
            try
            {
                string draftResourceName = CreateCampaignDraft(client, customerId, baseCampaignId);
                string draftCampaignResourceName = FetchDraftCampaign(client, customerId,
                    draftResourceName);
                AddLanguageCriteria(client, customerId, draftCampaignResourceName);
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
        /// Creates the campaign draft.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="baseCampaignId">The base campaign ID.</param>
        /// <returns></returns>
        private static string CreateCampaignDraft(GoogleAdsClient client, long customerId,
            long baseCampaignId)
        {
            // Get the CampaignDraftService.
            CampaignDraftServiceClient campaignDraftService =
                client.GetService(Services.V12.CampaignDraftService);

            CampaignDraft campaignDraft = new CampaignDraft()
            {
                BaseCampaign = ResourceNames.Campaign(customerId, baseCampaignId),
                Name = "Campaign Draft #" + ExampleUtilities.GetRandomString(),
            };

            CampaignDraftOperation operation = new CampaignDraftOperation()
            {
                Create = campaignDraft
            };

            MutateCampaignDraftsResponse response = campaignDraftService.MutateCampaignDrafts(
                customerId.ToString(), new CampaignDraftOperation[] { operation });

            string draftResourceName = response.Results[0].ResourceName;
            Console.WriteLine($"Campaign with resource ID = '{draftResourceName}' was added.");
            return draftResourceName;
        }

        /// <summary>
        /// Fetches the draft campaign associated with a campaign draft.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// <param name="draftResourceName">Resource name of the draft.</param>
        /// <returns></returns>
        private static string FetchDraftCampaign(GoogleAdsClient client, long customerId,
            string draftResourceName)
        {
            // Get the GoogleAdsService.
            GoogleAdsServiceClient googleAdsService =
                client.GetService(Services.V12.GoogleAdsService);

            // Once the draft is created, you can modify the draft campaign as if it were
            // a real campaign. For example, you may add criteria, adjust bids, or even
            // include additional ads. Adding a criterion is shown here.
            string query = $@"
                SELECT
                    campaign_draft.draft_campaign
                FROM
                    campaign_draft
                WHERE
                    campaign_draft.resource_name = '{draftResourceName}'";

            // Get the draft campaign resource name.
            string draftCampaignResourceName = googleAdsService.Search(
                customerId.ToString(), query).First().CampaignDraft.DraftCampaign;
            return draftCampaignResourceName;
        }

        /// <summary>
        /// Adds a language criterion to the draft campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="customerId">The Google Ads customer ID for which the call is made.</param>
        /// /// <param name="draftCampaignResourceName">Resource name of the draft campaign.</param>
        private static void AddLanguageCriteria(GoogleAdsClient client, long customerId,
            string draftCampaignResourceName)
        {
            // Get the CampaignCriterionService.
            CampaignCriterionServiceClient campaignCriterionService =
                client.GetService(Services.V12.CampaignCriterionService);

            // Add a language criterion.
            CampaignCriterionOperation criterionOperation = new CampaignCriterionOperation()
            {
                Create = new CampaignCriterion()
                {
                    Language = new LanguageInfo()
                    {
                        // Spanish
                        LanguageConstant = ResourceNames.LanguageConstant(1003)
                    },
                    Campaign = draftCampaignResourceName
                }
            };

            MutateCampaignCriteriaResponse campaignCriteriaResponse =
                campaignCriterionService.MutateCampaignCriteria(
                    customerId.ToString(),
                    new CampaignCriterionOperation[] { criterionOperation });

            string newCampaignCriterionResource = campaignCriteriaResponse.Results[0].ResourceName;
            Console.WriteLine($"Campaign Criterion with resource ID = " +
                $"'{newCampaignCriterionResource}' was added to campaign with resource ID = " +
                $"'{draftCampaignResourceName}'.");
        }
    }
}

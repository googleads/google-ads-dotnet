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

using Google.Ads.GoogleAds.Examples;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Tests.V3;
using Google.Ads.GoogleAds.V3.Common;
using Google.Ads.GoogleAds.V3.Enums;
using Google.Ads.GoogleAds.V3.Resources;
using Google.Ads.GoogleAds.V3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using static Google.Ads.GoogleAds.V3.Enums.AdGroupAdStatusEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.AdGroupCriterionStatusEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.AdvertisingChannelTypeEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.BudgetDeliveryMethodEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.CampaignStatusEnum.Types;
using static Google.Ads.GoogleAds.V3.Enums.KeywordMatchTypeEnum.Types;
using static Google.Ads.GoogleAds.V3.Resources.Campaign.Types;

namespace Google.Ads.GoogleAds.Tests.Examples.V3
{
    internal class ExampleTestsUtils : TestUtils
    {
        /// <summary>
        /// Creates the budget for the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <returns>The resource name of the newly created campaign budget.</returns>
        internal static string CreateBudget(GoogleAdsClient client)
        {
            CampaignBudget budget = new CampaignBudget()
            {
                Name = "Interplanetary Cruise Budget #" + ExampleUtilities.GetRandomString(),
                DeliveryMethod = BudgetDeliveryMethod.Standard,
                AmountMicros = 500000
            };

            MutateOperation mutateOperation = new MutateOperation()
            {
                CampaignBudgetOperation = new CampaignBudgetOperation()
                {
                    Create = budget,
                },
            };

            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .CampaignBudgetResult.ResourceName;
        }

        /// <summary>
        /// Creates the campaign.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="budgetResourceName">The resource name for the budget.</param>
        /// <returns>The resource name of the newly created campaign.</returns>
        internal static string CreateCampaign(GoogleAdsClient client, string budgetResourceName)
        {
            Campaign campaign = new Campaign()
            {
                Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),
                AdvertisingChannelType = AdvertisingChannelType.Search,
                Status = CampaignStatus.Paused,
                ManualCpc = new ManualCpc(),
                CampaignBudget = budgetResourceName,
                NetworkSettings = new NetworkSettings
                {
                    TargetGoogleSearch = true,
                    TargetSearchNetwork = true,
                    TargetContentNetwork = false,
                    TargetPartnerSearchNetwork = false
                },
                StartDate = DateTime.Now.AddDays(1).ToString("yyyyMMdd"),
                EndDate = DateTime.Now.AddYears(1).ToString("yyyyMMdd"),
            };

            MutateOperation mutateOperation = new MutateOperation()
            {
                CampaignOperation = new CampaignOperation() { Create = campaign }
            };
            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .CampaignResult.ResourceName;
        }

        /// <summary>
        ///  Creates a new standard shopping campaign in the specified client account.
        /// </summary>
        /// <param name="client">The Google Ads API client.</param>
        /// <param name="budgetResourceName">The resource name of the budget for the campaign.
        /// </param>
        /// <param name="merchantCenterAccountId">The Merchant Center account ID.</param>
        /// <returns>Resource name of the newly created campaign.</returns>
        internal static string CreateStandardShoppingCampaign(GoogleAdsClient client,
            string budgetResourceName, long merchantCenterAccountId)
        {
            Campaign campaign = new Campaign()
            {
                Name = "Interplanetary Cruise #" + ExampleUtilities.GetRandomString(),
                AdvertisingChannelType = AdvertisingChannelType.Shopping,
                ShoppingSetting = new ShoppingSetting()
                {
                    SalesCountry = "US",
                    CampaignPriority = 0,
                    MerchantId = merchantCenterAccountId,
                    EnableLocal = true
                },

                Status = CampaignStatus.Paused,
                ManualCpc = new ManualCpc()
                {
                    EnhancedCpcEnabled = true
                },
                CampaignBudget = budgetResourceName
            };

            MutateOperation mutateOperation = new MutateOperation()
            {
                CampaignOperation = new CampaignOperation() { Create = campaign }
            };
            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .CampaignResult.ResourceName;
        }

        /// <summary>
        /// Creates the ad group.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="campaignResourceName">Resource name of the campaign in which ad group
        /// is created.</param>
        /// <returns>The resource name of the newly created ad group.</returns>
        internal static string CreateAdGroup(GoogleAdsClient client, string campaignResourceName)
        {
            AdGroup adGroup = new AdGroup()
            {
                Name = $"Earth to Mars Cruises #{ExampleUtilities.GetRandomString()}",
                Status = AdGroupStatusEnum.Types.AdGroupStatus.Enabled,
                Campaign = campaignResourceName,
                CpcBidMicros = 10000000
            };

            MutateOperation mutateOperation = new MutateOperation()
            {
                AdGroupOperation = new AdGroupOperation() { Create = adGroup }
            };
            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .AdGroupResult.ResourceName;
        }

        /// <summary>
        /// Creates the expanded text ad.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupResourceName">Resource name of the ad group in which expanded
        /// text ad is created.</param>
        /// <returns>The resource name of the newly created expanded text ad.</returns>
        internal static string CreateExpandedTextAd(GoogleAdsClient client,
            string adGroupResourceName)
        {
            AdGroupAd adGroupAd = new AdGroupAd
            {
                AdGroup = adGroupResourceName,
                Status = AdGroupAdStatus.Paused,
                Ad = new Ad
                {
                    FinalUrls = { "http://www.example.com/" },
                    ExpandedTextAd = new ExpandedTextAdInfo
                    {
                        Description = "Buy your tickets now!",
                        HeadlinePart1 = $"Cruise #{DateTime.Now.Ticks % 1000} to Mars",
                        HeadlinePart2 = "Best Space Cruise Line",
                        Path1 = "path1",
                        Path2 = "path2"
                    }
                }
            };

            MutateOperation mutateOperation = new MutateOperation()
            {
                AdGroupAdOperation = new AdGroupAdOperation() { Create = adGroupAd }
            };
            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .AdGroupAdResult.ResourceName;
        }

        /// <summary>
        /// Creates a keyword.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group to which keyword
        /// is added.</param>
        /// <returns>The resource name of the newly created keyword.</returns>
        internal static string CreateKeyword(GoogleAdsClient client, string adGroupResourceName)
        {
            AdGroupCriterion criterion = new AdGroupCriterion()
            {
                AdGroup = adGroupResourceName,
                Status = AdGroupCriterionStatus.Enabled,
                Keyword = new KeywordInfo()
                {
                    Text = $"mars cruise #{DateTime.Now.Ticks}",
                    MatchType = KeywordMatchType.Exact
                }
            };
            MutateOperation mutateOperation = new MutateOperation()
            {
                AdGroupCriterionOperation = new AdGroupCriterionOperation() { Create = criterion }
            };
            return ExecuteOperations(client, new[] { mutateOperation }).First()
                .AdGroupCriterionResult.ResourceName;
        }

        /// <summary>
        /// Retrieves a campaign's ID.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="campaignResourceName">The resource name of the campaign.</param>
        /// <returns>The campaign ID.</returns>
        internal static long GetCampaign(GoogleAdsClient client, string campaignResourceName)
        {
            string query = $"SELECT campaign.id FROM campaign WHERE " +
                $"campaign.resource_name='{campaignResourceName}' ORDER BY campaign.id";
            return GetGoogleAdsRows(client, query).First().Campaign.Id.Value;
        }

        /// <summary>
        /// Retrieves an ad group's ID.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupResourceName">The resource name of the ad group.</param>
        /// <returns>The ad group ID.</returns>
        internal static long GetAdGroup(GoogleAdsClient client, string adGroupResourceName)
        {
            string query = $"SELECT ad_group.id FROM ad_group WHERE " +
                $"ad_group.resource_name='{adGroupResourceName}' ORDER BY ad_group.id";
            return GetGoogleAdsRows(client, query).First().AdGroup.Id.Value;
        }

        /// <summary>
        /// Retrieves an adgroup ad's ID
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupAdResourceName">The resource name of the ad group ad.</param>
        /// <returns>The ad group ID.</returns>
        internal static long GetAdGroupAd(GoogleAdsClient client, string adGroupAdResourceName)
        {
            string query = $"SELECT ad_group_ad.ad.id FROM ad_group_ad WHERE " +
                $"ad_group_ad.resource_name='{adGroupAdResourceName}'";
            return GetGoogleAdsRows(client, query).First().AdGroupAd.Ad.Id.Value;
        }

        /// <summary>
        /// Retrieves an adgroup ad's ID
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="adGroupAdResourceName">The resource name of the ad group.</param>
        /// <returns>The keyword ID.</returns>
        internal static long GetKeyword(GoogleAdsClient client, string adGroupCriterionResourceName)
        {
            string query = $"SELECT ad_group_criterion.criterion_id FROM ad_group_criterion" +
                $" WHERE ad_group_criterion.resource_name = '{adGroupCriterionResourceName}'";
            return GetGoogleAdsRows(client, query).First().AdGroupCriterion.CriterionId.Value;
        }

        /// <summary>
        /// Execute a list of operations and return results.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="operations">The list of operations.</param>
        /// <returns>The list of mutate responses from executing the operations.</returns>
        internal static IEnumerable<MutateOperationResponse> ExecuteOperations(
            GoogleAdsClient client, MutateOperation[] operations)
        {
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V3.GoogleAdsService);

            MutateGoogleAdsRequest request = new MutateGoogleAdsRequest()
            {
                CustomerId = client.Config.ClientCustomerId.ToString(),
            };
            request.MutateOperations.AddRange(operations);

            return googleAdsService.Mutate(request).MutateOperationResponses;
        }

        /// <summary>
        /// Gets a list of google ads rows.
        /// </summary>
        /// <param name="client">The Google Ads client.</param>
        /// <param name="query">The query to execute.</param>
        /// <returns>The list of google ads rows.</returns>
        internal static IEnumerable<GoogleAdsRow> GetGoogleAdsRows(GoogleAdsClient client,
            string query)
        {
            GoogleAdsServiceClient googleAdsService = client.GetService(
                Services.V3.GoogleAdsService);

            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest()
            {
                Query = query,
                CustomerId = client.Config.ClientCustomerId.ToString()
            };

            return googleAdsService.Search(request);
        }
    }
}

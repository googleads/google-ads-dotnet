// Copyright 2018 Google LLC
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

namespace Google.Ads.GoogleAds.Lib {

  /// <summary>
  /// Helper class to generate resource names for various entities.
  /// </summary>
  public class ResourceNames {

    /// <summary>
    /// Generate resource name for an ad group.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="adGroupId">The ad group ID.</param>
    /// <returns>The ad group resource name.</returns>
    public static string AdGroup(long customerId, long adGroupId) {
      return $"customers/{customerId}/adGroups/{adGroupId}";
    }

    /// <summary>
    /// Generate resource name for an ad group ad.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="adGroupId">The ad group ID.</param>
    /// <param name="adId">The ad ID.</param>
    /// <returns>The ad group ad resource name.</returns>
    public static string AdGroupAd(long customerId, long adGroupId, long adId) {
      return $"customers/{customerId}/adGroupAds/{adGroupId}_{adId}";
    }

    /// <summary>
    /// Generate resource name for an ad group criterion.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="adGroupId">The ad group ID.</param>
    /// <param name="criterionId">The criterion ID.</param>
    /// <returns>The ad group criterion resource name.</returns>
    public static string AdGroupCriterion(long customerId, long adGroupId, long criterionId) {
      return $"customers/{customerId}/adGroupCriteria/{adGroupId}_{criterionId}";
    }

    /// <summary>
    /// Generate resource name for a bidding strategy.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="biddingStrategyId">The bidding strategy ID.</param>
    /// <returns>The bidding strategy resource name.</returns>
    public static string BiddingStrategy(long customerId, long biddingStrategyId) {
      return $"customers/{customerId}/biddingStrategies/{biddingStrategyId}";
    }

    /// <summary>
    /// Generate resource name for a budget.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="budgetId">The budget ID.</param>
    /// <returns>The budget resource name.</returns>
    public static string Budget(long customerId, long budgetId) {
      return $"customers/{customerId}/budgets/{budgetId}";
    }

    /// <summary>
    /// Generate resource name for a campaign.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="campaignId">The campaign ID.</param>
    /// <returns>The campaign resource name.</returns>
    public static string Campaign(long customerId, long campaignId) {
      return $"customers/{customerId}/campaigns/{campaignId}";
    }

    /// <summary>
    /// Generate resource name for a campaign criterion.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="campaignId">The campaign ID.</param>
    /// <param name="criterionId">The criterion ID.</param>
    /// <returns>The campaign criterion resource name.</returns>
    public static string CampaignCriterion(long customerId, long campaignId, long criterionId) {
      return $"customers/{customerId}/campaignCriteria/{campaignId}_{criterionId}";
    }

    /// <summary>
    /// Generate resource name for a customer.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <returns>The customer resource name.</returns>
    public static string Customer(long customerId) {
      return $"customers/{customerId}";
    }

    /// <summary>
    /// Generate resource name for a Google Ads field.
    /// </summary>
    /// <param name="fieldName">Name of the field.</param>
    /// <returns>The field resource name.</returns>
    public static string GoogleAdsField(long fieldName) {
      return $"googleAdsFields/{fieldName}";
    }

    /// <summary>
    /// Generate resource name for a keyword view.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="adGroupId">The ad group ID.</param>
    /// <param name="criterionId">The criterion ID.</param>
    /// <returns>The keyword view resource name.</returns>
    public static string KeywordView(long customerId, long adGroupId, long criterionId) {
      return $"customers/{customerId}/keywordViews/{adGroupId}_{criterionId}";
    }

    /// <summary>
    /// Generate resource name for an ad group bid modifier.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="adGroupId">The ad group ID.</param>
    /// <param name="criterionId">The criterion ID.</param>
    /// <returns>The ad group bid modifier resource name.</returns>
    public static string AdGroupBidModifier(long customerId, long adGroupId, long criterionId) {
      return $"customers/{customerId}/adGroupBidModifiers/{adGroupId}_{criterionId}";
    }

    /// <summary>
    /// Generate resource name for a recommendation.
    /// </summary>
    /// <param name="customerId">The customer ID.</param>
    /// <param name="recommendationId">The recommendation ID.</param>
    /// <returns>The recommendation resource name.</returns>
    public static string Recommendation(long customerId, long recommendationId) {
      return $"customers/{customerId}/recommendations/{recommendationId}";
    }

    /// <summary>
    /// Generate resource name for a geo target constant.
    /// </summary>
    /// <param name="geoTargetConstantId">The geo target constant ID.</param>
    /// <returns>The geo target constant resource name.</returns>
    public static string GeoTargetConstant(long geoTargetConstantId) {
      return $"geoTargetConstants/{geoTargetConstantId}";
    }
  }
}

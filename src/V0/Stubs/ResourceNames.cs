// Copyright 2018 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gax = Google.Api.Gax;
using sys = System;
using linq = System.Linq;

namespace Google.Ads.GoogleAds.V0.Services
{
    /// <summary>
    /// Resource name for the 'ad_group_ad' resource.
    /// </summary>
    public sealed partial class AdGroupAdName : gax::IResourceName, sys::IEquatable<AdGroupAdName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupAds/{ad_group_ad}");

        /// <summary>
        /// Parses the given ad_group_ad resource name in string form into a new
        /// <see cref="AdGroupAdName"/> instance.
        /// </summary>
        /// <param name="adGroupAdName">The ad_group_ad resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupAdName"/> if successful.</returns>
        public static AdGroupAdName Parse(string adGroupAdName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAdName, nameof(adGroupAdName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupAdName);
            return new AdGroupAdName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_ad resource name in string form into a new
        /// <see cref="AdGroupAdName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupAdName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupAdName">The ad_group_ad resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupAdName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdName, out AdGroupAdName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAdName, nameof(adGroupAdName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupAdName, out resourceName))
            {
                result = new AdGroupAdName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupAdName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupAdId">The adGroupAd ID. Must not be <c>null</c>.</param>
        public AdGroupAdName(string customerId, string adGroupAdId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupAdId = gax::GaxPreconditions.CheckNotNull(adGroupAdId, nameof(adGroupAdId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupAd ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupAdId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupAdId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupAdName);

        /// <inheritdoc />
        public bool Equals(AdGroupAdName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupAdName a, AdGroupAdName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupAdName a, AdGroupAdName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'ad_group_bid_modifier' resource.
    /// </summary>
    public sealed partial class AdGroupBidModifierName : gax::IResourceName, sys::IEquatable<AdGroupBidModifierName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}");

        /// <summary>
        /// Parses the given ad_group_bid_modifier resource name in string form into a new
        /// <see cref="AdGroupBidModifierName"/> instance.
        /// </summary>
        /// <param name="adGroupBidModifierName">The ad_group_bid_modifier resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupBidModifierName"/> if successful.</returns>
        public static AdGroupBidModifierName Parse(string adGroupBidModifierName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupBidModifierName, nameof(adGroupBidModifierName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupBidModifierName);
            return new AdGroupBidModifierName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_bid_modifier resource name in string form into a new
        /// <see cref="AdGroupBidModifierName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupBidModifierName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupBidModifierName">The ad_group_bid_modifier resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupBidModifierName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupBidModifierName, out AdGroupBidModifierName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupBidModifierName, nameof(adGroupBidModifierName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupBidModifierName, out resourceName))
            {
                result = new AdGroupBidModifierName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupBidModifierName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupBidModifierId">The adGroupBidModifier ID. Must not be <c>null</c>.</param>
        public AdGroupBidModifierName(string customerId, string adGroupBidModifierId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupBidModifierId = gax::GaxPreconditions.CheckNotNull(adGroupBidModifierId, nameof(adGroupBidModifierId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupBidModifier ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupBidModifierId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupBidModifierId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupBidModifierName);

        /// <inheritdoc />
        public bool Equals(AdGroupBidModifierName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupBidModifierName a, AdGroupBidModifierName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupBidModifierName a, AdGroupBidModifierName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'ad_group_criteria' resource.
    /// </summary>
    public sealed partial class AdGroupCriteriaName : gax::IResourceName, sys::IEquatable<AdGroupCriteriaName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupCriteria/{ad_group_criteria}");

        /// <summary>
        /// Parses the given ad_group_criteria resource name in string form into a new
        /// <see cref="AdGroupCriteriaName"/> instance.
        /// </summary>
        /// <param name="adGroupCriteriaName">The ad_group_criteria resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupCriteriaName"/> if successful.</returns>
        public static AdGroupCriteriaName Parse(string adGroupCriteriaName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupCriteriaName, nameof(adGroupCriteriaName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupCriteriaName);
            return new AdGroupCriteriaName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_criteria resource name in string form into a new
        /// <see cref="AdGroupCriteriaName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupCriteriaName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupCriteriaName">The ad_group_criteria resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupCriteriaName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupCriteriaName, out AdGroupCriteriaName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupCriteriaName, nameof(adGroupCriteriaName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupCriteriaName, out resourceName))
            {
                result = new AdGroupCriteriaName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupCriteriaName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupCriteriaId">The adGroupCriteria ID. Must not be <c>null</c>.</param>
        public AdGroupCriteriaName(string customerId, string adGroupCriteriaId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupCriteriaId = gax::GaxPreconditions.CheckNotNull(adGroupCriteriaId, nameof(adGroupCriteriaId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupCriteria ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupCriteriaId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupCriteriaId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupCriteriaName);

        /// <inheritdoc />
        public bool Equals(AdGroupCriteriaName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupCriteriaName a, AdGroupCriteriaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupCriteriaName a, AdGroupCriteriaName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'ad_group' resource.
    /// </summary>
    public sealed partial class AdGroupName : gax::IResourceName, sys::IEquatable<AdGroupName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroups/{ad_group}");

        /// <summary>
        /// Parses the given ad_group resource name in string form into a new
        /// <see cref="AdGroupName"/> instance.
        /// </summary>
        /// <param name="adGroupName">The ad_group resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupName"/> if successful.</returns>
        public static AdGroupName Parse(string adGroupName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupName, nameof(adGroupName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupName);
            return new AdGroupName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group resource name in string form into a new
        /// <see cref="AdGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupName">The ad_group resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupName, out AdGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupName, nameof(adGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupName, out resourceName))
            {
                result = new AdGroupName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupId">The adGroup ID. Must not be <c>null</c>.</param>
        public AdGroupName(string customerId, string adGroupId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupId = gax::GaxPreconditions.CheckNotNull(adGroupId, nameof(adGroupId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroup ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupName);

        /// <inheritdoc />
        public bool Equals(AdGroupName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupName a, AdGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupName a, AdGroupName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'bidding_strategy' resource.
    /// </summary>
    public sealed partial class BiddingStrategyName : gax::IResourceName, sys::IEquatable<BiddingStrategyName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/biddingStrategies/{bidding_strategy}");

        /// <summary>
        /// Parses the given bidding_strategy resource name in string form into a new
        /// <see cref="BiddingStrategyName"/> instance.
        /// </summary>
        /// <param name="biddingStrategyName">The bidding_strategy resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BiddingStrategyName"/> if successful.</returns>
        public static BiddingStrategyName Parse(string biddingStrategyName)
        {
            gax::GaxPreconditions.CheckNotNull(biddingStrategyName, nameof(biddingStrategyName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(biddingStrategyName);
            return new BiddingStrategyName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given bidding_strategy resource name in string form into a new
        /// <see cref="BiddingStrategyName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="biddingStrategyName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="biddingStrategyName">The bidding_strategy resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="BiddingStrategyName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string biddingStrategyName, out BiddingStrategyName result)
        {
            gax::GaxPreconditions.CheckNotNull(biddingStrategyName, nameof(biddingStrategyName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(biddingStrategyName, out resourceName))
            {
                result = new BiddingStrategyName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="BiddingStrategyName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="biddingStrategyId">The biddingStrategy ID. Must not be <c>null</c>.</param>
        public BiddingStrategyName(string customerId, string biddingStrategyId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            BiddingStrategyId = gax::GaxPreconditions.CheckNotNull(biddingStrategyId, nameof(biddingStrategyId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The biddingStrategy ID. Never <c>null</c>.
        /// </summary>
        public string BiddingStrategyId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, BiddingStrategyId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as BiddingStrategyName);

        /// <inheritdoc />
        public bool Equals(BiddingStrategyName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(BiddingStrategyName a, BiddingStrategyName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(BiddingStrategyName a, BiddingStrategyName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'campaign_bid_modifier' resource.
    /// </summary>
    public sealed partial class CampaignBidModifierName : gax::IResourceName, sys::IEquatable<CampaignBidModifierName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignBidModifiers/{campaign_bid_modifier}");

        /// <summary>
        /// Parses the given campaign_bid_modifier resource name in string form into a new
        /// <see cref="CampaignBidModifierName"/> instance.
        /// </summary>
        /// <param name="campaignBidModifierName">The campaign_bid_modifier resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignBidModifierName"/> if successful.</returns>
        public static CampaignBidModifierName Parse(string campaignBidModifierName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignBidModifierName, nameof(campaignBidModifierName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignBidModifierName);
            return new CampaignBidModifierName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_bid_modifier resource name in string form into a new
        /// <see cref="CampaignBidModifierName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignBidModifierName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignBidModifierName">The campaign_bid_modifier resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignBidModifierName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignBidModifierName, out CampaignBidModifierName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignBidModifierName, nameof(campaignBidModifierName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignBidModifierName, out resourceName))
            {
                result = new CampaignBidModifierName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignBidModifierName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignBidModifierId">The campaignBidModifier ID. Must not be <c>null</c>.</param>
        public CampaignBidModifierName(string customerId, string campaignBidModifierId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignBidModifierId = gax::GaxPreconditions.CheckNotNull(campaignBidModifierId, nameof(campaignBidModifierId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignBidModifier ID. Never <c>null</c>.
        /// </summary>
        public string CampaignBidModifierId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignBidModifierId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignBidModifierName);

        /// <inheritdoc />
        public bool Equals(CampaignBidModifierName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignBidModifierName a, CampaignBidModifierName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignBidModifierName a, CampaignBidModifierName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'campaign_budget' resource.
    /// </summary>
    public sealed partial class CampaignBudgetName : gax::IResourceName, sys::IEquatable<CampaignBudgetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignBudgets/{campaign_budget}");

        /// <summary>
        /// Parses the given campaign_budget resource name in string form into a new
        /// <see cref="CampaignBudgetName"/> instance.
        /// </summary>
        /// <param name="campaignBudgetName">The campaign_budget resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignBudgetName"/> if successful.</returns>
        public static CampaignBudgetName Parse(string campaignBudgetName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignBudgetName, nameof(campaignBudgetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignBudgetName);
            return new CampaignBudgetName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_budget resource name in string form into a new
        /// <see cref="CampaignBudgetName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignBudgetName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignBudgetName">The campaign_budget resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignBudgetName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignBudgetName, out CampaignBudgetName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignBudgetName, nameof(campaignBudgetName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignBudgetName, out resourceName))
            {
                result = new CampaignBudgetName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignBudgetName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignBudgetId">The campaignBudget ID. Must not be <c>null</c>.</param>
        public CampaignBudgetName(string customerId, string campaignBudgetId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignBudgetId = gax::GaxPreconditions.CheckNotNull(campaignBudgetId, nameof(campaignBudgetId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignBudget ID. Never <c>null</c>.
        /// </summary>
        public string CampaignBudgetId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignBudgetId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignBudgetName);

        /// <inheritdoc />
        public bool Equals(CampaignBudgetName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignBudgetName a, CampaignBudgetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignBudgetName a, CampaignBudgetName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'campaign_criteria' resource.
    /// </summary>
    public sealed partial class CampaignCriteriaName : gax::IResourceName, sys::IEquatable<CampaignCriteriaName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignCriteria/{campaign_criteria}");

        /// <summary>
        /// Parses the given campaign_criteria resource name in string form into a new
        /// <see cref="CampaignCriteriaName"/> instance.
        /// </summary>
        /// <param name="campaignCriteriaName">The campaign_criteria resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignCriteriaName"/> if successful.</returns>
        public static CampaignCriteriaName Parse(string campaignCriteriaName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignCriteriaName, nameof(campaignCriteriaName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignCriteriaName);
            return new CampaignCriteriaName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_criteria resource name in string form into a new
        /// <see cref="CampaignCriteriaName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignCriteriaName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignCriteriaName">The campaign_criteria resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignCriteriaName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignCriteriaName, out CampaignCriteriaName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignCriteriaName, nameof(campaignCriteriaName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignCriteriaName, out resourceName))
            {
                result = new CampaignCriteriaName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignCriteriaName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignCriteriaId">The campaignCriteria ID. Must not be <c>null</c>.</param>
        public CampaignCriteriaName(string customerId, string campaignCriteriaId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignCriteriaId = gax::GaxPreconditions.CheckNotNull(campaignCriteriaId, nameof(campaignCriteriaId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignCriteria ID. Never <c>null</c>.
        /// </summary>
        public string CampaignCriteriaId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignCriteriaId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignCriteriaName);

        /// <inheritdoc />
        public bool Equals(CampaignCriteriaName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignCriteriaName a, CampaignCriteriaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignCriteriaName a, CampaignCriteriaName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'campaign_group' resource.
    /// </summary>
    public sealed partial class CampaignGroupName : gax::IResourceName, sys::IEquatable<CampaignGroupName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignGroups/{campaign_group}");

        /// <summary>
        /// Parses the given campaign_group resource name in string form into a new
        /// <see cref="CampaignGroupName"/> instance.
        /// </summary>
        /// <param name="campaignGroupName">The campaign_group resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignGroupName"/> if successful.</returns>
        public static CampaignGroupName Parse(string campaignGroupName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignGroupName, nameof(campaignGroupName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignGroupName);
            return new CampaignGroupName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_group resource name in string form into a new
        /// <see cref="CampaignGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignGroupName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignGroupName">The campaign_group resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignGroupName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignGroupName, out CampaignGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignGroupName, nameof(campaignGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignGroupName, out resourceName))
            {
                result = new CampaignGroupName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignGroupName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignGroupId">The campaignGroup ID. Must not be <c>null</c>.</param>
        public CampaignGroupName(string customerId, string campaignGroupId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignGroupId = gax::GaxPreconditions.CheckNotNull(campaignGroupId, nameof(campaignGroupId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignGroup ID. Never <c>null</c>.
        /// </summary>
        public string CampaignGroupId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignGroupId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignGroupName);

        /// <inheritdoc />
        public bool Equals(CampaignGroupName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignGroupName a, CampaignGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignGroupName a, CampaignGroupName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'campaign' resource.
    /// </summary>
    public sealed partial class CampaignName : gax::IResourceName, sys::IEquatable<CampaignName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaigns/{campaign}");

        /// <summary>
        /// Parses the given campaign resource name in string form into a new
        /// <see cref="CampaignName"/> instance.
        /// </summary>
        /// <param name="campaignName">The campaign resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignName"/> if successful.</returns>
        public static CampaignName Parse(string campaignName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignName, nameof(campaignName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignName);
            return new CampaignName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign resource name in string form into a new
        /// <see cref="CampaignName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignName">The campaign resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignName, out CampaignName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignName, nameof(campaignName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignName, out resourceName))
            {
                result = new CampaignName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignId">The campaign ID. Must not be <c>null</c>.</param>
        public CampaignName(string customerId, string campaignId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignId = gax::GaxPreconditions.CheckNotNull(campaignId, nameof(campaignId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaign ID. Never <c>null</c>.
        /// </summary>
        public string CampaignId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignName);

        /// <inheritdoc />
        public bool Equals(CampaignName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignName a, CampaignName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignName a, CampaignName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'campaign_shared_set' resource.
    /// </summary>
    public sealed partial class CampaignSharedSetName : gax::IResourceName, sys::IEquatable<CampaignSharedSetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignSharedSets/{campaign_shared_set}");

        /// <summary>
        /// Parses the given campaign_shared_set resource name in string form into a new
        /// <see cref="CampaignSharedSetName"/> instance.
        /// </summary>
        /// <param name="campaignSharedSetName">The campaign_shared_set resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignSharedSetName"/> if successful.</returns>
        public static CampaignSharedSetName Parse(string campaignSharedSetName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignSharedSetName, nameof(campaignSharedSetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignSharedSetName);
            return new CampaignSharedSetName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_shared_set resource name in string form into a new
        /// <see cref="CampaignSharedSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignSharedSetName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignSharedSetName">The campaign_shared_set resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignSharedSetName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignSharedSetName, out CampaignSharedSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignSharedSetName, nameof(campaignSharedSetName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignSharedSetName, out resourceName))
            {
                result = new CampaignSharedSetName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignSharedSetName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignSharedSetId">The campaignSharedSet ID. Must not be <c>null</c>.</param>
        public CampaignSharedSetName(string customerId, string campaignSharedSetId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignSharedSetId = gax::GaxPreconditions.CheckNotNull(campaignSharedSetId, nameof(campaignSharedSetId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignSharedSet ID. Never <c>null</c>.
        /// </summary>
        public string CampaignSharedSetId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignSharedSetId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignSharedSetName);

        /// <inheritdoc />
        public bool Equals(CampaignSharedSetName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignSharedSetName a, CampaignSharedSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignSharedSetName a, CampaignSharedSetName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'customer' resource.
    /// </summary>
    public sealed partial class CustomerName : gax::IResourceName, sys::IEquatable<CustomerName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}");

        /// <summary>
        /// Parses the given customer resource name in string form into a new
        /// <see cref="CustomerName"/> instance.
        /// </summary>
        /// <param name="customerName">The customer resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerName"/> if successful.</returns>
        public static CustomerName Parse(string customerName)
        {
            gax::GaxPreconditions.CheckNotNull(customerName, nameof(customerName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(customerName);
            return new CustomerName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given customer resource name in string form into a new
        /// <see cref="CustomerName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="customerName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="customerName">The customer resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CustomerName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerName, out CustomerName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerName, nameof(customerName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(customerName, out resourceName))
            {
                result = new CustomerName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CustomerName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        public CustomerName(string customerId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CustomerName);

        /// <inheritdoc />
        public bool Equals(CustomerName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CustomerName a, CustomerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CustomerName a, CustomerName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'geo_target_constant' resource.
    /// </summary>
    public sealed partial class GeoTargetConstantName : gax::IResourceName, sys::IEquatable<GeoTargetConstantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("geoTargetConstants/{geo_target_constant}");

        /// <summary>
        /// Parses the given geo_target_constant resource name in string form into a new
        /// <see cref="GeoTargetConstantName"/> instance.
        /// </summary>
        /// <param name="geoTargetConstantName">The geo_target_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GeoTargetConstantName"/> if successful.</returns>
        public static GeoTargetConstantName Parse(string geoTargetConstantName)
        {
            gax::GaxPreconditions.CheckNotNull(geoTargetConstantName, nameof(geoTargetConstantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(geoTargetConstantName);
            return new GeoTargetConstantName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given geo_target_constant resource name in string form into a new
        /// <see cref="GeoTargetConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="geoTargetConstantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="geoTargetConstantName">The geo_target_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="GeoTargetConstantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string geoTargetConstantName, out GeoTargetConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(geoTargetConstantName, nameof(geoTargetConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(geoTargetConstantName, out resourceName))
            {
                result = new GeoTargetConstantName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="GeoTargetConstantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="geoTargetConstantId">The geoTargetConstant ID. Must not be <c>null</c>.</param>
        public GeoTargetConstantName(string geoTargetConstantId)
        {
            GeoTargetConstantId = gax::GaxPreconditions.CheckNotNull(geoTargetConstantId, nameof(geoTargetConstantId));
        }

        /// <summary>
        /// The geoTargetConstant ID. Never <c>null</c>.
        /// </summary>
        public string GeoTargetConstantId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(GeoTargetConstantId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as GeoTargetConstantName);

        /// <inheritdoc />
        public bool Equals(GeoTargetConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(GeoTargetConstantName a, GeoTargetConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(GeoTargetConstantName a, GeoTargetConstantName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'google_ads_field' resource.
    /// </summary>
    public sealed partial class GoogleAdsFieldName : gax::IResourceName, sys::IEquatable<GoogleAdsFieldName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("googleAdsFields/{google_ads_field}");

        /// <summary>
        /// Parses the given google_ads_field resource name in string form into a new
        /// <see cref="GoogleAdsFieldName"/> instance.
        /// </summary>
        /// <param name="googleAdsFieldName">The google_ads_field resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GoogleAdsFieldName"/> if successful.</returns>
        public static GoogleAdsFieldName Parse(string googleAdsFieldName)
        {
            gax::GaxPreconditions.CheckNotNull(googleAdsFieldName, nameof(googleAdsFieldName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(googleAdsFieldName);
            return new GoogleAdsFieldName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given google_ads_field resource name in string form into a new
        /// <see cref="GoogleAdsFieldName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="googleAdsFieldName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="googleAdsFieldName">The google_ads_field resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="GoogleAdsFieldName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string googleAdsFieldName, out GoogleAdsFieldName result)
        {
            gax::GaxPreconditions.CheckNotNull(googleAdsFieldName, nameof(googleAdsFieldName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(googleAdsFieldName, out resourceName))
            {
                result = new GoogleAdsFieldName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="GoogleAdsFieldName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="googleAdsFieldId">The googleAdsField ID. Must not be <c>null</c>.</param>
        public GoogleAdsFieldName(string googleAdsFieldId)
        {
            GoogleAdsFieldId = gax::GaxPreconditions.CheckNotNull(googleAdsFieldId, nameof(googleAdsFieldId));
        }

        /// <summary>
        /// The googleAdsField ID. Never <c>null</c>.
        /// </summary>
        public string GoogleAdsFieldId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(GoogleAdsFieldId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as GoogleAdsFieldName);

        /// <inheritdoc />
        public bool Equals(GoogleAdsFieldName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(GoogleAdsFieldName a, GoogleAdsFieldName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(GoogleAdsFieldName a, GoogleAdsFieldName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'keyword_view' resource.
    /// </summary>
    public sealed partial class KeywordViewName : gax::IResourceName, sys::IEquatable<KeywordViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordViews/{keyword_view}");

        /// <summary>
        /// Parses the given keyword_view resource name in string form into a new
        /// <see cref="KeywordViewName"/> instance.
        /// </summary>
        /// <param name="keywordViewName">The keyword_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordViewName"/> if successful.</returns>
        public static KeywordViewName Parse(string keywordViewName)
        {
            gax::GaxPreconditions.CheckNotNull(keywordViewName, nameof(keywordViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(keywordViewName);
            return new KeywordViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given keyword_view resource name in string form into a new
        /// <see cref="KeywordViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="keywordViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="keywordViewName">The keyword_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="KeywordViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordViewName, out KeywordViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordViewName, nameof(keywordViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(keywordViewName, out resourceName))
            {
                result = new KeywordViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="KeywordViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="keywordViewId">The keywordView ID. Must not be <c>null</c>.</param>
        public KeywordViewName(string customerId, string keywordViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            KeywordViewId = gax::GaxPreconditions.CheckNotNull(keywordViewId, nameof(keywordViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The keywordView ID. Never <c>null</c>.
        /// </summary>
        public string KeywordViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, KeywordViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as KeywordViewName);

        /// <inheritdoc />
        public bool Equals(KeywordViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(KeywordViewName a, KeywordViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(KeywordViewName a, KeywordViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'recommendation' resource.
    /// </summary>
    public sealed partial class RecommendationName : gax::IResourceName, sys::IEquatable<RecommendationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/recommendations/{recommendation}");

        /// <summary>
        /// Parses the given recommendation resource name in string form into a new
        /// <see cref="RecommendationName"/> instance.
        /// </summary>
        /// <param name="recommendationName">The recommendation resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RecommendationName"/> if successful.</returns>
        public static RecommendationName Parse(string recommendationName)
        {
            gax::GaxPreconditions.CheckNotNull(recommendationName, nameof(recommendationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(recommendationName);
            return new RecommendationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given recommendation resource name in string form into a new
        /// <see cref="RecommendationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="recommendationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="recommendationName">The recommendation resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="RecommendationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommendationName, out RecommendationName result)
        {
            gax::GaxPreconditions.CheckNotNull(recommendationName, nameof(recommendationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(recommendationName, out resourceName))
            {
                result = new RecommendationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="RecommendationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="recommendationId">The recommendation ID. Must not be <c>null</c>.</param>
        public RecommendationName(string customerId, string recommendationId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            RecommendationId = gax::GaxPreconditions.CheckNotNull(recommendationId, nameof(recommendationId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The recommendation ID. Never <c>null</c>.
        /// </summary>
        public string RecommendationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, RecommendationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as RecommendationName);

        /// <inheritdoc />
        public bool Equals(RecommendationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(RecommendationName a, RecommendationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(RecommendationName a, RecommendationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'shared_criteria' resource.
    /// </summary>
    public sealed partial class SharedCriteriaName : gax::IResourceName, sys::IEquatable<SharedCriteriaName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/sharedCriteria/{shared_criteria}");

        /// <summary>
        /// Parses the given shared_criteria resource name in string form into a new
        /// <see cref="SharedCriteriaName"/> instance.
        /// </summary>
        /// <param name="sharedCriteriaName">The shared_criteria resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SharedCriteriaName"/> if successful.</returns>
        public static SharedCriteriaName Parse(string sharedCriteriaName)
        {
            gax::GaxPreconditions.CheckNotNull(sharedCriteriaName, nameof(sharedCriteriaName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(sharedCriteriaName);
            return new SharedCriteriaName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given shared_criteria resource name in string form into a new
        /// <see cref="SharedCriteriaName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="sharedCriteriaName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="sharedCriteriaName">The shared_criteria resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SharedCriteriaName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sharedCriteriaName, out SharedCriteriaName result)
        {
            gax::GaxPreconditions.CheckNotNull(sharedCriteriaName, nameof(sharedCriteriaName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(sharedCriteriaName, out resourceName))
            {
                result = new SharedCriteriaName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="SharedCriteriaName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="sharedCriteriaId">The sharedCriteria ID. Must not be <c>null</c>.</param>
        public SharedCriteriaName(string customerId, string sharedCriteriaId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            SharedCriteriaId = gax::GaxPreconditions.CheckNotNull(sharedCriteriaId, nameof(sharedCriteriaId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The sharedCriteria ID. Never <c>null</c>.
        /// </summary>
        public string SharedCriteriaId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, SharedCriteriaId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SharedCriteriaName);

        /// <inheritdoc />
        public bool Equals(SharedCriteriaName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SharedCriteriaName a, SharedCriteriaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SharedCriteriaName a, SharedCriteriaName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'shared_set' resource.
    /// </summary>
    public sealed partial class SharedSetName : gax::IResourceName, sys::IEquatable<SharedSetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/sharedSets/{shared_set}");

        /// <summary>
        /// Parses the given shared_set resource name in string form into a new
        /// <see cref="SharedSetName"/> instance.
        /// </summary>
        /// <param name="sharedSetName">The shared_set resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SharedSetName"/> if successful.</returns>
        public static SharedSetName Parse(string sharedSetName)
        {
            gax::GaxPreconditions.CheckNotNull(sharedSetName, nameof(sharedSetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(sharedSetName);
            return new SharedSetName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given shared_set resource name in string form into a new
        /// <see cref="SharedSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="sharedSetName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="sharedSetName">The shared_set resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SharedSetName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sharedSetName, out SharedSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(sharedSetName, nameof(sharedSetName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(sharedSetName, out resourceName))
            {
                result = new SharedSetName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="SharedSetName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="sharedSetId">The sharedSet ID. Must not be <c>null</c>.</param>
        public SharedSetName(string customerId, string sharedSetId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            SharedSetId = gax::GaxPreconditions.CheckNotNull(sharedSetId, nameof(sharedSetId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The sharedSet ID. Never <c>null</c>.
        /// </summary>
        public string SharedSetId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, SharedSetId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SharedSetName);

        /// <inheritdoc />
        public bool Equals(SharedSetName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SharedSetName a, SharedSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SharedSetName a, SharedSetName b) => !(a == b);
    }



}
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

// TODO( b/119694056): Removed Comment

using gax = Google.Api.Gax;
using sys = System;
using linq = System.Linq;

namespace Google.Ads.GoogleAds.V0.Services
{
    /// <summary>
    /// Resource name for the 'account_budget' resource.
    /// </summary>
    public sealed partial class AccountBudgetName : gax::IResourceName, sys::IEquatable<AccountBudgetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/accountBudgets/{account_budget}");

        /// <summary>
        /// Parses the given account_budget resource name in string form into a new
        /// <see cref="AccountBudgetName"/> instance.
        /// </summary>
        /// <param name="accountBudgetName">The account_budget resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountBudgetName"/> if successful.</returns>
        public static AccountBudgetName Parse(string accountBudgetName)
        {
            gax::GaxPreconditions.CheckNotNull(accountBudgetName, nameof(accountBudgetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(accountBudgetName);
            return new AccountBudgetName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given account_budget resource name in string form into a new
        /// <see cref="AccountBudgetName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="accountBudgetName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="accountBudgetName">The account_budget resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AccountBudgetName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountBudgetName, out AccountBudgetName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountBudgetName, nameof(accountBudgetName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(accountBudgetName, out resourceName))
            {
                result = new AccountBudgetName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AccountBudgetName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="accountBudgetId">The accountBudget ID. Must not be <c>null</c>.</param>
        public AccountBudgetName(string customerId, string accountBudgetId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AccountBudgetId = gax::GaxPreconditions.CheckNotNull(accountBudgetId, nameof(accountBudgetId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The accountBudget ID. Never <c>null</c>.
        /// </summary>
        public string AccountBudgetId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AccountBudgetId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AccountBudgetName);

        /// <inheritdoc />
        public bool Equals(AccountBudgetName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AccountBudgetName a, AccountBudgetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AccountBudgetName a, AccountBudgetName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'account_budget_proposal' resource.
    /// </summary>
    public sealed partial class AccountBudgetProposalName : gax::IResourceName, sys::IEquatable<AccountBudgetProposalName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/accountBudgetProposals/{account_budget_proposal}");

        /// <summary>
        /// Parses the given account_budget_proposal resource name in string form into a new
        /// <see cref="AccountBudgetProposalName"/> instance.
        /// </summary>
        /// <param name="accountBudgetProposalName">The account_budget_proposal resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountBudgetProposalName"/> if successful.</returns>
        public static AccountBudgetProposalName Parse(string accountBudgetProposalName)
        {
            gax::GaxPreconditions.CheckNotNull(accountBudgetProposalName, nameof(accountBudgetProposalName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(accountBudgetProposalName);
            return new AccountBudgetProposalName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given account_budget_proposal resource name in string form into a new
        /// <see cref="AccountBudgetProposalName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="accountBudgetProposalName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="accountBudgetProposalName">The account_budget_proposal resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AccountBudgetProposalName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountBudgetProposalName, out AccountBudgetProposalName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountBudgetProposalName, nameof(accountBudgetProposalName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(accountBudgetProposalName, out resourceName))
            {
                result = new AccountBudgetProposalName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AccountBudgetProposalName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="accountBudgetProposalId">The accountBudgetProposal ID. Must not be <c>null</c>.</param>
        public AccountBudgetProposalName(string customerId, string accountBudgetProposalId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AccountBudgetProposalId = gax::GaxPreconditions.CheckNotNull(accountBudgetProposalId, nameof(accountBudgetProposalId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The accountBudgetProposal ID. Never <c>null</c>.
        /// </summary>
        public string AccountBudgetProposalId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AccountBudgetProposalId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AccountBudgetProposalName);

        /// <inheritdoc />
        public bool Equals(AccountBudgetProposalName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AccountBudgetProposalName a, AccountBudgetProposalName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AccountBudgetProposalName a, AccountBudgetProposalName b) => !(a == b);
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
    /// Resource name for the 'ad_group_audience_view' resource.
    /// </summary>
    public sealed partial class AdGroupAudienceViewName : gax::IResourceName, sys::IEquatable<AdGroupAudienceViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}");

        /// <summary>
        /// Parses the given ad_group_audience_view resource name in string form into a new
        /// <see cref="AdGroupAudienceViewName"/> instance.
        /// </summary>
        /// <param name="adGroupAudienceViewName">The ad_group_audience_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupAudienceViewName"/> if successful.</returns>
        public static AdGroupAudienceViewName Parse(string adGroupAudienceViewName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAudienceViewName, nameof(adGroupAudienceViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupAudienceViewName);
            return new AdGroupAudienceViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_audience_view resource name in string form into a new
        /// <see cref="AdGroupAudienceViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupAudienceViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupAudienceViewName">The ad_group_audience_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupAudienceViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAudienceViewName, out AdGroupAudienceViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAudienceViewName, nameof(adGroupAudienceViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupAudienceViewName, out resourceName))
            {
                result = new AdGroupAudienceViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupAudienceViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupAudienceViewId">The adGroupAudienceView ID. Must not be <c>null</c>.</param>
        public AdGroupAudienceViewName(string customerId, string adGroupAudienceViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupAudienceViewId = gax::GaxPreconditions.CheckNotNull(adGroupAudienceViewId, nameof(adGroupAudienceViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupAudienceView ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupAudienceViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupAudienceViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupAudienceViewName);

        /// <inheritdoc />
        public bool Equals(AdGroupAudienceViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupAudienceViewName a, AdGroupAudienceViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupAudienceViewName a, AdGroupAudienceViewName b) => !(a == b);
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
    /// Resource name for the 'ad_group_feed' resource.
    /// </summary>
    public sealed partial class AdGroupFeedName : gax::IResourceName, sys::IEquatable<AdGroupFeedName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupFeeds/{ad_group_feed}");

        /// <summary>
        /// Parses the given ad_group_feed resource name in string form into a new
        /// <see cref="AdGroupFeedName"/> instance.
        /// </summary>
        /// <param name="adGroupFeedName">The ad_group_feed resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupFeedName"/> if successful.</returns>
        public static AdGroupFeedName Parse(string adGroupFeedName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupFeedName, nameof(adGroupFeedName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupFeedName);
            return new AdGroupFeedName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_feed resource name in string form into a new
        /// <see cref="AdGroupFeedName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupFeedName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupFeedName">The ad_group_feed resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupFeedName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupFeedName, out AdGroupFeedName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupFeedName, nameof(adGroupFeedName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupFeedName, out resourceName))
            {
                result = new AdGroupFeedName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupFeedName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupFeedId">The adGroupFeed ID. Must not be <c>null</c>.</param>
        public AdGroupFeedName(string customerId, string adGroupFeedId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupFeedId = gax::GaxPreconditions.CheckNotNull(adGroupFeedId, nameof(adGroupFeedId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupFeed ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupFeedId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupFeedId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupFeedName);

        /// <inheritdoc />
        public bool Equals(AdGroupFeedName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupFeedName a, AdGroupFeedName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupFeedName a, AdGroupFeedName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'age_range_view' resource.
    /// </summary>
    public sealed partial class AgeRangeViewName : gax::IResourceName, sys::IEquatable<AgeRangeViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/ageRangeViews/{age_range_view}");

        /// <summary>
        /// Parses the given age_range_view resource name in string form into a new
        /// <see cref="AgeRangeViewName"/> instance.
        /// </summary>
        /// <param name="ageRangeViewName">The age_range_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AgeRangeViewName"/> if successful.</returns>
        public static AgeRangeViewName Parse(string ageRangeViewName)
        {
            gax::GaxPreconditions.CheckNotNull(ageRangeViewName, nameof(ageRangeViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(ageRangeViewName);
            return new AgeRangeViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given age_range_view resource name in string form into a new
        /// <see cref="AgeRangeViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="ageRangeViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="ageRangeViewName">The age_range_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AgeRangeViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string ageRangeViewName, out AgeRangeViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(ageRangeViewName, nameof(ageRangeViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(ageRangeViewName, out resourceName))
            {
                result = new AgeRangeViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AgeRangeViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="ageRangeViewId">The ageRangeView ID. Must not be <c>null</c>.</param>
        public AgeRangeViewName(string customerId, string ageRangeViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AgeRangeViewId = gax::GaxPreconditions.CheckNotNull(ageRangeViewId, nameof(ageRangeViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The ageRangeView ID. Never <c>null</c>.
        /// </summary>
        public string AgeRangeViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AgeRangeViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AgeRangeViewName);

        /// <inheritdoc />
        public bool Equals(AgeRangeViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AgeRangeViewName a, AgeRangeViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AgeRangeViewName a, AgeRangeViewName b) => !(a == b);
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
    /// Resource name for the 'billing_setup' resource.
    /// </summary>
    public sealed partial class BillingSetupName : gax::IResourceName, sys::IEquatable<BillingSetupName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/billingSetups/{billing_setup}");

        /// <summary>
        /// Parses the given billing_setup resource name in string form into a new
        /// <see cref="BillingSetupName"/> instance.
        /// </summary>
        /// <param name="billingSetupName">The billing_setup resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="BillingSetupName"/> if successful.</returns>
        public static BillingSetupName Parse(string billingSetupName)
        {
            gax::GaxPreconditions.CheckNotNull(billingSetupName, nameof(billingSetupName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(billingSetupName);
            return new BillingSetupName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given billing_setup resource name in string form into a new
        /// <see cref="BillingSetupName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="billingSetupName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="billingSetupName">The billing_setup resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="BillingSetupName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string billingSetupName, out BillingSetupName result)
        {
            gax::GaxPreconditions.CheckNotNull(billingSetupName, nameof(billingSetupName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(billingSetupName, out resourceName))
            {
                result = new BillingSetupName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="BillingSetupName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="billingSetupId">The billingSetup ID. Must not be <c>null</c>.</param>
        public BillingSetupName(string customerId, string billingSetupId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            BillingSetupId = gax::GaxPreconditions.CheckNotNull(billingSetupId, nameof(billingSetupId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The billingSetup ID. Never <c>null</c>.
        /// </summary>
        public string BillingSetupId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, BillingSetupId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as BillingSetupName);

        /// <inheritdoc />
        public bool Equals(BillingSetupName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(BillingSetupName a, BillingSetupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(BillingSetupName a, BillingSetupName b) => !(a == b);
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
    /// Resource name for the 'campaign_audience_view' resource.
    /// </summary>
    public sealed partial class CampaignAudienceViewName : gax::IResourceName, sys::IEquatable<CampaignAudienceViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignAudienceViews/{campaign_audience_view}");

        /// <summary>
        /// Parses the given campaign_audience_view resource name in string form into a new
        /// <see cref="CampaignAudienceViewName"/> instance.
        /// </summary>
        /// <param name="campaignAudienceViewName">The campaign_audience_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignAudienceViewName"/> if successful.</returns>
        public static CampaignAudienceViewName Parse(string campaignAudienceViewName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignAudienceViewName, nameof(campaignAudienceViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignAudienceViewName);
            return new CampaignAudienceViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_audience_view resource name in string form into a new
        /// <see cref="CampaignAudienceViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignAudienceViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignAudienceViewName">The campaign_audience_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignAudienceViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignAudienceViewName, out CampaignAudienceViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignAudienceViewName, nameof(campaignAudienceViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignAudienceViewName, out resourceName))
            {
                result = new CampaignAudienceViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignAudienceViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignAudienceViewId">The campaignAudienceView ID. Must not be <c>null</c>.</param>
        public CampaignAudienceViewName(string customerId, string campaignAudienceViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignAudienceViewId = gax::GaxPreconditions.CheckNotNull(campaignAudienceViewId, nameof(campaignAudienceViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignAudienceView ID. Never <c>null</c>.
        /// </summary>
        public string CampaignAudienceViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignAudienceViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignAudienceViewName);

        /// <inheritdoc />
        public bool Equals(CampaignAudienceViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignAudienceViewName a, CampaignAudienceViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignAudienceViewName a, CampaignAudienceViewName b) => !(a == b);
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
    /// Resource name for the 'campaign_feed' resource.
    /// </summary>
    public sealed partial class CampaignFeedName : gax::IResourceName, sys::IEquatable<CampaignFeedName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignFeeds/{campaign_feed}");

        /// <summary>
        /// Parses the given campaign_feed resource name in string form into a new
        /// <see cref="CampaignFeedName"/> instance.
        /// </summary>
        /// <param name="campaignFeedName">The campaign_feed resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignFeedName"/> if successful.</returns>
        public static CampaignFeedName Parse(string campaignFeedName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignFeedName, nameof(campaignFeedName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignFeedName);
            return new CampaignFeedName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_feed resource name in string form into a new
        /// <see cref="CampaignFeedName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignFeedName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignFeedName">The campaign_feed resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignFeedName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignFeedName, out CampaignFeedName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignFeedName, nameof(campaignFeedName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignFeedName, out resourceName))
            {
                result = new CampaignFeedName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignFeedName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignFeedId">The campaignFeed ID. Must not be <c>null</c>.</param>
        public CampaignFeedName(string customerId, string campaignFeedId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignFeedId = gax::GaxPreconditions.CheckNotNull(campaignFeedId, nameof(campaignFeedId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignFeed ID. Never <c>null</c>.
        /// </summary>
        public string CampaignFeedId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignFeedId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignFeedName);

        /// <inheritdoc />
        public bool Equals(CampaignFeedName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignFeedName a, CampaignFeedName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignFeedName a, CampaignFeedName b) => !(a == b);
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
    /// Resource name for the 'carrier_constant' resource.
    /// </summary>
    public sealed partial class CarrierConstantName : gax::IResourceName, sys::IEquatable<CarrierConstantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("carrierConstants/{carrier_constant}");

        /// <summary>
        /// Parses the given carrier_constant resource name in string form into a new
        /// <see cref="CarrierConstantName"/> instance.
        /// </summary>
        /// <param name="carrierConstantName">The carrier_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CarrierConstantName"/> if successful.</returns>
        public static CarrierConstantName Parse(string carrierConstantName)
        {
            gax::GaxPreconditions.CheckNotNull(carrierConstantName, nameof(carrierConstantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(carrierConstantName);
            return new CarrierConstantName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given carrier_constant resource name in string form into a new
        /// <see cref="CarrierConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="carrierConstantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="carrierConstantName">The carrier_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CarrierConstantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string carrierConstantName, out CarrierConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(carrierConstantName, nameof(carrierConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(carrierConstantName, out resourceName))
            {
                result = new CarrierConstantName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CarrierConstantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="carrierConstantId">The carrierConstant ID. Must not be <c>null</c>.</param>
        public CarrierConstantName(string carrierConstantId)
        {
            CarrierConstantId = gax::GaxPreconditions.CheckNotNull(carrierConstantId, nameof(carrierConstantId));
        }

        /// <summary>
        /// The carrierConstant ID. Never <c>null</c>.
        /// </summary>
        public string CarrierConstantId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CarrierConstantId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CarrierConstantName);

        /// <inheritdoc />
        public bool Equals(CarrierConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CarrierConstantName a, CarrierConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CarrierConstantName a, CarrierConstantName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'change_status' resource.
    /// </summary>
    public sealed partial class ChangeStatusName : gax::IResourceName, sys::IEquatable<ChangeStatusName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/changeStatus/{change_status}");

        /// <summary>
        /// Parses the given change_status resource name in string form into a new
        /// <see cref="ChangeStatusName"/> instance.
        /// </summary>
        /// <param name="changeStatusName">The change_status resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChangeStatusName"/> if successful.</returns>
        public static ChangeStatusName Parse(string changeStatusName)
        {
            gax::GaxPreconditions.CheckNotNull(changeStatusName, nameof(changeStatusName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(changeStatusName);
            return new ChangeStatusName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given change_status resource name in string form into a new
        /// <see cref="ChangeStatusName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="changeStatusName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="changeStatusName">The change_status resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ChangeStatusName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changeStatusName, out ChangeStatusName result)
        {
            gax::GaxPreconditions.CheckNotNull(changeStatusName, nameof(changeStatusName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(changeStatusName, out resourceName))
            {
                result = new ChangeStatusName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ChangeStatusName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="changeStatusId">The changeStatus ID. Must not be <c>null</c>.</param>
        public ChangeStatusName(string customerId, string changeStatusId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            ChangeStatusId = gax::GaxPreconditions.CheckNotNull(changeStatusId, nameof(changeStatusId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The changeStatus ID. Never <c>null</c>.
        /// </summary>
        public string ChangeStatusId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, ChangeStatusId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ChangeStatusName);

        /// <inheritdoc />
        public bool Equals(ChangeStatusName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ChangeStatusName a, ChangeStatusName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ChangeStatusName a, ChangeStatusName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'conversion_action' resource.
    /// </summary>
    public sealed partial class ConversionActionName : gax::IResourceName, sys::IEquatable<ConversionActionName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/conversionActions/{conversion_action}");

        /// <summary>
        /// Parses the given conversion_action resource name in string form into a new
        /// <see cref="ConversionActionName"/> instance.
        /// </summary>
        /// <param name="conversionActionName">The conversion_action resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversionActionName"/> if successful.</returns>
        public static ConversionActionName Parse(string conversionActionName)
        {
            gax::GaxPreconditions.CheckNotNull(conversionActionName, nameof(conversionActionName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(conversionActionName);
            return new ConversionActionName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given conversion_action resource name in string form into a new
        /// <see cref="ConversionActionName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="conversionActionName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="conversionActionName">The conversion_action resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ConversionActionName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionActionName, out ConversionActionName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversionActionName, nameof(conversionActionName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(conversionActionName, out resourceName))
            {
                result = new ConversionActionName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ConversionActionName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="conversionActionId">The conversionAction ID. Must not be <c>null</c>.</param>
        public ConversionActionName(string customerId, string conversionActionId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            ConversionActionId = gax::GaxPreconditions.CheckNotNull(conversionActionId, nameof(conversionActionId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The conversionAction ID. Never <c>null</c>.
        /// </summary>
        public string ConversionActionId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, ConversionActionId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ConversionActionName);

        /// <inheritdoc />
        public bool Equals(ConversionActionName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ConversionActionName a, ConversionActionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ConversionActionName a, ConversionActionName b) => !(a == b);
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
    /// Resource name for the 'customer_client' resource.
    /// </summary>
    public sealed partial class CustomerClientName : gax::IResourceName, sys::IEquatable<CustomerClientName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerClients/{customer_client}");

        /// <summary>
        /// Parses the given customer_client resource name in string form into a new
        /// <see cref="CustomerClientName"/> instance.
        /// </summary>
        /// <param name="customerClientName">The customer_client resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerClientName"/> if successful.</returns>
        public static CustomerClientName Parse(string customerClientName)
        {
            gax::GaxPreconditions.CheckNotNull(customerClientName, nameof(customerClientName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(customerClientName);
            return new CustomerClientName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given customer_client resource name in string form into a new
        /// <see cref="CustomerClientName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="customerClientName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="customerClientName">The customer_client resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CustomerClientName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerClientName, out CustomerClientName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerClientName, nameof(customerClientName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(customerClientName, out resourceName))
            {
                result = new CustomerClientName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CustomerClientName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="customerClientId">The customerClient ID. Must not be <c>null</c>.</param>
        public CustomerClientName(string customerId, string customerClientId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CustomerClientId = gax::GaxPreconditions.CheckNotNull(customerClientId, nameof(customerClientId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The customerClient ID. Never <c>null</c>.
        /// </summary>
        public string CustomerClientId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CustomerClientId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CustomerClientName);

        /// <inheritdoc />
        public bool Equals(CustomerClientName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CustomerClientName a, CustomerClientName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CustomerClientName a, CustomerClientName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'customer_client_link' resource.
    /// </summary>
    public sealed partial class CustomerClientLinkName : gax::IResourceName, sys::IEquatable<CustomerClientLinkName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerClientLinks/{customer_client_link}");

        /// <summary>
        /// Parses the given customer_client_link resource name in string form into a new
        /// <see cref="CustomerClientLinkName"/> instance.
        /// </summary>
        /// <param name="customerClientLinkName">The customer_client_link resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerClientLinkName"/> if successful.</returns>
        public static CustomerClientLinkName Parse(string customerClientLinkName)
        {
            gax::GaxPreconditions.CheckNotNull(customerClientLinkName, nameof(customerClientLinkName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(customerClientLinkName);
            return new CustomerClientLinkName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given customer_client_link resource name in string form into a new
        /// <see cref="CustomerClientLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="customerClientLinkName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="customerClientLinkName">The customer_client_link resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CustomerClientLinkName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerClientLinkName, out CustomerClientLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerClientLinkName, nameof(customerClientLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(customerClientLinkName, out resourceName))
            {
                result = new CustomerClientLinkName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CustomerClientLinkName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="customerClientLinkId">The customerClientLink ID. Must not be <c>null</c>.</param>
        public CustomerClientLinkName(string customerId, string customerClientLinkId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CustomerClientLinkId = gax::GaxPreconditions.CheckNotNull(customerClientLinkId, nameof(customerClientLinkId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The customerClientLink ID. Never <c>null</c>.
        /// </summary>
        public string CustomerClientLinkId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CustomerClientLinkId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CustomerClientLinkName);

        /// <inheritdoc />
        public bool Equals(CustomerClientLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CustomerClientLinkName a, CustomerClientLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CustomerClientLinkName a, CustomerClientLinkName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'customer_feed' resource.
    /// </summary>
    public sealed partial class CustomerFeedName : gax::IResourceName, sys::IEquatable<CustomerFeedName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerFeeds/{customer_feed}");

        /// <summary>
        /// Parses the given customer_feed resource name in string form into a new
        /// <see cref="CustomerFeedName"/> instance.
        /// </summary>
        /// <param name="customerFeedName">The customer_feed resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerFeedName"/> if successful.</returns>
        public static CustomerFeedName Parse(string customerFeedName)
        {
            gax::GaxPreconditions.CheckNotNull(customerFeedName, nameof(customerFeedName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(customerFeedName);
            return new CustomerFeedName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given customer_feed resource name in string form into a new
        /// <see cref="CustomerFeedName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="customerFeedName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="customerFeedName">The customer_feed resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CustomerFeedName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerFeedName, out CustomerFeedName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerFeedName, nameof(customerFeedName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(customerFeedName, out resourceName))
            {
                result = new CustomerFeedName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CustomerFeedName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="customerFeedId">The customerFeed ID. Must not be <c>null</c>.</param>
        public CustomerFeedName(string customerId, string customerFeedId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CustomerFeedId = gax::GaxPreconditions.CheckNotNull(customerFeedId, nameof(customerFeedId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The customerFeed ID. Never <c>null</c>.
        /// </summary>
        public string CustomerFeedId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CustomerFeedId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CustomerFeedName);

        /// <inheritdoc />
        public bool Equals(CustomerFeedName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CustomerFeedName a, CustomerFeedName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CustomerFeedName a, CustomerFeedName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'customer_manager_link' resource.
    /// </summary>
    public sealed partial class CustomerManagerLinkName : gax::IResourceName, sys::IEquatable<CustomerManagerLinkName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerManagerLinks/{customer_manager_link}");

        /// <summary>
        /// Parses the given customer_manager_link resource name in string form into a new
        /// <see cref="CustomerManagerLinkName"/> instance.
        /// </summary>
        /// <param name="customerManagerLinkName">The customer_manager_link resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerManagerLinkName"/> if successful.</returns>
        public static CustomerManagerLinkName Parse(string customerManagerLinkName)
        {
            gax::GaxPreconditions.CheckNotNull(customerManagerLinkName, nameof(customerManagerLinkName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(customerManagerLinkName);
            return new CustomerManagerLinkName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given customer_manager_link resource name in string form into a new
        /// <see cref="CustomerManagerLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="customerManagerLinkName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="customerManagerLinkName">The customer_manager_link resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CustomerManagerLinkName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerManagerLinkName, out CustomerManagerLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerManagerLinkName, nameof(customerManagerLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(customerManagerLinkName, out resourceName))
            {
                result = new CustomerManagerLinkName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CustomerManagerLinkName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="customerManagerLinkId">The customerManagerLink ID. Must not be <c>null</c>.</param>
        public CustomerManagerLinkName(string customerId, string customerManagerLinkId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CustomerManagerLinkId = gax::GaxPreconditions.CheckNotNull(customerManagerLinkId, nameof(customerManagerLinkId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The customerManagerLink ID. Never <c>null</c>.
        /// </summary>
        public string CustomerManagerLinkId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CustomerManagerLinkId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CustomerManagerLinkName);

        /// <inheritdoc />
        public bool Equals(CustomerManagerLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CustomerManagerLinkName a, CustomerManagerLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CustomerManagerLinkName a, CustomerManagerLinkName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'display_keyword_view' resource.
    /// </summary>
    public sealed partial class DisplayKeywordViewName : gax::IResourceName, sys::IEquatable<DisplayKeywordViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/displayKeywordViews/{display_keyword_view}");

        /// <summary>
        /// Parses the given display_keyword_view resource name in string form into a new
        /// <see cref="DisplayKeywordViewName"/> instance.
        /// </summary>
        /// <param name="displayKeywordViewName">The display_keyword_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DisplayKeywordViewName"/> if successful.</returns>
        public static DisplayKeywordViewName Parse(string displayKeywordViewName)
        {
            gax::GaxPreconditions.CheckNotNull(displayKeywordViewName, nameof(displayKeywordViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(displayKeywordViewName);
            return new DisplayKeywordViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given display_keyword_view resource name in string form into a new
        /// <see cref="DisplayKeywordViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="displayKeywordViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="displayKeywordViewName">The display_keyword_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DisplayKeywordViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string displayKeywordViewName, out DisplayKeywordViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(displayKeywordViewName, nameof(displayKeywordViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(displayKeywordViewName, out resourceName))
            {
                result = new DisplayKeywordViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DisplayKeywordViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="displayKeywordViewId">The displayKeywordView ID. Must not be <c>null</c>.</param>
        public DisplayKeywordViewName(string customerId, string displayKeywordViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            DisplayKeywordViewId = gax::GaxPreconditions.CheckNotNull(displayKeywordViewId, nameof(displayKeywordViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The displayKeywordView ID. Never <c>null</c>.
        /// </summary>
        public string DisplayKeywordViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, DisplayKeywordViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DisplayKeywordViewName);

        /// <inheritdoc />
        public bool Equals(DisplayKeywordViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DisplayKeywordViewName a, DisplayKeywordViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DisplayKeywordViewName a, DisplayKeywordViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'feed' resource.
    /// </summary>
    public sealed partial class FeedName : gax::IResourceName, sys::IEquatable<FeedName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/feeds/{feed}");

        /// <summary>
        /// Parses the given feed resource name in string form into a new
        /// <see cref="FeedName"/> instance.
        /// </summary>
        /// <param name="feedName">The feed resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedName"/> if successful.</returns>
        public static FeedName Parse(string feedName)
        {
            gax::GaxPreconditions.CheckNotNull(feedName, nameof(feedName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(feedName);
            return new FeedName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given feed resource name in string form into a new
        /// <see cref="FeedName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="feedName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="feedName">The feed resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FeedName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedName, out FeedName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedName, nameof(feedName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(feedName, out resourceName))
            {
                result = new FeedName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="FeedName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="feedId">The feed ID. Must not be <c>null</c>.</param>
        public FeedName(string customerId, string feedId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            FeedId = gax::GaxPreconditions.CheckNotNull(feedId, nameof(feedId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The feed ID. Never <c>null</c>.
        /// </summary>
        public string FeedId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, FeedId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FeedName);

        /// <inheritdoc />
        public bool Equals(FeedName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FeedName a, FeedName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FeedName a, FeedName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'feed_item' resource.
    /// </summary>
    public sealed partial class FeedItemName : gax::IResourceName, sys::IEquatable<FeedItemName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/feedItems/{feed_item}");

        /// <summary>
        /// Parses the given feed_item resource name in string form into a new
        /// <see cref="FeedItemName"/> instance.
        /// </summary>
        /// <param name="feedItemName">The feed_item resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedItemName"/> if successful.</returns>
        public static FeedItemName Parse(string feedItemName)
        {
            gax::GaxPreconditions.CheckNotNull(feedItemName, nameof(feedItemName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(feedItemName);
            return new FeedItemName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given feed_item resource name in string form into a new
        /// <see cref="FeedItemName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="feedItemName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="feedItemName">The feed_item resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FeedItemName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedItemName, out FeedItemName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedItemName, nameof(feedItemName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(feedItemName, out resourceName))
            {
                result = new FeedItemName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="FeedItemName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="feedItemId">The feedItem ID. Must not be <c>null</c>.</param>
        public FeedItemName(string customerId, string feedItemId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            FeedItemId = gax::GaxPreconditions.CheckNotNull(feedItemId, nameof(feedItemId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The feedItem ID. Never <c>null</c>.
        /// </summary>
        public string FeedItemId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, FeedItemId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FeedItemName);

        /// <inheritdoc />
        public bool Equals(FeedItemName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FeedItemName a, FeedItemName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FeedItemName a, FeedItemName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'feed_mapping' resource.
    /// </summary>
    public sealed partial class FeedMappingName : gax::IResourceName, sys::IEquatable<FeedMappingName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/feedMappings/{feed_mapping}");

        /// <summary>
        /// Parses the given feed_mapping resource name in string form into a new
        /// <see cref="FeedMappingName"/> instance.
        /// </summary>
        /// <param name="feedMappingName">The feed_mapping resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedMappingName"/> if successful.</returns>
        public static FeedMappingName Parse(string feedMappingName)
        {
            gax::GaxPreconditions.CheckNotNull(feedMappingName, nameof(feedMappingName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(feedMappingName);
            return new FeedMappingName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given feed_mapping resource name in string form into a new
        /// <see cref="FeedMappingName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="feedMappingName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="feedMappingName">The feed_mapping resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FeedMappingName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedMappingName, out FeedMappingName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedMappingName, nameof(feedMappingName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(feedMappingName, out resourceName))
            {
                result = new FeedMappingName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="FeedMappingName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="feedMappingId">The feedMapping ID. Must not be <c>null</c>.</param>
        public FeedMappingName(string customerId, string feedMappingId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            FeedMappingId = gax::GaxPreconditions.CheckNotNull(feedMappingId, nameof(feedMappingId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The feedMapping ID. Never <c>null</c>.
        /// </summary>
        public string FeedMappingId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, FeedMappingId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FeedMappingName);

        /// <inheritdoc />
        public bool Equals(FeedMappingName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FeedMappingName a, FeedMappingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FeedMappingName a, FeedMappingName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'gender_view' resource.
    /// </summary>
    public sealed partial class GenderViewName : gax::IResourceName, sys::IEquatable<GenderViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/genderViews/{gender_view}");

        /// <summary>
        /// Parses the given gender_view resource name in string form into a new
        /// <see cref="GenderViewName"/> instance.
        /// </summary>
        /// <param name="genderViewName">The gender_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GenderViewName"/> if successful.</returns>
        public static GenderViewName Parse(string genderViewName)
        {
            gax::GaxPreconditions.CheckNotNull(genderViewName, nameof(genderViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(genderViewName);
            return new GenderViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given gender_view resource name in string form into a new
        /// <see cref="GenderViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="genderViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="genderViewName">The gender_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="GenderViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string genderViewName, out GenderViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(genderViewName, nameof(genderViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(genderViewName, out resourceName))
            {
                result = new GenderViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="GenderViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="genderViewId">The genderView ID. Must not be <c>null</c>.</param>
        public GenderViewName(string customerId, string genderViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            GenderViewId = gax::GaxPreconditions.CheckNotNull(genderViewId, nameof(genderViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The genderView ID. Never <c>null</c>.
        /// </summary>
        public string GenderViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, GenderViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as GenderViewName);

        /// <inheritdoc />
        public bool Equals(GenderViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(GenderViewName a, GenderViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(GenderViewName a, GenderViewName b) => !(a == b);
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
    /// Resource name for the 'hotel_group_view' resource.
    /// </summary>
    public sealed partial class HotelGroupViewName : gax::IResourceName, sys::IEquatable<HotelGroupViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/hotelGroupViews/{hotel_group_view}");

        /// <summary>
        /// Parses the given hotel_group_view resource name in string form into a new
        /// <see cref="HotelGroupViewName"/> instance.
        /// </summary>
        /// <param name="hotelGroupViewName">The hotel_group_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HotelGroupViewName"/> if successful.</returns>
        public static HotelGroupViewName Parse(string hotelGroupViewName)
        {
            gax::GaxPreconditions.CheckNotNull(hotelGroupViewName, nameof(hotelGroupViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(hotelGroupViewName);
            return new HotelGroupViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given hotel_group_view resource name in string form into a new
        /// <see cref="HotelGroupViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="hotelGroupViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="hotelGroupViewName">The hotel_group_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="HotelGroupViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hotelGroupViewName, out HotelGroupViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(hotelGroupViewName, nameof(hotelGroupViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(hotelGroupViewName, out resourceName))
            {
                result = new HotelGroupViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="HotelGroupViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="hotelGroupViewId">The hotelGroupView ID. Must not be <c>null</c>.</param>
        public HotelGroupViewName(string customerId, string hotelGroupViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            HotelGroupViewId = gax::GaxPreconditions.CheckNotNull(hotelGroupViewId, nameof(hotelGroupViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The hotelGroupView ID. Never <c>null</c>.
        /// </summary>
        public string HotelGroupViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, HotelGroupViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as HotelGroupViewName);

        /// <inheritdoc />
        public bool Equals(HotelGroupViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(HotelGroupViewName a, HotelGroupViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(HotelGroupViewName a, HotelGroupViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'hotel_performance_view' resource.
    /// </summary>
    public sealed partial class HotelPerformanceViewName : gax::IResourceName, sys::IEquatable<HotelPerformanceViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/hotelPerformanceView");

        /// <summary>
        /// Parses the given hotel_performance_view resource name in string form into a new
        /// <see cref="HotelPerformanceViewName"/> instance.
        /// </summary>
        /// <param name="hotelPerformanceViewName">The hotel_performance_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HotelPerformanceViewName"/> if successful.</returns>
        public static HotelPerformanceViewName Parse(string hotelPerformanceViewName)
        {
            gax::GaxPreconditions.CheckNotNull(hotelPerformanceViewName, nameof(hotelPerformanceViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(hotelPerformanceViewName);
            return new HotelPerformanceViewName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given hotel_performance_view resource name in string form into a new
        /// <see cref="HotelPerformanceViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="hotelPerformanceViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="hotelPerformanceViewName">The hotel_performance_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="HotelPerformanceViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hotelPerformanceViewName, out HotelPerformanceViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(hotelPerformanceViewName, nameof(hotelPerformanceViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(hotelPerformanceViewName, out resourceName))
            {
                result = new HotelPerformanceViewName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="HotelPerformanceViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        public HotelPerformanceViewName(string customerId)
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
        public override bool Equals(object obj) => Equals(obj as HotelPerformanceViewName);

        /// <inheritdoc />
        public bool Equals(HotelPerformanceViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(HotelPerformanceViewName a, HotelPerformanceViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(HotelPerformanceViewName a, HotelPerformanceViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'keyword_plan' resource.
    /// </summary>
    public sealed partial class KeywordPlanName : gax::IResourceName, sys::IEquatable<KeywordPlanName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordPlans/{keyword_plan}");

        /// <summary>
        /// Parses the given keyword_plan resource name in string form into a new
        /// <see cref="KeywordPlanName"/> instance.
        /// </summary>
        /// <param name="keywordPlanName">The keyword_plan resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordPlanName"/> if successful.</returns>
        public static KeywordPlanName Parse(string keywordPlanName)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanName, nameof(keywordPlanName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(keywordPlanName);
            return new KeywordPlanName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given keyword_plan resource name in string form into a new
        /// <see cref="KeywordPlanName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="keywordPlanName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="keywordPlanName">The keyword_plan resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="KeywordPlanName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanName, out KeywordPlanName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanName, nameof(keywordPlanName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(keywordPlanName, out resourceName))
            {
                result = new KeywordPlanName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="KeywordPlanName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="keywordPlanId">The keywordPlan ID. Must not be <c>null</c>.</param>
        public KeywordPlanName(string customerId, string keywordPlanId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            KeywordPlanId = gax::GaxPreconditions.CheckNotNull(keywordPlanId, nameof(keywordPlanId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The keywordPlan ID. Never <c>null</c>.
        /// </summary>
        public string KeywordPlanId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, KeywordPlanId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as KeywordPlanName);

        /// <inheritdoc />
        public bool Equals(KeywordPlanName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(KeywordPlanName a, KeywordPlanName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(KeywordPlanName a, KeywordPlanName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'keyword_plan_ad_group' resource.
    /// </summary>
    public sealed partial class KeywordPlanAdGroupName : gax::IResourceName, sys::IEquatable<KeywordPlanAdGroupName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}");

        /// <summary>
        /// Parses the given keyword_plan_ad_group resource name in string form into a new
        /// <see cref="KeywordPlanAdGroupName"/> instance.
        /// </summary>
        /// <param name="keywordPlanAdGroupName">The keyword_plan_ad_group resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordPlanAdGroupName"/> if successful.</returns>
        public static KeywordPlanAdGroupName Parse(string keywordPlanAdGroupName)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanAdGroupName, nameof(keywordPlanAdGroupName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(keywordPlanAdGroupName);
            return new KeywordPlanAdGroupName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given keyword_plan_ad_group resource name in string form into a new
        /// <see cref="KeywordPlanAdGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="keywordPlanAdGroupName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="keywordPlanAdGroupName">The keyword_plan_ad_group resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="KeywordPlanAdGroupName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanAdGroupName, out KeywordPlanAdGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanAdGroupName, nameof(keywordPlanAdGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(keywordPlanAdGroupName, out resourceName))
            {
                result = new KeywordPlanAdGroupName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="KeywordPlanAdGroupName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="keywordPlanAdGroupId">The keywordPlanAdGroup ID. Must not be <c>null</c>.</param>
        public KeywordPlanAdGroupName(string customerId, string keywordPlanAdGroupId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            KeywordPlanAdGroupId = gax::GaxPreconditions.CheckNotNull(keywordPlanAdGroupId, nameof(keywordPlanAdGroupId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The keywordPlanAdGroup ID. Never <c>null</c>.
        /// </summary>
        public string KeywordPlanAdGroupId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, KeywordPlanAdGroupId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as KeywordPlanAdGroupName);

        /// <inheritdoc />
        public bool Equals(KeywordPlanAdGroupName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(KeywordPlanAdGroupName a, KeywordPlanAdGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(KeywordPlanAdGroupName a, KeywordPlanAdGroupName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'keyword_plan_campaign' resource.
    /// </summary>
    public sealed partial class KeywordPlanCampaignName : gax::IResourceName, sys::IEquatable<KeywordPlanCampaignName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordPlanCampaigns/{keyword_plan_campaign}");

        /// <summary>
        /// Parses the given keyword_plan_campaign resource name in string form into a new
        /// <see cref="KeywordPlanCampaignName"/> instance.
        /// </summary>
        /// <param name="keywordPlanCampaignName">The keyword_plan_campaign resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordPlanCampaignName"/> if successful.</returns>
        public static KeywordPlanCampaignName Parse(string keywordPlanCampaignName)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanCampaignName, nameof(keywordPlanCampaignName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(keywordPlanCampaignName);
            return new KeywordPlanCampaignName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given keyword_plan_campaign resource name in string form into a new
        /// <see cref="KeywordPlanCampaignName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="keywordPlanCampaignName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="keywordPlanCampaignName">The keyword_plan_campaign resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="KeywordPlanCampaignName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanCampaignName, out KeywordPlanCampaignName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanCampaignName, nameof(keywordPlanCampaignName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(keywordPlanCampaignName, out resourceName))
            {
                result = new KeywordPlanCampaignName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="KeywordPlanCampaignName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="keywordPlanCampaignId">The keywordPlanCampaign ID. Must not be <c>null</c>.</param>
        public KeywordPlanCampaignName(string customerId, string keywordPlanCampaignId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            KeywordPlanCampaignId = gax::GaxPreconditions.CheckNotNull(keywordPlanCampaignId, nameof(keywordPlanCampaignId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The keywordPlanCampaign ID. Never <c>null</c>.
        /// </summary>
        public string KeywordPlanCampaignId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, KeywordPlanCampaignId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as KeywordPlanCampaignName);

        /// <inheritdoc />
        public bool Equals(KeywordPlanCampaignName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(KeywordPlanCampaignName a, KeywordPlanCampaignName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(KeywordPlanCampaignName a, KeywordPlanCampaignName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'keyword_plan_keyword' resource.
    /// </summary>
    public sealed partial class KeywordPlanKeywordName : gax::IResourceName, sys::IEquatable<KeywordPlanKeywordName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}");

        /// <summary>
        /// Parses the given keyword_plan_keyword resource name in string form into a new
        /// <see cref="KeywordPlanKeywordName"/> instance.
        /// </summary>
        /// <param name="keywordPlanKeywordName">The keyword_plan_keyword resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordPlanKeywordName"/> if successful.</returns>
        public static KeywordPlanKeywordName Parse(string keywordPlanKeywordName)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanKeywordName, nameof(keywordPlanKeywordName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(keywordPlanKeywordName);
            return new KeywordPlanKeywordName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given keyword_plan_keyword resource name in string form into a new
        /// <see cref="KeywordPlanKeywordName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="keywordPlanKeywordName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="keywordPlanKeywordName">The keyword_plan_keyword resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="KeywordPlanKeywordName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanKeywordName, out KeywordPlanKeywordName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanKeywordName, nameof(keywordPlanKeywordName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(keywordPlanKeywordName, out resourceName))
            {
                result = new KeywordPlanKeywordName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="KeywordPlanKeywordName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="keywordPlanKeywordId">The keywordPlanKeyword ID. Must not be <c>null</c>.</param>
        public KeywordPlanKeywordName(string customerId, string keywordPlanKeywordId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            KeywordPlanKeywordId = gax::GaxPreconditions.CheckNotNull(keywordPlanKeywordId, nameof(keywordPlanKeywordId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The keywordPlanKeyword ID. Never <c>null</c>.
        /// </summary>
        public string KeywordPlanKeywordId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, KeywordPlanKeywordId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as KeywordPlanKeywordName);

        /// <inheritdoc />
        public bool Equals(KeywordPlanKeywordName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(KeywordPlanKeywordName a, KeywordPlanKeywordName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(KeywordPlanKeywordName a, KeywordPlanKeywordName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'keyword_plan_negative_keyword' resource.
    /// </summary>
    public sealed partial class KeywordPlanNegativeKeywordName : gax::IResourceName, sys::IEquatable<KeywordPlanNegativeKeywordName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}");

        /// <summary>
        /// Parses the given keyword_plan_negative_keyword resource name in string form into a new
        /// <see cref="KeywordPlanNegativeKeywordName"/> instance.
        /// </summary>
        /// <param name="keywordPlanNegativeKeywordName">The keyword_plan_negative_keyword resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordPlanNegativeKeywordName"/> if successful.</returns>
        public static KeywordPlanNegativeKeywordName Parse(string keywordPlanNegativeKeywordName)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanNegativeKeywordName, nameof(keywordPlanNegativeKeywordName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(keywordPlanNegativeKeywordName);
            return new KeywordPlanNegativeKeywordName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given keyword_plan_negative_keyword resource name in string form into a new
        /// <see cref="KeywordPlanNegativeKeywordName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="keywordPlanNegativeKeywordName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="keywordPlanNegativeKeywordName">The keyword_plan_negative_keyword resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="KeywordPlanNegativeKeywordName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanNegativeKeywordName, out KeywordPlanNegativeKeywordName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanNegativeKeywordName, nameof(keywordPlanNegativeKeywordName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(keywordPlanNegativeKeywordName, out resourceName))
            {
                result = new KeywordPlanNegativeKeywordName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="KeywordPlanNegativeKeywordName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="keywordPlanNegativeKeywordId">The keywordPlanNegativeKeyword ID. Must not be <c>null</c>.</param>
        public KeywordPlanNegativeKeywordName(string customerId, string keywordPlanNegativeKeywordId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            KeywordPlanNegativeKeywordId = gax::GaxPreconditions.CheckNotNull(keywordPlanNegativeKeywordId, nameof(keywordPlanNegativeKeywordId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The keywordPlanNegativeKeyword ID. Never <c>null</c>.
        /// </summary>
        public string KeywordPlanNegativeKeywordId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, KeywordPlanNegativeKeywordId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as KeywordPlanNegativeKeywordName);

        /// <inheritdoc />
        public bool Equals(KeywordPlanNegativeKeywordName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(KeywordPlanNegativeKeywordName a, KeywordPlanNegativeKeywordName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(KeywordPlanNegativeKeywordName a, KeywordPlanNegativeKeywordName b) => !(a == b);
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
    /// Resource name for the 'language_constant' resource.
    /// </summary>
    public sealed partial class LanguageConstantName : gax::IResourceName, sys::IEquatable<LanguageConstantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("languageConstants/{language_constant}");

        /// <summary>
        /// Parses the given language_constant resource name in string form into a new
        /// <see cref="LanguageConstantName"/> instance.
        /// </summary>
        /// <param name="languageConstantName">The language_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LanguageConstantName"/> if successful.</returns>
        public static LanguageConstantName Parse(string languageConstantName)
        {
            gax::GaxPreconditions.CheckNotNull(languageConstantName, nameof(languageConstantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(languageConstantName);
            return new LanguageConstantName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given language_constant resource name in string form into a new
        /// <see cref="LanguageConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="languageConstantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="languageConstantName">The language_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LanguageConstantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string languageConstantName, out LanguageConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(languageConstantName, nameof(languageConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(languageConstantName, out resourceName))
            {
                result = new LanguageConstantName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LanguageConstantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="languageConstantId">The languageConstant ID. Must not be <c>null</c>.</param>
        public LanguageConstantName(string languageConstantId)
        {
            LanguageConstantId = gax::GaxPreconditions.CheckNotNull(languageConstantId, nameof(languageConstantId));
        }

        /// <summary>
        /// The languageConstant ID. Never <c>null</c>.
        /// </summary>
        public string LanguageConstantId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(LanguageConstantId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LanguageConstantName);

        /// <inheritdoc />
        public bool Equals(LanguageConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LanguageConstantName a, LanguageConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LanguageConstantName a, LanguageConstantName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'managed_placement_view' resource.
    /// </summary>
    public sealed partial class ManagedPlacementViewName : gax::IResourceName, sys::IEquatable<ManagedPlacementViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/managedPlacementViews/{managed_placement_view}");

        /// <summary>
        /// Parses the given managed_placement_view resource name in string form into a new
        /// <see cref="ManagedPlacementViewName"/> instance.
        /// </summary>
        /// <param name="managedPlacementViewName">The managed_placement_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ManagedPlacementViewName"/> if successful.</returns>
        public static ManagedPlacementViewName Parse(string managedPlacementViewName)
        {
            gax::GaxPreconditions.CheckNotNull(managedPlacementViewName, nameof(managedPlacementViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(managedPlacementViewName);
            return new ManagedPlacementViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given managed_placement_view resource name in string form into a new
        /// <see cref="ManagedPlacementViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="managedPlacementViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="managedPlacementViewName">The managed_placement_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ManagedPlacementViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string managedPlacementViewName, out ManagedPlacementViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(managedPlacementViewName, nameof(managedPlacementViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(managedPlacementViewName, out resourceName))
            {
                result = new ManagedPlacementViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ManagedPlacementViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="managedPlacementViewId">The managedPlacementView ID. Must not be <c>null</c>.</param>
        public ManagedPlacementViewName(string customerId, string managedPlacementViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            ManagedPlacementViewId = gax::GaxPreconditions.CheckNotNull(managedPlacementViewId, nameof(managedPlacementViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The managedPlacementView ID. Never <c>null</c>.
        /// </summary>
        public string ManagedPlacementViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, ManagedPlacementViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ManagedPlacementViewName);

        /// <inheritdoc />
        public bool Equals(ManagedPlacementViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ManagedPlacementViewName a, ManagedPlacementViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ManagedPlacementViewName a, ManagedPlacementViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'media_file' resource.
    /// </summary>
    public sealed partial class MediaFileName : gax::IResourceName, sys::IEquatable<MediaFileName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/mediaFiles/{media_file}");

        /// <summary>
        /// Parses the given media_file resource name in string form into a new
        /// <see cref="MediaFileName"/> instance.
        /// </summary>
        /// <param name="mediaFileName">The media_file resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MediaFileName"/> if successful.</returns>
        public static MediaFileName Parse(string mediaFileName)
        {
            gax::GaxPreconditions.CheckNotNull(mediaFileName, nameof(mediaFileName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(mediaFileName);
            return new MediaFileName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given media_file resource name in string form into a new
        /// <see cref="MediaFileName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="mediaFileName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="mediaFileName">The media_file resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MediaFileName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mediaFileName, out MediaFileName result)
        {
            gax::GaxPreconditions.CheckNotNull(mediaFileName, nameof(mediaFileName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(mediaFileName, out resourceName))
            {
                result = new MediaFileName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="MediaFileName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="mediaFileId">The mediaFile ID. Must not be <c>null</c>.</param>
        public MediaFileName(string customerId, string mediaFileId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            MediaFileId = gax::GaxPreconditions.CheckNotNull(mediaFileId, nameof(mediaFileId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The mediaFile ID. Never <c>null</c>.
        /// </summary>
        public string MediaFileId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, MediaFileId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as MediaFileName);

        /// <inheritdoc />
        public bool Equals(MediaFileName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(MediaFileName a, MediaFileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(MediaFileName a, MediaFileName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'parental_status_view' resource.
    /// </summary>
    public sealed partial class ParentalStatusViewName : gax::IResourceName, sys::IEquatable<ParentalStatusViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/parentalStatusViews/{parental_status_view}");

        /// <summary>
        /// Parses the given parental_status_view resource name in string form into a new
        /// <see cref="ParentalStatusViewName"/> instance.
        /// </summary>
        /// <param name="parentalStatusViewName">The parental_status_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ParentalStatusViewName"/> if successful.</returns>
        public static ParentalStatusViewName Parse(string parentalStatusViewName)
        {
            gax::GaxPreconditions.CheckNotNull(parentalStatusViewName, nameof(parentalStatusViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(parentalStatusViewName);
            return new ParentalStatusViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given parental_status_view resource name in string form into a new
        /// <see cref="ParentalStatusViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="parentalStatusViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="parentalStatusViewName">The parental_status_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ParentalStatusViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string parentalStatusViewName, out ParentalStatusViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(parentalStatusViewName, nameof(parentalStatusViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(parentalStatusViewName, out resourceName))
            {
                result = new ParentalStatusViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ParentalStatusViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="parentalStatusViewId">The parentalStatusView ID. Must not be <c>null</c>.</param>
        public ParentalStatusViewName(string customerId, string parentalStatusViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            ParentalStatusViewId = gax::GaxPreconditions.CheckNotNull(parentalStatusViewId, nameof(parentalStatusViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The parentalStatusView ID. Never <c>null</c>.
        /// </summary>
        public string ParentalStatusViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, ParentalStatusViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ParentalStatusViewName);

        /// <inheritdoc />
        public bool Equals(ParentalStatusViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ParentalStatusViewName a, ParentalStatusViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ParentalStatusViewName a, ParentalStatusViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'product_group_view' resource.
    /// </summary>
    public sealed partial class ProductGroupViewName : gax::IResourceName, sys::IEquatable<ProductGroupViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/productGroupViews/{product_group_view}");

        /// <summary>
        /// Parses the given product_group_view resource name in string form into a new
        /// <see cref="ProductGroupViewName"/> instance.
        /// </summary>
        /// <param name="productGroupViewName">The product_group_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProductGroupViewName"/> if successful.</returns>
        public static ProductGroupViewName Parse(string productGroupViewName)
        {
            gax::GaxPreconditions.CheckNotNull(productGroupViewName, nameof(productGroupViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(productGroupViewName);
            return new ProductGroupViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given product_group_view resource name in string form into a new
        /// <see cref="ProductGroupViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="productGroupViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="productGroupViewName">The product_group_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProductGroupViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productGroupViewName, out ProductGroupViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(productGroupViewName, nameof(productGroupViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(productGroupViewName, out resourceName))
            {
                result = new ProductGroupViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ProductGroupViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="productGroupViewId">The productGroupView ID. Must not be <c>null</c>.</param>
        public ProductGroupViewName(string customerId, string productGroupViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            ProductGroupViewId = gax::GaxPreconditions.CheckNotNull(productGroupViewId, nameof(productGroupViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The productGroupView ID. Never <c>null</c>.
        /// </summary>
        public string ProductGroupViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, ProductGroupViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProductGroupViewName);

        /// <inheritdoc />
        public bool Equals(ProductGroupViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProductGroupViewName a, ProductGroupViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProductGroupViewName a, ProductGroupViewName b) => !(a == b);
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
    /// Resource name for the 'search_term_view' resource.
    /// </summary>
    public sealed partial class SearchTermViewName : gax::IResourceName, sys::IEquatable<SearchTermViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/searchTermViews/{search_term_view}");

        /// <summary>
        /// Parses the given search_term_view resource name in string form into a new
        /// <see cref="SearchTermViewName"/> instance.
        /// </summary>
        /// <param name="searchTermViewName">The search_term_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SearchTermViewName"/> if successful.</returns>
        public static SearchTermViewName Parse(string searchTermViewName)
        {
            gax::GaxPreconditions.CheckNotNull(searchTermViewName, nameof(searchTermViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(searchTermViewName);
            return new SearchTermViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given search_term_view resource name in string form into a new
        /// <see cref="SearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="searchTermViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="searchTermViewName">The search_term_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="SearchTermViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchTermViewName, out SearchTermViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(searchTermViewName, nameof(searchTermViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(searchTermViewName, out resourceName))
            {
                result = new SearchTermViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="SearchTermViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="searchTermViewId">The searchTermView ID. Must not be <c>null</c>.</param>
        public SearchTermViewName(string customerId, string searchTermViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            SearchTermViewId = gax::GaxPreconditions.CheckNotNull(searchTermViewId, nameof(searchTermViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The searchTermView ID. Never <c>null</c>.
        /// </summary>
        public string SearchTermViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, SearchTermViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as SearchTermViewName);

        /// <inheritdoc />
        public bool Equals(SearchTermViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(SearchTermViewName a, SearchTermViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(SearchTermViewName a, SearchTermViewName b) => !(a == b);
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

    /// <summary>
    /// Resource name for the 'topic_constant' resource.
    /// </summary>
    public sealed partial class TopicConstantName : gax::IResourceName, sys::IEquatable<TopicConstantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("topicConstants/{topic_constant}");

        /// <summary>
        /// Parses the given topic_constant resource name in string form into a new
        /// <see cref="TopicConstantName"/> instance.
        /// </summary>
        /// <param name="topicConstantName">The topic_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicConstantName"/> if successful.</returns>
        public static TopicConstantName Parse(string topicConstantName)
        {
            gax::GaxPreconditions.CheckNotNull(topicConstantName, nameof(topicConstantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(topicConstantName);
            return new TopicConstantName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given topic_constant resource name in string form into a new
        /// <see cref="TopicConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="topicConstantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="topicConstantName">The topic_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TopicConstantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicConstantName, out TopicConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(topicConstantName, nameof(topicConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(topicConstantName, out resourceName))
            {
                result = new TopicConstantName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="TopicConstantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="topicConstantId">The topicConstant ID. Must not be <c>null</c>.</param>
        public TopicConstantName(string topicConstantId)
        {
            TopicConstantId = gax::GaxPreconditions.CheckNotNull(topicConstantId, nameof(topicConstantId));
        }

        /// <summary>
        /// The topicConstant ID. Never <c>null</c>.
        /// </summary>
        public string TopicConstantId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(TopicConstantId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TopicConstantName);

        /// <inheritdoc />
        public bool Equals(TopicConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TopicConstantName a, TopicConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TopicConstantName a, TopicConstantName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'topic_view' resource.
    /// </summary>
    public sealed partial class TopicViewName : gax::IResourceName, sys::IEquatable<TopicViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/topicViews/{topic_view}");

        /// <summary>
        /// Parses the given topic_view resource name in string form into a new
        /// <see cref="TopicViewName"/> instance.
        /// </summary>
        /// <param name="topicViewName">The topic_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicViewName"/> if successful.</returns>
        public static TopicViewName Parse(string topicViewName)
        {
            gax::GaxPreconditions.CheckNotNull(topicViewName, nameof(topicViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(topicViewName);
            return new TopicViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given topic_view resource name in string form into a new
        /// <see cref="TopicViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="topicViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="topicViewName">The topic_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="TopicViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicViewName, out TopicViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(topicViewName, nameof(topicViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(topicViewName, out resourceName))
            {
                result = new TopicViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="TopicViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="topicViewId">The topicView ID. Must not be <c>null</c>.</param>
        public TopicViewName(string customerId, string topicViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            TopicViewId = gax::GaxPreconditions.CheckNotNull(topicViewId, nameof(topicViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The topicView ID. Never <c>null</c>.
        /// </summary>
        public string TopicViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, TopicViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as TopicViewName);

        /// <inheritdoc />
        public bool Equals(TopicViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(TopicViewName a, TopicViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(TopicViewName a, TopicViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'user_interest' resource.
    /// </summary>
    public sealed partial class UserInterestName : gax::IResourceName, sys::IEquatable<UserInterestName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/userInterests/{user_interest}");

        /// <summary>
        /// Parses the given user_interest resource name in string form into a new
        /// <see cref="UserInterestName"/> instance.
        /// </summary>
        /// <param name="userInterestName">The user_interest resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserInterestName"/> if successful.</returns>
        public static UserInterestName Parse(string userInterestName)
        {
            gax::GaxPreconditions.CheckNotNull(userInterestName, nameof(userInterestName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(userInterestName);
            return new UserInterestName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given user_interest resource name in string form into a new
        /// <see cref="UserInterestName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="userInterestName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="userInterestName">The user_interest resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="UserInterestName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userInterestName, out UserInterestName result)
        {
            gax::GaxPreconditions.CheckNotNull(userInterestName, nameof(userInterestName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(userInterestName, out resourceName))
            {
                result = new UserInterestName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="UserInterestName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="userInterestId">The userInterest ID. Must not be <c>null</c>.</param>
        public UserInterestName(string customerId, string userInterestId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            UserInterestId = gax::GaxPreconditions.CheckNotNull(userInterestId, nameof(userInterestId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The userInterest ID. Never <c>null</c>.
        /// </summary>
        public string UserInterestId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, UserInterestId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as UserInterestName);

        /// <inheritdoc />
        public bool Equals(UserInterestName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(UserInterestName a, UserInterestName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(UserInterestName a, UserInterestName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'user_list' resource.
    /// </summary>
    public sealed partial class UserListName : gax::IResourceName, sys::IEquatable<UserListName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/userLists/{user_list}");

        /// <summary>
        /// Parses the given user_list resource name in string form into a new
        /// <see cref="UserListName"/> instance.
        /// </summary>
        /// <param name="userListName">The user_list resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserListName"/> if successful.</returns>
        public static UserListName Parse(string userListName)
        {
            gax::GaxPreconditions.CheckNotNull(userListName, nameof(userListName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(userListName);
            return new UserListName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given user_list resource name in string form into a new
        /// <see cref="UserListName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="userListName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="userListName">The user_list resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="UserListName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userListName, out UserListName result)
        {
            gax::GaxPreconditions.CheckNotNull(userListName, nameof(userListName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(userListName, out resourceName))
            {
                result = new UserListName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="UserListName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="userListId">The userList ID. Must not be <c>null</c>.</param>
        public UserListName(string customerId, string userListId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            UserListId = gax::GaxPreconditions.CheckNotNull(userListId, nameof(userListId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The userList ID. Never <c>null</c>.
        /// </summary>
        public string UserListId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, UserListId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as UserListName);

        /// <inheritdoc />
        public bool Equals(UserListName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(UserListName a, UserListName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(UserListName a, UserListName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'video' resource.
    /// </summary>
    public sealed partial class VideoName : gax::IResourceName, sys::IEquatable<VideoName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/videos/{video}");

        /// <summary>
        /// Parses the given video resource name in string form into a new
        /// <see cref="VideoName"/> instance.
        /// </summary>
        /// <param name="videoName">The video resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VideoName"/> if successful.</returns>
        public static VideoName Parse(string videoName)
        {
            gax::GaxPreconditions.CheckNotNull(videoName, nameof(videoName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(videoName);
            return new VideoName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given video resource name in string form into a new
        /// <see cref="VideoName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="videoName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="videoName">The video resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="VideoName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string videoName, out VideoName result)
        {
            gax::GaxPreconditions.CheckNotNull(videoName, nameof(videoName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(videoName, out resourceName))
            {
                result = new VideoName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="VideoName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="videoId">The video ID. Must not be <c>null</c>.</param>
        public VideoName(string customerId, string videoId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            VideoId = gax::GaxPreconditions.CheckNotNull(videoId, nameof(videoId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The video ID. Never <c>null</c>.
        /// </summary>
        public string VideoId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, VideoId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as VideoName);

        /// <inheritdoc />
        public bool Equals(VideoName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(VideoName a, VideoName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(VideoName a, VideoName b) => !(a == b);
    }



}
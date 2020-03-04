// Copyright 2019 Google LLC
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

namespace Google.Ads.GoogleAds.V3.Services
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
    /// Resource name for the 'ad' resource.
    /// </summary>
    public sealed partial class AdName : gax::IResourceName, sys::IEquatable<AdName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/ads/{ad}");

        /// <summary>
        /// Parses the given ad resource name in string form into a new
        /// <see cref="AdName"/> instance.
        /// </summary>
        /// <param name="adName">The ad resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdName"/> if successful.</returns>
        public static AdName Parse(string adName)
        {
            gax::GaxPreconditions.CheckNotNull(adName, nameof(adName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adName);
            return new AdName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad resource name in string form into a new
        /// <see cref="AdName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adName">The ad resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adName, out AdName result)
        {
            gax::GaxPreconditions.CheckNotNull(adName, nameof(adName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adName, out resourceName))
            {
                result = new AdName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adId">The ad ID. Must not be <c>null</c>.</param>
        public AdName(string customerId, string adId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdId = gax::GaxPreconditions.CheckNotNull(adId, nameof(adId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The ad ID. Never <c>null</c>.
        /// </summary>
        public string AdId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdName);

        /// <inheritdoc />
        public bool Equals(AdName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdName a, AdName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdName a, AdName b) => !(a == b);
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
    /// Resource name for the 'ad_group_ad_asset_view' resource.
    /// </summary>
    public sealed partial class AdGroupAdAssetViewName : gax::IResourceName, sys::IEquatable<AdGroupAdAssetViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}");

        /// <summary>
        /// Parses the given ad_group_ad_asset_view resource name in string form into a new
        /// <see cref="AdGroupAdAssetViewName"/> instance.
        /// </summary>
        /// <param name="adGroupAdAssetViewName">The ad_group_ad_asset_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupAdAssetViewName"/> if successful.</returns>
        public static AdGroupAdAssetViewName Parse(string adGroupAdAssetViewName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAdAssetViewName, nameof(adGroupAdAssetViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupAdAssetViewName);
            return new AdGroupAdAssetViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_ad_asset_view resource name in string form into a new
        /// <see cref="AdGroupAdAssetViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupAdAssetViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupAdAssetViewName">The ad_group_ad_asset_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupAdAssetViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdAssetViewName, out AdGroupAdAssetViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAdAssetViewName, nameof(adGroupAdAssetViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupAdAssetViewName, out resourceName))
            {
                result = new AdGroupAdAssetViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupAdAssetViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupAdAssetViewId">The adGroupAdAssetView ID. Must not be <c>null</c>.</param>
        public AdGroupAdAssetViewName(string customerId, string adGroupAdAssetViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupAdAssetViewId = gax::GaxPreconditions.CheckNotNull(adGroupAdAssetViewId, nameof(adGroupAdAssetViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupAdAssetView ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupAdAssetViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupAdAssetViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupAdAssetViewName);

        /// <inheritdoc />
        public bool Equals(AdGroupAdAssetViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupAdAssetViewName a, AdGroupAdAssetViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupAdAssetViewName a, AdGroupAdAssetViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'ad_group_ad_label' resource.
    /// </summary>
    public sealed partial class AdGroupAdLabelName : gax::IResourceName, sys::IEquatable<AdGroupAdLabelName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupAdLabels/{ad_group_ad_label}");

        /// <summary>
        /// Parses the given ad_group_ad_label resource name in string form into a new
        /// <see cref="AdGroupAdLabelName"/> instance.
        /// </summary>
        /// <param name="adGroupAdLabelName">The ad_group_ad_label resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupAdLabelName"/> if successful.</returns>
        public static AdGroupAdLabelName Parse(string adGroupAdLabelName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAdLabelName, nameof(adGroupAdLabelName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupAdLabelName);
            return new AdGroupAdLabelName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_ad_label resource name in string form into a new
        /// <see cref="AdGroupAdLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupAdLabelName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupAdLabelName">The ad_group_ad_label resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupAdLabelName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdLabelName, out AdGroupAdLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAdLabelName, nameof(adGroupAdLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupAdLabelName, out resourceName))
            {
                result = new AdGroupAdLabelName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupAdLabelName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupAdLabelId">The adGroupAdLabel ID. Must not be <c>null</c>.</param>
        public AdGroupAdLabelName(string customerId, string adGroupAdLabelId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupAdLabelId = gax::GaxPreconditions.CheckNotNull(adGroupAdLabelId, nameof(adGroupAdLabelId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupAdLabel ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupAdLabelId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupAdLabelId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupAdLabelName);

        /// <inheritdoc />
        public bool Equals(AdGroupAdLabelName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupAdLabelName a, AdGroupAdLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupAdLabelName a, AdGroupAdLabelName b) => !(a == b);
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
    /// Resource name for the 'ad_group_criterion_label' resource.
    /// </summary>
    public sealed partial class AdGroupCriterionLabelName : gax::IResourceName, sys::IEquatable<AdGroupCriterionLabelName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}");

        /// <summary>
        /// Parses the given ad_group_criterion_label resource name in string form into a new
        /// <see cref="AdGroupCriterionLabelName"/> instance.
        /// </summary>
        /// <param name="adGroupCriterionLabelName">The ad_group_criterion_label resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupCriterionLabelName"/> if successful.</returns>
        public static AdGroupCriterionLabelName Parse(string adGroupCriterionLabelName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupCriterionLabelName, nameof(adGroupCriterionLabelName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupCriterionLabelName);
            return new AdGroupCriterionLabelName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_criterion_label resource name in string form into a new
        /// <see cref="AdGroupCriterionLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupCriterionLabelName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupCriterionLabelName">The ad_group_criterion_label resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupCriterionLabelName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupCriterionLabelName, out AdGroupCriterionLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupCriterionLabelName, nameof(adGroupCriterionLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupCriterionLabelName, out resourceName))
            {
                result = new AdGroupCriterionLabelName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupCriterionLabelName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupCriterionLabelId">The adGroupCriterionLabel ID. Must not be <c>null</c>.</param>
        public AdGroupCriterionLabelName(string customerId, string adGroupCriterionLabelId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupCriterionLabelId = gax::GaxPreconditions.CheckNotNull(adGroupCriterionLabelId, nameof(adGroupCriterionLabelId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupCriterionLabel ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupCriterionLabelId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupCriterionLabelId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupCriterionLabelName);

        /// <inheritdoc />
        public bool Equals(AdGroupCriterionLabelName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupCriterionLabelName a, AdGroupCriterionLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupCriterionLabelName a, AdGroupCriterionLabelName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'ad_group_criterion_simulation' resource.
    /// </summary>
    public sealed partial class AdGroupCriterionSimulationName : gax::IResourceName, sys::IEquatable<AdGroupCriterionSimulationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupCriterionSimulations/{ad_group_criterion_simulation}");

        /// <summary>
        /// Parses the given ad_group_criterion_simulation resource name in string form into a new
        /// <see cref="AdGroupCriterionSimulationName"/> instance.
        /// </summary>
        /// <param name="adGroupCriterionSimulationName">The ad_group_criterion_simulation resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupCriterionSimulationName"/> if successful.</returns>
        public static AdGroupCriterionSimulationName Parse(string adGroupCriterionSimulationName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupCriterionSimulationName, nameof(adGroupCriterionSimulationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupCriterionSimulationName);
            return new AdGroupCriterionSimulationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_criterion_simulation resource name in string form into a new
        /// <see cref="AdGroupCriterionSimulationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupCriterionSimulationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupCriterionSimulationName">The ad_group_criterion_simulation resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupCriterionSimulationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupCriterionSimulationName, out AdGroupCriterionSimulationName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupCriterionSimulationName, nameof(adGroupCriterionSimulationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupCriterionSimulationName, out resourceName))
            {
                result = new AdGroupCriterionSimulationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupCriterionSimulationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupCriterionSimulationId">The adGroupCriterionSimulation ID. Must not be <c>null</c>.</param>
        public AdGroupCriterionSimulationName(string customerId, string adGroupCriterionSimulationId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupCriterionSimulationId = gax::GaxPreconditions.CheckNotNull(adGroupCriterionSimulationId, nameof(adGroupCriterionSimulationId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupCriterionSimulation ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupCriterionSimulationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupCriterionSimulationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupCriterionSimulationName);

        /// <inheritdoc />
        public bool Equals(AdGroupCriterionSimulationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupCriterionSimulationName a, AdGroupCriterionSimulationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupCriterionSimulationName a, AdGroupCriterionSimulationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'ad_group_extension_setting' resource.
    /// </summary>
    public sealed partial class AdGroupExtensionSettingName : gax::IResourceName, sys::IEquatable<AdGroupExtensionSettingName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupExtensionSettings/{ad_group_extension_setting}");

        /// <summary>
        /// Parses the given ad_group_extension_setting resource name in string form into a new
        /// <see cref="AdGroupExtensionSettingName"/> instance.
        /// </summary>
        /// <param name="adGroupExtensionSettingName">The ad_group_extension_setting resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupExtensionSettingName"/> if successful.</returns>
        public static AdGroupExtensionSettingName Parse(string adGroupExtensionSettingName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupExtensionSettingName, nameof(adGroupExtensionSettingName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupExtensionSettingName);
            return new AdGroupExtensionSettingName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_extension_setting resource name in string form into a new
        /// <see cref="AdGroupExtensionSettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupExtensionSettingName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupExtensionSettingName">The ad_group_extension_setting resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupExtensionSettingName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupExtensionSettingName, out AdGroupExtensionSettingName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupExtensionSettingName, nameof(adGroupExtensionSettingName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupExtensionSettingName, out resourceName))
            {
                result = new AdGroupExtensionSettingName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupExtensionSettingName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupExtensionSettingId">The adGroupExtensionSetting ID. Must not be <c>null</c>.</param>
        public AdGroupExtensionSettingName(string customerId, string adGroupExtensionSettingId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupExtensionSettingId = gax::GaxPreconditions.CheckNotNull(adGroupExtensionSettingId, nameof(adGroupExtensionSettingId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupExtensionSetting ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupExtensionSettingId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupExtensionSettingId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupExtensionSettingName);

        /// <inheritdoc />
        public bool Equals(AdGroupExtensionSettingName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupExtensionSettingName a, AdGroupExtensionSettingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupExtensionSettingName a, AdGroupExtensionSettingName b) => !(a == b);
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
    /// Resource name for the 'ad_group_label' resource.
    /// </summary>
    public sealed partial class AdGroupLabelName : gax::IResourceName, sys::IEquatable<AdGroupLabelName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupLabels/{ad_group_label}");

        /// <summary>
        /// Parses the given ad_group_label resource name in string form into a new
        /// <see cref="AdGroupLabelName"/> instance.
        /// </summary>
        /// <param name="adGroupLabelName">The ad_group_label resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupLabelName"/> if successful.</returns>
        public static AdGroupLabelName Parse(string adGroupLabelName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupLabelName, nameof(adGroupLabelName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupLabelName);
            return new AdGroupLabelName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_label resource name in string form into a new
        /// <see cref="AdGroupLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupLabelName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupLabelName">The ad_group_label resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupLabelName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupLabelName, out AdGroupLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupLabelName, nameof(adGroupLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupLabelName, out resourceName))
            {
                result = new AdGroupLabelName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupLabelName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupLabelId">The adGroupLabel ID. Must not be <c>null</c>.</param>
        public AdGroupLabelName(string customerId, string adGroupLabelId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupLabelId = gax::GaxPreconditions.CheckNotNull(adGroupLabelId, nameof(adGroupLabelId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupLabel ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupLabelId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupLabelId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupLabelName);

        /// <inheritdoc />
        public bool Equals(AdGroupLabelName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupLabelName a, AdGroupLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupLabelName a, AdGroupLabelName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'ad_group_simulation' resource.
    /// </summary>
    public sealed partial class AdGroupSimulationName : gax::IResourceName, sys::IEquatable<AdGroupSimulationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adGroupSimulations/{ad_group_simulation}");

        /// <summary>
        /// Parses the given ad_group_simulation resource name in string form into a new
        /// <see cref="AdGroupSimulationName"/> instance.
        /// </summary>
        /// <param name="adGroupSimulationName">The ad_group_simulation resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupSimulationName"/> if successful.</returns>
        public static AdGroupSimulationName Parse(string adGroupSimulationName)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupSimulationName, nameof(adGroupSimulationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adGroupSimulationName);
            return new AdGroupSimulationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_group_simulation resource name in string form into a new
        /// <see cref="AdGroupSimulationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adGroupSimulationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adGroupSimulationName">The ad_group_simulation resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdGroupSimulationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupSimulationName, out AdGroupSimulationName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupSimulationName, nameof(adGroupSimulationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adGroupSimulationName, out resourceName))
            {
                result = new AdGroupSimulationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdGroupSimulationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adGroupSimulationId">The adGroupSimulation ID. Must not be <c>null</c>.</param>
        public AdGroupSimulationName(string customerId, string adGroupSimulationId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdGroupSimulationId = gax::GaxPreconditions.CheckNotNull(adGroupSimulationId, nameof(adGroupSimulationId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adGroupSimulation ID. Never <c>null</c>.
        /// </summary>
        public string AdGroupSimulationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdGroupSimulationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdGroupSimulationName);

        /// <inheritdoc />
        public bool Equals(AdGroupSimulationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdGroupSimulationName a, AdGroupSimulationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdGroupSimulationName a, AdGroupSimulationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'ad_parameter' resource.
    /// </summary>
    public sealed partial class AdParameterName : gax::IResourceName, sys::IEquatable<AdParameterName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adParameters/{ad_parameter}");

        /// <summary>
        /// Parses the given ad_parameter resource name in string form into a new
        /// <see cref="AdParameterName"/> instance.
        /// </summary>
        /// <param name="adParameterName">The ad_parameter resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdParameterName"/> if successful.</returns>
        public static AdParameterName Parse(string adParameterName)
        {
            gax::GaxPreconditions.CheckNotNull(adParameterName, nameof(adParameterName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adParameterName);
            return new AdParameterName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_parameter resource name in string form into a new
        /// <see cref="AdParameterName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adParameterName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adParameterName">The ad_parameter resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdParameterName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adParameterName, out AdParameterName result)
        {
            gax::GaxPreconditions.CheckNotNull(adParameterName, nameof(adParameterName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adParameterName, out resourceName))
            {
                result = new AdParameterName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdParameterName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adParameterId">The adParameter ID. Must not be <c>null</c>.</param>
        public AdParameterName(string customerId, string adParameterId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdParameterId = gax::GaxPreconditions.CheckNotNull(adParameterId, nameof(adParameterId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adParameter ID. Never <c>null</c>.
        /// </summary>
        public string AdParameterId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdParameterId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdParameterName);

        /// <inheritdoc />
        public bool Equals(AdParameterName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdParameterName a, AdParameterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdParameterName a, AdParameterName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'ad_schedule_view' resource.
    /// </summary>
    public sealed partial class AdScheduleViewName : gax::IResourceName, sys::IEquatable<AdScheduleViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/adScheduleViews/{ad_schedule_view}");

        /// <summary>
        /// Parses the given ad_schedule_view resource name in string form into a new
        /// <see cref="AdScheduleViewName"/> instance.
        /// </summary>
        /// <param name="adScheduleViewName">The ad_schedule_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdScheduleViewName"/> if successful.</returns>
        public static AdScheduleViewName Parse(string adScheduleViewName)
        {
            gax::GaxPreconditions.CheckNotNull(adScheduleViewName, nameof(adScheduleViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(adScheduleViewName);
            return new AdScheduleViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given ad_schedule_view resource name in string form into a new
        /// <see cref="AdScheduleViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="adScheduleViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="adScheduleViewName">The ad_schedule_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AdScheduleViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adScheduleViewName, out AdScheduleViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(adScheduleViewName, nameof(adScheduleViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(adScheduleViewName, out resourceName))
            {
                result = new AdScheduleViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AdScheduleViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="adScheduleViewId">The adScheduleView ID. Must not be <c>null</c>.</param>
        public AdScheduleViewName(string customerId, string adScheduleViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AdScheduleViewId = gax::GaxPreconditions.CheckNotNull(adScheduleViewId, nameof(adScheduleViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The adScheduleView ID. Never <c>null</c>.
        /// </summary>
        public string AdScheduleViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AdScheduleViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AdScheduleViewName);

        /// <inheritdoc />
        public bool Equals(AdScheduleViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AdScheduleViewName a, AdScheduleViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AdScheduleViewName a, AdScheduleViewName b) => !(a == b);
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
    /// Resource name for the 'asset' resource.
    /// </summary>
    public sealed partial class AssetName : gax::IResourceName, sys::IEquatable<AssetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/assets/{asset}");

        /// <summary>
        /// Parses the given asset resource name in string form into a new
        /// <see cref="AssetName"/> instance.
        /// </summary>
        /// <param name="assetName">The asset resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetName"/> if successful.</returns>
        public static AssetName Parse(string assetName)
        {
            gax::GaxPreconditions.CheckNotNull(assetName, nameof(assetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(assetName);
            return new AssetName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given asset resource name in string form into a new
        /// <see cref="AssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="assetName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="assetName">The asset resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="AssetName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetName, out AssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetName, nameof(assetName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(assetName, out resourceName))
            {
                result = new AssetName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="AssetName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="assetId">The asset ID. Must not be <c>null</c>.</param>
        public AssetName(string customerId, string assetId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            AssetId = gax::GaxPreconditions.CheckNotNull(assetId, nameof(assetId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The asset ID. Never <c>null</c>.
        /// </summary>
        public string AssetId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, AssetId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as AssetName);

        /// <inheritdoc />
        public bool Equals(AssetName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(AssetName a, AssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(AssetName a, AssetName b) => !(a == b);
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
    /// Resource name for the 'campaign_criterion_simulation' resource.
    /// </summary>
    public sealed partial class CampaignCriterionSimulationName : gax::IResourceName, sys::IEquatable<CampaignCriterionSimulationName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}");

        /// <summary>
        /// Parses the given campaign_criterion_simulation resource name in string form into a new
        /// <see cref="CampaignCriterionSimulationName"/> instance.
        /// </summary>
        /// <param name="campaignCriterionSimulationName">The campaign_criterion_simulation resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignCriterionSimulationName"/> if successful.</returns>
        public static CampaignCriterionSimulationName Parse(string campaignCriterionSimulationName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignCriterionSimulationName, nameof(campaignCriterionSimulationName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignCriterionSimulationName);
            return new CampaignCriterionSimulationName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_criterion_simulation resource name in string form into a new
        /// <see cref="CampaignCriterionSimulationName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignCriterionSimulationName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignCriterionSimulationName">The campaign_criterion_simulation resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignCriterionSimulationName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignCriterionSimulationName, out CampaignCriterionSimulationName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignCriterionSimulationName, nameof(campaignCriterionSimulationName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignCriterionSimulationName, out resourceName))
            {
                result = new CampaignCriterionSimulationName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignCriterionSimulationName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignCriterionSimulationId">The campaignCriterionSimulation ID. Must not be <c>null</c>.</param>
        public CampaignCriterionSimulationName(string customerId, string campaignCriterionSimulationId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignCriterionSimulationId = gax::GaxPreconditions.CheckNotNull(campaignCriterionSimulationId, nameof(campaignCriterionSimulationId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignCriterionSimulation ID. Never <c>null</c>.
        /// </summary>
        public string CampaignCriterionSimulationId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignCriterionSimulationId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignCriterionSimulationName);

        /// <inheritdoc />
        public bool Equals(CampaignCriterionSimulationName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignCriterionSimulationName a, CampaignCriterionSimulationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignCriterionSimulationName a, CampaignCriterionSimulationName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'campaign_draft' resource.
    /// </summary>
    public sealed partial class CampaignDraftName : gax::IResourceName, sys::IEquatable<CampaignDraftName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignDrafts/{campaign_draft}");

        /// <summary>
        /// Parses the given campaign_draft resource name in string form into a new
        /// <see cref="CampaignDraftName"/> instance.
        /// </summary>
        /// <param name="campaignDraftName">The campaign_draft resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignDraftName"/> if successful.</returns>
        public static CampaignDraftName Parse(string campaignDraftName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignDraftName, nameof(campaignDraftName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignDraftName);
            return new CampaignDraftName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_draft resource name in string form into a new
        /// <see cref="CampaignDraftName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignDraftName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignDraftName">The campaign_draft resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignDraftName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignDraftName, out CampaignDraftName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignDraftName, nameof(campaignDraftName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignDraftName, out resourceName))
            {
                result = new CampaignDraftName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignDraftName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignDraftId">The campaignDraft ID. Must not be <c>null</c>.</param>
        public CampaignDraftName(string customerId, string campaignDraftId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignDraftId = gax::GaxPreconditions.CheckNotNull(campaignDraftId, nameof(campaignDraftId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignDraft ID. Never <c>null</c>.
        /// </summary>
        public string CampaignDraftId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignDraftId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignDraftName);

        /// <inheritdoc />
        public bool Equals(CampaignDraftName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignDraftName a, CampaignDraftName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignDraftName a, CampaignDraftName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'campaign_experiment' resource.
    /// </summary>
    public sealed partial class CampaignExperimentName : gax::IResourceName, sys::IEquatable<CampaignExperimentName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignExperiments/{campaign_experiment}");

        /// <summary>
        /// Parses the given campaign_experiment resource name in string form into a new
        /// <see cref="CampaignExperimentName"/> instance.
        /// </summary>
        /// <param name="campaignExperimentName">The campaign_experiment resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignExperimentName"/> if successful.</returns>
        public static CampaignExperimentName Parse(string campaignExperimentName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignExperimentName, nameof(campaignExperimentName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignExperimentName);
            return new CampaignExperimentName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_experiment resource name in string form into a new
        /// <see cref="CampaignExperimentName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignExperimentName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignExperimentName">The campaign_experiment resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignExperimentName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignExperimentName, out CampaignExperimentName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignExperimentName, nameof(campaignExperimentName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignExperimentName, out resourceName))
            {
                result = new CampaignExperimentName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignExperimentName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignExperimentId">The campaignExperiment ID. Must not be <c>null</c>.</param>
        public CampaignExperimentName(string customerId, string campaignExperimentId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignExperimentId = gax::GaxPreconditions.CheckNotNull(campaignExperimentId, nameof(campaignExperimentId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignExperiment ID. Never <c>null</c>.
        /// </summary>
        public string CampaignExperimentId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignExperimentId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignExperimentName);

        /// <inheritdoc />
        public bool Equals(CampaignExperimentName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignExperimentName a, CampaignExperimentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignExperimentName a, CampaignExperimentName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'campaign_extension_setting' resource.
    /// </summary>
    public sealed partial class CampaignExtensionSettingName : gax::IResourceName, sys::IEquatable<CampaignExtensionSettingName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignExtensionSettings/{campaign_extension_setting}");

        /// <summary>
        /// Parses the given campaign_extension_setting resource name in string form into a new
        /// <see cref="CampaignExtensionSettingName"/> instance.
        /// </summary>
        /// <param name="campaignExtensionSettingName">The campaign_extension_setting resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignExtensionSettingName"/> if successful.</returns>
        public static CampaignExtensionSettingName Parse(string campaignExtensionSettingName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignExtensionSettingName, nameof(campaignExtensionSettingName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignExtensionSettingName);
            return new CampaignExtensionSettingName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_extension_setting resource name in string form into a new
        /// <see cref="CampaignExtensionSettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignExtensionSettingName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignExtensionSettingName">The campaign_extension_setting resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignExtensionSettingName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignExtensionSettingName, out CampaignExtensionSettingName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignExtensionSettingName, nameof(campaignExtensionSettingName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignExtensionSettingName, out resourceName))
            {
                result = new CampaignExtensionSettingName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignExtensionSettingName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignExtensionSettingId">The campaignExtensionSetting ID. Must not be <c>null</c>.</param>
        public CampaignExtensionSettingName(string customerId, string campaignExtensionSettingId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignExtensionSettingId = gax::GaxPreconditions.CheckNotNull(campaignExtensionSettingId, nameof(campaignExtensionSettingId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignExtensionSetting ID. Never <c>null</c>.
        /// </summary>
        public string CampaignExtensionSettingId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignExtensionSettingId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignExtensionSettingName);

        /// <inheritdoc />
        public bool Equals(CampaignExtensionSettingName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignExtensionSettingName a, CampaignExtensionSettingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignExtensionSettingName a, CampaignExtensionSettingName b) => !(a == b);
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
    /// Resource name for the 'campaign_label' resource.
    /// </summary>
    public sealed partial class CampaignLabelName : gax::IResourceName, sys::IEquatable<CampaignLabelName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/campaignLabels/{campaign_label}");

        /// <summary>
        /// Parses the given campaign_label resource name in string form into a new
        /// <see cref="CampaignLabelName"/> instance.
        /// </summary>
        /// <param name="campaignLabelName">The campaign_label resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignLabelName"/> if successful.</returns>
        public static CampaignLabelName Parse(string campaignLabelName)
        {
            gax::GaxPreconditions.CheckNotNull(campaignLabelName, nameof(campaignLabelName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(campaignLabelName);
            return new CampaignLabelName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given campaign_label resource name in string form into a new
        /// <see cref="CampaignLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="campaignLabelName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="campaignLabelName">The campaign_label resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CampaignLabelName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignLabelName, out CampaignLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignLabelName, nameof(campaignLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(campaignLabelName, out resourceName))
            {
                result = new CampaignLabelName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CampaignLabelName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="campaignLabelId">The campaignLabel ID. Must not be <c>null</c>.</param>
        public CampaignLabelName(string customerId, string campaignLabelId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CampaignLabelId = gax::GaxPreconditions.CheckNotNull(campaignLabelId, nameof(campaignLabelId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The campaignLabel ID. Never <c>null</c>.
        /// </summary>
        public string CampaignLabelId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CampaignLabelId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CampaignLabelName);

        /// <inheritdoc />
        public bool Equals(CampaignLabelName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CampaignLabelName a, CampaignLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CampaignLabelName a, CampaignLabelName b) => !(a == b);
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
    /// Resource name for the 'click_view' resource.
    /// </summary>
    public sealed partial class ClickViewName : gax::IResourceName, sys::IEquatable<ClickViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/clickViews/{click_view}");

        /// <summary>
        /// Parses the given click_view resource name in string form into a new
        /// <see cref="ClickViewName"/> instance.
        /// </summary>
        /// <param name="clickViewName">The click_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ClickViewName"/> if successful.</returns>
        public static ClickViewName Parse(string clickViewName)
        {
            gax::GaxPreconditions.CheckNotNull(clickViewName, nameof(clickViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(clickViewName);
            return new ClickViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given click_view resource name in string form into a new
        /// <see cref="ClickViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="clickViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="clickViewName">The click_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ClickViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clickViewName, out ClickViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(clickViewName, nameof(clickViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(clickViewName, out resourceName))
            {
                result = new ClickViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ClickViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="clickViewId">The clickView ID. Must not be <c>null</c>.</param>
        public ClickViewName(string customerId, string clickViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            ClickViewId = gax::GaxPreconditions.CheckNotNull(clickViewId, nameof(clickViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The clickView ID. Never <c>null</c>.
        /// </summary>
        public string ClickViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, ClickViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ClickViewName);

        /// <inheritdoc />
        public bool Equals(ClickViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ClickViewName a, ClickViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ClickViewName a, ClickViewName b) => !(a == b);
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
    /// Resource name for the 'currency_constant' resource.
    /// </summary>
    public sealed partial class CurrencyConstantName : gax::IResourceName, sys::IEquatable<CurrencyConstantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("currencyConstants/{currency_constant}");

        /// <summary>
        /// Parses the given currency_constant resource name in string form into a new
        /// <see cref="CurrencyConstantName"/> instance.
        /// </summary>
        /// <param name="currencyConstantName">The currency_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CurrencyConstantName"/> if successful.</returns>
        public static CurrencyConstantName Parse(string currencyConstantName)
        {
            gax::GaxPreconditions.CheckNotNull(currencyConstantName, nameof(currencyConstantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(currencyConstantName);
            return new CurrencyConstantName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given currency_constant resource name in string form into a new
        /// <see cref="CurrencyConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="currencyConstantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="currencyConstantName">The currency_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CurrencyConstantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string currencyConstantName, out CurrencyConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(currencyConstantName, nameof(currencyConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(currencyConstantName, out resourceName))
            {
                result = new CurrencyConstantName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CurrencyConstantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="currencyConstantId">The currencyConstant ID. Must not be <c>null</c>.</param>
        public CurrencyConstantName(string currencyConstantId)
        {
            CurrencyConstantId = gax::GaxPreconditions.CheckNotNull(currencyConstantId, nameof(currencyConstantId));
        }

        /// <summary>
        /// The currencyConstant ID. Never <c>null</c>.
        /// </summary>
        public string CurrencyConstantId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CurrencyConstantId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CurrencyConstantName);

        /// <inheritdoc />
        public bool Equals(CurrencyConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CurrencyConstantName a, CurrencyConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CurrencyConstantName a, CurrencyConstantName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'custom_interest' resource.
    /// </summary>
    public sealed partial class CustomInterestName : gax::IResourceName, sys::IEquatable<CustomInterestName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customInterests/{custom_interest}");

        /// <summary>
        /// Parses the given custom_interest resource name in string form into a new
        /// <see cref="CustomInterestName"/> instance.
        /// </summary>
        /// <param name="customInterestName">The custom_interest resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomInterestName"/> if successful.</returns>
        public static CustomInterestName Parse(string customInterestName)
        {
            gax::GaxPreconditions.CheckNotNull(customInterestName, nameof(customInterestName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(customInterestName);
            return new CustomInterestName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given custom_interest resource name in string form into a new
        /// <see cref="CustomInterestName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="customInterestName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="customInterestName">The custom_interest resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CustomInterestName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customInterestName, out CustomInterestName result)
        {
            gax::GaxPreconditions.CheckNotNull(customInterestName, nameof(customInterestName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(customInterestName, out resourceName))
            {
                result = new CustomInterestName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CustomInterestName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="customInterestId">The customInterest ID. Must not be <c>null</c>.</param>
        public CustomInterestName(string customerId, string customInterestId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CustomInterestId = gax::GaxPreconditions.CheckNotNull(customInterestId, nameof(customInterestId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The customInterest ID. Never <c>null</c>.
        /// </summary>
        public string CustomInterestId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CustomInterestId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CustomInterestName);

        /// <inheritdoc />
        public bool Equals(CustomInterestName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CustomInterestName a, CustomInterestName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CustomInterestName a, CustomInterestName b) => !(a == b);
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
    /// Resource name for the 'customer_extension_setting' resource.
    /// </summary>
    public sealed partial class CustomerExtensionSettingName : gax::IResourceName, sys::IEquatable<CustomerExtensionSettingName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerExtensionSettings/{customer_extension_setting}");

        /// <summary>
        /// Parses the given customer_extension_setting resource name in string form into a new
        /// <see cref="CustomerExtensionSettingName"/> instance.
        /// </summary>
        /// <param name="customerExtensionSettingName">The customer_extension_setting resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerExtensionSettingName"/> if successful.</returns>
        public static CustomerExtensionSettingName Parse(string customerExtensionSettingName)
        {
            gax::GaxPreconditions.CheckNotNull(customerExtensionSettingName, nameof(customerExtensionSettingName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(customerExtensionSettingName);
            return new CustomerExtensionSettingName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given customer_extension_setting resource name in string form into a new
        /// <see cref="CustomerExtensionSettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="customerExtensionSettingName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="customerExtensionSettingName">The customer_extension_setting resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CustomerExtensionSettingName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerExtensionSettingName, out CustomerExtensionSettingName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerExtensionSettingName, nameof(customerExtensionSettingName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(customerExtensionSettingName, out resourceName))
            {
                result = new CustomerExtensionSettingName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CustomerExtensionSettingName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="customerExtensionSettingId">The customerExtensionSetting ID. Must not be <c>null</c>.</param>
        public CustomerExtensionSettingName(string customerId, string customerExtensionSettingId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CustomerExtensionSettingId = gax::GaxPreconditions.CheckNotNull(customerExtensionSettingId, nameof(customerExtensionSettingId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The customerExtensionSetting ID. Never <c>null</c>.
        /// </summary>
        public string CustomerExtensionSettingId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CustomerExtensionSettingId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CustomerExtensionSettingName);

        /// <inheritdoc />
        public bool Equals(CustomerExtensionSettingName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CustomerExtensionSettingName a, CustomerExtensionSettingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CustomerExtensionSettingName a, CustomerExtensionSettingName b) => !(a == b);
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
    /// Resource name for the 'customer_label' resource.
    /// </summary>
    public sealed partial class CustomerLabelName : gax::IResourceName, sys::IEquatable<CustomerLabelName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerLabels/{customer_label}");

        /// <summary>
        /// Parses the given customer_label resource name in string form into a new
        /// <see cref="CustomerLabelName"/> instance.
        /// </summary>
        /// <param name="customerLabelName">The customer_label resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerLabelName"/> if successful.</returns>
        public static CustomerLabelName Parse(string customerLabelName)
        {
            gax::GaxPreconditions.CheckNotNull(customerLabelName, nameof(customerLabelName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(customerLabelName);
            return new CustomerLabelName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given customer_label resource name in string form into a new
        /// <see cref="CustomerLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="customerLabelName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="customerLabelName">The customer_label resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CustomerLabelName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerLabelName, out CustomerLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerLabelName, nameof(customerLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(customerLabelName, out resourceName))
            {
                result = new CustomerLabelName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CustomerLabelName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="customerLabelId">The customerLabel ID. Must not be <c>null</c>.</param>
        public CustomerLabelName(string customerId, string customerLabelId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CustomerLabelId = gax::GaxPreconditions.CheckNotNull(customerLabelId, nameof(customerLabelId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The customerLabel ID. Never <c>null</c>.
        /// </summary>
        public string CustomerLabelId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CustomerLabelId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CustomerLabelName);

        /// <inheritdoc />
        public bool Equals(CustomerLabelName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CustomerLabelName a, CustomerLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CustomerLabelName a, CustomerLabelName b) => !(a == b);
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
    /// Resource name for the 'customer_negative_criteria' resource.
    /// </summary>
    public sealed partial class CustomerNegativeCriteriaName : gax::IResourceName, sys::IEquatable<CustomerNegativeCriteriaName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/customerNegativeCriteria/{customer_negative_criteria}");

        /// <summary>
        /// Parses the given customer_negative_criteria resource name in string form into a new
        /// <see cref="CustomerNegativeCriteriaName"/> instance.
        /// </summary>
        /// <param name="customerNegativeCriteriaName">The customer_negative_criteria resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerNegativeCriteriaName"/> if successful.</returns>
        public static CustomerNegativeCriteriaName Parse(string customerNegativeCriteriaName)
        {
            gax::GaxPreconditions.CheckNotNull(customerNegativeCriteriaName, nameof(customerNegativeCriteriaName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(customerNegativeCriteriaName);
            return new CustomerNegativeCriteriaName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given customer_negative_criteria resource name in string form into a new
        /// <see cref="CustomerNegativeCriteriaName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="customerNegativeCriteriaName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="customerNegativeCriteriaName">The customer_negative_criteria resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="CustomerNegativeCriteriaName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerNegativeCriteriaName, out CustomerNegativeCriteriaName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerNegativeCriteriaName, nameof(customerNegativeCriteriaName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(customerNegativeCriteriaName, out resourceName))
            {
                result = new CustomerNegativeCriteriaName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="CustomerNegativeCriteriaName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="customerNegativeCriteriaId">The customerNegativeCriteria ID. Must not be <c>null</c>.</param>
        public CustomerNegativeCriteriaName(string customerId, string customerNegativeCriteriaId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            CustomerNegativeCriteriaId = gax::GaxPreconditions.CheckNotNull(customerNegativeCriteriaId, nameof(customerNegativeCriteriaId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The customerNegativeCriteria ID. Never <c>null</c>.
        /// </summary>
        public string CustomerNegativeCriteriaId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, CustomerNegativeCriteriaId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as CustomerNegativeCriteriaName);

        /// <inheritdoc />
        public bool Equals(CustomerNegativeCriteriaName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(CustomerNegativeCriteriaName a, CustomerNegativeCriteriaName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(CustomerNegativeCriteriaName a, CustomerNegativeCriteriaName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'detail_placement_view' resource.
    /// </summary>
    public sealed partial class DetailPlacementViewName : gax::IResourceName, sys::IEquatable<DetailPlacementViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/detailPlacementViews/{detail_placement_view}");

        /// <summary>
        /// Parses the given detail_placement_view resource name in string form into a new
        /// <see cref="DetailPlacementViewName"/> instance.
        /// </summary>
        /// <param name="detailPlacementViewName">The detail_placement_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DetailPlacementViewName"/> if successful.</returns>
        public static DetailPlacementViewName Parse(string detailPlacementViewName)
        {
            gax::GaxPreconditions.CheckNotNull(detailPlacementViewName, nameof(detailPlacementViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(detailPlacementViewName);
            return new DetailPlacementViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given detail_placement_view resource name in string form into a new
        /// <see cref="DetailPlacementViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="detailPlacementViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="detailPlacementViewName">The detail_placement_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DetailPlacementViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string detailPlacementViewName, out DetailPlacementViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(detailPlacementViewName, nameof(detailPlacementViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(detailPlacementViewName, out resourceName))
            {
                result = new DetailPlacementViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DetailPlacementViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="detailPlacementViewId">The detailPlacementView ID. Must not be <c>null</c>.</param>
        public DetailPlacementViewName(string customerId, string detailPlacementViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            DetailPlacementViewId = gax::GaxPreconditions.CheckNotNull(detailPlacementViewId, nameof(detailPlacementViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The detailPlacementView ID. Never <c>null</c>.
        /// </summary>
        public string DetailPlacementViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, DetailPlacementViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DetailPlacementViewName);

        /// <inheritdoc />
        public bool Equals(DetailPlacementViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DetailPlacementViewName a, DetailPlacementViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DetailPlacementViewName a, DetailPlacementViewName b) => !(a == b);
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
    /// Resource name for the 'distance_view' resource.
    /// </summary>
    public sealed partial class DistanceViewName : gax::IResourceName, sys::IEquatable<DistanceViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/distanceViews/{distance_view}");

        /// <summary>
        /// Parses the given distance_view resource name in string form into a new
        /// <see cref="DistanceViewName"/> instance.
        /// </summary>
        /// <param name="distanceViewName">The distance_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DistanceViewName"/> if successful.</returns>
        public static DistanceViewName Parse(string distanceViewName)
        {
            gax::GaxPreconditions.CheckNotNull(distanceViewName, nameof(distanceViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(distanceViewName);
            return new DistanceViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given distance_view resource name in string form into a new
        /// <see cref="DistanceViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="distanceViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="distanceViewName">The distance_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DistanceViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string distanceViewName, out DistanceViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(distanceViewName, nameof(distanceViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(distanceViewName, out resourceName))
            {
                result = new DistanceViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DistanceViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="distanceViewId">The distanceView ID. Must not be <c>null</c>.</param>
        public DistanceViewName(string customerId, string distanceViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            DistanceViewId = gax::GaxPreconditions.CheckNotNull(distanceViewId, nameof(distanceViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The distanceView ID. Never <c>null</c>.
        /// </summary>
        public string DistanceViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, DistanceViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DistanceViewName);

        /// <inheritdoc />
        public bool Equals(DistanceViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DistanceViewName a, DistanceViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DistanceViewName a, DistanceViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'domain_category' resource.
    /// </summary>
    public sealed partial class DomainCategoryName : gax::IResourceName, sys::IEquatable<DomainCategoryName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/domainCategories/{domain_category}");

        /// <summary>
        /// Parses the given domain_category resource name in string form into a new
        /// <see cref="DomainCategoryName"/> instance.
        /// </summary>
        /// <param name="domainCategoryName">The domain_category resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DomainCategoryName"/> if successful.</returns>
        public static DomainCategoryName Parse(string domainCategoryName)
        {
            gax::GaxPreconditions.CheckNotNull(domainCategoryName, nameof(domainCategoryName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(domainCategoryName);
            return new DomainCategoryName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given domain_category resource name in string form into a new
        /// <see cref="DomainCategoryName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="domainCategoryName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="domainCategoryName">The domain_category resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DomainCategoryName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string domainCategoryName, out DomainCategoryName result)
        {
            gax::GaxPreconditions.CheckNotNull(domainCategoryName, nameof(domainCategoryName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(domainCategoryName, out resourceName))
            {
                result = new DomainCategoryName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DomainCategoryName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="domainCategoryId">The domainCategory ID. Must not be <c>null</c>.</param>
        public DomainCategoryName(string customerId, string domainCategoryId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            DomainCategoryId = gax::GaxPreconditions.CheckNotNull(domainCategoryId, nameof(domainCategoryId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The domainCategory ID. Never <c>null</c>.
        /// </summary>
        public string DomainCategoryId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, DomainCategoryId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DomainCategoryName);

        /// <inheritdoc />
        public bool Equals(DomainCategoryName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DomainCategoryName a, DomainCategoryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DomainCategoryName a, DomainCategoryName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'dynamic_search_ads_search_term_view' resource.
    /// </summary>
    public sealed partial class DynamicSearchAdsSearchTermViewName : gax::IResourceName, sys::IEquatable<DynamicSearchAdsSearchTermViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}");

        /// <summary>
        /// Parses the given dynamic_search_ads_search_term_view resource name in string form into a new
        /// <see cref="DynamicSearchAdsSearchTermViewName"/> instance.
        /// </summary>
        /// <param name="dynamicSearchAdsSearchTermViewName">The dynamic_search_ads_search_term_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DynamicSearchAdsSearchTermViewName"/> if successful.</returns>
        public static DynamicSearchAdsSearchTermViewName Parse(string dynamicSearchAdsSearchTermViewName)
        {
            gax::GaxPreconditions.CheckNotNull(dynamicSearchAdsSearchTermViewName, nameof(dynamicSearchAdsSearchTermViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(dynamicSearchAdsSearchTermViewName);
            return new DynamicSearchAdsSearchTermViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given dynamic_search_ads_search_term_view resource name in string form into a new
        /// <see cref="DynamicSearchAdsSearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="dynamicSearchAdsSearchTermViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="dynamicSearchAdsSearchTermViewName">The dynamic_search_ads_search_term_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="DynamicSearchAdsSearchTermViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dynamicSearchAdsSearchTermViewName, out DynamicSearchAdsSearchTermViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(dynamicSearchAdsSearchTermViewName, nameof(dynamicSearchAdsSearchTermViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(dynamicSearchAdsSearchTermViewName, out resourceName))
            {
                result = new DynamicSearchAdsSearchTermViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="DynamicSearchAdsSearchTermViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="dynamicSearchAdsSearchTermViewId">The dynamicSearchAdsSearchTermView ID. Must not be <c>null</c>.</param>
        public DynamicSearchAdsSearchTermViewName(string customerId, string dynamicSearchAdsSearchTermViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            DynamicSearchAdsSearchTermViewId = gax::GaxPreconditions.CheckNotNull(dynamicSearchAdsSearchTermViewId, nameof(dynamicSearchAdsSearchTermViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The dynamicSearchAdsSearchTermView ID. Never <c>null</c>.
        /// </summary>
        public string DynamicSearchAdsSearchTermViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, DynamicSearchAdsSearchTermViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as DynamicSearchAdsSearchTermViewName);

        /// <inheritdoc />
        public bool Equals(DynamicSearchAdsSearchTermViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(DynamicSearchAdsSearchTermViewName a, DynamicSearchAdsSearchTermViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(DynamicSearchAdsSearchTermViewName a, DynamicSearchAdsSearchTermViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'expanded_landing_page_view' resource.
    /// </summary>
    public sealed partial class ExpandedLandingPageViewName : gax::IResourceName, sys::IEquatable<ExpandedLandingPageViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/expandedLandingPageViews/{expanded_landing_page_view}");

        /// <summary>
        /// Parses the given expanded_landing_page_view resource name in string form into a new
        /// <see cref="ExpandedLandingPageViewName"/> instance.
        /// </summary>
        /// <param name="expandedLandingPageViewName">The expanded_landing_page_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExpandedLandingPageViewName"/> if successful.</returns>
        public static ExpandedLandingPageViewName Parse(string expandedLandingPageViewName)
        {
            gax::GaxPreconditions.CheckNotNull(expandedLandingPageViewName, nameof(expandedLandingPageViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(expandedLandingPageViewName);
            return new ExpandedLandingPageViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given expanded_landing_page_view resource name in string form into a new
        /// <see cref="ExpandedLandingPageViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="expandedLandingPageViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="expandedLandingPageViewName">The expanded_landing_page_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ExpandedLandingPageViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string expandedLandingPageViewName, out ExpandedLandingPageViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(expandedLandingPageViewName, nameof(expandedLandingPageViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(expandedLandingPageViewName, out resourceName))
            {
                result = new ExpandedLandingPageViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ExpandedLandingPageViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="expandedLandingPageViewId">The expandedLandingPageView ID. Must not be <c>null</c>.</param>
        public ExpandedLandingPageViewName(string customerId, string expandedLandingPageViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            ExpandedLandingPageViewId = gax::GaxPreconditions.CheckNotNull(expandedLandingPageViewId, nameof(expandedLandingPageViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The expandedLandingPageView ID. Never <c>null</c>.
        /// </summary>
        public string ExpandedLandingPageViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, ExpandedLandingPageViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ExpandedLandingPageViewName);

        /// <inheritdoc />
        public bool Equals(ExpandedLandingPageViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ExpandedLandingPageViewName a, ExpandedLandingPageViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ExpandedLandingPageViewName a, ExpandedLandingPageViewName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'extension_feed_item' resource.
    /// </summary>
    public sealed partial class ExtensionFeedItemName : gax::IResourceName, sys::IEquatable<ExtensionFeedItemName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/extensionFeedItems/{extension_feed_item}");

        /// <summary>
        /// Parses the given extension_feed_item resource name in string form into a new
        /// <see cref="ExtensionFeedItemName"/> instance.
        /// </summary>
        /// <param name="extensionFeedItemName">The extension_feed_item resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExtensionFeedItemName"/> if successful.</returns>
        public static ExtensionFeedItemName Parse(string extensionFeedItemName)
        {
            gax::GaxPreconditions.CheckNotNull(extensionFeedItemName, nameof(extensionFeedItemName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(extensionFeedItemName);
            return new ExtensionFeedItemName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given extension_feed_item resource name in string form into a new
        /// <see cref="ExtensionFeedItemName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="extensionFeedItemName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="extensionFeedItemName">The extension_feed_item resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ExtensionFeedItemName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string extensionFeedItemName, out ExtensionFeedItemName result)
        {
            gax::GaxPreconditions.CheckNotNull(extensionFeedItemName, nameof(extensionFeedItemName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(extensionFeedItemName, out resourceName))
            {
                result = new ExtensionFeedItemName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ExtensionFeedItemName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="extensionFeedItemId">The extensionFeedItem ID. Must not be <c>null</c>.</param>
        public ExtensionFeedItemName(string customerId, string extensionFeedItemId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            ExtensionFeedItemId = gax::GaxPreconditions.CheckNotNull(extensionFeedItemId, nameof(extensionFeedItemId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The extensionFeedItem ID. Never <c>null</c>.
        /// </summary>
        public string ExtensionFeedItemId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, ExtensionFeedItemId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ExtensionFeedItemName);

        /// <inheritdoc />
        public bool Equals(ExtensionFeedItemName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ExtensionFeedItemName a, ExtensionFeedItemName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ExtensionFeedItemName a, ExtensionFeedItemName b) => !(a == b);
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
    /// Resource name for the 'feed_item_target' resource.
    /// </summary>
    public sealed partial class FeedItemTargetName : gax::IResourceName, sys::IEquatable<FeedItemTargetName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/feedItemTargets/{feed_item_target}");

        /// <summary>
        /// Parses the given feed_item_target resource name in string form into a new
        /// <see cref="FeedItemTargetName"/> instance.
        /// </summary>
        /// <param name="feedItemTargetName">The feed_item_target resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedItemTargetName"/> if successful.</returns>
        public static FeedItemTargetName Parse(string feedItemTargetName)
        {
            gax::GaxPreconditions.CheckNotNull(feedItemTargetName, nameof(feedItemTargetName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(feedItemTargetName);
            return new FeedItemTargetName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given feed_item_target resource name in string form into a new
        /// <see cref="FeedItemTargetName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="feedItemTargetName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="feedItemTargetName">The feed_item_target resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FeedItemTargetName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedItemTargetName, out FeedItemTargetName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedItemTargetName, nameof(feedItemTargetName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(feedItemTargetName, out resourceName))
            {
                result = new FeedItemTargetName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="FeedItemTargetName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="feedItemTargetId">The feedItemTarget ID. Must not be <c>null</c>.</param>
        public FeedItemTargetName(string customerId, string feedItemTargetId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            FeedItemTargetId = gax::GaxPreconditions.CheckNotNull(feedItemTargetId, nameof(feedItemTargetId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The feedItemTarget ID. Never <c>null</c>.
        /// </summary>
        public string FeedItemTargetId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, FeedItemTargetId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FeedItemTargetName);

        /// <inheritdoc />
        public bool Equals(FeedItemTargetName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FeedItemTargetName a, FeedItemTargetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FeedItemTargetName a, FeedItemTargetName b) => !(a == b);
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
    /// Resource name for the 'feed_placeholder_view' resource.
    /// </summary>
    public sealed partial class FeedPlaceholderViewName : gax::IResourceName, sys::IEquatable<FeedPlaceholderViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}");

        /// <summary>
        /// Parses the given feed_placeholder_view resource name in string form into a new
        /// <see cref="FeedPlaceholderViewName"/> instance.
        /// </summary>
        /// <param name="feedPlaceholderViewName">The feed_placeholder_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedPlaceholderViewName"/> if successful.</returns>
        public static FeedPlaceholderViewName Parse(string feedPlaceholderViewName)
        {
            gax::GaxPreconditions.CheckNotNull(feedPlaceholderViewName, nameof(feedPlaceholderViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(feedPlaceholderViewName);
            return new FeedPlaceholderViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given feed_placeholder_view resource name in string form into a new
        /// <see cref="FeedPlaceholderViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="feedPlaceholderViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="feedPlaceholderViewName">The feed_placeholder_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="FeedPlaceholderViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedPlaceholderViewName, out FeedPlaceholderViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedPlaceholderViewName, nameof(feedPlaceholderViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(feedPlaceholderViewName, out resourceName))
            {
                result = new FeedPlaceholderViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="FeedPlaceholderViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="feedPlaceholderViewId">The feedPlaceholderView ID. Must not be <c>null</c>.</param>
        public FeedPlaceholderViewName(string customerId, string feedPlaceholderViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            FeedPlaceholderViewId = gax::GaxPreconditions.CheckNotNull(feedPlaceholderViewId, nameof(feedPlaceholderViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The feedPlaceholderView ID. Never <c>null</c>.
        /// </summary>
        public string FeedPlaceholderViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, FeedPlaceholderViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as FeedPlaceholderViewName);

        /// <inheritdoc />
        public bool Equals(FeedPlaceholderViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(FeedPlaceholderViewName a, FeedPlaceholderViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(FeedPlaceholderViewName a, FeedPlaceholderViewName b) => !(a == b);
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
    /// Resource name for the 'geographic_view' resource.
    /// </summary>
    public sealed partial class GeographicViewName : gax::IResourceName, sys::IEquatable<GeographicViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/geographicViews/{geographic_view}");

        /// <summary>
        /// Parses the given geographic_view resource name in string form into a new
        /// <see cref="GeographicViewName"/> instance.
        /// </summary>
        /// <param name="geographicViewName">The geographic_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GeographicViewName"/> if successful.</returns>
        public static GeographicViewName Parse(string geographicViewName)
        {
            gax::GaxPreconditions.CheckNotNull(geographicViewName, nameof(geographicViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(geographicViewName);
            return new GeographicViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given geographic_view resource name in string form into a new
        /// <see cref="GeographicViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="geographicViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="geographicViewName">The geographic_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="GeographicViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string geographicViewName, out GeographicViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(geographicViewName, nameof(geographicViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(geographicViewName, out resourceName))
            {
                result = new GeographicViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="GeographicViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="geographicViewId">The geographicView ID. Must not be <c>null</c>.</param>
        public GeographicViewName(string customerId, string geographicViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            GeographicViewId = gax::GaxPreconditions.CheckNotNull(geographicViewId, nameof(geographicViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The geographicView ID. Never <c>null</c>.
        /// </summary>
        public string GeographicViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, GeographicViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as GeographicViewName);

        /// <inheritdoc />
        public bool Equals(GeographicViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(GeographicViewName a, GeographicViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(GeographicViewName a, GeographicViewName b) => !(a == b);
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
    /// Resource name for the 'group_placement_view' resource.
    /// </summary>
    public sealed partial class GroupPlacementViewName : gax::IResourceName, sys::IEquatable<GroupPlacementViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/groupPlacementViews/{group_placement_view}");

        /// <summary>
        /// Parses the given group_placement_view resource name in string form into a new
        /// <see cref="GroupPlacementViewName"/> instance.
        /// </summary>
        /// <param name="groupPlacementViewName">The group_placement_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GroupPlacementViewName"/> if successful.</returns>
        public static GroupPlacementViewName Parse(string groupPlacementViewName)
        {
            gax::GaxPreconditions.CheckNotNull(groupPlacementViewName, nameof(groupPlacementViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(groupPlacementViewName);
            return new GroupPlacementViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given group_placement_view resource name in string form into a new
        /// <see cref="GroupPlacementViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="groupPlacementViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="groupPlacementViewName">The group_placement_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="GroupPlacementViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string groupPlacementViewName, out GroupPlacementViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(groupPlacementViewName, nameof(groupPlacementViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(groupPlacementViewName, out resourceName))
            {
                result = new GroupPlacementViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="GroupPlacementViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="groupPlacementViewId">The groupPlacementView ID. Must not be <c>null</c>.</param>
        public GroupPlacementViewName(string customerId, string groupPlacementViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            GroupPlacementViewId = gax::GaxPreconditions.CheckNotNull(groupPlacementViewId, nameof(groupPlacementViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The groupPlacementView ID. Never <c>null</c>.
        /// </summary>
        public string GroupPlacementViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, GroupPlacementViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as GroupPlacementViewName);

        /// <inheritdoc />
        public bool Equals(GroupPlacementViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(GroupPlacementViewName a, GroupPlacementViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(GroupPlacementViewName a, GroupPlacementViewName b) => !(a == b);
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
    /// Resource name for the 'label' resource.
    /// </summary>
    public sealed partial class LabelName : gax::IResourceName, sys::IEquatable<LabelName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/labels/{label}");

        /// <summary>
        /// Parses the given label resource name in string form into a new
        /// <see cref="LabelName"/> instance.
        /// </summary>
        /// <param name="labelName">The label resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LabelName"/> if successful.</returns>
        public static LabelName Parse(string labelName)
        {
            gax::GaxPreconditions.CheckNotNull(labelName, nameof(labelName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(labelName);
            return new LabelName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given label resource name in string form into a new
        /// <see cref="LabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="labelName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="labelName">The label resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LabelName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string labelName, out LabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(labelName, nameof(labelName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(labelName, out resourceName))
            {
                result = new LabelName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LabelName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="labelId">The label ID. Must not be <c>null</c>.</param>
        public LabelName(string customerId, string labelId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            LabelId = gax::GaxPreconditions.CheckNotNull(labelId, nameof(labelId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The label ID. Never <c>null</c>.
        /// </summary>
        public string LabelId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, LabelId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LabelName);

        /// <inheritdoc />
        public bool Equals(LabelName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LabelName a, LabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LabelName a, LabelName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'landing_page_view' resource.
    /// </summary>
    public sealed partial class LandingPageViewName : gax::IResourceName, sys::IEquatable<LandingPageViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/landingPageViews/{landing_page_view}");

        /// <summary>
        /// Parses the given landing_page_view resource name in string form into a new
        /// <see cref="LandingPageViewName"/> instance.
        /// </summary>
        /// <param name="landingPageViewName">The landing_page_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LandingPageViewName"/> if successful.</returns>
        public static LandingPageViewName Parse(string landingPageViewName)
        {
            gax::GaxPreconditions.CheckNotNull(landingPageViewName, nameof(landingPageViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(landingPageViewName);
            return new LandingPageViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given landing_page_view resource name in string form into a new
        /// <see cref="LandingPageViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="landingPageViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="landingPageViewName">The landing_page_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LandingPageViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string landingPageViewName, out LandingPageViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(landingPageViewName, nameof(landingPageViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(landingPageViewName, out resourceName))
            {
                result = new LandingPageViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LandingPageViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="landingPageViewId">The landingPageView ID. Must not be <c>null</c>.</param>
        public LandingPageViewName(string customerId, string landingPageViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            LandingPageViewId = gax::GaxPreconditions.CheckNotNull(landingPageViewId, nameof(landingPageViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The landingPageView ID. Never <c>null</c>.
        /// </summary>
        public string LandingPageViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, LandingPageViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LandingPageViewName);

        /// <inheritdoc />
        public bool Equals(LandingPageViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LandingPageViewName a, LandingPageViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LandingPageViewName a, LandingPageViewName b) => !(a == b);
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
    /// Resource name for the 'location_view' resource.
    /// </summary>
    public sealed partial class LocationViewName : gax::IResourceName, sys::IEquatable<LocationViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/locationViews/{location_view}");

        /// <summary>
        /// Parses the given location_view resource name in string form into a new
        /// <see cref="LocationViewName"/> instance.
        /// </summary>
        /// <param name="locationViewName">The location_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationViewName"/> if successful.</returns>
        public static LocationViewName Parse(string locationViewName)
        {
            gax::GaxPreconditions.CheckNotNull(locationViewName, nameof(locationViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(locationViewName);
            return new LocationViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given location_view resource name in string form into a new
        /// <see cref="LocationViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="locationViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="locationViewName">The location_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="LocationViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationViewName, out LocationViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationViewName, nameof(locationViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(locationViewName, out resourceName))
            {
                result = new LocationViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="LocationViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="locationViewId">The locationView ID. Must not be <c>null</c>.</param>
        public LocationViewName(string customerId, string locationViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            LocationViewId = gax::GaxPreconditions.CheckNotNull(locationViewId, nameof(locationViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The locationView ID. Never <c>null</c>.
        /// </summary>
        public string LocationViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, LocationViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as LocationViewName);

        /// <inheritdoc />
        public bool Equals(LocationViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(LocationViewName a, LocationViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(LocationViewName a, LocationViewName b) => !(a == b);
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
    /// Resource name for the 'merchant_center_link' resource.
    /// </summary>
    public sealed partial class MerchantCenterLinkName : gax::IResourceName, sys::IEquatable<MerchantCenterLinkName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/merchantCenterLinks/{merchant_center_link}");

        /// <summary>
        /// Parses the given merchant_center_link resource name in string form into a new
        /// <see cref="MerchantCenterLinkName"/> instance.
        /// </summary>
        /// <param name="merchantCenterLinkName">The merchant_center_link resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MerchantCenterLinkName"/> if successful.</returns>
        public static MerchantCenterLinkName Parse(string merchantCenterLinkName)
        {
            gax::GaxPreconditions.CheckNotNull(merchantCenterLinkName, nameof(merchantCenterLinkName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(merchantCenterLinkName);
            return new MerchantCenterLinkName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given merchant_center_link resource name in string form into a new
        /// <see cref="MerchantCenterLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="merchantCenterLinkName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="merchantCenterLinkName">The merchant_center_link resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MerchantCenterLinkName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string merchantCenterLinkName, out MerchantCenterLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(merchantCenterLinkName, nameof(merchantCenterLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(merchantCenterLinkName, out resourceName))
            {
                result = new MerchantCenterLinkName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="MerchantCenterLinkName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="merchantCenterLinkId">The merchantCenterLink ID. Must not be <c>null</c>.</param>
        public MerchantCenterLinkName(string customerId, string merchantCenterLinkId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            MerchantCenterLinkId = gax::GaxPreconditions.CheckNotNull(merchantCenterLinkId, nameof(merchantCenterLinkId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The merchantCenterLink ID. Never <c>null</c>.
        /// </summary>
        public string MerchantCenterLinkId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, MerchantCenterLinkId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as MerchantCenterLinkName);

        /// <inheritdoc />
        public bool Equals(MerchantCenterLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(MerchantCenterLinkName a, MerchantCenterLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(MerchantCenterLinkName a, MerchantCenterLinkName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'mobile_app_category_constant' resource.
    /// </summary>
    public sealed partial class MobileAppCategoryConstantName : gax::IResourceName, sys::IEquatable<MobileAppCategoryConstantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("mobileAppCategoryConstants/{mobile_app_category_constant}");

        /// <summary>
        /// Parses the given mobile_app_category_constant resource name in string form into a new
        /// <see cref="MobileAppCategoryConstantName"/> instance.
        /// </summary>
        /// <param name="mobileAppCategoryConstantName">The mobile_app_category_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MobileAppCategoryConstantName"/> if successful.</returns>
        public static MobileAppCategoryConstantName Parse(string mobileAppCategoryConstantName)
        {
            gax::GaxPreconditions.CheckNotNull(mobileAppCategoryConstantName, nameof(mobileAppCategoryConstantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(mobileAppCategoryConstantName);
            return new MobileAppCategoryConstantName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given mobile_app_category_constant resource name in string form into a new
        /// <see cref="MobileAppCategoryConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="mobileAppCategoryConstantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="mobileAppCategoryConstantName">The mobile_app_category_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MobileAppCategoryConstantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mobileAppCategoryConstantName, out MobileAppCategoryConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(mobileAppCategoryConstantName, nameof(mobileAppCategoryConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(mobileAppCategoryConstantName, out resourceName))
            {
                result = new MobileAppCategoryConstantName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="MobileAppCategoryConstantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="mobileAppCategoryConstantId">The mobileAppCategoryConstant ID. Must not be <c>null</c>.</param>
        public MobileAppCategoryConstantName(string mobileAppCategoryConstantId)
        {
            MobileAppCategoryConstantId = gax::GaxPreconditions.CheckNotNull(mobileAppCategoryConstantId, nameof(mobileAppCategoryConstantId));
        }

        /// <summary>
        /// The mobileAppCategoryConstant ID. Never <c>null</c>.
        /// </summary>
        public string MobileAppCategoryConstantId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(MobileAppCategoryConstantId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as MobileAppCategoryConstantName);

        /// <inheritdoc />
        public bool Equals(MobileAppCategoryConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(MobileAppCategoryConstantName a, MobileAppCategoryConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(MobileAppCategoryConstantName a, MobileAppCategoryConstantName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'mobile_device_constant' resource.
    /// </summary>
    public sealed partial class MobileDeviceConstantName : gax::IResourceName, sys::IEquatable<MobileDeviceConstantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("mobileDeviceConstants/{mobile_device_constant}");

        /// <summary>
        /// Parses the given mobile_device_constant resource name in string form into a new
        /// <see cref="MobileDeviceConstantName"/> instance.
        /// </summary>
        /// <param name="mobileDeviceConstantName">The mobile_device_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MobileDeviceConstantName"/> if successful.</returns>
        public static MobileDeviceConstantName Parse(string mobileDeviceConstantName)
        {
            gax::GaxPreconditions.CheckNotNull(mobileDeviceConstantName, nameof(mobileDeviceConstantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(mobileDeviceConstantName);
            return new MobileDeviceConstantName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given mobile_device_constant resource name in string form into a new
        /// <see cref="MobileDeviceConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="mobileDeviceConstantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="mobileDeviceConstantName">The mobile_device_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MobileDeviceConstantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mobileDeviceConstantName, out MobileDeviceConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(mobileDeviceConstantName, nameof(mobileDeviceConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(mobileDeviceConstantName, out resourceName))
            {
                result = new MobileDeviceConstantName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="MobileDeviceConstantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="mobileDeviceConstantId">The mobileDeviceConstant ID. Must not be <c>null</c>.</param>
        public MobileDeviceConstantName(string mobileDeviceConstantId)
        {
            MobileDeviceConstantId = gax::GaxPreconditions.CheckNotNull(mobileDeviceConstantId, nameof(mobileDeviceConstantId));
        }

        /// <summary>
        /// The mobileDeviceConstant ID. Never <c>null</c>.
        /// </summary>
        public string MobileDeviceConstantId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(MobileDeviceConstantId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as MobileDeviceConstantName);

        /// <inheritdoc />
        public bool Equals(MobileDeviceConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(MobileDeviceConstantName a, MobileDeviceConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(MobileDeviceConstantName a, MobileDeviceConstantName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'mutate_job' resource.
    /// </summary>
    public sealed partial class MutateJobName : gax::IResourceName, sys::IEquatable<MutateJobName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/mutateJobs/{mutate_job}");

        /// <summary>
        /// Parses the given mutate_job resource name in string form into a new
        /// <see cref="MutateJobName"/> instance.
        /// </summary>
        /// <param name="mutateJobName">The mutate_job resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MutateJobName"/> if successful.</returns>
        public static MutateJobName Parse(string mutateJobName)
        {
            gax::GaxPreconditions.CheckNotNull(mutateJobName, nameof(mutateJobName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(mutateJobName);
            return new MutateJobName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given mutate_job resource name in string form into a new
        /// <see cref="MutateJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="mutateJobName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="mutateJobName">The mutate_job resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="MutateJobName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mutateJobName, out MutateJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(mutateJobName, nameof(mutateJobName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(mutateJobName, out resourceName))
            {
                result = new MutateJobName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="MutateJobName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="mutateJobId">The mutateJob ID. Must not be <c>null</c>.</param>
        public MutateJobName(string customerId, string mutateJobId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            MutateJobId = gax::GaxPreconditions.CheckNotNull(mutateJobId, nameof(mutateJobId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The mutateJob ID. Never <c>null</c>.
        /// </summary>
        public string MutateJobId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, MutateJobId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as MutateJobName);

        /// <inheritdoc />
        public bool Equals(MutateJobName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(MutateJobName a, MutateJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(MutateJobName a, MutateJobName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'operating_system_version_constant' resource.
    /// </summary>
    public sealed partial class OperatingSystemVersionConstantName : gax::IResourceName, sys::IEquatable<OperatingSystemVersionConstantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("operatingSystemVersionConstants/{operating_system_version_constant}");

        /// <summary>
        /// Parses the given operating_system_version_constant resource name in string form into a new
        /// <see cref="OperatingSystemVersionConstantName"/> instance.
        /// </summary>
        /// <param name="operatingSystemVersionConstantName">The operating_system_version_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OperatingSystemVersionConstantName"/> if successful.</returns>
        public static OperatingSystemVersionConstantName Parse(string operatingSystemVersionConstantName)
        {
            gax::GaxPreconditions.CheckNotNull(operatingSystemVersionConstantName, nameof(operatingSystemVersionConstantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(operatingSystemVersionConstantName);
            return new OperatingSystemVersionConstantName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given operating_system_version_constant resource name in string form into a new
        /// <see cref="OperatingSystemVersionConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="operatingSystemVersionConstantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="operatingSystemVersionConstantName">The operating_system_version_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="OperatingSystemVersionConstantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string operatingSystemVersionConstantName, out OperatingSystemVersionConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(operatingSystemVersionConstantName, nameof(operatingSystemVersionConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(operatingSystemVersionConstantName, out resourceName))
            {
                result = new OperatingSystemVersionConstantName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="OperatingSystemVersionConstantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="operatingSystemVersionConstantId">The operatingSystemVersionConstant ID. Must not be <c>null</c>.</param>
        public OperatingSystemVersionConstantName(string operatingSystemVersionConstantId)
        {
            OperatingSystemVersionConstantId = gax::GaxPreconditions.CheckNotNull(operatingSystemVersionConstantId, nameof(operatingSystemVersionConstantId));
        }

        /// <summary>
        /// The operatingSystemVersionConstant ID. Never <c>null</c>.
        /// </summary>
        public string OperatingSystemVersionConstantId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(OperatingSystemVersionConstantId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as OperatingSystemVersionConstantName);

        /// <inheritdoc />
        public bool Equals(OperatingSystemVersionConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(OperatingSystemVersionConstantName a, OperatingSystemVersionConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(OperatingSystemVersionConstantName a, OperatingSystemVersionConstantName b) => !(a == b);
    }

    /// <summary>
    /// Resource name for the 'paid_organic_search_term_view' resource.
    /// </summary>
    public sealed partial class PaidOrganicSearchTermViewName : gax::IResourceName, sys::IEquatable<PaidOrganicSearchTermViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/paidOrganicSearchTermViews/{paid_organic_search_term_view}");

        /// <summary>
        /// Parses the given paid_organic_search_term_view resource name in string form into a new
        /// <see cref="PaidOrganicSearchTermViewName"/> instance.
        /// </summary>
        /// <param name="paidOrganicSearchTermViewName">The paid_organic_search_term_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PaidOrganicSearchTermViewName"/> if successful.</returns>
        public static PaidOrganicSearchTermViewName Parse(string paidOrganicSearchTermViewName)
        {
            gax::GaxPreconditions.CheckNotNull(paidOrganicSearchTermViewName, nameof(paidOrganicSearchTermViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(paidOrganicSearchTermViewName);
            return new PaidOrganicSearchTermViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given paid_organic_search_term_view resource name in string form into a new
        /// <see cref="PaidOrganicSearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="paidOrganicSearchTermViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="paidOrganicSearchTermViewName">The paid_organic_search_term_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="PaidOrganicSearchTermViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string paidOrganicSearchTermViewName, out PaidOrganicSearchTermViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(paidOrganicSearchTermViewName, nameof(paidOrganicSearchTermViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(paidOrganicSearchTermViewName, out resourceName))
            {
                result = new PaidOrganicSearchTermViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="PaidOrganicSearchTermViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="paidOrganicSearchTermViewId">The paidOrganicSearchTermView ID. Must not be <c>null</c>.</param>
        public PaidOrganicSearchTermViewName(string customerId, string paidOrganicSearchTermViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            PaidOrganicSearchTermViewId = gax::GaxPreconditions.CheckNotNull(paidOrganicSearchTermViewId, nameof(paidOrganicSearchTermViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The paidOrganicSearchTermView ID. Never <c>null</c>.
        /// </summary>
        public string PaidOrganicSearchTermViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, PaidOrganicSearchTermViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as PaidOrganicSearchTermViewName);

        /// <inheritdoc />
        public bool Equals(PaidOrganicSearchTermViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(PaidOrganicSearchTermViewName a, PaidOrganicSearchTermViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(PaidOrganicSearchTermViewName a, PaidOrganicSearchTermViewName b) => !(a == b);
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
    /// Resource name for the 'product_bidding_category_constant' resource.
    /// </summary>
    public sealed partial class ProductBiddingCategoryConstantName : gax::IResourceName, sys::IEquatable<ProductBiddingCategoryConstantName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("productBiddingCategoryConstants/{product_bidding_category_constant}");

        /// <summary>
        /// Parses the given product_bidding_category_constant resource name in string form into a new
        /// <see cref="ProductBiddingCategoryConstantName"/> instance.
        /// </summary>
        /// <param name="productBiddingCategoryConstantName">The product_bidding_category_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProductBiddingCategoryConstantName"/> if successful.</returns>
        public static ProductBiddingCategoryConstantName Parse(string productBiddingCategoryConstantName)
        {
            gax::GaxPreconditions.CheckNotNull(productBiddingCategoryConstantName, nameof(productBiddingCategoryConstantName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(productBiddingCategoryConstantName);
            return new ProductBiddingCategoryConstantName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given product_bidding_category_constant resource name in string form into a new
        /// <see cref="ProductBiddingCategoryConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="productBiddingCategoryConstantName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="productBiddingCategoryConstantName">The product_bidding_category_constant resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ProductBiddingCategoryConstantName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productBiddingCategoryConstantName, out ProductBiddingCategoryConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(productBiddingCategoryConstantName, nameof(productBiddingCategoryConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(productBiddingCategoryConstantName, out resourceName))
            {
                result = new ProductBiddingCategoryConstantName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ProductBiddingCategoryConstantName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="productBiddingCategoryConstantId">The productBiddingCategoryConstant ID. Must not be <c>null</c>.</param>
        public ProductBiddingCategoryConstantName(string productBiddingCategoryConstantId)
        {
            ProductBiddingCategoryConstantId = gax::GaxPreconditions.CheckNotNull(productBiddingCategoryConstantId, nameof(productBiddingCategoryConstantId));
        }

        /// <summary>
        /// The productBiddingCategoryConstant ID. Never <c>null</c>.
        /// </summary>
        public string ProductBiddingCategoryConstantId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(ProductBiddingCategoryConstantId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as ProductBiddingCategoryConstantName);

        /// <inheritdoc />
        public bool Equals(ProductBiddingCategoryConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ProductBiddingCategoryConstantName a, ProductBiddingCategoryConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ProductBiddingCategoryConstantName a, ProductBiddingCategoryConstantName b) => !(a == b);
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
    /// Resource name for the 'remarketing_action' resource.
    /// </summary>
    public sealed partial class RemarketingActionName : gax::IResourceName, sys::IEquatable<RemarketingActionName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/remarketingActions/{remarketing_action}");

        /// <summary>
        /// Parses the given remarketing_action resource name in string form into a new
        /// <see cref="RemarketingActionName"/> instance.
        /// </summary>
        /// <param name="remarketingActionName">The remarketing_action resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RemarketingActionName"/> if successful.</returns>
        public static RemarketingActionName Parse(string remarketingActionName)
        {
            gax::GaxPreconditions.CheckNotNull(remarketingActionName, nameof(remarketingActionName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(remarketingActionName);
            return new RemarketingActionName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given remarketing_action resource name in string form into a new
        /// <see cref="RemarketingActionName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="remarketingActionName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="remarketingActionName">The remarketing_action resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="RemarketingActionName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string remarketingActionName, out RemarketingActionName result)
        {
            gax::GaxPreconditions.CheckNotNull(remarketingActionName, nameof(remarketingActionName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(remarketingActionName, out resourceName))
            {
                result = new RemarketingActionName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="RemarketingActionName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="remarketingActionId">The remarketingAction ID. Must not be <c>null</c>.</param>
        public RemarketingActionName(string customerId, string remarketingActionId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            RemarketingActionId = gax::GaxPreconditions.CheckNotNull(remarketingActionId, nameof(remarketingActionId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The remarketingAction ID. Never <c>null</c>.
        /// </summary>
        public string RemarketingActionId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, RemarketingActionId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as RemarketingActionName);

        /// <inheritdoc />
        public bool Equals(RemarketingActionName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(RemarketingActionName a, RemarketingActionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(RemarketingActionName a, RemarketingActionName b) => !(a == b);
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
    /// Resource name for the 'shopping_performance_view' resource.
    /// </summary>
    public sealed partial class ShoppingPerformanceViewName : gax::IResourceName, sys::IEquatable<ShoppingPerformanceViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/shoppingPerformanceView");

        /// <summary>
        /// Parses the given shopping_performance_view resource name in string form into a new
        /// <see cref="ShoppingPerformanceViewName"/> instance.
        /// </summary>
        /// <param name="shoppingPerformanceViewName">The shopping_performance_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ShoppingPerformanceViewName"/> if successful.</returns>
        public static ShoppingPerformanceViewName Parse(string shoppingPerformanceViewName)
        {
            gax::GaxPreconditions.CheckNotNull(shoppingPerformanceViewName, nameof(shoppingPerformanceViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(shoppingPerformanceViewName);
            return new ShoppingPerformanceViewName(resourceName[0]);
        }

        /// <summary>
        /// Tries to parse the given shopping_performance_view resource name in string form into a new
        /// <see cref="ShoppingPerformanceViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="shoppingPerformanceViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="shoppingPerformanceViewName">The shopping_performance_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="ShoppingPerformanceViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string shoppingPerformanceViewName, out ShoppingPerformanceViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(shoppingPerformanceViewName, nameof(shoppingPerformanceViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(shoppingPerformanceViewName, out resourceName))
            {
                result = new ShoppingPerformanceViewName(resourceName[0]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="ShoppingPerformanceViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        public ShoppingPerformanceViewName(string customerId)
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
        public override bool Equals(object obj) => Equals(obj as ShoppingPerformanceViewName);

        /// <inheritdoc />
        public bool Equals(ShoppingPerformanceViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(ShoppingPerformanceViewName a, ShoppingPerformanceViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(ShoppingPerformanceViewName a, ShoppingPerformanceViewName b) => !(a == b);
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
    /// Resource name for the 'user_location_view' resource.
    /// </summary>
    public sealed partial class UserLocationViewName : gax::IResourceName, sys::IEquatable<UserLocationViewName>
    {
        private static readonly gax::PathTemplate s_template = new gax::PathTemplate("customers/{customer}/userLocationViews/{user_location_view}");

        /// <summary>
        /// Parses the given user_location_view resource name in string form into a new
        /// <see cref="UserLocationViewName"/> instance.
        /// </summary>
        /// <param name="userLocationViewName">The user_location_view resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserLocationViewName"/> if successful.</returns>
        public static UserLocationViewName Parse(string userLocationViewName)
        {
            gax::GaxPreconditions.CheckNotNull(userLocationViewName, nameof(userLocationViewName));
            gax::TemplatedResourceName resourceName = s_template.ParseName(userLocationViewName);
            return new UserLocationViewName(resourceName[0], resourceName[1]);
        }

        /// <summary>
        /// Tries to parse the given user_location_view resource name in string form into a new
        /// <see cref="UserLocationViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// This method still throws <see cref="sys::ArgumentNullException"/> if <paramref name="userLocationViewName"/> is null,
        /// as this would usually indicate a programming error rather than a data error.
        /// </remarks>
        /// <param name="userLocationViewName">The user_location_view resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">When this method returns, the parsed <see cref="UserLocationViewName"/>,
        /// or <c>null</c> if parsing fails.</param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userLocationViewName, out UserLocationViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(userLocationViewName, nameof(userLocationViewName));
            gax::TemplatedResourceName resourceName;
            if (s_template.TryParseName(userLocationViewName, out resourceName))
            {
                result = new UserLocationViewName(resourceName[0], resourceName[1]);
                return true;
            }
            else
            {
                result = null;
                return false;
            }
        }

        /// <summary>
        /// Constructs a new instance of the <see cref="UserLocationViewName"/> resource name class
        /// from its component parts.
        /// </summary>
        /// <param name="customerId">The customer ID. Must not be <c>null</c>.</param>
        /// <param name="userLocationViewId">The userLocationView ID. Must not be <c>null</c>.</param>
        public UserLocationViewName(string customerId, string userLocationViewId)
        {
            CustomerId = gax::GaxPreconditions.CheckNotNull(customerId, nameof(customerId));
            UserLocationViewId = gax::GaxPreconditions.CheckNotNull(userLocationViewId, nameof(userLocationViewId));
        }

        /// <summary>
        /// The customer ID. Never <c>null</c>.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The userLocationView ID. Never <c>null</c>.
        /// </summary>
        public string UserLocationViewId { get; }

        /// <inheritdoc />
        public gax::ResourceNameKind Kind => gax::ResourceNameKind.Simple;

        /// <inheritdoc />
        public override string ToString() => s_template.Expand(CustomerId, UserLocationViewId);

        /// <inheritdoc />
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc />
        public override bool Equals(object obj) => Equals(obj as UserLocationViewName);

        /// <inheritdoc />
        public bool Equals(UserLocationViewName other) => ToString() == other?.ToString();

        /// <inheritdoc />
        public static bool operator ==(UserLocationViewName a, UserLocationViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc />
        public static bool operator !=(UserLocationViewName a, UserLocationViewName b) => !(a == b);
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
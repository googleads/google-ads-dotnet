// Copyright 2021 Google LLC
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

namespace Google.Ads.GoogleAds.V8.Resources
{
    /// <summary>Resource name for the <c>AccountBudgetProposal</c> resource.</summary>
    public sealed partial class AccountBudgetProposalName : gax::IResourceName, sys::IEquatable<AccountBudgetProposalName>
    {
        /// <summary>The possible contents of <see cref="AccountBudgetProposalName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>.
            /// </summary>
            CustomerAccountBudgetProposal = 1,
        }

        private static gax::PathTemplate s_customerAccountBudgetProposal = new gax::PathTemplate("customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}");

        /// <summary>Creates a <see cref="AccountBudgetProposalName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountBudgetProposalName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountBudgetProposalName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountBudgetProposalName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccountBudgetProposalName"/> with the pattern
        /// <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountBudgetProposalId">
        /// The <c>AccountBudgetProposal</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AccountBudgetProposalName"/> constructed from the provided ids.
        /// </returns>
        public static AccountBudgetProposalName FromCustomerAccountBudgetProposal(string customerId, string accountBudgetProposalId) =>
            new AccountBudgetProposalName(ResourceNameType.CustomerAccountBudgetProposal, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), accountBudgetProposalId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountBudgetProposalId, nameof(accountBudgetProposalId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountBudgetProposalName"/> with pattern
        /// <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountBudgetProposalId">
        /// The <c>AccountBudgetProposal</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AccountBudgetProposalName"/> with pattern
        /// <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>.
        /// </returns>
        public static string Format(string customerId, string accountBudgetProposalId) =>
            FormatCustomerAccountBudgetProposal(customerId, accountBudgetProposalId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountBudgetProposalName"/> with pattern
        /// <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountBudgetProposalId">
        /// The <c>AccountBudgetProposal</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AccountBudgetProposalName"/> with pattern
        /// <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>.
        /// </returns>
        public static string FormatCustomerAccountBudgetProposal(string customerId, string accountBudgetProposalId) =>
            s_customerAccountBudgetProposal.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accountBudgetProposalId, nameof(accountBudgetProposalId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountBudgetProposalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="accountBudgetProposalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountBudgetProposalName"/> if successful.</returns>
        public static AccountBudgetProposalName Parse(string accountBudgetProposalName) =>
            Parse(accountBudgetProposalName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountBudgetProposalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountBudgetProposalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountBudgetProposalName"/> if successful.</returns>
        public static AccountBudgetProposalName Parse(string accountBudgetProposalName, bool allowUnparsed) =>
            TryParse(accountBudgetProposalName, allowUnparsed, out AccountBudgetProposalName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountBudgetProposalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="accountBudgetProposalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountBudgetProposalName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountBudgetProposalName, out AccountBudgetProposalName result) =>
            TryParse(accountBudgetProposalName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountBudgetProposalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountBudgetProposalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountBudgetProposalName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountBudgetProposalName, bool allowUnparsed, out AccountBudgetProposalName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountBudgetProposalName, nameof(accountBudgetProposalName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAccountBudgetProposal.TryParseName(accountBudgetProposalName, out resourceName))
            {
                result = FromCustomerAccountBudgetProposal(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountBudgetProposalName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountBudgetProposalName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountBudgetProposalId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountBudgetProposalId = accountBudgetProposalId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountBudgetProposalName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/accountBudgetProposals/{account_budget_proposal_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountBudgetProposalId">
        /// The <c>AccountBudgetProposal</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AccountBudgetProposalName(string customerId, string accountBudgetProposalId) : this(ResourceNameType.CustomerAccountBudgetProposal, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), accountBudgetProposalId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountBudgetProposalId, nameof(accountBudgetProposalId)))
        {
        }

        /// <summary>The <see cref="ResourceNameType"/> of the contained resource name.</summary>
        public ResourceNameType Type { get; }

        /// <summary>
        /// The contained <see cref="gax::UnparsedResourceName"/>. Only non-<c>null</c> if this instance contains an
        /// unparsed resource name.
        /// </summary>
        public gax::UnparsedResourceName UnparsedResource { get; }

        /// <summary>
        /// The <c>AccountBudgetProposal</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AccountBudgetProposalId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerAccountBudgetProposal: return s_customerAccountBudgetProposal.Expand(CustomerId, AccountBudgetProposalId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountBudgetProposalName);

        /// <inheritdoc/>
        public bool Equals(AccountBudgetProposalName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AccountBudgetProposalName a, AccountBudgetProposalName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AccountBudgetProposalName a, AccountBudgetProposalName b) => !(a == b);
    }

    public partial class AccountBudgetProposal
    {
        /// <summary>
        /// <see cref="AccountBudgetProposalName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal AccountBudgetProposalName ResourceNameAsAccountBudgetProposalName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AccountBudgetProposalName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BillingSetupName"/>-typed view over the <see cref="BillingSetup"/> resource name property.
        /// </summary>
        internal BillingSetupName BillingSetupAsBillingSetupName
        {
            get => string.IsNullOrEmpty(BillingSetup) ? null : BillingSetupName.Parse(BillingSetup, allowUnparsed: true);
            set => BillingSetup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AccountBudgetName"/>-typed view over the <see cref="AccountBudget"/> resource name property.
        /// </summary>
        internal AccountBudgetName AccountBudgetAsAccountBudgetName
        {
            get => string.IsNullOrEmpty(AccountBudget) ? null : AccountBudgetName.Parse(AccountBudget, allowUnparsed: true);
            set => AccountBudget = value?.ToString() ?? "";
        }
    }
}

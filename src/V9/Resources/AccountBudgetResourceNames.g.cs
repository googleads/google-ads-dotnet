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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V9.Resources
{
    /// <summary>Resource name for the <c>AccountBudget</c> resource.</summary>
    public sealed partial class AccountBudgetName : gax::IResourceName, sys::IEquatable<AccountBudgetName>
    {
        /// <summary>The possible contents of <see cref="AccountBudgetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/accountBudgets/{account_budget_id}</c>.
            /// </summary>
            CustomerAccountBudget = 1,
        }

        private static gax::PathTemplate s_customerAccountBudget = new gax::PathTemplate("customers/{customer_id}/accountBudgets/{account_budget_id}");

        /// <summary>Creates a <see cref="AccountBudgetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountBudgetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountBudgetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountBudgetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccountBudgetName"/> with the pattern
        /// <c>customers/{customer_id}/accountBudgets/{account_budget_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountBudgetId">The <c>AccountBudget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccountBudgetName"/> constructed from the provided ids.</returns>
        public static AccountBudgetName FromCustomerAccountBudget(string customerId, string accountBudgetId) =>
            new AccountBudgetName(ResourceNameType.CustomerAccountBudget, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), accountBudgetId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountBudgetId, nameof(accountBudgetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountBudgetName"/> with pattern
        /// <c>customers/{customer_id}/accountBudgets/{account_budget_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountBudgetId">The <c>AccountBudget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountBudgetName"/> with pattern
        /// <c>customers/{customer_id}/accountBudgets/{account_budget_id}</c>.
        /// </returns>
        public static string Format(string customerId, string accountBudgetId) =>
            FormatCustomerAccountBudget(customerId, accountBudgetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountBudgetName"/> with pattern
        /// <c>customers/{customer_id}/accountBudgets/{account_budget_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountBudgetId">The <c>AccountBudget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountBudgetName"/> with pattern
        /// <c>customers/{customer_id}/accountBudgets/{account_budget_id}</c>.
        /// </returns>
        public static string FormatCustomerAccountBudget(string customerId, string accountBudgetId) =>
            s_customerAccountBudget.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accountBudgetId, nameof(accountBudgetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountBudgetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/accountBudgets/{account_budget_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accountBudgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountBudgetName"/> if successful.</returns>
        public static AccountBudgetName Parse(string accountBudgetName) => Parse(accountBudgetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountBudgetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/accountBudgets/{account_budget_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountBudgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountBudgetName"/> if successful.</returns>
        public static AccountBudgetName Parse(string accountBudgetName, bool allowUnparsed) =>
            TryParse(accountBudgetName, allowUnparsed, out AccountBudgetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountBudgetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/accountBudgets/{account_budget_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accountBudgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountBudgetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountBudgetName, out AccountBudgetName result) =>
            TryParse(accountBudgetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountBudgetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/accountBudgets/{account_budget_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountBudgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountBudgetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountBudgetName, bool allowUnparsed, out AccountBudgetName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountBudgetName, nameof(accountBudgetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAccountBudget.TryParseName(accountBudgetName, out resourceName))
            {
                result = FromCustomerAccountBudget(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountBudgetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountBudgetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountBudgetId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountBudgetId = accountBudgetId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountBudgetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/accountBudgets/{account_budget_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountBudgetId">The <c>AccountBudget</c> ID. Must not be <c>null</c> or empty.</param>
        public AccountBudgetName(string customerId, string accountBudgetId) : this(ResourceNameType.CustomerAccountBudget, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), accountBudgetId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountBudgetId, nameof(accountBudgetId)))
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
        /// The <c>AccountBudget</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AccountBudgetId { get; }

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
                case ResourceNameType.CustomerAccountBudget: return s_customerAccountBudget.Expand(CustomerId, AccountBudgetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountBudgetName);

        /// <inheritdoc/>
        public bool Equals(AccountBudgetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AccountBudgetName a, AccountBudgetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AccountBudgetName a, AccountBudgetName b) => !(a == b);
    }

    public partial class AccountBudget
    {
        /// <summary>
        /// <see cref="gagvr::AccountBudgetName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal AccountBudgetName ResourceNameAsAccountBudgetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::AccountBudgetName.Parse(ResourceName, allowUnparsed: true);
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
        /// <see cref="gagvr::AccountBudgetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal AccountBudgetName AccountBudgetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::AccountBudgetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

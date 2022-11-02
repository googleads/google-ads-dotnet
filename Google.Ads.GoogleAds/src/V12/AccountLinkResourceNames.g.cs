// Copyright 2022 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V12.Resources
{
    /// <summary>Resource name for the <c>AccountLink</c> resource.</summary>
    public sealed partial class AccountLinkName : gax::IResourceName, sys::IEquatable<AccountLinkName>
    {
        /// <summary>The possible contents of <see cref="AccountLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/accountLinks/{account_link_id}</c>.
            /// </summary>
            CustomerAccountLink = 1,
        }

        private static gax::PathTemplate s_customerAccountLink = new gax::PathTemplate("customers/{customer_id}/accountLinks/{account_link_id}");

        /// <summary>Creates a <see cref="AccountLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AccountLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AccountLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AccountLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AccountLinkName"/> with the pattern
        /// <c>customers/{customer_id}/accountLinks/{account_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountLinkId">The <c>AccountLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AccountLinkName"/> constructed from the provided ids.</returns>
        public static AccountLinkName FromCustomerAccountLink(string customerId, string accountLinkId) =>
            new AccountLinkName(ResourceNameType.CustomerAccountLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), accountLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountLinkId, nameof(accountLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountLinkName"/> with pattern
        /// <c>customers/{customer_id}/accountLinks/{account_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountLinkId">The <c>AccountLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountLinkName"/> with pattern
        /// <c>customers/{customer_id}/accountLinks/{account_link_id}</c>.
        /// </returns>
        public static string Format(string customerId, string accountLinkId) =>
            FormatCustomerAccountLink(customerId, accountLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AccountLinkName"/> with pattern
        /// <c>customers/{customer_id}/accountLinks/{account_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountLinkId">The <c>AccountLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AccountLinkName"/> with pattern
        /// <c>customers/{customer_id}/accountLinks/{account_link_id}</c>.
        /// </returns>
        public static string FormatCustomerAccountLink(string customerId, string accountLinkId) =>
            s_customerAccountLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(accountLinkId, nameof(accountLinkId)));

        /// <summary>Parses the given resource name string into a new <see cref="AccountLinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/accountLinks/{account_link_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accountLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AccountLinkName"/> if successful.</returns>
        public static AccountLinkName Parse(string accountLinkName) => Parse(accountLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AccountLinkName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/accountLinks/{account_link_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AccountLinkName"/> if successful.</returns>
        public static AccountLinkName Parse(string accountLinkName, bool allowUnparsed) =>
            TryParse(accountLinkName, allowUnparsed, out AccountLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/accountLinks/{account_link_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="accountLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountLinkName, out AccountLinkName result) =>
            TryParse(accountLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AccountLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/accountLinks/{account_link_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="accountLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AccountLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string accountLinkName, bool allowUnparsed, out AccountLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(accountLinkName, nameof(accountLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAccountLink.TryParseName(accountLinkName, out resourceName))
            {
                result = FromCustomerAccountLink(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(accountLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AccountLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string accountLinkId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AccountLinkId = accountLinkId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AccountLinkName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/accountLinks/{account_link_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="accountLinkId">The <c>AccountLink</c> ID. Must not be <c>null</c> or empty.</param>
        public AccountLinkName(string customerId, string accountLinkId) : this(ResourceNameType.CustomerAccountLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), accountLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(accountLinkId, nameof(accountLinkId)))
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
        /// The <c>AccountLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AccountLinkId { get; }

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
                case ResourceNameType.CustomerAccountLink: return s_customerAccountLink.Expand(CustomerId, AccountLinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AccountLinkName);

        /// <inheritdoc/>
        public bool Equals(AccountLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AccountLinkName a, AccountLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AccountLinkName a, AccountLinkName b) => !(a == b);
    }

    public partial class AccountLink
    {
        /// <summary>
        /// <see cref="AccountLinkName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AccountLinkName ResourceNameAsAccountLinkName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AccountLinkName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }

    public partial class GoogleAdsLinkIdentifier
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Customer"/> resource name property.
        /// </summary>
        internal CustomerName CustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(Customer) ? null : CustomerName.Parse(Customer, allowUnparsed: true);
            set => Customer = value?.ToString() ?? "";
        }
    }

    public partial class AdvertisingPartnerLinkIdentifier
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Customer"/> resource name property.
        /// </summary>
        internal CustomerName CustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(Customer) ? null : CustomerName.Parse(Customer, allowUnparsed: true);
            set => Customer = value?.ToString() ?? "";
        }
    }
}

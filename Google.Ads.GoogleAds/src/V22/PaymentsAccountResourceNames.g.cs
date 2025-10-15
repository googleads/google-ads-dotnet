// Copyright 2025 Google LLC
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
using gagvr = Google.Ads.GoogleAds.V22.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V22.Resources
{
    /// <summary>Resource name for the <c>PaymentsAccount</c> resource.</summary>
    public sealed partial class PaymentsAccountName : gax::IResourceName, sys::IEquatable<PaymentsAccountName>
    {
        /// <summary>The possible contents of <see cref="PaymentsAccountName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c>.
            /// </summary>
            CustomerPaymentsAccount = 1,
        }

        private static gax::PathTemplate s_customerPaymentsAccount = new gax::PathTemplate("customers/{customer_id}/paymentsAccounts/{payments_account_id}");

        /// <summary>Creates a <see cref="PaymentsAccountName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PaymentsAccountName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PaymentsAccountName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PaymentsAccountName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PaymentsAccountName"/> with the pattern
        /// <c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="paymentsAccountId">The <c>PaymentsAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="PaymentsAccountName"/> constructed from the provided ids.</returns>
        public static PaymentsAccountName FromCustomerPaymentsAccount(string customerId, string paymentsAccountId) =>
            new PaymentsAccountName(ResourceNameType.CustomerPaymentsAccount, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), paymentsAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(paymentsAccountId, nameof(paymentsAccountId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PaymentsAccountName"/> with pattern
        /// <c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="paymentsAccountId">The <c>PaymentsAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PaymentsAccountName"/> with pattern
        /// <c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c>.
        /// </returns>
        public static string Format(string customerId, string paymentsAccountId) =>
            FormatCustomerPaymentsAccount(customerId, paymentsAccountId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PaymentsAccountName"/> with pattern
        /// <c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="paymentsAccountId">The <c>PaymentsAccount</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PaymentsAccountName"/> with pattern
        /// <c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c>.
        /// </returns>
        public static string FormatCustomerPaymentsAccount(string customerId, string paymentsAccountId) =>
            s_customerPaymentsAccount.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(paymentsAccountId, nameof(paymentsAccountId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PaymentsAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="paymentsAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="PaymentsAccountName"/> if successful.</returns>
        public static PaymentsAccountName Parse(string paymentsAccountName) => Parse(paymentsAccountName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PaymentsAccountName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="paymentsAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PaymentsAccountName"/> if successful.</returns>
        public static PaymentsAccountName Parse(string paymentsAccountName, bool allowUnparsed) =>
            TryParse(paymentsAccountName, allowUnparsed, out PaymentsAccountName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PaymentsAccountName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="paymentsAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PaymentsAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string paymentsAccountName, out PaymentsAccountName result) =>
            TryParse(paymentsAccountName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PaymentsAccountName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="paymentsAccountName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PaymentsAccountName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string paymentsAccountName, bool allowUnparsed, out PaymentsAccountName result)
        {
            gax::GaxPreconditions.CheckNotNull(paymentsAccountName, nameof(paymentsAccountName));
            gax::TemplatedResourceName resourceName;
            if (s_customerPaymentsAccount.TryParseName(paymentsAccountName, out resourceName))
            {
                result = FromCustomerPaymentsAccount(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(paymentsAccountName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PaymentsAccountName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string paymentsAccountId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            PaymentsAccountId = paymentsAccountId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PaymentsAccountName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/paymentsAccounts/{payments_account_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="paymentsAccountId">The <c>PaymentsAccount</c> ID. Must not be <c>null</c> or empty.</param>
        public PaymentsAccountName(string customerId, string paymentsAccountId) : this(ResourceNameType.CustomerPaymentsAccount, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), paymentsAccountId: gax::GaxPreconditions.CheckNotNullOrEmpty(paymentsAccountId, nameof(paymentsAccountId)))
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
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>PaymentsAccount</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string PaymentsAccountId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerPaymentsAccount: return s_customerPaymentsAccount.Expand(CustomerId, PaymentsAccountId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PaymentsAccountName);

        /// <inheritdoc/>
        public bool Equals(PaymentsAccountName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PaymentsAccountName a, PaymentsAccountName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PaymentsAccountName a, PaymentsAccountName b) => !(a == b);
    }

    public partial class PaymentsAccount
    {
        /// <summary>
        /// <see cref="gagvr::PaymentsAccountName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::PaymentsAccountName ResourceNameAsPaymentsAccountName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::PaymentsAccountName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::PaymentsAccountName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::PaymentsAccountName PaymentsAccountName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::PaymentsAccountName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="PayingManagerCustomer"/> resource name property.
        /// </summary>
        internal CustomerName PayingManagerCustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(PayingManagerCustomer) ? null : CustomerName.Parse(PayingManagerCustomer, allowUnparsed: true);
            set => PayingManagerCustomer = value?.ToString() ?? "";
        }
    }
}

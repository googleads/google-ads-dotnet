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

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V11.Resources
{
    /// <summary>Resource name for the <c>ThirdPartyAppAnalyticsLink</c> resource.</summary>
    public sealed partial class ThirdPartyAppAnalyticsLinkName : gax::IResourceName, sys::IEquatable<ThirdPartyAppAnalyticsLinkName>
    {
        /// <summary>The possible contents of <see cref="ThirdPartyAppAnalyticsLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c>
            /// .
            /// </summary>
            CustomerCustomerLink = 1,
        }

        private static gax::PathTemplate s_customerCustomerLink = new gax::PathTemplate("customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}");

        /// <summary>
        /// Creates a <see cref="ThirdPartyAppAnalyticsLinkName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ThirdPartyAppAnalyticsLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ThirdPartyAppAnalyticsLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ThirdPartyAppAnalyticsLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ThirdPartyAppAnalyticsLinkName"/> with the pattern
        /// <c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerLinkId">The <c>CustomerLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ThirdPartyAppAnalyticsLinkName"/> constructed from the provided ids.
        /// </returns>
        public static ThirdPartyAppAnalyticsLinkName FromCustomerCustomerLink(string customerId, string customerLinkId) =>
            new ThirdPartyAppAnalyticsLinkName(ResourceNameType.CustomerCustomerLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerLinkId, nameof(customerLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ThirdPartyAppAnalyticsLinkName"/> with
        /// pattern <c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerLinkId">The <c>CustomerLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ThirdPartyAppAnalyticsLinkName"/> with pattern
        /// <c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c>.
        /// </returns>
        public static string Format(string customerId, string customerLinkId) =>
            FormatCustomerCustomerLink(customerId, customerLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ThirdPartyAppAnalyticsLinkName"/> with
        /// pattern <c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerLinkId">The <c>CustomerLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ThirdPartyAppAnalyticsLinkName"/> with pattern
        /// <c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c>.
        /// </returns>
        public static string FormatCustomerCustomerLink(string customerId, string customerLinkId) =>
            s_customerCustomerLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customerLinkId, nameof(customerLinkId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ThirdPartyAppAnalyticsLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="thirdPartyAppAnalyticsLinkName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ThirdPartyAppAnalyticsLinkName"/> if successful.</returns>
        public static ThirdPartyAppAnalyticsLinkName Parse(string thirdPartyAppAnalyticsLinkName) =>
            Parse(thirdPartyAppAnalyticsLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ThirdPartyAppAnalyticsLinkName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="thirdPartyAppAnalyticsLinkName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ThirdPartyAppAnalyticsLinkName"/> if successful.</returns>
        public static ThirdPartyAppAnalyticsLinkName Parse(string thirdPartyAppAnalyticsLinkName, bool allowUnparsed) =>
            TryParse(thirdPartyAppAnalyticsLinkName, allowUnparsed, out ThirdPartyAppAnalyticsLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ThirdPartyAppAnalyticsLinkName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="thirdPartyAppAnalyticsLinkName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ThirdPartyAppAnalyticsLinkName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string thirdPartyAppAnalyticsLinkName, out ThirdPartyAppAnalyticsLinkName result) =>
            TryParse(thirdPartyAppAnalyticsLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ThirdPartyAppAnalyticsLinkName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="thirdPartyAppAnalyticsLinkName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ThirdPartyAppAnalyticsLinkName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string thirdPartyAppAnalyticsLinkName, bool allowUnparsed, out ThirdPartyAppAnalyticsLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(thirdPartyAppAnalyticsLinkName, nameof(thirdPartyAppAnalyticsLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCustomerLink.TryParseName(thirdPartyAppAnalyticsLinkName, out resourceName))
            {
                result = FromCustomerCustomerLink(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(thirdPartyAppAnalyticsLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ThirdPartyAppAnalyticsLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string customerLinkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            CustomerLinkId = customerLinkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ThirdPartyAppAnalyticsLinkName"/> class from the component parts
        /// of pattern <c>customers/{customer_id}/thirdPartyAppAnalyticsLinks/{customer_link_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerLinkId">The <c>CustomerLink</c> ID. Must not be <c>null</c> or empty.</param>
        public ThirdPartyAppAnalyticsLinkName(string customerId, string customerLinkId) : this(ResourceNameType.CustomerCustomerLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerLinkId, nameof(customerLinkId)))
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
        /// The <c>CustomerLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CustomerLinkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCustomerLink: return s_customerCustomerLink.Expand(CustomerId, CustomerLinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ThirdPartyAppAnalyticsLinkName);

        /// <inheritdoc/>
        public bool Equals(ThirdPartyAppAnalyticsLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ThirdPartyAppAnalyticsLinkName a, ThirdPartyAppAnalyticsLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ThirdPartyAppAnalyticsLinkName a, ThirdPartyAppAnalyticsLinkName b) => !(a == b);
    }

    public partial class ThirdPartyAppAnalyticsLink
    {
        /// <summary>
        /// <see cref="ThirdPartyAppAnalyticsLinkName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal ThirdPartyAppAnalyticsLinkName ResourceNameAsThirdPartyAppAnalyticsLinkName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ThirdPartyAppAnalyticsLinkName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

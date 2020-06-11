// Copyright 2020 Google LLC
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

namespace Google.Ads.GoogleAds.V2.Resources
{
    /// <summary>Resource name for the <c>CustomerClientLink</c> resource.</summary>
    public sealed partial class CustomerClientLinkName : gax::IResourceName, sys::IEquatable<CustomerClientLinkName>
    {
        /// <summary>The possible contents of <see cref="CustomerClientLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/customerClientLinks/{customer_client_link}</c>.
            /// </summary>
            CustomerCustomerClientLink = 1
        }

        private static gax::PathTemplate s_customerCustomerClientLink = new gax::PathTemplate("customers/{customer}/customerClientLinks/{customer_client_link}");

        /// <summary>Creates a <see cref="CustomerClientLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerClientLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerClientLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerClientLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerClientLinkName"/> with the pattern
        /// <c>customers/{customer}/customerClientLinks/{customer_client_link}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerClientLinkId">
        /// The <c>CustomerClientLink</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="CustomerClientLinkName"/> constructed from the provided ids.</returns>
        public static CustomerClientLinkName FromCustomerCustomerClientLink(string customerId, string customerClientLinkId) =>
            new CustomerClientLinkName(ResourceNameType.CustomerCustomerClientLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerClientLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerClientLinkId, nameof(customerClientLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerClientLinkName"/> with pattern
        /// <c>customers/{customer}/customerClientLinks/{customer_client_link}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerClientLinkId">
        /// The <c>CustomerClientLink</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomerClientLinkName"/> with pattern
        /// <c>customers/{customer}/customerClientLinks/{customer_client_link}</c>.
        /// </returns>
        public static string Format(string customerId, string customerClientLinkId) =>
            FormatCustomerCustomerClientLink(customerId, customerClientLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerClientLinkName"/> with pattern
        /// <c>customers/{customer}/customerClientLinks/{customer_client_link}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerClientLinkId">
        /// The <c>CustomerClientLink</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomerClientLinkName"/> with pattern
        /// <c>customers/{customer}/customerClientLinks/{customer_client_link}</c>.
        /// </returns>
        public static string FormatCustomerCustomerClientLink(string customerId, string customerClientLinkId) =>
            s_customerCustomerClientLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customerClientLinkId, nameof(customerClientLinkId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerClientLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/customerClientLinks/{customer_client_link}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerClientLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerClientLinkName"/> if successful.</returns>
        public static CustomerClientLinkName Parse(string customerClientLinkName) => Parse(customerClientLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerClientLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/customerClientLinks/{customer_client_link}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerClientLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerClientLinkName"/> if successful.</returns>
        public static CustomerClientLinkName Parse(string customerClientLinkName, bool allowUnparsed) =>
            TryParse(customerClientLinkName, allowUnparsed, out CustomerClientLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerClientLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/customerClientLinks/{customer_client_link}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerClientLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerClientLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerClientLinkName, out CustomerClientLinkName result) =>
            TryParse(customerClientLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerClientLinkName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/customerClientLinks/{customer_client_link}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerClientLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerClientLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerClientLinkName, bool allowUnparsed, out CustomerClientLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerClientLinkName, nameof(customerClientLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCustomerClientLink.TryParseName(customerClientLinkName, out resourceName))
            {
                result = FromCustomerCustomerClientLink(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerClientLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerClientLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string customerClientLinkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            CustomerClientLinkId = customerClientLinkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerClientLinkName"/> class from the component parts of
        /// pattern <c>customers/{customer}/customerClientLinks/{customer_client_link}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerClientLinkId">
        /// The <c>CustomerClientLink</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CustomerClientLinkName(string customerId, string customerClientLinkId) : this(ResourceNameType.CustomerCustomerClientLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerClientLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerClientLinkId, nameof(customerClientLinkId)))
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
        /// The <c>CustomerClientLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CustomerClientLinkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCustomerClientLink: return s_customerCustomerClientLink.Expand(CustomerId, CustomerClientLinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerClientLinkName);

        /// <inheritdoc/>
        public bool Equals(CustomerClientLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerClientLinkName a, CustomerClientLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerClientLinkName a, CustomerClientLinkName b) => !(a == b);
    }

    public partial class CustomerClientLink
    {
        /// <summary>
        /// <see cref="CustomerClientLinkName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CustomerClientLinkName ResourceNameAsCustomerClientLinkName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerClientLinkName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

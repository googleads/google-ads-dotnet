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

namespace Google.Ads.GoogleAds.V4.Resources
{
    /// <summary>Resource name for the <c>CustomerManagerLink</c> resource.</summary>
    public sealed partial class CustomerManagerLinkName : gax::IResourceName, sys::IEquatable<CustomerManagerLinkName>
    {
        /// <summary>The possible contents of <see cref="CustomerManagerLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c>.
            /// </summary>
            CustomerCustomerManagerLink = 1,
        }

        private static gax::PathTemplate s_customerCustomerManagerLink = new gax::PathTemplate("customers/{customer}/customerManagerLinks/{customer_manager_link}");

        /// <summary>Creates a <see cref="CustomerManagerLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerManagerLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerManagerLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerManagerLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerManagerLinkName"/> with the pattern
        /// <c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerManagerLinkId">
        /// The <c>CustomerManagerLink</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CustomerManagerLinkName"/> constructed from the provided ids.
        /// </returns>
        public static CustomerManagerLinkName FromCustomerCustomerManagerLink(string customerId, string customerManagerLinkId) =>
            new CustomerManagerLinkName(ResourceNameType.CustomerCustomerManagerLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerManagerLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerManagerLinkId, nameof(customerManagerLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerManagerLinkName"/> with pattern
        /// <c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerManagerLinkId">
        /// The <c>CustomerManagerLink</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomerManagerLinkName"/> with pattern
        /// <c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c>.
        /// </returns>
        public static string Format(string customerId, string customerManagerLinkId) =>
            FormatCustomerCustomerManagerLink(customerId, customerManagerLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerManagerLinkName"/> with pattern
        /// <c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerManagerLinkId">
        /// The <c>CustomerManagerLink</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomerManagerLinkName"/> with pattern
        /// <c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c>.
        /// </returns>
        public static string FormatCustomerCustomerManagerLink(string customerId, string customerManagerLinkId) =>
            s_customerCustomerManagerLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customerManagerLinkId, nameof(customerManagerLinkId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerManagerLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerManagerLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerManagerLinkName"/> if successful.</returns>
        public static CustomerManagerLinkName Parse(string customerManagerLinkName) => Parse(customerManagerLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerManagerLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerManagerLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerManagerLinkName"/> if successful.</returns>
        public static CustomerManagerLinkName Parse(string customerManagerLinkName, bool allowUnparsed) =>
            TryParse(customerManagerLinkName, allowUnparsed, out CustomerManagerLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerManagerLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerManagerLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerManagerLinkName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerManagerLinkName, out CustomerManagerLinkName result) =>
            TryParse(customerManagerLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerManagerLinkName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerManagerLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerManagerLinkName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerManagerLinkName, bool allowUnparsed, out CustomerManagerLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerManagerLinkName, nameof(customerManagerLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCustomerManagerLink.TryParseName(customerManagerLinkName, out resourceName))
            {
                result = FromCustomerCustomerManagerLink(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerManagerLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerManagerLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string customerManagerLinkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            CustomerManagerLinkId = customerManagerLinkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerManagerLinkName"/> class from the component parts of
        /// pattern <c>customers/{customer}/customerManagerLinks/{customer_manager_link}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerManagerLinkId">
        /// The <c>CustomerManagerLink</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CustomerManagerLinkName(string customerId, string customerManagerLinkId) : this(ResourceNameType.CustomerCustomerManagerLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerManagerLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerManagerLinkId, nameof(customerManagerLinkId)))
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
        /// The <c>CustomerManagerLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CustomerManagerLinkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCustomerManagerLink: return s_customerCustomerManagerLink.Expand(CustomerId, CustomerManagerLinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerManagerLinkName);

        /// <inheritdoc/>
        public bool Equals(CustomerManagerLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerManagerLinkName a, CustomerManagerLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerManagerLinkName a, CustomerManagerLinkName b) => !(a == b);
    }

    public partial class CustomerManagerLink
    {
        /// <summary>
        /// <see cref="CustomerManagerLinkName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CustomerManagerLinkName ResourceNameAsCustomerManagerLinkName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerManagerLinkName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

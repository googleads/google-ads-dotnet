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

namespace Google.Ads.GoogleAds.V5.Resources
{
    /// <summary>Resource name for the <c>CustomerClient</c> resource.</summary>
    public sealed partial class CustomerClientName : gax::IResourceName, sys::IEquatable<CustomerClientName>
    {
        /// <summary>The possible contents of <see cref="CustomerClientName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/customerClients/{customer_client}</c>.
            /// </summary>
            CustomerCustomerClient = 1,
        }

        private static gax::PathTemplate s_customerCustomerClient = new gax::PathTemplate("customers/{customer}/customerClients/{customer_client}");

        /// <summary>Creates a <see cref="CustomerClientName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerClientName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerClientName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerClientName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerClientName"/> with the pattern
        /// <c>customers/{customer}/customerClients/{customer_client}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerClientId">The <c>CustomerClient</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomerClientName"/> constructed from the provided ids.</returns>
        public static CustomerClientName FromCustomerCustomerClient(string customerId, string customerClientId) =>
            new CustomerClientName(ResourceNameType.CustomerCustomerClient, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerClientId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerClientId, nameof(customerClientId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerClientName"/> with pattern
        /// <c>customers/{customer}/customerClients/{customer_client}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerClientId">The <c>CustomerClient</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerClientName"/> with pattern
        /// <c>customers/{customer}/customerClients/{customer_client}</c>.
        /// </returns>
        public static string Format(string customerId, string customerClientId) =>
            FormatCustomerCustomerClient(customerId, customerClientId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerClientName"/> with pattern
        /// <c>customers/{customer}/customerClients/{customer_client}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerClientId">The <c>CustomerClient</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerClientName"/> with pattern
        /// <c>customers/{customer}/customerClients/{customer_client}</c>.
        /// </returns>
        public static string FormatCustomerCustomerClient(string customerId, string customerClientId) =>
            s_customerCustomerClient.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customerClientId, nameof(customerClientId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerClientName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/customerClients/{customer_client}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerClientName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerClientName"/> if successful.</returns>
        public static CustomerClientName Parse(string customerClientName) => Parse(customerClientName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerClientName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/customerClients/{customer_client}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerClientName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerClientName"/> if successful.</returns>
        public static CustomerClientName Parse(string customerClientName, bool allowUnparsed) =>
            TryParse(customerClientName, allowUnparsed, out CustomerClientName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerClientName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/customerClients/{customer_client}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerClientName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerClientName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerClientName, out CustomerClientName result) =>
            TryParse(customerClientName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerClientName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/customerClients/{customer_client}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerClientName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerClientName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerClientName, bool allowUnparsed, out CustomerClientName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerClientName, nameof(customerClientName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCustomerClient.TryParseName(customerClientName, out resourceName))
            {
                result = FromCustomerCustomerClient(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerClientName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerClientName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string customerClientId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            CustomerClientId = customerClientId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerClientName"/> class from the component parts of pattern
        /// <c>customers/{customer}/customerClients/{customer_client}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerClientId">The <c>CustomerClient</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerClientName(string customerId, string customerClientId) : this(ResourceNameType.CustomerCustomerClient, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerClientId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerClientId, nameof(customerClientId)))
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
        /// The <c>CustomerClient</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CustomerClientId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCustomerClient: return s_customerCustomerClient.Expand(CustomerId, CustomerClientId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerClientName);

        /// <inheritdoc/>
        public bool Equals(CustomerClientName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerClientName a, CustomerClientName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerClientName a, CustomerClientName b) => !(a == b);
    }

    public partial class CustomerClient
    {
        /// <summary>
        /// <see cref="CustomerClientName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CustomerClientName ResourceNameAsCustomerClientName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerClientName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="ClientCustomer"/> resource name property.
        /// </summary>
        internal CustomerName ClientCustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(ClientCustomer) ? null : CustomerName.Parse(ClientCustomer, allowUnparsed: true);
            set => ClientCustomer = value?.ToString() ?? "";
        }
    }
}

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
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V20.Resources
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
            /// A resource name with pattern <c>customers/{customer_id}/customerClients/{client_customer_id}</c>.
            /// </summary>
            CustomerClientCustomer = 1,
        }

        private static gax::PathTemplate s_customerClientCustomer = new gax::PathTemplate("customers/{customer_id}/customerClients/{client_customer_id}");

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
        /// <c>customers/{customer_id}/customerClients/{client_customer_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientCustomerId">The <c>ClientCustomer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomerClientName"/> constructed from the provided ids.</returns>
        public static CustomerClientName FromCustomerClientCustomer(string customerId, string clientCustomerId) =>
            new CustomerClientName(ResourceNameType.CustomerClientCustomer, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), clientCustomerId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientCustomerId, nameof(clientCustomerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerClientName"/> with pattern
        /// <c>customers/{customer_id}/customerClients/{client_customer_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientCustomerId">The <c>ClientCustomer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerClientName"/> with pattern
        /// <c>customers/{customer_id}/customerClients/{client_customer_id}</c>.
        /// </returns>
        public static string Format(string customerId, string clientCustomerId) =>
            FormatCustomerClientCustomer(customerId, clientCustomerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerClientName"/> with pattern
        /// <c>customers/{customer_id}/customerClients/{client_customer_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientCustomerId">The <c>ClientCustomer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerClientName"/> with pattern
        /// <c>customers/{customer_id}/customerClients/{client_customer_id}</c>.
        /// </returns>
        public static string FormatCustomerClientCustomer(string customerId, string clientCustomerId) =>
            s_customerClientCustomer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clientCustomerId, nameof(clientCustomerId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerClientName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerClients/{client_customer_id}</c></description></item>
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
        /// <item><description><c>customers/{customer_id}/customerClients/{client_customer_id}</c></description></item>
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
        /// <item><description><c>customers/{customer_id}/customerClients/{client_customer_id}</c></description></item>
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
        /// <item><description><c>customers/{customer_id}/customerClients/{client_customer_id}</c></description></item>
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
            if (s_customerClientCustomer.TryParseName(customerClientName, out resourceName))
            {
                result = FromCustomerClientCustomer(resourceName[0], resourceName[1]);
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

        private CustomerClientName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clientCustomerId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClientCustomerId = clientCustomerId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerClientName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/customerClients/{client_customer_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientCustomerId">The <c>ClientCustomer</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerClientName(string customerId, string clientCustomerId) : this(ResourceNameType.CustomerClientCustomer, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), clientCustomerId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientCustomerId, nameof(clientCustomerId)))
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
        /// The <c>ClientCustomer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ClientCustomerId { get; }

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
                case ResourceNameType.CustomerClientCustomer: return s_customerClientCustomer.Expand(CustomerId, ClientCustomerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerClientName);

        /// <inheritdoc/>
        public bool Equals(CustomerClientName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomerClientName a, CustomerClientName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
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

        /// <summary>
        /// <see cref="LabelName"/>-typed view over the <see cref="AppliedLabels"/> resource name property.
        /// </summary>
        internal gax::ResourceNameList<LabelName> AppliedLabelsAsLabelNames
        {
            get => new gax::ResourceNameList<LabelName>(AppliedLabels, s => string.IsNullOrEmpty(s) ? null : LabelName.Parse(s, allowUnparsed: true));
        }
    }
}

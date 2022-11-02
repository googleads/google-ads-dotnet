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
    /// <summary>Resource name for the <c>CustomerCustomizer</c> resource.</summary>
    public sealed partial class CustomerCustomizerName : gax::IResourceName, sys::IEquatable<CustomerCustomizerName>
    {
        /// <summary>The possible contents of <see cref="CustomerCustomizerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c>
            /// .
            /// </summary>
            CustomerCustomizerAttribute = 1,
        }

        private static gax::PathTemplate s_customerCustomizerAttribute = new gax::PathTemplate("customers/{customer_id}/customerCustomizers/{customizer_attribute_id}");

        /// <summary>Creates a <see cref="CustomerCustomizerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerCustomizerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerCustomizerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerCustomizerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerCustomizerName"/> with the pattern
        /// <c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customizerAttributeId">
        /// The <c>CustomizerAttribute</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="CustomerCustomizerName"/> constructed from the provided ids.</returns>
        public static CustomerCustomizerName FromCustomerCustomizerAttribute(string customerId, string customizerAttributeId) =>
            new CustomerCustomizerName(ResourceNameType.CustomerCustomizerAttribute, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customizerAttributeId: gax::GaxPreconditions.CheckNotNullOrEmpty(customizerAttributeId, nameof(customizerAttributeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerCustomizerName"/> with pattern
        /// <c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customizerAttributeId">
        /// The <c>CustomizerAttribute</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomerCustomizerName"/> with pattern
        /// <c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c>.
        /// </returns>
        public static string Format(string customerId, string customizerAttributeId) =>
            FormatCustomerCustomizerAttribute(customerId, customizerAttributeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerCustomizerName"/> with pattern
        /// <c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customizerAttributeId">
        /// The <c>CustomizerAttribute</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomerCustomizerName"/> with pattern
        /// <c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c>.
        /// </returns>
        public static string FormatCustomerCustomizerAttribute(string customerId, string customizerAttributeId) =>
            s_customerCustomizerAttribute.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customizerAttributeId, nameof(customizerAttributeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerCustomizerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerCustomizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerCustomizerName"/> if successful.</returns>
        public static CustomerCustomizerName Parse(string customerCustomizerName) => Parse(customerCustomizerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerCustomizerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerCustomizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerCustomizerName"/> if successful.</returns>
        public static CustomerCustomizerName Parse(string customerCustomizerName, bool allowUnparsed) =>
            TryParse(customerCustomizerName, allowUnparsed, out CustomerCustomizerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerCustomizerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerCustomizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerCustomizerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerCustomizerName, out CustomerCustomizerName result) =>
            TryParse(customerCustomizerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerCustomizerName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerCustomizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerCustomizerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerCustomizerName, bool allowUnparsed, out CustomerCustomizerName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerCustomizerName, nameof(customerCustomizerName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCustomizerAttribute.TryParseName(customerCustomizerName, out resourceName))
            {
                result = FromCustomerCustomizerAttribute(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerCustomizerName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerCustomizerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string customizerAttributeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            CustomizerAttributeId = customizerAttributeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerCustomizerName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/customerCustomizers/{customizer_attribute_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customizerAttributeId">
        /// The <c>CustomizerAttribute</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CustomerCustomizerName(string customerId, string customizerAttributeId) : this(ResourceNameType.CustomerCustomizerAttribute, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customizerAttributeId: gax::GaxPreconditions.CheckNotNullOrEmpty(customizerAttributeId, nameof(customizerAttributeId)))
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
        /// The <c>CustomizerAttribute</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CustomizerAttributeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCustomizerAttribute: return s_customerCustomizerAttribute.Expand(CustomerId, CustomizerAttributeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerCustomizerName);

        /// <inheritdoc/>
        public bool Equals(CustomerCustomizerName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerCustomizerName a, CustomerCustomizerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerCustomizerName a, CustomerCustomizerName b) => !(a == b);
    }

    public partial class CustomerCustomizer
    {
        /// <summary>
        /// <see cref="CustomerCustomizerName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CustomerCustomizerName ResourceNameAsCustomerCustomizerName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerCustomizerName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CustomizerAttributeName"/>-typed view over the <see cref="CustomizerAttribute"/> resource name
        /// property.
        /// </summary>
        internal CustomizerAttributeName CustomizerAttributeAsCustomizerAttributeName
        {
            get => string.IsNullOrEmpty(CustomizerAttribute) ? null : CustomizerAttributeName.Parse(CustomizerAttribute, allowUnparsed: true);
            set => CustomizerAttribute = value?.ToString() ?? "";
        }
    }
}

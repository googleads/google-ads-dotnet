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

namespace Google.Ads.GoogleAds.V3.Resources
{
    /// <summary>Resource name for the <c>CustomerExtensionSetting</c> resource.</summary>
    public sealed partial class CustomerExtensionSettingName : gax::IResourceName, sys::IEquatable<CustomerExtensionSettingName>
    {
        /// <summary>The possible contents of <see cref="CustomerExtensionSettingName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>.
            /// </summary>
            CustomerCustomerExtensionSetting = 1,
        }

        private static gax::PathTemplate s_customerCustomerExtensionSetting = new gax::PathTemplate("customers/{customer}/customerExtensionSettings/{customer_extension_setting}");

        /// <summary>
        /// Creates a <see cref="CustomerExtensionSettingName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerExtensionSettingName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerExtensionSettingName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerExtensionSettingName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerExtensionSettingName"/> with the pattern
        /// <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerExtensionSettingId">
        /// The <c>CustomerExtensionSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CustomerExtensionSettingName"/> constructed from the provided ids.
        /// </returns>
        public static CustomerExtensionSettingName FromCustomerCustomerExtensionSetting(string customerId, string customerExtensionSettingId) =>
            new CustomerExtensionSettingName(ResourceNameType.CustomerCustomerExtensionSetting, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerExtensionSettingId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerExtensionSettingId, nameof(customerExtensionSettingId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerExtensionSettingName"/> with
        /// pattern <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerExtensionSettingId">
        /// The <c>CustomerExtensionSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomerExtensionSettingName"/> with pattern
        /// <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>.
        /// </returns>
        public static string Format(string customerId, string customerExtensionSettingId) =>
            FormatCustomerCustomerExtensionSetting(customerId, customerExtensionSettingId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerExtensionSettingName"/> with
        /// pattern <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerExtensionSettingId">
        /// The <c>CustomerExtensionSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CustomerExtensionSettingName"/> with pattern
        /// <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>.
        /// </returns>
        public static string FormatCustomerCustomerExtensionSetting(string customerId, string customerExtensionSettingId) =>
            s_customerCustomerExtensionSetting.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customerExtensionSettingId, nameof(customerExtensionSettingId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerExtensionSettingName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="CustomerExtensionSettingName"/> if successful.</returns>
        public static CustomerExtensionSettingName Parse(string customerExtensionSettingName) =>
            Parse(customerExtensionSettingName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerExtensionSettingName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerExtensionSettingName"/> if successful.</returns>
        public static CustomerExtensionSettingName Parse(string customerExtensionSettingName, bool allowUnparsed) =>
            TryParse(customerExtensionSettingName, allowUnparsed, out CustomerExtensionSettingName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerExtensionSettingName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerExtensionSettingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerExtensionSettingName, out CustomerExtensionSettingName result) =>
            TryParse(customerExtensionSettingName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerExtensionSettingName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerExtensionSettingName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerExtensionSettingName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerExtensionSettingName, bool allowUnparsed, out CustomerExtensionSettingName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerExtensionSettingName, nameof(customerExtensionSettingName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCustomerExtensionSetting.TryParseName(customerExtensionSettingName, out resourceName))
            {
                result = FromCustomerCustomerExtensionSetting(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerExtensionSettingName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerExtensionSettingName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string customerExtensionSettingId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            CustomerExtensionSettingId = customerExtensionSettingId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerExtensionSettingName"/> class from the component parts of
        /// pattern <c>customers/{customer}/customerExtensionSettings/{customer_extension_setting}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customerExtensionSettingId">
        /// The <c>CustomerExtensionSetting</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CustomerExtensionSettingName(string customerId, string customerExtensionSettingId) : this(ResourceNameType.CustomerCustomerExtensionSetting, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customerExtensionSettingId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerExtensionSettingId, nameof(customerExtensionSettingId)))
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
        /// The <c>CustomerExtensionSetting</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CustomerExtensionSettingId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCustomerExtensionSetting: return s_customerCustomerExtensionSetting.Expand(CustomerId, CustomerExtensionSettingId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerExtensionSettingName);

        /// <inheritdoc/>
        public bool Equals(CustomerExtensionSettingName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerExtensionSettingName a, CustomerExtensionSettingName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerExtensionSettingName a, CustomerExtensionSettingName b) => !(a == b);
    }

    public partial class CustomerExtensionSetting
    {
        /// <summary>
        /// <see cref="CustomerExtensionSettingName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CustomerExtensionSettingName ResourceNameAsCustomerExtensionSettingName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerExtensionSettingName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ExtensionFeedItemName"/>-typed view over the <see cref="ExtensionFeedItems"/> resource name
        /// property.
        /// </summary>
        internal gax::ResourceNameList<ExtensionFeedItemName> ExtensionFeedItemsAsExtensionFeedItemNames
        {
            get => new gax::ResourceNameList<ExtensionFeedItemName>(ExtensionFeedItems, s => string.IsNullOrEmpty(s) ? null : ExtensionFeedItemName.Parse(s, allowUnparsed: true));
        }
    }
}

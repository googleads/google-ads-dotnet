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

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V7.Resources
{
    /// <summary>Resource name for the <c>CustomerAsset</c> resource.</summary>
    public sealed partial class CustomerAssetName : gax::IResourceName, sys::IEquatable<CustomerAssetName>
    {
        /// <summary>The possible contents of <see cref="CustomerAssetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c>.
            /// </summary>
            CustomerAssetFieldType = 1,
        }

        private static gax::PathTemplate s_customerAssetFieldType = new gax::PathTemplate("customers/{customer_id}/customerAssets/{asset_id_field_type}");

        /// <summary>Creates a <see cref="CustomerAssetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerAssetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerAssetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerAssetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerAssetName"/> with the pattern
        /// <c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomerAssetName"/> constructed from the provided ids.</returns>
        public static CustomerAssetName FromCustomerAssetFieldType(string customerId, string assetId, string fieldTypeId) =>
            new CustomerAssetName(ResourceNameType.CustomerAssetFieldType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), fieldTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerAssetName"/> with pattern
        /// <c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerAssetName"/> with pattern
        /// <c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c>.
        /// </returns>
        public static string Format(string customerId, string assetId, string fieldTypeId) =>
            FormatCustomerAssetFieldType(customerId, assetId, fieldTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerAssetName"/> with pattern
        /// <c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerAssetName"/> with pattern
        /// <c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c>.
        /// </returns>
        public static string FormatCustomerAssetFieldType(string customerId, string assetId, string fieldTypeId) =>
            s_customerAssetFieldType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerAssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerAssetName"/> if successful.</returns>
        public static CustomerAssetName Parse(string customerAssetName) => Parse(customerAssetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerAssetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerAssetName"/> if successful.</returns>
        public static CustomerAssetName Parse(string customerAssetName, bool allowUnparsed) =>
            TryParse(customerAssetName, allowUnparsed, out CustomerAssetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerAssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerAssetName, out CustomerAssetName result) =>
            TryParse(customerAssetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerAssetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerAssetName, bool allowUnparsed, out CustomerAssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerAssetName, nameof(customerAssetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAssetFieldType.TryParseName(customerAssetName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAssetFieldType(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerAssetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private CustomerAssetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetId = null, string customerId = null, string fieldTypeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetId = assetId;
            CustomerId = customerId;
            FieldTypeId = fieldTypeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerAssetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/customerAssets/{asset_id}~{field_type}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerAssetName(string customerId, string assetId, string fieldTypeId) : this(ResourceNameType.CustomerAssetFieldType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), fieldTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)))
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
        /// The <c>Asset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>FieldType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FieldTypeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerAssetFieldType: return s_customerAssetFieldType.Expand(CustomerId, $"{AssetId}~{FieldTypeId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerAssetName);

        /// <inheritdoc/>
        public bool Equals(CustomerAssetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerAssetName a, CustomerAssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerAssetName a, CustomerAssetName b) => !(a == b);
    }

    public partial class CustomerAsset
    {
        /// <summary>
        /// <see cref="CustomerAssetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CustomerAssetName ResourceNameAsCustomerAssetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerAssetName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        internal AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }
    }
}

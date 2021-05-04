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
    /// <summary>Resource name for the <c>AdGroupAsset</c> resource.</summary>
    public sealed partial class AdGroupAssetName : gax::IResourceName, sys::IEquatable<AdGroupAssetName>
    {
        /// <summary>The possible contents of <see cref="AdGroupAssetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>.
            /// </summary>
            CustomerAdGroupAssetFieldType = 1,
        }

        private static gax::PathTemplate s_customerAdGroupAssetFieldType = new gax::PathTemplate("customers/{customer_id}/adGroupAssets/{ad_group_id_asset_id_field_type}");

        /// <summary>Creates a <see cref="AdGroupAssetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupAssetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupAssetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupAssetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupAssetName"/> with the pattern
        /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdGroupAssetName"/> constructed from the provided ids.</returns>
        public static AdGroupAssetName FromCustomerAdGroupAssetFieldType(string customerId, string adGroupId, string assetId, string fieldTypeId) =>
            new AdGroupAssetName(ResourceNameType.CustomerAdGroupAssetFieldType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), fieldTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAssetName"/> with pattern
        /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAssetName"/> with pattern
        /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupId, string assetId, string fieldTypeId) =>
            FormatCustomerAdGroupAssetFieldType(customerId, adGroupId, assetId, fieldTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAssetName"/> with pattern
        /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAssetName"/> with pattern
        /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupAssetFieldType(string customerId, string adGroupId, string assetId, string fieldTypeId) =>
            s_customerAdGroupAssetFieldType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)))}");

        /// <summary>Parses the given resource name string into a new <see cref="AdGroupAssetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupAssetName"/> if successful.</returns>
        public static AdGroupAssetName Parse(string adGroupAssetName) => Parse(adGroupAssetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAssetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupAssetName"/> if successful.</returns>
        public static AdGroupAssetName Parse(string adGroupAssetName, bool allowUnparsed) =>
            TryParse(adGroupAssetName, allowUnparsed, out AdGroupAssetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAssetName, out AdGroupAssetName result) =>
            TryParse(adGroupAssetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAssetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAssetName, bool allowUnparsed, out AdGroupAssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAssetName, nameof(adGroupAssetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupAssetFieldType.TryParseName(adGroupAssetName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAdGroupAssetFieldType(resourceName[0], split1[0], split1[1], split1[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupAssetName, out gax::UnparsedResourceName unparsedResourceName))
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

        private AdGroupAssetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupId = null, string assetId = null, string customerId = null, string fieldTypeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupId = adGroupId;
            AssetId = assetId;
            CustomerId = customerId;
            FieldTypeId = fieldTypeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupAssetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/adGroupAssets/{ad_group_id}~{asset_id}~{field_type}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        public AdGroupAssetName(string customerId, string adGroupId, string assetId, string fieldTypeId) : this(ResourceNameType.CustomerAdGroupAssetFieldType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), fieldTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)))
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
        /// The <c>AdGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdGroupId { get; }

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
                case ResourceNameType.CustomerAdGroupAssetFieldType: return s_customerAdGroupAssetFieldType.Expand(CustomerId, $"{AdGroupId}~{AssetId}~{FieldTypeId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupAssetName);

        /// <inheritdoc/>
        public bool Equals(AdGroupAssetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupAssetName a, AdGroupAssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupAssetName a, AdGroupAssetName b) => !(a == b);
    }

    public partial class AdGroupAsset
    {
        /// <summary>
        /// <see cref="AdGroupAssetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupAssetName ResourceNameAsAdGroupAssetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupAssetName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupName"/>-typed view over the <see cref="AdGroup"/> resource name property.
        /// </summary>
        internal AdGroupName AdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(AdGroup) ? null : AdGroupName.Parse(AdGroup, allowUnparsed: true);
            set => AdGroup = value?.ToString() ?? "";
        }

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        internal AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }
    }
}

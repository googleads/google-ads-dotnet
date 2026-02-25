// Copyright 2026 Google LLC
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
    /// <summary>Resource name for the <c>AssetGroupAsset</c> resource.</summary>
    public sealed partial class AssetGroupAssetName : gax::IResourceName, sys::IEquatable<AssetGroupAssetName>
    {
        /// <summary>The possible contents of <see cref="AssetGroupAssetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>.
            /// </summary>
            CustomerAssetGroupAssetFieldType = 1,
        }

        private static gax::PathTemplate s_customerAssetGroupAssetFieldType = new gax::PathTemplate("customers/{customer_id}/assetGroupAssets/{asset_group_id_asset_id_field_type}");

        /// <summary>Creates a <see cref="AssetGroupAssetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetGroupAssetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssetGroupAssetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetGroupAssetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetGroupAssetName"/> with the pattern
        /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssetGroupAssetName"/> constructed from the provided ids.</returns>
        public static AssetGroupAssetName FromCustomerAssetGroupAssetFieldType(string customerId, string assetGroupId, string assetId, string fieldTypeId) =>
            new AssetGroupAssetName(ResourceNameType.CustomerAssetGroupAssetFieldType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetGroupId, nameof(assetGroupId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), fieldTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetGroupAssetName"/> with pattern
        /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetGroupAssetName"/> with pattern
        /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>.
        /// </returns>
        public static string Format(string customerId, string assetGroupId, string assetId, string fieldTypeId) =>
            FormatCustomerAssetGroupAssetFieldType(customerId, assetGroupId, assetId, fieldTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetGroupAssetName"/> with pattern
        /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetGroupAssetName"/> with pattern
        /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>.
        /// </returns>
        public static string FormatCustomerAssetGroupAssetFieldType(string customerId, string assetGroupId, string assetId, string fieldTypeId) =>
            s_customerAssetGroupAssetFieldType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetGroupId, nameof(assetGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetGroupAssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assetGroupAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetGroupAssetName"/> if successful.</returns>
        public static AssetGroupAssetName Parse(string assetGroupAssetName) => Parse(assetGroupAssetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetGroupAssetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetGroupAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssetGroupAssetName"/> if successful.</returns>
        public static AssetGroupAssetName Parse(string assetGroupAssetName, bool allowUnparsed) =>
            TryParse(assetGroupAssetName, allowUnparsed, out AssetGroupAssetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetGroupAssetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assetGroupAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetGroupAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetGroupAssetName, out AssetGroupAssetName result) =>
            TryParse(assetGroupAssetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetGroupAssetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetGroupAssetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetGroupAssetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetGroupAssetName, bool allowUnparsed, out AssetGroupAssetName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetGroupAssetName, nameof(assetGroupAssetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAssetGroupAssetFieldType.TryParseName(assetGroupAssetName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAssetGroupAssetFieldType(resourceName[0], split1[0], split1[1], split1[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assetGroupAssetName, out gax::UnparsedResourceName unparsedResourceName))
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

        private AssetGroupAssetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetId = null, string assetGroupId = null, string customerId = null, string fieldTypeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetId = assetId;
            AssetGroupId = assetGroupId;
            CustomerId = customerId;
            FieldTypeId = fieldTypeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetGroupAssetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/assetGroupAssets/{asset_group_id}~{asset_id}~{field_type}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        public AssetGroupAssetName(string customerId, string assetGroupId, string assetId, string fieldTypeId) : this(ResourceNameType.CustomerAssetGroupAssetFieldType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetGroupId, nameof(assetGroupId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), fieldTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)))
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
        /// The <c>AssetGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetGroupId { get; }

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
                case ResourceNameType.CustomerAssetGroupAssetFieldType: return s_customerAssetGroupAssetFieldType.Expand(CustomerId, $"{AssetGroupId}~{AssetId}~{FieldTypeId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetGroupAssetName);

        /// <inheritdoc/>
        public bool Equals(AssetGroupAssetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssetGroupAssetName a, AssetGroupAssetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AssetGroupAssetName a, AssetGroupAssetName b) => !(a == b);
    }

    public partial class AssetGroupAsset
    {
        /// <summary>
        /// <see cref="AssetGroupAssetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AssetGroupAssetName ResourceNameAsAssetGroupAssetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AssetGroupAssetName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AssetGroupName"/>-typed view over the <see cref="AssetGroup"/> resource name property.
        /// </summary>
        internal AssetGroupName AssetGroupAsAssetGroupName
        {
            get => string.IsNullOrEmpty(AssetGroup) ? null : AssetGroupName.Parse(AssetGroup, allowUnparsed: true);
            set => AssetGroup = value?.ToString() ?? "";
        }

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        internal AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }
    }
}

// Copyright 2024 Google LLC
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

namespace Google.Ads.GoogleAds.V16.Resources
{
    /// <summary>Resource name for the <c>AdGroupAssetSet</c> resource.</summary>
    public sealed partial class AdGroupAssetSetName : gax::IResourceName, sys::IEquatable<AdGroupAssetSetName>
    {
        /// <summary>The possible contents of <see cref="AdGroupAssetSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c>
            /// .
            /// </summary>
            CustomerAdGroupAssetSet = 1,
        }

        private static gax::PathTemplate s_customerAdGroupAssetSet = new gax::PathTemplate("customers/{customer_id}/adGroupAssetSets/{ad_group_id_asset_set_id}");

        /// <summary>Creates a <see cref="AdGroupAssetSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupAssetSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupAssetSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupAssetSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupAssetSetName"/> with the pattern
        /// <c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdGroupAssetSetName"/> constructed from the provided ids.</returns>
        public static AdGroupAssetSetName FromCustomerAdGroupAssetSet(string customerId, string adGroupId, string assetSetId) =>
            new AdGroupAssetSetName(ResourceNameType.CustomerAdGroupAssetSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), assetSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAssetSetName"/> with pattern
        /// <c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAssetSetName"/> with pattern
        /// <c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupId, string assetSetId) =>
            FormatCustomerAdGroupAssetSet(customerId, adGroupId, assetSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAssetSetName"/> with pattern
        /// <c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAssetSetName"/> with pattern
        /// <c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupAssetSet(string customerId, string adGroupId, string assetSetId) =>
            s_customerAdGroupAssetSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAssetSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAssetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupAssetSetName"/> if successful.</returns>
        public static AdGroupAssetSetName Parse(string adGroupAssetSetName) => Parse(adGroupAssetSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAssetSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAssetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupAssetSetName"/> if successful.</returns>
        public static AdGroupAssetSetName Parse(string adGroupAssetSetName, bool allowUnparsed) =>
            TryParse(adGroupAssetSetName, allowUnparsed, out AdGroupAssetSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAssetSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAssetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAssetSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAssetSetName, out AdGroupAssetSetName result) =>
            TryParse(adGroupAssetSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAssetSetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAssetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAssetSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAssetSetName, bool allowUnparsed, out AdGroupAssetSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAssetSetName, nameof(adGroupAssetSetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupAssetSet.TryParseName(adGroupAssetSetName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAdGroupAssetSet(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupAssetSetName, out gax::UnparsedResourceName unparsedResourceName))
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

        private AdGroupAssetSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupId = null, string assetSetId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupId = adGroupId;
            AssetSetId = assetSetId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupAssetSetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/adGroupAssetSets/{ad_group_id}~{asset_set_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        public AdGroupAssetSetName(string customerId, string adGroupId, string assetSetId) : this(ResourceNameType.CustomerAdGroupAssetSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), assetSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)))
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
        /// The <c>AssetSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetSetId { get; }

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
                case ResourceNameType.CustomerAdGroupAssetSet: return s_customerAdGroupAssetSet.Expand(CustomerId, $"{AdGroupId}~{AssetSetId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupAssetSetName);

        /// <inheritdoc/>
        public bool Equals(AdGroupAssetSetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AdGroupAssetSetName a, AdGroupAssetSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AdGroupAssetSetName a, AdGroupAssetSetName b) => !(a == b);
    }

    public partial class AdGroupAssetSet
    {
        /// <summary>
        /// <see cref="AdGroupAssetSetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupAssetSetName ResourceNameAsAdGroupAssetSetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupAssetSetName.Parse(ResourceName, allowUnparsed: true);
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

        /// <summary>
        /// <see cref="AssetSetName"/>-typed view over the <see cref="AssetSet"/> resource name property.
        /// </summary>
        internal AssetSetName AssetSetAsAssetSetName
        {
            get => string.IsNullOrEmpty(AssetSet) ? null : AssetSetName.Parse(AssetSet, allowUnparsed: true);
            set => AssetSet = value?.ToString() ?? "";
        }
    }
}

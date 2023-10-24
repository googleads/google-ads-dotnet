// Copyright 2023 Google LLC
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

namespace Google.Ads.GoogleAds.V15.Resources
{
    /// <summary>Resource name for the <c>AssetGroupTopCombinationView</c> resource.</summary>
    public sealed partial class AssetGroupTopCombinationViewName : gax::IResourceName, sys::IEquatable<AssetGroupTopCombinationViewName>
    {
        /// <summary>The possible contents of <see cref="AssetGroupTopCombinationViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>
            /// .
            /// </summary>
            CustomerAssetGroupAssetCombinationCategory = 1,
        }

        private static gax::PathTemplate s_customerAssetGroupAssetCombinationCategory = new gax::PathTemplate("customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id_asset_combination_category}");

        /// <summary>
        /// Creates a <see cref="AssetGroupTopCombinationViewName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetGroupTopCombinationViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssetGroupTopCombinationViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetGroupTopCombinationViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetGroupTopCombinationViewName"/> with the pattern
        /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetCombinationCategoryId">
        /// The <c>AssetCombinationCategory</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AssetGroupTopCombinationViewName"/> constructed from the provided ids.
        /// </returns>
        public static AssetGroupTopCombinationViewName FromCustomerAssetGroupAssetCombinationCategory(string customerId, string assetGroupId, string assetCombinationCategoryId) =>
            new AssetGroupTopCombinationViewName(ResourceNameType.CustomerAssetGroupAssetCombinationCategory, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetGroupId, nameof(assetGroupId)), assetCombinationCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetCombinationCategoryId, nameof(assetCombinationCategoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetGroupTopCombinationViewName"/> with
        /// pattern
        /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetCombinationCategoryId">
        /// The <c>AssetCombinationCategory</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AssetGroupTopCombinationViewName"/> with pattern
        /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>.
        /// </returns>
        public static string Format(string customerId, string assetGroupId, string assetCombinationCategoryId) =>
            FormatCustomerAssetGroupAssetCombinationCategory(customerId, assetGroupId, assetCombinationCategoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetGroupTopCombinationViewName"/> with
        /// pattern
        /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetCombinationCategoryId">
        /// The <c>AssetCombinationCategory</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AssetGroupTopCombinationViewName"/> with pattern
        /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>.
        /// </returns>
        public static string FormatCustomerAssetGroupAssetCombinationCategory(string customerId, string assetGroupId, string assetCombinationCategoryId) =>
            s_customerAssetGroupAssetCombinationCategory.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetGroupId, nameof(assetGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetCombinationCategoryId, nameof(assetCombinationCategoryId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetGroupTopCombinationViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assetGroupTopCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AssetGroupTopCombinationViewName"/> if successful.</returns>
        public static AssetGroupTopCombinationViewName Parse(string assetGroupTopCombinationViewName) =>
            Parse(assetGroupTopCombinationViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetGroupTopCombinationViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetGroupTopCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssetGroupTopCombinationViewName"/> if successful.</returns>
        public static AssetGroupTopCombinationViewName Parse(string assetGroupTopCombinationViewName, bool allowUnparsed) =>
            TryParse(assetGroupTopCombinationViewName, allowUnparsed, out AssetGroupTopCombinationViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetGroupTopCombinationViewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assetGroupTopCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetGroupTopCombinationViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetGroupTopCombinationViewName, out AssetGroupTopCombinationViewName result) =>
            TryParse(assetGroupTopCombinationViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetGroupTopCombinationViewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetGroupTopCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetGroupTopCombinationViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetGroupTopCombinationViewName, bool allowUnparsed, out AssetGroupTopCombinationViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetGroupTopCombinationViewName, nameof(assetGroupTopCombinationViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAssetGroupAssetCombinationCategory.TryParseName(assetGroupTopCombinationViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAssetGroupAssetCombinationCategory(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assetGroupTopCombinationViewName, out gax::UnparsedResourceName unparsedResourceName))
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

        private AssetGroupTopCombinationViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetCombinationCategoryId = null, string assetGroupId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetCombinationCategoryId = assetCombinationCategoryId;
            AssetGroupId = assetGroupId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetGroupTopCombinationViewName"/> class from the component parts
        /// of pattern
        /// <c>customers/{customer_id}/assetGroupTopCombinationViews/{asset_group_id}~{asset_combination_category}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetCombinationCategoryId">
        /// The <c>AssetCombinationCategory</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AssetGroupTopCombinationViewName(string customerId, string assetGroupId, string assetCombinationCategoryId) : this(ResourceNameType.CustomerAssetGroupAssetCombinationCategory, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetGroupId, nameof(assetGroupId)), assetCombinationCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetCombinationCategoryId, nameof(assetCombinationCategoryId)))
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
        /// The <c>AssetCombinationCategory</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AssetCombinationCategoryId { get; }

        /// <summary>
        /// The <c>AssetGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetGroupId { get; }

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
                case ResourceNameType.CustomerAssetGroupAssetCombinationCategory: return s_customerAssetGroupAssetCombinationCategory.Expand(CustomerId, $"{AssetGroupId}~{AssetCombinationCategoryId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetGroupTopCombinationViewName);

        /// <inheritdoc/>
        public bool Equals(AssetGroupTopCombinationViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AssetGroupTopCombinationViewName a, AssetGroupTopCombinationViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AssetGroupTopCombinationViewName a, AssetGroupTopCombinationViewName b) => !(a == b);
    }

    public partial class AssetGroupTopCombinationView
    {
        /// <summary>
        /// <see cref="AssetGroupTopCombinationViewName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal AssetGroupTopCombinationViewName ResourceNameAsAssetGroupTopCombinationViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AssetGroupTopCombinationViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

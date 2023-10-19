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
    /// <summary>Resource name for the <c>AdGroupAdAssetCombinationView</c> resource.</summary>
    public sealed partial class AdGroupAdAssetCombinationViewName : gax::IResourceName, sys::IEquatable<AdGroupAdAssetCombinationViewName>
    {
        /// <summary>The possible contents of <see cref="AdGroupAdAssetCombinationViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
            /// .
            /// </summary>
            CustomerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh = 1,
        }

        private static gax::PathTemplate s_customerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh = new gax::PathTemplate("customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id_ad_id_asset_combination_id_low_asset_combination_id_high}");

        /// <summary>
        /// Creates a <see cref="AdGroupAdAssetCombinationViewName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupAdAssetCombinationViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupAdAssetCombinationViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupAdAssetCombinationViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupAdAssetCombinationViewName"/> with the pattern
        /// <c>
        /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adId">The <c>Ad</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetCombinationIdLowId">
        /// The <c>AssetCombinationIdLow</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="assetCombinationIdHighId">
        /// The <c>AssetCombinationIdHigh</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AdGroupAdAssetCombinationViewName"/> constructed from the provided ids.
        /// </returns>
        public static AdGroupAdAssetCombinationViewName FromCustomerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh(string customerId, string adGroupId, string adId, string assetCombinationIdLowId, string assetCombinationIdHighId) =>
            new AdGroupAdAssetCombinationViewName(ResourceNameType.CustomerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), adId: gax::GaxPreconditions.CheckNotNullOrEmpty(adId, nameof(adId)), assetCombinationIdLowId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetCombinationIdLowId, nameof(assetCombinationIdLowId)), assetCombinationIdHighId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetCombinationIdHighId, nameof(assetCombinationIdHighId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAdAssetCombinationViewName"/> with
        /// pattern
        /// <c>
        /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adId">The <c>Ad</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetCombinationIdLowId">
        /// The <c>AssetCombinationIdLow</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="assetCombinationIdHighId">
        /// The <c>AssetCombinationIdHigh</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAdAssetCombinationViewName"/> with pattern
        /// <c>
        /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
        /// .
        /// </returns>
        public static string Format(string customerId, string adGroupId, string adId, string assetCombinationIdLowId, string assetCombinationIdHighId) =>
            FormatCustomerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh(customerId, adGroupId, adId, assetCombinationIdLowId, assetCombinationIdHighId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAdAssetCombinationViewName"/> with
        /// pattern
        /// <c>
        /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adId">The <c>Ad</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetCombinationIdLowId">
        /// The <c>AssetCombinationIdLow</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="assetCombinationIdHighId">
        /// The <c>AssetCombinationIdHigh</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAdAssetCombinationViewName"/> with pattern
        /// <c>
        /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
        /// .
        /// </returns>
        public static string FormatCustomerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh(string customerId, string adGroupId, string adId, string assetCombinationIdLowId, string assetCombinationIdHighId) =>
            s_customerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(adId, nameof(adId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetCombinationIdLowId, nameof(assetCombinationIdLowId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetCombinationIdHighId, nameof(assetCombinationIdHighId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAdAssetCombinationViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAdAssetCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupAdAssetCombinationViewName"/> if successful.</returns>
        public static AdGroupAdAssetCombinationViewName Parse(string adGroupAdAssetCombinationViewName) =>
            Parse(adGroupAdAssetCombinationViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAdAssetCombinationViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAdAssetCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupAdAssetCombinationViewName"/> if successful.</returns>
        public static AdGroupAdAssetCombinationViewName Parse(string adGroupAdAssetCombinationViewName, bool allowUnparsed) =>
            TryParse(adGroupAdAssetCombinationViewName, allowUnparsed, out AdGroupAdAssetCombinationViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAdAssetCombinationViewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAdAssetCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAdAssetCombinationViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdAssetCombinationViewName, out AdGroupAdAssetCombinationViewName result) =>
            TryParse(adGroupAdAssetCombinationViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAdAssetCombinationViewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAdAssetCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAdAssetCombinationViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdAssetCombinationViewName, bool allowUnparsed, out AdGroupAdAssetCombinationViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAdAssetCombinationViewName, nameof(adGroupAdAssetCombinationViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh.TryParseName(adGroupAdAssetCombinationViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh(resourceName[0], split1[0], split1[1], split1[2], split1[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupAdAssetCombinationViewName, out gax::UnparsedResourceName unparsedResourceName))
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

        private AdGroupAdAssetCombinationViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adId = null, string adGroupId = null, string assetCombinationIdHighId = null, string assetCombinationIdLowId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdId = adId;
            AdGroupId = adGroupId;
            AssetCombinationIdHighId = assetCombinationIdHighId;
            AssetCombinationIdLowId = assetCombinationIdLowId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupAdAssetCombinationViewName"/> class from the component
        /// parts of pattern
        /// <c>
        /// customers/{customer_id}/adGroupAdAssetCombinationViews/{ad_group_id}~{ad_id}~{asset_combination_id_low}~{asset_combination_id_high}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adId">The <c>Ad</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetCombinationIdLowId">
        /// The <c>AssetCombinationIdLow</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="assetCombinationIdHighId">
        /// The <c>AssetCombinationIdHigh</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AdGroupAdAssetCombinationViewName(string customerId, string adGroupId, string adId, string assetCombinationIdLowId, string assetCombinationIdHighId) : this(ResourceNameType.CustomerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), adId: gax::GaxPreconditions.CheckNotNullOrEmpty(adId, nameof(adId)), assetCombinationIdLowId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetCombinationIdLowId, nameof(assetCombinationIdLowId)), assetCombinationIdHighId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetCombinationIdHighId, nameof(assetCombinationIdHighId)))
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
        /// The <c>Ad</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdId { get; }

        /// <summary>
        /// The <c>AdGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdGroupId { get; }

        /// <summary>
        /// The <c>AssetCombinationIdHigh</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AssetCombinationIdHighId { get; }

        /// <summary>
        /// The <c>AssetCombinationIdLow</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AssetCombinationIdLowId { get; }

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
                case ResourceNameType.CustomerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh: return s_customerAdGroupAdAssetCombinationIdLowAssetCombinationIdHigh.Expand(CustomerId, $"{AdGroupId}~{AdId}~{AssetCombinationIdLowId}~{AssetCombinationIdHighId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupAdAssetCombinationViewName);

        /// <inheritdoc/>
        public bool Equals(AdGroupAdAssetCombinationViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupAdAssetCombinationViewName a, AdGroupAdAssetCombinationViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupAdAssetCombinationViewName a, AdGroupAdAssetCombinationViewName b) => !(a == b);
    }

    public partial class AdGroupAdAssetCombinationView
    {
        /// <summary>
        /// <see cref="AdGroupAdAssetCombinationViewName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal AdGroupAdAssetCombinationViewName ResourceNameAsAdGroupAdAssetCombinationViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupAdAssetCombinationViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

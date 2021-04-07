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

namespace Google.Ads.GoogleAds.V5.Resources
{
    /// <summary>Resource name for the <c>AdGroupAdAssetView</c> resource.</summary>
    public sealed partial class AdGroupAdAssetViewName : gax::IResourceName, sys::IEquatable<AdGroupAdAssetViewName>
    {
        /// <summary>The possible contents of <see cref="AdGroupAdAssetViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c>.
            /// </summary>
            CustomerAdGroupAdAssetView = 1,
        }

        private static gax::PathTemplate s_customerAdGroupAdAssetView = new gax::PathTemplate("customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}");

        /// <summary>Creates a <see cref="AdGroupAdAssetViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupAdAssetViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupAdAssetViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupAdAssetViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupAdAssetViewName"/> with the pattern
        /// <c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdAssetViewId">
        /// The <c>AdGroupAdAssetView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="AdGroupAdAssetViewName"/> constructed from the provided ids.</returns>
        public static AdGroupAdAssetViewName FromCustomerAdGroupAdAssetView(string customerId, string adGroupAdAssetViewId) =>
            new AdGroupAdAssetViewName(ResourceNameType.CustomerAdGroupAdAssetView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupAdAssetViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAdAssetViewId, nameof(adGroupAdAssetViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAdAssetViewName"/> with pattern
        /// <c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdAssetViewId">
        /// The <c>AdGroupAdAssetView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAdAssetViewName"/> with pattern
        /// <c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupAdAssetViewId) =>
            FormatCustomerAdGroupAdAssetView(customerId, adGroupAdAssetViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAdAssetViewName"/> with pattern
        /// <c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdAssetViewId">
        /// The <c>AdGroupAdAssetView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAdAssetViewName"/> with pattern
        /// <c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupAdAssetView(string customerId, string adGroupAdAssetViewId) =>
            s_customerAdGroupAdAssetView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAdAssetViewId, nameof(adGroupAdAssetViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAdAssetViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAdAssetViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupAdAssetViewName"/> if successful.</returns>
        public static AdGroupAdAssetViewName Parse(string adGroupAdAssetViewName) => Parse(adGroupAdAssetViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAdAssetViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAdAssetViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupAdAssetViewName"/> if successful.</returns>
        public static AdGroupAdAssetViewName Parse(string adGroupAdAssetViewName, bool allowUnparsed) =>
            TryParse(adGroupAdAssetViewName, allowUnparsed, out AdGroupAdAssetViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAdAssetViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAdAssetViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAdAssetViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdAssetViewName, out AdGroupAdAssetViewName result) =>
            TryParse(adGroupAdAssetViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAdAssetViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAdAssetViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAdAssetViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdAssetViewName, bool allowUnparsed, out AdGroupAdAssetViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAdAssetViewName, nameof(adGroupAdAssetViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupAdAssetView.TryParseName(adGroupAdAssetViewName, out resourceName))
            {
                result = FromCustomerAdGroupAdAssetView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupAdAssetViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupAdAssetViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupAdAssetViewId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupAdAssetViewId = adGroupAdAssetViewId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupAdAssetViewName"/> class from the component parts of
        /// pattern <c>customers/{customer}/adGroupAdAssetViews/{ad_group_ad_asset_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdAssetViewId">
        /// The <c>AdGroupAdAssetView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AdGroupAdAssetViewName(string customerId, string adGroupAdAssetViewId) : this(ResourceNameType.CustomerAdGroupAdAssetView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupAdAssetViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAdAssetViewId, nameof(adGroupAdAssetViewId)))
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
        /// The <c>AdGroupAdAssetView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AdGroupAdAssetViewId { get; }

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
                case ResourceNameType.CustomerAdGroupAdAssetView: return s_customerAdGroupAdAssetView.Expand(CustomerId, AdGroupAdAssetViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupAdAssetViewName);

        /// <inheritdoc/>
        public bool Equals(AdGroupAdAssetViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupAdAssetViewName a, AdGroupAdAssetViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupAdAssetViewName a, AdGroupAdAssetViewName b) => !(a == b);
    }

    public partial class AdGroupAdAssetView
    {
        /// <summary>
        /// <see cref="AdGroupAdAssetViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupAdAssetViewName ResourceNameAsAdGroupAdAssetViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupAdAssetViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupAdName"/>-typed view over the <see cref="AdGroupAd"/> resource name property.
        /// </summary>
        internal AdGroupAdName AdGroupAdAsAdGroupAdName
        {
            get => string.IsNullOrEmpty(AdGroupAd) ? null : AdGroupAdName.Parse(AdGroupAd, allowUnparsed: true);
            set => AdGroupAd = value?.ToString() ?? "";
        }

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        internal AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }
    }
}

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

using gagvr = Google.Ads.GoogleAds.V10.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V10.Resources
{
    /// <summary>Resource name for the <c>AssetSet</c> resource.</summary>
    public sealed partial class AssetSetName : gax::IResourceName, sys::IEquatable<AssetSetName>
    {
        /// <summary>The possible contents of <see cref="AssetSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/assetSets/{asset_set_id}</c>.</summary>
            CustomerAssetSet = 1,
        }

        private static gax::PathTemplate s_customerAssetSet = new gax::PathTemplate("customers/{customer_id}/assetSets/{asset_set_id}");

        /// <summary>Creates a <see cref="AssetSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetSetName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static AssetSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetSetName"/> with the pattern <c>customers/{customer_id}/assetSets/{asset_set_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssetSetName"/> constructed from the provided ids.</returns>
        public static AssetSetName FromCustomerAssetSet(string customerId, string assetSetId) =>
            new AssetSetName(ResourceNameType.CustomerAssetSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetSetName"/> with pattern
        /// <c>customers/{customer_id}/assetSets/{asset_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetSetName"/> with pattern
        /// <c>customers/{customer_id}/assetSets/{asset_set_id}</c>.
        /// </returns>
        public static string Format(string customerId, string assetSetId) => FormatCustomerAssetSet(customerId, assetSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetSetName"/> with pattern
        /// <c>customers/{customer_id}/assetSets/{asset_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetSetName"/> with pattern
        /// <c>customers/{customer_id}/assetSets/{asset_set_id}</c>.
        /// </returns>
        public static string FormatCustomerAssetSet(string customerId, string assetSetId) =>
            s_customerAssetSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)));

        /// <summary>Parses the given resource name string into a new <see cref="AssetSetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetSets/{asset_set_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetSetName"/> if successful.</returns>
        public static AssetSetName Parse(string assetSetName) => Parse(assetSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetSetName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetSets/{asset_set_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssetSetName"/> if successful.</returns>
        public static AssetSetName Parse(string assetSetName, bool allowUnparsed) =>
            TryParse(assetSetName, allowUnparsed, out AssetSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetSets/{asset_set_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetSetName, out AssetSetName result) => TryParse(assetSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetSets/{asset_set_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetSetName, bool allowUnparsed, out AssetSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetSetName, nameof(assetSetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAssetSet.TryParseName(assetSetName, out resourceName))
            {
                result = FromCustomerAssetSet(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assetSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssetSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetSetId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetSetId = assetSetId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetSetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/assetSets/{asset_set_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        public AssetSetName(string customerId, string assetSetId) : this(ResourceNameType.CustomerAssetSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)))
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
                case ResourceNameType.CustomerAssetSet: return s_customerAssetSet.Expand(CustomerId, AssetSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetSetName);

        /// <inheritdoc/>
        public bool Equals(AssetSetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AssetSetName a, AssetSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AssetSetName a, AssetSetName b) => !(a == b);
    }

    public partial class AssetSet
    {
        /// <summary>
        /// <see cref="gagvr::AssetSetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal gagvr::AssetSetName ResourceNameAsAssetSetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::AssetSetName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::AssetSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::AssetSetName AssetSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::AssetSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

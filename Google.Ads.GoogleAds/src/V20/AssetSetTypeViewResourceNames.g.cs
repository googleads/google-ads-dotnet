// Copyright 2025 Google LLC
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
    /// <summary>Resource name for the <c>AssetSetTypeView</c> resource.</summary>
    public sealed partial class AssetSetTypeViewName : gax::IResourceName, sys::IEquatable<AssetSetTypeViewName>
    {
        /// <summary>The possible contents of <see cref="AssetSetTypeViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c>.
            /// </summary>
            CustomerAssetSetType = 1,
        }

        private static gax::PathTemplate s_customerAssetSetType = new gax::PathTemplate("customers/{customer_id}/assetSetTypeViews/{asset_set_type}");

        /// <summary>Creates a <see cref="AssetSetTypeViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetSetTypeViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssetSetTypeViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetSetTypeViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetSetTypeViewName"/> with the pattern
        /// <c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetTypeId">The <c>AssetSetType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssetSetTypeViewName"/> constructed from the provided ids.</returns>
        public static AssetSetTypeViewName FromCustomerAssetSetType(string customerId, string assetSetTypeId) =>
            new AssetSetTypeViewName(ResourceNameType.CustomerAssetSetType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetSetTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetTypeId, nameof(assetSetTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetSetTypeViewName"/> with pattern
        /// <c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetTypeId">The <c>AssetSetType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetSetTypeViewName"/> with pattern
        /// <c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c>.
        /// </returns>
        public static string Format(string customerId, string assetSetTypeId) =>
            FormatCustomerAssetSetType(customerId, assetSetTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetSetTypeViewName"/> with pattern
        /// <c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetTypeId">The <c>AssetSetType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetSetTypeViewName"/> with pattern
        /// <c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c>.
        /// </returns>
        public static string FormatCustomerAssetSetType(string customerId, string assetSetTypeId) =>
            s_customerAssetSetType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetTypeId, nameof(assetSetTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetSetTypeViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assetSetTypeViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetSetTypeViewName"/> if successful.</returns>
        public static AssetSetTypeViewName Parse(string assetSetTypeViewName) => Parse(assetSetTypeViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetSetTypeViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetSetTypeViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssetSetTypeViewName"/> if successful.</returns>
        public static AssetSetTypeViewName Parse(string assetSetTypeViewName, bool allowUnparsed) =>
            TryParse(assetSetTypeViewName, allowUnparsed, out AssetSetTypeViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetSetTypeViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assetSetTypeViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetSetTypeViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetSetTypeViewName, out AssetSetTypeViewName result) =>
            TryParse(assetSetTypeViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetSetTypeViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetSetTypeViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetSetTypeViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetSetTypeViewName, bool allowUnparsed, out AssetSetTypeViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetSetTypeViewName, nameof(assetSetTypeViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAssetSetType.TryParseName(assetSetTypeViewName, out resourceName))
            {
                result = FromCustomerAssetSetType(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assetSetTypeViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssetSetTypeViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetSetTypeId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetSetTypeId = assetSetTypeId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetSetTypeViewName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/assetSetTypeViews/{asset_set_type}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetTypeId">The <c>AssetSetType</c> ID. Must not be <c>null</c> or empty.</param>
        public AssetSetTypeViewName(string customerId, string assetSetTypeId) : this(ResourceNameType.CustomerAssetSetType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetSetTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetTypeId, nameof(assetSetTypeId)))
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
        /// The <c>AssetSetType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AssetSetTypeId { get; }

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
                case ResourceNameType.CustomerAssetSetType: return s_customerAssetSetType.Expand(CustomerId, AssetSetTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetSetTypeViewName);

        /// <inheritdoc/>
        public bool Equals(AssetSetTypeViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssetSetTypeViewName a, AssetSetTypeViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AssetSetTypeViewName a, AssetSetTypeViewName b) => !(a == b);
    }

    public partial class AssetSetTypeView
    {
        /// <summary>
        /// <see cref="AssetSetTypeViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AssetSetTypeViewName ResourceNameAsAssetSetTypeViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AssetSetTypeViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

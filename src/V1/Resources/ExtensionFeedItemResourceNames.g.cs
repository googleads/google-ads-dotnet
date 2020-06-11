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

namespace Google.Ads.GoogleAds.V1.Resources
{
    /// <summary>Resource name for the <c>ExtensionFeedItem</c> resource.</summary>
    public sealed partial class ExtensionFeedItemName : gax::IResourceName, sys::IEquatable<ExtensionFeedItemName>
    {
        /// <summary>The possible contents of <see cref="ExtensionFeedItemName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c>.
            /// </summary>
            CustomerExtensionFeedItem = 1
        }

        private static gax::PathTemplate s_customerExtensionFeedItem = new gax::PathTemplate("customers/{customer}/extensionFeedItems/{extension_feed_item}");

        /// <summary>Creates a <see cref="ExtensionFeedItemName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExtensionFeedItemName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExtensionFeedItemName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExtensionFeedItemName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExtensionFeedItemName"/> with the pattern
        /// <c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionFeedItemId">The <c>ExtensionFeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExtensionFeedItemName"/> constructed from the provided ids.</returns>
        public static ExtensionFeedItemName FromCustomerExtensionFeedItem(string customerId, string extensionFeedItemId) =>
            new ExtensionFeedItemName(ResourceNameType.CustomerExtensionFeedItem, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), extensionFeedItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(extensionFeedItemId, nameof(extensionFeedItemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExtensionFeedItemName"/> with pattern
        /// <c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionFeedItemId">The <c>ExtensionFeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExtensionFeedItemName"/> with pattern
        /// <c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c>.
        /// </returns>
        public static string Format(string customerId, string extensionFeedItemId) =>
            FormatCustomerExtensionFeedItem(customerId, extensionFeedItemId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExtensionFeedItemName"/> with pattern
        /// <c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionFeedItemId">The <c>ExtensionFeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExtensionFeedItemName"/> with pattern
        /// <c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c>.
        /// </returns>
        public static string FormatCustomerExtensionFeedItem(string customerId, string extensionFeedItemId) =>
            s_customerExtensionFeedItem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(extensionFeedItemId, nameof(extensionFeedItemId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExtensionFeedItemName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="extensionFeedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExtensionFeedItemName"/> if successful.</returns>
        public static ExtensionFeedItemName Parse(string extensionFeedItemName) => Parse(extensionFeedItemName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExtensionFeedItemName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="extensionFeedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExtensionFeedItemName"/> if successful.</returns>
        public static ExtensionFeedItemName Parse(string extensionFeedItemName, bool allowUnparsed) =>
            TryParse(extensionFeedItemName, allowUnparsed, out ExtensionFeedItemName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExtensionFeedItemName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="extensionFeedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExtensionFeedItemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string extensionFeedItemName, out ExtensionFeedItemName result) =>
            TryParse(extensionFeedItemName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExtensionFeedItemName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="extensionFeedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExtensionFeedItemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string extensionFeedItemName, bool allowUnparsed, out ExtensionFeedItemName result)
        {
            gax::GaxPreconditions.CheckNotNull(extensionFeedItemName, nameof(extensionFeedItemName));
            gax::TemplatedResourceName resourceName;
            if (s_customerExtensionFeedItem.TryParseName(extensionFeedItemName, out resourceName))
            {
                result = FromCustomerExtensionFeedItem(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(extensionFeedItemName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExtensionFeedItemName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string extensionFeedItemId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            ExtensionFeedItemId = extensionFeedItemId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExtensionFeedItemName"/> class from the component parts of pattern
        /// <c>customers/{customer}/extensionFeedItems/{extension_feed_item}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="extensionFeedItemId">The <c>ExtensionFeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        public ExtensionFeedItemName(string customerId, string extensionFeedItemId) : this(ResourceNameType.CustomerExtensionFeedItem, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), extensionFeedItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(extensionFeedItemId, nameof(extensionFeedItemId)))
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
        /// The <c>ExtensionFeedItem</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ExtensionFeedItemId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerExtensionFeedItem: return s_customerExtensionFeedItem.Expand(CustomerId, ExtensionFeedItemId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExtensionFeedItemName);

        /// <inheritdoc/>
        public bool Equals(ExtensionFeedItemName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ExtensionFeedItemName a, ExtensionFeedItemName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ExtensionFeedItemName a, ExtensionFeedItemName b) => !(a == b);
    }

    public partial class ExtensionFeedItem
    {
        /// <summary>
        /// <see cref="ExtensionFeedItemName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal ExtensionFeedItemName ResourceNameAsExtensionFeedItemName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ExtensionFeedItemName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="TargetedCampaign"/> resource name property.
        /// </summary>
        internal CampaignName TargetedCampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(TargetedCampaign) ? null : CampaignName.Parse(TargetedCampaign, allowUnparsed: true);
            set => TargetedCampaign = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupName"/>-typed view over the <see cref="TargetedAdGroup"/> resource name property.
        /// </summary>
        internal AdGroupName TargetedAdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(TargetedAdGroup) ? null : AdGroupName.Parse(TargetedAdGroup, allowUnparsed: true);
            set => TargetedAdGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="GeoTargetConstantName"/>-typed view over the <see cref="TargetedGeoTargetConstant"/> resource
        /// name property.
        /// </summary>
        internal GeoTargetConstantName TargetedGeoTargetConstantAsGeoTargetConstantName
        {
            get => string.IsNullOrEmpty(TargetedGeoTargetConstant) ? null : GeoTargetConstantName.Parse(TargetedGeoTargetConstant, allowUnparsed: true);
            set => TargetedGeoTargetConstant = value?.ToString() ?? "";
        }
    }
}

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

namespace Google.Ads.GoogleAds.V5.Resources
{
    /// <summary>Resource name for the <c>FeedItemTarget</c> resource.</summary>
    public sealed partial class FeedItemTargetName : gax::IResourceName, sys::IEquatable<FeedItemTargetName>
    {
        /// <summary>The possible contents of <see cref="FeedItemTargetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/feedItemTargets/{feed_item_target}</c>.
            /// </summary>
            CustomerFeedItemTarget = 1
        }

        private static gax::PathTemplate s_customerFeedItemTarget = new gax::PathTemplate("customers/{customer}/feedItemTargets/{feed_item_target}");

        /// <summary>Creates a <see cref="FeedItemTargetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeedItemTargetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeedItemTargetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeedItemTargetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeedItemTargetName"/> with the pattern
        /// <c>customers/{customer}/feedItemTargets/{feed_item_target}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemTargetId">The <c>FeedItemTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeedItemTargetName"/> constructed from the provided ids.</returns>
        public static FeedItemTargetName FromCustomerFeedItemTarget(string customerId, string feedItemTargetId) =>
            new FeedItemTargetName(ResourceNameType.CustomerFeedItemTarget, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedItemTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemTargetId, nameof(feedItemTargetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedItemTargetName"/> with pattern
        /// <c>customers/{customer}/feedItemTargets/{feed_item_target}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemTargetId">The <c>FeedItemTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedItemTargetName"/> with pattern
        /// <c>customers/{customer}/feedItemTargets/{feed_item_target}</c>.
        /// </returns>
        public static string Format(string customerId, string feedItemTargetId) =>
            FormatCustomerFeedItemTarget(customerId, feedItemTargetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedItemTargetName"/> with pattern
        /// <c>customers/{customer}/feedItemTargets/{feed_item_target}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemTargetId">The <c>FeedItemTarget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedItemTargetName"/> with pattern
        /// <c>customers/{customer}/feedItemTargets/{feed_item_target}</c>.
        /// </returns>
        public static string FormatCustomerFeedItemTarget(string customerId, string feedItemTargetId) =>
            s_customerFeedItemTarget.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemTargetId, nameof(feedItemTargetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedItemTargetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/feedItemTargets/{feed_item_target}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="feedItemTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedItemTargetName"/> if successful.</returns>
        public static FeedItemTargetName Parse(string feedItemTargetName) => Parse(feedItemTargetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedItemTargetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/feedItemTargets/{feed_item_target}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedItemTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeedItemTargetName"/> if successful.</returns>
        public static FeedItemTargetName Parse(string feedItemTargetName, bool allowUnparsed) =>
            TryParse(feedItemTargetName, allowUnparsed, out FeedItemTargetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedItemTargetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/feedItemTargets/{feed_item_target}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="feedItemTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedItemTargetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedItemTargetName, out FeedItemTargetName result) =>
            TryParse(feedItemTargetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedItemTargetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/feedItemTargets/{feed_item_target}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedItemTargetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedItemTargetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedItemTargetName, bool allowUnparsed, out FeedItemTargetName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedItemTargetName, nameof(feedItemTargetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerFeedItemTarget.TryParseName(feedItemTargetName, out resourceName))
            {
                result = FromCustomerFeedItemTarget(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(feedItemTargetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeedItemTargetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string feedItemTargetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            FeedItemTargetId = feedItemTargetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeedItemTargetName"/> class from the component parts of pattern
        /// <c>customers/{customer}/feedItemTargets/{feed_item_target}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemTargetId">The <c>FeedItemTarget</c> ID. Must not be <c>null</c> or empty.</param>
        public FeedItemTargetName(string customerId, string feedItemTargetId) : this(ResourceNameType.CustomerFeedItemTarget, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedItemTargetId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemTargetId, nameof(feedItemTargetId)))
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
        /// The <c>FeedItemTarget</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string FeedItemTargetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerFeedItemTarget: return s_customerFeedItemTarget.Expand(CustomerId, FeedItemTargetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeedItemTargetName);

        /// <inheritdoc/>
        public bool Equals(FeedItemTargetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(FeedItemTargetName a, FeedItemTargetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(FeedItemTargetName a, FeedItemTargetName b) => !(a == b);
    }

    public partial class FeedItemTarget
    {
        /// <summary>
        /// <see cref="FeedItemTargetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal FeedItemTargetName ResourceNameAsFeedItemTargetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : FeedItemTargetName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="FeedItemName"/>-typed view over the <see cref="FeedItem"/> resource name property.
        /// </summary>
        internal FeedItemName FeedItemAsFeedItemName
        {
            get => string.IsNullOrEmpty(FeedItem) ? null : FeedItemName.Parse(FeedItem, allowUnparsed: true);
            set => FeedItem = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaign"/> resource name property.
        /// </summary>
        internal CampaignName CampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(Campaign) ? null : CampaignName.Parse(Campaign, allowUnparsed: true);
            set => Campaign = value?.ToString() ?? "";
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
        /// <see cref="GeoTargetConstantName"/>-typed view over the <see cref="GeoTargetConstant"/> resource name
        /// property.
        /// </summary>
        internal GeoTargetConstantName GeoTargetConstantAsGeoTargetConstantName
        {
            get => string.IsNullOrEmpty(GeoTargetConstant) ? null : GeoTargetConstantName.Parse(GeoTargetConstant, allowUnparsed: true);
            set => GeoTargetConstant = value?.ToString() ?? "";
        }
    }
}

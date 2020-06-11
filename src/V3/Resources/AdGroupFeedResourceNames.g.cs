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

namespace Google.Ads.GoogleAds.V3.Resources
{
    /// <summary>Resource name for the <c>AdGroupFeed</c> resource.</summary>
    public sealed partial class AdGroupFeedName : gax::IResourceName, sys::IEquatable<AdGroupFeedName>
    {
        /// <summary>The possible contents of <see cref="AdGroupFeedName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c>.
            /// </summary>
            CustomerAdGroupFeed = 1
        }

        private static gax::PathTemplate s_customerAdGroupFeed = new gax::PathTemplate("customers/{customer}/adGroupFeeds/{ad_group_feed}");

        /// <summary>Creates a <see cref="AdGroupFeedName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupFeedName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupFeedName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupFeedName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupFeedName"/> with the pattern
        /// <c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupFeedId">The <c>AdGroupFeed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdGroupFeedName"/> constructed from the provided ids.</returns>
        public static AdGroupFeedName FromCustomerAdGroupFeed(string customerId, string adGroupFeedId) =>
            new AdGroupFeedName(ResourceNameType.CustomerAdGroupFeed, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupFeedId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupFeedId, nameof(adGroupFeedId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupFeedName"/> with pattern
        /// <c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupFeedId">The <c>AdGroupFeed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupFeedName"/> with pattern
        /// <c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupFeedId) =>
            FormatCustomerAdGroupFeed(customerId, adGroupFeedId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupFeedName"/> with pattern
        /// <c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupFeedId">The <c>AdGroupFeed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupFeedName"/> with pattern
        /// <c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupFeed(string customerId, string adGroupFeedId) =>
            s_customerAdGroupFeed.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupFeedId, nameof(adGroupFeedId)));

        /// <summary>Parses the given resource name string into a new <see cref="AdGroupFeedName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupFeedName"/> if successful.</returns>
        public static AdGroupFeedName Parse(string adGroupFeedName) => Parse(adGroupFeedName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupFeedName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupFeedName"/> if successful.</returns>
        public static AdGroupFeedName Parse(string adGroupFeedName, bool allowUnparsed) =>
            TryParse(adGroupFeedName, allowUnparsed, out AdGroupFeedName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupFeedName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupFeedName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupFeedName, out AdGroupFeedName result) =>
            TryParse(adGroupFeedName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupFeedName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupFeedName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupFeedName, bool allowUnparsed, out AdGroupFeedName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupFeedName, nameof(adGroupFeedName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupFeed.TryParseName(adGroupFeedName, out resourceName))
            {
                result = FromCustomerAdGroupFeed(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupFeedName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupFeedName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupFeedId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupFeedId = adGroupFeedId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupFeedName"/> class from the component parts of pattern
        /// <c>customers/{customer}/adGroupFeeds/{ad_group_feed}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupFeedId">The <c>AdGroupFeed</c> ID. Must not be <c>null</c> or empty.</param>
        public AdGroupFeedName(string customerId, string adGroupFeedId) : this(ResourceNameType.CustomerAdGroupFeed, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupFeedId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupFeedId, nameof(adGroupFeedId)))
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
        /// The <c>AdGroupFeed</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdGroupFeedId { get; }

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
                case ResourceNameType.CustomerAdGroupFeed: return s_customerAdGroupFeed.Expand(CustomerId, AdGroupFeedId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupFeedName);

        /// <inheritdoc/>
        public bool Equals(AdGroupFeedName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupFeedName a, AdGroupFeedName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupFeedName a, AdGroupFeedName b) => !(a == b);
    }

    public partial class AdGroupFeed
    {
        /// <summary>
        /// <see cref="AdGroupFeedName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupFeedName ResourceNameAsAdGroupFeedName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupFeedName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary><see cref="FeedName"/>-typed view over the <see cref="Feed"/> resource name property.</summary>
        internal FeedName FeedAsFeedName
        {
            get => string.IsNullOrEmpty(Feed) ? null : FeedName.Parse(Feed, allowUnparsed: true);
            set => Feed = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupName"/>-typed view over the <see cref="AdGroup"/> resource name property.
        /// </summary>
        internal AdGroupName AdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(AdGroup) ? null : AdGroupName.Parse(AdGroup, allowUnparsed: true);
            set => AdGroup = value?.ToString() ?? "";
        }
    }
}

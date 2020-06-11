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
    /// <summary>Resource name for the <c>FeedItem</c> resource.</summary>
    public sealed partial class FeedItemName : gax::IResourceName, sys::IEquatable<FeedItemName>
    {
        /// <summary>The possible contents of <see cref="FeedItemName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer}/feedItems/{feed_item}</c>.</summary>
            CustomerFeedItem = 1
        }

        private static gax::PathTemplate s_customerFeedItem = new gax::PathTemplate("customers/{customer}/feedItems/{feed_item}");

        /// <summary>Creates a <see cref="FeedItemName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeedItemName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static FeedItemName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeedItemName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeedItemName"/> with the pattern <c>customers/{customer}/feedItems/{feed_item}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemId">The <c>FeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeedItemName"/> constructed from the provided ids.</returns>
        public static FeedItemName FromCustomerFeedItem(string customerId, string feedItemId) =>
            new FeedItemName(ResourceNameType.CustomerFeedItem, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemId, nameof(feedItemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedItemName"/> with pattern
        /// <c>customers/{customer}/feedItems/{feed_item}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemId">The <c>FeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedItemName"/> with pattern
        /// <c>customers/{customer}/feedItems/{feed_item}</c>.
        /// </returns>
        public static string Format(string customerId, string feedItemId) => FormatCustomerFeedItem(customerId, feedItemId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedItemName"/> with pattern
        /// <c>customers/{customer}/feedItems/{feed_item}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemId">The <c>FeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedItemName"/> with pattern
        /// <c>customers/{customer}/feedItems/{feed_item}</c>.
        /// </returns>
        public static string FormatCustomerFeedItem(string customerId, string feedItemId) =>
            s_customerFeedItem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemId, nameof(feedItemId)));

        /// <summary>Parses the given resource name string into a new <see cref="FeedItemName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/feedItems/{feed_item}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="feedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedItemName"/> if successful.</returns>
        public static FeedItemName Parse(string feedItemName) => Parse(feedItemName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedItemName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/feedItems/{feed_item}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeedItemName"/> if successful.</returns>
        public static FeedItemName Parse(string feedItemName, bool allowUnparsed) =>
            TryParse(feedItemName, allowUnparsed, out FeedItemName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedItemName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/feedItems/{feed_item}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="feedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedItemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedItemName, out FeedItemName result) => TryParse(feedItemName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedItemName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/feedItems/{feed_item}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedItemName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedItemName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedItemName, bool allowUnparsed, out FeedItemName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedItemName, nameof(feedItemName));
            gax::TemplatedResourceName resourceName;
            if (s_customerFeedItem.TryParseName(feedItemName, out resourceName))
            {
                result = FromCustomerFeedItem(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(feedItemName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeedItemName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string feedItemId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            FeedItemId = feedItemId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeedItemName"/> class from the component parts of pattern
        /// <c>customers/{customer}/feedItems/{feed_item}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemId">The <c>FeedItem</c> ID. Must not be <c>null</c> or empty.</param>
        public FeedItemName(string customerId, string feedItemId) : this(ResourceNameType.CustomerFeedItem, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedItemId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemId, nameof(feedItemId)))
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
        /// The <c>FeedItem</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FeedItemId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerFeedItem: return s_customerFeedItem.Expand(CustomerId, FeedItemId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeedItemName);

        /// <inheritdoc/>
        public bool Equals(FeedItemName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(FeedItemName a, FeedItemName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(FeedItemName a, FeedItemName b) => !(a == b);
    }

    public partial class FeedItem
    {
        /// <summary>
        /// <see cref="FeedItemName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal FeedItemName ResourceNameAsFeedItemName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : FeedItemName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary><see cref="FeedName"/>-typed view over the <see cref="Feed"/> resource name property.</summary>
        internal FeedName FeedAsFeedName
        {
            get => string.IsNullOrEmpty(Feed) ? null : FeedName.Parse(Feed, allowUnparsed: true);
            set => Feed = value?.ToString() ?? "";
        }
    }
}

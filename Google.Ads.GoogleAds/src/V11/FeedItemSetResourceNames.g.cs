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

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V11.Resources
{
    /// <summary>Resource name for the <c>FeedItemSet</c> resource.</summary>
    public sealed partial class FeedItemSetName : gax::IResourceName, sys::IEquatable<FeedItemSetName>
    {
        /// <summary>The possible contents of <see cref="FeedItemSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c>.
            /// </summary>
            CustomerFeedFeedItemSet = 1,
        }

        private static gax::PathTemplate s_customerFeedFeedItemSet = new gax::PathTemplate("customers/{customer_id}/feedItemSets/{feed_id_feed_item_set_id}");

        /// <summary>Creates a <see cref="FeedItemSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeedItemSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeedItemSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeedItemSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeedItemSetName"/> with the pattern
        /// <c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemSetId">The <c>FeedItemSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="FeedItemSetName"/> constructed from the provided ids.</returns>
        public static FeedItemSetName FromCustomerFeedFeedItemSet(string customerId, string feedId, string feedItemSetId) =>
            new FeedItemSetName(ResourceNameType.CustomerFeedFeedItemSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)), feedItemSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemSetId, nameof(feedItemSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedItemSetName"/> with pattern
        /// <c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemSetId">The <c>FeedItemSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedItemSetName"/> with pattern
        /// <c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c>.
        /// </returns>
        public static string Format(string customerId, string feedId, string feedItemSetId) =>
            FormatCustomerFeedFeedItemSet(customerId, feedId, feedItemSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedItemSetName"/> with pattern
        /// <c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemSetId">The <c>FeedItemSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FeedItemSetName"/> with pattern
        /// <c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c>.
        /// </returns>
        public static string FormatCustomerFeedFeedItemSet(string customerId, string feedId, string feedItemSetId) =>
            s_customerFeedFeedItemSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemSetId, nameof(feedItemSetId)))}");

        /// <summary>Parses the given resource name string into a new <see cref="FeedItemSetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedItemSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedItemSetName"/> if successful.</returns>
        public static FeedItemSetName Parse(string feedItemSetName) => Parse(feedItemSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedItemSetName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedItemSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeedItemSetName"/> if successful.</returns>
        public static FeedItemSetName Parse(string feedItemSetName, bool allowUnparsed) =>
            TryParse(feedItemSetName, allowUnparsed, out FeedItemSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedItemSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedItemSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedItemSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedItemSetName, out FeedItemSetName result) =>
            TryParse(feedItemSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedItemSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedItemSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedItemSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedItemSetName, bool allowUnparsed, out FeedItemSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedItemSetName, nameof(feedItemSetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerFeedFeedItemSet.TryParseName(feedItemSetName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerFeedFeedItemSet(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(feedItemSetName, out gax::UnparsedResourceName unparsedResourceName))
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

        private FeedItemSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string feedId = null, string feedItemSetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            FeedId = feedId;
            FeedItemSetId = feedItemSetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeedItemSetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/feedItemSets/{feed_id}~{feed_item_set_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedItemSetId">The <c>FeedItemSet</c> ID. Must not be <c>null</c> or empty.</param>
        public FeedItemSetName(string customerId, string feedId, string feedItemSetId) : this(ResourceNameType.CustomerFeedFeedItemSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)), feedItemSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedItemSetId, nameof(feedItemSetId)))
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
        /// The <c>Feed</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FeedId { get; }

        /// <summary>
        /// The <c>FeedItemSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FeedItemSetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerFeedFeedItemSet: return s_customerFeedFeedItemSet.Expand(CustomerId, $"{FeedId}~{FeedItemSetId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeedItemSetName);

        /// <inheritdoc/>
        public bool Equals(FeedItemSetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(FeedItemSetName a, FeedItemSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(FeedItemSetName a, FeedItemSetName b) => !(a == b);
    }

    public partial class FeedItemSet
    {
        /// <summary>
        /// <see cref="FeedItemSetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal FeedItemSetName ResourceNameAsFeedItemSetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : FeedItemSetName.Parse(ResourceName, allowUnparsed: true);
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

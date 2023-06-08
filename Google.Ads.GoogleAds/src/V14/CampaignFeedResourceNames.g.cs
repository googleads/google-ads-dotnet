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

namespace Google.Ads.GoogleAds.V14.Resources
{
    /// <summary>Resource name for the <c>CampaignFeed</c> resource.</summary>
    public sealed partial class CampaignFeedName : gax::IResourceName, sys::IEquatable<CampaignFeedName>
    {
        /// <summary>The possible contents of <see cref="CampaignFeedName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c>.
            /// </summary>
            CustomerCampaignFeed = 1,
        }

        private static gax::PathTemplate s_customerCampaignFeed = new gax::PathTemplate("customers/{customer_id}/campaignFeeds/{campaign_id_feed_id}");

        /// <summary>Creates a <see cref="CampaignFeedName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignFeedName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignFeedName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignFeedName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignFeedName"/> with the pattern
        /// <c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignFeedName"/> constructed from the provided ids.</returns>
        public static CampaignFeedName FromCustomerCampaignFeed(string customerId, string campaignId, string feedId) =>
            new CampaignFeedName(ResourceNameType.CustomerCampaignFeed, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), feedId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignFeedName"/> with pattern
        /// <c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignFeedName"/> with pattern
        /// <c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string feedId) =>
            FormatCustomerCampaignFeed(customerId, campaignId, feedId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignFeedName"/> with pattern
        /// <c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignFeedName"/> with pattern
        /// <c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c>.
        /// </returns>
        public static string FormatCustomerCampaignFeed(string customerId, string campaignId, string feedId) =>
            s_customerCampaignFeed.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)))}");

        /// <summary>Parses the given resource name string into a new <see cref="CampaignFeedName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignFeedName"/> if successful.</returns>
        public static CampaignFeedName Parse(string campaignFeedName) => Parse(campaignFeedName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignFeedName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignFeedName"/> if successful.</returns>
        public static CampaignFeedName Parse(string campaignFeedName, bool allowUnparsed) =>
            TryParse(campaignFeedName, allowUnparsed, out CampaignFeedName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignFeedName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignFeedName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignFeedName, out CampaignFeedName result) =>
            TryParse(campaignFeedName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignFeedName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignFeedName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignFeedName, bool allowUnparsed, out CampaignFeedName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignFeedName, nameof(campaignFeedName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignFeed.TryParseName(campaignFeedName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignFeed(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignFeedName, out gax::UnparsedResourceName unparsedResourceName))
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

        private CampaignFeedName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string customerId = null, string feedId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CustomerId = customerId;
            FeedId = feedId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignFeedName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/campaignFeeds/{campaign_id}~{feed_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignFeedName(string customerId, string campaignId, string feedId) : this(ResourceNameType.CustomerCampaignFeed, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), feedId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)))
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
        /// The <c>Campaign</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CampaignId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>Feed</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FeedId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignFeed: return s_customerCampaignFeed.Expand(CustomerId, $"{CampaignId}~{FeedId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignFeedName);

        /// <inheritdoc/>
        public bool Equals(CampaignFeedName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignFeedName a, CampaignFeedName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignFeedName a, CampaignFeedName b) => !(a == b);
    }

    public partial class CampaignFeed
    {
        /// <summary>
        /// <see cref="CampaignFeedName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CampaignFeedName ResourceNameAsCampaignFeedName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignFeedName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary><see cref="FeedName"/>-typed view over the <see cref="Feed"/> resource name property.</summary>
        internal FeedName FeedAsFeedName
        {
            get => string.IsNullOrEmpty(Feed) ? null : FeedName.Parse(Feed, allowUnparsed: true);
            set => Feed = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaign"/> resource name property.
        /// </summary>
        internal CampaignName CampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(Campaign) ? null : CampaignName.Parse(Campaign, allowUnparsed: true);
            set => Campaign = value?.ToString() ?? "";
        }
    }
}

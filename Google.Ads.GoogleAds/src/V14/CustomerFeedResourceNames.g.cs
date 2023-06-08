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
    /// <summary>Resource name for the <c>CustomerFeed</c> resource.</summary>
    public sealed partial class CustomerFeedName : gax::IResourceName, sys::IEquatable<CustomerFeedName>
    {
        /// <summary>The possible contents of <see cref="CustomerFeedName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/customerFeeds/{feed_id}</c>.</summary>
            CustomerFeed = 1,
        }

        private static gax::PathTemplate s_customerFeed = new gax::PathTemplate("customers/{customer_id}/customerFeeds/{feed_id}");

        /// <summary>Creates a <see cref="CustomerFeedName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerFeedName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerFeedName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerFeedName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerFeedName"/> with the pattern <c>customers/{customer_id}/customerFeeds/{feed_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomerFeedName"/> constructed from the provided ids.</returns>
        public static CustomerFeedName FromCustomerFeed(string customerId, string feedId) =>
            new CustomerFeedName(ResourceNameType.CustomerFeed, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerFeedName"/> with pattern
        /// <c>customers/{customer_id}/customerFeeds/{feed_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerFeedName"/> with pattern
        /// <c>customers/{customer_id}/customerFeeds/{feed_id}</c>.
        /// </returns>
        public static string Format(string customerId, string feedId) => FormatCustomerFeed(customerId, feedId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerFeedName"/> with pattern
        /// <c>customers/{customer_id}/customerFeeds/{feed_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerFeedName"/> with pattern
        /// <c>customers/{customer_id}/customerFeeds/{feed_id}</c>.
        /// </returns>
        public static string FormatCustomerFeed(string customerId, string feedId) =>
            s_customerFeed.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)));

        /// <summary>Parses the given resource name string into a new <see cref="CustomerFeedName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerFeeds/{feed_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerFeedName"/> if successful.</returns>
        public static CustomerFeedName Parse(string customerFeedName) => Parse(customerFeedName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerFeedName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerFeeds/{feed_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerFeedName"/> if successful.</returns>
        public static CustomerFeedName Parse(string customerFeedName, bool allowUnparsed) =>
            TryParse(customerFeedName, allowUnparsed, out CustomerFeedName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerFeedName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerFeeds/{feed_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerFeedName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerFeedName, out CustomerFeedName result) =>
            TryParse(customerFeedName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerFeedName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerFeeds/{feed_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerFeedName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerFeedName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerFeedName, bool allowUnparsed, out CustomerFeedName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerFeedName, nameof(customerFeedName));
            gax::TemplatedResourceName resourceName;
            if (s_customerFeed.TryParseName(customerFeedName, out resourceName))
            {
                result = FromCustomerFeed(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerFeedName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerFeedName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string feedId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            FeedId = feedId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerFeedName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/customerFeeds/{feed_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedId">The <c>Feed</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerFeedName(string customerId, string feedId) : this(ResourceNameType.CustomerFeed, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedId, nameof(feedId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerFeed: return s_customerFeed.Expand(CustomerId, FeedId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerFeedName);

        /// <inheritdoc/>
        public bool Equals(CustomerFeedName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerFeedName a, CustomerFeedName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerFeedName a, CustomerFeedName b) => !(a == b);
    }

    public partial class CustomerFeed
    {
        /// <summary>
        /// <see cref="CustomerFeedName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CustomerFeedName ResourceNameAsCustomerFeedName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerFeedName.Parse(ResourceName, allowUnparsed: true);
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

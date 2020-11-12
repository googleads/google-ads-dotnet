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
    /// <summary>Resource name for the <c>FeedPlaceholderView</c> resource.</summary>
    public sealed partial class FeedPlaceholderViewName : gax::IResourceName, sys::IEquatable<FeedPlaceholderViewName>
    {
        /// <summary>The possible contents of <see cref="FeedPlaceholderViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c>.
            /// </summary>
            CustomerFeedPlaceholderView = 1,
        }

        private static gax::PathTemplate s_customerFeedPlaceholderView = new gax::PathTemplate("customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}");

        /// <summary>Creates a <see cref="FeedPlaceholderViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FeedPlaceholderViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FeedPlaceholderViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FeedPlaceholderViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FeedPlaceholderViewName"/> with the pattern
        /// <c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedPlaceholderViewId">
        /// The <c>FeedPlaceholderView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="FeedPlaceholderViewName"/> constructed from the provided ids.
        /// </returns>
        public static FeedPlaceholderViewName FromCustomerFeedPlaceholderView(string customerId, string feedPlaceholderViewId) =>
            new FeedPlaceholderViewName(ResourceNameType.CustomerFeedPlaceholderView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedPlaceholderViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedPlaceholderViewId, nameof(feedPlaceholderViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedPlaceholderViewName"/> with pattern
        /// <c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedPlaceholderViewId">
        /// The <c>FeedPlaceholderView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FeedPlaceholderViewName"/> with pattern
        /// <c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c>.
        /// </returns>
        public static string Format(string customerId, string feedPlaceholderViewId) =>
            FormatCustomerFeedPlaceholderView(customerId, feedPlaceholderViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FeedPlaceholderViewName"/> with pattern
        /// <c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedPlaceholderViewId">
        /// The <c>FeedPlaceholderView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="FeedPlaceholderViewName"/> with pattern
        /// <c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c>.
        /// </returns>
        public static string FormatCustomerFeedPlaceholderView(string customerId, string feedPlaceholderViewId) =>
            s_customerFeedPlaceholderView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(feedPlaceholderViewId, nameof(feedPlaceholderViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedPlaceholderViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedPlaceholderViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="FeedPlaceholderViewName"/> if successful.</returns>
        public static FeedPlaceholderViewName Parse(string feedPlaceholderViewName) => Parse(feedPlaceholderViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FeedPlaceholderViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedPlaceholderViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FeedPlaceholderViewName"/> if successful.</returns>
        public static FeedPlaceholderViewName Parse(string feedPlaceholderViewName, bool allowUnparsed) =>
            TryParse(feedPlaceholderViewName, allowUnparsed, out FeedPlaceholderViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedPlaceholderViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="feedPlaceholderViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedPlaceholderViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedPlaceholderViewName, out FeedPlaceholderViewName result) =>
            TryParse(feedPlaceholderViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FeedPlaceholderViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="feedPlaceholderViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FeedPlaceholderViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string feedPlaceholderViewName, bool allowUnparsed, out FeedPlaceholderViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(feedPlaceholderViewName, nameof(feedPlaceholderViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerFeedPlaceholderView.TryParseName(feedPlaceholderViewName, out resourceName))
            {
                result = FromCustomerFeedPlaceholderView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(feedPlaceholderViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private FeedPlaceholderViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string feedPlaceholderViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            FeedPlaceholderViewId = feedPlaceholderViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FeedPlaceholderViewName"/> class from the component parts of
        /// pattern <c>customers/{customer}/feedPlaceholderViews/{feed_placeholder_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedPlaceholderViewId">
        /// The <c>FeedPlaceholderView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public FeedPlaceholderViewName(string customerId, string feedPlaceholderViewId) : this(ResourceNameType.CustomerFeedPlaceholderView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), feedPlaceholderViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedPlaceholderViewId, nameof(feedPlaceholderViewId)))
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
        /// The <c>FeedPlaceholderView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string FeedPlaceholderViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerFeedPlaceholderView: return s_customerFeedPlaceholderView.Expand(CustomerId, FeedPlaceholderViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FeedPlaceholderViewName);

        /// <inheritdoc/>
        public bool Equals(FeedPlaceholderViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(FeedPlaceholderViewName a, FeedPlaceholderViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(FeedPlaceholderViewName a, FeedPlaceholderViewName b) => !(a == b);
    }

    public partial class FeedPlaceholderView
    {
        /// <summary>
        /// <see cref="FeedPlaceholderViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal FeedPlaceholderViewName ResourceNameAsFeedPlaceholderViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : FeedPlaceholderViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

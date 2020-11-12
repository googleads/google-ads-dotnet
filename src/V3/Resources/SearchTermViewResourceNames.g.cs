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
    /// <summary>Resource name for the <c>SearchTermView</c> resource.</summary>
    public sealed partial class SearchTermViewName : gax::IResourceName, sys::IEquatable<SearchTermViewName>
    {
        /// <summary>The possible contents of <see cref="SearchTermViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/searchTermViews/{search_term_view}</c>.
            /// </summary>
            CustomerSearchTermView = 1,
        }

        private static gax::PathTemplate s_customerSearchTermView = new gax::PathTemplate("customers/{customer}/searchTermViews/{search_term_view}");

        /// <summary>Creates a <see cref="SearchTermViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SearchTermViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SearchTermViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SearchTermViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SearchTermViewName"/> with the pattern
        /// <c>customers/{customer}/searchTermViews/{search_term_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermViewId">The <c>SearchTermView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SearchTermViewName"/> constructed from the provided ids.</returns>
        public static SearchTermViewName FromCustomerSearchTermView(string customerId, string searchTermViewId) =>
            new SearchTermViewName(ResourceNameType.CustomerSearchTermView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), searchTermViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchTermViewId, nameof(searchTermViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SearchTermViewName"/> with pattern
        /// <c>customers/{customer}/searchTermViews/{search_term_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermViewId">The <c>SearchTermView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SearchTermViewName"/> with pattern
        /// <c>customers/{customer}/searchTermViews/{search_term_view}</c>.
        /// </returns>
        public static string Format(string customerId, string searchTermViewId) =>
            FormatCustomerSearchTermView(customerId, searchTermViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SearchTermViewName"/> with pattern
        /// <c>customers/{customer}/searchTermViews/{search_term_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermViewId">The <c>SearchTermView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SearchTermViewName"/> with pattern
        /// <c>customers/{customer}/searchTermViews/{search_term_view}</c>.
        /// </returns>
        public static string FormatCustomerSearchTermView(string customerId, string searchTermViewId) =>
            s_customerSearchTermView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(searchTermViewId, nameof(searchTermViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/searchTermViews/{search_term_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="searchTermViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SearchTermViewName"/> if successful.</returns>
        public static SearchTermViewName Parse(string searchTermViewName) => Parse(searchTermViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SearchTermViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/searchTermViews/{search_term_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="searchTermViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SearchTermViewName"/> if successful.</returns>
        public static SearchTermViewName Parse(string searchTermViewName, bool allowUnparsed) =>
            TryParse(searchTermViewName, allowUnparsed, out SearchTermViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/searchTermViews/{search_term_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="searchTermViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SearchTermViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchTermViewName, out SearchTermViewName result) =>
            TryParse(searchTermViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SearchTermViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/searchTermViews/{search_term_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="searchTermViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SearchTermViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchTermViewName, bool allowUnparsed, out SearchTermViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(searchTermViewName, nameof(searchTermViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerSearchTermView.TryParseName(searchTermViewName, out resourceName))
            {
                result = FromCustomerSearchTermView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(searchTermViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SearchTermViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string searchTermViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            SearchTermViewId = searchTermViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SearchTermViewName"/> class from the component parts of pattern
        /// <c>customers/{customer}/searchTermViews/{search_term_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermViewId">The <c>SearchTermView</c> ID. Must not be <c>null</c> or empty.</param>
        public SearchTermViewName(string customerId, string searchTermViewId) : this(ResourceNameType.CustomerSearchTermView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), searchTermViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchTermViewId, nameof(searchTermViewId)))
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
        /// The <c>SearchTermView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SearchTermViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerSearchTermView: return s_customerSearchTermView.Expand(CustomerId, SearchTermViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SearchTermViewName);

        /// <inheritdoc/>
        public bool Equals(SearchTermViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SearchTermViewName a, SearchTermViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SearchTermViewName a, SearchTermViewName b) => !(a == b);
    }

    public partial class SearchTermView
    {
        /// <summary>
        /// <see cref="SearchTermViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal SearchTermViewName ResourceNameAsSearchTermViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : SearchTermViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
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

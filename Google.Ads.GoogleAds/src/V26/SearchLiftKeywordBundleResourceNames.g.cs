// Copyright 2026 Google LLC
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

namespace Google.Ads.GoogleAds.V26.Resources
{
    /// <summary>Resource name for the <c>SearchLiftKeywordBundle</c> resource.</summary>
    public sealed partial class SearchLiftKeywordBundleName : gax::IResourceName, sys::IEquatable<SearchLiftKeywordBundleName>
    {
        /// <summary>The possible contents of <see cref="SearchLiftKeywordBundleName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>.
            /// </summary>
            CustomerSearchLiftKeywordBundle = 1,
        }

        private static gax::PathTemplate s_customerSearchLiftKeywordBundle = new gax::PathTemplate("customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}");

        /// <summary>Creates a <see cref="SearchLiftKeywordBundleName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SearchLiftKeywordBundleName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SearchLiftKeywordBundleName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SearchLiftKeywordBundleName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SearchLiftKeywordBundleName"/> with the pattern
        /// <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchLiftKeywordBundleId">
        /// The <c>SearchLiftKeywordBundle</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="SearchLiftKeywordBundleName"/> constructed from the provided ids.
        /// </returns>
        public static SearchLiftKeywordBundleName FromCustomerSearchLiftKeywordBundle(string customerId, string searchLiftKeywordBundleId) =>
            new SearchLiftKeywordBundleName(ResourceNameType.CustomerSearchLiftKeywordBundle, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), searchLiftKeywordBundleId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchLiftKeywordBundleId, nameof(searchLiftKeywordBundleId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SearchLiftKeywordBundleName"/> with
        /// pattern <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchLiftKeywordBundleId">
        /// The <c>SearchLiftKeywordBundle</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SearchLiftKeywordBundleName"/> with pattern
        /// <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>.
        /// </returns>
        public static string Format(string customerId, string searchLiftKeywordBundleId) =>
            FormatCustomerSearchLiftKeywordBundle(customerId, searchLiftKeywordBundleId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SearchLiftKeywordBundleName"/> with
        /// pattern <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchLiftKeywordBundleId">
        /// The <c>SearchLiftKeywordBundle</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="SearchLiftKeywordBundleName"/> with pattern
        /// <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>.
        /// </returns>
        public static string FormatCustomerSearchLiftKeywordBundle(string customerId, string searchLiftKeywordBundleId) =>
            s_customerSearchLiftKeywordBundle.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(searchLiftKeywordBundleId, nameof(searchLiftKeywordBundleId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SearchLiftKeywordBundleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="searchLiftKeywordBundleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SearchLiftKeywordBundleName"/> if successful.</returns>
        public static SearchLiftKeywordBundleName Parse(string searchLiftKeywordBundleName) =>
            Parse(searchLiftKeywordBundleName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SearchLiftKeywordBundleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="searchLiftKeywordBundleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SearchLiftKeywordBundleName"/> if successful.</returns>
        public static SearchLiftKeywordBundleName Parse(string searchLiftKeywordBundleName, bool allowUnparsed) =>
            TryParse(searchLiftKeywordBundleName, allowUnparsed, out SearchLiftKeywordBundleName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SearchLiftKeywordBundleName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="searchLiftKeywordBundleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SearchLiftKeywordBundleName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchLiftKeywordBundleName, out SearchLiftKeywordBundleName result) =>
            TryParse(searchLiftKeywordBundleName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SearchLiftKeywordBundleName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="searchLiftKeywordBundleName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SearchLiftKeywordBundleName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string searchLiftKeywordBundleName, bool allowUnparsed, out SearchLiftKeywordBundleName result)
        {
            gax::GaxPreconditions.CheckNotNull(searchLiftKeywordBundleName, nameof(searchLiftKeywordBundleName));
            gax::TemplatedResourceName resourceName;
            if (s_customerSearchLiftKeywordBundle.TryParseName(searchLiftKeywordBundleName, out resourceName))
            {
                result = FromCustomerSearchLiftKeywordBundle(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(searchLiftKeywordBundleName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SearchLiftKeywordBundleName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string searchLiftKeywordBundleId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            SearchLiftKeywordBundleId = searchLiftKeywordBundleId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SearchLiftKeywordBundleName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/searchLiftKeywordBundles/{search_lift_keyword_bundle_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchLiftKeywordBundleId">
        /// The <c>SearchLiftKeywordBundle</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public SearchLiftKeywordBundleName(string customerId, string searchLiftKeywordBundleId) : this(ResourceNameType.CustomerSearchLiftKeywordBundle, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), searchLiftKeywordBundleId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchLiftKeywordBundleId, nameof(searchLiftKeywordBundleId)))
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
        /// The <c>SearchLiftKeywordBundle</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string SearchLiftKeywordBundleId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerSearchLiftKeywordBundle: return s_customerSearchLiftKeywordBundle.Expand(CustomerId, SearchLiftKeywordBundleId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SearchLiftKeywordBundleName);

        /// <inheritdoc/>
        public bool Equals(SearchLiftKeywordBundleName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(SearchLiftKeywordBundleName a, SearchLiftKeywordBundleName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(SearchLiftKeywordBundleName a, SearchLiftKeywordBundleName b) => !(a == b);
    }

    public partial class SearchLiftKeywordBundle
    {
        /// <summary>
        /// <see cref="SearchLiftKeywordBundleName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal SearchLiftKeywordBundleName ResourceNameAsSearchLiftKeywordBundleName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : SearchLiftKeywordBundleName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

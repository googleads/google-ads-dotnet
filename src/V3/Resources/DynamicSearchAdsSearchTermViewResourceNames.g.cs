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
    /// <summary>Resource name for the <c>DynamicSearchAdsSearchTermView</c> resource.</summary>
    public sealed partial class DynamicSearchAdsSearchTermViewName : gax::IResourceName, sys::IEquatable<DynamicSearchAdsSearchTermViewName>
    {
        /// <summary>The possible contents of <see cref="DynamicSearchAdsSearchTermViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>.
            /// </summary>
            CustomerDynamicSearchAdsSearchTermView = 1,
        }

        private static gax::PathTemplate s_customerDynamicSearchAdsSearchTermView = new gax::PathTemplate("customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}");

        /// <summary>
        /// Creates a <see cref="DynamicSearchAdsSearchTermViewName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DynamicSearchAdsSearchTermViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DynamicSearchAdsSearchTermViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DynamicSearchAdsSearchTermViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DynamicSearchAdsSearchTermViewName"/> with the pattern
        /// <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dynamicSearchAdsSearchTermViewId">
        /// The <c>DynamicSearchAdsSearchTermView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="DynamicSearchAdsSearchTermViewName"/> constructed from the provided ids.
        /// </returns>
        public static DynamicSearchAdsSearchTermViewName FromCustomerDynamicSearchAdsSearchTermView(string customerId, string dynamicSearchAdsSearchTermViewId) =>
            new DynamicSearchAdsSearchTermViewName(ResourceNameType.CustomerDynamicSearchAdsSearchTermView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), dynamicSearchAdsSearchTermViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(dynamicSearchAdsSearchTermViewId, nameof(dynamicSearchAdsSearchTermViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DynamicSearchAdsSearchTermViewName"/> with
        /// pattern <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dynamicSearchAdsSearchTermViewId">
        /// The <c>DynamicSearchAdsSearchTermView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DynamicSearchAdsSearchTermViewName"/> with pattern
        /// <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>.
        /// </returns>
        public static string Format(string customerId, string dynamicSearchAdsSearchTermViewId) =>
            FormatCustomerDynamicSearchAdsSearchTermView(customerId, dynamicSearchAdsSearchTermViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DynamicSearchAdsSearchTermViewName"/> with
        /// pattern <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dynamicSearchAdsSearchTermViewId">
        /// The <c>DynamicSearchAdsSearchTermView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DynamicSearchAdsSearchTermViewName"/> with pattern
        /// <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>.
        /// </returns>
        public static string FormatCustomerDynamicSearchAdsSearchTermView(string customerId, string dynamicSearchAdsSearchTermViewId) =>
            s_customerDynamicSearchAdsSearchTermView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(dynamicSearchAdsSearchTermViewId, nameof(dynamicSearchAdsSearchTermViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DynamicSearchAdsSearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dynamicSearchAdsSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="DynamicSearchAdsSearchTermViewName"/> if successful.</returns>
        public static DynamicSearchAdsSearchTermViewName Parse(string dynamicSearchAdsSearchTermViewName) =>
            Parse(dynamicSearchAdsSearchTermViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DynamicSearchAdsSearchTermViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dynamicSearchAdsSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DynamicSearchAdsSearchTermViewName"/> if successful.</returns>
        public static DynamicSearchAdsSearchTermViewName Parse(string dynamicSearchAdsSearchTermViewName, bool allowUnparsed) =>
            TryParse(dynamicSearchAdsSearchTermViewName, allowUnparsed, out DynamicSearchAdsSearchTermViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DynamicSearchAdsSearchTermViewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dynamicSearchAdsSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DynamicSearchAdsSearchTermViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dynamicSearchAdsSearchTermViewName, out DynamicSearchAdsSearchTermViewName result) =>
            TryParse(dynamicSearchAdsSearchTermViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DynamicSearchAdsSearchTermViewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dynamicSearchAdsSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DynamicSearchAdsSearchTermViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dynamicSearchAdsSearchTermViewName, bool allowUnparsed, out DynamicSearchAdsSearchTermViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(dynamicSearchAdsSearchTermViewName, nameof(dynamicSearchAdsSearchTermViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerDynamicSearchAdsSearchTermView.TryParseName(dynamicSearchAdsSearchTermViewName, out resourceName))
            {
                result = FromCustomerDynamicSearchAdsSearchTermView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dynamicSearchAdsSearchTermViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DynamicSearchAdsSearchTermViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string dynamicSearchAdsSearchTermViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            DynamicSearchAdsSearchTermViewId = dynamicSearchAdsSearchTermViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DynamicSearchAdsSearchTermViewName"/> class from the component
        /// parts of pattern
        /// <c>customers/{customer}/dynamicSearchAdsSearchTermViews/{dynamic_search_ads_search_term_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dynamicSearchAdsSearchTermViewId">
        /// The <c>DynamicSearchAdsSearchTermView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DynamicSearchAdsSearchTermViewName(string customerId, string dynamicSearchAdsSearchTermViewId) : this(ResourceNameType.CustomerDynamicSearchAdsSearchTermView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), dynamicSearchAdsSearchTermViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(dynamicSearchAdsSearchTermViewId, nameof(dynamicSearchAdsSearchTermViewId)))
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
        /// The <c>DynamicSearchAdsSearchTermView</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string DynamicSearchAdsSearchTermViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerDynamicSearchAdsSearchTermView: return s_customerDynamicSearchAdsSearchTermView.Expand(CustomerId, DynamicSearchAdsSearchTermViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DynamicSearchAdsSearchTermViewName);

        /// <inheritdoc/>
        public bool Equals(DynamicSearchAdsSearchTermViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DynamicSearchAdsSearchTermViewName a, DynamicSearchAdsSearchTermViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DynamicSearchAdsSearchTermViewName a, DynamicSearchAdsSearchTermViewName b) => !(a == b);
    }

    public partial class DynamicSearchAdsSearchTermView
    {
        /// <summary>
        /// <see cref="DynamicSearchAdsSearchTermViewName"/>-typed view over the <see cref="ResourceName"/> resource
        /// name property.
        /// </summary>
        internal DynamicSearchAdsSearchTermViewName ResourceNameAsDynamicSearchAdsSearchTermViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : DynamicSearchAdsSearchTermViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

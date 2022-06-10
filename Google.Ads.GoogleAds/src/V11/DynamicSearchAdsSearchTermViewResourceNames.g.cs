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
            /// <c>
            /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
            /// .
            /// </summary>
            CustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint = 1,
        }

        private static gax::PathTemplate s_customerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint = new gax::PathTemplate("customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id_search_term_fingerprint_headline_fingerprint_landing_page_fingerprint_page_url_fingerprint}");

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
        /// <c>
        /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermFingerprintId">
        /// The <c>SearchTermFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="headlineFingerprintId">
        /// The <c>HeadlineFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="landingPageFingerprintId">
        /// The <c>LandingPageFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="pageUrlFingerprintId">
        /// The <c>PageUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="DynamicSearchAdsSearchTermViewName"/> constructed from the provided ids.
        /// </returns>
        public static DynamicSearchAdsSearchTermViewName FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint(string customerId, string adGroupId, string searchTermFingerprintId, string headlineFingerprintId, string landingPageFingerprintId, string pageUrlFingerprintId) =>
            new DynamicSearchAdsSearchTermViewName(ResourceNameType.CustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), searchTermFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchTermFingerprintId, nameof(searchTermFingerprintId)), headlineFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(headlineFingerprintId, nameof(headlineFingerprintId)), landingPageFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(landingPageFingerprintId, nameof(landingPageFingerprintId)), pageUrlFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(pageUrlFingerprintId, nameof(pageUrlFingerprintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DynamicSearchAdsSearchTermViewName"/> with
        /// pattern
        /// <c>
        /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermFingerprintId">
        /// The <c>SearchTermFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="headlineFingerprintId">
        /// The <c>HeadlineFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="landingPageFingerprintId">
        /// The <c>LandingPageFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="pageUrlFingerprintId">
        /// The <c>PageUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DynamicSearchAdsSearchTermViewName"/> with pattern
        /// <c>
        /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
        /// .
        /// </returns>
        public static string Format(string customerId, string adGroupId, string searchTermFingerprintId, string headlineFingerprintId, string landingPageFingerprintId, string pageUrlFingerprintId) =>
            FormatCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint(customerId, adGroupId, searchTermFingerprintId, headlineFingerprintId, landingPageFingerprintId, pageUrlFingerprintId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DynamicSearchAdsSearchTermViewName"/> with
        /// pattern
        /// <c>
        /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermFingerprintId">
        /// The <c>SearchTermFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="headlineFingerprintId">
        /// The <c>HeadlineFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="landingPageFingerprintId">
        /// The <c>LandingPageFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="pageUrlFingerprintId">
        /// The <c>PageUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DynamicSearchAdsSearchTermViewName"/> with pattern
        /// <c>
        /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
        /// .
        /// </returns>
        public static string FormatCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint(string customerId, string adGroupId, string searchTermFingerprintId, string headlineFingerprintId, string landingPageFingerprintId, string pageUrlFingerprintId) =>
            s_customerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(searchTermFingerprintId, nameof(searchTermFingerprintId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(headlineFingerprintId, nameof(headlineFingerprintId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(landingPageFingerprintId, nameof(landingPageFingerprintId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(pageUrlFingerprintId, nameof(pageUrlFingerprintId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DynamicSearchAdsSearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
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
        /// <c>
        /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
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
        /// <c>
        /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
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
        /// <c>
        /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
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
            if (s_customerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint.TryParseName(dynamicSearchAdsSearchTermViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint(resourceName[0], split1[0], split1[1], split1[2], split1[3], split1[4]);
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

        private DynamicSearchAdsSearchTermViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupId = null, string customerId = null, string headlineFingerprintId = null, string landingPageFingerprintId = null, string pageUrlFingerprintId = null, string searchTermFingerprintId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupId = adGroupId;
            CustomerId = customerId;
            HeadlineFingerprintId = headlineFingerprintId;
            LandingPageFingerprintId = landingPageFingerprintId;
            PageUrlFingerprintId = pageUrlFingerprintId;
            SearchTermFingerprintId = searchTermFingerprintId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DynamicSearchAdsSearchTermViewName"/> class from the component
        /// parts of pattern
        /// <c>
        /// customers/{customer_id}/dynamicSearchAdsSearchTermViews/{ad_group_id}~{search_term_fingerprint}~{headline_fingerprint}~{landing_page_fingerprint}~{page_url_fingerprint}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermFingerprintId">
        /// The <c>SearchTermFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="headlineFingerprintId">
        /// The <c>HeadlineFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="landingPageFingerprintId">
        /// The <c>LandingPageFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="pageUrlFingerprintId">
        /// The <c>PageUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DynamicSearchAdsSearchTermViewName(string customerId, string adGroupId, string searchTermFingerprintId, string headlineFingerprintId, string landingPageFingerprintId, string pageUrlFingerprintId) : this(ResourceNameType.CustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), searchTermFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchTermFingerprintId, nameof(searchTermFingerprintId)), headlineFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(headlineFingerprintId, nameof(headlineFingerprintId)), landingPageFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(landingPageFingerprintId, nameof(landingPageFingerprintId)), pageUrlFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(pageUrlFingerprintId, nameof(pageUrlFingerprintId)))
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
        /// The <c>AdGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdGroupId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>HeadlineFingerprint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string HeadlineFingerprintId { get; }

        /// <summary>
        /// The <c>LandingPageFingerprint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string LandingPageFingerprintId { get; }

        /// <summary>
        /// The <c>PageUrlFingerprint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string PageUrlFingerprintId { get; }

        /// <summary>
        /// The <c>SearchTermFingerprint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string SearchTermFingerprintId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint: return s_customerAdGroupSearchTermFingerprintHeadlineFingerprintLandingPageFingerprintPageUrlFingerprint.Expand(CustomerId, $"{AdGroupId}~{SearchTermFingerprintId}~{HeadlineFingerprintId}~{LandingPageFingerprintId}~{PageUrlFingerprintId}");
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

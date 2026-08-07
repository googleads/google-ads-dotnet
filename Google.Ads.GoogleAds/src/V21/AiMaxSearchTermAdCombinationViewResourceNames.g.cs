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

namespace Google.Ads.GoogleAds.V21.Resources
{
    /// <summary>Resource name for the <c>AiMaxSearchTermAdCombinationView</c> resource.</summary>
    public sealed partial class AiMaxSearchTermAdCombinationViewName : gax::IResourceName, sys::IEquatable<AiMaxSearchTermAdCombinationViewName>
    {
        /// <summary>The possible contents of <see cref="AiMaxSearchTermAdCombinationViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
            /// .
            /// </summary>
            CustomerAdGroupSearchTermLandingPageHeadline = 1,
        }

        private static gax::PathTemplate s_customerAdGroupSearchTermLandingPageHeadline = new gax::PathTemplate("customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id_search_term_landing_page_headline}");

        /// <summary>
        /// Creates a <see cref="AiMaxSearchTermAdCombinationViewName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AiMaxSearchTermAdCombinationViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AiMaxSearchTermAdCombinationViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AiMaxSearchTermAdCombinationViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AiMaxSearchTermAdCombinationViewName"/> with the pattern
        /// <c>
        /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermId">The <c>SearchTerm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="landingPageId">The <c>LandingPage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="headlineId">The <c>Headline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="AiMaxSearchTermAdCombinationViewName"/> constructed from the provided ids.
        /// </returns>
        public static AiMaxSearchTermAdCombinationViewName FromCustomerAdGroupSearchTermLandingPageHeadline(string customerId, string adGroupId, string searchTermId, string landingPageId, string headlineId) =>
            new AiMaxSearchTermAdCombinationViewName(ResourceNameType.CustomerAdGroupSearchTermLandingPageHeadline, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), searchTermId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchTermId, nameof(searchTermId)), landingPageId: gax::GaxPreconditions.CheckNotNullOrEmpty(landingPageId, nameof(landingPageId)), headlineId: gax::GaxPreconditions.CheckNotNullOrEmpty(headlineId, nameof(headlineId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AiMaxSearchTermAdCombinationViewName"/>
        /// with pattern
        /// <c>
        /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermId">The <c>SearchTerm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="landingPageId">The <c>LandingPage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="headlineId">The <c>Headline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AiMaxSearchTermAdCombinationViewName"/> with pattern
        /// <c>
        /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
        /// .
        /// </returns>
        public static string Format(string customerId, string adGroupId, string searchTermId, string landingPageId, string headlineId) =>
            FormatCustomerAdGroupSearchTermLandingPageHeadline(customerId, adGroupId, searchTermId, landingPageId, headlineId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AiMaxSearchTermAdCombinationViewName"/>
        /// with pattern
        /// <c>
        /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermId">The <c>SearchTerm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="landingPageId">The <c>LandingPage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="headlineId">The <c>Headline</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AiMaxSearchTermAdCombinationViewName"/> with pattern
        /// <c>
        /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
        /// .
        /// </returns>
        public static string FormatCustomerAdGroupSearchTermLandingPageHeadline(string customerId, string adGroupId, string searchTermId, string landingPageId, string headlineId) =>
            s_customerAdGroupSearchTermLandingPageHeadline.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(searchTermId, nameof(searchTermId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(landingPageId, nameof(landingPageId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(headlineId, nameof(headlineId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AiMaxSearchTermAdCombinationViewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="aiMaxSearchTermAdCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AiMaxSearchTermAdCombinationViewName"/> if successful.</returns>
        public static AiMaxSearchTermAdCombinationViewName Parse(string aiMaxSearchTermAdCombinationViewName) =>
            Parse(aiMaxSearchTermAdCombinationViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AiMaxSearchTermAdCombinationViewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="aiMaxSearchTermAdCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AiMaxSearchTermAdCombinationViewName"/> if successful.</returns>
        public static AiMaxSearchTermAdCombinationViewName Parse(string aiMaxSearchTermAdCombinationViewName, bool allowUnparsed) =>
            TryParse(aiMaxSearchTermAdCombinationViewName, allowUnparsed, out AiMaxSearchTermAdCombinationViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AiMaxSearchTermAdCombinationViewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="aiMaxSearchTermAdCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AiMaxSearchTermAdCombinationViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string aiMaxSearchTermAdCombinationViewName, out AiMaxSearchTermAdCombinationViewName result) =>
            TryParse(aiMaxSearchTermAdCombinationViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AiMaxSearchTermAdCombinationViewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="aiMaxSearchTermAdCombinationViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AiMaxSearchTermAdCombinationViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string aiMaxSearchTermAdCombinationViewName, bool allowUnparsed, out AiMaxSearchTermAdCombinationViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(aiMaxSearchTermAdCombinationViewName, nameof(aiMaxSearchTermAdCombinationViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupSearchTermLandingPageHeadline.TryParseName(aiMaxSearchTermAdCombinationViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAdGroupSearchTermLandingPageHeadline(resourceName[0], split1[0], split1[1], split1[2], split1[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(aiMaxSearchTermAdCombinationViewName, out gax::UnparsedResourceName unparsedResourceName))
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

        private AiMaxSearchTermAdCombinationViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupId = null, string customerId = null, string headlineId = null, string landingPageId = null, string searchTermId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupId = adGroupId;
            CustomerId = customerId;
            HeadlineId = headlineId;
            LandingPageId = landingPageId;
            SearchTermId = searchTermId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AiMaxSearchTermAdCombinationViewName"/> class from the component
        /// parts of pattern
        /// <c>
        /// customers/{customer_id}/aiMaxSearchTermAdCombinationViews/{ad_group_id}~{search_term}~{landing_page}~{headline}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="searchTermId">The <c>SearchTerm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="landingPageId">The <c>LandingPage</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="headlineId">The <c>Headline</c> ID. Must not be <c>null</c> or empty.</param>
        public AiMaxSearchTermAdCombinationViewName(string customerId, string adGroupId, string searchTermId, string landingPageId, string headlineId) : this(ResourceNameType.CustomerAdGroupSearchTermLandingPageHeadline, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), searchTermId: gax::GaxPreconditions.CheckNotNullOrEmpty(searchTermId, nameof(searchTermId)), landingPageId: gax::GaxPreconditions.CheckNotNullOrEmpty(landingPageId, nameof(landingPageId)), headlineId: gax::GaxPreconditions.CheckNotNullOrEmpty(headlineId, nameof(headlineId)))
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
        /// The <c>Headline</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string HeadlineId { get; }

        /// <summary>
        /// The <c>LandingPage</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LandingPageId { get; }

        /// <summary>
        /// The <c>SearchTerm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SearchTermId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerAdGroupSearchTermLandingPageHeadline: return s_customerAdGroupSearchTermLandingPageHeadline.Expand(CustomerId, $"{AdGroupId}~{SearchTermId}~{LandingPageId}~{HeadlineId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AiMaxSearchTermAdCombinationViewName);

        /// <inheritdoc/>
        public bool Equals(AiMaxSearchTermAdCombinationViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AiMaxSearchTermAdCombinationViewName a, AiMaxSearchTermAdCombinationViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AiMaxSearchTermAdCombinationViewName a, AiMaxSearchTermAdCombinationViewName b) => !(a == b);
    }

    public partial class AiMaxSearchTermAdCombinationView
    {
        /// <summary>
        /// <see cref="AiMaxSearchTermAdCombinationViewName"/>-typed view over the <see cref="ResourceName"/> resource
        /// name property.
        /// </summary>
        internal AiMaxSearchTermAdCombinationViewName ResourceNameAsAiMaxSearchTermAdCombinationViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AiMaxSearchTermAdCombinationViewName.Parse(ResourceName, allowUnparsed: true);
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

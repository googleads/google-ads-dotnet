// Copyright 2021 Google LLC
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

namespace Google.Ads.GoogleAds.V9.Resources
{
    /// <summary>Resource name for the <c>PaidOrganicSearchTermView</c> resource.</summary>
    public sealed partial class PaidOrganicSearchTermViewName : gax::IResourceName, sys::IEquatable<PaidOrganicSearchTermViewName>
    {
        /// <summary>The possible contents of <see cref="PaidOrganicSearchTermViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>
            /// .
            /// </summary>
            CustomerCampaignAdGroupBase64SearchTerm = 1,
        }

        private static gax::PathTemplate s_customerCampaignAdGroupBase64SearchTerm = new gax::PathTemplate("customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id_ad_group_id_base64_search_term}");

        /// <summary>
        /// Creates a <see cref="PaidOrganicSearchTermViewName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PaidOrganicSearchTermViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PaidOrganicSearchTermViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PaidOrganicSearchTermViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PaidOrganicSearchTermViewName"/> with the pattern
        /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64SearchTermId">The <c>Base64SearchTerm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="PaidOrganicSearchTermViewName"/> constructed from the provided ids.
        /// </returns>
        public static PaidOrganicSearchTermViewName FromCustomerCampaignAdGroupBase64SearchTerm(string customerId, string campaignId, string adGroupId, string base64SearchTermId) =>
            new PaidOrganicSearchTermViewName(ResourceNameType.CustomerCampaignAdGroupBase64SearchTerm, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), base64SearchTermId: gax::GaxPreconditions.CheckNotNullOrEmpty(base64SearchTermId, nameof(base64SearchTermId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PaidOrganicSearchTermViewName"/> with
        /// pattern
        /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64SearchTermId">The <c>Base64SearchTerm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PaidOrganicSearchTermViewName"/> with pattern
        /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string adGroupId, string base64SearchTermId) =>
            FormatCustomerCampaignAdGroupBase64SearchTerm(customerId, campaignId, adGroupId, base64SearchTermId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PaidOrganicSearchTermViewName"/> with
        /// pattern
        /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64SearchTermId">The <c>Base64SearchTerm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PaidOrganicSearchTermViewName"/> with pattern
        /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>.
        /// </returns>
        public static string FormatCustomerCampaignAdGroupBase64SearchTerm(string customerId, string campaignId, string adGroupId, string base64SearchTermId) =>
            s_customerCampaignAdGroupBase64SearchTerm.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(base64SearchTermId, nameof(base64SearchTermId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PaidOrganicSearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="paidOrganicSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="PaidOrganicSearchTermViewName"/> if successful.</returns>
        public static PaidOrganicSearchTermViewName Parse(string paidOrganicSearchTermViewName) =>
            Parse(paidOrganicSearchTermViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PaidOrganicSearchTermViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="paidOrganicSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PaidOrganicSearchTermViewName"/> if successful.</returns>
        public static PaidOrganicSearchTermViewName Parse(string paidOrganicSearchTermViewName, bool allowUnparsed) =>
            TryParse(paidOrganicSearchTermViewName, allowUnparsed, out PaidOrganicSearchTermViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PaidOrganicSearchTermViewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="paidOrganicSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PaidOrganicSearchTermViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string paidOrganicSearchTermViewName, out PaidOrganicSearchTermViewName result) =>
            TryParse(paidOrganicSearchTermViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PaidOrganicSearchTermViewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="paidOrganicSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PaidOrganicSearchTermViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string paidOrganicSearchTermViewName, bool allowUnparsed, out PaidOrganicSearchTermViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(paidOrganicSearchTermViewName, nameof(paidOrganicSearchTermViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignAdGroupBase64SearchTerm.TryParseName(paidOrganicSearchTermViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignAdGroupBase64SearchTerm(resourceName[0], split1[0], split1[1], split1[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(paidOrganicSearchTermViewName, out gax::UnparsedResourceName unparsedResourceName))
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

        private PaidOrganicSearchTermViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupId = null, string base64SearchTermId = null, string campaignId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupId = adGroupId;
            Base64SearchTermId = base64SearchTermId;
            CampaignId = campaignId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PaidOrganicSearchTermViewName"/> class from the component parts of
        /// pattern
        /// <c>customers/{customer_id}/paidOrganicSearchTermViews/{campaign_id}~{ad_group_id}~{base64_search_term}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64SearchTermId">The <c>Base64SearchTerm</c> ID. Must not be <c>null</c> or empty.</param>
        public PaidOrganicSearchTermViewName(string customerId, string campaignId, string adGroupId, string base64SearchTermId) : this(ResourceNameType.CustomerCampaignAdGroupBase64SearchTerm, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), base64SearchTermId: gax::GaxPreconditions.CheckNotNullOrEmpty(base64SearchTermId, nameof(base64SearchTermId)))
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
        /// The <c>Base64SearchTerm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string Base64SearchTermId { get; }

        /// <summary>
        /// The <c>Campaign</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CampaignId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignAdGroupBase64SearchTerm: return s_customerCampaignAdGroupBase64SearchTerm.Expand(CustomerId, $"{CampaignId}~{AdGroupId}~{Base64SearchTermId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PaidOrganicSearchTermViewName);

        /// <inheritdoc/>
        public bool Equals(PaidOrganicSearchTermViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(PaidOrganicSearchTermViewName a, PaidOrganicSearchTermViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(PaidOrganicSearchTermViewName a, PaidOrganicSearchTermViewName b) => !(a == b);
    }

    public partial class PaidOrganicSearchTermView
    {
        /// <summary>
        /// <see cref="PaidOrganicSearchTermViewName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal PaidOrganicSearchTermViewName ResourceNameAsPaidOrganicSearchTermViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : PaidOrganicSearchTermViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

// Copyright 2025 Google LLC
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

namespace Google.Ads.GoogleAds.V19.Resources
{
    /// <summary>Resource name for the <c>CampaignCriterion</c> resource.</summary>
    public sealed partial class CampaignCriterionName : gax::IResourceName, sys::IEquatable<CampaignCriterionName>
    {
        /// <summary>The possible contents of <see cref="CampaignCriterionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c>
            /// .
            /// </summary>
            CustomerCampaignCriterion = 1,
        }

        private static gax::PathTemplate s_customerCampaignCriterion = new gax::PathTemplate("customers/{customer_id}/campaignCriteria/{campaign_id_criterion_id}");

        /// <summary>Creates a <see cref="CampaignCriterionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignCriterionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignCriterionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignCriterionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignCriterionName"/> with the pattern
        /// <c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignCriterionName"/> constructed from the provided ids.</returns>
        public static CampaignCriterionName FromCustomerCampaignCriterion(string customerId, string campaignId, string criterionId) =>
            new CampaignCriterionName(ResourceNameType.CustomerCampaignCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignCriterionName"/> with pattern
        /// <c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignCriterionName"/> with pattern
        /// <c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string criterionId) =>
            FormatCustomerCampaignCriterion(customerId, campaignId, criterionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignCriterionName"/> with pattern
        /// <c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignCriterionName"/> with pattern
        /// <c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c>.
        /// </returns>
        public static string FormatCustomerCampaignCriterion(string customerId, string campaignId, string criterionId) =>
            s_customerCampaignCriterion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignCriterionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignCriterionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignCriterionName"/> if successful.</returns>
        public static CampaignCriterionName Parse(string campaignCriterionName) => Parse(campaignCriterionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignCriterionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignCriterionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignCriterionName"/> if successful.</returns>
        public static CampaignCriterionName Parse(string campaignCriterionName, bool allowUnparsed) =>
            TryParse(campaignCriterionName, allowUnparsed, out CampaignCriterionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignCriterionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignCriterionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignCriterionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignCriterionName, out CampaignCriterionName result) =>
            TryParse(campaignCriterionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignCriterionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignCriterionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignCriterionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignCriterionName, bool allowUnparsed, out CampaignCriterionName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignCriterionName, nameof(campaignCriterionName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignCriterion.TryParseName(campaignCriterionName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignCriterion(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignCriterionName, out gax::UnparsedResourceName unparsedResourceName))
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

        private CampaignCriterionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string criterionId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CriterionId = criterionId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignCriterionName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/campaignCriteria/{campaign_id}~{criterion_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignCriterionName(string customerId, string campaignId, string criterionId) : this(ResourceNameType.CustomerCampaignCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))
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
        /// The <c>Criterion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CriterionId { get; }

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
                case ResourceNameType.CustomerCampaignCriterion: return s_customerCampaignCriterion.Expand(CustomerId, $"{CampaignId}~{CriterionId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignCriterionName);

        /// <inheritdoc/>
        public bool Equals(CampaignCriterionName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CampaignCriterionName a, CampaignCriterionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CampaignCriterionName a, CampaignCriterionName b) => !(a == b);
    }

    public partial class CampaignCriterion
    {
        /// <summary>
        /// <see cref="CampaignCriterionName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CampaignCriterionName ResourceNameAsCampaignCriterionName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignCriterionName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
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

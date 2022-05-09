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

namespace Google.Ads.GoogleAds.V10.Resources
{
    /// <summary>Resource name for the <c>CampaignBidModifier</c> resource.</summary>
    public sealed partial class CampaignBidModifierName : gax::IResourceName, sys::IEquatable<CampaignBidModifierName>
    {
        /// <summary>The possible contents of <see cref="CampaignBidModifierName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c>.
            /// </summary>
            CustomerCampaignCriterion = 1,
        }

        private static gax::PathTemplate s_customerCampaignCriterion = new gax::PathTemplate("customers/{customer_id}/campaignBidModifiers/{campaign_id_criterion_id}");

        /// <summary>Creates a <see cref="CampaignBidModifierName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignBidModifierName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignBidModifierName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignBidModifierName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignBidModifierName"/> with the pattern
        /// <c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignBidModifierName"/> constructed from the provided ids.
        /// </returns>
        public static CampaignBidModifierName FromCustomerCampaignCriterion(string customerId, string campaignId, string criterionId) =>
            new CampaignBidModifierName(ResourceNameType.CustomerCampaignCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignBidModifierName"/> with pattern
        /// <c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignBidModifierName"/> with pattern
        /// <c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string criterionId) =>
            FormatCustomerCampaignCriterion(customerId, campaignId, criterionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignBidModifierName"/> with pattern
        /// <c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignBidModifierName"/> with pattern
        /// <c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c>.
        /// </returns>
        public static string FormatCustomerCampaignCriterion(string customerId, string campaignId, string criterionId) =>
            s_customerCampaignCriterion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignBidModifierName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignBidModifierName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignBidModifierName"/> if successful.</returns>
        public static CampaignBidModifierName Parse(string campaignBidModifierName) => Parse(campaignBidModifierName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignBidModifierName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignBidModifierName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignBidModifierName"/> if successful.</returns>
        public static CampaignBidModifierName Parse(string campaignBidModifierName, bool allowUnparsed) =>
            TryParse(campaignBidModifierName, allowUnparsed, out CampaignBidModifierName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignBidModifierName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignBidModifierName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignBidModifierName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignBidModifierName, out CampaignBidModifierName result) =>
            TryParse(campaignBidModifierName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignBidModifierName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignBidModifierName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignBidModifierName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignBidModifierName, bool allowUnparsed, out CampaignBidModifierName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignBidModifierName, nameof(campaignBidModifierName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignCriterion.TryParseName(campaignBidModifierName, out resourceName))
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
                if (gax::UnparsedResourceName.TryParse(campaignBidModifierName, out gax::UnparsedResourceName unparsedResourceName))
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

        private CampaignBidModifierName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string criterionId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CriterionId = criterionId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignBidModifierName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/campaignBidModifiers/{campaign_id}~{criterion_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignBidModifierName(string customerId, string campaignId, string criterionId) : this(ResourceNameType.CustomerCampaignCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))
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
        public override bool Equals(object obj) => Equals(obj as CampaignBidModifierName);

        /// <inheritdoc/>
        public bool Equals(CampaignBidModifierName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignBidModifierName a, CampaignBidModifierName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignBidModifierName a, CampaignBidModifierName b) => !(a == b);
    }

    public partial class CampaignBidModifier
    {
        /// <summary>
        /// <see cref="CampaignBidModifierName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CampaignBidModifierName ResourceNameAsCampaignBidModifierName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignBidModifierName.Parse(ResourceName, allowUnparsed: true);
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

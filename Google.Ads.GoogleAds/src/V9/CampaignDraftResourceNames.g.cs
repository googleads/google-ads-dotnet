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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V9.Resources
{
    /// <summary>Resource name for the <c>CampaignDraft</c> resource.</summary>
    public sealed partial class CampaignDraftName : gax::IResourceName, sys::IEquatable<CampaignDraftName>
    {
        /// <summary>The possible contents of <see cref="CampaignDraftName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c>
            /// .
            /// </summary>
            CustomerBaseCampaignDraft = 1,
        }

        private static gax::PathTemplate s_customerBaseCampaignDraft = new gax::PathTemplate("customers/{customer_id}/campaignDrafts/{base_campaign_id_draft_id}");

        /// <summary>Creates a <see cref="CampaignDraftName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignDraftName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignDraftName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignDraftName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignDraftName"/> with the pattern
        /// <c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="baseCampaignId">The <c>BaseCampaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="draftId">The <c>Draft</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignDraftName"/> constructed from the provided ids.</returns>
        public static CampaignDraftName FromCustomerBaseCampaignDraft(string customerId, string baseCampaignId, string draftId) =>
            new CampaignDraftName(ResourceNameType.CustomerBaseCampaignDraft, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), baseCampaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(baseCampaignId, nameof(baseCampaignId)), draftId: gax::GaxPreconditions.CheckNotNullOrEmpty(draftId, nameof(draftId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignDraftName"/> with pattern
        /// <c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="baseCampaignId">The <c>BaseCampaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="draftId">The <c>Draft</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignDraftName"/> with pattern
        /// <c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c>.
        /// </returns>
        public static string Format(string customerId, string baseCampaignId, string draftId) =>
            FormatCustomerBaseCampaignDraft(customerId, baseCampaignId, draftId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignDraftName"/> with pattern
        /// <c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="baseCampaignId">The <c>BaseCampaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="draftId">The <c>Draft</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignDraftName"/> with pattern
        /// <c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c>.
        /// </returns>
        public static string FormatCustomerBaseCampaignDraft(string customerId, string baseCampaignId, string draftId) =>
            s_customerBaseCampaignDraft.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(baseCampaignId, nameof(baseCampaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(draftId, nameof(draftId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignDraftName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignDraftName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignDraftName"/> if successful.</returns>
        public static CampaignDraftName Parse(string campaignDraftName) => Parse(campaignDraftName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignDraftName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignDraftName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignDraftName"/> if successful.</returns>
        public static CampaignDraftName Parse(string campaignDraftName, bool allowUnparsed) =>
            TryParse(campaignDraftName, allowUnparsed, out CampaignDraftName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignDraftName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignDraftName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignDraftName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignDraftName, out CampaignDraftName result) =>
            TryParse(campaignDraftName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignDraftName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignDraftName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignDraftName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignDraftName, bool allowUnparsed, out CampaignDraftName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignDraftName, nameof(campaignDraftName));
            gax::TemplatedResourceName resourceName;
            if (s_customerBaseCampaignDraft.TryParseName(campaignDraftName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerBaseCampaignDraft(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignDraftName, out gax::UnparsedResourceName unparsedResourceName))
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

        private CampaignDraftName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string baseCampaignId = null, string customerId = null, string draftId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            BaseCampaignId = baseCampaignId;
            CustomerId = customerId;
            DraftId = draftId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignDraftName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/campaignDrafts/{base_campaign_id}~{draft_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="baseCampaignId">The <c>BaseCampaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="draftId">The <c>Draft</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignDraftName(string customerId, string baseCampaignId, string draftId) : this(ResourceNameType.CustomerBaseCampaignDraft, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), baseCampaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(baseCampaignId, nameof(baseCampaignId)), draftId: gax::GaxPreconditions.CheckNotNullOrEmpty(draftId, nameof(draftId)))
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
        /// The <c>BaseCampaign</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string BaseCampaignId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>Draft</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DraftId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerBaseCampaignDraft: return s_customerBaseCampaignDraft.Expand(CustomerId, $"{BaseCampaignId}~{DraftId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignDraftName);

        /// <inheritdoc/>
        public bool Equals(CampaignDraftName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignDraftName a, CampaignDraftName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignDraftName a, CampaignDraftName b) => !(a == b);
    }

    public partial class CampaignDraft
    {
        /// <summary>
        /// <see cref="gagvr::CampaignDraftName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::CampaignDraftName ResourceNameAsCampaignDraftName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::CampaignDraftName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="BaseCampaign"/> resource name property.
        /// </summary>
        internal CampaignName BaseCampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(BaseCampaign) ? null : CampaignName.Parse(BaseCampaign, allowUnparsed: true);
            set => BaseCampaign = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CampaignDraftName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::CampaignDraftName CampaignDraftName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::CampaignDraftName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="DraftCampaign"/> resource name property.
        /// </summary>
        internal CampaignName DraftCampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(DraftCampaign) ? null : CampaignName.Parse(DraftCampaign, allowUnparsed: true);
            set => DraftCampaign = value?.ToString() ?? "";
        }
    }
}

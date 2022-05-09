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
    /// <summary>Resource name for the <c>Campaign</c> resource.</summary>
    public sealed partial class CampaignName : gax::IResourceName, sys::IEquatable<CampaignName>
    {
        /// <summary>The possible contents of <see cref="CampaignName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/campaigns/{campaign_id}</c>.</summary>
            CustomerCampaign = 1,
        }

        private static gax::PathTemplate s_customerCampaign = new gax::PathTemplate("customers/{customer_id}/campaigns/{campaign_id}");

        /// <summary>Creates a <see cref="CampaignName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static CampaignName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignName"/> with the pattern <c>customers/{customer_id}/campaigns/{campaign_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignName"/> constructed from the provided ids.</returns>
        public static CampaignName FromCustomerCampaign(string customerId, string campaignId) =>
            new CampaignName(ResourceNameType.CustomerCampaign, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignName"/> with pattern
        /// <c>customers/{customer_id}/campaigns/{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignName"/> with pattern
        /// <c>customers/{customer_id}/campaigns/{campaign_id}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId) => FormatCustomerCampaign(customerId, campaignId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignName"/> with pattern
        /// <c>customers/{customer_id}/campaigns/{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignName"/> with pattern
        /// <c>customers/{customer_id}/campaigns/{campaign_id}</c>.
        /// </returns>
        public static string FormatCustomerCampaign(string customerId, string campaignId) =>
            s_customerCampaign.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)));

        /// <summary>Parses the given resource name string into a new <see cref="CampaignName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaigns/{campaign_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="campaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignName"/> if successful.</returns>
        public static CampaignName Parse(string campaignName) => Parse(campaignName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaigns/{campaign_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignName"/> if successful.</returns>
        public static CampaignName Parse(string campaignName, bool allowUnparsed) =>
            TryParse(campaignName, allowUnparsed, out CampaignName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaigns/{campaign_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="campaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignName, out CampaignName result) => TryParse(campaignName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaigns/{campaign_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignName, bool allowUnparsed, out CampaignName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignName, nameof(campaignName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaign.TryParseName(campaignName, out resourceName))
            {
                result = FromCustomerCampaign(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CampaignName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/campaigns/{campaign_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignName(string customerId, string campaignId) : this(ResourceNameType.CustomerCampaign, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))
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
                case ResourceNameType.CustomerCampaign: return s_customerCampaign.Expand(CustomerId, CampaignId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignName);

        /// <inheritdoc/>
        public bool Equals(CampaignName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignName a, CampaignName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignName a, CampaignName b) => !(a == b);
    }

    public partial class Campaign
    {
        /// <summary>
        /// <see cref="gagvr::CampaignName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal gagvr::CampaignName ResourceNameAsCampaignName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::CampaignName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CampaignName"/>-typed view over the <see cref="BaseCampaign"/> resource name property.
        /// </summary>
        internal gagvr::CampaignName BaseCampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(BaseCampaign) ? null : gagvr::CampaignName.Parse(BaseCampaign, allowUnparsed: true);
            set => BaseCampaign = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CampaignName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::CampaignName CampaignName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::CampaignName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignLabelName"/>-typed view over the <see cref="Labels"/> resource name property.
        /// </summary>
        internal gax::ResourceNameList<CampaignLabelName> LabelsAsCampaignLabelNames
        {
            get => new gax::ResourceNameList<CampaignLabelName>(Labels, s => string.IsNullOrEmpty(s) ? null : CampaignLabelName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="CampaignBudgetName"/>-typed view over the <see cref="CampaignBudget"/> resource name property.
        /// </summary>
        internal CampaignBudgetName CampaignBudgetAsCampaignBudgetName
        {
            get => string.IsNullOrEmpty(CampaignBudget) ? null : CampaignBudgetName.Parse(CampaignBudget, allowUnparsed: true);
            set => CampaignBudget = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="BiddingStrategyName"/>-typed view over the <see cref="BiddingStrategy"/> resource name property.
        /// </summary>
        internal BiddingStrategyName BiddingStrategyAsBiddingStrategyName
        {
            get => string.IsNullOrEmpty(BiddingStrategy) ? null : BiddingStrategyName.Parse(BiddingStrategy, allowUnparsed: true);
            set => BiddingStrategy = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AccessibleBiddingStrategyName"/>-typed view over the <see cref="AccessibleBiddingStrategy"/>
        /// resource name property.
        /// </summary>
        internal AccessibleBiddingStrategyName AccessibleBiddingStrategyAsAccessibleBiddingStrategyName
        {
            get => string.IsNullOrEmpty(AccessibleBiddingStrategy) ? null : AccessibleBiddingStrategyName.Parse(AccessibleBiddingStrategy, allowUnparsed: true);
            set => AccessibleBiddingStrategy = value?.ToString() ?? "";
        }
    }
}

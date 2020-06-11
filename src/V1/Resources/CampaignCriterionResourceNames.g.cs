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

namespace Google.Ads.GoogleAds.V1.Resources
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
            /// A resource name with pattern <c>customers/{customer}/campaignCriteria/{campaign_criterion}</c>.
            /// </summary>
            CustomerCampaignCriterion = 1
        }

        private static gax::PathTemplate s_customerCampaignCriterion = new gax::PathTemplate("customers/{customer}/campaignCriteria/{campaign_criterion}");

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
        /// <c>customers/{customer}/campaignCriteria/{campaign_criterion}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignCriterionId">The <c>CampaignCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignCriterionName"/> constructed from the provided ids.</returns>
        public static CampaignCriterionName FromCustomerCampaignCriterion(string customerId, string campaignCriterionId) =>
            new CampaignCriterionName(ResourceNameType.CustomerCampaignCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignCriterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignCriterionId, nameof(campaignCriterionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignCriterionName"/> with pattern
        /// <c>customers/{customer}/campaignCriteria/{campaign_criterion}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignCriterionId">The <c>CampaignCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignCriterionName"/> with pattern
        /// <c>customers/{customer}/campaignCriteria/{campaign_criterion}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignCriterionId) =>
            FormatCustomerCampaignCriterion(customerId, campaignCriterionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignCriterionName"/> with pattern
        /// <c>customers/{customer}/campaignCriteria/{campaign_criterion}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignCriterionId">The <c>CampaignCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignCriterionName"/> with pattern
        /// <c>customers/{customer}/campaignCriteria/{campaign_criterion}</c>.
        /// </returns>
        public static string FormatCustomerCampaignCriterion(string customerId, string campaignCriterionId) =>
            s_customerCampaignCriterion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(campaignCriterionId, nameof(campaignCriterionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignCriterionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/campaignCriteria/{campaign_criterion}</c></description></item>
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
        /// <item><description><c>customers/{customer}/campaignCriteria/{campaign_criterion}</c></description></item>
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
        /// <item><description><c>customers/{customer}/campaignCriteria/{campaign_criterion}</c></description></item>
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
        /// <item><description><c>customers/{customer}/campaignCriteria/{campaign_criterion}</c></description></item>
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
                result = FromCustomerCampaignCriterion(resourceName[0], resourceName[1]);
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

        private CampaignCriterionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignCriterionId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignCriterionId = campaignCriterionId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignCriterionName"/> class from the component parts of pattern
        /// <c>customers/{customer}/campaignCriteria/{campaign_criterion}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignCriterionId">The <c>CampaignCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignCriterionName(string customerId, string campaignCriterionId) : this(ResourceNameType.CustomerCampaignCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignCriterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignCriterionId, nameof(campaignCriterionId)))
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
        /// The <c>CampaignCriterion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CampaignCriterionId { get; }

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
                case ResourceNameType.CustomerCampaignCriterion: return s_customerCampaignCriterion.Expand(CustomerId, CampaignCriterionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignCriterionName);

        /// <inheritdoc/>
        public bool Equals(CampaignCriterionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignCriterionName a, CampaignCriterionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
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

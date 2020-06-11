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
    /// <summary>Resource name for the <c>CampaignSharedSet</c> resource.</summary>
    public sealed partial class CampaignSharedSetName : gax::IResourceName, sys::IEquatable<CampaignSharedSetName>
    {
        /// <summary>The possible contents of <see cref="CampaignSharedSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c>.
            /// </summary>
            CustomerCampaignSharedSet = 1
        }

        private static gax::PathTemplate s_customerCampaignSharedSet = new gax::PathTemplate("customers/{customer}/campaignSharedSets/{campaign_shared_set}");

        /// <summary>Creates a <see cref="CampaignSharedSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignSharedSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignSharedSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignSharedSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignSharedSetName"/> with the pattern
        /// <c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignSharedSetId">The <c>CampaignSharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignSharedSetName"/> constructed from the provided ids.</returns>
        public static CampaignSharedSetName FromCustomerCampaignSharedSet(string customerId, string campaignSharedSetId) =>
            new CampaignSharedSetName(ResourceNameType.CustomerCampaignSharedSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignSharedSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignSharedSetId, nameof(campaignSharedSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignSharedSetName"/> with pattern
        /// <c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignSharedSetId">The <c>CampaignSharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignSharedSetName"/> with pattern
        /// <c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignSharedSetId) =>
            FormatCustomerCampaignSharedSet(customerId, campaignSharedSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignSharedSetName"/> with pattern
        /// <c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignSharedSetId">The <c>CampaignSharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignSharedSetName"/> with pattern
        /// <c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c>.
        /// </returns>
        public static string FormatCustomerCampaignSharedSet(string customerId, string campaignSharedSetId) =>
            s_customerCampaignSharedSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(campaignSharedSetId, nameof(campaignSharedSetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignSharedSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignSharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignSharedSetName"/> if successful.</returns>
        public static CampaignSharedSetName Parse(string campaignSharedSetName) => Parse(campaignSharedSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignSharedSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignSharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignSharedSetName"/> if successful.</returns>
        public static CampaignSharedSetName Parse(string campaignSharedSetName, bool allowUnparsed) =>
            TryParse(campaignSharedSetName, allowUnparsed, out CampaignSharedSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignSharedSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignSharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignSharedSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignSharedSetName, out CampaignSharedSetName result) =>
            TryParse(campaignSharedSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignSharedSetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignSharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignSharedSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignSharedSetName, bool allowUnparsed, out CampaignSharedSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignSharedSetName, nameof(campaignSharedSetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignSharedSet.TryParseName(campaignSharedSetName, out resourceName))
            {
                result = FromCustomerCampaignSharedSet(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignSharedSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CampaignSharedSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignSharedSetId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignSharedSetId = campaignSharedSetId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignSharedSetName"/> class from the component parts of pattern
        /// <c>customers/{customer}/campaignSharedSets/{campaign_shared_set}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignSharedSetId">The <c>CampaignSharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignSharedSetName(string customerId, string campaignSharedSetId) : this(ResourceNameType.CustomerCampaignSharedSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignSharedSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignSharedSetId, nameof(campaignSharedSetId)))
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
        /// The <c>CampaignSharedSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CampaignSharedSetId { get; }

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
                case ResourceNameType.CustomerCampaignSharedSet: return s_customerCampaignSharedSet.Expand(CustomerId, CampaignSharedSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignSharedSetName);

        /// <inheritdoc/>
        public bool Equals(CampaignSharedSetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignSharedSetName a, CampaignSharedSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignSharedSetName a, CampaignSharedSetName b) => !(a == b);
    }

    public partial class CampaignSharedSet
    {
        /// <summary>
        /// <see cref="CampaignSharedSetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CampaignSharedSetName ResourceNameAsCampaignSharedSetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignSharedSetName.Parse(ResourceName, allowUnparsed: true);
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

        /// <summary>
        /// <see cref="SharedSetName"/>-typed view over the <see cref="SharedSet"/> resource name property.
        /// </summary>
        internal SharedSetName SharedSetAsSharedSetName
        {
            get => string.IsNullOrEmpty(SharedSet) ? null : SharedSetName.Parse(SharedSet, allowUnparsed: true);
            set => SharedSet = value?.ToString() ?? "";
        }
    }
}

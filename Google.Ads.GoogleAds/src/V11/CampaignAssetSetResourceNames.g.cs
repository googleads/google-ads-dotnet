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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V11.Resources
{
    /// <summary>Resource name for the <c>CampaignAssetSet</c> resource.</summary>
    public sealed partial class CampaignAssetSetName : gax::IResourceName, sys::IEquatable<CampaignAssetSetName>
    {
        /// <summary>The possible contents of <see cref="CampaignAssetSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c>
            /// .
            /// </summary>
            CustomerCampaignAssetSet = 1,
        }

        private static gax::PathTemplate s_customerCampaignAssetSet = new gax::PathTemplate("customers/{customer_id}/campaignAssetSets/{campaign_id_asset_set_id}");

        /// <summary>Creates a <see cref="CampaignAssetSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignAssetSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignAssetSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignAssetSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignAssetSetName"/> with the pattern
        /// <c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignAssetSetName"/> constructed from the provided ids.</returns>
        public static CampaignAssetSetName FromCustomerCampaignAssetSet(string customerId, string campaignId, string assetSetId) =>
            new CampaignAssetSetName(ResourceNameType.CustomerCampaignAssetSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), assetSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignAssetSetName"/> with pattern
        /// <c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignAssetSetName"/> with pattern
        /// <c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string assetSetId) =>
            FormatCustomerCampaignAssetSet(customerId, campaignId, assetSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignAssetSetName"/> with pattern
        /// <c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignAssetSetName"/> with pattern
        /// <c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c>.
        /// </returns>
        public static string FormatCustomerCampaignAssetSet(string customerId, string campaignId, string assetSetId) =>
            s_customerCampaignAssetSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignAssetSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignAssetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignAssetSetName"/> if successful.</returns>
        public static CampaignAssetSetName Parse(string campaignAssetSetName) => Parse(campaignAssetSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignAssetSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignAssetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignAssetSetName"/> if successful.</returns>
        public static CampaignAssetSetName Parse(string campaignAssetSetName, bool allowUnparsed) =>
            TryParse(campaignAssetSetName, allowUnparsed, out CampaignAssetSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignAssetSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignAssetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignAssetSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignAssetSetName, out CampaignAssetSetName result) =>
            TryParse(campaignAssetSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignAssetSetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignAssetSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignAssetSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignAssetSetName, bool allowUnparsed, out CampaignAssetSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignAssetSetName, nameof(campaignAssetSetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignAssetSet.TryParseName(campaignAssetSetName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignAssetSet(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignAssetSetName, out gax::UnparsedResourceName unparsedResourceName))
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

        private CampaignAssetSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetSetId = null, string campaignId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetSetId = assetSetId;
            CampaignId = campaignId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignAssetSetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/campaignAssetSets/{campaign_id}~{asset_set_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetSetId">The <c>AssetSet</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignAssetSetName(string customerId, string campaignId, string assetSetId) : this(ResourceNameType.CustomerCampaignAssetSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), assetSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetSetId, nameof(assetSetId)))
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
        /// The <c>AssetSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetSetId { get; }

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
                case ResourceNameType.CustomerCampaignAssetSet: return s_customerCampaignAssetSet.Expand(CustomerId, $"{CampaignId}~{AssetSetId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignAssetSetName);

        /// <inheritdoc/>
        public bool Equals(CampaignAssetSetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignAssetSetName a, CampaignAssetSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignAssetSetName a, CampaignAssetSetName b) => !(a == b);
    }

    public partial class CampaignAssetSet
    {
        /// <summary>
        /// <see cref="CampaignAssetSetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CampaignAssetSetName ResourceNameAsCampaignAssetSetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignAssetSetName.Parse(ResourceName, allowUnparsed: true);
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
        /// <see cref="AssetSetName"/>-typed view over the <see cref="AssetSet"/> resource name property.
        /// </summary>
        internal AssetSetName AssetSetAsAssetSetName
        {
            get => string.IsNullOrEmpty(AssetSet) ? null : AssetSetName.Parse(AssetSet, allowUnparsed: true);
            set => AssetSet = value?.ToString() ?? "";
        }
    }
}

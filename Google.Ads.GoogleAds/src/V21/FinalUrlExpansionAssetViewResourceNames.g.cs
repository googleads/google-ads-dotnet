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

namespace Google.Ads.GoogleAds.V21.Resources
{
    /// <summary>Resource name for the <c>FinalUrlExpansionAssetView</c> resource.</summary>
    public sealed partial class FinalUrlExpansionAssetViewName : gax::IResourceName, sys::IEquatable<FinalUrlExpansionAssetViewName>
    {
        /// <summary>The possible contents of <see cref="FinalUrlExpansionAssetViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>
            /// .
            /// </summary>
            CustomerCampaignAssetFieldTypeUrlFp = 1,
        }

        private static gax::PathTemplate s_customerCampaignAssetFieldTypeUrlFp = new gax::PathTemplate("customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id_asset_id_field_type_url_fp}");

        /// <summary>
        /// Creates a <see cref="FinalUrlExpansionAssetViewName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="FinalUrlExpansionAssetViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static FinalUrlExpansionAssetViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new FinalUrlExpansionAssetViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="FinalUrlExpansionAssetViewName"/> with the pattern
        /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="urlFpId">The <c>UrlFp</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="FinalUrlExpansionAssetViewName"/> constructed from the provided ids.
        /// </returns>
        public static FinalUrlExpansionAssetViewName FromCustomerCampaignAssetFieldTypeUrlFp(string customerId, string campaignId, string assetId, string fieldTypeId, string urlFpId) =>
            new FinalUrlExpansionAssetViewName(ResourceNameType.CustomerCampaignAssetFieldTypeUrlFp, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), fieldTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)), urlFpId: gax::GaxPreconditions.CheckNotNullOrEmpty(urlFpId, nameof(urlFpId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FinalUrlExpansionAssetViewName"/> with
        /// pattern
        /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="urlFpId">The <c>UrlFp</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FinalUrlExpansionAssetViewName"/> with pattern
        /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string assetId, string fieldTypeId, string urlFpId) =>
            FormatCustomerCampaignAssetFieldTypeUrlFp(customerId, campaignId, assetId, fieldTypeId, urlFpId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="FinalUrlExpansionAssetViewName"/> with
        /// pattern
        /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="urlFpId">The <c>UrlFp</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="FinalUrlExpansionAssetViewName"/> with pattern
        /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>.
        /// </returns>
        public static string FormatCustomerCampaignAssetFieldTypeUrlFp(string customerId, string campaignId, string assetId, string fieldTypeId, string urlFpId) =>
            s_customerCampaignAssetFieldTypeUrlFp.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(urlFpId, nameof(urlFpId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FinalUrlExpansionAssetViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="finalUrlExpansionAssetViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="FinalUrlExpansionAssetViewName"/> if successful.</returns>
        public static FinalUrlExpansionAssetViewName Parse(string finalUrlExpansionAssetViewName) =>
            Parse(finalUrlExpansionAssetViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="FinalUrlExpansionAssetViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="finalUrlExpansionAssetViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="FinalUrlExpansionAssetViewName"/> if successful.</returns>
        public static FinalUrlExpansionAssetViewName Parse(string finalUrlExpansionAssetViewName, bool allowUnparsed) =>
            TryParse(finalUrlExpansionAssetViewName, allowUnparsed, out FinalUrlExpansionAssetViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FinalUrlExpansionAssetViewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="finalUrlExpansionAssetViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FinalUrlExpansionAssetViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string finalUrlExpansionAssetViewName, out FinalUrlExpansionAssetViewName result) =>
            TryParse(finalUrlExpansionAssetViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="FinalUrlExpansionAssetViewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="finalUrlExpansionAssetViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="FinalUrlExpansionAssetViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string finalUrlExpansionAssetViewName, bool allowUnparsed, out FinalUrlExpansionAssetViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(finalUrlExpansionAssetViewName, nameof(finalUrlExpansionAssetViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignAssetFieldTypeUrlFp.TryParseName(finalUrlExpansionAssetViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignAssetFieldTypeUrlFp(resourceName[0], split1[0], split1[1], split1[2], split1[3]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(finalUrlExpansionAssetViewName, out gax::UnparsedResourceName unparsedResourceName))
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

        private FinalUrlExpansionAssetViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetId = null, string campaignId = null, string customerId = null, string fieldTypeId = null, string urlFpId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetId = assetId;
            CampaignId = campaignId;
            CustomerId = customerId;
            FieldTypeId = fieldTypeId;
            UrlFpId = urlFpId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="FinalUrlExpansionAssetViewName"/> class from the component parts
        /// of pattern
        /// <c>customers/{customer_id}/finalUrlExpansionAssetViews/{campaign_id}~{asset_id}~{field_type}~{url_fp}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetId">The <c>Asset</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="urlFpId">The <c>UrlFp</c> ID. Must not be <c>null</c> or empty.</param>
        public FinalUrlExpansionAssetViewName(string customerId, string campaignId, string assetId, string fieldTypeId, string urlFpId) : this(ResourceNameType.CustomerCampaignAssetFieldTypeUrlFp, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), assetId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetId, nameof(assetId)), fieldTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)), urlFpId: gax::GaxPreconditions.CheckNotNullOrEmpty(urlFpId, nameof(urlFpId)))
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
        /// The <c>Asset</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetId { get; }

        /// <summary>
        /// The <c>Campaign</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CampaignId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>FieldType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FieldTypeId { get; }

        /// <summary>
        /// The <c>UrlFp</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UrlFpId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignAssetFieldTypeUrlFp: return s_customerCampaignAssetFieldTypeUrlFp.Expand(CustomerId, $"{CampaignId}~{AssetId}~{FieldTypeId}~{UrlFpId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as FinalUrlExpansionAssetViewName);

        /// <inheritdoc/>
        public bool Equals(FinalUrlExpansionAssetViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(FinalUrlExpansionAssetViewName a, FinalUrlExpansionAssetViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(FinalUrlExpansionAssetViewName a, FinalUrlExpansionAssetViewName b) => !(a == b);
    }

    public partial class FinalUrlExpansionAssetView
    {
        /// <summary>
        /// <see cref="FinalUrlExpansionAssetViewName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal FinalUrlExpansionAssetViewName ResourceNameAsFinalUrlExpansionAssetViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : FinalUrlExpansionAssetViewName.Parse(ResourceName, allowUnparsed: true);
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

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        internal AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupName"/>-typed view over the <see cref="AdGroup"/> resource name property.
        /// </summary>
        internal AdGroupName AdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(AdGroup) ? null : AdGroupName.Parse(AdGroup, allowUnparsed: true);
            set => AdGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AssetGroupName"/>-typed view over the <see cref="AssetGroup"/> resource name property.
        /// </summary>
        internal AssetGroupName AssetGroupAsAssetGroupName
        {
            get => string.IsNullOrEmpty(AssetGroup) ? null : AssetGroupName.Parse(AssetGroup, allowUnparsed: true);
            set => AssetGroup = value?.ToString() ?? "";
        }
    }
}

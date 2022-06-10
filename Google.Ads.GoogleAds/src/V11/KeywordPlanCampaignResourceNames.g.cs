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

using gagvr = Google.Ads.GoogleAds.V11.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V11.Resources
{
    /// <summary>Resource name for the <c>KeywordPlanCampaign</c> resource.</summary>
    public sealed partial class KeywordPlanCampaignName : gax::IResourceName, sys::IEquatable<KeywordPlanCampaignName>
    {
        /// <summary>The possible contents of <see cref="KeywordPlanCampaignName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c>
            /// .
            /// </summary>
            CustomerKeywordPlanCampaign = 1,
        }

        private static gax::PathTemplate s_customerKeywordPlanCampaign = new gax::PathTemplate("customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}");

        /// <summary>Creates a <see cref="KeywordPlanCampaignName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanCampaignName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KeywordPlanCampaignName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeywordPlanCampaignName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KeywordPlanCampaignName"/> with the pattern
        /// <c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanCampaignId">
        /// The <c>KeywordPlanCampaign</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanCampaignName"/> constructed from the provided ids.
        /// </returns>
        public static KeywordPlanCampaignName FromCustomerKeywordPlanCampaign(string customerId, string keywordPlanCampaignId) =>
            new KeywordPlanCampaignName(ResourceNameType.CustomerKeywordPlanCampaign, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanCampaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanCampaignId, nameof(keywordPlanCampaignId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanCampaignName"/> with pattern
        /// <c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanCampaignId">
        /// The <c>KeywordPlanCampaign</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanCampaignName"/> with pattern
        /// <c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c>.
        /// </returns>
        public static string Format(string customerId, string keywordPlanCampaignId) =>
            FormatCustomerKeywordPlanCampaign(customerId, keywordPlanCampaignId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanCampaignName"/> with pattern
        /// <c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanCampaignId">
        /// The <c>KeywordPlanCampaign</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanCampaignName"/> with pattern
        /// <c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c>.
        /// </returns>
        public static string FormatCustomerKeywordPlanCampaign(string customerId, string keywordPlanCampaignId) =>
            s_customerKeywordPlanCampaign.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanCampaignId, nameof(keywordPlanCampaignId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanCampaignName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanCampaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordPlanCampaignName"/> if successful.</returns>
        public static KeywordPlanCampaignName Parse(string keywordPlanCampaignName) => Parse(keywordPlanCampaignName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanCampaignName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanCampaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeywordPlanCampaignName"/> if successful.</returns>
        public static KeywordPlanCampaignName Parse(string keywordPlanCampaignName, bool allowUnparsed) =>
            TryParse(keywordPlanCampaignName, allowUnparsed, out KeywordPlanCampaignName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanCampaignName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanCampaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanCampaignName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanCampaignName, out KeywordPlanCampaignName result) =>
            TryParse(keywordPlanCampaignName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanCampaignName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanCampaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanCampaignName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanCampaignName, bool allowUnparsed, out KeywordPlanCampaignName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanCampaignName, nameof(keywordPlanCampaignName));
            gax::TemplatedResourceName resourceName;
            if (s_customerKeywordPlanCampaign.TryParseName(keywordPlanCampaignName, out resourceName))
            {
                result = FromCustomerKeywordPlanCampaign(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keywordPlanCampaignName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KeywordPlanCampaignName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string keywordPlanCampaignId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            KeywordPlanCampaignId = keywordPlanCampaignId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeywordPlanCampaignName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/keywordPlanCampaigns/{keyword_plan_campaign_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanCampaignId">
        /// The <c>KeywordPlanCampaign</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public KeywordPlanCampaignName(string customerId, string keywordPlanCampaignId) : this(ResourceNameType.CustomerKeywordPlanCampaign, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanCampaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanCampaignId, nameof(keywordPlanCampaignId)))
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
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>KeywordPlanCampaign</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string KeywordPlanCampaignId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerKeywordPlanCampaign: return s_customerKeywordPlanCampaign.Expand(CustomerId, KeywordPlanCampaignId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeywordPlanCampaignName);

        /// <inheritdoc/>
        public bool Equals(KeywordPlanCampaignName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(KeywordPlanCampaignName a, KeywordPlanCampaignName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(KeywordPlanCampaignName a, KeywordPlanCampaignName b) => !(a == b);
    }

    public partial class KeywordPlanCampaign
    {
        /// <summary>
        /// <see cref="gagvr::KeywordPlanCampaignName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::KeywordPlanCampaignName ResourceNameAsKeywordPlanCampaignName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::KeywordPlanCampaignName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="KeywordPlanName"/>-typed view over the <see cref="KeywordPlan"/> resource name property.
        /// </summary>
        internal KeywordPlanName KeywordPlanAsKeywordPlanName
        {
            get => string.IsNullOrEmpty(KeywordPlan) ? null : KeywordPlanName.Parse(KeywordPlan, allowUnparsed: true);
            set => KeywordPlan = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::KeywordPlanCampaignName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::KeywordPlanCampaignName KeywordPlanCampaignName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::KeywordPlanCampaignName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="LanguageConstantName"/>-typed view over the <see cref="LanguageConstants"/> resource name
        /// property.
        /// </summary>
        internal gax::ResourceNameList<LanguageConstantName> LanguageConstantsAsLanguageConstantNames
        {
            get => new gax::ResourceNameList<LanguageConstantName>(LanguageConstants, s => string.IsNullOrEmpty(s) ? null : LanguageConstantName.Parse(s, allowUnparsed: true));
        }
    }

    public partial class KeywordPlanGeoTarget
    {
        /// <summary>
        /// <see cref="GeoTargetConstantName"/>-typed view over the <see cref="GeoTargetConstant"/> resource name
        /// property.
        /// </summary>
        internal GeoTargetConstantName GeoTargetConstantAsGeoTargetConstantName
        {
            get => string.IsNullOrEmpty(GeoTargetConstant) ? null : GeoTargetConstantName.Parse(GeoTargetConstant, allowUnparsed: true);
            set => GeoTargetConstant = value?.ToString() ?? "";
        }
    }
}

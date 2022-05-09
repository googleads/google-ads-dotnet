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
    /// <summary>Resource name for the <c>CampaignConversionGoal</c> resource.</summary>
    public sealed partial class CampaignConversionGoalName : gax::IResourceName, sys::IEquatable<CampaignConversionGoalName>
    {
        /// <summary>The possible contents of <see cref="CampaignConversionGoalName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>.
            /// </summary>
            CustomerCampaignCategorySource = 1,
        }

        private static gax::PathTemplate s_customerCampaignCategorySource = new gax::PathTemplate("customers/{customer_id}/campaignConversionGoals/{campaign_id_category_source}");

        /// <summary>Creates a <see cref="CampaignConversionGoalName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignConversionGoalName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignConversionGoalName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignConversionGoalName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignConversionGoalName"/> with the pattern
        /// <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignConversionGoalName"/> constructed from the provided ids.
        /// </returns>
        public static CampaignConversionGoalName FromCustomerCampaignCategorySource(string customerId, string campaignId, string categoryId, string sourceId) =>
            new CampaignConversionGoalName(ResourceNameType.CustomerCampaignCategorySource, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), categoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignConversionGoalName"/> with pattern
        /// <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignConversionGoalName"/> with pattern
        /// <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string categoryId, string sourceId) =>
            FormatCustomerCampaignCategorySource(customerId, campaignId, categoryId, sourceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignConversionGoalName"/> with pattern
        /// <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignConversionGoalName"/> with pattern
        /// <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>.
        /// </returns>
        public static string FormatCustomerCampaignCategorySource(string customerId, string campaignId, string categoryId, string sourceId) =>
            s_customerCampaignCategorySource.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignConversionGoalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignConversionGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignConversionGoalName"/> if successful.</returns>
        public static CampaignConversionGoalName Parse(string campaignConversionGoalName) =>
            Parse(campaignConversionGoalName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignConversionGoalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignConversionGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignConversionGoalName"/> if successful.</returns>
        public static CampaignConversionGoalName Parse(string campaignConversionGoalName, bool allowUnparsed) =>
            TryParse(campaignConversionGoalName, allowUnparsed, out CampaignConversionGoalName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignConversionGoalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignConversionGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignConversionGoalName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignConversionGoalName, out CampaignConversionGoalName result) =>
            TryParse(campaignConversionGoalName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignConversionGoalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignConversionGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignConversionGoalName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignConversionGoalName, bool allowUnparsed, out CampaignConversionGoalName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignConversionGoalName, nameof(campaignConversionGoalName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignCategorySource.TryParseName(campaignConversionGoalName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignCategorySource(resourceName[0], split1[0], split1[1], split1[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignConversionGoalName, out gax::UnparsedResourceName unparsedResourceName))
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

        private CampaignConversionGoalName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string categoryId = null, string customerId = null, string sourceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CategoryId = categoryId;
            CustomerId = customerId;
            SourceId = sourceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignConversionGoalName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/campaignConversionGoals/{campaign_id}~{category}~{source}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sourceId">The <c>Source</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignConversionGoalName(string customerId, string campaignId, string categoryId, string sourceId) : this(ResourceNameType.CustomerCampaignCategorySource, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), categoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)), sourceId: gax::GaxPreconditions.CheckNotNullOrEmpty(sourceId, nameof(sourceId)))
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
        /// The <c>Category</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CategoryId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>Source</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SourceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignCategorySource: return s_customerCampaignCategorySource.Expand(CustomerId, $"{CampaignId}~{CategoryId}~{SourceId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignConversionGoalName);

        /// <inheritdoc/>
        public bool Equals(CampaignConversionGoalName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignConversionGoalName a, CampaignConversionGoalName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignConversionGoalName a, CampaignConversionGoalName b) => !(a == b);
    }

    public partial class CampaignConversionGoal
    {
        /// <summary>
        /// <see cref="CampaignConversionGoalName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CampaignConversionGoalName ResourceNameAsCampaignConversionGoalName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignConversionGoalName.Parse(ResourceName, allowUnparsed: true);
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

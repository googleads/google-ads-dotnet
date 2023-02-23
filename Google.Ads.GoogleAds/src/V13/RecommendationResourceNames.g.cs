// Copyright 2023 Google LLC
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

namespace Google.Ads.GoogleAds.V13.Resources
{
    /// <summary>Resource name for the <c>Recommendation</c> resource.</summary>
    public sealed partial class RecommendationName : gax::IResourceName, sys::IEquatable<RecommendationName>
    {
        /// <summary>The possible contents of <see cref="RecommendationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/recommendations/{recommendation_id}</c>.
            /// </summary>
            CustomerRecommendation = 1,
        }

        private static gax::PathTemplate s_customerRecommendation = new gax::PathTemplate("customers/{customer_id}/recommendations/{recommendation_id}");

        /// <summary>Creates a <see cref="RecommendationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="RecommendationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static RecommendationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new RecommendationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="RecommendationName"/> with the pattern
        /// <c>customers/{customer_id}/recommendations/{recommendation_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="RecommendationName"/> constructed from the provided ids.</returns>
        public static RecommendationName FromCustomerRecommendation(string customerId, string recommendationId) =>
            new RecommendationName(ResourceNameType.CustomerRecommendation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), recommendationId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>customers/{customer_id}/recommendations/{recommendation_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>customers/{customer_id}/recommendations/{recommendation_id}</c>.
        /// </returns>
        public static string Format(string customerId, string recommendationId) =>
            FormatCustomerRecommendation(customerId, recommendationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>customers/{customer_id}/recommendations/{recommendation_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="RecommendationName"/> with pattern
        /// <c>customers/{customer_id}/recommendations/{recommendation_id}</c>.
        /// </returns>
        public static string FormatCustomerRecommendation(string customerId, string recommendationId) =>
            s_customerRecommendation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RecommendationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/recommendations/{recommendation_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="recommendationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="RecommendationName"/> if successful.</returns>
        public static RecommendationName Parse(string recommendationName) => Parse(recommendationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="RecommendationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/recommendations/{recommendation_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recommendationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="RecommendationName"/> if successful.</returns>
        public static RecommendationName Parse(string recommendationName, bool allowUnparsed) =>
            TryParse(recommendationName, allowUnparsed, out RecommendationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecommendationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/recommendations/{recommendation_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="recommendationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecommendationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommendationName, out RecommendationName result) =>
            TryParse(recommendationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="RecommendationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/recommendations/{recommendation_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="recommendationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="RecommendationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string recommendationName, bool allowUnparsed, out RecommendationName result)
        {
            gax::GaxPreconditions.CheckNotNull(recommendationName, nameof(recommendationName));
            gax::TemplatedResourceName resourceName;
            if (s_customerRecommendation.TryParseName(recommendationName, out resourceName))
            {
                result = FromCustomerRecommendation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(recommendationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private RecommendationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string recommendationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            RecommendationId = recommendationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="RecommendationName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/recommendations/{recommendation_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="recommendationId">The <c>Recommendation</c> ID. Must not be <c>null</c> or empty.</param>
        public RecommendationName(string customerId, string recommendationId) : this(ResourceNameType.CustomerRecommendation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), recommendationId: gax::GaxPreconditions.CheckNotNullOrEmpty(recommendationId, nameof(recommendationId)))
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
        /// The <c>Recommendation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string RecommendationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerRecommendation: return s_customerRecommendation.Expand(CustomerId, RecommendationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as RecommendationName);

        /// <inheritdoc/>
        public bool Equals(RecommendationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(RecommendationName a, RecommendationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(RecommendationName a, RecommendationName b) => !(a == b);
    }

    public partial class Recommendation
    {
        /// <summary>
        /// <see cref="RecommendationName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal RecommendationName ResourceNameAsRecommendationName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : RecommendationName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
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
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaign"/> resource name property.
        /// </summary>
        internal CampaignName CampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(Campaign) ? null : CampaignName.Parse(Campaign, allowUnparsed: true);
            set => Campaign = value?.ToString() ?? "";
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
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaigns"/> resource name property.
        /// </summary>
        internal gax::ResourceNameList<CampaignName> CampaignsAsCampaignNames
        {
            get => new gax::ResourceNameList<CampaignName>(Campaigns, s => string.IsNullOrEmpty(s) ? null : CampaignName.Parse(s, allowUnparsed: true));
        }
    }
}

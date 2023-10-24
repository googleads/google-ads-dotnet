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

namespace Google.Ads.GoogleAds.V15.Resources
{
    /// <summary>Resource name for the <c>ConversionGoalCampaignConfig</c> resource.</summary>
    public sealed partial class ConversionGoalCampaignConfigName : gax::IResourceName, sys::IEquatable<ConversionGoalCampaignConfigName>
    {
        /// <summary>The possible contents of <see cref="ConversionGoalCampaignConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c>.
            /// </summary>
            CustomerCampaign = 1,
        }

        private static gax::PathTemplate s_customerCampaign = new gax::PathTemplate("customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}");

        /// <summary>
        /// Creates a <see cref="ConversionGoalCampaignConfigName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversionGoalCampaignConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversionGoalCampaignConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversionGoalCampaignConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversionGoalCampaignConfigName"/> with the pattern
        /// <c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ConversionGoalCampaignConfigName"/> constructed from the provided ids.
        /// </returns>
        public static ConversionGoalCampaignConfigName FromCustomerCampaign(string customerId, string campaignId) =>
            new ConversionGoalCampaignConfigName(ResourceNameType.CustomerCampaign, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionGoalCampaignConfigName"/> with
        /// pattern <c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversionGoalCampaignConfigName"/> with pattern
        /// <c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId) => FormatCustomerCampaign(customerId, campaignId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionGoalCampaignConfigName"/> with
        /// pattern <c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversionGoalCampaignConfigName"/> with pattern
        /// <c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c>.
        /// </returns>
        public static string FormatCustomerCampaign(string customerId, string campaignId) =>
            s_customerCampaign.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionGoalCampaignConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversionGoalCampaignConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ConversionGoalCampaignConfigName"/> if successful.</returns>
        public static ConversionGoalCampaignConfigName Parse(string conversionGoalCampaignConfigName) =>
            Parse(conversionGoalCampaignConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionGoalCampaignConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionGoalCampaignConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversionGoalCampaignConfigName"/> if successful.</returns>
        public static ConversionGoalCampaignConfigName Parse(string conversionGoalCampaignConfigName, bool allowUnparsed) =>
            TryParse(conversionGoalCampaignConfigName, allowUnparsed, out ConversionGoalCampaignConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionGoalCampaignConfigName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversionGoalCampaignConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionGoalCampaignConfigName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionGoalCampaignConfigName, out ConversionGoalCampaignConfigName result) =>
            TryParse(conversionGoalCampaignConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionGoalCampaignConfigName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionGoalCampaignConfigName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionGoalCampaignConfigName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionGoalCampaignConfigName, bool allowUnparsed, out ConversionGoalCampaignConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversionGoalCampaignConfigName, nameof(conversionGoalCampaignConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaign.TryParseName(conversionGoalCampaignConfigName, out resourceName))
            {
                result = FromCustomerCampaign(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversionGoalCampaignConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversionGoalCampaignConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversionGoalCampaignConfigName"/> class from the component parts
        /// of pattern <c>customers/{customer_id}/conversionGoalCampaignConfigs/{campaign_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        public ConversionGoalCampaignConfigName(string customerId, string campaignId) : this(ResourceNameType.CustomerCampaign, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))
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
        public override bool Equals(object obj) => Equals(obj as ConversionGoalCampaignConfigName);

        /// <inheritdoc/>
        public bool Equals(ConversionGoalCampaignConfigName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ConversionGoalCampaignConfigName a, ConversionGoalCampaignConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ConversionGoalCampaignConfigName a, ConversionGoalCampaignConfigName b) => !(a == b);
    }

    public partial class ConversionGoalCampaignConfig
    {
        /// <summary>
        /// <see cref="ConversionGoalCampaignConfigName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal ConversionGoalCampaignConfigName ResourceNameAsConversionGoalCampaignConfigName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ConversionGoalCampaignConfigName.Parse(ResourceName, allowUnparsed: true);
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
        /// <see cref="CustomConversionGoalName"/>-typed view over the <see cref="CustomConversionGoal"/> resource name
        /// property.
        /// </summary>
        internal CustomConversionGoalName CustomConversionGoalAsCustomConversionGoalName
        {
            get => string.IsNullOrEmpty(CustomConversionGoal) ? null : CustomConversionGoalName.Parse(CustomConversionGoal, allowUnparsed: true);
            set => CustomConversionGoal = value?.ToString() ?? "";
        }
    }
}

// Copyright 2024 Google LLC
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

namespace Google.Ads.GoogleAds.V18.Resources
{
    /// <summary>Resource name for the <c>CampaignLifecycleGoal</c> resource.</summary>
    public sealed partial class CampaignLifecycleGoalName : gax::IResourceName, sys::IEquatable<CampaignLifecycleGoalName>
    {
        /// <summary>The possible contents of <see cref="CampaignLifecycleGoalName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c>.
            /// </summary>
            CustomerCampaign = 1,
        }

        private static gax::PathTemplate s_customerCampaign = new gax::PathTemplate("customers/{customer_id}/campaignLifecycleGoals/{campaign_id}");

        /// <summary>Creates a <see cref="CampaignLifecycleGoalName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignLifecycleGoalName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignLifecycleGoalName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignLifecycleGoalName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignLifecycleGoalName"/> with the pattern
        /// <c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignLifecycleGoalName"/> constructed from the provided ids.
        /// </returns>
        public static CampaignLifecycleGoalName FromCustomerCampaign(string customerId, string campaignId) =>
            new CampaignLifecycleGoalName(ResourceNameType.CustomerCampaign, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignLifecycleGoalName"/> with pattern
        /// <c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignLifecycleGoalName"/> with pattern
        /// <c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId) => FormatCustomerCampaign(customerId, campaignId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignLifecycleGoalName"/> with pattern
        /// <c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignLifecycleGoalName"/> with pattern
        /// <c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c>.
        /// </returns>
        public static string FormatCustomerCampaign(string customerId, string campaignId) =>
            s_customerCampaign.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignLifecycleGoalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="campaignLifecycleGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignLifecycleGoalName"/> if successful.</returns>
        public static CampaignLifecycleGoalName Parse(string campaignLifecycleGoalName) =>
            Parse(campaignLifecycleGoalName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignLifecycleGoalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignLifecycleGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignLifecycleGoalName"/> if successful.</returns>
        public static CampaignLifecycleGoalName Parse(string campaignLifecycleGoalName, bool allowUnparsed) =>
            TryParse(campaignLifecycleGoalName, allowUnparsed, out CampaignLifecycleGoalName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignLifecycleGoalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="campaignLifecycleGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignLifecycleGoalName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignLifecycleGoalName, out CampaignLifecycleGoalName result) =>
            TryParse(campaignLifecycleGoalName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignLifecycleGoalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignLifecycleGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignLifecycleGoalName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignLifecycleGoalName, bool allowUnparsed, out CampaignLifecycleGoalName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignLifecycleGoalName, nameof(campaignLifecycleGoalName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaign.TryParseName(campaignLifecycleGoalName, out resourceName))
            {
                result = FromCustomerCampaign(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignLifecycleGoalName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CampaignLifecycleGoalName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignLifecycleGoalName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/campaignLifecycleGoals/{campaign_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignLifecycleGoalName(string customerId, string campaignId) : this(ResourceNameType.CustomerCampaign, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))
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
        public override bool Equals(object obj) => Equals(obj as CampaignLifecycleGoalName);

        /// <inheritdoc/>
        public bool Equals(CampaignLifecycleGoalName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CampaignLifecycleGoalName a, CampaignLifecycleGoalName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CampaignLifecycleGoalName a, CampaignLifecycleGoalName b) => !(a == b);
    }

    public partial class CampaignLifecycleGoal
    {
        /// <summary>
        /// <see cref="CampaignLifecycleGoalName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CampaignLifecycleGoalName ResourceNameAsCampaignLifecycleGoalName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignLifecycleGoalName.Parse(ResourceName, allowUnparsed: true);
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

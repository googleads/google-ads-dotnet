// Copyright 2026 Google LLC
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
using gagvr = Google.Ads.GoogleAds.V22.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V22.Resources
{
    /// <summary>Resource name for the <c>CampaignBudget</c> resource.</summary>
    public sealed partial class CampaignBudgetName : gax::IResourceName, sys::IEquatable<CampaignBudgetName>
    {
        /// <summary>The possible contents of <see cref="CampaignBudgetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c>.
            /// </summary>
            CustomerCampaignBudget = 1,
        }

        private static gax::PathTemplate s_customerCampaignBudget = new gax::PathTemplate("customers/{customer_id}/campaignBudgets/{campaign_budget_id}");

        /// <summary>Creates a <see cref="CampaignBudgetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignBudgetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignBudgetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignBudgetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignBudgetName"/> with the pattern
        /// <c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignBudgetId">The <c>CampaignBudget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignBudgetName"/> constructed from the provided ids.</returns>
        public static CampaignBudgetName FromCustomerCampaignBudget(string customerId, string campaignBudgetId) =>
            new CampaignBudgetName(ResourceNameType.CustomerCampaignBudget, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignBudgetId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignBudgetId, nameof(campaignBudgetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignBudgetName"/> with pattern
        /// <c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignBudgetId">The <c>CampaignBudget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignBudgetName"/> with pattern
        /// <c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignBudgetId) =>
            FormatCustomerCampaignBudget(customerId, campaignBudgetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignBudgetName"/> with pattern
        /// <c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignBudgetId">The <c>CampaignBudget</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignBudgetName"/> with pattern
        /// <c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c>.
        /// </returns>
        public static string FormatCustomerCampaignBudget(string customerId, string campaignBudgetId) =>
            s_customerCampaignBudget.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(campaignBudgetId, nameof(campaignBudgetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignBudgetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="campaignBudgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignBudgetName"/> if successful.</returns>
        public static CampaignBudgetName Parse(string campaignBudgetName) => Parse(campaignBudgetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignBudgetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignBudgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignBudgetName"/> if successful.</returns>
        public static CampaignBudgetName Parse(string campaignBudgetName, bool allowUnparsed) =>
            TryParse(campaignBudgetName, allowUnparsed, out CampaignBudgetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignBudgetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="campaignBudgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignBudgetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignBudgetName, out CampaignBudgetName result) =>
            TryParse(campaignBudgetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignBudgetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignBudgetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignBudgetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignBudgetName, bool allowUnparsed, out CampaignBudgetName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignBudgetName, nameof(campaignBudgetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignBudget.TryParseName(campaignBudgetName, out resourceName))
            {
                result = FromCustomerCampaignBudget(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignBudgetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CampaignBudgetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignBudgetId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignBudgetId = campaignBudgetId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignBudgetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/campaignBudgets/{campaign_budget_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignBudgetId">The <c>CampaignBudget</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignBudgetName(string customerId, string campaignBudgetId) : this(ResourceNameType.CustomerCampaignBudget, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignBudgetId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignBudgetId, nameof(campaignBudgetId)))
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
        /// The <c>CampaignBudget</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CampaignBudgetId { get; }

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
                case ResourceNameType.CustomerCampaignBudget: return s_customerCampaignBudget.Expand(CustomerId, CampaignBudgetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignBudgetName);

        /// <inheritdoc/>
        public bool Equals(CampaignBudgetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CampaignBudgetName a, CampaignBudgetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CampaignBudgetName a, CampaignBudgetName b) => !(a == b);
    }

    public partial class CampaignBudget
    {
        /// <summary>
        /// <see cref="gagvr::CampaignBudgetName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::CampaignBudgetName ResourceNameAsCampaignBudgetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::CampaignBudgetName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CampaignBudgetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::CampaignBudgetName CampaignBudgetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::CampaignBudgetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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

namespace Google.Ads.GoogleAds.V5.Resources
{
    /// <summary>Resource name for the <c>CampaignCriterionSimulation</c> resource.</summary>
    public sealed partial class CampaignCriterionSimulationName : gax::IResourceName, sys::IEquatable<CampaignCriterionSimulationName>
    {
        /// <summary>The possible contents of <see cref="CampaignCriterionSimulationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>.
            /// </summary>
            CustomerCampaignCriterionSimulation = 1
        }

        private static gax::PathTemplate s_customerCampaignCriterionSimulation = new gax::PathTemplate("customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}");

        /// <summary>
        /// Creates a <see cref="CampaignCriterionSimulationName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignCriterionSimulationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignCriterionSimulationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignCriterionSimulationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignCriterionSimulationName"/> with the pattern
        /// <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignCriterionSimulationId">
        /// The <c>CampaignCriterionSimulation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="CampaignCriterionSimulationName"/> constructed from the provided ids.
        /// </returns>
        public static CampaignCriterionSimulationName FromCustomerCampaignCriterionSimulation(string customerId, string campaignCriterionSimulationId) =>
            new CampaignCriterionSimulationName(ResourceNameType.CustomerCampaignCriterionSimulation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignCriterionSimulationId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignCriterionSimulationId, nameof(campaignCriterionSimulationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignCriterionSimulationName"/> with
        /// pattern <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignCriterionSimulationId">
        /// The <c>CampaignCriterionSimulation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CampaignCriterionSimulationName"/> with pattern
        /// <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignCriterionSimulationId) =>
            FormatCustomerCampaignCriterionSimulation(customerId, campaignCriterionSimulationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignCriterionSimulationName"/> with
        /// pattern <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignCriterionSimulationId">
        /// The <c>CampaignCriterionSimulation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CampaignCriterionSimulationName"/> with pattern
        /// <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>.
        /// </returns>
        public static string FormatCustomerCampaignCriterionSimulation(string customerId, string campaignCriterionSimulationId) =>
            s_customerCampaignCriterionSimulation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(campaignCriterionSimulationId, nameof(campaignCriterionSimulationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignCriterionSimulationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignCriterionSimulationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="CampaignCriterionSimulationName"/> if successful.</returns>
        public static CampaignCriterionSimulationName Parse(string campaignCriterionSimulationName) =>
            Parse(campaignCriterionSimulationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignCriterionSimulationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignCriterionSimulationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignCriterionSimulationName"/> if successful.</returns>
        public static CampaignCriterionSimulationName Parse(string campaignCriterionSimulationName, bool allowUnparsed) =>
            TryParse(campaignCriterionSimulationName, allowUnparsed, out CampaignCriterionSimulationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignCriterionSimulationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignCriterionSimulationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignCriterionSimulationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignCriterionSimulationName, out CampaignCriterionSimulationName result) =>
            TryParse(campaignCriterionSimulationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignCriterionSimulationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignCriterionSimulationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignCriterionSimulationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignCriterionSimulationName, bool allowUnparsed, out CampaignCriterionSimulationName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignCriterionSimulationName, nameof(campaignCriterionSimulationName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignCriterionSimulation.TryParseName(campaignCriterionSimulationName, out resourceName))
            {
                result = FromCustomerCampaignCriterionSimulation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignCriterionSimulationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CampaignCriterionSimulationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignCriterionSimulationId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignCriterionSimulationId = campaignCriterionSimulationId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignCriterionSimulationName"/> class from the component parts
        /// of pattern <c>customers/{customer}/campaignCriterionSimulations/{campaign_criterion_simulation}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignCriterionSimulationId">
        /// The <c>CampaignCriterionSimulation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CampaignCriterionSimulationName(string customerId, string campaignCriterionSimulationId) : this(ResourceNameType.CustomerCampaignCriterionSimulation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignCriterionSimulationId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignCriterionSimulationId, nameof(campaignCriterionSimulationId)))
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
        /// The <c>CampaignCriterionSimulation</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string CampaignCriterionSimulationId { get; }

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
                case ResourceNameType.CustomerCampaignCriterionSimulation: return s_customerCampaignCriterionSimulation.Expand(CustomerId, CampaignCriterionSimulationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignCriterionSimulationName);

        /// <inheritdoc/>
        public bool Equals(CampaignCriterionSimulationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignCriterionSimulationName a, CampaignCriterionSimulationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignCriterionSimulationName a, CampaignCriterionSimulationName b) => !(a == b);
    }

    public partial class CampaignCriterionSimulation
    {
        /// <summary>
        /// <see cref="CampaignCriterionSimulationName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CampaignCriterionSimulationName ResourceNameAsCampaignCriterionSimulationName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignCriterionSimulationName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

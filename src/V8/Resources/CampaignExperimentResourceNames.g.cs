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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V8.Resources
{
    /// <summary>Resource name for the <c>CampaignExperiment</c> resource.</summary>
    public sealed partial class CampaignExperimentName : gax::IResourceName, sys::IEquatable<CampaignExperimentName>
    {
        /// <summary>The possible contents of <see cref="CampaignExperimentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c>
            /// .
            /// </summary>
            CustomerCampaignExperiment = 1,
        }

        private static gax::PathTemplate s_customerCampaignExperiment = new gax::PathTemplate("customers/{customer_id}/campaignExperiments/{campaign_experiment_id}");

        /// <summary>Creates a <see cref="CampaignExperimentName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignExperimentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignExperimentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignExperimentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignExperimentName"/> with the pattern
        /// <c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignExperimentId">
        /// The <c>CampaignExperiment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="CampaignExperimentName"/> constructed from the provided ids.</returns>
        public static CampaignExperimentName FromCustomerCampaignExperiment(string customerId, string campaignExperimentId) =>
            new CampaignExperimentName(ResourceNameType.CustomerCampaignExperiment, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignExperimentId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperimentId, nameof(campaignExperimentId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignExperimentName"/> with pattern
        /// <c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignExperimentId">
        /// The <c>CampaignExperiment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CampaignExperimentName"/> with pattern
        /// <c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignExperimentId) =>
            FormatCustomerCampaignExperiment(customerId, campaignExperimentId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignExperimentName"/> with pattern
        /// <c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignExperimentId">
        /// The <c>CampaignExperiment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="CampaignExperimentName"/> with pattern
        /// <c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c>.
        /// </returns>
        public static string FormatCustomerCampaignExperiment(string customerId, string campaignExperimentId) =>
            s_customerCampaignExperiment.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperimentId, nameof(campaignExperimentId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignExperimentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignExperimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignExperimentName"/> if successful.</returns>
        public static CampaignExperimentName Parse(string campaignExperimentName) => Parse(campaignExperimentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignExperimentName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignExperimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignExperimentName"/> if successful.</returns>
        public static CampaignExperimentName Parse(string campaignExperimentName, bool allowUnparsed) =>
            TryParse(campaignExperimentName, allowUnparsed, out CampaignExperimentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignExperimentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignExperimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignExperimentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignExperimentName, out CampaignExperimentName result) =>
            TryParse(campaignExperimentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignExperimentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignExperimentName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignExperimentName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignExperimentName, bool allowUnparsed, out CampaignExperimentName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignExperimentName, nameof(campaignExperimentName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignExperiment.TryParseName(campaignExperimentName, out resourceName))
            {
                result = FromCustomerCampaignExperiment(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignExperimentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CampaignExperimentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignExperimentId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignExperimentId = campaignExperimentId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignExperimentName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/campaignExperiments/{campaign_experiment_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignExperimentId">
        /// The <c>CampaignExperiment</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public CampaignExperimentName(string customerId, string campaignExperimentId) : this(ResourceNameType.CustomerCampaignExperiment, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignExperimentId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperimentId, nameof(campaignExperimentId)))
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
        /// The <c>CampaignExperiment</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CampaignExperimentId { get; }

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
                case ResourceNameType.CustomerCampaignExperiment: return s_customerCampaignExperiment.Expand(CustomerId, CampaignExperimentId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignExperimentName);

        /// <inheritdoc/>
        public bool Equals(CampaignExperimentName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CampaignExperimentName a, CampaignExperimentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CampaignExperimentName a, CampaignExperimentName b) => !(a == b);
    }

    public partial class CampaignExperiment
    {
        /// <summary>
        /// <see cref="gagvr::CampaignExperimentName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CampaignExperimentName ResourceNameAsCampaignExperimentName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::CampaignExperimentName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignDraftName"/>-typed view over the <see cref="CampaignDraft"/> resource name property.
        /// </summary>
        internal CampaignDraftName CampaignDraftAsCampaignDraftName
        {
            get => string.IsNullOrEmpty(CampaignDraft) ? null : CampaignDraftName.Parse(CampaignDraft, allowUnparsed: true);
            set => CampaignDraft = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CampaignExperimentName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal CampaignExperimentName CampaignExperimentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::CampaignExperimentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="ExperimentCampaign"/> resource name property.
        /// </summary>
        internal CampaignName ExperimentCampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(ExperimentCampaign) ? null : CampaignName.Parse(ExperimentCampaign, allowUnparsed: true);
            set => ExperimentCampaign = value?.ToString() ?? "";
        }
    }
}

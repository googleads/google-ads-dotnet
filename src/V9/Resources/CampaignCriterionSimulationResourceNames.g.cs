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
            /// <c>
            /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
            /// .
            /// </summary>
            CustomerCampaignCriterionTypeModificationMethodStartDateEndDate = 1,
        }

        private static gax::PathTemplate s_customerCampaignCriterionTypeModificationMethodStartDateEndDate = new gax::PathTemplate("customers/{customer_id}/campaignCriterionSimulations/{campaign_id_criterion_id_type_modification_method_start_date_end_date}");

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
        /// <c>
        /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="typeId">The <c>Type</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modificationMethodId">
        /// The <c>ModificationMethod</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="startDateId">The <c>StartDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endDateId">The <c>EndDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignCriterionSimulationName"/> constructed from the provided ids.
        /// </returns>
        public static CampaignCriterionSimulationName FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate(string customerId, string campaignId, string criterionId, string typeId, string modificationMethodId, string startDateId, string endDateId) =>
            new CampaignCriterionSimulationName(ResourceNameType.CustomerCampaignCriterionTypeModificationMethodStartDateEndDate, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)), typeId: gax::GaxPreconditions.CheckNotNullOrEmpty(typeId, nameof(typeId)), modificationMethodId: gax::GaxPreconditions.CheckNotNullOrEmpty(modificationMethodId, nameof(modificationMethodId)), startDateId: gax::GaxPreconditions.CheckNotNullOrEmpty(startDateId, nameof(startDateId)), endDateId: gax::GaxPreconditions.CheckNotNullOrEmpty(endDateId, nameof(endDateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignCriterionSimulationName"/> with
        /// pattern
        /// <c>
        /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="typeId">The <c>Type</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modificationMethodId">
        /// The <c>ModificationMethod</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="startDateId">The <c>StartDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endDateId">The <c>EndDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignCriterionSimulationName"/> with pattern
        /// <c>
        /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// .
        /// </returns>
        public static string Format(string customerId, string campaignId, string criterionId, string typeId, string modificationMethodId, string startDateId, string endDateId) =>
            FormatCustomerCampaignCriterionTypeModificationMethodStartDateEndDate(customerId, campaignId, criterionId, typeId, modificationMethodId, startDateId, endDateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignCriterionSimulationName"/> with
        /// pattern
        /// <c>
        /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="typeId">The <c>Type</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modificationMethodId">
        /// The <c>ModificationMethod</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="startDateId">The <c>StartDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endDateId">The <c>EndDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignCriterionSimulationName"/> with pattern
        /// <c>
        /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// .
        /// </returns>
        public static string FormatCustomerCampaignCriterionTypeModificationMethodStartDateEndDate(string customerId, string campaignId, string criterionId, string typeId, string modificationMethodId, string startDateId, string endDateId) =>
            s_customerCampaignCriterionTypeModificationMethodStartDateEndDate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(typeId, nameof(typeId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(modificationMethodId, nameof(modificationMethodId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(startDateId, nameof(startDateId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(endDateId, nameof(endDateId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignCriterionSimulationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
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
        /// <c>
        /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
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
        /// <c>
        /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
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
        /// <c>
        /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
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
            if (s_customerCampaignCriterionTypeModificationMethodStartDateEndDate.TryParseName(campaignCriterionSimulationName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[]
                {
                    '~',
                    '~',
                    '~',
                    '~',
                    '~',
                });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignCriterionTypeModificationMethodStartDateEndDate(resourceName[0], split1[0], split1[1], split1[2], split1[3], split1[4], split1[5]);
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

        private CampaignCriterionSimulationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string criterionId = null, string customerId = null, string endDateId = null, string modificationMethodId = null, string startDateId = null, string typeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CriterionId = criterionId;
            CustomerId = customerId;
            EndDateId = endDateId;
            ModificationMethodId = modificationMethodId;
            StartDateId = startDateId;
            TypeId = typeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignCriterionSimulationName"/> class from the component parts
        /// of pattern
        /// <c>
        /// customers/{customer_id}/campaignCriterionSimulations/{campaign_id}~{criterion_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="typeId">The <c>Type</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modificationMethodId">
        /// The <c>ModificationMethod</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="startDateId">The <c>StartDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endDateId">The <c>EndDate</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignCriterionSimulationName(string customerId, string campaignId, string criterionId, string typeId, string modificationMethodId, string startDateId, string endDateId) : this(ResourceNameType.CustomerCampaignCriterionTypeModificationMethodStartDateEndDate, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)), typeId: gax::GaxPreconditions.CheckNotNullOrEmpty(typeId, nameof(typeId)), modificationMethodId: gax::GaxPreconditions.CheckNotNullOrEmpty(modificationMethodId, nameof(modificationMethodId)), startDateId: gax::GaxPreconditions.CheckNotNullOrEmpty(startDateId, nameof(startDateId)), endDateId: gax::GaxPreconditions.CheckNotNullOrEmpty(endDateId, nameof(endDateId)))
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
        /// The <c>Criterion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CriterionId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>EndDate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string EndDateId { get; }

        /// <summary>
        /// The <c>ModificationMethod</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ModificationMethodId { get; }

        /// <summary>
        /// The <c>StartDate</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string StartDateId { get; }

        /// <summary>
        /// The <c>Type</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TypeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignCriterionTypeModificationMethodStartDateEndDate: return s_customerCampaignCriterionTypeModificationMethodStartDateEndDate.Expand(CustomerId, $"{CampaignId}~{CriterionId}~{TypeId}~{ModificationMethodId}~{StartDateId}~{EndDateId}");
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

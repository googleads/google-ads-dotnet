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

namespace Google.Ads.GoogleAds.V16.Resources
{
    /// <summary>Resource name for the <c>CampaignSimulation</c> resource.</summary>
    public sealed partial class CampaignSimulationName : gax::IResourceName, sys::IEquatable<CampaignSimulationName>
    {
        /// <summary>The possible contents of <see cref="CampaignSimulationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
            /// .
            /// </summary>
            CustomerCampaignTypeModificationMethodStartDateEndDate = 1,
        }

        private static gax::PathTemplate s_customerCampaignTypeModificationMethodStartDateEndDate = new gax::PathTemplate("customers/{customer_id}/campaignSimulations/{campaign_id_type_modification_method_start_date_end_date}");

        /// <summary>Creates a <see cref="CampaignSimulationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignSimulationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignSimulationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignSimulationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignSimulationName"/> with the pattern
        /// <c>
        /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="typeId">The <c>Type</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modificationMethodId">
        /// The <c>ModificationMethod</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="startDateId">The <c>StartDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endDateId">The <c>EndDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignSimulationName"/> constructed from the provided ids.</returns>
        public static CampaignSimulationName FromCustomerCampaignTypeModificationMethodStartDateEndDate(string customerId, string campaignId, string typeId, string modificationMethodId, string startDateId, string endDateId) =>
            new CampaignSimulationName(ResourceNameType.CustomerCampaignTypeModificationMethodStartDateEndDate, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), typeId: gax::GaxPreconditions.CheckNotNullOrEmpty(typeId, nameof(typeId)), modificationMethodId: gax::GaxPreconditions.CheckNotNullOrEmpty(modificationMethodId, nameof(modificationMethodId)), startDateId: gax::GaxPreconditions.CheckNotNullOrEmpty(startDateId, nameof(startDateId)), endDateId: gax::GaxPreconditions.CheckNotNullOrEmpty(endDateId, nameof(endDateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignSimulationName"/> with pattern
        /// <c>
        /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="typeId">The <c>Type</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modificationMethodId">
        /// The <c>ModificationMethod</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="startDateId">The <c>StartDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endDateId">The <c>EndDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignSimulationName"/> with pattern
        /// <c>
        /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// .
        /// </returns>
        public static string Format(string customerId, string campaignId, string typeId, string modificationMethodId, string startDateId, string endDateId) =>
            FormatCustomerCampaignTypeModificationMethodStartDateEndDate(customerId, campaignId, typeId, modificationMethodId, startDateId, endDateId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignSimulationName"/> with pattern
        /// <c>
        /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="typeId">The <c>Type</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modificationMethodId">
        /// The <c>ModificationMethod</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="startDateId">The <c>StartDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endDateId">The <c>EndDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignSimulationName"/> with pattern
        /// <c>
        /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// .
        /// </returns>
        public static string FormatCustomerCampaignTypeModificationMethodStartDateEndDate(string customerId, string campaignId, string typeId, string modificationMethodId, string startDateId, string endDateId) =>
            s_customerCampaignTypeModificationMethodStartDateEndDate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(typeId, nameof(typeId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(modificationMethodId, nameof(modificationMethodId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(startDateId, nameof(startDateId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(endDateId, nameof(endDateId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignSimulationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignSimulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignSimulationName"/> if successful.</returns>
        public static CampaignSimulationName Parse(string campaignSimulationName) => Parse(campaignSimulationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignSimulationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignSimulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignSimulationName"/> if successful.</returns>
        public static CampaignSimulationName Parse(string campaignSimulationName, bool allowUnparsed) =>
            TryParse(campaignSimulationName, allowUnparsed, out CampaignSimulationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignSimulationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignSimulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignSimulationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignSimulationName, out CampaignSimulationName result) =>
            TryParse(campaignSimulationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignSimulationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignSimulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignSimulationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignSimulationName, bool allowUnparsed, out CampaignSimulationName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignSimulationName, nameof(campaignSimulationName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignTypeModificationMethodStartDateEndDate.TryParseName(campaignSimulationName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignTypeModificationMethodStartDateEndDate(resourceName[0], split1[0], split1[1], split1[2], split1[3], split1[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignSimulationName, out gax::UnparsedResourceName unparsedResourceName))
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

        private CampaignSimulationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string customerId = null, string endDateId = null, string modificationMethodId = null, string startDateId = null, string typeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CustomerId = customerId;
            EndDateId = endDateId;
            ModificationMethodId = modificationMethodId;
            StartDateId = startDateId;
            TypeId = typeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignSimulationName"/> class from the component parts of
        /// pattern
        /// <c>
        /// customers/{customer_id}/campaignSimulations/{campaign_id}~{type}~{modification_method}~{start_date}~{end_date}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="typeId">The <c>Type</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="modificationMethodId">
        /// The <c>ModificationMethod</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="startDateId">The <c>StartDate</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="endDateId">The <c>EndDate</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignSimulationName(string customerId, string campaignId, string typeId, string modificationMethodId, string startDateId, string endDateId) : this(ResourceNameType.CustomerCampaignTypeModificationMethodStartDateEndDate, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), typeId: gax::GaxPreconditions.CheckNotNullOrEmpty(typeId, nameof(typeId)), modificationMethodId: gax::GaxPreconditions.CheckNotNullOrEmpty(modificationMethodId, nameof(modificationMethodId)), startDateId: gax::GaxPreconditions.CheckNotNullOrEmpty(startDateId, nameof(startDateId)), endDateId: gax::GaxPreconditions.CheckNotNullOrEmpty(endDateId, nameof(endDateId)))
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
                case ResourceNameType.CustomerCampaignTypeModificationMethodStartDateEndDate: return s_customerCampaignTypeModificationMethodStartDateEndDate.Expand(CustomerId, $"{CampaignId}~{TypeId}~{ModificationMethodId}~{StartDateId}~{EndDateId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignSimulationName);

        /// <inheritdoc/>
        public bool Equals(CampaignSimulationName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CampaignSimulationName a, CampaignSimulationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CampaignSimulationName a, CampaignSimulationName b) => !(a == b);
    }

    public partial class CampaignSimulation
    {
        /// <summary>
        /// <see cref="CampaignSimulationName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CampaignSimulationName ResourceNameAsCampaignSimulationName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignSimulationName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

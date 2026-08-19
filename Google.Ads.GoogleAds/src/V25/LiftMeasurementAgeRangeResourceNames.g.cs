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
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V25.Resources
{
    /// <summary>Resource name for the <c>LiftMeasurementAgeRange</c> resource.</summary>
    public sealed partial class LiftMeasurementAgeRangeName : gax::IResourceName, sys::IEquatable<LiftMeasurementAgeRangeName>
    {
        /// <summary>The possible contents of <see cref="LiftMeasurementAgeRangeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
            /// .
            /// </summary>
            CustomerLiftMeasurementConfigurationCampaignCriterion = 1,
        }

        private static gax::PathTemplate s_customerLiftMeasurementConfigurationCampaignCriterion = new gax::PathTemplate("customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id_campaign_id_criterion_id}");

        /// <summary>Creates a <see cref="LiftMeasurementAgeRangeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LiftMeasurementAgeRangeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LiftMeasurementAgeRangeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LiftMeasurementAgeRangeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LiftMeasurementAgeRangeName"/> with the pattern
        /// <c>
        /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="LiftMeasurementAgeRangeName"/> constructed from the provided ids.
        /// </returns>
        public static LiftMeasurementAgeRangeName FromCustomerLiftMeasurementConfigurationCampaignCriterion(string customerId, string liftMeasurementConfigurationId, string campaignId, string criterionId) =>
            new LiftMeasurementAgeRangeName(ResourceNameType.CustomerLiftMeasurementConfigurationCampaignCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), liftMeasurementConfigurationId: gax::GaxPreconditions.CheckNotNullOrEmpty(liftMeasurementConfigurationId, nameof(liftMeasurementConfigurationId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiftMeasurementAgeRangeName"/> with
        /// pattern
        /// <c>
        /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiftMeasurementAgeRangeName"/> with pattern
        /// <c>
        /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
        /// .
        /// </returns>
        public static string Format(string customerId, string liftMeasurementConfigurationId, string campaignId, string criterionId) =>
            FormatCustomerLiftMeasurementConfigurationCampaignCriterion(customerId, liftMeasurementConfigurationId, campaignId, criterionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiftMeasurementAgeRangeName"/> with
        /// pattern
        /// <c>
        /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiftMeasurementAgeRangeName"/> with pattern
        /// <c>
        /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
        /// .
        /// </returns>
        public static string FormatCustomerLiftMeasurementConfigurationCampaignCriterion(string customerId, string liftMeasurementConfigurationId, string campaignId, string criterionId) =>
            s_customerLiftMeasurementConfigurationCampaignCriterion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(liftMeasurementConfigurationId, nameof(liftMeasurementConfigurationId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiftMeasurementAgeRangeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liftMeasurementAgeRangeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LiftMeasurementAgeRangeName"/> if successful.</returns>
        public static LiftMeasurementAgeRangeName Parse(string liftMeasurementAgeRangeName) =>
            Parse(liftMeasurementAgeRangeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiftMeasurementAgeRangeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liftMeasurementAgeRangeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LiftMeasurementAgeRangeName"/> if successful.</returns>
        public static LiftMeasurementAgeRangeName Parse(string liftMeasurementAgeRangeName, bool allowUnparsed) =>
            TryParse(liftMeasurementAgeRangeName, allowUnparsed, out LiftMeasurementAgeRangeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiftMeasurementAgeRangeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liftMeasurementAgeRangeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiftMeasurementAgeRangeName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liftMeasurementAgeRangeName, out LiftMeasurementAgeRangeName result) =>
            TryParse(liftMeasurementAgeRangeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiftMeasurementAgeRangeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liftMeasurementAgeRangeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiftMeasurementAgeRangeName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liftMeasurementAgeRangeName, bool allowUnparsed, out LiftMeasurementAgeRangeName result)
        {
            gax::GaxPreconditions.CheckNotNull(liftMeasurementAgeRangeName, nameof(liftMeasurementAgeRangeName));
            gax::TemplatedResourceName resourceName;
            if (s_customerLiftMeasurementConfigurationCampaignCriterion.TryParseName(liftMeasurementAgeRangeName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerLiftMeasurementConfigurationCampaignCriterion(resourceName[0], split1[0], split1[1], split1[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(liftMeasurementAgeRangeName, out gax::UnparsedResourceName unparsedResourceName))
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

        private LiftMeasurementAgeRangeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string criterionId = null, string customerId = null, string liftMeasurementConfigurationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CriterionId = criterionId;
            CustomerId = customerId;
            LiftMeasurementConfigurationId = liftMeasurementConfigurationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LiftMeasurementAgeRangeName"/> class from the component parts of
        /// pattern
        /// <c>
        /// customers/{customer_id}/liftMeasurementAgeRanges/{lift_measurement_configuration_id}~{campaign_id}~{criterion_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        public LiftMeasurementAgeRangeName(string customerId, string liftMeasurementConfigurationId, string campaignId, string criterionId) : this(ResourceNameType.CustomerLiftMeasurementConfigurationCampaignCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), liftMeasurementConfigurationId: gax::GaxPreconditions.CheckNotNullOrEmpty(liftMeasurementConfigurationId, nameof(liftMeasurementConfigurationId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))
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
        /// The <c>LiftMeasurementConfiguration</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string LiftMeasurementConfigurationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerLiftMeasurementConfigurationCampaignCriterion: return s_customerLiftMeasurementConfigurationCampaignCriterion.Expand(CustomerId, $"{LiftMeasurementConfigurationId}~{CampaignId}~{CriterionId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LiftMeasurementAgeRangeName);

        /// <inheritdoc/>
        public bool Equals(LiftMeasurementAgeRangeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LiftMeasurementAgeRangeName a, LiftMeasurementAgeRangeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LiftMeasurementAgeRangeName a, LiftMeasurementAgeRangeName b) => !(a == b);
    }

    public partial class LiftMeasurementAgeRange
    {
        /// <summary>
        /// <see cref="LiftMeasurementAgeRangeName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal LiftMeasurementAgeRangeName ResourceNameAsLiftMeasurementAgeRangeName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : LiftMeasurementAgeRangeName.Parse(ResourceName, allowUnparsed: true);
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

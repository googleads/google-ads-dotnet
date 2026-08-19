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
    /// <summary>Resource name for the <c>LiftMeasurementCampaign</c> resource.</summary>
    public sealed partial class LiftMeasurementCampaignName : gax::IResourceName, sys::IEquatable<LiftMeasurementCampaignName>
    {
        /// <summary>The possible contents of <see cref="LiftMeasurementCampaignName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>
            /// .
            /// </summary>
            CustomerLiftMeasurementConfigurationCampaign = 1,
        }

        private static gax::PathTemplate s_customerLiftMeasurementConfigurationCampaign = new gax::PathTemplate("customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id_campaign_id}");

        /// <summary>Creates a <see cref="LiftMeasurementCampaignName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LiftMeasurementCampaignName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LiftMeasurementCampaignName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LiftMeasurementCampaignName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LiftMeasurementCampaignName"/> with the pattern
        /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="LiftMeasurementCampaignName"/> constructed from the provided ids.
        /// </returns>
        public static LiftMeasurementCampaignName FromCustomerLiftMeasurementConfigurationCampaign(string customerId, string liftMeasurementConfigurationId, string campaignId) =>
            new LiftMeasurementCampaignName(ResourceNameType.CustomerLiftMeasurementConfigurationCampaign, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), liftMeasurementConfigurationId: gax::GaxPreconditions.CheckNotNullOrEmpty(liftMeasurementConfigurationId, nameof(liftMeasurementConfigurationId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiftMeasurementCampaignName"/> with
        /// pattern
        /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiftMeasurementCampaignName"/> with pattern
        /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>.
        /// </returns>
        public static string Format(string customerId, string liftMeasurementConfigurationId, string campaignId) =>
            FormatCustomerLiftMeasurementConfigurationCampaign(customerId, liftMeasurementConfigurationId, campaignId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiftMeasurementCampaignName"/> with
        /// pattern
        /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LiftMeasurementCampaignName"/> with pattern
        /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>.
        /// </returns>
        public static string FormatCustomerLiftMeasurementConfigurationCampaign(string customerId, string liftMeasurementConfigurationId, string campaignId) =>
            s_customerLiftMeasurementConfigurationCampaign.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(liftMeasurementConfigurationId, nameof(liftMeasurementConfigurationId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiftMeasurementCampaignName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liftMeasurementCampaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LiftMeasurementCampaignName"/> if successful.</returns>
        public static LiftMeasurementCampaignName Parse(string liftMeasurementCampaignName) =>
            Parse(liftMeasurementCampaignName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiftMeasurementCampaignName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liftMeasurementCampaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LiftMeasurementCampaignName"/> if successful.</returns>
        public static LiftMeasurementCampaignName Parse(string liftMeasurementCampaignName, bool allowUnparsed) =>
            TryParse(liftMeasurementCampaignName, allowUnparsed, out LiftMeasurementCampaignName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiftMeasurementCampaignName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liftMeasurementCampaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiftMeasurementCampaignName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liftMeasurementCampaignName, out LiftMeasurementCampaignName result) =>
            TryParse(liftMeasurementCampaignName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiftMeasurementCampaignName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liftMeasurementCampaignName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiftMeasurementCampaignName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liftMeasurementCampaignName, bool allowUnparsed, out LiftMeasurementCampaignName result)
        {
            gax::GaxPreconditions.CheckNotNull(liftMeasurementCampaignName, nameof(liftMeasurementCampaignName));
            gax::TemplatedResourceName resourceName;
            if (s_customerLiftMeasurementConfigurationCampaign.TryParseName(liftMeasurementCampaignName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerLiftMeasurementConfigurationCampaign(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(liftMeasurementCampaignName, out gax::UnparsedResourceName unparsedResourceName))
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

        private LiftMeasurementCampaignName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string customerId = null, string liftMeasurementConfigurationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CustomerId = customerId;
            LiftMeasurementConfigurationId = liftMeasurementConfigurationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LiftMeasurementCampaignName"/> class from the component parts of
        /// pattern
        /// <c>customers/{customer_id}/liftMeasurementCampaigns/{lift_measurement_configuration_id}~{campaign_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        public LiftMeasurementCampaignName(string customerId, string liftMeasurementConfigurationId, string campaignId) : this(ResourceNameType.CustomerLiftMeasurementConfigurationCampaign, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), liftMeasurementConfigurationId: gax::GaxPreconditions.CheckNotNullOrEmpty(liftMeasurementConfigurationId, nameof(liftMeasurementConfigurationId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))
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
                case ResourceNameType.CustomerLiftMeasurementConfigurationCampaign: return s_customerLiftMeasurementConfigurationCampaign.Expand(CustomerId, $"{LiftMeasurementConfigurationId}~{CampaignId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LiftMeasurementCampaignName);

        /// <inheritdoc/>
        public bool Equals(LiftMeasurementCampaignName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LiftMeasurementCampaignName a, LiftMeasurementCampaignName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LiftMeasurementCampaignName a, LiftMeasurementCampaignName b) => !(a == b);
    }

    public partial class LiftMeasurementCampaign
    {
        /// <summary>
        /// <see cref="LiftMeasurementCampaignName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal LiftMeasurementCampaignName ResourceNameAsLiftMeasurementCampaignName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : LiftMeasurementCampaignName.Parse(ResourceName, allowUnparsed: true);
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

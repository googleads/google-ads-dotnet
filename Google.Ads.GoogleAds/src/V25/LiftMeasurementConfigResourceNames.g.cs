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
using gagvr = Google.Ads.GoogleAds.V25.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V25.Resources
{
    /// <summary>Resource name for the <c>LiftMeasurementConfig</c> resource.</summary>
    public sealed partial class LiftMeasurementConfigName : gax::IResourceName, sys::IEquatable<LiftMeasurementConfigName>
    {
        /// <summary>The possible contents of <see cref="LiftMeasurementConfigName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>.
            /// </summary>
            CustomerLiftMeasurementConfiguration = 1,
        }

        private static gax::PathTemplate s_customerLiftMeasurementConfiguration = new gax::PathTemplate("customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}");

        /// <summary>Creates a <see cref="LiftMeasurementConfigName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LiftMeasurementConfigName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LiftMeasurementConfigName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LiftMeasurementConfigName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LiftMeasurementConfigName"/> with the pattern
        /// <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="LiftMeasurementConfigName"/> constructed from the provided ids.
        /// </returns>
        public static LiftMeasurementConfigName FromCustomerLiftMeasurementConfiguration(string customerId, string liftMeasurementConfigurationId) =>
            new LiftMeasurementConfigName(ResourceNameType.CustomerLiftMeasurementConfiguration, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), liftMeasurementConfigurationId: gax::GaxPreconditions.CheckNotNullOrEmpty(liftMeasurementConfigurationId, nameof(liftMeasurementConfigurationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiftMeasurementConfigName"/> with pattern
        /// <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="LiftMeasurementConfigName"/> with pattern
        /// <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>.
        /// </returns>
        public static string Format(string customerId, string liftMeasurementConfigurationId) =>
            FormatCustomerLiftMeasurementConfiguration(customerId, liftMeasurementConfigurationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LiftMeasurementConfigName"/> with pattern
        /// <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="LiftMeasurementConfigName"/> with pattern
        /// <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>.
        /// </returns>
        public static string FormatCustomerLiftMeasurementConfiguration(string customerId, string liftMeasurementConfigurationId) =>
            s_customerLiftMeasurementConfiguration.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(liftMeasurementConfigurationId, nameof(liftMeasurementConfigurationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiftMeasurementConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liftMeasurementConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LiftMeasurementConfigName"/> if successful.</returns>
        public static LiftMeasurementConfigName Parse(string liftMeasurementConfigName) =>
            Parse(liftMeasurementConfigName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LiftMeasurementConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liftMeasurementConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LiftMeasurementConfigName"/> if successful.</returns>
        public static LiftMeasurementConfigName Parse(string liftMeasurementConfigName, bool allowUnparsed) =>
            TryParse(liftMeasurementConfigName, allowUnparsed, out LiftMeasurementConfigName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiftMeasurementConfigName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="liftMeasurementConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiftMeasurementConfigName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liftMeasurementConfigName, out LiftMeasurementConfigName result) =>
            TryParse(liftMeasurementConfigName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LiftMeasurementConfigName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="liftMeasurementConfigName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LiftMeasurementConfigName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string liftMeasurementConfigName, bool allowUnparsed, out LiftMeasurementConfigName result)
        {
            gax::GaxPreconditions.CheckNotNull(liftMeasurementConfigName, nameof(liftMeasurementConfigName));
            gax::TemplatedResourceName resourceName;
            if (s_customerLiftMeasurementConfiguration.TryParseName(liftMeasurementConfigName, out resourceName))
            {
                result = FromCustomerLiftMeasurementConfiguration(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(liftMeasurementConfigName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LiftMeasurementConfigName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string liftMeasurementConfigurationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            LiftMeasurementConfigurationId = liftMeasurementConfigurationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LiftMeasurementConfigName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/liftMeasurementConfigs/{lift_measurement_configuration_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="liftMeasurementConfigurationId">
        /// The <c>LiftMeasurementConfiguration</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public LiftMeasurementConfigName(string customerId, string liftMeasurementConfigurationId) : this(ResourceNameType.CustomerLiftMeasurementConfiguration, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), liftMeasurementConfigurationId: gax::GaxPreconditions.CheckNotNullOrEmpty(liftMeasurementConfigurationId, nameof(liftMeasurementConfigurationId)))
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
                case ResourceNameType.CustomerLiftMeasurementConfiguration: return s_customerLiftMeasurementConfiguration.Expand(CustomerId, LiftMeasurementConfigurationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LiftMeasurementConfigName);

        /// <inheritdoc/>
        public bool Equals(LiftMeasurementConfigName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LiftMeasurementConfigName a, LiftMeasurementConfigName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LiftMeasurementConfigName a, LiftMeasurementConfigName b) => !(a == b);
    }

    public partial class LiftMeasurementConfig
    {
        /// <summary>
        /// <see cref="gagvr::LiftMeasurementConfigName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::LiftMeasurementConfigName ResourceNameAsLiftMeasurementConfigName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::LiftMeasurementConfigName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::LiftMeasurementConfigName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        internal gagvr::LiftMeasurementConfigName LiftMeasurementConfigName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::LiftMeasurementConfigName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ConversionActionName"/>-typed view over the <see cref="ConversionActions"/> resource name
        /// property.
        /// </summary>
        internal gax::ResourceNameList<ConversionActionName> ConversionActionsAsConversionActionNames
        {
            get => new gax::ResourceNameList<ConversionActionName>(ConversionActions, s => string.IsNullOrEmpty(s) ? null : ConversionActionName.Parse(s, allowUnparsed: true));
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

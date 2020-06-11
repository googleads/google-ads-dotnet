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

namespace Google.Ads.GoogleAds.V3.Resources
{
    /// <summary>Resource name for the <c>AdGroupSimulation</c> resource.</summary>
    public sealed partial class AdGroupSimulationName : gax::IResourceName, sys::IEquatable<AdGroupSimulationName>
    {
        /// <summary>The possible contents of <see cref="AdGroupSimulationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c>.
            /// </summary>
            CustomerAdGroupSimulation = 1
        }

        private static gax::PathTemplate s_customerAdGroupSimulation = new gax::PathTemplate("customers/{customer}/adGroupSimulations/{ad_group_simulation}");

        /// <summary>Creates a <see cref="AdGroupSimulationName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupSimulationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupSimulationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupSimulationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupSimulationName"/> with the pattern
        /// <c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupSimulationId">The <c>AdGroupSimulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdGroupSimulationName"/> constructed from the provided ids.</returns>
        public static AdGroupSimulationName FromCustomerAdGroupSimulation(string customerId, string adGroupSimulationId) =>
            new AdGroupSimulationName(ResourceNameType.CustomerAdGroupSimulation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupSimulationId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupSimulationId, nameof(adGroupSimulationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupSimulationName"/> with pattern
        /// <c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupSimulationId">The <c>AdGroupSimulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupSimulationName"/> with pattern
        /// <c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupSimulationId) =>
            FormatCustomerAdGroupSimulation(customerId, adGroupSimulationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupSimulationName"/> with pattern
        /// <c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupSimulationId">The <c>AdGroupSimulation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupSimulationName"/> with pattern
        /// <c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupSimulation(string customerId, string adGroupSimulationId) =>
            s_customerAdGroupSimulation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupSimulationId, nameof(adGroupSimulationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupSimulationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupSimulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupSimulationName"/> if successful.</returns>
        public static AdGroupSimulationName Parse(string adGroupSimulationName) => Parse(adGroupSimulationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupSimulationName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupSimulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupSimulationName"/> if successful.</returns>
        public static AdGroupSimulationName Parse(string adGroupSimulationName, bool allowUnparsed) =>
            TryParse(adGroupSimulationName, allowUnparsed, out AdGroupSimulationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupSimulationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupSimulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupSimulationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupSimulationName, out AdGroupSimulationName result) =>
            TryParse(adGroupSimulationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupSimulationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupSimulationName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupSimulationName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupSimulationName, bool allowUnparsed, out AdGroupSimulationName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupSimulationName, nameof(adGroupSimulationName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupSimulation.TryParseName(adGroupSimulationName, out resourceName))
            {
                result = FromCustomerAdGroupSimulation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupSimulationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupSimulationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupSimulationId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupSimulationId = adGroupSimulationId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupSimulationName"/> class from the component parts of pattern
        /// <c>customers/{customer}/adGroupSimulations/{ad_group_simulation}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupSimulationId">The <c>AdGroupSimulation</c> ID. Must not be <c>null</c> or empty.</param>
        public AdGroupSimulationName(string customerId, string adGroupSimulationId) : this(ResourceNameType.CustomerAdGroupSimulation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupSimulationId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupSimulationId, nameof(adGroupSimulationId)))
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
        /// The <c>AdGroupSimulation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AdGroupSimulationId { get; }

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
                case ResourceNameType.CustomerAdGroupSimulation: return s_customerAdGroupSimulation.Expand(CustomerId, AdGroupSimulationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupSimulationName);

        /// <inheritdoc/>
        public bool Equals(AdGroupSimulationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupSimulationName a, AdGroupSimulationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupSimulationName a, AdGroupSimulationName b) => !(a == b);
    }

    public partial class AdGroupSimulation
    {
        /// <summary>
        /// <see cref="AdGroupSimulationName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupSimulationName ResourceNameAsAdGroupSimulationName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupSimulationName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

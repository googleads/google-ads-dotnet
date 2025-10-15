// Copyright 2025 Google LLC
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

namespace Google.Ads.GoogleAds.V22.Resources
{
    /// <summary>Resource name for the <c>GeographicView</c> resource.</summary>
    public sealed partial class GeographicViewName : gax::IResourceName, sys::IEquatable<GeographicViewName>
    {
        /// <summary>The possible contents of <see cref="GeographicViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>.
            /// </summary>
            CustomerCountryCriterionLocationType = 1,
        }

        private static gax::PathTemplate s_customerCountryCriterionLocationType = new gax::PathTemplate("customers/{customer_id}/geographicViews/{country_criterion_id_location_type}");

        /// <summary>Creates a <see cref="GeographicViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GeographicViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GeographicViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GeographicViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GeographicViewName"/> with the pattern
        /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="countryCriterionId">The <c>CountryCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationTypeId">The <c>LocationType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GeographicViewName"/> constructed from the provided ids.</returns>
        public static GeographicViewName FromCustomerCountryCriterionLocationType(string customerId, string countryCriterionId, string locationTypeId) =>
            new GeographicViewName(ResourceNameType.CustomerCountryCriterionLocationType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), countryCriterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(countryCriterionId, nameof(countryCriterionId)), locationTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationTypeId, nameof(locationTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GeographicViewName"/> with pattern
        /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="countryCriterionId">The <c>CountryCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationTypeId">The <c>LocationType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GeographicViewName"/> with pattern
        /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>.
        /// </returns>
        public static string Format(string customerId, string countryCriterionId, string locationTypeId) =>
            FormatCustomerCountryCriterionLocationType(customerId, countryCriterionId, locationTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GeographicViewName"/> with pattern
        /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="countryCriterionId">The <c>CountryCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationTypeId">The <c>LocationType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GeographicViewName"/> with pattern
        /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>.
        /// </returns>
        public static string FormatCustomerCountryCriterionLocationType(string customerId, string countryCriterionId, string locationTypeId) =>
            s_customerCountryCriterionLocationType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(countryCriterionId, nameof(countryCriterionId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(locationTypeId, nameof(locationTypeId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GeographicViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="geographicViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GeographicViewName"/> if successful.</returns>
        public static GeographicViewName Parse(string geographicViewName) => Parse(geographicViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GeographicViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="geographicViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GeographicViewName"/> if successful.</returns>
        public static GeographicViewName Parse(string geographicViewName, bool allowUnparsed) =>
            TryParse(geographicViewName, allowUnparsed, out GeographicViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GeographicViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="geographicViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GeographicViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string geographicViewName, out GeographicViewName result) =>
            TryParse(geographicViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GeographicViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="geographicViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GeographicViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string geographicViewName, bool allowUnparsed, out GeographicViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(geographicViewName, nameof(geographicViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCountryCriterionLocationType.TryParseName(geographicViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCountryCriterionLocationType(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(geographicViewName, out gax::UnparsedResourceName unparsedResourceName))
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

        private GeographicViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string countryCriterionId = null, string customerId = null, string locationTypeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CountryCriterionId = countryCriterionId;
            CustomerId = customerId;
            LocationTypeId = locationTypeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GeographicViewName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/geographicViews/{country_criterion_id}~{location_type}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="countryCriterionId">The <c>CountryCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationTypeId">The <c>LocationType</c> ID. Must not be <c>null</c> or empty.</param>
        public GeographicViewName(string customerId, string countryCriterionId, string locationTypeId) : this(ResourceNameType.CustomerCountryCriterionLocationType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), countryCriterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(countryCriterionId, nameof(countryCriterionId)), locationTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationTypeId, nameof(locationTypeId)))
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
        /// The <c>CountryCriterion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CountryCriterionId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>LocationType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LocationTypeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCountryCriterionLocationType: return s_customerCountryCriterionLocationType.Expand(CustomerId, $"{CountryCriterionId}~{LocationTypeId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GeographicViewName);

        /// <inheritdoc/>
        public bool Equals(GeographicViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(GeographicViewName a, GeographicViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(GeographicViewName a, GeographicViewName b) => !(a == b);
    }

    public partial class GeographicView
    {
        /// <summary>
        /// <see cref="GeographicViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal GeographicViewName ResourceNameAsGeographicViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : GeographicViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

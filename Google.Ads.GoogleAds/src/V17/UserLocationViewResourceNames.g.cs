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

namespace Google.Ads.GoogleAds.V17.Resources
{
    /// <summary>Resource name for the <c>UserLocationView</c> resource.</summary>
    public sealed partial class UserLocationViewName : gax::IResourceName, sys::IEquatable<UserLocationViewName>
    {
        /// <summary>The possible contents of <see cref="UserLocationViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>.
            /// </summary>
            CustomerCountryCriterionIsTargetingLocation = 1,
        }

        private static gax::PathTemplate s_customerCountryCriterionIsTargetingLocation = new gax::PathTemplate("customers/{customer_id}/userLocationViews/{country_criterion_id_is_targeting_location}");

        /// <summary>Creates a <see cref="UserLocationViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserLocationViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserLocationViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserLocationViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserLocationViewName"/> with the pattern
        /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="countryCriterionId">The <c>CountryCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="isTargetingLocationId">
        /// The <c>IsTargetingLocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="UserLocationViewName"/> constructed from the provided ids.</returns>
        public static UserLocationViewName FromCustomerCountryCriterionIsTargetingLocation(string customerId, string countryCriterionId, string isTargetingLocationId) =>
            new UserLocationViewName(ResourceNameType.CustomerCountryCriterionIsTargetingLocation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), countryCriterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(countryCriterionId, nameof(countryCriterionId)), isTargetingLocationId: gax::GaxPreconditions.CheckNotNullOrEmpty(isTargetingLocationId, nameof(isTargetingLocationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserLocationViewName"/> with pattern
        /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="countryCriterionId">The <c>CountryCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="isTargetingLocationId">
        /// The <c>IsTargetingLocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="UserLocationViewName"/> with pattern
        /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>.
        /// </returns>
        public static string Format(string customerId, string countryCriterionId, string isTargetingLocationId) =>
            FormatCustomerCountryCriterionIsTargetingLocation(customerId, countryCriterionId, isTargetingLocationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserLocationViewName"/> with pattern
        /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="countryCriterionId">The <c>CountryCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="isTargetingLocationId">
        /// The <c>IsTargetingLocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="UserLocationViewName"/> with pattern
        /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>.
        /// </returns>
        public static string FormatCustomerCountryCriterionIsTargetingLocation(string customerId, string countryCriterionId, string isTargetingLocationId) =>
            s_customerCountryCriterionIsTargetingLocation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(countryCriterionId, nameof(countryCriterionId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(isTargetingLocationId, nameof(isTargetingLocationId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserLocationViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userLocationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserLocationViewName"/> if successful.</returns>
        public static UserLocationViewName Parse(string userLocationViewName) => Parse(userLocationViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserLocationViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userLocationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserLocationViewName"/> if successful.</returns>
        public static UserLocationViewName Parse(string userLocationViewName, bool allowUnparsed) =>
            TryParse(userLocationViewName, allowUnparsed, out UserLocationViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserLocationViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userLocationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserLocationViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userLocationViewName, out UserLocationViewName result) =>
            TryParse(userLocationViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserLocationViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userLocationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserLocationViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userLocationViewName, bool allowUnparsed, out UserLocationViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(userLocationViewName, nameof(userLocationViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCountryCriterionIsTargetingLocation.TryParseName(userLocationViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCountryCriterionIsTargetingLocation(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userLocationViewName, out gax::UnparsedResourceName unparsedResourceName))
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

        private UserLocationViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string countryCriterionId = null, string customerId = null, string isTargetingLocationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CountryCriterionId = countryCriterionId;
            CustomerId = customerId;
            IsTargetingLocationId = isTargetingLocationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserLocationViewName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/userLocationViews/{country_criterion_id}~{is_targeting_location}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="countryCriterionId">The <c>CountryCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="isTargetingLocationId">
        /// The <c>IsTargetingLocation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public UserLocationViewName(string customerId, string countryCriterionId, string isTargetingLocationId) : this(ResourceNameType.CustomerCountryCriterionIsTargetingLocation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), countryCriterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(countryCriterionId, nameof(countryCriterionId)), isTargetingLocationId: gax::GaxPreconditions.CheckNotNullOrEmpty(isTargetingLocationId, nameof(isTargetingLocationId)))
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
        /// The <c>IsTargetingLocation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string IsTargetingLocationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCountryCriterionIsTargetingLocation: return s_customerCountryCriterionIsTargetingLocation.Expand(CustomerId, $"{CountryCriterionId}~{IsTargetingLocationId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserLocationViewName);

        /// <inheritdoc/>
        public bool Equals(UserLocationViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserLocationViewName a, UserLocationViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserLocationViewName a, UserLocationViewName b) => !(a == b);
    }

    public partial class UserLocationView
    {
        /// <summary>
        /// <see cref="UserLocationViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal UserLocationViewName ResourceNameAsUserLocationViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : UserLocationViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

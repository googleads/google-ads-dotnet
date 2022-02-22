// Copyright 2022 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V10.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V10.Resources
{
    /// <summary>Resource name for the <c>DetailedDemographic</c> resource.</summary>
    public sealed partial class DetailedDemographicName : gax::IResourceName, sys::IEquatable<DetailedDemographicName>
    {
        /// <summary>The possible contents of <see cref="DetailedDemographicName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c>
            /// .
            /// </summary>
            CustomerDetailedDemographic = 1,
        }

        private static gax::PathTemplate s_customerDetailedDemographic = new gax::PathTemplate("customers/{customer_id}/detailedDemographics/{detailed_demographic_id}");

        /// <summary>Creates a <see cref="DetailedDemographicName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DetailedDemographicName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DetailedDemographicName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DetailedDemographicName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DetailedDemographicName"/> with the pattern
        /// <c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="detailedDemographicId">
        /// The <c>DetailedDemographic</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="DetailedDemographicName"/> constructed from the provided ids.
        /// </returns>
        public static DetailedDemographicName FromCustomerDetailedDemographic(string customerId, string detailedDemographicId) =>
            new DetailedDemographicName(ResourceNameType.CustomerDetailedDemographic, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), detailedDemographicId: gax::GaxPreconditions.CheckNotNullOrEmpty(detailedDemographicId, nameof(detailedDemographicId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DetailedDemographicName"/> with pattern
        /// <c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="detailedDemographicId">
        /// The <c>DetailedDemographic</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DetailedDemographicName"/> with pattern
        /// <c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c>.
        /// </returns>
        public static string Format(string customerId, string detailedDemographicId) =>
            FormatCustomerDetailedDemographic(customerId, detailedDemographicId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DetailedDemographicName"/> with pattern
        /// <c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="detailedDemographicId">
        /// The <c>DetailedDemographic</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DetailedDemographicName"/> with pattern
        /// <c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c>.
        /// </returns>
        public static string FormatCustomerDetailedDemographic(string customerId, string detailedDemographicId) =>
            s_customerDetailedDemographic.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(detailedDemographicId, nameof(detailedDemographicId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DetailedDemographicName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="detailedDemographicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DetailedDemographicName"/> if successful.</returns>
        public static DetailedDemographicName Parse(string detailedDemographicName) => Parse(detailedDemographicName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DetailedDemographicName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="detailedDemographicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DetailedDemographicName"/> if successful.</returns>
        public static DetailedDemographicName Parse(string detailedDemographicName, bool allowUnparsed) =>
            TryParse(detailedDemographicName, allowUnparsed, out DetailedDemographicName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DetailedDemographicName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="detailedDemographicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DetailedDemographicName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string detailedDemographicName, out DetailedDemographicName result) =>
            TryParse(detailedDemographicName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DetailedDemographicName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="detailedDemographicName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DetailedDemographicName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string detailedDemographicName, bool allowUnparsed, out DetailedDemographicName result)
        {
            gax::GaxPreconditions.CheckNotNull(detailedDemographicName, nameof(detailedDemographicName));
            gax::TemplatedResourceName resourceName;
            if (s_customerDetailedDemographic.TryParseName(detailedDemographicName, out resourceName))
            {
                result = FromCustomerDetailedDemographic(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(detailedDemographicName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DetailedDemographicName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string detailedDemographicId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            DetailedDemographicId = detailedDemographicId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DetailedDemographicName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/detailedDemographics/{detailed_demographic_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="detailedDemographicId">
        /// The <c>DetailedDemographic</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DetailedDemographicName(string customerId, string detailedDemographicId) : this(ResourceNameType.CustomerDetailedDemographic, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), detailedDemographicId: gax::GaxPreconditions.CheckNotNullOrEmpty(detailedDemographicId, nameof(detailedDemographicId)))
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
        /// The <c>DetailedDemographic</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string DetailedDemographicId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerDetailedDemographic: return s_customerDetailedDemographic.Expand(CustomerId, DetailedDemographicId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DetailedDemographicName);

        /// <inheritdoc/>
        public bool Equals(DetailedDemographicName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DetailedDemographicName a, DetailedDemographicName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DetailedDemographicName a, DetailedDemographicName b) => !(a == b);
    }

    public partial class DetailedDemographic
    {
        /// <summary>
        /// <see cref="gagvr::DetailedDemographicName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal DetailedDemographicName ResourceNameAsDetailedDemographicName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::DetailedDemographicName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::DetailedDemographicName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal DetailedDemographicName DetailedDemographicName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::DetailedDemographicName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::DetailedDemographicName"/>-typed view over the <see cref="Parent"/> resource name
        /// property.
        /// </summary>
        internal DetailedDemographicName ParentAsDetailedDemographicName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagvr::DetailedDemographicName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}

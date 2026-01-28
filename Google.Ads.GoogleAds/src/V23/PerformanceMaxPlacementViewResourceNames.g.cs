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

namespace Google.Ads.GoogleAds.V23.Resources
{
    /// <summary>Resource name for the <c>PerformanceMaxPlacementView</c> resource.</summary>
    public sealed partial class PerformanceMaxPlacementViewName : gax::IResourceName, sys::IEquatable<PerformanceMaxPlacementViewName>
    {
        /// <summary>The possible contents of <see cref="PerformanceMaxPlacementViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c>
            /// .
            /// </summary>
            CustomerBase64Placement = 1,
        }

        private static gax::PathTemplate s_customerBase64Placement = new gax::PathTemplate("customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}");

        /// <summary>
        /// Creates a <see cref="PerformanceMaxPlacementViewName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="PerformanceMaxPlacementViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static PerformanceMaxPlacementViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new PerformanceMaxPlacementViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="PerformanceMaxPlacementViewName"/> with the pattern
        /// <c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64PlacementId">The <c>Base64Placement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="PerformanceMaxPlacementViewName"/> constructed from the provided ids.
        /// </returns>
        public static PerformanceMaxPlacementViewName FromCustomerBase64Placement(string customerId, string base64PlacementId) =>
            new PerformanceMaxPlacementViewName(ResourceNameType.CustomerBase64Placement, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), base64PlacementId: gax::GaxPreconditions.CheckNotNullOrEmpty(base64PlacementId, nameof(base64PlacementId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PerformanceMaxPlacementViewName"/> with
        /// pattern <c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64PlacementId">The <c>Base64Placement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PerformanceMaxPlacementViewName"/> with pattern
        /// <c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c>.
        /// </returns>
        public static string Format(string customerId, string base64PlacementId) =>
            FormatCustomerBase64Placement(customerId, base64PlacementId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="PerformanceMaxPlacementViewName"/> with
        /// pattern <c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64PlacementId">The <c>Base64Placement</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="PerformanceMaxPlacementViewName"/> with pattern
        /// <c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c>.
        /// </returns>
        public static string FormatCustomerBase64Placement(string customerId, string base64PlacementId) =>
            s_customerBase64Placement.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(base64PlacementId, nameof(base64PlacementId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PerformanceMaxPlacementViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="performanceMaxPlacementViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="PerformanceMaxPlacementViewName"/> if successful.</returns>
        public static PerformanceMaxPlacementViewName Parse(string performanceMaxPlacementViewName) =>
            Parse(performanceMaxPlacementViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="PerformanceMaxPlacementViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="performanceMaxPlacementViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="PerformanceMaxPlacementViewName"/> if successful.</returns>
        public static PerformanceMaxPlacementViewName Parse(string performanceMaxPlacementViewName, bool allowUnparsed) =>
            TryParse(performanceMaxPlacementViewName, allowUnparsed, out PerformanceMaxPlacementViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PerformanceMaxPlacementViewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="performanceMaxPlacementViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PerformanceMaxPlacementViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string performanceMaxPlacementViewName, out PerformanceMaxPlacementViewName result) =>
            TryParse(performanceMaxPlacementViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="PerformanceMaxPlacementViewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="performanceMaxPlacementViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="PerformanceMaxPlacementViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string performanceMaxPlacementViewName, bool allowUnparsed, out PerformanceMaxPlacementViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(performanceMaxPlacementViewName, nameof(performanceMaxPlacementViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerBase64Placement.TryParseName(performanceMaxPlacementViewName, out resourceName))
            {
                result = FromCustomerBase64Placement(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(performanceMaxPlacementViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private PerformanceMaxPlacementViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string base64PlacementId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            Base64PlacementId = base64PlacementId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="PerformanceMaxPlacementViewName"/> class from the component parts
        /// of pattern <c>customers/{customer_id}/performanceMaxPlacementViews/{base_64_placement}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="base64PlacementId">The <c>Base64Placement</c> ID. Must not be <c>null</c> or empty.</param>
        public PerformanceMaxPlacementViewName(string customerId, string base64PlacementId) : this(ResourceNameType.CustomerBase64Placement, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), base64PlacementId: gax::GaxPreconditions.CheckNotNullOrEmpty(base64PlacementId, nameof(base64PlacementId)))
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
        /// The <c>Base64Placement</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string Base64PlacementId { get; }

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
                case ResourceNameType.CustomerBase64Placement: return s_customerBase64Placement.Expand(CustomerId, Base64PlacementId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as PerformanceMaxPlacementViewName);

        /// <inheritdoc/>
        public bool Equals(PerformanceMaxPlacementViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(PerformanceMaxPlacementViewName a, PerformanceMaxPlacementViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(PerformanceMaxPlacementViewName a, PerformanceMaxPlacementViewName b) => !(a == b);
    }

    public partial class PerformanceMaxPlacementView
    {
        /// <summary>
        /// <see cref="PerformanceMaxPlacementViewName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal PerformanceMaxPlacementViewName ResourceNameAsPerformanceMaxPlacementViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : PerformanceMaxPlacementViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

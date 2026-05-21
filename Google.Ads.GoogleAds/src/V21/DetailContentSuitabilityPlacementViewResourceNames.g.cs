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

namespace Google.Ads.GoogleAds.V21.Resources
{
    /// <summary>Resource name for the <c>DetailContentSuitabilityPlacementView</c> resource.</summary>
    public sealed partial class DetailContentSuitabilityPlacementViewName : gax::IResourceName, sys::IEquatable<DetailContentSuitabilityPlacementViewName>
    {
        /// <summary>The possible contents of <see cref="DetailContentSuitabilityPlacementViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>.
            /// </summary>
            CustomerPlacementFingerprint = 1,
        }

        private static gax::PathTemplate s_customerPlacementFingerprint = new gax::PathTemplate("customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}");

        /// <summary>
        /// Creates a <see cref="DetailContentSuitabilityPlacementViewName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DetailContentSuitabilityPlacementViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DetailContentSuitabilityPlacementViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DetailContentSuitabilityPlacementViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DetailContentSuitabilityPlacementViewName"/> with the pattern
        /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="placementFingerprintId">
        /// The <c>PlacementFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="DetailContentSuitabilityPlacementViewName"/> constructed from the provided ids.
        /// </returns>
        public static DetailContentSuitabilityPlacementViewName FromCustomerPlacementFingerprint(string customerId, string placementFingerprintId) =>
            new DetailContentSuitabilityPlacementViewName(ResourceNameType.CustomerPlacementFingerprint, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), placementFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(placementFingerprintId, nameof(placementFingerprintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="DetailContentSuitabilityPlacementViewName"/> with pattern
        /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="placementFingerprintId">
        /// The <c>PlacementFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DetailContentSuitabilityPlacementViewName"/> with pattern
        /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>.
        /// </returns>
        public static string Format(string customerId, string placementFingerprintId) =>
            FormatCustomerPlacementFingerprint(customerId, placementFingerprintId);

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="DetailContentSuitabilityPlacementViewName"/> with pattern
        /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="placementFingerprintId">
        /// The <c>PlacementFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="DetailContentSuitabilityPlacementViewName"/> with pattern
        /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>.
        /// </returns>
        public static string FormatCustomerPlacementFingerprint(string customerId, string placementFingerprintId) =>
            s_customerPlacementFingerprint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(placementFingerprintId, nameof(placementFingerprintId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DetailContentSuitabilityPlacementViewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="detailContentSuitabilityPlacementViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="DetailContentSuitabilityPlacementViewName"/> if successful.</returns>
        public static DetailContentSuitabilityPlacementViewName Parse(string detailContentSuitabilityPlacementViewName) =>
            Parse(detailContentSuitabilityPlacementViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DetailContentSuitabilityPlacementViewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="detailContentSuitabilityPlacementViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DetailContentSuitabilityPlacementViewName"/> if successful.</returns>
        public static DetailContentSuitabilityPlacementViewName Parse(string detailContentSuitabilityPlacementViewName, bool allowUnparsed) =>
            TryParse(detailContentSuitabilityPlacementViewName, allowUnparsed, out DetailContentSuitabilityPlacementViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="DetailContentSuitabilityPlacementViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="detailContentSuitabilityPlacementViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DetailContentSuitabilityPlacementViewName"/>, or <c>null</c>
        /// if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string detailContentSuitabilityPlacementViewName, out DetailContentSuitabilityPlacementViewName result) =>
            TryParse(detailContentSuitabilityPlacementViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="DetailContentSuitabilityPlacementViewName"/> instance; optionally allowing an unparseable
        /// resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="detailContentSuitabilityPlacementViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DetailContentSuitabilityPlacementViewName"/>, or <c>null</c>
        /// if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string detailContentSuitabilityPlacementViewName, bool allowUnparsed, out DetailContentSuitabilityPlacementViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(detailContentSuitabilityPlacementViewName, nameof(detailContentSuitabilityPlacementViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerPlacementFingerprint.TryParseName(detailContentSuitabilityPlacementViewName, out resourceName))
            {
                result = FromCustomerPlacementFingerprint(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(detailContentSuitabilityPlacementViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DetailContentSuitabilityPlacementViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string placementFingerprintId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            PlacementFingerprintId = placementFingerprintId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DetailContentSuitabilityPlacementViewName"/> class from the
        /// component parts of pattern
        /// <c>customers/{customer_id}/detailContentSuitabilityPlacementViews/{placement_fingerprint}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="placementFingerprintId">
        /// The <c>PlacementFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public DetailContentSuitabilityPlacementViewName(string customerId, string placementFingerprintId) : this(ResourceNameType.CustomerPlacementFingerprint, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), placementFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(placementFingerprintId, nameof(placementFingerprintId)))
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
        /// The <c>PlacementFingerprint</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string PlacementFingerprintId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerPlacementFingerprint: return s_customerPlacementFingerprint.Expand(CustomerId, PlacementFingerprintId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DetailContentSuitabilityPlacementViewName);

        /// <inheritdoc/>
        public bool Equals(DetailContentSuitabilityPlacementViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DetailContentSuitabilityPlacementViewName a, DetailContentSuitabilityPlacementViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DetailContentSuitabilityPlacementViewName a, DetailContentSuitabilityPlacementViewName b) => !(a == b);
    }

    public partial class DetailContentSuitabilityPlacementView
    {
        /// <summary>
        /// <see cref="DetailContentSuitabilityPlacementViewName"/>-typed view over the <see cref="ResourceName"/>
        /// resource name property.
        /// </summary>
        internal DetailContentSuitabilityPlacementViewName ResourceNameAsDetailContentSuitabilityPlacementViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : DetailContentSuitabilityPlacementViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

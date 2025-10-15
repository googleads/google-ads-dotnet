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
    /// <summary>Resource name for the <c>ExpandedLandingPageView</c> resource.</summary>
    public sealed partial class ExpandedLandingPageViewName : gax::IResourceName, sys::IEquatable<ExpandedLandingPageViewName>
    {
        /// <summary>The possible contents of <see cref="ExpandedLandingPageViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>.
            /// </summary>
            CustomerExpandedFinalUrlFingerprint = 1,
        }

        private static gax::PathTemplate s_customerExpandedFinalUrlFingerprint = new gax::PathTemplate("customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}");

        /// <summary>Creates a <see cref="ExpandedLandingPageViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExpandedLandingPageViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExpandedLandingPageViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExpandedLandingPageViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExpandedLandingPageViewName"/> with the pattern
        /// <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="expandedFinalUrlFingerprintId">
        /// The <c>ExpandedFinalUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ExpandedLandingPageViewName"/> constructed from the provided ids.
        /// </returns>
        public static ExpandedLandingPageViewName FromCustomerExpandedFinalUrlFingerprint(string customerId, string expandedFinalUrlFingerprintId) =>
            new ExpandedLandingPageViewName(ResourceNameType.CustomerExpandedFinalUrlFingerprint, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), expandedFinalUrlFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(expandedFinalUrlFingerprintId, nameof(expandedFinalUrlFingerprintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExpandedLandingPageViewName"/> with
        /// pattern <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="expandedFinalUrlFingerprintId">
        /// The <c>ExpandedFinalUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ExpandedLandingPageViewName"/> with pattern
        /// <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>.
        /// </returns>
        public static string Format(string customerId, string expandedFinalUrlFingerprintId) =>
            FormatCustomerExpandedFinalUrlFingerprint(customerId, expandedFinalUrlFingerprintId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExpandedLandingPageViewName"/> with
        /// pattern <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="expandedFinalUrlFingerprintId">
        /// The <c>ExpandedFinalUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ExpandedLandingPageViewName"/> with pattern
        /// <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>.
        /// </returns>
        public static string FormatCustomerExpandedFinalUrlFingerprint(string customerId, string expandedFinalUrlFingerprintId) =>
            s_customerExpandedFinalUrlFingerprint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(expandedFinalUrlFingerprintId, nameof(expandedFinalUrlFingerprintId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExpandedLandingPageViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="expandedLandingPageViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExpandedLandingPageViewName"/> if successful.</returns>
        public static ExpandedLandingPageViewName Parse(string expandedLandingPageViewName) =>
            Parse(expandedLandingPageViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExpandedLandingPageViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="expandedLandingPageViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExpandedLandingPageViewName"/> if successful.</returns>
        public static ExpandedLandingPageViewName Parse(string expandedLandingPageViewName, bool allowUnparsed) =>
            TryParse(expandedLandingPageViewName, allowUnparsed, out ExpandedLandingPageViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExpandedLandingPageViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="expandedLandingPageViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExpandedLandingPageViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string expandedLandingPageViewName, out ExpandedLandingPageViewName result) =>
            TryParse(expandedLandingPageViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExpandedLandingPageViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="expandedLandingPageViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExpandedLandingPageViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string expandedLandingPageViewName, bool allowUnparsed, out ExpandedLandingPageViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(expandedLandingPageViewName, nameof(expandedLandingPageViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerExpandedFinalUrlFingerprint.TryParseName(expandedLandingPageViewName, out resourceName))
            {
                result = FromCustomerExpandedFinalUrlFingerprint(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(expandedLandingPageViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ExpandedLandingPageViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string expandedFinalUrlFingerprintId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            ExpandedFinalUrlFingerprintId = expandedFinalUrlFingerprintId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExpandedLandingPageViewName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/expandedLandingPageViews/{expanded_final_url_fingerprint}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="expandedFinalUrlFingerprintId">
        /// The <c>ExpandedFinalUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ExpandedLandingPageViewName(string customerId, string expandedFinalUrlFingerprintId) : this(ResourceNameType.CustomerExpandedFinalUrlFingerprint, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), expandedFinalUrlFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(expandedFinalUrlFingerprintId, nameof(expandedFinalUrlFingerprintId)))
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
        /// The <c>ExpandedFinalUrlFingerprint</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string ExpandedFinalUrlFingerprintId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerExpandedFinalUrlFingerprint: return s_customerExpandedFinalUrlFingerprint.Expand(CustomerId, ExpandedFinalUrlFingerprintId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExpandedLandingPageViewName);

        /// <inheritdoc/>
        public bool Equals(ExpandedLandingPageViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ExpandedLandingPageViewName a, ExpandedLandingPageViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ExpandedLandingPageViewName a, ExpandedLandingPageViewName b) => !(a == b);
    }

    public partial class ExpandedLandingPageView
    {
        /// <summary>
        /// <see cref="ExpandedLandingPageViewName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal ExpandedLandingPageViewName ResourceNameAsExpandedLandingPageViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ExpandedLandingPageViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

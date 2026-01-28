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
    /// <summary>Resource name for the <c>LandingPageView</c> resource.</summary>
    public sealed partial class LandingPageViewName : gax::IResourceName, sys::IEquatable<LandingPageViewName>
    {
        /// <summary>The possible contents of <see cref="LandingPageViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>.
            /// </summary>
            CustomerUnexpandedFinalUrlFingerprint = 1,
        }

        private static gax::PathTemplate s_customerUnexpandedFinalUrlFingerprint = new gax::PathTemplate("customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}");

        /// <summary>Creates a <see cref="LandingPageViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LandingPageViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LandingPageViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LandingPageViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LandingPageViewName"/> with the pattern
        /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unexpandedFinalUrlFingerprintId">
        /// The <c>UnexpandedFinalUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="LandingPageViewName"/> constructed from the provided ids.</returns>
        public static LandingPageViewName FromCustomerUnexpandedFinalUrlFingerprint(string customerId, string unexpandedFinalUrlFingerprintId) =>
            new LandingPageViewName(ResourceNameType.CustomerUnexpandedFinalUrlFingerprint, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), unexpandedFinalUrlFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(unexpandedFinalUrlFingerprintId, nameof(unexpandedFinalUrlFingerprintId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LandingPageViewName"/> with pattern
        /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unexpandedFinalUrlFingerprintId">
        /// The <c>UnexpandedFinalUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="LandingPageViewName"/> with pattern
        /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>.
        /// </returns>
        public static string Format(string customerId, string unexpandedFinalUrlFingerprintId) =>
            FormatCustomerUnexpandedFinalUrlFingerprint(customerId, unexpandedFinalUrlFingerprintId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LandingPageViewName"/> with pattern
        /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unexpandedFinalUrlFingerprintId">
        /// The <c>UnexpandedFinalUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="LandingPageViewName"/> with pattern
        /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>.
        /// </returns>
        public static string FormatCustomerUnexpandedFinalUrlFingerprint(string customerId, string unexpandedFinalUrlFingerprintId) =>
            s_customerUnexpandedFinalUrlFingerprint.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(unexpandedFinalUrlFingerprintId, nameof(unexpandedFinalUrlFingerprintId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LandingPageViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="landingPageViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LandingPageViewName"/> if successful.</returns>
        public static LandingPageViewName Parse(string landingPageViewName) => Parse(landingPageViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LandingPageViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="landingPageViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LandingPageViewName"/> if successful.</returns>
        public static LandingPageViewName Parse(string landingPageViewName, bool allowUnparsed) =>
            TryParse(landingPageViewName, allowUnparsed, out LandingPageViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LandingPageViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="landingPageViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LandingPageViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string landingPageViewName, out LandingPageViewName result) =>
            TryParse(landingPageViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LandingPageViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="landingPageViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LandingPageViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string landingPageViewName, bool allowUnparsed, out LandingPageViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(landingPageViewName, nameof(landingPageViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerUnexpandedFinalUrlFingerprint.TryParseName(landingPageViewName, out resourceName))
            {
                result = FromCustomerUnexpandedFinalUrlFingerprint(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(landingPageViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LandingPageViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string unexpandedFinalUrlFingerprintId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            UnexpandedFinalUrlFingerprintId = unexpandedFinalUrlFingerprintId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LandingPageViewName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/landingPageViews/{unexpanded_final_url_fingerprint}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="unexpandedFinalUrlFingerprintId">
        /// The <c>UnexpandedFinalUrlFingerprint</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public LandingPageViewName(string customerId, string unexpandedFinalUrlFingerprintId) : this(ResourceNameType.CustomerUnexpandedFinalUrlFingerprint, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), unexpandedFinalUrlFingerprintId: gax::GaxPreconditions.CheckNotNullOrEmpty(unexpandedFinalUrlFingerprintId, nameof(unexpandedFinalUrlFingerprintId)))
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
        /// The <c>UnexpandedFinalUrlFingerprint</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string UnexpandedFinalUrlFingerprintId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerUnexpandedFinalUrlFingerprint: return s_customerUnexpandedFinalUrlFingerprint.Expand(CustomerId, UnexpandedFinalUrlFingerprintId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LandingPageViewName);

        /// <inheritdoc/>
        public bool Equals(LandingPageViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(LandingPageViewName a, LandingPageViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(LandingPageViewName a, LandingPageViewName b) => !(a == b);
    }

    public partial class LandingPageView
    {
        /// <summary>
        /// <see cref="LandingPageViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal LandingPageViewName ResourceNameAsLandingPageViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : LandingPageViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

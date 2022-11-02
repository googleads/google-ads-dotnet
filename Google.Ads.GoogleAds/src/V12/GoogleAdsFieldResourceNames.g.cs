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

#pragma warning disable CS8981
using gagvr = Google.Ads.GoogleAds.V12.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V12.Resources
{
    /// <summary>Resource name for the <c>GoogleAdsField</c> resource.</summary>
    public sealed partial class GoogleAdsFieldName : gax::IResourceName, sys::IEquatable<GoogleAdsFieldName>
    {
        /// <summary>The possible contents of <see cref="GoogleAdsFieldName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>googleAdsFields/{google_ads_field}</c>.</summary>
            GoogleAdsField = 1,
        }

        private static gax::PathTemplate s_googleAdsField = new gax::PathTemplate("googleAdsFields/{google_ads_field}");

        /// <summary>Creates a <see cref="GoogleAdsFieldName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="GoogleAdsFieldName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static GoogleAdsFieldName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new GoogleAdsFieldName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="GoogleAdsFieldName"/> with the pattern <c>googleAdsFields/{google_ads_field}</c>.
        /// </summary>
        /// <param name="googleAdsFieldId">The <c>GoogleAdsField</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="GoogleAdsFieldName"/> constructed from the provided ids.</returns>
        public static GoogleAdsFieldName FromGoogleAdsField(string googleAdsFieldId) =>
            new GoogleAdsFieldName(ResourceNameType.GoogleAdsField, googleAdsFieldId: gax::GaxPreconditions.CheckNotNullOrEmpty(googleAdsFieldId, nameof(googleAdsFieldId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoogleAdsFieldName"/> with pattern
        /// <c>googleAdsFields/{google_ads_field}</c>.
        /// </summary>
        /// <param name="googleAdsFieldId">The <c>GoogleAdsField</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GoogleAdsFieldName"/> with pattern
        /// <c>googleAdsFields/{google_ads_field}</c>.
        /// </returns>
        public static string Format(string googleAdsFieldId) => FormatGoogleAdsField(googleAdsFieldId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="GoogleAdsFieldName"/> with pattern
        /// <c>googleAdsFields/{google_ads_field}</c>.
        /// </summary>
        /// <param name="googleAdsFieldId">The <c>GoogleAdsField</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="GoogleAdsFieldName"/> with pattern
        /// <c>googleAdsFields/{google_ads_field}</c>.
        /// </returns>
        public static string FormatGoogleAdsField(string googleAdsFieldId) =>
            s_googleAdsField.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(googleAdsFieldId, nameof(googleAdsFieldId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoogleAdsFieldName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>googleAdsFields/{google_ads_field}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="googleAdsFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="GoogleAdsFieldName"/> if successful.</returns>
        public static GoogleAdsFieldName Parse(string googleAdsFieldName) => Parse(googleAdsFieldName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="GoogleAdsFieldName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>googleAdsFields/{google_ads_field}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="googleAdsFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="GoogleAdsFieldName"/> if successful.</returns>
        public static GoogleAdsFieldName Parse(string googleAdsFieldName, bool allowUnparsed) =>
            TryParse(googleAdsFieldName, allowUnparsed, out GoogleAdsFieldName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoogleAdsFieldName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>googleAdsFields/{google_ads_field}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="googleAdsFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoogleAdsFieldName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string googleAdsFieldName, out GoogleAdsFieldName result) =>
            TryParse(googleAdsFieldName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="GoogleAdsFieldName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>googleAdsFields/{google_ads_field}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="googleAdsFieldName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="GoogleAdsFieldName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string googleAdsFieldName, bool allowUnparsed, out GoogleAdsFieldName result)
        {
            gax::GaxPreconditions.CheckNotNull(googleAdsFieldName, nameof(googleAdsFieldName));
            gax::TemplatedResourceName resourceName;
            if (s_googleAdsField.TryParseName(googleAdsFieldName, out resourceName))
            {
                result = FromGoogleAdsField(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(googleAdsFieldName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private GoogleAdsFieldName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string googleAdsFieldId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            GoogleAdsFieldId = googleAdsFieldId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="GoogleAdsFieldName"/> class from the component parts of pattern
        /// <c>googleAdsFields/{google_ads_field}</c>
        /// </summary>
        /// <param name="googleAdsFieldId">The <c>GoogleAdsField</c> ID. Must not be <c>null</c> or empty.</param>
        public GoogleAdsFieldName(string googleAdsFieldId) : this(ResourceNameType.GoogleAdsField, googleAdsFieldId: gax::GaxPreconditions.CheckNotNullOrEmpty(googleAdsFieldId, nameof(googleAdsFieldId)))
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
        /// The <c>GoogleAdsField</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string GoogleAdsFieldId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.GoogleAdsField: return s_googleAdsField.Expand(GoogleAdsFieldId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as GoogleAdsFieldName);

        /// <inheritdoc/>
        public bool Equals(GoogleAdsFieldName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(GoogleAdsFieldName a, GoogleAdsFieldName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(GoogleAdsFieldName a, GoogleAdsFieldName b) => !(a == b);
    }

    public partial class GoogleAdsField
    {
        /// <summary>
        /// <see cref="gagvr::GoogleAdsFieldName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::GoogleAdsFieldName ResourceNameAsGoogleAdsFieldName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::GoogleAdsFieldName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::GoogleAdsFieldName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::GoogleAdsFieldName GoogleAdsFieldName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::GoogleAdsFieldName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

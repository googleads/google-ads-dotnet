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
    /// <summary>Resource name for the <c>MediaFile</c> resource.</summary>
    public sealed partial class MediaFileName : gax::IResourceName, sys::IEquatable<MediaFileName>
    {
        /// <summary>The possible contents of <see cref="MediaFileName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/mediaFiles/{media_file_id}</c>.
            /// </summary>
            CustomerMediaFile = 1,
        }

        private static gax::PathTemplate s_customerMediaFile = new gax::PathTemplate("customers/{customer_id}/mediaFiles/{media_file_id}");

        /// <summary>Creates a <see cref="MediaFileName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MediaFileName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MediaFileName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MediaFileName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MediaFileName"/> with the pattern <c>customers/{customer_id}/mediaFiles/{media_file_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mediaFileId">The <c>MediaFile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MediaFileName"/> constructed from the provided ids.</returns>
        public static MediaFileName FromCustomerMediaFile(string customerId, string mediaFileId) =>
            new MediaFileName(ResourceNameType.CustomerMediaFile, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), mediaFileId: gax::GaxPreconditions.CheckNotNullOrEmpty(mediaFileId, nameof(mediaFileId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MediaFileName"/> with pattern
        /// <c>customers/{customer_id}/mediaFiles/{media_file_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mediaFileId">The <c>MediaFile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MediaFileName"/> with pattern
        /// <c>customers/{customer_id}/mediaFiles/{media_file_id}</c>.
        /// </returns>
        public static string Format(string customerId, string mediaFileId) => FormatCustomerMediaFile(customerId, mediaFileId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MediaFileName"/> with pattern
        /// <c>customers/{customer_id}/mediaFiles/{media_file_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mediaFileId">The <c>MediaFile</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MediaFileName"/> with pattern
        /// <c>customers/{customer_id}/mediaFiles/{media_file_id}</c>.
        /// </returns>
        public static string FormatCustomerMediaFile(string customerId, string mediaFileId) =>
            s_customerMediaFile.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mediaFileId, nameof(mediaFileId)));

        /// <summary>Parses the given resource name string into a new <see cref="MediaFileName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/mediaFiles/{media_file_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="mediaFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MediaFileName"/> if successful.</returns>
        public static MediaFileName Parse(string mediaFileName) => Parse(mediaFileName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MediaFileName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/mediaFiles/{media_file_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mediaFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MediaFileName"/> if successful.</returns>
        public static MediaFileName Parse(string mediaFileName, bool allowUnparsed) =>
            TryParse(mediaFileName, allowUnparsed, out MediaFileName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MediaFileName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/mediaFiles/{media_file_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="mediaFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MediaFileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mediaFileName, out MediaFileName result) => TryParse(mediaFileName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MediaFileName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/mediaFiles/{media_file_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mediaFileName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MediaFileName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mediaFileName, bool allowUnparsed, out MediaFileName result)
        {
            gax::GaxPreconditions.CheckNotNull(mediaFileName, nameof(mediaFileName));
            gax::TemplatedResourceName resourceName;
            if (s_customerMediaFile.TryParseName(mediaFileName, out resourceName))
            {
                result = FromCustomerMediaFile(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mediaFileName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MediaFileName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string mediaFileId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            MediaFileId = mediaFileId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MediaFileName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/mediaFiles/{media_file_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mediaFileId">The <c>MediaFile</c> ID. Must not be <c>null</c> or empty.</param>
        public MediaFileName(string customerId, string mediaFileId) : this(ResourceNameType.CustomerMediaFile, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), mediaFileId: gax::GaxPreconditions.CheckNotNullOrEmpty(mediaFileId, nameof(mediaFileId)))
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
        /// The <c>MediaFile</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MediaFileId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerMediaFile: return s_customerMediaFile.Expand(CustomerId, MediaFileId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MediaFileName);

        /// <inheritdoc/>
        public bool Equals(MediaFileName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MediaFileName a, MediaFileName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MediaFileName a, MediaFileName b) => !(a == b);
    }

    public partial class MediaFile
    {
        /// <summary>
        /// <see cref="gagvr::MediaFileName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal gagvr::MediaFileName ResourceNameAsMediaFileName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::MediaFileName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::MediaFileName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::MediaFileName MediaFileName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::MediaFileName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

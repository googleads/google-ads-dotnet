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
    /// <summary>Resource name for the <c>YouTubeVideoUpload</c> resource.</summary>
    public sealed partial class YouTubeVideoUploadName : gax::IResourceName, sys::IEquatable<YouTubeVideoUploadName>
    {
        /// <summary>The possible contents of <see cref="YouTubeVideoUploadName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c>.
            /// </summary>
            CustomerVideoUpload = 1,
        }

        private static gax::PathTemplate s_customerVideoUpload = new gax::PathTemplate("customers/{customer_id}/youTubeVideoUploads/{video_upload_id}");

        /// <summary>Creates a <see cref="YouTubeVideoUploadName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="YouTubeVideoUploadName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static YouTubeVideoUploadName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new YouTubeVideoUploadName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="YouTubeVideoUploadName"/> with the pattern
        /// <c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="videoUploadId">The <c>VideoUpload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="YouTubeVideoUploadName"/> constructed from the provided ids.</returns>
        public static YouTubeVideoUploadName FromCustomerVideoUpload(string customerId, string videoUploadId) =>
            new YouTubeVideoUploadName(ResourceNameType.CustomerVideoUpload, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), videoUploadId: gax::GaxPreconditions.CheckNotNullOrEmpty(videoUploadId, nameof(videoUploadId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="YouTubeVideoUploadName"/> with pattern
        /// <c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="videoUploadId">The <c>VideoUpload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="YouTubeVideoUploadName"/> with pattern
        /// <c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c>.
        /// </returns>
        public static string Format(string customerId, string videoUploadId) =>
            FormatCustomerVideoUpload(customerId, videoUploadId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="YouTubeVideoUploadName"/> with pattern
        /// <c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="videoUploadId">The <c>VideoUpload</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="YouTubeVideoUploadName"/> with pattern
        /// <c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c>.
        /// </returns>
        public static string FormatCustomerVideoUpload(string customerId, string videoUploadId) =>
            s_customerVideoUpload.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(videoUploadId, nameof(videoUploadId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="YouTubeVideoUploadName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="youTubeVideoUploadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="YouTubeVideoUploadName"/> if successful.</returns>
        public static YouTubeVideoUploadName Parse(string youTubeVideoUploadName) => Parse(youTubeVideoUploadName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="YouTubeVideoUploadName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="youTubeVideoUploadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="YouTubeVideoUploadName"/> if successful.</returns>
        public static YouTubeVideoUploadName Parse(string youTubeVideoUploadName, bool allowUnparsed) =>
            TryParse(youTubeVideoUploadName, allowUnparsed, out YouTubeVideoUploadName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="YouTubeVideoUploadName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="youTubeVideoUploadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="YouTubeVideoUploadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string youTubeVideoUploadName, out YouTubeVideoUploadName result) =>
            TryParse(youTubeVideoUploadName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="YouTubeVideoUploadName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="youTubeVideoUploadName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="YouTubeVideoUploadName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string youTubeVideoUploadName, bool allowUnparsed, out YouTubeVideoUploadName result)
        {
            gax::GaxPreconditions.CheckNotNull(youTubeVideoUploadName, nameof(youTubeVideoUploadName));
            gax::TemplatedResourceName resourceName;
            if (s_customerVideoUpload.TryParseName(youTubeVideoUploadName, out resourceName))
            {
                result = FromCustomerVideoUpload(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(youTubeVideoUploadName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private YouTubeVideoUploadName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string videoUploadId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            VideoUploadId = videoUploadId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="YouTubeVideoUploadName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/youTubeVideoUploads/{video_upload_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="videoUploadId">The <c>VideoUpload</c> ID. Must not be <c>null</c> or empty.</param>
        public YouTubeVideoUploadName(string customerId, string videoUploadId) : this(ResourceNameType.CustomerVideoUpload, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), videoUploadId: gax::GaxPreconditions.CheckNotNullOrEmpty(videoUploadId, nameof(videoUploadId)))
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
        /// The <c>VideoUpload</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VideoUploadId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerVideoUpload: return s_customerVideoUpload.Expand(CustomerId, VideoUploadId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as YouTubeVideoUploadName);

        /// <inheritdoc/>
        public bool Equals(YouTubeVideoUploadName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(YouTubeVideoUploadName a, YouTubeVideoUploadName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(YouTubeVideoUploadName a, YouTubeVideoUploadName b) => !(a == b);
    }

    public partial class YouTubeVideoUpload
    {
        /// <summary>
        /// <see cref="YouTubeVideoUploadName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal YouTubeVideoUploadName ResourceNameAsYouTubeVideoUploadName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : YouTubeVideoUploadName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

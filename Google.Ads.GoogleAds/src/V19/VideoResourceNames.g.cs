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

namespace Google.Ads.GoogleAds.V19.Resources
{
    /// <summary>Resource name for the <c>Video</c> resource.</summary>
    public sealed partial class VideoName : gax::IResourceName, sys::IEquatable<VideoName>
    {
        /// <summary>The possible contents of <see cref="VideoName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/videos/{video_id}</c>.</summary>
            CustomerVideo = 1,
        }

        private static gax::PathTemplate s_customerVideo = new gax::PathTemplate("customers/{customer_id}/videos/{video_id}");

        /// <summary>Creates a <see cref="VideoName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="VideoName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static VideoName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new VideoName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="VideoName"/> with the pattern <c>customers/{customer_id}/videos/{video_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="videoId">The <c>Video</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="VideoName"/> constructed from the provided ids.</returns>
        public static VideoName FromCustomerVideo(string customerId, string videoId) =>
            new VideoName(ResourceNameType.CustomerVideo, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), videoId: gax::GaxPreconditions.CheckNotNullOrEmpty(videoId, nameof(videoId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VideoName"/> with pattern
        /// <c>customers/{customer_id}/videos/{video_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="videoId">The <c>Video</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VideoName"/> with pattern
        /// <c>customers/{customer_id}/videos/{video_id}</c>.
        /// </returns>
        public static string Format(string customerId, string videoId) => FormatCustomerVideo(customerId, videoId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="VideoName"/> with pattern
        /// <c>customers/{customer_id}/videos/{video_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="videoId">The <c>Video</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="VideoName"/> with pattern
        /// <c>customers/{customer_id}/videos/{video_id}</c>.
        /// </returns>
        public static string FormatCustomerVideo(string customerId, string videoId) =>
            s_customerVideo.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(videoId, nameof(videoId)));

        /// <summary>Parses the given resource name string into a new <see cref="VideoName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/videos/{video_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="videoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="VideoName"/> if successful.</returns>
        public static VideoName Parse(string videoName) => Parse(videoName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="VideoName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/videos/{video_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="videoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="VideoName"/> if successful.</returns>
        public static VideoName Parse(string videoName, bool allowUnparsed) =>
            TryParse(videoName, allowUnparsed, out VideoName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VideoName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/videos/{video_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="videoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VideoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string videoName, out VideoName result) => TryParse(videoName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="VideoName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/videos/{video_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="videoName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="VideoName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string videoName, bool allowUnparsed, out VideoName result)
        {
            gax::GaxPreconditions.CheckNotNull(videoName, nameof(videoName));
            gax::TemplatedResourceName resourceName;
            if (s_customerVideo.TryParseName(videoName, out resourceName))
            {
                result = FromCustomerVideo(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(videoName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private VideoName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string videoId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            VideoId = videoId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="VideoName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/videos/{video_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="videoId">The <c>Video</c> ID. Must not be <c>null</c> or empty.</param>
        public VideoName(string customerId, string videoId) : this(ResourceNameType.CustomerVideo, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), videoId: gax::GaxPreconditions.CheckNotNullOrEmpty(videoId, nameof(videoId)))
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
        /// The <c>Video</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string VideoId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerVideo: return s_customerVideo.Expand(CustomerId, VideoId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as VideoName);

        /// <inheritdoc/>
        public bool Equals(VideoName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(VideoName a, VideoName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(VideoName a, VideoName b) => !(a == b);
    }

    public partial class Video
    {
        /// <summary>
        /// <see cref="VideoName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal VideoName ResourceNameAsVideoName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : VideoName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

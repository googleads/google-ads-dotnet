// Copyright 2020 Google LLC
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

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V1.Resources
{
    /// <summary>Resource name for the <c>TopicConstant</c> resource.</summary>
    public sealed partial class TopicConstantName : gax::IResourceName, sys::IEquatable<TopicConstantName>
    {
        /// <summary>The possible contents of <see cref="TopicConstantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>topicConstants/{topic_constant}</c>.</summary>
            TopicConstant = 1
        }

        private static gax::PathTemplate s_topicConstant = new gax::PathTemplate("topicConstants/{topic_constant}");

        /// <summary>Creates a <see cref="TopicConstantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="TopicConstantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static TopicConstantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new TopicConstantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="TopicConstantName"/> with the pattern <c>topicConstants/{topic_constant}</c>.
        /// </summary>
        /// <param name="topicConstantId">The <c>TopicConstant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="TopicConstantName"/> constructed from the provided ids.</returns>
        public static TopicConstantName FromTopicConstant(string topicConstantId) =>
            new TopicConstantName(ResourceNameType.TopicConstant, topicConstantId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicConstantId, nameof(topicConstantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicConstantName"/> with pattern
        /// <c>topicConstants/{topic_constant}</c>.
        /// </summary>
        /// <param name="topicConstantId">The <c>TopicConstant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicConstantName"/> with pattern
        /// <c>topicConstants/{topic_constant}</c>.
        /// </returns>
        public static string Format(string topicConstantId) => FormatTopicConstant(topicConstantId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="TopicConstantName"/> with pattern
        /// <c>topicConstants/{topic_constant}</c>.
        /// </summary>
        /// <param name="topicConstantId">The <c>TopicConstant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="TopicConstantName"/> with pattern
        /// <c>topicConstants/{topic_constant}</c>.
        /// </returns>
        public static string FormatTopicConstant(string topicConstantId) =>
            s_topicConstant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(topicConstantId, nameof(topicConstantId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TopicConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>topicConstants/{topic_constant}</c></description></item></list>
        /// </remarks>
        /// <param name="topicConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="TopicConstantName"/> if successful.</returns>
        public static TopicConstantName Parse(string topicConstantName) => Parse(topicConstantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="TopicConstantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>topicConstants/{topic_constant}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="TopicConstantName"/> if successful.</returns>
        public static TopicConstantName Parse(string topicConstantName, bool allowUnparsed) =>
            TryParse(topicConstantName, allowUnparsed, out TopicConstantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>topicConstants/{topic_constant}</c></description></item></list>
        /// </remarks>
        /// <param name="topicConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicConstantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicConstantName, out TopicConstantName result) =>
            TryParse(topicConstantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="TopicConstantName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>topicConstants/{topic_constant}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="topicConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="TopicConstantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string topicConstantName, bool allowUnparsed, out TopicConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(topicConstantName, nameof(topicConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_topicConstant.TryParseName(topicConstantName, out resourceName))
            {
                result = FromTopicConstant(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(topicConstantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private TopicConstantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string topicConstantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            TopicConstantId = topicConstantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="TopicConstantName"/> class from the component parts of pattern
        /// <c>topicConstants/{topic_constant}</c>
        /// </summary>
        /// <param name="topicConstantId">The <c>TopicConstant</c> ID. Must not be <c>null</c> or empty.</param>
        public TopicConstantName(string topicConstantId) : this(ResourceNameType.TopicConstant, topicConstantId: gax::GaxPreconditions.CheckNotNullOrEmpty(topicConstantId, nameof(topicConstantId)))
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
        /// The <c>TopicConstant</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string TopicConstantId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.TopicConstant: return s_topicConstant.Expand(TopicConstantId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as TopicConstantName);

        /// <inheritdoc/>
        public bool Equals(TopicConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(TopicConstantName a, TopicConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(TopicConstantName a, TopicConstantName b) => !(a == b);
    }

    public partial class TopicConstant
    {
        /// <summary>
        /// <see cref="TopicConstantName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal TopicConstantName ResourceNameAsTopicConstantName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : TopicConstantName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="TopicConstantName"/>-typed view over the <see cref="TopicConstantParent"/> resource name
        /// property.
        /// </summary>
        internal TopicConstantName TopicConstantParentAsTopicConstantName
        {
            get => string.IsNullOrEmpty(TopicConstantParent) ? null : TopicConstantName.Parse(TopicConstantParent, allowUnparsed: true);
            set => TopicConstantParent = value?.ToString() ?? "";
        }
    }
}

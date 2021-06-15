// Copyright 2021 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V8.Resources
{
    /// <summary>Resource name for the <c>LanguageConstant</c> resource.</summary>
    public sealed partial class LanguageConstantName : gax::IResourceName, sys::IEquatable<LanguageConstantName>
    {
        /// <summary>The possible contents of <see cref="LanguageConstantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>languageConstants/{criterion_id}</c>.</summary>
            Criterion = 1,
        }

        private static gax::PathTemplate s_criterion = new gax::PathTemplate("languageConstants/{criterion_id}");

        /// <summary>Creates a <see cref="LanguageConstantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LanguageConstantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LanguageConstantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LanguageConstantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LanguageConstantName"/> with the pattern <c>languageConstants/{criterion_id}</c>.
        /// </summary>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LanguageConstantName"/> constructed from the provided ids.</returns>
        public static LanguageConstantName FromCriterion(string criterionId) =>
            new LanguageConstantName(ResourceNameType.Criterion, criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LanguageConstantName"/> with pattern
        /// <c>languageConstants/{criterion_id}</c>.
        /// </summary>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LanguageConstantName"/> with pattern
        /// <c>languageConstants/{criterion_id}</c>.
        /// </returns>
        public static string Format(string criterionId) => FormatCriterion(criterionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LanguageConstantName"/> with pattern
        /// <c>languageConstants/{criterion_id}</c>.
        /// </summary>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LanguageConstantName"/> with pattern
        /// <c>languageConstants/{criterion_id}</c>.
        /// </returns>
        public static string FormatCriterion(string criterionId) =>
            s_criterion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LanguageConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>languageConstants/{criterion_id}</c></description></item></list>
        /// </remarks>
        /// <param name="languageConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LanguageConstantName"/> if successful.</returns>
        public static LanguageConstantName Parse(string languageConstantName) => Parse(languageConstantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LanguageConstantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>languageConstants/{criterion_id}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="languageConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LanguageConstantName"/> if successful.</returns>
        public static LanguageConstantName Parse(string languageConstantName, bool allowUnparsed) =>
            TryParse(languageConstantName, allowUnparsed, out LanguageConstantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LanguageConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>languageConstants/{criterion_id}</c></description></item></list>
        /// </remarks>
        /// <param name="languageConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LanguageConstantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string languageConstantName, out LanguageConstantName result) =>
            TryParse(languageConstantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LanguageConstantName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>languageConstants/{criterion_id}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="languageConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LanguageConstantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string languageConstantName, bool allowUnparsed, out LanguageConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(languageConstantName, nameof(languageConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_criterion.TryParseName(languageConstantName, out resourceName))
            {
                result = FromCriterion(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(languageConstantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LanguageConstantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string criterionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CriterionId = criterionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LanguageConstantName"/> class from the component parts of pattern
        /// <c>languageConstants/{criterion_id}</c>
        /// </summary>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        public LanguageConstantName(string criterionId) : this(ResourceNameType.Criterion, criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))
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
        /// The <c>Criterion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CriterionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Criterion: return s_criterion.Expand(CriterionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LanguageConstantName);

        /// <inheritdoc/>
        public bool Equals(LanguageConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(LanguageConstantName a, LanguageConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(LanguageConstantName a, LanguageConstantName b) => !(a == b);
    }

    public partial class LanguageConstant
    {
        /// <summary>
        /// <see cref="gagvr::LanguageConstantName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal LanguageConstantName ResourceNameAsLanguageConstantName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::LanguageConstantName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::LanguageConstantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal LanguageConstantName LanguageConstantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::LanguageConstantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

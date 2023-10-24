// Copyright 2023 Google LLC
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

namespace Google.Ads.GoogleAds.V15.Resources
{
    /// <summary>Resource name for the <c>QualifyingQuestion</c> resource.</summary>
    public sealed partial class QualifyingQuestionName : gax::IResourceName, sys::IEquatable<QualifyingQuestionName>
    {
        /// <summary>The possible contents of <see cref="QualifyingQuestionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>qualifyingQuestions/{qualifying_question_id}</c>.</summary>
            QualifyingQuestion = 1,
        }

        private static gax::PathTemplate s_qualifyingQuestion = new gax::PathTemplate("qualifyingQuestions/{qualifying_question_id}");

        /// <summary>Creates a <see cref="QualifyingQuestionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="QualifyingQuestionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static QualifyingQuestionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new QualifyingQuestionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="QualifyingQuestionName"/> with the pattern
        /// <c>qualifyingQuestions/{qualifying_question_id}</c>.
        /// </summary>
        /// <param name="qualifyingQuestionId">
        /// The <c>QualifyingQuestion</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="QualifyingQuestionName"/> constructed from the provided ids.</returns>
        public static QualifyingQuestionName FromQualifyingQuestion(string qualifyingQuestionId) =>
            new QualifyingQuestionName(ResourceNameType.QualifyingQuestion, qualifyingQuestionId: gax::GaxPreconditions.CheckNotNullOrEmpty(qualifyingQuestionId, nameof(qualifyingQuestionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QualifyingQuestionName"/> with pattern
        /// <c>qualifyingQuestions/{qualifying_question_id}</c>.
        /// </summary>
        /// <param name="qualifyingQuestionId">
        /// The <c>QualifyingQuestion</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="QualifyingQuestionName"/> with pattern
        /// <c>qualifyingQuestions/{qualifying_question_id}</c>.
        /// </returns>
        public static string Format(string qualifyingQuestionId) => FormatQualifyingQuestion(qualifyingQuestionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="QualifyingQuestionName"/> with pattern
        /// <c>qualifyingQuestions/{qualifying_question_id}</c>.
        /// </summary>
        /// <param name="qualifyingQuestionId">
        /// The <c>QualifyingQuestion</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="QualifyingQuestionName"/> with pattern
        /// <c>qualifyingQuestions/{qualifying_question_id}</c>.
        /// </returns>
        public static string FormatQualifyingQuestion(string qualifyingQuestionId) =>
            s_qualifyingQuestion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(qualifyingQuestionId, nameof(qualifyingQuestionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QualifyingQuestionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>qualifyingQuestions/{qualifying_question_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="qualifyingQuestionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="QualifyingQuestionName"/> if successful.</returns>
        public static QualifyingQuestionName Parse(string qualifyingQuestionName) => Parse(qualifyingQuestionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="QualifyingQuestionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>qualifyingQuestions/{qualifying_question_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="qualifyingQuestionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="QualifyingQuestionName"/> if successful.</returns>
        public static QualifyingQuestionName Parse(string qualifyingQuestionName, bool allowUnparsed) =>
            TryParse(qualifyingQuestionName, allowUnparsed, out QualifyingQuestionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QualifyingQuestionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>qualifyingQuestions/{qualifying_question_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="qualifyingQuestionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QualifyingQuestionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string qualifyingQuestionName, out QualifyingQuestionName result) =>
            TryParse(qualifyingQuestionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="QualifyingQuestionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>qualifyingQuestions/{qualifying_question_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="qualifyingQuestionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="QualifyingQuestionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string qualifyingQuestionName, bool allowUnparsed, out QualifyingQuestionName result)
        {
            gax::GaxPreconditions.CheckNotNull(qualifyingQuestionName, nameof(qualifyingQuestionName));
            gax::TemplatedResourceName resourceName;
            if (s_qualifyingQuestion.TryParseName(qualifyingQuestionName, out resourceName))
            {
                result = FromQualifyingQuestion(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(qualifyingQuestionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private QualifyingQuestionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string qualifyingQuestionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            QualifyingQuestionId = qualifyingQuestionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="QualifyingQuestionName"/> class from the component parts of
        /// pattern <c>qualifyingQuestions/{qualifying_question_id}</c>
        /// </summary>
        /// <param name="qualifyingQuestionId">
        /// The <c>QualifyingQuestion</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public QualifyingQuestionName(string qualifyingQuestionId) : this(ResourceNameType.QualifyingQuestion, qualifyingQuestionId: gax::GaxPreconditions.CheckNotNullOrEmpty(qualifyingQuestionId, nameof(qualifyingQuestionId)))
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
        /// The <c>QualifyingQuestion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string QualifyingQuestionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.QualifyingQuestion: return s_qualifyingQuestion.Expand(QualifyingQuestionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as QualifyingQuestionName);

        /// <inheritdoc/>
        public bool Equals(QualifyingQuestionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(QualifyingQuestionName a, QualifyingQuestionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(QualifyingQuestionName a, QualifyingQuestionName b) => !(a == b);
    }

    public partial class QualifyingQuestion
    {
        /// <summary>
        /// <see cref="QualifyingQuestionName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal QualifyingQuestionName ResourceNameAsQualifyingQuestionName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : QualifyingQuestionName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

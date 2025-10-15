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
    /// <summary>Resource name for the <c>KeywordThemeConstant</c> resource.</summary>
    public sealed partial class KeywordThemeConstantName : gax::IResourceName, sys::IEquatable<KeywordThemeConstantName>
    {
        /// <summary>The possible contents of <see cref="KeywordThemeConstantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c>
            /// .
            /// </summary>
            ExpressCategoryExpressSubCategory = 1,
        }

        private static gax::PathTemplate s_expressCategoryExpressSubCategory = new gax::PathTemplate("keywordThemeConstants/{express_category_id_express_sub_category_id}");

        /// <summary>Creates a <see cref="KeywordThemeConstantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeywordThemeConstantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KeywordThemeConstantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeywordThemeConstantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KeywordThemeConstantName"/> with the pattern
        /// <c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c>.
        /// </summary>
        /// <param name="expressCategoryId">The <c>ExpressCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="expressSubCategoryId">
        /// The <c>ExpressSubCategory</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="KeywordThemeConstantName"/> constructed from the provided ids.
        /// </returns>
        public static KeywordThemeConstantName FromExpressCategoryExpressSubCategory(string expressCategoryId, string expressSubCategoryId) =>
            new KeywordThemeConstantName(ResourceNameType.ExpressCategoryExpressSubCategory, expressCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(expressCategoryId, nameof(expressCategoryId)), expressSubCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(expressSubCategoryId, nameof(expressSubCategoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordThemeConstantName"/> with pattern
        /// <c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c>.
        /// </summary>
        /// <param name="expressCategoryId">The <c>ExpressCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="expressSubCategoryId">
        /// The <c>ExpressSubCategory</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordThemeConstantName"/> with pattern
        /// <c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c>.
        /// </returns>
        public static string Format(string expressCategoryId, string expressSubCategoryId) =>
            FormatExpressCategoryExpressSubCategory(expressCategoryId, expressSubCategoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordThemeConstantName"/> with pattern
        /// <c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c>.
        /// </summary>
        /// <param name="expressCategoryId">The <c>ExpressCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="expressSubCategoryId">
        /// The <c>ExpressSubCategory</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordThemeConstantName"/> with pattern
        /// <c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c>.
        /// </returns>
        public static string FormatExpressCategoryExpressSubCategory(string expressCategoryId, string expressSubCategoryId) =>
            s_expressCategoryExpressSubCategory.Expand($"{(gax::GaxPreconditions.CheckNotNullOrEmpty(expressCategoryId, nameof(expressCategoryId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(expressSubCategoryId, nameof(expressSubCategoryId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordThemeConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordThemeConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordThemeConstantName"/> if successful.</returns>
        public static KeywordThemeConstantName Parse(string keywordThemeConstantName) =>
            Parse(keywordThemeConstantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordThemeConstantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordThemeConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeywordThemeConstantName"/> if successful.</returns>
        public static KeywordThemeConstantName Parse(string keywordThemeConstantName, bool allowUnparsed) =>
            TryParse(keywordThemeConstantName, allowUnparsed, out KeywordThemeConstantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordThemeConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordThemeConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordThemeConstantName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordThemeConstantName, out KeywordThemeConstantName result) =>
            TryParse(keywordThemeConstantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordThemeConstantName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordThemeConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordThemeConstantName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordThemeConstantName, bool allowUnparsed, out KeywordThemeConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordThemeConstantName, nameof(keywordThemeConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_expressCategoryExpressSubCategory.TryParseName(keywordThemeConstantName, out resourceName))
            {
                string[] split0 = ParseSplitHelper(resourceName[0], new char[] { '~', });
                if (split0 == null)
                {
                    result = null;
                    return false;
                }
                result = FromExpressCategoryExpressSubCategory(split0[0], split0[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keywordThemeConstantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private KeywordThemeConstantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string expressCategoryId = null, string expressSubCategoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ExpressCategoryId = expressCategoryId;
            ExpressSubCategoryId = expressSubCategoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeywordThemeConstantName"/> class from the component parts of
        /// pattern <c>keywordThemeConstants/{express_category_id}~{express_sub_category_id}</c>
        /// </summary>
        /// <param name="expressCategoryId">The <c>ExpressCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="expressSubCategoryId">
        /// The <c>ExpressSubCategory</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public KeywordThemeConstantName(string expressCategoryId, string expressSubCategoryId) : this(ResourceNameType.ExpressCategoryExpressSubCategory, expressCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(expressCategoryId, nameof(expressCategoryId)), expressSubCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(expressSubCategoryId, nameof(expressSubCategoryId)))
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
        /// The <c>ExpressCategory</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ExpressCategoryId { get; }

        /// <summary>
        /// The <c>ExpressSubCategory</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ExpressSubCategoryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.ExpressCategoryExpressSubCategory: return s_expressCategoryExpressSubCategory.Expand($"{ExpressCategoryId}~{ExpressSubCategoryId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeywordThemeConstantName);

        /// <inheritdoc/>
        public bool Equals(KeywordThemeConstantName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(KeywordThemeConstantName a, KeywordThemeConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(KeywordThemeConstantName a, KeywordThemeConstantName b) => !(a == b);
    }

    public partial class KeywordThemeConstant
    {
        /// <summary>
        /// <see cref="KeywordThemeConstantName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal KeywordThemeConstantName ResourceNameAsKeywordThemeConstantName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : KeywordThemeConstantName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

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

namespace Google.Ads.GoogleAds.V20.Resources
{
    /// <summary>Resource name for the <c>ProductCategoryConstant</c> resource.</summary>
    public sealed partial class ProductCategoryConstantName : gax::IResourceName, sys::IEquatable<ProductCategoryConstantName>
    {
        /// <summary>The possible contents of <see cref="ProductCategoryConstantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>productCategoryConstants/{level}~{category_id}</c>.</summary>
            LevelCategory = 1,
        }

        private static gax::PathTemplate s_levelCategory = new gax::PathTemplate("productCategoryConstants/{level_category_id}");

        /// <summary>Creates a <see cref="ProductCategoryConstantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProductCategoryConstantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProductCategoryConstantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProductCategoryConstantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProductCategoryConstantName"/> with the pattern
        /// <c>productCategoryConstants/{level}~{category_id}</c>.
        /// </summary>
        /// <param name="levelId">The <c>Level</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ProductCategoryConstantName"/> constructed from the provided ids.
        /// </returns>
        public static ProductCategoryConstantName FromLevelCategory(string levelId, string categoryId) =>
            new ProductCategoryConstantName(ResourceNameType.LevelCategory, levelId: gax::GaxPreconditions.CheckNotNullOrEmpty(levelId, nameof(levelId)), categoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductCategoryConstantName"/> with
        /// pattern <c>productCategoryConstants/{level}~{category_id}</c>.
        /// </summary>
        /// <param name="levelId">The <c>Level</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductCategoryConstantName"/> with pattern
        /// <c>productCategoryConstants/{level}~{category_id}</c>.
        /// </returns>
        public static string Format(string levelId, string categoryId) => FormatLevelCategory(levelId, categoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductCategoryConstantName"/> with
        /// pattern <c>productCategoryConstants/{level}~{category_id}</c>.
        /// </summary>
        /// <param name="levelId">The <c>Level</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductCategoryConstantName"/> with pattern
        /// <c>productCategoryConstants/{level}~{category_id}</c>.
        /// </returns>
        public static string FormatLevelCategory(string levelId, string categoryId) =>
            s_levelCategory.Expand($"{(gax::GaxPreconditions.CheckNotNullOrEmpty(levelId, nameof(levelId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProductCategoryConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>productCategoryConstants/{level}~{category_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="productCategoryConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProductCategoryConstantName"/> if successful.</returns>
        public static ProductCategoryConstantName Parse(string productCategoryConstantName) =>
            Parse(productCategoryConstantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProductCategoryConstantName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>productCategoryConstants/{level}~{category_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productCategoryConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProductCategoryConstantName"/> if successful.</returns>
        public static ProductCategoryConstantName Parse(string productCategoryConstantName, bool allowUnparsed) =>
            TryParse(productCategoryConstantName, allowUnparsed, out ProductCategoryConstantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductCategoryConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>productCategoryConstants/{level}~{category_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="productCategoryConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductCategoryConstantName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productCategoryConstantName, out ProductCategoryConstantName result) =>
            TryParse(productCategoryConstantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductCategoryConstantName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>productCategoryConstants/{level}~{category_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productCategoryConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductCategoryConstantName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productCategoryConstantName, bool allowUnparsed, out ProductCategoryConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(productCategoryConstantName, nameof(productCategoryConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_levelCategory.TryParseName(productCategoryConstantName, out resourceName))
            {
                string[] split0 = ParseSplitHelper(resourceName[0], new char[] { '~', });
                if (split0 == null)
                {
                    result = null;
                    return false;
                }
                result = FromLevelCategory(split0[0], split0[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(productCategoryConstantName, out gax::UnparsedResourceName unparsedResourceName))
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

        private ProductCategoryConstantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string categoryId = null, string levelId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CategoryId = categoryId;
            LevelId = levelId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProductCategoryConstantName"/> class from the component parts of
        /// pattern <c>productCategoryConstants/{level}~{category_id}</c>
        /// </summary>
        /// <param name="levelId">The <c>Level</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="categoryId">The <c>Category</c> ID. Must not be <c>null</c> or empty.</param>
        public ProductCategoryConstantName(string levelId, string categoryId) : this(ResourceNameType.LevelCategory, levelId: gax::GaxPreconditions.CheckNotNullOrEmpty(levelId, nameof(levelId)), categoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(categoryId, nameof(categoryId)))
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
        /// The <c>Category</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CategoryId { get; }

        /// <summary>
        /// The <c>Level</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LevelId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.LevelCategory: return s_levelCategory.Expand($"{LevelId}~{CategoryId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProductCategoryConstantName);

        /// <inheritdoc/>
        public bool Equals(ProductCategoryConstantName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ProductCategoryConstantName a, ProductCategoryConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ProductCategoryConstantName a, ProductCategoryConstantName b) => !(a == b);
    }

    public partial class ProductCategoryConstant
    {
        /// <summary>
        /// <see cref="ProductCategoryConstantName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal ProductCategoryConstantName ResourceNameAsProductCategoryConstantName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ProductCategoryConstantName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductCategoryConstantName"/>-typed view over the <see cref="ProductCategoryConstantParent"/>
        /// resource name property.
        /// </summary>
        internal ProductCategoryConstantName ProductCategoryConstantParentAsProductCategoryConstantName
        {
            get => string.IsNullOrEmpty(ProductCategoryConstantParent) ? null : ProductCategoryConstantName.Parse(ProductCategoryConstantParent, allowUnparsed: true);
            set => ProductCategoryConstantParent = value?.ToString() ?? "";
        }
    }
}

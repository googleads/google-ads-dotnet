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

namespace Google.Ads.GoogleAds.V13.Resources
{
    /// <summary>Resource name for the <c>ProductBiddingCategoryConstant</c> resource.</summary>
    public sealed partial class ProductBiddingCategoryConstantName : gax::IResourceName, sys::IEquatable<ProductBiddingCategoryConstantName>
    {
        /// <summary>The possible contents of <see cref="ProductBiddingCategoryConstantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c>.
            /// </summary>
            CountryCodeLevelId = 1,
        }

        private static gax::PathTemplate s_countryCodeLevelId = new gax::PathTemplate("productBiddingCategoryConstants/{country_code_level_id}");

        /// <summary>
        /// Creates a <see cref="ProductBiddingCategoryConstantName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProductBiddingCategoryConstantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProductBiddingCategoryConstantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProductBiddingCategoryConstantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProductBiddingCategoryConstantName"/> with the pattern
        /// <c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c>.
        /// </summary>
        /// <param name="countryCodeId">The <c>CountryCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="levelId">The <c>Level</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="idId">The <c>Id</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="ProductBiddingCategoryConstantName"/> constructed from the provided ids.
        /// </returns>
        public static ProductBiddingCategoryConstantName FromCountryCodeLevelId(string countryCodeId, string levelId, string idId) =>
            new ProductBiddingCategoryConstantName(ResourceNameType.CountryCodeLevelId, countryCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(countryCodeId, nameof(countryCodeId)), levelId: gax::GaxPreconditions.CheckNotNullOrEmpty(levelId, nameof(levelId)), idId: gax::GaxPreconditions.CheckNotNullOrEmpty(idId, nameof(idId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductBiddingCategoryConstantName"/> with
        /// pattern <c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c>.
        /// </summary>
        /// <param name="countryCodeId">The <c>CountryCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="levelId">The <c>Level</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="idId">The <c>Id</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductBiddingCategoryConstantName"/> with pattern
        /// <c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c>.
        /// </returns>
        public static string Format(string countryCodeId, string levelId, string idId) =>
            FormatCountryCodeLevelId(countryCodeId, levelId, idId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductBiddingCategoryConstantName"/> with
        /// pattern <c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c>.
        /// </summary>
        /// <param name="countryCodeId">The <c>CountryCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="levelId">The <c>Level</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="idId">The <c>Id</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductBiddingCategoryConstantName"/> with pattern
        /// <c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c>.
        /// </returns>
        public static string FormatCountryCodeLevelId(string countryCodeId, string levelId, string idId) =>
            s_countryCodeLevelId.Expand($"{(gax::GaxPreconditions.CheckNotNullOrEmpty(countryCodeId, nameof(countryCodeId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(levelId, nameof(levelId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(idId, nameof(idId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProductBiddingCategoryConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="productBiddingCategoryConstantName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ProductBiddingCategoryConstantName"/> if successful.</returns>
        public static ProductBiddingCategoryConstantName Parse(string productBiddingCategoryConstantName) =>
            Parse(productBiddingCategoryConstantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProductBiddingCategoryConstantName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productBiddingCategoryConstantName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProductBiddingCategoryConstantName"/> if successful.</returns>
        public static ProductBiddingCategoryConstantName Parse(string productBiddingCategoryConstantName, bool allowUnparsed) =>
            TryParse(productBiddingCategoryConstantName, allowUnparsed, out ProductBiddingCategoryConstantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductBiddingCategoryConstantName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="productBiddingCategoryConstantName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductBiddingCategoryConstantName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productBiddingCategoryConstantName, out ProductBiddingCategoryConstantName result) =>
            TryParse(productBiddingCategoryConstantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductBiddingCategoryConstantName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productBiddingCategoryConstantName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductBiddingCategoryConstantName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productBiddingCategoryConstantName, bool allowUnparsed, out ProductBiddingCategoryConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(productBiddingCategoryConstantName, nameof(productBiddingCategoryConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_countryCodeLevelId.TryParseName(productBiddingCategoryConstantName, out resourceName))
            {
                string[] split0 = ParseSplitHelper(resourceName[0], new char[] { '~', '~', });
                if (split0 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCountryCodeLevelId(split0[0], split0[1], split0[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(productBiddingCategoryConstantName, out gax::UnparsedResourceName unparsedResourceName))
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

        private ProductBiddingCategoryConstantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string countryCodeId = null, string idId = null, string levelId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CountryCodeId = countryCodeId;
            IdId = idId;
            LevelId = levelId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProductBiddingCategoryConstantName"/> class from the component
        /// parts of pattern <c>productBiddingCategoryConstants/{country_code}~{level}~{id}</c>
        /// </summary>
        /// <param name="countryCodeId">The <c>CountryCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="levelId">The <c>Level</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="idId">The <c>Id</c> ID. Must not be <c>null</c> or empty.</param>
        public ProductBiddingCategoryConstantName(string countryCodeId, string levelId, string idId) : this(ResourceNameType.CountryCodeLevelId, countryCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(countryCodeId, nameof(countryCodeId)), levelId: gax::GaxPreconditions.CheckNotNullOrEmpty(levelId, nameof(levelId)), idId: gax::GaxPreconditions.CheckNotNullOrEmpty(idId, nameof(idId)))
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
        /// The <c>CountryCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CountryCodeId { get; }

        /// <summary>
        /// The <c>Id</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string IdId { get; }

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
                case ResourceNameType.CountryCodeLevelId: return s_countryCodeLevelId.Expand($"{CountryCodeId}~{LevelId}~{IdId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProductBiddingCategoryConstantName);

        /// <inheritdoc/>
        public bool Equals(ProductBiddingCategoryConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ProductBiddingCategoryConstantName a, ProductBiddingCategoryConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ProductBiddingCategoryConstantName a, ProductBiddingCategoryConstantName b) => !(a == b);
    }

    public partial class ProductBiddingCategoryConstant
    {
        /// <summary>
        /// <see cref="ProductBiddingCategoryConstantName"/>-typed view over the <see cref="ResourceName"/> resource
        /// name property.
        /// </summary>
        internal ProductBiddingCategoryConstantName ResourceNameAsProductBiddingCategoryConstantName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ProductBiddingCategoryConstantName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductBiddingCategoryConstantName"/>-typed view over the
        /// <see cref="ProductBiddingCategoryConstantParent"/> resource name property.
        /// </summary>
        internal ProductBiddingCategoryConstantName ProductBiddingCategoryConstantParentAsProductBiddingCategoryConstantName
        {
            get => string.IsNullOrEmpty(ProductBiddingCategoryConstantParent) ? null : ProductBiddingCategoryConstantName.Parse(ProductBiddingCategoryConstantParent, allowUnparsed: true);
            set => ProductBiddingCategoryConstantParent = value?.ToString() ?? "";
        }
    }
}

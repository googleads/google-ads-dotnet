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

namespace Google.Ads.GoogleAds.V3.Resources
{
    /// <summary>Resource name for the <c>KeywordPlanKeyword</c> resource.</summary>
    public sealed partial class KeywordPlanKeywordName : gax::IResourceName, sys::IEquatable<KeywordPlanKeywordName>
    {
        /// <summary>The possible contents of <see cref="KeywordPlanKeywordName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c>.
            /// </summary>
            CustomerKeywordPlanKeyword = 1,
        }

        private static gax::PathTemplate s_customerKeywordPlanKeyword = new gax::PathTemplate("customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}");

        /// <summary>Creates a <see cref="KeywordPlanKeywordName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanKeywordName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KeywordPlanKeywordName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeywordPlanKeywordName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KeywordPlanKeywordName"/> with the pattern
        /// <c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanKeywordId">
        /// The <c>KeywordPlanKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="KeywordPlanKeywordName"/> constructed from the provided ids.</returns>
        public static KeywordPlanKeywordName FromCustomerKeywordPlanKeyword(string customerId, string keywordPlanKeywordId) =>
            new KeywordPlanKeywordName(ResourceNameType.CustomerKeywordPlanKeyword, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanKeywordId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanKeywordId, nameof(keywordPlanKeywordId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanKeywordName"/> with pattern
        /// <c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanKeywordId">
        /// The <c>KeywordPlanKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanKeywordName"/> with pattern
        /// <c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c>.
        /// </returns>
        public static string Format(string customerId, string keywordPlanKeywordId) =>
            FormatCustomerKeywordPlanKeyword(customerId, keywordPlanKeywordId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanKeywordName"/> with pattern
        /// <c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanKeywordId">
        /// The <c>KeywordPlanKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanKeywordName"/> with pattern
        /// <c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c>.
        /// </returns>
        public static string FormatCustomerKeywordPlanKeyword(string customerId, string keywordPlanKeywordId) =>
            s_customerKeywordPlanKeyword.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanKeywordId, nameof(keywordPlanKeywordId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanKeywordName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanKeywordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordPlanKeywordName"/> if successful.</returns>
        public static KeywordPlanKeywordName Parse(string keywordPlanKeywordName) => Parse(keywordPlanKeywordName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanKeywordName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanKeywordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeywordPlanKeywordName"/> if successful.</returns>
        public static KeywordPlanKeywordName Parse(string keywordPlanKeywordName, bool allowUnparsed) =>
            TryParse(keywordPlanKeywordName, allowUnparsed, out KeywordPlanKeywordName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanKeywordName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanKeywordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanKeywordName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanKeywordName, out KeywordPlanKeywordName result) =>
            TryParse(keywordPlanKeywordName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanKeywordName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanKeywordName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanKeywordName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanKeywordName, bool allowUnparsed, out KeywordPlanKeywordName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanKeywordName, nameof(keywordPlanKeywordName));
            gax::TemplatedResourceName resourceName;
            if (s_customerKeywordPlanKeyword.TryParseName(keywordPlanKeywordName, out resourceName))
            {
                result = FromCustomerKeywordPlanKeyword(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keywordPlanKeywordName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KeywordPlanKeywordName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string keywordPlanKeywordId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            KeywordPlanKeywordId = keywordPlanKeywordId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeywordPlanKeywordName"/> class from the component parts of
        /// pattern <c>customers/{customer}/keywordPlanKeywords/{keyword_plan_keyword}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanKeywordId">
        /// The <c>KeywordPlanKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public KeywordPlanKeywordName(string customerId, string keywordPlanKeywordId) : this(ResourceNameType.CustomerKeywordPlanKeyword, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanKeywordId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanKeywordId, nameof(keywordPlanKeywordId)))
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
        /// The <c>KeywordPlanKeyword</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string KeywordPlanKeywordId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerKeywordPlanKeyword: return s_customerKeywordPlanKeyword.Expand(CustomerId, KeywordPlanKeywordId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeywordPlanKeywordName);

        /// <inheritdoc/>
        public bool Equals(KeywordPlanKeywordName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(KeywordPlanKeywordName a, KeywordPlanKeywordName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(KeywordPlanKeywordName a, KeywordPlanKeywordName b) => !(a == b);
    }

    public partial class KeywordPlanKeyword
    {
        /// <summary>
        /// <see cref="KeywordPlanKeywordName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal KeywordPlanKeywordName ResourceNameAsKeywordPlanKeywordName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : KeywordPlanKeywordName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="KeywordPlanAdGroupName"/>-typed view over the <see cref="KeywordPlanAdGroup"/> resource name
        /// property.
        /// </summary>
        internal KeywordPlanAdGroupName KeywordPlanAdGroupAsKeywordPlanAdGroupName
        {
            get => string.IsNullOrEmpty(KeywordPlanAdGroup) ? null : KeywordPlanAdGroupName.Parse(KeywordPlanAdGroup, allowUnparsed: true);
            set => KeywordPlanAdGroup = value?.ToString() ?? "";
        }
    }
}

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
    /// <summary>Resource name for the <c>KeywordPlanNegativeKeyword</c> resource.</summary>
    public sealed partial class KeywordPlanNegativeKeywordName : gax::IResourceName, sys::IEquatable<KeywordPlanNegativeKeywordName>
    {
        /// <summary>The possible contents of <see cref="KeywordPlanNegativeKeywordName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>.
            /// </summary>
            CustomerKeywordPlanNegativeKeyword = 1
        }

        private static gax::PathTemplate s_customerKeywordPlanNegativeKeyword = new gax::PathTemplate("customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}");

        /// <summary>
        /// Creates a <see cref="KeywordPlanNegativeKeywordName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanNegativeKeywordName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KeywordPlanNegativeKeywordName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeywordPlanNegativeKeywordName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KeywordPlanNegativeKeywordName"/> with the pattern
        /// <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanNegativeKeywordId">
        /// The <c>KeywordPlanNegativeKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanNegativeKeywordName"/> constructed from the provided ids.
        /// </returns>
        public static KeywordPlanNegativeKeywordName FromCustomerKeywordPlanNegativeKeyword(string customerId, string keywordPlanNegativeKeywordId) =>
            new KeywordPlanNegativeKeywordName(ResourceNameType.CustomerKeywordPlanNegativeKeyword, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanNegativeKeywordId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanNegativeKeywordId, nameof(keywordPlanNegativeKeywordId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanNegativeKeywordName"/> with
        /// pattern <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanNegativeKeywordId">
        /// The <c>KeywordPlanNegativeKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanNegativeKeywordName"/> with pattern
        /// <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>.
        /// </returns>
        public static string Format(string customerId, string keywordPlanNegativeKeywordId) =>
            FormatCustomerKeywordPlanNegativeKeyword(customerId, keywordPlanNegativeKeywordId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanNegativeKeywordName"/> with
        /// pattern <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanNegativeKeywordId">
        /// The <c>KeywordPlanNegativeKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanNegativeKeywordName"/> with pattern
        /// <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>.
        /// </returns>
        public static string FormatCustomerKeywordPlanNegativeKeyword(string customerId, string keywordPlanNegativeKeywordId) =>
            s_customerKeywordPlanNegativeKeyword.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanNegativeKeywordId, nameof(keywordPlanNegativeKeywordId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanNegativeKeywordName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanNegativeKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="KeywordPlanNegativeKeywordName"/> if successful.</returns>
        public static KeywordPlanNegativeKeywordName Parse(string keywordPlanNegativeKeywordName) =>
            Parse(keywordPlanNegativeKeywordName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanNegativeKeywordName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanNegativeKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeywordPlanNegativeKeywordName"/> if successful.</returns>
        public static KeywordPlanNegativeKeywordName Parse(string keywordPlanNegativeKeywordName, bool allowUnparsed) =>
            TryParse(keywordPlanNegativeKeywordName, allowUnparsed, out KeywordPlanNegativeKeywordName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanNegativeKeywordName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanNegativeKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanNegativeKeywordName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanNegativeKeywordName, out KeywordPlanNegativeKeywordName result) =>
            TryParse(keywordPlanNegativeKeywordName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanNegativeKeywordName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanNegativeKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanNegativeKeywordName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanNegativeKeywordName, bool allowUnparsed, out KeywordPlanNegativeKeywordName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanNegativeKeywordName, nameof(keywordPlanNegativeKeywordName));
            gax::TemplatedResourceName resourceName;
            if (s_customerKeywordPlanNegativeKeyword.TryParseName(keywordPlanNegativeKeywordName, out resourceName))
            {
                result = FromCustomerKeywordPlanNegativeKeyword(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keywordPlanNegativeKeywordName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KeywordPlanNegativeKeywordName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string keywordPlanNegativeKeywordId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            KeywordPlanNegativeKeywordId = keywordPlanNegativeKeywordId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeywordPlanNegativeKeywordName"/> class from the component parts
        /// of pattern <c>customers/{customer}/keywordPlanNegativeKeywords/{keyword_plan_negative_keyword}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanNegativeKeywordId">
        /// The <c>KeywordPlanNegativeKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public KeywordPlanNegativeKeywordName(string customerId, string keywordPlanNegativeKeywordId) : this(ResourceNameType.CustomerKeywordPlanNegativeKeyword, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanNegativeKeywordId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanNegativeKeywordId, nameof(keywordPlanNegativeKeywordId)))
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
        /// The <c>KeywordPlanNegativeKeyword</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string KeywordPlanNegativeKeywordId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerKeywordPlanNegativeKeyword: return s_customerKeywordPlanNegativeKeyword.Expand(CustomerId, KeywordPlanNegativeKeywordId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeywordPlanNegativeKeywordName);

        /// <inheritdoc/>
        public bool Equals(KeywordPlanNegativeKeywordName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(KeywordPlanNegativeKeywordName a, KeywordPlanNegativeKeywordName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(KeywordPlanNegativeKeywordName a, KeywordPlanNegativeKeywordName b) => !(a == b);
    }

    public partial class KeywordPlanNegativeKeyword
    {
        /// <summary>
        /// <see cref="KeywordPlanNegativeKeywordName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal KeywordPlanNegativeKeywordName ResourceNameAsKeywordPlanNegativeKeywordName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : KeywordPlanNegativeKeywordName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="KeywordPlanCampaignName"/>-typed view over the <see cref="KeywordPlanCampaign"/> resource name
        /// property.
        /// </summary>
        internal KeywordPlanCampaignName KeywordPlanCampaignAsKeywordPlanCampaignName
        {
            get => string.IsNullOrEmpty(KeywordPlanCampaign) ? null : KeywordPlanCampaignName.Parse(KeywordPlanCampaign, allowUnparsed: true);
            set => KeywordPlanCampaign = value?.ToString() ?? "";
        }
    }
}

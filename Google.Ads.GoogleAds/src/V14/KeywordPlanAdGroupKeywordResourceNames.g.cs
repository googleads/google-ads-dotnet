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

namespace Google.Ads.GoogleAds.V14.Resources
{
    /// <summary>Resource name for the <c>KeywordPlanAdGroupKeyword</c> resource.</summary>
    public sealed partial class KeywordPlanAdGroupKeywordName : gax::IResourceName, sys::IEquatable<KeywordPlanAdGroupKeywordName>
    {
        /// <summary>The possible contents of <see cref="KeywordPlanAdGroupKeywordName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>.
            /// </summary>
            CustomerKeywordPlanAdGroupKeyword = 1,
        }

        private static gax::PathTemplate s_customerKeywordPlanAdGroupKeyword = new gax::PathTemplate("customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}");

        /// <summary>
        /// Creates a <see cref="KeywordPlanAdGroupKeywordName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanAdGroupKeywordName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KeywordPlanAdGroupKeywordName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeywordPlanAdGroupKeywordName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KeywordPlanAdGroupKeywordName"/> with the pattern
        /// <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanAdGroupKeywordId">
        /// The <c>KeywordPlanAdGroupKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanAdGroupKeywordName"/> constructed from the provided ids.
        /// </returns>
        public static KeywordPlanAdGroupKeywordName FromCustomerKeywordPlanAdGroupKeyword(string customerId, string keywordPlanAdGroupKeywordId) =>
            new KeywordPlanAdGroupKeywordName(ResourceNameType.CustomerKeywordPlanAdGroupKeyword, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanAdGroupKeywordId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanAdGroupKeywordId, nameof(keywordPlanAdGroupKeywordId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanAdGroupKeywordName"/> with
        /// pattern <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanAdGroupKeywordId">
        /// The <c>KeywordPlanAdGroupKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanAdGroupKeywordName"/> with pattern
        /// <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>.
        /// </returns>
        public static string Format(string customerId, string keywordPlanAdGroupKeywordId) =>
            FormatCustomerKeywordPlanAdGroupKeyword(customerId, keywordPlanAdGroupKeywordId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanAdGroupKeywordName"/> with
        /// pattern <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanAdGroupKeywordId">
        /// The <c>KeywordPlanAdGroupKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanAdGroupKeywordName"/> with pattern
        /// <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>.
        /// </returns>
        public static string FormatCustomerKeywordPlanAdGroupKeyword(string customerId, string keywordPlanAdGroupKeywordId) =>
            s_customerKeywordPlanAdGroupKeyword.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanAdGroupKeywordId, nameof(keywordPlanAdGroupKeywordId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanAdGroupKeywordName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanAdGroupKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="KeywordPlanAdGroupKeywordName"/> if successful.</returns>
        public static KeywordPlanAdGroupKeywordName Parse(string keywordPlanAdGroupKeywordName) =>
            Parse(keywordPlanAdGroupKeywordName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanAdGroupKeywordName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanAdGroupKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeywordPlanAdGroupKeywordName"/> if successful.</returns>
        public static KeywordPlanAdGroupKeywordName Parse(string keywordPlanAdGroupKeywordName, bool allowUnparsed) =>
            TryParse(keywordPlanAdGroupKeywordName, allowUnparsed, out KeywordPlanAdGroupKeywordName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanAdGroupKeywordName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanAdGroupKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanAdGroupKeywordName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanAdGroupKeywordName, out KeywordPlanAdGroupKeywordName result) =>
            TryParse(keywordPlanAdGroupKeywordName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanAdGroupKeywordName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanAdGroupKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanAdGroupKeywordName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanAdGroupKeywordName, bool allowUnparsed, out KeywordPlanAdGroupKeywordName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanAdGroupKeywordName, nameof(keywordPlanAdGroupKeywordName));
            gax::TemplatedResourceName resourceName;
            if (s_customerKeywordPlanAdGroupKeyword.TryParseName(keywordPlanAdGroupKeywordName, out resourceName))
            {
                result = FromCustomerKeywordPlanAdGroupKeyword(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keywordPlanAdGroupKeywordName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KeywordPlanAdGroupKeywordName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string keywordPlanAdGroupKeywordId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            KeywordPlanAdGroupKeywordId = keywordPlanAdGroupKeywordId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeywordPlanAdGroupKeywordName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/keywordPlanAdGroupKeywords/{keyword_plan_ad_group_keyword_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanAdGroupKeywordId">
        /// The <c>KeywordPlanAdGroupKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public KeywordPlanAdGroupKeywordName(string customerId, string keywordPlanAdGroupKeywordId) : this(ResourceNameType.CustomerKeywordPlanAdGroupKeyword, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanAdGroupKeywordId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanAdGroupKeywordId, nameof(keywordPlanAdGroupKeywordId)))
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
        /// The <c>KeywordPlanAdGroupKeyword</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string KeywordPlanAdGroupKeywordId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerKeywordPlanAdGroupKeyword: return s_customerKeywordPlanAdGroupKeyword.Expand(CustomerId, KeywordPlanAdGroupKeywordId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeywordPlanAdGroupKeywordName);

        /// <inheritdoc/>
        public bool Equals(KeywordPlanAdGroupKeywordName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(KeywordPlanAdGroupKeywordName a, KeywordPlanAdGroupKeywordName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(KeywordPlanAdGroupKeywordName a, KeywordPlanAdGroupKeywordName b) => !(a == b);
    }

    public partial class KeywordPlanAdGroupKeyword
    {
        /// <summary>
        /// <see cref="KeywordPlanAdGroupKeywordName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal KeywordPlanAdGroupKeywordName ResourceNameAsKeywordPlanAdGroupKeywordName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : KeywordPlanAdGroupKeywordName.Parse(ResourceName, allowUnparsed: true);
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

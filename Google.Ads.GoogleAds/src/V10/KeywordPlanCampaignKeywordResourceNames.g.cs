// Copyright 2022 Google LLC
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

namespace Google.Ads.GoogleAds.V10.Resources
{
    /// <summary>Resource name for the <c>KeywordPlanCampaignKeyword</c> resource.</summary>
    public sealed partial class KeywordPlanCampaignKeywordName : gax::IResourceName, sys::IEquatable<KeywordPlanCampaignKeywordName>
    {
        /// <summary>The possible contents of <see cref="KeywordPlanCampaignKeywordName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>.
            /// </summary>
            CustomerKeywordPlanCampaignKeyword = 1,
        }

        private static gax::PathTemplate s_customerKeywordPlanCampaignKeyword = new gax::PathTemplate("customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}");

        /// <summary>
        /// Creates a <see cref="KeywordPlanCampaignKeywordName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanCampaignKeywordName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KeywordPlanCampaignKeywordName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeywordPlanCampaignKeywordName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KeywordPlanCampaignKeywordName"/> with the pattern
        /// <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanCampaignKeywordId">
        /// The <c>KeywordPlanCampaignKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanCampaignKeywordName"/> constructed from the provided ids.
        /// </returns>
        public static KeywordPlanCampaignKeywordName FromCustomerKeywordPlanCampaignKeyword(string customerId, string keywordPlanCampaignKeywordId) =>
            new KeywordPlanCampaignKeywordName(ResourceNameType.CustomerKeywordPlanCampaignKeyword, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanCampaignKeywordId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanCampaignKeywordId, nameof(keywordPlanCampaignKeywordId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanCampaignKeywordName"/> with
        /// pattern <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanCampaignKeywordId">
        /// The <c>KeywordPlanCampaignKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanCampaignKeywordName"/> with pattern
        /// <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>.
        /// </returns>
        public static string Format(string customerId, string keywordPlanCampaignKeywordId) =>
            FormatCustomerKeywordPlanCampaignKeyword(customerId, keywordPlanCampaignKeywordId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanCampaignKeywordName"/> with
        /// pattern <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanCampaignKeywordId">
        /// The <c>KeywordPlanCampaignKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanCampaignKeywordName"/> with pattern
        /// <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>.
        /// </returns>
        public static string FormatCustomerKeywordPlanCampaignKeyword(string customerId, string keywordPlanCampaignKeywordId) =>
            s_customerKeywordPlanCampaignKeyword.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanCampaignKeywordId, nameof(keywordPlanCampaignKeywordId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanCampaignKeywordName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanCampaignKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="KeywordPlanCampaignKeywordName"/> if successful.</returns>
        public static KeywordPlanCampaignKeywordName Parse(string keywordPlanCampaignKeywordName) =>
            Parse(keywordPlanCampaignKeywordName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanCampaignKeywordName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanCampaignKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeywordPlanCampaignKeywordName"/> if successful.</returns>
        public static KeywordPlanCampaignKeywordName Parse(string keywordPlanCampaignKeywordName, bool allowUnparsed) =>
            TryParse(keywordPlanCampaignKeywordName, allowUnparsed, out KeywordPlanCampaignKeywordName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanCampaignKeywordName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanCampaignKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanCampaignKeywordName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanCampaignKeywordName, out KeywordPlanCampaignKeywordName result) =>
            TryParse(keywordPlanCampaignKeywordName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanCampaignKeywordName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanCampaignKeywordName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanCampaignKeywordName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanCampaignKeywordName, bool allowUnparsed, out KeywordPlanCampaignKeywordName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanCampaignKeywordName, nameof(keywordPlanCampaignKeywordName));
            gax::TemplatedResourceName resourceName;
            if (s_customerKeywordPlanCampaignKeyword.TryParseName(keywordPlanCampaignKeywordName, out resourceName))
            {
                result = FromCustomerKeywordPlanCampaignKeyword(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keywordPlanCampaignKeywordName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KeywordPlanCampaignKeywordName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string keywordPlanCampaignKeywordId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            KeywordPlanCampaignKeywordId = keywordPlanCampaignKeywordId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeywordPlanCampaignKeywordName"/> class from the component parts
        /// of pattern <c>customers/{customer_id}/keywordPlanCampaignKeywords/{keyword_plan_campaign_keyword_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanCampaignKeywordId">
        /// The <c>KeywordPlanCampaignKeyword</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public KeywordPlanCampaignKeywordName(string customerId, string keywordPlanCampaignKeywordId) : this(ResourceNameType.CustomerKeywordPlanCampaignKeyword, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanCampaignKeywordId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanCampaignKeywordId, nameof(keywordPlanCampaignKeywordId)))
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
        /// The <c>KeywordPlanCampaignKeyword</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string KeywordPlanCampaignKeywordId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerKeywordPlanCampaignKeyword: return s_customerKeywordPlanCampaignKeyword.Expand(CustomerId, KeywordPlanCampaignKeywordId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeywordPlanCampaignKeywordName);

        /// <inheritdoc/>
        public bool Equals(KeywordPlanCampaignKeywordName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(KeywordPlanCampaignKeywordName a, KeywordPlanCampaignKeywordName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(KeywordPlanCampaignKeywordName a, KeywordPlanCampaignKeywordName b) => !(a == b);
    }

    public partial class KeywordPlanCampaignKeyword
    {
        /// <summary>
        /// <see cref="KeywordPlanCampaignKeywordName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal KeywordPlanCampaignKeywordName ResourceNameAsKeywordPlanCampaignKeywordName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : KeywordPlanCampaignKeywordName.Parse(ResourceName, allowUnparsed: true);
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

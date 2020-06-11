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

using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V3.Resources
{
    /// <summary>Resource name for the <c>KeywordPlanAdGroup</c> resource.</summary>
    public sealed partial class KeywordPlanAdGroupName : gax::IResourceName, sys::IEquatable<KeywordPlanAdGroupName>
    {
        /// <summary>The possible contents of <see cref="KeywordPlanAdGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c>.
            /// </summary>
            CustomerKeywordPlanAdGroup = 1
        }

        private static gax::PathTemplate s_customerKeywordPlanAdGroup = new gax::PathTemplate("customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}");

        /// <summary>Creates a <see cref="KeywordPlanAdGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanAdGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KeywordPlanAdGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeywordPlanAdGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KeywordPlanAdGroupName"/> with the pattern
        /// <c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanAdGroupId">
        /// The <c>KeywordPlanAdGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="KeywordPlanAdGroupName"/> constructed from the provided ids.</returns>
        public static KeywordPlanAdGroupName FromCustomerKeywordPlanAdGroup(string customerId, string keywordPlanAdGroupId) =>
            new KeywordPlanAdGroupName(ResourceNameType.CustomerKeywordPlanAdGroup, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanAdGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanAdGroupId, nameof(keywordPlanAdGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanAdGroupName"/> with pattern
        /// <c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanAdGroupId">
        /// The <c>KeywordPlanAdGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanAdGroupName"/> with pattern
        /// <c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c>.
        /// </returns>
        public static string Format(string customerId, string keywordPlanAdGroupId) =>
            FormatCustomerKeywordPlanAdGroup(customerId, keywordPlanAdGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanAdGroupName"/> with pattern
        /// <c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanAdGroupId">
        /// The <c>KeywordPlanAdGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanAdGroupName"/> with pattern
        /// <c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c>.
        /// </returns>
        public static string FormatCustomerKeywordPlanAdGroup(string customerId, string keywordPlanAdGroupId) =>
            s_customerKeywordPlanAdGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanAdGroupId, nameof(keywordPlanAdGroupId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanAdGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanAdGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordPlanAdGroupName"/> if successful.</returns>
        public static KeywordPlanAdGroupName Parse(string keywordPlanAdGroupName) => Parse(keywordPlanAdGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanAdGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanAdGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeywordPlanAdGroupName"/> if successful.</returns>
        public static KeywordPlanAdGroupName Parse(string keywordPlanAdGroupName, bool allowUnparsed) =>
            TryParse(keywordPlanAdGroupName, allowUnparsed, out KeywordPlanAdGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanAdGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanAdGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanAdGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanAdGroupName, out KeywordPlanAdGroupName result) =>
            TryParse(keywordPlanAdGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanAdGroupName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanAdGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanAdGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanAdGroupName, bool allowUnparsed, out KeywordPlanAdGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanAdGroupName, nameof(keywordPlanAdGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_customerKeywordPlanAdGroup.TryParseName(keywordPlanAdGroupName, out resourceName))
            {
                result = FromCustomerKeywordPlanAdGroup(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keywordPlanAdGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KeywordPlanAdGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string keywordPlanAdGroupId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            KeywordPlanAdGroupId = keywordPlanAdGroupId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeywordPlanAdGroupName"/> class from the component parts of
        /// pattern <c>customers/{customer}/keywordPlanAdGroups/{keyword_plan_ad_group}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanAdGroupId">
        /// The <c>KeywordPlanAdGroup</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public KeywordPlanAdGroupName(string customerId, string keywordPlanAdGroupId) : this(ResourceNameType.CustomerKeywordPlanAdGroup, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanAdGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanAdGroupId, nameof(keywordPlanAdGroupId)))
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
        /// The <c>KeywordPlanAdGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string KeywordPlanAdGroupId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerKeywordPlanAdGroup: return s_customerKeywordPlanAdGroup.Expand(CustomerId, KeywordPlanAdGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeywordPlanAdGroupName);

        /// <inheritdoc/>
        public bool Equals(KeywordPlanAdGroupName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(KeywordPlanAdGroupName a, KeywordPlanAdGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(KeywordPlanAdGroupName a, KeywordPlanAdGroupName b) => !(a == b);
    }

    public partial class KeywordPlanAdGroup
    {
        /// <summary>
        /// <see cref="gagvr::KeywordPlanAdGroupName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        public gagvr::KeywordPlanAdGroupName ResourceNameAsKeywordPlanAdGroupName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::KeywordPlanAdGroupName.Parse(ResourceName, allowUnparsed: true);
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

        /// <summary>
        /// <see cref="gagvr::KeywordPlanAdGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagvr::KeywordPlanAdGroupName KeywordPlanAdGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::KeywordPlanAdGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

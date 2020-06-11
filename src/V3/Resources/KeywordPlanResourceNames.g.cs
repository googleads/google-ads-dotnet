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
    /// <summary>Resource name for the <c>KeywordPlan</c> resource.</summary>
    public sealed partial class KeywordPlanName : gax::IResourceName, sys::IEquatable<KeywordPlanName>
    {
        /// <summary>The possible contents of <see cref="KeywordPlanName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer}/keywordPlans/{keyword_plan}</c>.</summary>
            CustomerKeywordPlan = 1
        }

        private static gax::PathTemplate s_customerKeywordPlan = new gax::PathTemplate("customers/{customer}/keywordPlans/{keyword_plan}");

        /// <summary>Creates a <see cref="KeywordPlanName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeywordPlanName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KeywordPlanName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeywordPlanName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KeywordPlanName"/> with the pattern <c>customers/{customer}/keywordPlans/{keyword_plan}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanId">The <c>KeywordPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="KeywordPlanName"/> constructed from the provided ids.</returns>
        public static KeywordPlanName FromCustomerKeywordPlan(string customerId, string keywordPlanId) =>
            new KeywordPlanName(ResourceNameType.CustomerKeywordPlan, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanId, nameof(keywordPlanId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanName"/> with pattern
        /// <c>customers/{customer}/keywordPlans/{keyword_plan}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanId">The <c>KeywordPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanName"/> with pattern
        /// <c>customers/{customer}/keywordPlans/{keyword_plan}</c>.
        /// </returns>
        public static string Format(string customerId, string keywordPlanId) =>
            FormatCustomerKeywordPlan(customerId, keywordPlanId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordPlanName"/> with pattern
        /// <c>customers/{customer}/keywordPlans/{keyword_plan}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanId">The <c>KeywordPlan</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KeywordPlanName"/> with pattern
        /// <c>customers/{customer}/keywordPlans/{keyword_plan}</c>.
        /// </returns>
        public static string FormatCustomerKeywordPlan(string customerId, string keywordPlanId) =>
            s_customerKeywordPlan.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanId, nameof(keywordPlanId)));

        /// <summary>Parses the given resource name string into a new <see cref="KeywordPlanName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/keywordPlans/{keyword_plan}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordPlanName"/> if successful.</returns>
        public static KeywordPlanName Parse(string keywordPlanName) => Parse(keywordPlanName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordPlanName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/keywordPlans/{keyword_plan}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeywordPlanName"/> if successful.</returns>
        public static KeywordPlanName Parse(string keywordPlanName, bool allowUnparsed) =>
            TryParse(keywordPlanName, allowUnparsed, out KeywordPlanName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/keywordPlans/{keyword_plan}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="keywordPlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanName, out KeywordPlanName result) =>
            TryParse(keywordPlanName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordPlanName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/keywordPlans/{keyword_plan}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordPlanName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordPlanName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordPlanName, bool allowUnparsed, out KeywordPlanName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordPlanName, nameof(keywordPlanName));
            gax::TemplatedResourceName resourceName;
            if (s_customerKeywordPlan.TryParseName(keywordPlanName, out resourceName))
            {
                result = FromCustomerKeywordPlan(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keywordPlanName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KeywordPlanName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string keywordPlanId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            KeywordPlanId = keywordPlanId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeywordPlanName"/> class from the component parts of pattern
        /// <c>customers/{customer}/keywordPlans/{keyword_plan}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordPlanId">The <c>KeywordPlan</c> ID. Must not be <c>null</c> or empty.</param>
        public KeywordPlanName(string customerId, string keywordPlanId) : this(ResourceNameType.CustomerKeywordPlan, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordPlanId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlanId, nameof(keywordPlanId)))
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
        /// The <c>KeywordPlan</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeywordPlanId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerKeywordPlan: return s_customerKeywordPlan.Expand(CustomerId, KeywordPlanId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeywordPlanName);

        /// <inheritdoc/>
        public bool Equals(KeywordPlanName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(KeywordPlanName a, KeywordPlanName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(KeywordPlanName a, KeywordPlanName b) => !(a == b);
    }

    public partial class KeywordPlan
    {
        /// <summary>
        /// <see cref="gagvr::KeywordPlanName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        public gagvr::KeywordPlanName ResourceNameAsKeywordPlanName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::KeywordPlanName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::KeywordPlanName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        public gagvr::KeywordPlanName KeywordPlanName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::KeywordPlanName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

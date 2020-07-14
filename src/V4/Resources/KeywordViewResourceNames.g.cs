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

namespace Google.Ads.GoogleAds.V4.Resources
{
    /// <summary>Resource name for the <c>KeywordView</c> resource.</summary>
    public sealed partial class KeywordViewName : gax::IResourceName, sys::IEquatable<KeywordViewName>
    {
        /// <summary>The possible contents of <see cref="KeywordViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer}/keywordViews/{keyword_view}</c>.</summary>
            CustomerKeywordView = 1
        }

        private static gax::PathTemplate s_customerKeywordView = new gax::PathTemplate("customers/{customer}/keywordViews/{keyword_view}");

        /// <summary>Creates a <see cref="KeywordViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="KeywordViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static KeywordViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new KeywordViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="KeywordViewName"/> with the pattern <c>customers/{customer}/keywordViews/{keyword_view}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordViewId">The <c>KeywordView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="KeywordViewName"/> constructed from the provided ids.</returns>
        public static KeywordViewName FromCustomerKeywordView(string customerId, string keywordViewId) =>
            new KeywordViewName(ResourceNameType.CustomerKeywordView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordViewId, nameof(keywordViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordViewName"/> with pattern
        /// <c>customers/{customer}/keywordViews/{keyword_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordViewId">The <c>KeywordView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KeywordViewName"/> with pattern
        /// <c>customers/{customer}/keywordViews/{keyword_view}</c>.
        /// </returns>
        public static string Format(string customerId, string keywordViewId) =>
            FormatCustomerKeywordView(customerId, keywordViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="KeywordViewName"/> with pattern
        /// <c>customers/{customer}/keywordViews/{keyword_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordViewId">The <c>KeywordView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="KeywordViewName"/> with pattern
        /// <c>customers/{customer}/keywordViews/{keyword_view}</c>.
        /// </returns>
        public static string FormatCustomerKeywordView(string customerId, string keywordViewId) =>
            s_customerKeywordView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(keywordViewId, nameof(keywordViewId)));

        /// <summary>Parses the given resource name string into a new <see cref="KeywordViewName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/keywordViews/{keyword_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="keywordViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="KeywordViewName"/> if successful.</returns>
        public static KeywordViewName Parse(string keywordViewName) => Parse(keywordViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="KeywordViewName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/keywordViews/{keyword_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="KeywordViewName"/> if successful.</returns>
        public static KeywordViewName Parse(string keywordViewName, bool allowUnparsed) =>
            TryParse(keywordViewName, allowUnparsed, out KeywordViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/keywordViews/{keyword_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="keywordViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordViewName, out KeywordViewName result) =>
            TryParse(keywordViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="KeywordViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/keywordViews/{keyword_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="keywordViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="KeywordViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string keywordViewName, bool allowUnparsed, out KeywordViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(keywordViewName, nameof(keywordViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerKeywordView.TryParseName(keywordViewName, out resourceName))
            {
                result = FromCustomerKeywordView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(keywordViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private KeywordViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string keywordViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            KeywordViewId = keywordViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="KeywordViewName"/> class from the component parts of pattern
        /// <c>customers/{customer}/keywordViews/{keyword_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="keywordViewId">The <c>KeywordView</c> ID. Must not be <c>null</c> or empty.</param>
        public KeywordViewName(string customerId, string keywordViewId) : this(ResourceNameType.CustomerKeywordView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), keywordViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(keywordViewId, nameof(keywordViewId)))
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
        /// The <c>KeywordView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string KeywordViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerKeywordView: return s_customerKeywordView.Expand(CustomerId, KeywordViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as KeywordViewName);

        /// <inheritdoc/>
        public bool Equals(KeywordViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(KeywordViewName a, KeywordViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(KeywordViewName a, KeywordViewName b) => !(a == b);
    }

    public partial class KeywordView
    {
        /// <summary>
        /// <see cref="KeywordViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal KeywordViewName ResourceNameAsKeywordViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : KeywordViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

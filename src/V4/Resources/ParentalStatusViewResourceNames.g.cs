// Copyright 2021 Google LLC
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
    /// <summary>Resource name for the <c>ParentalStatusView</c> resource.</summary>
    public sealed partial class ParentalStatusViewName : gax::IResourceName, sys::IEquatable<ParentalStatusViewName>
    {
        /// <summary>The possible contents of <see cref="ParentalStatusViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/parentalStatusViews/{parental_status_view}</c>.
            /// </summary>
            CustomerParentalStatusView = 1,
        }

        private static gax::PathTemplate s_customerParentalStatusView = new gax::PathTemplate("customers/{customer}/parentalStatusViews/{parental_status_view}");

        /// <summary>Creates a <see cref="ParentalStatusViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ParentalStatusViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ParentalStatusViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ParentalStatusViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ParentalStatusViewName"/> with the pattern
        /// <c>customers/{customer}/parentalStatusViews/{parental_status_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parentalStatusViewId">
        /// The <c>ParentalStatusView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="ParentalStatusViewName"/> constructed from the provided ids.</returns>
        public static ParentalStatusViewName FromCustomerParentalStatusView(string customerId, string parentalStatusViewId) =>
            new ParentalStatusViewName(ResourceNameType.CustomerParentalStatusView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), parentalStatusViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(parentalStatusViewId, nameof(parentalStatusViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParentalStatusViewName"/> with pattern
        /// <c>customers/{customer}/parentalStatusViews/{parental_status_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parentalStatusViewId">
        /// The <c>ParentalStatusView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ParentalStatusViewName"/> with pattern
        /// <c>customers/{customer}/parentalStatusViews/{parental_status_view}</c>.
        /// </returns>
        public static string Format(string customerId, string parentalStatusViewId) =>
            FormatCustomerParentalStatusView(customerId, parentalStatusViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ParentalStatusViewName"/> with pattern
        /// <c>customers/{customer}/parentalStatusViews/{parental_status_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parentalStatusViewId">
        /// The <c>ParentalStatusView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ParentalStatusViewName"/> with pattern
        /// <c>customers/{customer}/parentalStatusViews/{parental_status_view}</c>.
        /// </returns>
        public static string FormatCustomerParentalStatusView(string customerId, string parentalStatusViewId) =>
            s_customerParentalStatusView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(parentalStatusViewId, nameof(parentalStatusViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ParentalStatusViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/parentalStatusViews/{parental_status_view}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="parentalStatusViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ParentalStatusViewName"/> if successful.</returns>
        public static ParentalStatusViewName Parse(string parentalStatusViewName) => Parse(parentalStatusViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ParentalStatusViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/parentalStatusViews/{parental_status_view}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="parentalStatusViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ParentalStatusViewName"/> if successful.</returns>
        public static ParentalStatusViewName Parse(string parentalStatusViewName, bool allowUnparsed) =>
            TryParse(parentalStatusViewName, allowUnparsed, out ParentalStatusViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParentalStatusViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/parentalStatusViews/{parental_status_view}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="parentalStatusViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParentalStatusViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string parentalStatusViewName, out ParentalStatusViewName result) =>
            TryParse(parentalStatusViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ParentalStatusViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/parentalStatusViews/{parental_status_view}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="parentalStatusViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ParentalStatusViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string parentalStatusViewName, bool allowUnparsed, out ParentalStatusViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(parentalStatusViewName, nameof(parentalStatusViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerParentalStatusView.TryParseName(parentalStatusViewName, out resourceName))
            {
                result = FromCustomerParentalStatusView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(parentalStatusViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ParentalStatusViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string parentalStatusViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            ParentalStatusViewId = parentalStatusViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ParentalStatusViewName"/> class from the component parts of
        /// pattern <c>customers/{customer}/parentalStatusViews/{parental_status_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="parentalStatusViewId">
        /// The <c>ParentalStatusView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ParentalStatusViewName(string customerId, string parentalStatusViewId) : this(ResourceNameType.CustomerParentalStatusView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), parentalStatusViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(parentalStatusViewId, nameof(parentalStatusViewId)))
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
        /// The <c>ParentalStatusView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ParentalStatusViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerParentalStatusView: return s_customerParentalStatusView.Expand(CustomerId, ParentalStatusViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ParentalStatusViewName);

        /// <inheritdoc/>
        public bool Equals(ParentalStatusViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ParentalStatusViewName a, ParentalStatusViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ParentalStatusViewName a, ParentalStatusViewName b) => !(a == b);
    }

    public partial class ParentalStatusView
    {
        /// <summary>
        /// <see cref="ParentalStatusViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal ParentalStatusViewName ResourceNameAsParentalStatusViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ParentalStatusViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

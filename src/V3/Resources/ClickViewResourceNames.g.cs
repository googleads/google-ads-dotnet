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
    /// <summary>Resource name for the <c>ClickView</c> resource.</summary>
    public sealed partial class ClickViewName : gax::IResourceName, sys::IEquatable<ClickViewName>
    {
        /// <summary>The possible contents of <see cref="ClickViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer}/clickViews/{click_view}</c>.</summary>
            CustomerClickView = 1
        }

        private static gax::PathTemplate s_customerClickView = new gax::PathTemplate("customers/{customer}/clickViews/{click_view}");

        /// <summary>Creates a <see cref="ClickViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ClickViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ClickViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ClickViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ClickViewName"/> with the pattern <c>customers/{customer}/clickViews/{click_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clickViewId">The <c>ClickView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ClickViewName"/> constructed from the provided ids.</returns>
        public static ClickViewName FromCustomerClickView(string customerId, string clickViewId) =>
            new ClickViewName(ResourceNameType.CustomerClickView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), clickViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(clickViewId, nameof(clickViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClickViewName"/> with pattern
        /// <c>customers/{customer}/clickViews/{click_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clickViewId">The <c>ClickView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClickViewName"/> with pattern
        /// <c>customers/{customer}/clickViews/{click_view}</c>.
        /// </returns>
        public static string Format(string customerId, string clickViewId) => FormatCustomerClickView(customerId, clickViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ClickViewName"/> with pattern
        /// <c>customers/{customer}/clickViews/{click_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clickViewId">The <c>ClickView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ClickViewName"/> with pattern
        /// <c>customers/{customer}/clickViews/{click_view}</c>.
        /// </returns>
        public static string FormatCustomerClickView(string customerId, string clickViewId) =>
            s_customerClickView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clickViewId, nameof(clickViewId)));

        /// <summary>Parses the given resource name string into a new <see cref="ClickViewName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/clickViews/{click_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="clickViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ClickViewName"/> if successful.</returns>
        public static ClickViewName Parse(string clickViewName) => Parse(clickViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ClickViewName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/clickViews/{click_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clickViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ClickViewName"/> if successful.</returns>
        public static ClickViewName Parse(string clickViewName, bool allowUnparsed) =>
            TryParse(clickViewName, allowUnparsed, out ClickViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClickViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/clickViews/{click_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="clickViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClickViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clickViewName, out ClickViewName result) => TryParse(clickViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ClickViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/clickViews/{click_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="clickViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ClickViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string clickViewName, bool allowUnparsed, out ClickViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(clickViewName, nameof(clickViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerClickView.TryParseName(clickViewName, out resourceName))
            {
                result = FromCustomerClickView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(clickViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ClickViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clickViewId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClickViewId = clickViewId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ClickViewName"/> class from the component parts of pattern
        /// <c>customers/{customer}/clickViews/{click_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clickViewId">The <c>ClickView</c> ID. Must not be <c>null</c> or empty.</param>
        public ClickViewName(string customerId, string clickViewId) : this(ResourceNameType.CustomerClickView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), clickViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(clickViewId, nameof(clickViewId)))
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
        /// The <c>ClickView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClickViewId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerClickView: return s_customerClickView.Expand(CustomerId, ClickViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ClickViewName);

        /// <inheritdoc/>
        public bool Equals(ClickViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ClickViewName a, ClickViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ClickViewName a, ClickViewName b) => !(a == b);
    }

    public partial class ClickView
    {
        /// <summary>
        /// <see cref="ClickViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal ClickViewName ResourceNameAsClickViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ClickViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupAdName"/>-typed view over the <see cref="AdGroupAd"/> resource name property.
        /// </summary>
        internal AdGroupAdName AdGroupAdAsAdGroupAdName
        {
            get => string.IsNullOrEmpty(AdGroupAd) ? null : AdGroupAdName.Parse(AdGroupAd, allowUnparsed: true);
            set => AdGroupAd = value?.ToString() ?? "";
        }
    }
}

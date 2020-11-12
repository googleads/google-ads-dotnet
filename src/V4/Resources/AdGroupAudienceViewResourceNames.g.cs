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
    /// <summary>Resource name for the <c>AdGroupAudienceView</c> resource.</summary>
    public sealed partial class AdGroupAudienceViewName : gax::IResourceName, sys::IEquatable<AdGroupAudienceViewName>
    {
        /// <summary>The possible contents of <see cref="AdGroupAudienceViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c>.
            /// </summary>
            CustomerAdGroupAudienceView = 1,
        }

        private static gax::PathTemplate s_customerAdGroupAudienceView = new gax::PathTemplate("customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}");

        /// <summary>Creates a <see cref="AdGroupAudienceViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupAudienceViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupAudienceViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupAudienceViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupAudienceViewName"/> with the pattern
        /// <c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAudienceViewId">
        /// The <c>AdGroupAudienceView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AdGroupAudienceViewName"/> constructed from the provided ids.
        /// </returns>
        public static AdGroupAudienceViewName FromCustomerAdGroupAudienceView(string customerId, string adGroupAudienceViewId) =>
            new AdGroupAudienceViewName(ResourceNameType.CustomerAdGroupAudienceView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupAudienceViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAudienceViewId, nameof(adGroupAudienceViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAudienceViewName"/> with pattern
        /// <c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAudienceViewId">
        /// The <c>AdGroupAudienceView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAudienceViewName"/> with pattern
        /// <c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupAudienceViewId) =>
            FormatCustomerAdGroupAudienceView(customerId, adGroupAudienceViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAudienceViewName"/> with pattern
        /// <c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAudienceViewId">
        /// The <c>AdGroupAudienceView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAudienceViewName"/> with pattern
        /// <c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupAudienceView(string customerId, string adGroupAudienceViewId) =>
            s_customerAdGroupAudienceView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAudienceViewId, nameof(adGroupAudienceViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAudienceViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAudienceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupAudienceViewName"/> if successful.</returns>
        public static AdGroupAudienceViewName Parse(string adGroupAudienceViewName) => Parse(adGroupAudienceViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAudienceViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAudienceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupAudienceViewName"/> if successful.</returns>
        public static AdGroupAudienceViewName Parse(string adGroupAudienceViewName, bool allowUnparsed) =>
            TryParse(adGroupAudienceViewName, allowUnparsed, out AdGroupAudienceViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAudienceViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAudienceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAudienceViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAudienceViewName, out AdGroupAudienceViewName result) =>
            TryParse(adGroupAudienceViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAudienceViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAudienceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAudienceViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAudienceViewName, bool allowUnparsed, out AdGroupAudienceViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAudienceViewName, nameof(adGroupAudienceViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupAudienceView.TryParseName(adGroupAudienceViewName, out resourceName))
            {
                result = FromCustomerAdGroupAudienceView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupAudienceViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupAudienceViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupAudienceViewId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupAudienceViewId = adGroupAudienceViewId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupAudienceViewName"/> class from the component parts of
        /// pattern <c>customers/{customer}/adGroupAudienceViews/{ad_group_audience_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAudienceViewId">
        /// The <c>AdGroupAudienceView</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AdGroupAudienceViewName(string customerId, string adGroupAudienceViewId) : this(ResourceNameType.CustomerAdGroupAudienceView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupAudienceViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAudienceViewId, nameof(adGroupAudienceViewId)))
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
        /// The <c>AdGroupAudienceView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AdGroupAudienceViewId { get; }

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
                case ResourceNameType.CustomerAdGroupAudienceView: return s_customerAdGroupAudienceView.Expand(CustomerId, AdGroupAudienceViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupAudienceViewName);

        /// <inheritdoc/>
        public bool Equals(AdGroupAudienceViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupAudienceViewName a, AdGroupAudienceViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupAudienceViewName a, AdGroupAudienceViewName b) => !(a == b);
    }

    public partial class AdGroupAudienceView
    {
        /// <summary>
        /// <see cref="AdGroupAudienceViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupAudienceViewName ResourceNameAsAdGroupAudienceViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupAudienceViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

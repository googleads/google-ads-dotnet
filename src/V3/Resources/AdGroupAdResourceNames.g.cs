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
    /// <summary>Resource name for the <c>AdGroupAd</c> resource.</summary>
    public sealed partial class AdGroupAdName : gax::IResourceName, sys::IEquatable<AdGroupAdName>
    {
        /// <summary>The possible contents of <see cref="AdGroupAdName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer}/adGroupAds/{ad_group_ad}</c>.</summary>
            CustomerAdGroupAd = 1
        }

        private static gax::PathTemplate s_customerAdGroupAd = new gax::PathTemplate("customers/{customer}/adGroupAds/{ad_group_ad}");

        /// <summary>Creates a <see cref="AdGroupAdName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupAdName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupAdName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupAdName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupAdName"/> with the pattern <c>customers/{customer}/adGroupAds/{ad_group_ad}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdId">The <c>AdGroupAd</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdGroupAdName"/> constructed from the provided ids.</returns>
        public static AdGroupAdName FromCustomerAdGroupAd(string customerId, string adGroupAdId) =>
            new AdGroupAdName(ResourceNameType.CustomerAdGroupAd, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupAdId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAdId, nameof(adGroupAdId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAdName"/> with pattern
        /// <c>customers/{customer}/adGroupAds/{ad_group_ad}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdId">The <c>AdGroupAd</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAdName"/> with pattern
        /// <c>customers/{customer}/adGroupAds/{ad_group_ad}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupAdId) => FormatCustomerAdGroupAd(customerId, adGroupAdId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAdName"/> with pattern
        /// <c>customers/{customer}/adGroupAds/{ad_group_ad}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdId">The <c>AdGroupAd</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAdName"/> with pattern
        /// <c>customers/{customer}/adGroupAds/{ad_group_ad}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupAd(string customerId, string adGroupAdId) =>
            s_customerAdGroupAd.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAdId, nameof(adGroupAdId)));

        /// <summary>Parses the given resource name string into a new <see cref="AdGroupAdName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupAds/{ad_group_ad}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAdName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupAdName"/> if successful.</returns>
        public static AdGroupAdName Parse(string adGroupAdName) => Parse(adGroupAdName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAdName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupAds/{ad_group_ad}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAdName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupAdName"/> if successful.</returns>
        public static AdGroupAdName Parse(string adGroupAdName, bool allowUnparsed) =>
            TryParse(adGroupAdName, allowUnparsed, out AdGroupAdName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAdName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupAds/{ad_group_ad}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAdName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAdName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdName, out AdGroupAdName result) => TryParse(adGroupAdName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAdName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupAds/{ad_group_ad}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAdName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAdName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdName, bool allowUnparsed, out AdGroupAdName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAdName, nameof(adGroupAdName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupAd.TryParseName(adGroupAdName, out resourceName))
            {
                result = FromCustomerAdGroupAd(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupAdName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupAdName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupAdId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupAdId = adGroupAdId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupAdName"/> class from the component parts of pattern
        /// <c>customers/{customer}/adGroupAds/{ad_group_ad}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdId">The <c>AdGroupAd</c> ID. Must not be <c>null</c> or empty.</param>
        public AdGroupAdName(string customerId, string adGroupAdId) : this(ResourceNameType.CustomerAdGroupAd, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupAdId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAdId, nameof(adGroupAdId)))
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
        /// The <c>AdGroupAd</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdGroupAdId { get; }

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
                case ResourceNameType.CustomerAdGroupAd: return s_customerAdGroupAd.Expand(CustomerId, AdGroupAdId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupAdName);

        /// <inheritdoc/>
        public bool Equals(AdGroupAdName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupAdName a, AdGroupAdName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupAdName a, AdGroupAdName b) => !(a == b);
    }

    public partial class AdGroupAd
    {
        /// <summary>
        /// <see cref="AdGroupAdName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupAdName ResourceNameAsAdGroupAdName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupAdName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupName"/>-typed view over the <see cref="AdGroup"/> resource name property.
        /// </summary>
        internal AdGroupName AdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(AdGroup) ? null : AdGroupName.Parse(AdGroup, allowUnparsed: true);
            set => AdGroup = value?.ToString() ?? "";
        }
    }
}

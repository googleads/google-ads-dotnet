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

using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V4.Resources
{
    /// <summary>Resource name for the <c>Ad</c> resource.</summary>
    public sealed partial class AdName : gax::IResourceName, sys::IEquatable<AdName>
    {
        /// <summary>The possible contents of <see cref="AdName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer}/ads/{ad}</c>.</summary>
            CustomerAd = 1,
        }

        private static gax::PathTemplate s_customerAd = new gax::PathTemplate("customers/{customer}/ads/{ad}");

        /// <summary>Creates a <see cref="AdName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>Creates a <see cref="AdName"/> with the pattern <c>customers/{customer}/ads/{ad}</c>.</summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adId">The <c>Ad</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdName"/> constructed from the provided ids.</returns>
        public static AdName FromCustomerAd(string customerId, string adId) =>
            new AdName(ResourceNameType.CustomerAd, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adId: gax::GaxPreconditions.CheckNotNullOrEmpty(adId, nameof(adId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdName"/> with pattern
        /// <c>customers/{customer}/ads/{ad}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adId">The <c>Ad</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdName"/> with pattern <c>customers/{customer}/ads/{ad}</c>.
        /// </returns>
        public static string Format(string customerId, string adId) => FormatCustomerAd(customerId, adId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdName"/> with pattern
        /// <c>customers/{customer}/ads/{ad}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adId">The <c>Ad</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdName"/> with pattern <c>customers/{customer}/ads/{ad}</c>.
        /// </returns>
        public static string FormatCustomerAd(string customerId, string adId) =>
            s_customerAd.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adId, nameof(adId)));

        /// <summary>Parses the given resource name string into a new <see cref="AdName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>customers/{customer}/ads/{ad}</c></description></item></list>
        /// </remarks>
        /// <param name="adName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdName"/> if successful.</returns>
        public static AdName Parse(string adName) => Parse(adName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>customers/{customer}/ads/{ad}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdName"/> if successful.</returns>
        public static AdName Parse(string adName, bool allowUnparsed) =>
            TryParse(adName, allowUnparsed, out AdName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>Tries to parse the given resource name string into a new <see cref="AdName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>customers/{customer}/ads/{ad}</c></description></item></list>
        /// </remarks>
        /// <param name="adName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adName, out AdName result) => TryParse(adName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>customers/{customer}/ads/{ad}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adName, bool allowUnparsed, out AdName result)
        {
            gax::GaxPreconditions.CheckNotNull(adName, nameof(adName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAd.TryParseName(adName, out resourceName))
            {
                result = FromCustomerAd(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdId = adId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdName"/> class from the component parts of pattern
        /// <c>customers/{customer}/ads/{ad}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adId">The <c>Ad</c> ID. Must not be <c>null</c> or empty.</param>
        public AdName(string customerId, string adId) : this(ResourceNameType.CustomerAd, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adId: gax::GaxPreconditions.CheckNotNullOrEmpty(adId, nameof(adId)))
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
        /// The <c>Ad</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdId { get; }

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
                case ResourceNameType.CustomerAd: return s_customerAd.Expand(CustomerId, AdId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdName);

        /// <inheritdoc/>
        public bool Equals(AdName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdName a, AdName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdName a, AdName b) => !(a == b);
    }

    public partial class Ad
    {
        /// <summary>
        /// <see cref="gagvr::AdName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal AdName AdName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::AdName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::AdName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdName ResourceNameAsAdName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::AdName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

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

namespace Google.Ads.GoogleAds.V5.Resources
{
    /// <summary>Resource name for the <c>AdGroupBidModifier</c> resource.</summary>
    public sealed partial class AdGroupBidModifierName : gax::IResourceName, sys::IEquatable<AdGroupBidModifierName>
    {
        /// <summary>The possible contents of <see cref="AdGroupBidModifierName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c>.
            /// </summary>
            CustomerAdGroupBidModifier = 1,
        }

        private static gax::PathTemplate s_customerAdGroupBidModifier = new gax::PathTemplate("customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}");

        /// <summary>Creates a <see cref="AdGroupBidModifierName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupBidModifierName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupBidModifierName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupBidModifierName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupBidModifierName"/> with the pattern
        /// <c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupBidModifierId">
        /// The <c>AdGroupBidModifier</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="AdGroupBidModifierName"/> constructed from the provided ids.</returns>
        public static AdGroupBidModifierName FromCustomerAdGroupBidModifier(string customerId, string adGroupBidModifierId) =>
            new AdGroupBidModifierName(ResourceNameType.CustomerAdGroupBidModifier, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupBidModifierId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupBidModifierId, nameof(adGroupBidModifierId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupBidModifierName"/> with pattern
        /// <c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupBidModifierId">
        /// The <c>AdGroupBidModifier</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupBidModifierName"/> with pattern
        /// <c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupBidModifierId) =>
            FormatCustomerAdGroupBidModifier(customerId, adGroupBidModifierId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupBidModifierName"/> with pattern
        /// <c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupBidModifierId">
        /// The <c>AdGroupBidModifier</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupBidModifierName"/> with pattern
        /// <c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupBidModifier(string customerId, string adGroupBidModifierId) =>
            s_customerAdGroupBidModifier.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupBidModifierId, nameof(adGroupBidModifierId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupBidModifierName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupBidModifierName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupBidModifierName"/> if successful.</returns>
        public static AdGroupBidModifierName Parse(string adGroupBidModifierName) => Parse(adGroupBidModifierName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupBidModifierName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupBidModifierName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupBidModifierName"/> if successful.</returns>
        public static AdGroupBidModifierName Parse(string adGroupBidModifierName, bool allowUnparsed) =>
            TryParse(adGroupBidModifierName, allowUnparsed, out AdGroupBidModifierName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupBidModifierName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupBidModifierName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupBidModifierName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupBidModifierName, out AdGroupBidModifierName result) =>
            TryParse(adGroupBidModifierName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupBidModifierName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupBidModifierName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupBidModifierName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupBidModifierName, bool allowUnparsed, out AdGroupBidModifierName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupBidModifierName, nameof(adGroupBidModifierName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupBidModifier.TryParseName(adGroupBidModifierName, out resourceName))
            {
                result = FromCustomerAdGroupBidModifier(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupBidModifierName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupBidModifierName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupBidModifierId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupBidModifierId = adGroupBidModifierId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupBidModifierName"/> class from the component parts of
        /// pattern <c>customers/{customer}/adGroupBidModifiers/{ad_group_bid_modifier}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupBidModifierId">
        /// The <c>AdGroupBidModifier</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AdGroupBidModifierName(string customerId, string adGroupBidModifierId) : this(ResourceNameType.CustomerAdGroupBidModifier, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupBidModifierId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupBidModifierId, nameof(adGroupBidModifierId)))
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
        /// The <c>AdGroupBidModifier</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AdGroupBidModifierId { get; }

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
                case ResourceNameType.CustomerAdGroupBidModifier: return s_customerAdGroupBidModifier.Expand(CustomerId, AdGroupBidModifierId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupBidModifierName);

        /// <inheritdoc/>
        public bool Equals(AdGroupBidModifierName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupBidModifierName a, AdGroupBidModifierName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupBidModifierName a, AdGroupBidModifierName b) => !(a == b);
    }

    public partial class AdGroupBidModifier
    {
        /// <summary>
        /// <see cref="AdGroupBidModifierName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupBidModifierName ResourceNameAsAdGroupBidModifierName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupBidModifierName.Parse(ResourceName, allowUnparsed: true);
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

        /// <summary>
        /// <see cref="AdGroupName"/>-typed view over the <see cref="BaseAdGroup"/> resource name property.
        /// </summary>
        internal AdGroupName BaseAdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(BaseAdGroup) ? null : AdGroupName.Parse(BaseAdGroup, allowUnparsed: true);
            set => BaseAdGroup = value?.ToString() ?? "";
        }
    }
}

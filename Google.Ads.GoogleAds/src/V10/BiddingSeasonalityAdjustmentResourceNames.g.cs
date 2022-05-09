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

using gagvr = Google.Ads.GoogleAds.V10.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V10.Resources
{
    /// <summary>Resource name for the <c>BiddingSeasonalityAdjustment</c> resource.</summary>
    public sealed partial class BiddingSeasonalityAdjustmentName : gax::IResourceName, sys::IEquatable<BiddingSeasonalityAdjustmentName>
    {
        /// <summary>The possible contents of <see cref="BiddingSeasonalityAdjustmentName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>.
            /// </summary>
            CustomerSeasonalityEvent = 1,
        }

        private static gax::PathTemplate s_customerSeasonalityEvent = new gax::PathTemplate("customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}");

        /// <summary>
        /// Creates a <see cref="BiddingSeasonalityAdjustmentName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="BiddingSeasonalityAdjustmentName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static BiddingSeasonalityAdjustmentName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new BiddingSeasonalityAdjustmentName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="BiddingSeasonalityAdjustmentName"/> with the pattern
        /// <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="seasonalityEventId">The <c>SeasonalityEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="BiddingSeasonalityAdjustmentName"/> constructed from the provided ids.
        /// </returns>
        public static BiddingSeasonalityAdjustmentName FromCustomerSeasonalityEvent(string customerId, string seasonalityEventId) =>
            new BiddingSeasonalityAdjustmentName(ResourceNameType.CustomerSeasonalityEvent, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), seasonalityEventId: gax::GaxPreconditions.CheckNotNullOrEmpty(seasonalityEventId, nameof(seasonalityEventId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BiddingSeasonalityAdjustmentName"/> with
        /// pattern <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="seasonalityEventId">The <c>SeasonalityEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BiddingSeasonalityAdjustmentName"/> with pattern
        /// <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>.
        /// </returns>
        public static string Format(string customerId, string seasonalityEventId) =>
            FormatCustomerSeasonalityEvent(customerId, seasonalityEventId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="BiddingSeasonalityAdjustmentName"/> with
        /// pattern <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="seasonalityEventId">The <c>SeasonalityEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="BiddingSeasonalityAdjustmentName"/> with pattern
        /// <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>.
        /// </returns>
        public static string FormatCustomerSeasonalityEvent(string customerId, string seasonalityEventId) =>
            s_customerSeasonalityEvent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(seasonalityEventId, nameof(seasonalityEventId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BiddingSeasonalityAdjustmentName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="biddingSeasonalityAdjustmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="BiddingSeasonalityAdjustmentName"/> if successful.</returns>
        public static BiddingSeasonalityAdjustmentName Parse(string biddingSeasonalityAdjustmentName) =>
            Parse(biddingSeasonalityAdjustmentName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="BiddingSeasonalityAdjustmentName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="biddingSeasonalityAdjustmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="BiddingSeasonalityAdjustmentName"/> if successful.</returns>
        public static BiddingSeasonalityAdjustmentName Parse(string biddingSeasonalityAdjustmentName, bool allowUnparsed) =>
            TryParse(biddingSeasonalityAdjustmentName, allowUnparsed, out BiddingSeasonalityAdjustmentName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BiddingSeasonalityAdjustmentName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="biddingSeasonalityAdjustmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BiddingSeasonalityAdjustmentName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string biddingSeasonalityAdjustmentName, out BiddingSeasonalityAdjustmentName result) =>
            TryParse(biddingSeasonalityAdjustmentName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="BiddingSeasonalityAdjustmentName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="biddingSeasonalityAdjustmentName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="BiddingSeasonalityAdjustmentName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string biddingSeasonalityAdjustmentName, bool allowUnparsed, out BiddingSeasonalityAdjustmentName result)
        {
            gax::GaxPreconditions.CheckNotNull(biddingSeasonalityAdjustmentName, nameof(biddingSeasonalityAdjustmentName));
            gax::TemplatedResourceName resourceName;
            if (s_customerSeasonalityEvent.TryParseName(biddingSeasonalityAdjustmentName, out resourceName))
            {
                result = FromCustomerSeasonalityEvent(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(biddingSeasonalityAdjustmentName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private BiddingSeasonalityAdjustmentName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string seasonalityEventId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            SeasonalityEventId = seasonalityEventId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="BiddingSeasonalityAdjustmentName"/> class from the component parts
        /// of pattern <c>customers/{customer_id}/biddingSeasonalityAdjustments/{seasonality_event_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="seasonalityEventId">The <c>SeasonalityEvent</c> ID. Must not be <c>null</c> or empty.</param>
        public BiddingSeasonalityAdjustmentName(string customerId, string seasonalityEventId) : this(ResourceNameType.CustomerSeasonalityEvent, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), seasonalityEventId: gax::GaxPreconditions.CheckNotNullOrEmpty(seasonalityEventId, nameof(seasonalityEventId)))
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
        /// The <c>SeasonalityEvent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SeasonalityEventId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerSeasonalityEvent: return s_customerSeasonalityEvent.Expand(CustomerId, SeasonalityEventId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as BiddingSeasonalityAdjustmentName);

        /// <inheritdoc/>
        public bool Equals(BiddingSeasonalityAdjustmentName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(BiddingSeasonalityAdjustmentName a, BiddingSeasonalityAdjustmentName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(BiddingSeasonalityAdjustmentName a, BiddingSeasonalityAdjustmentName b) => !(a == b);
    }

    public partial class BiddingSeasonalityAdjustment
    {
        /// <summary>
        /// <see cref="gagvr::BiddingSeasonalityAdjustmentName"/>-typed view over the <see cref="ResourceName"/>
        /// resource name property.
        /// </summary>
        internal gagvr::BiddingSeasonalityAdjustmentName ResourceNameAsBiddingSeasonalityAdjustmentName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::BiddingSeasonalityAdjustmentName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::BiddingSeasonalityAdjustmentName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        internal gagvr::BiddingSeasonalityAdjustmentName BiddingSeasonalityAdjustmentName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::BiddingSeasonalityAdjustmentName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaigns"/> resource name property.
        /// </summary>
        internal gax::ResourceNameList<CampaignName> CampaignsAsCampaignNames
        {
            get => new gax::ResourceNameList<CampaignName>(Campaigns, s => string.IsNullOrEmpty(s) ? null : CampaignName.Parse(s, allowUnparsed: true));
        }
    }
}

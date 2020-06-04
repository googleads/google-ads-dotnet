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

namespace Google.Ads.GoogleAds.V2.Resources
{
    /// <summary>Resource name for the <c>HotelGroupView</c> resource.</summary>
    public sealed partial class HotelGroupViewName : gax::IResourceName, sys::IEquatable<HotelGroupViewName>
    {
        /// <summary>The possible contents of <see cref="HotelGroupViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c>.
            /// </summary>
            CustomerHotelGroupView = 1
        }

        private static gax::PathTemplate s_customerHotelGroupView = new gax::PathTemplate("customers/{customer}/hotelGroupViews/{hotel_group_view}");

        /// <summary>Creates a <see cref="HotelGroupViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HotelGroupViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HotelGroupViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HotelGroupViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HotelGroupViewName"/> with the pattern
        /// <c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hotelGroupViewId">The <c>HotelGroupView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="HotelGroupViewName"/> constructed from the provided ids.</returns>
        public static HotelGroupViewName FromCustomerHotelGroupView(string customerId, string hotelGroupViewId) =>
            new HotelGroupViewName(ResourceNameType.CustomerHotelGroupView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), hotelGroupViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(hotelGroupViewId, nameof(hotelGroupViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HotelGroupViewName"/> with pattern
        /// <c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hotelGroupViewId">The <c>HotelGroupView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HotelGroupViewName"/> with pattern
        /// <c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c>.
        /// </returns>
        public static string Format(string customerId, string hotelGroupViewId) =>
            FormatCustomerHotelGroupView(customerId, hotelGroupViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HotelGroupViewName"/> with pattern
        /// <c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hotelGroupViewId">The <c>HotelGroupView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HotelGroupViewName"/> with pattern
        /// <c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c>.
        /// </returns>
        public static string FormatCustomerHotelGroupView(string customerId, string hotelGroupViewId) =>
            s_customerHotelGroupView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(hotelGroupViewId, nameof(hotelGroupViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HotelGroupViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="hotelGroupViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HotelGroupViewName"/> if successful.</returns>
        public static HotelGroupViewName Parse(string hotelGroupViewName) => Parse(hotelGroupViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HotelGroupViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hotelGroupViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HotelGroupViewName"/> if successful.</returns>
        public static HotelGroupViewName Parse(string hotelGroupViewName, bool allowUnparsed) =>
            TryParse(hotelGroupViewName, allowUnparsed, out HotelGroupViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HotelGroupViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="hotelGroupViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HotelGroupViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hotelGroupViewName, out HotelGroupViewName result) =>
            TryParse(hotelGroupViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HotelGroupViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hotelGroupViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HotelGroupViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hotelGroupViewName, bool allowUnparsed, out HotelGroupViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(hotelGroupViewName, nameof(hotelGroupViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerHotelGroupView.TryParseName(hotelGroupViewName, out resourceName))
            {
                result = FromCustomerHotelGroupView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hotelGroupViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HotelGroupViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string hotelGroupViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            HotelGroupViewId = hotelGroupViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HotelGroupViewName"/> class from the component parts of pattern
        /// <c>customers/{customer}/hotelGroupViews/{hotel_group_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="hotelGroupViewId">The <c>HotelGroupView</c> ID. Must not be <c>null</c> or empty.</param>
        public HotelGroupViewName(string customerId, string hotelGroupViewId) : this(ResourceNameType.CustomerHotelGroupView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), hotelGroupViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(hotelGroupViewId, nameof(hotelGroupViewId)))
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
        /// The <c>HotelGroupView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string HotelGroupViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerHotelGroupView: return s_customerHotelGroupView.Expand(CustomerId, HotelGroupViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HotelGroupViewName);

        /// <inheritdoc/>
        public bool Equals(HotelGroupViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(HotelGroupViewName a, HotelGroupViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(HotelGroupViewName a, HotelGroupViewName b) => !(a == b);
    }

    public partial class HotelGroupView
    {
        /// <summary>
        /// <see cref="HotelGroupViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal HotelGroupViewName ResourceNameAsHotelGroupViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : HotelGroupViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

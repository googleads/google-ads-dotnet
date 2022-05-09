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

namespace Google.Ads.GoogleAds.V9.Resources
{
    /// <summary>Resource name for the <c>HotelPerformanceView</c> resource.</summary>
    public sealed partial class HotelPerformanceViewName : gax::IResourceName, sys::IEquatable<HotelPerformanceViewName>
    {
        /// <summary>The possible contents of <see cref="HotelPerformanceViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/hotelPerformanceView</c>.</summary>
            Customer = 1,
        }

        private static gax::PathTemplate s_customer = new gax::PathTemplate("customers/{customer_id}/hotelPerformanceView");

        /// <summary>Creates a <see cref="HotelPerformanceViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="HotelPerformanceViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static HotelPerformanceViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new HotelPerformanceViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="HotelPerformanceViewName"/> with the pattern
        /// <c>customers/{customer_id}/hotelPerformanceView</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="HotelPerformanceViewName"/> constructed from the provided ids.
        /// </returns>
        public static HotelPerformanceViewName FromCustomer(string customerId) =>
            new HotelPerformanceViewName(ResourceNameType.Customer, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HotelPerformanceViewName"/> with pattern
        /// <c>customers/{customer_id}/hotelPerformanceView</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HotelPerformanceViewName"/> with pattern
        /// <c>customers/{customer_id}/hotelPerformanceView</c>.
        /// </returns>
        public static string Format(string customerId) => FormatCustomer(customerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="HotelPerformanceViewName"/> with pattern
        /// <c>customers/{customer_id}/hotelPerformanceView</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="HotelPerformanceViewName"/> with pattern
        /// <c>customers/{customer_id}/hotelPerformanceView</c>.
        /// </returns>
        public static string FormatCustomer(string customerId) =>
            s_customer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HotelPerformanceViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/hotelPerformanceView</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="hotelPerformanceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="HotelPerformanceViewName"/> if successful.</returns>
        public static HotelPerformanceViewName Parse(string hotelPerformanceViewName) =>
            Parse(hotelPerformanceViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="HotelPerformanceViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/hotelPerformanceView</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hotelPerformanceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="HotelPerformanceViewName"/> if successful.</returns>
        public static HotelPerformanceViewName Parse(string hotelPerformanceViewName, bool allowUnparsed) =>
            TryParse(hotelPerformanceViewName, allowUnparsed, out HotelPerformanceViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HotelPerformanceViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/hotelPerformanceView</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="hotelPerformanceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HotelPerformanceViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hotelPerformanceViewName, out HotelPerformanceViewName result) =>
            TryParse(hotelPerformanceViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="HotelPerformanceViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/hotelPerformanceView</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="hotelPerformanceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="HotelPerformanceViewName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string hotelPerformanceViewName, bool allowUnparsed, out HotelPerformanceViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(hotelPerformanceViewName, nameof(hotelPerformanceViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customer.TryParseName(hotelPerformanceViewName, out resourceName))
            {
                result = FromCustomer(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(hotelPerformanceViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private HotelPerformanceViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="HotelPerformanceViewName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/hotelPerformanceView</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        public HotelPerformanceViewName(string customerId) : this(ResourceNameType.Customer, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Customer: return s_customer.Expand(CustomerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as HotelPerformanceViewName);

        /// <inheritdoc/>
        public bool Equals(HotelPerformanceViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(HotelPerformanceViewName a, HotelPerformanceViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(HotelPerformanceViewName a, HotelPerformanceViewName b) => !(a == b);
    }

    public partial class HotelPerformanceView
    {
        /// <summary>
        /// <see cref="HotelPerformanceViewName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal HotelPerformanceViewName ResourceNameAsHotelPerformanceViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : HotelPerformanceViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

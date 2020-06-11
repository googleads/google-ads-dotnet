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

namespace Google.Ads.GoogleAds.V1.Resources
{
    /// <summary>Resource name for the <c>LocationView</c> resource.</summary>
    public sealed partial class LocationViewName : gax::IResourceName, sys::IEquatable<LocationViewName>
    {
        /// <summary>The possible contents of <see cref="LocationViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/locationViews/{location_view}</c>.
            /// </summary>
            CustomerLocationView = 1
        }

        private static gax::PathTemplate s_customerLocationView = new gax::PathTemplate("customers/{customer}/locationViews/{location_view}");

        /// <summary>Creates a <see cref="LocationViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LocationViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LocationViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LocationViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LocationViewName"/> with the pattern
        /// <c>customers/{customer}/locationViews/{location_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationViewId">The <c>LocationView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LocationViewName"/> constructed from the provided ids.</returns>
        public static LocationViewName FromCustomerLocationView(string customerId, string locationViewId) =>
            new LocationViewName(ResourceNameType.CustomerLocationView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), locationViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationViewId, nameof(locationViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocationViewName"/> with pattern
        /// <c>customers/{customer}/locationViews/{location_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationViewId">The <c>LocationView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LocationViewName"/> with pattern
        /// <c>customers/{customer}/locationViews/{location_view}</c>.
        /// </returns>
        public static string Format(string customerId, string locationViewId) =>
            FormatCustomerLocationView(customerId, locationViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocationViewName"/> with pattern
        /// <c>customers/{customer}/locationViews/{location_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationViewId">The <c>LocationView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LocationViewName"/> with pattern
        /// <c>customers/{customer}/locationViews/{location_view}</c>.
        /// </returns>
        public static string FormatCustomerLocationView(string customerId, string locationViewId) =>
            s_customerLocationView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(locationViewId, nameof(locationViewId)));

        /// <summary>Parses the given resource name string into a new <see cref="LocationViewName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/locationViews/{location_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="locationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LocationViewName"/> if successful.</returns>
        public static LocationViewName Parse(string locationViewName) => Parse(locationViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LocationViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/locationViews/{location_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="locationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LocationViewName"/> if successful.</returns>
        public static LocationViewName Parse(string locationViewName, bool allowUnparsed) =>
            TryParse(locationViewName, allowUnparsed, out LocationViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocationViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/locationViews/{location_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="locationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocationViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationViewName, out LocationViewName result) =>
            TryParse(locationViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocationViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/locationViews/{location_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="locationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocationViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string locationViewName, bool allowUnparsed, out LocationViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(locationViewName, nameof(locationViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerLocationView.TryParseName(locationViewName, out resourceName))
            {
                result = FromCustomerLocationView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(locationViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LocationViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string locationViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            LocationViewId = locationViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LocationViewName"/> class from the component parts of pattern
        /// <c>customers/{customer}/locationViews/{location_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="locationViewId">The <c>LocationView</c> ID. Must not be <c>null</c> or empty.</param>
        public LocationViewName(string customerId, string locationViewId) : this(ResourceNameType.CustomerLocationView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), locationViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(locationViewId, nameof(locationViewId)))
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
        /// The <c>LocationView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LocationViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerLocationView: return s_customerLocationView.Expand(CustomerId, LocationViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LocationViewName);

        /// <inheritdoc/>
        public bool Equals(LocationViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(LocationViewName a, LocationViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(LocationViewName a, LocationViewName b) => !(a == b);
    }

    public partial class LocationView
    {
        /// <summary>
        /// <see cref="LocationViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal LocationViewName ResourceNameAsLocationViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : LocationViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

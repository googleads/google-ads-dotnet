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
    /// <summary>Resource name for the <c>DistanceView</c> resource.</summary>
    public sealed partial class DistanceViewName : gax::IResourceName, sys::IEquatable<DistanceViewName>
    {
        /// <summary>The possible contents of <see cref="DistanceViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/distanceViews/{distance_view}</c>.
            /// </summary>
            CustomerDistanceView = 1,
        }

        private static gax::PathTemplate s_customerDistanceView = new gax::PathTemplate("customers/{customer}/distanceViews/{distance_view}");

        /// <summary>Creates a <see cref="DistanceViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DistanceViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DistanceViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DistanceViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DistanceViewName"/> with the pattern
        /// <c>customers/{customer}/distanceViews/{distance_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="distanceViewId">The <c>DistanceView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DistanceViewName"/> constructed from the provided ids.</returns>
        public static DistanceViewName FromCustomerDistanceView(string customerId, string distanceViewId) =>
            new DistanceViewName(ResourceNameType.CustomerDistanceView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), distanceViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(distanceViewId, nameof(distanceViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DistanceViewName"/> with pattern
        /// <c>customers/{customer}/distanceViews/{distance_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="distanceViewId">The <c>DistanceView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DistanceViewName"/> with pattern
        /// <c>customers/{customer}/distanceViews/{distance_view}</c>.
        /// </returns>
        public static string Format(string customerId, string distanceViewId) =>
            FormatCustomerDistanceView(customerId, distanceViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DistanceViewName"/> with pattern
        /// <c>customers/{customer}/distanceViews/{distance_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="distanceViewId">The <c>DistanceView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DistanceViewName"/> with pattern
        /// <c>customers/{customer}/distanceViews/{distance_view}</c>.
        /// </returns>
        public static string FormatCustomerDistanceView(string customerId, string distanceViewId) =>
            s_customerDistanceView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(distanceViewId, nameof(distanceViewId)));

        /// <summary>Parses the given resource name string into a new <see cref="DistanceViewName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/distanceViews/{distance_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="distanceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DistanceViewName"/> if successful.</returns>
        public static DistanceViewName Parse(string distanceViewName) => Parse(distanceViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DistanceViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/distanceViews/{distance_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="distanceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DistanceViewName"/> if successful.</returns>
        public static DistanceViewName Parse(string distanceViewName, bool allowUnparsed) =>
            TryParse(distanceViewName, allowUnparsed, out DistanceViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DistanceViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/distanceViews/{distance_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="distanceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DistanceViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string distanceViewName, out DistanceViewName result) =>
            TryParse(distanceViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DistanceViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/distanceViews/{distance_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="distanceViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DistanceViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string distanceViewName, bool allowUnparsed, out DistanceViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(distanceViewName, nameof(distanceViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerDistanceView.TryParseName(distanceViewName, out resourceName))
            {
                result = FromCustomerDistanceView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(distanceViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private DistanceViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string distanceViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            DistanceViewId = distanceViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DistanceViewName"/> class from the component parts of pattern
        /// <c>customers/{customer}/distanceViews/{distance_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="distanceViewId">The <c>DistanceView</c> ID. Must not be <c>null</c> or empty.</param>
        public DistanceViewName(string customerId, string distanceViewId) : this(ResourceNameType.CustomerDistanceView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), distanceViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(distanceViewId, nameof(distanceViewId)))
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
        /// The <c>DistanceView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string DistanceViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerDistanceView: return s_customerDistanceView.Expand(CustomerId, DistanceViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DistanceViewName);

        /// <inheritdoc/>
        public bool Equals(DistanceViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DistanceViewName a, DistanceViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DistanceViewName a, DistanceViewName b) => !(a == b);
    }

    public partial class DistanceView
    {
        /// <summary>
        /// <see cref="DistanceViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal DistanceViewName ResourceNameAsDistanceViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : DistanceViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

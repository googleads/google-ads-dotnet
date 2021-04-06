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

namespace Google.Ads.GoogleAds.V4.Resources
{
    /// <summary>Resource name for the <c>UserLocationView</c> resource.</summary>
    public sealed partial class UserLocationViewName : gax::IResourceName, sys::IEquatable<UserLocationViewName>
    {
        /// <summary>The possible contents of <see cref="UserLocationViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/userLocationViews/{user_location_view}</c>.
            /// </summary>
            CustomerUserLocationView = 1,
        }

        private static gax::PathTemplate s_customerUserLocationView = new gax::PathTemplate("customers/{customer}/userLocationViews/{user_location_view}");

        /// <summary>Creates a <see cref="UserLocationViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserLocationViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserLocationViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserLocationViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserLocationViewName"/> with the pattern
        /// <c>customers/{customer}/userLocationViews/{user_location_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userLocationViewId">The <c>UserLocationView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UserLocationViewName"/> constructed from the provided ids.</returns>
        public static UserLocationViewName FromCustomerUserLocationView(string customerId, string userLocationViewId) =>
            new UserLocationViewName(ResourceNameType.CustomerUserLocationView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), userLocationViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(userLocationViewId, nameof(userLocationViewId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserLocationViewName"/> with pattern
        /// <c>customers/{customer}/userLocationViews/{user_location_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userLocationViewId">The <c>UserLocationView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserLocationViewName"/> with pattern
        /// <c>customers/{customer}/userLocationViews/{user_location_view}</c>.
        /// </returns>
        public static string Format(string customerId, string userLocationViewId) =>
            FormatCustomerUserLocationView(customerId, userLocationViewId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserLocationViewName"/> with pattern
        /// <c>customers/{customer}/userLocationViews/{user_location_view}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userLocationViewId">The <c>UserLocationView</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserLocationViewName"/> with pattern
        /// <c>customers/{customer}/userLocationViews/{user_location_view}</c>.
        /// </returns>
        public static string FormatCustomerUserLocationView(string customerId, string userLocationViewId) =>
            s_customerUserLocationView.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userLocationViewId, nameof(userLocationViewId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserLocationViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/userLocationViews/{user_location_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="userLocationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserLocationViewName"/> if successful.</returns>
        public static UserLocationViewName Parse(string userLocationViewName) => Parse(userLocationViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserLocationViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/userLocationViews/{user_location_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userLocationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserLocationViewName"/> if successful.</returns>
        public static UserLocationViewName Parse(string userLocationViewName, bool allowUnparsed) =>
            TryParse(userLocationViewName, allowUnparsed, out UserLocationViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserLocationViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/userLocationViews/{user_location_view}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="userLocationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserLocationViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userLocationViewName, out UserLocationViewName result) =>
            TryParse(userLocationViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserLocationViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/userLocationViews/{user_location_view}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userLocationViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserLocationViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userLocationViewName, bool allowUnparsed, out UserLocationViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(userLocationViewName, nameof(userLocationViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerUserLocationView.TryParseName(userLocationViewName, out resourceName))
            {
                result = FromCustomerUserLocationView(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userLocationViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserLocationViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string userLocationViewId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            UserLocationViewId = userLocationViewId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserLocationViewName"/> class from the component parts of pattern
        /// <c>customers/{customer}/userLocationViews/{user_location_view}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userLocationViewId">The <c>UserLocationView</c> ID. Must not be <c>null</c> or empty.</param>
        public UserLocationViewName(string customerId, string userLocationViewId) : this(ResourceNameType.CustomerUserLocationView, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), userLocationViewId: gax::GaxPreconditions.CheckNotNullOrEmpty(userLocationViewId, nameof(userLocationViewId)))
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
        /// The <c>UserLocationView</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string UserLocationViewId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerUserLocationView: return s_customerUserLocationView.Expand(CustomerId, UserLocationViewId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserLocationViewName);

        /// <inheritdoc/>
        public bool Equals(UserLocationViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(UserLocationViewName a, UserLocationViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(UserLocationViewName a, UserLocationViewName b) => !(a == b);
    }

    public partial class UserLocationView
    {
        /// <summary>
        /// <see cref="UserLocationViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal UserLocationViewName ResourceNameAsUserLocationViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : UserLocationViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

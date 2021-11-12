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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V9.Resources
{
    /// <summary>Resource name for the <c>UserInterest</c> resource.</summary>
    public sealed partial class UserInterestName : gax::IResourceName, sys::IEquatable<UserInterestName>
    {
        /// <summary>The possible contents of <see cref="UserInterestName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/userInterests/{user_interest_id}</c>.
            /// </summary>
            CustomerUserInterest = 1,
        }

        private static gax::PathTemplate s_customerUserInterest = new gax::PathTemplate("customers/{customer_id}/userInterests/{user_interest_id}");

        /// <summary>Creates a <see cref="UserInterestName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserInterestName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserInterestName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserInterestName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserInterestName"/> with the pattern
        /// <c>customers/{customer_id}/userInterests/{user_interest_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userInterestId">The <c>UserInterest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UserInterestName"/> constructed from the provided ids.</returns>
        public static UserInterestName FromCustomerUserInterest(string customerId, string userInterestId) =>
            new UserInterestName(ResourceNameType.CustomerUserInterest, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), userInterestId: gax::GaxPreconditions.CheckNotNullOrEmpty(userInterestId, nameof(userInterestId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserInterestName"/> with pattern
        /// <c>customers/{customer_id}/userInterests/{user_interest_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userInterestId">The <c>UserInterest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserInterestName"/> with pattern
        /// <c>customers/{customer_id}/userInterests/{user_interest_id}</c>.
        /// </returns>
        public static string Format(string customerId, string userInterestId) =>
            FormatCustomerUserInterest(customerId, userInterestId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserInterestName"/> with pattern
        /// <c>customers/{customer_id}/userInterests/{user_interest_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userInterestId">The <c>UserInterest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserInterestName"/> with pattern
        /// <c>customers/{customer_id}/userInterests/{user_interest_id}</c>.
        /// </returns>
        public static string FormatCustomerUserInterest(string customerId, string userInterestId) =>
            s_customerUserInterest.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userInterestId, nameof(userInterestId)));

        /// <summary>Parses the given resource name string into a new <see cref="UserInterestName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/userInterests/{user_interest_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="userInterestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserInterestName"/> if successful.</returns>
        public static UserInterestName Parse(string userInterestName) => Parse(userInterestName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserInterestName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/userInterests/{user_interest_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userInterestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserInterestName"/> if successful.</returns>
        public static UserInterestName Parse(string userInterestName, bool allowUnparsed) =>
            TryParse(userInterestName, allowUnparsed, out UserInterestName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserInterestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/userInterests/{user_interest_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="userInterestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserInterestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userInterestName, out UserInterestName result) =>
            TryParse(userInterestName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserInterestName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/userInterests/{user_interest_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userInterestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserInterestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userInterestName, bool allowUnparsed, out UserInterestName result)
        {
            gax::GaxPreconditions.CheckNotNull(userInterestName, nameof(userInterestName));
            gax::TemplatedResourceName resourceName;
            if (s_customerUserInterest.TryParseName(userInterestName, out resourceName))
            {
                result = FromCustomerUserInterest(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userInterestName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserInterestName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string userInterestId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            UserInterestId = userInterestId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserInterestName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/userInterests/{user_interest_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userInterestId">The <c>UserInterest</c> ID. Must not be <c>null</c> or empty.</param>
        public UserInterestName(string customerId, string userInterestId) : this(ResourceNameType.CustomerUserInterest, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), userInterestId: gax::GaxPreconditions.CheckNotNullOrEmpty(userInterestId, nameof(userInterestId)))
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
        /// The <c>UserInterest</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string UserInterestId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerUserInterest: return s_customerUserInterest.Expand(CustomerId, UserInterestId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserInterestName);

        /// <inheritdoc/>
        public bool Equals(UserInterestName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(UserInterestName a, UserInterestName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(UserInterestName a, UserInterestName b) => !(a == b);
    }

    public partial class UserInterest
    {
        /// <summary>
        /// <see cref="gagvr::UserInterestName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal UserInterestName ResourceNameAsUserInterestName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::UserInterestName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::UserInterestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal UserInterestName UserInterestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::UserInterestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::UserInterestName"/>-typed view over the <see cref="UserInterestParent"/> resource name
        /// property.
        /// </summary>
        internal UserInterestName UserInterestParentAsUserInterestName
        {
            get => string.IsNullOrEmpty(UserInterestParent) ? null : gagvr::UserInterestName.Parse(UserInterestParent, allowUnparsed: true);
            set => UserInterestParent = value?.ToString() ?? "";
        }
    }
}

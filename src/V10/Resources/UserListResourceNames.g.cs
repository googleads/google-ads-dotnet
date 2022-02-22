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
    /// <summary>Resource name for the <c>UserList</c> resource.</summary>
    public sealed partial class UserListName : gax::IResourceName, sys::IEquatable<UserListName>
    {
        /// <summary>The possible contents of <see cref="UserListName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/userLists/{user_list_id}</c>.</summary>
            CustomerUserList = 1,
        }

        private static gax::PathTemplate s_customerUserList = new gax::PathTemplate("customers/{customer_id}/userLists/{user_list_id}");

        /// <summary>Creates a <see cref="UserListName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserListName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static UserListName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserListName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserListName"/> with the pattern <c>customers/{customer_id}/userLists/{user_list_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListId">The <c>UserList</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="UserListName"/> constructed from the provided ids.</returns>
        public static UserListName FromCustomerUserList(string customerId, string userListId) =>
            new UserListName(ResourceNameType.CustomerUserList, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), userListId: gax::GaxPreconditions.CheckNotNullOrEmpty(userListId, nameof(userListId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserListName"/> with pattern
        /// <c>customers/{customer_id}/userLists/{user_list_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListId">The <c>UserList</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserListName"/> with pattern
        /// <c>customers/{customer_id}/userLists/{user_list_id}</c>.
        /// </returns>
        public static string Format(string customerId, string userListId) => FormatCustomerUserList(customerId, userListId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserListName"/> with pattern
        /// <c>customers/{customer_id}/userLists/{user_list_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListId">The <c>UserList</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserListName"/> with pattern
        /// <c>customers/{customer_id}/userLists/{user_list_id}</c>.
        /// </returns>
        public static string FormatCustomerUserList(string customerId, string userListId) =>
            s_customerUserList.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userListId, nameof(userListId)));

        /// <summary>Parses the given resource name string into a new <see cref="UserListName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/userLists/{user_list_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="userListName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserListName"/> if successful.</returns>
        public static UserListName Parse(string userListName) => Parse(userListName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserListName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/userLists/{user_list_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userListName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserListName"/> if successful.</returns>
        public static UserListName Parse(string userListName, bool allowUnparsed) =>
            TryParse(userListName, allowUnparsed, out UserListName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserListName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/userLists/{user_list_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="userListName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserListName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userListName, out UserListName result) => TryParse(userListName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserListName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/userLists/{user_list_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userListName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserListName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userListName, bool allowUnparsed, out UserListName result)
        {
            gax::GaxPreconditions.CheckNotNull(userListName, nameof(userListName));
            gax::TemplatedResourceName resourceName;
            if (s_customerUserList.TryParseName(userListName, out resourceName))
            {
                result = FromCustomerUserList(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userListName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private UserListName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string userListId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            UserListId = userListId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserListName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/userLists/{user_list_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListId">The <c>UserList</c> ID. Must not be <c>null</c> or empty.</param>
        public UserListName(string customerId, string userListId) : this(ResourceNameType.CustomerUserList, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), userListId: gax::GaxPreconditions.CheckNotNullOrEmpty(userListId, nameof(userListId)))
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
        /// The <c>UserList</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserListId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerUserList: return s_customerUserList.Expand(CustomerId, UserListId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserListName);

        /// <inheritdoc/>
        public bool Equals(UserListName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(UserListName a, UserListName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(UserListName a, UserListName b) => !(a == b);
    }

    public partial class UserList
    {
        /// <summary>
        /// <see cref="gagvr::UserListName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal UserListName ResourceNameAsUserListName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::UserListName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::UserListName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal UserListName UserListName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::UserListName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

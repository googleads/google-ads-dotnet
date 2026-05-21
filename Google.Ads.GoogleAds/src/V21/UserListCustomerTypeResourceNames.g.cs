// Copyright 2026 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V21.Resources
{
    /// <summary>Resource name for the <c>UserListCustomerType</c> resource.</summary>
    public sealed partial class UserListCustomerTypeName : gax::IResourceName, sys::IEquatable<UserListCustomerTypeName>
    {
        /// <summary>The possible contents of <see cref="UserListCustomerTypeName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>.
            /// </summary>
            CustomerUserListSemanticLabel = 1,
        }

        private static gax::PathTemplate s_customerUserListSemanticLabel = new gax::PathTemplate("customers/{customer_id}/userListCustomerTypes/{user_list_id_semantic_label}");

        /// <summary>Creates a <see cref="UserListCustomerTypeName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="UserListCustomerTypeName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static UserListCustomerTypeName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new UserListCustomerTypeName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="UserListCustomerTypeName"/> with the pattern
        /// <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListId">The <c>UserList</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="semanticLabelId">The <c>SemanticLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="UserListCustomerTypeName"/> constructed from the provided ids.
        /// </returns>
        public static UserListCustomerTypeName FromCustomerUserListSemanticLabel(string customerId, string userListId, string semanticLabelId) =>
            new UserListCustomerTypeName(ResourceNameType.CustomerUserListSemanticLabel, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), userListId: gax::GaxPreconditions.CheckNotNullOrEmpty(userListId, nameof(userListId)), semanticLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(semanticLabelId, nameof(semanticLabelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserListCustomerTypeName"/> with pattern
        /// <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListId">The <c>UserList</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="semanticLabelId">The <c>SemanticLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserListCustomerTypeName"/> with pattern
        /// <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>.
        /// </returns>
        public static string Format(string customerId, string userListId, string semanticLabelId) =>
            FormatCustomerUserListSemanticLabel(customerId, userListId, semanticLabelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="UserListCustomerTypeName"/> with pattern
        /// <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListId">The <c>UserList</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="semanticLabelId">The <c>SemanticLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="UserListCustomerTypeName"/> with pattern
        /// <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>.
        /// </returns>
        public static string FormatCustomerUserListSemanticLabel(string customerId, string userListId, string semanticLabelId) =>
            s_customerUserListSemanticLabel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(userListId, nameof(userListId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(semanticLabelId, nameof(semanticLabelId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserListCustomerTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userListCustomerTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="UserListCustomerTypeName"/> if successful.</returns>
        public static UserListCustomerTypeName Parse(string userListCustomerTypeName) =>
            Parse(userListCustomerTypeName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="UserListCustomerTypeName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userListCustomerTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="UserListCustomerTypeName"/> if successful.</returns>
        public static UserListCustomerTypeName Parse(string userListCustomerTypeName, bool allowUnparsed) =>
            TryParse(userListCustomerTypeName, allowUnparsed, out UserListCustomerTypeName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserListCustomerTypeName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="userListCustomerTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserListCustomerTypeName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userListCustomerTypeName, out UserListCustomerTypeName result) =>
            TryParse(userListCustomerTypeName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="UserListCustomerTypeName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="userListCustomerTypeName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="UserListCustomerTypeName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string userListCustomerTypeName, bool allowUnparsed, out UserListCustomerTypeName result)
        {
            gax::GaxPreconditions.CheckNotNull(userListCustomerTypeName, nameof(userListCustomerTypeName));
            gax::TemplatedResourceName resourceName;
            if (s_customerUserListSemanticLabel.TryParseName(userListCustomerTypeName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerUserListSemanticLabel(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(userListCustomerTypeName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private UserListCustomerTypeName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string semanticLabelId = null, string userListId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            SemanticLabelId = semanticLabelId;
            UserListId = userListId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="UserListCustomerTypeName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/userListCustomerTypes/{user_list_id}~{semantic_label}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userListId">The <c>UserList</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="semanticLabelId">The <c>SemanticLabel</c> ID. Must not be <c>null</c> or empty.</param>
        public UserListCustomerTypeName(string customerId, string userListId, string semanticLabelId) : this(ResourceNameType.CustomerUserListSemanticLabel, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), userListId: gax::GaxPreconditions.CheckNotNullOrEmpty(userListId, nameof(userListId)), semanticLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(semanticLabelId, nameof(semanticLabelId)))
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
        /// The <c>SemanticLabel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string SemanticLabelId { get; }

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
                case ResourceNameType.CustomerUserListSemanticLabel: return s_customerUserListSemanticLabel.Expand(CustomerId, $"{UserListId}~{SemanticLabelId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as UserListCustomerTypeName);

        /// <inheritdoc/>
        public bool Equals(UserListCustomerTypeName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(UserListCustomerTypeName a, UserListCustomerTypeName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(UserListCustomerTypeName a, UserListCustomerTypeName b) => !(a == b);
    }

    public partial class UserListCustomerType
    {
        /// <summary>
        /// <see cref="UserListCustomerTypeName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal UserListCustomerTypeName ResourceNameAsUserListCustomerTypeName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : UserListCustomerTypeName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="UserListName"/>-typed view over the <see cref="UserList"/> resource name property.
        /// </summary>
        internal UserListName UserListAsUserListName
        {
            get => string.IsNullOrEmpty(UserList) ? null : UserListName.Parse(UserList, allowUnparsed: true);
            set => UserList = value?.ToString() ?? "";
        }
    }
}

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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V12.Resources
{
    /// <summary>Resource name for the <c>CustomerUserAccess</c> resource.</summary>
    public sealed partial class CustomerUserAccessName : gax::IResourceName, sys::IEquatable<CustomerUserAccessName>
    {
        /// <summary>The possible contents of <see cref="CustomerUserAccessName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/customerUserAccesses/{user_id}</c>.
            /// </summary>
            CustomerUser = 1,
        }

        private static gax::PathTemplate s_customerUser = new gax::PathTemplate("customers/{customer_id}/customerUserAccesses/{user_id}");

        /// <summary>Creates a <see cref="CustomerUserAccessName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerUserAccessName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerUserAccessName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerUserAccessName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerUserAccessName"/> with the pattern
        /// <c>customers/{customer_id}/customerUserAccesses/{user_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomerUserAccessName"/> constructed from the provided ids.</returns>
        public static CustomerUserAccessName FromCustomerUser(string customerId, string userId) =>
            new CustomerUserAccessName(ResourceNameType.CustomerUser, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerUserAccessName"/> with pattern
        /// <c>customers/{customer_id}/customerUserAccesses/{user_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerUserAccessName"/> with pattern
        /// <c>customers/{customer_id}/customerUserAccesses/{user_id}</c>.
        /// </returns>
        public static string Format(string customerId, string userId) => FormatCustomerUser(customerId, userId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerUserAccessName"/> with pattern
        /// <c>customers/{customer_id}/customerUserAccesses/{user_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerUserAccessName"/> with pattern
        /// <c>customers/{customer_id}/customerUserAccesses/{user_id}</c>.
        /// </returns>
        public static string FormatCustomerUser(string customerId, string userId) =>
            s_customerUser.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerUserAccessName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerUserAccesses/{user_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerUserAccessName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerUserAccessName"/> if successful.</returns>
        public static CustomerUserAccessName Parse(string customerUserAccessName) => Parse(customerUserAccessName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerUserAccessName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerUserAccesses/{user_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerUserAccessName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerUserAccessName"/> if successful.</returns>
        public static CustomerUserAccessName Parse(string customerUserAccessName, bool allowUnparsed) =>
            TryParse(customerUserAccessName, allowUnparsed, out CustomerUserAccessName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerUserAccessName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerUserAccesses/{user_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerUserAccessName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerUserAccessName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerUserAccessName, out CustomerUserAccessName result) =>
            TryParse(customerUserAccessName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerUserAccessName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerUserAccesses/{user_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerUserAccessName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerUserAccessName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerUserAccessName, bool allowUnparsed, out CustomerUserAccessName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerUserAccessName, nameof(customerUserAccessName));
            gax::TemplatedResourceName resourceName;
            if (s_customerUser.TryParseName(customerUserAccessName, out resourceName))
            {
                result = FromCustomerUser(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerUserAccessName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerUserAccessName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string userId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            UserId = userId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerUserAccessName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/customerUserAccesses/{user_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="userId">The <c>User</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerUserAccessName(string customerId, string userId) : this(ResourceNameType.CustomerUser, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), userId: gax::GaxPreconditions.CheckNotNullOrEmpty(userId, nameof(userId)))
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
        /// The <c>User</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string UserId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerUser: return s_customerUser.Expand(CustomerId, UserId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerUserAccessName);

        /// <inheritdoc/>
        public bool Equals(CustomerUserAccessName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerUserAccessName a, CustomerUserAccessName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerUserAccessName a, CustomerUserAccessName b) => !(a == b);
    }

    public partial class CustomerUserAccess
    {
        /// <summary>
        /// <see cref="CustomerUserAccessName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CustomerUserAccessName ResourceNameAsCustomerUserAccessName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerUserAccessName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

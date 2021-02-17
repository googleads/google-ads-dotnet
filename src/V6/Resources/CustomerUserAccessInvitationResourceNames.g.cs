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

namespace Google.Ads.GoogleAds.V6.Resources
{
    /// <summary>Resource name for the <c>CustomerUserAccessInvitation</c> resource.</summary>
    public sealed partial class CustomerUserAccessInvitationName : gax::IResourceName, sys::IEquatable<CustomerUserAccessInvitationName>
    {
        /// <summary>The possible contents of <see cref="CustomerUserAccessInvitationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c>
            /// .
            /// </summary>
            CustomerInvitation = 1,
        }

        private static gax::PathTemplate s_customerInvitation = new gax::PathTemplate("customers/{customer_id}/customerUserAccessInvitations/{invitation_id}");

        /// <summary>
        /// Creates a <see cref="CustomerUserAccessInvitationName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerUserAccessInvitationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerUserAccessInvitationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerUserAccessInvitationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerUserAccessInvitationName"/> with the pattern
        /// <c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="invitationId">The <c>Invitation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerUserAccessInvitationName"/> constructed from the provided ids.
        /// </returns>
        public static CustomerUserAccessInvitationName FromCustomerInvitation(string customerId, string invitationId) =>
            new CustomerUserAccessInvitationName(ResourceNameType.CustomerInvitation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), invitationId: gax::GaxPreconditions.CheckNotNullOrEmpty(invitationId, nameof(invitationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerUserAccessInvitationName"/> with
        /// pattern <c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="invitationId">The <c>Invitation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerUserAccessInvitationName"/> with pattern
        /// <c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c>.
        /// </returns>
        public static string Format(string customerId, string invitationId) =>
            FormatCustomerInvitation(customerId, invitationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerUserAccessInvitationName"/> with
        /// pattern <c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="invitationId">The <c>Invitation</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerUserAccessInvitationName"/> with pattern
        /// <c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c>.
        /// </returns>
        public static string FormatCustomerInvitation(string customerId, string invitationId) =>
            s_customerInvitation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(invitationId, nameof(invitationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerUserAccessInvitationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerUserAccessInvitationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="CustomerUserAccessInvitationName"/> if successful.</returns>
        public static CustomerUserAccessInvitationName Parse(string customerUserAccessInvitationName) =>
            Parse(customerUserAccessInvitationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerUserAccessInvitationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerUserAccessInvitationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerUserAccessInvitationName"/> if successful.</returns>
        public static CustomerUserAccessInvitationName Parse(string customerUserAccessInvitationName, bool allowUnparsed) =>
            TryParse(customerUserAccessInvitationName, allowUnparsed, out CustomerUserAccessInvitationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerUserAccessInvitationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerUserAccessInvitationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerUserAccessInvitationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerUserAccessInvitationName, out CustomerUserAccessInvitationName result) =>
            TryParse(customerUserAccessInvitationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerUserAccessInvitationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerUserAccessInvitationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerUserAccessInvitationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerUserAccessInvitationName, bool allowUnparsed, out CustomerUserAccessInvitationName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerUserAccessInvitationName, nameof(customerUserAccessInvitationName));
            gax::TemplatedResourceName resourceName;
            if (s_customerInvitation.TryParseName(customerUserAccessInvitationName, out resourceName))
            {
                result = FromCustomerInvitation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerUserAccessInvitationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerUserAccessInvitationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string invitationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            InvitationId = invitationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerUserAccessInvitationName"/> class from the component parts
        /// of pattern <c>customers/{customer_id}/customerUserAccessInvitations/{invitation_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="invitationId">The <c>Invitation</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerUserAccessInvitationName(string customerId, string invitationId) : this(ResourceNameType.CustomerInvitation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), invitationId: gax::GaxPreconditions.CheckNotNullOrEmpty(invitationId, nameof(invitationId)))
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
        /// The <c>Invitation</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InvitationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerInvitation: return s_customerInvitation.Expand(CustomerId, InvitationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerUserAccessInvitationName);

        /// <inheritdoc/>
        public bool Equals(CustomerUserAccessInvitationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerUserAccessInvitationName a, CustomerUserAccessInvitationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerUserAccessInvitationName a, CustomerUserAccessInvitationName b) => !(a == b);
    }

    public partial class CustomerUserAccessInvitation
    {
        /// <summary>
        /// <see cref="CustomerUserAccessInvitationName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CustomerUserAccessInvitationName ResourceNameAsCustomerUserAccessInvitationName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerUserAccessInvitationName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

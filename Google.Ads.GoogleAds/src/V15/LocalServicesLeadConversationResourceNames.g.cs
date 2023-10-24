// Copyright 2023 Google LLC
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

namespace Google.Ads.GoogleAds.V15.Resources
{
    /// <summary>Resource name for the <c>LocalServicesLeadConversation</c> resource.</summary>
    public sealed partial class LocalServicesLeadConversationName : gax::IResourceName, sys::IEquatable<LocalServicesLeadConversationName>
    {
        /// <summary>The possible contents of <see cref="LocalServicesLeadConversationName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>.
            /// </summary>
            CustomerLocalServicesLeadConversation = 1,
        }

        private static gax::PathTemplate s_customerLocalServicesLeadConversation = new gax::PathTemplate("customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}");

        /// <summary>
        /// Creates a <see cref="LocalServicesLeadConversationName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LocalServicesLeadConversationName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LocalServicesLeadConversationName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LocalServicesLeadConversationName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LocalServicesLeadConversationName"/> with the pattern
        /// <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="localServicesLeadConversationId">
        /// The <c>LocalServicesLeadConversation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="LocalServicesLeadConversationName"/> constructed from the provided ids.
        /// </returns>
        public static LocalServicesLeadConversationName FromCustomerLocalServicesLeadConversation(string customerId, string localServicesLeadConversationId) =>
            new LocalServicesLeadConversationName(ResourceNameType.CustomerLocalServicesLeadConversation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), localServicesLeadConversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(localServicesLeadConversationId, nameof(localServicesLeadConversationId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocalServicesLeadConversationName"/> with
        /// pattern <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="localServicesLeadConversationId">
        /// The <c>LocalServicesLeadConversation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="LocalServicesLeadConversationName"/> with pattern
        /// <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>.
        /// </returns>
        public static string Format(string customerId, string localServicesLeadConversationId) =>
            FormatCustomerLocalServicesLeadConversation(customerId, localServicesLeadConversationId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LocalServicesLeadConversationName"/> with
        /// pattern <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="localServicesLeadConversationId">
        /// The <c>LocalServicesLeadConversation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="LocalServicesLeadConversationName"/> with pattern
        /// <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>.
        /// </returns>
        public static string FormatCustomerLocalServicesLeadConversation(string customerId, string localServicesLeadConversationId) =>
            s_customerLocalServicesLeadConversation.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(localServicesLeadConversationId, nameof(localServicesLeadConversationId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LocalServicesLeadConversationName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="localServicesLeadConversationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="LocalServicesLeadConversationName"/> if successful.</returns>
        public static LocalServicesLeadConversationName Parse(string localServicesLeadConversationName) =>
            Parse(localServicesLeadConversationName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LocalServicesLeadConversationName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="localServicesLeadConversationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LocalServicesLeadConversationName"/> if successful.</returns>
        public static LocalServicesLeadConversationName Parse(string localServicesLeadConversationName, bool allowUnparsed) =>
            TryParse(localServicesLeadConversationName, allowUnparsed, out LocalServicesLeadConversationName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocalServicesLeadConversationName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="localServicesLeadConversationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocalServicesLeadConversationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string localServicesLeadConversationName, out LocalServicesLeadConversationName result) =>
            TryParse(localServicesLeadConversationName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LocalServicesLeadConversationName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="localServicesLeadConversationName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LocalServicesLeadConversationName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string localServicesLeadConversationName, bool allowUnparsed, out LocalServicesLeadConversationName result)
        {
            gax::GaxPreconditions.CheckNotNull(localServicesLeadConversationName, nameof(localServicesLeadConversationName));
            gax::TemplatedResourceName resourceName;
            if (s_customerLocalServicesLeadConversation.TryParseName(localServicesLeadConversationName, out resourceName))
            {
                result = FromCustomerLocalServicesLeadConversation(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(localServicesLeadConversationName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LocalServicesLeadConversationName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string localServicesLeadConversationId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            LocalServicesLeadConversationId = localServicesLeadConversationId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LocalServicesLeadConversationName"/> class from the component
        /// parts of pattern
        /// <c>customers/{customer_id}/localServicesLeadConversations/{local_services_lead_conversation_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="localServicesLeadConversationId">
        /// The <c>LocalServicesLeadConversation</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public LocalServicesLeadConversationName(string customerId, string localServicesLeadConversationId) : this(ResourceNameType.CustomerLocalServicesLeadConversation, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), localServicesLeadConversationId: gax::GaxPreconditions.CheckNotNullOrEmpty(localServicesLeadConversationId, nameof(localServicesLeadConversationId)))
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
        /// The <c>LocalServicesLeadConversation</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string LocalServicesLeadConversationId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerLocalServicesLeadConversation: return s_customerLocalServicesLeadConversation.Expand(CustomerId, LocalServicesLeadConversationId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LocalServicesLeadConversationName);

        /// <inheritdoc/>
        public bool Equals(LocalServicesLeadConversationName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(LocalServicesLeadConversationName a, LocalServicesLeadConversationName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(LocalServicesLeadConversationName a, LocalServicesLeadConversationName b) => !(a == b);
    }

    public partial class LocalServicesLeadConversation
    {
        /// <summary>
        /// <see cref="LocalServicesLeadConversationName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal LocalServicesLeadConversationName ResourceNameAsLocalServicesLeadConversationName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : LocalServicesLeadConversationName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="LocalServicesLeadName"/>-typed view over the <see cref="Lead"/> resource name property.
        /// </summary>
        internal LocalServicesLeadName LeadAsLocalServicesLeadName
        {
            get => string.IsNullOrEmpty(Lead) ? null : LocalServicesLeadName.Parse(Lead, allowUnparsed: true);
            set => Lead = value?.ToString() ?? "";
        }
    }
}

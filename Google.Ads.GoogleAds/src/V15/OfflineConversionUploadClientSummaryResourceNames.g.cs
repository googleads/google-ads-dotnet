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
    /// <summary>Resource name for the <c>OfflineConversionUploadClientSummary</c> resource.</summary>
    public sealed partial class OfflineConversionUploadClientSummaryName : gax::IResourceName, sys::IEquatable<OfflineConversionUploadClientSummaryName>
    {
        /// <summary>The possible contents of <see cref="OfflineConversionUploadClientSummaryName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c>
            /// .
            /// </summary>
            CustomerClient = 1,
        }

        private static gax::PathTemplate s_customerClient = new gax::PathTemplate("customers/{customer_id}/offlineConversionUploadClientSummaries/{client}");

        /// <summary>
        /// Creates a <see cref="OfflineConversionUploadClientSummaryName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OfflineConversionUploadClientSummaryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OfflineConversionUploadClientSummaryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OfflineConversionUploadClientSummaryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OfflineConversionUploadClientSummaryName"/> with the pattern
        /// <c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientId">The <c>Client</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="OfflineConversionUploadClientSummaryName"/> constructed from the provided ids.
        /// </returns>
        public static OfflineConversionUploadClientSummaryName FromCustomerClient(string customerId, string clientId) =>
            new OfflineConversionUploadClientSummaryName(ResourceNameType.CustomerClient, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), clientId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientId, nameof(clientId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="OfflineConversionUploadClientSummaryName"/> with pattern
        /// <c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientId">The <c>Client</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OfflineConversionUploadClientSummaryName"/> with pattern
        /// <c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c>.
        /// </returns>
        public static string Format(string customerId, string clientId) => FormatCustomerClient(customerId, clientId);

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="OfflineConversionUploadClientSummaryName"/> with pattern
        /// <c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientId">The <c>Client</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OfflineConversionUploadClientSummaryName"/> with pattern
        /// <c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c>.
        /// </returns>
        public static string FormatCustomerClient(string customerId, string clientId) =>
            s_customerClient.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(clientId, nameof(clientId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OfflineConversionUploadClientSummaryName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="offlineConversionUploadClientSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="OfflineConversionUploadClientSummaryName"/> if successful.</returns>
        public static OfflineConversionUploadClientSummaryName Parse(string offlineConversionUploadClientSummaryName) =>
            Parse(offlineConversionUploadClientSummaryName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OfflineConversionUploadClientSummaryName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="offlineConversionUploadClientSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OfflineConversionUploadClientSummaryName"/> if successful.</returns>
        public static OfflineConversionUploadClientSummaryName Parse(string offlineConversionUploadClientSummaryName, bool allowUnparsed) =>
            TryParse(offlineConversionUploadClientSummaryName, allowUnparsed, out OfflineConversionUploadClientSummaryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="OfflineConversionUploadClientSummaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="offlineConversionUploadClientSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OfflineConversionUploadClientSummaryName"/>, or <c>null</c>
        /// if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string offlineConversionUploadClientSummaryName, out OfflineConversionUploadClientSummaryName result) =>
            TryParse(offlineConversionUploadClientSummaryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="OfflineConversionUploadClientSummaryName"/> instance; optionally allowing an unparseable resource
        /// name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="offlineConversionUploadClientSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OfflineConversionUploadClientSummaryName"/>, or <c>null</c>
        /// if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string offlineConversionUploadClientSummaryName, bool allowUnparsed, out OfflineConversionUploadClientSummaryName result)
        {
            gax::GaxPreconditions.CheckNotNull(offlineConversionUploadClientSummaryName, nameof(offlineConversionUploadClientSummaryName));
            gax::TemplatedResourceName resourceName;
            if (s_customerClient.TryParseName(offlineConversionUploadClientSummaryName, out resourceName))
            {
                result = FromCustomerClient(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(offlineConversionUploadClientSummaryName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OfflineConversionUploadClientSummaryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clientId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClientId = clientId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OfflineConversionUploadClientSummaryName"/> class from the
        /// component parts of pattern <c>customers/{customer_id}/offlineConversionUploadClientSummaries/{client}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientId">The <c>Client</c> ID. Must not be <c>null</c> or empty.</param>
        public OfflineConversionUploadClientSummaryName(string customerId, string clientId) : this(ResourceNameType.CustomerClient, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), clientId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientId, nameof(clientId)))
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
        /// The <c>Client</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ClientId { get; }

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
                case ResourceNameType.CustomerClient: return s_customerClient.Expand(CustomerId, ClientId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OfflineConversionUploadClientSummaryName);

        /// <inheritdoc/>
        public bool Equals(OfflineConversionUploadClientSummaryName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(OfflineConversionUploadClientSummaryName a, OfflineConversionUploadClientSummaryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(OfflineConversionUploadClientSummaryName a, OfflineConversionUploadClientSummaryName b) => !(a == b);
    }

    public partial class OfflineConversionUploadClientSummary
    {
        /// <summary>
        /// <see cref="OfflineConversionUploadClientSummaryName"/>-typed view over the <see cref="ResourceName"/>
        /// resource name property.
        /// </summary>
        internal OfflineConversionUploadClientSummaryName ResourceNameAsOfflineConversionUploadClientSummaryName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : OfflineConversionUploadClientSummaryName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

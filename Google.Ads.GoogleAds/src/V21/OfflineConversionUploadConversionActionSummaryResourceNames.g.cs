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
    /// <summary>Resource name for the <c>OfflineConversionUploadConversionActionSummary</c> resource.</summary>
    public sealed partial class OfflineConversionUploadConversionActionSummaryName : gax::IResourceName, sys::IEquatable<OfflineConversionUploadConversionActionSummaryName>
    {
        /// <summary>
        /// The possible contents of <see cref="OfflineConversionUploadConversionActionSummaryName"/>.
        /// </summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
            /// .
            /// </summary>
            CustomerConversionTypeClient = 1,
        }

        private static gax::PathTemplate s_customerConversionTypeClient = new gax::PathTemplate("customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id_client}");

        /// <summary>
        /// Creates a <see cref="OfflineConversionUploadConversionActionSummaryName"/> containing an unparsed resource
        /// name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OfflineConversionUploadConversionActionSummaryName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OfflineConversionUploadConversionActionSummaryName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OfflineConversionUploadConversionActionSummaryName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OfflineConversionUploadConversionActionSummaryName"/> with the pattern
        /// <c>customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionTypeId">The <c>ConversionType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientId">The <c>Client</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="OfflineConversionUploadConversionActionSummaryName"/> constructed from the
        /// provided ids.
        /// </returns>
        public static OfflineConversionUploadConversionActionSummaryName FromCustomerConversionTypeClient(string customerId, string conversionTypeId, string clientId) =>
            new OfflineConversionUploadConversionActionSummaryName(ResourceNameType.CustomerConversionTypeClient, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), conversionTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionTypeId, nameof(conversionTypeId)), clientId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientId, nameof(clientId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="OfflineConversionUploadConversionActionSummaryName"/> with pattern
        /// <c>customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionTypeId">The <c>ConversionType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientId">The <c>Client</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OfflineConversionUploadConversionActionSummaryName"/> with
        /// pattern
        /// <c>customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
        /// .
        /// </returns>
        public static string Format(string customerId, string conversionTypeId, string clientId) =>
            FormatCustomerConversionTypeClient(customerId, conversionTypeId, clientId);

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="OfflineConversionUploadConversionActionSummaryName"/> with pattern
        /// <c>customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionTypeId">The <c>ConversionType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientId">The <c>Client</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="OfflineConversionUploadConversionActionSummaryName"/> with
        /// pattern
        /// <c>customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
        /// .
        /// </returns>
        public static string FormatCustomerConversionTypeClient(string customerId, string conversionTypeId, string clientId) =>
            s_customerConversionTypeClient.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(conversionTypeId, nameof(conversionTypeId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(clientId, nameof(clientId)))}");

        /// <summary>
        /// Parses the given resource name string into a new
        /// <see cref="OfflineConversionUploadConversionActionSummaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="offlineConversionUploadConversionActionSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>
        /// The parsed <see cref="OfflineConversionUploadConversionActionSummaryName"/> if successful.
        /// </returns>
        public static OfflineConversionUploadConversionActionSummaryName Parse(string offlineConversionUploadConversionActionSummaryName) =>
            Parse(offlineConversionUploadConversionActionSummaryName, false);

        /// <summary>
        /// Parses the given resource name string into a new
        /// <see cref="OfflineConversionUploadConversionActionSummaryName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="offlineConversionUploadConversionActionSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>
        /// The parsed <see cref="OfflineConversionUploadConversionActionSummaryName"/> if successful.
        /// </returns>
        public static OfflineConversionUploadConversionActionSummaryName Parse(string offlineConversionUploadConversionActionSummaryName, bool allowUnparsed) =>
            TryParse(offlineConversionUploadConversionActionSummaryName, allowUnparsed, out OfflineConversionUploadConversionActionSummaryName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="OfflineConversionUploadConversionActionSummaryName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="offlineConversionUploadConversionActionSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OfflineConversionUploadConversionActionSummaryName"/>, or
        /// <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string offlineConversionUploadConversionActionSummaryName, out OfflineConversionUploadConversionActionSummaryName result) =>
            TryParse(offlineConversionUploadConversionActionSummaryName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="OfflineConversionUploadConversionActionSummaryName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="offlineConversionUploadConversionActionSummaryName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OfflineConversionUploadConversionActionSummaryName"/>, or
        /// <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string offlineConversionUploadConversionActionSummaryName, bool allowUnparsed, out OfflineConversionUploadConversionActionSummaryName result)
        {
            gax::GaxPreconditions.CheckNotNull(offlineConversionUploadConversionActionSummaryName, nameof(offlineConversionUploadConversionActionSummaryName));
            gax::TemplatedResourceName resourceName;
            if (s_customerConversionTypeClient.TryParseName(offlineConversionUploadConversionActionSummaryName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerConversionTypeClient(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(offlineConversionUploadConversionActionSummaryName, out gax::UnparsedResourceName unparsedResourceName))
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

        private OfflineConversionUploadConversionActionSummaryName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string clientId = null, string conversionTypeId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ClientId = clientId;
            ConversionTypeId = conversionTypeId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OfflineConversionUploadConversionActionSummaryName"/> class from
        /// the component parts of pattern
        /// <c>customers/{customer_id}/offlineConversionUploadConversionActionSummaries/{conversion_type_id}~{client}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionTypeId">The <c>ConversionType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="clientId">The <c>Client</c> ID. Must not be <c>null</c> or empty.</param>
        public OfflineConversionUploadConversionActionSummaryName(string customerId, string conversionTypeId, string clientId) : this(ResourceNameType.CustomerConversionTypeClient, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), conversionTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionTypeId, nameof(conversionTypeId)), clientId: gax::GaxPreconditions.CheckNotNullOrEmpty(clientId, nameof(clientId)))
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
        /// The <c>ConversionType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConversionTypeId { get; }

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
                case ResourceNameType.CustomerConversionTypeClient: return s_customerConversionTypeClient.Expand(CustomerId, $"{ConversionTypeId}~{ClientId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OfflineConversionUploadConversionActionSummaryName);

        /// <inheritdoc/>
        public bool Equals(OfflineConversionUploadConversionActionSummaryName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(OfflineConversionUploadConversionActionSummaryName a, OfflineConversionUploadConversionActionSummaryName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(OfflineConversionUploadConversionActionSummaryName a, OfflineConversionUploadConversionActionSummaryName b) => !(a == b);
    }

    public partial class OfflineConversionUploadConversionActionSummary
    {
        /// <summary>
        /// <see cref="OfflineConversionUploadConversionActionSummaryName"/>-typed view over the
        /// <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal OfflineConversionUploadConversionActionSummaryName ResourceNameAsOfflineConversionUploadConversionActionSummaryName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : OfflineConversionUploadConversionActionSummaryName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

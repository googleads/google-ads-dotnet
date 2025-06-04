// Copyright 2025 Google LLC
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

namespace Google.Ads.GoogleAds.V20.Resources
{
    /// <summary>Resource name for the <c>DataLink</c> resource.</summary>
    public sealed partial class DataLinkName : gax::IResourceName, sys::IEquatable<DataLinkName>
    {
        /// <summary>The possible contents of <see cref="DataLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c>.
            /// </summary>
            CustomerProductLinkDataLink = 1,
        }

        private static gax::PathTemplate s_customerProductLinkDataLink = new gax::PathTemplate("customers/{customer_id}/dataLinks/{product_link_id_data_link_id}");

        /// <summary>Creates a <see cref="DataLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DataLinkName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static DataLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DataLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DataLinkName"/> with the pattern
        /// <c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productLinkId">The <c>ProductLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataLinkId">The <c>DataLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DataLinkName"/> constructed from the provided ids.</returns>
        public static DataLinkName FromCustomerProductLinkDataLink(string customerId, string productLinkId, string dataLinkId) =>
            new DataLinkName(ResourceNameType.CustomerProductLinkDataLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), productLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(productLinkId, nameof(productLinkId)), dataLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataLinkId, nameof(dataLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataLinkName"/> with pattern
        /// <c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productLinkId">The <c>ProductLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataLinkId">The <c>DataLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataLinkName"/> with pattern
        /// <c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c>.
        /// </returns>
        public static string Format(string customerId, string productLinkId, string dataLinkId) =>
            FormatCustomerProductLinkDataLink(customerId, productLinkId, dataLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DataLinkName"/> with pattern
        /// <c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productLinkId">The <c>ProductLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataLinkId">The <c>DataLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DataLinkName"/> with pattern
        /// <c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c>.
        /// </returns>
        public static string FormatCustomerProductLinkDataLink(string customerId, string productLinkId, string dataLinkId) =>
            s_customerProductLinkDataLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(productLinkId, nameof(productLinkId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(dataLinkId, nameof(dataLinkId)))}");

        /// <summary>Parses the given resource name string into a new <see cref="DataLinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DataLinkName"/> if successful.</returns>
        public static DataLinkName Parse(string dataLinkName) => Parse(dataLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DataLinkName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DataLinkName"/> if successful.</returns>
        public static DataLinkName Parse(string dataLinkName, bool allowUnparsed) =>
            TryParse(dataLinkName, allowUnparsed, out DataLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="dataLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataLinkName, out DataLinkName result) => TryParse(dataLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DataLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="dataLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DataLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string dataLinkName, bool allowUnparsed, out DataLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(dataLinkName, nameof(dataLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_customerProductLinkDataLink.TryParseName(dataLinkName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerProductLinkDataLink(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(dataLinkName, out gax::UnparsedResourceName unparsedResourceName))
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

        private DataLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string dataLinkId = null, string productLinkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            DataLinkId = dataLinkId;
            ProductLinkId = productLinkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DataLinkName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/dataLinks/{product_link_id}~{data_link_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productLinkId">The <c>ProductLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="dataLinkId">The <c>DataLink</c> ID. Must not be <c>null</c> or empty.</param>
        public DataLinkName(string customerId, string productLinkId, string dataLinkId) : this(ResourceNameType.CustomerProductLinkDataLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), productLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(productLinkId, nameof(productLinkId)), dataLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(dataLinkId, nameof(dataLinkId)))
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
        /// The <c>DataLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string DataLinkId { get; }

        /// <summary>
        /// The <c>ProductLink</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ProductLinkId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerProductLinkDataLink: return s_customerProductLinkDataLink.Expand(CustomerId, $"{ProductLinkId}~{DataLinkId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DataLinkName);

        /// <inheritdoc/>
        public bool Equals(DataLinkName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(DataLinkName a, DataLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(DataLinkName a, DataLinkName b) => !(a == b);
    }

    public partial class DataLink
    {
        /// <summary>
        /// <see cref="DataLinkName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal DataLinkName ResourceNameAsDataLinkName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : DataLinkName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

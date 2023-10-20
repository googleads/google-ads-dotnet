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
    /// <summary>Resource name for the <c>ProductLink</c> resource.</summary>
    public sealed partial class ProductLinkName : gax::IResourceName, sys::IEquatable<ProductLinkName>
    {
        /// <summary>The possible contents of <see cref="ProductLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/productLinks/{product_link_id}</c>.
            /// </summary>
            CustomerProductLink = 1,
        }

        private static gax::PathTemplate s_customerProductLink = new gax::PathTemplate("customers/{customer_id}/productLinks/{product_link_id}");

        /// <summary>Creates a <see cref="ProductLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ProductLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ProductLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ProductLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ProductLinkName"/> with the pattern
        /// <c>customers/{customer_id}/productLinks/{product_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productLinkId">The <c>ProductLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ProductLinkName"/> constructed from the provided ids.</returns>
        public static ProductLinkName FromCustomerProductLink(string customerId, string productLinkId) =>
            new ProductLinkName(ResourceNameType.CustomerProductLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), productLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(productLinkId, nameof(productLinkId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductLinkName"/> with pattern
        /// <c>customers/{customer_id}/productLinks/{product_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productLinkId">The <c>ProductLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductLinkName"/> with pattern
        /// <c>customers/{customer_id}/productLinks/{product_link_id}</c>.
        /// </returns>
        public static string Format(string customerId, string productLinkId) =>
            FormatCustomerProductLink(customerId, productLinkId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ProductLinkName"/> with pattern
        /// <c>customers/{customer_id}/productLinks/{product_link_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productLinkId">The <c>ProductLink</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ProductLinkName"/> with pattern
        /// <c>customers/{customer_id}/productLinks/{product_link_id}</c>.
        /// </returns>
        public static string FormatCustomerProductLink(string customerId, string productLinkId) =>
            s_customerProductLink.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(productLinkId, nameof(productLinkId)));

        /// <summary>Parses the given resource name string into a new <see cref="ProductLinkName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/productLinks/{product_link_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="productLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ProductLinkName"/> if successful.</returns>
        public static ProductLinkName Parse(string productLinkName) => Parse(productLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ProductLinkName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/productLinks/{product_link_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ProductLinkName"/> if successful.</returns>
        public static ProductLinkName Parse(string productLinkName, bool allowUnparsed) =>
            TryParse(productLinkName, allowUnparsed, out ProductLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/productLinks/{product_link_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="productLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productLinkName, out ProductLinkName result) =>
            TryParse(productLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ProductLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/productLinks/{product_link_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="productLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ProductLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string productLinkName, bool allowUnparsed, out ProductLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(productLinkName, nameof(productLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_customerProductLink.TryParseName(productLinkName, out resourceName))
            {
                result = FromCustomerProductLink(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(productLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ProductLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string productLinkId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            ProductLinkId = productLinkId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ProductLinkName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/productLinks/{product_link_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="productLinkId">The <c>ProductLink</c> ID. Must not be <c>null</c> or empty.</param>
        public ProductLinkName(string customerId, string productLinkId) : this(ResourceNameType.CustomerProductLink, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), productLinkId: gax::GaxPreconditions.CheckNotNullOrEmpty(productLinkId, nameof(productLinkId)))
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
                case ResourceNameType.CustomerProductLink: return s_customerProductLink.Expand(CustomerId, ProductLinkId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ProductLinkName);

        /// <inheritdoc/>
        public bool Equals(ProductLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ProductLinkName a, ProductLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ProductLinkName a, ProductLinkName b) => !(a == b);
    }

    public partial class ProductLink
    {
        /// <summary>
        /// <see cref="ProductLinkName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal ProductLinkName ResourceNameAsProductLinkName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ProductLinkName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }

    public partial class GoogleAdsIdentifier
    {
        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Customer"/> resource name property.
        /// </summary>
        internal CustomerName CustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(Customer) ? null : CustomerName.Parse(Customer, allowUnparsed: true);
            set => Customer = value?.ToString() ?? "";
        }
    }
}

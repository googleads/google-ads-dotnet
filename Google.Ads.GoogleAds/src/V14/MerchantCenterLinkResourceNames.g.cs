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

namespace Google.Ads.GoogleAds.V14.Resources
{
    /// <summary>Resource name for the <c>MerchantCenterLink</c> resource.</summary>
    public sealed partial class MerchantCenterLinkName : gax::IResourceName, sys::IEquatable<MerchantCenterLinkName>
    {
        /// <summary>The possible contents of <see cref="MerchantCenterLinkName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c>.
            /// </summary>
            CustomerMerchantCenter = 1,
        }

        private static gax::PathTemplate s_customerMerchantCenter = new gax::PathTemplate("customers/{customer_id}/merchantCenterLinks/{merchant_center_id}");

        /// <summary>Creates a <see cref="MerchantCenterLinkName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MerchantCenterLinkName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MerchantCenterLinkName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MerchantCenterLinkName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MerchantCenterLinkName"/> with the pattern
        /// <c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="merchantCenterId">The <c>MerchantCenter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MerchantCenterLinkName"/> constructed from the provided ids.</returns>
        public static MerchantCenterLinkName FromCustomerMerchantCenter(string customerId, string merchantCenterId) =>
            new MerchantCenterLinkName(ResourceNameType.CustomerMerchantCenter, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), merchantCenterId: gax::GaxPreconditions.CheckNotNullOrEmpty(merchantCenterId, nameof(merchantCenterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MerchantCenterLinkName"/> with pattern
        /// <c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="merchantCenterId">The <c>MerchantCenter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MerchantCenterLinkName"/> with pattern
        /// <c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c>.
        /// </returns>
        public static string Format(string customerId, string merchantCenterId) =>
            FormatCustomerMerchantCenter(customerId, merchantCenterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MerchantCenterLinkName"/> with pattern
        /// <c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="merchantCenterId">The <c>MerchantCenter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MerchantCenterLinkName"/> with pattern
        /// <c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c>.
        /// </returns>
        public static string FormatCustomerMerchantCenter(string customerId, string merchantCenterId) =>
            s_customerMerchantCenter.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(merchantCenterId, nameof(merchantCenterId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MerchantCenterLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="merchantCenterLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MerchantCenterLinkName"/> if successful.</returns>
        public static MerchantCenterLinkName Parse(string merchantCenterLinkName) => Parse(merchantCenterLinkName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MerchantCenterLinkName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="merchantCenterLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MerchantCenterLinkName"/> if successful.</returns>
        public static MerchantCenterLinkName Parse(string merchantCenterLinkName, bool allowUnparsed) =>
            TryParse(merchantCenterLinkName, allowUnparsed, out MerchantCenterLinkName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MerchantCenterLinkName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="merchantCenterLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MerchantCenterLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string merchantCenterLinkName, out MerchantCenterLinkName result) =>
            TryParse(merchantCenterLinkName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MerchantCenterLinkName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="merchantCenterLinkName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MerchantCenterLinkName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string merchantCenterLinkName, bool allowUnparsed, out MerchantCenterLinkName result)
        {
            gax::GaxPreconditions.CheckNotNull(merchantCenterLinkName, nameof(merchantCenterLinkName));
            gax::TemplatedResourceName resourceName;
            if (s_customerMerchantCenter.TryParseName(merchantCenterLinkName, out resourceName))
            {
                result = FromCustomerMerchantCenter(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(merchantCenterLinkName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MerchantCenterLinkName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string merchantCenterId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            MerchantCenterId = merchantCenterId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MerchantCenterLinkName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/merchantCenterLinks/{merchant_center_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="merchantCenterId">The <c>MerchantCenter</c> ID. Must not be <c>null</c> or empty.</param>
        public MerchantCenterLinkName(string customerId, string merchantCenterId) : this(ResourceNameType.CustomerMerchantCenter, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), merchantCenterId: gax::GaxPreconditions.CheckNotNullOrEmpty(merchantCenterId, nameof(merchantCenterId)))
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
        /// The <c>MerchantCenter</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MerchantCenterId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerMerchantCenter: return s_customerMerchantCenter.Expand(CustomerId, MerchantCenterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MerchantCenterLinkName);

        /// <inheritdoc/>
        public bool Equals(MerchantCenterLinkName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MerchantCenterLinkName a, MerchantCenterLinkName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MerchantCenterLinkName a, MerchantCenterLinkName b) => !(a == b);
    }

    public partial class MerchantCenterLink
    {
        /// <summary>
        /// <see cref="MerchantCenterLinkName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal MerchantCenterLinkName ResourceNameAsMerchantCenterLinkName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : MerchantCenterLinkName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

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

using gagvr = Google.Ads.GoogleAds.V4.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V4.Resources
{
    /// <summary>Resource name for the <c>ConversionAction</c> resource.</summary>
    public sealed partial class ConversionActionName : gax::IResourceName, sys::IEquatable<ConversionActionName>
    {
        /// <summary>The possible contents of <see cref="ConversionActionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/conversionActions/{conversion_action}</c>.
            /// </summary>
            CustomerConversionAction = 1,
        }

        private static gax::PathTemplate s_customerConversionAction = new gax::PathTemplate("customers/{customer}/conversionActions/{conversion_action}");

        /// <summary>Creates a <see cref="ConversionActionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversionActionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversionActionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversionActionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversionActionName"/> with the pattern
        /// <c>customers/{customer}/conversionActions/{conversion_action}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionActionId">The <c>ConversionAction</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ConversionActionName"/> constructed from the provided ids.</returns>
        public static ConversionActionName FromCustomerConversionAction(string customerId, string conversionActionId) =>
            new ConversionActionName(ResourceNameType.CustomerConversionAction, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), conversionActionId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionActionId, nameof(conversionActionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionActionName"/> with pattern
        /// <c>customers/{customer}/conversionActions/{conversion_action}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionActionId">The <c>ConversionAction</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversionActionName"/> with pattern
        /// <c>customers/{customer}/conversionActions/{conversion_action}</c>.
        /// </returns>
        public static string Format(string customerId, string conversionActionId) =>
            FormatCustomerConversionAction(customerId, conversionActionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionActionName"/> with pattern
        /// <c>customers/{customer}/conversionActions/{conversion_action}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionActionId">The <c>ConversionAction</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ConversionActionName"/> with pattern
        /// <c>customers/{customer}/conversionActions/{conversion_action}</c>.
        /// </returns>
        public static string FormatCustomerConversionAction(string customerId, string conversionActionId) =>
            s_customerConversionAction.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversionActionId, nameof(conversionActionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionActionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/conversionActions/{conversion_action}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="conversionActionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversionActionName"/> if successful.</returns>
        public static ConversionActionName Parse(string conversionActionName) => Parse(conversionActionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionActionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/conversionActions/{conversion_action}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionActionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversionActionName"/> if successful.</returns>
        public static ConversionActionName Parse(string conversionActionName, bool allowUnparsed) =>
            TryParse(conversionActionName, allowUnparsed, out ConversionActionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionActionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/conversionActions/{conversion_action}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="conversionActionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionActionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionActionName, out ConversionActionName result) =>
            TryParse(conversionActionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionActionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/conversionActions/{conversion_action}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionActionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionActionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionActionName, bool allowUnparsed, out ConversionActionName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversionActionName, nameof(conversionActionName));
            gax::TemplatedResourceName resourceName;
            if (s_customerConversionAction.TryParseName(conversionActionName, out resourceName))
            {
                result = FromCustomerConversionAction(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversionActionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversionActionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversionActionId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversionActionId = conversionActionId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversionActionName"/> class from the component parts of pattern
        /// <c>customers/{customer}/conversionActions/{conversion_action}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionActionId">The <c>ConversionAction</c> ID. Must not be <c>null</c> or empty.</param>
        public ConversionActionName(string customerId, string conversionActionId) : this(ResourceNameType.CustomerConversionAction, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), conversionActionId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionActionId, nameof(conversionActionId)))
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
        /// The <c>ConversionAction</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ConversionActionId { get; }

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
                case ResourceNameType.CustomerConversionAction: return s_customerConversionAction.Expand(CustomerId, ConversionActionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversionActionName);

        /// <inheritdoc/>
        public bool Equals(ConversionActionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ConversionActionName a, ConversionActionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ConversionActionName a, ConversionActionName b) => !(a == b);
    }

    public partial class ConversionAction
    {
        /// <summary>
        /// <see cref="gagvr::ConversionActionName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal ConversionActionName ResourceNameAsConversionActionName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::ConversionActionName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::ConversionActionName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal ConversionActionName ConversionActionName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::ConversionActionName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="OwnerCustomer"/> resource name property.
        /// </summary>
        internal CustomerName OwnerCustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(OwnerCustomer) ? null : CustomerName.Parse(OwnerCustomer, allowUnparsed: true);
            set => OwnerCustomer = value?.ToString() ?? "";
        }
    }
}

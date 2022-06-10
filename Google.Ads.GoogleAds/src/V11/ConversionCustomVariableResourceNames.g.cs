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

using gagvr = Google.Ads.GoogleAds.V11.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V11.Resources
{
    /// <summary>Resource name for the <c>ConversionCustomVariable</c> resource.</summary>
    public sealed partial class ConversionCustomVariableName : gax::IResourceName, sys::IEquatable<ConversionCustomVariableName>
    {
        /// <summary>The possible contents of <see cref="ConversionCustomVariableName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>.
            /// </summary>
            CustomerConversionCustomVariable = 1,
        }

        private static gax::PathTemplate s_customerConversionCustomVariable = new gax::PathTemplate("customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}");

        /// <summary>
        /// Creates a <see cref="ConversionCustomVariableName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversionCustomVariableName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversionCustomVariableName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversionCustomVariableName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversionCustomVariableName"/> with the pattern
        /// <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionCustomVariableId">
        /// The <c>ConversionCustomVariable</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ConversionCustomVariableName"/> constructed from the provided ids.
        /// </returns>
        public static ConversionCustomVariableName FromCustomerConversionCustomVariable(string customerId, string conversionCustomVariableId) =>
            new ConversionCustomVariableName(ResourceNameType.CustomerConversionCustomVariable, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), conversionCustomVariableId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionCustomVariableId, nameof(conversionCustomVariableId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionCustomVariableName"/> with
        /// pattern <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionCustomVariableId">
        /// The <c>ConversionCustomVariable</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversionCustomVariableName"/> with pattern
        /// <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>.
        /// </returns>
        public static string Format(string customerId, string conversionCustomVariableId) =>
            FormatCustomerConversionCustomVariable(customerId, conversionCustomVariableId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionCustomVariableName"/> with
        /// pattern <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionCustomVariableId">
        /// The <c>ConversionCustomVariable</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversionCustomVariableName"/> with pattern
        /// <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>.
        /// </returns>
        public static string FormatCustomerConversionCustomVariable(string customerId, string conversionCustomVariableId) =>
            s_customerConversionCustomVariable.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversionCustomVariableId, nameof(conversionCustomVariableId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionCustomVariableName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversionCustomVariableName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="ConversionCustomVariableName"/> if successful.</returns>
        public static ConversionCustomVariableName Parse(string conversionCustomVariableName) =>
            Parse(conversionCustomVariableName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionCustomVariableName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionCustomVariableName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversionCustomVariableName"/> if successful.</returns>
        public static ConversionCustomVariableName Parse(string conversionCustomVariableName, bool allowUnparsed) =>
            TryParse(conversionCustomVariableName, allowUnparsed, out ConversionCustomVariableName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionCustomVariableName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversionCustomVariableName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionCustomVariableName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionCustomVariableName, out ConversionCustomVariableName result) =>
            TryParse(conversionCustomVariableName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionCustomVariableName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionCustomVariableName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionCustomVariableName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionCustomVariableName, bool allowUnparsed, out ConversionCustomVariableName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversionCustomVariableName, nameof(conversionCustomVariableName));
            gax::TemplatedResourceName resourceName;
            if (s_customerConversionCustomVariable.TryParseName(conversionCustomVariableName, out resourceName))
            {
                result = FromCustomerConversionCustomVariable(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversionCustomVariableName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversionCustomVariableName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversionCustomVariableId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversionCustomVariableId = conversionCustomVariableId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversionCustomVariableName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/conversionCustomVariables/{conversion_custom_variable_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionCustomVariableId">
        /// The <c>ConversionCustomVariable</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ConversionCustomVariableName(string customerId, string conversionCustomVariableId) : this(ResourceNameType.CustomerConversionCustomVariable, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), conversionCustomVariableId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionCustomVariableId, nameof(conversionCustomVariableId)))
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
        /// The <c>ConversionCustomVariable</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ConversionCustomVariableId { get; }

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
                case ResourceNameType.CustomerConversionCustomVariable: return s_customerConversionCustomVariable.Expand(CustomerId, ConversionCustomVariableId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversionCustomVariableName);

        /// <inheritdoc/>
        public bool Equals(ConversionCustomVariableName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ConversionCustomVariableName a, ConversionCustomVariableName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ConversionCustomVariableName a, ConversionCustomVariableName b) => !(a == b);
    }

    public partial class ConversionCustomVariable
    {
        /// <summary>
        /// <see cref="gagvr::ConversionCustomVariableName"/>-typed view over the <see cref="ResourceName"/> resource
        /// name property.
        /// </summary>
        internal gagvr::ConversionCustomVariableName ResourceNameAsConversionCustomVariableName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::ConversionCustomVariableName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::ConversionCustomVariableName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        internal gagvr::ConversionCustomVariableName ConversionCustomVariableName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::ConversionCustomVariableName.Parse(Name, allowUnparsed: true);
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

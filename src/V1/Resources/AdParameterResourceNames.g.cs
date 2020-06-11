// Copyright 2020 Google LLC
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

namespace Google.Ads.GoogleAds.V1.Resources
{
    /// <summary>Resource name for the <c>AdParameter</c> resource.</summary>
    public sealed partial class AdParameterName : gax::IResourceName, sys::IEquatable<AdParameterName>
    {
        /// <summary>The possible contents of <see cref="AdParameterName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer}/adParameters/{ad_parameter}</c>.</summary>
            CustomerAdParameter = 1
        }

        private static gax::PathTemplate s_customerAdParameter = new gax::PathTemplate("customers/{customer}/adParameters/{ad_parameter}");

        /// <summary>Creates a <see cref="AdParameterName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdParameterName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdParameterName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdParameterName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdParameterName"/> with the pattern <c>customers/{customer}/adParameters/{ad_parameter}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adParameterId">The <c>AdParameter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdParameterName"/> constructed from the provided ids.</returns>
        public static AdParameterName FromCustomerAdParameter(string customerId, string adParameterId) =>
            new AdParameterName(ResourceNameType.CustomerAdParameter, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adParameterId: gax::GaxPreconditions.CheckNotNullOrEmpty(adParameterId, nameof(adParameterId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdParameterName"/> with pattern
        /// <c>customers/{customer}/adParameters/{ad_parameter}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adParameterId">The <c>AdParameter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdParameterName"/> with pattern
        /// <c>customers/{customer}/adParameters/{ad_parameter}</c>.
        /// </returns>
        public static string Format(string customerId, string adParameterId) =>
            FormatCustomerAdParameter(customerId, adParameterId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdParameterName"/> with pattern
        /// <c>customers/{customer}/adParameters/{ad_parameter}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adParameterId">The <c>AdParameter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdParameterName"/> with pattern
        /// <c>customers/{customer}/adParameters/{ad_parameter}</c>.
        /// </returns>
        public static string FormatCustomerAdParameter(string customerId, string adParameterId) =>
            s_customerAdParameter.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adParameterId, nameof(adParameterId)));

        /// <summary>Parses the given resource name string into a new <see cref="AdParameterName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adParameters/{ad_parameter}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adParameterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdParameterName"/> if successful.</returns>
        public static AdParameterName Parse(string adParameterName) => Parse(adParameterName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdParameterName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adParameters/{ad_parameter}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adParameterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdParameterName"/> if successful.</returns>
        public static AdParameterName Parse(string adParameterName, bool allowUnparsed) =>
            TryParse(adParameterName, allowUnparsed, out AdParameterName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdParameterName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adParameters/{ad_parameter}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adParameterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdParameterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adParameterName, out AdParameterName result) =>
            TryParse(adParameterName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdParameterName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adParameters/{ad_parameter}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adParameterName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdParameterName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adParameterName, bool allowUnparsed, out AdParameterName result)
        {
            gax::GaxPreconditions.CheckNotNull(adParameterName, nameof(adParameterName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdParameter.TryParseName(adParameterName, out resourceName))
            {
                result = FromCustomerAdParameter(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adParameterName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdParameterName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adParameterId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdParameterId = adParameterId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdParameterName"/> class from the component parts of pattern
        /// <c>customers/{customer}/adParameters/{ad_parameter}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adParameterId">The <c>AdParameter</c> ID. Must not be <c>null</c> or empty.</param>
        public AdParameterName(string customerId, string adParameterId) : this(ResourceNameType.CustomerAdParameter, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adParameterId: gax::GaxPreconditions.CheckNotNullOrEmpty(adParameterId, nameof(adParameterId)))
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
        /// The <c>AdParameter</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdParameterId { get; }

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
                case ResourceNameType.CustomerAdParameter: return s_customerAdParameter.Expand(CustomerId, AdParameterId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdParameterName);

        /// <inheritdoc/>
        public bool Equals(AdParameterName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdParameterName a, AdParameterName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdParameterName a, AdParameterName b) => !(a == b);
    }

    public partial class AdParameter
    {
        /// <summary>
        /// <see cref="AdParameterName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdParameterName ResourceNameAsAdParameterName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdParameterName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupCriterionName"/>-typed view over the <see cref="AdGroupCriterion"/> resource name
        /// property.
        /// </summary>
        internal AdGroupCriterionName AdGroupCriterionAsAdGroupCriterionName
        {
            get => string.IsNullOrEmpty(AdGroupCriterion) ? null : AdGroupCriterionName.Parse(AdGroupCriterion, allowUnparsed: true);
            set => AdGroupCriterion = value?.ToString() ?? "";
        }
    }
}

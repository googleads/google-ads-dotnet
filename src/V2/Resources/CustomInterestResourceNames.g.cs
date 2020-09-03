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

using gagvr = Google.Ads.GoogleAds.V2.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V2.Resources
{
    /// <summary>Resource name for the <c>CustomInterest</c> resource.</summary>
    public sealed partial class CustomInterestName : gax::IResourceName, sys::IEquatable<CustomInterestName>
    {
        /// <summary>The possible contents of <see cref="CustomInterestName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/customInterests/{custom_interest}</c>.
            /// </summary>
            CustomerCustomInterest = 1
        }

        private static gax::PathTemplate s_customerCustomInterest = new gax::PathTemplate("customers/{customer}/customInterests/{custom_interest}");

        /// <summary>Creates a <see cref="CustomInterestName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomInterestName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomInterestName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomInterestName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomInterestName"/> with the pattern
        /// <c>customers/{customer}/customInterests/{custom_interest}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customInterestId">The <c>CustomInterest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomInterestName"/> constructed from the provided ids.</returns>
        public static CustomInterestName FromCustomerCustomInterest(string customerId, string customInterestId) =>
            new CustomInterestName(ResourceNameType.CustomerCustomInterest, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customInterestId: gax::GaxPreconditions.CheckNotNullOrEmpty(customInterestId, nameof(customInterestId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomInterestName"/> with pattern
        /// <c>customers/{customer}/customInterests/{custom_interest}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customInterestId">The <c>CustomInterest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomInterestName"/> with pattern
        /// <c>customers/{customer}/customInterests/{custom_interest}</c>.
        /// </returns>
        public static string Format(string customerId, string customInterestId) =>
            FormatCustomerCustomInterest(customerId, customInterestId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomInterestName"/> with pattern
        /// <c>customers/{customer}/customInterests/{custom_interest}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customInterestId">The <c>CustomInterest</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomInterestName"/> with pattern
        /// <c>customers/{customer}/customInterests/{custom_interest}</c>.
        /// </returns>
        public static string FormatCustomerCustomInterest(string customerId, string customInterestId) =>
            s_customerCustomInterest.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customInterestId, nameof(customInterestId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomInterestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/customInterests/{custom_interest}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customInterestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomInterestName"/> if successful.</returns>
        public static CustomInterestName Parse(string customInterestName) => Parse(customInterestName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomInterestName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/customInterests/{custom_interest}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customInterestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomInterestName"/> if successful.</returns>
        public static CustomInterestName Parse(string customInterestName, bool allowUnparsed) =>
            TryParse(customInterestName, allowUnparsed, out CustomInterestName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomInterestName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/customInterests/{custom_interest}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customInterestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomInterestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customInterestName, out CustomInterestName result) =>
            TryParse(customInterestName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomInterestName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/customInterests/{custom_interest}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customInterestName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomInterestName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customInterestName, bool allowUnparsed, out CustomInterestName result)
        {
            gax::GaxPreconditions.CheckNotNull(customInterestName, nameof(customInterestName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCustomInterest.TryParseName(customInterestName, out resourceName))
            {
                result = FromCustomerCustomInterest(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customInterestName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomInterestName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customInterestId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomInterestId = customInterestId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomInterestName"/> class from the component parts of pattern
        /// <c>customers/{customer}/customInterests/{custom_interest}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customInterestId">The <c>CustomInterest</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomInterestName(string customerId, string customInterestId) : this(ResourceNameType.CustomerCustomInterest, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customInterestId: gax::GaxPreconditions.CheckNotNullOrEmpty(customInterestId, nameof(customInterestId)))
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
        /// The <c>CustomInterest</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CustomInterestId { get; }

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
                case ResourceNameType.CustomerCustomInterest: return s_customerCustomInterest.Expand(CustomerId, CustomInterestId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomInterestName);

        /// <inheritdoc/>
        public bool Equals(CustomInterestName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomInterestName a, CustomInterestName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomInterestName a, CustomInterestName b) => !(a == b);
    }

    public partial class CustomInterest
    {
        /// <summary>
        /// <see cref="gagvr::CustomInterestName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CustomInterestName ResourceNameAsCustomInterestName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::CustomInterestName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CustomInterestName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal CustomInterestName CustomInterestName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::CustomInterestName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

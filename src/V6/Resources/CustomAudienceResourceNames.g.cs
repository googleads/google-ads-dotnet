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

using gagvr = Google.Ads.GoogleAds.V6.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V6.Resources
{
    /// <summary>Resource name for the <c>CustomAudience</c> resource.</summary>
    public sealed partial class CustomAudienceName : gax::IResourceName, sys::IEquatable<CustomAudienceName>
    {
        /// <summary>The possible contents of <see cref="CustomAudienceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/customAudiences/{custom_audience_id}</c>.
            /// </summary>
            CustomerCustomAudience = 1,
        }

        private static gax::PathTemplate s_customerCustomAudience = new gax::PathTemplate("customers/{customer_id}/customAudiences/{custom_audience_id}");

        /// <summary>Creates a <see cref="CustomAudienceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomAudienceName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomAudienceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomAudienceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomAudienceName"/> with the pattern
        /// <c>customers/{customer_id}/customAudiences/{custom_audience_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customAudienceId">The <c>CustomAudience</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomAudienceName"/> constructed from the provided ids.</returns>
        public static CustomAudienceName FromCustomerCustomAudience(string customerId, string customAudienceId) =>
            new CustomAudienceName(ResourceNameType.CustomerCustomAudience, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customAudienceId: gax::GaxPreconditions.CheckNotNullOrEmpty(customAudienceId, nameof(customAudienceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomAudienceName"/> with pattern
        /// <c>customers/{customer_id}/customAudiences/{custom_audience_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customAudienceId">The <c>CustomAudience</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomAudienceName"/> with pattern
        /// <c>customers/{customer_id}/customAudiences/{custom_audience_id}</c>.
        /// </returns>
        public static string Format(string customerId, string customAudienceId) =>
            FormatCustomerCustomAudience(customerId, customAudienceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomAudienceName"/> with pattern
        /// <c>customers/{customer_id}/customAudiences/{custom_audience_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customAudienceId">The <c>CustomAudience</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomAudienceName"/> with pattern
        /// <c>customers/{customer_id}/customAudiences/{custom_audience_id}</c>.
        /// </returns>
        public static string FormatCustomerCustomAudience(string customerId, string customAudienceId) =>
            s_customerCustomAudience.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(customAudienceId, nameof(customAudienceId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomAudienceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customAudiences/{custom_audience_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customAudienceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomAudienceName"/> if successful.</returns>
        public static CustomAudienceName Parse(string customAudienceName) => Parse(customAudienceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomAudienceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customAudiences/{custom_audience_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customAudienceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomAudienceName"/> if successful.</returns>
        public static CustomAudienceName Parse(string customAudienceName, bool allowUnparsed) =>
            TryParse(customAudienceName, allowUnparsed, out CustomAudienceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomAudienceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customAudiences/{custom_audience_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customAudienceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomAudienceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customAudienceName, out CustomAudienceName result) =>
            TryParse(customAudienceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomAudienceName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customAudiences/{custom_audience_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customAudienceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomAudienceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customAudienceName, bool allowUnparsed, out CustomAudienceName result)
        {
            gax::GaxPreconditions.CheckNotNull(customAudienceName, nameof(customAudienceName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCustomAudience.TryParseName(customAudienceName, out resourceName))
            {
                result = FromCustomerCustomAudience(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customAudienceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomAudienceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customAudienceId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomAudienceId = customAudienceId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomAudienceName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/customAudiences/{custom_audience_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customAudienceId">The <c>CustomAudience</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomAudienceName(string customerId, string customAudienceId) : this(ResourceNameType.CustomerCustomAudience, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), customAudienceId: gax::GaxPreconditions.CheckNotNullOrEmpty(customAudienceId, nameof(customAudienceId)))
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
        /// The <c>CustomAudience</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CustomAudienceId { get; }

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
                case ResourceNameType.CustomerCustomAudience: return s_customerCustomAudience.Expand(CustomerId, CustomAudienceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomAudienceName);

        /// <inheritdoc/>
        public bool Equals(CustomAudienceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomAudienceName a, CustomAudienceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomAudienceName a, CustomAudienceName b) => !(a == b);
    }

    public partial class CustomAudience
    {
        /// <summary>
        /// <see cref="gagvr::CustomAudienceName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CustomAudienceName ResourceNameAsCustomAudienceName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::CustomAudienceName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CustomAudienceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal CustomAudienceName CustomAudienceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::CustomAudienceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

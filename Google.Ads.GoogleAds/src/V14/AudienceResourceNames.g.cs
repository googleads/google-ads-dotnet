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
using gagvr = Google.Ads.GoogleAds.V14.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V14.Resources
{
    /// <summary>Resource name for the <c>Audience</c> resource.</summary>
    public sealed partial class AudienceName : gax::IResourceName, sys::IEquatable<AudienceName>
    {
        /// <summary>The possible contents of <see cref="AudienceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/audiences/{audience_id}</c>.</summary>
            CustomerAudience = 1,
        }

        private static gax::PathTemplate s_customerAudience = new gax::PathTemplate("customers/{customer_id}/audiences/{audience_id}");

        /// <summary>Creates a <see cref="AudienceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AudienceName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static AudienceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AudienceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AudienceName"/> with the pattern <c>customers/{customer_id}/audiences/{audience_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceId">The <c>Audience</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AudienceName"/> constructed from the provided ids.</returns>
        public static AudienceName FromCustomerAudience(string customerId, string audienceId) =>
            new AudienceName(ResourceNameType.CustomerAudience, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), audienceId: gax::GaxPreconditions.CheckNotNullOrEmpty(audienceId, nameof(audienceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AudienceName"/> with pattern
        /// <c>customers/{customer_id}/audiences/{audience_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceId">The <c>Audience</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AudienceName"/> with pattern
        /// <c>customers/{customer_id}/audiences/{audience_id}</c>.
        /// </returns>
        public static string Format(string customerId, string audienceId) => FormatCustomerAudience(customerId, audienceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AudienceName"/> with pattern
        /// <c>customers/{customer_id}/audiences/{audience_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceId">The <c>Audience</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AudienceName"/> with pattern
        /// <c>customers/{customer_id}/audiences/{audience_id}</c>.
        /// </returns>
        public static string FormatCustomerAudience(string customerId, string audienceId) =>
            s_customerAudience.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(audienceId, nameof(audienceId)));

        /// <summary>Parses the given resource name string into a new <see cref="AudienceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/audiences/{audience_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="audienceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AudienceName"/> if successful.</returns>
        public static AudienceName Parse(string audienceName) => Parse(audienceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AudienceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/audiences/{audience_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="audienceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AudienceName"/> if successful.</returns>
        public static AudienceName Parse(string audienceName, bool allowUnparsed) =>
            TryParse(audienceName, allowUnparsed, out AudienceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AudienceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/audiences/{audience_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="audienceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AudienceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string audienceName, out AudienceName result) => TryParse(audienceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AudienceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/audiences/{audience_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="audienceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AudienceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string audienceName, bool allowUnparsed, out AudienceName result)
        {
            gax::GaxPreconditions.CheckNotNull(audienceName, nameof(audienceName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAudience.TryParseName(audienceName, out resourceName))
            {
                result = FromCustomerAudience(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(audienceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AudienceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string audienceId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AudienceId = audienceId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AudienceName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/audiences/{audience_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="audienceId">The <c>Audience</c> ID. Must not be <c>null</c> or empty.</param>
        public AudienceName(string customerId, string audienceId) : this(ResourceNameType.CustomerAudience, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), audienceId: gax::GaxPreconditions.CheckNotNullOrEmpty(audienceId, nameof(audienceId)))
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
        /// The <c>Audience</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AudienceId { get; }

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
                case ResourceNameType.CustomerAudience: return s_customerAudience.Expand(CustomerId, AudienceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AudienceName);

        /// <inheritdoc/>
        public bool Equals(AudienceName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AudienceName a, AudienceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AudienceName a, AudienceName b) => !(a == b);
    }

    public partial class Audience
    {
        /// <summary>
        /// <see cref="gagvr::AudienceName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal gagvr::AudienceName ResourceNameAsAudienceName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::AudienceName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::AudienceName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::AudienceName AudienceName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::AudienceName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

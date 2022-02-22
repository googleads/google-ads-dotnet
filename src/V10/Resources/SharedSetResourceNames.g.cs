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

using gagvr = Google.Ads.GoogleAds.V10.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V10.Resources
{
    /// <summary>Resource name for the <c>SharedSet</c> resource.</summary>
    public sealed partial class SharedSetName : gax::IResourceName, sys::IEquatable<SharedSetName>
    {
        /// <summary>The possible contents of <see cref="SharedSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/sharedSets/{shared_set_id}</c>.
            /// </summary>
            CustomerSharedSet = 1,
        }

        private static gax::PathTemplate s_customerSharedSet = new gax::PathTemplate("customers/{customer_id}/sharedSets/{shared_set_id}");

        /// <summary>Creates a <see cref="SharedSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SharedSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SharedSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SharedSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SharedSetName"/> with the pattern <c>customers/{customer_id}/sharedSets/{shared_set_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedSetId">The <c>SharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="SharedSetName"/> constructed from the provided ids.</returns>
        public static SharedSetName FromCustomerSharedSet(string customerId, string sharedSetId) =>
            new SharedSetName(ResourceNameType.CustomerSharedSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), sharedSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(sharedSetId, nameof(sharedSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SharedSetName"/> with pattern
        /// <c>customers/{customer_id}/sharedSets/{shared_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedSetId">The <c>SharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SharedSetName"/> with pattern
        /// <c>customers/{customer_id}/sharedSets/{shared_set_id}</c>.
        /// </returns>
        public static string Format(string customerId, string sharedSetId) => FormatCustomerSharedSet(customerId, sharedSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SharedSetName"/> with pattern
        /// <c>customers/{customer_id}/sharedSets/{shared_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedSetId">The <c>SharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SharedSetName"/> with pattern
        /// <c>customers/{customer_id}/sharedSets/{shared_set_id}</c>.
        /// </returns>
        public static string FormatCustomerSharedSet(string customerId, string sharedSetId) =>
            s_customerSharedSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(sharedSetId, nameof(sharedSetId)));

        /// <summary>Parses the given resource name string into a new <see cref="SharedSetName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/sharedSets/{shared_set_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="SharedSetName"/> if successful.</returns>
        public static SharedSetName Parse(string sharedSetName) => Parse(sharedSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SharedSetName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/sharedSets/{shared_set_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SharedSetName"/> if successful.</returns>
        public static SharedSetName Parse(string sharedSetName, bool allowUnparsed) =>
            TryParse(sharedSetName, allowUnparsed, out SharedSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SharedSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/sharedSets/{shared_set_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="sharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SharedSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sharedSetName, out SharedSetName result) => TryParse(sharedSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SharedSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/sharedSets/{shared_set_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="sharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SharedSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string sharedSetName, bool allowUnparsed, out SharedSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(sharedSetName, nameof(sharedSetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerSharedSet.TryParseName(sharedSetName, out resourceName))
            {
                result = FromCustomerSharedSet(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(sharedSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private SharedSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string sharedSetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            SharedSetId = sharedSetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SharedSetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/sharedSets/{shared_set_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedSetId">The <c>SharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        public SharedSetName(string customerId, string sharedSetId) : this(ResourceNameType.CustomerSharedSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), sharedSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(sharedSetId, nameof(sharedSetId)))
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
        /// The <c>SharedSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SharedSetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerSharedSet: return s_customerSharedSet.Expand(CustomerId, SharedSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SharedSetName);

        /// <inheritdoc/>
        public bool Equals(SharedSetName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SharedSetName a, SharedSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SharedSetName a, SharedSetName b) => !(a == b);
    }

    public partial class SharedSet
    {
        /// <summary>
        /// <see cref="gagvr::SharedSetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal SharedSetName ResourceNameAsSharedSetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::SharedSetName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::SharedSetName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal SharedSetName SharedSetName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::SharedSetName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V9.Resources
{
    /// <summary>Resource name for the <c>LifeEvent</c> resource.</summary>
    public sealed partial class LifeEventName : gax::IResourceName, sys::IEquatable<LifeEventName>
    {
        /// <summary>The possible contents of <see cref="LifeEventName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/lifeEvents/{life_event_id}</c>.
            /// </summary>
            CustomerLifeEvent = 1,
        }

        private static gax::PathTemplate s_customerLifeEvent = new gax::PathTemplate("customers/{customer_id}/lifeEvents/{life_event_id}");

        /// <summary>Creates a <see cref="LifeEventName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="LifeEventName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static LifeEventName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new LifeEventName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="LifeEventName"/> with the pattern <c>customers/{customer_id}/lifeEvents/{life_event_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lifeEventId">The <c>LifeEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="LifeEventName"/> constructed from the provided ids.</returns>
        public static LifeEventName FromCustomerLifeEvent(string customerId, string lifeEventId) =>
            new LifeEventName(ResourceNameType.CustomerLifeEvent, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), lifeEventId: gax::GaxPreconditions.CheckNotNullOrEmpty(lifeEventId, nameof(lifeEventId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LifeEventName"/> with pattern
        /// <c>customers/{customer_id}/lifeEvents/{life_event_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lifeEventId">The <c>LifeEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LifeEventName"/> with pattern
        /// <c>customers/{customer_id}/lifeEvents/{life_event_id}</c>.
        /// </returns>
        public static string Format(string customerId, string lifeEventId) => FormatCustomerLifeEvent(customerId, lifeEventId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="LifeEventName"/> with pattern
        /// <c>customers/{customer_id}/lifeEvents/{life_event_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lifeEventId">The <c>LifeEvent</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="LifeEventName"/> with pattern
        /// <c>customers/{customer_id}/lifeEvents/{life_event_id}</c>.
        /// </returns>
        public static string FormatCustomerLifeEvent(string customerId, string lifeEventId) =>
            s_customerLifeEvent.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(lifeEventId, nameof(lifeEventId)));

        /// <summary>Parses the given resource name string into a new <see cref="LifeEventName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/lifeEvents/{life_event_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="lifeEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="LifeEventName"/> if successful.</returns>
        public static LifeEventName Parse(string lifeEventName) => Parse(lifeEventName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="LifeEventName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/lifeEvents/{life_event_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lifeEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="LifeEventName"/> if successful.</returns>
        public static LifeEventName Parse(string lifeEventName, bool allowUnparsed) =>
            TryParse(lifeEventName, allowUnparsed, out LifeEventName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LifeEventName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/lifeEvents/{life_event_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="lifeEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LifeEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lifeEventName, out LifeEventName result) => TryParse(lifeEventName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="LifeEventName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/lifeEvents/{life_event_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="lifeEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="LifeEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string lifeEventName, bool allowUnparsed, out LifeEventName result)
        {
            gax::GaxPreconditions.CheckNotNull(lifeEventName, nameof(lifeEventName));
            gax::TemplatedResourceName resourceName;
            if (s_customerLifeEvent.TryParseName(lifeEventName, out resourceName))
            {
                result = FromCustomerLifeEvent(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(lifeEventName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private LifeEventName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string lifeEventId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            LifeEventId = lifeEventId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="LifeEventName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/lifeEvents/{life_event_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="lifeEventId">The <c>LifeEvent</c> ID. Must not be <c>null</c> or empty.</param>
        public LifeEventName(string customerId, string lifeEventId) : this(ResourceNameType.CustomerLifeEvent, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), lifeEventId: gax::GaxPreconditions.CheckNotNullOrEmpty(lifeEventId, nameof(lifeEventId)))
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
        /// The <c>LifeEvent</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LifeEventId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerLifeEvent: return s_customerLifeEvent.Expand(CustomerId, LifeEventId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as LifeEventName);

        /// <inheritdoc/>
        public bool Equals(LifeEventName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(LifeEventName a, LifeEventName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(LifeEventName a, LifeEventName b) => !(a == b);
    }

    public partial class LifeEvent
    {
        /// <summary>
        /// <see cref="gagvr::LifeEventName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal LifeEventName ResourceNameAsLifeEventName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::LifeEventName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::LifeEventName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal LifeEventName LifeEventName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::LifeEventName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::LifeEventName"/>-typed view over the <see cref="Parent"/> resource name property.
        /// </summary>
        internal LifeEventName ParentAsLifeEventName
        {
            get => string.IsNullOrEmpty(Parent) ? null : gagvr::LifeEventName.Parse(Parent, allowUnparsed: true);
            set => Parent = value?.ToString() ?? "";
        }
    }
}

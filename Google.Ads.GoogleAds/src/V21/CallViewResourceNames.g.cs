// Copyright 2026 Google LLC
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

namespace Google.Ads.GoogleAds.V21.Resources
{
    /// <summary>Resource name for the <c>CallView</c> resource.</summary>
    public sealed partial class CallViewName : gax::IResourceName, sys::IEquatable<CallViewName>
    {
        /// <summary>The possible contents of <see cref="CallViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/callViews/{call_detail_id}</c>.
            /// </summary>
            CustomerCallDetail = 1,
        }

        private static gax::PathTemplate s_customerCallDetail = new gax::PathTemplate("customers/{customer_id}/callViews/{call_detail_id}");

        /// <summary>Creates a <see cref="CallViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CallViewName"/> containing the provided <paramref name="unparsedResourceName"/>
        /// .
        /// </returns>
        public static CallViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CallViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CallViewName"/> with the pattern <c>customers/{customer_id}/callViews/{call_detail_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callDetailId">The <c>CallDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CallViewName"/> constructed from the provided ids.</returns>
        public static CallViewName FromCustomerCallDetail(string customerId, string callDetailId) =>
            new CallViewName(ResourceNameType.CustomerCallDetail, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), callDetailId: gax::GaxPreconditions.CheckNotNullOrEmpty(callDetailId, nameof(callDetailId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CallViewName"/> with pattern
        /// <c>customers/{customer_id}/callViews/{call_detail_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callDetailId">The <c>CallDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CallViewName"/> with pattern
        /// <c>customers/{customer_id}/callViews/{call_detail_id}</c>.
        /// </returns>
        public static string Format(string customerId, string callDetailId) =>
            FormatCustomerCallDetail(customerId, callDetailId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CallViewName"/> with pattern
        /// <c>customers/{customer_id}/callViews/{call_detail_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callDetailId">The <c>CallDetail</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CallViewName"/> with pattern
        /// <c>customers/{customer_id}/callViews/{call_detail_id}</c>.
        /// </returns>
        public static string FormatCustomerCallDetail(string customerId, string callDetailId) =>
            s_customerCallDetail.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(callDetailId, nameof(callDetailId)));

        /// <summary>Parses the given resource name string into a new <see cref="CallViewName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/callViews/{call_detail_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="callViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CallViewName"/> if successful.</returns>
        public static CallViewName Parse(string callViewName) => Parse(callViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CallViewName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/callViews/{call_detail_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="callViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CallViewName"/> if successful.</returns>
        public static CallViewName Parse(string callViewName, bool allowUnparsed) =>
            TryParse(callViewName, allowUnparsed, out CallViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CallViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/callViews/{call_detail_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="callViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CallViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string callViewName, out CallViewName result) => TryParse(callViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CallViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/callViews/{call_detail_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="callViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CallViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string callViewName, bool allowUnparsed, out CallViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(callViewName, nameof(callViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCallDetail.TryParseName(callViewName, out resourceName))
            {
                result = FromCustomerCallDetail(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(callViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CallViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string callDetailId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CallDetailId = callDetailId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CallViewName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/callViews/{call_detail_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="callDetailId">The <c>CallDetail</c> ID. Must not be <c>null</c> or empty.</param>
        public CallViewName(string customerId, string callDetailId) : this(ResourceNameType.CustomerCallDetail, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), callDetailId: gax::GaxPreconditions.CheckNotNullOrEmpty(callDetailId, nameof(callDetailId)))
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
        /// The <c>CallDetail</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CallDetailId { get; }

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
                case ResourceNameType.CustomerCallDetail: return s_customerCallDetail.Expand(CustomerId, CallDetailId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CallViewName);

        /// <inheritdoc/>
        public bool Equals(CallViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CallViewName a, CallViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CallViewName a, CallViewName b) => !(a == b);
    }

    public partial class CallView
    {
        /// <summary>
        /// <see cref="CallViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CallViewName ResourceNameAsCallViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CallViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

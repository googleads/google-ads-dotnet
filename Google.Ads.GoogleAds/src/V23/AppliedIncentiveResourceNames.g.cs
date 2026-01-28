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

namespace Google.Ads.GoogleAds.V23.Resources
{
    /// <summary>Resource name for the <c>AppliedIncentive</c> resource.</summary>
    public sealed partial class AppliedIncentiveName : gax::IResourceName, sys::IEquatable<AppliedIncentiveName>
    {
        /// <summary>The possible contents of <see cref="AppliedIncentiveName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/appliedIncentives/{coupon_code}</c>.
            /// </summary>
            CustomerCouponCode = 1,
        }

        private static gax::PathTemplate s_customerCouponCode = new gax::PathTemplate("customers/{customer_id}/appliedIncentives/{coupon_code}");

        /// <summary>Creates a <see cref="AppliedIncentiveName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AppliedIncentiveName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AppliedIncentiveName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AppliedIncentiveName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AppliedIncentiveName"/> with the pattern
        /// <c>customers/{customer_id}/appliedIncentives/{coupon_code}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="couponCodeId">The <c>CouponCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AppliedIncentiveName"/> constructed from the provided ids.</returns>
        public static AppliedIncentiveName FromCustomerCouponCode(string customerId, string couponCodeId) =>
            new AppliedIncentiveName(ResourceNameType.CustomerCouponCode, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), couponCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(couponCodeId, nameof(couponCodeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AppliedIncentiveName"/> with pattern
        /// <c>customers/{customer_id}/appliedIncentives/{coupon_code}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="couponCodeId">The <c>CouponCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AppliedIncentiveName"/> with pattern
        /// <c>customers/{customer_id}/appliedIncentives/{coupon_code}</c>.
        /// </returns>
        public static string Format(string customerId, string couponCodeId) =>
            FormatCustomerCouponCode(customerId, couponCodeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AppliedIncentiveName"/> with pattern
        /// <c>customers/{customer_id}/appliedIncentives/{coupon_code}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="couponCodeId">The <c>CouponCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AppliedIncentiveName"/> with pattern
        /// <c>customers/{customer_id}/appliedIncentives/{coupon_code}</c>.
        /// </returns>
        public static string FormatCustomerCouponCode(string customerId, string couponCodeId) =>
            s_customerCouponCode.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(couponCodeId, nameof(couponCodeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AppliedIncentiveName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/appliedIncentives/{coupon_code}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="appliedIncentiveName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AppliedIncentiveName"/> if successful.</returns>
        public static AppliedIncentiveName Parse(string appliedIncentiveName) => Parse(appliedIncentiveName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AppliedIncentiveName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/appliedIncentives/{coupon_code}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="appliedIncentiveName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AppliedIncentiveName"/> if successful.</returns>
        public static AppliedIncentiveName Parse(string appliedIncentiveName, bool allowUnparsed) =>
            TryParse(appliedIncentiveName, allowUnparsed, out AppliedIncentiveName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AppliedIncentiveName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/appliedIncentives/{coupon_code}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="appliedIncentiveName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AppliedIncentiveName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string appliedIncentiveName, out AppliedIncentiveName result) =>
            TryParse(appliedIncentiveName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AppliedIncentiveName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/appliedIncentives/{coupon_code}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="appliedIncentiveName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AppliedIncentiveName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string appliedIncentiveName, bool allowUnparsed, out AppliedIncentiveName result)
        {
            gax::GaxPreconditions.CheckNotNull(appliedIncentiveName, nameof(appliedIncentiveName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCouponCode.TryParseName(appliedIncentiveName, out resourceName))
            {
                result = FromCustomerCouponCode(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(appliedIncentiveName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AppliedIncentiveName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string couponCodeId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CouponCodeId = couponCodeId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AppliedIncentiveName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/appliedIncentives/{coupon_code}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="couponCodeId">The <c>CouponCode</c> ID. Must not be <c>null</c> or empty.</param>
        public AppliedIncentiveName(string customerId, string couponCodeId) : this(ResourceNameType.CustomerCouponCode, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), couponCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(couponCodeId, nameof(couponCodeId)))
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
        /// The <c>CouponCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CouponCodeId { get; }

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
                case ResourceNameType.CustomerCouponCode: return s_customerCouponCode.Expand(CustomerId, CouponCodeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AppliedIncentiveName);

        /// <inheritdoc/>
        public bool Equals(AppliedIncentiveName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AppliedIncentiveName a, AppliedIncentiveName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AppliedIncentiveName a, AppliedIncentiveName b) => !(a == b);
    }

    public partial class AppliedIncentive
    {
        /// <summary>
        /// <see cref="AppliedIncentiveName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AppliedIncentiveName ResourceNameAsAppliedIncentiveName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AppliedIncentiveName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

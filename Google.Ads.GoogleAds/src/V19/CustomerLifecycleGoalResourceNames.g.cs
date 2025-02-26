// Copyright 2025 Google LLC
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

namespace Google.Ads.GoogleAds.V19.Resources
{
    /// <summary>Resource name for the <c>CustomerLifecycleGoal</c> resource.</summary>
    public sealed partial class CustomerLifecycleGoalName : gax::IResourceName, sys::IEquatable<CustomerLifecycleGoalName>
    {
        /// <summary>The possible contents of <see cref="CustomerLifecycleGoalName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/customerLifecycleGoals</c>.</summary>
            Customer = 1,
        }

        private static gax::PathTemplate s_customer = new gax::PathTemplate("customers/{customer_id}/customerLifecycleGoals");

        /// <summary>Creates a <see cref="CustomerLifecycleGoalName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerLifecycleGoalName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerLifecycleGoalName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerLifecycleGoalName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerLifecycleGoalName"/> with the pattern
        /// <c>customers/{customer_id}/customerLifecycleGoals</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerLifecycleGoalName"/> constructed from the provided ids.
        /// </returns>
        public static CustomerLifecycleGoalName FromCustomer(string customerId) =>
            new CustomerLifecycleGoalName(ResourceNameType.Customer, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerLifecycleGoalName"/> with pattern
        /// <c>customers/{customer_id}/customerLifecycleGoals</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerLifecycleGoalName"/> with pattern
        /// <c>customers/{customer_id}/customerLifecycleGoals</c>.
        /// </returns>
        public static string Format(string customerId) => FormatCustomer(customerId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerLifecycleGoalName"/> with pattern
        /// <c>customers/{customer_id}/customerLifecycleGoals</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerLifecycleGoalName"/> with pattern
        /// <c>customers/{customer_id}/customerLifecycleGoals</c>.
        /// </returns>
        public static string FormatCustomer(string customerId) =>
            s_customer.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerLifecycleGoalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerLifecycleGoals</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerLifecycleGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerLifecycleGoalName"/> if successful.</returns>
        public static CustomerLifecycleGoalName Parse(string customerLifecycleGoalName) =>
            Parse(customerLifecycleGoalName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerLifecycleGoalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerLifecycleGoals</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerLifecycleGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerLifecycleGoalName"/> if successful.</returns>
        public static CustomerLifecycleGoalName Parse(string customerLifecycleGoalName, bool allowUnparsed) =>
            TryParse(customerLifecycleGoalName, allowUnparsed, out CustomerLifecycleGoalName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerLifecycleGoalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerLifecycleGoals</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerLifecycleGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerLifecycleGoalName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerLifecycleGoalName, out CustomerLifecycleGoalName result) =>
            TryParse(customerLifecycleGoalName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerLifecycleGoalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerLifecycleGoals</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerLifecycleGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerLifecycleGoalName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerLifecycleGoalName, bool allowUnparsed, out CustomerLifecycleGoalName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerLifecycleGoalName, nameof(customerLifecycleGoalName));
            gax::TemplatedResourceName resourceName;
            if (s_customer.TryParseName(customerLifecycleGoalName, out resourceName))
            {
                result = FromCustomer(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerLifecycleGoalName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerLifecycleGoalName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerLifecycleGoalName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/customerLifecycleGoals</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerLifecycleGoalName(string customerId) : this(ResourceNameType.Customer, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)))
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

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Customer: return s_customer.Expand(CustomerId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerLifecycleGoalName);

        /// <inheritdoc/>
        public bool Equals(CustomerLifecycleGoalName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomerLifecycleGoalName a, CustomerLifecycleGoalName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomerLifecycleGoalName a, CustomerLifecycleGoalName b) => !(a == b);
    }

    public partial class CustomerLifecycleGoal
    {
        /// <summary>
        /// <see cref="CustomerLifecycleGoalName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CustomerLifecycleGoalName ResourceNameAsCustomerLifecycleGoalName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerLifecycleGoalName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
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

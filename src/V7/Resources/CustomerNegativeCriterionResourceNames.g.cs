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

using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V7.Resources
{
    /// <summary>Resource name for the <c>CustomerNegativeCriterion</c> resource.</summary>
    public sealed partial class CustomerNegativeCriterionName : gax::IResourceName, sys::IEquatable<CustomerNegativeCriterionName>
    {
        /// <summary>The possible contents of <see cref="CustomerNegativeCriterionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c>.
            /// </summary>
            CustomerCriterion = 1,
        }

        private static gax::PathTemplate s_customerCriterion = new gax::PathTemplate("customers/{customer_id}/customerNegativeCriteria/{criterion_id}");

        /// <summary>
        /// Creates a <see cref="CustomerNegativeCriterionName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerNegativeCriterionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerNegativeCriterionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerNegativeCriterionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerNegativeCriterionName"/> with the pattern
        /// <c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerNegativeCriterionName"/> constructed from the provided ids.
        /// </returns>
        public static CustomerNegativeCriterionName FromCustomerCriterion(string customerId, string criterionId) =>
            new CustomerNegativeCriterionName(ResourceNameType.CustomerCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerNegativeCriterionName"/> with
        /// pattern <c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerNegativeCriterionName"/> with pattern
        /// <c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c>.
        /// </returns>
        public static string Format(string customerId, string criterionId) => FormatCustomerCriterion(customerId, criterionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerNegativeCriterionName"/> with
        /// pattern <c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerNegativeCriterionName"/> with pattern
        /// <c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c>.
        /// </returns>
        public static string FormatCustomerCriterion(string customerId, string criterionId) =>
            s_customerCriterion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerNegativeCriterionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerNegativeCriterionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="CustomerNegativeCriterionName"/> if successful.</returns>
        public static CustomerNegativeCriterionName Parse(string customerNegativeCriterionName) =>
            Parse(customerNegativeCriterionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerNegativeCriterionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerNegativeCriterionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerNegativeCriterionName"/> if successful.</returns>
        public static CustomerNegativeCriterionName Parse(string customerNegativeCriterionName, bool allowUnparsed) =>
            TryParse(customerNegativeCriterionName, allowUnparsed, out CustomerNegativeCriterionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerNegativeCriterionName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="customerNegativeCriterionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerNegativeCriterionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerNegativeCriterionName, out CustomerNegativeCriterionName result) =>
            TryParse(customerNegativeCriterionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerNegativeCriterionName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerNegativeCriterionName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerNegativeCriterionName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerNegativeCriterionName, bool allowUnparsed, out CustomerNegativeCriterionName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerNegativeCriterionName, nameof(customerNegativeCriterionName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCriterion.TryParseName(customerNegativeCriterionName, out resourceName))
            {
                result = FromCustomerCriterion(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerNegativeCriterionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerNegativeCriterionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string criterionId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CriterionId = criterionId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerNegativeCriterionName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/customerNegativeCriteria/{criterion_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerNegativeCriterionName(string customerId, string criterionId) : this(ResourceNameType.CustomerCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))
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
        /// The <c>Criterion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CriterionId { get; }

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
                case ResourceNameType.CustomerCriterion: return s_customerCriterion.Expand(CustomerId, CriterionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerNegativeCriterionName);

        /// <inheritdoc/>
        public bool Equals(CustomerNegativeCriterionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CustomerNegativeCriterionName a, CustomerNegativeCriterionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CustomerNegativeCriterionName a, CustomerNegativeCriterionName b) => !(a == b);
    }

    public partial class CustomerNegativeCriterion
    {
        /// <summary>
        /// <see cref="CustomerNegativeCriterionName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CustomerNegativeCriterionName ResourceNameAsCustomerNegativeCriterionName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerNegativeCriterionName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

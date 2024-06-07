// Copyright 2024 Google LLC
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

namespace Google.Ads.GoogleAds.V17.Resources
{
    /// <summary>Resource name for the <c>CustomerLabel</c> resource.</summary>
    public sealed partial class CustomerLabelName : gax::IResourceName, sys::IEquatable<CustomerLabelName>
    {
        /// <summary>The possible contents of <see cref="CustomerLabelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/customerLabels/{label_id}</c>.
            /// </summary>
            CustomerLabel = 1,
        }

        private static gax::PathTemplate s_customerLabel = new gax::PathTemplate("customers/{customer_id}/customerLabels/{label_id}");

        /// <summary>Creates a <see cref="CustomerLabelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomerLabelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomerLabelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomerLabelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomerLabelName"/> with the pattern
        /// <c>customers/{customer_id}/customerLabels/{label_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="labelId">The <c>Label</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CustomerLabelName"/> constructed from the provided ids.</returns>
        public static CustomerLabelName FromCustomerLabel(string customerId, string labelId) =>
            new CustomerLabelName(ResourceNameType.CustomerLabel, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), labelId: gax::GaxPreconditions.CheckNotNullOrEmpty(labelId, nameof(labelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerLabelName"/> with pattern
        /// <c>customers/{customer_id}/customerLabels/{label_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="labelId">The <c>Label</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerLabelName"/> with pattern
        /// <c>customers/{customer_id}/customerLabels/{label_id}</c>.
        /// </returns>
        public static string Format(string customerId, string labelId) => FormatCustomerLabel(customerId, labelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomerLabelName"/> with pattern
        /// <c>customers/{customer_id}/customerLabels/{label_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="labelId">The <c>Label</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomerLabelName"/> with pattern
        /// <c>customers/{customer_id}/customerLabels/{label_id}</c>.
        /// </returns>
        public static string FormatCustomerLabel(string customerId, string labelId) =>
            s_customerLabel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(labelId, nameof(labelId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerLabels/{label_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomerLabelName"/> if successful.</returns>
        public static CustomerLabelName Parse(string customerLabelName) => Parse(customerLabelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomerLabelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerLabels/{label_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomerLabelName"/> if successful.</returns>
        public static CustomerLabelName Parse(string customerLabelName, bool allowUnparsed) =>
            TryParse(customerLabelName, allowUnparsed, out CustomerLabelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerLabels/{label_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customerLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerLabelName, out CustomerLabelName result) =>
            TryParse(customerLabelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomerLabelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customerLabels/{label_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customerLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomerLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customerLabelName, bool allowUnparsed, out CustomerLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(customerLabelName, nameof(customerLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_customerLabel.TryParseName(customerLabelName, out resourceName))
            {
                result = FromCustomerLabel(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customerLabelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomerLabelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string labelId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            LabelId = labelId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomerLabelName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/customerLabels/{label_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="labelId">The <c>Label</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomerLabelName(string customerId, string labelId) : this(ResourceNameType.CustomerLabel, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), labelId: gax::GaxPreconditions.CheckNotNullOrEmpty(labelId, nameof(labelId)))
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
        /// The <c>Label</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string LabelId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerLabel: return s_customerLabel.Expand(CustomerId, LabelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomerLabelName);

        /// <inheritdoc/>
        public bool Equals(CustomerLabelName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomerLabelName a, CustomerLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomerLabelName a, CustomerLabelName b) => !(a == b);
    }

    public partial class CustomerLabel
    {
        /// <summary>
        /// <see cref="CustomerLabelName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CustomerLabelName ResourceNameAsCustomerLabelName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CustomerLabelName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="Customer"/> resource name property.
        /// </summary>
        internal CustomerName CustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(Customer) ? null : CustomerName.Parse(Customer, allowUnparsed: true);
            set => Customer = value?.ToString() ?? "";
        }

        /// <summary><see cref="LabelName"/>-typed view over the <see cref="Label"/> resource name property.</summary>
        internal LabelName LabelAsLabelName
        {
            get => string.IsNullOrEmpty(Label) ? null : LabelName.Parse(Label, allowUnparsed: true);
            set => Label = value?.ToString() ?? "";
        }
    }
}

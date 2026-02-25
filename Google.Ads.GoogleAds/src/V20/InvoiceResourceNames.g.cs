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

namespace Google.Ads.GoogleAds.V20.Resources
{
    /// <summary>Resource name for the <c>Invoice</c> resource.</summary>
    public sealed partial class InvoiceName : gax::IResourceName, sys::IEquatable<InvoiceName>
    {
        /// <summary>The possible contents of <see cref="InvoiceName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/invoices/{invoice_id}</c>.</summary>
            CustomerInvoice = 1,
        }

        private static gax::PathTemplate s_customerInvoice = new gax::PathTemplate("customers/{customer_id}/invoices/{invoice_id}");

        /// <summary>Creates a <see cref="InvoiceName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="InvoiceName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static InvoiceName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new InvoiceName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="InvoiceName"/> with the pattern <c>customers/{customer_id}/invoices/{invoice_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="invoiceId">The <c>Invoice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="InvoiceName"/> constructed from the provided ids.</returns>
        public static InvoiceName FromCustomerInvoice(string customerId, string invoiceId) =>
            new InvoiceName(ResourceNameType.CustomerInvoice, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), invoiceId: gax::GaxPreconditions.CheckNotNullOrEmpty(invoiceId, nameof(invoiceId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InvoiceName"/> with pattern
        /// <c>customers/{customer_id}/invoices/{invoice_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="invoiceId">The <c>Invoice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InvoiceName"/> with pattern
        /// <c>customers/{customer_id}/invoices/{invoice_id}</c>.
        /// </returns>
        public static string Format(string customerId, string invoiceId) => FormatCustomerInvoice(customerId, invoiceId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="InvoiceName"/> with pattern
        /// <c>customers/{customer_id}/invoices/{invoice_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="invoiceId">The <c>Invoice</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="InvoiceName"/> with pattern
        /// <c>customers/{customer_id}/invoices/{invoice_id}</c>.
        /// </returns>
        public static string FormatCustomerInvoice(string customerId, string invoiceId) =>
            s_customerInvoice.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(invoiceId, nameof(invoiceId)));

        /// <summary>Parses the given resource name string into a new <see cref="InvoiceName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/invoices/{invoice_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="invoiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="InvoiceName"/> if successful.</returns>
        public static InvoiceName Parse(string invoiceName) => Parse(invoiceName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="InvoiceName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/invoices/{invoice_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="invoiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="InvoiceName"/> if successful.</returns>
        public static InvoiceName Parse(string invoiceName, bool allowUnparsed) =>
            TryParse(invoiceName, allowUnparsed, out InvoiceName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InvoiceName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/invoices/{invoice_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="invoiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InvoiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string invoiceName, out InvoiceName result) => TryParse(invoiceName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="InvoiceName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/invoices/{invoice_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="invoiceName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="InvoiceName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string invoiceName, bool allowUnparsed, out InvoiceName result)
        {
            gax::GaxPreconditions.CheckNotNull(invoiceName, nameof(invoiceName));
            gax::TemplatedResourceName resourceName;
            if (s_customerInvoice.TryParseName(invoiceName, out resourceName))
            {
                result = FromCustomerInvoice(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(invoiceName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private InvoiceName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string invoiceId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            InvoiceId = invoiceId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="InvoiceName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/invoices/{invoice_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="invoiceId">The <c>Invoice</c> ID. Must not be <c>null</c> or empty.</param>
        public InvoiceName(string customerId, string invoiceId) : this(ResourceNameType.CustomerInvoice, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), invoiceId: gax::GaxPreconditions.CheckNotNullOrEmpty(invoiceId, nameof(invoiceId)))
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
        /// The <c>Invoice</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string InvoiceId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerInvoice: return s_customerInvoice.Expand(CustomerId, InvoiceId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as InvoiceName);

        /// <inheritdoc/>
        public bool Equals(InvoiceName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(InvoiceName a, InvoiceName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(InvoiceName a, InvoiceName b) => !(a == b);
    }

    public partial class Invoice
    {
        /// <summary>
        /// <see cref="InvoiceName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal InvoiceName ResourceNameAsInvoiceName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : InvoiceName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

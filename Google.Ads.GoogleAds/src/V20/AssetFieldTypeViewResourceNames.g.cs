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

namespace Google.Ads.GoogleAds.V20.Resources
{
    /// <summary>Resource name for the <c>AssetFieldTypeView</c> resource.</summary>
    public sealed partial class AssetFieldTypeViewName : gax::IResourceName, sys::IEquatable<AssetFieldTypeViewName>
    {
        /// <summary>The possible contents of <see cref="AssetFieldTypeViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c>.
            /// </summary>
            CustomerFieldType = 1,
        }

        private static gax::PathTemplate s_customerFieldType = new gax::PathTemplate("customers/{customer_id}/assetFieldTypeViews/{field_type}");

        /// <summary>Creates a <see cref="AssetFieldTypeViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetFieldTypeViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssetFieldTypeViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetFieldTypeViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetFieldTypeViewName"/> with the pattern
        /// <c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssetFieldTypeViewName"/> constructed from the provided ids.</returns>
        public static AssetFieldTypeViewName FromCustomerFieldType(string customerId, string fieldTypeId) =>
            new AssetFieldTypeViewName(ResourceNameType.CustomerFieldType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), fieldTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetFieldTypeViewName"/> with pattern
        /// <c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetFieldTypeViewName"/> with pattern
        /// <c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c>.
        /// </returns>
        public static string Format(string customerId, string fieldTypeId) => FormatCustomerFieldType(customerId, fieldTypeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetFieldTypeViewName"/> with pattern
        /// <c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetFieldTypeViewName"/> with pattern
        /// <c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c>.
        /// </returns>
        public static string FormatCustomerFieldType(string customerId, string fieldTypeId) =>
            s_customerFieldType.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetFieldTypeViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assetFieldTypeViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetFieldTypeViewName"/> if successful.</returns>
        public static AssetFieldTypeViewName Parse(string assetFieldTypeViewName) => Parse(assetFieldTypeViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetFieldTypeViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetFieldTypeViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssetFieldTypeViewName"/> if successful.</returns>
        public static AssetFieldTypeViewName Parse(string assetFieldTypeViewName, bool allowUnparsed) =>
            TryParse(assetFieldTypeViewName, allowUnparsed, out AssetFieldTypeViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetFieldTypeViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="assetFieldTypeViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetFieldTypeViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetFieldTypeViewName, out AssetFieldTypeViewName result) =>
            TryParse(assetFieldTypeViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetFieldTypeViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetFieldTypeViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetFieldTypeViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetFieldTypeViewName, bool allowUnparsed, out AssetFieldTypeViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetFieldTypeViewName, nameof(assetFieldTypeViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerFieldType.TryParseName(assetFieldTypeViewName, out resourceName))
            {
                result = FromCustomerFieldType(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assetFieldTypeViewName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AssetFieldTypeViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string fieldTypeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            FieldTypeId = fieldTypeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetFieldTypeViewName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/assetFieldTypeViews/{field_type}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="fieldTypeId">The <c>FieldType</c> ID. Must not be <c>null</c> or empty.</param>
        public AssetFieldTypeViewName(string customerId, string fieldTypeId) : this(ResourceNameType.CustomerFieldType, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), fieldTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(fieldTypeId, nameof(fieldTypeId)))
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
        /// The <c>FieldType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FieldTypeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerFieldType: return s_customerFieldType.Expand(CustomerId, FieldTypeId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetFieldTypeViewName);

        /// <inheritdoc/>
        public bool Equals(AssetFieldTypeViewName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssetFieldTypeViewName a, AssetFieldTypeViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AssetFieldTypeViewName a, AssetFieldTypeViewName b) => !(a == b);
    }

    public partial class AssetFieldTypeView
    {
        /// <summary>
        /// <see cref="AssetFieldTypeViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AssetFieldTypeViewName ResourceNameAsAssetFieldTypeViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AssetFieldTypeViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

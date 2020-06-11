// Copyright 2020 Google LLC
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

namespace Google.Ads.GoogleAds.V3.Resources
{
    /// <summary>Resource name for the <c>AdGroupLabel</c> resource.</summary>
    public sealed partial class AdGroupLabelName : gax::IResourceName, sys::IEquatable<AdGroupLabelName>
    {
        /// <summary>The possible contents of <see cref="AdGroupLabelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/adGroupLabels/{ad_group_label}</c>.
            /// </summary>
            CustomerAdGroupLabel = 1
        }

        private static gax::PathTemplate s_customerAdGroupLabel = new gax::PathTemplate("customers/{customer}/adGroupLabels/{ad_group_label}");

        /// <summary>Creates a <see cref="AdGroupLabelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupLabelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupLabelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupLabelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupLabelName"/> with the pattern
        /// <c>customers/{customer}/adGroupLabels/{ad_group_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupLabelId">The <c>AdGroupLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdGroupLabelName"/> constructed from the provided ids.</returns>
        public static AdGroupLabelName FromCustomerAdGroupLabel(string customerId, string adGroupLabelId) =>
            new AdGroupLabelName(ResourceNameType.CustomerAdGroupLabel, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupLabelId, nameof(adGroupLabelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupLabels/{ad_group_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupLabelId">The <c>AdGroupLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupLabels/{ad_group_label}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupLabelId) =>
            FormatCustomerAdGroupLabel(customerId, adGroupLabelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupLabels/{ad_group_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupLabelId">The <c>AdGroupLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupLabels/{ad_group_label}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupLabel(string customerId, string adGroupLabelId) =>
            s_customerAdGroupLabel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupLabelId, nameof(adGroupLabelId)));

        /// <summary>Parses the given resource name string into a new <see cref="AdGroupLabelName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupLabels/{ad_group_label}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupLabelName"/> if successful.</returns>
        public static AdGroupLabelName Parse(string adGroupLabelName) => Parse(adGroupLabelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupLabelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupLabels/{ad_group_label}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupLabelName"/> if successful.</returns>
        public static AdGroupLabelName Parse(string adGroupLabelName, bool allowUnparsed) =>
            TryParse(adGroupLabelName, allowUnparsed, out AdGroupLabelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupLabels/{ad_group_label}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupLabelName, out AdGroupLabelName result) =>
            TryParse(adGroupLabelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupLabelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupLabels/{ad_group_label}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupLabelName, bool allowUnparsed, out AdGroupLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupLabelName, nameof(adGroupLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupLabel.TryParseName(adGroupLabelName, out resourceName))
            {
                result = FromCustomerAdGroupLabel(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupLabelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupLabelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupLabelId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupLabelId = adGroupLabelId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupLabelName"/> class from the component parts of pattern
        /// <c>customers/{customer}/adGroupLabels/{ad_group_label}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupLabelId">The <c>AdGroupLabel</c> ID. Must not be <c>null</c> or empty.</param>
        public AdGroupLabelName(string customerId, string adGroupLabelId) : this(ResourceNameType.CustomerAdGroupLabel, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupLabelId, nameof(adGroupLabelId)))
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
        /// The <c>AdGroupLabel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AdGroupLabelId { get; }

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
                case ResourceNameType.CustomerAdGroupLabel: return s_customerAdGroupLabel.Expand(CustomerId, AdGroupLabelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupLabelName);

        /// <inheritdoc/>
        public bool Equals(AdGroupLabelName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupLabelName a, AdGroupLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupLabelName a, AdGroupLabelName b) => !(a == b);
    }

    public partial class AdGroupLabel
    {
        /// <summary>
        /// <see cref="AdGroupLabelName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupLabelName ResourceNameAsAdGroupLabelName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupLabelName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupName"/>-typed view over the <see cref="AdGroup"/> resource name property.
        /// </summary>
        internal AdGroupName AdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(AdGroup) ? null : AdGroupName.Parse(AdGroup, allowUnparsed: true);
            set => AdGroup = value?.ToString() ?? "";
        }

        /// <summary><see cref="LabelName"/>-typed view over the <see cref="Label"/> resource name property.</summary>
        internal LabelName LabelAsLabelName
        {
            get => string.IsNullOrEmpty(Label) ? null : LabelName.Parse(Label, allowUnparsed: true);
            set => Label = value?.ToString() ?? "";
        }
    }
}

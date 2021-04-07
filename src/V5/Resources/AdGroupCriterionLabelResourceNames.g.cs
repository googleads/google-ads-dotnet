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

namespace Google.Ads.GoogleAds.V5.Resources
{
    /// <summary>Resource name for the <c>AdGroupCriterionLabel</c> resource.</summary>
    public sealed partial class AdGroupCriterionLabelName : gax::IResourceName, sys::IEquatable<AdGroupCriterionLabelName>
    {
        /// <summary>The possible contents of <see cref="AdGroupCriterionLabelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c>
            /// .
            /// </summary>
            CustomerAdGroupCriterionLabel = 1,
        }

        private static gax::PathTemplate s_customerAdGroupCriterionLabel = new gax::PathTemplate("customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}");

        /// <summary>Creates a <see cref="AdGroupCriterionLabelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupCriterionLabelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupCriterionLabelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupCriterionLabelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupCriterionLabelName"/> with the pattern
        /// <c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupCriterionLabelId">
        /// The <c>AdGroupCriterionLabel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AdGroupCriterionLabelName"/> constructed from the provided ids.
        /// </returns>
        public static AdGroupCriterionLabelName FromCustomerAdGroupCriterionLabel(string customerId, string adGroupCriterionLabelId) =>
            new AdGroupCriterionLabelName(ResourceNameType.CustomerAdGroupCriterionLabel, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupCriterionLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupCriterionLabelId, nameof(adGroupCriterionLabelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupCriterionLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupCriterionLabelId">
        /// The <c>AdGroupCriterionLabel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupCriterionLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupCriterionLabelId) =>
            FormatCustomerAdGroupCriterionLabel(customerId, adGroupCriterionLabelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupCriterionLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupCriterionLabelId">
        /// The <c>AdGroupCriterionLabel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupCriterionLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupCriterionLabel(string customerId, string adGroupCriterionLabelId) =>
            s_customerAdGroupCriterionLabel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupCriterionLabelId, nameof(adGroupCriterionLabelId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupCriterionLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupCriterionLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupCriterionLabelName"/> if successful.</returns>
        public static AdGroupCriterionLabelName Parse(string adGroupCriterionLabelName) =>
            Parse(adGroupCriterionLabelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupCriterionLabelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupCriterionLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupCriterionLabelName"/> if successful.</returns>
        public static AdGroupCriterionLabelName Parse(string adGroupCriterionLabelName, bool allowUnparsed) =>
            TryParse(adGroupCriterionLabelName, allowUnparsed, out AdGroupCriterionLabelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupCriterionLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupCriterionLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupCriterionLabelName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupCriterionLabelName, out AdGroupCriterionLabelName result) =>
            TryParse(adGroupCriterionLabelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupCriterionLabelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupCriterionLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupCriterionLabelName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupCriterionLabelName, bool allowUnparsed, out AdGroupCriterionLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupCriterionLabelName, nameof(adGroupCriterionLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupCriterionLabel.TryParseName(adGroupCriterionLabelName, out resourceName))
            {
                result = FromCustomerAdGroupCriterionLabel(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupCriterionLabelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupCriterionLabelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupCriterionLabelId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupCriterionLabelId = adGroupCriterionLabelId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupCriterionLabelName"/> class from the component parts of
        /// pattern <c>customers/{customer}/adGroupCriterionLabels/{ad_group_criterion_label}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupCriterionLabelId">
        /// The <c>AdGroupCriterionLabel</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AdGroupCriterionLabelName(string customerId, string adGroupCriterionLabelId) : this(ResourceNameType.CustomerAdGroupCriterionLabel, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupCriterionLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupCriterionLabelId, nameof(adGroupCriterionLabelId)))
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
        /// The <c>AdGroupCriterionLabel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AdGroupCriterionLabelId { get; }

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
                case ResourceNameType.CustomerAdGroupCriterionLabel: return s_customerAdGroupCriterionLabel.Expand(CustomerId, AdGroupCriterionLabelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupCriterionLabelName);

        /// <inheritdoc/>
        public bool Equals(AdGroupCriterionLabelName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupCriterionLabelName a, AdGroupCriterionLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupCriterionLabelName a, AdGroupCriterionLabelName b) => !(a == b);
    }

    public partial class AdGroupCriterionLabel
    {
        /// <summary>
        /// <see cref="AdGroupCriterionLabelName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal AdGroupCriterionLabelName ResourceNameAsAdGroupCriterionLabelName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupCriterionLabelName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupCriterionName"/>-typed view over the <see cref="AdGroupCriterion"/> resource name
        /// property.
        /// </summary>
        internal AdGroupCriterionName AdGroupCriterionAsAdGroupCriterionName
        {
            get => string.IsNullOrEmpty(AdGroupCriterion) ? null : AdGroupCriterionName.Parse(AdGroupCriterion, allowUnparsed: true);
            set => AdGroupCriterion = value?.ToString() ?? "";
        }

        /// <summary><see cref="LabelName"/>-typed view over the <see cref="Label"/> resource name property.</summary>
        internal LabelName LabelAsLabelName
        {
            get => string.IsNullOrEmpty(Label) ? null : LabelName.Parse(Label, allowUnparsed: true);
            set => Label = value?.ToString() ?? "";
        }
    }
}

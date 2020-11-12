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
    /// <summary>Resource name for the <c>AdGroupAdLabel</c> resource.</summary>
    public sealed partial class AdGroupAdLabelName : gax::IResourceName, sys::IEquatable<AdGroupAdLabelName>
    {
        /// <summary>The possible contents of <see cref="AdGroupAdLabelName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c>.
            /// </summary>
            CustomerAdGroupAdLabel = 1,
        }

        private static gax::PathTemplate s_customerAdGroupAdLabel = new gax::PathTemplate("customers/{customer}/adGroupAdLabels/{ad_group_ad_label}");

        /// <summary>Creates a <see cref="AdGroupAdLabelName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupAdLabelName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupAdLabelName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupAdLabelName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupAdLabelName"/> with the pattern
        /// <c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdLabelId">The <c>AdGroupAdLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdGroupAdLabelName"/> constructed from the provided ids.</returns>
        public static AdGroupAdLabelName FromCustomerAdGroupAdLabel(string customerId, string adGroupAdLabelId) =>
            new AdGroupAdLabelName(ResourceNameType.CustomerAdGroupAdLabel, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupAdLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAdLabelId, nameof(adGroupAdLabelId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAdLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdLabelId">The <c>AdGroupAdLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAdLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupAdLabelId) =>
            FormatCustomerAdGroupAdLabel(customerId, adGroupAdLabelId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupAdLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdLabelId">The <c>AdGroupAdLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupAdLabelName"/> with pattern
        /// <c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupAdLabel(string customerId, string adGroupAdLabelId) =>
            s_customerAdGroupAdLabel.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAdLabelId, nameof(adGroupAdLabelId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAdLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAdLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupAdLabelName"/> if successful.</returns>
        public static AdGroupAdLabelName Parse(string adGroupAdLabelName) => Parse(adGroupAdLabelName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupAdLabelName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAdLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupAdLabelName"/> if successful.</returns>
        public static AdGroupAdLabelName Parse(string adGroupAdLabelName, bool allowUnparsed) =>
            TryParse(adGroupAdLabelName, allowUnparsed, out AdGroupAdLabelName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAdLabelName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupAdLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAdLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdLabelName, out AdGroupAdLabelName result) =>
            TryParse(adGroupAdLabelName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupAdLabelName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupAdLabelName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupAdLabelName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupAdLabelName, bool allowUnparsed, out AdGroupAdLabelName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupAdLabelName, nameof(adGroupAdLabelName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupAdLabel.TryParseName(adGroupAdLabelName, out resourceName))
            {
                result = FromCustomerAdGroupAdLabel(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupAdLabelName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupAdLabelName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupAdLabelId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupAdLabelId = adGroupAdLabelId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupAdLabelName"/> class from the component parts of pattern
        /// <c>customers/{customer}/adGroupAdLabels/{ad_group_ad_label}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupAdLabelId">The <c>AdGroupAdLabel</c> ID. Must not be <c>null</c> or empty.</param>
        public AdGroupAdLabelName(string customerId, string adGroupAdLabelId) : this(ResourceNameType.CustomerAdGroupAdLabel, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupAdLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAdLabelId, nameof(adGroupAdLabelId)))
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
        /// The <c>AdGroupAdLabel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AdGroupAdLabelId { get; }

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
                case ResourceNameType.CustomerAdGroupAdLabel: return s_customerAdGroupAdLabel.Expand(CustomerId, AdGroupAdLabelId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupAdLabelName);

        /// <inheritdoc/>
        public bool Equals(AdGroupAdLabelName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupAdLabelName a, AdGroupAdLabelName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupAdLabelName a, AdGroupAdLabelName b) => !(a == b);
    }

    public partial class AdGroupAdLabel
    {
        /// <summary>
        /// <see cref="AdGroupAdLabelName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupAdLabelName ResourceNameAsAdGroupAdLabelName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupAdLabelName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupAdName"/>-typed view over the <see cref="AdGroupAd"/> resource name property.
        /// </summary>
        internal AdGroupAdName AdGroupAdAsAdGroupAdName
        {
            get => string.IsNullOrEmpty(AdGroupAd) ? null : AdGroupAdName.Parse(AdGroupAd, allowUnparsed: true);
            set => AdGroupAd = value?.ToString() ?? "";
        }

        /// <summary><see cref="LabelName"/>-typed view over the <see cref="Label"/> resource name property.</summary>
        internal LabelName LabelAsLabelName
        {
            get => string.IsNullOrEmpty(Label) ? null : LabelName.Parse(Label, allowUnparsed: true);
            set => Label = value?.ToString() ?? "";
        }
    }
}

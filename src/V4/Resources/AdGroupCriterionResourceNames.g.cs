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

namespace Google.Ads.GoogleAds.V4.Resources
{
    /// <summary>Resource name for the <c>AdGroupCriterion</c> resource.</summary>
    public sealed partial class AdGroupCriterionName : gax::IResourceName, sys::IEquatable<AdGroupCriterionName>
    {
        /// <summary>The possible contents of <see cref="AdGroupCriterionName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c>.
            /// </summary>
            CustomerAdGroupCriterion = 1,
        }

        private static gax::PathTemplate s_customerAdGroupCriterion = new gax::PathTemplate("customers/{customer}/adGroupCriteria/{ad_group_criterion}");

        /// <summary>Creates a <see cref="AdGroupCriterionName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupCriterionName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupCriterionName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupCriterionName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupCriterionName"/> with the pattern
        /// <c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupCriterionId">The <c>AdGroupCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdGroupCriterionName"/> constructed from the provided ids.</returns>
        public static AdGroupCriterionName FromCustomerAdGroupCriterion(string customerId, string adGroupCriterionId) =>
            new AdGroupCriterionName(ResourceNameType.CustomerAdGroupCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupCriterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupCriterionId, nameof(adGroupCriterionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupCriterionName"/> with pattern
        /// <c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupCriterionId">The <c>AdGroupCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupCriterionName"/> with pattern
        /// <c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupCriterionId) =>
            FormatCustomerAdGroupCriterion(customerId, adGroupCriterionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupCriterionName"/> with pattern
        /// <c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupCriterionId">The <c>AdGroupCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupCriterionName"/> with pattern
        /// <c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupCriterion(string customerId, string adGroupCriterionId) =>
            s_customerAdGroupCriterion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupCriterionId, nameof(adGroupCriterionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupCriterionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupCriterionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupCriterionName"/> if successful.</returns>
        public static AdGroupCriterionName Parse(string adGroupCriterionName) => Parse(adGroupCriterionName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupCriterionName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupCriterionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupCriterionName"/> if successful.</returns>
        public static AdGroupCriterionName Parse(string adGroupCriterionName, bool allowUnparsed) =>
            TryParse(adGroupCriterionName, allowUnparsed, out AdGroupCriterionName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupCriterionName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupCriterionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupCriterionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupCriterionName, out AdGroupCriterionName result) =>
            TryParse(adGroupCriterionName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupCriterionName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupCriterionName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupCriterionName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupCriterionName, bool allowUnparsed, out AdGroupCriterionName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupCriterionName, nameof(adGroupCriterionName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupCriterion.TryParseName(adGroupCriterionName, out resourceName))
            {
                result = FromCustomerAdGroupCriterion(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupCriterionName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupCriterionName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupCriterionId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupCriterionId = adGroupCriterionId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupCriterionName"/> class from the component parts of pattern
        /// <c>customers/{customer}/adGroupCriteria/{ad_group_criterion}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupCriterionId">The <c>AdGroupCriterion</c> ID. Must not be <c>null</c> or empty.</param>
        public AdGroupCriterionName(string customerId, string adGroupCriterionId) : this(ResourceNameType.CustomerAdGroupCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupCriterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupCriterionId, nameof(adGroupCriterionId)))
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
        /// The <c>AdGroupCriterion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string AdGroupCriterionId { get; }

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
                case ResourceNameType.CustomerAdGroupCriterion: return s_customerAdGroupCriterion.Expand(CustomerId, AdGroupCriterionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupCriterionName);

        /// <inheritdoc/>
        public bool Equals(AdGroupCriterionName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(AdGroupCriterionName a, AdGroupCriterionName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(AdGroupCriterionName a, AdGroupCriterionName b) => !(a == b);
    }

    public partial class AdGroupCriterion
    {
        /// <summary>
        /// <see cref="AdGroupCriterionName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupCriterionName ResourceNameAsAdGroupCriterionName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupCriterionName.Parse(ResourceName, allowUnparsed: true);
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
    }
}

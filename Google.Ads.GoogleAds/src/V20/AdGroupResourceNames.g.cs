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
using gagvr = Google.Ads.GoogleAds.V20.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V20.Resources
{
    /// <summary>Resource name for the <c>AdGroup</c> resource.</summary>
    public sealed partial class AdGroupName : gax::IResourceName, sys::IEquatable<AdGroupName>
    {
        /// <summary>The possible contents of <see cref="AdGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer_id}/adGroups/{ad_group_id}</c>.</summary>
            CustomerAdGroup = 1,
        }

        private static gax::PathTemplate s_customerAdGroup = new gax::PathTemplate("customers/{customer_id}/adGroups/{ad_group_id}");

        /// <summary>Creates a <see cref="AdGroupName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupName"/> containing the provided <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupName"/> with the pattern <c>customers/{customer_id}/adGroups/{ad_group_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AdGroupName"/> constructed from the provided ids.</returns>
        public static AdGroupName FromCustomerAdGroup(string customerId, string adGroupId) =>
            new AdGroupName(ResourceNameType.CustomerAdGroup, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupName"/> with pattern
        /// <c>customers/{customer_id}/adGroups/{ad_group_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupName"/> with pattern
        /// <c>customers/{customer_id}/adGroups/{ad_group_id}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupId) => FormatCustomerAdGroup(customerId, adGroupId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupName"/> with pattern
        /// <c>customers/{customer_id}/adGroups/{ad_group_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupName"/> with pattern
        /// <c>customers/{customer_id}/adGroups/{ad_group_id}</c>.
        /// </returns>
        public static string FormatCustomerAdGroup(string customerId, string adGroupId) =>
            s_customerAdGroup.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)));

        /// <summary>Parses the given resource name string into a new <see cref="AdGroupName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/adGroups/{ad_group_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupName"/> if successful.</returns>
        public static AdGroupName Parse(string adGroupName) => Parse(adGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupName"/> instance; optionally allowing an
        /// unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/adGroups/{ad_group_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupName"/> if successful.</returns>
        public static AdGroupName Parse(string adGroupName, bool allowUnparsed) =>
            TryParse(adGroupName, allowUnparsed, out AdGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/adGroups/{ad_group_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupName, out AdGroupName result) => TryParse(adGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/adGroups/{ad_group_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupName, bool allowUnparsed, out AdGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupName, nameof(adGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroup.TryParseName(adGroupName, out resourceName))
            {
                result = FromCustomerAdGroup(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private AdGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupId = adGroupId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/adGroups/{ad_group_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        public AdGroupName(string customerId, string adGroupId) : this(ResourceNameType.CustomerAdGroup, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))
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
        /// The <c>AdGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AdGroupId { get; }

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
                case ResourceNameType.CustomerAdGroup: return s_customerAdGroup.Expand(CustomerId, AdGroupId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupName);

        /// <inheritdoc/>
        public bool Equals(AdGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AdGroupName a, AdGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AdGroupName a, AdGroupName b) => !(a == b);
    }

    public partial class AdGroup
    {
        /// <summary>
        /// <see cref="gagvr::AdGroupName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal gagvr::AdGroupName ResourceNameAsAdGroupName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::AdGroupName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::AdGroupName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::AdGroupName AdGroupName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::AdGroupName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::AdGroupName"/>-typed view over the <see cref="BaseAdGroup"/> resource name property.
        /// </summary>
        internal gagvr::AdGroupName BaseAdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(BaseAdGroup) ? null : gagvr::AdGroupName.Parse(BaseAdGroup, allowUnparsed: true);
            set => BaseAdGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaign"/> resource name property.
        /// </summary>
        internal CampaignName CampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(Campaign) ? null : CampaignName.Parse(Campaign, allowUnparsed: true);
            set => Campaign = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupLabelName"/>-typed view over the <see cref="Labels"/> resource name property.
        /// </summary>
        internal gax::ResourceNameList<AdGroupLabelName> LabelsAsAdGroupLabelNames
        {
            get => new gax::ResourceNameList<AdGroupLabelName>(Labels, s => string.IsNullOrEmpty(s) ? null : AdGroupLabelName.Parse(s, allowUnparsed: true));
        }
    }
}

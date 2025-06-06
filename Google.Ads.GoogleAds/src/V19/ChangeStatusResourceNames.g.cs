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
    /// <summary>Resource name for the <c>ChangeStatus</c> resource.</summary>
    public sealed partial class ChangeStatusName : gax::IResourceName, sys::IEquatable<ChangeStatusName>
    {
        /// <summary>The possible contents of <see cref="ChangeStatusName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/changeStatus/{change_status_id}</c>.
            /// </summary>
            CustomerChangeStatus = 1,
        }

        private static gax::PathTemplate s_customerChangeStatus = new gax::PathTemplate("customers/{customer_id}/changeStatus/{change_status_id}");

        /// <summary>Creates a <see cref="ChangeStatusName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChangeStatusName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChangeStatusName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChangeStatusName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChangeStatusName"/> with the pattern
        /// <c>customers/{customer_id}/changeStatus/{change_status_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeStatusId">The <c>ChangeStatus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChangeStatusName"/> constructed from the provided ids.</returns>
        public static ChangeStatusName FromCustomerChangeStatus(string customerId, string changeStatusId) =>
            new ChangeStatusName(ResourceNameType.CustomerChangeStatus, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), changeStatusId: gax::GaxPreconditions.CheckNotNullOrEmpty(changeStatusId, nameof(changeStatusId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChangeStatusName"/> with pattern
        /// <c>customers/{customer_id}/changeStatus/{change_status_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeStatusId">The <c>ChangeStatus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChangeStatusName"/> with pattern
        /// <c>customers/{customer_id}/changeStatus/{change_status_id}</c>.
        /// </returns>
        public static string Format(string customerId, string changeStatusId) =>
            FormatCustomerChangeStatus(customerId, changeStatusId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChangeStatusName"/> with pattern
        /// <c>customers/{customer_id}/changeStatus/{change_status_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeStatusId">The <c>ChangeStatus</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChangeStatusName"/> with pattern
        /// <c>customers/{customer_id}/changeStatus/{change_status_id}</c>.
        /// </returns>
        public static string FormatCustomerChangeStatus(string customerId, string changeStatusId) =>
            s_customerChangeStatus.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(changeStatusId, nameof(changeStatusId)));

        /// <summary>Parses the given resource name string into a new <see cref="ChangeStatusName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/changeStatus/{change_status_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="changeStatusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChangeStatusName"/> if successful.</returns>
        public static ChangeStatusName Parse(string changeStatusName) => Parse(changeStatusName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChangeStatusName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/changeStatus/{change_status_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="changeStatusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChangeStatusName"/> if successful.</returns>
        public static ChangeStatusName Parse(string changeStatusName, bool allowUnparsed) =>
            TryParse(changeStatusName, allowUnparsed, out ChangeStatusName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChangeStatusName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/changeStatus/{change_status_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="changeStatusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChangeStatusName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changeStatusName, out ChangeStatusName result) =>
            TryParse(changeStatusName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChangeStatusName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/changeStatus/{change_status_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="changeStatusName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChangeStatusName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changeStatusName, bool allowUnparsed, out ChangeStatusName result)
        {
            gax::GaxPreconditions.CheckNotNull(changeStatusName, nameof(changeStatusName));
            gax::TemplatedResourceName resourceName;
            if (s_customerChangeStatus.TryParseName(changeStatusName, out resourceName))
            {
                result = FromCustomerChangeStatus(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(changeStatusName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ChangeStatusName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string changeStatusId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChangeStatusId = changeStatusId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChangeStatusName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/changeStatus/{change_status_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="changeStatusId">The <c>ChangeStatus</c> ID. Must not be <c>null</c> or empty.</param>
        public ChangeStatusName(string customerId, string changeStatusId) : this(ResourceNameType.CustomerChangeStatus, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), changeStatusId: gax::GaxPreconditions.CheckNotNullOrEmpty(changeStatusId, nameof(changeStatusId)))
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
        /// The <c>ChangeStatus</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string ChangeStatusId { get; }

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
                case ResourceNameType.CustomerChangeStatus: return s_customerChangeStatus.Expand(CustomerId, ChangeStatusId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChangeStatusName);

        /// <inheritdoc/>
        public bool Equals(ChangeStatusName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChangeStatusName a, ChangeStatusName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChangeStatusName a, ChangeStatusName b) => !(a == b);
    }

    public partial class ChangeStatus
    {
        /// <summary>
        /// <see cref="ChangeStatusName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal ChangeStatusName ResourceNameAsChangeStatusName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ChangeStatusName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
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
        /// <see cref="AdGroupName"/>-typed view over the <see cref="AdGroup"/> resource name property.
        /// </summary>
        internal AdGroupName AdGroupAsAdGroupName
        {
            get => string.IsNullOrEmpty(AdGroup) ? null : AdGroupName.Parse(AdGroup, allowUnparsed: true);
            set => AdGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupAdName"/>-typed view over the <see cref="AdGroupAd"/> resource name property.
        /// </summary>
        internal AdGroupAdName AdGroupAdAsAdGroupAdName
        {
            get => string.IsNullOrEmpty(AdGroupAd) ? null : AdGroupAdName.Parse(AdGroupAd, allowUnparsed: true);
            set => AdGroupAd = value?.ToString() ?? "";
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

        /// <summary>
        /// <see cref="CampaignCriterionName"/>-typed view over the <see cref="CampaignCriterion"/> resource name
        /// property.
        /// </summary>
        internal CampaignCriterionName CampaignCriterionAsCampaignCriterionName
        {
            get => string.IsNullOrEmpty(CampaignCriterion) ? null : CampaignCriterionName.Parse(CampaignCriterion, allowUnparsed: true);
            set => CampaignCriterion = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupBidModifierName"/>-typed view over the <see cref="AdGroupBidModifier"/> resource name
        /// property.
        /// </summary>
        internal AdGroupBidModifierName AdGroupBidModifierAsAdGroupBidModifierName
        {
            get => string.IsNullOrEmpty(AdGroupBidModifier) ? null : AdGroupBidModifierName.Parse(AdGroupBidModifier, allowUnparsed: true);
            set => AdGroupBidModifier = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="SharedSetName"/>-typed view over the <see cref="SharedSet"/> resource name property.
        /// </summary>
        internal SharedSetName SharedSetAsSharedSetName
        {
            get => string.IsNullOrEmpty(SharedSet) ? null : SharedSetName.Parse(SharedSet, allowUnparsed: true);
            set => SharedSet = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignSharedSetName"/>-typed view over the <see cref="CampaignSharedSet"/> resource name
        /// property.
        /// </summary>
        internal CampaignSharedSetName CampaignSharedSetAsCampaignSharedSetName
        {
            get => string.IsNullOrEmpty(CampaignSharedSet) ? null : CampaignSharedSetName.Parse(CampaignSharedSet, allowUnparsed: true);
            set => CampaignSharedSet = value?.ToString() ?? "";
        }

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        internal AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CustomerAssetName"/>-typed view over the <see cref="CustomerAsset"/> resource name property.
        /// </summary>
        internal CustomerAssetName CustomerAssetAsCustomerAssetName
        {
            get => string.IsNullOrEmpty(CustomerAsset) ? null : CustomerAssetName.Parse(CustomerAsset, allowUnparsed: true);
            set => CustomerAsset = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignAssetName"/>-typed view over the <see cref="CampaignAsset"/> resource name property.
        /// </summary>
        internal CampaignAssetName CampaignAssetAsCampaignAssetName
        {
            get => string.IsNullOrEmpty(CampaignAsset) ? null : CampaignAssetName.Parse(CampaignAsset, allowUnparsed: true);
            set => CampaignAsset = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AdGroupAssetName"/>-typed view over the <see cref="AdGroupAsset"/> resource name property.
        /// </summary>
        internal AdGroupAssetName AdGroupAssetAsAdGroupAssetName
        {
            get => string.IsNullOrEmpty(AdGroupAsset) ? null : AdGroupAssetName.Parse(AdGroupAsset, allowUnparsed: true);
            set => AdGroupAsset = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CombinedAudienceName"/>-typed view over the <see cref="CombinedAudience"/> resource name
        /// property.
        /// </summary>
        internal CombinedAudienceName CombinedAudienceAsCombinedAudienceName
        {
            get => string.IsNullOrEmpty(CombinedAudience) ? null : CombinedAudienceName.Parse(CombinedAudience, allowUnparsed: true);
            set => CombinedAudience = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AssetGroupName"/>-typed view over the <see cref="AssetGroup"/> resource name property.
        /// </summary>
        internal AssetGroupName AssetGroupAsAssetGroupName
        {
            get => string.IsNullOrEmpty(AssetGroup) ? null : AssetGroupName.Parse(AssetGroup, allowUnparsed: true);
            set => AssetGroup = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignBudgetName"/>-typed view over the <see cref="CampaignBudget"/> resource name property.
        /// </summary>
        internal CampaignBudgetName CampaignBudgetAsCampaignBudgetName
        {
            get => string.IsNullOrEmpty(CampaignBudget) ? null : CampaignBudgetName.Parse(CampaignBudget, allowUnparsed: true);
            set => CampaignBudget = value?.ToString() ?? "";
        }
    }
}

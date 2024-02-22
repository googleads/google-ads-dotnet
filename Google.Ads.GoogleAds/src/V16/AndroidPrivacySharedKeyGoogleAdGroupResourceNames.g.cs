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

namespace Google.Ads.GoogleAds.V16.Resources
{
    /// <summary>Resource name for the <c>AndroidPrivacySharedKeyGoogleAdGroup</c> resource.</summary>
    public sealed partial class AndroidPrivacySharedKeyGoogleAdGroupName : gax::IResourceName, sys::IEquatable<AndroidPrivacySharedKeyGoogleAdGroupName>
    {
        /// <summary>The possible contents of <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
            /// .
            /// </summary>
            CustomerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate = 1,
        }

        private static gax::PathTemplate s_customerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate = new gax::PathTemplate("customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id_ad_group_id_android_privacy_interaction_type_android_privacy_network_type_android_privacy_interaction_date}");

        /// <summary>
        /// Creates a <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AndroidPrivacySharedKeyGoogleAdGroupName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AndroidPrivacySharedKeyGoogleAdGroupName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> with the pattern
        /// <c>
        /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="androidPrivacyInteractionTypeId">
        /// The <c>AndroidPrivacyInteractionType</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="androidPrivacyNetworkTypeId">
        /// The <c>AndroidPrivacyNetworkType</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="androidPrivacyInteractionDateId">
        /// The <c>AndroidPrivacyInteractionDate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> constructed from the provided ids.
        /// </returns>
        public static AndroidPrivacySharedKeyGoogleAdGroupName FromCustomerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate(string customerId, string campaignId, string adGroupId, string androidPrivacyInteractionTypeId, string androidPrivacyNetworkTypeId, string androidPrivacyInteractionDateId) =>
            new AndroidPrivacySharedKeyGoogleAdGroupName(ResourceNameType.CustomerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), androidPrivacyInteractionTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(androidPrivacyInteractionTypeId, nameof(androidPrivacyInteractionTypeId)), androidPrivacyNetworkTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(androidPrivacyNetworkTypeId, nameof(androidPrivacyNetworkTypeId)), androidPrivacyInteractionDateId: gax::GaxPreconditions.CheckNotNullOrEmpty(androidPrivacyInteractionDateId, nameof(androidPrivacyInteractionDateId)));

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> with pattern
        /// <c>
        /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="androidPrivacyInteractionTypeId">
        /// The <c>AndroidPrivacyInteractionType</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="androidPrivacyNetworkTypeId">
        /// The <c>AndroidPrivacyNetworkType</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="androidPrivacyInteractionDateId">
        /// The <c>AndroidPrivacyInteractionDate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> with pattern
        /// <c>
        /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
        /// .
        /// </returns>
        public static string Format(string customerId, string campaignId, string adGroupId, string androidPrivacyInteractionTypeId, string androidPrivacyNetworkTypeId, string androidPrivacyInteractionDateId) =>
            FormatCustomerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate(customerId, campaignId, adGroupId, androidPrivacyInteractionTypeId, androidPrivacyNetworkTypeId, androidPrivacyInteractionDateId);

        /// <summary>
        /// Formats the IDs into the string representation of this
        /// <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> with pattern
        /// <c>
        /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="androidPrivacyInteractionTypeId">
        /// The <c>AndroidPrivacyInteractionType</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="androidPrivacyNetworkTypeId">
        /// The <c>AndroidPrivacyNetworkType</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="androidPrivacyInteractionDateId">
        /// The <c>AndroidPrivacyInteractionDate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> with pattern
        /// <c>
        /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
        /// .
        /// </returns>
        public static string FormatCustomerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate(string customerId, string campaignId, string adGroupId, string androidPrivacyInteractionTypeId, string androidPrivacyNetworkTypeId, string androidPrivacyInteractionDateId) =>
            s_customerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(androidPrivacyInteractionTypeId, nameof(androidPrivacyInteractionTypeId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(androidPrivacyNetworkTypeId, nameof(androidPrivacyNetworkTypeId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(androidPrivacyInteractionDateId, nameof(androidPrivacyInteractionDateId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="androidPrivacySharedKeyGoogleAdGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> if successful.</returns>
        public static AndroidPrivacySharedKeyGoogleAdGroupName Parse(string androidPrivacySharedKeyGoogleAdGroupName) =>
            Parse(androidPrivacySharedKeyGoogleAdGroupName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="androidPrivacySharedKeyGoogleAdGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> if successful.</returns>
        public static AndroidPrivacySharedKeyGoogleAdGroupName Parse(string androidPrivacySharedKeyGoogleAdGroupName, bool allowUnparsed) =>
            TryParse(androidPrivacySharedKeyGoogleAdGroupName, allowUnparsed, out AndroidPrivacySharedKeyGoogleAdGroupName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="androidPrivacySharedKeyGoogleAdGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/>, or <c>null</c>
        /// if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string androidPrivacySharedKeyGoogleAdGroupName, out AndroidPrivacySharedKeyGoogleAdGroupName result) =>
            TryParse(androidPrivacySharedKeyGoogleAdGroupName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new
        /// <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> instance; optionally allowing an unparseable resource
        /// name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="androidPrivacySharedKeyGoogleAdGroupName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/>, or <c>null</c>
        /// if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string androidPrivacySharedKeyGoogleAdGroupName, bool allowUnparsed, out AndroidPrivacySharedKeyGoogleAdGroupName result)
        {
            gax::GaxPreconditions.CheckNotNull(androidPrivacySharedKeyGoogleAdGroupName, nameof(androidPrivacySharedKeyGoogleAdGroupName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate.TryParseName(androidPrivacySharedKeyGoogleAdGroupName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate(resourceName[0], split1[0], split1[1], split1[2], split1[3], split1[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(androidPrivacySharedKeyGoogleAdGroupName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private static string[] ParseSplitHelper(string s, char[] separators)
        {
            string[] result = new string[separators.Length + 1];
            int i0 = 0;
            for (int i = 0; i <= separators.Length; i++)
            {
                int i1 = i < separators.Length ? s.IndexOf(separators[i], i0) : s.Length;
                if (i1 < 0 || i1 == i0)
                {
                    return null;
                }
                result[i] = s.Substring(i0, i1 - i0);
                i0 = i1 + 1;
            }
            return result;
        }

        private AndroidPrivacySharedKeyGoogleAdGroupName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupId = null, string androidPrivacyInteractionDateId = null, string androidPrivacyInteractionTypeId = null, string androidPrivacyNetworkTypeId = null, string campaignId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupId = adGroupId;
            AndroidPrivacyInteractionDateId = androidPrivacyInteractionDateId;
            AndroidPrivacyInteractionTypeId = androidPrivacyInteractionTypeId;
            AndroidPrivacyNetworkTypeId = androidPrivacyNetworkTypeId;
            CampaignId = campaignId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/> class from the
        /// component parts of pattern
        /// <c>
        /// customers/{customer_id}/androidPrivacySharedKeyGoogleAdGroups/{campaign_id}~{ad_group_id}~{android_privacy_interaction_type}~{android_privacy_network_type}~{android_privacy_interaction_date}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="androidPrivacyInteractionTypeId">
        /// The <c>AndroidPrivacyInteractionType</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="androidPrivacyNetworkTypeId">
        /// The <c>AndroidPrivacyNetworkType</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="androidPrivacyInteractionDateId">
        /// The <c>AndroidPrivacyInteractionDate</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AndroidPrivacySharedKeyGoogleAdGroupName(string customerId, string campaignId, string adGroupId, string androidPrivacyInteractionTypeId, string androidPrivacyNetworkTypeId, string androidPrivacyInteractionDateId) : this(ResourceNameType.CustomerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), androidPrivacyInteractionTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(androidPrivacyInteractionTypeId, nameof(androidPrivacyInteractionTypeId)), androidPrivacyNetworkTypeId: gax::GaxPreconditions.CheckNotNullOrEmpty(androidPrivacyNetworkTypeId, nameof(androidPrivacyNetworkTypeId)), androidPrivacyInteractionDateId: gax::GaxPreconditions.CheckNotNullOrEmpty(androidPrivacyInteractionDateId, nameof(androidPrivacyInteractionDateId)))
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
        /// The <c>AndroidPrivacyInteractionDate</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string AndroidPrivacyInteractionDateId { get; }

        /// <summary>
        /// The <c>AndroidPrivacyInteractionType</c> ID. Will not be <c>null</c>, unless this instance contains an
        /// unparsed resource name.
        /// </summary>
        public string AndroidPrivacyInteractionTypeId { get; }

        /// <summary>
        /// The <c>AndroidPrivacyNetworkType</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string AndroidPrivacyNetworkTypeId { get; }

        /// <summary>
        /// The <c>Campaign</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CampaignId { get; }

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
                case ResourceNameType.CustomerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate: return s_customerCampaignAdGroupAndroidPrivacyInteractionTypeAndroidPrivacyNetworkTypeAndroidPrivacyInteractionDate.Expand(CustomerId, $"{CampaignId}~{AdGroupId}~{AndroidPrivacyInteractionTypeId}~{AndroidPrivacyNetworkTypeId}~{AndroidPrivacyInteractionDateId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AndroidPrivacySharedKeyGoogleAdGroupName);

        /// <inheritdoc/>
        public bool Equals(AndroidPrivacySharedKeyGoogleAdGroupName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AndroidPrivacySharedKeyGoogleAdGroupName a, AndroidPrivacySharedKeyGoogleAdGroupName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AndroidPrivacySharedKeyGoogleAdGroupName a, AndroidPrivacySharedKeyGoogleAdGroupName b) => !(a == b);
    }

    public partial class AndroidPrivacySharedKeyGoogleAdGroup
    {
        /// <summary>
        /// <see cref="AndroidPrivacySharedKeyGoogleAdGroupName"/>-typed view over the <see cref="ResourceName"/>
        /// resource name property.
        /// </summary>
        internal AndroidPrivacySharedKeyGoogleAdGroupName ResourceNameAsAndroidPrivacySharedKeyGoogleAdGroupName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AndroidPrivacySharedKeyGoogleAdGroupName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

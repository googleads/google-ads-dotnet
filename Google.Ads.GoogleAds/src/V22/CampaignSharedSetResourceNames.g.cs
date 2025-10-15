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

namespace Google.Ads.GoogleAds.V22.Resources
{
    /// <summary>Resource name for the <c>CampaignSharedSet</c> resource.</summary>
    public sealed partial class CampaignSharedSetName : gax::IResourceName, sys::IEquatable<CampaignSharedSetName>
    {
        /// <summary>The possible contents of <see cref="CampaignSharedSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c>
            /// .
            /// </summary>
            CustomerCampaignSharedSet = 1,
        }

        private static gax::PathTemplate s_customerCampaignSharedSet = new gax::PathTemplate("customers/{customer_id}/campaignSharedSets/{campaign_id_shared_set_id}");

        /// <summary>Creates a <see cref="CampaignSharedSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CampaignSharedSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CampaignSharedSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CampaignSharedSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CampaignSharedSetName"/> with the pattern
        /// <c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedSetId">The <c>SharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CampaignSharedSetName"/> constructed from the provided ids.</returns>
        public static CampaignSharedSetName FromCustomerCampaignSharedSet(string customerId, string campaignId, string sharedSetId) =>
            new CampaignSharedSetName(ResourceNameType.CustomerCampaignSharedSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), sharedSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(sharedSetId, nameof(sharedSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignSharedSetName"/> with pattern
        /// <c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedSetId">The <c>SharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignSharedSetName"/> with pattern
        /// <c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string sharedSetId) =>
            FormatCustomerCampaignSharedSet(customerId, campaignId, sharedSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CampaignSharedSetName"/> with pattern
        /// <c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedSetId">The <c>SharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CampaignSharedSetName"/> with pattern
        /// <c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c>.
        /// </returns>
        public static string FormatCustomerCampaignSharedSet(string customerId, string campaignId, string sharedSetId) =>
            s_customerCampaignSharedSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(sharedSetId, nameof(sharedSetId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignSharedSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignSharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CampaignSharedSetName"/> if successful.</returns>
        public static CampaignSharedSetName Parse(string campaignSharedSetName) => Parse(campaignSharedSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CampaignSharedSetName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignSharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CampaignSharedSetName"/> if successful.</returns>
        public static CampaignSharedSetName Parse(string campaignSharedSetName, bool allowUnparsed) =>
            TryParse(campaignSharedSetName, allowUnparsed, out CampaignSharedSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignSharedSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="campaignSharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignSharedSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignSharedSetName, out CampaignSharedSetName result) =>
            TryParse(campaignSharedSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CampaignSharedSetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="campaignSharedSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CampaignSharedSetName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string campaignSharedSetName, bool allowUnparsed, out CampaignSharedSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(campaignSharedSetName, nameof(campaignSharedSetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignSharedSet.TryParseName(campaignSharedSetName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignSharedSet(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(campaignSharedSetName, out gax::UnparsedResourceName unparsedResourceName))
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

        private CampaignSharedSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string customerId = null, string sharedSetId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CustomerId = customerId;
            SharedSetId = sharedSetId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CampaignSharedSetName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/campaignSharedSets/{campaign_id}~{shared_set_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="sharedSetId">The <c>SharedSet</c> ID. Must not be <c>null</c> or empty.</param>
        public CampaignSharedSetName(string customerId, string campaignId, string sharedSetId) : this(ResourceNameType.CustomerCampaignSharedSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), sharedSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(sharedSetId, nameof(sharedSetId)))
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
        /// The <c>Campaign</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CampaignId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>SharedSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string SharedSetId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignSharedSet: return s_customerCampaignSharedSet.Expand(CustomerId, $"{CampaignId}~{SharedSetId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CampaignSharedSetName);

        /// <inheritdoc/>
        public bool Equals(CampaignSharedSetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CampaignSharedSetName a, CampaignSharedSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CampaignSharedSetName a, CampaignSharedSetName b) => !(a == b);
    }

    public partial class CampaignSharedSet
    {
        /// <summary>
        /// <see cref="CampaignSharedSetName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal CampaignSharedSetName ResourceNameAsCampaignSharedSetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : CampaignSharedSetName.Parse(ResourceName, allowUnparsed: true);
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
        /// <see cref="SharedSetName"/>-typed view over the <see cref="SharedSet"/> resource name property.
        /// </summary>
        internal SharedSetName SharedSetAsSharedSetName
        {
            get => string.IsNullOrEmpty(SharedSet) ? null : SharedSetName.Parse(SharedSet, allowUnparsed: true);
            set => SharedSet = value?.ToString() ?? "";
        }
    }
}

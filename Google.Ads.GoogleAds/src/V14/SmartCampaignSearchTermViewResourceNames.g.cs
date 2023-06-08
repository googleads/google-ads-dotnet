// Copyright 2023 Google LLC
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

namespace Google.Ads.GoogleAds.V14.Resources
{
    /// <summary>Resource name for the <c>SmartCampaignSearchTermView</c> resource.</summary>
    public sealed partial class SmartCampaignSearchTermViewName : gax::IResourceName, sys::IEquatable<SmartCampaignSearchTermViewName>
    {
        /// <summary>The possible contents of <see cref="SmartCampaignSearchTermViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>.
            /// </summary>
            CustomerCampaignQuery = 1,
        }

        private static gax::PathTemplate s_customerCampaignQuery = new gax::PathTemplate("customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id_query}");

        /// <summary>
        /// Creates a <see cref="SmartCampaignSearchTermViewName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="SmartCampaignSearchTermViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static SmartCampaignSearchTermViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new SmartCampaignSearchTermViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="SmartCampaignSearchTermViewName"/> with the pattern
        /// <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queryId">The <c>Query</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="SmartCampaignSearchTermViewName"/> constructed from the provided ids.
        /// </returns>
        public static SmartCampaignSearchTermViewName FromCustomerCampaignQuery(string customerId, string campaignId, string queryId) =>
            new SmartCampaignSearchTermViewName(ResourceNameType.CustomerCampaignQuery, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), queryId: gax::GaxPreconditions.CheckNotNullOrEmpty(queryId, nameof(queryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SmartCampaignSearchTermViewName"/> with
        /// pattern <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queryId">The <c>Query</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SmartCampaignSearchTermViewName"/> with pattern
        /// <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>.
        /// </returns>
        public static string Format(string customerId, string campaignId, string queryId) =>
            FormatCustomerCampaignQuery(customerId, campaignId, queryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="SmartCampaignSearchTermViewName"/> with
        /// pattern <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queryId">The <c>Query</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="SmartCampaignSearchTermViewName"/> with pattern
        /// <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>.
        /// </returns>
        public static string FormatCustomerCampaignQuery(string customerId, string campaignId, string queryId) =>
            s_customerCampaignQuery.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(queryId, nameof(queryId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SmartCampaignSearchTermViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="smartCampaignSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="SmartCampaignSearchTermViewName"/> if successful.</returns>
        public static SmartCampaignSearchTermViewName Parse(string smartCampaignSearchTermViewName) =>
            Parse(smartCampaignSearchTermViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="SmartCampaignSearchTermViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="smartCampaignSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="SmartCampaignSearchTermViewName"/> if successful.</returns>
        public static SmartCampaignSearchTermViewName Parse(string smartCampaignSearchTermViewName, bool allowUnparsed) =>
            TryParse(smartCampaignSearchTermViewName, allowUnparsed, out SmartCampaignSearchTermViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SmartCampaignSearchTermViewName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="smartCampaignSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SmartCampaignSearchTermViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string smartCampaignSearchTermViewName, out SmartCampaignSearchTermViewName result) =>
            TryParse(smartCampaignSearchTermViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="SmartCampaignSearchTermViewName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="smartCampaignSearchTermViewName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="SmartCampaignSearchTermViewName"/>, or <c>null</c> if
        /// parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string smartCampaignSearchTermViewName, bool allowUnparsed, out SmartCampaignSearchTermViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(smartCampaignSearchTermViewName, nameof(smartCampaignSearchTermViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerCampaignQuery.TryParseName(smartCampaignSearchTermViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerCampaignQuery(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(smartCampaignSearchTermViewName, out gax::UnparsedResourceName unparsedResourceName))
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

        private SmartCampaignSearchTermViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string campaignId = null, string customerId = null, string queryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CampaignId = campaignId;
            CustomerId = customerId;
            QueryId = queryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="SmartCampaignSearchTermViewName"/> class from the component parts
        /// of pattern <c>customers/{customer_id}/smartCampaignSearchTermViews/{campaign_id}~{query}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="campaignId">The <c>Campaign</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="queryId">The <c>Query</c> ID. Must not be <c>null</c> or empty.</param>
        public SmartCampaignSearchTermViewName(string customerId, string campaignId, string queryId) : this(ResourceNameType.CustomerCampaignQuery, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), campaignId: gax::GaxPreconditions.CheckNotNullOrEmpty(campaignId, nameof(campaignId)), queryId: gax::GaxPreconditions.CheckNotNullOrEmpty(queryId, nameof(queryId)))
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
        /// The <c>Query</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string QueryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerCampaignQuery: return s_customerCampaignQuery.Expand(CustomerId, $"{CampaignId}~{QueryId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as SmartCampaignSearchTermViewName);

        /// <inheritdoc/>
        public bool Equals(SmartCampaignSearchTermViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(SmartCampaignSearchTermViewName a, SmartCampaignSearchTermViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(SmartCampaignSearchTermViewName a, SmartCampaignSearchTermViewName b) => !(a == b);
    }

    public partial class SmartCampaignSearchTermView
    {
        /// <summary>
        /// <see cref="SmartCampaignSearchTermViewName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal SmartCampaignSearchTermViewName ResourceNameAsSmartCampaignSearchTermViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : SmartCampaignSearchTermViewName.Parse(ResourceName, allowUnparsed: true);
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
    }
}

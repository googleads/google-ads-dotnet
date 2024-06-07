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

namespace Google.Ads.GoogleAds.V17.Resources
{
    /// <summary>Resource name for the <c>ShoppingProduct</c> resource.</summary>
    public sealed partial class ShoppingProductName : gax::IResourceName, sys::IEquatable<ShoppingProductName>
    {
        /// <summary>The possible contents of <see cref="ShoppingProductName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>
            /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
            /// .
            /// </summary>
            CustomerMerchantCenterChannelLanguageCodeFeedLabelItem = 1,
        }

        private static gax::PathTemplate s_customerMerchantCenterChannelLanguageCodeFeedLabelItem = new gax::PathTemplate("customers/{customer_id}/shoppingProducts/{merchant_center_id_channel_language_code_feed_label_item_id}");

        /// <summary>Creates a <see cref="ShoppingProductName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ShoppingProductName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ShoppingProductName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ShoppingProductName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ShoppingProductName"/> with the pattern
        /// <c>
        /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="merchantCenterId">The <c>MerchantCenter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="languageCodeId">The <c>LanguageCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedLabelId">The <c>FeedLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ShoppingProductName"/> constructed from the provided ids.</returns>
        public static ShoppingProductName FromCustomerMerchantCenterChannelLanguageCodeFeedLabelItem(string customerId, string merchantCenterId, string channelId, string languageCodeId, string feedLabelId, string itemId) =>
            new ShoppingProductName(ResourceNameType.CustomerMerchantCenterChannelLanguageCodeFeedLabelItem, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), merchantCenterId: gax::GaxPreconditions.CheckNotNullOrEmpty(merchantCenterId, nameof(merchantCenterId)), channelId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)), languageCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(languageCodeId, nameof(languageCodeId)), feedLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedLabelId, nameof(feedLabelId)), itemId: gax::GaxPreconditions.CheckNotNullOrEmpty(itemId, nameof(itemId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ShoppingProductName"/> with pattern
        /// <c>
        /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="merchantCenterId">The <c>MerchantCenter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="languageCodeId">The <c>LanguageCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedLabelId">The <c>FeedLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ShoppingProductName"/> with pattern
        /// <c>
        /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
        /// .
        /// </returns>
        public static string Format(string customerId, string merchantCenterId, string channelId, string languageCodeId, string feedLabelId, string itemId) =>
            FormatCustomerMerchantCenterChannelLanguageCodeFeedLabelItem(customerId, merchantCenterId, channelId, languageCodeId, feedLabelId, itemId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ShoppingProductName"/> with pattern
        /// <c>
        /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
        /// .
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="merchantCenterId">The <c>MerchantCenter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="languageCodeId">The <c>LanguageCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedLabelId">The <c>FeedLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ShoppingProductName"/> with pattern
        /// <c>
        /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
        /// .
        /// </returns>
        public static string FormatCustomerMerchantCenterChannelLanguageCodeFeedLabelItem(string customerId, string merchantCenterId, string channelId, string languageCodeId, string feedLabelId, string itemId) =>
            s_customerMerchantCenterChannelLanguageCodeFeedLabelItem.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(merchantCenterId, nameof(merchantCenterId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(languageCodeId, nameof(languageCodeId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(feedLabelId, nameof(feedLabelId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(itemId, nameof(itemId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ShoppingProductName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="shoppingProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ShoppingProductName"/> if successful.</returns>
        public static ShoppingProductName Parse(string shoppingProductName) => Parse(shoppingProductName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ShoppingProductName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="shoppingProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ShoppingProductName"/> if successful.</returns>
        public static ShoppingProductName Parse(string shoppingProductName, bool allowUnparsed) =>
            TryParse(shoppingProductName, allowUnparsed, out ShoppingProductName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ShoppingProductName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="shoppingProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ShoppingProductName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string shoppingProductName, out ShoppingProductName result) =>
            TryParse(shoppingProductName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ShoppingProductName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>
        /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="shoppingProductName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ShoppingProductName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string shoppingProductName, bool allowUnparsed, out ShoppingProductName result)
        {
            gax::GaxPreconditions.CheckNotNull(shoppingProductName, nameof(shoppingProductName));
            gax::TemplatedResourceName resourceName;
            if (s_customerMerchantCenterChannelLanguageCodeFeedLabelItem.TryParseName(shoppingProductName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerMerchantCenterChannelLanguageCodeFeedLabelItem(resourceName[0], split1[0], split1[1], split1[2], split1[3], split1[4]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(shoppingProductName, out gax::UnparsedResourceName unparsedResourceName))
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

        private ShoppingProductName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string channelId = null, string customerId = null, string feedLabelId = null, string itemId = null, string languageCodeId = null, string merchantCenterId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ChannelId = channelId;
            CustomerId = customerId;
            FeedLabelId = feedLabelId;
            ItemId = itemId;
            LanguageCodeId = languageCodeId;
            MerchantCenterId = merchantCenterId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ShoppingProductName"/> class from the component parts of pattern
        /// <c>
        /// customers/{customer_id}/shoppingProducts/{merchant_center_id}~{channel}~{language_code}~{feed_label}~{item_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="merchantCenterId">The <c>MerchantCenter</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="channelId">The <c>Channel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="languageCodeId">The <c>LanguageCode</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="feedLabelId">The <c>FeedLabel</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="itemId">The <c>Item</c> ID. Must not be <c>null</c> or empty.</param>
        public ShoppingProductName(string customerId, string merchantCenterId, string channelId, string languageCodeId, string feedLabelId, string itemId) : this(ResourceNameType.CustomerMerchantCenterChannelLanguageCodeFeedLabelItem, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), merchantCenterId: gax::GaxPreconditions.CheckNotNullOrEmpty(merchantCenterId, nameof(merchantCenterId)), channelId: gax::GaxPreconditions.CheckNotNullOrEmpty(channelId, nameof(channelId)), languageCodeId: gax::GaxPreconditions.CheckNotNullOrEmpty(languageCodeId, nameof(languageCodeId)), feedLabelId: gax::GaxPreconditions.CheckNotNullOrEmpty(feedLabelId, nameof(feedLabelId)), itemId: gax::GaxPreconditions.CheckNotNullOrEmpty(itemId, nameof(itemId)))
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
        /// The <c>Channel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ChannelId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>FeedLabel</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string FeedLabelId { get; }

        /// <summary>
        /// The <c>Item</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string ItemId { get; }

        /// <summary>
        /// The <c>LanguageCode</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string LanguageCodeId { get; }

        /// <summary>
        /// The <c>MerchantCenter</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MerchantCenterId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerMerchantCenterChannelLanguageCodeFeedLabelItem: return s_customerMerchantCenterChannelLanguageCodeFeedLabelItem.Expand(CustomerId, $"{MerchantCenterId}~{ChannelId}~{LanguageCodeId}~{FeedLabelId}~{ItemId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ShoppingProductName);

        /// <inheritdoc/>
        public bool Equals(ShoppingProductName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ShoppingProductName a, ShoppingProductName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ShoppingProductName a, ShoppingProductName b) => !(a == b);
    }

    public partial class ShoppingProduct
    {
        /// <summary>
        /// <see cref="ShoppingProductName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal ShoppingProductName ResourceNameAsShoppingProductName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ShoppingProductName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductCategoryConstantName"/>-typed view over the <see cref="CategoryLevel1"/> resource name
        /// property.
        /// </summary>
        internal ProductCategoryConstantName CategoryLevel1AsProductCategoryConstantName
        {
            get => string.IsNullOrEmpty(CategoryLevel1) ? null : ProductCategoryConstantName.Parse(CategoryLevel1, allowUnparsed: true);
            set => CategoryLevel1 = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductCategoryConstantName"/>-typed view over the <see cref="CategoryLevel2"/> resource name
        /// property.
        /// </summary>
        internal ProductCategoryConstantName CategoryLevel2AsProductCategoryConstantName
        {
            get => string.IsNullOrEmpty(CategoryLevel2) ? null : ProductCategoryConstantName.Parse(CategoryLevel2, allowUnparsed: true);
            set => CategoryLevel2 = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductCategoryConstantName"/>-typed view over the <see cref="CategoryLevel3"/> resource name
        /// property.
        /// </summary>
        internal ProductCategoryConstantName CategoryLevel3AsProductCategoryConstantName
        {
            get => string.IsNullOrEmpty(CategoryLevel3) ? null : ProductCategoryConstantName.Parse(CategoryLevel3, allowUnparsed: true);
            set => CategoryLevel3 = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductCategoryConstantName"/>-typed view over the <see cref="CategoryLevel4"/> resource name
        /// property.
        /// </summary>
        internal ProductCategoryConstantName CategoryLevel4AsProductCategoryConstantName
        {
            get => string.IsNullOrEmpty(CategoryLevel4) ? null : ProductCategoryConstantName.Parse(CategoryLevel4, allowUnparsed: true);
            set => CategoryLevel4 = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ProductCategoryConstantName"/>-typed view over the <see cref="CategoryLevel5"/> resource name
        /// property.
        /// </summary>
        internal ProductCategoryConstantName CategoryLevel5AsProductCategoryConstantName
        {
            get => string.IsNullOrEmpty(CategoryLevel5) ? null : ProductCategoryConstantName.Parse(CategoryLevel5, allowUnparsed: true);
            set => CategoryLevel5 = value?.ToString() ?? "";
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
    }
}

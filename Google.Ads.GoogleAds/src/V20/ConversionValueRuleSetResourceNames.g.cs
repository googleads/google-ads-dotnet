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

namespace Google.Ads.GoogleAds.V20.Resources
{
    /// <summary>Resource name for the <c>ConversionValueRuleSet</c> resource.</summary>
    public sealed partial class ConversionValueRuleSetName : gax::IResourceName, sys::IEquatable<ConversionValueRuleSetName>
    {
        /// <summary>The possible contents of <see cref="ConversionValueRuleSetName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>.
            /// </summary>
            CustomerConversionValueRuleSet = 1,
        }

        private static gax::PathTemplate s_customerConversionValueRuleSet = new gax::PathTemplate("customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}");

        /// <summary>Creates a <see cref="ConversionValueRuleSetName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ConversionValueRuleSetName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ConversionValueRuleSetName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ConversionValueRuleSetName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ConversionValueRuleSetName"/> with the pattern
        /// <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionValueRuleSetId">
        /// The <c>ConversionValueRuleSet</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// A new instance of <see cref="ConversionValueRuleSetName"/> constructed from the provided ids.
        /// </returns>
        public static ConversionValueRuleSetName FromCustomerConversionValueRuleSet(string customerId, string conversionValueRuleSetId) =>
            new ConversionValueRuleSetName(ResourceNameType.CustomerConversionValueRuleSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), conversionValueRuleSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionValueRuleSetId, nameof(conversionValueRuleSetId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionValueRuleSetName"/> with pattern
        /// <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionValueRuleSetId">
        /// The <c>ConversionValueRuleSet</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversionValueRuleSetName"/> with pattern
        /// <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>.
        /// </returns>
        public static string Format(string customerId, string conversionValueRuleSetId) =>
            FormatCustomerConversionValueRuleSet(customerId, conversionValueRuleSetId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ConversionValueRuleSetName"/> with pattern
        /// <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionValueRuleSetId">
        /// The <c>ConversionValueRuleSet</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="ConversionValueRuleSetName"/> with pattern
        /// <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>.
        /// </returns>
        public static string FormatCustomerConversionValueRuleSet(string customerId, string conversionValueRuleSetId) =>
            s_customerConversionValueRuleSet.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(conversionValueRuleSetId, nameof(conversionValueRuleSetId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionValueRuleSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversionValueRuleSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ConversionValueRuleSetName"/> if successful.</returns>
        public static ConversionValueRuleSetName Parse(string conversionValueRuleSetName) =>
            Parse(conversionValueRuleSetName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ConversionValueRuleSetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionValueRuleSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ConversionValueRuleSetName"/> if successful.</returns>
        public static ConversionValueRuleSetName Parse(string conversionValueRuleSetName, bool allowUnparsed) =>
            TryParse(conversionValueRuleSetName, allowUnparsed, out ConversionValueRuleSetName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionValueRuleSetName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="conversionValueRuleSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionValueRuleSetName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionValueRuleSetName, out ConversionValueRuleSetName result) =>
            TryParse(conversionValueRuleSetName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ConversionValueRuleSetName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="conversionValueRuleSetName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ConversionValueRuleSetName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string conversionValueRuleSetName, bool allowUnparsed, out ConversionValueRuleSetName result)
        {
            gax::GaxPreconditions.CheckNotNull(conversionValueRuleSetName, nameof(conversionValueRuleSetName));
            gax::TemplatedResourceName resourceName;
            if (s_customerConversionValueRuleSet.TryParseName(conversionValueRuleSetName, out resourceName))
            {
                result = FromCustomerConversionValueRuleSet(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(conversionValueRuleSetName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private ConversionValueRuleSetName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string conversionValueRuleSetId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            ConversionValueRuleSetId = conversionValueRuleSetId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ConversionValueRuleSetName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/conversionValueRuleSets/{conversion_value_rule_set_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="conversionValueRuleSetId">
        /// The <c>ConversionValueRuleSet</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public ConversionValueRuleSetName(string customerId, string conversionValueRuleSetId) : this(ResourceNameType.CustomerConversionValueRuleSet, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), conversionValueRuleSetId: gax::GaxPreconditions.CheckNotNullOrEmpty(conversionValueRuleSetId, nameof(conversionValueRuleSetId)))
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
        /// The <c>ConversionValueRuleSet</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string ConversionValueRuleSetId { get; }

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
                case ResourceNameType.CustomerConversionValueRuleSet: return s_customerConversionValueRuleSet.Expand(CustomerId, ConversionValueRuleSetId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ConversionValueRuleSetName);

        /// <inheritdoc/>
        public bool Equals(ConversionValueRuleSetName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ConversionValueRuleSetName a, ConversionValueRuleSetName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ConversionValueRuleSetName a, ConversionValueRuleSetName b) => !(a == b);
    }

    public partial class ConversionValueRuleSet
    {
        /// <summary>
        /// <see cref="ConversionValueRuleSetName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal ConversionValueRuleSetName ResourceNameAsConversionValueRuleSetName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ConversionValueRuleSetName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ConversionValueRuleName"/>-typed view over the <see cref="ConversionValueRules"/> resource name
        /// property.
        /// </summary>
        internal gax::ResourceNameList<ConversionValueRuleName> ConversionValueRulesAsConversionValueRuleNames
        {
            get => new gax::ResourceNameList<ConversionValueRuleName>(ConversionValueRules, s => string.IsNullOrEmpty(s) ? null : ConversionValueRuleName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="CustomerName"/>-typed view over the <see cref="OwnerCustomer"/> resource name property.
        /// </summary>
        internal CustomerName OwnerCustomerAsCustomerName
        {
            get => string.IsNullOrEmpty(OwnerCustomer) ? null : CustomerName.Parse(OwnerCustomer, allowUnparsed: true);
            set => OwnerCustomer = value?.ToString() ?? "";
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

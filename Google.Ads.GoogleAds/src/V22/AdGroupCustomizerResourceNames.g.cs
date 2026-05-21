// Copyright 2026 Google LLC
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
    /// <summary>Resource name for the <c>AdGroupCustomizer</c> resource.</summary>
    public sealed partial class AdGroupCustomizerName : gax::IResourceName, sys::IEquatable<AdGroupCustomizerName>
    {
        /// <summary>The possible contents of <see cref="AdGroupCustomizerName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>.
            /// </summary>
            CustomerAdGroupCustomizerAttribute = 1,
        }

        private static gax::PathTemplate s_customerAdGroupCustomizerAttribute = new gax::PathTemplate("customers/{customer_id}/adGroupCustomizers/{ad_group_id_customizer_attribute_id}");

        /// <summary>Creates a <see cref="AdGroupCustomizerName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AdGroupCustomizerName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AdGroupCustomizerName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AdGroupCustomizerName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AdGroupCustomizerName"/> with the pattern
        /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customizerAttributeId">
        /// The <c>CustomizerAttribute</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="AdGroupCustomizerName"/> constructed from the provided ids.</returns>
        public static AdGroupCustomizerName FromCustomerAdGroupCustomizerAttribute(string customerId, string adGroupId, string customizerAttributeId) =>
            new AdGroupCustomizerName(ResourceNameType.CustomerAdGroupCustomizerAttribute, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), customizerAttributeId: gax::GaxPreconditions.CheckNotNullOrEmpty(customizerAttributeId, nameof(customizerAttributeId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupCustomizerName"/> with pattern
        /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customizerAttributeId">
        /// The <c>CustomizerAttribute</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupCustomizerName"/> with pattern
        /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupId, string customizerAttributeId) =>
            FormatCustomerAdGroupCustomizerAttribute(customerId, adGroupId, customizerAttributeId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AdGroupCustomizerName"/> with pattern
        /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customizerAttributeId">
        /// The <c>CustomizerAttribute</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="AdGroupCustomizerName"/> with pattern
        /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupCustomizerAttribute(string customerId, string adGroupId, string customizerAttributeId) =>
            s_customerAdGroupCustomizerAttribute.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(customizerAttributeId, nameof(customizerAttributeId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupCustomizerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupCustomizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AdGroupCustomizerName"/> if successful.</returns>
        public static AdGroupCustomizerName Parse(string adGroupCustomizerName) => Parse(adGroupCustomizerName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AdGroupCustomizerName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupCustomizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AdGroupCustomizerName"/> if successful.</returns>
        public static AdGroupCustomizerName Parse(string adGroupCustomizerName, bool allowUnparsed) =>
            TryParse(adGroupCustomizerName, allowUnparsed, out AdGroupCustomizerName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupCustomizerName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="adGroupCustomizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupCustomizerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupCustomizerName, out AdGroupCustomizerName result) =>
            TryParse(adGroupCustomizerName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AdGroupCustomizerName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="adGroupCustomizerName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AdGroupCustomizerName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string adGroupCustomizerName, bool allowUnparsed, out AdGroupCustomizerName result)
        {
            gax::GaxPreconditions.CheckNotNull(adGroupCustomizerName, nameof(adGroupCustomizerName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupCustomizerAttribute.TryParseName(adGroupCustomizerName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAdGroupCustomizerAttribute(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(adGroupCustomizerName, out gax::UnparsedResourceName unparsedResourceName))
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

        private AdGroupCustomizerName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupId = null, string customerId = null, string customizerAttributeId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupId = adGroupId;
            CustomerId = customerId;
            CustomizerAttributeId = customizerAttributeId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AdGroupCustomizerName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/adGroupCustomizers/{ad_group_id}~{customizer_attribute_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="customizerAttributeId">
        /// The <c>CustomizerAttribute</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public AdGroupCustomizerName(string customerId, string adGroupId, string customizerAttributeId) : this(ResourceNameType.CustomerAdGroupCustomizerAttribute, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), customizerAttributeId: gax::GaxPreconditions.CheckNotNullOrEmpty(customizerAttributeId, nameof(customizerAttributeId)))
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

        /// <summary>
        /// The <c>CustomizerAttribute</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string CustomizerAttributeId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerAdGroupCustomizerAttribute: return s_customerAdGroupCustomizerAttribute.Expand(CustomerId, $"{AdGroupId}~{CustomizerAttributeId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AdGroupCustomizerName);

        /// <inheritdoc/>
        public bool Equals(AdGroupCustomizerName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AdGroupCustomizerName a, AdGroupCustomizerName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AdGroupCustomizerName a, AdGroupCustomizerName b) => !(a == b);
    }

    public partial class AdGroupCustomizer
    {
        /// <summary>
        /// <see cref="AdGroupCustomizerName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AdGroupCustomizerName ResourceNameAsAdGroupCustomizerName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AdGroupCustomizerName.Parse(ResourceName, allowUnparsed: true);
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

        /// <summary>
        /// <see cref="CustomizerAttributeName"/>-typed view over the <see cref="CustomizerAttribute"/> resource name
        /// property.
        /// </summary>
        internal CustomizerAttributeName CustomizerAttributeAsCustomizerAttributeName
        {
            get => string.IsNullOrEmpty(CustomizerAttribute) ? null : CustomizerAttributeName.Parse(CustomizerAttribute, allowUnparsed: true);
            set => CustomizerAttribute = value?.ToString() ?? "";
        }
    }
}

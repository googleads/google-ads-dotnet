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

namespace Google.Ads.GoogleAds.V6.Resources
{
    /// <summary>Resource name for the <c>DisplayKeywordView</c> resource.</summary>
    public sealed partial class DisplayKeywordViewName : gax::IResourceName, sys::IEquatable<DisplayKeywordViewName>
    {
        /// <summary>The possible contents of <see cref="DisplayKeywordViewName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c>
            /// .
            /// </summary>
            CustomerAdGroupCriterion = 1,
        }

        private static gax::PathTemplate s_customerAdGroupCriterion = new gax::PathTemplate("customers/{customer_id}/displayKeywordViews/{ad_group_id_criterion_id}");

        /// <summary>Creates a <see cref="DisplayKeywordViewName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="DisplayKeywordViewName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static DisplayKeywordViewName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new DisplayKeywordViewName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="DisplayKeywordViewName"/> with the pattern
        /// <c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="DisplayKeywordViewName"/> constructed from the provided ids.</returns>
        public static DisplayKeywordViewName FromCustomerAdGroupCriterion(string customerId, string adGroupId, string criterionId) =>
            new DisplayKeywordViewName(ResourceNameType.CustomerAdGroupCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DisplayKeywordViewName"/> with pattern
        /// <c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DisplayKeywordViewName"/> with pattern
        /// <c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c>.
        /// </returns>
        public static string Format(string customerId, string adGroupId, string criterionId) =>
            FormatCustomerAdGroupCriterion(customerId, adGroupId, criterionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="DisplayKeywordViewName"/> with pattern
        /// <c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="DisplayKeywordViewName"/> with pattern
        /// <c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c>.
        /// </returns>
        public static string FormatCustomerAdGroupCriterion(string customerId, string adGroupId, string criterionId) =>
            s_customerAdGroupCriterion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DisplayKeywordViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="displayKeywordViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="DisplayKeywordViewName"/> if successful.</returns>
        public static DisplayKeywordViewName Parse(string displayKeywordViewName) => Parse(displayKeywordViewName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="DisplayKeywordViewName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="displayKeywordViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="DisplayKeywordViewName"/> if successful.</returns>
        public static DisplayKeywordViewName Parse(string displayKeywordViewName, bool allowUnparsed) =>
            TryParse(displayKeywordViewName, allowUnparsed, out DisplayKeywordViewName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DisplayKeywordViewName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="displayKeywordViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DisplayKeywordViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string displayKeywordViewName, out DisplayKeywordViewName result) =>
            TryParse(displayKeywordViewName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="DisplayKeywordViewName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="displayKeywordViewName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="DisplayKeywordViewName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string displayKeywordViewName, bool allowUnparsed, out DisplayKeywordViewName result)
        {
            gax::GaxPreconditions.CheckNotNull(displayKeywordViewName, nameof(displayKeywordViewName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAdGroupCriterion.TryParseName(displayKeywordViewName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAdGroupCriterion(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(displayKeywordViewName, out gax::UnparsedResourceName unparsedResourceName))
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

        private DisplayKeywordViewName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string adGroupId = null, string criterionId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AdGroupId = adGroupId;
            CriterionId = criterionId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="DisplayKeywordViewName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/displayKeywordViews/{ad_group_id}~{criterion_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="adGroupId">The <c>AdGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        public DisplayKeywordViewName(string customerId, string adGroupId, string criterionId) : this(ResourceNameType.CustomerAdGroupCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), adGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupId, nameof(adGroupId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))
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
        /// The <c>Criterion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CriterionId { get; }

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
                case ResourceNameType.CustomerAdGroupCriterion: return s_customerAdGroupCriterion.Expand(CustomerId, $"{AdGroupId}~{CriterionId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as DisplayKeywordViewName);

        /// <inheritdoc/>
        public bool Equals(DisplayKeywordViewName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(DisplayKeywordViewName a, DisplayKeywordViewName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(DisplayKeywordViewName a, DisplayKeywordViewName b) => !(a == b);
    }

    public partial class DisplayKeywordView
    {
        /// <summary>
        /// <see cref="DisplayKeywordViewName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal DisplayKeywordViewName ResourceNameAsDisplayKeywordViewName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : DisplayKeywordViewName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

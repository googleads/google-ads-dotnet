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
    /// <summary>Resource name for the <c>AssetGroupSignal</c> resource.</summary>
    public sealed partial class AssetGroupSignalName : gax::IResourceName, sys::IEquatable<AssetGroupSignalName>
    {
        /// <summary>The possible contents of <see cref="AssetGroupSignalName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c>.
            /// </summary>
            CustomerAssetGroupCriterion = 1,
        }

        private static gax::PathTemplate s_customerAssetGroupCriterion = new gax::PathTemplate("customers/{customer_id}/assetGroupSignals/{asset_group_id_criterion_id}");

        /// <summary>Creates a <see cref="AssetGroupSignalName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="AssetGroupSignalName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static AssetGroupSignalName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new AssetGroupSignalName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="AssetGroupSignalName"/> with the pattern
        /// <c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="AssetGroupSignalName"/> constructed from the provided ids.</returns>
        public static AssetGroupSignalName FromCustomerAssetGroupCriterion(string customerId, string assetGroupId, string criterionId) =>
            new AssetGroupSignalName(ResourceNameType.CustomerAssetGroupCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetGroupId, nameof(assetGroupId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetGroupSignalName"/> with pattern
        /// <c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetGroupSignalName"/> with pattern
        /// <c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c>.
        /// </returns>
        public static string Format(string customerId, string assetGroupId, string criterionId) =>
            FormatCustomerAssetGroupCriterion(customerId, assetGroupId, criterionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="AssetGroupSignalName"/> with pattern
        /// <c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="AssetGroupSignalName"/> with pattern
        /// <c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c>.
        /// </returns>
        public static string FormatCustomerAssetGroupCriterion(string customerId, string assetGroupId, string criterionId) =>
            s_customerAssetGroupCriterion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(assetGroupId, nameof(assetGroupId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetGroupSignalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assetGroupSignalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="AssetGroupSignalName"/> if successful.</returns>
        public static AssetGroupSignalName Parse(string assetGroupSignalName) => Parse(assetGroupSignalName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="AssetGroupSignalName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetGroupSignalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="AssetGroupSignalName"/> if successful.</returns>
        public static AssetGroupSignalName Parse(string assetGroupSignalName, bool allowUnparsed) =>
            TryParse(assetGroupSignalName, allowUnparsed, out AssetGroupSignalName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetGroupSignalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="assetGroupSignalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetGroupSignalName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetGroupSignalName, out AssetGroupSignalName result) =>
            TryParse(assetGroupSignalName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="AssetGroupSignalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="assetGroupSignalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="AssetGroupSignalName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string assetGroupSignalName, bool allowUnparsed, out AssetGroupSignalName result)
        {
            gax::GaxPreconditions.CheckNotNull(assetGroupSignalName, nameof(assetGroupSignalName));
            gax::TemplatedResourceName resourceName;
            if (s_customerAssetGroupCriterion.TryParseName(assetGroupSignalName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerAssetGroupCriterion(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(assetGroupSignalName, out gax::UnparsedResourceName unparsedResourceName))
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

        private AssetGroupSignalName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string assetGroupId = null, string criterionId = null, string customerId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            AssetGroupId = assetGroupId;
            CriterionId = criterionId;
            CustomerId = customerId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="AssetGroupSignalName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/assetGroupSignals/{asset_group_id}~{criterion_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="assetGroupId">The <c>AssetGroup</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        public AssetGroupSignalName(string customerId, string assetGroupId, string criterionId) : this(ResourceNameType.CustomerAssetGroupCriterion, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), assetGroupId: gax::GaxPreconditions.CheckNotNullOrEmpty(assetGroupId, nameof(assetGroupId)), criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))
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
        /// The <c>AssetGroup</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string AssetGroupId { get; }

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
                case ResourceNameType.CustomerAssetGroupCriterion: return s_customerAssetGroupCriterion.Expand(CustomerId, $"{AssetGroupId}~{CriterionId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as AssetGroupSignalName);

        /// <inheritdoc/>
        public bool Equals(AssetGroupSignalName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(AssetGroupSignalName a, AssetGroupSignalName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(AssetGroupSignalName a, AssetGroupSignalName b) => !(a == b);
    }

    public partial class AssetGroupSignal
    {
        /// <summary>
        /// <see cref="AssetGroupSignalName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal AssetGroupSignalName ResourceNameAsAssetGroupSignalName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : AssetGroupSignalName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="AssetGroupName"/>-typed view over the <see cref="AssetGroup"/> resource name property.
        /// </summary>
        internal AssetGroupName AssetGroupAsAssetGroupName
        {
            get => string.IsNullOrEmpty(AssetGroup) ? null : AssetGroupName.Parse(AssetGroup, allowUnparsed: true);
            set => AssetGroup = value?.ToString() ?? "";
        }
    }
}

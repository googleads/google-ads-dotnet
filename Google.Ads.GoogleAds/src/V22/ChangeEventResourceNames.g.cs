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
    /// <summary>Resource name for the <c>ChangeEvent</c> resource.</summary>
    public sealed partial class ChangeEventName : gax::IResourceName, sys::IEquatable<ChangeEventName>
    {
        /// <summary>The possible contents of <see cref="ChangeEventName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern
            /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>.
            /// </summary>
            CustomerTimestampMicrosCommandIndexMutateIndex = 1,
        }

        private static gax::PathTemplate s_customerTimestampMicrosCommandIndexMutateIndex = new gax::PathTemplate("customers/{customer_id}/changeEvents/{timestamp_micros_command_index_mutate_index}");

        /// <summary>Creates a <see cref="ChangeEventName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ChangeEventName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ChangeEventName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ChangeEventName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ChangeEventName"/> with the pattern
        /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timestampMicrosId">The <c>TimestampMicros</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commandIndexId">The <c>CommandIndex</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mutateIndexId">The <c>MutateIndex</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ChangeEventName"/> constructed from the provided ids.</returns>
        public static ChangeEventName FromCustomerTimestampMicrosCommandIndexMutateIndex(string customerId, string timestampMicrosId, string commandIndexId, string mutateIndexId) =>
            new ChangeEventName(ResourceNameType.CustomerTimestampMicrosCommandIndexMutateIndex, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), timestampMicrosId: gax::GaxPreconditions.CheckNotNullOrEmpty(timestampMicrosId, nameof(timestampMicrosId)), commandIndexId: gax::GaxPreconditions.CheckNotNullOrEmpty(commandIndexId, nameof(commandIndexId)), mutateIndexId: gax::GaxPreconditions.CheckNotNullOrEmpty(mutateIndexId, nameof(mutateIndexId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChangeEventName"/> with pattern
        /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timestampMicrosId">The <c>TimestampMicros</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commandIndexId">The <c>CommandIndex</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mutateIndexId">The <c>MutateIndex</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChangeEventName"/> with pattern
        /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>.
        /// </returns>
        public static string Format(string customerId, string timestampMicrosId, string commandIndexId, string mutateIndexId) =>
            FormatCustomerTimestampMicrosCommandIndexMutateIndex(customerId, timestampMicrosId, commandIndexId, mutateIndexId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ChangeEventName"/> with pattern
        /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timestampMicrosId">The <c>TimestampMicros</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commandIndexId">The <c>CommandIndex</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mutateIndexId">The <c>MutateIndex</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ChangeEventName"/> with pattern
        /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>.
        /// </returns>
        public static string FormatCustomerTimestampMicrosCommandIndexMutateIndex(string customerId, string timestampMicrosId, string commandIndexId, string mutateIndexId) =>
            s_customerTimestampMicrosCommandIndexMutateIndex.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(timestampMicrosId, nameof(timestampMicrosId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(commandIndexId, nameof(commandIndexId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(mutateIndexId, nameof(mutateIndexId)))}");

        /// <summary>Parses the given resource name string into a new <see cref="ChangeEventName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="changeEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ChangeEventName"/> if successful.</returns>
        public static ChangeEventName Parse(string changeEventName) => Parse(changeEventName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ChangeEventName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="changeEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ChangeEventName"/> if successful.</returns>
        public static ChangeEventName Parse(string changeEventName, bool allowUnparsed) =>
            TryParse(changeEventName, allowUnparsed, out ChangeEventName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChangeEventName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="changeEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChangeEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changeEventName, out ChangeEventName result) =>
            TryParse(changeEventName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ChangeEventName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description>
        /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>
        /// </description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="changeEventName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ChangeEventName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string changeEventName, bool allowUnparsed, out ChangeEventName result)
        {
            gax::GaxPreconditions.CheckNotNull(changeEventName, nameof(changeEventName));
            gax::TemplatedResourceName resourceName;
            if (s_customerTimestampMicrosCommandIndexMutateIndex.TryParseName(changeEventName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerTimestampMicrosCommandIndexMutateIndex(resourceName[0], split1[0], split1[1], split1[2]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(changeEventName, out gax::UnparsedResourceName unparsedResourceName))
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

        private ChangeEventName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string commandIndexId = null, string customerId = null, string mutateIndexId = null, string timestampMicrosId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CommandIndexId = commandIndexId;
            CustomerId = customerId;
            MutateIndexId = mutateIndexId;
            TimestampMicrosId = timestampMicrosId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ChangeEventName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/changeEvents/{timestamp_micros}~{command_index}~{mutate_index}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="timestampMicrosId">The <c>TimestampMicros</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="commandIndexId">The <c>CommandIndex</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mutateIndexId">The <c>MutateIndex</c> ID. Must not be <c>null</c> or empty.</param>
        public ChangeEventName(string customerId, string timestampMicrosId, string commandIndexId, string mutateIndexId) : this(ResourceNameType.CustomerTimestampMicrosCommandIndexMutateIndex, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), timestampMicrosId: gax::GaxPreconditions.CheckNotNullOrEmpty(timestampMicrosId, nameof(timestampMicrosId)), commandIndexId: gax::GaxPreconditions.CheckNotNullOrEmpty(commandIndexId, nameof(commandIndexId)), mutateIndexId: gax::GaxPreconditions.CheckNotNullOrEmpty(mutateIndexId, nameof(mutateIndexId)))
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
        /// The <c>CommandIndex</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CommandIndexId { get; }

        /// <summary>
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>MutateIndex</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MutateIndexId { get; }

        /// <summary>
        /// The <c>TimestampMicros</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string TimestampMicrosId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerTimestampMicrosCommandIndexMutateIndex: return s_customerTimestampMicrosCommandIndexMutateIndex.Expand(CustomerId, $"{TimestampMicrosId}~{CommandIndexId}~{MutateIndexId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ChangeEventName);

        /// <inheritdoc/>
        public bool Equals(ChangeEventName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(ChangeEventName a, ChangeEventName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(ChangeEventName a, ChangeEventName b) => !(a == b);
    }

    public partial class ChangeEvent
    {
        /// <summary>
        /// <see cref="ChangeEventName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal ChangeEventName ResourceNameAsChangeEventName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : ChangeEventName.Parse(ResourceName, allowUnparsed: true);
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

        /// <summary><see cref="AssetName"/>-typed view over the <see cref="Asset"/> resource name property.</summary>
        internal AssetName AssetAsAssetName
        {
            get => string.IsNullOrEmpty(Asset) ? null : AssetName.Parse(Asset, allowUnparsed: true);
            set => Asset = value?.ToString() ?? "";
        }
    }
}

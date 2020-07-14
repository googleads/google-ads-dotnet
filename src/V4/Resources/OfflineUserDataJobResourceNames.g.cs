// Copyright 2020 Google LLC
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

namespace Google.Ads.GoogleAds.V4.Resources
{
    /// <summary>Resource name for the <c>OfflineUserDataJob</c> resource.</summary>
    public sealed partial class OfflineUserDataJobName : gax::IResourceName, sys::IEquatable<OfflineUserDataJobName>
    {
        /// <summary>The possible contents of <see cref="OfflineUserDataJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c>.
            /// </summary>
            CustomerOfflineUserDataJob = 1
        }

        private static gax::PathTemplate s_customerOfflineUserDataJob = new gax::PathTemplate("customers/{customer}/offlineUserDataJobs/{offline_user_data_job}");

        /// <summary>Creates a <see cref="OfflineUserDataJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="OfflineUserDataJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static OfflineUserDataJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new OfflineUserDataJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="OfflineUserDataJobName"/> with the pattern
        /// <c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offlineUserDataJobId">
        /// The <c>OfflineUserDataJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>A new instance of <see cref="OfflineUserDataJobName"/> constructed from the provided ids.</returns>
        public static OfflineUserDataJobName FromCustomerOfflineUserDataJob(string customerId, string offlineUserDataJobId) =>
            new OfflineUserDataJobName(ResourceNameType.CustomerOfflineUserDataJob, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), offlineUserDataJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(offlineUserDataJobId, nameof(offlineUserDataJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OfflineUserDataJobName"/> with pattern
        /// <c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offlineUserDataJobId">
        /// The <c>OfflineUserDataJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OfflineUserDataJobName"/> with pattern
        /// <c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c>.
        /// </returns>
        public static string Format(string customerId, string offlineUserDataJobId) =>
            FormatCustomerOfflineUserDataJob(customerId, offlineUserDataJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="OfflineUserDataJobName"/> with pattern
        /// <c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offlineUserDataJobId">
        /// The <c>OfflineUserDataJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        /// <returns>
        /// The string representation of this <see cref="OfflineUserDataJobName"/> with pattern
        /// <c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c>.
        /// </returns>
        public static string FormatCustomerOfflineUserDataJob(string customerId, string offlineUserDataJobId) =>
            s_customerOfflineUserDataJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(offlineUserDataJobId, nameof(offlineUserDataJobId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OfflineUserDataJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="offlineUserDataJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="OfflineUserDataJobName"/> if successful.</returns>
        public static OfflineUserDataJobName Parse(string offlineUserDataJobName) => Parse(offlineUserDataJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="OfflineUserDataJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="offlineUserDataJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="OfflineUserDataJobName"/> if successful.</returns>
        public static OfflineUserDataJobName Parse(string offlineUserDataJobName, bool allowUnparsed) =>
            TryParse(offlineUserDataJobName, allowUnparsed, out OfflineUserDataJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OfflineUserDataJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="offlineUserDataJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OfflineUserDataJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string offlineUserDataJobName, out OfflineUserDataJobName result) =>
            TryParse(offlineUserDataJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="OfflineUserDataJobName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="offlineUserDataJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="OfflineUserDataJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string offlineUserDataJobName, bool allowUnparsed, out OfflineUserDataJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(offlineUserDataJobName, nameof(offlineUserDataJobName));
            gax::TemplatedResourceName resourceName;
            if (s_customerOfflineUserDataJob.TryParseName(offlineUserDataJobName, out resourceName))
            {
                result = FromCustomerOfflineUserDataJob(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(offlineUserDataJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private OfflineUserDataJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string offlineUserDataJobId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            OfflineUserDataJobId = offlineUserDataJobId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="OfflineUserDataJobName"/> class from the component parts of
        /// pattern <c>customers/{customer}/offlineUserDataJobs/{offline_user_data_job}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="offlineUserDataJobId">
        /// The <c>OfflineUserDataJob</c> ID. Must not be <c>null</c> or empty.
        /// </param>
        public OfflineUserDataJobName(string customerId, string offlineUserDataJobId) : this(ResourceNameType.CustomerOfflineUserDataJob, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), offlineUserDataJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(offlineUserDataJobId, nameof(offlineUserDataJobId)))
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
        /// The <c>Customer</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CustomerId { get; }

        /// <summary>
        /// The <c>OfflineUserDataJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed
        /// resource name.
        /// </summary>
        public string OfflineUserDataJobId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerOfflineUserDataJob: return s_customerOfflineUserDataJob.Expand(CustomerId, OfflineUserDataJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as OfflineUserDataJobName);

        /// <inheritdoc/>
        public bool Equals(OfflineUserDataJobName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(OfflineUserDataJobName a, OfflineUserDataJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(OfflineUserDataJobName a, OfflineUserDataJobName b) => !(a == b);
    }

    public partial class OfflineUserDataJob
    {
        /// <summary>
        /// <see cref="OfflineUserDataJobName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal OfflineUserDataJobName ResourceNameAsOfflineUserDataJobName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : OfflineUserDataJobName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

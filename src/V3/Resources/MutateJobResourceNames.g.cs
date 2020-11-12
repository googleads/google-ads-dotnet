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

namespace Google.Ads.GoogleAds.V3.Resources
{
    /// <summary>Resource name for the <c>MutateJob</c> resource.</summary>
    public sealed partial class MutateJobName : gax::IResourceName, sys::IEquatable<MutateJobName>
    {
        /// <summary>The possible contents of <see cref="MutateJobName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>customers/{customer}/mutateJobs/{mutate_job}</c>.</summary>
            CustomerMutateJob = 1,
        }

        private static gax::PathTemplate s_customerMutateJob = new gax::PathTemplate("customers/{customer}/mutateJobs/{mutate_job}");

        /// <summary>Creates a <see cref="MutateJobName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MutateJobName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MutateJobName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MutateJobName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MutateJobName"/> with the pattern <c>customers/{customer}/mutateJobs/{mutate_job}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mutateJobId">The <c>MutateJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="MutateJobName"/> constructed from the provided ids.</returns>
        public static MutateJobName FromCustomerMutateJob(string customerId, string mutateJobId) =>
            new MutateJobName(ResourceNameType.CustomerMutateJob, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), mutateJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(mutateJobId, nameof(mutateJobId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MutateJobName"/> with pattern
        /// <c>customers/{customer}/mutateJobs/{mutate_job}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mutateJobId">The <c>MutateJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MutateJobName"/> with pattern
        /// <c>customers/{customer}/mutateJobs/{mutate_job}</c>.
        /// </returns>
        public static string Format(string customerId, string mutateJobId) => FormatCustomerMutateJob(customerId, mutateJobId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MutateJobName"/> with pattern
        /// <c>customers/{customer}/mutateJobs/{mutate_job}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mutateJobId">The <c>MutateJob</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MutateJobName"/> with pattern
        /// <c>customers/{customer}/mutateJobs/{mutate_job}</c>.
        /// </returns>
        public static string FormatCustomerMutateJob(string customerId, string mutateJobId) =>
            s_customerMutateJob.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(mutateJobId, nameof(mutateJobId)));

        /// <summary>Parses the given resource name string into a new <see cref="MutateJobName"/> instance.</summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/mutateJobs/{mutate_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="mutateJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="MutateJobName"/> if successful.</returns>
        public static MutateJobName Parse(string mutateJobName) => Parse(mutateJobName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MutateJobName"/> instance; optionally allowing
        /// an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/mutateJobs/{mutate_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mutateJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MutateJobName"/> if successful.</returns>
        public static MutateJobName Parse(string mutateJobName, bool allowUnparsed) =>
            TryParse(mutateJobName, allowUnparsed, out MutateJobName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MutateJobName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/mutateJobs/{mutate_job}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="mutateJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MutateJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mutateJobName, out MutateJobName result) => TryParse(mutateJobName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MutateJobName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer}/mutateJobs/{mutate_job}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mutateJobName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MutateJobName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mutateJobName, bool allowUnparsed, out MutateJobName result)
        {
            gax::GaxPreconditions.CheckNotNull(mutateJobName, nameof(mutateJobName));
            gax::TemplatedResourceName resourceName;
            if (s_customerMutateJob.TryParseName(mutateJobName, out resourceName))
            {
                result = FromCustomerMutateJob(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mutateJobName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MutateJobName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string mutateJobId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            MutateJobId = mutateJobId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MutateJobName"/> class from the component parts of pattern
        /// <c>customers/{customer}/mutateJobs/{mutate_job}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="mutateJobId">The <c>MutateJob</c> ID. Must not be <c>null</c> or empty.</param>
        public MutateJobName(string customerId, string mutateJobId) : this(ResourceNameType.CustomerMutateJob, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), mutateJobId: gax::GaxPreconditions.CheckNotNullOrEmpty(mutateJobId, nameof(mutateJobId)))
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
        /// The <c>MutateJob</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string MutateJobId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerMutateJob: return s_customerMutateJob.Expand(CustomerId, MutateJobId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MutateJobName);

        /// <inheritdoc/>
        public bool Equals(MutateJobName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(MutateJobName a, MutateJobName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(MutateJobName a, MutateJobName b) => !(a == b);
    }

    public partial class MutateJob
    {
        /// <summary>
        /// <see cref="MutateJobName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal MutateJobName ResourceNameAsMutateJobName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : MutateJobName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

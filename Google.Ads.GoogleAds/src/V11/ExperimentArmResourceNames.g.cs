// Copyright 2022 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V11.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V11.Resources
{
    /// <summary>Resource name for the <c>ExperimentArm</c> resource.</summary>
    public sealed partial class ExperimentArmName : gax::IResourceName, sys::IEquatable<ExperimentArmName>
    {
        /// <summary>The possible contents of <see cref="ExperimentArmName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c>.
            /// </summary>
            CustomerTrialTrialArm = 1,
        }

        private static gax::PathTemplate s_customerTrialTrialArm = new gax::PathTemplate("customers/{customer_id}/experimentArms/{trial_id_trial_arm_id}");

        /// <summary>Creates a <see cref="ExperimentArmName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="ExperimentArmName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static ExperimentArmName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new ExperimentArmName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="ExperimentArmName"/> with the pattern
        /// <c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialArmId">The <c>TrialArm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="ExperimentArmName"/> constructed from the provided ids.</returns>
        public static ExperimentArmName FromCustomerTrialTrialArm(string customerId, string trialId, string trialArmId) =>
            new ExperimentArmName(ResourceNameType.CustomerTrialTrialArm, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), trialId: gax::GaxPreconditions.CheckNotNullOrEmpty(trialId, nameof(trialId)), trialArmId: gax::GaxPreconditions.CheckNotNullOrEmpty(trialArmId, nameof(trialArmId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExperimentArmName"/> with pattern
        /// <c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialArmId">The <c>TrialArm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExperimentArmName"/> with pattern
        /// <c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c>.
        /// </returns>
        public static string Format(string customerId, string trialId, string trialArmId) =>
            FormatCustomerTrialTrialArm(customerId, trialId, trialArmId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="ExperimentArmName"/> with pattern
        /// <c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialArmId">The <c>TrialArm</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="ExperimentArmName"/> with pattern
        /// <c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c>.
        /// </returns>
        public static string FormatCustomerTrialTrialArm(string customerId, string trialId, string trialArmId) =>
            s_customerTrialTrialArm.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), $"{(gax::GaxPreconditions.CheckNotNullOrEmpty(trialId, nameof(trialId)))}~{(gax::GaxPreconditions.CheckNotNullOrEmpty(trialArmId, nameof(trialArmId)))}");

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExperimentArmName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="experimentArmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="ExperimentArmName"/> if successful.</returns>
        public static ExperimentArmName Parse(string experimentArmName) => Parse(experimentArmName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="ExperimentArmName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="experimentArmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="ExperimentArmName"/> if successful.</returns>
        public static ExperimentArmName Parse(string experimentArmName, bool allowUnparsed) =>
            TryParse(experimentArmName, allowUnparsed, out ExperimentArmName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExperimentArmName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c></description>
        /// </item>
        /// </list>
        /// </remarks>
        /// <param name="experimentArmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExperimentArmName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string experimentArmName, out ExperimentArmName result) =>
            TryParse(experimentArmName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="ExperimentArmName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item>
        /// <description><c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c></description>
        /// </item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="experimentArmName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="ExperimentArmName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string experimentArmName, bool allowUnparsed, out ExperimentArmName result)
        {
            gax::GaxPreconditions.CheckNotNull(experimentArmName, nameof(experimentArmName));
            gax::TemplatedResourceName resourceName;
            if (s_customerTrialTrialArm.TryParseName(experimentArmName, out resourceName))
            {
                string[] split1 = ParseSplitHelper(resourceName[1], new char[] { '~', });
                if (split1 == null)
                {
                    result = null;
                    return false;
                }
                result = FromCustomerTrialTrialArm(resourceName[0], split1[0], split1[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(experimentArmName, out gax::UnparsedResourceName unparsedResourceName))
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

        private ExperimentArmName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string trialId = null, string trialArmId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            TrialId = trialId;
            TrialArmId = trialArmId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="ExperimentArmName"/> class from the component parts of pattern
        /// <c>customers/{customer_id}/experimentArms/{trial_id}~{trial_arm_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialId">The <c>Trial</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="trialArmId">The <c>TrialArm</c> ID. Must not be <c>null</c> or empty.</param>
        public ExperimentArmName(string customerId, string trialId, string trialArmId) : this(ResourceNameType.CustomerTrialTrialArm, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), trialId: gax::GaxPreconditions.CheckNotNullOrEmpty(trialId, nameof(trialId)), trialArmId: gax::GaxPreconditions.CheckNotNullOrEmpty(trialArmId, nameof(trialArmId)))
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
        /// The <c>Trial</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TrialId { get; }

        /// <summary>
        /// The <c>TrialArm</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string TrialArmId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerTrialTrialArm: return s_customerTrialTrialArm.Expand(CustomerId, $"{TrialId}~{TrialArmId}");
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as ExperimentArmName);

        /// <inheritdoc/>
        public bool Equals(ExperimentArmName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(ExperimentArmName a, ExperimentArmName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(ExperimentArmName a, ExperimentArmName b) => !(a == b);
    }

    public partial class ExperimentArm
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentArmName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::ExperimentArmName ResourceNameAsExperimentArmName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::ExperimentArmName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ExperimentName"/>-typed view over the <see cref="Trial"/> resource name property.
        /// </summary>
        internal ExperimentName TrialAsExperimentName
        {
            get => string.IsNullOrEmpty(Trial) ? null : ExperimentName.Parse(Trial, allowUnparsed: true);
            set => Trial = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::ExperimentArmName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentArmName ExperimentArmName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::ExperimentArmName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="Campaigns"/> resource name property.
        /// </summary>
        internal gax::ResourceNameList<CampaignName> CampaignsAsCampaignNames
        {
            get => new gax::ResourceNameList<CampaignName>(Campaigns, s => string.IsNullOrEmpty(s) ? null : CampaignName.Parse(s, allowUnparsed: true));
        }

        /// <summary>
        /// <see cref="CampaignName"/>-typed view over the <see cref="InDesignCampaigns"/> resource name property.
        /// </summary>
        internal gax::ResourceNameList<CampaignName> InDesignCampaignsAsCampaignNames
        {
            get => new gax::ResourceNameList<CampaignName>(InDesignCampaigns, s => string.IsNullOrEmpty(s) ? null : CampaignName.Parse(s, allowUnparsed: true));
        }
    }
}

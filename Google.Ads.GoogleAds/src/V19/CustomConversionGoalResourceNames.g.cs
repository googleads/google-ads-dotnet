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
using gagvr = Google.Ads.GoogleAds.V19.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V19.Resources
{
    /// <summary>Resource name for the <c>CustomConversionGoal</c> resource.</summary>
    public sealed partial class CustomConversionGoalName : gax::IResourceName, sys::IEquatable<CustomConversionGoalName>
    {
        /// <summary>The possible contents of <see cref="CustomConversionGoalName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>customers/{customer_id}/customConversionGoals/{goal_id}</c>.
            /// </summary>
            CustomerGoal = 1,
        }

        private static gax::PathTemplate s_customerGoal = new gax::PathTemplate("customers/{customer_id}/customConversionGoals/{goal_id}");

        /// <summary>Creates a <see cref="CustomConversionGoalName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CustomConversionGoalName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CustomConversionGoalName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CustomConversionGoalName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CustomConversionGoalName"/> with the pattern
        /// <c>customers/{customer_id}/customConversionGoals/{goal_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goalId">The <c>Goal</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="CustomConversionGoalName"/> constructed from the provided ids.
        /// </returns>
        public static CustomConversionGoalName FromCustomerGoal(string customerId, string goalId) =>
            new CustomConversionGoalName(ResourceNameType.CustomerGoal, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), goalId: gax::GaxPreconditions.CheckNotNullOrEmpty(goalId, nameof(goalId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomConversionGoalName"/> with pattern
        /// <c>customers/{customer_id}/customConversionGoals/{goal_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goalId">The <c>Goal</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomConversionGoalName"/> with pattern
        /// <c>customers/{customer_id}/customConversionGoals/{goal_id}</c>.
        /// </returns>
        public static string Format(string customerId, string goalId) => FormatCustomerGoal(customerId, goalId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CustomConversionGoalName"/> with pattern
        /// <c>customers/{customer_id}/customConversionGoals/{goal_id}</c>.
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goalId">The <c>Goal</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CustomConversionGoalName"/> with pattern
        /// <c>customers/{customer_id}/customConversionGoals/{goal_id}</c>.
        /// </returns>
        public static string FormatCustomerGoal(string customerId, string goalId) =>
            s_customerGoal.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), gax::GaxPreconditions.CheckNotNullOrEmpty(goalId, nameof(goalId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomConversionGoalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customConversionGoals/{goal_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customConversionGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CustomConversionGoalName"/> if successful.</returns>
        public static CustomConversionGoalName Parse(string customConversionGoalName) =>
            Parse(customConversionGoalName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CustomConversionGoalName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customConversionGoals/{goal_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customConversionGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CustomConversionGoalName"/> if successful.</returns>
        public static CustomConversionGoalName Parse(string customConversionGoalName, bool allowUnparsed) =>
            TryParse(customConversionGoalName, allowUnparsed, out CustomConversionGoalName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomConversionGoalName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customConversionGoals/{goal_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="customConversionGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomConversionGoalName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customConversionGoalName, out CustomConversionGoalName result) =>
            TryParse(customConversionGoalName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CustomConversionGoalName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>customers/{customer_id}/customConversionGoals/{goal_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="customConversionGoalName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CustomConversionGoalName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string customConversionGoalName, bool allowUnparsed, out CustomConversionGoalName result)
        {
            gax::GaxPreconditions.CheckNotNull(customConversionGoalName, nameof(customConversionGoalName));
            gax::TemplatedResourceName resourceName;
            if (s_customerGoal.TryParseName(customConversionGoalName, out resourceName))
            {
                result = FromCustomerGoal(resourceName[0], resourceName[1]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(customConversionGoalName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CustomConversionGoalName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string customerId = null, string goalId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CustomerId = customerId;
            GoalId = goalId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CustomConversionGoalName"/> class from the component parts of
        /// pattern <c>customers/{customer_id}/customConversionGoals/{goal_id}</c>
        /// </summary>
        /// <param name="customerId">The <c>Customer</c> ID. Must not be <c>null</c> or empty.</param>
        /// <param name="goalId">The <c>Goal</c> ID. Must not be <c>null</c> or empty.</param>
        public CustomConversionGoalName(string customerId, string goalId) : this(ResourceNameType.CustomerGoal, customerId: gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)), goalId: gax::GaxPreconditions.CheckNotNullOrEmpty(goalId, nameof(goalId)))
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
        /// The <c>Goal</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string GoalId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CustomerGoal: return s_customerGoal.Expand(CustomerId, GoalId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CustomConversionGoalName);

        /// <inheritdoc/>
        public bool Equals(CustomConversionGoalName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(CustomConversionGoalName a, CustomConversionGoalName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(CustomConversionGoalName a, CustomConversionGoalName b) => !(a == b);
    }

    public partial class CustomConversionGoal
    {
        /// <summary>
        /// <see cref="gagvr::CustomConversionGoalName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::CustomConversionGoalName ResourceNameAsCustomConversionGoalName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::CustomConversionGoalName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CustomConversionGoalName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::CustomConversionGoalName CustomConversionGoalName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::CustomConversionGoalName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="ConversionActionName"/>-typed view over the <see cref="ConversionActions"/> resource name
        /// property.
        /// </summary>
        internal gax::ResourceNameList<ConversionActionName> ConversionActionsAsConversionActionNames
        {
            get => new gax::ResourceNameList<ConversionActionName>(ConversionActions, s => string.IsNullOrEmpty(s) ? null : ConversionActionName.Parse(s, allowUnparsed: true));
        }
    }
}

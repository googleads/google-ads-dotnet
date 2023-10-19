// Copyright 2023 Google LLC
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
using gagvr = Google.Ads.GoogleAds.V15.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V15.Resources
{
    /// <summary>Resource name for the <c>CarrierConstant</c> resource.</summary>
    public sealed partial class CarrierConstantName : gax::IResourceName, sys::IEquatable<CarrierConstantName>
    {
        /// <summary>The possible contents of <see cref="CarrierConstantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>carrierConstants/{criterion_id}</c>.</summary>
            Criterion = 1,
        }

        private static gax::PathTemplate s_criterion = new gax::PathTemplate("carrierConstants/{criterion_id}");

        /// <summary>Creates a <see cref="CarrierConstantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CarrierConstantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CarrierConstantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CarrierConstantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CarrierConstantName"/> with the pattern <c>carrierConstants/{criterion_id}</c>.
        /// </summary>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CarrierConstantName"/> constructed from the provided ids.</returns>
        public static CarrierConstantName FromCriterion(string criterionId) =>
            new CarrierConstantName(ResourceNameType.Criterion, criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CarrierConstantName"/> with pattern
        /// <c>carrierConstants/{criterion_id}</c>.
        /// </summary>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CarrierConstantName"/> with pattern
        /// <c>carrierConstants/{criterion_id}</c>.
        /// </returns>
        public static string Format(string criterionId) => FormatCriterion(criterionId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CarrierConstantName"/> with pattern
        /// <c>carrierConstants/{criterion_id}</c>.
        /// </summary>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CarrierConstantName"/> with pattern
        /// <c>carrierConstants/{criterion_id}</c>.
        /// </returns>
        public static string FormatCriterion(string criterionId) =>
            s_criterion.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CarrierConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>carrierConstants/{criterion_id}</c></description></item></list>
        /// </remarks>
        /// <param name="carrierConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CarrierConstantName"/> if successful.</returns>
        public static CarrierConstantName Parse(string carrierConstantName) => Parse(carrierConstantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CarrierConstantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>carrierConstants/{criterion_id}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="carrierConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CarrierConstantName"/> if successful.</returns>
        public static CarrierConstantName Parse(string carrierConstantName, bool allowUnparsed) =>
            TryParse(carrierConstantName, allowUnparsed, out CarrierConstantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CarrierConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>carrierConstants/{criterion_id}</c></description></item></list>
        /// </remarks>
        /// <param name="carrierConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CarrierConstantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string carrierConstantName, out CarrierConstantName result) =>
            TryParse(carrierConstantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CarrierConstantName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet"><item><description><c>carrierConstants/{criterion_id}</c></description></item></list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="carrierConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CarrierConstantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string carrierConstantName, bool allowUnparsed, out CarrierConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(carrierConstantName, nameof(carrierConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_criterion.TryParseName(carrierConstantName, out resourceName))
            {
                result = FromCriterion(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(carrierConstantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CarrierConstantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string criterionId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CriterionId = criterionId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CarrierConstantName"/> class from the component parts of pattern
        /// <c>carrierConstants/{criterion_id}</c>
        /// </summary>
        /// <param name="criterionId">The <c>Criterion</c> ID. Must not be <c>null</c> or empty.</param>
        public CarrierConstantName(string criterionId) : this(ResourceNameType.Criterion, criterionId: gax::GaxPreconditions.CheckNotNullOrEmpty(criterionId, nameof(criterionId)))
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
        /// The <c>Criterion</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource name.
        /// </summary>
        public string CriterionId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.Criterion: return s_criterion.Expand(CriterionId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CarrierConstantName);

        /// <inheritdoc/>
        public bool Equals(CarrierConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CarrierConstantName a, CarrierConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CarrierConstantName a, CarrierConstantName b) => !(a == b);
    }

    public partial class CarrierConstant
    {
        /// <summary>
        /// <see cref="gagvr::CarrierConstantName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::CarrierConstantName ResourceNameAsCarrierConstantName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::CarrierConstantName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CarrierConstantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal gagvr::CarrierConstantName CarrierConstantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::CarrierConstantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

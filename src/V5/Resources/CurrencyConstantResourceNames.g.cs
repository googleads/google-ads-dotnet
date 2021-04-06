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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V5.Resources
{
    /// <summary>Resource name for the <c>CurrencyConstant</c> resource.</summary>
    public sealed partial class CurrencyConstantName : gax::IResourceName, sys::IEquatable<CurrencyConstantName>
    {
        /// <summary>The possible contents of <see cref="CurrencyConstantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>A resource name with pattern <c>currencyConstants/{currency_constant}</c>.</summary>
            CurrencyConstant = 1,
        }

        private static gax::PathTemplate s_currencyConstant = new gax::PathTemplate("currencyConstants/{currency_constant}");

        /// <summary>Creates a <see cref="CurrencyConstantName"/> containing an unparsed resource name.</summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="CurrencyConstantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static CurrencyConstantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new CurrencyConstantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="CurrencyConstantName"/> with the pattern <c>currencyConstants/{currency_constant}</c>.
        /// </summary>
        /// <param name="currencyConstantId">The <c>CurrencyConstant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>A new instance of <see cref="CurrencyConstantName"/> constructed from the provided ids.</returns>
        public static CurrencyConstantName FromCurrencyConstant(string currencyConstantId) =>
            new CurrencyConstantName(ResourceNameType.CurrencyConstant, currencyConstantId: gax::GaxPreconditions.CheckNotNullOrEmpty(currencyConstantId, nameof(currencyConstantId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CurrencyConstantName"/> with pattern
        /// <c>currencyConstants/{currency_constant}</c>.
        /// </summary>
        /// <param name="currencyConstantId">The <c>CurrencyConstant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CurrencyConstantName"/> with pattern
        /// <c>currencyConstants/{currency_constant}</c>.
        /// </returns>
        public static string Format(string currencyConstantId) => FormatCurrencyConstant(currencyConstantId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="CurrencyConstantName"/> with pattern
        /// <c>currencyConstants/{currency_constant}</c>.
        /// </summary>
        /// <param name="currencyConstantId">The <c>CurrencyConstant</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="CurrencyConstantName"/> with pattern
        /// <c>currencyConstants/{currency_constant}</c>.
        /// </returns>
        public static string FormatCurrencyConstant(string currencyConstantId) =>
            s_currencyConstant.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(currencyConstantId, nameof(currencyConstantId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CurrencyConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>currencyConstants/{currency_constant}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="currencyConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <returns>The parsed <see cref="CurrencyConstantName"/> if successful.</returns>
        public static CurrencyConstantName Parse(string currencyConstantName) => Parse(currencyConstantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="CurrencyConstantName"/> instance; optionally
        /// allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>currencyConstants/{currency_constant}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="currencyConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="CurrencyConstantName"/> if successful.</returns>
        public static CurrencyConstantName Parse(string currencyConstantName, bool allowUnparsed) =>
            TryParse(currencyConstantName, allowUnparsed, out CurrencyConstantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CurrencyConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>currencyConstants/{currency_constant}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="currencyConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CurrencyConstantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string currencyConstantName, out CurrencyConstantName result) =>
            TryParse(currencyConstantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="CurrencyConstantName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>currencyConstants/{currency_constant}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="currencyConstantName">The resource name in string form. Must not be <c>null</c>.</param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="CurrencyConstantName"/>, or <c>null</c> if parsing failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string currencyConstantName, bool allowUnparsed, out CurrencyConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(currencyConstantName, nameof(currencyConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_currencyConstant.TryParseName(currencyConstantName, out resourceName))
            {
                result = FromCurrencyConstant(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(currencyConstantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private CurrencyConstantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string currencyConstantId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            CurrencyConstantId = currencyConstantId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="CurrencyConstantName"/> class from the component parts of pattern
        /// <c>currencyConstants/{currency_constant}</c>
        /// </summary>
        /// <param name="currencyConstantId">The <c>CurrencyConstant</c> ID. Must not be <c>null</c> or empty.</param>
        public CurrencyConstantName(string currencyConstantId) : this(ResourceNameType.CurrencyConstant, currencyConstantId: gax::GaxPreconditions.CheckNotNullOrEmpty(currencyConstantId, nameof(currencyConstantId)))
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
        /// The <c>CurrencyConstant</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string CurrencyConstantId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.CurrencyConstant: return s_currencyConstant.Expand(CurrencyConstantId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as CurrencyConstantName);

        /// <inheritdoc/>
        public bool Equals(CurrencyConstantName other) => ToString() == other?.ToString();

        /// <inheritdoc/>
        public static bool operator ==(CurrencyConstantName a, CurrencyConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <inheritdoc/>
        public static bool operator !=(CurrencyConstantName a, CurrencyConstantName b) => !(a == b);
    }

    public partial class CurrencyConstant
    {
        /// <summary>
        /// <see cref="gagvr::CurrencyConstantName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal CurrencyConstantName ResourceNameAsCurrencyConstantName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::CurrencyConstantName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CurrencyConstantName"/>-typed view over the <see cref="Name"/> resource name property.
        /// </summary>
        internal CurrencyConstantName CurrencyConstantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::CurrencyConstantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

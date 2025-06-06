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
using gagvr = Google.Ads.GoogleAds.V20.Resources;
using gax = Google.Api.Gax;
using sys = System;

namespace Google.Ads.GoogleAds.V20.Resources
{
    /// <summary>Resource name for the <c>MobileAppCategoryConstant</c> resource.</summary>
    public sealed partial class MobileAppCategoryConstantName : gax::IResourceName, sys::IEquatable<MobileAppCategoryConstantName>
    {
        /// <summary>The possible contents of <see cref="MobileAppCategoryConstantName"/>.</summary>
        public enum ResourceNameType
        {
            /// <summary>An unparsed resource name.</summary>
            Unparsed = 0,

            /// <summary>
            /// A resource name with pattern <c>mobileAppCategoryConstants/{mobile_app_category_id}</c>.
            /// </summary>
            MobileAppCategory = 1,
        }

        private static gax::PathTemplate s_mobileAppCategory = new gax::PathTemplate("mobileAppCategoryConstants/{mobile_app_category_id}");

        /// <summary>
        /// Creates a <see cref="MobileAppCategoryConstantName"/> containing an unparsed resource name.
        /// </summary>
        /// <param name="unparsedResourceName">The unparsed resource name. Must not be <c>null</c>.</param>
        /// <returns>
        /// A new instance of <see cref="MobileAppCategoryConstantName"/> containing the provided
        /// <paramref name="unparsedResourceName"/>.
        /// </returns>
        public static MobileAppCategoryConstantName FromUnparsed(gax::UnparsedResourceName unparsedResourceName) =>
            new MobileAppCategoryConstantName(ResourceNameType.Unparsed, gax::GaxPreconditions.CheckNotNull(unparsedResourceName, nameof(unparsedResourceName)));

        /// <summary>
        /// Creates a <see cref="MobileAppCategoryConstantName"/> with the pattern
        /// <c>mobileAppCategoryConstants/{mobile_app_category_id}</c>.
        /// </summary>
        /// <param name="mobileAppCategoryId">The <c>MobileAppCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// A new instance of <see cref="MobileAppCategoryConstantName"/> constructed from the provided ids.
        /// </returns>
        public static MobileAppCategoryConstantName FromMobileAppCategory(string mobileAppCategoryId) =>
            new MobileAppCategoryConstantName(ResourceNameType.MobileAppCategory, mobileAppCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(mobileAppCategoryId, nameof(mobileAppCategoryId)));

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MobileAppCategoryConstantName"/> with
        /// pattern <c>mobileAppCategoryConstants/{mobile_app_category_id}</c>.
        /// </summary>
        /// <param name="mobileAppCategoryId">The <c>MobileAppCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MobileAppCategoryConstantName"/> with pattern
        /// <c>mobileAppCategoryConstants/{mobile_app_category_id}</c>.
        /// </returns>
        public static string Format(string mobileAppCategoryId) => FormatMobileAppCategory(mobileAppCategoryId);

        /// <summary>
        /// Formats the IDs into the string representation of this <see cref="MobileAppCategoryConstantName"/> with
        /// pattern <c>mobileAppCategoryConstants/{mobile_app_category_id}</c>.
        /// </summary>
        /// <param name="mobileAppCategoryId">The <c>MobileAppCategory</c> ID. Must not be <c>null</c> or empty.</param>
        /// <returns>
        /// The string representation of this <see cref="MobileAppCategoryConstantName"/> with pattern
        /// <c>mobileAppCategoryConstants/{mobile_app_category_id}</c>.
        /// </returns>
        public static string FormatMobileAppCategory(string mobileAppCategoryId) =>
            s_mobileAppCategory.Expand(gax::GaxPreconditions.CheckNotNullOrEmpty(mobileAppCategoryId, nameof(mobileAppCategoryId)));

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MobileAppCategoryConstantName"/> instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>mobileAppCategoryConstants/{mobile_app_category_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="mobileAppCategoryConstantName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <returns>The parsed <see cref="MobileAppCategoryConstantName"/> if successful.</returns>
        public static MobileAppCategoryConstantName Parse(string mobileAppCategoryConstantName) =>
            Parse(mobileAppCategoryConstantName, false);

        /// <summary>
        /// Parses the given resource name string into a new <see cref="MobileAppCategoryConstantName"/> instance;
        /// optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>mobileAppCategoryConstants/{mobile_app_category_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mobileAppCategoryConstantName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <returns>The parsed <see cref="MobileAppCategoryConstantName"/> if successful.</returns>
        public static MobileAppCategoryConstantName Parse(string mobileAppCategoryConstantName, bool allowUnparsed) =>
            TryParse(mobileAppCategoryConstantName, allowUnparsed, out MobileAppCategoryConstantName result) ? result : throw new sys::ArgumentException("The given resource-name matches no pattern.");

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MobileAppCategoryConstantName"/>
        /// instance.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>mobileAppCategoryConstants/{mobile_app_category_id}</c></description></item>
        /// </list>
        /// </remarks>
        /// <param name="mobileAppCategoryConstantName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MobileAppCategoryConstantName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mobileAppCategoryConstantName, out MobileAppCategoryConstantName result) =>
            TryParse(mobileAppCategoryConstantName, false, out result);

        /// <summary>
        /// Tries to parse the given resource name string into a new <see cref="MobileAppCategoryConstantName"/>
        /// instance; optionally allowing an unparseable resource name.
        /// </summary>
        /// <remarks>
        /// To parse successfully, the resource name must be formatted as one of the following:
        /// <list type="bullet">
        /// <item><description><c>mobileAppCategoryConstants/{mobile_app_category_id}</c></description></item>
        /// </list>
        /// Or may be in any format if <paramref name="allowUnparsed"/> is <c>true</c>.
        /// </remarks>
        /// <param name="mobileAppCategoryConstantName">
        /// The resource name in string form. Must not be <c>null</c>.
        /// </param>
        /// <param name="allowUnparsed">
        /// If <c>true</c> will successfully store an unparseable resource name into the <see cref="UnparsedResource"/>
        /// property; otherwise will throw an <see cref="sys::ArgumentException"/> if an unparseable resource name is
        /// specified.
        /// </param>
        /// <param name="result">
        /// When this method returns, the parsed <see cref="MobileAppCategoryConstantName"/>, or <c>null</c> if parsing
        /// failed.
        /// </param>
        /// <returns><c>true</c> if the name was parsed successfully; <c>false</c> otherwise.</returns>
        public static bool TryParse(string mobileAppCategoryConstantName, bool allowUnparsed, out MobileAppCategoryConstantName result)
        {
            gax::GaxPreconditions.CheckNotNull(mobileAppCategoryConstantName, nameof(mobileAppCategoryConstantName));
            gax::TemplatedResourceName resourceName;
            if (s_mobileAppCategory.TryParseName(mobileAppCategoryConstantName, out resourceName))
            {
                result = FromMobileAppCategory(resourceName[0]);
                return true;
            }
            if (allowUnparsed)
            {
                if (gax::UnparsedResourceName.TryParse(mobileAppCategoryConstantName, out gax::UnparsedResourceName unparsedResourceName))
                {
                    result = FromUnparsed(unparsedResourceName);
                    return true;
                }
            }
            result = null;
            return false;
        }

        private MobileAppCategoryConstantName(ResourceNameType type, gax::UnparsedResourceName unparsedResourceName = null, string mobileAppCategoryId = null)
        {
            Type = type;
            UnparsedResource = unparsedResourceName;
            MobileAppCategoryId = mobileAppCategoryId;
        }

        /// <summary>
        /// Constructs a new instance of a <see cref="MobileAppCategoryConstantName"/> class from the component parts of
        /// pattern <c>mobileAppCategoryConstants/{mobile_app_category_id}</c>
        /// </summary>
        /// <param name="mobileAppCategoryId">The <c>MobileAppCategory</c> ID. Must not be <c>null</c> or empty.</param>
        public MobileAppCategoryConstantName(string mobileAppCategoryId) : this(ResourceNameType.MobileAppCategory, mobileAppCategoryId: gax::GaxPreconditions.CheckNotNullOrEmpty(mobileAppCategoryId, nameof(mobileAppCategoryId)))
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
        /// The <c>MobileAppCategory</c> ID. Will not be <c>null</c>, unless this instance contains an unparsed resource
        /// name.
        /// </summary>
        public string MobileAppCategoryId { get; }

        /// <summary>Whether this instance contains a resource name with a known pattern.</summary>
        public bool IsKnownPattern => Type != ResourceNameType.Unparsed;

        /// <summary>The string representation of the resource name.</summary>
        /// <returns>The string representation of the resource name.</returns>
        public override string ToString()
        {
            switch (Type)
            {
                case ResourceNameType.Unparsed: return UnparsedResource.ToString();
                case ResourceNameType.MobileAppCategory: return s_mobileAppCategory.Expand(MobileAppCategoryId);
                default: throw new sys::InvalidOperationException("Unrecognized resource-type.");
            }
        }

        /// <summary>Returns a hash code for this resource name.</summary>
        public override int GetHashCode() => ToString().GetHashCode();

        /// <inheritdoc/>
        public override bool Equals(object obj) => Equals(obj as MobileAppCategoryConstantName);

        /// <inheritdoc/>
        public bool Equals(MobileAppCategoryConstantName other) => ToString() == other?.ToString();

        /// <summary>Determines whether two specified resource names have the same value.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is the same as the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator ==(MobileAppCategoryConstantName a, MobileAppCategoryConstantName b) => ReferenceEquals(a, b) || (a?.Equals(b) ?? false);

        /// <summary>Determines whether two specified resource names have different values.</summary>
        /// <param name="a">The first resource name to compare, or null.</param>
        /// <param name="b">The second resource name to compare, or null.</param>
        /// <returns>
        /// true if the value of <paramref name="a"/> is different from the value of <paramref name="b"/>; otherwise,
        /// false.
        /// </returns>
        public static bool operator !=(MobileAppCategoryConstantName a, MobileAppCategoryConstantName b) => !(a == b);
    }

    public partial class MobileAppCategoryConstant
    {
        /// <summary>
        /// <see cref="gagvr::MobileAppCategoryConstantName"/>-typed view over the <see cref="ResourceName"/> resource
        /// name property.
        /// </summary>
        internal gagvr::MobileAppCategoryConstantName ResourceNameAsMobileAppCategoryConstantName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::MobileAppCategoryConstantName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::MobileAppCategoryConstantName"/>-typed view over the <see cref="Name"/> resource name
        /// property.
        /// </summary>
        internal gagvr::MobileAppCategoryConstantName MobileAppCategoryConstantName
        {
            get => string.IsNullOrEmpty(Name) ? null : gagvr::MobileAppCategoryConstantName.Parse(Name, allowUnparsed: true);
            set => Name = value?.ToString() ?? "";
        }
    }
}

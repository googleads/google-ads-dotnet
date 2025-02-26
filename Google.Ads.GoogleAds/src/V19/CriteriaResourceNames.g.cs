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

namespace Google.Ads.GoogleAds.V19.Common
{
    public partial class MobileAppCategoryInfo
    {
        /// <summary>
        /// <see cref="gagvr::MobileAppCategoryConstantName"/>-typed view over the
        /// <see cref="MobileAppCategoryConstant"/> resource name property.
        /// </summary>
        internal gagvr::MobileAppCategoryConstantName MobileAppCategoryConstantAsMobileAppCategoryConstantName
        {
            get => string.IsNullOrEmpty(MobileAppCategoryConstant) ? null : gagvr::MobileAppCategoryConstantName.Parse(MobileAppCategoryConstant, allowUnparsed: true);
            set => MobileAppCategoryConstant = value?.ToString() ?? "";
        }
    }

    public partial class TopicInfo
    {
        /// <summary>
        /// <see cref="gagvr::TopicConstantName"/>-typed view over the <see cref="TopicConstant"/> resource name
        /// property.
        /// </summary>
        internal gagvr::TopicConstantName TopicConstantAsTopicConstantName
        {
            get => string.IsNullOrEmpty(TopicConstant) ? null : gagvr::TopicConstantName.Parse(TopicConstant, allowUnparsed: true);
            set => TopicConstant = value?.ToString() ?? "";
        }
    }

    public partial class CarrierInfo
    {
        /// <summary>
        /// <see cref="gagvr::CarrierConstantName"/>-typed view over the <see cref="CarrierConstant"/> resource name
        /// property.
        /// </summary>
        internal gagvr::CarrierConstantName CarrierConstantAsCarrierConstantName
        {
            get => string.IsNullOrEmpty(CarrierConstant) ? null : gagvr::CarrierConstantName.Parse(CarrierConstant, allowUnparsed: true);
            set => CarrierConstant = value?.ToString() ?? "";
        }
    }

    public partial class OperatingSystemVersionInfo
    {
        /// <summary>
        /// <see cref="gagvr::OperatingSystemVersionConstantName"/>-typed view over the
        /// <see cref="OperatingSystemVersionConstant"/> resource name property.
        /// </summary>
        internal gagvr::OperatingSystemVersionConstantName OperatingSystemVersionConstantAsOperatingSystemVersionConstantName
        {
            get => string.IsNullOrEmpty(OperatingSystemVersionConstant) ? null : gagvr::OperatingSystemVersionConstantName.Parse(OperatingSystemVersionConstant, allowUnparsed: true);
            set => OperatingSystemVersionConstant = value?.ToString() ?? "";
        }
    }

    public partial class MobileDeviceInfo
    {
        /// <summary>
        /// <see cref="gagvr::MobileDeviceConstantName"/>-typed view over the <see cref="MobileDeviceConstant"/>
        /// resource name property.
        /// </summary>
        internal gagvr::MobileDeviceConstantName MobileDeviceConstantAsMobileDeviceConstantName
        {
            get => string.IsNullOrEmpty(MobileDeviceConstant) ? null : gagvr::MobileDeviceConstantName.Parse(MobileDeviceConstant, allowUnparsed: true);
            set => MobileDeviceConstant = value?.ToString() ?? "";
        }
    }

    public partial class CombinedAudienceInfo
    {
        /// <summary>
        /// <see cref="gagvr::CombinedAudienceName"/>-typed view over the <see cref="CombinedAudience"/> resource name
        /// property.
        /// </summary>
        internal gagvr::CombinedAudienceName CombinedAudienceAsCombinedAudienceName
        {
            get => string.IsNullOrEmpty(CombinedAudience) ? null : gagvr::CombinedAudienceName.Parse(CombinedAudience, allowUnparsed: true);
            set => CombinedAudience = value?.ToString() ?? "";
        }
    }

    public partial class KeywordThemeInfo
    {
        /// <summary>
        /// <see cref="gagvr::KeywordThemeConstantName"/>-typed view over the <see cref="KeywordThemeConstant"/>
        /// resource name property.
        /// </summary>
        internal gagvr::KeywordThemeConstantName KeywordThemeConstantAsKeywordThemeConstantName
        {
            get => string.IsNullOrEmpty(KeywordThemeConstant) ? null : gagvr::KeywordThemeConstantName.Parse(KeywordThemeConstant, allowUnparsed: true);
            set => KeywordThemeConstant = value?.ToString() ?? "";
        }
    }
}

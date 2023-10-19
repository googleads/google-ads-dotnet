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

namespace Google.Ads.GoogleAds.V15.Common
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
}

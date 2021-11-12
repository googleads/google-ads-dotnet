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

using gagvr = Google.Ads.GoogleAds.V9.Resources;

namespace Google.Ads.GoogleAds.V9.Services
{
    public partial class GetKeywordPlanCampaignRequest
    {
        /// <summary>
        /// <see cref="gagvr::KeywordPlanCampaignName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        public gagvr::KeywordPlanCampaignName ResourceNameAsKeywordPlanCampaignName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::KeywordPlanCampaignName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }

    public partial class KeywordPlanCampaignOperation
    {
        /// <summary>
        /// <see cref="gagvr::KeywordPlanCampaignName"/>-typed view over the <see cref="Remove"/> resource name
        /// property.
        /// </summary>
        public gagvr::KeywordPlanCampaignName RemoveAsKeywordPlanCampaignName
        {
            get => string.IsNullOrEmpty(Remove) ? null : gagvr::KeywordPlanCampaignName.Parse(Remove, allowUnparsed: true);
            set => Remove = value?.ToString() ?? "";
        }
    }
}

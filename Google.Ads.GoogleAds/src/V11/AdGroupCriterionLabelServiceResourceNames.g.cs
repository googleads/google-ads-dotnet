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

#pragma warning disable CS8981
using gagvr = Google.Ads.GoogleAds.V11.Resources;

namespace Google.Ads.GoogleAds.V11.Services
{
    public partial class AdGroupCriterionLabelOperation
    {
        /// <summary>
        /// <see cref="gagvr::AdGroupCriterionLabelName"/>-typed view over the <see cref="Remove"/> resource name
        /// property.
        /// </summary>
        internal gagvr::AdGroupCriterionLabelName RemoveAsAdGroupCriterionLabelName
        {
            get => string.IsNullOrEmpty(Remove) ? null : gagvr::AdGroupCriterionLabelName.Parse(Remove, allowUnparsed: true);
            set => Remove = value?.ToString() ?? "";
        }
    }

    public partial class MutateAdGroupCriterionLabelResult
    {
        /// <summary>
        /// <see cref="gagvr::AdGroupCriterionLabelName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::AdGroupCriterionLabelName ResourceNameAsAdGroupCriterionLabelName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::AdGroupCriterionLabelName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

// Copyright 2024 Google LLC
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
using gagvr = Google.Ads.GoogleAds.V18.Resources;

namespace Google.Ads.GoogleAds.V18.Services
{
    public partial class SharedCriterionOperation
    {
        /// <summary>
        /// <see cref="gagvr::SharedCriterionName"/>-typed view over the <see cref="Remove"/> resource name property.
        /// </summary>
        internal gagvr::SharedCriterionName RemoveAsSharedCriterionName
        {
            get => string.IsNullOrEmpty(Remove) ? null : gagvr::SharedCriterionName.Parse(Remove, allowUnparsed: true);
            set => Remove = value?.ToString() ?? "";
        }
    }

    public partial class MutateSharedCriterionResult
    {
        /// <summary>
        /// <see cref="gagvr::SharedCriterionName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::SharedCriterionName ResourceNameAsSharedCriterionName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::SharedCriterionName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

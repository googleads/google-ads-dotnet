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

using gagvr = Google.Ads.GoogleAds.V10.Resources;

namespace Google.Ads.GoogleAds.V10.Services
{
    public partial class BiddingDataExclusionOperation
    {
        /// <summary>
        /// <see cref="gagvr::BiddingDataExclusionName"/>-typed view over the <see cref="Remove"/> resource name
        /// property.
        /// </summary>
        public gagvr::BiddingDataExclusionName RemoveAsBiddingDataExclusionName
        {
            get => string.IsNullOrEmpty(Remove) ? null : gagvr::BiddingDataExclusionName.Parse(Remove, allowUnparsed: true);
            set => Remove = value?.ToString() ?? "";
        }
    }

    public partial class MutateBiddingDataExclusionsResult
    {
        /// <summary>
        /// <see cref="gagvr::BiddingDataExclusionName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        public gagvr::BiddingDataExclusionName ResourceNameAsBiddingDataExclusionName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::BiddingDataExclusionName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

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

namespace Google.Ads.GoogleAds.V18.Common
{
    public partial class LifeEventSegment
    {
        /// <summary>
        /// <see cref="gagvr::LifeEventName"/>-typed view over the <see cref="LifeEvent"/> resource name property.
        /// </summary>
        internal gagvr::LifeEventName LifeEventAsLifeEventName
        {
            get => string.IsNullOrEmpty(LifeEvent) ? null : gagvr::LifeEventName.Parse(LifeEvent, allowUnparsed: true);
            set => LifeEvent = value?.ToString() ?? "";
        }
    }

    public partial class DetailedDemographicSegment
    {
        /// <summary>
        /// <see cref="gagvr::DetailedDemographicName"/>-typed view over the <see cref="DetailedDemographic"/> resource
        /// name property.
        /// </summary>
        internal gagvr::DetailedDemographicName DetailedDemographicAsDetailedDemographicName
        {
            get => string.IsNullOrEmpty(DetailedDemographic) ? null : gagvr::DetailedDemographicName.Parse(DetailedDemographic, allowUnparsed: true);
            set => DetailedDemographic = value?.ToString() ?? "";
        }
    }
}

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

namespace Google.Ads.GoogleAds.V19.Services
{
    public partial class ExperimentOperation
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="Remove"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName RemoveAsExperimentName
        {
            get => string.IsNullOrEmpty(Remove) ? null : gagvr::ExperimentName.Parse(Remove, allowUnparsed: true);
            set => Remove = value?.ToString() ?? "";
        }
    }

    public partial class MutateExperimentResult
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName ResourceNameAsExperimentName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::ExperimentName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }

    public partial class EndExperimentRequest
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="Experiment"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName ExperimentAsExperimentName
        {
            get => string.IsNullOrEmpty(Experiment) ? null : gagvr::ExperimentName.Parse(Experiment, allowUnparsed: true);
            set => Experiment = value?.ToString() ?? "";
        }
    }

    public partial class ListExperimentAsyncErrorsRequest
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName ResourceNameAsExperimentName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::ExperimentName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }

    public partial class GraduateExperimentRequest
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="Experiment"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName ExperimentAsExperimentName
        {
            get => string.IsNullOrEmpty(Experiment) ? null : gagvr::ExperimentName.Parse(Experiment, allowUnparsed: true);
            set => Experiment = value?.ToString() ?? "";
        }
    }

    public partial class CampaignBudgetMapping
    {
        /// <summary>
        /// <see cref="gagvr::CampaignName"/>-typed view over the <see cref="ExperimentCampaign"/> resource name
        /// property.
        /// </summary>
        internal gagvr::CampaignName ExperimentCampaignAsCampaignName
        {
            get => string.IsNullOrEmpty(ExperimentCampaign) ? null : gagvr::CampaignName.Parse(ExperimentCampaign, allowUnparsed: true);
            set => ExperimentCampaign = value?.ToString() ?? "";
        }

        /// <summary>
        /// <see cref="gagvr::CampaignBudgetName"/>-typed view over the <see cref="CampaignBudget"/> resource name
        /// property.
        /// </summary>
        internal gagvr::CampaignBudgetName CampaignBudgetAsCampaignBudgetName
        {
            get => string.IsNullOrEmpty(CampaignBudget) ? null : gagvr::CampaignBudgetName.Parse(CampaignBudget, allowUnparsed: true);
            set => CampaignBudget = value?.ToString() ?? "";
        }
    }

    public partial class ScheduleExperimentRequest
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName ResourceNameAsExperimentName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::ExperimentName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }

    public partial class ScheduleExperimentMetadata
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="Experiment"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName ExperimentAsExperimentName
        {
            get => string.IsNullOrEmpty(Experiment) ? null : gagvr::ExperimentName.Parse(Experiment, allowUnparsed: true);
            set => Experiment = value?.ToString() ?? "";
        }
    }

    public partial class PromoteExperimentRequest
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="ResourceName"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName ResourceNameAsExperimentName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::ExperimentName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }

    public partial class PromoteExperimentMetadata
    {
        /// <summary>
        /// <see cref="gagvr::ExperimentName"/>-typed view over the <see cref="Experiment"/> resource name property.
        /// </summary>
        internal gagvr::ExperimentName ExperimentAsExperimentName
        {
            get => string.IsNullOrEmpty(Experiment) ? null : gagvr::ExperimentName.Parse(Experiment, allowUnparsed: true);
            set => Experiment = value?.ToString() ?? "";
        }
    }
}

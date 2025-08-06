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
using gagvr = Google.Ads.GoogleAds.V21.Resources;

namespace Google.Ads.GoogleAds.V21.Services
{
    public partial class Conversation
    {
        /// <summary>
        /// <see cref="gagvr::LocalServicesLeadName"/>-typed view over the <see cref="LocalServicesLead"/> resource name
        /// property.
        /// </summary>
        internal gagvr::LocalServicesLeadName LocalServicesLeadAsLocalServicesLeadName
        {
            get => string.IsNullOrEmpty(LocalServicesLead) ? null : gagvr::LocalServicesLeadName.Parse(LocalServicesLead, allowUnparsed: true);
            set => LocalServicesLead = value?.ToString() ?? "";
        }
    }

    public partial class ProvideLeadFeedbackRequest
    {
        /// <summary>
        /// <see cref="gagvr::LocalServicesLeadName"/>-typed view over the <see cref="ResourceName"/> resource name
        /// property.
        /// </summary>
        internal gagvr::LocalServicesLeadName ResourceNameAsLocalServicesLeadName
        {
            get => string.IsNullOrEmpty(ResourceName) ? null : gagvr::LocalServicesLeadName.Parse(ResourceName, allowUnparsed: true);
            set => ResourceName = value?.ToString() ?? "";
        }
    }
}

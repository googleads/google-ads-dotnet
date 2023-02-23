// Copyright 2023 Google LLC. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
// Generated code - do not edit

using Google.Ads.GoogleAds.V13.Errors;
using System.Collections.Generic;
using Google.Protobuf.WellKnownTypes;

namespace Google.Ads.GoogleAds.V13.Services
{
    public sealed partial class MutateUserListsResponse 
    {
        /// <summary>
        /// Gets a GoogleAdsFailure instance that combines all the errors
        /// from a failed API call.
        /// </summary>
        public GoogleAdsFailure PartialFailure
        {
            get
            {
                if (this.PartialFailureError == null)
                {
                    return null;
                }
                GoogleAdsFailure retval = new GoogleAdsFailure();
                foreach (Any any in this.PartialFailureError.Details)
                {
                    GoogleAdsFailure failure = any.Unpack<GoogleAdsFailure>();
                    retval.Errors.AddRange(failure.Errors);
                }
                return retval;
            }
        }
    }
}

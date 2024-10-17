// Copyright 2022 Google LLC
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

using Google.Ads.GoogleAds.V18.Errors;
using Google.Protobuf.WellKnownTypes;

#pragma warning disable CS1591

namespace Google.Ads.GoogleAds.V18.Services
{
    public partial class BatchJobResult
    {
        /// <summary>
        /// Gets a value indicating whether this instance is failed.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is failed; otherwise, <c>false</c>.
        /// </value>
        public bool IsFailed
        {
            get
            {
                return this.Status != null;
            }
        }

        /// <summary>
        /// Gets a GoogleAdsFailure instance that combines all the errors
        /// from a failed API call.
        /// </summary>
        public GoogleAdsFailure Failure
        {
            get
            {
                if (this.Status == null)
                {
                    return null;
                }
                GoogleAdsFailure retval = new GoogleAdsFailure();
                foreach (Any any in this.Status.Details)
                {
                    GoogleAdsFailure failure = any.Unpack<GoogleAdsFailure>();
                    retval.Errors.AddRange(failure.Errors);
                }
                return retval;
            }
        }
    }
}

#pragma warning restore CS1591

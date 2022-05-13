// Copyright 2021 Google LLC
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

using Google.Ads.Gax.Lib;
using System.Collections.Generic;
using System.Linq;

namespace Google.Ads.GoogleAds.V9.Errors
{
    partial class GoogleAdsFailure : IResponseMetadata
    {
        /// <summary>
        /// The operations fieldname.
        /// </summary>
        private const string OPERATIONS_FIELDNAME = "operations";

        /// <summary>
        /// Gets the errors for a given operation index.
        /// </summary>
        /// <param name="operationIndex">Index of the operation.</param>
        /// <returns>The list of errors.</returns>
        public List<GoogleAdsError> GetErrorsByOperationIndex(long operationIndex)
        {
            return this.Errors.ToList().Where(delegate (GoogleAdsError error)
            {
                if (error.Location == null)
                {
                    return false;
                }
                return error.Location.FieldPathElements.Any(fpElement =>
                    fpElement.FieldName == OPERATIONS_FIELDNAME &&
                    fpElement.HasIndex &&
                    fpElement.Index == operationIndex);
            }).ToList();
        }
    }

    public partial class GoogleAdsError
    {
        /// <summary>
        /// Gets the combined field path.
        /// </summary>
        public string CombinedFieldPath
        {
            get
            {
                if (this.Location == null)
                {
                    return "";
                }
                List<string> fieldPaths = this.Location.FieldPathElements.Select(fpElement =>
                    {
                        return (fpElement.HasIndex) ?
                            $"{fpElement.FieldName}[{fpElement.Index}]" :
                            fpElement.FieldName;
                    }
                ).ToList();

                return string.Join(".", fieldPaths);
            }
        }
    }
}

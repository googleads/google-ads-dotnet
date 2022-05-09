// Copyright 2018 Google LLC
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

using Google.Ads.Gax.Util;
using Grpc.Core;

namespace Google.Ads.Gax.Lib
{
    /// <summary>
    /// Metadata contained in a Google Ads API call response.
    /// </summary>
    internal class AdsResponseMetadata : IResponseMetadata
    {
        /// <summary>
        /// The metadata key name for request ID.
        /// </summary>
        internal const string RequestIdKey = "request-id";

        /// <summary>
        /// Gets the request ID.
        /// </summary>
        public string RequestId
        {
            get;
            set;
        }

        /// <summary>
        /// Creates a new instance with metadata.
        /// </summary>
        public AdsResponseMetadata(Metadata metadata) : base()
        {
            RequestId = metadata?.GetEntry(RequestIdKey)?.Value;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdsResponseMetadata"/> class.
        /// </summary>
        /// <param name="metadata">The metadata.</param>
        public AdsResponseMetadata(IResponseMetadata metadata) : base()
        {
            RequestId = metadata?.RequestId;
        }
    }
}

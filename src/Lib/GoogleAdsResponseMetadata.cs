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

using Grpc.Core;

namespace Google.Ads.GoogleAds.Lib
{
    /// <summary>
    /// Metadata contained in a Google Ads API call response.
    /// </summary>
    public class GoogleAdsResponseMetadata
    {
        /// <summary>
        /// The gRPC metadata key name for request ID.
        /// </summary>
        private const string RequestIdKey = "request-id";

        /// <summary>
        /// Gets the request ID.
        /// </summary>
        public string RequestId
        {
            get;
            private set;
        }

        /// <summary>
        /// Creates a new instance with metadata.
        /// </summary>
        public GoogleAdsResponseMetadata(Metadata metadata) : base()
        {
            // Clear out all properties to start with, to end up with
            // a consistent set.
            RequestId = null;

            if (metadata == null)
            {
                return;
            }

            for (int i = 0; i < metadata.Count; i++)
            {
                var entry = metadata[i];
                switch (entry.Key)
                {
                    case RequestIdKey:
                        RequestId = entry.Value;
                        break;
                }
            }
        }
    }
}

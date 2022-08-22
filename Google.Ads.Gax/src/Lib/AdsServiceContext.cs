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

using Google.Ads.Gax.Config;
using Google.Api.Gax.Grpc;
using Google.LongRunning;
using Grpc.Core;

namespace Google.Ads.Gax.Lib
{
    /// <summary>
    /// A context class to bind a service instance to its call settings, and the
    /// <see cref="AdsClient{T}"/> instance that created it.
    /// </summary>
    public class AdsServiceContext<T> where T : AdsConfig
    {
        /// <summary>
        /// Gets or sets the client.
        /// </summary>
        public AdsClient<T> Client
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the service.
        /// </summary>
        public AdsServiceClientBase<T> Service
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the call settings.
        /// </summary>
        public CallSettings CallSettings
        {
            get;
            set;
        }

        /// <summary>
        /// Gets the LRO settings.
        /// </summary>
        public OperationsSettings OperationsSettings
        {
            get
            {
                return new OperationsSettings()
                {
                    CallSettings = CallSettings
                };
            }
        }

        /// <summary>
        /// Gets or sets the underlying Ads channel.
        /// </summary>
        internal ChannelBase Channel
        {
            get;
            set;
        }

        /// <summary>
        /// Called when a response metadata is received.
        /// </summary>
        /// <param name="responseMetadata">The response metadata.</param>
        internal void OnResponseMetadataReceived(IResponseMetadata responseMetadata)
        {
            Client?.OnResponseMetadataReceived?.Invoke(this, responseMetadata);
        }
    }
}

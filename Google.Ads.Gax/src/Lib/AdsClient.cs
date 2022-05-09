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
using System;

namespace Google.Ads.Gax.Lib
{
    /// <summary>
    /// A client for creating Ads API services.
    /// </summary>
    public class AdsClient<T> where T : AdsConfig
    {
        /// <summary>
        /// The client configuration.
        /// </summary>
        public T Config
        {
            get; protected set;
        }

        /// <summary>
        /// Initializes a new instance of the <code>AdsClient</code> class.
        /// </summary>
        /// <param name="config">The client configuration.</param>
        public AdsClient(T config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Gets or sets the event handler that will be triggered when a response metadata is
        /// received.
        /// </summary>
        public EventHandler<IResponseMetadata> OnResponseMetadataReceived
        {
            get;
            set;
        }
    }
}

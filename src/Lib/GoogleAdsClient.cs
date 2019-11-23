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

using Google.Ads.GoogleAds.Config;
using Google.Api.Gax.Grpc;
using System;

namespace Google.Ads.GoogleAds.Lib
{
    /// <summary>
    /// A client for creating Google Ads API services.
    /// </summary>
    public class GoogleAdsClient
    {
        /// <summary>
        /// The client configuration.
        /// </summary>
        public GoogleAdsConfig Config
        {
            get; private set;
        }

        /// <summary>
        /// Gets or sets the event handler that will be triggered when a response metadata is
        /// received.
        /// </summary>
        public EventHandler<object> OnResponseMetadataReceived
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsClient"/> class.
        /// </summary>
        /// <remarks>This client uses the configuration values from App.config.</remarks>
        public GoogleAdsClient() : this(new GoogleAdsConfig())
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsClient"/> class.
        /// </summary>
        /// <param name="config">The client configuration.</param>
        public GoogleAdsClient(GoogleAdsConfig config)
        {
            this.Config = config;
        }

        /// <summary>
        /// Gets an instance of the specified service.
        /// </summary>
        /// <param name="serviceTemplate">The service template.</param>
        /// <returns>A service instance.</returns>
        public TService GetService<TService, TServiceSetting>(
            ServiceTemplate<TService, TServiceSetting> serviceTemplate)
                where TServiceSetting : ServiceSettingsBase, new()
                where TService : GoogleAdsServiceClientBase
        {
            GoogleAdsServiceClientFactory factory = new GoogleAdsServiceClientFactory();
            TService service = factory.GetService(serviceTemplate, Config);
            service.ServiceContext.Client = this;
            return service;
        }
    }
}

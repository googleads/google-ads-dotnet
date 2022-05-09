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

using Google.Ads.Gax.Config;
using Google.Ads.Gax.Lib;
using Google.Api.Gax.Grpc;
using Grpc.Core;

namespace Google.Ads.Gax.Lib
{
    /// <summary>
    /// Defines a service template.
    /// </summary>
    /// <typeparam name="TService">Type of the service.</typeparam>
    /// <typeparam name="TServiceSetting">Type of the service setting.</typeparam>
    /// <typeparam name="TConfig">The type of config.</typeparam>
    public class ServiceTemplate<TService, TServiceSetting, TConfig> 
        where TService : AdsServiceClientBase<TConfig> where TConfig : AdsConfig
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceTemplate{TService, TServiceSetting, TConfig}"/> class.
        /// </summary>
        /// <param name="createService">The service creation method.</param>
        public ServiceTemplate(Create createService)
        {
            this.createService = createService;
        }

        /// <summary>
        /// Gets the name of the service type.
        /// </summary>
        /// <value>
        /// The name of the service type.
        /// </value>
        public string ServiceTypeName
        {
            get
            {
                return typeof(TService).Name;
            }
        }

        /// <summary>
        /// Method that creates the service instance.
        /// </summary>
        /// <param name="serviceName">Name of the service.</param>
        /// <param name="callInvoker">The call invoker.</param>
        /// <param name="settings">The settings.</param>
        /// <returns></returns>
        public delegate AdsServiceClientBase<TConfig> Create(string serviceName, CallInvoker callInvoker,
            ServiceSettingsBase settings);

        readonly Create createService;
        /// <summary>
        /// Gets the create service method.
        /// </summary>
        public Create CreateService
        {
            get
            {
                return createService;
            }
        }
    }
}

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
using Grpc.Core;
using System.Linq;
using System.Reflection;

namespace Google.Ads.Gax.Lib
{
    /// <summary>
    /// Factory class for various Ads services.
    /// </summary>
    internal class AdsServiceClientFactory
    {
        /// <summary>
        /// Creates the service settings.
        /// </summary>
        /// <typeparam name="TServiceSetting">The type of the service setting.</typeparam>
        /// <typeparam name="TConfig">The type of the config.</typeparam>
        /// <param name="serviceContext">The service context.</param>
        /// <returns>A service setting object, to be used for creating the service.</returns>
        protected TServiceSetting CreateServiceSettings<TServiceSetting, TConfig>(
            AdsServiceContext<TConfig> serviceContext)
                where TServiceSetting : ServiceSettingsBase, new()
                where TConfig : AdsConfig
        {
            TServiceSetting serviceSettings = new TServiceSetting();

            SetAllPropertySettings(serviceSettings, serviceContext.CallSettings);
            SetAllPropertySettings(serviceSettings, serviceContext.OperationsSettings);
            return serviceSettings;
        }

        /// <summary>
        /// Sets all property settings of a given type with a given value.
        /// </summary>
        /// <typeparam name="TServiceSetting">The type of the service setting.</typeparam>
        /// <typeparam name="TPropertyType">The type of the property to be scanned for.</typeparam>
        /// <param name="serviceSettings">The service settings object whose properties should be
        /// set.</param>
        /// <param name="propertyValue">The property value to be set.</param>
        private static void SetAllPropertySettings<TServiceSetting, TPropertyType>(
            TServiceSetting serviceSettings, TPropertyType propertyValue)
            where TServiceSetting : ServiceSettingsBase, new()
        {
            PropertyInfo[] settingProperties = serviceSettings.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(delegate (PropertyInfo x)
                {
                    return x.PropertyType == typeof(TPropertyType) && x.Name != "CallSettings";
                }
            ).ToArray();

            foreach (PropertyInfo pi in settingProperties)
            {
                pi.SetValue(serviceSettings, propertyValue);
            }
            return;
        }

        /// <summary>
        /// Creates the specified service.
        /// </summary>
        /// <typeparam name="TService">The service type.</typeparam>
        /// <typeparam name="TServiceSetting">The service setting type.</typeparam>
        /// <typeparam name="TConfig">The config type.</typeparam>
        /// <param name="callInvoker">The call invoker for service.</param>
        /// <param name="serviceSettings">The service settings.</param>
        /// <param name="serviceTemplate">The service template.</param>
        /// <returns>The newly created service instance.</returns>
        protected TService Create<TService, TServiceSetting, TConfig>(
            ServiceTemplate<TService, TServiceSetting, TConfig> serviceTemplate, CallInvoker callInvoker,
            ServiceSettingsBase serviceSettings)
            where TService : AdsServiceClientBase<TConfig>
            where TServiceSetting : ServiceSettingsBase, new()
            where TConfig : AdsConfig
        {
            return (TService)serviceTemplate.CreateService(serviceTemplate.ServiceTypeName,
                callInvoker, serviceSettings);
        }
    }
}

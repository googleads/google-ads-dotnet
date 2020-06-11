﻿// Copyright 2018 Google LLC
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
using Google.Ads.GoogleAds.Interceptors;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Linq;
using System.Reflection;

namespace Google.Ads.GoogleAds.Lib
{
    /// <summary>
    /// Factory class for various Google Ads services.
    /// </summary>
    internal class GoogleAdsServiceClientFactory
    {
        /// <summary>
        /// Gets an instance of the specified service.
        /// </summary>
        /// <param name="serviceTemplate">The service template.</param>
        /// <param name="config">The configuration.</param>
        /// <returns>A service instance.</returns>
        internal TService GetService<TService, TServiceSetting>(
            ServiceTemplate<TService, TServiceSetting> serviceTemplate, GoogleAdsConfig config)
                where TServiceSetting : ServiceSettingsBase, new()
                where TService : GoogleAdsServiceClientBase
        {
            Channel channel = CreateChannel(config);
            CallInvoker callInvoker = channel
                .Intercept(GoogleAdsGrpcInterceptor.GetInstance(config));

            // Build a service context to bind the service, configuration and CallSettings.
            GoogleAdsServiceContext serviceContext = new GoogleAdsServiceContext();

            // Build the call settings.
            CallSettings callSettings = CreateCallSettings<TServiceSetting>(config,
                serviceContext);
            serviceContext.CallSettings = callSettings;

            // Create the service settings.
            TServiceSetting serviceSettings = CreateServiceSettings<TServiceSetting>(
                serviceContext);

            // Create the service.
            TService service = Create(serviceTemplate, callInvoker, serviceSettings);
            serviceContext.Service = service;
            service.ServiceContext = serviceContext;
            return service;
        }

        /// <summary>
        /// Creates the service settings.
        /// </summary>
        /// <typeparam name="TServiceSetting">The type of the service setting.</typeparam>
        /// <param name="serviceContext">The service context.</param>
        /// <returns>A service setting object, to be used for creating the service.</returns>
        private TServiceSetting CreateServiceSettings<TServiceSetting>(
            GoogleAdsServiceContext serviceContext)
                where TServiceSetting : ServiceSettingsBase, new()
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
        /// Creates the call settings.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="serviceContext">The service context.</param>
        /// <returns>The call settings.</returns>
        private CallSettings CreateCallSettings<TServiceSetting>(GoogleAdsConfig config, GoogleAdsServiceContext serviceContext)
            where TServiceSetting : ServiceSettingsBase, new()
        {
            // Get the default call settings from the generated stubs.
            CallSettings callSettings = new TServiceSetting().CallSettings;

            // Override various parameters with configuration parameters.
            callSettings = UpdateCallSettingsWithConfigParameters(callSettings,
                config, serviceContext);

            return callSettings;
        }

        /// <summary>
        /// Updates the call settings with configuration parameters.
        /// </summary>
        /// <param name="callSettings">The call settings.</param>
        /// <param name="config">The configuration.</param>
        /// <param name="serviceContext">The service context.</param>
        /// <returns></returns>
        private CallSettings UpdateCallSettingsWithConfigParameters(CallSettings callSettings,
                    GoogleAdsConfig config, GoogleAdsServiceContext serviceContext)
        {
            callSettings = callSettings.WithHeader(MetadataKeyNames.DeveloperToken,
                config.DeveloperToken)
                .WithResponseMetadataHandler(delegate (Metadata metadata)
                {
                    GoogleAdsResponseMetadata responseMetadata =
                        new GoogleAdsResponseMetadata(metadata);
                    serviceContext.OnResponseMetadataReceived(responseMetadata);
                });

            if (!string.IsNullOrEmpty(config.LoginCustomerId))
            {
                callSettings = callSettings.WithHeader(MetadataKeyNames.LoginCustomerId,
                    config.LoginCustomerId);
            }

            if (!string.IsNullOrEmpty(config.LibraryIdentifierOverride))
            {
                callSettings = callSettings.WithHeader(MetadataKeyNames.LibraryIdentifier,
                    config.LibraryIdentifierOverride);
            }

            callSettings = callSettings.WithExpiration(Expiration.FromTimeout(
                TimeSpan.FromMilliseconds(config.Timeout)));

            return callSettings;
        }

        /// <summary>
        /// Creates the channel for the new service, and sets the proxy server.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns>The new channel.</returns>
        private Channel CreateChannel(GoogleAdsConfig config)
        {
            if (config.Proxy == null)
            {
                Environment.SetEnvironmentVariable("http_proxy", null);
            }
            else
            {
                Environment.SetEnvironmentVariable("http_proxy", config.Proxy.Address.ToString());
            }

            // GRPC uses c-ares DNS resolver, which doesn't seem to work on some Windows machines.
            // Turn it off for now.
            // https://github.com/googleads/google-ads-dotnet/issues/59
            Environment.SetEnvironmentVariable("GRPC_DNS_RESOLVER", "native");

            return CachedChannelFactory.GetChannel(config);
        }

        /// <summary>
        /// Creates the specified service.
        /// </summary>
        /// <typeparam name="TService">The service type.</typeparam>
        /// <typeparam name="TServiceSetting">The service setting type.</typeparam>
        /// <param name="callInvoker">The call invoker for service.</param>
        /// <param name="serviceSettings">The service settings.</param>
        /// <param name="serviceTemplate">The service template.</param>
        /// <returns>The newly created service instance.</returns>
        private TService Create<TService, TServiceSetting>(
            ServiceTemplate<TService, TServiceSetting> serviceTemplate, CallInvoker callInvoker,
            ServiceSettingsBase serviceSettings)
            where TService : GoogleAdsServiceClientBase
            where TServiceSetting : ServiceSettingsBase, new()
        {
            return (TService) serviceTemplate.CreateService(serviceTemplate.ServiceTypeName,
                callInvoker, serviceSettings);
        }
    }
}

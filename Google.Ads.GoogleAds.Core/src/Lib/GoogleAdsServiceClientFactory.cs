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

using Google.Ads.Gax.Lib;
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Interceptors;
using Google.Ads.Gax.Profiling;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System;

namespace Google.Ads.GoogleAds.Lib
{
    /// <summary>
    /// Factory class for various Google Ads services.
    /// </summary>
    internal class GoogleAdsServiceClientFactory : AdsServiceClientFactory
    {
        /// <summary>
        /// The channel factory.
        /// </summary>
        private CachedChannelFactory channelFactory = new CachedChannelFactory();

        /// <summary>
        /// Gets an instance of the specified service.
        /// </summary>
        /// <param name="serviceTemplate">The service template.</param>
        /// <param name="config">The configuration.</param>
        /// <returns>A service instance.</returns>
        internal TService GetService<TService, TServiceSetting>(
            ServiceTemplate<TService, TServiceSetting, GoogleAdsConfig> serviceTemplate,
            GoogleAdsConfig config)
                where TServiceSetting : ServiceSettingsBase, new()
                where TService : GoogleAdsServiceClientBase
        {
            ChannelBase channel = CreateChannel(config);
            CallInvoker interceptedInvoker = channel
                .Intercept(new GoogleAdsGrpcInterceptor());

            CallInvoker callInvoker = config.EnableProfiling ?
                new ProfilingCallInvoker(interceptedInvoker, config) : interceptedInvoker;

            // Build a service context to bind the service, configuration and CallSettings.
            GoogleAdsServiceContext serviceContext = new GoogleAdsServiceContext();

            // Build the call settings.
            CallSettings callSettings = CreateCallSettings<TServiceSetting>(config,
                serviceContext);
            serviceContext.CallSettings = callSettings;

            // Create the service settings.
            TServiceSetting serviceSettings =
                CreateServiceSettings<TServiceSetting, GoogleAdsConfig>(serviceContext);
            serviceSettings.VersionHeaderBuilder.AppendAssemblyVersion("gccl", this.GetType());
            serviceSettings.VersionHeaderBuilder.AppendAssemblyVersion("pb",
                typeof(IMessage));

            // Create the service.
            TService service = Create(serviceTemplate, callInvoker, serviceSettings);
            serviceContext.Service = service;
            service.ServiceContext = serviceContext;
            service.ServiceContext.Channel = channel;
            return service;
        }

        /// <summary>
        /// Creates the call settings.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="serviceContext">The service context.</param>
        /// <returns>The call settings.</returns>
        private CallSettings CreateCallSettings<TServiceSetting>(GoogleAdsConfig config,
            GoogleAdsServiceContext serviceContext)
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
                    AdsResponseMetadata responseMetadata = new AdsResponseMetadata(metadata);
                    serviceContext.OnResponseMetadataReceived(responseMetadata);
                });

            if (!string.IsNullOrEmpty(config.LoginCustomerId))
            {
                callSettings = callSettings.WithHeader(MetadataKeyNames.LoginCustomerId,
                    config.LoginCustomerId);
            }

            if (!string.IsNullOrEmpty(config.LinkedCustomerId))
            {
                callSettings = callSettings.WithHeader(MetadataKeyNames.LinkedCustomerId,
                    config.LinkedCustomerId);
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
        private ChannelBase CreateChannel(GoogleAdsConfig config)
        {
            return channelFactory.GetChannel(config, config.ServerUrl);
        }
    }
}

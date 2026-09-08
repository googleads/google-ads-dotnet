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
using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Interceptors;
using Google.Ads.Gax.Profiling;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Google.Api.Gax.Grpc.Rest;
using Google.Protobuf;
using Grpc.Auth;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Reflection;

namespace Google.Ads.GoogleAds.Lib
{
    /// <summary>
    /// Factory class for various Google Ads services.
    /// </summary>
    internal class GoogleAdsServiceClientFactory : AdsServiceClientFactory
    {
        /// <summary>
        /// The custom interceptors.
        /// </summary>
        private List<Interceptor> userInterceptors = new List<Interceptor>();

        /// <summary>
        /// The channel factory.
        /// </summary>
        private CachedChannelFactory channelFactory = new CachedChannelFactory();

        internal GoogleAdsServiceClientFactory(): this(new List<Interceptor>()) {
        }

        internal GoogleAdsServiceClientFactory(List<Interceptor> userInterceptors)
        {
            this.userInterceptors = userInterceptors;
        }

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

            foreach (Interceptor customInterceptor in userInterceptors)
            {
                interceptedInvoker = interceptedInvoker.Intercept(customInterceptor);
            }

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

            // Create the service.
            TService service;
            // Determine whether the service needs a RestCallInvoker using reflection.
            MethodInfo createWithRestMethod = typeof(TService).GetMethod(
                "Create",
                BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public,
                null,
                new System.Type[] { typeof(CallInvoker), typeof(CallInvoker), typeof(TServiceSetting), typeof(Microsoft.Extensions.Logging.ILogger) },
                null
            ) ?? typeof(TService).GetMethod(
                "Create",
                BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public,
                null,
                new System.Type[] { typeof(CallInvoker), typeof(CallInvoker), typeof(TServiceSetting) },
                null
            );

            if (createWithRestMethod != null)
            {
                CallInvoker restCallInvoker = CreateRestCallInvoker(config, typeof(TService));
                object[] args = createWithRestMethod.GetParameters().Length == 4
                    ? new object[] { callInvoker, restCallInvoker, serviceSettings, null }
                    : new object[] { callInvoker, restCallInvoker, serviceSettings };
                service = (TService) createWithRestMethod.Invoke(null, args);
            }
            else
            {
                service = Create(serviceTemplate, callInvoker, serviceSettings);
            }

            serviceContext.Service = service;
            service.ServiceContext = serviceContext;
            service.ServiceContext.Channel = channel;
            return service;
        }

        /// <summary>
        /// Creates a REST call invoker for services requiring REST transport.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="serviceType">The service type.</param>
        /// <returns>The REST call invoker.</returns>
        private CallInvoker CreateRestCallInvoker(GoogleAdsConfig config, System.Type serviceType)
        {
            PropertyInfo serviceMetadataProp = serviceType.GetProperty("ServiceMetadata",
                BindingFlags.Public | BindingFlags.Static);
            if (serviceMetadataProp == null)
            {
                return null;
            }

            ServiceMetadata serviceMetadata = (ServiceMetadata) serviceMetadataProp.GetValue(null);
            if (serviceMetadata == null)
            {
                return null;
            }

            ServiceMetadata restMetadata = new ServiceMetadata(
                serviceMetadata.ServiceDescriptor,
                serviceMetadata.DefaultEndpoint,
                serviceMetadata.DefaultScopes,
                true,
                ApiTransports.Rest,
                serviceMetadata.ApiMetadata
            );

            ChannelCredentials credentials;
            if (config.AuthorizationMethod == AuthorizationMethod.Insecure || config.Credentials == null)
            {
                credentials = ChannelCredentials.Insecure;
            }
            else
            {
                credentials = GoogleGrpcCredentials.ToChannelCredentials(config.Credentials);
            }

            Uri uri = new Uri(config.ServerUrl);
            string endpoint = $"{uri.Host}:{uri.Port}";

            GrpcChannelOptions options = GrpcChannelOptions.Empty;
            if (config.Proxy != null)
            {
                options = options.WithCustomOption("grpc.http_proxy", config.Proxy.Address.ToString());
            }

            MethodInfo createChannelMethod = typeof(GrpcAdapter).GetMethod(
                "CreateChannel",
                BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance
            );

            ChannelBase restChannel = (ChannelBase) createChannelMethod.Invoke(
                RestGrpcAdapter.Default,
                new object[] { restMetadata, endpoint, credentials, options }
            );

            return restChannel.CreateCallInvoker();
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
            if (!config.UseCloudOrgForApiAccess)
            {
                callSettings = callSettings.WithHeader(MetadataKeyNames.DeveloperToken,
                    config.DeveloperToken);
            }

            callSettings = callSettings.WithResponseMetadataHandler(delegate (Metadata metadata)
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

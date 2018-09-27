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
using Google.Ads.GoogleAds.Logging;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using Grpc.Auth;
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
        /// The minimum backoff delay in milliseconds.
        /// </summary>
        private const int MINIMUM_BACKOFF_DELAY = 30000;

        /// <summary>
        /// The maximum backoff delay in milliseconds.
        /// </summary>
        private const int MAXIMUM_BACKOFF_DELAY = 60000;

        /// <summary>
        /// The backoff delay multiplier.
        /// </summary>
        private const double BACKOFF_DELAY_MULTIPLIER = 1.2;

        /// <summary>
        /// The backoff settings for retryable errors.
        /// </summary>
        private static readonly BackoffSettings backoffSettings = new BackoffSettings(
            TimeSpan.FromMilliseconds(MINIMUM_BACKOFF_DELAY),
            TimeSpan.FromMilliseconds(MAXIMUM_BACKOFF_DELAY),
            BACKOFF_DELAY_MULTIPLIER
        );

        /// <summary>
        /// Default set of exceptions to be retried.
        /// </summary>
        private static readonly Predicate<RpcException> retryFilter =
            RetrySettings.FilterForStatusCodes(StatusCode.DeadlineExceeded,
                StatusCode.Unavailable);

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
            CallInvoker callInvoker = channel.Intercept(
                LoggingInterceptor.GetInstance(config));

            GoogleAdsServiceContext serviceContext = CreateServiceContext(config);
            TServiceSetting serviceSettings = CreateServiceSettings<TServiceSetting>(
                serviceContext);
            TService service = Create<TService, TServiceSetting>(
                callInvoker, serviceSettings);
            serviceContext.Service = service;
            service.ServiceContext = serviceContext;
            return service;
        }

        /// <summary>
        /// Creates a service context that binds the service, callsettings and the client.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns>The service context.</returns>
        private GoogleAdsServiceContext CreateServiceContext(GoogleAdsConfig config)
        {
            GoogleAdsServiceContext serviceContext = new GoogleAdsServiceContext();
            CallSettings callSettings = CallSettings.FromCallTiming(
                CallTiming.FromRetry(new RetrySettings(
                    retryBackoff: backoffSettings,
                    timeoutBackoff: backoffSettings,
                    totalExpiration: Expiration.FromTimeout(TimeSpan.FromMilliseconds(
                        config.Timeout)),
                    retryFilter: retryFilter
                )))
                .WithHeader(GoogleAdsConfig.DEVELOPER_TOKEN_KEYNAME, config.DeveloperToken)
                .WithResponseMetadataHandler(delegate (Metadata metadata)
                {
                    GoogleAdsResponseMetadata responseMetadata = new GoogleAdsResponseMetadata(metadata);
                    serviceContext.OnResponseMetadataReceived(responseMetadata);
                });
            serviceContext.CallSettings = callSettings;
            return serviceContext;
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

            // Service settings have a client-specific callsetting, and
            // one callsetting per method. Since these are all kept separate
            // and not merged, we will instead set each of them using reflection.
            PropertyInfo[] callSettingProperties = serviceSettings.GetType()
                .GetProperties(BindingFlags.Public | BindingFlags.Instance)
                .Where(delegate (PropertyInfo x)
                {
                    return x.PropertyType == typeof(CallSettings) && x.Name != "CallSettings";
                }
            ).ToArray();

            foreach (PropertyInfo pi in callSettingProperties)
            {
                pi.SetValue(serviceSettings, serviceContext.CallSettings);
            }
            return serviceSettings;
        }

        /// <summary>
        /// Creates the channel for the new service, and sets the proxy server.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns>The new channel.</returns>
        private Channel CreateChannel(GoogleAdsConfig config)
        {
            ChannelCredentials channelCredentials =
                GoogleGrpcCredentials.ToChannelCredentials(config.Credentials);

            if (config.Proxy == null)
            {
                Environment.SetEnvironmentVariable("http_proxy", null);
            }
            else
            {
                Environment.SetEnvironmentVariable("http_proxy", config.Proxy.Address.ToString());
            }

            Uri uri = new Uri(config.ServerUrl);
            return new Channel(uri.Host, uri.Port, channelCredentials, null);
        }

        /// <summary>
        /// Creates the specified service.
        /// </summary>
        /// <typeparam name="TService">The service type.</typeparam>
        /// <typeparam name="TServiceSetting">The service setting type.</typeparam>
        /// <param name="callInvoker">The call invoker for service.</param>
        /// <param name="serviceSettings">The service settings.</param>
        /// <returns>The newly created service instance.</returns>
        private TService Create<TService, TServiceSetting>(CallInvoker callInvoker,
            TServiceSetting serviceSettings)
            where TServiceSetting : ServiceSettingsBase, new()
        {
            MethodInfo methodInfo = typeof(TService).GetMethod(
                "Create",
                BindingFlags.Static | BindingFlags.Public,
                null,
                new System.Type[] { typeof(CallInvoker), typeof(TServiceSetting) },
                null
            );

            if (methodInfo != null)
            {
                return (TService) methodInfo.Invoke(
                    null, new object[] { callInvoker, serviceSettings });
            }
            else
            {
                return default(TService);
            }
        }
    }
}

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

using Grpc.Auth;
using Grpc.Core;

using System;
using System.Reflection;

namespace Google.Ads.GoogleAds.Lib {

  /// <summary>
  /// A client for creating Google Ads API services.
  /// </summary>
  public class GoogleAdsClient {

    /// <summary>
    /// The client configuration.
    /// </summary>
    public GoogleAdsConfig Config {
      get;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GoogleAdsClient"/> class.
    /// </summary>
    /// <remarks>This client uses the configuration values from App.config.</remarks>
    public GoogleAdsClient() : this(new GoogleAdsConfig()) {
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="GoogleAdsClient"/> class.
    /// </summary>
    /// <param name="config">The client configuration.</param>
    public GoogleAdsClient(GoogleAdsConfig config) {
      this.Config = config;
    }

    /// <summary>
    /// Gets an instance of the specified service.
    /// </summary>
    /// <param name="serviceTemplate">The service template.</param>
    /// <returns>A service instance.</returns>
    public TService GetService<TService, TServiceSetting>(
        ServiceTemplate<TService, TServiceSetting> serviceTemplate)
            where TServiceSetting : ServiceSettingsBase, new() {
      Channel channel = CreateChannel();

      TServiceSetting serviceSettings = new TServiceSetting() {
        CallSettings = Config.CallSettings
      };

      return Create<TService, TServiceSetting>(channel, serviceSettings);
    }

    /// <summary>
    /// Creates the channel for the new service.
    /// </summary>
    /// <returns>The new channel.</returns>
    private Channel CreateChannel() {
      ChannelCredentials channelCredentials =
          GoogleGrpcCredentials.ToChannelCredentials(Config.Credentials);

      // Set the proxy for grpc service.
      // TODO: Figure out if there's a channel-level proxy setting that grpc honors.
      if (Config.Proxy == null) {
        Environment.SetEnvironmentVariable("http_proxy", null);
      } else {
        Environment.SetEnvironmentVariable("http_proxy", Config.Proxy.Address.ToString());
      }

      Uri uri = new Uri(Config.ServerUrl);
      return new Channel(uri.Host, uri.Port, channelCredentials, null);
    }

    /// <summary>
    /// Creates the specified service.
    /// </summary>
    /// <typeparam name="TService">The service type.</typeparam>
    /// <typeparam name="TServiceSetting">The service setting type.</typeparam>
    /// <param name="channel">The channel for service.</param>
    /// <param name="serviceSettings">The service settings.</param>
    /// <returns>The newly created service instance.</returns>
    private TService Create<TService, TServiceSetting>(Channel channel,
        TServiceSetting serviceSettings)
        where TServiceSetting : ServiceSettingsBase, new() {
      MethodInfo methodInfo = typeof(TService).GetMethod(
          "Create",
          BindingFlags.Static | BindingFlags.Public,
          null,
          new System.Type[] { typeof(Channel), typeof(TServiceSetting) },
          null
      );

      if (methodInfo != null) {
        return (TService) methodInfo.Invoke(null, new object[] { channel, serviceSettings });
      } else {
        return default(TService);
      }
    }
  }
}

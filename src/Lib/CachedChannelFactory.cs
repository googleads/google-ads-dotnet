// Copyright 2019 Google LLC
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
using Grpc.Auth;
using Grpc.Core;
using System;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Lib
{
    /// <summary>
    /// A channel factory that uses internal caching when possible.
    /// </summary>
    internal class CachedChannelFactory
    {
        /// <summary>
        /// The cache to store existing channels.
        /// </summary>
        private static Dictionary<string, Channel> cache = new Dictionary<string, Channel>();


        /// <summary>
        /// Gets the channel for the specified configuration.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns>The channel.</returns>
        internal static Channel GetChannel(GoogleAdsConfig config)
        {
            Channel retval = null;

            // Channels with unique (credentials, Url) combination should be unique.
            string key = string.Join("~", new object[] {
                config.OAuth2Mode,
                config.OAuth2ClientId,
                config.OAuth2ClientSecret,
                config.OAuth2RefreshToken,
                config.OAuth2PrivateKey,
                config.OAuth2PrnEmail,
                config.ServerUrl
            });

            lock (cache)
            {
                if (cache.ContainsKey(key))
                {
                    retval = cache[key];
                    if (retval.State == ChannelState.Shutdown)
                    {
                        // If the channel is shut down, then remove it from cache.
                        lock (cache)
                        {
                            cache.Remove(key);
                            retval = null;
                        }
                    }
                }

                if (retval == null)
                {
                    // Create a new channel.
                    lock (cache)
                    {
                        retval = CreateChannel(config);
                        cache[key] = retval;
                    }
                }
            }

            return retval;
        }

        /// <summary>
        /// Creates the channel.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <returns>The channel.</returns>
        private static Channel CreateChannel(GoogleAdsConfig config)
        {
            ChannelCredentials channelCredentials =
                GoogleGrpcCredentials.ToChannelCredentials(config.Credentials);
            Uri uri = new Uri(config.ServerUrl);
            return new Channel(uri.Host, uri.Port, channelCredentials);
        }
    }
}

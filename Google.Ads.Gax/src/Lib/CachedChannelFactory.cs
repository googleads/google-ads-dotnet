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

using Google.Ads.Gax.Config;
using Grpc.Core;
using System.Collections.Generic;

namespace Google.Ads.Gax.Lib
{
    /// <summary>
    /// A channel factory that uses internal caching when possible.
    /// </summary>
    internal class CachedChannelFactory
    {
        /// <summary>
        /// The cache to store existing channels.
        /// </summary>
        private static Dictionary<string, AdsChannel> cache = new Dictionary<string, AdsChannel>();

        /// <summary>
        /// Gets the channel for the specified configuration.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="serverUrl">The server URL.</param>
        /// <returns>The channel.</returns>
        internal ChannelBase GetChannel(AdsConfig config, string serverUrl)
        {
            AdsChannel retval = null;

            if (!config.UseChannelCache)
            {
                return new AdsChannel(config, serverUrl);
            }

            // Channels with unique (credentials, Url) combination should be unique.
            string key = string.Join("~", new object[] {
                config.OAuth2Mode,
                config.OAuth2ClientId,
                config.OAuth2ClientSecret,
                config.OAuth2RefreshToken,
                config.OAuth2PrivateKey,
                config.OAuth2PrnEmail,
                serverUrl
            });

            lock (cache)
            {
                if (cache.ContainsKey(key))
                {
                    retval = cache[key];
                    if (retval.IsDisposed())
                    {
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
                        retval = new AdsChannel(config, serverUrl);
                        cache[key] = retval;
                    }
                }
            }

            return retval;
        }
    }
}
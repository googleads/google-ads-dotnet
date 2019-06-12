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
        /// The gRPC setting name for maximum message length in bytes that can be received.
        /// </summary>
        private const string GRPC_MAX_RECEIVE_MESSAGE_LENGTH_IN_BYTES_SETTING_NAME =
            "grpc.max_receive_message_length";

        /// <summary>
        /// The maximum message length in bytes that the client library can receive (64 MB).
        /// </summary>
        private const long MAX_RECEIVE_MESSAGE_LENGTH_IN_BYTES = 64 * 1024 * 1024;

        /// <summary>
        /// The gRPC setting name for maximum metadata size in bytes that can be handled.
        /// </summary>
        private const string GRPC_MAX_METADATA_SIZE_IN_BYTES_SETTING_NAME =
            "grpc.max_metadata_size";

        /// <summary>
        /// The maximum metadata size in bytes that the client library can receive (16 MB).
        /// </summary>
        private const long MAX_METADATA_SIZE_IN_BYTES = 16 * 1024 * 1024;

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
            return new Channel(uri.Host, uri.Port, channelCredentials,
                new List<ChannelOption>()
                {
                    new ChannelOption(GRPC_MAX_RECEIVE_MESSAGE_LENGTH_IN_BYTES_SETTING_NAME,
                        MAX_RECEIVE_MESSAGE_LENGTH_IN_BYTES.ToString()),
                    new ChannelOption(GRPC_MAX_METADATA_SIZE_IN_BYTES_SETTING_NAME,
                        MAX_METADATA_SIZE_IN_BYTES.ToString()),
                }
            );
        }
    }
}

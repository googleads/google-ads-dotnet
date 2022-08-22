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
using Grpc.Auth;
using Grpc.Core;
using Grpc.Net.Client;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace Google.Ads.Gax.Lib
{
    /// <summary>
    /// A Grpc channel that wraps <code>Google.Api.Core</code> and <code>Grpc.Net.Client</code>
    /// implementations.
    /// </summary>
    public class AdsChannel : ChannelBase, IDisposable
    {
        private ChannelBase channel;

        /// <summary>
        /// Keeps track of whether this object is disposed.
        /// </summary>
        private bool disposed;

        /// <summary>
        /// A variable to use for locks when disposing this object.
        /// </summary>
        private readonly object disposeLock = new object();

        /// <summary>
        /// The gRPC setting name for maximum message length in bytes that can be received.
        /// </summary>
        private const string GRPC_MAX_RECEIVE_MESSAGE_LENGTH_IN_BYTES_SETTING_NAME =
            "grpc.max_receive_message_length";

        /// <summary>
        /// The gRPC setting name for maximum metadata size in bytes that can be handled.
        /// </summary>
        private const string GRPC_MAX_METADATA_SIZE_IN_BYTES_SETTING_NAME =
            "grpc.max_metadata_size";

        /// <summary>
        /// The gRPC setting name for HTTP proxy.
        /// </summary>
        private const string GRPC_HTTP_PROXY_SETTING_NAME = "grpc.http_proxy";

        private AdsConfig config;

        private static bool GrpcNetClientSupported
        {
            get;
            set;
        }

        static AdsChannel()
        {
            GrpcNetClientSupported = DetectGrpcNetClientTransport();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdsChannel"/> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        /// <param name="url">Target of the channel.</param>
        public AdsChannel(AdsConfig config, string url) : base(url)
        {
            this.config = config;
            this.channel = CreateChannel(url);
        }

        /// <summary>
        /// Create a new <see cref="T:Grpc.Core.CallInvoker" /> for the channel.
        /// </summary>
        /// <returns>
        /// A new <see cref="T:Grpc.Core.CallInvoker" />.
        /// </returns>
        public override CallInvoker CreateCallInvoker()
        {
            return channel.CreateCallInvoker();
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> to release both managed and unmanaged resources;
        /// <c>false</c> to release only unmanaged resources.</param>
        /// <remarks>We only have unmanaged resources to dispose, so we don't use
        /// <paramref name="disposing"/>.</remarks>
        protected virtual void Dispose(bool disposing)
        {
            // First, mark the object as disposed, so other calls don't have to wait.
            lock (disposeLock)
            {
                if (disposed)
                {
                    return;
                }

                disposed = true;
            }

            if (channel is Channel)
            {
                if ((channel as Channel).State != ChannelState.Shutdown)
                {
                    var shutdownTask = channel.ShutdownAsync();
                    // Offload waiting for shutdown to finish to another thread.
                    Task.Run(delegate ()
                    {
                        try
                        {
                            shutdownTask.Wait();
                        }
                        catch (Exception)
                        {
                            // Nothing to do, except to log this error.
                            // TODO(Anash): Add logging once
                            // https://github.com/googleads/google-ads-dotnet/issues/381 is fixed.
                        }
                    });
                }
            }
            else if (channel is GrpcChannel)
            {
                (channel as GrpcChannel).Dispose();
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or resetting
        /// unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            // Dispose of unmanaged resources.
            Dispose(true);
            // Suppress finalization.
            GC.SuppressFinalize(this);
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="AdsChannel"/> class.
        /// </summary>
        ~AdsChannel()
        {
            Dispose(false);
        }

        internal bool IsDisposed()
        {
            if (disposed)
            {
                return true;
            }
            return (channel is Channel && (channel as Channel).State == ChannelState.Shutdown);
        }

        /// <summary>
        /// Detects if <code>Grpc.Net.Client</code> transport is supported.
        /// </summary>
        /// <returns><code>True</code> if the <code>Grpc.Net.Client</code> is supported,
        /// <code>false</code> otherwise.</returns>
        private static bool DetectGrpcNetClientTransport()
        {
            try
            {
                GrpcChannel.ForAddress("https://ignored.com");
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Creates the channel.
        /// </summary>
        /// <param name="url">Target of the channel.</param>
        /// <returns>The newly created channel.</returns>
        private ChannelBase CreateChannel(string url)
        {
            ChannelCredentials channelCredentials;

            if (config.AuthorizationMethod == AuthorizationMethod.Insecure)
            {
                channelCredentials = ChannelCredentials.Insecure;
            }
            else // if config.AuthenticationMode == AuthenticationMode.OAUTH)
            {
                channelCredentials =
                    GoogleGrpcCredentials.ToChannelCredentials(config.Credentials);
            }

            Uri uri = new Uri(url);
            if (config.UseGrpcCore || !GrpcNetClientSupported)
            {
                return CreateGrpcCoreChannel(uri, channelCredentials);
            }

            return CreateGrpcNetClientChannel(uri, channelCredentials);
        }

        /// <summary>
        /// Creates the channel using Grpc.Net.Client library.
        /// </summary>
        /// <param name="uri">The chanel URI.</param>
        /// <param name="credentials">The channel credentials.</param>
        /// <returns>The newly created channel.</returns>
        private ChannelBase CreateGrpcNetClientChannel(Uri uri, ChannelCredentials credentials)
        {
            if (!GrpcNetClientSupported)
            {
                throw new PlatformNotSupportedException(ErrorMessages.GrpcNetClientNotSupported);
            }
            GrpcChannelOptions options = new GrpcChannelOptions();
            options.MaxReceiveMessageSize = config.MaxReceiveMessageSizeInBytes;
            options.Credentials = credentials;

            // Since there are no settings on GrpcChannelOptions to set the proxy and trailing
            // metadata size, we write our own custom logic.
            // TODO(Anash): Use GrpcChannelOptions in the future if
            // https://github.com/grpc/grpc-dotnet/issues/1842 is fixed.

            // Note: https://github.com/grpc/grpc-dotnet/issues/1842 suggests using
            // SocketsHttpHandler directly, but
            // https://docs.microsoft.com/en-us/dotnet/api/system.net.http.httpclienthandler?view=netcore-3.1#httpclienthandler-in-net-core
            // says that HttpClientHandler will internally use SocketsHttpHandler on newer
            // platforms. So we will use HttpClientHandler directly.
            HttpClientHandler httpClientHandler = new HttpClientHandler();
            if (config.Proxy != null)
            {
                httpClientHandler.Proxy = config.Proxy;
            }
            // config.MaxMetadataSizeInBytes is in bytes, but MaxResponseHeadersLength is in KB.
            // Note: Since we are dividing by 1024, we are not affected by
            // https://github.com/dotnet/runtime/issues/73848
            httpClientHandler.MaxResponseHeadersLength = config.MaxMetadataSizeInBytes / 1024;
            options.HttpHandler = httpClientHandler;

            return GrpcChannel.ForAddress(uri, options);
        }

        /// <summary>
        /// Creates the channel using Grpc.Core library.
        /// </summary>
        /// <param name="uri">The chanel URI.</param>
        /// <param name="credentials">The channel credentials.</param>
        /// <returns>The newly created channel.</returns>
        private ChannelBase CreateGrpcCoreChannel(Uri uri, ChannelCredentials credentials)
        {
            // GRPC uses c-ares DNS resolver, which doesn't seem to work on some Windows machines.
            // Turn it off for now.
            // https://github.com/googleads/google-ads-dotnet/issues/59
            Environment.SetEnvironmentVariable("GRPC_DNS_RESOLVER", "native");

            List<ChannelOption> options = new List<ChannelOption>()
            {
                new ChannelOption(GRPC_MAX_RECEIVE_MESSAGE_LENGTH_IN_BYTES_SETTING_NAME,
                    config.MaxReceiveMessageSizeInBytes),
                new ChannelOption(GRPC_MAX_METADATA_SIZE_IN_BYTES_SETTING_NAME,
                    config.MaxMetadataSizeInBytes),
            };

            if (config.Proxy != null)
            {
                options.Add(new ChannelOption(GRPC_HTTP_PROXY_SETTING_NAME,
                    config.Proxy.Address.ToString()));
            }

            return new Channel(uri.Host, uri.Port, credentials, options);
        }
    }
}
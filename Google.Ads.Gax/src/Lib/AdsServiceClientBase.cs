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
using System;

namespace Google.Ads.Gax.Lib
{
    /// <summary>
    /// A base class for all Ads services.
    /// </summary>
    public class AdsServiceClientBase<T> : IDisposable where T : AdsConfig
    {
        /// <summary>
        /// Keeps track of whether this object is disposed.
        /// </summary>
        private bool disposed;

        /// <summary>
        /// A variable to use for locks when disposing this object.
        /// </summary>
        private readonly object disposeLock = new object();

        /// <summary>
        /// Gets the service context.
        /// </summary>
        public AdsServiceContext<T> ServiceContext
        {
            get;
            internal set;
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

            // Now do the disposal.

            var context = this.ServiceContext;
            if (context != null)
            {
                AdsChannel channel = context.Channel as AdsChannel;
                var client = context.Client;

                if (client != null && channel != null && client.Config.UseChannelCache == false)
                {
                    channel.Dispose();
                    context.Channel = null;
                }
            }
        }

        /// <summary>
        /// Finalizes an instance of the <see cref="AdsServiceClientBase{T}"/> class.
        /// </summary>
        ~AdsServiceClientBase()
        {
            Dispose(false);
        }
    }
}
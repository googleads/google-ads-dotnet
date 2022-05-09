// Copyright 2020 Google LLC
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

using Grpc.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Tests
{
    /// <summary>
    /// An async stream reader for testing purposes.
    /// </summary>
    /// <typeparam name="T">The type of objects in the stream.</typeparam>
    /// <seealso cref="Grpc.Core.IAsyncStreamReader{T}" />
    internal class TestStreamReader<T> : IAsyncStreamReader<T> where T : class
    {
        /// <summary>
        /// The items in the stream.
        /// </summary>
        private IEnumerator<T> items;

        /// <summary>
        /// The RPC exception to be thrown by the test stream.
        /// </summary>
        private RpcException rpcException;

        /// <summary>
        /// Initializes a new instance of the <see cref="TestStreamReader{T}"/> class.
        /// </summary>
        /// <param name="items">The items in the stream.</param>
        /// <param name="rpcException">The RPC exception to be thrown.</param>
        internal TestStreamReader(T[] items, RpcException rpcException)
        {
            this.items = items.ToList().GetEnumerator();
            this.rpcException = rpcException;
        }

        /// <summary>
        /// Gets the current item.
        /// </summary>
        public T Current
        {
            get
            {
                return items.Current;
            }
        }

        /// <summary>
        /// Utility method that creates a task from an exception.
        /// </summary>
        /// <typeparam name="T">The task return type.</typeparam>
        /// <param name="ex">The exception to throw.</param>
        /// <returns>The task.</returns>
        /// <remarks>Task.FromException is not available in .NET 452.</remarks>
        internal static Task<TResult> FromException<TResult>(Exception ex)
        {
            Task<TResult> responseTask = new Task<TResult>(() =>
            {
                throw ex;
            });
            responseTask.RunSynchronously();
            return responseTask;
        }

        /// <summary>
        /// Moves the next item to the current position.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>True, if the item could be moved, false otherwise.</returns>
        public Task<bool> MoveNext(CancellationToken cancellationToken)
        {
            if (this.rpcException != null)
            {
                return FromException<bool>(rpcException);
            }
            else
            {
                return Task.FromResult(items.MoveNext());
            }
        }

        public void Dispose()
        {
        }
    }
}

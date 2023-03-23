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

using Google.Ads.Gax.Util;
using Grpc.Core;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Google.Ads.Gax.Interceptors
{
    /// <summary>
    /// An <see cref="IAsyncStreamReader{TResponse}" /> class for intecepting streaming
    /// requests.
    /// </summary>
    /// <typeparam name="TResponse">The type of the response.</typeparam>
    /// <seealso cref="Grpc.Core.IAsyncStreamReader{TResponse}" />
    internal class StreamingRpcInterceptor<TResponse> : IAsyncStreamReader<TResponse>
        where TResponse : class
    {
        /// <summary>
        /// The stream reader that this instance wraps over.
        /// </summary>
        private readonly IAsyncStreamReader<TResponse> innerStreamReader = null;

        /// <summary>
        /// The callback to be invoked when MoveNext() is called.
        /// </summary>
        private Action<TResponse, AggregateException> onMoveNext = null;

        /// <summary>
        /// Initializes a new instance of the <see cref="StreamingRpcInterceptor{TResponse}"/> class.
        /// </summary>
        /// <param name="streamReader">The stream reader to wrap over..</param>
        /// <param name="moveNextCallback">The callback to be invoked when MoveNext() is
        /// called.</param>
        internal StreamingRpcInterceptor(IAsyncStreamReader<TResponse> streamReader,
            Action<TResponse, AggregateException> moveNextCallback)
        {
            this.innerStreamReader = streamReader;
            this.onMoveNext = moveNextCallback;
        }

        /// <summary>
        /// Gets the current item in the stream.
        /// </summary>
        public TResponse Current
        {
            get
            {
                return innerStreamReader.Current;
            }
        }

        /// <summary>
        /// Moves to the next item in the stream.
        /// </summary>
        /// <param name="cancellationToken">The cancellation token.</param>
        /// <returns>A task that can be waited upon to complete this operation.</returns>
        public async Task<bool> MoveNext(CancellationToken cancellationToken)
        {
            AggregateException aggregateException = null;
            Task<bool> task = innerStreamReader.MoveNext(cancellationToken);

            try
            {
                // Wait for the next result to be retrieved.
                await task.ConfigureAwait(false);
            }
            catch (AggregateException e)
            {
                // If an exception is caught, we catch it, for parsing later.
                aggregateException = e;
            }
            catch (RpcException e)
            {
                aggregateException = new AggregateException(e);
            }
            finally
            {
                if (onMoveNext != null)
                {
                    if (task.IsFaulted)
                    {
                        // The task has already faulted, so there's no result. Pass the default
                        // value of TResponse and the caught exception to the callback.
                        onMoveNext(default, aggregateException);
                    }
                    else
                    {
                        // There is no exception.
                        if (task.Result)
                        {
                            // We have some results, so log it.
                            onMoveNext(this.Current, null);
                        }
                        else
                        {
                            // We have an empty response, so invoke the callback with null response
                            // to complete logging.
                            onMoveNext(null, null);
                        }
                    }
                }
            }

            if (task.IsFaulted)
            {
                // Parse the exception thrown by the task and throw it.
                throw ExceptionUtilities.ParseTaskException<TResponse>(aggregateException);
            }
            else
            {
                // Pass on the result we retrieved.
                return task.Result;
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        public void Dispose()
        {
        }
    }
}

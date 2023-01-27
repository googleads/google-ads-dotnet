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

using Google.Ads.Gax.Lib;
using Google.Ads.Gax.Util;
using Google.Apis.Auth.OAuth2.Responses;
using Grpc.Core;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Google.Ads.Gax.Interceptors
{
    /// <summary>
    /// This class provides functionality to intercept tasks and callbacks, and performs custom
    /// exception handling.
    /// </summary>
    internal class UnaryRpcInterceptor
    {
        /// <summary>
        /// Intercepts an async unary call adds a custom exception handler.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="call">The async unary call to intercept.</param>
        /// <param name="responseCallback">Response callback</param>
        /// <returns>The async unary call with custom exception handling for
        /// <see cref="RpcException"/>.</returns>
        internal static AsyncUnaryCall<TResponse> Intercept<TResponse>(
            AsyncUnaryCall<TResponse> call, Action<Task<TResponse>> responseCallback)
        {
            return new AsyncUnaryCall<TResponse>(
                Intercept<TResponse, TResponse>(call.ResponseAsync, responseCallback),
                Intercept<Metadata, TResponse>(call.ResponseHeadersAsync, null),
                Intercept<Status, TResponse>(call.GetStatus),
                Intercept<Metadata, TResponse>(call.GetTrailers),
                Intercept<TResponse>(call.Dispose));
        }

        /// <summary>
        /// Intercepts a task and adds a custom exception handler.
        /// </summary>
        /// <typeparam name="T">The task result type</typeparam>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="task">The task to be intercepted.</param>
        /// <param name="callback">The callback to be invoked after the intercepted task
        /// is completed.</param>
        /// <returns>The intercepted task with custom exception handling for
        /// <see cref="RpcException"/>.</returns>
        /// <exception cref="AdsBaseException">Thrown if the intercepted
        /// <see cref="RpcException"/> can be parsed.</exception>
        internal static async Task<T> Intercept<T, TResponse>(Task<T> task,
            Action<Task<T>> callback)
        {
            try
            {
                return await task;
            }
            catch (RpcException e)
            {
                AdsBaseException parsedException =
                    ExceptionUtilities.ParseRpcException<TResponse>(e);
                if (parsedException != null)
                {
                    throw parsedException;
                }
                throw;
            }
            finally
            {
                if (callback != null)
                {
                    callback(task);
                }
            }
        }

        /// <summary>
        /// Intercepts a function delegate and adds a custom exception handler.
        /// </summary>
        /// <typeparam name="T">The return type of the function delegate.</typeparam>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="function">The function delegate to intercept.</param>
        /// <returns>The intercepted function delegate with custom exception handling for
        /// <see cref="RpcException"/></returns>
        internal static Func<T> Intercept<T, TResponse>(Func<T> function)
        {
            return new Func<T>(delegate ()
            {
                AdsBaseException parsedException;
                try
                {
                    return function();
                }
                catch (RpcException e) when ((parsedException =
                    ExceptionUtilities.ParseRpcException<TResponse>(e)) != null)
                {
                    throw parsedException;
                }
            });
        }

        /// <summary>
        /// Intercepts an action delegate and adds custom exception handling.
        /// </summary>
        /// <typeparam name="TResponse">The response type.</typeparam>
        /// <param name="action">The action delegate to intercept.</param>
        /// <returns>The intercepted action delegate, with custom exception handling for
        /// <see cref="RpcException"/></returns>
        internal static Action Intercept<TResponse>(Action action)
        {
            return new Action(delegate ()
            {
                AdsBaseException parsedException;
                try
                {
                    action();
                }
                catch (RpcException e) when ((parsedException =
                    ExceptionUtilities.ParseRpcException<TResponse>(e)) != null)
                {
                    throw parsedException;
                }
            });
        }
    }
}

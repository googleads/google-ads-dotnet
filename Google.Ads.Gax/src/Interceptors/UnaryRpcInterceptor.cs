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
        /// <returns>The async unary call with custom exception handling for
        /// <see cref="RpcException"/>.</returns>
        internal static AsyncUnaryCall<TResponse> Intercept<TResponse>(AsyncUnaryCall<TResponse> call)
        {
            return new AsyncUnaryCall<TResponse>(
                Intercept<TResponse, TResponse>(call.ResponseAsync),
                Intercept<Metadata, TResponse>(call.ResponseHeadersAsync),
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
        /// <returns>The intercepted task with custom exception handling for
        /// <see cref="RpcException"/>.</returns>
        /// <exception cref="AdsBaseException">Thrown if the intercepted
        /// <see cref="RpcException"/> can be parsed.</exception>
        internal static async Task<T> Intercept<T, TResponse>(Task<T> task)
        {
            AdsBaseException parsedException;
            try
            {
                return await task;
            }
            catch (RpcException e) when ((parsedException = ParseRpcException<TResponse>(e)) != null)
            {
                throw parsedException;
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
                catch (RpcException e) when ((parsedException = ParseRpcException<TResponse>(e)) != null)
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
                catch (RpcException e) when ((parsedException = ParseRpcException<TResponse>(e)) != null)
                {
                    throw parsedException;
                }
            });
        }

        /// <summary>
        /// Parses the task exception.
        /// </summary>
        /// <param name="e">The <see cref="AggregateException"/> to parse.</param>
        /// <returns>The parsed <see cref="AdsBaseException"/> if parsing is successful;
        /// The underlying <see cref="RpcException" /> if the exception cannot be parsed as a
        /// AdsBaseException.</returns>
        /// <remarks><code>AggregateException</code> is very close to a catch-all exception for
        /// Tasks. While all the situations that we know of involves this exception being thrown
        /// by an underlying <code>RpcException</code>, theoretically this method may return a
        /// null object, if the <code>AggregateException</code> is not caused by an
        /// <code>RpcException</code>. That would typically indicate an underlying issue with
        /// the code.</remarks>
        internal static RpcException ParseTaskException<TResponse>(AggregateException e)
        {
            RpcException rpcException = ExtractRpcException(e);
            AdsBaseException adsException = ParseRpcException<TResponse>(rpcException);
            return (adsException == null) ? rpcException : adsException;
        }

        /// <summary>
        /// Parses the RPC exception into a <see cref="AdsBaseException" />.
        /// </summary>
        /// <param name="rpcException">The RPC exception.</param>
        /// <returns>The parsed exception, or a null if the parsing cannot be done.</returns>
        internal static AdsBaseException ParseRpcException<TResponse>(RpcException rpcException)
        {
            if (rpcException == null)
            {
                return null;
            }

            System.Type exceptionType = FindAdsExceptionType<TResponse>(rpcException);

            if (exceptionType == null)
            {
                return null;
            }
            MethodInfo methodInfo = exceptionType.GetMethod("Create",
                BindingFlags.Public | BindingFlags.Static);
            if (methodInfo == null)
            {
                return null;
            }
            return methodInfo.Invoke(null, new object[] { rpcException })
                as AdsBaseException;
        }

        /// <summary>
        /// Finds the type of the ads exception that matches <paramref name="rpcException"/>.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="rpcException">The RPC exception.</param>
        private static System.Type FindAdsExceptionType<TResponse>(RpcException rpcException)
        {
            // We are trying to find a AdsBaseException in the assembly pointed to by
            // TResponse which has a matching FailureKey.

            Assembly myAssembly = typeof(TResponse).Assembly;
            return myAssembly.GetTypes().Where(delegate (System.Type type)
            {
                if (!type.IsSubclassOf(typeof(AdsBaseException)))
                {
                    return false;
                }
                string failureKey = type.GetProperty("FailureKey",
                    BindingFlags.Static | BindingFlags.Public | BindingFlags.FlattenHierarchy)
                    .GetValue(null).ToString();
                Metadata.Entry failureEntry = rpcException.Trailers.GetEntry(failureKey);
                if (failureEntry != null)
                {
                    return true;
                }
                return false;

            }).FirstOrDefault();
        }

        /// <summary>
        /// Extracts the RPC exception from an <see cref="AggregateException"/>.
        /// </summary>
        /// <param name="aggregateException">The aggregate exception.</param>
        /// <returns>the extracted <see cref="RpcException"/>, or null if an exception
        /// cannot be extracted.</returns>
        internal static RpcException ExtractRpcException(AggregateException aggregateException)
        {
            return aggregateException?.InnerExceptions?.FirstOrDefault(
                delegate (Exception innerException)
                {
                    return (innerException is RpcException);
                }
            ) as RpcException;
        }
    }
}

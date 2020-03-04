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

using Google.Ads.GoogleAds.Lib;
using Grpc.Core;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Interceptors
{
    /// <summary>
    /// This class provides functionality to intercept tasks and callbacks, and performs custom
    /// exception handling.
    /// </summary>
    internal class UnaryRpcInterceptor
    {
        private const string GOOGLE_ADS_EXCEPTION_NAMESPACE_TEMPLATE =
            "Google.Ads.GoogleAds.{0}.Errors.GoogleAdsException";

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
                Intercept(call.ResponseAsync), Intercept(call.ResponseHeadersAsync),
                    Intercept(call.GetStatus), Intercept(call.GetTrailers), Intercept(call.Dispose));
        }

        /// <summary>
        /// Intercepts a task and adds a custom exception handler.
        /// </summary>
        /// <typeparam name="T">The task result type</typeparam>
        /// <param name="task">The task to be intercepted.</param>
        /// <returns>The intercepted task with custom exception handling for
        /// <see cref="RpcException"/>.</returns>
        /// <exception cref="GoogleAdsBaseException">Thrown if the intercepted
        /// <see cref="RpcException"/> can be parsed.</exception>
        internal static async Task<T> Intercept<T>(Task<T> task)
        {
            GoogleAdsBaseException parsedException;
            try
            {
                return await task;
            }
            catch (RpcException e) when ((parsedException = ParseRpcException(e)) != null)
            {
                throw parsedException;
            }
        }

        /// <summary>
        /// Intercepts a function delegate and adds a custom exception handler.
        /// </summary>
        /// <typeparam name="T">The return type of the function delegate.</typeparam>
        /// <param name="function">The function delegate to intercept.</param>
        /// <returns>The intercepted function delegate with custom exception handling for
        /// <see cref="RpcException"/></returns>
        internal static Func<T> Intercept<T>(Func<T> function)
        {
            return new Func<T>(delegate ()
            {
                GoogleAdsBaseException parsedException;
                try
                {
                    return function();
                }
                catch (RpcException e) when ((parsedException = ParseRpcException(e)) != null)
                {
                    throw parsedException;
                }
            });
        }

        /// <summary>
        /// Intercepts an action delegate and adds custom exception handling.
        /// </summary>
        /// <param name="action">The action delegate to intercept.</param>
        /// <returns>The intercepted action delegate, with custom exception handling for
        /// <see cref="RpcException"/></returns>
        internal static Action Intercept(Action action)
        {
            return new Action(delegate ()
            {
                GoogleAdsBaseException parsedException;
                try
                {
                    action();
                }
                catch (RpcException e) when ((parsedException = ParseRpcException(e)) != null)
                {
                    throw parsedException;
                }
            });
        }

        /// <summary>
        /// Parses the task exception.
        /// </summary>
        /// <param name="e">The <see cref="AggregateException"/> to parse.</param>
        /// <returns>The parsed <see cref="GoogleAdsBaseException"/> if parsing is successful;
        /// The underlying <see cref="RpcException" /> if the exception cannot be parsed as a
        /// GoogleAdsException.</returns>
        /// <remarks><code>AggregateException</code> is very close to a catch-all exception for
        /// Tasks. While all the situations that we know of involves this exception being thrown
        /// by an underlying <code>RpcException</code>, theoretically this method may return a
        /// null object, if the <code>AggregateException</code> is not caused by an
        /// <code>RpcException</code>. That would typically indicate an underlying issue with
        /// the code.</remarks>
        internal static RpcException ParseTaskException(AggregateException e)
        {
            RpcException rpcException = ExtractRpcException(e);
            GoogleAdsBaseException googleAdsException = ParseRpcException(rpcException);
            return (googleAdsException == null) ? rpcException : googleAdsException;
        }

        /// <summary>
        /// Parses the RPC exception into a <see cref="GoogleAdsBaseException" />.
        /// </summary>
        /// <param name="rpcException">The RPC exception.</param>
        /// <returns>The parsed exception, or a null if the parsing cannot be done.</returns>
        internal static GoogleAdsBaseException ParseRpcException(RpcException rpcException)
        {
            if (rpcException == null)
            {
                return null;
            }

            string apiVersion = GetApiExceptionVersion(rpcException);
            if (string.IsNullOrEmpty(apiVersion))
            {
                return null;
            }
            System.Type exceptionType = GetApiExceptionType(apiVersion);
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
                as GoogleAdsBaseException;
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

        /// <summary>
        /// Gets the API exception version.
        /// </summary>
        /// <param name="rpcException">The RPC exception.</param>
        /// <returns>The version string.</returns>
        private static string GetApiExceptionVersion(RpcException rpcException)
        {
            foreach (Metadata.Entry entry in rpcException.Trailers)
            {
                if (entry.Key.EndsWith(".googleadsfailure-bin"))
                {
                    return entry.Key.Replace("google.ads.googleads.", "")
                        .Replace(".errors.googleadsfailure-bin", "").ToUpper();
                }
            }
            return null;
        }

        /// <summary>
        /// Gets the type of the API exception.
        /// </summary>
        /// <param name="version">The version.</param>
        /// <returns>The type of the exception.</returns>
        private static System.Type GetApiExceptionType(string version)
        {
            Assembly myAssembly = MethodBase.GetCurrentMethod().DeclaringType.Assembly;
            string googleAdsExceptionTypeName =
                string.Format(GOOGLE_ADS_EXCEPTION_NAMESPACE_TEMPLATE, version);
            return myAssembly.GetType(googleAdsExceptionTypeName);
        }
    }
}

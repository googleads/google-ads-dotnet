// Copyright 2023 Google LLC
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
using Google.Apis.Auth.OAuth2.Responses;
using Grpc.Core;
using System;
using System.Linq;
using System.Reflection;

namespace Google.Ads.Gax.Util
{
    /// <summary>
    /// Extensions to <see cref="RpcException"/> class to extract OAuth errors.
    /// </summary>
    public static class ExceptionUtilities
    {
        /// <summary>
        /// Parses the OAuth exceptions.
        /// </summary>
        /// <param name="e">The aggregate exception that wraps the rpc exception.</param>
        /// <returns>The parsed exception, or <code>null</code> if the exception cannot be parsed.
        /// </returns>
        internal static TokenResponseException ParseOAuthException(AggregateException e) =>
            ParseOAuthException(ExtractRpcException(e));

        /// <summary>
        /// Parses the OAuth exceptions.
        /// </summary>
        /// <param name="rpcException">The rpc exception</param>
        /// <returns>The parsed exception, or <code>null</code> if the exception cannot be parsed.
        /// </returns>
        internal static TokenResponseException ParseOAuthException(RpcException rpcException)
        {
            const string EXCEPTION_TYPE_PREFIX =
                "Google.Apis.Auth.OAuth2.Responses.TokenResponseException: ";
            const string ERROR_PREFIX = "Error:";
            const string DESC_PREFIX = "Description:";
            const string URI_PREFIX = "Uri:";

            if (rpcException == null)
            {
                return null;
            }
            if (!(rpcException.StatusCode == StatusCode.Internal ||
                rpcException.StatusCode == StatusCode.Unavailable))
            {
                return null;
            }
            // When the grpc layer serializes the inner exception into a string, it starts with
            // the full type of the exception. So if we can't find the full type name of
            // TokenResponseException in the message (index == -1), we won't try to parse
            // the OAuth exception.
            int prefixIndex = rpcException.Message.IndexOf(EXCEPTION_TYPE_PREFIX);
            if (prefixIndex == -1)
            {
                return null;
            }
            string messageToProcess = rpcException.Message.Substring(
                prefixIndex + EXCEPTION_TYPE_PREFIX.Length);
            string[] messageParts = messageToProcess.Split('\n');
            if (messageParts.Length >= 0)
            {
                string lineToParse = messageParts[0];
                string[] subParts = lineToParse.Split(',').Select(s => s.Trim()).ToArray();
                // TokenErrorResponse is serialized as
                // Error:\"{Error}\", Description:\"{ErrorDescription}\", Uri:\"{ErrorUri}\"
                string error = "";
                string description = "";
                string uri = "";

                foreach (string subPart in subParts)
                {
                    if (subPart.StartsWith(ERROR_PREFIX))
                    {
                        error = subPart.Substring(ERROR_PREFIX.Length).Trim('"');
                    }
                    else if (subPart.StartsWith(DESC_PREFIX))
                    {
                        description = subPart.Substring(DESC_PREFIX.Length).Trim('"');
                    }
                    else if (subPart.StartsWith(URI_PREFIX))
                    {
                        uri = subPart.Substring(URI_PREFIX.Length).Trim('"');
                    }
                }
                return new TokenResponseException(new TokenErrorResponse()
                {
                    Error = error,
                    ErrorDescription = description,
                    ErrorUri = uri
                });
            }
            return null;
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
        /// Extracts the RPC exception from an <see cref="AggregateException"/>.
        /// </summary>
        /// <param name="aggregateException">The aggregate exception.</param>
        /// <returns>the extracted <see cref="RpcException"/>, or null if an exception
        /// cannot be extracted.</returns>
        /// <remarks>The <code>AggregateException</code>We do not have a scenario where we can
        /// have more than one RpcException in a single API call. An RpcException is fatal for
        /// an API call, and the call logic fails and returns immediately to the caller.
        /// As a result, we've chosen to make this method return an RpcException and not a
        /// <code>List(RpcException).</code>
        /// </remarks>
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
        /// Inspect the <paramref name="rpcException"/> to find a potential type of Ads exception
        /// that the <code>rpcException</code> can be interpreted as.
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
    }
}
// Copyright 2018 Google LLC
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
using Google.Ads.GoogleAds.Util;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Logging
{
    /// <summary>
    /// Interceptor for logging requests and responses.
    /// </summary>
    internal class LoggingInterceptor : Interceptor
    {
        /// <summary>
        /// The singleton instance.
        /// </summary>
        private static LoggingInterceptor instance;

        /// <summary>
        /// The callback to be called when a new <see cref="LogEntry"/> is available.
        /// </summary>
        protected EventHandler<LogEntry> OnLogEventAvailable;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingInterceptor"/> class.
        /// </summary>
        /// <param name="config">The configuration.</param>
        protected LoggingInterceptor(GoogleAdsConfig config) : base()
        {
            this.Config = config;
            this.TraceWriter = new DefaultTraceWriter();
            OnLogEventAvailable += WriteLogEntry;
        }

        /// <summary>
        /// Gets an instance of the logging interceptor.
        /// </summary>
        /// <param name="config">The application configuration.</param>
        /// <returns>An instance of the logging interceptor.</returns>
        public static LoggingInterceptor GetInstance(GoogleAdsConfig config)
        {
            lock (typeof(LoggingInterceptor))
            {
                if (instance == null)
                {
                    instance = new LoggingInterceptor(config);
                }
            }
            return instance;
        }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        protected GoogleAdsConfig Config
        {
            get;
        }

        /// <summary>
        /// Gets the trace writer.
        /// </summary>
        public ITraceWriter TraceWriter
        {
            get;
            protected set;
        }

        /// <summary>
        /// Intercepts an asynchronous invocation of a simple remote call.
        /// </summary>
        /// <param name="request">The request message of the invocation.</param>
        /// <param name="context">The <see cref="ClientInterceptorContext{TRequest, TResponse}" />
        /// associated with the current invocation.</param>
        /// <param name="continuation">The callback that continues the invocation process.
        /// This can be invoked zero or more times by the interceptor.
        /// The interceptor can invoke the continuation passing the given
        /// request value and context arguments, or substitute them as it sees fit.</param>
        /// <returns>
        /// An instance of <see cref="AsyncUnaryCall{TResponse}" />
        /// representing an asynchronous unary invocation.
        /// The interceptor can simply return the return value of the
        /// continuation delegate passed to it intact, or construct its
        /// own substitute as it sees fit.
        /// </returns>
        public override AsyncUnaryCall<TResponse> AsyncUnaryCall<TRequest, TResponse>(
            TRequest request, ClientInterceptorContext<TRequest, TResponse> context,
            AsyncUnaryCallContinuation<TRequest, TResponse> continuation)
        {
            AsyncUnaryCall<TResponse> call = continuation(request, context);
            Task t = call.ResponseAsync.ContinueWith(
                delegate (Task<TResponse> oldTask)
            {
                // Generating log entry is expensive, so let's do that only if the log source
                // has been configured to do so.
                if (TraceUtilities.ShouldGenerateRequestLogs())
                {
                    LogEntry logEntry = new LogEntry()
                    {
                        Host = Config.ServerUrl,
                        Method = context.Method.FullName,
                        RequestHeaders = context.Options.Headers,
                        Request = request,
                        ResponseHeaders = GetResponseHeader(call),
                        Response = (oldTask.IsFaulted) ? default(TResponse) : oldTask.Result,
                        Exception = GetGoogleAdsException(oldTask.Exception),
                        IsFailure = oldTask.IsFaulted,
                        CustomerId = GetCustomerId(request),
                        PartialFailures = (oldTask.IsFaulted) ? "" :
                            GetPartialFailures(oldTask.Result)
                    };
                    OnLogEventAvailable?.Invoke(this, logEntry);
                }
            });
            t.Wait();
            return call;
        }

        /// <summary>
        /// Gets the partial failures.
        /// </summary>
        /// <param name="response">The response.</param>
        /// <returns></returns>
        private string GetPartialFailures(object response)
        {
            if (response == null)
            {
                return "";
            }
            PropertyInfo propInfo = response.GetType().GetProperty("PartialFailure");
            if (propInfo == null)
            {
                return "";
            }
            object propValue = propInfo.GetValue(response);
            if (propValue == null)
            {
                return "";
            }
            else
            {
                return propValue.ToString();
            }
        }

        /// <summary>
        /// Writes the log entry.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="logEntry">The log entry.</param>
        private void WriteLogEntry(object sender, LogEntry logEntry)
        {
            TraceWriter.WriteDetailedRequestLogs(logEntry);
            TraceWriter.WriteSummaryRequestLogs(logEntry);
        }

        /// <summary>
        /// Gets the customer ID from the request, if available.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <returns>The customer ID, or an empty string if customer ID is not found.</returns>
        private string GetCustomerId<TRequest>(TRequest request)
        {
            try
            {
                return request.GetType().GetProperty("CustomerId").GetValue(
                    request, null).ToString();
            }
            catch
            {
                return "";
            }
        }

        /// <summary>
        /// Gets the response header.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="call">The call instance.</param>
        /// <returns>The trailing response metadata headers.</returns>
        private static Metadata GetResponseHeader<TResponse>(AsyncUnaryCall<TResponse> call)
            where TResponse : class
        {
            call.ResponseHeadersAsync.Wait();
            return call.ResponseHeadersAsync.Result;
        }

        /// <summary>
        /// Gets the Google Ads exception.
        /// </summary>
        /// <param name="e">The aggregate exception from the task.</param>
        /// <returns>The deserialized exception, or null if the exception cannot be deserialized.
        /// </returns>
        private static RpcException GetGoogleAdsException(AggregateException e)
        {
            Assembly myAssembly = MethodBase.GetCurrentMethod().DeclaringType.Assembly;

            RpcException rpcException = e?.InnerExceptions?.FirstOrDefault(
                delegate (Exception innerException)
                {
                    return (innerException is RpcException);
                }
            ) as RpcException;

            if (rpcException == null)
            {
                return null;
            }

            foreach (Metadata.Entry entry in rpcException.Trailers)
            {
                if (entry.Key.EndsWith(".googleadsfailure-bin"))
                {
                    string version = entry.Key.Replace("google.ads.googleads.", "")
                        .Replace(".errors.googleadsfailure-bin", "").ToUpper();

                    return (RpcException) myAssembly.GetType(
                        $"Google.Ads.GoogleAds.{version}.Errors.GoogleAdsException")
                        .GetMethod("Create", BindingFlags.Public | BindingFlags.Static)
                        .Invoke(null, new object[] { rpcException });
                }
            }
            return rpcException;
        }
    }
}

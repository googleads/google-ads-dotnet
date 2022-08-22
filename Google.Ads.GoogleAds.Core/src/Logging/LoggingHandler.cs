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

using Google.Ads.Gax.Interceptors;
using Google.Ads.Gax.Logging;
using Google.Ads.GoogleAds.Util;
using Grpc.Core;
using Grpc.Core.Interceptors;
using System;
using System.Reflection;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Logging
{
    /// <summary>
    /// Handles logging of requests and responses.
    /// </summary>
    internal class LoggingHandler
    {
        /// <summary>
        /// Gets the trace writer.
        /// </summary>
        private ITraceWriter traceWriter;

        /// <summary>
        /// Gets or sets the callback for writing detailed logs.
        /// </summary>
        internal Action<LogEntry> WriteDetailedLogs
        {
            get;
            set;
        }

        /// <summary>
        /// Gets or sets the callback for writing summary logs.
        /// </summary>
        internal Action<LogEntry> WriteSummaryLogs
        {
            get;
            set;
        }

        /// <summary>
        /// The log customizer.
        /// </summary>
        private ILogFormatter logCustomizer;

        /// <summary>
        /// Initializes a new instance of the <see cref="LoggingHandler"/> class.
        /// </summary>
        internal LoggingHandler()
        {
            this.traceWriter = new DefaultTraceWriter();
            this.logCustomizer = new LogFormatter();
            this.WriteDetailedLogs = WriteDetailedLogEntry;
            this.WriteSummaryLogs = WriteSummaryLogEntry;
        }

        /// <summary>
        /// Handles the logging of asynchronous unary calls.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="context">The context.</param>
        /// <param name="oldTask">The old task.</param>
        /// <param name="call">The call.</param>
        internal async void HandleAsyncUnaryLogging<TRequest, TResponse>(TRequest request,
            ClientInterceptorContext<TRequest, TResponse> context,
            Task<TResponse> oldTask, AsyncUnaryCall<TResponse> call)
            where TRequest : class
            where TResponse : class
        {
            // Generating log entry is expensive, so let's do that only if the log source
            // has been configured to do so.

            RpcException exception = null;

            if (TraceUtilities.ShouldGenerateSummaryRequestLogs())
            {
                exception = UnaryRpcInterceptor.ParseTaskException<TResponse>(oldTask.Exception);

                LogEntry logEntry = new LogEntry(logCustomizer)
                {
                    Host = context.Host,
                    Method = context.Method.FullName,
                    RequestHeaders = context.Options.Headers,  // includes the RequestId
                    IsFailure = oldTask.IsFaulted,
                    Exception = exception,
                    CustomerId = GetCustomerId(request),
                    ResponseHeaders = Merge(await call.ResponseHeadersAsync,
                                            call.GetTrailers()),
                    Response = (oldTask.IsFaulted) ? default : oldTask.Result,
                };

                WriteSummaryLogs(logEntry);
            }

            if (TraceUtilities.ShouldGenerateDetailedRequestLogs())
            {
                LogEntry logEntry = new LogEntry(logCustomizer)
                {
                    Host = context.Host,
                    Method = context.Method.FullName,
                    RequestHeaders = context.Options.Headers,
                    Request = request,
                    ResponseHeaders = Merge(await call.ResponseHeadersAsync,
                                            call.GetTrailers()),
                    Response = (oldTask.IsFaulted) ? default : oldTask.Result,
                    Exception = exception ?? UnaryRpcInterceptor.ParseTaskException<TResponse>(
                        oldTask.Exception),
                    IsFailure = oldTask.IsFaulted,
                    CustomerId = GetCustomerId(request),
                    PartialFailures = (oldTask.IsFaulted) ? "" :
                        GetPartialFailures(oldTask.Result)
                };

                WriteDetailedLogs(logEntry);
            }
        }

        /// <summary>
        /// Handles the logging of asynchronous server streaming calls.
        /// </summary>
        /// <typeparam name="TRequest">The type of the request.</typeparam>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="request">The request.</param>
        /// <param name="response">The response.</param>
        /// <param name="context">The context.</param>
        /// <param name="rpcException">The RPC exception.</param>
        /// <param name="call">The call.</param>
        internal async void HandleAsyncServerStreamingLogging<TRequest, TResponse>(TRequest request,
            TResponse response, ClientInterceptorContext<TRequest, TResponse> context,
            AggregateException rpcException, AsyncServerStreamingCall<TResponse> call)
            where TRequest : class
            where TResponse : class
        {
            // Generating log entry is expensive, so let's do that only if the log source
            // has been configured to do so.

            RpcException exception = null;

            if (TraceUtilities.ShouldGenerateSummaryRequestLogs())
            {
                exception = UnaryRpcInterceptor.ParseTaskException<TResponse>(rpcException);

                LogEntry logEntry = new LogEntry(logCustomizer)
                {
                    Host = context.Host,
                    Method = context.Method.FullName,
                    RequestHeaders = context.Options.Headers,  // includes the RequestId
                    IsFailure = (rpcException != null),
                    Exception = exception,
                    CustomerId = GetCustomerId(request),
                    Response = response,
                    ResponseHeaders = Merge(await call.ResponseHeadersAsync,
                        TryGetCallTrailers(call)),
                };

                WriteSummaryLogs(logEntry);
            }

            if (TraceUtilities.ShouldGenerateDetailedRequestLogs())
            {
                LogEntry logEntry = new LogEntry(logCustomizer)
                {
                    Host = context.Host,
                    Method = context.Method.FullName,
                    RequestHeaders = context.Options.Headers,
                    Request = request,
                    ResponseHeaders = Merge(await call.ResponseHeadersAsync,
                        TryGetCallTrailers(call)),
                    Response = response,
                    Exception = exception ?? UnaryRpcInterceptor.ParseTaskException<TResponse>(
                        rpcException),
                    IsFailure = (rpcException != null),
                    CustomerId = GetCustomerId(request),
                    PartialFailures = (rpcException != null) ? "" : GetPartialFailures(response)
                };

                WriteDetailedLogs(logEntry);
            }
        }

        /// <summary>
        /// Tries to the get call trailers.
        /// </summary>
        /// <typeparam name="TResponse">The type of the response.</typeparam>
        /// <param name="call">The call.</param>
        /// <returns>The trailing metadata, if the call has completed, an empty metadata if the
        /// call is ongoing.</returns>
        /// <remarks>There is currently no exposed method in the gRPC stack to check if an API call
        /// has completed.</remarks>
        private Metadata TryGetCallTrailers<TResponse>(AsyncServerStreamingCall<TResponse> call)
        {
            try
            {
                return call.GetTrailers();
            }
            catch (InvalidOperationException)
            {
                return new Metadata();
            }
        }

        /// <summary>
        /// Writes the detailed log entry.
        /// </summary>
        /// <param name="logEntry">The log entry.</param>
        private void WriteDetailedLogEntry(LogEntry logEntry)
        {
            traceWriter.WriteDetailedRequestLogs(logEntry);
        }

        /// <summary>
        /// Writes the summary log entry.
        /// </summary>
        /// <param name="logEntry">The log entry.</param>
        private void WriteSummaryLogEntry(LogEntry logEntry)
        {
            traceWriter.WriteSummaryRequestLogs(logEntry);
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
                PropertyInfo propertyInfo = request.GetType().GetProperty("CustomerId");
                if (propertyInfo != null)
                {
                    return propertyInfo.GetValue(request, null).ToString();
                }
                // Try to parse out of resource name.
                propertyInfo = request.GetType().GetProperty("Name");
                if (propertyInfo != null)
                {
                    string resourceName = propertyInfo.GetValue(request, null).ToString();
                    if (resourceName.StartsWith("customers"))
                    {
                        string[] parts = resourceName.Split('/');
                        if (parts.Length >= 2)
                        {
                            return parts[1];
                        }
                    }
                }
                return "";
            }
            catch
            {
                return "";
            }
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
        /// Gets the response header.
        /// </summary>
        /// <param name="task">The task for retrieving metadata headers.</param>
        /// <returns>The trailing response metadata headers.</returns>
        private static async Task<Metadata> GetResponseHeader(Task<Metadata> task)
        {
            await task;
            return task.Result;
        }

        /// <summary>
        /// Merges two metadata objects.
        /// </summary>
        /// <param name="first">The first metadata object.</param>
        /// <param name="second">The second metadata object.</param>
        /// <returns>The merged metadata object.</returns>
        private static Metadata Merge(Metadata first, Metadata second)
        {
            Metadata merged = new Metadata();

            foreach (Metadata.Entry entry in first)
            {
                merged.Add(entry);
            }

            foreach (Metadata.Entry entry in second)
            {
                merged.Add(entry);
            }

            return merged;
        }
    }
}

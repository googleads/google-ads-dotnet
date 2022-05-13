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

using Google.Ads.Gax.Lib;
using Grpc.Core;

namespace Google.Ads.Gax.Logging
{
    /// <summary>
    /// Interface for formatting logs.
    /// </summary>
    public interface ILogFormatter
    {
        /// <summary>
        /// Formats the request body.
        /// </summary>
        /// <param name="body">The request body.</param>
        /// <returns>The formatted text.</returns>
        string FormatRequestBody(object body);

        /// <summary>
        /// Formats the response body.
        /// </summary>
        /// <param name="body">The response body.</param>
        /// <returns>The formatted text.</returns>
        string FormatResponseBody(object body);

        /// <summary>
        /// Formats the request headers.
        /// </summary>
        /// <param name="header">The request header.</param>
        /// <returns>The formatted text.</returns>
        string FormatRequestHeaders(Metadata header);

        /// <summary>
        /// Formats the response headers.
        /// </summary>
        /// <param name="header">The response header.</param>
        /// <returns>The formatted text.</returns>
        string FormatResponseHeaders(Metadata header);

        /// <summary>
        /// Gets the request ID for logging.
        /// </summary>
        /// <param name="responseHeaders">The response headers.</param>
        /// <param name="response">The response.</param>
        /// <param name="exception">The exception, if available, null otherwise.</param>
        /// <returns>The request ID.</returns>
        public string GetRequestId(Metadata responseHeaders, object response,
            RpcException exception);
    }
}

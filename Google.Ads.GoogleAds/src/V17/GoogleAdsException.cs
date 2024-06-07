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
using System;
using System.Linq;

namespace Google.Ads.GoogleAds.V17.Errors
{
    /// <summary>
    /// Exception thrown in response to an API error from the GoogleAds servers.
    /// </summary>
    public sealed class GoogleAdsException : AdsBaseException<GoogleAdsFailure>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsException"/> class.
        /// </summary>
        /// <param name="status">Resulting status of a call.</param>
        /// <param name="message">The exception message.</param>
        private GoogleAdsException(Status status, string message) : base(status, message) { }

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleAdsException"/> class.
        /// </summary>
        /// <param name="status">Resulting status of a call.</param>
        /// <param name="trailers">Response trailing metadata.</param>
        private GoogleAdsException(Status status, Metadata trailers) : base(status, trailers) { }

        /// <summary>
        /// Creates a new instance of the <see cref="GoogleAdsException"/> class from an
        /// <see cref="RpcException"/>.
        /// </summary>
        /// <param name="rpcException">The original gRPC exception.</param>
        /// <returns></returns>
        public static AdsBaseException Create(RpcException rpcException)
        {
            return (rpcException.Trailers != null)
                ? new GoogleAdsException(rpcException.Status, rpcException.Trailers)
                : new GoogleAdsException(rpcException.Status, rpcException.Message);
        }

        /// <summary>
        /// Extracts a <see cref="GoogleAdsException"/> from an <see cref="AggregateException"/>
        /// </summary>
        /// <param name="ae">The aggregate exception.</param>
        /// <returns>An underlying GoogleAdsException if present, or <code>null</code> if one
        /// is missing.</returns>
        public static GoogleAdsException FromTaskException(AggregateException ae)
        {
            return ae.Flatten().InnerExceptions.Where((Exception ex) =>
            {
                return ex is GoogleAdsException;
            }).FirstOrDefault() as GoogleAdsException;
        }
    }
}

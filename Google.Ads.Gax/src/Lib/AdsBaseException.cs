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

using Google.Ads.Gax.Util;
using Google.Protobuf;
using Grpc.Core;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Google.Ads.Gax.Lib
{
    /// <summary>
    /// Base class for all ads exceptions.
    /// </summary>
    /// <seealso cref="Grpc.Core.RpcException" />
    public abstract class AdsBaseException : RpcException, IResponseMetadata
    {
        /// <summary>
        /// Gets the request ID.
        /// </summary>
        public string RequestId
        {
            get;
            set;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdsBaseException{T}"/> class.
        /// </summary>
        /// <param name="status">Resulting status of a call.</param>
        /// <param name="message">The exception message.</param>
        protected AdsBaseException(Status status, string message) : base(status, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdsBaseException{T}"/> class.
        /// </summary>
        /// <param name="status">Resulting status of a call.</param>
        /// <param name="trailers">Response trailing metadata.</param>
        protected AdsBaseException(Status status, Metadata trailers) : base(status, trailers)
        {
        }
    }

    /// <summary>
    ///
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <seealso cref="Grpc.Core.RpcException" />
    public abstract class AdsBaseException<T> : AdsBaseException where T : IMessage<T>, new()
    {
        /// <summary>
        /// Gets the Google Ads failure details.
        /// </summary>
        public T Failure
        {
            get;
        }

        /// <summary>
        /// Gets the failure key.
        /// </summary>
        public static string FailureKey
        {
            get => ProtobufUtilities.GetBinarySerializationKeyName<T>();
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdsBaseException{T}"/> class.
        /// </summary>
        /// <param name="status">Resulting status of a call.</param>
        /// <param name="message">The exception message.</param>
        protected AdsBaseException(Status status, string message) : base(status, message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdsBaseException{T}"/> class.
        /// </summary>
        /// <param name="status">Resulting status of a call.</param>
        /// <param name="trailers">Response trailing metadata.</param>
        protected AdsBaseException(Status status, Metadata trailers) : base(status, trailers)
        {
            Failure = ProtobufUtilities.Parse<T>(trailers.GetEntry(FailureKey).ValueBytes);
            // Try to extract the request ID from the response trailers, and fall back
            // to extract from Failure if possible.
            this.RequestId = new AdsResponseMetadata(trailers).RequestId;
            if (this.RequestId == null && Failure is IResponseMetadata)
            {
                this.RequestId = (Failure as IResponseMetadata).RequestId;
            }
        }

        /// <summary>
        /// Returns a <see cref="string" /> that represents this instance.
        /// </summary>
        /// <returns>
        /// A <see cref="string" /> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            JObject jsonObject = new JObject(
                new JProperty("StatusCode", this.StatusCode),
                new JProperty("Details", this.Status.Detail),
                new JProperty("RequestId", this.RequestId)
            );

            if (this.Failure != null)
            {
                jsonObject.Add(new JProperty("Failure", JObject.Parse(
                    JsonFormatter.ToDiagnosticString(this.Failure))));
            }

            return JsonConvert.SerializeObject(jsonObject, Formatting.Indented);
        }
    }
}

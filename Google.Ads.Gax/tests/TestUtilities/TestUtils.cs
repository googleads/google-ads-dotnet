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
using Google.Ads.Gax.Util;
using Google.Protobuf;
using Grpc.Core;
using System.IO;

namespace Google.Ads.Gax.Tests
{
    /// <summary>
    /// 
    /// </summary>
    public class AdsTestUtils
    {
        /// <summary>
        /// Creates an <see cref="RpcException"/> for testing purposes.
        /// </summary>
        public static RpcException CreateRpcException(string errorMessage, string errorTrigger,
            string requestId)
        {
            HelloFailure failure = new HelloFailure();
            failure.Errors.Add(new HelloError()
            {
                ErrorCode = new HelloErrorCode()
                {
                    RequestError = HelloRequestErrorEnum.Types.HelloRequestError.ResourceNameMissing
                },
                Message = errorMessage,
                Trigger = errorTrigger
            });

            Metadata metadata = new Metadata();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                failure.WriteTo(memoryStream);
                string failureKey =
                    ProtobufUtilities.GetBinarySerializationKeyName<HelloFailure>();
                metadata.Add(failureKey, memoryStream.ToArray());
                metadata.Add(AdsResponseMetadata.RequestIdKey, requestId);
            }

            return new RpcException(Status.DefaultSuccess, metadata);
        }

        /// <summary>
        /// Creates an <see cref="HelloException"/> for testing purposes.
        /// </summary>
        public static HelloException CreateException(string errorMessage,
            string errorTrigger, string requestId)
        {
            return (HelloException) HelloException.Create(CreateRpcException(
                errorMessage, errorTrigger, requestId));
        }
    }
}

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
using Google.Ads.GoogleAds.V6.Common;
using Google.Ads.GoogleAds.V6.Errors;
using Google.Protobuf;
using Grpc.Core;
using System.IO;

namespace Google.Ads.GoogleAds.Tests.V6
{
    internal class TestUtils
    {
        /// <summary>
        /// Creates an <see cref="RpcException"/> for testing purposes.
        /// </summary>
        internal static RpcException CreateRpcException(string errorMessage, string errorTrigger,
            string requestId)
        {
            GoogleAdsFailure failure = new GoogleAdsFailure();
            failure.Errors.Add(new GoogleAdsError()
            {
                ErrorCode = new ErrorCode()
                {
                    DistinctError = DistinctErrorEnum.Types.DistinctError.DuplicateElement
                },
                Message = errorMessage,
                Trigger = new Value()
                {
                    StringValue = errorTrigger
                }
            });

            Metadata metadata = new Metadata();
            using (MemoryStream memoryStream = new MemoryStream())
            {
                failure.WriteTo(memoryStream);
                metadata.Add(GoogleAdsBaseException.GetFailureKeyFromTypeName(
                    typeof(GoogleAdsException)), memoryStream.ToArray());
                metadata.Add(MetadataKeyNames.RequestId, requestId);
            }

            return new RpcException(Status.DefaultSuccess, metadata);
        }

        /// <summary>
        /// Creates an <see cref="GoogleAdsException"/> for testing purposes.
        /// </summary>
        internal static GoogleAdsException CreateException(string errorMessage,
            string errorTrigger, string requestId)
        {
            return (GoogleAdsException) GoogleAdsException.Create(CreateRpcException(
                errorMessage, errorTrigger, requestId));
        }
    }
}

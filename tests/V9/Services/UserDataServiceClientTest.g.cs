// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagvc = Google.Ads.GoogleAds.V9.Common;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V9.Services;

namespace Google.Ads.GoogleAds.Tests.V9.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedUserDataServiceClientTest
    {
        [Category("Smoke")][Test]
        public void UploadUserDataRequestObject()
        {
            moq::Mock<UserDataService.UserDataServiceClient> mockGrpcClient = new moq::Mock<UserDataService.UserDataServiceClient>(moq::MockBehavior.Strict);
            UploadUserDataRequest request = new UploadUserDataRequest
            {
                CustomerId = "customer_id3b3724cb",
                CustomerMatchUserListMetadata = new gagvc::CustomerMatchUserListMetadata(),
                Operations =
                {
                    new UserDataOperation(),
                },
            };
            UploadUserDataResponse expectedResponse = new UploadUserDataResponse
            {
                UploadDateTime = "upload_date_time763e3ebd",
                ReceivedOperationsCount = -816258212,
            };
            mockGrpcClient.Setup(x => x.UploadUserData(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            UserDataServiceClient client = new UserDataServiceClientImpl(mockGrpcClient.Object, null);
            UploadUserDataResponse response = client.UploadUserData(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task UploadUserDataRequestObjectAsync()
        {
            moq::Mock<UserDataService.UserDataServiceClient> mockGrpcClient = new moq::Mock<UserDataService.UserDataServiceClient>(moq::MockBehavior.Strict);
            UploadUserDataRequest request = new UploadUserDataRequest
            {
                CustomerId = "customer_id3b3724cb",
                CustomerMatchUserListMetadata = new gagvc::CustomerMatchUserListMetadata(),
                Operations =
                {
                    new UserDataOperation(),
                },
            };
            UploadUserDataResponse expectedResponse = new UploadUserDataResponse
            {
                UploadDateTime = "upload_date_time763e3ebd",
                ReceivedOperationsCount = -816258212,
            };
            mockGrpcClient.Setup(x => x.UploadUserDataAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<UploadUserDataResponse>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            UserDataServiceClient client = new UserDataServiceClientImpl(mockGrpcClient.Object, null);
            UploadUserDataResponse responseCallSettings = await client.UploadUserDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            UploadUserDataResponse responseCancellationToken = await client.UploadUserDataAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

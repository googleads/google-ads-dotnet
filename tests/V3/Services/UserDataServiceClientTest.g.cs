// Copyright 2020 Google LLC
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

namespace Google.Ads.GoogleAds.V3.Services.Tests
{
    using apis = Google.Ads.GoogleAds.V3.Services;
    using Google.Api.Gax;
    using Google.Api.Gax.Grpc;
    using Google.Protobuf.WellKnownTypes;
    using Grpc.Core;
    using Moq;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Threading;
    using System.Threading.Tasks;
    using NUnit.Framework;

    /// <summary>Generated unit tests</summary>
    public class GeneratedUserDataServiceClientTest
    {
        [Test]
        public void UploadUserData()
        {
            Mock<UserDataService.UserDataServiceClient> mockGrpcClient = new Mock<UserDataService.UserDataServiceClient>(MockBehavior.Strict);
            UploadUserDataRequest expectedRequest = new UploadUserDataRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            UploadUserDataResponse expectedResponse = new UploadUserDataResponse();
            mockGrpcClient.Setup(x => x.UploadUserData(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserDataServiceClient client = new UserDataServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<UserDataOperation> operations = new List<UserDataOperation>();
            UploadUserDataResponse response = client.UploadUserData(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task UploadUserDataAsync()
        {
            Mock<UserDataService.UserDataServiceClient> mockGrpcClient = new Mock<UserDataService.UserDataServiceClient>(MockBehavior.Strict);
            UploadUserDataRequest expectedRequest = new UploadUserDataRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            UploadUserDataResponse expectedResponse = new UploadUserDataResponse();
            mockGrpcClient.Setup(x => x.UploadUserDataAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UploadUserDataResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            UserDataServiceClient client = new UserDataServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<UserDataOperation> operations = new List<UserDataOperation>();
            UploadUserDataResponse response = await client.UploadUserDataAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void UploadUserData2()
        {
            Mock<UserDataService.UserDataServiceClient> mockGrpcClient = new Mock<UserDataService.UserDataServiceClient>(MockBehavior.Strict);
            UploadUserDataRequest request = new UploadUserDataRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            UploadUserDataResponse expectedResponse = new UploadUserDataResponse();
            mockGrpcClient.Setup(x => x.UploadUserData(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserDataServiceClient client = new UserDataServiceClientImpl(mockGrpcClient.Object, null);
            UploadUserDataResponse response = client.UploadUserData(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task UploadUserDataAsync2()
        {
            Mock<UserDataService.UserDataServiceClient> mockGrpcClient = new Mock<UserDataService.UserDataServiceClient>(MockBehavior.Strict);
            UploadUserDataRequest request = new UploadUserDataRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            UploadUserDataResponse expectedResponse = new UploadUserDataResponse();
            mockGrpcClient.Setup(x => x.UploadUserDataAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UploadUserDataResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            UserDataServiceClient client = new UserDataServiceClientImpl(mockGrpcClient.Object, null);
            UploadUserDataResponse response = await client.UploadUserDataAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

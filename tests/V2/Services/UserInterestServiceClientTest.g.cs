// Copyright 2019 Google LLC
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

namespace Google.Ads.GoogleAds.V2.Services.Tests
{
    using Google.Ads.GoogleAds.V2.Resources;
    using apis = Google.Ads.GoogleAds.V2.Services;
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
    public class GeneratedUserInterestServiceClientTest
    {
        [Test]
        public void GetUserInterest()
        {
            Mock<UserInterestService.UserInterestServiceClient> mockGrpcClient = new Mock<UserInterestService.UserInterestServiceClient>(MockBehavior.Strict);
            GetUserInterestRequest expectedRequest = new GetUserInterestRequest
            {
                ResourceName = new UserInterestName("[CUSTOMER]", "[USER_INTEREST]").ToString(),
            };
            UserInterest expectedResponse = new UserInterest
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserInterest(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserInterestServiceClient client = new UserInterestServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new UserInterestName("[CUSTOMER]", "[USER_INTEREST]").ToString();
            UserInterest response = client.GetUserInterest(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetUserInterestAsync()
        {
            Mock<UserInterestService.UserInterestServiceClient> mockGrpcClient = new Mock<UserInterestService.UserInterestServiceClient>(MockBehavior.Strict);
            GetUserInterestRequest expectedRequest = new GetUserInterestRequest
            {
                ResourceName = new UserInterestName("[CUSTOMER]", "[USER_INTEREST]").ToString(),
            };
            UserInterest expectedResponse = new UserInterest
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserInterestAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UserInterest>(Task.FromResult(expectedResponse), null, null, null, null));
            UserInterestServiceClient client = new UserInterestServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new UserInterestName("[CUSTOMER]", "[USER_INTEREST]").ToString();
            UserInterest response = await client.GetUserInterestAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetUserInterest2()
        {
            Mock<UserInterestService.UserInterestServiceClient> mockGrpcClient = new Mock<UserInterestService.UserInterestServiceClient>(MockBehavior.Strict);
            GetUserInterestRequest request = new GetUserInterestRequest
            {
                ResourceName = new UserInterestName("[CUSTOMER]", "[USER_INTEREST]").ToString(),
            };
            UserInterest expectedResponse = new UserInterest
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserInterest(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            UserInterestServiceClient client = new UserInterestServiceClientImpl(mockGrpcClient.Object, null);
            UserInterest response = client.GetUserInterest(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetUserInterestAsync2()
        {
            Mock<UserInterestService.UserInterestServiceClient> mockGrpcClient = new Mock<UserInterestService.UserInterestServiceClient>(MockBehavior.Strict);
            GetUserInterestRequest request = new GetUserInterestRequest
            {
                ResourceName = new UserInterestName("[CUSTOMER]", "[USER_INTEREST]").ToString(),
            };
            UserInterest expectedResponse = new UserInterest
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetUserInterestAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<UserInterest>(Task.FromResult(expectedResponse), null, null, null, null));
            UserInterestServiceClient client = new UserInterestServiceClientImpl(mockGrpcClient.Object, null);
            UserInterest response = await client.GetUserInterestAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

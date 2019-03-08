// Copyright 2018 Google LLC
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

// TODO( b/119694056): Removed Comment

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using apis = Google.Ads.GoogleAds.V0.Services;
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
    public class GeneratedAgeRangeViewServiceClientTest
    {
        [Test]
        public void GetAgeRangeView()
        {
            Mock<AgeRangeViewService.AgeRangeViewServiceClient> mockGrpcClient = new Mock<AgeRangeViewService.AgeRangeViewServiceClient>(MockBehavior.Strict);
            GetAgeRangeViewRequest expectedRequest = new GetAgeRangeViewRequest
            {
                ResourceName = new AgeRangeViewName("[CUSTOMER]", "[AGE_RANGE_VIEW]").ToString(),
            };
            AgeRangeView expectedResponse = new AgeRangeView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAgeRangeView(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AgeRangeViewServiceClient client = new AgeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AgeRangeViewName("[CUSTOMER]", "[AGE_RANGE_VIEW]").ToString();
            AgeRangeView response = client.GetAgeRangeView(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAgeRangeViewAsync()
        {
            Mock<AgeRangeViewService.AgeRangeViewServiceClient> mockGrpcClient = new Mock<AgeRangeViewService.AgeRangeViewServiceClient>(MockBehavior.Strict);
            GetAgeRangeViewRequest expectedRequest = new GetAgeRangeViewRequest
            {
                ResourceName = new AgeRangeViewName("[CUSTOMER]", "[AGE_RANGE_VIEW]").ToString(),
            };
            AgeRangeView expectedResponse = new AgeRangeView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAgeRangeViewAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AgeRangeView>(Task.FromResult(expectedResponse), null, null, null, null));
            AgeRangeViewServiceClient client = new AgeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new AgeRangeViewName("[CUSTOMER]", "[AGE_RANGE_VIEW]").ToString();
            AgeRangeView response = await client.GetAgeRangeViewAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetAgeRangeView2()
        {
            Mock<AgeRangeViewService.AgeRangeViewServiceClient> mockGrpcClient = new Mock<AgeRangeViewService.AgeRangeViewServiceClient>(MockBehavior.Strict);
            GetAgeRangeViewRequest request = new GetAgeRangeViewRequest
            {
                ResourceName = new AgeRangeViewName("[CUSTOMER]", "[AGE_RANGE_VIEW]").ToString(),
            };
            AgeRangeView expectedResponse = new AgeRangeView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAgeRangeView(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            AgeRangeViewServiceClient client = new AgeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            AgeRangeView response = client.GetAgeRangeView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetAgeRangeViewAsync2()
        {
            Mock<AgeRangeViewService.AgeRangeViewServiceClient> mockGrpcClient = new Mock<AgeRangeViewService.AgeRangeViewServiceClient>(MockBehavior.Strict);
            GetAgeRangeViewRequest request = new GetAgeRangeViewRequest
            {
                ResourceName = new AgeRangeViewName("[CUSTOMER]", "[AGE_RANGE_VIEW]").ToString(),
            };
            AgeRangeView expectedResponse = new AgeRangeView
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetAgeRangeViewAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<AgeRangeView>(Task.FromResult(expectedResponse), null, null, null, null));
            AgeRangeViewServiceClient client = new AgeRangeViewServiceClientImpl(mockGrpcClient.Object, null);
            AgeRangeView response = await client.GetAgeRangeViewAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

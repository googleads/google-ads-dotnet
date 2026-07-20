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

// Generated code. DO NOT EDIT!

namespace Google.Ads.GoogleAds.V0.Services.Tests
{
    using Google.Ads.GoogleAds.V0.Resources;
    using Google.Ads.GoogleAds.V0.Services;
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
    public class GeneratedGoogleAdsFieldServiceClientTest
    {
        [Test]
        public void GetGoogleAdsField()
        {
            Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient> mockGrpcClient = new Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient>(MockBehavior.Strict);
            GetGoogleAdsFieldRequest expectedRequest = new GetGoogleAdsFieldRequest
            {
                ResourceName = new GoogleAdsFieldName("[GOOGLE_ADS_FIELD]").ToString(),
            };
            GoogleAdsField expectedResponse = new GoogleAdsField
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGoogleAdsField(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GoogleAdsFieldServiceClient client = new GoogleAdsFieldServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new GoogleAdsFieldName("[GOOGLE_ADS_FIELD]").ToString();
            GoogleAdsField response = client.GetGoogleAdsField(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetGoogleAdsFieldAsync()
        {
            Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient> mockGrpcClient = new Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient>(MockBehavior.Strict);
            GetGoogleAdsFieldRequest expectedRequest = new GetGoogleAdsFieldRequest
            {
                ResourceName = new GoogleAdsFieldName("[GOOGLE_ADS_FIELD]").ToString(),
            };
            GoogleAdsField expectedResponse = new GoogleAdsField
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGoogleAdsFieldAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GoogleAdsField>(Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsFieldServiceClient client = new GoogleAdsFieldServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new GoogleAdsFieldName("[GOOGLE_ADS_FIELD]").ToString();
            GoogleAdsField response = await client.GetGoogleAdsFieldAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetGoogleAdsField2()
        {
            Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient> mockGrpcClient = new Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient>(MockBehavior.Strict);
            GetGoogleAdsFieldRequest request = new GetGoogleAdsFieldRequest
            {
                ResourceName = new GoogleAdsFieldName("[GOOGLE_ADS_FIELD]").ToString(),
            };
            GoogleAdsField expectedResponse = new GoogleAdsField
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGoogleAdsField(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            GoogleAdsFieldServiceClient client = new GoogleAdsFieldServiceClientImpl(mockGrpcClient.Object, null);
            GoogleAdsField response = client.GetGoogleAdsField(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetGoogleAdsFieldAsync2()
        {
            Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient> mockGrpcClient = new Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient>(MockBehavior.Strict);
            GetGoogleAdsFieldRequest request = new GetGoogleAdsFieldRequest
            {
                ResourceName = new GoogleAdsFieldName("[GOOGLE_ADS_FIELD]").ToString(),
            };
            GoogleAdsField expectedResponse = new GoogleAdsField
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetGoogleAdsFieldAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<GoogleAdsField>(Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsFieldServiceClient client = new GoogleAdsFieldServiceClientImpl(mockGrpcClient.Object, null);
            GoogleAdsField response = await client.GetGoogleAdsFieldAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

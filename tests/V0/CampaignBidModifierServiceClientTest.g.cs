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
    public class GeneratedCampaignBidModifierServiceClientTest
    {
        [Test]
        public void GetCampaignBidModifier()
        {
            Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(MockBehavior.Strict);
            GetCampaignBidModifierRequest expectedRequest = new GetCampaignBidModifierRequest
            {
                ResourceName = new CampaignBidModifierName("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]").ToString(),
            };
            CampaignBidModifier expectedResponse = new CampaignBidModifier
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignBidModifier(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignBidModifierName("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]").ToString();
            CampaignBidModifier response = client.GetCampaignBidModifier(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignBidModifierAsync()
        {
            Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(MockBehavior.Strict);
            GetCampaignBidModifierRequest expectedRequest = new GetCampaignBidModifierRequest
            {
                ResourceName = new CampaignBidModifierName("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]").ToString(),
            };
            CampaignBidModifier expectedResponse = new CampaignBidModifier
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignBidModifierAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignBidModifier>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new CampaignBidModifierName("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]").ToString();
            CampaignBidModifier response = await client.GetCampaignBidModifierAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetCampaignBidModifier2()
        {
            Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(MockBehavior.Strict);
            GetCampaignBidModifierRequest request = new GetCampaignBidModifierRequest
            {
                ResourceName = new CampaignBidModifierName("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]").ToString(),
            };
            CampaignBidModifier expectedResponse = new CampaignBidModifier
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignBidModifier(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            CampaignBidModifier response = client.GetCampaignBidModifier(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetCampaignBidModifierAsync2()
        {
            Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(MockBehavior.Strict);
            GetCampaignBidModifierRequest request = new GetCampaignBidModifierRequest
            {
                ResourceName = new CampaignBidModifierName("[CUSTOMER]", "[CAMPAIGN_BID_MODIFIER]").ToString(),
            };
            CampaignBidModifier expectedResponse = new CampaignBidModifier
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetCampaignBidModifierAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<CampaignBidModifier>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            CampaignBidModifier response = await client.GetCampaignBidModifierAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignBidModifiers()
        {
            Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(MockBehavior.Strict);
            MutateCampaignBidModifiersRequest expectedRequest = new MutateCampaignBidModifiersRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignBidModifiersResponse expectedResponse = new MutateCampaignBidModifiersResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignBidModifiers(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignBidModifierOperation> operations = new List<CampaignBidModifierOperation>();
            MutateCampaignBidModifiersResponse response = client.MutateCampaignBidModifiers(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignBidModifiersAsync()
        {
            Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(MockBehavior.Strict);
            MutateCampaignBidModifiersRequest expectedRequest = new MutateCampaignBidModifiersRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignBidModifiersResponse expectedResponse = new MutateCampaignBidModifiersResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignBidModifiersAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignBidModifiersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<CampaignBidModifierOperation> operations = new List<CampaignBidModifierOperation>();
            MutateCampaignBidModifiersResponse response = await client.MutateCampaignBidModifiersAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateCampaignBidModifiers2()
        {
            Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(MockBehavior.Strict);
            MutateCampaignBidModifiersRequest request = new MutateCampaignBidModifiersRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignBidModifiersResponse expectedResponse = new MutateCampaignBidModifiersResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignBidModifiers(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBidModifiersResponse response = client.MutateCampaignBidModifiers(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateCampaignBidModifiersAsync2()
        {
            Mock<CampaignBidModifierService.CampaignBidModifierServiceClient> mockGrpcClient = new Mock<CampaignBidModifierService.CampaignBidModifierServiceClient>(MockBehavior.Strict);
            MutateCampaignBidModifiersRequest request = new MutateCampaignBidModifiersRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateCampaignBidModifiersResponse expectedResponse = new MutateCampaignBidModifiersResponse();
            mockGrpcClient.Setup(x => x.MutateCampaignBidModifiersAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignBidModifiersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            CampaignBidModifierServiceClient client = new CampaignBidModifierServiceClientImpl(mockGrpcClient.Object, null);
            MutateCampaignBidModifiersResponse response = await client.MutateCampaignBidModifiersAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

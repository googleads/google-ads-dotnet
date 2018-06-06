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

namespace Google.Ads.GoogleAds.V0.Services.Tests {

  using Google.Ads.GoogleAds.V0.Resources;
  using Google.Ads.GoogleAds.V0.Services;
  using Grpc.Core;
  using Moq;
  using NUnit.Framework;
  using System.Collections.Generic;
  using System.Threading.Tasks;

  /// <summary>Generated unit tests</summary>
  public class GeneratedAdGroupBidModifierServiceClientTest {

    [Test]
    public void GetAdGroupBidModifier() {
      Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(MockBehavior.Strict);
      GetAdGroupBidModifierRequest expectedRequest = new GetAdGroupBidModifierRequest {
        ResourceName = new AdGroupBidModifierName("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]").ToString(),
      };
      AdGroupBidModifier expectedResponse = new AdGroupBidModifier {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetAdGroupBidModifier(expectedRequest, It.IsAny<CallOptions>()))
          .Returns(expectedResponse);
      AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
      string formattedResourceName = new AdGroupBidModifierName("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]").ToString();
      AdGroupBidModifier response = client.GetAdGroupBidModifier(formattedResourceName);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public async Task GetAdGroupBidModifierAsync() {
      Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(MockBehavior.Strict);
      GetAdGroupBidModifierRequest expectedRequest = new GetAdGroupBidModifierRequest {
        ResourceName = new AdGroupBidModifierName("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]").ToString(),
      };
      AdGroupBidModifier expectedResponse = new AdGroupBidModifier {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetAdGroupBidModifierAsync(expectedRequest, It.IsAny<CallOptions>()))
          .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupBidModifier>(Task.FromResult(expectedResponse), null, null, null, null));
      AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
      string formattedResourceName = new AdGroupBidModifierName("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]").ToString();
      AdGroupBidModifier response = await client.GetAdGroupBidModifierAsync(formattedResourceName);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public void GetAdGroupBidModifier2() {
      Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(MockBehavior.Strict);
      GetAdGroupBidModifierRequest request = new GetAdGroupBidModifierRequest {
        ResourceName = new AdGroupBidModifierName("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]").ToString(),
      };
      AdGroupBidModifier expectedResponse = new AdGroupBidModifier {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetAdGroupBidModifier(request, It.IsAny<CallOptions>()))
          .Returns(expectedResponse);
      AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
      AdGroupBidModifier response = client.GetAdGroupBidModifier(request);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public async Task GetAdGroupBidModifierAsync2() {
      Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(MockBehavior.Strict);
      GetAdGroupBidModifierRequest request = new GetAdGroupBidModifierRequest {
        ResourceName = new AdGroupBidModifierName("[CUSTOMER]", "[AD_GROUP_BID_MODIFIER]").ToString(),
      };
      AdGroupBidModifier expectedResponse = new AdGroupBidModifier {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetAdGroupBidModifierAsync(request, It.IsAny<CallOptions>()))
          .Returns(new Grpc.Core.AsyncUnaryCall<AdGroupBidModifier>(Task.FromResult(expectedResponse), null, null, null, null));
      AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
      AdGroupBidModifier response = await client.GetAdGroupBidModifierAsync(request);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public void MutateAdGroupBidModifiers() {
      Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(MockBehavior.Strict);
      MutateAdGroupBidModifiersRequest expectedRequest = new MutateAdGroupBidModifiersRequest {
        CustomerId = "customerId-1772061412",
        Operations = { },
      };
      MutateAdGroupBidModifiersResponse expectedResponse = new MutateAdGroupBidModifiersResponse();
      mockGrpcClient.Setup(x => x.MutateAdGroupBidModifiers(expectedRequest, It.IsAny<CallOptions>()))
          .Returns(expectedResponse);
      AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
      string customerId = "customerId-1772061412";
      IEnumerable<AdGroupBidModifierOperation> operations = new List<AdGroupBidModifierOperation>();
      MutateAdGroupBidModifiersResponse response = client.MutateAdGroupBidModifiers(customerId, operations);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public async Task MutateAdGroupBidModifiersAsync() {
      Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(MockBehavior.Strict);
      MutateAdGroupBidModifiersRequest expectedRequest = new MutateAdGroupBidModifiersRequest {
        CustomerId = "customerId-1772061412",
        Operations = { },
      };
      MutateAdGroupBidModifiersResponse expectedResponse = new MutateAdGroupBidModifiersResponse();
      mockGrpcClient.Setup(x => x.MutateAdGroupBidModifiersAsync(expectedRequest, It.IsAny<CallOptions>()))
          .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupBidModifiersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
      AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
      string customerId = "customerId-1772061412";
      IEnumerable<AdGroupBidModifierOperation> operations = new List<AdGroupBidModifierOperation>();
      MutateAdGroupBidModifiersResponse response = await client.MutateAdGroupBidModifiersAsync(customerId, operations);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public void MutateAdGroupBidModifiers2() {
      Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(MockBehavior.Strict);
      MutateAdGroupBidModifiersRequest request = new MutateAdGroupBidModifiersRequest {
        CustomerId = "customerId-1772061412",
        Operations = { },
      };
      MutateAdGroupBidModifiersResponse expectedResponse = new MutateAdGroupBidModifiersResponse();
      mockGrpcClient.Setup(x => x.MutateAdGroupBidModifiers(request, It.IsAny<CallOptions>()))
          .Returns(expectedResponse);
      AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
      MutateAdGroupBidModifiersResponse response = client.MutateAdGroupBidModifiers(request);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public async Task MutateAdGroupBidModifiersAsync2() {
      Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient> mockGrpcClient = new Mock<AdGroupBidModifierService.AdGroupBidModifierServiceClient>(MockBehavior.Strict);
      MutateAdGroupBidModifiersRequest request = new MutateAdGroupBidModifiersRequest {
        CustomerId = "customerId-1772061412",
        Operations = { },
      };
      MutateAdGroupBidModifiersResponse expectedResponse = new MutateAdGroupBidModifiersResponse();
      mockGrpcClient.Setup(x => x.MutateAdGroupBidModifiersAsync(request, It.IsAny<CallOptions>()))
          .Returns(new Grpc.Core.AsyncUnaryCall<MutateAdGroupBidModifiersResponse>(Task.FromResult(expectedResponse), null, null, null, null));
      AdGroupBidModifierServiceClient client = new AdGroupBidModifierServiceClientImpl(mockGrpcClient.Object, null);
      MutateAdGroupBidModifiersResponse response = await client.MutateAdGroupBidModifiersAsync(request);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }
  }
}
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
  public class GeneratedCampaignBudgetServiceClientTest {

    [Test]
    public void GetCampaignBudget() {
      Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new Mock<CampaignBudgetService.CampaignBudgetServiceClient>(MockBehavior.Strict);
      GetCampaignBudgetRequest expectedRequest = new GetCampaignBudgetRequest {
        ResourceName = new CampaignBudgetName("[CUSTOMER]", "[CAMPAIGN_BUDGET]").ToString(),
      };
      CampaignBudget expectedResponse = new CampaignBudget {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetCampaignBudget(expectedRequest, It.IsAny<CallOptions>()))
          .Returns(expectedResponse);
      CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
      string formattedResourceName = new CampaignBudgetName("[CUSTOMER]", "[CAMPAIGN_BUDGET]").ToString();
      CampaignBudget response = client.GetCampaignBudget(formattedResourceName);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public async Task GetCampaignBudgetAsync() {
      Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new Mock<CampaignBudgetService.CampaignBudgetServiceClient>(MockBehavior.Strict);
      GetCampaignBudgetRequest expectedRequest = new GetCampaignBudgetRequest {
        ResourceName = new CampaignBudgetName("[CUSTOMER]", "[CAMPAIGN_BUDGET]").ToString(),
      };
      CampaignBudget expectedResponse = new CampaignBudget {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetCampaignBudgetAsync(expectedRequest, It.IsAny<CallOptions>()))
          .Returns(new Grpc.Core.AsyncUnaryCall<CampaignBudget>(Task.FromResult(expectedResponse), null, null, null, null));
      CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
      string formattedResourceName = new CampaignBudgetName("[CUSTOMER]", "[CAMPAIGN_BUDGET]").ToString();
      CampaignBudget response = await client.GetCampaignBudgetAsync(formattedResourceName);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public void GetCampaignBudget2() {
      Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new Mock<CampaignBudgetService.CampaignBudgetServiceClient>(MockBehavior.Strict);
      GetCampaignBudgetRequest request = new GetCampaignBudgetRequest {
        ResourceName = new CampaignBudgetName("[CUSTOMER]", "[CAMPAIGN_BUDGET]").ToString(),
      };
      CampaignBudget expectedResponse = new CampaignBudget {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetCampaignBudget(request, It.IsAny<CallOptions>()))
          .Returns(expectedResponse);
      CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
      CampaignBudget response = client.GetCampaignBudget(request);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public async Task GetCampaignBudgetAsync2() {
      Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new Mock<CampaignBudgetService.CampaignBudgetServiceClient>(MockBehavior.Strict);
      GetCampaignBudgetRequest request = new GetCampaignBudgetRequest {
        ResourceName = new CampaignBudgetName("[CUSTOMER]", "[CAMPAIGN_BUDGET]").ToString(),
      };
      CampaignBudget expectedResponse = new CampaignBudget {
        ResourceName = "resourceName2625949903",
      };
      mockGrpcClient.Setup(x => x.GetCampaignBudgetAsync(request, It.IsAny<CallOptions>()))
          .Returns(new Grpc.Core.AsyncUnaryCall<CampaignBudget>(Task.FromResult(expectedResponse), null, null, null, null));
      CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
      CampaignBudget response = await client.GetCampaignBudgetAsync(request);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public void MutateCampaignBudgets() {
      Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new Mock<CampaignBudgetService.CampaignBudgetServiceClient>(MockBehavior.Strict);
      MutateCampaignBudgetsRequest expectedRequest = new MutateCampaignBudgetsRequest {
        CustomerId = "customerId-1772061412",
        Operations = { },
      };
      MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse();
      mockGrpcClient.Setup(x => x.MutateCampaignBudgets(expectedRequest, It.IsAny<CallOptions>()))
          .Returns(expectedResponse);
      CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
      string customerId = "customerId-1772061412";
      IEnumerable<CampaignBudgetOperation> operations = new List<CampaignBudgetOperation>();
      MutateCampaignBudgetsResponse response = client.MutateCampaignBudgets(customerId, operations);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public async Task MutateCampaignBudgetsAsync() {
      Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new Mock<CampaignBudgetService.CampaignBudgetServiceClient>(MockBehavior.Strict);
      MutateCampaignBudgetsRequest expectedRequest = new MutateCampaignBudgetsRequest {
        CustomerId = "customerId-1772061412",
        Operations = { },
      };
      MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse();
      mockGrpcClient.Setup(x => x.MutateCampaignBudgetsAsync(expectedRequest, It.IsAny<CallOptions>()))
          .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignBudgetsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
      CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
      string customerId = "customerId-1772061412";
      IEnumerable<CampaignBudgetOperation> operations = new List<CampaignBudgetOperation>();
      MutateCampaignBudgetsResponse response = await client.MutateCampaignBudgetsAsync(customerId, operations);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public void MutateCampaignBudgets2() {
      Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new Mock<CampaignBudgetService.CampaignBudgetServiceClient>(MockBehavior.Strict);
      MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest {
        CustomerId = "customerId-1772061412",
        Operations = { },
      };
      MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse();
      mockGrpcClient.Setup(x => x.MutateCampaignBudgets(request, It.IsAny<CallOptions>()))
          .Returns(expectedResponse);
      CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
      MutateCampaignBudgetsResponse response = client.MutateCampaignBudgets(request);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }

    [Test]
    public async Task MutateCampaignBudgetsAsync2() {
      Mock<CampaignBudgetService.CampaignBudgetServiceClient> mockGrpcClient = new Mock<CampaignBudgetService.CampaignBudgetServiceClient>(MockBehavior.Strict);
      MutateCampaignBudgetsRequest request = new MutateCampaignBudgetsRequest {
        CustomerId = "customerId-1772061412",
        Operations = { },
      };
      MutateCampaignBudgetsResponse expectedResponse = new MutateCampaignBudgetsResponse();
      mockGrpcClient.Setup(x => x.MutateCampaignBudgetsAsync(request, It.IsAny<CallOptions>()))
          .Returns(new Grpc.Core.AsyncUnaryCall<MutateCampaignBudgetsResponse>(Task.FromResult(expectedResponse), null, null, null, null));
      CampaignBudgetServiceClient client = new CampaignBudgetServiceClientImpl(mockGrpcClient.Object, null);
      MutateCampaignBudgetsResponse response = await client.MutateCampaignBudgetsAsync(request);
      Assert.AreEqual(expectedResponse, response);
      mockGrpcClient.VerifyAll();
    }
  }
}
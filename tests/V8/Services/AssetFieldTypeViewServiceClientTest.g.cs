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

using gagve = Google.Ads.GoogleAds.V8.Enums;
using gagvr = Google.Ads.GoogleAds.V8.Resources;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using moq = Moq;
using st = System.Threading;
using stt = System.Threading.Tasks;
using NUnit.Framework;
using Google.Ads.GoogleAds.V8.Services;

namespace Google.Ads.GoogleAds.Tests.V8.Services
{
    /// <summary>Generated unit tests.</summary>
    public sealed class GeneratedAssetFieldTypeViewServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetAssetFieldTypeViewRequestObject()
        {
            moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient> mockGrpcClient = new moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient>(moq::MockBehavior.Strict);
            GetAssetFieldTypeViewRequest request = new GetAssetFieldTypeViewRequest
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetFieldTypeView expectedResponse = new gagvr::AssetFieldTypeView
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
            };
            mockGrpcClient.Setup(x => x.GetAssetFieldTypeView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetFieldTypeViewServiceClient client = new AssetFieldTypeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetFieldTypeView response = client.GetAssetFieldTypeView(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetFieldTypeViewRequestObjectAsync()
        {
            moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient> mockGrpcClient = new moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient>(moq::MockBehavior.Strict);
            GetAssetFieldTypeViewRequest request = new GetAssetFieldTypeViewRequest
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetFieldTypeView expectedResponse = new gagvr::AssetFieldTypeView
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
            };
            mockGrpcClient.Setup(x => x.GetAssetFieldTypeViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AssetFieldTypeView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetFieldTypeViewServiceClient client = new AssetFieldTypeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetFieldTypeView responseCallSettings = await client.GetAssetFieldTypeViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AssetFieldTypeView responseCancellationToken = await client.GetAssetFieldTypeViewAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAssetFieldTypeView()
        {
            moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient> mockGrpcClient = new moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient>(moq::MockBehavior.Strict);
            GetAssetFieldTypeViewRequest request = new GetAssetFieldTypeViewRequest
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetFieldTypeView expectedResponse = new gagvr::AssetFieldTypeView
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
            };
            mockGrpcClient.Setup(x => x.GetAssetFieldTypeView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetFieldTypeViewServiceClient client = new AssetFieldTypeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetFieldTypeView response = client.GetAssetFieldTypeView(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetFieldTypeViewAsync()
        {
            moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient> mockGrpcClient = new moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient>(moq::MockBehavior.Strict);
            GetAssetFieldTypeViewRequest request = new GetAssetFieldTypeViewRequest
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetFieldTypeView expectedResponse = new gagvr::AssetFieldTypeView
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
            };
            mockGrpcClient.Setup(x => x.GetAssetFieldTypeViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AssetFieldTypeView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetFieldTypeViewServiceClient client = new AssetFieldTypeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetFieldTypeView responseCallSettings = await client.GetAssetFieldTypeViewAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AssetFieldTypeView responseCancellationToken = await client.GetAssetFieldTypeViewAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetAssetFieldTypeViewResourceNames()
        {
            moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient> mockGrpcClient = new moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient>(moq::MockBehavior.Strict);
            GetAssetFieldTypeViewRequest request = new GetAssetFieldTypeViewRequest
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetFieldTypeView expectedResponse = new gagvr::AssetFieldTypeView
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
            };
            mockGrpcClient.Setup(x => x.GetAssetFieldTypeView(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            AssetFieldTypeViewServiceClient client = new AssetFieldTypeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetFieldTypeView response = client.GetAssetFieldTypeView(request.ResourceNameAsAssetFieldTypeViewName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetAssetFieldTypeViewResourceNamesAsync()
        {
            moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient> mockGrpcClient = new moq::Mock<AssetFieldTypeViewService.AssetFieldTypeViewServiceClient>(moq::MockBehavior.Strict);
            GetAssetFieldTypeViewRequest request = new GetAssetFieldTypeViewRequest
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
            };
            gagvr::AssetFieldTypeView expectedResponse = new gagvr::AssetFieldTypeView
            {
                ResourceNameAsAssetFieldTypeViewName = gagvr::AssetFieldTypeViewName.FromCustomerFieldType("[CUSTOMER_ID]", "[FIELD_TYPE]"),
                FieldType = gagve::AssetFieldTypeEnum.Types.AssetFieldType.YoutubeVideo,
            };
            mockGrpcClient.Setup(x => x.GetAssetFieldTypeViewAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::AssetFieldTypeView>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            AssetFieldTypeViewServiceClient client = new AssetFieldTypeViewServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::AssetFieldTypeView responseCallSettings = await client.GetAssetFieldTypeViewAsync(request.ResourceNameAsAssetFieldTypeViewName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::AssetFieldTypeView responseCancellationToken = await client.GetAssetFieldTypeViewAsync(request.ResourceNameAsAssetFieldTypeViewName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

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

using gagve = Google.Ads.GoogleAds.V9.Enums;
using gagvr = Google.Ads.GoogleAds.V9.Resources;
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
    public sealed class GeneratedGoogleAdsFieldServiceClientTest
    {
        [Category("Smoke")][Test]
        public void GetGoogleAdsFieldRequestObject()
        {
            moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient>(moq::MockBehavior.Strict);
            GetGoogleAdsFieldRequest request = new GetGoogleAdsFieldRequest
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
            };
            gagvr::GoogleAdsField expectedResponse = new gagvr::GoogleAdsField
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Category = gagve::GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Segment,
                DataType = gagve::GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Message,
                GoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Selectable = true,
                Filterable = true,
                Sortable = true,
                SelectableWith =
                {
                    "selectable_with6b2ad4c4",
                },
                AttributeResources =
                {
                    "attribute_resources3f8a5e5c",
                },
                Metrics = { "metrics7cd659aa", },
                Segments =
                {
                    "segments982d981f",
                },
                EnumValues =
                {
                    "enum_values30797dbe",
                },
                TypeUrl = "type_urlfde5623b",
                IsRepeated = false,
            };
            mockGrpcClient.Setup(x => x.GetGoogleAdsField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GoogleAdsFieldServiceClient client = new GoogleAdsFieldServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GoogleAdsField response = client.GetGoogleAdsField(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGoogleAdsFieldRequestObjectAsync()
        {
            moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient>(moq::MockBehavior.Strict);
            GetGoogleAdsFieldRequest request = new GetGoogleAdsFieldRequest
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
            };
            gagvr::GoogleAdsField expectedResponse = new gagvr::GoogleAdsField
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Category = gagve::GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Segment,
                DataType = gagve::GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Message,
                GoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Selectable = true,
                Filterable = true,
                Sortable = true,
                SelectableWith =
                {
                    "selectable_with6b2ad4c4",
                },
                AttributeResources =
                {
                    "attribute_resources3f8a5e5c",
                },
                Metrics = { "metrics7cd659aa", },
                Segments =
                {
                    "segments982d981f",
                },
                EnumValues =
                {
                    "enum_values30797dbe",
                },
                TypeUrl = "type_urlfde5623b",
                IsRepeated = false,
            };
            mockGrpcClient.Setup(x => x.GetGoogleAdsFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GoogleAdsField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsFieldServiceClient client = new GoogleAdsFieldServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GoogleAdsField responseCallSettings = await client.GetGoogleAdsFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GoogleAdsField responseCancellationToken = await client.GetGoogleAdsFieldAsync(request, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetGoogleAdsField()
        {
            moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient>(moq::MockBehavior.Strict);
            GetGoogleAdsFieldRequest request = new GetGoogleAdsFieldRequest
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
            };
            gagvr::GoogleAdsField expectedResponse = new gagvr::GoogleAdsField
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Category = gagve::GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Segment,
                DataType = gagve::GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Message,
                GoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Selectable = true,
                Filterable = true,
                Sortable = true,
                SelectableWith =
                {
                    "selectable_with6b2ad4c4",
                },
                AttributeResources =
                {
                    "attribute_resources3f8a5e5c",
                },
                Metrics = { "metrics7cd659aa", },
                Segments =
                {
                    "segments982d981f",
                },
                EnumValues =
                {
                    "enum_values30797dbe",
                },
                TypeUrl = "type_urlfde5623b",
                IsRepeated = false,
            };
            mockGrpcClient.Setup(x => x.GetGoogleAdsField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GoogleAdsFieldServiceClient client = new GoogleAdsFieldServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GoogleAdsField response = client.GetGoogleAdsField(request.ResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGoogleAdsFieldAsync()
        {
            moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient>(moq::MockBehavior.Strict);
            GetGoogleAdsFieldRequest request = new GetGoogleAdsFieldRequest
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
            };
            gagvr::GoogleAdsField expectedResponse = new gagvr::GoogleAdsField
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Category = gagve::GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Segment,
                DataType = gagve::GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Message,
                GoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Selectable = true,
                Filterable = true,
                Sortable = true,
                SelectableWith =
                {
                    "selectable_with6b2ad4c4",
                },
                AttributeResources =
                {
                    "attribute_resources3f8a5e5c",
                },
                Metrics = { "metrics7cd659aa", },
                Segments =
                {
                    "segments982d981f",
                },
                EnumValues =
                {
                    "enum_values30797dbe",
                },
                TypeUrl = "type_urlfde5623b",
                IsRepeated = false,
            };
            mockGrpcClient.Setup(x => x.GetGoogleAdsFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GoogleAdsField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsFieldServiceClient client = new GoogleAdsFieldServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GoogleAdsField responseCallSettings = await client.GetGoogleAdsFieldAsync(request.ResourceName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GoogleAdsField responseCancellationToken = await client.GetGoogleAdsFieldAsync(request.ResourceName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public void GetGoogleAdsFieldResourceNames()
        {
            moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient>(moq::MockBehavior.Strict);
            GetGoogleAdsFieldRequest request = new GetGoogleAdsFieldRequest
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
            };
            gagvr::GoogleAdsField expectedResponse = new gagvr::GoogleAdsField
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Category = gagve::GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Segment,
                DataType = gagve::GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Message,
                GoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Selectable = true,
                Filterable = true,
                Sortable = true,
                SelectableWith =
                {
                    "selectable_with6b2ad4c4",
                },
                AttributeResources =
                {
                    "attribute_resources3f8a5e5c",
                },
                Metrics = { "metrics7cd659aa", },
                Segments =
                {
                    "segments982d981f",
                },
                EnumValues =
                {
                    "enum_values30797dbe",
                },
                TypeUrl = "type_urlfde5623b",
                IsRepeated = false,
            };
            mockGrpcClient.Setup(x => x.GetGoogleAdsField(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(expectedResponse);
            GoogleAdsFieldServiceClient client = new GoogleAdsFieldServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GoogleAdsField response = client.GetGoogleAdsField(request.ResourceNameAsGoogleAdsFieldName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Category("Smoke")][Test]
        public async stt::Task GetGoogleAdsFieldResourceNamesAsync()
        {
            moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient> mockGrpcClient = new moq::Mock<GoogleAdsFieldService.GoogleAdsFieldServiceClient>(moq::MockBehavior.Strict);
            GetGoogleAdsFieldRequest request = new GetGoogleAdsFieldRequest
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
            };
            gagvr::GoogleAdsField expectedResponse = new gagvr::GoogleAdsField
            {
                ResourceNameAsGoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Category = gagve::GoogleAdsFieldCategoryEnum.Types.GoogleAdsFieldCategory.Segment,
                DataType = gagve::GoogleAdsFieldDataTypeEnum.Types.GoogleAdsFieldDataType.Message,
                GoogleAdsFieldName = gagvr::GoogleAdsFieldName.FromGoogleAdsField("[GOOGLE_ADS_FIELD]"),
                Selectable = true,
                Filterable = true,
                Sortable = true,
                SelectableWith =
                {
                    "selectable_with6b2ad4c4",
                },
                AttributeResources =
                {
                    "attribute_resources3f8a5e5c",
                },
                Metrics = { "metrics7cd659aa", },
                Segments =
                {
                    "segments982d981f",
                },
                EnumValues =
                {
                    "enum_values30797dbe",
                },
                TypeUrl = "type_urlfde5623b",
                IsRepeated = false,
            };
            mockGrpcClient.Setup(x => x.GetGoogleAdsFieldAsync(request, moq::It.IsAny<grpccore::CallOptions>())).Returns(new grpccore::AsyncUnaryCall<gagvr::GoogleAdsField>(stt::Task.FromResult(expectedResponse), null, null, null, null));
            GoogleAdsFieldServiceClient client = new GoogleAdsFieldServiceClientImpl(mockGrpcClient.Object, null);
            gagvr::GoogleAdsField responseCallSettings = await client.GetGoogleAdsFieldAsync(request.ResourceNameAsGoogleAdsFieldName, gaxgrpc::CallSettings.FromCancellationToken(st::CancellationToken.None));
            Assert.AreEqual(expectedResponse, responseCallSettings);
            gagvr::GoogleAdsField responseCancellationToken = await client.GetGoogleAdsFieldAsync(request.ResourceNameAsGoogleAdsFieldName, st::CancellationToken.None);
            Assert.AreEqual(expectedResponse, responseCancellationToken);
            mockGrpcClient.VerifyAll();
        }
    }
}

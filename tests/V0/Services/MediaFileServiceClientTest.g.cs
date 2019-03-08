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
    public class GeneratedMediaFileServiceClientTest
    {
        [Test]
        public void GetMediaFile()
        {
            Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new Mock<MediaFileService.MediaFileServiceClient>(MockBehavior.Strict);
            GetMediaFileRequest expectedRequest = new GetMediaFileRequest
            {
                ResourceName = new MediaFileName("[CUSTOMER]", "[MEDIA_FILE]").ToString(),
            };
            MediaFile expectedResponse = new MediaFile
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMediaFile(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MediaFileName("[CUSTOMER]", "[MEDIA_FILE]").ToString();
            MediaFile response = client.GetMediaFile(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetMediaFileAsync()
        {
            Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new Mock<MediaFileService.MediaFileServiceClient>(MockBehavior.Strict);
            GetMediaFileRequest expectedRequest = new GetMediaFileRequest
            {
                ResourceName = new MediaFileName("[CUSTOMER]", "[MEDIA_FILE]").ToString(),
            };
            MediaFile expectedResponse = new MediaFile
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMediaFileAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MediaFile>(Task.FromResult(expectedResponse), null, null, null, null));
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            string formattedResourceName = new MediaFileName("[CUSTOMER]", "[MEDIA_FILE]").ToString();
            MediaFile response = await client.GetMediaFileAsync(formattedResourceName);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void GetMediaFile2()
        {
            Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new Mock<MediaFileService.MediaFileServiceClient>(MockBehavior.Strict);
            GetMediaFileRequest request = new GetMediaFileRequest
            {
                ResourceName = new MediaFileName("[CUSTOMER]", "[MEDIA_FILE]").ToString(),
            };
            MediaFile expectedResponse = new MediaFile
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMediaFile(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            MediaFile response = client.GetMediaFile(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task GetMediaFileAsync2()
        {
            Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new Mock<MediaFileService.MediaFileServiceClient>(MockBehavior.Strict);
            GetMediaFileRequest request = new GetMediaFileRequest
            {
                ResourceName = new MediaFileName("[CUSTOMER]", "[MEDIA_FILE]").ToString(),
            };
            MediaFile expectedResponse = new MediaFile
            {
                ResourceName = "resourceName2625949903",
            };
            mockGrpcClient.Setup(x => x.GetMediaFileAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MediaFile>(Task.FromResult(expectedResponse), null, null, null, null));
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            MediaFile response = await client.GetMediaFileAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateMediaFiles()
        {
            Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new Mock<MediaFileService.MediaFileServiceClient>(MockBehavior.Strict);
            MutateMediaFilesRequest expectedRequest = new MutateMediaFilesRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateMediaFilesResponse expectedResponse = new MutateMediaFilesResponse();
            mockGrpcClient.Setup(x => x.MutateMediaFiles(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<MediaFileOperation> operations = new List<MediaFileOperation>();
            MutateMediaFilesResponse response = client.MutateMediaFiles(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateMediaFilesAsync()
        {
            Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new Mock<MediaFileService.MediaFileServiceClient>(MockBehavior.Strict);
            MutateMediaFilesRequest expectedRequest = new MutateMediaFilesRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateMediaFilesResponse expectedResponse = new MutateMediaFilesResponse();
            mockGrpcClient.Setup(x => x.MutateMediaFilesAsync(expectedRequest, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateMediaFilesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            string customerId = "customerId-1772061412";
            IEnumerable<MediaFileOperation> operations = new List<MediaFileOperation>();
            MutateMediaFilesResponse response = await client.MutateMediaFilesAsync(customerId, operations);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public void MutateMediaFiles2()
        {
            Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new Mock<MediaFileService.MediaFileServiceClient>(MockBehavior.Strict);
            MutateMediaFilesRequest request = new MutateMediaFilesRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateMediaFilesResponse expectedResponse = new MutateMediaFilesResponse();
            mockGrpcClient.Setup(x => x.MutateMediaFiles(request, It.IsAny<CallOptions>()))
                .Returns(expectedResponse);
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            MutateMediaFilesResponse response = client.MutateMediaFiles(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

        [Test]
        public async Task MutateMediaFilesAsync2()
        {
            Mock<MediaFileService.MediaFileServiceClient> mockGrpcClient = new Mock<MediaFileService.MediaFileServiceClient>(MockBehavior.Strict);
            MutateMediaFilesRequest request = new MutateMediaFilesRequest
            {
                CustomerId = "customerId-1772061412",
                Operations = { },
            };
            MutateMediaFilesResponse expectedResponse = new MutateMediaFilesResponse();
            mockGrpcClient.Setup(x => x.MutateMediaFilesAsync(request, It.IsAny<CallOptions>()))
                .Returns(new Grpc.Core.AsyncUnaryCall<MutateMediaFilesResponse>(Task.FromResult(expectedResponse), null, null, null, null));
            MediaFileServiceClient client = new MediaFileServiceClientImpl(mockGrpcClient.Object, null);
            MutateMediaFilesResponse response = await client.MutateMediaFilesAsync(request);
            Assert.AreEqual(expectedResponse, response);
            mockGrpcClient.VerifyAll();
        }

    }
}

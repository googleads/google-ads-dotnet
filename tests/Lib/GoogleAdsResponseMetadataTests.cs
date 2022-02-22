// Copyright 2022 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.GoogleAds.Lib;
using Grpc.Core;
using NUnit.Framework;

namespace Google.Ads.GoogleAds.Tests.Lib
{
    /// <summary>
    /// Tests for <see cref="GoogleAdsResponseMetadata"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class GoogleAdsResponseMetadataTests
    {
        private const string REQUEST_ID = "TEST_REQUEST_ID";
        
        /// <summary>
        /// Tests if request ID can be retrieved from metadata.
        /// </summary>
        [Test]
        public void TestGetRequestIdFromMetadata()
        {
            Metadata metadata = new Metadata();
            metadata.Add("key1", "value1");
            metadata.Add("key2", "value2");

            Assert.IsNull(new GoogleAdsResponseMetadata(metadata).RequestId);

            metadata.Add(MetadataKeyNames.RequestId, REQUEST_ID);
            Assert.AreEqual(REQUEST_ID, new GoogleAdsResponseMetadata(metadata).RequestId);
        }

        /// <summary>
        /// Tests if request ID can be retrieved from response.
        /// </summary>
        [Test]
        public void TestGetRequestIdFromResponse()
        {
            HelloStreamResponse response = new HelloStreamResponse()
            {
                RequestId = REQUEST_ID
            };
            Assert.AreEqual(REQUEST_ID, new GoogleAdsResponseMetadata(response).RequestId);
        }
    }
}

// Copyright 2019 Google LLC
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

using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Util;

using NUnit.Framework;

using System;
using System.IO;
using System.Text;

namespace Google.Ads.GoogleAds.Tests.Util
{
    /// <summary>
    /// UnitTests for <see cref="MediaUtilities"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    [Parallelizable(ParallelScope.Self)]
    internal class MediaUtilitiesTest
    {
        private const string FILE_CONTENTS = "Hello world";

        private Uri fileUri = null;

        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
            String fileName = Path.GetTempFileName();
            using (StreamWriter writer = new StreamWriter(fileName))
            {
                writer.Write(FILE_CONTENTS);
            }
            fileUri = new Uri(fileName);
        }

        /// <summary>
        /// Tears down this instance.
        /// </summary>
        [TearDown]
        public void Teardown()
        {
            File.Delete(fileUri.AbsolutePath);
        }

        /// <summary>
        /// Tests if data can be retrieved from a URL.
        /// </summary>
        [Test]
        public void TestGetAssetDataFromUrl1()
        {
            byte[] data = MediaUtilities.GetAssetDataFromUrl(fileUri, new GoogleAdsConfig());
            Assert.AreEqual(FILE_CONTENTS, Encoding.UTF8.GetString(data));
        }

        /// <summary>
        /// Tests if data can be retrieved from a URL.
        /// </summary>
        [Test]
        public void TestGetAssetDataFromUrl2()
        {
            byte[] data = MediaUtilities.GetAssetDataFromUrl(fileUri.AbsoluteUri,
                new GoogleAdsConfig());
            Assert.AreEqual(FILE_CONTENTS, Encoding.UTF8.GetString(data));
        }
        
        /// <summary>
        /// Tests if data can be asynchronously retrieved from a URL.
        /// </summary>
        [Test]
        public async Task TestGetAssetDataFromUrlAsync1()
        {
            byte[] data = await MediaUtilities.GetAssetDataFromUrlAsync(fileUri, new GoogleAdsConfig());
            Assert.AreEqual(FILE_CONTENTS, Encoding.UTF8.GetString(data));
        }

        /// <summary>
        /// Tests if data can be asynchronously retrieved from a URL.
        /// </summary>
        [Test]
        public async Task TestGetAssetDataFromUrlAsync2()
        {
            byte[] data = await MediaUtilities.GetAssetDataFromUrlAsync(fileUri.AbsoluteUri,
                new GoogleAdsConfig());
            Assert.AreEqual(FILE_CONTENTS, Encoding.UTF8.GetString(data));
        }
    }
}

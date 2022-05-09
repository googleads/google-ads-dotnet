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

using Google.Ads.Gax.Util;
using Google.Ads.Gax.Config;

using NUnit.Framework;

using System;
using System.Net;

namespace Google.Ads.GoogleAds.Tests.Util
{
    /// <summary>
    /// UnitTests for <see cref="HttpUtilities"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class HttpUtilitiesTest
    {
        private const string TEST_URL = "http://www.example.com";
        private const string TEST_METHOD = "GET";
        private readonly WebProxy TEST_PROXY = new WebProxy("http://localhost:8888");
        private const int TEST_TIMEOUT = 100000;

        private AdsConfig TEST_CONFIG;

        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
            TEST_CONFIG = new AdsConfig()
            {
                Proxy = TEST_PROXY,
                Timeout = TEST_TIMEOUT,
            };
        }

        /// <summary>
        /// Tests if the BuildRequest method throws an exception when a null configuration is
        /// provided.
        /// </summary>
        [Test]
        [Category("Small")]
        public void TestBuildRequestThrowsErrorForNullConfig()
        {
            Assert.Throws(typeof(ArgumentNullException), delegate ()
            {
                WebRequest request = HttpUtilities.BuildRequest(TEST_URL, TEST_METHOD, null);
            });
        }

        /// <summary>
        /// Tests if a request can be built with provided data.
        /// </summary>
        [Test]
        [Category("Small")]
        public void TestBuildRequest()
        {
            WebRequest request = HttpUtilities.BuildRequest(TEST_URL, TEST_METHOD, TEST_CONFIG);
            Assert.AreEqual(request.Proxy, TEST_PROXY);
            Assert.AreEqual(request.Method, TEST_METHOD);
            Assert.AreEqual(request.RequestUri, TEST_URL);
            Assert.AreEqual(request.Timeout, TEST_TIMEOUT);
        }
    }
}

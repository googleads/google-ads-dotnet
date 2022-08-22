// Copyright 2020 Google LLC
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

using Google.Ads.Gax.Config;
using Google.Ads.Gax.Lib;
using Grpc.Core;
using NUnit.Framework;

namespace Google.Ads.Gax.Tests.Lib
{
    /// <summary>
    /// Tests for <see cref="CachedChannelFactory"/> class.
    /// </summary>
    [TestFixture]
    [Category("Flaky")]
    internal class CachedChannelFactoryTests
    {
        private AdsConfig config = new AdsConfig()
        {
            OAuth2Scope = "TEST_OAUTH2_SCOPE"
        };
        private const string TEST_SERVER_URL = "https://ignored.com";
        CachedChannelFactory factory = new CachedChannelFactory();

        /// <summary>
        /// Check if the channel factory caches instances on subsequent calls.
        /// </summary>
        [Test]
        public void TestGetChannelIsCached()
        {
            ChannelBase channel1 = factory.GetChannel(config, TEST_SERVER_URL);
            ChannelBase channel2 = factory.GetChannel(config, TEST_SERVER_URL);

            Assert.AreSame(channel1, channel2);
        }

        /// <summary>
        /// Check if the channel factory doesn't cache instances on subsequent calls
        /// when the cache is disabled.
        /// </summary>
        [Test]
        public void TestGetChannelCanBeDisabled()
        {
            AdsConfig configNoCache = new AdsConfig()
            {
                UseChannelCache = false,
                OAuth2Scope = "TEST_OAUTH2_SCOPE"
            };

            ChannelBase channel1 = factory.GetChannel(configNoCache, TEST_SERVER_URL);
            ChannelBase channel2 = factory.GetChannel(configNoCache, TEST_SERVER_URL);

            Assert.AreNotSame(channel1, channel2);
        }
    }
}

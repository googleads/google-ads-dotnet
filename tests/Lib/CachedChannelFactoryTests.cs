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

using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Lib;
using Grpc.Core;
using NUnit.Framework;

namespace Google.Ads.GoogleAds.Tests.Lib
{
    /// <summary>
    /// Tests for <see cref="CachedChannelFactory"/> class.
    /// </summary>
    [TestFixture]
    [Category("Flaky")]
    internal class CachedChannelFactoryTests
    {
        private GoogleAdsConfig config = new GoogleAdsConfig();
        CachedChannelFactory factory = new CachedChannelFactory();

        /// <summary>
        /// Check if the channel factory caches instances on subsequent calls.
        /// </summary>
        [Test]
        public void TestGetChannelIsCached()
        {
            Channel channel1 = factory.GetChannel(config);
            Channel channel2 = factory.GetChannel(config);

            Assert.AreSame(channel1, channel2);
        }

        /// <summary>
        /// Check if the channel factory doesn't cache instances on subsequent calls
        /// when the cache is disabled.
        /// </summary>
        [Test]
        public void TestGetChannelCanBeDisabled()
        {
            GoogleAdsConfig configNoCache = new GoogleAdsConfig()
            {
                UseChannelCache = false
            };

            Channel channel1 = factory.GetChannel(configNoCache);
            Channel channel2 = factory.GetChannel(configNoCache);

            Assert.AreNotSame(channel1, channel2);
        }

        /// <summary>
        /// Check if the channel factory removes closed channels from the cache.
        /// </summary>
        [Test]
        public void TestGetChannelRemovesClosedChannels()
        {
            Channel channel1 = factory.GetChannel(config);
            channel1.ShutdownAsync().Wait();

            Channel channel2 = factory.GetChannel(config);
            Assert.AreNotSame(channel1, channel2);
        }
    }
}

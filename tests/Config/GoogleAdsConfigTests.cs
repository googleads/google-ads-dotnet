// Copyright 2018 Google LLC
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
using NUnit.Framework;

using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Tests.Config {

  /// <summary>
  /// Tests for <see cref="GoogleAdsConfig"/> class.
  /// </summary>
  [TestFixture]
  [Category("Smoke")]
  internal class GoogleAdsConfigTests : GoogleAdsConfig {

    /// <summary>
    /// Test value for <see cref="GoogleAdsConfig.ServerUrl"/> property.
    /// </summary>
    private const string SERVER_URL_VALUE = "TEST_SERVER_URL";

    /// <summary>
    /// Test value for <see cref="GoogleAdsConfig.Timeout"/> property.
    /// </summary>
    private const int TIMEOUT_VALUE = 5000;

    /// <summary>
    /// The test configuration settings.
    /// </summary>
    private readonly Dictionary<string, string> CONFIG_SETTINGS =
        new Dictionary<string, string>() {
      { "ServerUrl",  SERVER_URL_VALUE },
      { "Timeout", TIMEOUT_VALUE.ToString() }
    };

    /// <summary>
    /// Tests the <see cref="GoogleAdsConfig.ReadSettings(Dictionary{string, string})"/> method.
    /// </summary>
    [Test]
    public void TestReadSettings() {
      ReadSettings(CONFIG_SETTINGS);
      Assert.AreEqual(SERVER_URL_VALUE, this.ServerUrl);
      Assert.AreEqual(TIMEOUT_VALUE, this.Timeout);
    }
  }
}

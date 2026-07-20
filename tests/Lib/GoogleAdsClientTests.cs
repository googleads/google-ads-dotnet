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

using Google.Ads.GoogleAds.Lib;

using NUnit.Framework;

using System.Reflection;

namespace Google.Ads.GoogleAds.Tests.Lib {

  /// <summary>
  /// Tests for <see cref="GoogleAdsClient"/> class.
  /// </summary>
  internal class GoogleAdsClientTests {
    private GoogleAdsClient googleAdsClient = new GoogleAdsClient();

    /// <summary>
    /// Tests if all the available service types can be created.
    /// </summary>
    [Test]
    public void TestGetService() {
      MethodInfo method = typeof(GoogleAdsClient).GetMethod("GetService");
      StubIntegrityTestHelper.EnumerateServices<Services>(
        delegate (System.Type serviceSignatureType) {
          Assert.DoesNotThrow(delegate () {
            MethodInfo genericMethod = method.MakeGenericMethod(
                serviceSignatureType.GenericTypeArguments);
            object result = genericMethod.Invoke(googleAdsClient, new object[] { null });
          });
        });
    }
  }
}

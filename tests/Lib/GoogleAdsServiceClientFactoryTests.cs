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
using Google.Ads.GoogleAds.Lib;
using NUnit.Framework;
using System.Collections.Generic;
using System.Reflection;

namespace Google.Ads.GoogleAds.Tests.Lib
{
    internal class GoogleAdsServiceClientFactoryTests
    {
        private GoogleAdsServiceClientFactory serviceClientFactory =
            new GoogleAdsServiceClientFactory();

        private GoogleAdsConfig config = new GoogleAdsConfig();

        /// <summary>
        /// Tests if all the available service types can be created.
        /// </summary>
        [Test]
        public void TestGetService()
        {
            MethodInfo method = typeof(GoogleAdsServiceClientFactory).GetMethod("GetService",
                BindingFlags.NonPublic | BindingFlags.Instance);
            StubIntegrityTestHelper.EnumerateServices<Services>(
              delegate (System.Type serviceSignatureType)
              {
                  Assert.DoesNotThrow(delegate ()
                  {
                      List<System.Type> arguments = new List<System.Type>(
                          serviceSignatureType.GenericTypeArguments);
                      arguments.Add(typeof(GoogleAdsConfig));
                      MethodInfo genericMethod = method.MakeGenericMethod(
                          serviceSignatureType.GenericTypeArguments);
                      object result = genericMethod.Invoke(serviceClientFactory,
                          new object[] { null, config });
                  });
              });
        }
    }
}

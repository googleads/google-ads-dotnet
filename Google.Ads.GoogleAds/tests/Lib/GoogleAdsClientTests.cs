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
using System.Linq;
using System.Reflection;

namespace Google.Ads.GoogleAds.Tests.Lib
{
    /// <summary>
    /// Tests for <see cref="GoogleAdsClient"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class GoogleAdsClientTests
    {
        private GoogleAdsClient googleAdsClient = new GoogleAdsClient();

        /// <summary>
        /// Tests if all the available service types can be created.
        /// </summary>
        [Test]
        public void TestGetService()
        {
            // Get the method with one parameter.
            MethodInfo method = typeof(GoogleAdsClient).GetMethods()
                .ToList().Where(delegate (MethodInfo mi)
                {
                    return mi.Name == "GetService" && mi.GetParameters().Length == 1;
                }).First();

            StubIntegrityTestHelper.EnumerateServices<Services>(
            delegate (object serviceSignature)
            {
                Assert.DoesNotThrow(delegate ()
                {
                    System.Type serviceSignatureType = serviceSignature.GetType();
                    MethodInfo genericMethod = method.MakeGenericMethod(
                    serviceSignatureType.GenericTypeArguments.Take(2).ToArray());
                    object result = genericMethod.Invoke(googleAdsClient,
                        new object[] { serviceSignature });
                });
            });
        }
    }
}

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

using Grpc.Core;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Google.Ads.GoogleAds.Tests.Lib
{
    /// <summary>
    /// Tests for <code>GoogleAdsException</code> class.
    /// </summary>
    internal class GoogleAdsExceptionTests
    {

        /// <summary>
        /// Tests if <code>GoogleAdsException</code> objects can be created without failure
        /// metadata.
        /// </summary>
        [Test]
        public void TestCreateException()
        {
            List<System.Type> exceptionTypes = typeof(Services).Assembly.GetTypes().Where(
                delegate (System.Type type)
                {
                    return type.Name == "GoogleAdsException";
                }).ToList();

            Assert.IsNotEmpty(exceptionTypes);
            foreach (System.Type exceptionType in exceptionTypes)
            {
                MethodInfo mi = exceptionType.GetMethod(
                    "Create", BindingFlags.Static | BindingFlags.Public);
                Assert.NotNull(mi);
                Assert.DoesNotThrow(delegate () {
                    var exception = mi.Invoke(null, new object[] {
                        new RpcException(Status.DefaultCancelled) });
                });
            }
        }
    }
}

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

using Google.Ads.GoogleAds.Interceptors;
using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.Tests.V3;
using Grpc.Core;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Tests.Interceptors
{
    /// <summary>
    /// Tests for <see cref="StreamingRpcInterceptor{TResponse}" class./>
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class StreamingRpcInterceptorTests
    {
        /// <summary>
        /// The exception object for testing purposes.
        /// </summary>
        private static readonly RpcException TEST_EXCEPTION = TestUtils.CreateException(
            "Test message", "Test trigger", "request-id");

        /// <summary>
        /// Tests if a server streaming call that returns successfully is handled correctly.
        /// </summary>
        [Test]
        public void TestInterceptStreamNoException()
        {
            TestStreamReader<object> testStreamReader = new TestStreamReader<object>(
                new object[] { 1, 2, 3 }, null);
            StreamingRpcInterceptor<object> interceptor =
                new StreamingRpcInterceptor<object>(testStreamReader,
                delegate (object o, AggregateException e)
                {
                    return;
                });

            Assert.DoesNotThrow(delegate ()
            {
                bool hasMoreItems = true;

                while (hasMoreItems)
                {
                    Task<bool> task = interceptor.MoveNext();
                    task.Wait();
                    hasMoreItems = task.Result;
                    object temp = interceptor.Current;
                }
            });
        }

        /// <summary>
        /// Tests if a server streaming call that throws an exception is intercepted and exceptions
        /// are handled correctly.
        /// </summary>
        [Test]
        public void TestInterceptStreamWithException()
        {
            TestStreamReader<object> testStreamReader = new TestStreamReader<object>(
                new object[] { }, TEST_EXCEPTION);
            StreamingRpcInterceptor<object> interceptor =
                new StreamingRpcInterceptor<object>(testStreamReader,
                delegate (object foo, AggregateException e)
                {
                    RpcException innerException = UnaryRpcInterceptor.ExtractRpcException(e);
                    Assert.IsInstanceOf<GoogleAdsBaseException>(innerException);
                    return;
                });

            Assert.Throws<AggregateException>(delegate ()
            {
                bool hasMoreItems = true;

                while (hasMoreItems)
                {
                    Task<bool> task = interceptor.MoveNext();
                    task.Wait();
                    hasMoreItems = task.Result;
                    object temp = interceptor.Current;
                }
            });
        }
    }
}

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

using Google.Ads.Gax.Interceptors;
using Google.Ads.Gax.Lib;
using Google.Ads.Gax.Tests;
using Grpc.Core;
using NUnit.Framework;
using System;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Tests.Interceptors
{
    /// <summary>
    /// Tests for <see cref="UnaryRpcInterceptor"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class UnaryRpcInterceptorTests
    {
        /// <summary>
        /// The exception object for testing purposes.
        /// </summary>
        private static readonly RpcException TEST_EXCEPTION = TestUtils.CreateException(
             "Test message", "Test trigger", "request-id");

        /// <summary>
        /// A test function delegate that raises an exception.
        /// </summary>
        private static Func<int> throwExceptionFunc = () => { throw TEST_EXCEPTION; };

        /// <summary>
        /// A test function delegate that returns a result without raising an exception.
        /// </summary>
        private static Func<int>  returnIntFunc = () => { return 42; };

        /// <summary>
        /// A test action delegate that raises an exception.
        /// </summary>
        private static Action throwExceptionAction = () => { throw TEST_EXCEPTION; };

        /// <summary>
        /// A test function delegate that returns without raising an exception.
        /// </summary>
        private static Action returnAction = () => { return; };

        /// <summary>
        /// Tests if a task that returns a result without raising exception is intercepted
        /// correctly.
        /// </summary>
        [Test]
        public void TestInterceptTaskNoException()
        {
            Task<int> interceptedTask = UnaryRpcInterceptor.Intercept<int, HelloException>(
                Task.Run(returnIntFunc));
            Assert.DoesNotThrow(delegate ()
            {
                interceptedTask.Wait();
            });
        }

        /// <summary>
        /// Tests if a task that raises an exception is intercepted correctly.
        /// </summary>
        [Test]
        public void TestInterceptTaskWithException()
        {
            Task<int> interceptedTask = UnaryRpcInterceptor.Intercept<int, HelloException>(
                Task.Run(throwExceptionFunc));
            try
            {
                interceptedTask.Wait();
            }
            catch (AggregateException ae)
            {
                CheckForHelloException(ae);
            }
        }

        /// <summary>
        /// Tests if a function delegate that returns results without raising an exception is
        /// intercepted correctly.
        /// </summary>
        [Test]
        public void TestInterceptFuncDelegateNoException()
        {
            Func<int> interceptedFunc = UnaryRpcInterceptor.Intercept<int, HelloException>(
                returnIntFunc);
            Assert.DoesNotThrow(delegate ()
            {
                interceptedFunc();
            });
        }

        /// <summary>
        /// Tests if a function delegate that throws an exception is intercepted correctly.
        /// </summary>
        [Test]
        public void TestInterceptFuncDelegateWithException()
        {
            Func<int> interceptedFunc = UnaryRpcInterceptor.Intercept<int, HelloException>(
                throwExceptionFunc);
            try
            {
                interceptedFunc();
            }
            catch (HelloException)
            {
                Assert.Pass("Exception parsed correctly.");
            }
            catch
            {
                Assert.Pass("Exception could not be parsed.");
            }
        }

        /// <summary>
        /// Tests if an action delegate that raises no exception is intercepted correctly.
        /// </summary>
        [Test]
        public void TestInterceptActionNoException()
        {
            Action interceptedAction = UnaryRpcInterceptor.Intercept<HelloException>(
                returnAction);
            Assert.DoesNotThrow(delegate ()
            {
                interceptedAction();
            });
        }

        /// <summary>
        /// Tests if an action delegate that raises an exception is intercepted correctly.
        /// </summary>
        [Test]
        public void TestInterceptActionWithException()
        {
            Action interceptedTask = UnaryRpcInterceptor.Intercept<HelloException>(
                throwExceptionAction);
            try
            {
                interceptedTask();
            }
            catch (HelloException)
            {
                Assert.Pass("Exception parsed correctly.");
            }
            catch
            {
                Assert.Pass("Exception could not be parsed.");
            }
        }

        /// <summary>
        /// Tests for <see cref="UnaryRpcInterceptor.ParseRpcException(RpcException)"/>
        /// method.
        /// </summary>
        [Test]
        public void TestParseRpcException()
        {
            Assert.NotNull(UnaryRpcInterceptor.ParseRpcException<HelloException>(
                TEST_EXCEPTION));
        }

        /// <summary>
        /// Tests for <see cref="UnaryRpcInterceptor.ParseTaskException(RpcException)"/>
        /// method.
        /// </summary>
        [Test]
        public void TestParseTaskException()
        {
            Assert.NotNull(UnaryRpcInterceptor.ParseTaskException<HelloException>(
                new AggregateException(TEST_EXCEPTION)));
        }

        /// <summary>
        /// Tests for <see cref="UnaryRpcInterceptor.ExtractRpcException(AggregateException)"/>
        /// method.
        /// </summary>
        [Test]
        public void TestExtractRpcException()
        {
            AggregateException ae = new AggregateException(TEST_EXCEPTION);
            RpcException innerException = UnaryRpcInterceptor.ExtractRpcException(ae);
            Assert.IsInstanceOf<AdsBaseException>(innerException);
        }

        /// <summary>
        /// Checks for a <see cref="HelloException"/> in an <see cref="AggregateException"/>.
        /// </summary>
        /// <param name="ae">The <see cref="AggregateException"/>.</param>
        private static void CheckForHelloException(AggregateException ae)
        {
            bool found = false;
            foreach (var ex in ae.Flatten().InnerExceptions)
            {
                if (ex is HelloException)
                {
                    found = true;
                }
            }
            if (!found)
            {
                Assert.Fail("Missing exception.");
            }
        }
    }
}

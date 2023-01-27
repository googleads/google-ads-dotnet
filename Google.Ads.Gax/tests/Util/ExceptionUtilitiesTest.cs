// Copyright 2023 Google LLC
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

using Google.Ads.Gax.Lib;
using Google.Ads.Gax.Util;
using Google.Apis.Auth.OAuth2.Responses;
using Grpc.Core;
using NUnit.Framework;
using System;
using System.Linq;

namespace Google.Ads.Gax.Tests.Util
{
    /// <summary>
    /// UnitTests for <see cref="ExceptionUtilities"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    [Parallelizable(ParallelScope.Self)]
    internal class ExceptionUtilitiesTest
    {
        /// <summary>
        /// A Google Ads Exception object for test purposes.
        /// </summary>
        internal sealed class MyGoogleAdsException : AdsBaseException<AdsFailure>
        {
            /// <summary>
            private MyGoogleAdsException(Status status, string message) : base(status, message) { }

            private MyGoogleAdsException(Status status, Metadata trailers) : base(status, trailers)
            {
            }

            public static AdsBaseException Create(RpcException rpcException)
            {
                return (rpcException.Trailers != null)
                    ? new MyGoogleAdsException(rpcException.Status, rpcException.Trailers)
                    : new MyGoogleAdsException(rpcException.Status, rpcException.Message);
            }

            public static MyGoogleAdsException FromTaskException(AggregateException ae)
            {
                return ae.Flatten().InnerExceptions.Where((Exception ex) =>
                {
                    return ex is MyGoogleAdsException;
                }).FirstOrDefault() as MyGoogleAdsException;
            }
        }

        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
        }

        /// <summary>
        /// Tears down this instance.
        /// </summary>
        [TearDown]
        public void Teardown()
        {
        }

        /// <summary>
        /// Tests the <see cref="ExceptionUtilities.ParseRpcException{TResponse}(RpcException)"
        /// method./>
        /// </summary>
        [Test]
        public void TestParseRpcException()
        {
            AdsFailure failure = new AdsFailure()
            {
                Id = 42,
                Text = "Hello world"
            };
            RpcException rpcException = CreateAdsRpcException(failure);
            MyGoogleAdsException myException =
                (MyGoogleAdsException)ExceptionUtilities.ParseRpcException<AdsFailure>(
                    rpcException);
            Assert.IsNotNull(myException);
            Assert.AreEqual(failure.Id, myException.Failure.Id);
            Assert.AreEqual(failure.Text, myException.Failure.Text);
        }

        /// <summary>
        /// Tests the <see cref="ExceptionUtilities.ParseOAuthException(RpcException)" method./>
        /// </summary>
        [Test]
        public void ParseOAuthException()
        {
            RpcException rpcException = new RpcException(new Status(StatusCode.Internal,
                TestResources.OAuthException));
            TokenResponseException oAuthException = ExceptionUtilities.ParseOAuthException(
                rpcException);
            AssertOAuthException(oAuthException);
        }

        /// <summary>
        /// Tests the <see cref="ExceptionUtilities.ParseOAuthException(AggregateException)"
        /// method./>
        /// </summary>
        [Test]
        public void ParseOAuthAggregateException()
        {
            RpcException rpcException = new RpcException(new Status(StatusCode.Internal,
                TestResources.OAuthException));
            AggregateException aggregateException = new AggregateException(rpcException);
            TokenResponseException oAuthException = ExceptionUtilities.ParseOAuthException(
                aggregateException);
            AssertOAuthException(oAuthException);
        }

        /// <summary>
        /// Tests the <see cref="ExceptionUtilities.ExtractRpcException(AggregateException)"
        /// method./>
        /// </summary>
        [Test]
        public void TestExtractRpcException()
        {
            RpcException rpcException = new RpcException(
                new Status(StatusCode.Unavailable, "Unavailable Test"));
            AggregateException aggregateException = new AggregateException(rpcException);
            Assert.AreSame(rpcException,
                ExceptionUtilities.ExtractRpcException(aggregateException));
        }

        /// <summary>
        /// Asserts the OAuth exception.
        /// </summary>
        /// <param name="oAuthException">The OAuth exception to validate.</param>
        private static void AssertOAuthException(TokenResponseException oAuthException)
        {
            Assert.AreEqual("Bad Request", oAuthException.Error.ErrorDescription);
            Assert.AreEqual("http://example.com", oAuthException.Error.ErrorUri);
            Assert.AreEqual("invalid_grant", oAuthException.Error.Error);
        }

        /// <summary>
        /// Creates an Ads RPC exception for testing purposes.
        /// </summary>
        /// <param name="failure">The Ads failure object to wrap..</param>
        /// <returns>A wrapped RPC exception.</returns>
        private static RpcException CreateAdsRpcException(AdsFailure failure)
        {
            Status status = new Status(StatusCode.Internal, "Unavailable Test");
            Metadata metadata = new Metadata();

            string key = ProtobufUtilities.GetBinarySerializationKeyName<AdsFailure>();
            byte[] data = ProtobufUtilities.Serialize(failure);
            metadata.Add(key, data);
            return new RpcException(status, metadata);
        }
    }
}
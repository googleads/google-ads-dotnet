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

using Google.Ads.GoogleAds.Lib;
using Google.Ads.GoogleAds.V8.Errors;
using Google.Ads.GoogleAds.V8.Services;
using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;
using System.Linq;
using static Google.Ads.GoogleAds.V8.Errors.ErrorLocation.Types;

namespace Google.Ads.GoogleAds.Tests.V8.Errors
{
    /// <summary>
    /// UnitTests for extensions in GoogleAdsFailureExtensionsTests.cs.
    /// </summary>
    [TestFixture]
    internal class GoogleAdsFailureExtensionsTests
    {
        private static readonly FieldPathElement OPERATIONS = new FieldPathElement()
        {
            FieldName = "operations",
        };

        private static readonly FieldPathElement OPERATIONS_WITH_INDEX = new FieldPathElement()
        {
            FieldName = "operations",
            Index = 2
        };

        private static readonly FieldPathElement CREATE = new FieldPathElement()
        {
            FieldName = "create",
        };

        private static readonly FieldPathElement NAME = new FieldPathElement()
        {
            FieldName = "name",
        };

        private static readonly FieldPathElement NAME_WITH_INDEX = new FieldPathElement()
        {
            FieldName = "name",
            Index = 1
        };

        private static readonly GoogleAdsError OPERATIONS_2_NAME = CreateError(
            // operations[2].create.name
            new FieldPathElement[] { OPERATIONS_WITH_INDEX, CREATE, NAME }
        );

        private static readonly GoogleAdsError OPERATIONS_NAME = CreateError(
            // operations.create.name
            new FieldPathElement[] { OPERATIONS, CREATE, NAME }
        );

        private static readonly GoogleAdsError OPERATIONS_2_NAME_INDEX = CreateError(
            // operations[2].create.name
            new FieldPathElement[] { OPERATIONS_WITH_INDEX, CREATE, NAME_WITH_INDEX }
        );

        /// <summary>
        /// Check if GetErrorsByOperationIndex method can retrieve errors by specified index.
        /// </summary>
        [Test]
        public void TestGetErrorsByOperationIndexWithErrors()
        {
            GoogleAdsFailure failure = new GoogleAdsFailure();
            failure.Errors.Add(OPERATIONS_2_NAME);

            // There are no errors for index = 0.
            Assert.AreEqual(failure.GetErrorsByOperationIndex(0).ToList().Count, 0);

            // There is one error for index = 2.
            Assert.AreEqual(failure.GetErrorsByOperationIndex(2).ToList().Count, 1);
        }

        /// <summary>
        /// Check if GetErrorsByOperationIndex method can retrieve errors when the GoogleAdsFailure
        /// has no errors.
        /// </summary>
        [Test]
        public void TestGetErrorsByOperationIndexWhenNoErrors()
        {
            GoogleAdsFailure failure = new GoogleAdsFailure();
            Assert.AreEqual(failure.GetErrorsByOperationIndex(0).ToList().Count, 0);
        }

        /// <summary>
        /// Check if GetErrorsByOperationIndex method can retrieve an empty list of errors when
        /// errors don't have any Location field set.
        /// </summary>
        [Test]
        public void TestGetErrorsByOperationIndexNoLocation()
        {
            GoogleAdsFailure failure = new GoogleAdsFailure();
            failure.Errors.Add(new GoogleAdsError());
            Assert.AreEqual(failure.GetErrorsByOperationIndex(0).ToList().Count, 0);
        }

        /// <summary>
        /// Check if GetErrorsByOperationIndex method can retrieve an empty list of errors when
        /// operations don't have an index.
        /// </summary>
        [Test]
        public void TestGetErrorsByOperationIndexNoOperationIndex()
        {
            GoogleAdsFailure failure = new GoogleAdsFailure();

            failure.Errors.AddRange(new GoogleAdsError[] { OPERATIONS_NAME });
            Assert.AreEqual(failure.GetErrorsByOperationIndex(0).ToList().Count, 0);
        }

        /// <summary>
        /// Tests for <see cref="GoogleAdsError.CombinedFieldPath"/> property.
        /// </summary>
        [Test]
        public void TestCombinedFieldPath()
        {
            Assert.AreEqual("operations[2].create.name", OPERATIONS_2_NAME.CombinedFieldPath);
            Assert.AreEqual("operations.create.name", OPERATIONS_NAME.CombinedFieldPath);
            Assert.AreEqual("operations[2].create.name[1]",
                OPERATIONS_2_NAME_INDEX.CombinedFieldPath);

            // If the location is empty, you get back
            Assert.IsEmpty(new GoogleAdsError().CombinedFieldPath);
        }

        /// <summary>
        /// Check if IsEmpty message evaluates to false for a non-empty message.
        /// </summary>
        [Test]
        public void TestIsEmptyForNonEmptyMessage()
        {
            MutateAdGroupResult successResult = new MutateAdGroupResult()
            {
                ResourceName = "TEST",
            };
            Assert.False(successResult.IsEmpty());
        }

        /// <summary>
        /// Check if IsEmpty message evaluates to true for an empty message.
        /// </summary>
        [Test]
        public void TestIsEmptyForEmptyMessage()
        {
            MutateAdGroupResult failedResult = new MutateAdGroupResult();
            Assert.True(failedResult.IsEmpty());
        }

        /// <summary>
        /// Verify that PartialFailure property can correctly deserialize a GoogleAdsFailure object.
        /// </summary>
        [Test]
        public void TestPartialFailureDeserialization()
        {
            GoogleAdsFailure failure = new GoogleAdsFailure();
            failure.Errors.Add(OPERATIONS_2_NAME);
            MutateAdGroupsResponse failedResponse = new MutateAdGroupsResponse()
            {
                PartialFailureError = GetStatus(failure)
            };

            Assert.True(failedResponse.PartialFailure.Equals(failure));
        }

        /// <summary>
        /// Tests for PartialFailure property of Response objects when there is no error.
        /// </summary>
        [Test]
        public void TestPartialFailureWithNoErrors()
        {
            MutateAdGroupsResponse failedResponse = new MutateAdGroupsResponse()
            {
                PartialFailureError = null
            };

            Assert.Null(failedResponse.PartialFailure);
        }

        /// <summary>
        /// Wraps a <see cref="GoogleAdsFailure"/> in an Rpc.Status object.
        /// </summary>
        /// <param name="failure">The failure.</param>
        /// <returns>The wrapped Rpc.Status.</returns>
        private static Rpc.Status GetStatus(GoogleAdsFailure failure)
        {
            Rpc.Status status = new Rpc.Status();
            status.Details.Add(Any.Pack(failure));
            return status;
        }

        /// <summary>
        /// Creates a <see cref="GoogleAdsError"/> object for testing purposes.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="operationIndex">Index of the operation.</param>
        /// <returns>A GoogleAdsError instance.</returns>
        private static GoogleAdsError CreateError(FieldPathElement[] fieldPathElements)
        {
            GoogleAdsError error = new GoogleAdsError()
            {
                Location = new ErrorLocation()
                {
                }
            };
            error.Location.FieldPathElements.AddRange(fieldPathElements);
            return error;
        }
    }
}

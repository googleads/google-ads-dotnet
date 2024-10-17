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

using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Reflection;

namespace Google.Ads.GoogleAds.Tests.Lib
{
    /// <summary>
    /// UnitTests for extensions in GoogleAdsFailureExtensionsTests.cs.
    /// </summary>
    [TestFixture("16")]
    [TestFixture("17")]
    [TestFixture("18")]
    internal class GoogleAdsFailureExtensionsTests
    {
        private string apiVersion;

        private static readonly string NAMESPACE_PREFIX = "Google.Ads.GoogleAds";
        private static readonly string ASSEMBLY_NAME = "Google.Ads.GoogleAds";

        public GoogleAdsFailureExtensionsTests(string apiVersion)
        {
            this.apiVersion = apiVersion;
        }

        /// <summary>
        /// Check if GetErrorsByOperationIndex method can retrieve errors by specified index.
        /// </summary>
        [Test]
        public void TestGetErrorsByOperationIndexWithErrors()
        {
            dynamic googleAdsFailure = CreateGoogleAdsFailure();

            googleAdsFailure.Errors.Add(Operations2Name());

            // There are no errors for index = 0.
            Assert.AreEqual(googleAdsFailure.GetErrorsByOperationIndex(0).Count, 0);

            // There is one error for index = 2.
            Assert.AreEqual(googleAdsFailure.GetErrorsByOperationIndex(2).Count, 1);
        }

        /// <summary>
        /// Check if GetErrorsByOperationIndex method can retrieve errors when the GoogleAdsFailure
        /// has no errors.
        /// </summary>
        [Test]
        public void TestGetErrorsByOperationIndexWhenNoErrors()
        {
            dynamic googleAdsFailure = CreateGoogleAdsFailure();
            Assert.AreEqual(googleAdsFailure.GetErrorsByOperationIndex(0).Count, 0);
        }

        /// <summary>
        /// Check if GetErrorsByOperationIndex method can retrieve an empty list of errors when
        /// errors don't have any Location field set.
        /// </summary>
        [Test]
        public void TestGetErrorsByOperationIndexNoLocation()
        {
            dynamic googleAdsFailure = CreateGoogleAdsFailure();

            googleAdsFailure.Errors.Add(CreateGoogleAdsError());

            Assert.AreEqual(googleAdsFailure.GetErrorsByOperationIndex(0).Count, 0);
        }

        /// <summary>
        /// Check if GetErrorsByOperationIndex method can retrieve an empty list of errors when
        /// operations don't have an index.
        /// </summary>
        [Test]
        public void TestGetErrorsByOperationIndexNoOperationIndex()
        {
            dynamic failure = CreateGoogleAdsFailure();

            failure.Errors.Add(OperationsName());

            Assert.AreEqual(failure.GetErrorsByOperationIndex(0).Count, 0);
        }

        /// <summary>
        /// Tests for <see cref="GoogleAdsError.CombinedFieldPath"/> property.
        /// </summary>
        [Test]
        public void TestCombinedFieldPath()
        {
            Assert.AreEqual("operations[2].create.name", Operations2Name().CombinedFieldPath);
            Assert.AreEqual("operations.create.name", OperationsName().CombinedFieldPath);
            Assert.AreEqual("operations[2].create.name[1]",
                Operations2NameIndex().CombinedFieldPath);

            // If the location is empty, you get back
            Assert.IsEmpty(CreateGoogleAdsError().CombinedFieldPath);
        }

        /// <summary>
        /// Verify that PartialFailure property can correctly deserialize a GoogleAdsFailure object.
        /// </summary>
        [Test]
        public void TestPartialFailureDeserialization()
        {
            dynamic failure = CreateGoogleAdsFailure();
            failure.Errors.Add(Operations2Name());

            dynamic failedResponse = CreateMutateAdGroupsResponse();
            failedResponse.PartialFailureError = GetStatus(failure);

            Assert.True(failedResponse.PartialFailure.Equals(failure));
        }

        /// <summary>
        /// Tests for PartialFailure property of Response objects when there is no error.
        /// </summary>
        [Test]
        public void TestPartialFailureWithNoErrors()
        {
            dynamic failedResponse = CreateMutateAdGroupsResponse();
            failedResponse.PartialFailureError = null;

            Assert.Null(failedResponse.PartialFailure);
        }

        /// <summary>
        /// Creates a <see cref="GoogleAdsFailure"> object for testing purposes.
        /// </summary>
        /// <returns>A GoogleAdsFailure instance.</returns>
        private dynamic CreateGoogleAdsFailure()
        {
            var type = System.Type.GetType($"{NAMESPACE_PREFIX}.V{apiVersion}.Errors.GoogleAdsFailure,{ASSEMBLY_NAME}");
            return Activator.CreateInstance(type);
        }

        /// <summary>
        /// Creates an empty <see cref="GoogleAdsError"> object for testing purposes.
        /// </summary>
        /// <returns>A GoogleAdsError instance.</returns>
        private dynamic CreateGoogleAdsError()
        {
            var type = System.Type.GetType($"{NAMESPACE_PREFIX}.V{apiVersion}.Errors.GoogleAdsError,{ASSEMBLY_NAME}");
            return Activator.CreateInstance(type);
        }

        /// <summary>
        /// Creates a <see cref="MutateAdGroupsResponse"> object for testing purposes.
        /// </summary>
        /// <returns>A MutateAdGroupsResponse instance.</returns>
        private dynamic CreateMutateAdGroupsResponse()
        {
            var type = System.Type.GetType($"{NAMESPACE_PREFIX}.V{apiVersion}.Services.MutateAdGroupsResponse,{ASSEMBLY_NAME}");
            return Activator.CreateInstance(type);
        }

        /// <summary>
        /// Creates a <see cref="FieldPathElement"> object for testing purposes.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="index">Index of the operation.</param>
        /// <returns>A FieldPathElement instance.</returns>
        private dynamic CreateFieldPathElement(string fieldName, int index = 0)
        {
            System.Type fieldPathElementType = GetFieldPathElementType();
            dynamic fieldPathElement = Convert.ChangeType(Activator.CreateInstance(fieldPathElementType), fieldPathElementType);

            fieldPathElement.FieldName = fieldName;

            if (index != 0) {
                fieldPathElement.Index = index;
            }

            return fieldPathElement;
        }

        /// <summary>
        /// Creates a <see cref="GoogleAdsError"> object with a failure in the `operations.create.name` field
        /// for testing purposes.
        /// </summary>
        /// <returns>A GoogleAdsError instance.</returns>
        private dynamic OperationsName()
        {
            return CreateError(new List<dynamic>() {
                CreateFieldPathElement("operations"),
                CreateFieldPathElement("create"),
                CreateFieldPathElement("name")
            });
        }

        /// <summary>
        /// Creates a <see cref="GoogleAdsError"> object with a failure in the `operations[2].create.name` field
        /// for testing purposes.
        /// </summary>
        /// <returns>A GoogleAdsError instance.</returns>
        private dynamic Operations2Name()
        {
            return CreateError(
                // operations[2].create.name
                new List<dynamic>() {
                    CreateFieldPathElement("operations", 2),
                    CreateFieldPathElement("create"),
                    CreateFieldPathElement("name")
                }
            );
        }

        /// <summary>
        /// Creates a <see cref="GoogleAdsError"> object with a failure in the `operations[2].create.name[1]` field
        /// for testing purposes.
        /// </summary>
        /// <returns>A GoogleAdsError instance.</returns>
        private dynamic Operations2NameIndex()
        {
            return CreateError(
                // operations[2].create.name
                new List<dynamic>() {
                    CreateFieldPathElement("operations", 2),
                    CreateFieldPathElement("create"),
                    CreateFieldPathElement("name", 1)
                }
            );
        }

        /// <summary>
        /// Returns the System.Type for the current API version for FieldPathElement
        /// </summary>
        /// <returns>A System.Type instance.</returns>
        private System.Type GetFieldPathElementType()
        {
            var type =
                System.Type.GetType($"{NAMESPACE_PREFIX}.V{apiVersion}.Errors.ErrorLocation,{ASSEMBLY_NAME}");

            return type.GetTypeInfo().GetNestedTypes()[0].GetNestedTypes()[0];
        }

        /// <summary>
        /// Creates a <see cref="GoogleAdsError"/> object for testing purposes.
        /// </summary>
        /// <param name="fieldName">Name of the field.</param>
        /// <param name="operationIndex">Index of the operation.</param>
        /// <returns>A GoogleAdsError instance.</returns>
        private dynamic CreateError(List<dynamic> fieldPathElements)
        {
            dynamic error = CreateGoogleAdsError();

            var errorLocationType =
                System.Type.GetType($"{NAMESPACE_PREFIX}.V{apiVersion}.Errors.ErrorLocation,{ASSEMBLY_NAME}");

            dynamic errorLocation = Convert.ChangeType(Activator.CreateInstance(errorLocationType), errorLocationType);
            error.Location = errorLocation;

            fieldPathElements.ForEach(t => error.Location.FieldPathElements.Add(t));
            return error;
        }

        /// <summary>
        /// Wraps a <see cref="GoogleAdsFailure"/> in an Rpc.Status object.
        /// </summary>
        /// <param name="failure">The failure.</param>
        /// <returns>The wrapped Rpc.Status.</returns>
        private static Rpc.Status GetStatus(dynamic failure)
        {
            Rpc.Status status = new Rpc.Status();
            status.Details.Add(Any.Pack(failure));
            return status;
        }
    }
}
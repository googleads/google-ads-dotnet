// Copyright 2018, Google LLC. All Rights Reserved.
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

using Google.Ads.GoogleAds.Util;
using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;
using NUnit.Framework.Interfaces;

using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Ads.GoogleAds.Tests.Util
{
    /// <summary>
    /// Tests for <see cref="FieldMasks"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class FieldMasksTest
    {
        /// <summary>
        /// Gets the proto test cases.
        /// </summary>
        internal static IEnumerable<ITestCaseData> ProtoTestCases
        {
            get;
        } =
            LoadTestSuite().TestCases.Select(c => new TestCaseData(c)
            {
                TestName = c.Description
            }).ToList();

        /// <summary>
        /// Tests for <see cref="FieldMasks.FromChanges{T}(Protobuf.IMessage{T}, Protobuf.IMessage{T})"/>
        /// method.
        /// </summary>
        /// <param name="testCase">The test case.</param>
        [Test]
        [TestCaseSource(nameof(ProtoTestCases))]
        public void TestFromChanges(TestCase testCase)
        {
            FieldMask actual = FieldMasks.FromChanges(testCase.OriginalResource,
                testCase.ModifiedResource);
            Assert.AreEqual(testCase.ExpectedMask, actual);
        }

        /// <summary>
        /// Loads the test suite.
        /// </summary>
        /// <returns>The test suite</returns>
        private static TestSuite LoadTestSuite()
        {
            string json;
            using (var stream = typeof(FieldMasksTest).Assembly.GetManifestResourceStream(
                "Google.Ads.GoogleAds.Tests.Util.field_mask_tests.json"))
            {
                json = new StreamReader(stream).ReadToEnd();
            }
            return TestSuite.Parser.ParseJson(json);
        }
    }
}

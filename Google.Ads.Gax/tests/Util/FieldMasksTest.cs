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

using Google.Ads.Gax.Util;
using Google.Protobuf.WellKnownTypes;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Google.Ads.Gax.Tests.Util
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
                "Google.Ads.Gax.Tests.Util.field_mask_tests.json"))
            {
                json = new StreamReader(stream).ReadToEnd();
            }
            return TestSuite.Parser.ParseJson(json);
        }

        [Test]
        public void TestGetFieldValue()
        {
            Resource r1 = new Resource()
            {
                Foo = new Foo()
                {
                    Bar = new Bar()
                    {
                        Num = 5,
                    },
                    Num = 25,
                    Text = "hello world",
                    Bars = {
                        new Bar()
                        {
                            Num = 10
                        }
                    }
                },
                Foos =
                {
                    new Foo()
                    {
                        Num = 42
                    }
                },
                OptFoos = 45,
                Wrapper = "Test wrapper"
            };

            // Object references should be tested using AreSame.
            Assert.AreSame(FieldMasks.GetFieldValue("foo", r1), r1.Foo);
            Assert.AreSame(FieldMasks.GetFieldValue("foo.bar", r1), r1.Foo.Bar);
            Assert.AreSame(FieldMasks.GetFieldValue("foo.bars", r1), r1.Foo.Bars);
            Assert.AreSame(FieldMasks.GetFieldValue("foos", r1), r1.Foos);
            Assert.AreSame(FieldMasks.GetFieldValue("wrapper", r1), r1.Wrapper);

            // Value type should be tested using AreEqual.
            Assert.AreEqual(FieldMasks.GetFieldValue("foo.bar.num", r1), r1.Foo.Bar.Num);
            Assert.AreEqual(FieldMasks.GetFieldValue("foo.num", r1), r1.Foo.Num);
            Assert.AreEqual(FieldMasks.GetFieldValue("foo.text", r1), r1.Foo.Text);
            Assert.AreEqual(FieldMasks.GetFieldValue("opt_foos", r1), r1.OptFoos);

            Resource r2 = new Resource()
            {
                OptFoos = 32
            };

            Assert.IsNull(FieldMasks.GetFieldValue("foo.bar", r2));
            Assert.Throws<ArgumentException>(delegate () {
                // r2.Jazz is not a valid field.
                FieldMasks.GetFieldValue("jazz", r2);
            });
            Assert.Throws<ArgumentException>(delegate () {
                // r2.OptFoos.Blah cannot be recursed because OptFoos is a leaf level node.
                FieldMasks.GetFieldValue("opt_foos.blah", r2);
            });
            Assert.Throws<ArgumentException>(delegate () {
                // You cannot recurse r2.Foos because it is a repeated field.
                FieldMasks.GetFieldValue("foos.blah", r2);
            });
        }
    }
}

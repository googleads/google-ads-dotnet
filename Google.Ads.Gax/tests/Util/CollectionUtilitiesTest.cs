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

using Google.Ads.Gax.Util;

using NUnit.Framework;

using System.Collections.Generic;

namespace Google.Ads.Gax.Tests.Util
{
    /// <summary>
    /// UnitTests for <see cref="CollectionUtilities"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class CollectionUtilitiesTest
    {
        private const long value = long.MinValue;
        private const string invalidKey = "INVALID_KEY";
        private const string validKey = "VALID_KEY";

        private Dictionary<string, long> dictionary;

        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
            dictionary = new Dictionary<string, long>() {
                {validKey, value}
            };
        }

        /// <summary>
        /// Test for <see cref="CollectionUtilities.GetValueOrDefault{S, T}(Dictionary{S, T}, S)"/>
        /// </summary>
        [Test]
        public void TestGetValueOrDefault()
        {
            // Ensure that requesting an invalid key with no default specified returns the default
            // value for that type.
            Assert.AreEqual(0L, CollectionUtilities.GetValueOrDefault(dictionary, invalidKey));

            long validValue = dictionary[validKey];

            // Ensure requesting a valid key returns the expected value.
            Assert.AreEqual(validValue, CollectionUtilities.GetValueOrDefault(
                dictionary, validKey));

            // Ensure requesting an invalid key with a default specified returns the specified
            // default.
            Assert.AreEqual(validValue,CollectionUtilities.GetValueOrDefault(
                dictionary, invalidKey, validValue));
        }
    }
}

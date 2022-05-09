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

using Google.Ads.Gax.Util;

using NUnit.Framework;
using static Google.Ads.Gax.Tests.HelloStatusEnum.Types;

namespace Google.Ads.GoogleAds.Gax.Util
{
    /// <summary>
    /// UnitTests for <see cref="ProtobufUtilities"/> class.
    /// </summary>
    [TestFixture]
    [Category("Smoke")]
    internal class ProtobufUtilitiesTest
    {
        /// <summary>
        /// Test for <see cref="ProtobufUtilities.GetOriginalEnumFieldName(object)"/>
        /// </summary>
        [Test]
        public void TestGetOriginalEnumFieldName()
        {
            // Enum value and proto enum value are different.
            Assert.AreEqual("IN_PROCESS", ProtobufUtilities.GetOriginalEnumFieldName(
                HelloStatus.InProcess));

            // Enum value and proto enum value are same.
            Assert.AreEqual("EXPIRED", ProtobufUtilities.GetOriginalEnumFieldName(
                HelloStatus.Expired));
        }
    }
}
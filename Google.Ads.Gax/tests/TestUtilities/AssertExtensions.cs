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

using NUnit.Framework;

namespace Google.Ads.Gax.Tests
{
    /// <summary>
    /// Extension methods for <see cref="Assert"/> class.
    /// </summary>
    public class AssertExtensions
    {
        /// <summary>
        /// Adds an assertion for checking the equality of multiline texts.
        /// </summary>
        /// <param name="expected">The expected text.</param>
        /// <param name="actual">The actual text.</param>
        public static void AreMultiLineEqual(string expected, string actual)
        {
            Assert.AreEqual(CleanupMultiLineText(expected), CleanupMultiLineText(actual));
        }

        /// <summary>
        /// Cleanups the multi line text.
        /// </summary>
        /// <param name="text">The text to be cleaned up.</param>
        /// <returns>The cleaned up text.</returns>
        private static string CleanupMultiLineText(string text)
        {
            return text.Trim().Replace("\r\n", "\n");
        }
    }
}

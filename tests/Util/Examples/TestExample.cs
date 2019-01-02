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

using Google.Ads.GoogleAds.Examples;
using Google.Ads.GoogleAds.Lib;
using NUnit.Framework;

namespace Google.Ads.GoogleAds.Tests.Util.Examples.V0
{
    /// <summary>
    /// A Test example for running <see cref="ExampleRunnerTest"/>.
    /// </summary>
    /// <seealso cref="Google.Ads.GoogleAds.Examples.ExampleBase" />
    public class TestExample : ExampleBase
    {
        internal const long LONG_ARG1 = 12345;
        internal const long LONG_ARG2 = 34567;
        internal const long LONG_ARG3 = 56789;

        internal const string STRING_ARG1 = "string1";
        internal const string STRING_ARG2 = "string2";

        internal const string SINGLE_STRING_ARG = "singleString1";
        internal const long SINGLE_LONG_ARG = 345546788;

        internal const string STRING_ARGS_NAME = "stringArgs";
        internal const string SINGLE_STRING_ARG_NAME = "singleStringArg";
        internal const string LONG_ARGS_NAME = "longArgs";
        internal const string SINGLE_LONG_ARG_NAME = "singleLongArg";

        internal const string TEST_EXAMPLE_NAME = "V0.TestExample";
        internal const string TEST_EXAMPLE_DESCRIPTION = "Test example";

        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public override string Description
        {
            get
            {
                return TEST_EXAMPLE_DESCRIPTION;
            }
        }

        /// <summary>
        /// Runs the specified client.
        /// </summary>
        /// <param name="client">The client.</param>
        /// <param name="stringArgs">The string arguments.</param>
        /// <param name="longArgs">The long arguments.</param>
        /// <param name="singleStringArg">The single string argument.</param>
        /// <param name="singleLongArg">The single long argument.</param>
        public void Run(GoogleAdsClient client, string[] stringArgs,
            long[] longArgs, string singleStringArg, long singleLongArg)
        {
            Assert.AreEqual(stringArgs, new string[] { STRING_ARG1, STRING_ARG2 });
            Assert.AreEqual(longArgs, new long[] { LONG_ARG1, LONG_ARG2, LONG_ARG3 });
            Assert.AreEqual(SINGLE_STRING_ARG, singleStringArg);
            Assert.AreEqual(SINGLE_LONG_ARG, singleLongArg);
        }
    }

    /// <summary>
    /// A Test example for running <see cref="ExampleRunnerTest"/>. This example has no Run method.
    /// </summary>
    /// <seealso cref="Google.Ads.GoogleAds.Examples.ExampleBase" />
    public class NoRunTestExample : ExampleBase
    {
        public const string TEST_EXAMPLE_NAME = "V0.NoRunTestExample";
        public const string TEST_EXAMPLE_DESCRIPTION = "No Run Test example";

        public override string Description
        {
            get
            {
                return TEST_EXAMPLE_DESCRIPTION;
            }
        }
    }
}

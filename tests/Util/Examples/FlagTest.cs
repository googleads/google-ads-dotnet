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
using Google.Ads.GoogleAds.Tests.Util.Examples.V0;
using NUnit.Framework;
using System;
using System.Reflection;

namespace Google.Ads.GoogleAds.Tests.Util.Examples
{
    /// <summary>
    /// UnitTests for <see cref="Flag{T}"/>  and <see cref="Flags"/> classes.
    /// </summary>
    [TestFixture]
    public class FlagTest
    {
        internal const string STRING_FLAG = "stringFlag";
        internal const string STRING_REPEATED_FLAG = "stringRepeatFlag";
        internal const string STRING_ARG1 = "stringArg1";
        internal const string STRING_ARG2 = "stringArg2";
        internal const string LONG_FLAG = "longFlag";
        internal const long LONG_ARG1 = 1234;

        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
        }

        /// <summary>
        /// Test for Value and Values properties for non-repeatable flags.
        /// </summary>
        [Test]
        public void TestValuesForNonRepeatAbleFlag()
        {
            Flag<string> stringFlag = new Flag<string>($"--{STRING_FLAG}=", "", false);

            // Initially, the flag is empty.
            Assert.AreEqual(default(string), stringFlag.Value);

            // After adding a value, that value comes back in both Value and Values.
            stringFlag.Parse(STRING_ARG1);
            Assert.AreEqual(STRING_ARG1, stringFlag.Value);

            // When trying to add another value, an ArgumentException is thrown.
            Assert.Throws(typeof(ArgumentException), 
                delegate ()
                {
                    stringFlag.Parse(STRING_ARG2);
                }
            );
        }

        /// <summary>
        /// Test for Value and Values properties for non-repeatable flags.
        /// </summary>
        [Test]
        public void TestValuesForRepeatAbleFlag()
        {
            Flag<string> stringFlag = new Flag<string>($"--{STRING_REPEATED_FLAG}=", "", true);

            // Initially, the flag is empty.
            Assert.IsEmpty(stringFlag.Values);

            // After adding a value, that value comes back in both Value and Values.
            stringFlag.Parse(STRING_ARG1);
            Assert.AreEqual(new string[] { STRING_ARG1 }, stringFlag.Values);
            
            // After adding another value, the value still gives the first value, but values gives
            // the full list.
            stringFlag.Parse(STRING_ARG2);
            Assert.AreEqual(new string[] { STRING_ARG1, STRING_ARG2 }, stringFlag.Values);
        }

        /// <summary>
        /// Test for Invalid operations on Value and Values properties.
        /// </summary>
        [Test]
        public void TestValuesForInvalidOperation()
        {
            Flag<string> stringFlag = null;

            // Invalid operation is thrwn if the flag is repeatable, and Value property is invoked.
            stringFlag = new Flag<string>($"--{STRING_REPEATED_FLAG}=", "", true);

            Assert.Throws(typeof(InvalidOperationException), delegate ()
            {
                var temp = stringFlag.Value;
            });

            // Invalid operation is thrown if the flag is non-repeatable, and Values property is
            // invoked.
            stringFlag = new Flag<string>($"--{STRING_REPEATED_FLAG}=", "", false);

            Assert.Throws(typeof(InvalidOperationException), delegate ()
            {
                var temp = stringFlag.Values;
            });
        }


        /// <summary>
        /// Test for OnParse method.
        /// </summary>
        [Test]
        public void TestOnParse()
        {
            Flag<long> longFlag = new Flag<long>($"--{LONG_FLAG}=", "", false);

            // Verify that a long value can be sucessfully parsed by a long flag.
            longFlag.Parse(LONG_ARG1.ToString());
            Assert.AreEqual(LONG_ARG1, longFlag.Value);

            // Reset the flag.
            longFlag.Reset();

            // Verify that an ArgumentException is thrown when a long flag cannot parse an input
            // into a long flag.
            Assert.Throws(typeof(ArgumentException), 
                delegate ()
                {
                    longFlag.Parse(STRING_ARG2);
                }
            );
        }

        /// <summary>
        /// Test for Reset method.
        /// </summary>
        [Test]
        public void TestReset()
        {
            Flag<string> stringFlag = null;

            // Test for single value flag.
            stringFlag = new Flag<string>($"--{STRING_FLAG}=", "", false);

            // Initially, the flag is empty.
            Assert.AreEqual(default(string), stringFlag.Value);

            // After adding a value, that value comes back in Value.
            stringFlag.Parse(STRING_ARG1);
            Assert.AreEqual(STRING_ARG1, stringFlag.Value);

            // After resetting, the flag is empty again.
            stringFlag.Reset();
            Assert.AreEqual(default(string), stringFlag.Value);

            // Test for repeatable value flag.
            stringFlag = new Flag<string>($"--{STRING_FLAG}=", "", true);

            // Initially, the flag is empty.
            Assert.IsEmpty(stringFlag.Values);

            // After adding a value, that value comes back in Values.
            stringFlag.Parse(STRING_ARG1);
            Assert.AreEqual(new string[] { STRING_ARG1 }, stringFlag.Values);

            // After resetting, the flag is empty again.
            stringFlag.Reset();
            Assert.IsEmpty(stringFlag.Values);
        }

        /// <summary>
        /// Test for <see cref="Flags.Parse(IEnumerable{string}, Flag[])"/> method.
        /// </summary>
        [Test]
        public void TestParse()
        {
            Flag<string> stringFlags = new Flag<string>($"--{TestExample.STRING_ARGS_NAME}=",
                "", true);
            Flag<long> longFlags = new Flag<long>($"--{TestExample.LONG_ARGS_NAME}=", "", true);
            Flag<string> singleStringFlag =
                new Flag<string>($"--{TestExample.SINGLE_STRING_ARG_NAME}=", "", false);
            Flag<long> singleLongFlag =
                new Flag<long>($"--{TestExample.SINGLE_LONG_ARG_NAME}=", "", false);

            string[] args = new string[]
            {
                $"--{TestExample.STRING_ARGS_NAME}={TestExample.STRING_ARG1}",
                $"--{TestExample.STRING_ARGS_NAME}={TestExample.STRING_ARG2}",
                $"--{TestExample.LONG_ARGS_NAME}={TestExample.LONG_ARG1}",
                $"--{TestExample.LONG_ARGS_NAME}={TestExample.LONG_ARG2}",
                $"--{TestExample.LONG_ARGS_NAME}={TestExample.LONG_ARG3}",
                $"--{TestExample.SINGLE_STRING_ARG_NAME}={TestExample.SINGLE_STRING_ARG}",
                $"--{TestExample.SINGLE_LONG_ARG_NAME}={TestExample.SINGLE_LONG_ARG}"
            };
            Flag[] flags = new Flag[]
            {
                stringFlags, longFlags, singleStringFlag, singleLongFlag
            };

            Flags.Parse(args, flags);

            Assert.AreEqual(stringFlags.Values, new string[] {
                TestExample.STRING_ARG1, TestExample.STRING_ARG2 });
            Assert.AreEqual(longFlags.Values, new long[] {
                TestExample.LONG_ARG1, TestExample.LONG_ARG2, TestExample.LONG_ARG3 });
            Assert.AreEqual(singleStringFlag.Value, TestExample.SINGLE_STRING_ARG);
            Assert.AreEqual(singleLongFlag.Value, TestExample.SINGLE_LONG_ARG);
        }

        /// <summary>
        /// Test for <see cref="Flags.FromParameterInfo(ParameterInfo)"/> method.
        /// </summary>
        [Test]
        public void TestFromParameterInfo()
        {
            MethodInfo methodInfo = this.GetType().GetMethod(
                "TestMethod", BindingFlags.NonPublic | BindingFlags.Instance);

            ParameterInfo[] paramInfos = methodInfo.GetParameters();
            VerifyFlag<int>(paramInfos[0], "--intArgs=", true);
            VerifyFlag<long>(paramInfos[1], "--longArg=", false);
        }

        /// <summary>
        /// Convert the parameter info into flag and verify its properties.
        /// </summary>
        /// <typeparam name="T">The expected type of the flag.</typeparam>
        /// <param name="paramInfo">The parameter information.</param>
        /// <param name="expectedFlagPrototype">The expected flag prototype.</param>
        /// <param name="expectedIsRepeatable">The expected value for the flag's IsRepeatable
        /// property.</param>
        private static void VerifyFlag<T>(ParameterInfo paramInfo, string expectedFlagPrototype,
            bool expectedIsRepeatable)
        {
            // Convert the first parameter info into flag and verify its properties.
            Flag<T> flag = Flags.FromParameterInfo(paramInfo) as Flag<T>;
            Assert.IsNotNull(flag);
            Assert.AreEqual(expectedIsRepeatable, flag.IsRepeatable);
            Assert.AreEqual(expectedFlagPrototype, flag.Prototype);
        }

        /// <summary>
        /// Empty method for running TestFromParameterInfo method. 
        /// </summary>
        /// <param name="intArgs">The int arguments.</param>
        /// <param name="longArg">The long argument.</param>
        private void TestMethod(int[] intArgs, long longArg) { }
    }
}

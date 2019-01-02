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
using Google.Ads.GoogleAds.Tests.Util.Examples.V0;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.IO;

namespace Google.Ads.GoogleAds.Tests.Util.Examples
{
    /// <summary>
    /// UnitTests for <see cref="CollectionUtilitiesTest"/> class.
    /// </summary>
    [TestFixture]
    public class ExampleRunnerTest
    {
        private ExampleRunner runner;

        /// <summary>
        /// Inits this instance.
        /// </summary>
        [SetUp]
        public void Init()
        {
            runner = new ExampleRunner();
            runner.LoadCodeExamples(this.GetType().Assembly);
        }

        /// <summary>
        /// Test for <see cref="ExampleRunner.PrintAvailableExamples"/>
        /// </summary>
        [Test]
        public void TestPrintAvailableExamples()
        {
            CaptureConsoleIOAndExecute(
                delegate ()
                {
                    runner.PrintAvailableExamples();
                },
                delegate (string output)
                {
                    string[] outputs = output.Split(new char[] { '\r', '\n' },
                        StringSplitOptions.RemoveEmptyEntries);
                    string[] expectedOutputs = new string[] {
                        $"{TestExample.TEST_EXAMPLE_NAME} : {TestExample.TEST_EXAMPLE_DESCRIPTION}",
                        $"{NoRunTestExample.TEST_EXAMPLE_NAME} : {NoRunTestExample.TEST_EXAMPLE_DESCRIPTION}"
                    };
                    Assert.That(outputs, Is.EquivalentTo(expectedOutputs));
                }
            );
        }

        /// <summary>
        /// Test for <see cref="ExampleRunner.Run(string, GoogleAdsClient, IEnumerable{string})"/>
        /// </summary>
        [Test]
        public void TestRun()
        {
            GoogleAdsClient client = new GoogleAdsClient();

            // Verify that you can run an example with the right set of arguments.
            CaptureConsoleIOAndExecute(
                delegate ()
                {
                    runner.Run(TestExample.TEST_EXAMPLE_NAME, client, new string[] {
                        $"--{TestExample.STRING_ARGS_NAME}={TestExample.STRING_ARG1}",
                        $"--{TestExample.STRING_ARGS_NAME}={TestExample.STRING_ARG2}",
                        $"--{TestExample.LONG_ARGS_NAME}={TestExample.LONG_ARG1}",
                        $"--{TestExample.LONG_ARGS_NAME}={TestExample.LONG_ARG2}",
                        $"--{TestExample.LONG_ARGS_NAME}={TestExample.LONG_ARG3}",
                        $"--{TestExample.SINGLE_STRING_ARG_NAME}={TestExample.SINGLE_STRING_ARG}",
                        $"--{TestExample.SINGLE_LONG_ARG_NAME}={TestExample.SINGLE_LONG_ARG}"
                    });
                }, null
            );

            // Verify that a KeyNotFoundException is thrown if the specified example
            // is not found.
            CaptureConsoleIOAndExecute(
                delegate ()
                {
                    Assert.Throws(typeof(KeyNotFoundException),
                        delegate ()
                        {
                            runner.Run("V0.NoSuchExample", client, new string[] { });
                        }
                    );
                }, null
            );

            // Verify that a MissingMethodException is thrown if the specified example
            // does not have a Run() method.
            CaptureConsoleIOAndExecute(
                delegate ()
                {
                    Assert.Throws(typeof(MissingMethodException),
                        delegate ()
                        {
                            runner.Run(NoRunTestExample.TEST_EXAMPLE_NAME, client,
                                new string[] { });
                        }
                    );
                }, null
            );

            // Verify that a ArgumentException is thrown if an unknown flag is passed.
            CaptureConsoleIOAndExecute(
                delegate ()
                {
                    Assert.Throws(typeof(ArgumentException),
                        delegate ()
                        {
                            runner.Run(TestExample.TEST_EXAMPLE_NAME, client,
                                new string[] { "--foo=bar" });
                        }
                    );
                }, null
            );
        }

        /// <summary>
        /// Captures the console input + output and execute a method.
        /// </summary>
        /// <param name="functionToRun">The function to run. This function should not read any
        /// input from the console.</param>
        /// <param name="afterRunCallback">The callback to be invoked after
        /// <paramref name="functionToRun"/> completes. The console output is passed as an
        /// argument to the action.</param>
        private void CaptureConsoleIOAndExecute(TestDelegate functionToRun,
            Action<string> afterRunCallback)
        {
            StringWriter writer = new StringWriter();
            TextWriter oldWriter = null;
            TextReader oldReader = null;
            StringReader reader = new StringReader("\r\n");

            try
            {
                // Capture the console input and output.
                oldWriter = Console.Out;
                Console.SetOut(writer);
                oldReader = Console.In;
                Console.SetIn(reader);

                functionToRun?.Invoke();
                afterRunCallback?.Invoke(writer.ToString());
            }
            finally
            {
                // Restore the console input and output.
                Console.SetIn(oldReader);
                Console.SetOut(oldWriter);
            }
        }
    }
}

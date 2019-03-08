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

using Google.Ads.GoogleAds.Lib;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// The Main class for this application.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// The main method.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        public static void Main(string[] args)
        {
            ExampleRunner runner = new ExampleRunner();
            runner.LoadCodeExamples(Assembly.GetExecutingAssembly());

            if (args.Length == 0)
            {
                ShowUsage(runner);
                return;
            }

            GoogleAdsClient session = new GoogleAdsClient();
            string exampleName = args[0];
            try
            {
                runner.Run(exampleName, session, args.Skip(1));
            }
            catch (KeyNotFoundException)
            {
                ShowUsage(runner);
            }
        }

        /// <summary>
        /// Prints program usage message.
        /// </summary>
        private static void ShowUsage(ExampleRunner runner)
        {
            string exeName = Path.GetFileName(Assembly.GetExecutingAssembly().FullName);
            Console.WriteLine("Runs Google Ads API code examples");
            Console.WriteLine("Usage : {0} examplename [flags]\n", exeName);
            Console.WriteLine($"Supported examples: \n");
            runner.PrintAvailableExamples();
            Console.WriteLine("Press [Enter] to continue");
            Console.ReadLine();
        }
    }
}

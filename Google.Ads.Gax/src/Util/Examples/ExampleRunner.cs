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

using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using SystemType = System.Type;

namespace Google.Ads.Gax.Examples
{
    /// <summary>
    /// Helper class for running code examples.
    /// </summary>
    public class ExampleRunner
    {
        /// <summary>
        /// A map to hold the code examples to be executed.
        /// </summary>
        private static SortedDictionary<string, SystemType> codeExampleMap =
            new SortedDictionary<string, SystemType>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Finds the code examples in a given assembly.
        /// </summary>
        /// <param name="assembly">The assembly to search for.</param>
        /// <param name="typesToExclude">List of types to exclude.</param>
        public void LoadCodeExamples(Assembly assembly, SystemType[] typesToExclude)
        {
            lock (codeExampleMap)
            {
                codeExampleMap.Clear();
                SystemType[] types = assembly.GetTypes();

                foreach (SystemType type in types)
                {
                    if (type.IsSubclassOf(typeof(ExampleBase)) && !typesToExclude.Contains(type))
                    {
                        string versionedName = ExampleBase.GetVersionedName(type);
                        string name = ExampleBase.GetName(type);
                        // Support both versioned and unversioned names.
                        // E.g. You can run GetCampaigns example by either using V5.GetCampaigns
                        // or GetCampaigns.
                        codeExampleMap.Add(versionedName, type);
                        if (codeExampleMap.ContainsKey(name))
                        {
                            Console.WriteLine($"Multiple versions of the code example" +
                                $" '{name} was found. Using {name} in command " +
                                $"line will now run {versionedName}. To run a specific" +
                                $"version, use the example name with a version prefix.");
                        }
                        codeExampleMap.Add(name, type);
                    }
                }
            }
        }

        /// <summary>
        /// Finds the code examples in a given assembly.
        /// </summary>
        /// <param name="assembly">The assembly to search for.</param>
        public void LoadCodeExamples(Assembly assembly) =>
            LoadCodeExamples(assembly, new SystemType[] { });

        /// <summary>
        /// Prints the list of available code examples.
        /// </summary>
        public void PrintAvailableExamples()
        {
            foreach (string key in codeExampleMap.Keys)
            {
                Console.WriteLine(key);
            }
        }

        /// <summary>
        /// Returns the system type for a code example name
        /// </summary>
        /// <param name="exampleName">Name of the example.</param>
        public SystemType GetCodeExampleType(string exampleName) {
            SystemType codeExampleType = null;

            string[] splits = exampleName.Split('.');
            string exampleNameWithoutVersion = null;
            if (splits.Length == 2)
            {
                exampleNameWithoutVersion = splits[1];
            }

            if (codeExampleMap.ContainsKey(exampleName))
            {
                codeExampleType = codeExampleMap[exampleName];
            }
            else if (!string.IsNullOrEmpty(exampleNameWithoutVersion) &&
                codeExampleMap.ContainsKey(exampleNameWithoutVersion))
            {
                codeExampleType = codeExampleMap[exampleNameWithoutVersion];
            }

            return codeExampleType;
        }

        /// <summary>
        /// Runs the specified example name.
        /// </summary>
        /// <param name="exampleName">Name of the example.</param>
        /// <param name="args">The arguments.</param>
        /// <exception cref="KeyNotFoundException">Thrown if the example with the specified name
        /// is not found.</exception>
        public void Run(string exampleName, IEnumerable<string> args)
        {
            SystemType codeExampleType = GetCodeExampleType(exampleName);

            if (codeExampleType != null)
            {
                Console.WriteLine($"Requested: '{exampleName}', Loaded: '" +
                    $"{ExampleBase.GetVersionedName(codeExampleType)}'.");
            }
            else
            {
                throw new KeyNotFoundException($"Code example not found: '{exampleName}'.");
            }

            MethodBase method = codeExampleType.GetMethod("Main",
                BindingFlags.Static | BindingFlags.Public);

            if (method == null)
            {
                throw new MissingMethodException($"Main method not found in example: " +
                    $"'{exampleName}'.");
            }
            try
            {
                method.Invoke(null, new object[] { args.ToArray() });
            }
            catch (Exception e)
            {
                StackTrace stackTrace = new StackTrace(e.InnerException);
                StackFrame frame = stackTrace.GetFrame(0);
                if (frame.GetMethod() == method)
                {
                    // The site of the exception was the main method itself. So there was an error
                    // calling the Run() method, typically due to argument errors.
                    throw new ArgumentException("Could not call the Run() method from Main(). " +
                        "Check your arguments.");
                }
                throw e.InnerException;
            }
        }

        /// <summary>
        /// Gets the name of the executable.
        /// </summary>
        /// <returns>The name of the executable.</returns>
        public static string GetExecutableName()
        {
            return Path.GetFileName(Assembly.GetExecutingAssembly().Location);
        }
    }
}

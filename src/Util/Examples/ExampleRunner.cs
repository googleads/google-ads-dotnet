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
using SystemType = System.Type;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// Helper class for running code examples.
    /// </summary>
    public class ExampleRunner
    {
        /// <summary>
        /// A map to hold the code examples to be executed.
        /// </summary>
        private static SortedDictionary<string, ExampleBase> codeExampleMap =
            new SortedDictionary<string, ExampleBase>(StringComparer.OrdinalIgnoreCase);

        /// <summary>
        /// Finds the code examples.
        /// </summary>
        /// <param name="assembly">The assembly.</param>
        public void LoadCodeExamples(Assembly assembly)
        {
            SystemType[] types = assembly.GetTypes();

            foreach (SystemType type in types)
            {
                if (type.IsSubclassOf(typeof(ExampleBase)))
                {
                    ExampleBase example = (ExampleBase) Activator.CreateInstance(type);
                    codeExampleMap.Add(example.Name, example);
                }
            }
        }

        /// <summary>
        /// Prints the list of available code examples.
        /// </summary>
        public void PrintAvailableExamples()
        {
            foreach (ExampleBase codeExample in codeExampleMap.Values)
            {
                Console.WriteLine("{0} : {1}", codeExample.Name, codeExample.Description);
            }
        }

        /// <summary>
        /// Runs the specified example name.
        /// </summary>
        /// <param name="exampleName">Name of the example.</param>
        /// <param name="session">The session.</param>
        /// <param name="args">The arguments.</param>
        /// <exception cref="KeyNotFoundException">Thrown if the example with the specified name
        /// is not found.</exception>
        public void Run(string exampleName, GoogleAdsClient session, IEnumerable<string> args)
        {
            ExampleBase codeExample = null;

            if (!codeExampleMap.TryGetValue(exampleName, out codeExample))
            {
                throw new KeyNotFoundException($"Example not found: {codeExample}");
            }

            Console.WriteLine(codeExample.Description);
            Flag[] flags = GetFlagsFromRunMethodSignature(codeExample);
            if (flags.Length > 0)
            {
                Flags.Parse(args, flags);
            }

            object[] paramValues = BuildExampleParameterList(session, flags);
            MethodInfo runMethod = GetRunMethod(codeExample);
            try
            {
                runMethod.Invoke(codeExample, paramValues);
            }
            catch (Exception e)
            {
                Console.WriteLine("An exception occurred while running this code example. {0}",
                    ExampleUtilities.FormatException(e));
            }
            finally
            {
                Console.WriteLine("Press [Enter] to continue");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// Determines whether the specified type is Nullable.
        /// </summary>
        /// <param name="type">The type.</param>
        /// <returns>True, if the type is nullable, false otherwise.</returns>
        private static bool IsNullable(SystemType type)
        {
            return type.IsGenericType && type.GetGenericTypeDefinition() == typeof(Nullable<>);
        }

        /// <summary>
        /// Builds the parameter list for running a code example.
        /// </summary>
        /// <param name="session">The session.</param>
        /// <param name="flags">The flags.</param>
        /// <returns>The list of parameters for running the code example.</returns>
        private static object[] BuildExampleParameterList(GoogleAdsClient session, Flag[] flags)
        {
            List<object> paramValues = new List<object>() { session };
            foreach (Flag flag in flags)
            {
                paramValues.Add(flag.IsRepeatable ? flag.Values : flag.Value);
            }
            return paramValues.ToArray();
        }

        /// <summary>
        /// Gets the Run method for a code example.
        /// </summary>
        /// <param name="codeExample">The code example.</param>
        /// <returns>The <see cref="MethodInfo"/> object for the <code>Run</code> method.</returns>
        private static MethodInfo GetRunMethod(ExampleBase codeExample)
        {
            return codeExample.GetType().GetMethod("Run");
        }

        /// <summary>
        /// Gets the flags from <code>Run</code> method signature of a code example.
        /// </summary>
        /// <param name="codeExample">The code example.</param>
        /// <returns>A list of flags for running this code example.</returns>
        private static Flag[] GetFlagsFromRunMethodSignature(ExampleBase codeExample)
        {
            // Get the Run method.
            MethodInfo runMethod = GetRunMethod(codeExample);
            if (runMethod == null)
            {
                throw new MissingMethodException(
                    $"Run method is missing in the example: {codeExample.Name}.");
            }
            List<Flag> retval = new List<Flag>();

            // Skip one parameter, since the first parameter is the GoogleAdsClient.
            foreach(ParameterInfo parameterInfo in runMethod.GetParameters().Skip(1))
            {
                retval.Add(Flags.FromParameterInfo(parameterInfo));
            }
            return retval.ToArray();
        }
    }
}

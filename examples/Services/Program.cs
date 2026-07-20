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
using System.Reflection;

using ExamplePair = System.Collections.Generic.KeyValuePair<string,
    Google.Ads.GoogleAds.Examples.ExampleBase>;
using SystemType = System.Type;

namespace Google.Ads.GoogleAds.Examples {

  /// <summary>
  /// The Main class for this application.
  /// </summary>
  internal class Program {

    /// <summary>
    /// A map to hold the code examples to be executed.
    /// </summary>
    private static List<ExamplePair> codeExampleMap = new List<ExamplePair>();

    /// <summary>
    /// A flag to keep track of whether help message was shown earlier.
    /// </summary>
    private static bool helpShown = false;

    /// <summary>
    /// Registers the code example.
    /// </summary>
    /// <param name="key">The code example name.</param>
    /// <param name="value">The code example instance.</param>
    private static void RegisterCodeExample(string key, ExampleBase value) {
      codeExampleMap.Add(new ExamplePair(key, value));
    }

    /// <summary>
    /// Static constructor to initialize the sample map.
    /// </summary>
    static Program() {
      SystemType[] types = Assembly.GetExecutingAssembly().GetTypes();

      foreach (SystemType type in types) {
        if (type.IsSubclassOf(typeof(ExampleBase))) {
          ExampleBase example = (ExampleBase) Activator.CreateInstance(type);
          RegisterCodeExample(type.FullName.Replace(typeof(Program).Namespace + ".", ""), example);
        }
      }
    }

    /// <summary>
    /// The main method.
    /// </summary>
    /// <param name="args">The command line arguments.</param>
    public static void Main(string[] args) {
      if (args.Length == 0) {
        ShowUsage();
        return;
      }

      GoogleAdsClient session = new GoogleAdsClient();

      foreach (string cmdArgs in args) {
        ExamplePair matchingPair = codeExampleMap.Find(delegate (ExamplePair pair) {
          return string.Compare(pair.Key, cmdArgs, true) == 0;
        });

        if (matchingPair.Key != null) {
          RunACodeExample(session, matchingPair.Value);
        } else {
          ShowUsage();
        }
      }
    }

    /// <summary>
    /// Runs a code example.
    /// </summary>
    /// <param name="session">The GoogleAdsClient session for running the code example.</param>
    /// <param name="codeExample">The code example to run.</param>
    private static void RunACodeExample(GoogleAdsClient session, ExampleBase codeExample) {
      try {
        Console.WriteLine(codeExample.Description);
        InvokeRun(codeExample, session);
      } catch (Exception e) {
        Console.WriteLine("An exception occurred while running this code example. {0}",
            ExampleUtilities.FormatException(e));
      } finally {
        Console.WriteLine("Press [Enter] to continue");
        Console.ReadLine();
      }
    }

    /// <summary>
    /// Gets the parameters for running a code example.
    /// </summary>
    /// <param name="session">The GoogleAdsClient session for running the code example.</param>
    /// <param name="codeExample">The code example.</param>
    /// <returns>The list of parameters.</returns>
    private static object[] GetParameters(GoogleAdsClient session, ExampleBase codeExample) {
      MethodInfo methodInfo = codeExample.GetType().GetMethod("Run");
      List<object> parameters = new List<object>();
      parameters.Add(session);
      parameters.AddRange(ExampleUtilities.GetParameters(methodInfo));
      return parameters.ToArray();
    }

    /// <summary>
    /// Invokes the run method.
    /// </summary>
    /// <param name="codeExample">The code example.</param>
    /// <param name="session">The GoogleAdsClient session for running the code example.</param>
    private static void InvokeRun(ExampleBase codeExample, GoogleAdsClient session) {
      MethodInfo methodInfo = codeExample.GetType().GetMethod("Run");
      methodInfo.Invoke(codeExample, GetParameters(session, codeExample));
    }

    /// <summary>
    /// Prints program usage message.
    /// </summary>
    private static void ShowUsage() {
      if (helpShown) {
        return;
      } else {
        helpShown = true;
      }
      string exeName = Path.GetFileName(Assembly.GetExecutingAssembly().Location);
      Console.WriteLine("Runs Google Ads API code examples");
      Console.WriteLine("Usage : {0} [flags]\n", exeName);
      Console.WriteLine("Available flags\n");
      Console.WriteLine("--help\t\t : Prints this help message.", exeName);
      Console.WriteLine("--all\t\t : Run all code examples.", exeName);
      Console.WriteLine("examplename1 [examplename1 ...] : " +
          "Run specific code examples. Example name can be one of the following:\n", exeName);
      foreach (ExamplePair pair in codeExampleMap) {
        Console.WriteLine("{0} : {1}", pair.Key, pair.Value.Description);
      }
      Console.WriteLine("Press [Enter] to continue");
      Console.ReadLine();
    }
  }
}

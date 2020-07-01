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
using Google.Ads.GoogleAds.Util;

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
        /// <returns>The application's exit code.</returns>
        public static int Main(string[] args)
        {
            // Turn on detailed logging. This is useful for debugging your requests.
            // You should also replace INSERT_PATH_TO_DETAILED_LOGS_HERE to a file path that will
            // be used to write the detailed logs to. E.g. C:\\logs\\details.log
            // TraceUtilities.Configure(TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE,
            //    "INSERT_PATH_TO_DETAILED_LOGS_HERE", System.Diagnostics.SourceLevels.All);

            // If the API log doesn't give you enough details, then you can enable more low level
            // logging at grpc level. Keep in mind that this can get pretty detailed and long. The
            // grpc logs are written to stderr.
            // You can find all the supported environment variables here:
            // https://github.com/grpc/grpc/blob/master/doc/environment_variables.md
            // Environment.SetEnvironmentVariable("GRPC_VERBOSITY", "DEBUG");
            // Environment.SetEnvironmentVariable("GRPC_TRACE", "http");

            // If you simply want to try out a code example, you can create an instance of it here,
            // and call it's Run method. E.g.

            // Optional: If you have specified these keys in the App.config file, you can skip
            // creating a GoogleAdsConfig object and do
            // GoogleAdsClient googleAdsClient = new GoogleAdsClient();

            // string developerToken = "INSERT_YOUR_DEVELOPER_TOKEN_HERE";
            // string oAuth2clientId = "INSERT_OAUTH2_CLIENT_ID_HERE";
            // string oAuth2Secret = "INSERT_OAUTH2_CLIENT_SECRET_HERE";
            // string oAuth2RefreshToken = "INSERT_OAUTH2_REFRESH_TOKEN_HERE";
            // long loginCustomerId = long.Parse("INSERT_LOGIN_CUSTOMER_ID_HERE");

            // GoogleAdsConfig googleAdsConfig = new GoogleAdsConfig()
            // {
            //     DeveloperToken = developerToken,
            //     LoginCustomerId = loginCustomerId.ToString(),
            //     OAuth2ClientId = oAuth2clientId,
            //     OAuth2ClientSecret = oAuth2Secret,
            //     OAuth2RefreshToken = oAuth2RefreshToken,
            // };

            //GoogleAdsClient googleAdsClient = new GoogleAdsClient(googleAdsConfig);

            // Run the code example.
            // new V2.GetCampaigns().Run(new GoogleAdsClient(), 1234567890);

            // Alternatively, you can pass command line arguments to run the code example. E.g.
            // V2.GetCampaigns --customerId=1234567890
            // The first argument has the form VersionName.ExampleName, e.g. V2.GetCampaigns to run
            // Google.Ads.GoogleAds.Examples.V2.GetCampaigns example.
            // The subsequent arguments can be inferred by looking at the Run method of the code
            // example and skipping the first parameter.
            // E.g. GetCampaigns.cs has a Run method is defined as
            //
            //     public void Run(GoogleAdsClient client, long customerId)
            //
            // So, this example can be run with the command line arguments
            //
            //     V2.GetCampaigns --customerId=1234567890
            return RunExamplesFromCommandLineArguments(args);
        }

        /// <summary>
        /// Runs the examples from command line arguments.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The application's exit code. The valid return codes are:
        /// /// <list type="bullet">
        /// <item><description>0. The code example ran successfully.</description></item>
        /// <item><description>1. The code example threw an exception and did not complete
        /// successfully.</description></item>
        /// <item><description>2. The application was invoked with an incorrect command line
        /// argument.</description></item>
        /// </list>
        /// </returns>
        private static int RunExamplesFromCommandLineArguments(string[] args)
        {
            ExampleRunner runner = new ExampleRunner();
            runner.LoadCodeExamples(Assembly.GetExecutingAssembly());

            if (args.Length == 0)
            {
                // Bad command line parameter.
                ShowUsage(runner);
                return 2;
            }

            GoogleAdsClient session = new GoogleAdsClient();
            string exampleName = args[0];
            try
            {
                runner.Run(exampleName, session, args.Skip(1));
                return 0;
            }
            catch (TargetInvocationException)
            {
                // Indicates a failure due to an unhandled exception.
                return 1;
            }
            catch (Exception e) when (e is KeyNotFoundException || e is ArgumentException ||
               e is TargetParameterCountException)
            {
                // Bad command line parameter.
                // Note: There are a couple more exceptions that the runner may throw, but all
                // those indicate a failure with the runner implementation than a code example
                // failure.
                ShowUsage(runner);
                return 2;
            } 
        }

        /// <summary>
        /// Prints program usage message.
        /// </summary>
        private static void ShowUsage(ExampleRunner runner)
        {
            string exeName = ExampleRunner.GetExecutableName();
            Console.WriteLine("Runs Google Ads API code examples");
            Console.WriteLine("Usage : dotnet {0} examplename [flags]\n", exeName);
            Console.WriteLine($"Supported examples: \n");
            runner.PrintAvailableExamples();
            Console.WriteLine("Press [Enter] to continue");
            Console.ReadLine();
        }
    }
}

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
        public static void Main(string[] args)
        {
            // Turn on logging. This is useful for debugging your requests.
            TraceUtilities.Configure(TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE,
                "C:\\logs\\details.log", System.Diagnostics.SourceLevels.All);

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
            RunExamplesFromCommandLineArguments(args);
        }

        /// <summary>
        /// Runs the examples from command line arguments.
        /// </summary>
        /// <param name="args">The command line arguments.</param>
        private static void RunExamplesFromCommandLineArguments(string[] args)
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

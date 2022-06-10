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
using System.IO;
using CommandLine;

namespace Google.Ads.Gax.Examples
{

    /// <summary>
    /// Utility class for assisting in running code examples.
    /// </summary>
    public class ExampleUtilities
    {
        /// <summary>
        /// Gets a random string. Useful for generating unique names for campaigns,
        /// ad groups, etc.
        /// </summary>
        /// <returns>The current timestamp as a string.</returns>
        public static string GetRandomString()
        {
            return string.Format("{0} - {1}", Guid.NewGuid(),
                DateTime.Now.ToString("yyyy-M-d H-m-s.ffffff"));
        }

        /// <summary>
        /// Gets a random string. Useful for generating unique names for campaigns,
        /// ad groups, etc.
        /// </summary>
        /// <returns>The current timestamp as a string.</returns>
        public static string GetShortRandomString()
        {
            return Guid.NewGuid().ToString().Substring(0, 8);
        }

        /// <summary>
        /// Formats the exception as a printable message.
        /// </summary>
        /// <param name="ex">The exception.</param>
        /// <returns>The formatted exception string.</returns>
        public static string FormatException(Exception ex)
        {
            List<String> messages = new List<string>();
            Exception rootEx = ex;
            while (rootEx != null)
            {
                messages.Add(String.Format("{0} ({1})\n\n{2}\n", rootEx.GetType().ToString(),
                    rootEx.Message, rootEx.StackTrace));
                rootEx = rootEx.InnerException;
            }
            return String.Join("\nCaused by\n\n", messages.ToArray());
        }

        /// <summary>
        /// Parses the command line.
        /// </summary>
        /// <typeparam name="T">The type of options.</typeparam>
        /// <param name="args">The command line arguments.</param>
        /// <returns>The parsed options.</returns>
        public static T ParseCommandLine<T>(string[] args) where T : OptionsBase, new()
        {
            T options = new T();
            StringWriter memStream = new StringWriter();
            Parser parser = new Parser(settings =>
            {
                settings.CaseInsensitiveEnumValues = true;
                settings.AutoHelp = true;
                settings.HelpWriter = memStream;
            });
            bool hasErrors = false;
            parser.ParseArguments<T>(args).MapResult(
                delegate (T o)
                {
                    options = o;
                    return 0;
                }, delegate (IEnumerable<Error> errors)
                {
                    // We do not process the errors here, we just flip a flag to mark that
                    // the error help content in memStream should be inspected and an exception
                    // should be raised.
                    hasErrors = true;
                    return 0;
                });

            if (hasErrors)
            {
                throw new ArgumentException($"Invalid command line parameters\n {memStream}");
            }
            else
            {
                return options;
            }
        }
    }
}

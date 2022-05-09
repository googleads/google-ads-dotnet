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
    }
}

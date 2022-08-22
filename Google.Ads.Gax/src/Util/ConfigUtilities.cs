// Copyright 2022 Google LLC
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

using Microsoft.Extensions.Configuration;
using System;
using System.Collections;
using System.Diagnostics;
using System.IO;
using System.Reflection;
using System.Xml;

namespace Google.Ads.Gax.Util
{
    /// <summary>
    /// A minimal implementation to replace System.Configuration.ConfigurationManaager.
    /// </summary>
    /// <remarks>We support reading configuration from <code>App.config</code> for legacy reasons,
    /// but most modern applications will either set the configuration at runtime, or use a
    /// <see cref="ConfigurationBuilder"/> instead.</remarks>
    internal class ConfigUtilities
    {
        /// <summary>
        /// Gets the path of the App.config file.
        /// </summary>
        /// <returns>The path to the App.config file, or null if the path cannot be determined.
        /// </returns>
        private static string GetAppConfigPath()
        {
#if NET472
            // On .NET Framework, the path to App.config / Web.config is populated by the runtime.
            return AppDomain.CurrentDomain.SetupInformation.ConfigurationFile;
#else
            // On .NET Core, we attempt to figure out the path by looking at the entry assembly,
            // and falling back to the current process's main module path. This doesn't
            // fully cover the full App.config resolution logic; we only aim to support the
            // minimal use case of App.config residing in the executable's root folder.
            string applicationFilePath = null;
            string appConfigPath = null;
            Assembly entryAssembly = Assembly.GetEntryAssembly();
            if (entryAssembly?.Location.Length == 0)
            {
                using (Process process = Process.GetCurrentProcess())
                {
                    if (process.MainModule != null)
                    {
                        applicationFilePath = process.MainModule.FileName;
                    }
                }
            }
            else
            {
                applicationFilePath = entryAssembly.Location;
            }
            if (applicationFilePath != null)
            {
                // The executable file could be Foo.dll, Foo or Foo.exe depending upon how it
                // was compiled. So we extract the Foo part and construct the rest of the file path
                // ourselves.
                string directoryName = Path.GetDirectoryName(applicationFilePath);
                string applicationNameOnly = Path.GetFileNameWithoutExtension(applicationFilePath);

                return Path.Combine(directoryName, applicationNameOnly) + ".dll.config";
            }
            return appConfigPath;
#endif
        }

        /// <summary>
        /// Gets the section.
        /// </summary>
        /// <param name="sectionName">Name of the section.</param>
        /// <returns>A hashtable with key-value pairs from App.config.</returns>
        internal static Hashtable GetSection(string sectionName)
        {
            Hashtable section = new Hashtable();
            string appConfigFile = GetAppConfigPath();
            XmlDocument xDoc = new XmlDocument();

            try
            {
                xDoc.Load(appConfigFile);
            }
            catch
            {
                // A catch-all is fine here; there might be situations where we cannot
                // resolve the App.config file. ConfigurationManager.GetSection returns
                // an empty dictionary in this case instead of throwing an error.
            }
            finally
            {
                XmlNodeList nodes = xDoc.SelectNodes($"configuration/{sectionName}/child::*");

                foreach (XmlElement node in nodes)
                {
                    string key = node.Attributes["key"].Value;
                    string value = node.Attributes["value"].Value;
                    section[key] = value;
                }
            }
            return section;
        }
    }
}
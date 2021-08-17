// Copyright 2021 Google LLC
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

using CommandLine;
using System.Collections.Generic;
using System.Reflection;
using SystemType = System.Type;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// Base class for code example options class.
    /// </summary>
    public class OptionsBase
    {
        internal static string GetUsage(SystemType type)
        {
            List<string> commands = new List<string>();
            List<string> descriptions = new List<string>();

            if (type != null)
            {
                PropertyInfo[] properties = type.GetProperties();
                foreach (PropertyInfo property in properties)
                {
                    OptionAttribute option = property.GetCustomAttribute<OptionAttribute>();
                    commands.Add($"{option.LongName}=<{option.LongName}>");
                    string requiredPrefix = option.Required ? "Required" : "Optional";
                    descriptions.Add($"[{requiredPrefix}] {option.LongName}: {option.HelpText}");
                }
            }
            return string.Join(" ", commands) + "\n" + string.Join("\n", descriptions);
        }
    }
}

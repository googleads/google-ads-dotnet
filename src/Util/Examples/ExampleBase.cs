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

using System.Text.RegularExpressions;

namespace Google.Ads.GoogleAds.Examples
{
    /// <summary>
    /// This abstract class represents a code example.
    /// </summary>
    public abstract class ExampleBase
    {
        /// <summary>
        /// Returns a description about the code example.
        /// </summary>
        public abstract string Description
        {
            get;
        }

        /// <summary>
        /// Gets the name of the code example, including the version name. E.g. V5.GetCampaigns.
        /// </summary>
        public virtual string VersionedName
        {
            get
            {
                Regex myRegex = new Regex(@"V\d+\..*", RegexOptions.IgnoreCase);
                Match m = myRegex.Match(this.GetType().FullName);
                return m.Success ? m.Value : "";
            }
        }

        /// <summary>
        /// Gets the name of the code example, without the version name. E.g. GetCampaigns.
        /// </summary>
        public virtual string Name
        {
            get
            {
                Regex myRegex = new Regex(@"(.*)\.(V\d+)\.(.*)", RegexOptions.IgnoreCase);
                Match m = myRegex.Match(this.GetType().FullName);
                // m.Groups always has 1 element. If the match was a success, the zeroth element
                // has the whole matched string, and its success is set to true. If the match was
                // a failure, then the zeroth element has an empty string, and its success is set
                // to false. See
                // https://docs.microsoft.com/en-us/dotnet/api/system.text.regularexpressions.match.groups
                return m.Groups[0].Success? m.Groups[3].Value : "";
            }
        }
    }
}

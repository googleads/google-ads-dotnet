﻿// Copyright 2018 Google LLC
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

using Newtonsoft.Json;
using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Logging
{
    /// <summary>
    /// Formats a JSON trace message by masking out sensitive fields.
    /// </summary>
    public class JsonBodyFormatter : TraceFormatter
    {
        /// <summary>
        /// Masks the contents of the traced message.
        /// </summary>
        /// <param name="body">The message body.</param>
        /// <param name="keysToMask">The keys for which values should be masked
        /// in the message body.</param>
        /// <returns>
        /// The formatted message body.
        /// </returns>
        public override string MaskContents(string body, ISet<string> keysToMask)
        {
            Dictionary<string, string> jsonDict = null;

            try
            {
                jsonDict = JsonConvert.DeserializeObject<Dictionary<string, string>>(body);
            }
            catch
            {
                // This block could be hit if
                // - ArgumentException is thrown. This happens if the body being passed
                // here is not a JSON text.
                // - ArgumentNullException if body is null.
                // In both cases, it makes sense to return body unaltered.
                return body;
            }

            if (jsonDict != null && keysToMask != null)
            {
                foreach (string key in keysToMask)
                {
                    if (jsonDict.ContainsKey(key))
                    {
                        jsonDict[key] = MASK_PATTERN;
                    }
                }
                return JsonConvert.SerializeObject(jsonDict, Formatting.Indented);
            }
            else
            {
                return body;
            }
        }
    }
}

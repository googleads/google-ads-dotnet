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

using Google.Protobuf.Reflection;
using System.Linq;
using System.Reflection;

namespace Google.Ads.GoogleAds.Util
{
    /// <summary>
    /// Utility methods for working with protobuf objects.
    /// </summary>
    public class ProtobufUtilities
    {
        /// <summary>
        /// Gets the original name of an enum field in case it was renamed for
        /// name style conventions.
        /// </summary>
        /// <returns>The original name, or an empty string if the name cannot be retrieved.</returns>
        public static string GetOriginalEnumFieldName(object obj)
        {
            FieldInfo fi = obj.GetType().GetField(obj.ToString());
            if (fi != null)
            {
                OriginalNameAttribute originalName = (OriginalNameAttribute)
                    fi.GetCustomAttributes(typeof(OriginalNameAttribute),
                        false).FirstOrDefault();
                if (originalName != null)
                {
                    return originalName.Name;
                }
            }
            return "";
        }
    }
}
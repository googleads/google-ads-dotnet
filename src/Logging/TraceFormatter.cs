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

using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Logging
{
    /// <summary>
    /// Formats a Trace message.
    /// </summary>
    public abstract class TraceFormatter
    {
        /// <summary>
        /// The mask pattern to be used when masking sensitive data in logs.
        /// </summary>
        public const string MASK_PATTERN = "REDACTED";

        /// <summary>
        /// Masks the contents of the traced message.
        /// </summary>
        /// <param name="body">The JSON message body.</param>
        /// <param name="keysToMask">The keys for which values should be masked
        /// in the message body.</param>
        /// <returns>The formatted message body.</returns>
        public abstract string MaskContents(string body, ISet<string> keysToMask);
    }
}

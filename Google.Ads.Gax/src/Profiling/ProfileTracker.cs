// Copyright 2020 Google LLC
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
using System.Text;

namespace Google.Ads.GoogleAds.Profiling
{
    /// <summary>
    /// A class to keep track of profiles.
    /// </summary>
    internal class ProfileTracker
    {
        /// <summary>
        /// The singleton instance.
        /// </summary>
        private static readonly Lazy<ProfileTracker> instance =
            new Lazy<ProfileTracker>(() => new ProfileTracker());

        /// <summary>
        /// Prevents a default instance of the <see cref="ProfileTracker"/> class
        /// from being created.
        /// </summary>
        private ProfileTracker()
        {
        }

        /// <summary>
        /// The synchronize lock.
        /// </summary>
        private static object syncLock = new object();

        /// <summary>
        /// The profiles tracked by this instance.
        /// </summary>
        private HashSet<TimeProfile> profiles = new HashSet<TimeProfile>();

        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        internal static ProfileTracker Instance
        {
            get => instance.Value;
        }

        /// <summary>
        /// Adds a profile to track.
        /// </summary>
        /// <param name="profile">The profile to track.</param>
        internal void AddProfile(TimeProfile profile)
        {
            lock (syncLock)
            {
                profiles.Add(profile);
            }
        }

        /// <summary>
        /// Gets a debug string.
        /// </summary>
        /// <returns>The Debug string.</returns>
        internal string DebugString()
        {
            StringBuilder builder = new StringBuilder();
            lock (syncLock)
            {
                foreach (TimeProfile profile in profiles)
                {
                    builder.AppendLine(profile.GetDebugString());
                }
            }
            return builder.ToString();
        }
    }
}

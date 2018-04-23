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

using System.Collections.Generic;

namespace Google.Ads.GoogleAds.Util {

  /// <summary>
  /// Provides utility methods for working with collections.
  /// </summary>
  public static class CollectionUtilities {

    /// <summary>
    /// Attempts to retrieve a value associated with the specified key from the specified
    /// Dictionary.</summary>
    /// <param name="dictionary">The dictionary to query.</param>
    /// <param name="key">The key to retrieve a value for.</param>
    /// <returns>
    /// The value associated with the spcified key, or the default value for that type if none
    /// could be found.</returns>
    public static T GetValueOrDefault<S, T>(Dictionary<S, T> dictionary, S key) {
      return GetValueOrDefault(dictionary, key, default(T));
    }

    /// <summary>
    /// Attempts to retrieve a value associated with the specified key from the specified
    /// Dictionary.</summary>
    /// <param name="dictionary">The dictionary to query.</param>
    /// <param name="key">The key to retrieve a value for.</param>
    /// <param name="defaultValue">The value to return if none could be found.</param>
    /// <returns>
    /// The value associated with the spcified key, or defaultValue if none could be found.
    /// </returns>
    public static T GetValueOrDefault<S, T>(Dictionary<S, T> dictionary, S key, T defaultValue) {
      return dictionary.TryGetValue(key, out var value) ? value : defaultValue;
    }
  }
}

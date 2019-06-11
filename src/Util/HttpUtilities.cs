// Copyright 2019 Google LLC
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

using Google.Ads.GoogleAds.Config;

using System;
using System.Net;

namespace Google.Ads.GoogleAds.Util
{
    /// <summary>
    /// Utility class for various HTTP tasks.
    /// </summary>
    public class HttpUtilities
    {
        /// <summary>
        /// Builds an HTTP request with a specified method.
        /// </summary>
        /// <param name="url">The URL.</param>
        /// <param name="method">The HTTP method.</param>
        /// <param name="config">The configuration instance for customizing the
        /// connection settings.</param>
        /// <returns>The web request for making HTTP call.</returns>
        /// <exception cref="System.ArgumentNullException">Thrown if <paramref name="config"/>
        /// is null.</exception>
        public static WebRequest BuildRequest(string url, string method, GoogleAdsConfig config)
        {
            if (config == null)
            {
                throw new ArgumentNullException("config");
            }

            WebRequest request = HttpWebRequest.Create(url);

            request.Method = method;
            request.Proxy = config.Proxy;
            request.Timeout = config.Timeout;

            return request;
        }
    }
}

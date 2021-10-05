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
using System.IO;
using System.Net;
using System.Threading.Tasks;

namespace Google.Ads.GoogleAds.Util
{
    /// <summary>
    /// Provides utility methods for handling media resources.
    /// </summary>
    public static class MediaUtilities
    {
        /// <summary>
        /// Retrieves an asset from the web given its URL.
        /// </summary>
        /// <param name="assetUrl">The URL of the asset to be retrieved.</param>
        /// <param name="config">The application configuration instance.</param>
        /// <returns>Asset data, as an array of bytes.</returns>
        /// <exception cref="ArgumentNullException">Thrown if
        /// <paramref name="assetUrl"/> or <paramref name="config"/>is null.
        /// </exception>
        public static byte[] GetAssetDataFromUrl(Uri assetUrl, GoogleAdsConfig config)
        {
            if (assetUrl == null)
            {
                throw new ArgumentNullException("assetUrl");
            }

            if (config == null)
            {
                throw new ArgumentNullException("config");
            }

            WebRequest request = HttpUtilities.BuildRequest(assetUrl.AbsoluteUri, "GET", config);
            WebResponse response = request.GetResponse();

            MemoryStream memStream = new MemoryStream();
            using (Stream responseStream = response.GetResponseStream())
            {
                responseStream.CopyTo(memStream);
            }

            return memStream.ToArray();
        }

        /// <summary>
        /// Asynchronously retrieves an asset from the web given its URL.
        /// </summary>
        /// <param name="assetUrl">The URL of the asset to be retrieved.</param>
        /// <param name="config">The application configuration instance.</param>
        /// <returns>Asset data, as an array of bytes.</returns>
        /// <exception cref="ArgumentNullException">Thrown if
        /// <paramref name="assetUrl"/> or <paramref name="config"/>is null.
        /// </exception>
        public static async Task<byte[]> GetAssetDataFromUrlAsync(Uri assetUrl, GoogleAdsConfig config)
        {
            if (assetUrl == null)
            {
                throw new ArgumentNullException(nameof(assetUrl));
            }

            if (config == null)
            {
                throw new ArgumentNullException(nameof(config));
            }

            WebRequest request = HttpUtilities.BuildRequest(assetUrl.AbsoluteUri, "GET", config);
            WebResponse response = await request.GetResponseAsync();

            MemoryStream memStream = new MemoryStream();
            using (Stream responseStream = response.GetResponseStream())
            {
                await responseStream.CopyToAsync(memStream);
            }

            return memStream.ToArray();
        }

        /// <summary>
        /// Retrieves an asset from the web given its URL.
        /// </summary>
        /// <param name="assetUrl">The URL of the asset to be retrieved.</param>
        /// <param name="config">The application configuration instance.</param>
        /// <returns>Asset data, as an array of bytes.</returns>
        /// <exception cref="ArgumentNullException">Thrown if
        /// <paramref name="assetUrl"/> or <paramref name="config" /> is null.
        /// </exception>
        public static byte[] GetAssetDataFromUrl(string assetUrl, GoogleAdsConfig config)
        {
            return GetAssetDataFromUrl(new Uri(assetUrl), config);
        }

        /// <summary>
        /// Asynchronously retrieves an asset from the web given its URL.
        /// </summary>
        /// <param name="assetUrl">The URL of the asset to be retrieved.</param>
        /// <param name="config">The application configuration instance.</param>
        /// <returns>Asset data, as an array of bytes.</returns>
        /// <exception cref="ArgumentNullException">Thrown if
        /// <paramref name="assetUrl"/> or <paramref name="config" /> is null.
        /// </exception>
        public static async Task<byte[]> GetAssetDataFromUrlAsync(string assetUrl, GoogleAdsConfig config)
        {
            return await GetAssetDataFromUrlAsync(new Uri(assetUrl), config);
        }
    }
}

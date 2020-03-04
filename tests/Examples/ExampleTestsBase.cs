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

using Google.Ads.GoogleAds.Config;
using Google.Ads.GoogleAds.Lib;
using NUnit.Framework;

using System.IO;

namespace Google.Ads.GoogleAds.Tests.Examples
{
    /// <summary>
    /// Base class for all code example tests.
    /// </summary>
    internal class ExampleTestsBase
    {
        /// <summary>
        /// The GoogleAdsConfig instance for running code examples.
        /// </summary>
        protected GoogleAdsConfig config;

        /// <summary>
        /// The GoogleAdsClient instance for running code examples.
        /// </summary>
        protected GoogleAdsClient client;

        /// <summary>
        /// Default constructor.
        /// </summary>
        internal ExampleTestsBase()
        {
            config = new GoogleAdsConfig();
            client = new GoogleAdsClient(config);
        }

        /// <summary>
        /// Runs a code example.
        /// </summary>
        /// <param name="exampleDelegate">The delegate that initializes and runs the
        /// code example.</param>
        protected void RunExample(TestDelegate exampleDelegate)
        {
            StringWriter writer = new StringWriter();
            Assert.DoesNotThrow(delegate ()
            {
                exampleDelegate.Invoke();
            });
        }
    }
}

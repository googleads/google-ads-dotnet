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

using Google.Ads.GoogleAds.Util;
using NUnit.Framework;

namespace Google.Ads.GoogleAds.Tests.Examples
{
    [SetUpFixture]
    public class ExampleTestsSetup
    {
        [OneTimeSetUp]
        public void RunBeforeAnyTests()
        {
            // Turn on logging.
            TraceUtilities.Configure(TraceUtilities.DETAILED_REQUEST_LOGS_SOURCE,
                "C:\\logs\\details.log", System.Diagnostics.SourceLevels.All);
        }
    }
}

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

using Google.Api.Gax.Grpc;

namespace Google.Ads.GoogleAds.Lib {

  /// <summary>
  /// Defines a service template.
  /// </summary>
  /// <typeparam name="T">Type of the service.</typeparam>
  /// <typeparam name="U">Type of the service settings.</typeparam>
  public class ServiceTemplate<T, U> where U : ServiceSettingsBase, new() {

    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceTemplate{T, U}"/> class.
    /// </summary>
    public ServiceTemplate() {
    }
  }
}

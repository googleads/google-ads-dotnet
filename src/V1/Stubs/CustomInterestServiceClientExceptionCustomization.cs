// Copyright 2019 Google LLC. All Rights Reserved.
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
// Generated code - do not edit
using Google.Api.Gax.Grpc;
using Google.Protobuf;
using Google.Ads.GoogleAds.V1.Errors;
namespace Google.Ads.GoogleAds.V1.Services
{
    public partial class CustomInterestServiceClientImpl
    {
        // Modify every API call on construction to use GoogleAdsException
        partial void Modify_ApiCall<TRequest, TResponse>(ref ApiCall<TRequest, TResponse> call)
            where TRequest : class, IMessage<TRequest>
            where TResponse : class, IMessage<TResponse> =>
            call = call.WithExceptionCustomizer(GoogleAdsException.Create);
    }
}

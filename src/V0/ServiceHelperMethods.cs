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

using Google.Protobuf.WellKnownTypes;
using System.Linq;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagve = Google.Ads.GoogleAds.V0.Enums;
using scg = System.Collections.Generic;
using stt = System.Threading.Tasks;

#pragma warning disable CS1591

namespace Google.Ads.GoogleAds.V0.Services
{
    public abstract partial class CustomerServiceClient
    {
        public string[] ListAccessibleCustomers()
        {
            return ListAccessibleCustomers(new ListAccessibleCustomersRequest() { })
                .ResourceNames.ToArray();
        }
    }

    public abstract partial class GeoTargetConstantServiceClient
    {
        public virtual SuggestGeoTargetConstantsResponse SuggestGeoTargetConstants(
            StringValue locale,
            StringValue countryCode,
            gaxgrpc::CallSettings callSettings = null) => SuggestGeoTargetConstants(
                locale.Value, countryCode.Value, callSettings);

        public virtual stt::Task<SuggestGeoTargetConstantsResponse> SuggestGeoTargetConstantsAsync(
            StringValue locale,
            StringValue countryCode,
            gaxgrpc::CallSettings callSettings = null) => SuggestGeoTargetConstantsAsync(
                locale.Value, countryCode.Value, callSettings);
    }

    public abstract partial class KeywordPlanIdeaServiceClient
    {
        public virtual GenerateKeywordIdeaResponse GenerateKeywordIdeas(
            string customerId,
            StringValue language,
            scg::IEnumerable<string> geoTargetConstants,
            gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork keywordPlanNetwork,
            gaxgrpc::CallSettings callSettings = null) => GenerateKeywordIdeas(
                customerId, language.Value, geoTargetConstants, keywordPlanNetwork,
                callSettings);

        public virtual stt::Task<GenerateKeywordIdeaResponse> GenerateKeywordIdeasAsync(
            string customerId,
            StringValue language,
            scg::IEnumerable<string> geoTargetConstants,
            gagve::KeywordPlanNetworkEnum.Types.KeywordPlanNetwork keywordPlanNetwork,
            gaxgrpc::CallSettings callSettings = null) => GenerateKeywordIdeasAsync(
                customerId, language.Value, geoTargetConstants, keywordPlanNetwork,
                callSettings);
    }
}

#pragma warning restore CS1591

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

using Google.Protobuf.WellKnownTypes;
using System.Linq;
using gaxgrpc = Google.Api.Gax.Grpc;
using gagve = Google.Ads.GoogleAds.V3.Enums;
using scg = System.Collections.Generic;
using stt = System.Threading.Tasks;
using Google.Api.Gax;
using Google.Api.Gax.Grpc;
using static Google.Ads.GoogleAds.V3.Enums.SummaryRowSettingEnum.Types;
using System;
using Google.Ads.GoogleAds.V3.Errors;
using System.Threading.Tasks;
using System.Threading;

#pragma warning disable CS1591

namespace Google.Ads.GoogleAds.V3.Services
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

    public abstract partial class GoogleAdsServiceClient
    {
        public virtual PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> Search(
            string customerId,
            string query,
            string pageToken = null,
            int? pageSize = null,
            CallSettings callSettings = null) => Search(
                new SearchGoogleAdsRequest
                {
                    CustomerId = GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Query = GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                    PageToken = pageToken ?? "",
                    PageSize = pageSize ?? 0,
                },
                callSettings);

        public virtual Task SearchStreamAsync(
            string customerId,
            string query,
            Action<SearchGoogleAdsStreamResponse> responseCallback,
            SummaryRowSetting summaryRowSetting = SummaryRowSetting.NoSummaryRow,
            CallSettings callSettings = null)
        {
            SearchStreamStream searchStream = this.SearchStream(
                new SearchGoogleAdsStreamRequest()
                {
                    CustomerId = customerId.ToString(),
                    Query = query,
                    SummaryRowSetting = summaryRowSetting,
                });

            // Issue a search request.
            Task t = Task.Run(async () =>
            {
                while (await searchStream.ResponseStream.MoveNext(CancellationToken.None))
                {
                    SearchGoogleAdsStreamResponse resp = searchStream.ResponseStream.Current;
                    responseCallback(resp);
                }
            });

            return t;
        }

        public virtual void SearchStream(
            string customerId,
            string query,
            Action<SearchGoogleAdsStreamResponse> responseCallback,
            SummaryRowSetting summaryRowSetting = SummaryRowSetting.NoSummaryRow,
            CallSettings callSettings = null)
        {
            try
            {
                Task t = SearchStreamAsync(customerId, query, responseCallback, summaryRowSetting,
                    callSettings);
                t.Wait();
            }
            catch (AggregateException ae)
            {
                GoogleAdsException gae = GoogleAdsException.FromTaskException(ae);

                if (gae != null)
                {
                    throw gae;
                }
                throw;
            }
        }
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

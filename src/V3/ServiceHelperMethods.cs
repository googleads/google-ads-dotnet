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

using Google.Ads.GoogleAds.V3.Errors;
using Google.Api.Gax.Grpc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Ads.GoogleAds.V3.Enums.SummaryRowSettingEnum.Types;

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

    public abstract partial class GoogleAdsServiceClient
    {
        public virtual Task<SearchStreamStream> SearchStreamAsync(
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
            Task<SearchStreamStream> t = Task.Run(async () =>
            {
                var responseStream = searchStream.GetResponseStream();
                bool emptyResult = true;
                while (await responseStream.MoveNextAsync(CancellationToken.None))
                {
                    emptyResult = false;
                    SearchGoogleAdsStreamResponse resp = responseStream.Current;
                    responseCallback(resp);
                }
                // Invoke the callback at least once to avoid confusion when there are no results
                // and no errors.
                if (emptyResult)
                {
                    responseCallback(new SearchGoogleAdsStreamResponse());
                }
                return searchStream;
            });

            return t;
        }

        public virtual SearchStreamStream SearchStream(
            string customerId,
            string query,
            Action<SearchGoogleAdsStreamResponse> responseCallback,
            SummaryRowSetting summaryRowSetting = SummaryRowSetting.NoSummaryRow,
            CallSettings callSettings = null)
        {
            try
            {
                Task<SearchStreamStream> t = SearchStreamAsync(customerId, query, responseCallback,
                    summaryRowSetting, callSettings);
                t.Wait();
                return t.Result;
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
}

#pragma warning restore CS1591

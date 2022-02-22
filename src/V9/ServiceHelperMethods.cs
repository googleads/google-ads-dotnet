// Copyright 2021 Google LLC
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

using Google.Ads.GoogleAds.V9.Errors;
using Google.Api.Gax.Grpc;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using static Google.Ads.GoogleAds.V9.Enums.SummaryRowSettingEnum.Types;

namespace Google.Ads.GoogleAds.V9.Services
{
    public abstract partial class CustomerServiceClient
    {
        /// <summary>
        /// Lists the accessible customers.
        /// </summary>
        /// <returns>An array of accessible customer resources.</returns>
        public string[] ListAccessibleCustomers()
        {
            return ListAccessibleCustomers(new ListAccessibleCustomersRequest() { })
                .ResourceNames.ToArray();
        }
    }

    public abstract partial class GoogleAdsServiceClient
    {

        /// <summary>
        /// Runs a streaming search query and returns all rows that matches the query.
        /// </summary>
        /// <param name="customerId">ID of the customer for which the query is run.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="responseCallback">The callback that will be called for each
        /// <see cref="SearchGoogleAdsStreamResponse"/> returned by the server.</param>
        /// <param name="summaryRowSetting">The summary row setting.</param>
        /// <param name="callSettings">The call settings to customize this API call.</param>
        /// <returns>The search response task.</returns>
        /// <remarks>This method reads the response stream and invokes the callback for each
        /// <see cref="SearchGoogleAdsStreamResponse"/> object in the response, you cannot
        /// iterate further on the <see cref="SearchStreamStream"/> object to obtain results. You
        /// can however perform additional tasks like retrieving the trailing metadata. If you do
        /// not care about this additional information, it is fine to ignore the return value
        /// of this method.</remarks>
        public virtual Task<SearchStreamStream> SearchStreamAsync(
            string customerId,
            string query,
            Action<SearchGoogleAdsStreamResponse> responseCallback,
            SummaryRowSetting summaryRowSetting = SummaryRowSetting.NoSummaryRow,
            CallSettings callSettings = null)
        {
            var request = new SearchGoogleAdsStreamRequest()
            {
                CustomerId = customerId.ToString(),
                Query = query,
                SummaryRowSetting = summaryRowSetting,
            };
            return SearchStreamAsync(request, responseCallback, callSettings);
        }

        /// <summary>
        /// Runs a streaming search query and returns all rows that matches the query.
        /// </summary>
        /// <param name="request">The search request.</param>
        /// <param name="responseCallback">The callback that will be called for each
        /// <see cref="SearchGoogleAdsStreamResponse"/> returned by the server.</param>
        /// <param name="callSettings">The call settings to customize this API call.</param>
        /// <returns>The search response task.</returns>
        /// <remarks>This method reads the response stream and invokes the callback for each
        /// <see cref="SearchGoogleAdsStreamResponse"/> object in the response, you cannot
        /// iterate further on the <see cref="SearchStreamStream"/> object to obtain results. You
        /// can however perform additional tasks like retrieving the trailing metadata. If you do
        /// not care about this additional information, it is fine to ignore the return value
        /// of this method.</remarks>
        public virtual Task<SearchStreamStream> SearchStreamAsync(
            SearchGoogleAdsStreamRequest request,
            Action<SearchGoogleAdsStreamResponse> responseCallback,
            CallSettings callSettings = null)
        {
            SearchStreamStream searchStream = this.SearchStream(request, callSettings);

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

        /// <summary>
        /// Runs a streaming search query and returns all rows that matches the query.
        /// </summary>
        /// <param name="customerId">ID of the customer for which the query is run.</param>
        /// <param name="query">The query to run.</param>
        /// <param name="responseCallback">The callback that will be called for each
        /// <see cref="SearchGoogleAdsStreamResponse"/> returned by the server.</param>
        /// <param name="summaryRowSetting">The summary row setting.</param>
        /// <param name="callSettings">The call settings to customize this API call.</param>
        /// <returns>The <see cref="SearchStreamStream"/> object for further processing.</returns>
        /// <remarks>This method reads the response stream and invokes the callback for each
        /// <see cref="SearchGoogleAdsStreamResponse"/> object in the response, you cannot
        /// iterate further on the <see cref="SearchStreamStream"/> object to obtain results. You
        /// can however perform additional tasks like retrieving the trailing metadata. If you do
        /// not care about this additional information, it is fine to ignore the return value
        /// of this method.</remarks>
        public virtual SearchStreamStream SearchStream(
            string customerId,
            string query,
            Action<SearchGoogleAdsStreamResponse> responseCallback,
            SummaryRowSetting summaryRowSetting = SummaryRowSetting.NoSummaryRow,
            CallSettings callSettings = null)
        {
            var request = new SearchGoogleAdsStreamRequest()
            {
                CustomerId = customerId.ToString(),
                Query = query,
                SummaryRowSetting = summaryRowSetting,
            };
            return SearchStream(request, responseCallback, callSettings);
        }

        /// <summary>
        /// Runs a streaming search query and returns all rows that matches the query.
        /// </summary>
        /// <param name="request">The search request.</param>
        /// <param name="responseCallback">The response callback, which will be called
        /// for each <see cref="SearchGoogleAdsStreamResponse"/> in the response stream.</param>
        /// <param name="callSettings">The call settings to customize this API call.</param>
        /// <returns>The <see cref="SearchStreamStream"/> object for further processing.</returns>
        /// <remarks>This method reads the response stream and invokes the callback for each
        /// <see cref="SearchGoogleAdsStreamResponse"/> object in the response, you cannot
        /// iterate further on the <see cref="SearchStreamStream"/> object to obtain results. You
        /// can however perform additional tasks like retrieving the trailing metadata. If you do
        /// not care about this additional information, it is fine to ignore the return value
        /// of this method.</remarks>
        public virtual SearchStreamStream SearchStream(SearchGoogleAdsStreamRequest request,
            Action<SearchGoogleAdsStreamResponse> responseCallback,
            CallSettings callSettings = null)
        {
            try
            {
                Task<SearchStreamStream> t = SearchStreamAsync(request, responseCallback,
                    callSettings);
                // Since we call Task.Run() in SearchStreamAsync, it is safe to call
                // t.Result here without causing a deadlock. Also, no need to call t.Wait(),
                // because t.Result is blocking in nature.
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

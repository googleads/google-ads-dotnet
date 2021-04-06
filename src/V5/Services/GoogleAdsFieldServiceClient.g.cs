// Copyright 2021 Google LLC
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     https://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

// Generated code. DO NOT EDIT!

using gagvr = Google.Ads.GoogleAds.V5.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V5.Services
{
    /// <summary>Settings for <see cref="GoogleAdsFieldServiceClient"/> instances.</summary>
    public sealed partial class GoogleAdsFieldServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GoogleAdsFieldServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GoogleAdsFieldServiceSettings"/>.</returns>
        public static GoogleAdsFieldServiceSettings GetDefault() => new GoogleAdsFieldServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GoogleAdsFieldServiceSettings"/> object with default settings.
        /// </summary>
        public GoogleAdsFieldServiceSettings()
        {
        }

        private GoogleAdsFieldServiceSettings(GoogleAdsFieldServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGoogleAdsFieldSettings = existing.GetGoogleAdsFieldSettings;
            SearchGoogleAdsFieldsSettings = existing.SearchGoogleAdsFieldsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GoogleAdsFieldServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GoogleAdsFieldServiceClient.GetGoogleAdsField</c> and
        /// <c>GoogleAdsFieldServiceClient.GetGoogleAdsFieldAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGoogleAdsFieldSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GoogleAdsFieldServiceClient.SearchGoogleAdsFields</c> and
        /// <c>GoogleAdsFieldServiceClient.SearchGoogleAdsFieldsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings SearchGoogleAdsFieldsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GoogleAdsFieldServiceSettings"/> object.</returns>
        public GoogleAdsFieldServiceSettings Clone() => new GoogleAdsFieldServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GoogleAdsFieldServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class GoogleAdsFieldServiceClientBuilder : gaxgrpc::ClientBuilderBase<GoogleAdsFieldServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GoogleAdsFieldServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref GoogleAdsFieldServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GoogleAdsFieldServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GoogleAdsFieldServiceClient Build()
        {
            GoogleAdsFieldServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GoogleAdsFieldServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GoogleAdsFieldServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GoogleAdsFieldServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GoogleAdsFieldServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<GoogleAdsFieldServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GoogleAdsFieldServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => GoogleAdsFieldServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GoogleAdsFieldServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GoogleAdsFieldServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>GoogleAdsFieldService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Google Ads API fields.
    /// </remarks>
    public abstract partial class GoogleAdsFieldServiceClient
    {
        /// <summary>
        /// The default endpoint for the GoogleAdsFieldService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default GoogleAdsFieldService scopes.</summary>
        /// <remarks>
        /// The default GoogleAdsFieldService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="GoogleAdsFieldServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GoogleAdsFieldServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GoogleAdsFieldServiceClient"/>.</returns>
        public static stt::Task<GoogleAdsFieldServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GoogleAdsFieldServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GoogleAdsFieldServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="GoogleAdsFieldServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GoogleAdsFieldServiceClient"/>.</returns>
        public static GoogleAdsFieldServiceClient Create() => new GoogleAdsFieldServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GoogleAdsFieldServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GoogleAdsFieldServiceSettings"/>.</param>
        /// <returns>The created <see cref="GoogleAdsFieldServiceClient"/>.</returns>
        internal static GoogleAdsFieldServiceClient Create(grpccore::CallInvoker callInvoker, GoogleAdsFieldServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GoogleAdsFieldService.GoogleAdsFieldServiceClient grpcClient = new GoogleAdsFieldService.GoogleAdsFieldServiceClient(callInvoker);
            return new GoogleAdsFieldServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/>. Channels which weren't automatically created are not
        /// affected.
        /// </summary>
        /// <remarks>
        /// After calling this method, further calls to <see cref="Create()"/> and
        /// <see cref="CreateAsync(st::CancellationToken)"/> will create new channels, which could in turn be shut down
        /// by another call to this method.
        /// </remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => ChannelPool.ShutdownChannelsAsync();

        /// <summary>The underlying gRPC GoogleAdsFieldService client</summary>
        public virtual GoogleAdsFieldService.GoogleAdsFieldServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::GoogleAdsField GetGoogleAdsField(GetGoogleAdsFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(GetGoogleAdsFieldRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(GetGoogleAdsFieldRequest request, st::CancellationToken cancellationToken) =>
            GetGoogleAdsFieldAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the field to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::GoogleAdsField GetGoogleAdsField(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleAdsField(new GetGoogleAdsFieldRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the field to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleAdsFieldAsync(new GetGoogleAdsFieldRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the field to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetGoogleAdsFieldAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the field to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::GoogleAdsField GetGoogleAdsField(gagvr::GoogleAdsFieldName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleAdsField(new GetGoogleAdsFieldRequest
            {
                ResourceNameAsGoogleAdsFieldName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the field to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(gagvr::GoogleAdsFieldName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGoogleAdsFieldAsync(new GetGoogleAdsFieldRequest
            {
                ResourceNameAsGoogleAdsFieldName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the field to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(gagvr::GoogleAdsFieldName resourceName, st::CancellationToken cancellationToken) =>
            GetGoogleAdsFieldAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gagvr::GoogleAdsField"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFields(SearchGoogleAdsFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gagvr::GoogleAdsField"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFieldsAsync(SearchGoogleAdsFieldsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gagvr::GoogleAdsField"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFields(string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchGoogleAdsFields(new SearchGoogleAdsFieldsRequest
            {
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gagvr::GoogleAdsField"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFieldsAsync(string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            SearchGoogleAdsFieldsAsync(new SearchGoogleAdsFieldsRequest
            {
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>GoogleAdsFieldService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Google Ads API fields.
    /// </remarks>
    public sealed partial class GoogleAdsFieldServiceClientImpl : GoogleAdsFieldServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGoogleAdsFieldRequest, gagvr::GoogleAdsField> _callGetGoogleAdsField;

        private readonly gaxgrpc::ApiCall<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse> _callSearchGoogleAdsFields;

        /// <summary>
        /// Constructs a client wrapper for the GoogleAdsFieldService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GoogleAdsFieldServiceSettings"/> used within this client.</param>
        public GoogleAdsFieldServiceClientImpl(GoogleAdsFieldService.GoogleAdsFieldServiceClient grpcClient, GoogleAdsFieldServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GoogleAdsFieldServiceSettings effectiveSettings = settings ?? GoogleAdsFieldServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetGoogleAdsField = clientHelper.BuildApiCall<GetGoogleAdsFieldRequest, gagvr::GoogleAdsField>(grpcClient.GetGoogleAdsFieldAsync, grpcClient.GetGoogleAdsField, effectiveSettings.GetGoogleAdsFieldSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetGoogleAdsField);
            Modify_GetGoogleAdsFieldApiCall(ref _callGetGoogleAdsField);
            _callSearchGoogleAdsFields = clientHelper.BuildApiCall<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse>(grpcClient.SearchGoogleAdsFieldsAsync, grpcClient.SearchGoogleAdsFields, effectiveSettings.SearchGoogleAdsFieldsSettings);
            Modify_ApiCall(ref _callSearchGoogleAdsFields);
            Modify_SearchGoogleAdsFieldsApiCall(ref _callSearchGoogleAdsFields);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetGoogleAdsFieldApiCall(ref gaxgrpc::ApiCall<GetGoogleAdsFieldRequest, gagvr::GoogleAdsField> call);

        partial void Modify_SearchGoogleAdsFieldsApiCall(ref gaxgrpc::ApiCall<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse> call);

        partial void OnConstruction(GoogleAdsFieldService.GoogleAdsFieldServiceClient grpcClient, GoogleAdsFieldServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GoogleAdsFieldService client</summary>
        public override GoogleAdsFieldService.GoogleAdsFieldServiceClient GrpcClient { get; }

        partial void Modify_GetGoogleAdsFieldRequest(ref GetGoogleAdsFieldRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchGoogleAdsFieldsRequest(ref SearchGoogleAdsFieldsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::GoogleAdsField GetGoogleAdsField(GetGoogleAdsFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleAdsFieldRequest(ref request, ref callSettings);
            return _callGetGoogleAdsField.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns just the requested field.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::GoogleAdsField> GetGoogleAdsFieldAsync(GetGoogleAdsFieldRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGoogleAdsFieldRequest(ref request, ref callSettings);
            return _callGetGoogleAdsField.Async(request, callSettings);
        }

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gagvr::GoogleAdsField"/> resources.</returns>
        public override gax::PagedEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFields(SearchGoogleAdsFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGoogleAdsFieldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField>(_callSearchGoogleAdsFields, request, callSettings);
        }

        /// <summary>
        /// Returns all fields that match the search query.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gagvr::GoogleAdsField"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField> SearchGoogleAdsFieldsAsync(SearchGoogleAdsFieldsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGoogleAdsFieldsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchGoogleAdsFieldsRequest, SearchGoogleAdsFieldsResponse, gagvr::GoogleAdsField>(_callSearchGoogleAdsFields, request, callSettings);
        }
    }

    public partial class SearchGoogleAdsFieldsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchGoogleAdsFieldsResponse : gaxgrpc::IPageResponse<gagvr::GoogleAdsField>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<gagvr::GoogleAdsField> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

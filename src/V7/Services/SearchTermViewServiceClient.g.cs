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

using gagvr = Google.Ads.GoogleAds.V7.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V7.Services
{
    /// <summary>Settings for <see cref="SearchTermViewServiceClient"/> instances.</summary>
    public sealed partial class SearchTermViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SearchTermViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SearchTermViewServiceSettings"/>.</returns>
        public static SearchTermViewServiceSettings GetDefault() => new SearchTermViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SearchTermViewServiceSettings"/> object with default settings.
        /// </summary>
        public SearchTermViewServiceSettings()
        {
        }

        private SearchTermViewServiceSettings(SearchTermViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSearchTermViewSettings = existing.GetSearchTermViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SearchTermViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SearchTermViewServiceClient.GetSearchTermView</c> and
        /// <c>SearchTermViewServiceClient.GetSearchTermViewAsync</c>.
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
        public gaxgrpc::CallSettings GetSearchTermViewSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SearchTermViewServiceSettings"/> object.</returns>
        public SearchTermViewServiceSettings Clone() => new SearchTermViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SearchTermViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class SearchTermViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<SearchTermViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SearchTermViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref SearchTermViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SearchTermViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SearchTermViewServiceClient Build()
        {
            SearchTermViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SearchTermViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SearchTermViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SearchTermViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SearchTermViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<SearchTermViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SearchTermViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => SearchTermViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SearchTermViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SearchTermViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>SearchTermViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage search term views.
    /// </remarks>
    public abstract partial class SearchTermViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the SearchTermViewService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default SearchTermViewService scopes.</summary>
        /// <remarks>
        /// The default SearchTermViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="SearchTermViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SearchTermViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SearchTermViewServiceClient"/>.</returns>
        public static stt::Task<SearchTermViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SearchTermViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SearchTermViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SearchTermViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SearchTermViewServiceClient"/>.</returns>
        public static SearchTermViewServiceClient Create() => new SearchTermViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SearchTermViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SearchTermViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="SearchTermViewServiceClient"/>.</returns>
        internal static SearchTermViewServiceClient Create(grpccore::CallInvoker callInvoker, SearchTermViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SearchTermViewService.SearchTermViewServiceClient grpcClient = new SearchTermViewService.SearchTermViewServiceClient(callInvoker);
            return new SearchTermViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC SearchTermViewService client</summary>
        public virtual SearchTermViewService.SearchTermViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SearchTermView GetSearchTermView(GetSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SearchTermView> GetSearchTermViewAsync(GetSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SearchTermView> GetSearchTermViewAsync(GetSearchTermViewRequest request, st::CancellationToken cancellationToken) =>
            GetSearchTermViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SearchTermView GetSearchTermView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchTermView(new GetSearchTermViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SearchTermView> GetSearchTermViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchTermViewAsync(new GetSearchTermViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the search term view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SearchTermView> GetSearchTermViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetSearchTermViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SearchTermView GetSearchTermView(gagvr::SearchTermViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchTermView(new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the search term view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SearchTermView> GetSearchTermViewAsync(gagvr::SearchTermViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSearchTermViewAsync(new GetSearchTermViewRequest
            {
                ResourceNameAsSearchTermViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the search term view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SearchTermView> GetSearchTermViewAsync(gagvr::SearchTermViewName resourceName, st::CancellationToken cancellationToken) =>
            GetSearchTermViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SearchTermViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage search term views.
    /// </remarks>
    public sealed partial class SearchTermViewServiceClientImpl : SearchTermViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSearchTermViewRequest, gagvr::SearchTermView> _callGetSearchTermView;

        /// <summary>
        /// Constructs a client wrapper for the SearchTermViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SearchTermViewServiceSettings"/> used within this client.</param>
        public SearchTermViewServiceClientImpl(SearchTermViewService.SearchTermViewServiceClient grpcClient, SearchTermViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SearchTermViewServiceSettings effectiveSettings = settings ?? SearchTermViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetSearchTermView = clientHelper.BuildApiCall<GetSearchTermViewRequest, gagvr::SearchTermView>(grpcClient.GetSearchTermViewAsync, grpcClient.GetSearchTermView, effectiveSettings.GetSearchTermViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetSearchTermView);
            Modify_GetSearchTermViewApiCall(ref _callGetSearchTermView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSearchTermViewApiCall(ref gaxgrpc::ApiCall<GetSearchTermViewRequest, gagvr::SearchTermView> call);

        partial void OnConstruction(SearchTermViewService.SearchTermViewServiceClient grpcClient, SearchTermViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SearchTermViewService client</summary>
        public override SearchTermViewService.SearchTermViewServiceClient GrpcClient { get; }

        partial void Modify_GetSearchTermViewRequest(ref GetSearchTermViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::SearchTermView GetSearchTermView(GetSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSearchTermViewRequest(ref request, ref callSettings);
            return _callGetSearchTermView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the attributes of the requested search term view.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::SearchTermView> GetSearchTermViewAsync(GetSearchTermViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSearchTermViewRequest(ref request, ref callSettings);
            return _callGetSearchTermView.Async(request, callSettings);
        }
    }
}

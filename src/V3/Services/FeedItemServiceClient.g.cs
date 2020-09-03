// Copyright 2020 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V3.Resources;
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

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>Settings for <see cref="FeedItemServiceClient"/> instances.</summary>
    public sealed partial class FeedItemServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeedItemServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeedItemServiceSettings"/>.</returns>
        public static FeedItemServiceSettings GetDefault() => new FeedItemServiceSettings();

        /// <summary>Constructs a new <see cref="FeedItemServiceSettings"/> object with default settings.</summary>
        public FeedItemServiceSettings()
        {
        }

        private FeedItemServiceSettings(FeedItemServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFeedItemSettings = existing.GetFeedItemSettings;
            MutateFeedItemsSettings = existing.MutateFeedItemsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeedItemServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedItemServiceClient.GetFeedItem</c> and <c>FeedItemServiceClient.GetFeedItemAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeedItemSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedItemServiceClient.MutateFeedItems</c> and <c>FeedItemServiceClient.MutateFeedItemsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateFeedItemsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeedItemServiceSettings"/> object.</returns>
        public FeedItemServiceSettings Clone() => new FeedItemServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeedItemServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class FeedItemServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeedItemServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeedItemServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref FeedItemServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeedItemServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeedItemServiceClient Build()
        {
            FeedItemServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeedItemServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeedItemServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeedItemServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeedItemServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<FeedItemServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeedItemServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => FeedItemServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => FeedItemServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeedItemServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>FeedItemService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feed items.
    /// </remarks>
    public abstract partial class FeedItemServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeedItemService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default FeedItemService scopes.</summary>
        /// <remarks>The default FeedItemService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="FeedItemServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedItemServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeedItemServiceClient"/>.</returns>
        public static stt::Task<FeedItemServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeedItemServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeedItemServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedItemServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeedItemServiceClient"/>.</returns>
        public static FeedItemServiceClient Create() => new FeedItemServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeedItemServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeedItemServiceSettings"/>.</param>
        /// <returns>The created <see cref="FeedItemServiceClient"/>.</returns>
        internal static FeedItemServiceClient Create(grpccore::CallInvoker callInvoker, FeedItemServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeedItemService.FeedItemServiceClient grpcClient = new FeedItemService.FeedItemServiceClient(callInvoker);
            return new FeedItemServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC FeedItemService client</summary>
        public virtual FeedItemService.FeedItemServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedItem GetFeedItem(GetFeedItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItem> GetFeedItemAsync(GetFeedItemRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItem> GetFeedItemAsync(GetFeedItemRequest request, st::CancellationToken cancellationToken) =>
            GetFeedItemAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedItem GetFeedItem(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItem(new GetFeedItemRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItem> GetFeedItemAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItemAsync(new GetFeedItemRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItem> GetFeedItemAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetFeedItemAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedItem GetFeedItem(gagvr::FeedItemName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItem(new GetFeedItemRequest
            {
                ResourceNameAsFeedItemName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItem> GetFeedItemAsync(gagvr::FeedItemName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItemAsync(new GetFeedItemRequest
            {
                ResourceNameAsFeedItemName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItem> GetFeedItemAsync(gagvr::FeedItemName resourceName, st::CancellationToken cancellationToken) =>
            GetFeedItemAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes feed items. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateFeedItemsResponse MutateFeedItems(MutateFeedItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes feed items. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemsResponse> MutateFeedItemsAsync(MutateFeedItemsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes feed items. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemsResponse> MutateFeedItemsAsync(MutateFeedItemsRequest request, st::CancellationToken cancellationToken) =>
            MutateFeedItemsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes feed items. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed items are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed items.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateFeedItemsResponse MutateFeedItems(string customerId, scg::IEnumerable<FeedItemOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedItems(new MutateFeedItemsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes feed items. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed items are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed items.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemsResponse> MutateFeedItemsAsync(string customerId, scg::IEnumerable<FeedItemOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedItemsAsync(new MutateFeedItemsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes feed items. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed items are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed items.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemsResponse> MutateFeedItemsAsync(string customerId, scg::IEnumerable<FeedItemOperation> operations, st::CancellationToken cancellationToken) =>
            MutateFeedItemsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeedItemService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feed items.
    /// </remarks>
    public sealed partial class FeedItemServiceClientImpl : FeedItemServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetFeedItemRequest, gagvr::FeedItem> _callGetFeedItem;

        private readonly gaxgrpc::ApiCall<MutateFeedItemsRequest, MutateFeedItemsResponse> _callMutateFeedItems;

        /// <summary>
        /// Constructs a client wrapper for the FeedItemService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FeedItemServiceSettings"/> used within this client.</param>
        public FeedItemServiceClientImpl(FeedItemService.FeedItemServiceClient grpcClient, FeedItemServiceSettings settings)
        {
            GrpcClient = grpcClient;
            FeedItemServiceSettings effectiveSettings = settings ?? FeedItemServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetFeedItem = clientHelper.BuildApiCall<GetFeedItemRequest, gagvr::FeedItem>(grpcClient.GetFeedItemAsync, grpcClient.GetFeedItem, effectiveSettings.GetFeedItemSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetFeedItem);
            Modify_GetFeedItemApiCall(ref _callGetFeedItem);
            _callMutateFeedItems = clientHelper.BuildApiCall<MutateFeedItemsRequest, MutateFeedItemsResponse>(grpcClient.MutateFeedItemsAsync, grpcClient.MutateFeedItems, effectiveSettings.MutateFeedItemsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateFeedItems);
            Modify_MutateFeedItemsApiCall(ref _callMutateFeedItems);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFeedItemApiCall(ref gaxgrpc::ApiCall<GetFeedItemRequest, gagvr::FeedItem> call);

        partial void Modify_MutateFeedItemsApiCall(ref gaxgrpc::ApiCall<MutateFeedItemsRequest, MutateFeedItemsResponse> call);

        partial void OnConstruction(FeedItemService.FeedItemServiceClient grpcClient, FeedItemServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeedItemService client</summary>
        public override FeedItemService.FeedItemServiceClient GrpcClient { get; }

        partial void Modify_GetFeedItemRequest(ref GetFeedItemRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateFeedItemsRequest(ref MutateFeedItemsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::FeedItem GetFeedItem(GetFeedItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedItemRequest(ref request, ref callSettings);
            return _callGetFeedItem.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested feed item in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::FeedItem> GetFeedItemAsync(GetFeedItemRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedItemRequest(ref request, ref callSettings);
            return _callGetFeedItem.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes feed items. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateFeedItemsResponse MutateFeedItems(MutateFeedItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedItemsRequest(ref request, ref callSettings);
            return _callMutateFeedItems.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes feed items. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateFeedItemsResponse> MutateFeedItemsAsync(MutateFeedItemsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedItemsRequest(ref request, ref callSettings);
            return _callMutateFeedItems.Async(request, callSettings);
        }
    }
}

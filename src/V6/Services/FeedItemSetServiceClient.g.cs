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

using gagvr = Google.Ads.GoogleAds.V6.Resources;
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

namespace Google.Ads.GoogleAds.V6.Services
{
    /// <summary>Settings for <see cref="FeedItemSetServiceClient"/> instances.</summary>
    public sealed partial class FeedItemSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeedItemSetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeedItemSetServiceSettings"/>.</returns>
        public static FeedItemSetServiceSettings GetDefault() => new FeedItemSetServiceSettings();

        /// <summary>Constructs a new <see cref="FeedItemSetServiceSettings"/> object with default settings.</summary>
        public FeedItemSetServiceSettings()
        {
        }

        private FeedItemSetServiceSettings(FeedItemSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFeedItemSetSettings = existing.GetFeedItemSetSettings;
            MutateFeedItemSetsSettings = existing.MutateFeedItemSetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeedItemSetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedItemSetServiceClient.GetFeedItemSet</c> and <c>FeedItemSetServiceClient.GetFeedItemSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeedItemSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedItemSetServiceClient.MutateFeedItemSets</c> and <c>FeedItemSetServiceClient.MutateFeedItemSetsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateFeedItemSetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeedItemSetServiceSettings"/> object.</returns>
        public FeedItemSetServiceSettings Clone() => new FeedItemSetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeedItemSetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class FeedItemSetServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeedItemSetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeedItemSetServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref FeedItemSetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeedItemSetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeedItemSetServiceClient Build()
        {
            FeedItemSetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeedItemSetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeedItemSetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeedItemSetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeedItemSetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<FeedItemSetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeedItemSetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => FeedItemSetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => FeedItemSetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeedItemSetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>FeedItemSetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feed Item Set
    /// </remarks>
    public abstract partial class FeedItemSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeedItemSetService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default FeedItemSetService scopes.</summary>
        /// <remarks>
        /// The default FeedItemSetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="FeedItemSetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedItemSetServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeedItemSetServiceClient"/>.</returns>
        public static stt::Task<FeedItemSetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeedItemSetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeedItemSetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedItemSetServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="FeedItemSetServiceClient"/>.</returns>
        public static FeedItemSetServiceClient Create() => new FeedItemSetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeedItemSetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeedItemSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="FeedItemSetServiceClient"/>.</returns>
        internal static FeedItemSetServiceClient Create(grpccore::CallInvoker callInvoker, FeedItemSetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeedItemSetService.FeedItemSetServiceClient grpcClient = new FeedItemSetService.FeedItemSetServiceClient(callInvoker);
            return new FeedItemSetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC FeedItemSetService client</summary>
        public virtual FeedItemSetService.FeedItemSetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedItemSet GetFeedItemSet(GetFeedItemSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemSet> GetFeedItemSetAsync(GetFeedItemSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemSet> GetFeedItemSetAsync(GetFeedItemSetRequest request, st::CancellationToken cancellationToken) =>
            GetFeedItemSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedItemSet GetFeedItemSet(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItemSet(new GetFeedItemSetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemSet> GetFeedItemSetAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItemSetAsync(new GetFeedItemSetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item set to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemSet> GetFeedItemSetAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetFeedItemSetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedItemSet GetFeedItemSet(gagvr::FeedItemSetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItemSet(new GetFeedItemSetRequest
            {
                ResourceNameAsFeedItemSetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemSet> GetFeedItemSetAsync(gagvr::FeedItemSetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItemSetAsync(new GetFeedItemSetRequest
            {
                ResourceNameAsFeedItemSetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item set to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemSet> GetFeedItemSetAsync(gagvr::FeedItemSetName resourceName, st::CancellationToken cancellationToken) =>
            GetFeedItemSetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes feed item sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateFeedItemSetsResponse MutateFeedItemSets(MutateFeedItemSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes feed item sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemSetsResponse> MutateFeedItemSetsAsync(MutateFeedItemSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes feed item sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemSetsResponse> MutateFeedItemSetsAsync(MutateFeedItemSetsRequest request, st::CancellationToken cancellationToken) =>
            MutateFeedItemSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes feed item sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed item sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed item sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateFeedItemSetsResponse MutateFeedItemSets(string customerId, scg::IEnumerable<FeedItemSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedItemSets(new MutateFeedItemSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes feed item sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed item sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed item sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemSetsResponse> MutateFeedItemSetsAsync(string customerId, scg::IEnumerable<FeedItemSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedItemSetsAsync(new MutateFeedItemSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes feed item sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed item sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed item sets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemSetsResponse> MutateFeedItemSetsAsync(string customerId, scg::IEnumerable<FeedItemSetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateFeedItemSetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeedItemSetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feed Item Set
    /// </remarks>
    public sealed partial class FeedItemSetServiceClientImpl : FeedItemSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetFeedItemSetRequest, gagvr::FeedItemSet> _callGetFeedItemSet;

        private readonly gaxgrpc::ApiCall<MutateFeedItemSetsRequest, MutateFeedItemSetsResponse> _callMutateFeedItemSets;

        /// <summary>
        /// Constructs a client wrapper for the FeedItemSetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FeedItemSetServiceSettings"/> used within this client.</param>
        public FeedItemSetServiceClientImpl(FeedItemSetService.FeedItemSetServiceClient grpcClient, FeedItemSetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            FeedItemSetServiceSettings effectiveSettings = settings ?? FeedItemSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetFeedItemSet = clientHelper.BuildApiCall<GetFeedItemSetRequest, gagvr::FeedItemSet>(grpcClient.GetFeedItemSetAsync, grpcClient.GetFeedItemSet, effectiveSettings.GetFeedItemSetSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetFeedItemSet);
            Modify_GetFeedItemSetApiCall(ref _callGetFeedItemSet);
            _callMutateFeedItemSets = clientHelper.BuildApiCall<MutateFeedItemSetsRequest, MutateFeedItemSetsResponse>(grpcClient.MutateFeedItemSetsAsync, grpcClient.MutateFeedItemSets, effectiveSettings.MutateFeedItemSetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateFeedItemSets);
            Modify_MutateFeedItemSetsApiCall(ref _callMutateFeedItemSets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFeedItemSetApiCall(ref gaxgrpc::ApiCall<GetFeedItemSetRequest, gagvr::FeedItemSet> call);

        partial void Modify_MutateFeedItemSetsApiCall(ref gaxgrpc::ApiCall<MutateFeedItemSetsRequest, MutateFeedItemSetsResponse> call);

        partial void OnConstruction(FeedItemSetService.FeedItemSetServiceClient grpcClient, FeedItemSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeedItemSetService client</summary>
        public override FeedItemSetService.FeedItemSetServiceClient GrpcClient { get; }

        partial void Modify_GetFeedItemSetRequest(ref GetFeedItemSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateFeedItemSetsRequest(ref MutateFeedItemSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::FeedItemSet GetFeedItemSet(GetFeedItemSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedItemSetRequest(ref request, ref callSettings);
            return _callGetFeedItemSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested feed item set in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::FeedItemSet> GetFeedItemSetAsync(GetFeedItemSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedItemSetRequest(ref request, ref callSettings);
            return _callGetFeedItemSet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes feed item sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateFeedItemSetsResponse MutateFeedItemSets(MutateFeedItemSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedItemSetsRequest(ref request, ref callSettings);
            return _callMutateFeedItemSets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes feed item sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateFeedItemSetsResponse> MutateFeedItemSetsAsync(MutateFeedItemSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedItemSetsRequest(ref request, ref callSettings);
            return _callMutateFeedItemSets.Async(request, callSettings);
        }
    }
}

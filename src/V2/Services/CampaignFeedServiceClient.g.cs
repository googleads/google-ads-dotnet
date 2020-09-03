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

using gagvr = Google.Ads.GoogleAds.V2.Resources;
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

namespace Google.Ads.GoogleAds.V2.Services
{
    /// <summary>Settings for <see cref="CampaignFeedServiceClient"/> instances.</summary>
    public sealed partial class CampaignFeedServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignFeedServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignFeedServiceSettings"/>.</returns>
        public static CampaignFeedServiceSettings GetDefault() => new CampaignFeedServiceSettings();

        /// <summary>Constructs a new <see cref="CampaignFeedServiceSettings"/> object with default settings.</summary>
        public CampaignFeedServiceSettings()
        {
        }

        private CampaignFeedServiceSettings(CampaignFeedServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignFeedSettings = existing.GetCampaignFeedSettings;
            MutateCampaignFeedsSettings = existing.MutateCampaignFeedsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignFeedServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignFeedServiceClient.GetCampaignFeed</c> and <c>CampaignFeedServiceClient.GetCampaignFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCampaignFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignFeedServiceClient.MutateCampaignFeeds</c> and
        /// <c>CampaignFeedServiceClient.MutateCampaignFeedsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCampaignFeedsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignFeedServiceSettings"/> object.</returns>
        public CampaignFeedServiceSettings Clone() => new CampaignFeedServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignFeedServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CampaignFeedServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignFeedServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignFeedServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CampaignFeedServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignFeedServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignFeedServiceClient Build()
        {
            CampaignFeedServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignFeedServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignFeedServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignFeedServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignFeedServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CampaignFeedServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignFeedServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CampaignFeedServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CampaignFeedServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignFeedServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CampaignFeedService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign feeds.
    /// </remarks>
    public abstract partial class CampaignFeedServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignFeedService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignFeedService scopes.</summary>
        /// <remarks>The default CampaignFeedService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignFeedServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignFeedServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignFeedServiceClient"/>.</returns>
        public static stt::Task<CampaignFeedServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignFeedServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignFeedServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignFeedServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignFeedServiceClient"/>.</returns>
        public static CampaignFeedServiceClient Create() => new CampaignFeedServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignFeedServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignFeedServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignFeedServiceClient"/>.</returns>
        internal static CampaignFeedServiceClient Create(grpccore::CallInvoker callInvoker, CampaignFeedServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignFeedService.CampaignFeedServiceClient grpcClient = new CampaignFeedService.CampaignFeedServiceClient(callInvoker);
            return new CampaignFeedServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CampaignFeedService client</summary>
        public virtual CampaignFeedService.CampaignFeedServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignFeed GetCampaignFeed(GetCampaignFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignFeed> GetCampaignFeedAsync(GetCampaignFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignFeed> GetCampaignFeedAsync(GetCampaignFeedRequest request, st::CancellationToken cancellationToken) =>
            GetCampaignFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignFeed GetCampaignFeed(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignFeed(new GetCampaignFeedRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignFeed> GetCampaignFeedAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignFeedAsync(new GetCampaignFeedRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign feed to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignFeed> GetCampaignFeedAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignFeedAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignFeed GetCampaignFeed(gagvr::CampaignFeedName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignFeed(new GetCampaignFeedRequest
            {
                ResourceNameAsCampaignFeedName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignFeed> GetCampaignFeedAsync(gagvr::CampaignFeedName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignFeedAsync(new GetCampaignFeedRequest
            {
                ResourceNameAsCampaignFeedName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign feed to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignFeed> GetCampaignFeedAsync(gagvr::CampaignFeedName resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignFeedAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignFeedsResponse MutateCampaignFeeds(MutateCampaignFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignFeedsResponse> MutateCampaignFeedsAsync(MutateCampaignFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignFeedsResponse> MutateCampaignFeedsAsync(MutateCampaignFeedsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign feeds.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignFeedsResponse MutateCampaignFeeds(string customerId, scg::IEnumerable<CampaignFeedOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignFeeds(new MutateCampaignFeedsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign feeds.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignFeedsResponse> MutateCampaignFeedsAsync(string customerId, scg::IEnumerable<CampaignFeedOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignFeedsAsync(new MutateCampaignFeedsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign feeds.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignFeedsResponse> MutateCampaignFeedsAsync(string customerId, scg::IEnumerable<CampaignFeedOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignFeedsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignFeedService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign feeds.
    /// </remarks>
    public sealed partial class CampaignFeedServiceClientImpl : CampaignFeedServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignFeedRequest, gagvr::CampaignFeed> _callGetCampaignFeed;

        private readonly gaxgrpc::ApiCall<MutateCampaignFeedsRequest, MutateCampaignFeedsResponse> _callMutateCampaignFeeds;

        /// <summary>
        /// Constructs a client wrapper for the CampaignFeedService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignFeedServiceSettings"/> used within this client.</param>
        public CampaignFeedServiceClientImpl(CampaignFeedService.CampaignFeedServiceClient grpcClient, CampaignFeedServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignFeedServiceSettings effectiveSettings = settings ?? CampaignFeedServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignFeed = clientHelper.BuildApiCall<GetCampaignFeedRequest, gagvr::CampaignFeed>(grpcClient.GetCampaignFeedAsync, grpcClient.GetCampaignFeed, effectiveSettings.GetCampaignFeedSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCampaignFeed);
            Modify_GetCampaignFeedApiCall(ref _callGetCampaignFeed);
            _callMutateCampaignFeeds = clientHelper.BuildApiCall<MutateCampaignFeedsRequest, MutateCampaignFeedsResponse>(grpcClient.MutateCampaignFeedsAsync, grpcClient.MutateCampaignFeeds, effectiveSettings.MutateCampaignFeedsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignFeeds);
            Modify_MutateCampaignFeedsApiCall(ref _callMutateCampaignFeeds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCampaignFeedApiCall(ref gaxgrpc::ApiCall<GetCampaignFeedRequest, gagvr::CampaignFeed> call);

        partial void Modify_MutateCampaignFeedsApiCall(ref gaxgrpc::ApiCall<MutateCampaignFeedsRequest, MutateCampaignFeedsResponse> call);

        partial void OnConstruction(CampaignFeedService.CampaignFeedServiceClient grpcClient, CampaignFeedServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignFeedService client</summary>
        public override CampaignFeedService.CampaignFeedServiceClient GrpcClient { get; }

        partial void Modify_GetCampaignFeedRequest(ref GetCampaignFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCampaignFeedsRequest(ref MutateCampaignFeedsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CampaignFeed GetCampaignFeed(GetCampaignFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignFeedRequest(ref request, ref callSettings);
            return _callGetCampaignFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CampaignFeed> GetCampaignFeedAsync(GetCampaignFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignFeedRequest(ref request, ref callSettings);
            return _callGetCampaignFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignFeedsResponse MutateCampaignFeeds(MutateCampaignFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignFeedsRequest(ref request, ref callSettings);
            return _callMutateCampaignFeeds.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignFeedsResponse> MutateCampaignFeedsAsync(MutateCampaignFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignFeedsRequest(ref request, ref callSettings);
            return _callMutateCampaignFeeds.Async(request, callSettings);
        }
    }
}

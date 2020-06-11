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

using gagvr = Google.Ads.GoogleAds.V1.Resources;
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

namespace Google.Ads.GoogleAds.V1.Services
{
    /// <summary>Settings for <see cref="AdGroupFeedServiceClient"/> instances.</summary>
    public sealed partial class AdGroupFeedServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupFeedServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupFeedServiceSettings"/>.</returns>
        public static AdGroupFeedServiceSettings GetDefault() => new AdGroupFeedServiceSettings();

        /// <summary>Constructs a new <see cref="AdGroupFeedServiceSettings"/> object with default settings.</summary>
        public AdGroupFeedServiceSettings()
        {
        }

        private AdGroupFeedServiceSettings(AdGroupFeedServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupFeedSettings = existing.GetAdGroupFeedSettings;
            MutateAdGroupFeedsSettings = existing.MutateAdGroupFeedsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupFeedServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupFeedServiceClient.GetAdGroupFeed</c> and <c>AdGroupFeedServiceClient.GetAdGroupFeedAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupFeedSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupFeedServiceClient.MutateAdGroupFeeds</c> and <c>AdGroupFeedServiceClient.MutateAdGroupFeedsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAdGroupFeedsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupFeedServiceSettings"/> object.</returns>
        public AdGroupFeedServiceSettings Clone() => new AdGroupFeedServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupFeedServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AdGroupFeedServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupFeedServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupFeedServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupFeedServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupFeedServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupFeedServiceClient Build()
        {
            AdGroupFeedServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupFeedServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupFeedServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupFeedServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupFeedServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupFeedServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupFeedServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupFeedServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdGroupFeedServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupFeedServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupFeedService client wrapper, for convenient use.</summary>
    public abstract partial class AdGroupFeedServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupFeedService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupFeedService scopes.</summary>
        /// <remarks>The default AdGroupFeedService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupFeedServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdGroupFeedServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupFeedServiceClient"/>.</returns>
        public static stt::Task<AdGroupFeedServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupFeedServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupFeedServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdGroupFeedServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="AdGroupFeedServiceClient"/>.</returns>
        public static AdGroupFeedServiceClient Create() => new AdGroupFeedServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupFeedServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupFeedServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupFeedServiceClient"/>.</returns>
        internal static AdGroupFeedServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupFeedServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupFeedService.AdGroupFeedServiceClient grpcClient = new AdGroupFeedService.AdGroupFeedServiceClient(callInvoker);
            return new AdGroupFeedServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupFeedService client</summary>
        public virtual AdGroupFeedService.AdGroupFeedServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupFeed GetAdGroupFeed(GetAdGroupFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupFeed> GetAdGroupFeedAsync(GetAdGroupFeedRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupFeed> GetAdGroupFeedAsync(GetAdGroupFeedRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupFeedAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupFeed GetAdGroupFeed(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupFeed(new GetAdGroupFeedRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupFeed> GetAdGroupFeedAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupFeedAsync(new GetAdGroupFeedRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group feed to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupFeed> GetAdGroupFeedAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupFeedAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupFeed GetAdGroupFeed(gagvr::AdGroupFeedName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupFeed(new GetAdGroupFeedRequest
            {
                ResourceNameAsAdGroupFeedName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group feed to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupFeed> GetAdGroupFeedAsync(gagvr::AdGroupFeedName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupFeedAsync(new GetAdGroupFeedRequest
            {
                ResourceNameAsAdGroupFeedName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group feed to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupFeed> GetAdGroupFeedAsync(gagvr::AdGroupFeedName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupFeedAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ad group feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupFeedsResponse MutateAdGroupFeeds(MutateAdGroupFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad group feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupFeedsResponse> MutateAdGroupFeedsAsync(MutateAdGroupFeedsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad group feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupFeedsResponse> MutateAdGroupFeedsAsync(MutateAdGroupFeedsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupFeedsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ad group feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group feeds.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupFeedsResponse MutateAdGroupFeeds(string customerId, scg::IEnumerable<AdGroupFeedOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupFeeds(new MutateAdGroupFeedsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad group feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group feeds.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupFeedsResponse> MutateAdGroupFeedsAsync(string customerId, scg::IEnumerable<AdGroupFeedOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupFeedsAsync(new MutateAdGroupFeedsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad group feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group feeds are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group feeds.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupFeedsResponse> MutateAdGroupFeedsAsync(string customerId, scg::IEnumerable<AdGroupFeedOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupFeedsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupFeedService client wrapper implementation, for convenient use.</summary>
    public sealed partial class AdGroupFeedServiceClientImpl : AdGroupFeedServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupFeedRequest, gagvr::AdGroupFeed> _callGetAdGroupFeed;

        private readonly gaxgrpc::ApiCall<MutateAdGroupFeedsRequest, MutateAdGroupFeedsResponse> _callMutateAdGroupFeeds;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupFeedService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdGroupFeedServiceSettings"/> used within this client.</param>
        public AdGroupFeedServiceClientImpl(AdGroupFeedService.AdGroupFeedServiceClient grpcClient, AdGroupFeedServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupFeedServiceSettings effectiveSettings = settings ?? AdGroupFeedServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupFeed = clientHelper.BuildApiCall<GetAdGroupFeedRequest, gagvr::AdGroupFeed>(grpcClient.GetAdGroupFeedAsync, grpcClient.GetAdGroupFeed, effectiveSettings.GetAdGroupFeedSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupFeed);
            Modify_GetAdGroupFeedApiCall(ref _callGetAdGroupFeed);
            _callMutateAdGroupFeeds = clientHelper.BuildApiCall<MutateAdGroupFeedsRequest, MutateAdGroupFeedsResponse>(grpcClient.MutateAdGroupFeedsAsync, grpcClient.MutateAdGroupFeeds, effectiveSettings.MutateAdGroupFeedsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupFeeds);
            Modify_MutateAdGroupFeedsApiCall(ref _callMutateAdGroupFeeds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupFeedApiCall(ref gaxgrpc::ApiCall<GetAdGroupFeedRequest, gagvr::AdGroupFeed> call);

        partial void Modify_MutateAdGroupFeedsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupFeedsRequest, MutateAdGroupFeedsResponse> call);

        partial void OnConstruction(AdGroupFeedService.AdGroupFeedServiceClient grpcClient, AdGroupFeedServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupFeedService client</summary>
        public override AdGroupFeedService.AdGroupFeedServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupFeedRequest(ref GetAdGroupFeedRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateAdGroupFeedsRequest(ref MutateAdGroupFeedsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroupFeed GetAdGroupFeed(GetAdGroupFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupFeedRequest(ref request, ref callSettings);
            return _callGetAdGroupFeed.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group feed in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroupFeed> GetAdGroupFeedAsync(GetAdGroupFeedRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupFeedRequest(ref request, ref callSettings);
            return _callGetAdGroupFeed.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ad group feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupFeedsResponse MutateAdGroupFeeds(MutateAdGroupFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupFeedsRequest(ref request, ref callSettings);
            return _callMutateAdGroupFeeds.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ad group feeds. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupFeedsResponse> MutateAdGroupFeedsAsync(MutateAdGroupFeedsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupFeedsRequest(ref request, ref callSettings);
            return _callMutateAdGroupFeeds.Async(request, callSettings);
        }
    }
}

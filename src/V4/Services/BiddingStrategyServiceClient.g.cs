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

using gagvr = Google.Ads.GoogleAds.V4.Resources;
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

namespace Google.Ads.GoogleAds.V4.Services
{
    /// <summary>Settings for <see cref="BiddingStrategyServiceClient"/> instances.</summary>
    public sealed partial class BiddingStrategyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BiddingStrategyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BiddingStrategyServiceSettings"/>.</returns>
        public static BiddingStrategyServiceSettings GetDefault() => new BiddingStrategyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BiddingStrategyServiceSettings"/> object with default settings.
        /// </summary>
        public BiddingStrategyServiceSettings()
        {
        }

        private BiddingStrategyServiceSettings(BiddingStrategyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBiddingStrategySettings = existing.GetBiddingStrategySettings;
            MutateBiddingStrategiesSettings = existing.MutateBiddingStrategiesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BiddingStrategyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BiddingStrategyServiceClient.GetBiddingStrategy</c> and
        /// <c>BiddingStrategyServiceClient.GetBiddingStrategyAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetBiddingStrategySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BiddingStrategyServiceClient.MutateBiddingStrategies</c> and
        /// <c>BiddingStrategyServiceClient.MutateBiddingStrategiesAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateBiddingStrategiesSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BiddingStrategyServiceSettings"/> object.</returns>
        public BiddingStrategyServiceSettings Clone() => new BiddingStrategyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BiddingStrategyServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class BiddingStrategyServiceClientBuilder : gaxgrpc::ClientBuilderBase<BiddingStrategyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BiddingStrategyServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref BiddingStrategyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BiddingStrategyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BiddingStrategyServiceClient Build()
        {
            BiddingStrategyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BiddingStrategyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BiddingStrategyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BiddingStrategyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BiddingStrategyServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<BiddingStrategyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BiddingStrategyServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => BiddingStrategyServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => BiddingStrategyServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BiddingStrategyServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>BiddingStrategyService client wrapper, for convenient use.</summary>
    public abstract partial class BiddingStrategyServiceClient
    {
        /// <summary>
        /// The default endpoint for the BiddingStrategyService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default BiddingStrategyService scopes.</summary>
        /// <remarks>The default BiddingStrategyService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="BiddingStrategyServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BiddingStrategyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BiddingStrategyServiceClient"/>.</returns>
        public static stt::Task<BiddingStrategyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BiddingStrategyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BiddingStrategyServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BiddingStrategyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BiddingStrategyServiceClient"/>.</returns>
        public static BiddingStrategyServiceClient Create() => new BiddingStrategyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BiddingStrategyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BiddingStrategyServiceSettings"/>.</param>
        /// <returns>The created <see cref="BiddingStrategyServiceClient"/>.</returns>
        internal static BiddingStrategyServiceClient Create(grpccore::CallInvoker callInvoker, BiddingStrategyServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BiddingStrategyService.BiddingStrategyServiceClient grpcClient = new BiddingStrategyService.BiddingStrategyServiceClient(callInvoker);
            return new BiddingStrategyServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC BiddingStrategyService client</summary>
        public virtual BiddingStrategyService.BiddingStrategyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::BiddingStrategy GetBiddingStrategy(GetBiddingStrategyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(GetBiddingStrategyRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(GetBiddingStrategyRequest request, st::CancellationToken cancellationToken) =>
            GetBiddingStrategyAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::BiddingStrategy GetBiddingStrategy(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetBiddingStrategy(new GetBiddingStrategyRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetBiddingStrategyAsync(new GetBiddingStrategyRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetBiddingStrategyAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::BiddingStrategy GetBiddingStrategy(gagvr::BiddingStrategyName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetBiddingStrategy(new GetBiddingStrategyRequest
            {
                ResourceNameAsBiddingStrategyName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(gagvr::BiddingStrategyName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetBiddingStrategyAsync(new GetBiddingStrategyRequest
            {
                ResourceNameAsBiddingStrategyName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the bidding strategy to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(gagvr::BiddingStrategyName resourceName, st::CancellationToken cancellationToken) =>
            GetBiddingStrategyAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBiddingStrategiesResponse MutateBiddingStrategies(MutateBiddingStrategiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(MutateBiddingStrategiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(MutateBiddingStrategiesRequest request, st::CancellationToken cancellationToken) =>
            MutateBiddingStrategiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose bidding strategies are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual bidding strategies.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBiddingStrategiesResponse MutateBiddingStrategies(string customerId, scg::IEnumerable<BiddingStrategyOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateBiddingStrategies(new MutateBiddingStrategiesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose bidding strategies are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual bidding strategies.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(string customerId, scg::IEnumerable<BiddingStrategyOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateBiddingStrategiesAsync(new MutateBiddingStrategiesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose bidding strategies are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual bidding strategies.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(string customerId, scg::IEnumerable<BiddingStrategyOperation> operations, st::CancellationToken cancellationToken) =>
            MutateBiddingStrategiesAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BiddingStrategyService client wrapper implementation, for convenient use.</summary>
    public sealed partial class BiddingStrategyServiceClientImpl : BiddingStrategyServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBiddingStrategyRequest, gagvr::BiddingStrategy> _callGetBiddingStrategy;

        private readonly gaxgrpc::ApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse> _callMutateBiddingStrategies;

        /// <summary>
        /// Constructs a client wrapper for the BiddingStrategyService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BiddingStrategyServiceSettings"/> used within this client.
        /// </param>
        public BiddingStrategyServiceClientImpl(BiddingStrategyService.BiddingStrategyServiceClient grpcClient, BiddingStrategyServiceSettings settings)
        {
            GrpcClient = grpcClient;
            BiddingStrategyServiceSettings effectiveSettings = settings ?? BiddingStrategyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetBiddingStrategy = clientHelper.BuildApiCall<GetBiddingStrategyRequest, gagvr::BiddingStrategy>(grpcClient.GetBiddingStrategyAsync, grpcClient.GetBiddingStrategy, effectiveSettings.GetBiddingStrategySettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetBiddingStrategy);
            Modify_GetBiddingStrategyApiCall(ref _callGetBiddingStrategy);
            _callMutateBiddingStrategies = clientHelper.BuildApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse>(grpcClient.MutateBiddingStrategiesAsync, grpcClient.MutateBiddingStrategies, effectiveSettings.MutateBiddingStrategiesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateBiddingStrategies);
            Modify_MutateBiddingStrategiesApiCall(ref _callMutateBiddingStrategies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetBiddingStrategyApiCall(ref gaxgrpc::ApiCall<GetBiddingStrategyRequest, gagvr::BiddingStrategy> call);

        partial void Modify_MutateBiddingStrategiesApiCall(ref gaxgrpc::ApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse> call);

        partial void OnConstruction(BiddingStrategyService.BiddingStrategyServiceClient grpcClient, BiddingStrategyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BiddingStrategyService client</summary>
        public override BiddingStrategyService.BiddingStrategyServiceClient GrpcClient { get; }

        partial void Modify_GetBiddingStrategyRequest(ref GetBiddingStrategyRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateBiddingStrategiesRequest(ref MutateBiddingStrategiesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::BiddingStrategy GetBiddingStrategy(GetBiddingStrategyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBiddingStrategyRequest(ref request, ref callSettings);
            return _callGetBiddingStrategy.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested bidding strategy in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::BiddingStrategy> GetBiddingStrategyAsync(GetBiddingStrategyRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBiddingStrategyRequest(ref request, ref callSettings);
            return _callGetBiddingStrategy.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateBiddingStrategiesResponse MutateBiddingStrategies(MutateBiddingStrategiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBiddingStrategiesRequest(ref request, ref callSettings);
            return _callMutateBiddingStrategies.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(MutateBiddingStrategiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBiddingStrategiesRequest(ref request, ref callSettings);
            return _callMutateBiddingStrategies.Async(request, callSettings);
        }
    }
}

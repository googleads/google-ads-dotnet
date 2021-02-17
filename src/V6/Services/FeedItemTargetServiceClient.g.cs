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
    /// <summary>Settings for <see cref="FeedItemTargetServiceClient"/> instances.</summary>
    public sealed partial class FeedItemTargetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeedItemTargetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeedItemTargetServiceSettings"/>.</returns>
        public static FeedItemTargetServiceSettings GetDefault() => new FeedItemTargetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="FeedItemTargetServiceSettings"/> object with default settings.
        /// </summary>
        public FeedItemTargetServiceSettings()
        {
        }

        private FeedItemTargetServiceSettings(FeedItemTargetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetFeedItemTargetSettings = existing.GetFeedItemTargetSettings;
            MutateFeedItemTargetsSettings = existing.MutateFeedItemTargetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeedItemTargetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedItemTargetServiceClient.GetFeedItemTarget</c> and
        /// <c>FeedItemTargetServiceClient.GetFeedItemTargetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetFeedItemTargetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedItemTargetServiceClient.MutateFeedItemTargets</c> and
        /// <c>FeedItemTargetServiceClient.MutateFeedItemTargetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateFeedItemTargetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeedItemTargetServiceSettings"/> object.</returns>
        public FeedItemTargetServiceSettings Clone() => new FeedItemTargetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeedItemTargetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class FeedItemTargetServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeedItemTargetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeedItemTargetServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref FeedItemTargetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeedItemTargetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeedItemTargetServiceClient Build()
        {
            FeedItemTargetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeedItemTargetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeedItemTargetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeedItemTargetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeedItemTargetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<FeedItemTargetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeedItemTargetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => FeedItemTargetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => FeedItemTargetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeedItemTargetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>FeedItemTargetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feed item targets.
    /// </remarks>
    public abstract partial class FeedItemTargetServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeedItemTargetService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default FeedItemTargetService scopes.</summary>
        /// <remarks>
        /// The default FeedItemTargetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="FeedItemTargetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="FeedItemTargetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeedItemTargetServiceClient"/>.</returns>
        public static stt::Task<FeedItemTargetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeedItemTargetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeedItemTargetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="FeedItemTargetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="FeedItemTargetServiceClient"/>.</returns>
        public static FeedItemTargetServiceClient Create() => new FeedItemTargetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeedItemTargetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeedItemTargetServiceSettings"/>.</param>
        /// <returns>The created <see cref="FeedItemTargetServiceClient"/>.</returns>
        internal static FeedItemTargetServiceClient Create(grpccore::CallInvoker callInvoker, FeedItemTargetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeedItemTargetService.FeedItemTargetServiceClient grpcClient = new FeedItemTargetService.FeedItemTargetServiceClient(callInvoker);
            return new FeedItemTargetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC FeedItemTargetService client</summary>
        public virtual FeedItemTargetService.FeedItemTargetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedItemTarget GetFeedItemTarget(GetFeedItemTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemTarget> GetFeedItemTargetAsync(GetFeedItemTargetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemTarget> GetFeedItemTargetAsync(GetFeedItemTargetRequest request, st::CancellationToken cancellationToken) =>
            GetFeedItemTargetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item targets to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedItemTarget GetFeedItemTarget(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItemTarget(new GetFeedItemTargetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item targets to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemTarget> GetFeedItemTargetAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItemTargetAsync(new GetFeedItemTargetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item targets to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemTarget> GetFeedItemTargetAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetFeedItemTargetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item targets to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::FeedItemTarget GetFeedItemTarget(gagvr::FeedItemTargetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItemTarget(new GetFeedItemTargetRequest
            {
                ResourceNameAsFeedItemTargetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item targets to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemTarget> GetFeedItemTargetAsync(gagvr::FeedItemTargetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetFeedItemTargetAsync(new GetFeedItemTargetRequest
            {
                ResourceNameAsFeedItemTargetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the feed item targets to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::FeedItemTarget> GetFeedItemTargetAsync(gagvr::FeedItemTargetName resourceName, st::CancellationToken cancellationToken) =>
            GetFeedItemTargetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes feed item targets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateFeedItemTargetsResponse MutateFeedItemTargets(MutateFeedItemTargetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes feed item targets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemTargetsResponse> MutateFeedItemTargetsAsync(MutateFeedItemTargetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes feed item targets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemTargetsResponse> MutateFeedItemTargetsAsync(MutateFeedItemTargetsRequest request, st::CancellationToken cancellationToken) =>
            MutateFeedItemTargetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes feed item targets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed item targets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed item targets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateFeedItemTargetsResponse MutateFeedItemTargets(string customerId, scg::IEnumerable<FeedItemTargetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedItemTargets(new MutateFeedItemTargetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes feed item targets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed item targets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed item targets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemTargetsResponse> MutateFeedItemTargetsAsync(string customerId, scg::IEnumerable<FeedItemTargetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedItemTargetsAsync(new MutateFeedItemTargetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes feed item targets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose feed item targets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed item targets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedItemTargetsResponse> MutateFeedItemTargetsAsync(string customerId, scg::IEnumerable<FeedItemTargetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateFeedItemTargetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeedItemTargetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feed item targets.
    /// </remarks>
    public sealed partial class FeedItemTargetServiceClientImpl : FeedItemTargetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetFeedItemTargetRequest, gagvr::FeedItemTarget> _callGetFeedItemTarget;

        private readonly gaxgrpc::ApiCall<MutateFeedItemTargetsRequest, MutateFeedItemTargetsResponse> _callMutateFeedItemTargets;

        /// <summary>
        /// Constructs a client wrapper for the FeedItemTargetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FeedItemTargetServiceSettings"/> used within this client.</param>
        public FeedItemTargetServiceClientImpl(FeedItemTargetService.FeedItemTargetServiceClient grpcClient, FeedItemTargetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            FeedItemTargetServiceSettings effectiveSettings = settings ?? FeedItemTargetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetFeedItemTarget = clientHelper.BuildApiCall<GetFeedItemTargetRequest, gagvr::FeedItemTarget>(grpcClient.GetFeedItemTargetAsync, grpcClient.GetFeedItemTarget, effectiveSettings.GetFeedItemTargetSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetFeedItemTarget);
            Modify_GetFeedItemTargetApiCall(ref _callGetFeedItemTarget);
            _callMutateFeedItemTargets = clientHelper.BuildApiCall<MutateFeedItemTargetsRequest, MutateFeedItemTargetsResponse>(grpcClient.MutateFeedItemTargetsAsync, grpcClient.MutateFeedItemTargets, effectiveSettings.MutateFeedItemTargetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateFeedItemTargets);
            Modify_MutateFeedItemTargetsApiCall(ref _callMutateFeedItemTargets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetFeedItemTargetApiCall(ref gaxgrpc::ApiCall<GetFeedItemTargetRequest, gagvr::FeedItemTarget> call);

        partial void Modify_MutateFeedItemTargetsApiCall(ref gaxgrpc::ApiCall<MutateFeedItemTargetsRequest, MutateFeedItemTargetsResponse> call);

        partial void OnConstruction(FeedItemTargetService.FeedItemTargetServiceClient grpcClient, FeedItemTargetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeedItemTargetService client</summary>
        public override FeedItemTargetService.FeedItemTargetServiceClient GrpcClient { get; }

        partial void Modify_GetFeedItemTargetRequest(ref GetFeedItemTargetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateFeedItemTargetsRequest(ref MutateFeedItemTargetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::FeedItemTarget GetFeedItemTarget(GetFeedItemTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedItemTargetRequest(ref request, ref callSettings);
            return _callGetFeedItemTarget.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested feed item targets in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::FeedItemTarget> GetFeedItemTargetAsync(GetFeedItemTargetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetFeedItemTargetRequest(ref request, ref callSettings);
            return _callGetFeedItemTarget.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or removes feed item targets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateFeedItemTargetsResponse MutateFeedItemTargets(MutateFeedItemTargetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedItemTargetsRequest(ref request, ref callSettings);
            return _callMutateFeedItemTargets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes feed item targets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateFeedItemTargetsResponse> MutateFeedItemTargetsAsync(MutateFeedItemTargetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedItemTargetsRequest(ref request, ref callSettings);
            return _callMutateFeedItemTargets.Async(request, callSettings);
        }
    }
}

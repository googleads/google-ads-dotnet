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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
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

namespace Google.Ads.GoogleAds.V5.Services
{
    /// <summary>Settings for <see cref="RemarketingActionServiceClient"/> instances.</summary>
    public sealed partial class RemarketingActionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="RemarketingActionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="RemarketingActionServiceSettings"/>.</returns>
        public static RemarketingActionServiceSettings GetDefault() => new RemarketingActionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RemarketingActionServiceSettings"/> object with default settings.
        /// </summary>
        public RemarketingActionServiceSettings()
        {
        }

        private RemarketingActionServiceSettings(RemarketingActionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetRemarketingActionSettings = existing.GetRemarketingActionSettings;
            MutateRemarketingActionsSettings = existing.MutateRemarketingActionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RemarketingActionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RemarketingActionServiceClient.GetRemarketingAction</c> and
        /// <c>RemarketingActionServiceClient.GetRemarketingActionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetRemarketingActionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RemarketingActionServiceClient.MutateRemarketingActions</c> and
        /// <c>RemarketingActionServiceClient.MutateRemarketingActionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateRemarketingActionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="RemarketingActionServiceSettings"/> object.</returns>
        public RemarketingActionServiceSettings Clone() => new RemarketingActionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="RemarketingActionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class RemarketingActionServiceClientBuilder : gaxgrpc::ClientBuilderBase<RemarketingActionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public RemarketingActionServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref RemarketingActionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<RemarketingActionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override RemarketingActionServiceClient Build()
        {
            RemarketingActionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<RemarketingActionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<RemarketingActionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private RemarketingActionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return RemarketingActionServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<RemarketingActionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return RemarketingActionServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => RemarketingActionServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => RemarketingActionServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => RemarketingActionServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>RemarketingActionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage remarketing actions.
    /// </remarks>
    public abstract partial class RemarketingActionServiceClient
    {
        /// <summary>
        /// The default endpoint for the RemarketingActionService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default RemarketingActionService scopes.</summary>
        /// <remarks>
        /// The default RemarketingActionService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="RemarketingActionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="RemarketingActionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="RemarketingActionServiceClient"/>.</returns>
        public static stt::Task<RemarketingActionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new RemarketingActionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="RemarketingActionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="RemarketingActionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="RemarketingActionServiceClient"/>.</returns>
        public static RemarketingActionServiceClient Create() => new RemarketingActionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="RemarketingActionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="RemarketingActionServiceSettings"/>.</param>
        /// <returns>The created <see cref="RemarketingActionServiceClient"/>.</returns>
        internal static RemarketingActionServiceClient Create(grpccore::CallInvoker callInvoker, RemarketingActionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RemarketingActionService.RemarketingActionServiceClient grpcClient = new RemarketingActionService.RemarketingActionServiceClient(callInvoker);
            return new RemarketingActionServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC RemarketingActionService client</summary>
        public virtual RemarketingActionService.RemarketingActionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::RemarketingAction GetRemarketingAction(GetRemarketingActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(GetRemarketingActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(GetRemarketingActionRequest request, st::CancellationToken cancellationToken) =>
            GetRemarketingActionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the remarketing action to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::RemarketingAction GetRemarketingAction(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetRemarketingAction(new GetRemarketingActionRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the remarketing action to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetRemarketingActionAsync(new GetRemarketingActionRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the remarketing action to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetRemarketingActionAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the remarketing action to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::RemarketingAction GetRemarketingAction(gagvr::RemarketingActionName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetRemarketingAction(new GetRemarketingActionRequest
            {
                ResourceNameAsRemarketingActionName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the remarketing action to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(gagvr::RemarketingActionName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetRemarketingActionAsync(new GetRemarketingActionRequest
            {
                ResourceNameAsRemarketingActionName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the remarketing action to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(gagvr::RemarketingActionName resourceName, st::CancellationToken cancellationToken) =>
            GetRemarketingActionAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRemarketingActionsResponse MutateRemarketingActions(MutateRemarketingActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(MutateRemarketingActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(MutateRemarketingActionsRequest request, st::CancellationToken cancellationToken) =>
            MutateRemarketingActionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose remarketing actions are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual remarketing actions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateRemarketingActionsResponse MutateRemarketingActions(string customerId, scg::IEnumerable<RemarketingActionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRemarketingActions(new MutateRemarketingActionsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose remarketing actions are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual remarketing actions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(string customerId, scg::IEnumerable<RemarketingActionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateRemarketingActionsAsync(new MutateRemarketingActionsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose remarketing actions are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual remarketing actions.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(string customerId, scg::IEnumerable<RemarketingActionOperation> operations, st::CancellationToken cancellationToken) =>
            MutateRemarketingActionsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>RemarketingActionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage remarketing actions.
    /// </remarks>
    public sealed partial class RemarketingActionServiceClientImpl : RemarketingActionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetRemarketingActionRequest, gagvr::RemarketingAction> _callGetRemarketingAction;

        private readonly gaxgrpc::ApiCall<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse> _callMutateRemarketingActions;

        /// <summary>
        /// Constructs a client wrapper for the RemarketingActionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="RemarketingActionServiceSettings"/> used within this client.
        /// </param>
        public RemarketingActionServiceClientImpl(RemarketingActionService.RemarketingActionServiceClient grpcClient, RemarketingActionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            RemarketingActionServiceSettings effectiveSettings = settings ?? RemarketingActionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetRemarketingAction = clientHelper.BuildApiCall<GetRemarketingActionRequest, gagvr::RemarketingAction>(grpcClient.GetRemarketingActionAsync, grpcClient.GetRemarketingAction, effectiveSettings.GetRemarketingActionSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetRemarketingAction);
            Modify_GetRemarketingActionApiCall(ref _callGetRemarketingAction);
            _callMutateRemarketingActions = clientHelper.BuildApiCall<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse>(grpcClient.MutateRemarketingActionsAsync, grpcClient.MutateRemarketingActions, effectiveSettings.MutateRemarketingActionsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateRemarketingActions);
            Modify_MutateRemarketingActionsApiCall(ref _callMutateRemarketingActions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetRemarketingActionApiCall(ref gaxgrpc::ApiCall<GetRemarketingActionRequest, gagvr::RemarketingAction> call);

        partial void Modify_MutateRemarketingActionsApiCall(ref gaxgrpc::ApiCall<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse> call);

        partial void OnConstruction(RemarketingActionService.RemarketingActionServiceClient grpcClient, RemarketingActionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC RemarketingActionService client</summary>
        public override RemarketingActionService.RemarketingActionServiceClient GrpcClient { get; }

        partial void Modify_GetRemarketingActionRequest(ref GetRemarketingActionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateRemarketingActionsRequest(ref MutateRemarketingActionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::RemarketingAction GetRemarketingAction(GetRemarketingActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRemarketingActionRequest(ref request, ref callSettings);
            return _callGetRemarketingAction.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(GetRemarketingActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRemarketingActionRequest(ref request, ref callSettings);
            return _callGetRemarketingAction.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateRemarketingActionsResponse MutateRemarketingActions(MutateRemarketingActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRemarketingActionsRequest(ref request, ref callSettings);
            return _callMutateRemarketingActions.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(MutateRemarketingActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRemarketingActionsRequest(ref request, ref callSettings);
            return _callMutateRemarketingActions.Async(request, callSettings);
        }
    }
}

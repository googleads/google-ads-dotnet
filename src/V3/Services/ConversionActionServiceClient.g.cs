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
    /// <summary>Settings for <see cref="ConversionActionServiceClient"/> instances.</summary>
    public sealed partial class ConversionActionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversionActionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversionActionServiceSettings"/>.</returns>
        public static ConversionActionServiceSettings GetDefault() => new ConversionActionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionActionServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionActionServiceSettings()
        {
        }

        private ConversionActionServiceSettings(ConversionActionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetConversionActionSettings = existing.GetConversionActionSettings;
            MutateConversionActionsSettings = existing.MutateConversionActionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionActionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionActionServiceClient.GetConversionAction</c> and
        /// <c>ConversionActionServiceClient.GetConversionActionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConversionActionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionActionServiceClient.MutateConversionActions</c> and
        /// <c>ConversionActionServiceClient.MutateConversionActionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateConversionActionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversionActionServiceSettings"/> object.</returns>
        public ConversionActionServiceSettings Clone() => new ConversionActionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversionActionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ConversionActionServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversionActionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversionActionServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ConversionActionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversionActionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversionActionServiceClient Build()
        {
            ConversionActionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversionActionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversionActionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversionActionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversionActionServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ConversionActionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversionActionServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ConversionActionServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ConversionActionServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversionActionServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ConversionActionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage conversion actions.
    /// </remarks>
    public abstract partial class ConversionActionServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionActionService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ConversionActionService scopes.</summary>
        /// <remarks>The default ConversionActionService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversionActionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionActionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversionActionServiceClient"/>.</returns>
        public static stt::Task<ConversionActionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversionActionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversionActionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionActionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversionActionServiceClient"/>.</returns>
        public static ConversionActionServiceClient Create() => new ConversionActionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversionActionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversionActionServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionActionServiceClient"/>.</returns>
        internal static ConversionActionServiceClient Create(grpccore::CallInvoker callInvoker, ConversionActionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionActionService.ConversionActionServiceClient grpcClient = new ConversionActionService.ConversionActionServiceClient(callInvoker);
            return new ConversionActionServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ConversionActionService client</summary>
        public virtual ConversionActionService.ConversionActionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ConversionAction GetConversionAction(GetConversionActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionAction> GetConversionActionAsync(GetConversionActionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionAction> GetConversionActionAsync(GetConversionActionRequest request, st::CancellationToken cancellationToken) =>
            GetConversionActionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion action to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ConversionAction GetConversionAction(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionAction(new GetConversionActionRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion action to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionAction> GetConversionActionAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionActionAsync(new GetConversionActionRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion action to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionAction> GetConversionActionAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetConversionActionAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion action to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ConversionAction GetConversionAction(gagvr::ConversionActionName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionAction(new GetConversionActionRequest
            {
                ResourceNameAsConversionActionName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion action to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionAction> GetConversionActionAsync(gagvr::ConversionActionName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionActionAsync(new GetConversionActionRequest
            {
                ResourceNameAsConversionActionName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion action to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionAction> GetConversionActionAsync(gagvr::ConversionActionName resourceName, st::CancellationToken cancellationToken) =>
            GetConversionActionAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateConversionActionsResponse MutateConversionActions(MutateConversionActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(MutateConversionActionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(MutateConversionActionsRequest request, st::CancellationToken cancellationToken) =>
            MutateConversionActionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion actions are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion actions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateConversionActionsResponse MutateConversionActions(string customerId, scg::IEnumerable<ConversionActionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateConversionActions(new MutateConversionActionsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion actions are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion actions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(string customerId, scg::IEnumerable<ConversionActionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateConversionActionsAsync(new MutateConversionActionsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion actions are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion actions.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(string customerId, scg::IEnumerable<ConversionActionOperation> operations, st::CancellationToken cancellationToken) =>
            MutateConversionActionsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConversionActionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage conversion actions.
    /// </remarks>
    public sealed partial class ConversionActionServiceClientImpl : ConversionActionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetConversionActionRequest, gagvr::ConversionAction> _callGetConversionAction;

        private readonly gaxgrpc::ApiCall<MutateConversionActionsRequest, MutateConversionActionsResponse> _callMutateConversionActions;

        /// <summary>
        /// Constructs a client wrapper for the ConversionActionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConversionActionServiceSettings"/> used within this client.
        /// </param>
        public ConversionActionServiceClientImpl(ConversionActionService.ConversionActionServiceClient grpcClient, ConversionActionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ConversionActionServiceSettings effectiveSettings = settings ?? ConversionActionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetConversionAction = clientHelper.BuildApiCall<GetConversionActionRequest, gagvr::ConversionAction>(grpcClient.GetConversionActionAsync, grpcClient.GetConversionAction, effectiveSettings.GetConversionActionSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetConversionAction);
            Modify_GetConversionActionApiCall(ref _callGetConversionAction);
            _callMutateConversionActions = clientHelper.BuildApiCall<MutateConversionActionsRequest, MutateConversionActionsResponse>(grpcClient.MutateConversionActionsAsync, grpcClient.MutateConversionActions, effectiveSettings.MutateConversionActionsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateConversionActions);
            Modify_MutateConversionActionsApiCall(ref _callMutateConversionActions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetConversionActionApiCall(ref gaxgrpc::ApiCall<GetConversionActionRequest, gagvr::ConversionAction> call);

        partial void Modify_MutateConversionActionsApiCall(ref gaxgrpc::ApiCall<MutateConversionActionsRequest, MutateConversionActionsResponse> call);

        partial void OnConstruction(ConversionActionService.ConversionActionServiceClient grpcClient, ConversionActionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversionActionService client</summary>
        public override ConversionActionService.ConversionActionServiceClient GrpcClient { get; }

        partial void Modify_GetConversionActionRequest(ref GetConversionActionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateConversionActionsRequest(ref MutateConversionActionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::ConversionAction GetConversionAction(GetConversionActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionActionRequest(ref request, ref callSettings);
            return _callGetConversionAction.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::ConversionAction> GetConversionActionAsync(GetConversionActionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionActionRequest(ref request, ref callSettings);
            return _callGetConversionAction.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateConversionActionsResponse MutateConversionActions(MutateConversionActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionActionsRequest(ref request, ref callSettings);
            return _callMutateConversionActions.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(MutateConversionActionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionActionsRequest(ref request, ref callSettings);
            return _callMutateConversionActions.Async(request, callSettings);
        }
    }
}

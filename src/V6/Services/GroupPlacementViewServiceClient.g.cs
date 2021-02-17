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
    /// <summary>Settings for <see cref="GroupPlacementViewServiceClient"/> instances.</summary>
    public sealed partial class GroupPlacementViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GroupPlacementViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GroupPlacementViewServiceSettings"/>.</returns>
        public static GroupPlacementViewServiceSettings GetDefault() => new GroupPlacementViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="GroupPlacementViewServiceSettings"/> object with default settings.
        /// </summary>
        public GroupPlacementViewServiceSettings()
        {
        }

        private GroupPlacementViewServiceSettings(GroupPlacementViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetGroupPlacementViewSettings = existing.GetGroupPlacementViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GroupPlacementViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GroupPlacementViewServiceClient.GetGroupPlacementView</c> and
        /// <c>GroupPlacementViewServiceClient.GetGroupPlacementViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetGroupPlacementViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GroupPlacementViewServiceSettings"/> object.</returns>
        public GroupPlacementViewServiceSettings Clone() => new GroupPlacementViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GroupPlacementViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class GroupPlacementViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<GroupPlacementViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GroupPlacementViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref GroupPlacementViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GroupPlacementViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GroupPlacementViewServiceClient Build()
        {
            GroupPlacementViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GroupPlacementViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GroupPlacementViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GroupPlacementViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GroupPlacementViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<GroupPlacementViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GroupPlacementViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => GroupPlacementViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => GroupPlacementViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GroupPlacementViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>GroupPlacementViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Group Placement views.
    /// </remarks>
    public abstract partial class GroupPlacementViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the GroupPlacementViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default GroupPlacementViewService scopes.</summary>
        /// <remarks>
        /// The default GroupPlacementViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="GroupPlacementViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GroupPlacementViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GroupPlacementViewServiceClient"/>.</returns>
        public static stt::Task<GroupPlacementViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GroupPlacementViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GroupPlacementViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="GroupPlacementViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GroupPlacementViewServiceClient"/>.</returns>
        public static GroupPlacementViewServiceClient Create() => new GroupPlacementViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GroupPlacementViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GroupPlacementViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="GroupPlacementViewServiceClient"/>.</returns>
        internal static GroupPlacementViewServiceClient Create(grpccore::CallInvoker callInvoker, GroupPlacementViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GroupPlacementViewService.GroupPlacementViewServiceClient grpcClient = new GroupPlacementViewService.GroupPlacementViewServiceClient(callInvoker);
            return new GroupPlacementViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC GroupPlacementViewService client</summary>
        public virtual GroupPlacementViewService.GroupPlacementViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::GroupPlacementView GetGroupPlacementView(GetGroupPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(GetGroupPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(GetGroupPlacementViewRequest request, st::CancellationToken cancellationToken) =>
            GetGroupPlacementViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Group Placement view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::GroupPlacementView GetGroupPlacementView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupPlacementView(new GetGroupPlacementViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Group Placement view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupPlacementViewAsync(new GetGroupPlacementViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Group Placement view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetGroupPlacementViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Group Placement view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::GroupPlacementView GetGroupPlacementView(gagvr::GroupPlacementViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupPlacementView(new GetGroupPlacementViewRequest
            {
                ResourceNameAsGroupPlacementViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Group Placement view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(gagvr::GroupPlacementViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetGroupPlacementViewAsync(new GetGroupPlacementViewRequest
            {
                ResourceNameAsGroupPlacementViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Group Placement view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(gagvr::GroupPlacementViewName resourceName, st::CancellationToken cancellationToken) =>
            GetGroupPlacementViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GroupPlacementViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Group Placement views.
    /// </remarks>
    public sealed partial class GroupPlacementViewServiceClientImpl : GroupPlacementViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetGroupPlacementViewRequest, gagvr::GroupPlacementView> _callGetGroupPlacementView;

        /// <summary>
        /// Constructs a client wrapper for the GroupPlacementViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="GroupPlacementViewServiceSettings"/> used within this client.
        /// </param>
        public GroupPlacementViewServiceClientImpl(GroupPlacementViewService.GroupPlacementViewServiceClient grpcClient, GroupPlacementViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            GroupPlacementViewServiceSettings effectiveSettings = settings ?? GroupPlacementViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetGroupPlacementView = clientHelper.BuildApiCall<GetGroupPlacementViewRequest, gagvr::GroupPlacementView>(grpcClient.GetGroupPlacementViewAsync, grpcClient.GetGroupPlacementView, effectiveSettings.GetGroupPlacementViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetGroupPlacementView);
            Modify_GetGroupPlacementViewApiCall(ref _callGetGroupPlacementView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetGroupPlacementViewApiCall(ref gaxgrpc::ApiCall<GetGroupPlacementViewRequest, gagvr::GroupPlacementView> call);

        partial void OnConstruction(GroupPlacementViewService.GroupPlacementViewServiceClient grpcClient, GroupPlacementViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GroupPlacementViewService client</summary>
        public override GroupPlacementViewService.GroupPlacementViewServiceClient GrpcClient { get; }

        partial void Modify_GetGroupPlacementViewRequest(ref GetGroupPlacementViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::GroupPlacementView GetGroupPlacementView(GetGroupPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupPlacementViewRequest(ref request, ref callSettings);
            return _callGetGroupPlacementView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Group Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::GroupPlacementView> GetGroupPlacementViewAsync(GetGroupPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetGroupPlacementViewRequest(ref request, ref callSettings);
            return _callGetGroupPlacementView.Async(request, callSettings);
        }
    }
}

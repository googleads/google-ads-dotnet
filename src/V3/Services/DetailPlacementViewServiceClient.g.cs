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
    /// <summary>Settings for <see cref="DetailPlacementViewServiceClient"/> instances.</summary>
    public sealed partial class DetailPlacementViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DetailPlacementViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DetailPlacementViewServiceSettings"/>.</returns>
        public static DetailPlacementViewServiceSettings GetDefault() => new DetailPlacementViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DetailPlacementViewServiceSettings"/> object with default settings.
        /// </summary>
        public DetailPlacementViewServiceSettings()
        {
        }

        private DetailPlacementViewServiceSettings(DetailPlacementViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDetailPlacementViewSettings = existing.GetDetailPlacementViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DetailPlacementViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DetailPlacementViewServiceClient.GetDetailPlacementView</c> and
        /// <c>DetailPlacementViewServiceClient.GetDetailPlacementViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDetailPlacementViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DetailPlacementViewServiceSettings"/> object.</returns>
        public DetailPlacementViewServiceSettings Clone() => new DetailPlacementViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DetailPlacementViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DetailPlacementViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<DetailPlacementViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DetailPlacementViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref DetailPlacementViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DetailPlacementViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DetailPlacementViewServiceClient Build()
        {
            DetailPlacementViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DetailPlacementViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DetailPlacementViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DetailPlacementViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DetailPlacementViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DetailPlacementViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DetailPlacementViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DetailPlacementViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DetailPlacementViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DetailPlacementViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DetailPlacementViewService client wrapper, for convenient use.</summary>
    public abstract partial class DetailPlacementViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the DetailPlacementViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default DetailPlacementViewService scopes.</summary>
        /// <remarks>The default DetailPlacementViewService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="DetailPlacementViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DetailPlacementViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DetailPlacementViewServiceClient"/>.</returns>
        public static stt::Task<DetailPlacementViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DetailPlacementViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DetailPlacementViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DetailPlacementViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DetailPlacementViewServiceClient"/>.</returns>
        public static DetailPlacementViewServiceClient Create() => new DetailPlacementViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DetailPlacementViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DetailPlacementViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="DetailPlacementViewServiceClient"/>.</returns>
        internal static DetailPlacementViewServiceClient Create(grpccore::CallInvoker callInvoker, DetailPlacementViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DetailPlacementViewService.DetailPlacementViewServiceClient grpcClient = new DetailPlacementViewService.DetailPlacementViewServiceClient(callInvoker);
            return new DetailPlacementViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DetailPlacementViewService client</summary>
        public virtual DetailPlacementViewService.DetailPlacementViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DetailPlacementView GetDetailPlacementView(GetDetailPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailPlacementView> GetDetailPlacementViewAsync(GetDetailPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailPlacementView> GetDetailPlacementViewAsync(GetDetailPlacementViewRequest request, st::CancellationToken cancellationToken) =>
            GetDetailPlacementViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Detail Placement view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DetailPlacementView GetDetailPlacementView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDetailPlacementView(new GetDetailPlacementViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Detail Placement view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailPlacementView> GetDetailPlacementViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDetailPlacementViewAsync(new GetDetailPlacementViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Detail Placement view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailPlacementView> GetDetailPlacementViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetDetailPlacementViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Detail Placement view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DetailPlacementView GetDetailPlacementView(gagvr::DetailPlacementViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDetailPlacementView(new GetDetailPlacementViewRequest
            {
                ResourceNameAsDetailPlacementViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Detail Placement view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailPlacementView> GetDetailPlacementViewAsync(gagvr::DetailPlacementViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDetailPlacementViewAsync(new GetDetailPlacementViewRequest
            {
                ResourceNameAsDetailPlacementViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Detail Placement view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DetailPlacementView> GetDetailPlacementViewAsync(gagvr::DetailPlacementViewName resourceName, st::CancellationToken cancellationToken) =>
            GetDetailPlacementViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DetailPlacementViewService client wrapper implementation, for convenient use.</summary>
    public sealed partial class DetailPlacementViewServiceClientImpl : DetailPlacementViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDetailPlacementViewRequest, gagvr::DetailPlacementView> _callGetDetailPlacementView;

        /// <summary>
        /// Constructs a client wrapper for the DetailPlacementViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DetailPlacementViewServiceSettings"/> used within this client.
        /// </param>
        public DetailPlacementViewServiceClientImpl(DetailPlacementViewService.DetailPlacementViewServiceClient grpcClient, DetailPlacementViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DetailPlacementViewServiceSettings effectiveSettings = settings ?? DetailPlacementViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetDetailPlacementView = clientHelper.BuildApiCall<GetDetailPlacementViewRequest, gagvr::DetailPlacementView>(grpcClient.GetDetailPlacementViewAsync, grpcClient.GetDetailPlacementView, effectiveSettings.GetDetailPlacementViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetDetailPlacementView);
            Modify_GetDetailPlacementViewApiCall(ref _callGetDetailPlacementView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDetailPlacementViewApiCall(ref gaxgrpc::ApiCall<GetDetailPlacementViewRequest, gagvr::DetailPlacementView> call);

        partial void OnConstruction(DetailPlacementViewService.DetailPlacementViewServiceClient grpcClient, DetailPlacementViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DetailPlacementViewService client</summary>
        public override DetailPlacementViewService.DetailPlacementViewServiceClient GrpcClient { get; }

        partial void Modify_GetDetailPlacementViewRequest(ref GetDetailPlacementViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::DetailPlacementView GetDetailPlacementView(GetDetailPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDetailPlacementViewRequest(ref request, ref callSettings);
            return _callGetDetailPlacementView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Detail Placement view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::DetailPlacementView> GetDetailPlacementViewAsync(GetDetailPlacementViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDetailPlacementViewRequest(ref request, ref callSettings);
            return _callGetDetailPlacementView.Async(request, callSettings);
        }
    }
}

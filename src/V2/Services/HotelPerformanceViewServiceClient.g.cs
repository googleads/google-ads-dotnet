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
    /// <summary>Settings for <see cref="HotelPerformanceViewServiceClient"/> instances.</summary>
    public sealed partial class HotelPerformanceViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="HotelPerformanceViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="HotelPerformanceViewServiceSettings"/>.</returns>
        public static HotelPerformanceViewServiceSettings GetDefault() => new HotelPerformanceViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="HotelPerformanceViewServiceSettings"/> object with default settings.
        /// </summary>
        public HotelPerformanceViewServiceSettings()
        {
        }

        private HotelPerformanceViewServiceSettings(HotelPerformanceViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetHotelPerformanceViewSettings = existing.GetHotelPerformanceViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(HotelPerformanceViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>HotelPerformanceViewServiceClient.GetHotelPerformanceView</c> and
        /// <c>HotelPerformanceViewServiceClient.GetHotelPerformanceViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetHotelPerformanceViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="HotelPerformanceViewServiceSettings"/> object.</returns>
        public HotelPerformanceViewServiceSettings Clone() => new HotelPerformanceViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="HotelPerformanceViewServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class HotelPerformanceViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<HotelPerformanceViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public HotelPerformanceViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref HotelPerformanceViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<HotelPerformanceViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override HotelPerformanceViewServiceClient Build()
        {
            HotelPerformanceViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<HotelPerformanceViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<HotelPerformanceViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private HotelPerformanceViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return HotelPerformanceViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<HotelPerformanceViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return HotelPerformanceViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => HotelPerformanceViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => HotelPerformanceViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => HotelPerformanceViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>HotelPerformanceViewService client wrapper, for convenient use.</summary>
    public abstract partial class HotelPerformanceViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the HotelPerformanceViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default HotelPerformanceViewService scopes.</summary>
        /// <remarks>The default HotelPerformanceViewService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="HotelPerformanceViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="HotelPerformanceViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="HotelPerformanceViewServiceClient"/>.</returns>
        public static stt::Task<HotelPerformanceViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new HotelPerformanceViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="HotelPerformanceViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="HotelPerformanceViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="HotelPerformanceViewServiceClient"/>.</returns>
        public static HotelPerformanceViewServiceClient Create() => new HotelPerformanceViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="HotelPerformanceViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="HotelPerformanceViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="HotelPerformanceViewServiceClient"/>.</returns>
        internal static HotelPerformanceViewServiceClient Create(grpccore::CallInvoker callInvoker, HotelPerformanceViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            HotelPerformanceViewService.HotelPerformanceViewServiceClient grpcClient = new HotelPerformanceViewService.HotelPerformanceViewServiceClient(callInvoker);
            return new HotelPerformanceViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC HotelPerformanceViewService client</summary>
        public virtual HotelPerformanceViewService.HotelPerformanceViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::HotelPerformanceView GetHotelPerformanceView(GetHotelPerformanceViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::HotelPerformanceView> GetHotelPerformanceViewAsync(GetHotelPerformanceViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::HotelPerformanceView> GetHotelPerformanceViewAsync(GetHotelPerformanceViewRequest request, st::CancellationToken cancellationToken) =>
            GetHotelPerformanceViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Performance View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::HotelPerformanceView GetHotelPerformanceView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetHotelPerformanceView(new GetHotelPerformanceViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Performance View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::HotelPerformanceView> GetHotelPerformanceViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetHotelPerformanceViewAsync(new GetHotelPerformanceViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Performance View to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::HotelPerformanceView> GetHotelPerformanceViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetHotelPerformanceViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Performance View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::HotelPerformanceView GetHotelPerformanceView(gagvr::HotelPerformanceViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetHotelPerformanceView(new GetHotelPerformanceViewRequest
            {
                ResourceNameAsHotelPerformanceViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Performance View to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::HotelPerformanceView> GetHotelPerformanceViewAsync(gagvr::HotelPerformanceViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetHotelPerformanceViewAsync(new GetHotelPerformanceViewRequest
            {
                ResourceNameAsHotelPerformanceViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Hotel Performance View to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::HotelPerformanceView> GetHotelPerformanceViewAsync(gagvr::HotelPerformanceViewName resourceName, st::CancellationToken cancellationToken) =>
            GetHotelPerformanceViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>HotelPerformanceViewService client wrapper implementation, for convenient use.</summary>
    public sealed partial class HotelPerformanceViewServiceClientImpl : HotelPerformanceViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetHotelPerformanceViewRequest, gagvr::HotelPerformanceView> _callGetHotelPerformanceView;

        /// <summary>
        /// Constructs a client wrapper for the HotelPerformanceViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="HotelPerformanceViewServiceSettings"/> used within this client.
        /// </param>
        public HotelPerformanceViewServiceClientImpl(HotelPerformanceViewService.HotelPerformanceViewServiceClient grpcClient, HotelPerformanceViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            HotelPerformanceViewServiceSettings effectiveSettings = settings ?? HotelPerformanceViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetHotelPerformanceView = clientHelper.BuildApiCall<GetHotelPerformanceViewRequest, gagvr::HotelPerformanceView>(grpcClient.GetHotelPerformanceViewAsync, grpcClient.GetHotelPerformanceView, effectiveSettings.GetHotelPerformanceViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetHotelPerformanceView);
            Modify_GetHotelPerformanceViewApiCall(ref _callGetHotelPerformanceView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetHotelPerformanceViewApiCall(ref gaxgrpc::ApiCall<GetHotelPerformanceViewRequest, gagvr::HotelPerformanceView> call);

        partial void OnConstruction(HotelPerformanceViewService.HotelPerformanceViewServiceClient grpcClient, HotelPerformanceViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC HotelPerformanceViewService client</summary>
        public override HotelPerformanceViewService.HotelPerformanceViewServiceClient GrpcClient { get; }

        partial void Modify_GetHotelPerformanceViewRequest(ref GetHotelPerformanceViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::HotelPerformanceView GetHotelPerformanceView(GetHotelPerformanceViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHotelPerformanceViewRequest(ref request, ref callSettings);
            return _callGetHotelPerformanceView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Hotel Performance View in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::HotelPerformanceView> GetHotelPerformanceViewAsync(GetHotelPerformanceViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetHotelPerformanceViewRequest(ref request, ref callSettings);
            return _callGetHotelPerformanceView.Async(request, callSettings);
        }
    }
}

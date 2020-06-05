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
    /// <summary>Settings for <see cref="ShoppingPerformanceViewServiceClient"/> instances.</summary>
    public sealed partial class ShoppingPerformanceViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ShoppingPerformanceViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ShoppingPerformanceViewServiceSettings"/>.</returns>
        public static ShoppingPerformanceViewServiceSettings GetDefault() => new ShoppingPerformanceViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ShoppingPerformanceViewServiceSettings"/> object with default settings.
        /// </summary>
        public ShoppingPerformanceViewServiceSettings()
        {
        }

        private ShoppingPerformanceViewServiceSettings(ShoppingPerformanceViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetShoppingPerformanceViewSettings = existing.GetShoppingPerformanceViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ShoppingPerformanceViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ShoppingPerformanceViewServiceClient.GetShoppingPerformanceView</c> and
        /// <c>ShoppingPerformanceViewServiceClient.GetShoppingPerformanceViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetShoppingPerformanceViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ShoppingPerformanceViewServiceSettings"/> object.</returns>
        public ShoppingPerformanceViewServiceSettings Clone() => new ShoppingPerformanceViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ShoppingPerformanceViewServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class ShoppingPerformanceViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<ShoppingPerformanceViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ShoppingPerformanceViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ShoppingPerformanceViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ShoppingPerformanceViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ShoppingPerformanceViewServiceClient Build()
        {
            ShoppingPerformanceViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ShoppingPerformanceViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ShoppingPerformanceViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ShoppingPerformanceViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ShoppingPerformanceViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ShoppingPerformanceViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ShoppingPerformanceViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ShoppingPerformanceViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            ShoppingPerformanceViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ShoppingPerformanceViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ShoppingPerformanceViewService client wrapper, for convenient use.</summary>
    public abstract partial class ShoppingPerformanceViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the ShoppingPerformanceViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ShoppingPerformanceViewService scopes.</summary>
        /// <remarks>The default ShoppingPerformanceViewService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ShoppingPerformanceViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ShoppingPerformanceViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ShoppingPerformanceViewServiceClient"/>.</returns>
        public static stt::Task<ShoppingPerformanceViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ShoppingPerformanceViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ShoppingPerformanceViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ShoppingPerformanceViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ShoppingPerformanceViewServiceClient"/>.</returns>
        public static ShoppingPerformanceViewServiceClient Create() =>
            new ShoppingPerformanceViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ShoppingPerformanceViewServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ShoppingPerformanceViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="ShoppingPerformanceViewServiceClient"/>.</returns>
        internal static ShoppingPerformanceViewServiceClient Create(grpccore::CallInvoker callInvoker, ShoppingPerformanceViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient grpcClient = new ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient(callInvoker);
            return new ShoppingPerformanceViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ShoppingPerformanceViewService client</summary>
        public virtual ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ShoppingPerformanceView GetShoppingPerformanceView(GetShoppingPerformanceViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ShoppingPerformanceView> GetShoppingPerformanceViewAsync(GetShoppingPerformanceViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ShoppingPerformanceView> GetShoppingPerformanceViewAsync(GetShoppingPerformanceViewRequest request, st::CancellationToken cancellationToken) =>
            GetShoppingPerformanceViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Shopping performance view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ShoppingPerformanceView GetShoppingPerformanceView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetShoppingPerformanceView(new GetShoppingPerformanceViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Shopping performance view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ShoppingPerformanceView> GetShoppingPerformanceViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetShoppingPerformanceViewAsync(new GetShoppingPerformanceViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Shopping performance view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ShoppingPerformanceView> GetShoppingPerformanceViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetShoppingPerformanceViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Shopping performance view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ShoppingPerformanceView GetShoppingPerformanceView(gagvr::ShoppingPerformanceViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetShoppingPerformanceView(new GetShoppingPerformanceViewRequest
            {
                ResourceNameAsShoppingPerformanceViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Shopping performance view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ShoppingPerformanceView> GetShoppingPerformanceViewAsync(gagvr::ShoppingPerformanceViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetShoppingPerformanceViewAsync(new GetShoppingPerformanceViewRequest
            {
                ResourceNameAsShoppingPerformanceViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Shopping performance view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ShoppingPerformanceView> GetShoppingPerformanceViewAsync(gagvr::ShoppingPerformanceViewName resourceName, st::CancellationToken cancellationToken) =>
            GetShoppingPerformanceViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ShoppingPerformanceViewService client wrapper implementation, for convenient use.</summary>
    public sealed partial class ShoppingPerformanceViewServiceClientImpl : ShoppingPerformanceViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetShoppingPerformanceViewRequest, gagvr::ShoppingPerformanceView> _callGetShoppingPerformanceView;

        /// <summary>
        /// Constructs a client wrapper for the ShoppingPerformanceViewService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ShoppingPerformanceViewServiceSettings"/> used within this client.
        /// </param>
        public ShoppingPerformanceViewServiceClientImpl(ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient grpcClient, ShoppingPerformanceViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ShoppingPerformanceViewServiceSettings effectiveSettings = settings ?? ShoppingPerformanceViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetShoppingPerformanceView = clientHelper.BuildApiCall<GetShoppingPerformanceViewRequest, gagvr::ShoppingPerformanceView>(grpcClient.GetShoppingPerformanceViewAsync, grpcClient.GetShoppingPerformanceView, effectiveSettings.GetShoppingPerformanceViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetShoppingPerformanceView);
            Modify_GetShoppingPerformanceViewApiCall(ref _callGetShoppingPerformanceView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetShoppingPerformanceViewApiCall(ref gaxgrpc::ApiCall<GetShoppingPerformanceViewRequest, gagvr::ShoppingPerformanceView> call);

        partial void OnConstruction(ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient grpcClient, ShoppingPerformanceViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ShoppingPerformanceViewService client</summary>
        public override ShoppingPerformanceViewService.ShoppingPerformanceViewServiceClient GrpcClient { get; }

        partial void Modify_GetShoppingPerformanceViewRequest(ref GetShoppingPerformanceViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::ShoppingPerformanceView GetShoppingPerformanceView(GetShoppingPerformanceViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShoppingPerformanceViewRequest(ref request, ref callSettings);
            return _callGetShoppingPerformanceView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Shopping performance view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::ShoppingPerformanceView> GetShoppingPerformanceViewAsync(GetShoppingPerformanceViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetShoppingPerformanceViewRequest(ref request, ref callSettings);
            return _callGetShoppingPerformanceView.Async(request, callSettings);
        }
    }
}

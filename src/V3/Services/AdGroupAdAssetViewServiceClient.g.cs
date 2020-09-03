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
    /// <summary>Settings for <see cref="AdGroupAdAssetViewServiceClient"/> instances.</summary>
    public sealed partial class AdGroupAdAssetViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupAdAssetViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupAdAssetViewServiceSettings"/>.</returns>
        public static AdGroupAdAssetViewServiceSettings GetDefault() => new AdGroupAdAssetViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupAdAssetViewServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupAdAssetViewServiceSettings()
        {
        }

        private AdGroupAdAssetViewServiceSettings(AdGroupAdAssetViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupAdAssetViewSettings = existing.GetAdGroupAdAssetViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupAdAssetViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAdAssetViewServiceClient.GetAdGroupAdAssetView</c> and
        /// <c>AdGroupAdAssetViewServiceClient.GetAdGroupAdAssetViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupAdAssetViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupAdAssetViewServiceSettings"/> object.</returns>
        public AdGroupAdAssetViewServiceSettings Clone() => new AdGroupAdAssetViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupAdAssetViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class AdGroupAdAssetViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupAdAssetViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupAdAssetViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupAdAssetViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupAdAssetViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupAdAssetViewServiceClient Build()
        {
            AdGroupAdAssetViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupAdAssetViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupAdAssetViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupAdAssetViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupAdAssetViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupAdAssetViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupAdAssetViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupAdAssetViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdGroupAdAssetViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupAdAssetViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupAdAssetViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch ad group ad asset views.
    /// </remarks>
    public abstract partial class AdGroupAdAssetViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupAdAssetViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupAdAssetViewService scopes.</summary>
        /// <remarks>The default AdGroupAdAssetViewService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupAdAssetViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupAdAssetViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupAdAssetViewServiceClient"/>.</returns>
        public static stt::Task<AdGroupAdAssetViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupAdAssetViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupAdAssetViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupAdAssetViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupAdAssetViewServiceClient"/>.</returns>
        public static AdGroupAdAssetViewServiceClient Create() => new AdGroupAdAssetViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupAdAssetViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupAdAssetViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupAdAssetViewServiceClient"/>.</returns>
        internal static AdGroupAdAssetViewServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupAdAssetViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient grpcClient = new AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient(callInvoker);
            return new AdGroupAdAssetViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupAdAssetViewService client</summary>
        public virtual AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAdAssetView GetAdGroupAdAssetView(GetAdGroupAdAssetViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdAssetView> GetAdGroupAdAssetViewAsync(GetAdGroupAdAssetViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdAssetView> GetAdGroupAdAssetViewAsync(GetAdGroupAdAssetViewRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupAdAssetViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad asset view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAdAssetView GetAdGroupAdAssetView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAdAssetView(new GetAdGroupAdAssetViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad asset view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdAssetView> GetAdGroupAdAssetViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAdAssetViewAsync(new GetAdGroupAdAssetViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad asset view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdAssetView> GetAdGroupAdAssetViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAdAssetViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad asset view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAdAssetView GetAdGroupAdAssetView(gagvr::AdGroupAdAssetViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAdAssetView(new GetAdGroupAdAssetViewRequest
            {
                ResourceNameAsAdGroupAdAssetViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad asset view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdAssetView> GetAdGroupAdAssetViewAsync(gagvr::AdGroupAdAssetViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAdAssetViewAsync(new GetAdGroupAdAssetViewRequest
            {
                ResourceNameAsAdGroupAdAssetViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad asset view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdAssetView> GetAdGroupAdAssetViewAsync(gagvr::AdGroupAdAssetViewName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAdAssetViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupAdAssetViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch ad group ad asset views.
    /// </remarks>
    public sealed partial class AdGroupAdAssetViewServiceClientImpl : AdGroupAdAssetViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupAdAssetViewRequest, gagvr::AdGroupAdAssetView> _callGetAdGroupAdAssetView;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupAdAssetViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdGroupAdAssetViewServiceSettings"/> used within this client.
        /// </param>
        public AdGroupAdAssetViewServiceClientImpl(AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient grpcClient, AdGroupAdAssetViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupAdAssetViewServiceSettings effectiveSettings = settings ?? AdGroupAdAssetViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupAdAssetView = clientHelper.BuildApiCall<GetAdGroupAdAssetViewRequest, gagvr::AdGroupAdAssetView>(grpcClient.GetAdGroupAdAssetViewAsync, grpcClient.GetAdGroupAdAssetView, effectiveSettings.GetAdGroupAdAssetViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupAdAssetView);
            Modify_GetAdGroupAdAssetViewApiCall(ref _callGetAdGroupAdAssetView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupAdAssetViewApiCall(ref gaxgrpc::ApiCall<GetAdGroupAdAssetViewRequest, gagvr::AdGroupAdAssetView> call);

        partial void OnConstruction(AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient grpcClient, AdGroupAdAssetViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupAdAssetViewService client</summary>
        public override AdGroupAdAssetViewService.AdGroupAdAssetViewServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupAdAssetViewRequest(ref GetAdGroupAdAssetViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroupAdAssetView GetAdGroupAdAssetView(GetAdGroupAdAssetViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAdAssetViewRequest(ref request, ref callSettings);
            return _callGetAdGroupAdAssetView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group ad asset view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroupAdAssetView> GetAdGroupAdAssetViewAsync(GetAdGroupAdAssetViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAdAssetViewRequest(ref request, ref callSettings);
            return _callGetAdGroupAdAssetView.Async(request, callSettings);
        }
    }
}

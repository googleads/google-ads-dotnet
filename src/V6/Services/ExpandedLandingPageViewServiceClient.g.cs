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
    /// <summary>Settings for <see cref="ExpandedLandingPageViewServiceClient"/> instances.</summary>
    public sealed partial class ExpandedLandingPageViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExpandedLandingPageViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExpandedLandingPageViewServiceSettings"/>.</returns>
        public static ExpandedLandingPageViewServiceSettings GetDefault() => new ExpandedLandingPageViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ExpandedLandingPageViewServiceSettings"/> object with default settings.
        /// </summary>
        public ExpandedLandingPageViewServiceSettings()
        {
        }

        private ExpandedLandingPageViewServiceSettings(ExpandedLandingPageViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetExpandedLandingPageViewSettings = existing.GetExpandedLandingPageViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExpandedLandingPageViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExpandedLandingPageViewServiceClient.GetExpandedLandingPageView</c> and
        /// <c>ExpandedLandingPageViewServiceClient.GetExpandedLandingPageViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetExpandedLandingPageViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExpandedLandingPageViewServiceSettings"/> object.</returns>
        public ExpandedLandingPageViewServiceSettings Clone() => new ExpandedLandingPageViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExpandedLandingPageViewServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class ExpandedLandingPageViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<ExpandedLandingPageViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExpandedLandingPageViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ExpandedLandingPageViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExpandedLandingPageViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExpandedLandingPageViewServiceClient Build()
        {
            ExpandedLandingPageViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExpandedLandingPageViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExpandedLandingPageViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExpandedLandingPageViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExpandedLandingPageViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ExpandedLandingPageViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExpandedLandingPageViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ExpandedLandingPageViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            ExpandedLandingPageViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExpandedLandingPageViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ExpandedLandingPageViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch expanded landing page views.
    /// </remarks>
    public abstract partial class ExpandedLandingPageViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the ExpandedLandingPageViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ExpandedLandingPageViewService scopes.</summary>
        /// <remarks>The default ExpandedLandingPageViewService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ExpandedLandingPageViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ExpandedLandingPageViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExpandedLandingPageViewServiceClient"/>.</returns>
        public static stt::Task<ExpandedLandingPageViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExpandedLandingPageViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExpandedLandingPageViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ExpandedLandingPageViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExpandedLandingPageViewServiceClient"/>.</returns>
        public static ExpandedLandingPageViewServiceClient Create() =>
            new ExpandedLandingPageViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExpandedLandingPageViewServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExpandedLandingPageViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="ExpandedLandingPageViewServiceClient"/>.</returns>
        internal static ExpandedLandingPageViewServiceClient Create(grpccore::CallInvoker callInvoker, ExpandedLandingPageViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient grpcClient = new ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient(callInvoker);
            return new ExpandedLandingPageViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ExpandedLandingPageViewService client</summary>
        public virtual ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ExpandedLandingPageView GetExpandedLandingPageView(GetExpandedLandingPageViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExpandedLandingPageView> GetExpandedLandingPageViewAsync(GetExpandedLandingPageViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExpandedLandingPageView> GetExpandedLandingPageViewAsync(GetExpandedLandingPageViewRequest request, st::CancellationToken cancellationToken) =>
            GetExpandedLandingPageViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the expanded landing page view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ExpandedLandingPageView GetExpandedLandingPageView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetExpandedLandingPageView(new GetExpandedLandingPageViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the expanded landing page view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExpandedLandingPageView> GetExpandedLandingPageViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetExpandedLandingPageViewAsync(new GetExpandedLandingPageViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the expanded landing page view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExpandedLandingPageView> GetExpandedLandingPageViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetExpandedLandingPageViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the expanded landing page view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ExpandedLandingPageView GetExpandedLandingPageView(gagvr::ExpandedLandingPageViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetExpandedLandingPageView(new GetExpandedLandingPageViewRequest
            {
                ResourceNameAsExpandedLandingPageViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the expanded landing page view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExpandedLandingPageView> GetExpandedLandingPageViewAsync(gagvr::ExpandedLandingPageViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetExpandedLandingPageViewAsync(new GetExpandedLandingPageViewRequest
            {
                ResourceNameAsExpandedLandingPageViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the expanded landing page view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ExpandedLandingPageView> GetExpandedLandingPageViewAsync(gagvr::ExpandedLandingPageViewName resourceName, st::CancellationToken cancellationToken) =>
            GetExpandedLandingPageViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ExpandedLandingPageViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch expanded landing page views.
    /// </remarks>
    public sealed partial class ExpandedLandingPageViewServiceClientImpl : ExpandedLandingPageViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetExpandedLandingPageViewRequest, gagvr::ExpandedLandingPageView> _callGetExpandedLandingPageView;

        /// <summary>
        /// Constructs a client wrapper for the ExpandedLandingPageViewService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ExpandedLandingPageViewServiceSettings"/> used within this client.
        /// </param>
        public ExpandedLandingPageViewServiceClientImpl(ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient grpcClient, ExpandedLandingPageViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ExpandedLandingPageViewServiceSettings effectiveSettings = settings ?? ExpandedLandingPageViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetExpandedLandingPageView = clientHelper.BuildApiCall<GetExpandedLandingPageViewRequest, gagvr::ExpandedLandingPageView>(grpcClient.GetExpandedLandingPageViewAsync, grpcClient.GetExpandedLandingPageView, effectiveSettings.GetExpandedLandingPageViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetExpandedLandingPageView);
            Modify_GetExpandedLandingPageViewApiCall(ref _callGetExpandedLandingPageView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetExpandedLandingPageViewApiCall(ref gaxgrpc::ApiCall<GetExpandedLandingPageViewRequest, gagvr::ExpandedLandingPageView> call);

        partial void OnConstruction(ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient grpcClient, ExpandedLandingPageViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ExpandedLandingPageViewService client</summary>
        public override ExpandedLandingPageViewService.ExpandedLandingPageViewServiceClient GrpcClient { get; }

        partial void Modify_GetExpandedLandingPageViewRequest(ref GetExpandedLandingPageViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::ExpandedLandingPageView GetExpandedLandingPageView(GetExpandedLandingPageViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExpandedLandingPageViewRequest(ref request, ref callSettings);
            return _callGetExpandedLandingPageView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested expanded landing page view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::ExpandedLandingPageView> GetExpandedLandingPageViewAsync(GetExpandedLandingPageViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetExpandedLandingPageViewRequest(ref request, ref callSettings);
            return _callGetExpandedLandingPageView.Async(request, callSettings);
        }
    }
}

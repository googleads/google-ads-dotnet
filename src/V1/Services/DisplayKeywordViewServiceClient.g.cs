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

using gagvr = Google.Ads.GoogleAds.V1.Resources;
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

namespace Google.Ads.GoogleAds.V1.Services
{
    /// <summary>Settings for <see cref="DisplayKeywordViewServiceClient"/> instances.</summary>
    public sealed partial class DisplayKeywordViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DisplayKeywordViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DisplayKeywordViewServiceSettings"/>.</returns>
        public static DisplayKeywordViewServiceSettings GetDefault() => new DisplayKeywordViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DisplayKeywordViewServiceSettings"/> object with default settings.
        /// </summary>
        public DisplayKeywordViewServiceSettings()
        {
        }

        private DisplayKeywordViewServiceSettings(DisplayKeywordViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDisplayKeywordViewSettings = existing.GetDisplayKeywordViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(DisplayKeywordViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DisplayKeywordViewServiceClient.GetDisplayKeywordView</c> and
        /// <c>DisplayKeywordViewServiceClient.GetDisplayKeywordViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDisplayKeywordViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DisplayKeywordViewServiceSettings"/> object.</returns>
        public DisplayKeywordViewServiceSettings Clone() => new DisplayKeywordViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DisplayKeywordViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DisplayKeywordViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<DisplayKeywordViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DisplayKeywordViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref DisplayKeywordViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DisplayKeywordViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DisplayKeywordViewServiceClient Build()
        {
            DisplayKeywordViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DisplayKeywordViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DisplayKeywordViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DisplayKeywordViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DisplayKeywordViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DisplayKeywordViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DisplayKeywordViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DisplayKeywordViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DisplayKeywordViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DisplayKeywordViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DisplayKeywordViewService client wrapper, for convenient use.</summary>
    public abstract partial class DisplayKeywordViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the DisplayKeywordViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default DisplayKeywordViewService scopes.</summary>
        /// <remarks>The default DisplayKeywordViewService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="DisplayKeywordViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DisplayKeywordViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DisplayKeywordViewServiceClient"/>.</returns>
        public static stt::Task<DisplayKeywordViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DisplayKeywordViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DisplayKeywordViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="DisplayKeywordViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DisplayKeywordViewServiceClient"/>.</returns>
        public static DisplayKeywordViewServiceClient Create() => new DisplayKeywordViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DisplayKeywordViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DisplayKeywordViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="DisplayKeywordViewServiceClient"/>.</returns>
        internal static DisplayKeywordViewServiceClient Create(grpccore::CallInvoker callInvoker, DisplayKeywordViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DisplayKeywordViewService.DisplayKeywordViewServiceClient grpcClient = new DisplayKeywordViewService.DisplayKeywordViewServiceClient(callInvoker);
            return new DisplayKeywordViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DisplayKeywordViewService client</summary>
        public virtual DisplayKeywordViewService.DisplayKeywordViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DisplayKeywordView GetDisplayKeywordView(GetDisplayKeywordViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DisplayKeywordView> GetDisplayKeywordViewAsync(GetDisplayKeywordViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DisplayKeywordView> GetDisplayKeywordViewAsync(GetDisplayKeywordViewRequest request, st::CancellationToken cancellationToken) =>
            GetDisplayKeywordViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the display keyword view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DisplayKeywordView GetDisplayKeywordView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayKeywordView(new GetDisplayKeywordViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the display keyword view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DisplayKeywordView> GetDisplayKeywordViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayKeywordViewAsync(new GetDisplayKeywordViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the display keyword view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DisplayKeywordView> GetDisplayKeywordViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetDisplayKeywordViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the display keyword view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DisplayKeywordView GetDisplayKeywordView(gagvr::DisplayKeywordViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayKeywordView(new GetDisplayKeywordViewRequest
            {
                ResourceNameAsDisplayKeywordViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the display keyword view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DisplayKeywordView> GetDisplayKeywordViewAsync(gagvr::DisplayKeywordViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDisplayKeywordViewAsync(new GetDisplayKeywordViewRequest
            {
                ResourceNameAsDisplayKeywordViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the display keyword view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DisplayKeywordView> GetDisplayKeywordViewAsync(gagvr::DisplayKeywordViewName resourceName, st::CancellationToken cancellationToken) =>
            GetDisplayKeywordViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DisplayKeywordViewService client wrapper implementation, for convenient use.</summary>
    public sealed partial class DisplayKeywordViewServiceClientImpl : DisplayKeywordViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDisplayKeywordViewRequest, gagvr::DisplayKeywordView> _callGetDisplayKeywordView;

        /// <summary>
        /// Constructs a client wrapper for the DisplayKeywordViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="DisplayKeywordViewServiceSettings"/> used within this client.
        /// </param>
        public DisplayKeywordViewServiceClientImpl(DisplayKeywordViewService.DisplayKeywordViewServiceClient grpcClient, DisplayKeywordViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DisplayKeywordViewServiceSettings effectiveSettings = settings ?? DisplayKeywordViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetDisplayKeywordView = clientHelper.BuildApiCall<GetDisplayKeywordViewRequest, gagvr::DisplayKeywordView>(grpcClient.GetDisplayKeywordViewAsync, grpcClient.GetDisplayKeywordView, effectiveSettings.GetDisplayKeywordViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetDisplayKeywordView);
            Modify_GetDisplayKeywordViewApiCall(ref _callGetDisplayKeywordView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDisplayKeywordViewApiCall(ref gaxgrpc::ApiCall<GetDisplayKeywordViewRequest, gagvr::DisplayKeywordView> call);

        partial void OnConstruction(DisplayKeywordViewService.DisplayKeywordViewServiceClient grpcClient, DisplayKeywordViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DisplayKeywordViewService client</summary>
        public override DisplayKeywordViewService.DisplayKeywordViewServiceClient GrpcClient { get; }

        partial void Modify_GetDisplayKeywordViewRequest(ref GetDisplayKeywordViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::DisplayKeywordView GetDisplayKeywordView(GetDisplayKeywordViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDisplayKeywordViewRequest(ref request, ref callSettings);
            return _callGetDisplayKeywordView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested display keyword view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::DisplayKeywordView> GetDisplayKeywordViewAsync(GetDisplayKeywordViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDisplayKeywordViewRequest(ref request, ref callSettings);
            return _callGetDisplayKeywordView.Async(request, callSettings);
        }
    }
}

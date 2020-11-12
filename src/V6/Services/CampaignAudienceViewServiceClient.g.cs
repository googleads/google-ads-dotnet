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
    /// <summary>Settings for <see cref="CampaignAudienceViewServiceClient"/> instances.</summary>
    public sealed partial class CampaignAudienceViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignAudienceViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignAudienceViewServiceSettings"/>.</returns>
        public static CampaignAudienceViewServiceSettings GetDefault() => new CampaignAudienceViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignAudienceViewServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignAudienceViewServiceSettings()
        {
        }

        private CampaignAudienceViewServiceSettings(CampaignAudienceViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignAudienceViewSettings = existing.GetCampaignAudienceViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignAudienceViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignAudienceViewServiceClient.GetCampaignAudienceView</c> and
        /// <c>CampaignAudienceViewServiceClient.GetCampaignAudienceViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCampaignAudienceViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignAudienceViewServiceSettings"/> object.</returns>
        public CampaignAudienceViewServiceSettings Clone() => new CampaignAudienceViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignAudienceViewServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class CampaignAudienceViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignAudienceViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignAudienceViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CampaignAudienceViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignAudienceViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignAudienceViewServiceClient Build()
        {
            CampaignAudienceViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignAudienceViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignAudienceViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignAudienceViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignAudienceViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CampaignAudienceViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignAudienceViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CampaignAudienceViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CampaignAudienceViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignAudienceViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CampaignAudienceViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign audience views.
    /// </remarks>
    public abstract partial class CampaignAudienceViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignAudienceViewService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignAudienceViewService scopes.</summary>
        /// <remarks>The default CampaignAudienceViewService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignAudienceViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignAudienceViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignAudienceViewServiceClient"/>.</returns>
        public static stt::Task<CampaignAudienceViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignAudienceViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignAudienceViewServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignAudienceViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignAudienceViewServiceClient"/>.</returns>
        public static CampaignAudienceViewServiceClient Create() => new CampaignAudienceViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignAudienceViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignAudienceViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignAudienceViewServiceClient"/>.</returns>
        internal static CampaignAudienceViewServiceClient Create(grpccore::CallInvoker callInvoker, CampaignAudienceViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignAudienceViewService.CampaignAudienceViewServiceClient grpcClient = new CampaignAudienceViewService.CampaignAudienceViewServiceClient(callInvoker);
            return new CampaignAudienceViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CampaignAudienceViewService client</summary>
        public virtual CampaignAudienceViewService.CampaignAudienceViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignAudienceView GetCampaignAudienceView(GetCampaignAudienceViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAudienceView> GetCampaignAudienceViewAsync(GetCampaignAudienceViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAudienceView> GetCampaignAudienceViewAsync(GetCampaignAudienceViewRequest request, st::CancellationToken cancellationToken) =>
            GetCampaignAudienceViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign audience view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignAudienceView GetCampaignAudienceView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignAudienceView(new GetCampaignAudienceViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign audience view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAudienceView> GetCampaignAudienceViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignAudienceViewAsync(new GetCampaignAudienceViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign audience view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAudienceView> GetCampaignAudienceViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignAudienceViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign audience view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignAudienceView GetCampaignAudienceView(gagvr::CampaignAudienceViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignAudienceView(new GetCampaignAudienceViewRequest
            {
                ResourceNameAsCampaignAudienceViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign audience view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAudienceView> GetCampaignAudienceViewAsync(gagvr::CampaignAudienceViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignAudienceViewAsync(new GetCampaignAudienceViewRequest
            {
                ResourceNameAsCampaignAudienceViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign audience view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAudienceView> GetCampaignAudienceViewAsync(gagvr::CampaignAudienceViewName resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignAudienceViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignAudienceViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign audience views.
    /// </remarks>
    public sealed partial class CampaignAudienceViewServiceClientImpl : CampaignAudienceViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignAudienceViewRequest, gagvr::CampaignAudienceView> _callGetCampaignAudienceView;

        /// <summary>
        /// Constructs a client wrapper for the CampaignAudienceViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignAudienceViewServiceSettings"/> used within this client.
        /// </param>
        public CampaignAudienceViewServiceClientImpl(CampaignAudienceViewService.CampaignAudienceViewServiceClient grpcClient, CampaignAudienceViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignAudienceViewServiceSettings effectiveSettings = settings ?? CampaignAudienceViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignAudienceView = clientHelper.BuildApiCall<GetCampaignAudienceViewRequest, gagvr::CampaignAudienceView>(grpcClient.GetCampaignAudienceViewAsync, grpcClient.GetCampaignAudienceView, effectiveSettings.GetCampaignAudienceViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCampaignAudienceView);
            Modify_GetCampaignAudienceViewApiCall(ref _callGetCampaignAudienceView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCampaignAudienceViewApiCall(ref gaxgrpc::ApiCall<GetCampaignAudienceViewRequest, gagvr::CampaignAudienceView> call);

        partial void OnConstruction(CampaignAudienceViewService.CampaignAudienceViewServiceClient grpcClient, CampaignAudienceViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignAudienceViewService client</summary>
        public override CampaignAudienceViewService.CampaignAudienceViewServiceClient GrpcClient { get; }

        partial void Modify_GetCampaignAudienceViewRequest(ref GetCampaignAudienceViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CampaignAudienceView GetCampaignAudienceView(GetCampaignAudienceViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignAudienceViewRequest(ref request, ref callSettings);
            return _callGetCampaignAudienceView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign audience view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CampaignAudienceView> GetCampaignAudienceViewAsync(GetCampaignAudienceViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignAudienceViewRequest(ref request, ref callSettings);
            return _callGetCampaignAudienceView.Async(request, callSettings);
        }
    }
}

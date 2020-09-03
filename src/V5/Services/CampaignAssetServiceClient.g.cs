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
    /// <summary>Settings for <see cref="CampaignAssetServiceClient"/> instances.</summary>
    public sealed partial class CampaignAssetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignAssetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignAssetServiceSettings"/>.</returns>
        public static CampaignAssetServiceSettings GetDefault() => new CampaignAssetServiceSettings();

        /// <summary>Constructs a new <see cref="CampaignAssetServiceSettings"/> object with default settings.</summary>
        public CampaignAssetServiceSettings()
        {
        }

        private CampaignAssetServiceSettings(CampaignAssetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignAssetSettings = existing.GetCampaignAssetSettings;
            MutateCampaignAssetsSettings = existing.MutateCampaignAssetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignAssetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignAssetServiceClient.GetCampaignAsset</c> and <c>CampaignAssetServiceClient.GetCampaignAssetAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCampaignAssetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignAssetServiceClient.MutateCampaignAssets</c> and
        /// <c>CampaignAssetServiceClient.MutateCampaignAssetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCampaignAssetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignAssetServiceSettings"/> object.</returns>
        public CampaignAssetServiceSettings Clone() => new CampaignAssetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignAssetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CampaignAssetServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignAssetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignAssetServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CampaignAssetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignAssetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignAssetServiceClient Build()
        {
            CampaignAssetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignAssetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignAssetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignAssetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignAssetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CampaignAssetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignAssetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CampaignAssetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CampaignAssetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignAssetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CampaignAssetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign assets.
    /// </remarks>
    public abstract partial class CampaignAssetServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignAssetService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignAssetService scopes.</summary>
        /// <remarks>The default CampaignAssetService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignAssetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignAssetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignAssetServiceClient"/>.</returns>
        public static stt::Task<CampaignAssetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignAssetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignAssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignAssetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignAssetServiceClient"/>.</returns>
        public static CampaignAssetServiceClient Create() => new CampaignAssetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignAssetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignAssetServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignAssetServiceClient"/>.</returns>
        internal static CampaignAssetServiceClient Create(grpccore::CallInvoker callInvoker, CampaignAssetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignAssetService.CampaignAssetServiceClient grpcClient = new CampaignAssetService.CampaignAssetServiceClient(callInvoker);
            return new CampaignAssetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CampaignAssetService client</summary>
        public virtual CampaignAssetService.CampaignAssetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignAsset GetCampaignAsset(GetCampaignAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAsset> GetCampaignAssetAsync(GetCampaignAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAsset> GetCampaignAssetAsync(GetCampaignAssetRequest request, st::CancellationToken cancellationToken) =>
            GetCampaignAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign asset to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignAsset GetCampaignAsset(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignAsset(new GetCampaignAssetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign asset to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAsset> GetCampaignAssetAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignAssetAsync(new GetCampaignAssetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign asset to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAsset> GetCampaignAssetAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignAssetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign asset to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignAsset GetCampaignAsset(gagvr::CampaignAssetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignAsset(new GetCampaignAssetRequest
            {
                ResourceNameAsCampaignAssetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign asset to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAsset> GetCampaignAssetAsync(gagvr::CampaignAssetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignAssetAsync(new GetCampaignAssetRequest
            {
                ResourceNameAsCampaignAssetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign asset to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignAsset> GetCampaignAssetAsync(gagvr::CampaignAssetName resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignAssetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes campaign assets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignAssetsResponse MutateCampaignAssets(MutateCampaignAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes campaign assets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignAssetsResponse> MutateCampaignAssetsAsync(MutateCampaignAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes campaign assets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignAssetsResponse> MutateCampaignAssetsAsync(MutateCampaignAssetsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes campaign assets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign assets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignAssetsResponse MutateCampaignAssets(string customerId, scg::IEnumerable<CampaignAssetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignAssets(new MutateCampaignAssetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes campaign assets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign assets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignAssetsResponse> MutateCampaignAssetsAsync(string customerId, scg::IEnumerable<CampaignAssetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignAssetsAsync(new MutateCampaignAssetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes campaign assets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign assets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignAssetsResponse> MutateCampaignAssetsAsync(string customerId, scg::IEnumerable<CampaignAssetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignAssetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignAssetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign assets.
    /// </remarks>
    public sealed partial class CampaignAssetServiceClientImpl : CampaignAssetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignAssetRequest, gagvr::CampaignAsset> _callGetCampaignAsset;

        private readonly gaxgrpc::ApiCall<MutateCampaignAssetsRequest, MutateCampaignAssetsResponse> _callMutateCampaignAssets;

        /// <summary>
        /// Constructs a client wrapper for the CampaignAssetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignAssetServiceSettings"/> used within this client.</param>
        public CampaignAssetServiceClientImpl(CampaignAssetService.CampaignAssetServiceClient grpcClient, CampaignAssetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignAssetServiceSettings effectiveSettings = settings ?? CampaignAssetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignAsset = clientHelper.BuildApiCall<GetCampaignAssetRequest, gagvr::CampaignAsset>(grpcClient.GetCampaignAssetAsync, grpcClient.GetCampaignAsset, effectiveSettings.GetCampaignAssetSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCampaignAsset);
            Modify_GetCampaignAssetApiCall(ref _callGetCampaignAsset);
            _callMutateCampaignAssets = clientHelper.BuildApiCall<MutateCampaignAssetsRequest, MutateCampaignAssetsResponse>(grpcClient.MutateCampaignAssetsAsync, grpcClient.MutateCampaignAssets, effectiveSettings.MutateCampaignAssetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignAssets);
            Modify_MutateCampaignAssetsApiCall(ref _callMutateCampaignAssets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCampaignAssetApiCall(ref gaxgrpc::ApiCall<GetCampaignAssetRequest, gagvr::CampaignAsset> call);

        partial void Modify_MutateCampaignAssetsApiCall(ref gaxgrpc::ApiCall<MutateCampaignAssetsRequest, MutateCampaignAssetsResponse> call);

        partial void OnConstruction(CampaignAssetService.CampaignAssetServiceClient grpcClient, CampaignAssetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignAssetService client</summary>
        public override CampaignAssetService.CampaignAssetServiceClient GrpcClient { get; }

        partial void Modify_GetCampaignAssetRequest(ref GetCampaignAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCampaignAssetsRequest(ref MutateCampaignAssetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CampaignAsset GetCampaignAsset(GetCampaignAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignAssetRequest(ref request, ref callSettings);
            return _callGetCampaignAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign asset in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CampaignAsset> GetCampaignAssetAsync(GetCampaignAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignAssetRequest(ref request, ref callSettings);
            return _callGetCampaignAsset.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or removes campaign assets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignAssetsResponse MutateCampaignAssets(MutateCampaignAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignAssetsRequest(ref request, ref callSettings);
            return _callMutateCampaignAssets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes campaign assets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignAssetsResponse> MutateCampaignAssetsAsync(MutateCampaignAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignAssetsRequest(ref request, ref callSettings);
            return _callMutateCampaignAssets.Async(request, callSettings);
        }
    }
}

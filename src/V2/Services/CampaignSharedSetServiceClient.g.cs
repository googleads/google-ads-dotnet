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
    /// <summary>Settings for <see cref="CampaignSharedSetServiceClient"/> instances.</summary>
    public sealed partial class CampaignSharedSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignSharedSetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignSharedSetServiceSettings"/>.</returns>
        public static CampaignSharedSetServiceSettings GetDefault() => new CampaignSharedSetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignSharedSetServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignSharedSetServiceSettings()
        {
        }

        private CampaignSharedSetServiceSettings(CampaignSharedSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignSharedSetSettings = existing.GetCampaignSharedSetSettings;
            MutateCampaignSharedSetsSettings = existing.MutateCampaignSharedSetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignSharedSetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignSharedSetServiceClient.GetCampaignSharedSet</c> and
        /// <c>CampaignSharedSetServiceClient.GetCampaignSharedSetAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCampaignSharedSetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignSharedSetServiceClient.MutateCampaignSharedSets</c> and
        /// <c>CampaignSharedSetServiceClient.MutateCampaignSharedSetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCampaignSharedSetsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignSharedSetServiceSettings"/> object.</returns>
        public CampaignSharedSetServiceSettings Clone() => new CampaignSharedSetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignSharedSetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CampaignSharedSetServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignSharedSetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignSharedSetServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CampaignSharedSetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignSharedSetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignSharedSetServiceClient Build()
        {
            CampaignSharedSetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignSharedSetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignSharedSetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignSharedSetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignSharedSetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CampaignSharedSetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignSharedSetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CampaignSharedSetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CampaignSharedSetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignSharedSetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CampaignSharedSetService client wrapper, for convenient use.</summary>
    public abstract partial class CampaignSharedSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignSharedSetService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignSharedSetService scopes.</summary>
        /// <remarks>The default CampaignSharedSetService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignSharedSetServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignSharedSetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignSharedSetServiceClient"/>.</returns>
        public static stt::Task<CampaignSharedSetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignSharedSetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignSharedSetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignSharedSetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignSharedSetServiceClient"/>.</returns>
        public static CampaignSharedSetServiceClient Create() => new CampaignSharedSetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignSharedSetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignSharedSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignSharedSetServiceClient"/>.</returns>
        internal static CampaignSharedSetServiceClient Create(grpccore::CallInvoker callInvoker, CampaignSharedSetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignSharedSetService.CampaignSharedSetServiceClient grpcClient = new CampaignSharedSetService.CampaignSharedSetServiceClient(callInvoker);
            return new CampaignSharedSetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CampaignSharedSetService client</summary>
        public virtual CampaignSharedSetService.CampaignSharedSetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignSharedSet GetCampaignSharedSet(GetCampaignSharedSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(GetCampaignSharedSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(GetCampaignSharedSetRequest request, st::CancellationToken cancellationToken) =>
            GetCampaignSharedSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign shared set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignSharedSet GetCampaignSharedSet(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignSharedSet(new GetCampaignSharedSetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign shared set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignSharedSetAsync(new GetCampaignSharedSetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign shared set to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignSharedSetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign shared set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignSharedSet GetCampaignSharedSet(gagvr::CampaignSharedSetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignSharedSet(new GetCampaignSharedSetRequest
            {
                ResourceNameAsCampaignSharedSetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign shared set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(gagvr::CampaignSharedSetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignSharedSetAsync(new GetCampaignSharedSetRequest
            {
                ResourceNameAsCampaignSharedSetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign shared set to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(gagvr::CampaignSharedSetName resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignSharedSetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignSharedSetsResponse MutateCampaignSharedSets(MutateCampaignSharedSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(MutateCampaignSharedSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(MutateCampaignSharedSetsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignSharedSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign shared sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignSharedSetsResponse MutateCampaignSharedSets(string customerId, scg::IEnumerable<CampaignSharedSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignSharedSets(new MutateCampaignSharedSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign shared sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(string customerId, scg::IEnumerable<CampaignSharedSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignSharedSetsAsync(new MutateCampaignSharedSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign shared sets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(string customerId, scg::IEnumerable<CampaignSharedSetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignSharedSetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignSharedSetService client wrapper implementation, for convenient use.</summary>
    public sealed partial class CampaignSharedSetServiceClientImpl : CampaignSharedSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignSharedSetRequest, gagvr::CampaignSharedSet> _callGetCampaignSharedSet;

        private readonly gaxgrpc::ApiCall<MutateCampaignSharedSetsRequest, MutateCampaignSharedSetsResponse> _callMutateCampaignSharedSets;

        /// <summary>
        /// Constructs a client wrapper for the CampaignSharedSetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignSharedSetServiceSettings"/> used within this client.
        /// </param>
        public CampaignSharedSetServiceClientImpl(CampaignSharedSetService.CampaignSharedSetServiceClient grpcClient, CampaignSharedSetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignSharedSetServiceSettings effectiveSettings = settings ?? CampaignSharedSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignSharedSet = clientHelper.BuildApiCall<GetCampaignSharedSetRequest, gagvr::CampaignSharedSet>(grpcClient.GetCampaignSharedSetAsync, grpcClient.GetCampaignSharedSet, effectiveSettings.GetCampaignSharedSetSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCampaignSharedSet);
            Modify_GetCampaignSharedSetApiCall(ref _callGetCampaignSharedSet);
            _callMutateCampaignSharedSets = clientHelper.BuildApiCall<MutateCampaignSharedSetsRequest, MutateCampaignSharedSetsResponse>(grpcClient.MutateCampaignSharedSetsAsync, grpcClient.MutateCampaignSharedSets, effectiveSettings.MutateCampaignSharedSetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignSharedSets);
            Modify_MutateCampaignSharedSetsApiCall(ref _callMutateCampaignSharedSets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCampaignSharedSetApiCall(ref gaxgrpc::ApiCall<GetCampaignSharedSetRequest, gagvr::CampaignSharedSet> call);

        partial void Modify_MutateCampaignSharedSetsApiCall(ref gaxgrpc::ApiCall<MutateCampaignSharedSetsRequest, MutateCampaignSharedSetsResponse> call);

        partial void OnConstruction(CampaignSharedSetService.CampaignSharedSetServiceClient grpcClient, CampaignSharedSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignSharedSetService client</summary>
        public override CampaignSharedSetService.CampaignSharedSetServiceClient GrpcClient { get; }

        partial void Modify_GetCampaignSharedSetRequest(ref GetCampaignSharedSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCampaignSharedSetsRequest(ref MutateCampaignSharedSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CampaignSharedSet GetCampaignSharedSet(GetCampaignSharedSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignSharedSetRequest(ref request, ref callSettings);
            return _callGetCampaignSharedSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign shared set in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CampaignSharedSet> GetCampaignSharedSetAsync(GetCampaignSharedSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignSharedSetRequest(ref request, ref callSettings);
            return _callGetCampaignSharedSet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignSharedSetsResponse MutateCampaignSharedSets(MutateCampaignSharedSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignSharedSetsRequest(ref request, ref callSettings);
            return _callMutateCampaignSharedSets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes campaign shared sets. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignSharedSetsResponse> MutateCampaignSharedSetsAsync(MutateCampaignSharedSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignSharedSetsRequest(ref request, ref callSettings);
            return _callMutateCampaignSharedSets.Async(request, callSettings);
        }
    }
}

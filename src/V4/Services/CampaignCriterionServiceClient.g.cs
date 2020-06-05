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
    /// <summary>Settings for <see cref="CampaignCriterionServiceClient"/> instances.</summary>
    public sealed partial class CampaignCriterionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignCriterionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignCriterionServiceSettings"/>.</returns>
        public static CampaignCriterionServiceSettings GetDefault() => new CampaignCriterionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignCriterionServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignCriterionServiceSettings()
        {
        }

        private CampaignCriterionServiceSettings(CampaignCriterionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignCriterionSettings = existing.GetCampaignCriterionSettings;
            MutateCampaignCriteriaSettings = existing.MutateCampaignCriteriaSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignCriterionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignCriterionServiceClient.GetCampaignCriterion</c> and
        /// <c>CampaignCriterionServiceClient.GetCampaignCriterionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCampaignCriterionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignCriterionServiceClient.MutateCampaignCriteria</c> and
        /// <c>CampaignCriterionServiceClient.MutateCampaignCriteriaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCampaignCriteriaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignCriterionServiceSettings"/> object.</returns>
        public CampaignCriterionServiceSettings Clone() => new CampaignCriterionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignCriterionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CampaignCriterionServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignCriterionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignCriterionServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CampaignCriterionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignCriterionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignCriterionServiceClient Build()
        {
            CampaignCriterionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignCriterionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignCriterionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignCriterionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignCriterionServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CampaignCriterionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignCriterionServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CampaignCriterionServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CampaignCriterionServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignCriterionServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CampaignCriterionService client wrapper, for convenient use.</summary>
    public abstract partial class CampaignCriterionServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignCriterionService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignCriterionService scopes.</summary>
        /// <remarks>The default CampaignCriterionService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignCriterionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignCriterionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignCriterionServiceClient"/>.</returns>
        public static stt::Task<CampaignCriterionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignCriterionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignCriterionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignCriterionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignCriterionServiceClient"/>.</returns>
        public static CampaignCriterionServiceClient Create() => new CampaignCriterionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignCriterionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignCriterionServiceClient"/>.</returns>
        internal static CampaignCriterionServiceClient Create(grpccore::CallInvoker callInvoker, CampaignCriterionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignCriterionService.CampaignCriterionServiceClient grpcClient = new CampaignCriterionService.CampaignCriterionServiceClient(callInvoker);
            return new CampaignCriterionServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CampaignCriterionService client</summary>
        public virtual CampaignCriterionService.CampaignCriterionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignCriterion GetCampaignCriterion(GetCampaignCriterionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(GetCampaignCriterionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(GetCampaignCriterionRequest request, st::CancellationToken cancellationToken) =>
            GetCampaignCriterionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the criterion to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignCriterion GetCampaignCriterion(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignCriterion(new GetCampaignCriterionRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the criterion to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignCriterionAsync(new GetCampaignCriterionRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the criterion to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignCriterionAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the criterion to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignCriterion GetCampaignCriterion(gagvr::CampaignCriterionName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignCriterion(new GetCampaignCriterionRequest
            {
                ResourceNameAsCampaignCriterionName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the criterion to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(gagvr::CampaignCriterionName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignCriterionAsync(new GetCampaignCriterionRequest
            {
                ResourceNameAsCampaignCriterionName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the criterion to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(gagvr::CampaignCriterionName resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignCriterionAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignCriteriaResponse MutateCampaignCriteria(MutateCampaignCriteriaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(MutateCampaignCriteriaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(MutateCampaignCriteriaRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignCriteriaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignCriteriaResponse MutateCampaignCriteria(string customerId, scg::IEnumerable<CampaignCriterionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignCriteria(new MutateCampaignCriteriaRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(string customerId, scg::IEnumerable<CampaignCriterionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignCriteriaAsync(new MutateCampaignCriteriaRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(string customerId, scg::IEnumerable<CampaignCriterionOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignCriteriaAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignCriterionService client wrapper implementation, for convenient use.</summary>
    public sealed partial class CampaignCriterionServiceClientImpl : CampaignCriterionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignCriterionRequest, gagvr::CampaignCriterion> _callGetCampaignCriterion;

        private readonly gaxgrpc::ApiCall<MutateCampaignCriteriaRequest, MutateCampaignCriteriaResponse> _callMutateCampaignCriteria;

        /// <summary>
        /// Constructs a client wrapper for the CampaignCriterionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignCriterionServiceSettings"/> used within this client.
        /// </param>
        public CampaignCriterionServiceClientImpl(CampaignCriterionService.CampaignCriterionServiceClient grpcClient, CampaignCriterionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignCriterionServiceSettings effectiveSettings = settings ?? CampaignCriterionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignCriterion = clientHelper.BuildApiCall<GetCampaignCriterionRequest, gagvr::CampaignCriterion>(grpcClient.GetCampaignCriterionAsync, grpcClient.GetCampaignCriterion, effectiveSettings.GetCampaignCriterionSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCampaignCriterion);
            Modify_GetCampaignCriterionApiCall(ref _callGetCampaignCriterion);
            _callMutateCampaignCriteria = clientHelper.BuildApiCall<MutateCampaignCriteriaRequest, MutateCampaignCriteriaResponse>(grpcClient.MutateCampaignCriteriaAsync, grpcClient.MutateCampaignCriteria, effectiveSettings.MutateCampaignCriteriaSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignCriteria);
            Modify_MutateCampaignCriteriaApiCall(ref _callMutateCampaignCriteria);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCampaignCriterionApiCall(ref gaxgrpc::ApiCall<GetCampaignCriterionRequest, gagvr::CampaignCriterion> call);

        partial void Modify_MutateCampaignCriteriaApiCall(ref gaxgrpc::ApiCall<MutateCampaignCriteriaRequest, MutateCampaignCriteriaResponse> call);

        partial void OnConstruction(CampaignCriterionService.CampaignCriterionServiceClient grpcClient, CampaignCriterionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignCriterionService client</summary>
        public override CampaignCriterionService.CampaignCriterionServiceClient GrpcClient { get; }

        partial void Modify_GetCampaignCriterionRequest(ref GetCampaignCriterionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCampaignCriteriaRequest(ref MutateCampaignCriteriaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CampaignCriterion GetCampaignCriterion(GetCampaignCriterionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignCriterionRequest(ref request, ref callSettings);
            return _callGetCampaignCriterion.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(GetCampaignCriterionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignCriterionRequest(ref request, ref callSettings);
            return _callGetCampaignCriterion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignCriteriaResponse MutateCampaignCriteria(MutateCampaignCriteriaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignCriteriaRequest(ref request, ref callSettings);
            return _callMutateCampaignCriteria.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(MutateCampaignCriteriaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignCriteriaRequest(ref request, ref callSettings);
            return _callMutateCampaignCriteria.Async(request, callSettings);
        }
    }
}

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
    /// <summary>Settings for <see cref="CampaignBidModifierServiceClient"/> instances.</summary>
    public sealed partial class CampaignBidModifierServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignBidModifierServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignBidModifierServiceSettings"/>.</returns>
        public static CampaignBidModifierServiceSettings GetDefault() => new CampaignBidModifierServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignBidModifierServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignBidModifierServiceSettings()
        {
        }

        private CampaignBidModifierServiceSettings(CampaignBidModifierServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignBidModifierSettings = existing.GetCampaignBidModifierSettings;
            MutateCampaignBidModifiersSettings = existing.MutateCampaignBidModifiersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignBidModifierServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignBidModifierServiceClient.GetCampaignBidModifier</c> and
        /// <c>CampaignBidModifierServiceClient.GetCampaignBidModifierAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCampaignBidModifierSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignBidModifierServiceClient.MutateCampaignBidModifiers</c> and
        /// <c>CampaignBidModifierServiceClient.MutateCampaignBidModifiersAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCampaignBidModifiersSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignBidModifierServiceSettings"/> object.</returns>
        public CampaignBidModifierServiceSettings Clone() => new CampaignBidModifierServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignBidModifierServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CampaignBidModifierServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignBidModifierServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignBidModifierServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CampaignBidModifierServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignBidModifierServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignBidModifierServiceClient Build()
        {
            CampaignBidModifierServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignBidModifierServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignBidModifierServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignBidModifierServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignBidModifierServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CampaignBidModifierServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignBidModifierServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CampaignBidModifierServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CampaignBidModifierServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignBidModifierServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CampaignBidModifierService client wrapper, for convenient use.</summary>
    public abstract partial class CampaignBidModifierServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignBidModifierService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignBidModifierService scopes.</summary>
        /// <remarks>The default CampaignBidModifierService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignBidModifierServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignBidModifierServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignBidModifierServiceClient"/>.</returns>
        public static stt::Task<CampaignBidModifierServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignBidModifierServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignBidModifierServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignBidModifierServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignBidModifierServiceClient"/>.</returns>
        public static CampaignBidModifierServiceClient Create() => new CampaignBidModifierServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignBidModifierServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignBidModifierServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignBidModifierServiceClient"/>.</returns>
        internal static CampaignBidModifierServiceClient Create(grpccore::CallInvoker callInvoker, CampaignBidModifierServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignBidModifierService.CampaignBidModifierServiceClient grpcClient = new CampaignBidModifierService.CampaignBidModifierServiceClient(callInvoker);
            return new CampaignBidModifierServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CampaignBidModifierService client</summary>
        public virtual CampaignBidModifierService.CampaignBidModifierServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignBidModifier GetCampaignBidModifier(GetCampaignBidModifierRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignBidModifier> GetCampaignBidModifierAsync(GetCampaignBidModifierRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignBidModifier> GetCampaignBidModifierAsync(GetCampaignBidModifierRequest request, st::CancellationToken cancellationToken) =>
            GetCampaignBidModifierAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign bid modifier to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignBidModifier GetCampaignBidModifier(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignBidModifier(new GetCampaignBidModifierRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign bid modifier to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignBidModifier> GetCampaignBidModifierAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignBidModifierAsync(new GetCampaignBidModifierRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign bid modifier to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignBidModifier> GetCampaignBidModifierAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignBidModifierAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign bid modifier to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignBidModifier GetCampaignBidModifier(gagvr::CampaignBidModifierName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignBidModifier(new GetCampaignBidModifierRequest
            {
                ResourceNameAsCampaignBidModifierName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign bid modifier to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignBidModifier> GetCampaignBidModifierAsync(gagvr::CampaignBidModifierName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignBidModifierAsync(new GetCampaignBidModifierRequest
            {
                ResourceNameAsCampaignBidModifierName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign bid modifier to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignBidModifier> GetCampaignBidModifierAsync(gagvr::CampaignBidModifierName resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignBidModifierAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign bid modifiers.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignBidModifiersResponse MutateCampaignBidModifiers(MutateCampaignBidModifiersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign bid modifiers.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignBidModifiersResponse> MutateCampaignBidModifiersAsync(MutateCampaignBidModifiersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign bid modifiers.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignBidModifiersResponse> MutateCampaignBidModifiersAsync(MutateCampaignBidModifiersRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignBidModifiersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign bid modifiers.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose campaign bid modifiers are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign bid modifiers.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignBidModifiersResponse MutateCampaignBidModifiers(string customerId, scg::IEnumerable<CampaignBidModifierOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignBidModifiers(new MutateCampaignBidModifiersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign bid modifiers.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose campaign bid modifiers are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign bid modifiers.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignBidModifiersResponse> MutateCampaignBidModifiersAsync(string customerId, scg::IEnumerable<CampaignBidModifierOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignBidModifiersAsync(new MutateCampaignBidModifiersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign bid modifiers.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose campaign bid modifiers are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign bid modifiers.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignBidModifiersResponse> MutateCampaignBidModifiersAsync(string customerId, scg::IEnumerable<CampaignBidModifierOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignBidModifiersAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignBidModifierService client wrapper implementation, for convenient use.</summary>
    public sealed partial class CampaignBidModifierServiceClientImpl : CampaignBidModifierServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignBidModifierRequest, gagvr::CampaignBidModifier> _callGetCampaignBidModifier;

        private readonly gaxgrpc::ApiCall<MutateCampaignBidModifiersRequest, MutateCampaignBidModifiersResponse> _callMutateCampaignBidModifiers;

        /// <summary>
        /// Constructs a client wrapper for the CampaignBidModifierService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignBidModifierServiceSettings"/> used within this client.
        /// </param>
        public CampaignBidModifierServiceClientImpl(CampaignBidModifierService.CampaignBidModifierServiceClient grpcClient, CampaignBidModifierServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignBidModifierServiceSettings effectiveSettings = settings ?? CampaignBidModifierServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignBidModifier = clientHelper.BuildApiCall<GetCampaignBidModifierRequest, gagvr::CampaignBidModifier>(grpcClient.GetCampaignBidModifierAsync, grpcClient.GetCampaignBidModifier, effectiveSettings.GetCampaignBidModifierSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCampaignBidModifier);
            Modify_GetCampaignBidModifierApiCall(ref _callGetCampaignBidModifier);
            _callMutateCampaignBidModifiers = clientHelper.BuildApiCall<MutateCampaignBidModifiersRequest, MutateCampaignBidModifiersResponse>(grpcClient.MutateCampaignBidModifiersAsync, grpcClient.MutateCampaignBidModifiers, effectiveSettings.MutateCampaignBidModifiersSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignBidModifiers);
            Modify_MutateCampaignBidModifiersApiCall(ref _callMutateCampaignBidModifiers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCampaignBidModifierApiCall(ref gaxgrpc::ApiCall<GetCampaignBidModifierRequest, gagvr::CampaignBidModifier> call);

        partial void Modify_MutateCampaignBidModifiersApiCall(ref gaxgrpc::ApiCall<MutateCampaignBidModifiersRequest, MutateCampaignBidModifiersResponse> call);

        partial void OnConstruction(CampaignBidModifierService.CampaignBidModifierServiceClient grpcClient, CampaignBidModifierServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignBidModifierService client</summary>
        public override CampaignBidModifierService.CampaignBidModifierServiceClient GrpcClient { get; }

        partial void Modify_GetCampaignBidModifierRequest(ref GetCampaignBidModifierRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCampaignBidModifiersRequest(ref MutateCampaignBidModifiersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CampaignBidModifier GetCampaignBidModifier(GetCampaignBidModifierRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignBidModifierRequest(ref request, ref callSettings);
            return _callGetCampaignBidModifier.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign bid modifier in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CampaignBidModifier> GetCampaignBidModifierAsync(GetCampaignBidModifierRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignBidModifierRequest(ref request, ref callSettings);
            return _callGetCampaignBidModifier.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign bid modifiers.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignBidModifiersResponse MutateCampaignBidModifiers(MutateCampaignBidModifiersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignBidModifiersRequest(ref request, ref callSettings);
            return _callMutateCampaignBidModifiers.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign bid modifiers.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignBidModifiersResponse> MutateCampaignBidModifiersAsync(MutateCampaignBidModifiersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignBidModifiersRequest(ref request, ref callSettings);
            return _callMutateCampaignBidModifiers.Async(request, callSettings);
        }
    }
}

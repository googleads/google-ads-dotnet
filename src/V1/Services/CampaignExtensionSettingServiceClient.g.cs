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
    /// <summary>Settings for <see cref="CampaignExtensionSettingServiceClient"/> instances.</summary>
    public sealed partial class CampaignExtensionSettingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignExtensionSettingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignExtensionSettingServiceSettings"/>.</returns>
        public static CampaignExtensionSettingServiceSettings GetDefault() => new CampaignExtensionSettingServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignExtensionSettingServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignExtensionSettingServiceSettings()
        {
        }

        private CampaignExtensionSettingServiceSettings(CampaignExtensionSettingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignExtensionSettingSettings = existing.GetCampaignExtensionSettingSettings;
            MutateCampaignExtensionSettingsSettings = existing.MutateCampaignExtensionSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignExtensionSettingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExtensionSettingServiceClient.GetCampaignExtensionSetting</c> and
        /// <c>CampaignExtensionSettingServiceClient.GetCampaignExtensionSettingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCampaignExtensionSettingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExtensionSettingServiceClient.MutateCampaignExtensionSettings</c> and
        /// <c>CampaignExtensionSettingServiceClient.MutateCampaignExtensionSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCampaignExtensionSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignExtensionSettingServiceSettings"/> object.</returns>
        public CampaignExtensionSettingServiceSettings Clone() => new CampaignExtensionSettingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignExtensionSettingServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class CampaignExtensionSettingServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignExtensionSettingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignExtensionSettingServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CampaignExtensionSettingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignExtensionSettingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignExtensionSettingServiceClient Build()
        {
            CampaignExtensionSettingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignExtensionSettingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignExtensionSettingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignExtensionSettingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignExtensionSettingServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CampaignExtensionSettingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignExtensionSettingServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CampaignExtensionSettingServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            CampaignExtensionSettingServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignExtensionSettingServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CampaignExtensionSettingService client wrapper, for convenient use.</summary>
    public abstract partial class CampaignExtensionSettingServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignExtensionSettingService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignExtensionSettingService scopes.</summary>
        /// <remarks>The default CampaignExtensionSettingService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignExtensionSettingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignExtensionSettingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignExtensionSettingServiceClient"/>.</returns>
        public static stt::Task<CampaignExtensionSettingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignExtensionSettingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignExtensionSettingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignExtensionSettingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignExtensionSettingServiceClient"/>.</returns>
        public static CampaignExtensionSettingServiceClient Create() =>
            new CampaignExtensionSettingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignExtensionSettingServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignExtensionSettingServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignExtensionSettingServiceClient"/>.</returns>
        internal static CampaignExtensionSettingServiceClient Create(grpccore::CallInvoker callInvoker, CampaignExtensionSettingServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignExtensionSettingService.CampaignExtensionSettingServiceClient grpcClient = new CampaignExtensionSettingService.CampaignExtensionSettingServiceClient(callInvoker);
            return new CampaignExtensionSettingServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CampaignExtensionSettingService client</summary>
        public virtual CampaignExtensionSettingService.CampaignExtensionSettingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignExtensionSetting GetCampaignExtensionSetting(GetCampaignExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExtensionSetting> GetCampaignExtensionSettingAsync(GetCampaignExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExtensionSetting> GetCampaignExtensionSettingAsync(GetCampaignExtensionSettingRequest request, st::CancellationToken cancellationToken) =>
            GetCampaignExtensionSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignExtensionSetting GetCampaignExtensionSetting(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignExtensionSetting(new GetCampaignExtensionSettingRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExtensionSetting> GetCampaignExtensionSettingAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignExtensionSettingAsync(new GetCampaignExtensionSettingRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign extension setting to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExtensionSetting> GetCampaignExtensionSettingAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignExtensionSettingAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignExtensionSetting GetCampaignExtensionSetting(gagvr::CampaignExtensionSettingName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignExtensionSetting(new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExtensionSetting> GetCampaignExtensionSettingAsync(gagvr::CampaignExtensionSettingName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignExtensionSettingAsync(new GetCampaignExtensionSettingRequest
            {
                ResourceNameAsCampaignExtensionSettingName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the campaign extension setting to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExtensionSetting> GetCampaignExtensionSettingAsync(gagvr::CampaignExtensionSettingName resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignExtensionSettingAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignExtensionSettingsResponse MutateCampaignExtensionSettings(MutateCampaignExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignExtensionSettingsResponse> MutateCampaignExtensionSettingsAsync(MutateCampaignExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignExtensionSettingsResponse> MutateCampaignExtensionSettingsAsync(MutateCampaignExtensionSettingsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignExtensionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign extension settings are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign extension
        /// settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignExtensionSettingsResponse MutateCampaignExtensionSettings(string customerId, scg::IEnumerable<CampaignExtensionSettingOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignExtensionSettings(new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign extension settings are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign extension
        /// settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignExtensionSettingsResponse> MutateCampaignExtensionSettingsAsync(string customerId, scg::IEnumerable<CampaignExtensionSettingOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignExtensionSettingsAsync(new MutateCampaignExtensionSettingsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign extension settings are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign extension
        /// settings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignExtensionSettingsResponse> MutateCampaignExtensionSettingsAsync(string customerId, scg::IEnumerable<CampaignExtensionSettingOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignExtensionSettingsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignExtensionSettingService client wrapper implementation, for convenient use.</summary>
    public sealed partial class CampaignExtensionSettingServiceClientImpl : CampaignExtensionSettingServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignExtensionSettingRequest, gagvr::CampaignExtensionSetting> _callGetCampaignExtensionSetting;

        private readonly gaxgrpc::ApiCall<MutateCampaignExtensionSettingsRequest, MutateCampaignExtensionSettingsResponse> _callMutateCampaignExtensionSettings;

        /// <summary>
        /// Constructs a client wrapper for the CampaignExtensionSettingService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignExtensionSettingServiceSettings"/> used within this client.
        /// </param>
        public CampaignExtensionSettingServiceClientImpl(CampaignExtensionSettingService.CampaignExtensionSettingServiceClient grpcClient, CampaignExtensionSettingServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignExtensionSettingServiceSettings effectiveSettings = settings ?? CampaignExtensionSettingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignExtensionSetting = clientHelper.BuildApiCall<GetCampaignExtensionSettingRequest, gagvr::CampaignExtensionSetting>(grpcClient.GetCampaignExtensionSettingAsync, grpcClient.GetCampaignExtensionSetting, effectiveSettings.GetCampaignExtensionSettingSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCampaignExtensionSetting);
            Modify_GetCampaignExtensionSettingApiCall(ref _callGetCampaignExtensionSetting);
            _callMutateCampaignExtensionSettings = clientHelper.BuildApiCall<MutateCampaignExtensionSettingsRequest, MutateCampaignExtensionSettingsResponse>(grpcClient.MutateCampaignExtensionSettingsAsync, grpcClient.MutateCampaignExtensionSettings, effectiveSettings.MutateCampaignExtensionSettingsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignExtensionSettings);
            Modify_MutateCampaignExtensionSettingsApiCall(ref _callMutateCampaignExtensionSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCampaignExtensionSettingApiCall(ref gaxgrpc::ApiCall<GetCampaignExtensionSettingRequest, gagvr::CampaignExtensionSetting> call);

        partial void Modify_MutateCampaignExtensionSettingsApiCall(ref gaxgrpc::ApiCall<MutateCampaignExtensionSettingsRequest, MutateCampaignExtensionSettingsResponse> call);

        partial void OnConstruction(CampaignExtensionSettingService.CampaignExtensionSettingServiceClient grpcClient, CampaignExtensionSettingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignExtensionSettingService client</summary>
        public override CampaignExtensionSettingService.CampaignExtensionSettingServiceClient GrpcClient { get; }

        partial void Modify_GetCampaignExtensionSettingRequest(ref GetCampaignExtensionSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCampaignExtensionSettingsRequest(ref MutateCampaignExtensionSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CampaignExtensionSetting GetCampaignExtensionSetting(GetCampaignExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignExtensionSettingRequest(ref request, ref callSettings);
            return _callGetCampaignExtensionSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CampaignExtensionSetting> GetCampaignExtensionSettingAsync(GetCampaignExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignExtensionSettingRequest(ref request, ref callSettings);
            return _callGetCampaignExtensionSetting.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignExtensionSettingsResponse MutateCampaignExtensionSettings(MutateCampaignExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignExtensionSettingsRequest(ref request, ref callSettings);
            return _callMutateCampaignExtensionSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignExtensionSettingsResponse> MutateCampaignExtensionSettingsAsync(MutateCampaignExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignExtensionSettingsRequest(ref request, ref callSettings);
            return _callMutateCampaignExtensionSettings.Async(request, callSettings);
        }
    }
}

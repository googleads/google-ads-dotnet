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
    /// <summary>Settings for <see cref="AdGroupExtensionSettingServiceClient"/> instances.</summary>
    public sealed partial class AdGroupExtensionSettingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupExtensionSettingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupExtensionSettingServiceSettings"/>.</returns>
        public static AdGroupExtensionSettingServiceSettings GetDefault() => new AdGroupExtensionSettingServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupExtensionSettingServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupExtensionSettingServiceSettings()
        {
        }

        private AdGroupExtensionSettingServiceSettings(AdGroupExtensionSettingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupExtensionSettingSettings = existing.GetAdGroupExtensionSettingSettings;
            MutateAdGroupExtensionSettingsSettings = existing.MutateAdGroupExtensionSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupExtensionSettingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupExtensionSettingServiceClient.GetAdGroupExtensionSetting</c> and
        /// <c>AdGroupExtensionSettingServiceClient.GetAdGroupExtensionSettingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupExtensionSettingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupExtensionSettingServiceClient.MutateAdGroupExtensionSettings</c> and
        /// <c>AdGroupExtensionSettingServiceClient.MutateAdGroupExtensionSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAdGroupExtensionSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupExtensionSettingServiceSettings"/> object.</returns>
        public AdGroupExtensionSettingServiceSettings Clone() => new AdGroupExtensionSettingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupExtensionSettingServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class AdGroupExtensionSettingServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupExtensionSettingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupExtensionSettingServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupExtensionSettingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupExtensionSettingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupExtensionSettingServiceClient Build()
        {
            AdGroupExtensionSettingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupExtensionSettingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupExtensionSettingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupExtensionSettingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupExtensionSettingServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupExtensionSettingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupExtensionSettingServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupExtensionSettingServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            AdGroupExtensionSettingServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupExtensionSettingServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupExtensionSettingService client wrapper, for convenient use.</summary>
    public abstract partial class AdGroupExtensionSettingServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupExtensionSettingService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupExtensionSettingService scopes.</summary>
        /// <remarks>The default AdGroupExtensionSettingService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupExtensionSettingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupExtensionSettingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupExtensionSettingServiceClient"/>.</returns>
        public static stt::Task<AdGroupExtensionSettingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupExtensionSettingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupExtensionSettingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupExtensionSettingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupExtensionSettingServiceClient"/>.</returns>
        public static AdGroupExtensionSettingServiceClient Create() =>
            new AdGroupExtensionSettingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupExtensionSettingServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupExtensionSettingServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupExtensionSettingServiceClient"/>.</returns>
        internal static AdGroupExtensionSettingServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupExtensionSettingServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient grpcClient = new AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient(callInvoker);
            return new AdGroupExtensionSettingServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupExtensionSettingService client</summary>
        public virtual AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupExtensionSetting GetAdGroupExtensionSetting(GetAdGroupExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupExtensionSetting> GetAdGroupExtensionSettingAsync(GetAdGroupExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupExtensionSetting> GetAdGroupExtensionSettingAsync(GetAdGroupExtensionSettingRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupExtensionSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupExtensionSetting GetAdGroupExtensionSetting(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupExtensionSetting(new GetAdGroupExtensionSettingRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupExtensionSetting> GetAdGroupExtensionSettingAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupExtensionSettingAsync(new GetAdGroupExtensionSettingRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group extension setting to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupExtensionSetting> GetAdGroupExtensionSettingAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupExtensionSettingAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupExtensionSetting GetAdGroupExtensionSetting(gagvr::AdGroupExtensionSettingName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupExtensionSetting(new GetAdGroupExtensionSettingRequest
            {
                ResourceNameAsAdGroupExtensionSettingName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupExtensionSetting> GetAdGroupExtensionSettingAsync(gagvr::AdGroupExtensionSettingName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupExtensionSettingAsync(new GetAdGroupExtensionSettingRequest
            {
                ResourceNameAsAdGroupExtensionSettingName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group extension setting to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupExtensionSetting> GetAdGroupExtensionSettingAsync(gagvr::AdGroupExtensionSettingName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupExtensionSettingAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ad group extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupExtensionSettingsResponse MutateAdGroupExtensionSettings(MutateAdGroupExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad group extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupExtensionSettingsResponse> MutateAdGroupExtensionSettingsAsync(MutateAdGroupExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad group extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupExtensionSettingsResponse> MutateAdGroupExtensionSettingsAsync(MutateAdGroupExtensionSettingsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupExtensionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ad group extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group extension settings are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group extension
        /// settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupExtensionSettingsResponse MutateAdGroupExtensionSettings(string customerId, scg::IEnumerable<AdGroupExtensionSettingOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupExtensionSettings(new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad group extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group extension settings are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group extension
        /// settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupExtensionSettingsResponse> MutateAdGroupExtensionSettingsAsync(string customerId, scg::IEnumerable<AdGroupExtensionSettingOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupExtensionSettingsAsync(new MutateAdGroupExtensionSettingsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad group extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group extension settings are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group extension
        /// settings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupExtensionSettingsResponse> MutateAdGroupExtensionSettingsAsync(string customerId, scg::IEnumerable<AdGroupExtensionSettingOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupExtensionSettingsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupExtensionSettingService client wrapper implementation, for convenient use.</summary>
    public sealed partial class AdGroupExtensionSettingServiceClientImpl : AdGroupExtensionSettingServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupExtensionSettingRequest, gagvr::AdGroupExtensionSetting> _callGetAdGroupExtensionSetting;

        private readonly gaxgrpc::ApiCall<MutateAdGroupExtensionSettingsRequest, MutateAdGroupExtensionSettingsResponse> _callMutateAdGroupExtensionSettings;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupExtensionSettingService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdGroupExtensionSettingServiceSettings"/> used within this client.
        /// </param>
        public AdGroupExtensionSettingServiceClientImpl(AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient grpcClient, AdGroupExtensionSettingServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupExtensionSettingServiceSettings effectiveSettings = settings ?? AdGroupExtensionSettingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupExtensionSetting = clientHelper.BuildApiCall<GetAdGroupExtensionSettingRequest, gagvr::AdGroupExtensionSetting>(grpcClient.GetAdGroupExtensionSettingAsync, grpcClient.GetAdGroupExtensionSetting, effectiveSettings.GetAdGroupExtensionSettingSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupExtensionSetting);
            Modify_GetAdGroupExtensionSettingApiCall(ref _callGetAdGroupExtensionSetting);
            _callMutateAdGroupExtensionSettings = clientHelper.BuildApiCall<MutateAdGroupExtensionSettingsRequest, MutateAdGroupExtensionSettingsResponse>(grpcClient.MutateAdGroupExtensionSettingsAsync, grpcClient.MutateAdGroupExtensionSettings, effectiveSettings.MutateAdGroupExtensionSettingsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupExtensionSettings);
            Modify_MutateAdGroupExtensionSettingsApiCall(ref _callMutateAdGroupExtensionSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupExtensionSettingApiCall(ref gaxgrpc::ApiCall<GetAdGroupExtensionSettingRequest, gagvr::AdGroupExtensionSetting> call);

        partial void Modify_MutateAdGroupExtensionSettingsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupExtensionSettingsRequest, MutateAdGroupExtensionSettingsResponse> call);

        partial void OnConstruction(AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient grpcClient, AdGroupExtensionSettingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupExtensionSettingService client</summary>
        public override AdGroupExtensionSettingService.AdGroupExtensionSettingServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupExtensionSettingRequest(ref GetAdGroupExtensionSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateAdGroupExtensionSettingsRequest(ref MutateAdGroupExtensionSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroupExtensionSetting GetAdGroupExtensionSetting(GetAdGroupExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupExtensionSettingRequest(ref request, ref callSettings);
            return _callGetAdGroupExtensionSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroupExtensionSetting> GetAdGroupExtensionSettingAsync(GetAdGroupExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupExtensionSettingRequest(ref request, ref callSettings);
            return _callGetAdGroupExtensionSetting.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ad group extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupExtensionSettingsResponse MutateAdGroupExtensionSettings(MutateAdGroupExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupExtensionSettingsRequest(ref request, ref callSettings);
            return _callMutateAdGroupExtensionSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ad group extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupExtensionSettingsResponse> MutateAdGroupExtensionSettingsAsync(MutateAdGroupExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupExtensionSettingsRequest(ref request, ref callSettings);
            return _callMutateAdGroupExtensionSettings.Async(request, callSettings);
        }
    }
}

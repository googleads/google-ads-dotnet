// Copyright 2021 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
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

namespace Google.Ads.GoogleAds.V8.Services
{
    /// <summary>Settings for <see cref="SmartCampaignSettingServiceClient"/> instances.</summary>
    public sealed partial class SmartCampaignSettingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SmartCampaignSettingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SmartCampaignSettingServiceSettings"/>.</returns>
        public static SmartCampaignSettingServiceSettings GetDefault() => new SmartCampaignSettingServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SmartCampaignSettingServiceSettings"/> object with default settings.
        /// </summary>
        public SmartCampaignSettingServiceSettings()
        {
        }

        private SmartCampaignSettingServiceSettings(SmartCampaignSettingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSmartCampaignSettingSettings = existing.GetSmartCampaignSettingSettings;
            MutateSmartCampaignSettingsSettings = existing.MutateSmartCampaignSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SmartCampaignSettingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartCampaignSettingServiceClient.GetSmartCampaignSetting</c> and
        /// <c>SmartCampaignSettingServiceClient.GetSmartCampaignSettingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSmartCampaignSettingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartCampaignSettingServiceClient.MutateSmartCampaignSettings</c> and
        /// <c>SmartCampaignSettingServiceClient.MutateSmartCampaignSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateSmartCampaignSettingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SmartCampaignSettingServiceSettings"/> object.</returns>
        public SmartCampaignSettingServiceSettings Clone() => new SmartCampaignSettingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SmartCampaignSettingServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class SmartCampaignSettingServiceClientBuilder : gaxgrpc::ClientBuilderBase<SmartCampaignSettingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SmartCampaignSettingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SmartCampaignSettingServiceClientBuilder()
        {
            UseJwtAccessWithScopes = SmartCampaignSettingServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref SmartCampaignSettingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SmartCampaignSettingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SmartCampaignSettingServiceClient Build()
        {
            SmartCampaignSettingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SmartCampaignSettingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SmartCampaignSettingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SmartCampaignSettingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SmartCampaignSettingServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<SmartCampaignSettingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SmartCampaignSettingServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => SmartCampaignSettingServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SmartCampaignSettingServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SmartCampaignSettingServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>SmartCampaignSettingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Smart campaign settings.
    /// </remarks>
    public abstract partial class SmartCampaignSettingServiceClient
    {
        /// <summary>
        /// The default endpoint for the SmartCampaignSettingService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default SmartCampaignSettingService scopes.</summary>
        /// <remarks>
        /// The default SmartCampaignSettingService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="SmartCampaignSettingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SmartCampaignSettingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SmartCampaignSettingServiceClient"/>.</returns>
        public static stt::Task<SmartCampaignSettingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SmartCampaignSettingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SmartCampaignSettingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SmartCampaignSettingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SmartCampaignSettingServiceClient"/>.</returns>
        public static SmartCampaignSettingServiceClient Create() => new SmartCampaignSettingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SmartCampaignSettingServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SmartCampaignSettingServiceSettings"/>.</param>
        /// <returns>The created <see cref="SmartCampaignSettingServiceClient"/>.</returns>
        internal static SmartCampaignSettingServiceClient Create(grpccore::CallInvoker callInvoker, SmartCampaignSettingServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SmartCampaignSettingService.SmartCampaignSettingServiceClient grpcClient = new SmartCampaignSettingService.SmartCampaignSettingServiceClient(callInvoker);
            return new SmartCampaignSettingServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC SmartCampaignSettingService client</summary>
        public virtual SmartCampaignSettingService.SmartCampaignSettingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SmartCampaignSetting GetSmartCampaignSetting(GetSmartCampaignSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SmartCampaignSetting> GetSmartCampaignSettingAsync(GetSmartCampaignSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SmartCampaignSetting> GetSmartCampaignSettingAsync(GetSmartCampaignSettingRequest request, st::CancellationToken cancellationToken) =>
            GetSmartCampaignSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Smart campaign setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SmartCampaignSetting GetSmartCampaignSetting(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSmartCampaignSetting(new GetSmartCampaignSettingRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Smart campaign setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SmartCampaignSetting> GetSmartCampaignSettingAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSmartCampaignSettingAsync(new GetSmartCampaignSettingRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Smart campaign setting to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SmartCampaignSetting> GetSmartCampaignSettingAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetSmartCampaignSettingAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Smart campaign setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SmartCampaignSetting GetSmartCampaignSetting(gagvr::SmartCampaignSettingName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSmartCampaignSetting(new GetSmartCampaignSettingRequest
            {
                ResourceNameAsSmartCampaignSettingName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Smart campaign setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SmartCampaignSetting> GetSmartCampaignSettingAsync(gagvr::SmartCampaignSettingName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSmartCampaignSettingAsync(new GetSmartCampaignSettingRequest
            {
                ResourceNameAsSmartCampaignSettingName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the Smart campaign setting to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SmartCampaignSetting> GetSmartCampaignSettingAsync(gagvr::SmartCampaignSettingName resourceName, st::CancellationToken cancellationToken) =>
            GetSmartCampaignSettingAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates Smart campaign settings for campaigns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateSmartCampaignSettingsResponse MutateSmartCampaignSettings(MutateSmartCampaignSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates Smart campaign settings for campaigns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSmartCampaignSettingsResponse> MutateSmartCampaignSettingsAsync(MutateSmartCampaignSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates Smart campaign settings for campaigns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSmartCampaignSettingsResponse> MutateSmartCampaignSettingsAsync(MutateSmartCampaignSettingsRequest request, st::CancellationToken cancellationToken) =>
            MutateSmartCampaignSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates Smart campaign settings for campaigns.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Smart campaign settings are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Smart campaign settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateSmartCampaignSettingsResponse MutateSmartCampaignSettings(string customerId, scg::IEnumerable<SmartCampaignSettingOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateSmartCampaignSettings(new MutateSmartCampaignSettingsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Updates Smart campaign settings for campaigns.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Smart campaign settings are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Smart campaign settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSmartCampaignSettingsResponse> MutateSmartCampaignSettingsAsync(string customerId, scg::IEnumerable<SmartCampaignSettingOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateSmartCampaignSettingsAsync(new MutateSmartCampaignSettingsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Updates Smart campaign settings for campaigns.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Smart campaign settings are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Smart campaign settings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSmartCampaignSettingsResponse> MutateSmartCampaignSettingsAsync(string customerId, scg::IEnumerable<SmartCampaignSettingOperation> operations, st::CancellationToken cancellationToken) =>
            MutateSmartCampaignSettingsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SmartCampaignSettingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Smart campaign settings.
    /// </remarks>
    public sealed partial class SmartCampaignSettingServiceClientImpl : SmartCampaignSettingServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSmartCampaignSettingRequest, gagvr::SmartCampaignSetting> _callGetSmartCampaignSetting;

        private readonly gaxgrpc::ApiCall<MutateSmartCampaignSettingsRequest, MutateSmartCampaignSettingsResponse> _callMutateSmartCampaignSettings;

        /// <summary>
        /// Constructs a client wrapper for the SmartCampaignSettingService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SmartCampaignSettingServiceSettings"/> used within this client.
        /// </param>
        public SmartCampaignSettingServiceClientImpl(SmartCampaignSettingService.SmartCampaignSettingServiceClient grpcClient, SmartCampaignSettingServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SmartCampaignSettingServiceSettings effectiveSettings = settings ?? SmartCampaignSettingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetSmartCampaignSetting = clientHelper.BuildApiCall<GetSmartCampaignSettingRequest, gagvr::SmartCampaignSetting>(grpcClient.GetSmartCampaignSettingAsync, grpcClient.GetSmartCampaignSetting, effectiveSettings.GetSmartCampaignSettingSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetSmartCampaignSetting);
            Modify_GetSmartCampaignSettingApiCall(ref _callGetSmartCampaignSetting);
            _callMutateSmartCampaignSettings = clientHelper.BuildApiCall<MutateSmartCampaignSettingsRequest, MutateSmartCampaignSettingsResponse>(grpcClient.MutateSmartCampaignSettingsAsync, grpcClient.MutateSmartCampaignSettings, effectiveSettings.MutateSmartCampaignSettingsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateSmartCampaignSettings);
            Modify_MutateSmartCampaignSettingsApiCall(ref _callMutateSmartCampaignSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSmartCampaignSettingApiCall(ref gaxgrpc::ApiCall<GetSmartCampaignSettingRequest, gagvr::SmartCampaignSetting> call);

        partial void Modify_MutateSmartCampaignSettingsApiCall(ref gaxgrpc::ApiCall<MutateSmartCampaignSettingsRequest, MutateSmartCampaignSettingsResponse> call);

        partial void OnConstruction(SmartCampaignSettingService.SmartCampaignSettingServiceClient grpcClient, SmartCampaignSettingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SmartCampaignSettingService client</summary>
        public override SmartCampaignSettingService.SmartCampaignSettingServiceClient GrpcClient { get; }

        partial void Modify_GetSmartCampaignSettingRequest(ref GetSmartCampaignSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateSmartCampaignSettingsRequest(ref MutateSmartCampaignSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::SmartCampaignSetting GetSmartCampaignSetting(GetSmartCampaignSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSmartCampaignSettingRequest(ref request, ref callSettings);
            return _callGetSmartCampaignSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Smart campaign setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::SmartCampaignSetting> GetSmartCampaignSettingAsync(GetSmartCampaignSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSmartCampaignSettingRequest(ref request, ref callSettings);
            return _callGetSmartCampaignSetting.Async(request, callSettings);
        }

        /// <summary>
        /// Updates Smart campaign settings for campaigns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateSmartCampaignSettingsResponse MutateSmartCampaignSettings(MutateSmartCampaignSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateSmartCampaignSettingsRequest(ref request, ref callSettings);
            return _callMutateSmartCampaignSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates Smart campaign settings for campaigns.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateSmartCampaignSettingsResponse> MutateSmartCampaignSettingsAsync(MutateSmartCampaignSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateSmartCampaignSettingsRequest(ref request, ref callSettings);
            return _callMutateSmartCampaignSettings.Async(request, callSettings);
        }
    }
}

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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
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

namespace Google.Ads.GoogleAds.V9.Services
{
    /// <summary>Settings for <see cref="AdGroupAssetServiceClient"/> instances.</summary>
    public sealed partial class AdGroupAssetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupAssetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupAssetServiceSettings"/>.</returns>
        public static AdGroupAssetServiceSettings GetDefault() => new AdGroupAssetServiceSettings();

        /// <summary>Constructs a new <see cref="AdGroupAssetServiceSettings"/> object with default settings.</summary>
        public AdGroupAssetServiceSettings()
        {
        }

        private AdGroupAssetServiceSettings(AdGroupAssetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupAssetSettings = existing.GetAdGroupAssetSettings;
            MutateAdGroupAssetsSettings = existing.MutateAdGroupAssetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupAssetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAssetServiceClient.GetAdGroupAsset</c> and <c>AdGroupAssetServiceClient.GetAdGroupAssetAsync</c>.
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
        public gaxgrpc::CallSettings GetAdGroupAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAssetServiceClient.MutateAdGroupAssets</c> and
        /// <c>AdGroupAssetServiceClient.MutateAdGroupAssetsAsync</c>.
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
        public gaxgrpc::CallSettings MutateAdGroupAssetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupAssetServiceSettings"/> object.</returns>
        public AdGroupAssetServiceSettings Clone() => new AdGroupAssetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupAssetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AdGroupAssetServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupAssetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupAssetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdGroupAssetServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AdGroupAssetServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AdGroupAssetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupAssetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupAssetServiceClient Build()
        {
            AdGroupAssetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupAssetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupAssetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupAssetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupAssetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupAssetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupAssetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupAssetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdGroupAssetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupAssetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupAssetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group assets.
    /// </remarks>
    public abstract partial class AdGroupAssetServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupAssetService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupAssetService scopes.</summary>
        /// <remarks>
        /// The default AdGroupAssetService scopes are:
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
        /// Asynchronously creates a <see cref="AdGroupAssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupAssetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupAssetServiceClient"/>.</returns>
        public static stt::Task<AdGroupAssetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupAssetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupAssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupAssetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupAssetServiceClient"/>.</returns>
        public static AdGroupAssetServiceClient Create() => new AdGroupAssetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupAssetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupAssetServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupAssetServiceClient"/>.</returns>
        internal static AdGroupAssetServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupAssetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupAssetService.AdGroupAssetServiceClient grpcClient = new AdGroupAssetService.AdGroupAssetServiceClient(callInvoker);
            return new AdGroupAssetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupAssetService client</summary>
        public virtual AdGroupAssetService.AdGroupAssetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAsset GetAdGroupAsset(GetAdGroupAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAsset> GetAdGroupAssetAsync(GetAdGroupAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAsset> GetAdGroupAssetAsync(GetAdGroupAssetRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group asset to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAsset GetAdGroupAsset(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAsset(new GetAdGroupAssetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group asset to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAsset> GetAdGroupAssetAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAssetAsync(new GetAdGroupAssetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group asset to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAsset> GetAdGroupAssetAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAssetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group asset to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAsset GetAdGroupAsset(gagvr::AdGroupAssetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAsset(new GetAdGroupAssetRequest
            {
                ResourceNameAsAdGroupAssetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group asset to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAsset> GetAdGroupAssetAsync(gagvr::AdGroupAssetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAssetAsync(new GetAdGroupAssetRequest
            {
                ResourceNameAsAdGroupAssetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group asset to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAsset> GetAdGroupAssetAsync(gagvr::AdGroupAssetName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAssetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ad group assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupAssetsResponse MutateAdGroupAssets(MutateAdGroupAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad group assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAssetsResponse> MutateAdGroupAssetsAsync(MutateAdGroupAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad group assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAssetsResponse> MutateAdGroupAssetsAsync(MutateAdGroupAssetsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ad group assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group assets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupAssetsResponse MutateAdGroupAssets(string customerId, scg::IEnumerable<AdGroupAssetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupAssets(new MutateAdGroupAssetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad group assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group assets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAssetsResponse> MutateAdGroupAssetsAsync(string customerId, scg::IEnumerable<AdGroupAssetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupAssetsAsync(new MutateAdGroupAssetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad group assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group assets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAssetsResponse> MutateAdGroupAssetsAsync(string customerId, scg::IEnumerable<AdGroupAssetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupAssetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupAssetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group assets.
    /// </remarks>
    public sealed partial class AdGroupAssetServiceClientImpl : AdGroupAssetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupAssetRequest, gagvr::AdGroupAsset> _callGetAdGroupAsset;

        private readonly gaxgrpc::ApiCall<MutateAdGroupAssetsRequest, MutateAdGroupAssetsResponse> _callMutateAdGroupAssets;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupAssetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdGroupAssetServiceSettings"/> used within this client.</param>
        public AdGroupAssetServiceClientImpl(AdGroupAssetService.AdGroupAssetServiceClient grpcClient, AdGroupAssetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupAssetServiceSettings effectiveSettings = settings ?? AdGroupAssetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupAsset = clientHelper.BuildApiCall<GetAdGroupAssetRequest, gagvr::AdGroupAsset>(grpcClient.GetAdGroupAssetAsync, grpcClient.GetAdGroupAsset, effectiveSettings.GetAdGroupAssetSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupAsset);
            Modify_GetAdGroupAssetApiCall(ref _callGetAdGroupAsset);
            _callMutateAdGroupAssets = clientHelper.BuildApiCall<MutateAdGroupAssetsRequest, MutateAdGroupAssetsResponse>(grpcClient.MutateAdGroupAssetsAsync, grpcClient.MutateAdGroupAssets, effectiveSettings.MutateAdGroupAssetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupAssets);
            Modify_MutateAdGroupAssetsApiCall(ref _callMutateAdGroupAssets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupAssetApiCall(ref gaxgrpc::ApiCall<GetAdGroupAssetRequest, gagvr::AdGroupAsset> call);

        partial void Modify_MutateAdGroupAssetsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupAssetsRequest, MutateAdGroupAssetsResponse> call);

        partial void OnConstruction(AdGroupAssetService.AdGroupAssetServiceClient grpcClient, AdGroupAssetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupAssetService client</summary>
        public override AdGroupAssetService.AdGroupAssetServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupAssetRequest(ref GetAdGroupAssetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateAdGroupAssetsRequest(ref MutateAdGroupAssetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroupAsset GetAdGroupAsset(GetAdGroupAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAssetRequest(ref request, ref callSettings);
            return _callGetAdGroupAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group asset in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroupAsset> GetAdGroupAssetAsync(GetAdGroupAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAssetRequest(ref request, ref callSettings);
            return _callGetAdGroupAsset.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ad group assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupAssetsResponse MutateAdGroupAssets(MutateAdGroupAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAssetsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAssets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ad group assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupAssetsResponse> MutateAdGroupAssetsAsync(MutateAdGroupAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAssetsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAssets.Async(request, callSettings);
        }
    }
}

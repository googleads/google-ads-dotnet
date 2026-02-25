// Copyright 2026 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V20.Services
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
            MutateCampaignAssetsSettings = existing.MutateCampaignAssetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignAssetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignAssetServiceClient.MutateCampaignAssets</c> and
        /// <c>CampaignAssetServiceClient.MutateCampaignAssetsAsync</c>.
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
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCampaignAssetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignAssetServiceSettings"/> object.</returns>
        public CampaignAssetServiceSettings Clone() => new CampaignAssetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignAssetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CampaignAssetServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignAssetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignAssetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignAssetServiceClientBuilder() : base(CampaignAssetServiceClient.ServiceMetadata)
        {
        }

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
            return CampaignAssetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CampaignAssetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignAssetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignAssetServiceClient.ChannelPool;
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
        /// <remarks>
        /// The default CampaignAssetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CampaignAssetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

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
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CampaignAssetServiceClient"/>.</returns>
        internal static CampaignAssetServiceClient Create(grpccore::CallInvoker callInvoker, CampaignAssetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignAssetService.CampaignAssetServiceClient grpcClient = new CampaignAssetService.CampaignAssetServiceClient(callInvoker);
            return new CampaignAssetServiceClientImpl(grpcClient, settings, logger);
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
        /// Creates, updates, or removes campaign assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
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
        public virtual MutateCampaignAssetsResponse MutateCampaignAssets(MutateCampaignAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
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
        public virtual stt::Task<MutateCampaignAssetsResponse> MutateCampaignAssetsAsync(MutateCampaignAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
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
        public virtual stt::Task<MutateCampaignAssetsResponse> MutateCampaignAssetsAsync(MutateCampaignAssetsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
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
        /// Creates, updates, or removes campaign assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
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
        /// Creates, updates, or removes campaign assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotAllowlistedError]()
        /// [QuotaError]()
        /// [RequestError]()
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
        private readonly gaxgrpc::ApiCall<MutateCampaignAssetsRequest, MutateCampaignAssetsResponse> _callMutateCampaignAssets;

        /// <summary>
        /// Constructs a client wrapper for the CampaignAssetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignAssetServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CampaignAssetServiceClientImpl(CampaignAssetService.CampaignAssetServiceClient grpcClient, CampaignAssetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CampaignAssetServiceSettings effectiveSettings = settings ?? CampaignAssetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCampaignAssets = clientHelper.BuildApiCall<MutateCampaignAssetsRequest, MutateCampaignAssetsResponse>("MutateCampaignAssets", grpcClient.MutateCampaignAssetsAsync, grpcClient.MutateCampaignAssets, effectiveSettings.MutateCampaignAssetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignAssets);
            Modify_MutateCampaignAssetsApiCall(ref _callMutateCampaignAssets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCampaignAssetsApiCall(ref gaxgrpc::ApiCall<MutateCampaignAssetsRequest, MutateCampaignAssetsResponse> call);

        partial void OnConstruction(CampaignAssetService.CampaignAssetServiceClient grpcClient, CampaignAssetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignAssetService client</summary>
        public override CampaignAssetService.CampaignAssetServiceClient GrpcClient { get; }

        partial void Modify_MutateCampaignAssetsRequest(ref MutateCampaignAssetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes campaign assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
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
        public override MutateCampaignAssetsResponse MutateCampaignAssets(MutateCampaignAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignAssetsRequest(ref request, ref callSettings);
            return _callMutateCampaignAssets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [DatabaseError]()
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
        public override stt::Task<MutateCampaignAssetsResponse> MutateCampaignAssetsAsync(MutateCampaignAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignAssetsRequest(ref request, ref callSettings);
            return _callMutateCampaignAssets.Async(request, callSettings);
        }
    }
}

// Copyright 2025 Google LLC
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

namespace Google.Ads.GoogleAds.V22.Services
{
    /// <summary>Settings for <see cref="CampaignGoalConfigServiceClient"/> instances.</summary>
    public sealed partial class CampaignGoalConfigServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignGoalConfigServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignGoalConfigServiceSettings"/>.</returns>
        public static CampaignGoalConfigServiceSettings GetDefault() => new CampaignGoalConfigServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignGoalConfigServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignGoalConfigServiceSettings()
        {
        }

        private CampaignGoalConfigServiceSettings(CampaignGoalConfigServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCampaignGoalConfigsSettings = existing.MutateCampaignGoalConfigsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignGoalConfigServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignGoalConfigServiceClient.MutateCampaignGoalConfigs</c> and
        /// <c>CampaignGoalConfigServiceClient.MutateCampaignGoalConfigsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCampaignGoalConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignGoalConfigServiceSettings"/> object.</returns>
        public CampaignGoalConfigServiceSettings Clone() => new CampaignGoalConfigServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignGoalConfigServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CampaignGoalConfigServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignGoalConfigServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignGoalConfigServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignGoalConfigServiceClientBuilder() : base(CampaignGoalConfigServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CampaignGoalConfigServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignGoalConfigServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignGoalConfigServiceClient Build()
        {
            CampaignGoalConfigServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignGoalConfigServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignGoalConfigServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignGoalConfigServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignGoalConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CampaignGoalConfigServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignGoalConfigServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignGoalConfigServiceClient.ChannelPool;
    }

    /// <summary>CampaignGoalConfigService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign goal configs.
    /// </remarks>
    public abstract partial class CampaignGoalConfigServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignGoalConfigService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignGoalConfigService scopes.</summary>
        /// <remarks>
        /// The default CampaignGoalConfigService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CampaignGoalConfigService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignGoalConfigServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignGoalConfigServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignGoalConfigServiceClient"/>.</returns>
        public static stt::Task<CampaignGoalConfigServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignGoalConfigServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignGoalConfigServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignGoalConfigServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignGoalConfigServiceClient"/>.</returns>
        public static CampaignGoalConfigServiceClient Create() => new CampaignGoalConfigServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignGoalConfigServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignGoalConfigServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CampaignGoalConfigServiceClient"/>.</returns>
        internal static CampaignGoalConfigServiceClient Create(grpccore::CallInvoker callInvoker, CampaignGoalConfigServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignGoalConfigService.CampaignGoalConfigServiceClient grpcClient = new CampaignGoalConfigService.CampaignGoalConfigServiceClient(callInvoker);
            return new CampaignGoalConfigServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CampaignGoalConfigService client</summary>
        public virtual CampaignGoalConfigService.CampaignGoalConfigServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create or update campaign goal configs.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [CampaignGoalConfigError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignGoalConfigsResponse MutateCampaignGoalConfigs(MutateCampaignGoalConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create or update campaign goal configs.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [CampaignGoalConfigError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignGoalConfigsResponse> MutateCampaignGoalConfigsAsync(MutateCampaignGoalConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create or update campaign goal configs.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [CampaignGoalConfigError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignGoalConfigsResponse> MutateCampaignGoalConfigsAsync(MutateCampaignGoalConfigsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignGoalConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create or update campaign goal configs.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [CampaignGoalConfigError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign goal configs are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on the campaign goal configs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignGoalConfigsResponse MutateCampaignGoalConfigs(string customerId, scg::IEnumerable<CampaignGoalConfigOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignGoalConfigs(new MutateCampaignGoalConfigsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Create or update campaign goal configs.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [CampaignGoalConfigError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign goal configs are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on the campaign goal configs.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignGoalConfigsResponse> MutateCampaignGoalConfigsAsync(string customerId, scg::IEnumerable<CampaignGoalConfigOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignGoalConfigsAsync(new MutateCampaignGoalConfigsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Create or update campaign goal configs.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [CampaignGoalConfigError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign goal configs are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on the campaign goal configs.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignGoalConfigsResponse> MutateCampaignGoalConfigsAsync(string customerId, scg::IEnumerable<CampaignGoalConfigOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignGoalConfigsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignGoalConfigService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign goal configs.
    /// </remarks>
    public sealed partial class CampaignGoalConfigServiceClientImpl : CampaignGoalConfigServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCampaignGoalConfigsRequest, MutateCampaignGoalConfigsResponse> _callMutateCampaignGoalConfigs;

        /// <summary>
        /// Constructs a client wrapper for the CampaignGoalConfigService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignGoalConfigServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CampaignGoalConfigServiceClientImpl(CampaignGoalConfigService.CampaignGoalConfigServiceClient grpcClient, CampaignGoalConfigServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CampaignGoalConfigServiceSettings effectiveSettings = settings ?? CampaignGoalConfigServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCampaignGoalConfigs = clientHelper.BuildApiCall<MutateCampaignGoalConfigsRequest, MutateCampaignGoalConfigsResponse>("MutateCampaignGoalConfigs", grpcClient.MutateCampaignGoalConfigsAsync, grpcClient.MutateCampaignGoalConfigs, effectiveSettings.MutateCampaignGoalConfigsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignGoalConfigs);
            Modify_MutateCampaignGoalConfigsApiCall(ref _callMutateCampaignGoalConfigs);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCampaignGoalConfigsApiCall(ref gaxgrpc::ApiCall<MutateCampaignGoalConfigsRequest, MutateCampaignGoalConfigsResponse> call);

        partial void OnConstruction(CampaignGoalConfigService.CampaignGoalConfigServiceClient grpcClient, CampaignGoalConfigServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignGoalConfigService client</summary>
        public override CampaignGoalConfigService.CampaignGoalConfigServiceClient GrpcClient { get; }

        partial void Modify_MutateCampaignGoalConfigsRequest(ref MutateCampaignGoalConfigsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create or update campaign goal configs.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [CampaignGoalConfigError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignGoalConfigsResponse MutateCampaignGoalConfigs(MutateCampaignGoalConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignGoalConfigsRequest(ref request, ref callSettings);
            return _callMutateCampaignGoalConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Create or update campaign goal configs.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [CampaignGoalConfigError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignGoalConfigsResponse> MutateCampaignGoalConfigsAsync(MutateCampaignGoalConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignGoalConfigsRequest(ref request, ref callSettings);
            return _callMutateCampaignGoalConfigs.Async(request, callSettings);
        }
    }
}

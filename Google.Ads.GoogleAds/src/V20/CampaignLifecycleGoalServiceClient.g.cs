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
    /// <summary>Settings for <see cref="CampaignLifecycleGoalServiceClient"/> instances.</summary>
    public sealed partial class CampaignLifecycleGoalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignLifecycleGoalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignLifecycleGoalServiceSettings"/>.</returns>
        public static CampaignLifecycleGoalServiceSettings GetDefault() => new CampaignLifecycleGoalServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignLifecycleGoalServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignLifecycleGoalServiceSettings()
        {
        }

        private CampaignLifecycleGoalServiceSettings(CampaignLifecycleGoalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ConfigureCampaignLifecycleGoalsSettings = existing.ConfigureCampaignLifecycleGoalsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignLifecycleGoalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignLifecycleGoalServiceClient.ConfigureCampaignLifecycleGoals</c> and
        /// <c>CampaignLifecycleGoalServiceClient.ConfigureCampaignLifecycleGoalsAsync</c>.
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
        public gaxgrpc::CallSettings ConfigureCampaignLifecycleGoalsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignLifecycleGoalServiceSettings"/> object.</returns>
        public CampaignLifecycleGoalServiceSettings Clone() => new CampaignLifecycleGoalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignLifecycleGoalServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class CampaignLifecycleGoalServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignLifecycleGoalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignLifecycleGoalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignLifecycleGoalServiceClientBuilder() : base(CampaignLifecycleGoalServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CampaignLifecycleGoalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignLifecycleGoalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignLifecycleGoalServiceClient Build()
        {
            CampaignLifecycleGoalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignLifecycleGoalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignLifecycleGoalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignLifecycleGoalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignLifecycleGoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CampaignLifecycleGoalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignLifecycleGoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignLifecycleGoalServiceClient.ChannelPool;
    }

    /// <summary>CampaignLifecycleGoalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to configure campaign lifecycle goals.
    /// </remarks>
    public abstract partial class CampaignLifecycleGoalServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignLifecycleGoalService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignLifecycleGoalService scopes.</summary>
        /// <remarks>
        /// The default CampaignLifecycleGoalService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CampaignLifecycleGoalService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignLifecycleGoalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignLifecycleGoalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignLifecycleGoalServiceClient"/>.</returns>
        public static stt::Task<CampaignLifecycleGoalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignLifecycleGoalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignLifecycleGoalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignLifecycleGoalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignLifecycleGoalServiceClient"/>.</returns>
        public static CampaignLifecycleGoalServiceClient Create() => new CampaignLifecycleGoalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignLifecycleGoalServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignLifecycleGoalServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CampaignLifecycleGoalServiceClient"/>.</returns>
        internal static CampaignLifecycleGoalServiceClient Create(grpccore::CallInvoker callInvoker, CampaignLifecycleGoalServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignLifecycleGoalService.CampaignLifecycleGoalServiceClient grpcClient = new CampaignLifecycleGoalService.CampaignLifecycleGoalServiceClient(callInvoker);
            return new CampaignLifecycleGoalServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CampaignLifecycleGoalService client</summary>
        public virtual CampaignLifecycleGoalService.CampaignLifecycleGoalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Process the given campaign lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConfigureCampaignLifecycleGoalsResponse ConfigureCampaignLifecycleGoals(ConfigureCampaignLifecycleGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Process the given campaign lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConfigureCampaignLifecycleGoalsResponse> ConfigureCampaignLifecycleGoalsAsync(ConfigureCampaignLifecycleGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Process the given campaign lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConfigureCampaignLifecycleGoalsResponse> ConfigureCampaignLifecycleGoalsAsync(ConfigureCampaignLifecycleGoalsRequest request, st::CancellationToken cancellationToken) =>
            ConfigureCampaignLifecycleGoalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Process the given campaign lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform campaign lifecycle goal update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConfigureCampaignLifecycleGoalsResponse ConfigureCampaignLifecycleGoals(string customerId, CampaignLifecycleGoalOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureCampaignLifecycleGoals(new ConfigureCampaignLifecycleGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Process the given campaign lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform campaign lifecycle goal update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConfigureCampaignLifecycleGoalsResponse> ConfigureCampaignLifecycleGoalsAsync(string customerId, CampaignLifecycleGoalOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureCampaignLifecycleGoalsAsync(new ConfigureCampaignLifecycleGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Process the given campaign lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform campaign lifecycle goal update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConfigureCampaignLifecycleGoalsResponse> ConfigureCampaignLifecycleGoalsAsync(string customerId, CampaignLifecycleGoalOperation operation, st::CancellationToken cancellationToken) =>
            ConfigureCampaignLifecycleGoalsAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignLifecycleGoalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to configure campaign lifecycle goals.
    /// </remarks>
    public sealed partial class CampaignLifecycleGoalServiceClientImpl : CampaignLifecycleGoalServiceClient
    {
        private readonly gaxgrpc::ApiCall<ConfigureCampaignLifecycleGoalsRequest, ConfigureCampaignLifecycleGoalsResponse> _callConfigureCampaignLifecycleGoals;

        /// <summary>
        /// Constructs a client wrapper for the CampaignLifecycleGoalService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignLifecycleGoalServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CampaignLifecycleGoalServiceClientImpl(CampaignLifecycleGoalService.CampaignLifecycleGoalServiceClient grpcClient, CampaignLifecycleGoalServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CampaignLifecycleGoalServiceSettings effectiveSettings = settings ?? CampaignLifecycleGoalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callConfigureCampaignLifecycleGoals = clientHelper.BuildApiCall<ConfigureCampaignLifecycleGoalsRequest, ConfigureCampaignLifecycleGoalsResponse>("ConfigureCampaignLifecycleGoals", grpcClient.ConfigureCampaignLifecycleGoalsAsync, grpcClient.ConfigureCampaignLifecycleGoals, effectiveSettings.ConfigureCampaignLifecycleGoalsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callConfigureCampaignLifecycleGoals);
            Modify_ConfigureCampaignLifecycleGoalsApiCall(ref _callConfigureCampaignLifecycleGoals);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ConfigureCampaignLifecycleGoalsApiCall(ref gaxgrpc::ApiCall<ConfigureCampaignLifecycleGoalsRequest, ConfigureCampaignLifecycleGoalsResponse> call);

        partial void OnConstruction(CampaignLifecycleGoalService.CampaignLifecycleGoalServiceClient grpcClient, CampaignLifecycleGoalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignLifecycleGoalService client</summary>
        public override CampaignLifecycleGoalService.CampaignLifecycleGoalServiceClient GrpcClient { get; }

        partial void Modify_ConfigureCampaignLifecycleGoalsRequest(ref ConfigureCampaignLifecycleGoalsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Process the given campaign lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConfigureCampaignLifecycleGoalsResponse ConfigureCampaignLifecycleGoals(ConfigureCampaignLifecycleGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfigureCampaignLifecycleGoalsRequest(ref request, ref callSettings);
            return _callConfigureCampaignLifecycleGoals.Sync(request, callSettings);
        }

        /// <summary>
        /// Process the given campaign lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConfigureCampaignLifecycleGoalsResponse> ConfigureCampaignLifecycleGoalsAsync(ConfigureCampaignLifecycleGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfigureCampaignLifecycleGoalsRequest(ref request, ref callSettings);
            return _callConfigureCampaignLifecycleGoals.Async(request, callSettings);
        }
    }
}

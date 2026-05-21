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

namespace Google.Ads.GoogleAds.V22.Services
{
    /// <summary>Settings for <see cref="GoalServiceClient"/> instances.</summary>
    public sealed partial class GoalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GoalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GoalServiceSettings"/>.</returns>
        public static GoalServiceSettings GetDefault() => new GoalServiceSettings();

        /// <summary>Constructs a new <see cref="GoalServiceSettings"/> object with default settings.</summary>
        public GoalServiceSettings()
        {
        }

        private GoalServiceSettings(GoalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateGoalsSettings = existing.MutateGoalsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GoalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GoalServiceClient.MutateGoals</c> and <c>GoalServiceClient.MutateGoalsAsync</c>.
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
        public gaxgrpc::CallSettings MutateGoalsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GoalServiceSettings"/> object.</returns>
        public GoalServiceSettings Clone() => new GoalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GoalServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    internal sealed partial class GoalServiceClientBuilder : gaxgrpc::ClientBuilderBase<GoalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GoalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GoalServiceClientBuilder() : base(GoalServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GoalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GoalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GoalServiceClient Build()
        {
            GoalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GoalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GoalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GoalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GoalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GoalServiceClient.ChannelPool;
    }

    /// <summary>GoalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage goals.
    /// </remarks>
    public abstract partial class GoalServiceClient
    {
        /// <summary>
        /// The default endpoint for the GoalService service, which is a host of "googleads.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default GoalService scopes.</summary>
        /// <remarks>
        /// The default GoalService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GoalService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GoalServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GoalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GoalServiceClient"/>.</returns>
        public static stt::Task<GoalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GoalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GoalServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GoalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GoalServiceClient"/>.</returns>
        public static GoalServiceClient Create() => new GoalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GoalServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GoalServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GoalServiceClient"/>.</returns>
        internal static GoalServiceClient Create(grpccore::CallInvoker callInvoker, GoalServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GoalService.GoalServiceClient grpcClient = new GoalService.GoalServiceClient(callInvoker);
            return new GoalServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GoalService client</summary>
        public virtual GoalService.GoalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Create or update goals.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [GoalError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateGoalsResponse MutateGoals(MutateGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create or update goals.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [GoalError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateGoalsResponse> MutateGoalsAsync(MutateGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Create or update goals.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [GoalError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateGoalsResponse> MutateGoalsAsync(MutateGoalsRequest request, st::CancellationToken cancellationToken) =>
            MutateGoalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Create or update goals.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [GoalError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose goals are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on the goals.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateGoalsResponse MutateGoals(string customerId, scg::IEnumerable<GoalOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateGoals(new MutateGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Create or update goals.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [GoalError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose goals are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on the goals.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateGoalsResponse> MutateGoalsAsync(string customerId, scg::IEnumerable<GoalOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateGoalsAsync(new MutateGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Create or update goals.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [GoalError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose goals are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on the goals.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateGoalsResponse> MutateGoalsAsync(string customerId, scg::IEnumerable<GoalOperation> operations, st::CancellationToken cancellationToken) =>
            MutateGoalsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GoalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage goals.
    /// </remarks>
    public sealed partial class GoalServiceClientImpl : GoalServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateGoalsRequest, MutateGoalsResponse> _callMutateGoals;

        /// <summary>
        /// Constructs a client wrapper for the GoalService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GoalServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GoalServiceClientImpl(GoalService.GoalServiceClient grpcClient, GoalServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GoalServiceSettings effectiveSettings = settings ?? GoalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateGoals = clientHelper.BuildApiCall<MutateGoalsRequest, MutateGoalsResponse>("MutateGoals", grpcClient.MutateGoalsAsync, grpcClient.MutateGoals, effectiveSettings.MutateGoalsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateGoals);
            Modify_MutateGoalsApiCall(ref _callMutateGoals);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateGoalsApiCall(ref gaxgrpc::ApiCall<MutateGoalsRequest, MutateGoalsResponse> call);

        partial void OnConstruction(GoalService.GoalServiceClient grpcClient, GoalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GoalService client</summary>
        public override GoalService.GoalServiceClient GrpcClient { get; }

        partial void Modify_MutateGoalsRequest(ref MutateGoalsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Create or update goals.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [GoalError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateGoalsResponse MutateGoals(MutateGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateGoalsRequest(ref request, ref callSettings);
            return _callMutateGoals.Sync(request, callSettings);
        }

        /// <summary>
        /// Create or update goals.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [GoalError]()
        /// [GoalServicesError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateGoalsResponse> MutateGoalsAsync(MutateGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateGoalsRequest(ref request, ref callSettings);
            return _callMutateGoals.Async(request, callSettings);
        }
    }
}

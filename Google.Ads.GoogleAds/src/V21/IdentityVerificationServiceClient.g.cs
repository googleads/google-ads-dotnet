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
using gagve = Google.Ads.GoogleAds.V21.Enums;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.GoogleAds.V21.Services
{
    /// <summary>Settings for <see cref="IdentityVerificationServiceClient"/> instances.</summary>
    public sealed partial class IdentityVerificationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="IdentityVerificationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="IdentityVerificationServiceSettings"/>.</returns>
        public static IdentityVerificationServiceSettings GetDefault() => new IdentityVerificationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="IdentityVerificationServiceSettings"/> object with default settings.
        /// </summary>
        public IdentityVerificationServiceSettings()
        {
        }

        private IdentityVerificationServiceSettings(IdentityVerificationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            StartIdentityVerificationSettings = existing.StartIdentityVerificationSettings;
            GetIdentityVerificationSettings = existing.GetIdentityVerificationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(IdentityVerificationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityVerificationServiceClient.StartIdentityVerification</c> and
        /// <c>IdentityVerificationServiceClient.StartIdentityVerificationAsync</c>.
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
        public gaxgrpc::CallSettings StartIdentityVerificationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>IdentityVerificationServiceClient.GetIdentityVerification</c> and
        /// <c>IdentityVerificationServiceClient.GetIdentityVerificationAsync</c>.
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
        public gaxgrpc::CallSettings GetIdentityVerificationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="IdentityVerificationServiceSettings"/> object.</returns>
        public IdentityVerificationServiceSettings Clone() => new IdentityVerificationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="IdentityVerificationServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class IdentityVerificationServiceClientBuilder : gaxgrpc::ClientBuilderBase<IdentityVerificationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public IdentityVerificationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public IdentityVerificationServiceClientBuilder() : base(IdentityVerificationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref IdentityVerificationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<IdentityVerificationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override IdentityVerificationServiceClient Build()
        {
            IdentityVerificationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<IdentityVerificationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<IdentityVerificationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private IdentityVerificationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return IdentityVerificationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<IdentityVerificationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return IdentityVerificationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => IdentityVerificationServiceClient.ChannelPool;
    }

    /// <summary>IdentityVerificationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Identity Verification Service.
    /// </remarks>
    public abstract partial class IdentityVerificationServiceClient
    {
        /// <summary>
        /// The default endpoint for the IdentityVerificationService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default IdentityVerificationService scopes.</summary>
        /// <remarks>
        /// The default IdentityVerificationService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(IdentityVerificationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="IdentityVerificationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="IdentityVerificationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="IdentityVerificationServiceClient"/>.</returns>
        public static stt::Task<IdentityVerificationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new IdentityVerificationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="IdentityVerificationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="IdentityVerificationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="IdentityVerificationServiceClient"/>.</returns>
        public static IdentityVerificationServiceClient Create() => new IdentityVerificationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="IdentityVerificationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="IdentityVerificationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="IdentityVerificationServiceClient"/>.</returns>
        internal static IdentityVerificationServiceClient Create(grpccore::CallInvoker callInvoker, IdentityVerificationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            IdentityVerificationService.IdentityVerificationServiceClient grpcClient = new IdentityVerificationService.IdentityVerificationServiceClient(callInvoker);
            return new IdentityVerificationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC IdentityVerificationService client</summary>
        public virtual IdentityVerificationService.IdentityVerificationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Starts Identity Verification for a given verification program type.
        /// Statuses are returned.
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
        public virtual void StartIdentityVerification(StartIdentityVerificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts Identity Verification for a given verification program type.
        /// Statuses are returned.
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
        public virtual stt::Task StartIdentityVerificationAsync(StartIdentityVerificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Starts Identity Verification for a given verification program type.
        /// Statuses are returned.
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
        public virtual stt::Task StartIdentityVerificationAsync(StartIdentityVerificationRequest request, st::CancellationToken cancellationToken) =>
            StartIdentityVerificationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Starts Identity Verification for a given verification program type.
        /// Statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The Id of the customer for whom we are creating this
        /// verification.
        /// </param>
        /// <param name="verificationProgram">
        /// Required. The verification program type for which we want to start the
        /// verification.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void StartIdentityVerification(string customerId, gagve::IdentityVerificationProgramEnum.Types.IdentityVerificationProgram verificationProgram, gaxgrpc::CallSettings callSettings = null) =>
            StartIdentityVerification(new StartIdentityVerificationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                VerificationProgram = verificationProgram,
            }, callSettings);

        /// <summary>
        /// Starts Identity Verification for a given verification program type.
        /// Statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The Id of the customer for whom we are creating this
        /// verification.
        /// </param>
        /// <param name="verificationProgram">
        /// Required. The verification program type for which we want to start the
        /// verification.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task StartIdentityVerificationAsync(string customerId, gagve::IdentityVerificationProgramEnum.Types.IdentityVerificationProgram verificationProgram, gaxgrpc::CallSettings callSettings = null) =>
            StartIdentityVerificationAsync(new StartIdentityVerificationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                VerificationProgram = verificationProgram,
            }, callSettings);

        /// <summary>
        /// Starts Identity Verification for a given verification program type.
        /// Statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The Id of the customer for whom we are creating this
        /// verification.
        /// </param>
        /// <param name="verificationProgram">
        /// Required. The verification program type for which we want to start the
        /// verification.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task StartIdentityVerificationAsync(string customerId, gagve::IdentityVerificationProgramEnum.Types.IdentityVerificationProgram verificationProgram, st::CancellationToken cancellationToken) =>
            StartIdentityVerificationAsync(customerId, verificationProgram, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns Identity Verification information.
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
        public virtual GetIdentityVerificationResponse GetIdentityVerification(GetIdentityVerificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns Identity Verification information.
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
        public virtual stt::Task<GetIdentityVerificationResponse> GetIdentityVerificationAsync(GetIdentityVerificationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns Identity Verification information.
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
        public virtual stt::Task<GetIdentityVerificationResponse> GetIdentityVerificationAsync(GetIdentityVerificationRequest request, st::CancellationToken cancellationToken) =>
            GetIdentityVerificationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns Identity Verification information.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required.  The ID of the customer for whom we are requesting verification
        /// information.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GetIdentityVerificationResponse GetIdentityVerification(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            GetIdentityVerification(new GetIdentityVerificationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Returns Identity Verification information.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required.  The ID of the customer for whom we are requesting verification
        /// information.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetIdentityVerificationResponse> GetIdentityVerificationAsync(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            GetIdentityVerificationAsync(new GetIdentityVerificationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Returns Identity Verification information.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required.  The ID of the customer for whom we are requesting verification
        /// information.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GetIdentityVerificationResponse> GetIdentityVerificationAsync(string customerId, st::CancellationToken cancellationToken) =>
            GetIdentityVerificationAsync(customerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>IdentityVerificationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing Identity Verification Service.
    /// </remarks>
    public sealed partial class IdentityVerificationServiceClientImpl : IdentityVerificationServiceClient
    {
        private readonly gaxgrpc::ApiCall<StartIdentityVerificationRequest, wkt::Empty> _callStartIdentityVerification;

        private readonly gaxgrpc::ApiCall<GetIdentityVerificationRequest, GetIdentityVerificationResponse> _callGetIdentityVerification;

        /// <summary>
        /// Constructs a client wrapper for the IdentityVerificationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="IdentityVerificationServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public IdentityVerificationServiceClientImpl(IdentityVerificationService.IdentityVerificationServiceClient grpcClient, IdentityVerificationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            IdentityVerificationServiceSettings effectiveSettings = settings ?? IdentityVerificationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callStartIdentityVerification = clientHelper.BuildApiCall<StartIdentityVerificationRequest, wkt::Empty>("StartIdentityVerification", grpcClient.StartIdentityVerificationAsync, grpcClient.StartIdentityVerification, effectiveSettings.StartIdentityVerificationSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callStartIdentityVerification);
            Modify_StartIdentityVerificationApiCall(ref _callStartIdentityVerification);
            _callGetIdentityVerification = clientHelper.BuildApiCall<GetIdentityVerificationRequest, GetIdentityVerificationResponse>("GetIdentityVerification", grpcClient.GetIdentityVerificationAsync, grpcClient.GetIdentityVerification, effectiveSettings.GetIdentityVerificationSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGetIdentityVerification);
            Modify_GetIdentityVerificationApiCall(ref _callGetIdentityVerification);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_StartIdentityVerificationApiCall(ref gaxgrpc::ApiCall<StartIdentityVerificationRequest, wkt::Empty> call);

        partial void Modify_GetIdentityVerificationApiCall(ref gaxgrpc::ApiCall<GetIdentityVerificationRequest, GetIdentityVerificationResponse> call);

        partial void OnConstruction(IdentityVerificationService.IdentityVerificationServiceClient grpcClient, IdentityVerificationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC IdentityVerificationService client</summary>
        public override IdentityVerificationService.IdentityVerificationServiceClient GrpcClient { get; }

        partial void Modify_StartIdentityVerificationRequest(ref StartIdentityVerificationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetIdentityVerificationRequest(ref GetIdentityVerificationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Starts Identity Verification for a given verification program type.
        /// Statuses are returned.
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
        public override void StartIdentityVerification(StartIdentityVerificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartIdentityVerificationRequest(ref request, ref callSettings);
            _callStartIdentityVerification.Sync(request, callSettings);
        }

        /// <summary>
        /// Starts Identity Verification for a given verification program type.
        /// Statuses are returned.
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
        public override stt::Task StartIdentityVerificationAsync(StartIdentityVerificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_StartIdentityVerificationRequest(ref request, ref callSettings);
            return _callStartIdentityVerification.Async(request, callSettings);
        }

        /// <summary>
        /// Returns Identity Verification information.
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
        public override GetIdentityVerificationResponse GetIdentityVerification(GetIdentityVerificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIdentityVerificationRequest(ref request, ref callSettings);
            return _callGetIdentityVerification.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns Identity Verification information.
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
        public override stt::Task<GetIdentityVerificationResponse> GetIdentityVerificationAsync(GetIdentityVerificationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetIdentityVerificationRequest(ref request, ref callSettings);
            return _callGetIdentityVerification.Async(request, callSettings);
        }
    }
}

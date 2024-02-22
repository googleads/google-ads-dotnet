// Copyright 2024 Google LLC
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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V16.Services
{
    /// <summary>Settings for <see cref="BillingSetupServiceClient"/> instances.</summary>
    public sealed partial class BillingSetupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BillingSetupServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BillingSetupServiceSettings"/>.</returns>
        public static BillingSetupServiceSettings GetDefault() => new BillingSetupServiceSettings();

        /// <summary>Constructs a new <see cref="BillingSetupServiceSettings"/> object with default settings.</summary>
        public BillingSetupServiceSettings()
        {
        }

        private BillingSetupServiceSettings(BillingSetupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateBillingSetupSettings = existing.MutateBillingSetupSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BillingSetupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BillingSetupServiceClient.MutateBillingSetup</c> and <c>BillingSetupServiceClient.MutateBillingSetupAsync</c>
        /// .
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
        public gaxgrpc::CallSettings MutateBillingSetupSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BillingSetupServiceSettings"/> object.</returns>
        public BillingSetupServiceSettings Clone() => new BillingSetupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BillingSetupServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class BillingSetupServiceClientBuilder : gaxgrpc::ClientBuilderBase<BillingSetupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BillingSetupServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BillingSetupServiceClientBuilder() : base(BillingSetupServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BillingSetupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BillingSetupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BillingSetupServiceClient Build()
        {
            BillingSetupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BillingSetupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BillingSetupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BillingSetupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BillingSetupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BillingSetupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BillingSetupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BillingSetupServiceClient.ChannelPool;
    }

    /// <summary>BillingSetupService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for designating the business entity responsible for accrued costs.
    /// 
    /// A billing setup is associated with a payments account.  Billing-related
    /// activity for all billing setups associated with a particular payments account
    /// will appear on a single invoice generated monthly.
    /// 
    /// Mutates:
    /// The REMOVE operation cancels a pending billing setup.
    /// The CREATE operation creates a new billing setup.
    /// </remarks>
    public abstract partial class BillingSetupServiceClient
    {
        /// <summary>
        /// The default endpoint for the BillingSetupService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default BillingSetupService scopes.</summary>
        /// <remarks>
        /// The default BillingSetupService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BillingSetupService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BillingSetupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="BillingSetupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BillingSetupServiceClient"/>.</returns>
        public static stt::Task<BillingSetupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BillingSetupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BillingSetupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="BillingSetupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BillingSetupServiceClient"/>.</returns>
        public static BillingSetupServiceClient Create() => new BillingSetupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BillingSetupServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BillingSetupServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BillingSetupServiceClient"/>.</returns>
        internal static BillingSetupServiceClient Create(grpccore::CallInvoker callInvoker, BillingSetupServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BillingSetupService.BillingSetupServiceClient grpcClient = new BillingSetupService.BillingSetupServiceClient(callInvoker);
            return new BillingSetupServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BillingSetupService client</summary>
        public virtual BillingSetupService.BillingSetupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BillingSetupError]()
        /// [DateError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBillingSetupResponse MutateBillingSetup(MutateBillingSetupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BillingSetupError]()
        /// [DateError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBillingSetupResponse> MutateBillingSetupAsync(MutateBillingSetupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BillingSetupError]()
        /// [DateError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBillingSetupResponse> MutateBillingSetupAsync(MutateBillingSetupRequest request, st::CancellationToken cancellationToken) =>
            MutateBillingSetupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BillingSetupError]()
        /// [DateError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. Id of the customer to apply the billing setup mutate operation
        /// to.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBillingSetupResponse MutateBillingSetup(string customerId, BillingSetupOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateBillingSetup(new MutateBillingSetupRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BillingSetupError]()
        /// [DateError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. Id of the customer to apply the billing setup mutate operation
        /// to.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBillingSetupResponse> MutateBillingSetupAsync(string customerId, BillingSetupOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateBillingSetupAsync(new MutateBillingSetupRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BillingSetupError]()
        /// [DateError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. Id of the customer to apply the billing setup mutate operation
        /// to.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBillingSetupResponse> MutateBillingSetupAsync(string customerId, BillingSetupOperation operation, st::CancellationToken cancellationToken) =>
            MutateBillingSetupAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BillingSetupService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for designating the business entity responsible for accrued costs.
    /// 
    /// A billing setup is associated with a payments account.  Billing-related
    /// activity for all billing setups associated with a particular payments account
    /// will appear on a single invoice generated monthly.
    /// 
    /// Mutates:
    /// The REMOVE operation cancels a pending billing setup.
    /// The CREATE operation creates a new billing setup.
    /// </remarks>
    public sealed partial class BillingSetupServiceClientImpl : BillingSetupServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateBillingSetupRequest, MutateBillingSetupResponse> _callMutateBillingSetup;

        /// <summary>
        /// Constructs a client wrapper for the BillingSetupService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BillingSetupServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BillingSetupServiceClientImpl(BillingSetupService.BillingSetupServiceClient grpcClient, BillingSetupServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BillingSetupServiceSettings effectiveSettings = settings ?? BillingSetupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateBillingSetup = clientHelper.BuildApiCall<MutateBillingSetupRequest, MutateBillingSetupResponse>("MutateBillingSetup", grpcClient.MutateBillingSetupAsync, grpcClient.MutateBillingSetup, effectiveSettings.MutateBillingSetupSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateBillingSetup);
            Modify_MutateBillingSetupApiCall(ref _callMutateBillingSetup);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateBillingSetupApiCall(ref gaxgrpc::ApiCall<MutateBillingSetupRequest, MutateBillingSetupResponse> call);

        partial void OnConstruction(BillingSetupService.BillingSetupServiceClient grpcClient, BillingSetupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BillingSetupService client</summary>
        public override BillingSetupService.BillingSetupServiceClient GrpcClient { get; }

        partial void Modify_MutateBillingSetupRequest(ref MutateBillingSetupRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BillingSetupError]()
        /// [DateError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateBillingSetupResponse MutateBillingSetup(MutateBillingSetupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBillingSetupRequest(ref request, ref callSettings);
            return _callMutateBillingSetup.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BillingSetupError]()
        /// [DateError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateBillingSetupResponse> MutateBillingSetupAsync(MutateBillingSetupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBillingSetupRequest(ref request, ref callSettings);
            return _callMutateBillingSetup.Async(request, callSettings);
        }
    }
}

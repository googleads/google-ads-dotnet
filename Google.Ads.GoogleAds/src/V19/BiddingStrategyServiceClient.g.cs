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

namespace Google.Ads.GoogleAds.V19.Services
{
    /// <summary>Settings for <see cref="BiddingStrategyServiceClient"/> instances.</summary>
    public sealed partial class BiddingStrategyServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BiddingStrategyServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BiddingStrategyServiceSettings"/>.</returns>
        public static BiddingStrategyServiceSettings GetDefault() => new BiddingStrategyServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BiddingStrategyServiceSettings"/> object with default settings.
        /// </summary>
        public BiddingStrategyServiceSettings()
        {
        }

        private BiddingStrategyServiceSettings(BiddingStrategyServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateBiddingStrategiesSettings = existing.MutateBiddingStrategiesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BiddingStrategyServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BiddingStrategyServiceClient.MutateBiddingStrategies</c> and
        /// <c>BiddingStrategyServiceClient.MutateBiddingStrategiesAsync</c>.
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
        public gaxgrpc::CallSettings MutateBiddingStrategiesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BiddingStrategyServiceSettings"/> object.</returns>
        public BiddingStrategyServiceSettings Clone() => new BiddingStrategyServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BiddingStrategyServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class BiddingStrategyServiceClientBuilder : gaxgrpc::ClientBuilderBase<BiddingStrategyServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BiddingStrategyServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BiddingStrategyServiceClientBuilder() : base(BiddingStrategyServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BiddingStrategyServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BiddingStrategyServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BiddingStrategyServiceClient Build()
        {
            BiddingStrategyServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BiddingStrategyServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BiddingStrategyServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BiddingStrategyServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BiddingStrategyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BiddingStrategyServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BiddingStrategyServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BiddingStrategyServiceClient.ChannelPool;
    }

    /// <summary>BiddingStrategyService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage bidding strategies.
    /// </remarks>
    public abstract partial class BiddingStrategyServiceClient
    {
        /// <summary>
        /// The default endpoint for the BiddingStrategyService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default BiddingStrategyService scopes.</summary>
        /// <remarks>
        /// The default BiddingStrategyService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BiddingStrategyService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BiddingStrategyServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BiddingStrategyServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BiddingStrategyServiceClient"/>.</returns>
        public static stt::Task<BiddingStrategyServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BiddingStrategyServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BiddingStrategyServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="BiddingStrategyServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BiddingStrategyServiceClient"/>.</returns>
        public static BiddingStrategyServiceClient Create() => new BiddingStrategyServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BiddingStrategyServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BiddingStrategyServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BiddingStrategyServiceClient"/>.</returns>
        internal static BiddingStrategyServiceClient Create(grpccore::CallInvoker callInvoker, BiddingStrategyServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BiddingStrategyService.BiddingStrategyServiceClient grpcClient = new BiddingStrategyService.BiddingStrategyServiceClient(callInvoker);
            return new BiddingStrategyServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BiddingStrategyService client</summary>
        public virtual BiddingStrategyService.BiddingStrategyServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBiddingStrategiesResponse MutateBiddingStrategies(MutateBiddingStrategiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(MutateBiddingStrategiesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(MutateBiddingStrategiesRequest request, st::CancellationToken cancellationToken) =>
            MutateBiddingStrategiesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose bidding strategies are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual bidding
        /// strategies.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBiddingStrategiesResponse MutateBiddingStrategies(string customerId, scg::IEnumerable<BiddingStrategyOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateBiddingStrategies(new MutateBiddingStrategiesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose bidding strategies are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual bidding
        /// strategies.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(string customerId, scg::IEnumerable<BiddingStrategyOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateBiddingStrategiesAsync(new MutateBiddingStrategiesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose bidding strategies are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual bidding
        /// strategies.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(string customerId, scg::IEnumerable<BiddingStrategyOperation> operations, st::CancellationToken cancellationToken) =>
            MutateBiddingStrategiesAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BiddingStrategyService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage bidding strategies.
    /// </remarks>
    public sealed partial class BiddingStrategyServiceClientImpl : BiddingStrategyServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse> _callMutateBiddingStrategies;

        /// <summary>
        /// Constructs a client wrapper for the BiddingStrategyService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BiddingStrategyServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BiddingStrategyServiceClientImpl(BiddingStrategyService.BiddingStrategyServiceClient grpcClient, BiddingStrategyServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BiddingStrategyServiceSettings effectiveSettings = settings ?? BiddingStrategyServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateBiddingStrategies = clientHelper.BuildApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse>("MutateBiddingStrategies", grpcClient.MutateBiddingStrategiesAsync, grpcClient.MutateBiddingStrategies, effectiveSettings.MutateBiddingStrategiesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateBiddingStrategies);
            Modify_MutateBiddingStrategiesApiCall(ref _callMutateBiddingStrategies);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateBiddingStrategiesApiCall(ref gaxgrpc::ApiCall<MutateBiddingStrategiesRequest, MutateBiddingStrategiesResponse> call);

        partial void OnConstruction(BiddingStrategyService.BiddingStrategyServiceClient grpcClient, BiddingStrategyServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BiddingStrategyService client</summary>
        public override BiddingStrategyService.BiddingStrategyServiceClient GrpcClient { get; }

        partial void Modify_MutateBiddingStrategiesRequest(ref MutateBiddingStrategiesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateBiddingStrategiesResponse MutateBiddingStrategies(MutateBiddingStrategiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBiddingStrategiesRequest(ref request, ref callSettings);
            return _callMutateBiddingStrategies.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes bidding strategies. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateBiddingStrategiesResponse> MutateBiddingStrategiesAsync(MutateBiddingStrategiesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBiddingStrategiesRequest(ref request, ref callSettings);
            return _callMutateBiddingStrategies.Async(request, callSettings);
        }
    }
}

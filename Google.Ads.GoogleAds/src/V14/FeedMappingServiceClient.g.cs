// Copyright 2023 Google LLC
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

namespace Google.Ads.GoogleAds.V14.Services
{
    /// <summary>Settings for <see cref="FeedMappingServiceClient"/> instances.</summary>
    public sealed partial class FeedMappingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="FeedMappingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="FeedMappingServiceSettings"/>.</returns>
        public static FeedMappingServiceSettings GetDefault() => new FeedMappingServiceSettings();

        /// <summary>Constructs a new <see cref="FeedMappingServiceSettings"/> object with default settings.</summary>
        public FeedMappingServiceSettings()
        {
        }

        private FeedMappingServiceSettings(FeedMappingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateFeedMappingsSettings = existing.MutateFeedMappingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(FeedMappingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>FeedMappingServiceClient.MutateFeedMappings</c> and <c>FeedMappingServiceClient.MutateFeedMappingsAsync</c>
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
        public gaxgrpc::CallSettings MutateFeedMappingsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="FeedMappingServiceSettings"/> object.</returns>
        public FeedMappingServiceSettings Clone() => new FeedMappingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="FeedMappingServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class FeedMappingServiceClientBuilder : gaxgrpc::ClientBuilderBase<FeedMappingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public FeedMappingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public FeedMappingServiceClientBuilder() : base(FeedMappingServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref FeedMappingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<FeedMappingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override FeedMappingServiceClient Build()
        {
            FeedMappingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<FeedMappingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<FeedMappingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private FeedMappingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return FeedMappingServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<FeedMappingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return FeedMappingServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => FeedMappingServiceClient.ChannelPool;
    }

    /// <summary>FeedMappingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feed mappings.
    /// </remarks>
    public abstract partial class FeedMappingServiceClient
    {
        /// <summary>
        /// The default endpoint for the FeedMappingService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default FeedMappingService scopes.</summary>
        /// <remarks>
        /// The default FeedMappingService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(FeedMappingService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="FeedMappingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedMappingServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="FeedMappingServiceClient"/>.</returns>
        public static stt::Task<FeedMappingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new FeedMappingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="FeedMappingServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="FeedMappingServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="FeedMappingServiceClient"/>.</returns>
        public static FeedMappingServiceClient Create() => new FeedMappingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="FeedMappingServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="FeedMappingServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="FeedMappingServiceClient"/>.</returns>
        internal static FeedMappingServiceClient Create(grpccore::CallInvoker callInvoker, FeedMappingServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            FeedMappingService.FeedMappingServiceClient grpcClient = new FeedMappingService.FeedMappingServiceClient(callInvoker);
            return new FeedMappingServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC FeedMappingService client</summary>
        public virtual FeedMappingService.FeedMappingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes feed mappings. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FeedMappingError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotEmptyError]()
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
        public virtual MutateFeedMappingsResponse MutateFeedMappings(MutateFeedMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes feed mappings. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FeedMappingError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotEmptyError]()
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
        public virtual stt::Task<MutateFeedMappingsResponse> MutateFeedMappingsAsync(MutateFeedMappingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes feed mappings. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FeedMappingError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotEmptyError]()
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
        public virtual stt::Task<MutateFeedMappingsResponse> MutateFeedMappingsAsync(MutateFeedMappingsRequest request, st::CancellationToken cancellationToken) =>
            MutateFeedMappingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes feed mappings. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FeedMappingError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotEmptyError]()
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
        /// Required. The ID of the customer whose feed mappings are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed mappings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateFeedMappingsResponse MutateFeedMappings(string customerId, scg::IEnumerable<FeedMappingOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedMappings(new MutateFeedMappingsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes feed mappings. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FeedMappingError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotEmptyError]()
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
        /// Required. The ID of the customer whose feed mappings are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed mappings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedMappingsResponse> MutateFeedMappingsAsync(string customerId, scg::IEnumerable<FeedMappingOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateFeedMappingsAsync(new MutateFeedMappingsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes feed mappings. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FeedMappingError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotEmptyError]()
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
        /// Required. The ID of the customer whose feed mappings are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual feed mappings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateFeedMappingsResponse> MutateFeedMappingsAsync(string customerId, scg::IEnumerable<FeedMappingOperation> operations, st::CancellationToken cancellationToken) =>
            MutateFeedMappingsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>FeedMappingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage feed mappings.
    /// </remarks>
    public sealed partial class FeedMappingServiceClientImpl : FeedMappingServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateFeedMappingsRequest, MutateFeedMappingsResponse> _callMutateFeedMappings;

        /// <summary>
        /// Constructs a client wrapper for the FeedMappingService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="FeedMappingServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public FeedMappingServiceClientImpl(FeedMappingService.FeedMappingServiceClient grpcClient, FeedMappingServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            FeedMappingServiceSettings effectiveSettings = settings ?? FeedMappingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateFeedMappings = clientHelper.BuildApiCall<MutateFeedMappingsRequest, MutateFeedMappingsResponse>("MutateFeedMappings", grpcClient.MutateFeedMappingsAsync, grpcClient.MutateFeedMappings, effectiveSettings.MutateFeedMappingsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateFeedMappings);
            Modify_MutateFeedMappingsApiCall(ref _callMutateFeedMappings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateFeedMappingsApiCall(ref gaxgrpc::ApiCall<MutateFeedMappingsRequest, MutateFeedMappingsResponse> call);

        partial void OnConstruction(FeedMappingService.FeedMappingServiceClient grpcClient, FeedMappingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC FeedMappingService client</summary>
        public override FeedMappingService.FeedMappingServiceClient GrpcClient { get; }

        partial void Modify_MutateFeedMappingsRequest(ref MutateFeedMappingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates or removes feed mappings. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FeedMappingError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotEmptyError]()
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
        public override MutateFeedMappingsResponse MutateFeedMappings(MutateFeedMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedMappingsRequest(ref request, ref callSettings);
            return _callMutateFeedMappings.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes feed mappings. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FeedMappingError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NotEmptyError]()
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
        public override stt::Task<MutateFeedMappingsResponse> MutateFeedMappingsAsync(MutateFeedMappingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateFeedMappingsRequest(ref request, ref callSettings);
            return _callMutateFeedMappings.Async(request, callSettings);
        }
    }
}

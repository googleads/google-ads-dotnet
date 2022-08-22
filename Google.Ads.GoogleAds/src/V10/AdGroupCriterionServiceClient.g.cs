// Copyright 2022 Google LLC
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

namespace Google.Ads.GoogleAds.V10.Services
{
    /// <summary>Settings for <see cref="AdGroupCriterionServiceClient"/> instances.</summary>
    public sealed partial class AdGroupCriterionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupCriterionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupCriterionServiceSettings"/>.</returns>
        public static AdGroupCriterionServiceSettings GetDefault() => new AdGroupCriterionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupCriterionServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupCriterionServiceSettings()
        {
        }

        private AdGroupCriterionServiceSettings(AdGroupCriterionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAdGroupCriteriaSettings = existing.MutateAdGroupCriteriaSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupCriterionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupCriterionServiceClient.MutateAdGroupCriteria</c> and
        /// <c>AdGroupCriterionServiceClient.MutateAdGroupCriteriaAsync</c>.
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
        public gaxgrpc::CallSettings MutateAdGroupCriteriaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupCriterionServiceSettings"/> object.</returns>
        public AdGroupCriterionServiceSettings Clone() => new AdGroupCriterionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupCriterionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AdGroupCriterionServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupCriterionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupCriterionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdGroupCriterionServiceClientBuilder() : base(AdGroupCriterionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdGroupCriterionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupCriterionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupCriterionServiceClient Build()
        {
            AdGroupCriterionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupCriterionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupCriterionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupCriterionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupCriterionServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<AdGroupCriterionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupCriterionServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupCriterionServiceClient.ChannelPool;
    }

    /// <summary>AdGroupCriterionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group criteria.
    /// </remarks>
    public abstract partial class AdGroupCriterionServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupCriterionService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupCriterionService scopes.</summary>
        /// <remarks>
        /// The default AdGroupCriterionService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdGroupCriterionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupCriterionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupCriterionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupCriterionServiceClient"/>.</returns>
        public static stt::Task<AdGroupCriterionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupCriterionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupCriterionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupCriterionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupCriterionServiceClient"/>.</returns>
        public static AdGroupCriterionServiceClient Create() => new AdGroupCriterionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupCriterionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupCriterionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdGroupCriterionServiceClient"/>.</returns>
        internal static AdGroupCriterionServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupCriterionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupCriterionService.AdGroupCriterionServiceClient grpcClient = new AdGroupCriterionService.AdGroupCriterionServiceClient(callInvoker);
            return new AdGroupCriterionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdGroupCriterionService client</summary>
        public virtual AdGroupCriterionService.AdGroupCriterionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupCriterionError]()
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MultiplierError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupCriteriaResponse MutateAdGroupCriteria(MutateAdGroupCriteriaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupCriterionError]()
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MultiplierError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(MutateAdGroupCriteriaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupCriterionError]()
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MultiplierError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(MutateAdGroupCriteriaRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupCriteriaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupCriterionError]()
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MultiplierError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupCriteriaResponse MutateAdGroupCriteria(string customerId, scg::IEnumerable<AdGroupCriterionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupCriteria(new MutateAdGroupCriteriaRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupCriterionError]()
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MultiplierError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(string customerId, scg::IEnumerable<AdGroupCriterionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupCriteriaAsync(new MutateAdGroupCriteriaRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupCriterionError]()
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MultiplierError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(string customerId, scg::IEnumerable<AdGroupCriterionOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupCriteriaAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupCriterionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group criteria.
    /// </remarks>
    public sealed partial class AdGroupCriterionServiceClientImpl : AdGroupCriterionServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAdGroupCriteriaRequest, MutateAdGroupCriteriaResponse> _callMutateAdGroupCriteria;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupCriterionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdGroupCriterionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdGroupCriterionServiceClientImpl(AdGroupCriterionService.AdGroupCriterionServiceClient grpcClient, AdGroupCriterionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdGroupCriterionServiceSettings effectiveSettings = settings ?? AdGroupCriterionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateAdGroupCriteria = clientHelper.BuildApiCall<MutateAdGroupCriteriaRequest, MutateAdGroupCriteriaResponse>("MutateAdGroupCriteria", grpcClient.MutateAdGroupCriteriaAsync, grpcClient.MutateAdGroupCriteria, effectiveSettings.MutateAdGroupCriteriaSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupCriteria);
            Modify_MutateAdGroupCriteriaApiCall(ref _callMutateAdGroupCriteria);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAdGroupCriteriaApiCall(ref gaxgrpc::ApiCall<MutateAdGroupCriteriaRequest, MutateAdGroupCriteriaResponse> call);

        partial void OnConstruction(AdGroupCriterionService.AdGroupCriterionServiceClient grpcClient, AdGroupCriterionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupCriterionService client</summary>
        public override AdGroupCriterionService.AdGroupCriterionServiceClient GrpcClient { get; }

        partial void Modify_MutateAdGroupCriteriaRequest(ref MutateAdGroupCriteriaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupCriterionError]()
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MultiplierError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupCriteriaResponse MutateAdGroupCriteria(MutateAdGroupCriteriaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupCriteriaRequest(ref request, ref callSettings);
            return _callMutateAdGroupCriteria.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupCriterionError]()
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MultiplierError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(MutateAdGroupCriteriaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupCriteriaRequest(ref request, ref callSettings);
            return _callMutateAdGroupCriteria.Async(request, callSettings);
        }
    }
}

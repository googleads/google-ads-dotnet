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

namespace Google.Ads.GoogleAds.V20.Services
{
    /// <summary>Settings for <see cref="AdGroupBidModifierServiceClient"/> instances.</summary>
    public sealed partial class AdGroupBidModifierServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupBidModifierServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupBidModifierServiceSettings"/>.</returns>
        public static AdGroupBidModifierServiceSettings GetDefault() => new AdGroupBidModifierServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupBidModifierServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupBidModifierServiceSettings()
        {
        }

        private AdGroupBidModifierServiceSettings(AdGroupBidModifierServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAdGroupBidModifiersSettings = existing.MutateAdGroupBidModifiersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupBidModifierServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupBidModifierServiceClient.MutateAdGroupBidModifiers</c> and
        /// <c>AdGroupBidModifierServiceClient.MutateAdGroupBidModifiersAsync</c>.
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
        public gaxgrpc::CallSettings MutateAdGroupBidModifiersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupBidModifierServiceSettings"/> object.</returns>
        public AdGroupBidModifierServiceSettings Clone() => new AdGroupBidModifierServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupBidModifierServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AdGroupBidModifierServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupBidModifierServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupBidModifierServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdGroupBidModifierServiceClientBuilder() : base(AdGroupBidModifierServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdGroupBidModifierServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupBidModifierServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupBidModifierServiceClient Build()
        {
            AdGroupBidModifierServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupBidModifierServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupBidModifierServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupBidModifierServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupBidModifierServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdGroupBidModifierServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupBidModifierServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupBidModifierServiceClient.ChannelPool;
    }

    /// <summary>AdGroupBidModifierService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group bid modifiers.
    /// </remarks>
    public abstract partial class AdGroupBidModifierServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupBidModifierService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupBidModifierService scopes.</summary>
        /// <remarks>
        /// The default AdGroupBidModifierService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdGroupBidModifierService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupBidModifierServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupBidModifierServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupBidModifierServiceClient"/>.</returns>
        public static stt::Task<AdGroupBidModifierServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupBidModifierServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupBidModifierServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupBidModifierServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupBidModifierServiceClient"/>.</returns>
        public static AdGroupBidModifierServiceClient Create() => new AdGroupBidModifierServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupBidModifierServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupBidModifierServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdGroupBidModifierServiceClient"/>.</returns>
        internal static AdGroupBidModifierServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupBidModifierServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupBidModifierService.AdGroupBidModifierServiceClient grpcClient = new AdGroupBidModifierService.AdGroupBidModifierServiceClient(callInvoker);
            return new AdGroupBidModifierServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdGroupBidModifierService client</summary>
        public virtual AdGroupBidModifierService.AdGroupBidModifierServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad group bid modifiers.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupBidModifierError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupBidModifiersResponse MutateAdGroupBidModifiers(MutateAdGroupBidModifiersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad group bid modifiers.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupBidModifierError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupBidModifiersResponse> MutateAdGroupBidModifiersAsync(MutateAdGroupBidModifiersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad group bid modifiers.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupBidModifierError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupBidModifiersResponse> MutateAdGroupBidModifiersAsync(MutateAdGroupBidModifiersRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupBidModifiersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ad group bid modifiers.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupBidModifierError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group bid modifiers are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group bid
        /// modifiers.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupBidModifiersResponse MutateAdGroupBidModifiers(string customerId, scg::IEnumerable<AdGroupBidModifierOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupBidModifiers(new MutateAdGroupBidModifiersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad group bid modifiers.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupBidModifierError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group bid modifiers are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group bid
        /// modifiers.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupBidModifiersResponse> MutateAdGroupBidModifiersAsync(string customerId, scg::IEnumerable<AdGroupBidModifierOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupBidModifiersAsync(new MutateAdGroupBidModifiersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad group bid modifiers.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupBidModifierError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group bid modifiers are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group bid
        /// modifiers.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupBidModifiersResponse> MutateAdGroupBidModifiersAsync(string customerId, scg::IEnumerable<AdGroupBidModifierOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupBidModifiersAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupBidModifierService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group bid modifiers.
    /// </remarks>
    public sealed partial class AdGroupBidModifierServiceClientImpl : AdGroupBidModifierServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAdGroupBidModifiersRequest, MutateAdGroupBidModifiersResponse> _callMutateAdGroupBidModifiers;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupBidModifierService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdGroupBidModifierServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdGroupBidModifierServiceClientImpl(AdGroupBidModifierService.AdGroupBidModifierServiceClient grpcClient, AdGroupBidModifierServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdGroupBidModifierServiceSettings effectiveSettings = settings ?? AdGroupBidModifierServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateAdGroupBidModifiers = clientHelper.BuildApiCall<MutateAdGroupBidModifiersRequest, MutateAdGroupBidModifiersResponse>("MutateAdGroupBidModifiers", grpcClient.MutateAdGroupBidModifiersAsync, grpcClient.MutateAdGroupBidModifiers, effectiveSettings.MutateAdGroupBidModifiersSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupBidModifiers);
            Modify_MutateAdGroupBidModifiersApiCall(ref _callMutateAdGroupBidModifiers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAdGroupBidModifiersApiCall(ref gaxgrpc::ApiCall<MutateAdGroupBidModifiersRequest, MutateAdGroupBidModifiersResponse> call);

        partial void OnConstruction(AdGroupBidModifierService.AdGroupBidModifierServiceClient grpcClient, AdGroupBidModifierServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupBidModifierService client</summary>
        public override AdGroupBidModifierService.AdGroupBidModifierServiceClient GrpcClient { get; }

        partial void Modify_MutateAdGroupBidModifiersRequest(ref MutateAdGroupBidModifiersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes ad group bid modifiers.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupBidModifierError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupBidModifiersResponse MutateAdGroupBidModifiers(MutateAdGroupBidModifiersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupBidModifiersRequest(ref request, ref callSettings);
            return _callMutateAdGroupBidModifiers.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ad group bid modifiers.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdGroupBidModifierError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupBidModifiersResponse> MutateAdGroupBidModifiersAsync(MutateAdGroupBidModifiersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupBidModifiersRequest(ref request, ref callSettings);
            return _callMutateAdGroupBidModifiers.Async(request, callSettings);
        }
    }
}

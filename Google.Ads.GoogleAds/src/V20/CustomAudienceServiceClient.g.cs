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
    /// <summary>Settings for <see cref="CustomAudienceServiceClient"/> instances.</summary>
    public sealed partial class CustomAudienceServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomAudienceServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomAudienceServiceSettings"/>.</returns>
        public static CustomAudienceServiceSettings GetDefault() => new CustomAudienceServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomAudienceServiceSettings"/> object with default settings.
        /// </summary>
        public CustomAudienceServiceSettings()
        {
        }

        private CustomAudienceServiceSettings(CustomAudienceServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomAudiencesSettings = existing.MutateCustomAudiencesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomAudienceServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomAudienceServiceClient.MutateCustomAudiences</c> and
        /// <c>CustomAudienceServiceClient.MutateCustomAudiencesAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomAudiencesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomAudienceServiceSettings"/> object.</returns>
        public CustomAudienceServiceSettings Clone() => new CustomAudienceServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomAudienceServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomAudienceServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomAudienceServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomAudienceServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomAudienceServiceClientBuilder() : base(CustomAudienceServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomAudienceServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomAudienceServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomAudienceServiceClient Build()
        {
            CustomAudienceServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomAudienceServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomAudienceServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomAudienceServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomAudienceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomAudienceServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomAudienceServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomAudienceServiceClient.ChannelPool;
    }

    /// <summary>CustomAudienceService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage custom audiences.
    /// </remarks>
    public abstract partial class CustomAudienceServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomAudienceService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomAudienceService scopes.</summary>
        /// <remarks>
        /// The default CustomAudienceService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomAudienceService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomAudienceServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomAudienceServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomAudienceServiceClient"/>.</returns>
        public static stt::Task<CustomAudienceServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomAudienceServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomAudienceServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomAudienceServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomAudienceServiceClient"/>.</returns>
        public static CustomAudienceServiceClient Create() => new CustomAudienceServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomAudienceServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomAudienceServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomAudienceServiceClient"/>.</returns>
        internal static CustomAudienceServiceClient Create(grpccore::CallInvoker callInvoker, CustomAudienceServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomAudienceService.CustomAudienceServiceClient grpcClient = new CustomAudienceService.CustomAudienceServiceClient(callInvoker);
            return new CustomAudienceServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomAudienceService client</summary>
        public virtual CustomAudienceService.CustomAudienceServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates custom audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomAudienceError]()
        /// [CustomInterestError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomAudiencesResponse MutateCustomAudiences(MutateCustomAudiencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates custom audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomAudienceError]()
        /// [CustomInterestError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomAudiencesResponse> MutateCustomAudiencesAsync(MutateCustomAudiencesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates custom audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomAudienceError]()
        /// [CustomInterestError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomAudiencesResponse> MutateCustomAudiencesAsync(MutateCustomAudiencesRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomAudiencesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates custom audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomAudienceError]()
        /// [CustomInterestError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom audiences are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual custom audiences.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomAudiencesResponse MutateCustomAudiences(string customerId, scg::IEnumerable<CustomAudienceOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomAudiences(new MutateCustomAudiencesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates custom audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomAudienceError]()
        /// [CustomInterestError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom audiences are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual custom audiences.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomAudiencesResponse> MutateCustomAudiencesAsync(string customerId, scg::IEnumerable<CustomAudienceOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomAudiencesAsync(new MutateCustomAudiencesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates custom audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomAudienceError]()
        /// [CustomInterestError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom audiences are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual custom audiences.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomAudiencesResponse> MutateCustomAudiencesAsync(string customerId, scg::IEnumerable<CustomAudienceOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomAudiencesAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomAudienceService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage custom audiences.
    /// </remarks>
    public sealed partial class CustomAudienceServiceClientImpl : CustomAudienceServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomAudiencesRequest, MutateCustomAudiencesResponse> _callMutateCustomAudiences;

        /// <summary>
        /// Constructs a client wrapper for the CustomAudienceService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomAudienceServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomAudienceServiceClientImpl(CustomAudienceService.CustomAudienceServiceClient grpcClient, CustomAudienceServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomAudienceServiceSettings effectiveSettings = settings ?? CustomAudienceServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCustomAudiences = clientHelper.BuildApiCall<MutateCustomAudiencesRequest, MutateCustomAudiencesResponse>("MutateCustomAudiences", grpcClient.MutateCustomAudiencesAsync, grpcClient.MutateCustomAudiences, effectiveSettings.MutateCustomAudiencesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomAudiences);
            Modify_MutateCustomAudiencesApiCall(ref _callMutateCustomAudiences);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomAudiencesApiCall(ref gaxgrpc::ApiCall<MutateCustomAudiencesRequest, MutateCustomAudiencesResponse> call);

        partial void OnConstruction(CustomAudienceService.CustomAudienceServiceClient grpcClient, CustomAudienceServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomAudienceService client</summary>
        public override CustomAudienceService.CustomAudienceServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomAudiencesRequest(ref MutateCustomAudiencesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates or updates custom audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomAudienceError]()
        /// [CustomInterestError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomAudiencesResponse MutateCustomAudiences(MutateCustomAudiencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomAudiencesRequest(ref request, ref callSettings);
            return _callMutateCustomAudiences.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates custom audiences. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomAudienceError]()
        /// [CustomInterestError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomAudiencesResponse> MutateCustomAudiencesAsync(MutateCustomAudiencesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomAudiencesRequest(ref request, ref callSettings);
            return _callMutateCustomAudiences.Async(request, callSettings);
        }
    }
}

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

namespace Google.Ads.GoogleAds.V26.Services
{
    /// <summary>Settings for <see cref="CustomerBudgetNetworkSettingServiceClient"/> instances.</summary>
    public sealed partial class CustomerBudgetNetworkSettingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CustomerBudgetNetworkSettingServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="CustomerBudgetNetworkSettingServiceSettings"/>.</returns>
        public static CustomerBudgetNetworkSettingServiceSettings GetDefault() =>
            new CustomerBudgetNetworkSettingServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerBudgetNetworkSettingServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerBudgetNetworkSettingServiceSettings()
        {
        }

        private CustomerBudgetNetworkSettingServiceSettings(CustomerBudgetNetworkSettingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomerBudgetNetworkSettingSettings = existing.MutateCustomerBudgetNetworkSettingSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerBudgetNetworkSettingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerBudgetNetworkSettingServiceClient.MutateCustomerBudgetNetworkSetting</c> and
        /// <c>CustomerBudgetNetworkSettingServiceClient.MutateCustomerBudgetNetworkSettingAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomerBudgetNetworkSettingSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerBudgetNetworkSettingServiceSettings"/> object.</returns>
        public CustomerBudgetNetworkSettingServiceSettings Clone() => new CustomerBudgetNetworkSettingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerBudgetNetworkSettingServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class CustomerBudgetNetworkSettingServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerBudgetNetworkSettingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerBudgetNetworkSettingServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerBudgetNetworkSettingServiceClientBuilder() : base(CustomerBudgetNetworkSettingServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomerBudgetNetworkSettingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerBudgetNetworkSettingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerBudgetNetworkSettingServiceClient Build()
        {
            CustomerBudgetNetworkSettingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerBudgetNetworkSettingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerBudgetNetworkSettingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerBudgetNetworkSettingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerBudgetNetworkSettingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomerBudgetNetworkSettingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerBudgetNetworkSettingServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerBudgetNetworkSettingServiceClient.ChannelPool;
    }

    /// <summary>CustomerBudgetNetworkSettingService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer-level budget network settings.
    /// </remarks>
    public abstract partial class CustomerBudgetNetworkSettingServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerBudgetNetworkSettingService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerBudgetNetworkSettingService scopes.</summary>
        /// <remarks>
        /// The default CustomerBudgetNetworkSettingService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomerBudgetNetworkSettingService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerBudgetNetworkSettingServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerBudgetNetworkSettingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="CustomerBudgetNetworkSettingServiceClient"/>.
        /// </returns>
        public static stt::Task<CustomerBudgetNetworkSettingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerBudgetNetworkSettingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerBudgetNetworkSettingServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerBudgetNetworkSettingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerBudgetNetworkSettingServiceClient"/>.</returns>
        public static CustomerBudgetNetworkSettingServiceClient Create() =>
            new CustomerBudgetNetworkSettingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerBudgetNetworkSettingServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerBudgetNetworkSettingServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomerBudgetNetworkSettingServiceClient"/>.</returns>
        internal static CustomerBudgetNetworkSettingServiceClient Create(grpccore::CallInvoker callInvoker, CustomerBudgetNetworkSettingServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerBudgetNetworkSettingService.CustomerBudgetNetworkSettingServiceClient grpcClient = new CustomerBudgetNetworkSettingService.CustomerBudgetNetworkSettingServiceClient(callInvoker);
            return new CustomerBudgetNetworkSettingServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomerBudgetNetworkSettingService client</summary>
        public virtual CustomerBudgetNetworkSettingService.CustomerBudgetNetworkSettingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates the customer budget network setting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BudgetNetworkSettingError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerBudgetNetworkSettingResponse MutateCustomerBudgetNetworkSetting(MutateCustomerBudgetNetworkSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates the customer budget network setting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BudgetNetworkSettingError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerBudgetNetworkSettingResponse> MutateCustomerBudgetNetworkSettingAsync(MutateCustomerBudgetNetworkSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates the customer budget network setting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BudgetNetworkSettingError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerBudgetNetworkSettingResponse> MutateCustomerBudgetNetworkSettingAsync(MutateCustomerBudgetNetworkSettingRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerBudgetNetworkSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates the customer budget network setting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BudgetNetworkSettingError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer budget network setting is
        /// being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer budget network setting.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerBudgetNetworkSettingResponse MutateCustomerBudgetNetworkSetting(string customerId, CustomerBudgetNetworkSettingOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerBudgetNetworkSetting(new MutateCustomerBudgetNetworkSettingRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates or updates the customer budget network setting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BudgetNetworkSettingError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer budget network setting is
        /// being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer budget network setting.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerBudgetNetworkSettingResponse> MutateCustomerBudgetNetworkSettingAsync(string customerId, CustomerBudgetNetworkSettingOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerBudgetNetworkSettingAsync(new MutateCustomerBudgetNetworkSettingRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates or updates the customer budget network setting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BudgetNetworkSettingError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer budget network setting is
        /// being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer budget network setting.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerBudgetNetworkSettingResponse> MutateCustomerBudgetNetworkSettingAsync(string customerId, CustomerBudgetNetworkSettingOperation operation, st::CancellationToken cancellationToken) =>
            MutateCustomerBudgetNetworkSettingAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerBudgetNetworkSettingService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer-level budget network settings.
    /// </remarks>
    public sealed partial class CustomerBudgetNetworkSettingServiceClientImpl : CustomerBudgetNetworkSettingServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomerBudgetNetworkSettingRequest, MutateCustomerBudgetNetworkSettingResponse> _callMutateCustomerBudgetNetworkSetting;

        /// <summary>
        /// Constructs a client wrapper for the CustomerBudgetNetworkSettingService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerBudgetNetworkSettingServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomerBudgetNetworkSettingServiceClientImpl(CustomerBudgetNetworkSettingService.CustomerBudgetNetworkSettingServiceClient grpcClient, CustomerBudgetNetworkSettingServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomerBudgetNetworkSettingServiceSettings effectiveSettings = settings ?? CustomerBudgetNetworkSettingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCustomerBudgetNetworkSetting = clientHelper.BuildApiCall<MutateCustomerBudgetNetworkSettingRequest, MutateCustomerBudgetNetworkSettingResponse>("MutateCustomerBudgetNetworkSetting", grpcClient.MutateCustomerBudgetNetworkSettingAsync, grpcClient.MutateCustomerBudgetNetworkSetting, effectiveSettings.MutateCustomerBudgetNetworkSettingSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerBudgetNetworkSetting);
            Modify_MutateCustomerBudgetNetworkSettingApiCall(ref _callMutateCustomerBudgetNetworkSetting);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomerBudgetNetworkSettingApiCall(ref gaxgrpc::ApiCall<MutateCustomerBudgetNetworkSettingRequest, MutateCustomerBudgetNetworkSettingResponse> call);

        partial void OnConstruction(CustomerBudgetNetworkSettingService.CustomerBudgetNetworkSettingServiceClient grpcClient, CustomerBudgetNetworkSettingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerBudgetNetworkSettingService client</summary>
        public override CustomerBudgetNetworkSettingService.CustomerBudgetNetworkSettingServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomerBudgetNetworkSettingRequest(ref MutateCustomerBudgetNetworkSettingRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates or updates the customer budget network setting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BudgetNetworkSettingError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerBudgetNetworkSettingResponse MutateCustomerBudgetNetworkSetting(MutateCustomerBudgetNetworkSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerBudgetNetworkSettingRequest(ref request, ref callSettings);
            return _callMutateCustomerBudgetNetworkSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates the customer budget network setting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BudgetNetworkSettingError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerBudgetNetworkSettingResponse> MutateCustomerBudgetNetworkSettingAsync(MutateCustomerBudgetNetworkSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerBudgetNetworkSettingRequest(ref request, ref callSettings);
            return _callMutateCustomerBudgetNetworkSetting.Async(request, callSettings);
        }
    }
}

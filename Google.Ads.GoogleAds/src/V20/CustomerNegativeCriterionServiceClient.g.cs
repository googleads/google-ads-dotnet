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
    /// <summary>Settings for <see cref="CustomerNegativeCriterionServiceClient"/> instances.</summary>
    public sealed partial class CustomerNegativeCriterionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerNegativeCriterionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerNegativeCriterionServiceSettings"/>.</returns>
        public static CustomerNegativeCriterionServiceSettings GetDefault() => new CustomerNegativeCriterionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerNegativeCriterionServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerNegativeCriterionServiceSettings()
        {
        }

        private CustomerNegativeCriterionServiceSettings(CustomerNegativeCriterionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomerNegativeCriteriaSettings = existing.MutateCustomerNegativeCriteriaSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerNegativeCriterionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerNegativeCriterionServiceClient.MutateCustomerNegativeCriteria</c> and
        /// <c>CustomerNegativeCriterionServiceClient.MutateCustomerNegativeCriteriaAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomerNegativeCriteriaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerNegativeCriterionServiceSettings"/> object.</returns>
        public CustomerNegativeCriterionServiceSettings Clone() => new CustomerNegativeCriterionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerNegativeCriterionServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class CustomerNegativeCriterionServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerNegativeCriterionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerNegativeCriterionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerNegativeCriterionServiceClientBuilder() : base(CustomerNegativeCriterionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomerNegativeCriterionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerNegativeCriterionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerNegativeCriterionServiceClient Build()
        {
            CustomerNegativeCriterionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerNegativeCriterionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerNegativeCriterionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerNegativeCriterionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerNegativeCriterionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomerNegativeCriterionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerNegativeCriterionServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerNegativeCriterionServiceClient.ChannelPool;
    }

    /// <summary>CustomerNegativeCriterionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer negative criteria.
    /// </remarks>
    public abstract partial class CustomerNegativeCriterionServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerNegativeCriterionService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerNegativeCriterionService scopes.</summary>
        /// <remarks>
        /// The default CustomerNegativeCriterionService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomerNegativeCriterionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerNegativeCriterionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerNegativeCriterionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerNegativeCriterionServiceClient"/>.</returns>
        public static stt::Task<CustomerNegativeCriterionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerNegativeCriterionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerNegativeCriterionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerNegativeCriterionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerNegativeCriterionServiceClient"/>.</returns>
        public static CustomerNegativeCriterionServiceClient Create() =>
            new CustomerNegativeCriterionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerNegativeCriterionServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerNegativeCriterionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomerNegativeCriterionServiceClient"/>.</returns>
        internal static CustomerNegativeCriterionServiceClient Create(grpccore::CallInvoker callInvoker, CustomerNegativeCriterionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient grpcClient = new CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient(callInvoker);
            return new CustomerNegativeCriterionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomerNegativeCriterionService client</summary>
        public virtual CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CriterionError]()
        /// [DatabaseError]()
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
        public virtual MutateCustomerNegativeCriteriaResponse MutateCustomerNegativeCriteria(MutateCustomerNegativeCriteriaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CriterionError]()
        /// [DatabaseError]()
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
        public virtual stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(MutateCustomerNegativeCriteriaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CriterionError]()
        /// [DatabaseError]()
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
        public virtual stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(MutateCustomerNegativeCriteriaRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerNegativeCriteriaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerNegativeCriteriaResponse MutateCustomerNegativeCriteria(string customerId, scg::IEnumerable<CustomerNegativeCriterionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerNegativeCriteria(new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(string customerId, scg::IEnumerable<CustomerNegativeCriterionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerNegativeCriteriaAsync(new MutateCustomerNegativeCriteriaRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CriterionError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(string customerId, scg::IEnumerable<CustomerNegativeCriterionOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomerNegativeCriteriaAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerNegativeCriterionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer negative criteria.
    /// </remarks>
    public sealed partial class CustomerNegativeCriterionServiceClientImpl : CustomerNegativeCriterionServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomerNegativeCriteriaRequest, MutateCustomerNegativeCriteriaResponse> _callMutateCustomerNegativeCriteria;

        /// <summary>
        /// Constructs a client wrapper for the CustomerNegativeCriterionService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerNegativeCriterionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomerNegativeCriterionServiceClientImpl(CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient grpcClient, CustomerNegativeCriterionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomerNegativeCriterionServiceSettings effectiveSettings = settings ?? CustomerNegativeCriterionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCustomerNegativeCriteria = clientHelper.BuildApiCall<MutateCustomerNegativeCriteriaRequest, MutateCustomerNegativeCriteriaResponse>("MutateCustomerNegativeCriteria", grpcClient.MutateCustomerNegativeCriteriaAsync, grpcClient.MutateCustomerNegativeCriteria, effectiveSettings.MutateCustomerNegativeCriteriaSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerNegativeCriteria);
            Modify_MutateCustomerNegativeCriteriaApiCall(ref _callMutateCustomerNegativeCriteria);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomerNegativeCriteriaApiCall(ref gaxgrpc::ApiCall<MutateCustomerNegativeCriteriaRequest, MutateCustomerNegativeCriteriaResponse> call);

        partial void OnConstruction(CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient grpcClient, CustomerNegativeCriterionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerNegativeCriterionService client</summary>
        public override CustomerNegativeCriterionService.CustomerNegativeCriterionServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomerNegativeCriteriaRequest(ref MutateCustomerNegativeCriteriaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CriterionError]()
        /// [DatabaseError]()
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
        public override MutateCustomerNegativeCriteriaResponse MutateCustomerNegativeCriteria(MutateCustomerNegativeCriteriaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerNegativeCriteriaRequest(ref request, ref callSettings);
            return _callMutateCustomerNegativeCriteria.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes criteria. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CriterionError]()
        /// [DatabaseError]()
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
        public override stt::Task<MutateCustomerNegativeCriteriaResponse> MutateCustomerNegativeCriteriaAsync(MutateCustomerNegativeCriteriaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerNegativeCriteriaRequest(ref request, ref callSettings);
            return _callMutateCustomerNegativeCriteria.Async(request, callSettings);
        }
    }
}

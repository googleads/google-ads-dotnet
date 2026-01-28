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

namespace Google.Ads.GoogleAds.V23.Services
{
    /// <summary>Settings for <see cref="CustomerUserAccessServiceClient"/> instances.</summary>
    public sealed partial class CustomerUserAccessServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerUserAccessServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerUserAccessServiceSettings"/>.</returns>
        public static CustomerUserAccessServiceSettings GetDefault() => new CustomerUserAccessServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerUserAccessServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerUserAccessServiceSettings()
        {
        }

        private CustomerUserAccessServiceSettings(CustomerUserAccessServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomerUserAccessSettings = existing.MutateCustomerUserAccessSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerUserAccessServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerUserAccessServiceClient.MutateCustomerUserAccess</c> and
        /// <c>CustomerUserAccessServiceClient.MutateCustomerUserAccessAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomerUserAccessSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerUserAccessServiceSettings"/> object.</returns>
        public CustomerUserAccessServiceSettings Clone() => new CustomerUserAccessServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerUserAccessServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomerUserAccessServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerUserAccessServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerUserAccessServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerUserAccessServiceClientBuilder() : base(CustomerUserAccessServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomerUserAccessServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerUserAccessServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerUserAccessServiceClient Build()
        {
            CustomerUserAccessServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerUserAccessServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerUserAccessServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerUserAccessServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerUserAccessServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomerUserAccessServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerUserAccessServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerUserAccessServiceClient.ChannelPool;
    }

    /// <summary>CustomerUserAccessService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service manages the permissions of a user on a given customer.
    /// </remarks>
    public abstract partial class CustomerUserAccessServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerUserAccessService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerUserAccessService scopes.</summary>
        /// <remarks>
        /// The default CustomerUserAccessService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomerUserAccessService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerUserAccessServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerUserAccessServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerUserAccessServiceClient"/>.</returns>
        public static stt::Task<CustomerUserAccessServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerUserAccessServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerUserAccessServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerUserAccessServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerUserAccessServiceClient"/>.</returns>
        public static CustomerUserAccessServiceClient Create() => new CustomerUserAccessServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerUserAccessServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerUserAccessServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomerUserAccessServiceClient"/>.</returns>
        internal static CustomerUserAccessServiceClient Create(grpccore::CallInvoker callInvoker, CustomerUserAccessServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerUserAccessService.CustomerUserAccessServiceClient grpcClient = new CustomerUserAccessService.CustomerUserAccessServiceClient(callInvoker);
            return new CustomerUserAccessServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomerUserAccessService client</summary>
        public virtual CustomerUserAccessService.CustomerUserAccessServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Updates, removes permission of a user on a given customer. Operation
        /// statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerUserAccessResponse MutateCustomerUserAccess(MutateCustomerUserAccessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates, removes permission of a user on a given customer. Operation
        /// statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerUserAccessResponse> MutateCustomerUserAccessAsync(MutateCustomerUserAccessRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates, removes permission of a user on a given customer. Operation
        /// statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerUserAccessResponse> MutateCustomerUserAccessAsync(MutateCustomerUserAccessRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerUserAccessAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates, removes permission of a user on a given customer. Operation
        /// statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerUserAccessResponse MutateCustomerUserAccess(string customerId, CustomerUserAccessOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerUserAccess(new MutateCustomerUserAccessRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Updates, removes permission of a user on a given customer. Operation
        /// statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerUserAccessResponse> MutateCustomerUserAccessAsync(string customerId, CustomerUserAccessOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerUserAccessAsync(new MutateCustomerUserAccessRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Updates, removes permission of a user on a given customer. Operation
        /// statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the customer
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerUserAccessResponse> MutateCustomerUserAccessAsync(string customerId, CustomerUserAccessOperation operation, st::CancellationToken cancellationToken) =>
            MutateCustomerUserAccessAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerUserAccessService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service manages the permissions of a user on a given customer.
    /// </remarks>
    public sealed partial class CustomerUserAccessServiceClientImpl : CustomerUserAccessServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomerUserAccessRequest, MutateCustomerUserAccessResponse> _callMutateCustomerUserAccess;

        /// <summary>
        /// Constructs a client wrapper for the CustomerUserAccessService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerUserAccessServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomerUserAccessServiceClientImpl(CustomerUserAccessService.CustomerUserAccessServiceClient grpcClient, CustomerUserAccessServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomerUserAccessServiceSettings effectiveSettings = settings ?? CustomerUserAccessServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCustomerUserAccess = clientHelper.BuildApiCall<MutateCustomerUserAccessRequest, MutateCustomerUserAccessResponse>("MutateCustomerUserAccess", grpcClient.MutateCustomerUserAccessAsync, grpcClient.MutateCustomerUserAccess, effectiveSettings.MutateCustomerUserAccessSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerUserAccess);
            Modify_MutateCustomerUserAccessApiCall(ref _callMutateCustomerUserAccess);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomerUserAccessApiCall(ref gaxgrpc::ApiCall<MutateCustomerUserAccessRequest, MutateCustomerUserAccessResponse> call);

        partial void OnConstruction(CustomerUserAccessService.CustomerUserAccessServiceClient grpcClient, CustomerUserAccessServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerUserAccessService client</summary>
        public override CustomerUserAccessService.CustomerUserAccessServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomerUserAccessRequest(ref MutateCustomerUserAccessRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Updates, removes permission of a user on a given customer. Operation
        /// statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerUserAccessResponse MutateCustomerUserAccess(MutateCustomerUserAccessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerUserAccessRequest(ref request, ref callSettings);
            return _callMutateCustomerUserAccess.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates, removes permission of a user on a given customer. Operation
        /// statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerUserAccessError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerUserAccessResponse> MutateCustomerUserAccessAsync(MutateCustomerUserAccessRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerUserAccessRequest(ref request, ref callSettings);
            return _callMutateCustomerUserAccess.Async(request, callSettings);
        }
    }
}

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
    /// <summary>Settings for <see cref="CustomerLifecycleGoalServiceClient"/> instances.</summary>
    public sealed partial class CustomerLifecycleGoalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerLifecycleGoalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerLifecycleGoalServiceSettings"/>.</returns>
        public static CustomerLifecycleGoalServiceSettings GetDefault() => new CustomerLifecycleGoalServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerLifecycleGoalServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerLifecycleGoalServiceSettings()
        {
        }

        private CustomerLifecycleGoalServiceSettings(CustomerLifecycleGoalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ConfigureCustomerLifecycleGoalsSettings = existing.ConfigureCustomerLifecycleGoalsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerLifecycleGoalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerLifecycleGoalServiceClient.ConfigureCustomerLifecycleGoals</c> and
        /// <c>CustomerLifecycleGoalServiceClient.ConfigureCustomerLifecycleGoalsAsync</c>.
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
        public gaxgrpc::CallSettings ConfigureCustomerLifecycleGoalsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerLifecycleGoalServiceSettings"/> object.</returns>
        public CustomerLifecycleGoalServiceSettings Clone() => new CustomerLifecycleGoalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerLifecycleGoalServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class CustomerLifecycleGoalServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerLifecycleGoalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerLifecycleGoalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerLifecycleGoalServiceClientBuilder() : base(CustomerLifecycleGoalServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomerLifecycleGoalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerLifecycleGoalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerLifecycleGoalServiceClient Build()
        {
            CustomerLifecycleGoalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerLifecycleGoalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerLifecycleGoalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerLifecycleGoalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerLifecycleGoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomerLifecycleGoalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerLifecycleGoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerLifecycleGoalServiceClient.ChannelPool;
    }

    /// <summary>CustomerLifecycleGoalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to configure customer lifecycle goals.
    /// </remarks>
    public abstract partial class CustomerLifecycleGoalServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerLifecycleGoalService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerLifecycleGoalService scopes.</summary>
        /// <remarks>
        /// The default CustomerLifecycleGoalService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomerLifecycleGoalService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerLifecycleGoalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerLifecycleGoalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerLifecycleGoalServiceClient"/>.</returns>
        public static stt::Task<CustomerLifecycleGoalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerLifecycleGoalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerLifecycleGoalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerLifecycleGoalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerLifecycleGoalServiceClient"/>.</returns>
        public static CustomerLifecycleGoalServiceClient Create() => new CustomerLifecycleGoalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerLifecycleGoalServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerLifecycleGoalServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomerLifecycleGoalServiceClient"/>.</returns>
        internal static CustomerLifecycleGoalServiceClient Create(grpccore::CallInvoker callInvoker, CustomerLifecycleGoalServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerLifecycleGoalService.CustomerLifecycleGoalServiceClient grpcClient = new CustomerLifecycleGoalService.CustomerLifecycleGoalServiceClient(callInvoker);
            return new CustomerLifecycleGoalServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomerLifecycleGoalService client</summary>
        public virtual CustomerLifecycleGoalService.CustomerLifecycleGoalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Process the given customer lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConfigureCustomerLifecycleGoalsResponse ConfigureCustomerLifecycleGoals(ConfigureCustomerLifecycleGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Process the given customer lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConfigureCustomerLifecycleGoalsResponse> ConfigureCustomerLifecycleGoalsAsync(ConfigureCustomerLifecycleGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Process the given customer lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConfigureCustomerLifecycleGoalsResponse> ConfigureCustomerLifecycleGoalsAsync(ConfigureCustomerLifecycleGoalsRequest request, st::CancellationToken cancellationToken) =>
            ConfigureCustomerLifecycleGoalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Process the given customer lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform customer lifecycle goal update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ConfigureCustomerLifecycleGoalsResponse ConfigureCustomerLifecycleGoals(string customerId, CustomerLifecycleGoalOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureCustomerLifecycleGoals(new ConfigureCustomerLifecycleGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Process the given customer lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform customer lifecycle goal update.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConfigureCustomerLifecycleGoalsResponse> ConfigureCustomerLifecycleGoalsAsync(string customerId, CustomerLifecycleGoalOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            ConfigureCustomerLifecycleGoalsAsync(new ConfigureCustomerLifecycleGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Process the given customer lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform customer lifecycle goal update.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ConfigureCustomerLifecycleGoalsResponse> ConfigureCustomerLifecycleGoalsAsync(string customerId, CustomerLifecycleGoalOperation operation, st::CancellationToken cancellationToken) =>
            ConfigureCustomerLifecycleGoalsAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerLifecycleGoalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to configure customer lifecycle goals.
    /// </remarks>
    public sealed partial class CustomerLifecycleGoalServiceClientImpl : CustomerLifecycleGoalServiceClient
    {
        private readonly gaxgrpc::ApiCall<ConfigureCustomerLifecycleGoalsRequest, ConfigureCustomerLifecycleGoalsResponse> _callConfigureCustomerLifecycleGoals;

        /// <summary>
        /// Constructs a client wrapper for the CustomerLifecycleGoalService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerLifecycleGoalServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomerLifecycleGoalServiceClientImpl(CustomerLifecycleGoalService.CustomerLifecycleGoalServiceClient grpcClient, CustomerLifecycleGoalServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomerLifecycleGoalServiceSettings effectiveSettings = settings ?? CustomerLifecycleGoalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callConfigureCustomerLifecycleGoals = clientHelper.BuildApiCall<ConfigureCustomerLifecycleGoalsRequest, ConfigureCustomerLifecycleGoalsResponse>("ConfigureCustomerLifecycleGoals", grpcClient.ConfigureCustomerLifecycleGoalsAsync, grpcClient.ConfigureCustomerLifecycleGoals, effectiveSettings.ConfigureCustomerLifecycleGoalsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callConfigureCustomerLifecycleGoals);
            Modify_ConfigureCustomerLifecycleGoalsApiCall(ref _callConfigureCustomerLifecycleGoals);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ConfigureCustomerLifecycleGoalsApiCall(ref gaxgrpc::ApiCall<ConfigureCustomerLifecycleGoalsRequest, ConfigureCustomerLifecycleGoalsResponse> call);

        partial void OnConstruction(CustomerLifecycleGoalService.CustomerLifecycleGoalServiceClient grpcClient, CustomerLifecycleGoalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerLifecycleGoalService client</summary>
        public override CustomerLifecycleGoalService.CustomerLifecycleGoalServiceClient GrpcClient { get; }

        partial void Modify_ConfigureCustomerLifecycleGoalsRequest(ref ConfigureCustomerLifecycleGoalsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Process the given customer lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ConfigureCustomerLifecycleGoalsResponse ConfigureCustomerLifecycleGoals(ConfigureCustomerLifecycleGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfigureCustomerLifecycleGoalsRequest(ref request, ref callSettings);
            return _callConfigureCustomerLifecycleGoals.Sync(request, callSettings);
        }

        /// <summary>
        /// Process the given customer lifecycle configurations.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CustomerLifecycleGoalConfigError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ConfigureCustomerLifecycleGoalsResponse> ConfigureCustomerLifecycleGoalsAsync(ConfigureCustomerLifecycleGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ConfigureCustomerLifecycleGoalsRequest(ref request, ref callSettings);
            return _callConfigureCustomerLifecycleGoals.Async(request, callSettings);
        }
    }
}

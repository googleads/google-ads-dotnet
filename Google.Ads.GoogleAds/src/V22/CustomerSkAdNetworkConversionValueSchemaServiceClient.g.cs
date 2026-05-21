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

namespace Google.Ads.GoogleAds.V22.Services
{
    /// <summary>Settings for <see cref="CustomerSkAdNetworkConversionValueSchemaServiceClient"/> instances.</summary>
    public sealed partial class CustomerSkAdNetworkConversionValueSchemaServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CustomerSkAdNetworkConversionValueSchemaServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CustomerSkAdNetworkConversionValueSchemaServiceSettings"/>.
        /// </returns>
        public static CustomerSkAdNetworkConversionValueSchemaServiceSettings GetDefault() =>
            new CustomerSkAdNetworkConversionValueSchemaServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerSkAdNetworkConversionValueSchemaServiceSettings"/> object with default
        /// settings.
        /// </summary>
        public CustomerSkAdNetworkConversionValueSchemaServiceSettings()
        {
        }

        private CustomerSkAdNetworkConversionValueSchemaServiceSettings(CustomerSkAdNetworkConversionValueSchemaServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomerSkAdNetworkConversionValueSchemaSettings = existing.MutateCustomerSkAdNetworkConversionValueSchemaSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerSkAdNetworkConversionValueSchemaServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerSkAdNetworkConversionValueSchemaServiceClient.MutateCustomerSkAdNetworkConversionValueSchema</c>
        /// and
        /// <c>CustomerSkAdNetworkConversionValueSchemaServiceClient.MutateCustomerSkAdNetworkConversionValueSchemaAsync</c>
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
        public gaxgrpc::CallSettings MutateCustomerSkAdNetworkConversionValueSchemaSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>
        /// A deep clone of this <see cref="CustomerSkAdNetworkConversionValueSchemaServiceSettings"/> object.
        /// </returns>
        public CustomerSkAdNetworkConversionValueSchemaServiceSettings Clone() =>
            new CustomerSkAdNetworkConversionValueSchemaServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerSkAdNetworkConversionValueSchemaServiceClient"/> to provide simple
    /// configuration of credentials, endpoint etc.
    /// </summary>
    internal sealed partial class CustomerSkAdNetworkConversionValueSchemaServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerSkAdNetworkConversionValueSchemaServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerSkAdNetworkConversionValueSchemaServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerSkAdNetworkConversionValueSchemaServiceClientBuilder() : base(CustomerSkAdNetworkConversionValueSchemaServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomerSkAdNetworkConversionValueSchemaServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerSkAdNetworkConversionValueSchemaServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerSkAdNetworkConversionValueSchemaServiceClient Build()
        {
            CustomerSkAdNetworkConversionValueSchemaServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerSkAdNetworkConversionValueSchemaServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerSkAdNetworkConversionValueSchemaServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerSkAdNetworkConversionValueSchemaServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerSkAdNetworkConversionValueSchemaServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomerSkAdNetworkConversionValueSchemaServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerSkAdNetworkConversionValueSchemaServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() =>
            CustomerSkAdNetworkConversionValueSchemaServiceClient.ChannelPool;
    }

    /// <summary>CustomerSkAdNetworkConversionValueSchemaService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage CustomerSkAdNetworkConversionValueSchema.
    /// </remarks>
    public abstract partial class CustomerSkAdNetworkConversionValueSchemaServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerSkAdNetworkConversionValueSchemaService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerSkAdNetworkConversionValueSchemaService scopes.</summary>
        /// <remarks>
        /// The default CustomerSkAdNetworkConversionValueSchemaService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomerSkAdNetworkConversionValueSchemaService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerSkAdNetworkConversionValueSchemaServiceClient"/> using the
        /// default credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerSkAdNetworkConversionValueSchemaServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="CustomerSkAdNetworkConversionValueSchemaServiceClient"/>.
        /// </returns>
        public static stt::Task<CustomerSkAdNetworkConversionValueSchemaServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerSkAdNetworkConversionValueSchemaServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerSkAdNetworkConversionValueSchemaServiceClient"/> using the
        /// default credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerSkAdNetworkConversionValueSchemaServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerSkAdNetworkConversionValueSchemaServiceClient"/>.</returns>
        public static CustomerSkAdNetworkConversionValueSchemaServiceClient Create() =>
            new CustomerSkAdNetworkConversionValueSchemaServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerSkAdNetworkConversionValueSchemaServiceClient"/> which uses the specified call
        /// invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">
        /// Optional <see cref="CustomerSkAdNetworkConversionValueSchemaServiceSettings"/>.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomerSkAdNetworkConversionValueSchemaServiceClient"/>.</returns>
        internal static CustomerSkAdNetworkConversionValueSchemaServiceClient Create(grpccore::CallInvoker callInvoker, CustomerSkAdNetworkConversionValueSchemaServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerSkAdNetworkConversionValueSchemaService.CustomerSkAdNetworkConversionValueSchemaServiceClient grpcClient = new CustomerSkAdNetworkConversionValueSchemaService.CustomerSkAdNetworkConversionValueSchemaServiceClient(callInvoker);
            return new CustomerSkAdNetworkConversionValueSchemaServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomerSkAdNetworkConversionValueSchemaService client</summary>
        public virtual CustomerSkAdNetworkConversionValueSchemaService.CustomerSkAdNetworkConversionValueSchemaServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates the CustomerSkAdNetworkConversionValueSchema.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerSkAdNetworkConversionValueSchemaResponse MutateCustomerSkAdNetworkConversionValueSchema(MutateCustomerSkAdNetworkConversionValueSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates the CustomerSkAdNetworkConversionValueSchema.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerSkAdNetworkConversionValueSchemaResponse> MutateCustomerSkAdNetworkConversionValueSchemaAsync(MutateCustomerSkAdNetworkConversionValueSchemaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates the CustomerSkAdNetworkConversionValueSchema.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerSkAdNetworkConversionValueSchemaResponse> MutateCustomerSkAdNetworkConversionValueSchemaAsync(MutateCustomerSkAdNetworkConversionValueSchemaRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerSkAdNetworkConversionValueSchemaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>
    /// CustomerSkAdNetworkConversionValueSchemaService client wrapper implementation, for convenient use.
    /// </summary>
    /// <remarks>
    /// Service to manage CustomerSkAdNetworkConversionValueSchema.
    /// </remarks>
    public sealed partial class CustomerSkAdNetworkConversionValueSchemaServiceClientImpl : CustomerSkAdNetworkConversionValueSchemaServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomerSkAdNetworkConversionValueSchemaRequest, MutateCustomerSkAdNetworkConversionValueSchemaResponse> _callMutateCustomerSkAdNetworkConversionValueSchema;

        /// <summary>
        /// Constructs a client wrapper for the CustomerSkAdNetworkConversionValueSchemaService service, with the
        /// specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerSkAdNetworkConversionValueSchemaServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomerSkAdNetworkConversionValueSchemaServiceClientImpl(CustomerSkAdNetworkConversionValueSchemaService.CustomerSkAdNetworkConversionValueSchemaServiceClient grpcClient, CustomerSkAdNetworkConversionValueSchemaServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomerSkAdNetworkConversionValueSchemaServiceSettings effectiveSettings = settings ?? CustomerSkAdNetworkConversionValueSchemaServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCustomerSkAdNetworkConversionValueSchema = clientHelper.BuildApiCall<MutateCustomerSkAdNetworkConversionValueSchemaRequest, MutateCustomerSkAdNetworkConversionValueSchemaResponse>("MutateCustomerSkAdNetworkConversionValueSchema", grpcClient.MutateCustomerSkAdNetworkConversionValueSchemaAsync, grpcClient.MutateCustomerSkAdNetworkConversionValueSchema, effectiveSettings.MutateCustomerSkAdNetworkConversionValueSchemaSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerSkAdNetworkConversionValueSchema);
            Modify_MutateCustomerSkAdNetworkConversionValueSchemaApiCall(ref _callMutateCustomerSkAdNetworkConversionValueSchema);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomerSkAdNetworkConversionValueSchemaApiCall(ref gaxgrpc::ApiCall<MutateCustomerSkAdNetworkConversionValueSchemaRequest, MutateCustomerSkAdNetworkConversionValueSchemaResponse> call);

        partial void OnConstruction(CustomerSkAdNetworkConversionValueSchemaService.CustomerSkAdNetworkConversionValueSchemaServiceClient grpcClient, CustomerSkAdNetworkConversionValueSchemaServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerSkAdNetworkConversionValueSchemaService client</summary>
        public override CustomerSkAdNetworkConversionValueSchemaService.CustomerSkAdNetworkConversionValueSchemaServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomerSkAdNetworkConversionValueSchemaRequest(ref MutateCustomerSkAdNetworkConversionValueSchemaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates or updates the CustomerSkAdNetworkConversionValueSchema.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerSkAdNetworkConversionValueSchemaResponse MutateCustomerSkAdNetworkConversionValueSchema(MutateCustomerSkAdNetworkConversionValueSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerSkAdNetworkConversionValueSchemaRequest(ref request, ref callSettings);
            return _callMutateCustomerSkAdNetworkConversionValueSchema.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates the CustomerSkAdNetworkConversionValueSchema.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerSkAdNetworkConversionValueSchemaResponse> MutateCustomerSkAdNetworkConversionValueSchemaAsync(MutateCustomerSkAdNetworkConversionValueSchemaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerSkAdNetworkConversionValueSchemaRequest(ref request, ref callSettings);
            return _callMutateCustomerSkAdNetworkConversionValueSchema.Async(request, callSettings);
        }
    }
}

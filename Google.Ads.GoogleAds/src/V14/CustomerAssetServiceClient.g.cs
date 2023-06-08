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
    /// <summary>Settings for <see cref="CustomerAssetServiceClient"/> instances.</summary>
    public sealed partial class CustomerAssetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerAssetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerAssetServiceSettings"/>.</returns>
        public static CustomerAssetServiceSettings GetDefault() => new CustomerAssetServiceSettings();

        /// <summary>Constructs a new <see cref="CustomerAssetServiceSettings"/> object with default settings.</summary>
        public CustomerAssetServiceSettings()
        {
        }

        private CustomerAssetServiceSettings(CustomerAssetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomerAssetsSettings = existing.MutateCustomerAssetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerAssetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerAssetServiceClient.MutateCustomerAssets</c> and
        /// <c>CustomerAssetServiceClient.MutateCustomerAssetsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomerAssetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerAssetServiceSettings"/> object.</returns>
        public CustomerAssetServiceSettings Clone() => new CustomerAssetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerAssetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomerAssetServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerAssetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerAssetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerAssetServiceClientBuilder() : base(CustomerAssetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomerAssetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerAssetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerAssetServiceClient Build()
        {
            CustomerAssetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerAssetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerAssetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerAssetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerAssetServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<CustomerAssetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerAssetServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerAssetServiceClient.ChannelPool;
    }

    /// <summary>CustomerAssetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer assets.
    /// </remarks>
    public abstract partial class CustomerAssetServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerAssetService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerAssetService scopes.</summary>
        /// <remarks>
        /// The default CustomerAssetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomerAssetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerAssetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerAssetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerAssetServiceClient"/>.</returns>
        public static stt::Task<CustomerAssetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerAssetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerAssetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerAssetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerAssetServiceClient"/>.</returns>
        public static CustomerAssetServiceClient Create() => new CustomerAssetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerAssetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerAssetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomerAssetServiceClient"/>.</returns>
        internal static CustomerAssetServiceClient Create(grpccore::CallInvoker callInvoker, CustomerAssetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerAssetService.CustomerAssetServiceClient grpcClient = new CustomerAssetService.CustomerAssetServiceClient(callInvoker);
            return new CustomerAssetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomerAssetService client</summary>
        public virtual CustomerAssetService.CustomerAssetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes customer assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public virtual MutateCustomerAssetsResponse MutateCustomerAssets(MutateCustomerAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes customer assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public virtual stt::Task<MutateCustomerAssetsResponse> MutateCustomerAssetsAsync(MutateCustomerAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes customer assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public virtual stt::Task<MutateCustomerAssetsResponse> MutateCustomerAssetsAsync(MutateCustomerAssetsRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes customer assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer assets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerAssetsResponse MutateCustomerAssets(string customerId, scg::IEnumerable<CustomerAssetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerAssets(new MutateCustomerAssetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes customer assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer assets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerAssetsResponse> MutateCustomerAssetsAsync(string customerId, scg::IEnumerable<CustomerAssetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerAssetsAsync(new MutateCustomerAssetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes customer assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer assets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer assets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerAssetsResponse> MutateCustomerAssetsAsync(string customerId, scg::IEnumerable<CustomerAssetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomerAssetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerAssetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer assets.
    /// </remarks>
    public sealed partial class CustomerAssetServiceClientImpl : CustomerAssetServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomerAssetsRequest, MutateCustomerAssetsResponse> _callMutateCustomerAssets;

        /// <summary>
        /// Constructs a client wrapper for the CustomerAssetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomerAssetServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomerAssetServiceClientImpl(CustomerAssetService.CustomerAssetServiceClient grpcClient, CustomerAssetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomerAssetServiceSettings effectiveSettings = settings ?? CustomerAssetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateCustomerAssets = clientHelper.BuildApiCall<MutateCustomerAssetsRequest, MutateCustomerAssetsResponse>("MutateCustomerAssets", grpcClient.MutateCustomerAssetsAsync, grpcClient.MutateCustomerAssets, effectiveSettings.MutateCustomerAssetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerAssets);
            Modify_MutateCustomerAssetsApiCall(ref _callMutateCustomerAssets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomerAssetsApiCall(ref gaxgrpc::ApiCall<MutateCustomerAssetsRequest, MutateCustomerAssetsResponse> call);

        partial void OnConstruction(CustomerAssetService.CustomerAssetServiceClient grpcClient, CustomerAssetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerAssetService client</summary>
        public override CustomerAssetService.CustomerAssetServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomerAssetsRequest(ref MutateCustomerAssetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes customer assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public override MutateCustomerAssetsResponse MutateCustomerAssets(MutateCustomerAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerAssetsRequest(ref request, ref callSettings);
            return _callMutateCustomerAssets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes customer assets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public override stt::Task<MutateCustomerAssetsResponse> MutateCustomerAssetsAsync(MutateCustomerAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerAssetsRequest(ref request, ref callSettings);
            return _callMutateCustomerAssets.Async(request, callSettings);
        }
    }
}

// Copyright 2024 Google LLC
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

namespace Google.Ads.GoogleAds.V16.Services
{
    /// <summary>Settings for <see cref="CustomerAssetSetServiceClient"/> instances.</summary>
    public sealed partial class CustomerAssetSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerAssetSetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerAssetSetServiceSettings"/>.</returns>
        public static CustomerAssetSetServiceSettings GetDefault() => new CustomerAssetSetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerAssetSetServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerAssetSetServiceSettings()
        {
        }

        private CustomerAssetSetServiceSettings(CustomerAssetSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomerAssetSetsSettings = existing.MutateCustomerAssetSetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerAssetSetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerAssetSetServiceClient.MutateCustomerAssetSets</c> and
        /// <c>CustomerAssetSetServiceClient.MutateCustomerAssetSetsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomerAssetSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerAssetSetServiceSettings"/> object.</returns>
        public CustomerAssetSetServiceSettings Clone() => new CustomerAssetSetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerAssetSetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomerAssetSetServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerAssetSetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerAssetSetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerAssetSetServiceClientBuilder() : base(CustomerAssetSetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomerAssetSetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerAssetSetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerAssetSetServiceClient Build()
        {
            CustomerAssetSetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerAssetSetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerAssetSetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerAssetSetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerAssetSetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomerAssetSetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerAssetSetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerAssetSetServiceClient.ChannelPool;
    }

    /// <summary>CustomerAssetSetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer asset set
    /// </remarks>
    public abstract partial class CustomerAssetSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerAssetSetService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerAssetSetService scopes.</summary>
        /// <remarks>
        /// The default CustomerAssetSetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomerAssetSetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerAssetSetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerAssetSetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerAssetSetServiceClient"/>.</returns>
        public static stt::Task<CustomerAssetSetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerAssetSetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerAssetSetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerAssetSetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerAssetSetServiceClient"/>.</returns>
        public static CustomerAssetSetServiceClient Create() => new CustomerAssetSetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerAssetSetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerAssetSetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomerAssetSetServiceClient"/>.</returns>
        internal static CustomerAssetSetServiceClient Create(grpccore::CallInvoker callInvoker, CustomerAssetSetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerAssetSetService.CustomerAssetSetServiceClient grpcClient = new CustomerAssetSetService.CustomerAssetSetServiceClient(callInvoker);
            return new CustomerAssetSetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomerAssetSetService client</summary>
        public virtual CustomerAssetSetService.CustomerAssetSetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, or removes customer asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerAssetSetsResponse MutateCustomerAssetSets(MutateCustomerAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, or removes customer asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerAssetSetsResponse> MutateCustomerAssetSetsAsync(MutateCustomerAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, or removes customer asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerAssetSetsResponse> MutateCustomerAssetSetsAsync(MutateCustomerAssetSetsRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerAssetSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, or removes customer asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer asset sets are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer asset
        /// sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerAssetSetsResponse MutateCustomerAssetSets(string customerId, scg::IEnumerable<CustomerAssetSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerAssetSets(new MutateCustomerAssetSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, or removes customer asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer asset sets are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer asset
        /// sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerAssetSetsResponse> MutateCustomerAssetSetsAsync(string customerId, scg::IEnumerable<CustomerAssetSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerAssetSetsAsync(new MutateCustomerAssetSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, or removes customer asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer asset sets are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer asset
        /// sets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerAssetSetsResponse> MutateCustomerAssetSetsAsync(string customerId, scg::IEnumerable<CustomerAssetSetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomerAssetSetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerAssetSetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer asset set
    /// </remarks>
    public sealed partial class CustomerAssetSetServiceClientImpl : CustomerAssetSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomerAssetSetsRequest, MutateCustomerAssetSetsResponse> _callMutateCustomerAssetSets;

        /// <summary>
        /// Constructs a client wrapper for the CustomerAssetSetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerAssetSetServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomerAssetSetServiceClientImpl(CustomerAssetSetService.CustomerAssetSetServiceClient grpcClient, CustomerAssetSetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomerAssetSetServiceSettings effectiveSettings = settings ?? CustomerAssetSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateCustomerAssetSets = clientHelper.BuildApiCall<MutateCustomerAssetSetsRequest, MutateCustomerAssetSetsResponse>("MutateCustomerAssetSets", grpcClient.MutateCustomerAssetSetsAsync, grpcClient.MutateCustomerAssetSets, effectiveSettings.MutateCustomerAssetSetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerAssetSets);
            Modify_MutateCustomerAssetSetsApiCall(ref _callMutateCustomerAssetSets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomerAssetSetsApiCall(ref gaxgrpc::ApiCall<MutateCustomerAssetSetsRequest, MutateCustomerAssetSetsResponse> call);

        partial void OnConstruction(CustomerAssetSetService.CustomerAssetSetServiceClient grpcClient, CustomerAssetSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerAssetSetService client</summary>
        public override CustomerAssetSetService.CustomerAssetSetServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomerAssetSetsRequest(ref MutateCustomerAssetSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, or removes customer asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerAssetSetsResponse MutateCustomerAssetSets(MutateCustomerAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerAssetSetsRequest(ref request, ref callSettings);
            return _callMutateCustomerAssetSets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, or removes customer asset sets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerAssetSetsResponse> MutateCustomerAssetSetsAsync(MutateCustomerAssetSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerAssetSetsRequest(ref request, ref callSettings);
            return _callMutateCustomerAssetSets.Async(request, callSettings);
        }
    }
}

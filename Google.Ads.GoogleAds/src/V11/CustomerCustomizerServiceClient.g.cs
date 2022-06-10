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

using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V11.Services
{
    /// <summary>Settings for <see cref="CustomerCustomizerServiceClient"/> instances.</summary>
    public sealed partial class CustomerCustomizerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerCustomizerServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerCustomizerServiceSettings"/>.</returns>
        public static CustomerCustomizerServiceSettings GetDefault() => new CustomerCustomizerServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerCustomizerServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerCustomizerServiceSettings()
        {
        }

        private CustomerCustomizerServiceSettings(CustomerCustomizerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomerCustomizersSettings = existing.MutateCustomerCustomizersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerCustomizerServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerCustomizerServiceClient.MutateCustomerCustomizers</c> and
        /// <c>CustomerCustomizerServiceClient.MutateCustomerCustomizersAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomerCustomizersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerCustomizerServiceSettings"/> object.</returns>
        public CustomerCustomizerServiceSettings Clone() => new CustomerCustomizerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerCustomizerServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomerCustomizerServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerCustomizerServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerCustomizerServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerCustomizerServiceClientBuilder()
        {
            UseJwtAccessWithScopes = CustomerCustomizerServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref CustomerCustomizerServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerCustomizerServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerCustomizerServiceClient Build()
        {
            CustomerCustomizerServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerCustomizerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerCustomizerServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerCustomizerServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerCustomizerServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CustomerCustomizerServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerCustomizerServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CustomerCustomizerServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CustomerCustomizerServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerCustomizerServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CustomerCustomizerService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer customizer
    /// </remarks>
    public abstract partial class CustomerCustomizerServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerCustomizerService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerCustomizerService scopes.</summary>
        /// <remarks>
        /// The default CustomerCustomizerService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerCustomizerServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerCustomizerServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerCustomizerServiceClient"/>.</returns>
        public static stt::Task<CustomerCustomizerServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerCustomizerServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerCustomizerServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerCustomizerServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerCustomizerServiceClient"/>.</returns>
        public static CustomerCustomizerServiceClient Create() => new CustomerCustomizerServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerCustomizerServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerCustomizerServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerCustomizerServiceClient"/>.</returns>
        internal static CustomerCustomizerServiceClient Create(grpccore::CallInvoker callInvoker, CustomerCustomizerServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerCustomizerService.CustomerCustomizerServiceClient grpcClient = new CustomerCustomizerService.CustomerCustomizerServiceClient(callInvoker);
            return new CustomerCustomizerServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CustomerCustomizerService client</summary>
        public virtual CustomerCustomizerService.CustomerCustomizerServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes customer customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerCustomizersResponse MutateCustomerCustomizers(MutateCustomerCustomizersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes customer customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerCustomizersResponse> MutateCustomerCustomizersAsync(MutateCustomerCustomizersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes customer customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerCustomizersResponse> MutateCustomerCustomizersAsync(MutateCustomerCustomizersRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerCustomizersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes customer customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer customizers are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer customizers.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerCustomizersResponse MutateCustomerCustomizers(string customerId, scg::IEnumerable<CustomerCustomizerOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerCustomizers(new MutateCustomerCustomizersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes customer customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer customizers are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer customizers.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerCustomizersResponse> MutateCustomerCustomizersAsync(string customerId, scg::IEnumerable<CustomerCustomizerOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerCustomizersAsync(new MutateCustomerCustomizersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes customer customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer customizers are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer customizers.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerCustomizersResponse> MutateCustomerCustomizersAsync(string customerId, scg::IEnumerable<CustomerCustomizerOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomerCustomizersAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerCustomizerService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer customizer
    /// </remarks>
    public sealed partial class CustomerCustomizerServiceClientImpl : CustomerCustomizerServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomerCustomizersRequest, MutateCustomerCustomizersResponse> _callMutateCustomerCustomizers;

        /// <summary>
        /// Constructs a client wrapper for the CustomerCustomizerService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerCustomizerServiceSettings"/> used within this client.
        /// </param>
        public CustomerCustomizerServiceClientImpl(CustomerCustomizerService.CustomerCustomizerServiceClient grpcClient, CustomerCustomizerServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerCustomizerServiceSettings effectiveSettings = settings ?? CustomerCustomizerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callMutateCustomerCustomizers = clientHelper.BuildApiCall<MutateCustomerCustomizersRequest, MutateCustomerCustomizersResponse>(grpcClient.MutateCustomerCustomizersAsync, grpcClient.MutateCustomerCustomizers, effectiveSettings.MutateCustomerCustomizersSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerCustomizers);
            Modify_MutateCustomerCustomizersApiCall(ref _callMutateCustomerCustomizers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomerCustomizersApiCall(ref gaxgrpc::ApiCall<MutateCustomerCustomizersRequest, MutateCustomerCustomizersResponse> call);

        partial void OnConstruction(CustomerCustomizerService.CustomerCustomizerServiceClient grpcClient, CustomerCustomizerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerCustomizerService client</summary>
        public override CustomerCustomizerService.CustomerCustomizerServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomerCustomizersRequest(ref MutateCustomerCustomizersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes customer customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerCustomizersResponse MutateCustomerCustomizers(MutateCustomerCustomizersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerCustomizersRequest(ref request, ref callSettings);
            return _callMutateCustomerCustomizers.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes customer customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerCustomizersResponse> MutateCustomerCustomizersAsync(MutateCustomerCustomizersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerCustomizersRequest(ref request, ref callSettings);
            return _callMutateCustomerCustomizers.Async(request, callSettings);
        }
    }
}

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
    /// <summary>Settings for <see cref="PaymentsAccountServiceClient"/> instances.</summary>
    public sealed partial class PaymentsAccountServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="PaymentsAccountServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="PaymentsAccountServiceSettings"/>.</returns>
        public static PaymentsAccountServiceSettings GetDefault() => new PaymentsAccountServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="PaymentsAccountServiceSettings"/> object with default settings.
        /// </summary>
        public PaymentsAccountServiceSettings()
        {
        }

        private PaymentsAccountServiceSettings(PaymentsAccountServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListPaymentsAccountsSettings = existing.ListPaymentsAccountsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(PaymentsAccountServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>PaymentsAccountServiceClient.ListPaymentsAccounts</c> and
        /// <c>PaymentsAccountServiceClient.ListPaymentsAccountsAsync</c>.
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
        public gaxgrpc::CallSettings ListPaymentsAccountsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="PaymentsAccountServiceSettings"/> object.</returns>
        public PaymentsAccountServiceSettings Clone() => new PaymentsAccountServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="PaymentsAccountServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class PaymentsAccountServiceClientBuilder : gaxgrpc::ClientBuilderBase<PaymentsAccountServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public PaymentsAccountServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public PaymentsAccountServiceClientBuilder() : base(PaymentsAccountServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref PaymentsAccountServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<PaymentsAccountServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override PaymentsAccountServiceClient Build()
        {
            PaymentsAccountServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<PaymentsAccountServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<PaymentsAccountServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private PaymentsAccountServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return PaymentsAccountServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<PaymentsAccountServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return PaymentsAccountServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => PaymentsAccountServiceClient.ChannelPool;
    }

    /// <summary>PaymentsAccountService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to provide payments accounts that can be used to set up consolidated
    /// billing.
    /// </remarks>
    public abstract partial class PaymentsAccountServiceClient
    {
        /// <summary>
        /// The default endpoint for the PaymentsAccountService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default PaymentsAccountService scopes.</summary>
        /// <remarks>
        /// The default PaymentsAccountService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(PaymentsAccountService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="PaymentsAccountServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PaymentsAccountServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="PaymentsAccountServiceClient"/>.</returns>
        public static stt::Task<PaymentsAccountServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new PaymentsAccountServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="PaymentsAccountServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="PaymentsAccountServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="PaymentsAccountServiceClient"/>.</returns>
        public static PaymentsAccountServiceClient Create() => new PaymentsAccountServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="PaymentsAccountServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="PaymentsAccountServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="PaymentsAccountServiceClient"/>.</returns>
        internal static PaymentsAccountServiceClient Create(grpccore::CallInvoker callInvoker, PaymentsAccountServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            PaymentsAccountService.PaymentsAccountServiceClient grpcClient = new PaymentsAccountService.PaymentsAccountServiceClient(callInvoker);
            return new PaymentsAccountServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC PaymentsAccountService client</summary>
        public virtual PaymentsAccountService.PaymentsAccountServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all payments accounts associated with all managers
        /// between the login customer ID and specified serving customer in the
        /// hierarchy, inclusive.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PaymentsAccountError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPaymentsAccountsResponse ListPaymentsAccounts(ListPaymentsAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all payments accounts associated with all managers
        /// between the login customer ID and specified serving customer in the
        /// hierarchy, inclusive.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PaymentsAccountError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPaymentsAccountsResponse> ListPaymentsAccountsAsync(ListPaymentsAccountsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all payments accounts associated with all managers
        /// between the login customer ID and specified serving customer in the
        /// hierarchy, inclusive.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PaymentsAccountError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPaymentsAccountsResponse> ListPaymentsAccountsAsync(ListPaymentsAccountsRequest request, st::CancellationToken cancellationToken) =>
            ListPaymentsAccountsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all payments accounts associated with all managers
        /// between the login customer ID and specified serving customer in the
        /// hierarchy, inclusive.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PaymentsAccountError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer to apply the PaymentsAccount list
        /// operation to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPaymentsAccountsResponse ListPaymentsAccounts(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            ListPaymentsAccounts(new ListPaymentsAccountsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Returns all payments accounts associated with all managers
        /// between the login customer ID and specified serving customer in the
        /// hierarchy, inclusive.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PaymentsAccountError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer to apply the PaymentsAccount list
        /// operation to.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPaymentsAccountsResponse> ListPaymentsAccountsAsync(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            ListPaymentsAccountsAsync(new ListPaymentsAccountsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Returns all payments accounts associated with all managers
        /// between the login customer ID and specified serving customer in the
        /// hierarchy, inclusive.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PaymentsAccountError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer to apply the PaymentsAccount list
        /// operation to.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPaymentsAccountsResponse> ListPaymentsAccountsAsync(string customerId, st::CancellationToken cancellationToken) =>
            ListPaymentsAccountsAsync(customerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>PaymentsAccountService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to provide payments accounts that can be used to set up consolidated
    /// billing.
    /// </remarks>
    public sealed partial class PaymentsAccountServiceClientImpl : PaymentsAccountServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListPaymentsAccountsRequest, ListPaymentsAccountsResponse> _callListPaymentsAccounts;

        /// <summary>
        /// Constructs a client wrapper for the PaymentsAccountService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="PaymentsAccountServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public PaymentsAccountServiceClientImpl(PaymentsAccountService.PaymentsAccountServiceClient grpcClient, PaymentsAccountServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            PaymentsAccountServiceSettings effectiveSettings = settings ?? PaymentsAccountServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListPaymentsAccounts = clientHelper.BuildApiCall<ListPaymentsAccountsRequest, ListPaymentsAccountsResponse>("ListPaymentsAccounts", grpcClient.ListPaymentsAccountsAsync, grpcClient.ListPaymentsAccounts, effectiveSettings.ListPaymentsAccountsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callListPaymentsAccounts);
            Modify_ListPaymentsAccountsApiCall(ref _callListPaymentsAccounts);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListPaymentsAccountsApiCall(ref gaxgrpc::ApiCall<ListPaymentsAccountsRequest, ListPaymentsAccountsResponse> call);

        partial void OnConstruction(PaymentsAccountService.PaymentsAccountServiceClient grpcClient, PaymentsAccountServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC PaymentsAccountService client</summary>
        public override PaymentsAccountService.PaymentsAccountServiceClient GrpcClient { get; }

        partial void Modify_ListPaymentsAccountsRequest(ref ListPaymentsAccountsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns all payments accounts associated with all managers
        /// between the login customer ID and specified serving customer in the
        /// hierarchy, inclusive.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PaymentsAccountError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListPaymentsAccountsResponse ListPaymentsAccounts(ListPaymentsAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPaymentsAccountsRequest(ref request, ref callSettings);
            return _callListPaymentsAccounts.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns all payments accounts associated with all managers
        /// between the login customer ID and specified serving customer in the
        /// hierarchy, inclusive.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PaymentsAccountError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListPaymentsAccountsResponse> ListPaymentsAccountsAsync(ListPaymentsAccountsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPaymentsAccountsRequest(ref request, ref callSettings);
            return _callListPaymentsAccounts.Async(request, callSettings);
        }
    }
}

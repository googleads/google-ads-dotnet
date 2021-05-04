// Copyright 2021 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V7.Resources;
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

namespace Google.Ads.GoogleAds.V7.Services
{
    /// <summary>Settings for <see cref="CustomerLabelServiceClient"/> instances.</summary>
    public sealed partial class CustomerLabelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerLabelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerLabelServiceSettings"/>.</returns>
        public static CustomerLabelServiceSettings GetDefault() => new CustomerLabelServiceSettings();

        /// <summary>Constructs a new <see cref="CustomerLabelServiceSettings"/> object with default settings.</summary>
        public CustomerLabelServiceSettings()
        {
        }

        private CustomerLabelServiceSettings(CustomerLabelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerLabelSettings = existing.GetCustomerLabelSettings;
            MutateCustomerLabelsSettings = existing.MutateCustomerLabelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerLabelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerLabelServiceClient.GetCustomerLabel</c> and <c>CustomerLabelServiceClient.GetCustomerLabelAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomerLabelSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerLabelServiceClient.MutateCustomerLabels</c> and
        /// <c>CustomerLabelServiceClient.MutateCustomerLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCustomerLabelsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerLabelServiceSettings"/> object.</returns>
        public CustomerLabelServiceSettings Clone() => new CustomerLabelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerLabelServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomerLabelServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerLabelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerLabelServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CustomerLabelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerLabelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerLabelServiceClient Build()
        {
            CustomerLabelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerLabelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerLabelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerLabelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerLabelServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CustomerLabelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerLabelServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CustomerLabelServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CustomerLabelServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerLabelServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CustomerLabelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage labels on customers.
    /// </remarks>
    public abstract partial class CustomerLabelServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerLabelService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerLabelService scopes.</summary>
        /// <remarks>
        /// The default CustomerLabelService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerLabelServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerLabelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerLabelServiceClient"/>.</returns>
        public static stt::Task<CustomerLabelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerLabelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerLabelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerLabelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerLabelServiceClient"/>.</returns>
        public static CustomerLabelServiceClient Create() => new CustomerLabelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerLabelServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerLabelServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerLabelServiceClient"/>.</returns>
        internal static CustomerLabelServiceClient Create(grpccore::CallInvoker callInvoker, CustomerLabelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerLabelService.CustomerLabelServiceClient grpcClient = new CustomerLabelService.CustomerLabelServiceClient(callInvoker);
            return new CustomerLabelServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CustomerLabelService client</summary>
        public virtual CustomerLabelService.CustomerLabelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerLabel GetCustomerLabel(GetCustomerLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerLabel> GetCustomerLabelAsync(GetCustomerLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerLabel> GetCustomerLabelAsync(GetCustomerLabelRequest request, st::CancellationToken cancellationToken) =>
            GetCustomerLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer-label relationship to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerLabel GetCustomerLabel(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerLabel(new GetCustomerLabelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer-label relationship to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerLabel> GetCustomerLabelAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerLabelAsync(new GetCustomerLabelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer-label relationship to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerLabel> GetCustomerLabelAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerLabelAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer-label relationship to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerLabel GetCustomerLabel(gagvr::CustomerLabelName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerLabel(new GetCustomerLabelRequest
            {
                ResourceNameAsCustomerLabelName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer-label relationship to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerLabel> GetCustomerLabelAsync(gagvr::CustomerLabelName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerLabelAsync(new GetCustomerLabelRequest
            {
                ResourceNameAsCustomerLabelName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer-label relationship to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerLabel> GetCustomerLabelAsync(gagvr::CustomerLabelName resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerLabelAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes customer-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerLabelsResponse MutateCustomerLabels(MutateCustomerLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes customer-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerLabelsResponse> MutateCustomerLabelsAsync(MutateCustomerLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes customer-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerLabelsResponse> MutateCustomerLabelsAsync(MutateCustomerLabelsRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes customer-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose customer-label relationships are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on customer-label relationships.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerLabelsResponse MutateCustomerLabels(string customerId, scg::IEnumerable<CustomerLabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerLabels(new MutateCustomerLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates and removes customer-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose customer-label relationships are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on customer-label relationships.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerLabelsResponse> MutateCustomerLabelsAsync(string customerId, scg::IEnumerable<CustomerLabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerLabelsAsync(new MutateCustomerLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates and removes customer-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose customer-label relationships are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on customer-label relationships.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerLabelsResponse> MutateCustomerLabelsAsync(string customerId, scg::IEnumerable<CustomerLabelOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomerLabelsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerLabelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage labels on customers.
    /// </remarks>
    public sealed partial class CustomerLabelServiceClientImpl : CustomerLabelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerLabelRequest, gagvr::CustomerLabel> _callGetCustomerLabel;

        private readonly gaxgrpc::ApiCall<MutateCustomerLabelsRequest, MutateCustomerLabelsResponse> _callMutateCustomerLabels;

        /// <summary>
        /// Constructs a client wrapper for the CustomerLabelService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomerLabelServiceSettings"/> used within this client.</param>
        public CustomerLabelServiceClientImpl(CustomerLabelService.CustomerLabelServiceClient grpcClient, CustomerLabelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerLabelServiceSettings effectiveSettings = settings ?? CustomerLabelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomerLabel = clientHelper.BuildApiCall<GetCustomerLabelRequest, gagvr::CustomerLabel>(grpcClient.GetCustomerLabelAsync, grpcClient.GetCustomerLabel, effectiveSettings.GetCustomerLabelSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCustomerLabel);
            Modify_GetCustomerLabelApiCall(ref _callGetCustomerLabel);
            _callMutateCustomerLabels = clientHelper.BuildApiCall<MutateCustomerLabelsRequest, MutateCustomerLabelsResponse>(grpcClient.MutateCustomerLabelsAsync, grpcClient.MutateCustomerLabels, effectiveSettings.MutateCustomerLabelsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerLabels);
            Modify_MutateCustomerLabelsApiCall(ref _callMutateCustomerLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomerLabelApiCall(ref gaxgrpc::ApiCall<GetCustomerLabelRequest, gagvr::CustomerLabel> call);

        partial void Modify_MutateCustomerLabelsApiCall(ref gaxgrpc::ApiCall<MutateCustomerLabelsRequest, MutateCustomerLabelsResponse> call);

        partial void OnConstruction(CustomerLabelService.CustomerLabelServiceClient grpcClient, CustomerLabelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerLabelService client</summary>
        public override CustomerLabelService.CustomerLabelServiceClient GrpcClient { get; }

        partial void Modify_GetCustomerLabelRequest(ref GetCustomerLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCustomerLabelsRequest(ref MutateCustomerLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CustomerLabel GetCustomerLabel(GetCustomerLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerLabelRequest(ref request, ref callSettings);
            return _callGetCustomerLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested customer-label relationship in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CustomerLabel> GetCustomerLabelAsync(GetCustomerLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerLabelRequest(ref request, ref callSettings);
            return _callGetCustomerLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and removes customer-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerLabelsResponse MutateCustomerLabels(MutateCustomerLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerLabelsRequest(ref request, ref callSettings);
            return _callMutateCustomerLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and removes customer-label relationships.
        /// Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [LabelError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerLabelsResponse> MutateCustomerLabelsAsync(MutateCustomerLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerLabelsRequest(ref request, ref callSettings);
            return _callMutateCustomerLabels.Async(request, callSettings);
        }
    }
}

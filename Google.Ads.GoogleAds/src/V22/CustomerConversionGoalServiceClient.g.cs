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
    /// <summary>Settings for <see cref="CustomerConversionGoalServiceClient"/> instances.</summary>
    public sealed partial class CustomerConversionGoalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerConversionGoalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerConversionGoalServiceSettings"/>.</returns>
        public static CustomerConversionGoalServiceSettings GetDefault() => new CustomerConversionGoalServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerConversionGoalServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerConversionGoalServiceSettings()
        {
        }

        private CustomerConversionGoalServiceSettings(CustomerConversionGoalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomerConversionGoalsSettings = existing.MutateCustomerConversionGoalsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerConversionGoalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerConversionGoalServiceClient.MutateCustomerConversionGoals</c> and
        /// <c>CustomerConversionGoalServiceClient.MutateCustomerConversionGoalsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomerConversionGoalsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerConversionGoalServiceSettings"/> object.</returns>
        public CustomerConversionGoalServiceSettings Clone() => new CustomerConversionGoalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerConversionGoalServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class CustomerConversionGoalServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerConversionGoalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerConversionGoalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomerConversionGoalServiceClientBuilder() : base(CustomerConversionGoalServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomerConversionGoalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerConversionGoalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerConversionGoalServiceClient Build()
        {
            CustomerConversionGoalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerConversionGoalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerConversionGoalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerConversionGoalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerConversionGoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomerConversionGoalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerConversionGoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerConversionGoalServiceClient.ChannelPool;
    }

    /// <summary>CustomerConversionGoalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer conversion goal.
    /// </remarks>
    public abstract partial class CustomerConversionGoalServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerConversionGoalService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerConversionGoalService scopes.</summary>
        /// <remarks>
        /// The default CustomerConversionGoalService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomerConversionGoalService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerConversionGoalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerConversionGoalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerConversionGoalServiceClient"/>.</returns>
        public static stt::Task<CustomerConversionGoalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerConversionGoalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerConversionGoalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerConversionGoalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerConversionGoalServiceClient"/>.</returns>
        public static CustomerConversionGoalServiceClient Create() =>
            new CustomerConversionGoalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerConversionGoalServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerConversionGoalServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomerConversionGoalServiceClient"/>.</returns>
        internal static CustomerConversionGoalServiceClient Create(grpccore::CallInvoker callInvoker, CustomerConversionGoalServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerConversionGoalService.CustomerConversionGoalServiceClient grpcClient = new CustomerConversionGoalService.CustomerConversionGoalServiceClient(callInvoker);
            return new CustomerConversionGoalServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomerConversionGoalService client</summary>
        public virtual CustomerConversionGoalService.CustomerConversionGoalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes customer conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerConversionGoalsResponse MutateCustomerConversionGoals(MutateCustomerConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes customer conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerConversionGoalsResponse> MutateCustomerConversionGoalsAsync(MutateCustomerConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes customer conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerConversionGoalsResponse> MutateCustomerConversionGoalsAsync(MutateCustomerConversionGoalsRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerConversionGoalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes customer conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer conversion goals are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer
        /// conversion goal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerConversionGoalsResponse MutateCustomerConversionGoals(string customerId, scg::IEnumerable<CustomerConversionGoalOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerConversionGoals(new MutateCustomerConversionGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes customer conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer conversion goals are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer
        /// conversion goal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerConversionGoalsResponse> MutateCustomerConversionGoalsAsync(string customerId, scg::IEnumerable<CustomerConversionGoalOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerConversionGoalsAsync(new MutateCustomerConversionGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes customer conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer conversion goals are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer
        /// conversion goal.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerConversionGoalsResponse> MutateCustomerConversionGoalsAsync(string customerId, scg::IEnumerable<CustomerConversionGoalOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomerConversionGoalsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerConversionGoalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customer conversion goal.
    /// </remarks>
    public sealed partial class CustomerConversionGoalServiceClientImpl : CustomerConversionGoalServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomerConversionGoalsRequest, MutateCustomerConversionGoalsResponse> _callMutateCustomerConversionGoals;

        /// <summary>
        /// Constructs a client wrapper for the CustomerConversionGoalService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerConversionGoalServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomerConversionGoalServiceClientImpl(CustomerConversionGoalService.CustomerConversionGoalServiceClient grpcClient, CustomerConversionGoalServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomerConversionGoalServiceSettings effectiveSettings = settings ?? CustomerConversionGoalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCustomerConversionGoals = clientHelper.BuildApiCall<MutateCustomerConversionGoalsRequest, MutateCustomerConversionGoalsResponse>("MutateCustomerConversionGoals", grpcClient.MutateCustomerConversionGoalsAsync, grpcClient.MutateCustomerConversionGoals, effectiveSettings.MutateCustomerConversionGoalsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerConversionGoals);
            Modify_MutateCustomerConversionGoalsApiCall(ref _callMutateCustomerConversionGoals);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomerConversionGoalsApiCall(ref gaxgrpc::ApiCall<MutateCustomerConversionGoalsRequest, MutateCustomerConversionGoalsResponse> call);

        partial void OnConstruction(CustomerConversionGoalService.CustomerConversionGoalServiceClient grpcClient, CustomerConversionGoalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerConversionGoalService client</summary>
        public override CustomerConversionGoalService.CustomerConversionGoalServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomerConversionGoalsRequest(ref MutateCustomerConversionGoalsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes customer conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerConversionGoalsResponse MutateCustomerConversionGoals(MutateCustomerConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerConversionGoalsRequest(ref request, ref callSettings);
            return _callMutateCustomerConversionGoals.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes customer conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerConversionGoalsResponse> MutateCustomerConversionGoalsAsync(MutateCustomerConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerConversionGoalsRequest(ref request, ref callSettings);
            return _callMutateCustomerConversionGoals.Async(request, callSettings);
        }
    }
}

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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V17.Services
{
    /// <summary>Settings for <see cref="CampaignBudgetServiceClient"/> instances.</summary>
    public sealed partial class CampaignBudgetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignBudgetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignBudgetServiceSettings"/>.</returns>
        public static CampaignBudgetServiceSettings GetDefault() => new CampaignBudgetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignBudgetServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignBudgetServiceSettings()
        {
        }

        private CampaignBudgetServiceSettings(CampaignBudgetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCampaignBudgetsSettings = existing.MutateCampaignBudgetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignBudgetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignBudgetServiceClient.MutateCampaignBudgets</c> and
        /// <c>CampaignBudgetServiceClient.MutateCampaignBudgetsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCampaignBudgetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignBudgetServiceSettings"/> object.</returns>
        public CampaignBudgetServiceSettings Clone() => new CampaignBudgetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignBudgetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CampaignBudgetServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignBudgetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignBudgetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignBudgetServiceClientBuilder() : base(CampaignBudgetServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CampaignBudgetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignBudgetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignBudgetServiceClient Build()
        {
            CampaignBudgetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignBudgetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignBudgetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignBudgetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignBudgetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CampaignBudgetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignBudgetServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignBudgetServiceClient.ChannelPool;
    }

    /// <summary>CampaignBudgetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign budgets.
    /// </remarks>
    public abstract partial class CampaignBudgetServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignBudgetService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignBudgetService scopes.</summary>
        /// <remarks>
        /// The default CampaignBudgetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CampaignBudgetService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignBudgetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignBudgetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignBudgetServiceClient"/>.</returns>
        public static stt::Task<CampaignBudgetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignBudgetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignBudgetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignBudgetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignBudgetServiceClient"/>.</returns>
        public static CampaignBudgetServiceClient Create() => new CampaignBudgetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignBudgetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignBudgetServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CampaignBudgetServiceClient"/>.</returns>
        internal static CampaignBudgetServiceClient Create(grpccore::CallInvoker callInvoker, CampaignBudgetServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignBudgetService.CampaignBudgetServiceClient grpcClient = new CampaignBudgetService.CampaignBudgetServiceClient(callInvoker);
            return new CampaignBudgetServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CampaignBudgetService client</summary>
        public virtual CampaignBudgetService.CampaignBudgetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignBudgetError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignBudgetsResponse MutateCampaignBudgets(MutateCampaignBudgetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignBudgetError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(MutateCampaignBudgetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignBudgetError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(MutateCampaignBudgetsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignBudgetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignBudgetError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign budgets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign budgets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignBudgetsResponse MutateCampaignBudgets(string customerId, scg::IEnumerable<CampaignBudgetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignBudgets(new MutateCampaignBudgetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignBudgetError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign budgets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign budgets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(string customerId, scg::IEnumerable<CampaignBudgetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignBudgetsAsync(new MutateCampaignBudgetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignBudgetError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign budgets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign budgets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(string customerId, scg::IEnumerable<CampaignBudgetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignBudgetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignBudgetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign budgets.
    /// </remarks>
    public sealed partial class CampaignBudgetServiceClientImpl : CampaignBudgetServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCampaignBudgetsRequest, MutateCampaignBudgetsResponse> _callMutateCampaignBudgets;

        /// <summary>
        /// Constructs a client wrapper for the CampaignBudgetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignBudgetServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CampaignBudgetServiceClientImpl(CampaignBudgetService.CampaignBudgetServiceClient grpcClient, CampaignBudgetServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CampaignBudgetServiceSettings effectiveSettings = settings ?? CampaignBudgetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCampaignBudgets = clientHelper.BuildApiCall<MutateCampaignBudgetsRequest, MutateCampaignBudgetsResponse>("MutateCampaignBudgets", grpcClient.MutateCampaignBudgetsAsync, grpcClient.MutateCampaignBudgets, effectiveSettings.MutateCampaignBudgetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignBudgets);
            Modify_MutateCampaignBudgetsApiCall(ref _callMutateCampaignBudgets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCampaignBudgetsApiCall(ref gaxgrpc::ApiCall<MutateCampaignBudgetsRequest, MutateCampaignBudgetsResponse> call);

        partial void OnConstruction(CampaignBudgetService.CampaignBudgetServiceClient grpcClient, CampaignBudgetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignBudgetService client</summary>
        public override CampaignBudgetService.CampaignBudgetServiceClient GrpcClient { get; }

        partial void Modify_MutateCampaignBudgetsRequest(ref MutateCampaignBudgetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignBudgetError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignBudgetsResponse MutateCampaignBudgets(MutateCampaignBudgetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignBudgetsRequest(ref request, ref callSettings);
            return _callMutateCampaignBudgets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignBudgetError]()
        /// [DatabaseError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [OperationAccessDeniedError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(MutateCampaignBudgetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignBudgetsRequest(ref request, ref callSettings);
            return _callMutateCampaignBudgets.Async(request, callSettings);
        }
    }
}

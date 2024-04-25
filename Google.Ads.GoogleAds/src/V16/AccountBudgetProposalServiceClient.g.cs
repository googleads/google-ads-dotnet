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
    /// <summary>Settings for <see cref="AccountBudgetProposalServiceClient"/> instances.</summary>
    public sealed partial class AccountBudgetProposalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccountBudgetProposalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccountBudgetProposalServiceSettings"/>.</returns>
        public static AccountBudgetProposalServiceSettings GetDefault() => new AccountBudgetProposalServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AccountBudgetProposalServiceSettings"/> object with default settings.
        /// </summary>
        public AccountBudgetProposalServiceSettings()
        {
        }

        private AccountBudgetProposalServiceSettings(AccountBudgetProposalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAccountBudgetProposalSettings = existing.MutateAccountBudgetProposalSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountBudgetProposalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountBudgetProposalServiceClient.MutateAccountBudgetProposal</c> and
        /// <c>AccountBudgetProposalServiceClient.MutateAccountBudgetProposalAsync</c>.
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
        public gaxgrpc::CallSettings MutateAccountBudgetProposalSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccountBudgetProposalServiceSettings"/> object.</returns>
        public AccountBudgetProposalServiceSettings Clone() => new AccountBudgetProposalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccountBudgetProposalServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class AccountBudgetProposalServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccountBudgetProposalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccountBudgetProposalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AccountBudgetProposalServiceClientBuilder() : base(AccountBudgetProposalServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AccountBudgetProposalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccountBudgetProposalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccountBudgetProposalServiceClient Build()
        {
            AccountBudgetProposalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccountBudgetProposalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccountBudgetProposalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccountBudgetProposalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccountBudgetProposalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AccountBudgetProposalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccountBudgetProposalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccountBudgetProposalServiceClient.ChannelPool;
    }

    /// <summary>AccountBudgetProposalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for managing account-level budgets through proposals.
    /// 
    /// A proposal is a request to create a new budget or make changes to an
    /// existing one.
    /// 
    /// Mutates:
    /// The CREATE operation creates a new proposal.
    /// UPDATE operations aren't supported.
    /// The REMOVE operation cancels a pending proposal.
    /// </remarks>
    public abstract partial class AccountBudgetProposalServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountBudgetProposalService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AccountBudgetProposalService scopes.</summary>
        /// <remarks>
        /// The default AccountBudgetProposalService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AccountBudgetProposalService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AccountBudgetProposalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AccountBudgetProposalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccountBudgetProposalServiceClient"/>.</returns>
        public static stt::Task<AccountBudgetProposalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccountBudgetProposalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccountBudgetProposalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AccountBudgetProposalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccountBudgetProposalServiceClient"/>.</returns>
        public static AccountBudgetProposalServiceClient Create() => new AccountBudgetProposalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccountBudgetProposalServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccountBudgetProposalServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AccountBudgetProposalServiceClient"/>.</returns>
        internal static AccountBudgetProposalServiceClient Create(grpccore::CallInvoker callInvoker, AccountBudgetProposalServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountBudgetProposalService.AccountBudgetProposalServiceClient grpcClient = new AccountBudgetProposalService.AccountBudgetProposalServiceClient(callInvoker);
            return new AccountBudgetProposalServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AccountBudgetProposalService client</summary>
        public virtual AccountBudgetProposalService.AccountBudgetProposalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AccountBudgetProposalError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAccountBudgetProposalResponse MutateAccountBudgetProposal(MutateAccountBudgetProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AccountBudgetProposalError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(MutateAccountBudgetProposalRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AccountBudgetProposalError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(MutateAccountBudgetProposalRequest request, st::CancellationToken cancellationToken) =>
            MutateAccountBudgetProposalAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AccountBudgetProposalError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on an individual account-level budget
        /// proposal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAccountBudgetProposalResponse MutateAccountBudgetProposal(string customerId, AccountBudgetProposalOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateAccountBudgetProposal(new MutateAccountBudgetProposalRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AccountBudgetProposalError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on an individual account-level budget
        /// proposal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(string customerId, AccountBudgetProposalOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateAccountBudgetProposalAsync(new MutateAccountBudgetProposalRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AccountBudgetProposalError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on an individual account-level budget
        /// proposal.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(string customerId, AccountBudgetProposalOperation operation, st::CancellationToken cancellationToken) =>
            MutateAccountBudgetProposalAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccountBudgetProposalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for managing account-level budgets through proposals.
    /// 
    /// A proposal is a request to create a new budget or make changes to an
    /// existing one.
    /// 
    /// Mutates:
    /// The CREATE operation creates a new proposal.
    /// UPDATE operations aren't supported.
    /// The REMOVE operation cancels a pending proposal.
    /// </remarks>
    public sealed partial class AccountBudgetProposalServiceClientImpl : AccountBudgetProposalServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAccountBudgetProposalRequest, MutateAccountBudgetProposalResponse> _callMutateAccountBudgetProposal;

        /// <summary>
        /// Constructs a client wrapper for the AccountBudgetProposalService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AccountBudgetProposalServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AccountBudgetProposalServiceClientImpl(AccountBudgetProposalService.AccountBudgetProposalServiceClient grpcClient, AccountBudgetProposalServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AccountBudgetProposalServiceSettings effectiveSettings = settings ?? AccountBudgetProposalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateAccountBudgetProposal = clientHelper.BuildApiCall<MutateAccountBudgetProposalRequest, MutateAccountBudgetProposalResponse>("MutateAccountBudgetProposal", grpcClient.MutateAccountBudgetProposalAsync, grpcClient.MutateAccountBudgetProposal, effectiveSettings.MutateAccountBudgetProposalSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAccountBudgetProposal);
            Modify_MutateAccountBudgetProposalApiCall(ref _callMutateAccountBudgetProposal);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAccountBudgetProposalApiCall(ref gaxgrpc::ApiCall<MutateAccountBudgetProposalRequest, MutateAccountBudgetProposalResponse> call);

        partial void OnConstruction(AccountBudgetProposalService.AccountBudgetProposalServiceClient grpcClient, AccountBudgetProposalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountBudgetProposalService client</summary>
        public override AccountBudgetProposalService.AccountBudgetProposalServiceClient GrpcClient { get; }

        partial void Modify_MutateAccountBudgetProposalRequest(ref MutateAccountBudgetProposalRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AccountBudgetProposalError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAccountBudgetProposalResponse MutateAccountBudgetProposal(MutateAccountBudgetProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAccountBudgetProposalRequest(ref request, ref callSettings);
            return _callMutateAccountBudgetProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AccountBudgetProposalError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(MutateAccountBudgetProposalRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAccountBudgetProposalRequest(ref request, ref callSettings);
            return _callMutateAccountBudgetProposal.Async(request, callSettings);
        }
    }
}

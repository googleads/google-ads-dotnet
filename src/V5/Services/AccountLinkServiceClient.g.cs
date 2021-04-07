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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
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

namespace Google.Ads.GoogleAds.V5.Services
{
    /// <summary>Settings for <see cref="AccountLinkServiceClient"/> instances.</summary>
    public sealed partial class AccountLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccountLinkServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccountLinkServiceSettings"/>.</returns>
        public static AccountLinkServiceSettings GetDefault() => new AccountLinkServiceSettings();

        /// <summary>Constructs a new <see cref="AccountLinkServiceSettings"/> object with default settings.</summary>
        public AccountLinkServiceSettings()
        {
        }

        private AccountLinkServiceSettings(AccountLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAccountLinkSettings = existing.GetAccountLinkSettings;
            CreateAccountLinkSettings = existing.CreateAccountLinkSettings;
            MutateAccountLinkSettings = existing.MutateAccountLinkSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountLinkServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountLinkServiceClient.GetAccountLink</c> and <c>AccountLinkServiceClient.GetAccountLinkAsync</c>.
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
        public gaxgrpc::CallSettings GetAccountLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountLinkServiceClient.CreateAccountLink</c> and <c>AccountLinkServiceClient.CreateAccountLinkAsync</c>
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
        public gaxgrpc::CallSettings CreateAccountLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountLinkServiceClient.MutateAccountLink</c> and <c>AccountLinkServiceClient.MutateAccountLinkAsync</c>
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
        public gaxgrpc::CallSettings MutateAccountLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccountLinkServiceSettings"/> object.</returns>
        public AccountLinkServiceSettings Clone() => new AccountLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccountLinkServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AccountLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccountLinkServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccountLinkServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AccountLinkServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccountLinkServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccountLinkServiceClient Build()
        {
            AccountLinkServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccountLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccountLinkServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccountLinkServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccountLinkServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AccountLinkServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccountLinkServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AccountLinkServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AccountLinkServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccountLinkServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AccountLinkService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of links between Google Ads accounts and other
    /// accounts.
    /// </remarks>
    public abstract partial class AccountLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountLinkService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AccountLinkService scopes.</summary>
        /// <remarks>
        /// The default AccountLinkService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AccountLinkServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AccountLinkServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccountLinkServiceClient"/>.</returns>
        public static stt::Task<AccountLinkServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccountLinkServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccountLinkServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AccountLinkServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="AccountLinkServiceClient"/>.</returns>
        public static AccountLinkServiceClient Create() => new AccountLinkServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccountLinkServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccountLinkServiceSettings"/>.</param>
        /// <returns>The created <see cref="AccountLinkServiceClient"/>.</returns>
        internal static AccountLinkServiceClient Create(grpccore::CallInvoker callInvoker, AccountLinkServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountLinkService.AccountLinkServiceClient grpcClient = new AccountLinkService.AccountLinkServiceClient(callInvoker);
            return new AccountLinkServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AccountLinkService client</summary>
        public virtual AccountLinkService.AccountLinkServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AccountLink GetAccountLink(GetAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountLink> GetAccountLinkAsync(GetAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountLink> GetAccountLinkAsync(GetAccountLinkRequest request, st::CancellationToken cancellationToken) =>
            GetAccountLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the account link.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AccountLink GetAccountLink(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountLink(new GetAccountLinkRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the account link.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountLink> GetAccountLinkAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountLinkAsync(new GetAccountLinkRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the account link.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountLink> GetAccountLinkAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAccountLinkAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the account link.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AccountLink GetAccountLink(gagvr::AccountLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountLink(new GetAccountLinkRequest
            {
                ResourceNameAsAccountLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the account link.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountLink> GetAccountLinkAsync(gagvr::AccountLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountLinkAsync(new GetAccountLinkRequest
            {
                ResourceNameAsAccountLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the account link.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountLink> GetAccountLinkAsync(gagvr::AccountLinkName resourceName, st::CancellationToken cancellationToken) =>
            GetAccountLinkAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an account link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateAccountLinkResponse CreateAccountLink(CreateAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an account link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateAccountLinkResponse> CreateAccountLinkAsync(CreateAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an account link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateAccountLinkResponse> CreateAccountLinkAsync(CreateAccountLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateAccountLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an account link.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the account link is created.
        /// </param>
        /// <param name="accountLink">
        /// Required. The account link to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateAccountLinkResponse CreateAccountLink(string customerId, gagvr::AccountLink accountLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccountLink(new CreateAccountLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                AccountLink = gax::GaxPreconditions.CheckNotNull(accountLink, nameof(accountLink)),
            }, callSettings);

        /// <summary>
        /// Creates an account link.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the account link is created.
        /// </param>
        /// <param name="accountLink">
        /// Required. The account link to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateAccountLinkResponse> CreateAccountLinkAsync(string customerId, gagvr::AccountLink accountLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateAccountLinkAsync(new CreateAccountLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                AccountLink = gax::GaxPreconditions.CheckNotNull(accountLink, nameof(accountLink)),
            }, callSettings);

        /// <summary>
        /// Creates an account link.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the account link is created.
        /// </param>
        /// <param name="accountLink">
        /// Required. The account link to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateAccountLinkResponse> CreateAccountLinkAsync(string customerId, gagvr::AccountLink accountLink, st::CancellationToken cancellationToken) =>
            CreateAccountLinkAsync(customerId, accountLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes an account link.
        /// From V5, create is not supported through
        /// AccountLinkService.MutateAccountLink. Please use
        /// AccountLinkService.CreateAccountLink instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAccountLinkResponse MutateAccountLink(MutateAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes an account link.
        /// From V5, create is not supported through
        /// AccountLinkService.MutateAccountLink. Please use
        /// AccountLinkService.CreateAccountLink instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAccountLinkResponse> MutateAccountLinkAsync(MutateAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes an account link.
        /// From V5, create is not supported through
        /// AccountLinkService.MutateAccountLink. Please use
        /// AccountLinkService.CreateAccountLink instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAccountLinkResponse> MutateAccountLinkAsync(MutateAccountLinkRequest request, st::CancellationToken cancellationToken) =>
            MutateAccountLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes an account link.
        /// From V5, create is not supported through
        /// AccountLinkService.MutateAccountLink. Please use
        /// AccountLinkService.CreateAccountLink instead.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the link.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAccountLinkResponse MutateAccountLink(string customerId, AccountLinkOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateAccountLink(new MutateAccountLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates or removes an account link.
        /// From V5, create is not supported through
        /// AccountLinkService.MutateAccountLink. Please use
        /// AccountLinkService.CreateAccountLink instead.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the link.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAccountLinkResponse> MutateAccountLinkAsync(string customerId, AccountLinkOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateAccountLinkAsync(new MutateAccountLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates or removes an account link.
        /// From V5, create is not supported through
        /// AccountLinkService.MutateAccountLink. Please use
        /// AccountLinkService.CreateAccountLink instead.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the link.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAccountLinkResponse> MutateAccountLinkAsync(string customerId, AccountLinkOperation operation, st::CancellationToken cancellationToken) =>
            MutateAccountLinkAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccountLinkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of links between Google Ads accounts and other
    /// accounts.
    /// </remarks>
    public sealed partial class AccountLinkServiceClientImpl : AccountLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAccountLinkRequest, gagvr::AccountLink> _callGetAccountLink;

        private readonly gaxgrpc::ApiCall<CreateAccountLinkRequest, CreateAccountLinkResponse> _callCreateAccountLink;

        private readonly gaxgrpc::ApiCall<MutateAccountLinkRequest, MutateAccountLinkResponse> _callMutateAccountLink;

        /// <summary>
        /// Constructs a client wrapper for the AccountLinkService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AccountLinkServiceSettings"/> used within this client.</param>
        public AccountLinkServiceClientImpl(AccountLinkService.AccountLinkServiceClient grpcClient, AccountLinkServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AccountLinkServiceSettings effectiveSettings = settings ?? AccountLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAccountLink = clientHelper.BuildApiCall<GetAccountLinkRequest, gagvr::AccountLink>(grpcClient.GetAccountLinkAsync, grpcClient.GetAccountLink, effectiveSettings.GetAccountLinkSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAccountLink);
            Modify_GetAccountLinkApiCall(ref _callGetAccountLink);
            _callCreateAccountLink = clientHelper.BuildApiCall<CreateAccountLinkRequest, CreateAccountLinkResponse>(grpcClient.CreateAccountLinkAsync, grpcClient.CreateAccountLink, effectiveSettings.CreateAccountLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callCreateAccountLink);
            Modify_CreateAccountLinkApiCall(ref _callCreateAccountLink);
            _callMutateAccountLink = clientHelper.BuildApiCall<MutateAccountLinkRequest, MutateAccountLinkResponse>(grpcClient.MutateAccountLinkAsync, grpcClient.MutateAccountLink, effectiveSettings.MutateAccountLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAccountLink);
            Modify_MutateAccountLinkApiCall(ref _callMutateAccountLink);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAccountLinkApiCall(ref gaxgrpc::ApiCall<GetAccountLinkRequest, gagvr::AccountLink> call);

        partial void Modify_CreateAccountLinkApiCall(ref gaxgrpc::ApiCall<CreateAccountLinkRequest, CreateAccountLinkResponse> call);

        partial void Modify_MutateAccountLinkApiCall(ref gaxgrpc::ApiCall<MutateAccountLinkRequest, MutateAccountLinkResponse> call);

        partial void OnConstruction(AccountLinkService.AccountLinkServiceClient grpcClient, AccountLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountLinkService client</summary>
        public override AccountLinkService.AccountLinkServiceClient GrpcClient { get; }

        partial void Modify_GetAccountLinkRequest(ref GetAccountLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateAccountLinkRequest(ref CreateAccountLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateAccountLinkRequest(ref MutateAccountLinkRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AccountLink GetAccountLink(GetAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountLinkRequest(ref request, ref callSettings);
            return _callGetAccountLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the account link in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AccountLink> GetAccountLinkAsync(GetAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountLinkRequest(ref request, ref callSettings);
            return _callGetAccountLink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates an account link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreateAccountLinkResponse CreateAccountLink(CreateAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAccountLinkRequest(ref request, ref callSettings);
            return _callCreateAccountLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an account link.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreateAccountLinkResponse> CreateAccountLinkAsync(CreateAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateAccountLinkRequest(ref request, ref callSettings);
            return _callCreateAccountLink.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or removes an account link.
        /// From V5, create is not supported through
        /// AccountLinkService.MutateAccountLink. Please use
        /// AccountLinkService.CreateAccountLink instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAccountLinkResponse MutateAccountLink(MutateAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAccountLinkRequest(ref request, ref callSettings);
            return _callMutateAccountLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes an account link.
        /// From V5, create is not supported through
        /// AccountLinkService.MutateAccountLink. Please use
        /// AccountLinkService.CreateAccountLink instead.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAccountLinkResponse> MutateAccountLinkAsync(MutateAccountLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAccountLinkRequest(ref request, ref callSettings);
            return _callMutateAccountLink.Async(request, callSettings);
        }
    }
}

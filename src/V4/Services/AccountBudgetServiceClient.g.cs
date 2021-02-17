// Copyright 2020 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V4.Resources;
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

namespace Google.Ads.GoogleAds.V4.Services
{
    /// <summary>Settings for <see cref="AccountBudgetServiceClient"/> instances.</summary>
    public sealed partial class AccountBudgetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AccountBudgetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AccountBudgetServiceSettings"/>.</returns>
        public static AccountBudgetServiceSettings GetDefault() => new AccountBudgetServiceSettings();

        /// <summary>Constructs a new <see cref="AccountBudgetServiceSettings"/> object with default settings.</summary>
        public AccountBudgetServiceSettings()
        {
        }

        private AccountBudgetServiceSettings(AccountBudgetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAccountBudgetSettings = existing.GetAccountBudgetSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountBudgetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountBudgetServiceClient.GetAccountBudget</c> and <c>AccountBudgetServiceClient.GetAccountBudgetAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAccountBudgetSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AccountBudgetServiceSettings"/> object.</returns>
        public AccountBudgetServiceSettings Clone() => new AccountBudgetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AccountBudgetServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AccountBudgetServiceClientBuilder : gaxgrpc::ClientBuilderBase<AccountBudgetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AccountBudgetServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AccountBudgetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AccountBudgetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AccountBudgetServiceClient Build()
        {
            AccountBudgetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AccountBudgetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AccountBudgetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AccountBudgetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AccountBudgetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AccountBudgetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AccountBudgetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AccountBudgetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AccountBudgetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AccountBudgetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AccountBudgetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// A service for fetching an account-level budget.
    /// 
    /// Account-level budgets are mutated by creating proposal resources.
    /// </remarks>
    public abstract partial class AccountBudgetServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountBudgetService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AccountBudgetService scopes.</summary>
        /// <remarks>
        /// The default AccountBudgetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AccountBudgetServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AccountBudgetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AccountBudgetServiceClient"/>.</returns>
        public static stt::Task<AccountBudgetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AccountBudgetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AccountBudgetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AccountBudgetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AccountBudgetServiceClient"/>.</returns>
        public static AccountBudgetServiceClient Create() => new AccountBudgetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AccountBudgetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AccountBudgetServiceSettings"/>.</param>
        /// <returns>The created <see cref="AccountBudgetServiceClient"/>.</returns>
        internal static AccountBudgetServiceClient Create(grpccore::CallInvoker callInvoker, AccountBudgetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountBudgetService.AccountBudgetServiceClient grpcClient = new AccountBudgetService.AccountBudgetServiceClient(callInvoker);
            return new AccountBudgetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AccountBudgetService client</summary>
        public virtual AccountBudgetService.AccountBudgetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AccountBudget GetAccountBudget(GetAccountBudgetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountBudget> GetAccountBudgetAsync(GetAccountBudgetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountBudget> GetAccountBudgetAsync(GetAccountBudgetRequest request, st::CancellationToken cancellationToken) =>
            GetAccountBudgetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the account-level budget to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AccountBudget GetAccountBudget(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountBudget(new GetAccountBudgetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the account-level budget to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountBudget> GetAccountBudgetAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountBudgetAsync(new GetAccountBudgetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the account-level budget to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountBudget> GetAccountBudgetAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAccountBudgetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the account-level budget to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AccountBudget GetAccountBudget(gagvr::AccountBudgetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountBudget(new GetAccountBudgetRequest
            {
                ResourceNameAsAccountBudgetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the account-level budget to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountBudget> GetAccountBudgetAsync(gagvr::AccountBudgetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAccountBudgetAsync(new GetAccountBudgetRequest
            {
                ResourceNameAsAccountBudgetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the account-level budget to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AccountBudget> GetAccountBudgetAsync(gagvr::AccountBudgetName resourceName, st::CancellationToken cancellationToken) =>
            GetAccountBudgetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AccountBudgetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// A service for fetching an account-level budget.
    /// 
    /// Account-level budgets are mutated by creating proposal resources.
    /// </remarks>
    public sealed partial class AccountBudgetServiceClientImpl : AccountBudgetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAccountBudgetRequest, gagvr::AccountBudget> _callGetAccountBudget;

        /// <summary>
        /// Constructs a client wrapper for the AccountBudgetService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AccountBudgetServiceSettings"/> used within this client.</param>
        public AccountBudgetServiceClientImpl(AccountBudgetService.AccountBudgetServiceClient grpcClient, AccountBudgetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AccountBudgetServiceSettings effectiveSettings = settings ?? AccountBudgetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAccountBudget = clientHelper.BuildApiCall<GetAccountBudgetRequest, gagvr::AccountBudget>(grpcClient.GetAccountBudgetAsync, grpcClient.GetAccountBudget, effectiveSettings.GetAccountBudgetSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAccountBudget);
            Modify_GetAccountBudgetApiCall(ref _callGetAccountBudget);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAccountBudgetApiCall(ref gaxgrpc::ApiCall<GetAccountBudgetRequest, gagvr::AccountBudget> call);

        partial void OnConstruction(AccountBudgetService.AccountBudgetServiceClient grpcClient, AccountBudgetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AccountBudgetService client</summary>
        public override AccountBudgetService.AccountBudgetServiceClient GrpcClient { get; }

        partial void Modify_GetAccountBudgetRequest(ref GetAccountBudgetRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AccountBudget GetAccountBudget(GetAccountBudgetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountBudgetRequest(ref request, ref callSettings);
            return _callGetAccountBudget.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns an account-level budget in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AccountBudget> GetAccountBudgetAsync(GetAccountBudgetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountBudgetRequest(ref request, ref callSettings);
            return _callGetAccountBudget.Async(request, callSettings);
        }
    }
}

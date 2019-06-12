// Copyright 2019 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V1.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using pb = Google.Protobuf;
using pbwkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V1.Services
{
    /// <summary>
    /// Settings for a <see cref="AccountBudgetProposalServiceClient"/>.
    /// </summary>
    public sealed partial class AccountBudgetProposalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AccountBudgetProposalServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="AccountBudgetProposalServiceSettings"/>.
        /// </returns>
        public static AccountBudgetProposalServiceSettings GetDefault() => new AccountBudgetProposalServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AccountBudgetProposalServiceSettings"/> object with default settings.
        /// </summary>
        public AccountBudgetProposalServiceSettings() { }

        private AccountBudgetProposalServiceSettings(AccountBudgetProposalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAccountBudgetProposalSettings = existing.GetAccountBudgetProposalSettings;
            MutateAccountBudgetProposalSettings = existing.MutateAccountBudgetProposalSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AccountBudgetProposalServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="AccountBudgetProposalServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// The eligible RPC <see cref="grpccore::StatusCode"/>s for retry for "Idempotent" RPC methods are:
        /// <list type="bullet">
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> IdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.DeadlineExceeded, grpccore::StatusCode.Unavailable);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "NonIdempotent" <see cref="AccountBudgetProposalServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="AccountBudgetProposalServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="AccountBudgetProposalServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="AccountBudgetProposalServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 5000 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(5000),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="AccountBudgetProposalServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="AccountBudgetProposalServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="AccountBudgetProposalServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 3600000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(3600000),
            maxDelay: sys::TimeSpan.FromMilliseconds(3600000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountBudgetProposalServiceClient.GetAccountBudgetProposal</c> and <c>AccountBudgetProposalServiceClient.GetAccountBudgetProposalAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AccountBudgetProposalServiceClient.GetAccountBudgetProposal</c> and
        /// <c>AccountBudgetProposalServiceClient.GetAccountBudgetProposalAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetAccountBudgetProposalSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AccountBudgetProposalServiceClient.MutateAccountBudgetProposal</c> and <c>AccountBudgetProposalServiceClient.MutateAccountBudgetProposalAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AccountBudgetProposalServiceClient.MutateAccountBudgetProposal</c> and
        /// <c>AccountBudgetProposalServiceClient.MutateAccountBudgetProposalAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 3600000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 3600000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 3600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings MutateAccountBudgetProposalSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="AccountBudgetProposalServiceSettings"/> object.</returns>
        public AccountBudgetProposalServiceSettings Clone() => new AccountBudgetProposalServiceSettings(this);
    }

    /// <summary>
    /// AccountBudgetProposalService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class AccountBudgetProposalServiceClient
    {
        /// <summary>
        /// The default endpoint for the AccountBudgetProposalService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default AccountBudgetProposalService scopes.
        /// </summary>
        /// <remarks>
        /// The default AccountBudgetProposalService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AccountBudgetProposalServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// AccountBudgetProposalServiceClient client = await AccountBudgetProposalServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     AccountBudgetProposalServiceClient.DefaultEndpoint.Host, AccountBudgetProposalServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AccountBudgetProposalServiceClient client = AccountBudgetProposalServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AccountBudgetProposalServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="AccountBudgetProposalServiceClient"/>.</returns>
        public static async stt::Task<AccountBudgetProposalServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, AccountBudgetProposalServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="AccountBudgetProposalServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// AccountBudgetProposalServiceClient client = AccountBudgetProposalServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V1.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     AccountBudgetProposalServiceClient.DefaultEndpoint.Host, AccountBudgetProposalServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AccountBudgetProposalServiceClient client = AccountBudgetProposalServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AccountBudgetProposalServiceSettings"/>.</param>
        /// <returns>The created <see cref="AccountBudgetProposalServiceClient"/>.</returns>
        public static AccountBudgetProposalServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, AccountBudgetProposalServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="AccountBudgetProposalServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AccountBudgetProposalServiceSettings"/>.</param>
        /// <returns>The created <see cref="AccountBudgetProposalServiceClient"/>.</returns>
        public static AccountBudgetProposalServiceClient Create(grpccore::Channel channel, AccountBudgetProposalServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="AccountBudgetProposalServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AccountBudgetProposalServiceSettings"/>.</param>
        /// <returns>The created <see cref="AccountBudgetProposalServiceClient"/>.</returns>
        public static AccountBudgetProposalServiceClient Create(grpccore::CallInvoker callInvoker, AccountBudgetProposalServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AccountBudgetProposalService.AccountBudgetProposalServiceClient grpcClient = new AccountBudgetProposalService.AccountBudgetProposalServiceClient(callInvoker);
            return new AccountBudgetProposalServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, AccountBudgetProposalServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AccountBudgetProposalServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, AccountBudgetProposalServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AccountBudgetProposalServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC AccountBudgetProposalService client.
        /// </summary>
        public virtual AccountBudgetProposalService.AccountBudgetProposalServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns an account-level budget proposal in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the account-level budget proposal to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::AccountBudgetProposal> GetAccountBudgetProposalAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetAccountBudgetProposalAsync(
                new GetAccountBudgetProposalRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns an account-level budget proposal in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the account-level budget proposal to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::AccountBudgetProposal> GetAccountBudgetProposalAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetAccountBudgetProposalAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an account-level budget proposal in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the account-level budget proposal to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::AccountBudgetProposal GetAccountBudgetProposal(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetAccountBudgetProposal(
                new GetAccountBudgetProposalRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns an account-level budget proposal in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::AccountBudgetProposal> GetAccountBudgetProposalAsync(
            GetAccountBudgetProposalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns an account-level budget proposal in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::AccountBudgetProposal> GetAccountBudgetProposalAsync(
            GetAccountBudgetProposalRequest request,
            st::CancellationToken cancellationToken) => GetAccountBudgetProposalAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns an account-level budget proposal in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::AccountBudgetProposal GetAccountBudgetProposal(
            GetAccountBudgetProposalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer.
        /// </param>
        /// <param name="operation">
        /// The operation to perform on an individual account-level budget proposal.
        /// </param>
        /// <param name="validateOnly">
        /// If true, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(
            string customerId,
            AccountBudgetProposalOperation operation,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateAccountBudgetProposalAsync(
                new MutateAccountBudgetProposalRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer.
        /// </param>
        /// <param name="operation">
        /// The operation to perform on an individual account-level budget proposal.
        /// </param>
        /// <param name="validateOnly">
        /// If true, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(
            string customerId,
            AccountBudgetProposalOperation operation,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateAccountBudgetProposalAsync(
                customerId,
                operation,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer.
        /// </param>
        /// <param name="operation">
        /// The operation to perform on an individual account-level budget proposal.
        /// </param>
        /// <param name="validateOnly">
        /// If true, the request is validated but not executed. Only errors are
        /// returned, not results.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateAccountBudgetProposalResponse MutateAccountBudgetProposal(
            string customerId,
            AccountBudgetProposalOperation operation,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateAccountBudgetProposal(
                new MutateAccountBudgetProposalRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer.
        /// </param>
        /// <param name="operation">
        /// The operation to perform on an individual account-level budget proposal.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(
            string customerId,
            AccountBudgetProposalOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateAccountBudgetProposalAsync(
                new MutateAccountBudgetProposalRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer.
        /// </param>
        /// <param name="operation">
        /// The operation to perform on an individual account-level budget proposal.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(
            string customerId,
            AccountBudgetProposalOperation operation,
            st::CancellationToken cancellationToken) => MutateAccountBudgetProposalAsync(
                customerId,
                operation,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer.
        /// </param>
        /// <param name="operation">
        /// The operation to perform on an individual account-level budget proposal.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateAccountBudgetProposalResponse MutateAccountBudgetProposal(
            string customerId,
            AccountBudgetProposalOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateAccountBudgetProposal(
                new MutateAccountBudgetProposalRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(
            MutateAccountBudgetProposalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(
            MutateAccountBudgetProposalRequest request,
            st::CancellationToken cancellationToken) => MutateAccountBudgetProposalAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateAccountBudgetProposalResponse MutateAccountBudgetProposal(
            MutateAccountBudgetProposalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// AccountBudgetProposalService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class AccountBudgetProposalServiceClientImpl : AccountBudgetProposalServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAccountBudgetProposalRequest, gagvr::AccountBudgetProposal> _callGetAccountBudgetProposal;
        private readonly gaxgrpc::ApiCall<MutateAccountBudgetProposalRequest, MutateAccountBudgetProposalResponse> _callMutateAccountBudgetProposal;

        /// <summary>
        /// Constructs a client wrapper for the AccountBudgetProposalService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AccountBudgetProposalServiceSettings"/> used within this client </param>
        public AccountBudgetProposalServiceClientImpl(AccountBudgetProposalService.AccountBudgetProposalServiceClient grpcClient, AccountBudgetProposalServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AccountBudgetProposalServiceSettings effectiveSettings = settings ?? AccountBudgetProposalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAccountBudgetProposal = clientHelper.BuildApiCall<GetAccountBudgetProposalRequest, gagvr::AccountBudgetProposal>(
                GrpcClient.GetAccountBudgetProposalAsync, GrpcClient.GetAccountBudgetProposal, effectiveSettings.GetAccountBudgetProposalSettings);
            _callMutateAccountBudgetProposal = clientHelper.BuildApiCall<MutateAccountBudgetProposalRequest, MutateAccountBudgetProposalResponse>(
                GrpcClient.MutateAccountBudgetProposalAsync, GrpcClient.MutateAccountBudgetProposal, effectiveSettings.MutateAccountBudgetProposalSettings);
            Modify_ApiCall(ref _callGetAccountBudgetProposal);
            Modify_GetAccountBudgetProposalApiCall(ref _callGetAccountBudgetProposal);
            Modify_ApiCall(ref _callMutateAccountBudgetProposal);
            Modify_MutateAccountBudgetProposalApiCall(ref _callMutateAccountBudgetProposal);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        // Partial methods are named to (mostly) ensure there cannot be conflicts with RPC method names.

        // Partial methods called for every ApiCall on construction.
        // Allows modification of all the underlying ApiCall objects.
        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call)
            where TRequest : class, pb::IMessage<TRequest>
            where TResponse : class, pb::IMessage<TResponse>;

        // Partial methods called for each ApiCall on construction.
        // Allows per-RPC-method modification of the underlying ApiCall object.
        partial void Modify_GetAccountBudgetProposalApiCall(ref gaxgrpc::ApiCall<GetAccountBudgetProposalRequest, gagvr::AccountBudgetProposal> call);
        partial void Modify_MutateAccountBudgetProposalApiCall(ref gaxgrpc::ApiCall<MutateAccountBudgetProposalRequest, MutateAccountBudgetProposalResponse> call);
        partial void OnConstruction(AccountBudgetProposalService.AccountBudgetProposalServiceClient grpcClient, AccountBudgetProposalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC AccountBudgetProposalService client.
        /// </summary>
        public override AccountBudgetProposalService.AccountBudgetProposalServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetAccountBudgetProposalRequest(ref GetAccountBudgetProposalRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateAccountBudgetProposalRequest(ref MutateAccountBudgetProposalRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns an account-level budget proposal in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<gagvr::AccountBudgetProposal> GetAccountBudgetProposalAsync(
            GetAccountBudgetProposalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountBudgetProposalRequest(ref request, ref callSettings);
            return _callGetAccountBudgetProposal.Async(request, callSettings);
        }

        /// <summary>
        /// Returns an account-level budget proposal in full detail.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override gagvr::AccountBudgetProposal GetAccountBudgetProposal(
            GetAccountBudgetProposalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAccountBudgetProposalRequest(ref request, ref callSettings);
            return _callGetAccountBudgetProposal.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public override stt::Task<MutateAccountBudgetProposalResponse> MutateAccountBudgetProposalAsync(
            MutateAccountBudgetProposalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAccountBudgetProposalRequest(ref request, ref callSettings);
            return _callMutateAccountBudgetProposal.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes account budget proposals.  Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">
        /// The request object containing all of the parameters for the API call.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public override MutateAccountBudgetProposalResponse MutateAccountBudgetProposal(
            MutateAccountBudgetProposalRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAccountBudgetProposalRequest(ref request, ref callSettings);
            return _callMutateAccountBudgetProposal.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

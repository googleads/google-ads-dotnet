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

using gagvr = Google.Ads.GoogleAds.V0.Resources;
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

namespace Google.Ads.GoogleAds.V0.Services
{
    /// <summary>
    /// Settings for a <see cref="CampaignBudgetServiceClient"/>.
    /// </summary>
    public sealed partial class CampaignBudgetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CampaignBudgetServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CampaignBudgetServiceSettings"/>.
        /// </returns>
        public static CampaignBudgetServiceSettings GetDefault() => new CampaignBudgetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignBudgetServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignBudgetServiceSettings() { }

        private CampaignBudgetServiceSettings(CampaignBudgetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignBudgetSettings = existing.GetCampaignBudgetSettings;
            MutateCampaignBudgetsSettings = existing.MutateCampaignBudgetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignBudgetServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CampaignBudgetServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="CampaignBudgetServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CampaignBudgetServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CampaignBudgetServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CampaignBudgetServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial delay: 100 milliseconds</description></item>
        /// <item><description>Maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Delay multiplier: 1.3</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultRetryBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(100),
            maxDelay: sys::TimeSpan.FromMilliseconds(60000),
            delayMultiplier: 1.3
        );

        /// <summary>
        /// "Default" timeout backoff for <see cref="CampaignBudgetServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CampaignBudgetServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CampaignBudgetServiceClient"/> RPC methods is defined as:
        /// <list type="bullet">
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Maximum timeout: 20000 milliseconds</description></item>
        /// </list>
        /// </remarks>
        public static gaxgrpc::BackoffSettings GetDefaultTimeoutBackoff() => new gaxgrpc::BackoffSettings(
            delay: sys::TimeSpan.FromMilliseconds(20000),
            maxDelay: sys::TimeSpan.FromMilliseconds(20000),
            delayMultiplier: 1.0
        );

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignBudgetServiceClient.GetCampaignBudget</c> and <c>CampaignBudgetServiceClient.GetCampaignBudgetAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignBudgetServiceClient.GetCampaignBudget</c> and
        /// <c>CampaignBudgetServiceClient.GetCampaignBudgetAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description><see cref="grpccore::StatusCode.DeadlineExceeded"/></description></item>
        /// <item><description><see cref="grpccore::StatusCode.Unavailable"/></description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings GetCampaignBudgetSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignBudgetServiceClient.MutateCampaignBudgets</c> and <c>CampaignBudgetServiceClient.MutateCampaignBudgetsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignBudgetServiceClient.MutateCampaignBudgets</c> and
        /// <c>CampaignBudgetServiceClient.MutateCampaignBudgetsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 100 milliseconds</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds</description></item>
        /// <item><description>Initial timeout: 20000 milliseconds</description></item>
        /// <item><description>Timeout multiplier: 1.0</description></item>
        /// <item><description>Timeout maximum delay: 20000 milliseconds</description></item>
        /// </list>
        /// Retry will be attempted on the following response status codes:
        /// <list>
        /// <item><description>No status codes</description></item>
        /// </list>
        /// Default RPC expiration is 600000 milliseconds.
        /// </remarks>
        public gaxgrpc::CallSettings MutateCampaignBudgetsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CampaignBudgetServiceSettings"/> object.</returns>
        public CampaignBudgetServiceSettings Clone() => new CampaignBudgetServiceSettings(this);
    }

    /// <summary>
    /// CampaignBudgetService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CampaignBudgetServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignBudgetService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default CampaignBudgetService scopes.
        /// </summary>
        /// <remarks>
        /// The default CampaignBudgetService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignBudgetServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CampaignBudgetServiceClient client = await CampaignBudgetServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CampaignBudgetServiceClient.DefaultEndpoint.Host, CampaignBudgetServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CampaignBudgetServiceClient client = CampaignBudgetServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CampaignBudgetServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CampaignBudgetServiceClient"/>.</returns>
        public static async stt::Task<CampaignBudgetServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CampaignBudgetServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CampaignBudgetServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CampaignBudgetServiceClient client = CampaignBudgetServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V0.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CampaignBudgetServiceClient.DefaultEndpoint.Host, CampaignBudgetServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CampaignBudgetServiceClient client = CampaignBudgetServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CampaignBudgetServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignBudgetServiceClient"/>.</returns>
        public static CampaignBudgetServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CampaignBudgetServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CampaignBudgetServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CampaignBudgetServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignBudgetServiceClient"/>.</returns>
        public static CampaignBudgetServiceClient Create(grpccore::Channel channel, CampaignBudgetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CampaignBudgetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CampaignBudgetServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignBudgetServiceClient"/>.</returns>
        public static CampaignBudgetServiceClient Create(grpccore::CallInvoker callInvoker, CampaignBudgetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignBudgetService.CampaignBudgetServiceClient grpcClient = new CampaignBudgetService.CampaignBudgetServiceClient(callInvoker);
            return new CampaignBudgetServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CampaignBudgetServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CampaignBudgetServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CampaignBudgetServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CampaignBudgetServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CampaignBudgetService client.
        /// </summary>
        public virtual CampaignBudgetService.CampaignBudgetServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested Campaign Budget in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the campaign budget to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CampaignBudget> GetCampaignBudgetAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCampaignBudgetAsync(
                new GetCampaignBudgetRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested Campaign Budget in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the campaign budget to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CampaignBudget> GetCampaignBudgetAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetCampaignBudgetAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Campaign Budget in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the campaign budget to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::CampaignBudget GetCampaignBudget(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCampaignBudget(
                new GetCampaignBudgetRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested Campaign Budget in full detail.
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
        public virtual stt::Task<gagvr::CampaignBudget> GetCampaignBudgetAsync(
            GetCampaignBudgetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested Campaign Budget in full detail.
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
        public virtual stt::Task<gagvr::CampaignBudget> GetCampaignBudgetAsync(
            GetCampaignBudgetRequest request,
            st::CancellationToken cancellationToken) => GetCampaignBudgetAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Campaign Budget in full detail.
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
        public virtual gagvr::CampaignBudget GetCampaignBudget(
            GetCampaignBudgetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign budgets are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign budgets.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// Default is false.
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
        public virtual stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(
            string customerId,
            scg::IEnumerable<CampaignBudgetOperation> operations,
            bool partialFailure,
            bool validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignBudgetsAsync(
                new MutateCampaignBudgetsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure,
                    ValidateOnly = validateOnly,
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign budgets are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign budgets.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// Default is false.
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
        public virtual stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(
            string customerId,
            scg::IEnumerable<CampaignBudgetOperation> operations,
            bool partialFailure,
            bool validateOnly,
            st::CancellationToken cancellationToken) => MutateCampaignBudgetsAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose campaign budgets are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual campaign budgets.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// Default is false.
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
        public virtual MutateCampaignBudgetsResponse MutateCampaignBudgets(
            string customerId,
            scg::IEnumerable<CampaignBudgetOperation> operations,
            bool partialFailure,
            bool validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignBudgets(
                new MutateCampaignBudgetsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure,
                    ValidateOnly = validateOnly,
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
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
        public virtual stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(
            MutateCampaignBudgetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
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
        public virtual stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(
            MutateCampaignBudgetsRequest request,
            st::CancellationToken cancellationToken) => MutateCampaignBudgetsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
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
        public virtual MutateCampaignBudgetsResponse MutateCampaignBudgets(
            MutateCampaignBudgetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CampaignBudgetService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CampaignBudgetServiceClientImpl : CampaignBudgetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignBudgetRequest, gagvr::CampaignBudget> _callGetCampaignBudget;
        private readonly gaxgrpc::ApiCall<MutateCampaignBudgetsRequest, MutateCampaignBudgetsResponse> _callMutateCampaignBudgets;

        /// <summary>
        /// Constructs a client wrapper for the CampaignBudgetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignBudgetServiceSettings"/> used within this client </param>
        public CampaignBudgetServiceClientImpl(CampaignBudgetService.CampaignBudgetServiceClient grpcClient, CampaignBudgetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignBudgetServiceSettings effectiveSettings = settings ?? CampaignBudgetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignBudget = clientHelper.BuildApiCall<GetCampaignBudgetRequest, gagvr::CampaignBudget>(
                GrpcClient.GetCampaignBudgetAsync, GrpcClient.GetCampaignBudget, effectiveSettings.GetCampaignBudgetSettings);
            _callMutateCampaignBudgets = clientHelper.BuildApiCall<MutateCampaignBudgetsRequest, MutateCampaignBudgetsResponse>(
                GrpcClient.MutateCampaignBudgetsAsync, GrpcClient.MutateCampaignBudgets, effectiveSettings.MutateCampaignBudgetsSettings);
            Modify_ApiCall(ref _callGetCampaignBudget);
            Modify_GetCampaignBudgetApiCall(ref _callGetCampaignBudget);
            Modify_ApiCall(ref _callMutateCampaignBudgets);
            Modify_MutateCampaignBudgetsApiCall(ref _callMutateCampaignBudgets);
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
        partial void Modify_GetCampaignBudgetApiCall(ref gaxgrpc::ApiCall<GetCampaignBudgetRequest, gagvr::CampaignBudget> call);
        partial void Modify_MutateCampaignBudgetsApiCall(ref gaxgrpc::ApiCall<MutateCampaignBudgetsRequest, MutateCampaignBudgetsResponse> call);
        partial void OnConstruction(CampaignBudgetService.CampaignBudgetServiceClient grpcClient, CampaignBudgetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CampaignBudgetService client.
        /// </summary>
        public override CampaignBudgetService.CampaignBudgetServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetCampaignBudgetRequest(ref GetCampaignBudgetRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateCampaignBudgetsRequest(ref MutateCampaignBudgetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Campaign Budget in full detail.
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
        public override stt::Task<gagvr::CampaignBudget> GetCampaignBudgetAsync(
            GetCampaignBudgetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignBudgetRequest(ref request, ref callSettings);
            return _callGetCampaignBudget.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Campaign Budget in full detail.
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
        public override gagvr::CampaignBudget GetCampaignBudget(
            GetCampaignBudgetRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignBudgetRequest(ref request, ref callSettings);
            return _callGetCampaignBudget.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
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
        public override stt::Task<MutateCampaignBudgetsResponse> MutateCampaignBudgetsAsync(
            MutateCampaignBudgetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignBudgetsRequest(ref request, ref callSettings);
            return _callMutateCampaignBudgets.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign budgets. Operation statuses are
        /// returned.
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
        public override MutateCampaignBudgetsResponse MutateCampaignBudgets(
            MutateCampaignBudgetsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignBudgetsRequest(ref request, ref callSettings);
            return _callMutateCampaignBudgets.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

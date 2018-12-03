// Copyright 2018 Google LLC
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

// TODO( b/119694056): Removed Comment

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
    /// Settings for a <see cref="BillingSetupServiceClient"/>.
    /// </summary>
    public sealed partial class BillingSetupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BillingSetupServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="BillingSetupServiceSettings"/>.
        /// </returns>
        public static BillingSetupServiceSettings GetDefault() => new BillingSetupServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BillingSetupServiceSettings"/> object with default settings.
        /// </summary>
        public BillingSetupServiceSettings() { }

        private BillingSetupServiceSettings(BillingSetupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetBillingSetupSettings = existing.GetBillingSetupSettings;
            MutateBillingSetupSettings = existing.MutateBillingSetupSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BillingSetupServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="BillingSetupServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="BillingSetupServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="BillingSetupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="BillingSetupServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="BillingSetupServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="BillingSetupServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="BillingSetupServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="BillingSetupServiceClient"/> RPC methods is defined as:
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
        /// <c>BillingSetupServiceClient.GetBillingSetup</c> and <c>BillingSetupServiceClient.GetBillingSetupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BillingSetupServiceClient.GetBillingSetup</c> and
        /// <c>BillingSetupServiceClient.GetBillingSetupAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetBillingSetupSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BillingSetupServiceClient.MutateBillingSetup</c> and <c>BillingSetupServiceClient.MutateBillingSetupAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>BillingSetupServiceClient.MutateBillingSetup</c> and
        /// <c>BillingSetupServiceClient.MutateBillingSetupAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateBillingSetupSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="BillingSetupServiceSettings"/> object.</returns>
        public BillingSetupServiceSettings Clone() => new BillingSetupServiceSettings(this);
    }

    /// <summary>
    /// BillingSetupService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class BillingSetupServiceClient
    {
        /// <summary>
        /// The default endpoint for the BillingSetupService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default BillingSetupService scopes.
        /// </summary>
        /// <remarks>
        /// The default BillingSetupService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="BillingSetupServiceClient"/>, applying defaults for all unspecified settings,
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
        /// BillingSetupServiceClient client = await BillingSetupServiceClient.CreateAsync();
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
        ///     BillingSetupServiceClient.DefaultEndpoint.Host, BillingSetupServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// BillingSetupServiceClient client = BillingSetupServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BillingSetupServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="BillingSetupServiceClient"/>.</returns>
        public static async stt::Task<BillingSetupServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, BillingSetupServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="BillingSetupServiceClient"/>, applying defaults for all unspecified settings,
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
        /// BillingSetupServiceClient client = BillingSetupServiceClient.Create();
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
        ///     BillingSetupServiceClient.DefaultEndpoint.Host, BillingSetupServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// BillingSetupServiceClient client = BillingSetupServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="BillingSetupServiceSettings"/>.</param>
        /// <returns>The created <see cref="BillingSetupServiceClient"/>.</returns>
        public static BillingSetupServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, BillingSetupServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="BillingSetupServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BillingSetupServiceSettings"/>.</param>
        /// <returns>The created <see cref="BillingSetupServiceClient"/>.</returns>
        public static BillingSetupServiceClient Create(grpccore::Channel channel, BillingSetupServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="BillingSetupServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="BillingSetupServiceSettings"/>.</param>
        /// <returns>The created <see cref="BillingSetupServiceClient"/>.</returns>
        public static BillingSetupServiceClient Create(grpccore::CallInvoker callInvoker, BillingSetupServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BillingSetupService.BillingSetupServiceClient grpcClient = new BillingSetupService.BillingSetupServiceClient(callInvoker);
            return new BillingSetupServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, BillingSetupServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, BillingSetupServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, BillingSetupServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, BillingSetupServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC BillingSetupService client.
        /// </summary>
        public virtual BillingSetupService.BillingSetupServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns a billing setup.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the billing setup to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::BillingSetup> GetBillingSetupAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetBillingSetupAsync(
                new GetBillingSetupRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns a billing setup.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the billing setup to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::BillingSetup> GetBillingSetupAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetBillingSetupAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a billing setup.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the billing setup to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::BillingSetup GetBillingSetup(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetBillingSetup(
                new GetBillingSetupRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns a billing setup.
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
        public virtual stt::Task<gagvr::BillingSetup> GetBillingSetupAsync(
            GetBillingSetupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns a billing setup.
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
        public virtual stt::Task<gagvr::BillingSetup> GetBillingSetupAsync(
            GetBillingSetupRequest request,
            st::CancellationToken cancellationToken) => GetBillingSetupAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a billing setup.
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
        public virtual gagvr::BillingSetup GetBillingSetup(
            GetBillingSetupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// </summary>
        /// <param name="customerId">
        /// Id of the customer to apply the billing setup mutate operation to.
        /// </param>
        /// <param name="operation">
        /// The operation to perform.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateBillingSetupResponse> MutateBillingSetupAsync(
            string customerId,
            BillingSetupOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateBillingSetupAsync(
                new MutateBillingSetupRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                },
                callSettings);

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// </summary>
        /// <param name="customerId">
        /// Id of the customer to apply the billing setup mutate operation to.
        /// </param>
        /// <param name="operation">
        /// The operation to perform.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateBillingSetupResponse> MutateBillingSetupAsync(
            string customerId,
            BillingSetupOperation operation,
            st::CancellationToken cancellationToken) => MutateBillingSetupAsync(
                customerId,
                operation,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
        /// </summary>
        /// <param name="customerId">
        /// Id of the customer to apply the billing setup mutate operation to.
        /// </param>
        /// <param name="operation">
        /// The operation to perform.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateBillingSetupResponse MutateBillingSetup(
            string customerId,
            BillingSetupOperation operation,
            gaxgrpc::CallSettings callSettings = null) => MutateBillingSetup(
                new MutateBillingSetupRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
                },
                callSettings);

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
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
        public virtual stt::Task<MutateBillingSetupResponse> MutateBillingSetupAsync(
            MutateBillingSetupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
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
        public virtual stt::Task<MutateBillingSetupResponse> MutateBillingSetupAsync(
            MutateBillingSetupRequest request,
            st::CancellationToken cancellationToken) => MutateBillingSetupAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
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
        public virtual MutateBillingSetupResponse MutateBillingSetup(
            MutateBillingSetupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// BillingSetupService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class BillingSetupServiceClientImpl : BillingSetupServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetBillingSetupRequest, gagvr::BillingSetup> _callGetBillingSetup;
        private readonly gaxgrpc::ApiCall<MutateBillingSetupRequest, MutateBillingSetupResponse> _callMutateBillingSetup;

        /// <summary>
        /// Constructs a client wrapper for the BillingSetupService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BillingSetupServiceSettings"/> used within this client </param>
        public BillingSetupServiceClientImpl(BillingSetupService.BillingSetupServiceClient grpcClient, BillingSetupServiceSettings settings)
        {
            GrpcClient = grpcClient;
            BillingSetupServiceSettings effectiveSettings = settings ?? BillingSetupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetBillingSetup = clientHelper.BuildApiCall<GetBillingSetupRequest, gagvr::BillingSetup>(
                GrpcClient.GetBillingSetupAsync, GrpcClient.GetBillingSetup, effectiveSettings.GetBillingSetupSettings);
            _callMutateBillingSetup = clientHelper.BuildApiCall<MutateBillingSetupRequest, MutateBillingSetupResponse>(
                GrpcClient.MutateBillingSetupAsync, GrpcClient.MutateBillingSetup, effectiveSettings.MutateBillingSetupSettings);
            Modify_ApiCall(ref _callGetBillingSetup);
            Modify_GetBillingSetupApiCall(ref _callGetBillingSetup);
            Modify_ApiCall(ref _callMutateBillingSetup);
            Modify_MutateBillingSetupApiCall(ref _callMutateBillingSetup);
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
        partial void Modify_GetBillingSetupApiCall(ref gaxgrpc::ApiCall<GetBillingSetupRequest, gagvr::BillingSetup> call);
        partial void Modify_MutateBillingSetupApiCall(ref gaxgrpc::ApiCall<MutateBillingSetupRequest, MutateBillingSetupResponse> call);
        partial void OnConstruction(BillingSetupService.BillingSetupServiceClient grpcClient, BillingSetupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC BillingSetupService client.
        /// </summary>
        public override BillingSetupService.BillingSetupServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetBillingSetupRequest(ref GetBillingSetupRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateBillingSetupRequest(ref MutateBillingSetupRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a billing setup.
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
        public override stt::Task<gagvr::BillingSetup> GetBillingSetupAsync(
            GetBillingSetupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBillingSetupRequest(ref request, ref callSettings);
            return _callGetBillingSetup.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a billing setup.
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
        public override gagvr::BillingSetup GetBillingSetup(
            GetBillingSetupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetBillingSetupRequest(ref request, ref callSettings);
            return _callGetBillingSetup.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
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
        public override stt::Task<MutateBillingSetupResponse> MutateBillingSetupAsync(
            MutateBillingSetupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBillingSetupRequest(ref request, ref callSettings);
            return _callMutateBillingSetup.Async(request, callSettings);
        }

        /// <summary>
        /// Creates a billing setup, or cancels an existing billing setup.
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
        public override MutateBillingSetupResponse MutateBillingSetup(
            MutateBillingSetupRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBillingSetupRequest(ref request, ref callSettings);
            return _callMutateBillingSetup.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

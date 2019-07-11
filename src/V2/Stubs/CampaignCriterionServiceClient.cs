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

using gagvr = Google.Ads.GoogleAds.V2.Resources;
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

namespace Google.Ads.GoogleAds.V2.Services
{
    /// <summary>
    /// Settings for a <see cref="CampaignCriterionServiceClient"/>.
    /// </summary>
    public sealed partial class CampaignCriterionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CampaignCriterionServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="CampaignCriterionServiceSettings"/>.
        /// </returns>
        public static CampaignCriterionServiceSettings GetDefault() => new CampaignCriterionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignCriterionServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignCriterionServiceSettings() { }

        private CampaignCriterionServiceSettings(CampaignCriterionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignCriterionSettings = existing.GetCampaignCriterionSettings;
            MutateCampaignCriteriaSettings = existing.MutateCampaignCriteriaSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignCriterionServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="CampaignCriterionServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="CampaignCriterionServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="CampaignCriterionServiceClient"/> RPC methods is defined as:
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
        /// <c>CampaignCriterionServiceClient.GetCampaignCriterion</c> and <c>CampaignCriterionServiceClient.GetCampaignCriterionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignCriterionServiceClient.GetCampaignCriterion</c> and
        /// <c>CampaignCriterionServiceClient.GetCampaignCriterionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetCampaignCriterionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignCriterionServiceClient.MutateCampaignCriteria</c> and <c>CampaignCriterionServiceClient.MutateCampaignCriteriaAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>CampaignCriterionServiceClient.MutateCampaignCriteria</c> and
        /// <c>CampaignCriterionServiceClient.MutateCampaignCriteriaAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateCampaignCriteriaSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="CampaignCriterionServiceSettings"/> object.</returns>
        public CampaignCriterionServiceSettings Clone() => new CampaignCriterionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignCriterionServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class CampaignCriterionServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignCriterionServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public CampaignCriterionServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override CampaignCriterionServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignCriterionServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<CampaignCriterionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignCriterionServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => CampaignCriterionServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CampaignCriterionServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignCriterionServiceClient.ChannelPool;
    }

    /// <summary>
    /// CampaignCriterionService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class CampaignCriterionServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignCriterionService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default CampaignCriterionService scopes.
        /// </summary>
        /// <remarks>
        /// The default CampaignCriterionService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignCriterionServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V2.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CampaignCriterionServiceClient client = await CampaignCriterionServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V2.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CampaignCriterionServiceClient.DefaultEndpoint.Host, CampaignCriterionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CampaignCriterionServiceClient client = CampaignCriterionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CampaignCriterionServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="CampaignCriterionServiceClient"/>.</returns>
        public static async stt::Task<CampaignCriterionServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, CampaignCriterionServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="CampaignCriterionServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V2.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// CampaignCriterionServiceClient client = CampaignCriterionServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V2.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     CampaignCriterionServiceClient.DefaultEndpoint.Host, CampaignCriterionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// CampaignCriterionServiceClient client = CampaignCriterionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="CampaignCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignCriterionServiceClient"/>.</returns>
        public static CampaignCriterionServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, CampaignCriterionServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="CampaignCriterionServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CampaignCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignCriterionServiceClient"/>.</returns>
        public static CampaignCriterionServiceClient Create(grpccore::Channel channel, CampaignCriterionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="CampaignCriterionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="CampaignCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignCriterionServiceClient"/>.</returns>
        public static CampaignCriterionServiceClient Create(grpccore::CallInvoker callInvoker, CampaignCriterionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignCriterionService.CampaignCriterionServiceClient grpcClient = new CampaignCriterionService.CampaignCriterionServiceClient(callInvoker);
            return new CampaignCriterionServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, CampaignCriterionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CampaignCriterionServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, CampaignCriterionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, CampaignCriterionServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC CampaignCriterionService client.
        /// </summary>
        public virtual CampaignCriterionService.CampaignCriterionServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the criterion to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCampaignCriterionAsync(
                new GetCampaignCriterionRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the criterion to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetCampaignCriterionAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the criterion to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::CampaignCriterion GetCampaignCriterion(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetCampaignCriterion(
                new GetCampaignCriterionRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested criterion in full detail.
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
        public virtual stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(
            GetCampaignCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested criterion in full detail.
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
        public virtual stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(
            GetCampaignCriterionRequest request,
            st::CancellationToken cancellationToken) => GetCampaignCriterionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested criterion in full detail.
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
        public virtual gagvr::CampaignCriterion GetCampaignCriterion(
            GetCampaignCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual criteria.
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
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
            string customerId,
            scg::IEnumerable<CampaignCriterionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignCriteriaAsync(
                new MutateCampaignCriteriaRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual criteria.
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
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
            string customerId,
            scg::IEnumerable<CampaignCriterionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateCampaignCriteriaAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual criteria.
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
        public virtual MutateCampaignCriteriaResponse MutateCampaignCriteria(
            string customerId,
            scg::IEnumerable<CampaignCriterionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignCriteria(
                new MutateCampaignCriteriaRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
            string customerId,
            scg::IEnumerable<CampaignCriterionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignCriteriaAsync(
                new MutateCampaignCriteriaRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
            string customerId,
            scg::IEnumerable<CampaignCriterionOperation> operations,
            st::CancellationToken cancellationToken) => MutateCampaignCriteriaAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual criteria.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateCampaignCriteriaResponse MutateCampaignCriteria(
            string customerId,
            scg::IEnumerable<CampaignCriterionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateCampaignCriteria(
                new MutateCampaignCriteriaRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
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
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
            MutateCampaignCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
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
        public virtual stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
            MutateCampaignCriteriaRequest request,
            st::CancellationToken cancellationToken) => MutateCampaignCriteriaAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
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
        public virtual MutateCampaignCriteriaResponse MutateCampaignCriteria(
            MutateCampaignCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// CampaignCriterionService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class CampaignCriterionServiceClientImpl : CampaignCriterionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignCriterionRequest, gagvr::CampaignCriterion> _callGetCampaignCriterion;
        private readonly gaxgrpc::ApiCall<MutateCampaignCriteriaRequest, MutateCampaignCriteriaResponse> _callMutateCampaignCriteria;

        /// <summary>
        /// Constructs a client wrapper for the CampaignCriterionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignCriterionServiceSettings"/> used within this client </param>
        public CampaignCriterionServiceClientImpl(CampaignCriterionService.CampaignCriterionServiceClient grpcClient, CampaignCriterionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignCriterionServiceSettings effectiveSettings = settings ?? CampaignCriterionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCampaignCriterion = clientHelper.BuildApiCall<GetCampaignCriterionRequest, gagvr::CampaignCriterion>(
                GrpcClient.GetCampaignCriterionAsync, GrpcClient.GetCampaignCriterion, effectiveSettings.GetCampaignCriterionSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"resource_name={request.ResourceName}"));
            _callMutateCampaignCriteria = clientHelper.BuildApiCall<MutateCampaignCriteriaRequest, MutateCampaignCriteriaResponse>(
                GrpcClient.MutateCampaignCriteriaAsync, GrpcClient.MutateCampaignCriteria, effectiveSettings.MutateCampaignCriteriaSettings)
                .WithCallSettingsOverlay(request => gaxgrpc::CallSettings.FromHeader("x-goog-request-params", $"customer_id={request.CustomerId}"));
            Modify_ApiCall(ref _callGetCampaignCriterion);
            Modify_GetCampaignCriterionApiCall(ref _callGetCampaignCriterion);
            Modify_ApiCall(ref _callMutateCampaignCriteria);
            Modify_MutateCampaignCriteriaApiCall(ref _callMutateCampaignCriteria);
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
        partial void Modify_GetCampaignCriterionApiCall(ref gaxgrpc::ApiCall<GetCampaignCriterionRequest, gagvr::CampaignCriterion> call);
        partial void Modify_MutateCampaignCriteriaApiCall(ref gaxgrpc::ApiCall<MutateCampaignCriteriaRequest, MutateCampaignCriteriaResponse> call);
        partial void OnConstruction(CampaignCriterionService.CampaignCriterionServiceClient grpcClient, CampaignCriterionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC CampaignCriterionService client.
        /// </summary>
        public override CampaignCriterionService.CampaignCriterionServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetCampaignCriterionRequest(ref GetCampaignCriterionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateCampaignCriteriaRequest(ref MutateCampaignCriteriaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested criterion in full detail.
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
        public override stt::Task<gagvr::CampaignCriterion> GetCampaignCriterionAsync(
            GetCampaignCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignCriterionRequest(ref request, ref callSettings);
            return _callGetCampaignCriterion.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested criterion in full detail.
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
        public override gagvr::CampaignCriterion GetCampaignCriterion(
            GetCampaignCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignCriterionRequest(ref request, ref callSettings);
            return _callGetCampaignCriterion.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
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
        public override stt::Task<MutateCampaignCriteriaResponse> MutateCampaignCriteriaAsync(
            MutateCampaignCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignCriteriaRequest(ref request, ref callSettings);
            return _callMutateCampaignCriteria.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
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
        public override MutateCampaignCriteriaResponse MutateCampaignCriteria(
            MutateCampaignCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignCriteriaRequest(ref request, ref callSettings);
            return _callMutateCampaignCriteria.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

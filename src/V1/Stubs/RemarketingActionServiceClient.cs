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
    /// Settings for a <see cref="RemarketingActionServiceClient"/>.
    /// </summary>
    public sealed partial class RemarketingActionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="RemarketingActionServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="RemarketingActionServiceSettings"/>.
        /// </returns>
        public static RemarketingActionServiceSettings GetDefault() => new RemarketingActionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="RemarketingActionServiceSettings"/> object with default settings.
        /// </summary>
        public RemarketingActionServiceSettings() { }

        private RemarketingActionServiceSettings(RemarketingActionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetRemarketingActionSettings = existing.GetRemarketingActionSettings;
            MutateRemarketingActionsSettings = existing.MutateRemarketingActionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(RemarketingActionServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="RemarketingActionServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="RemarketingActionServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="RemarketingActionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="RemarketingActionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="RemarketingActionServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="RemarketingActionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="RemarketingActionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="RemarketingActionServiceClient"/> RPC methods is defined as:
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
        /// <c>RemarketingActionServiceClient.GetRemarketingAction</c> and <c>RemarketingActionServiceClient.GetRemarketingActionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>RemarketingActionServiceClient.GetRemarketingAction</c> and
        /// <c>RemarketingActionServiceClient.GetRemarketingActionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetRemarketingActionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>RemarketingActionServiceClient.MutateRemarketingActions</c> and <c>RemarketingActionServiceClient.MutateRemarketingActionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>RemarketingActionServiceClient.MutateRemarketingActions</c> and
        /// <c>RemarketingActionServiceClient.MutateRemarketingActionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateRemarketingActionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="RemarketingActionServiceSettings"/> object.</returns>
        public RemarketingActionServiceSettings Clone() => new RemarketingActionServiceSettings(this);
    }

    /// <summary>
    /// RemarketingActionService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class RemarketingActionServiceClient
    {
        /// <summary>
        /// The default endpoint for the RemarketingActionService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default RemarketingActionService scopes.
        /// </summary>
        /// <remarks>
        /// The default RemarketingActionService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="RemarketingActionServiceClient"/>, applying defaults for all unspecified settings,
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
        /// RemarketingActionServiceClient client = await RemarketingActionServiceClient.CreateAsync();
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
        ///     RemarketingActionServiceClient.DefaultEndpoint.Host, RemarketingActionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// RemarketingActionServiceClient client = RemarketingActionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="RemarketingActionServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="RemarketingActionServiceClient"/>.</returns>
        public static async stt::Task<RemarketingActionServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, RemarketingActionServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="RemarketingActionServiceClient"/>, applying defaults for all unspecified settings,
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
        /// RemarketingActionServiceClient client = RemarketingActionServiceClient.Create();
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
        ///     RemarketingActionServiceClient.DefaultEndpoint.Host, RemarketingActionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// RemarketingActionServiceClient client = RemarketingActionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="RemarketingActionServiceSettings"/>.</param>
        /// <returns>The created <see cref="RemarketingActionServiceClient"/>.</returns>
        public static RemarketingActionServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, RemarketingActionServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="RemarketingActionServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="RemarketingActionServiceSettings"/>.</param>
        /// <returns>The created <see cref="RemarketingActionServiceClient"/>.</returns>
        public static RemarketingActionServiceClient Create(grpccore::Channel channel, RemarketingActionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="RemarketingActionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="RemarketingActionServiceSettings"/>.</param>
        /// <returns>The created <see cref="RemarketingActionServiceClient"/>.</returns>
        public static RemarketingActionServiceClient Create(grpccore::CallInvoker callInvoker, RemarketingActionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            RemarketingActionService.RemarketingActionServiceClient grpcClient = new RemarketingActionService.RemarketingActionServiceClient(callInvoker);
            return new RemarketingActionServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, RemarketingActionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, RemarketingActionServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, RemarketingActionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, RemarketingActionServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC RemarketingActionService client.
        /// </summary>
        public virtual RemarketingActionService.RemarketingActionServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the remarketing action to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetRemarketingActionAsync(
                new GetRemarketingActionRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the remarketing action to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetRemarketingActionAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested remarketing action in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the remarketing action to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::RemarketingAction GetRemarketingAction(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetRemarketingAction(
                new GetRemarketingActionRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested remarketing action in full detail.
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
        public virtual stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(
            GetRemarketingActionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested remarketing action in full detail.
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
        public virtual stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(
            GetRemarketingActionRequest request,
            st::CancellationToken cancellationToken) => GetRemarketingActionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested remarketing action in full detail.
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
        public virtual gagvr::RemarketingAction GetRemarketingAction(
            GetRemarketingActionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose remarketing actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual remarketing actions.
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
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(
            string customerId,
            scg::IEnumerable<RemarketingActionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateRemarketingActionsAsync(
                new MutateRemarketingActionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose remarketing actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual remarketing actions.
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
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(
            string customerId,
            scg::IEnumerable<RemarketingActionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateRemarketingActionsAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose remarketing actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual remarketing actions.
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
        public virtual MutateRemarketingActionsResponse MutateRemarketingActions(
            string customerId,
            scg::IEnumerable<RemarketingActionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateRemarketingActions(
                new MutateRemarketingActionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose remarketing actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual remarketing actions.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(
            string customerId,
            scg::IEnumerable<RemarketingActionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateRemarketingActionsAsync(
                new MutateRemarketingActionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose remarketing actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual remarketing actions.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(
            string customerId,
            scg::IEnumerable<RemarketingActionOperation> operations,
            st::CancellationToken cancellationToken) => MutateRemarketingActionsAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose remarketing actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual remarketing actions.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateRemarketingActionsResponse MutateRemarketingActions(
            string customerId,
            scg::IEnumerable<RemarketingActionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateRemarketingActions(
                new MutateRemarketingActionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
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
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(
            MutateRemarketingActionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
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
        public virtual stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(
            MutateRemarketingActionsRequest request,
            st::CancellationToken cancellationToken) => MutateRemarketingActionsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
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
        public virtual MutateRemarketingActionsResponse MutateRemarketingActions(
            MutateRemarketingActionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// RemarketingActionService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class RemarketingActionServiceClientImpl : RemarketingActionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetRemarketingActionRequest, gagvr::RemarketingAction> _callGetRemarketingAction;
        private readonly gaxgrpc::ApiCall<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse> _callMutateRemarketingActions;

        /// <summary>
        /// Constructs a client wrapper for the RemarketingActionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="RemarketingActionServiceSettings"/> used within this client </param>
        public RemarketingActionServiceClientImpl(RemarketingActionService.RemarketingActionServiceClient grpcClient, RemarketingActionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            RemarketingActionServiceSettings effectiveSettings = settings ?? RemarketingActionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetRemarketingAction = clientHelper.BuildApiCall<GetRemarketingActionRequest, gagvr::RemarketingAction>(
                GrpcClient.GetRemarketingActionAsync, GrpcClient.GetRemarketingAction, effectiveSettings.GetRemarketingActionSettings);
            _callMutateRemarketingActions = clientHelper.BuildApiCall<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse>(
                GrpcClient.MutateRemarketingActionsAsync, GrpcClient.MutateRemarketingActions, effectiveSettings.MutateRemarketingActionsSettings);
            Modify_ApiCall(ref _callGetRemarketingAction);
            Modify_GetRemarketingActionApiCall(ref _callGetRemarketingAction);
            Modify_ApiCall(ref _callMutateRemarketingActions);
            Modify_MutateRemarketingActionsApiCall(ref _callMutateRemarketingActions);
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
        partial void Modify_GetRemarketingActionApiCall(ref gaxgrpc::ApiCall<GetRemarketingActionRequest, gagvr::RemarketingAction> call);
        partial void Modify_MutateRemarketingActionsApiCall(ref gaxgrpc::ApiCall<MutateRemarketingActionsRequest, MutateRemarketingActionsResponse> call);
        partial void OnConstruction(RemarketingActionService.RemarketingActionServiceClient grpcClient, RemarketingActionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC RemarketingActionService client.
        /// </summary>
        public override RemarketingActionService.RemarketingActionServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetRemarketingActionRequest(ref GetRemarketingActionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateRemarketingActionsRequest(ref MutateRemarketingActionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested remarketing action in full detail.
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
        public override stt::Task<gagvr::RemarketingAction> GetRemarketingActionAsync(
            GetRemarketingActionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRemarketingActionRequest(ref request, ref callSettings);
            return _callGetRemarketingAction.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested remarketing action in full detail.
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
        public override gagvr::RemarketingAction GetRemarketingAction(
            GetRemarketingActionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetRemarketingActionRequest(ref request, ref callSettings);
            return _callGetRemarketingAction.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
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
        public override stt::Task<MutateRemarketingActionsResponse> MutateRemarketingActionsAsync(
            MutateRemarketingActionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRemarketingActionsRequest(ref request, ref callSettings);
            return _callMutateRemarketingActions.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates remarketing actions. Operation statuses are returned.
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
        public override MutateRemarketingActionsResponse MutateRemarketingActions(
            MutateRemarketingActionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateRemarketingActionsRequest(ref request, ref callSettings);
            return _callMutateRemarketingActions.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

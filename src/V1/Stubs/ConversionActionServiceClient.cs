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
    /// Settings for a <see cref="ConversionActionServiceClient"/>.
    /// </summary>
    public sealed partial class ConversionActionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ConversionActionServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ConversionActionServiceSettings"/>.
        /// </returns>
        public static ConversionActionServiceSettings GetDefault() => new ConversionActionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionActionServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionActionServiceSettings() { }

        private ConversionActionServiceSettings(ConversionActionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetConversionActionSettings = existing.GetConversionActionSettings;
            MutateConversionActionsSettings = existing.MutateConversionActionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionActionServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ConversionActionServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ConversionActionServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ConversionActionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ConversionActionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ConversionActionServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ConversionActionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ConversionActionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ConversionActionServiceClient"/> RPC methods is defined as:
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
        /// <c>ConversionActionServiceClient.GetConversionAction</c> and <c>ConversionActionServiceClient.GetConversionActionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConversionActionServiceClient.GetConversionAction</c> and
        /// <c>ConversionActionServiceClient.GetConversionActionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetConversionActionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionActionServiceClient.MutateConversionActions</c> and <c>ConversionActionServiceClient.MutateConversionActionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConversionActionServiceClient.MutateConversionActions</c> and
        /// <c>ConversionActionServiceClient.MutateConversionActionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateConversionActionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ConversionActionServiceSettings"/> object.</returns>
        public ConversionActionServiceSettings Clone() => new ConversionActionServiceSettings(this);
    }

    /// <summary>
    /// ConversionActionService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ConversionActionServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionActionService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default ConversionActionService scopes.
        /// </summary>
        /// <remarks>
        /// The default ConversionActionService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversionActionServiceClient"/>, applying defaults for all unspecified settings,
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
        /// ConversionActionServiceClient client = await ConversionActionServiceClient.CreateAsync();
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
        ///     ConversionActionServiceClient.DefaultEndpoint.Host, ConversionActionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ConversionActionServiceClient client = ConversionActionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConversionActionServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ConversionActionServiceClient"/>.</returns>
        public static async stt::Task<ConversionActionServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ConversionActionServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ConversionActionServiceClient"/>, applying defaults for all unspecified settings,
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
        /// ConversionActionServiceClient client = ConversionActionServiceClient.Create();
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
        ///     ConversionActionServiceClient.DefaultEndpoint.Host, ConversionActionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ConversionActionServiceClient client = ConversionActionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConversionActionServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionActionServiceClient"/>.</returns>
        public static ConversionActionServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ConversionActionServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ConversionActionServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ConversionActionServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionActionServiceClient"/>.</returns>
        public static ConversionActionServiceClient Create(grpccore::Channel channel, ConversionActionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ConversionActionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ConversionActionServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionActionServiceClient"/>.</returns>
        public static ConversionActionServiceClient Create(grpccore::CallInvoker callInvoker, ConversionActionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionActionService.ConversionActionServiceClient grpcClient = new ConversionActionService.ConversionActionServiceClient(callInvoker);
            return new ConversionActionServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ConversionActionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ConversionActionServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ConversionActionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ConversionActionServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ConversionActionService client.
        /// </summary>
        public virtual ConversionActionService.ConversionActionServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the conversion action to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::ConversionAction> GetConversionActionAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetConversionActionAsync(
                new GetConversionActionRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the conversion action to fetch.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<gagvr::ConversionAction> GetConversionActionAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetConversionActionAsync(
                resourceName,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested conversion action.
        /// </summary>
        /// <param name="resourceName">
        /// The resource name of the conversion action to fetch.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual gagvr::ConversionAction GetConversionAction(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetConversionAction(
                new GetConversionActionRequest
                {
                    ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                },
                callSettings);

        /// <summary>
        /// Returns the requested conversion action.
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
        public virtual stt::Task<gagvr::ConversionAction> GetConversionActionAsync(
            GetConversionActionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Returns the requested conversion action.
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
        public virtual stt::Task<gagvr::ConversionAction> GetConversionActionAsync(
            GetConversionActionRequest request,
            st::CancellationToken cancellationToken) => GetConversionActionAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested conversion action.
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
        public virtual gagvr::ConversionAction GetConversionAction(
            GetConversionActionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose conversion actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual conversion actions.
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
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(
            string customerId,
            scg::IEnumerable<ConversionActionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateConversionActionsAsync(
                new MutateConversionActionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose conversion actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual conversion actions.
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
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(
            string customerId,
            scg::IEnumerable<ConversionActionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateConversionActionsAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose conversion actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual conversion actions.
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
        public virtual MutateConversionActionsResponse MutateConversionActions(
            string customerId,
            scg::IEnumerable<ConversionActionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateConversionActions(
                new MutateConversionActionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose conversion actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual conversion actions.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(
            string customerId,
            scg::IEnumerable<ConversionActionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateConversionActionsAsync(
                new MutateConversionActionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose conversion actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual conversion actions.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(
            string customerId,
            scg::IEnumerable<ConversionActionOperation> operations,
            st::CancellationToken cancellationToken) => MutateConversionActionsAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer whose conversion actions are being modified.
        /// </param>
        /// <param name="operations">
        /// The list of operations to perform on individual conversion actions.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual MutateConversionActionsResponse MutateConversionActions(
            string customerId,
            scg::IEnumerable<ConversionActionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateConversionActions(
                new MutateConversionActionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
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
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(
            MutateConversionActionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
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
        public virtual stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(
            MutateConversionActionsRequest request,
            st::CancellationToken cancellationToken) => MutateConversionActionsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
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
        public virtual MutateConversionActionsResponse MutateConversionActions(
            MutateConversionActionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ConversionActionService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ConversionActionServiceClientImpl : ConversionActionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetConversionActionRequest, gagvr::ConversionAction> _callGetConversionAction;
        private readonly gaxgrpc::ApiCall<MutateConversionActionsRequest, MutateConversionActionsResponse> _callMutateConversionActions;

        /// <summary>
        /// Constructs a client wrapper for the ConversionActionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConversionActionServiceSettings"/> used within this client </param>
        public ConversionActionServiceClientImpl(ConversionActionService.ConversionActionServiceClient grpcClient, ConversionActionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ConversionActionServiceSettings effectiveSettings = settings ?? ConversionActionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetConversionAction = clientHelper.BuildApiCall<GetConversionActionRequest, gagvr::ConversionAction>(
                GrpcClient.GetConversionActionAsync, GrpcClient.GetConversionAction, effectiveSettings.GetConversionActionSettings);
            _callMutateConversionActions = clientHelper.BuildApiCall<MutateConversionActionsRequest, MutateConversionActionsResponse>(
                GrpcClient.MutateConversionActionsAsync, GrpcClient.MutateConversionActions, effectiveSettings.MutateConversionActionsSettings);
            Modify_ApiCall(ref _callGetConversionAction);
            Modify_GetConversionActionApiCall(ref _callGetConversionAction);
            Modify_ApiCall(ref _callMutateConversionActions);
            Modify_MutateConversionActionsApiCall(ref _callMutateConversionActions);
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
        partial void Modify_GetConversionActionApiCall(ref gaxgrpc::ApiCall<GetConversionActionRequest, gagvr::ConversionAction> call);
        partial void Modify_MutateConversionActionsApiCall(ref gaxgrpc::ApiCall<MutateConversionActionsRequest, MutateConversionActionsResponse> call);
        partial void OnConstruction(ConversionActionService.ConversionActionServiceClient grpcClient, ConversionActionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ConversionActionService client.
        /// </summary>
        public override ConversionActionService.ConversionActionServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetConversionActionRequest(ref GetConversionActionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateConversionActionsRequest(ref MutateConversionActionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested conversion action.
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
        public override stt::Task<gagvr::ConversionAction> GetConversionActionAsync(
            GetConversionActionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionActionRequest(ref request, ref callSettings);
            return _callGetConversionAction.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested conversion action.
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
        public override gagvr::ConversionAction GetConversionAction(
            GetConversionActionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionActionRequest(ref request, ref callSettings);
            return _callGetConversionAction.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
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
        public override stt::Task<MutateConversionActionsResponse> MutateConversionActionsAsync(
            MutateConversionActionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionActionsRequest(ref request, ref callSettings);
            return _callMutateConversionActions.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes conversion actions. Operation statuses are
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
        public override MutateConversionActionsResponse MutateConversionActions(
            MutateConversionActionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionActionsRequest(ref request, ref callSettings);
            return _callMutateConversionActions.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

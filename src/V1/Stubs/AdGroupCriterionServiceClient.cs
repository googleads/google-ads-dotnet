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
    /// Settings for a <see cref="AdGroupCriterionServiceClient"/>.
    /// </summary>
    public sealed partial class AdGroupCriterionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AdGroupCriterionServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="AdGroupCriterionServiceSettings"/>.
        /// </returns>
        public static AdGroupCriterionServiceSettings GetDefault() => new AdGroupCriterionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupCriterionServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupCriterionServiceSettings() { }

        private AdGroupCriterionServiceSettings(AdGroupCriterionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupCriterionSettings = existing.GetAdGroupCriterionSettings;
            MutateAdGroupCriteriaSettings = existing.MutateAdGroupCriteriaSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupCriterionServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="AdGroupCriterionServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="AdGroupCriterionServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="AdGroupCriterionServiceClient"/> RPC methods is defined as:
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
        /// <c>AdGroupCriterionServiceClient.GetAdGroupCriterion</c> and <c>AdGroupCriterionServiceClient.GetAdGroupCriterionAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AdGroupCriterionServiceClient.GetAdGroupCriterion</c> and
        /// <c>AdGroupCriterionServiceClient.GetAdGroupCriterionAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings GetAdGroupCriterionSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: IdempotentRetryFilter
            )));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupCriterionServiceClient.MutateAdGroupCriteria</c> and <c>AdGroupCriterionServiceClient.MutateAdGroupCriteriaAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>AdGroupCriterionServiceClient.MutateAdGroupCriteria</c> and
        /// <c>AdGroupCriterionServiceClient.MutateAdGroupCriteriaAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings MutateAdGroupCriteriaSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="AdGroupCriterionServiceSettings"/> object.</returns>
        public AdGroupCriterionServiceSettings Clone() => new AdGroupCriterionServiceSettings(this);
    }

    /// <summary>
    /// AdGroupCriterionService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class AdGroupCriterionServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupCriterionService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default AdGroupCriterionService scopes.
        /// </summary>
        /// <remarks>
        /// The default AdGroupCriterionService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupCriterionServiceClient"/>, applying defaults for all unspecified settings,
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
        /// AdGroupCriterionServiceClient client = await AdGroupCriterionServiceClient.CreateAsync();
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
        ///     AdGroupCriterionServiceClient.DefaultEndpoint.Host, AdGroupCriterionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AdGroupCriterionServiceClient client = AdGroupCriterionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AdGroupCriterionServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="AdGroupCriterionServiceClient"/>.</returns>
        public static async stt::Task<AdGroupCriterionServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, AdGroupCriterionServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupCriterionServiceClient"/>, applying defaults for all unspecified settings,
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
        /// AdGroupCriterionServiceClient client = AdGroupCriterionServiceClient.Create();
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
        ///     AdGroupCriterionServiceClient.DefaultEndpoint.Host, AdGroupCriterionServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// AdGroupCriterionServiceClient client = AdGroupCriterionServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="AdGroupCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupCriterionServiceClient"/>.</returns>
        public static AdGroupCriterionServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, AdGroupCriterionServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="AdGroupCriterionServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AdGroupCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupCriterionServiceClient"/>.</returns>
        public static AdGroupCriterionServiceClient Create(grpccore::Channel channel, AdGroupCriterionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="AdGroupCriterionServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="AdGroupCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupCriterionServiceClient"/>.</returns>
        public static AdGroupCriterionServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupCriterionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupCriterionService.AdGroupCriterionServiceClient grpcClient = new AdGroupCriterionService.AdGroupCriterionServiceClient(callInvoker);
            return new AdGroupCriterionServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, AdGroupCriterionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AdGroupCriterionServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, AdGroupCriterionServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, AdGroupCriterionServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC AdGroupCriterionService client.
        /// </summary>
        public virtual AdGroupCriterionService.AdGroupCriterionServiceClient GrpcClient
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
        public virtual stt::Task<gagvr::AdGroupCriterion> GetAdGroupCriterionAsync(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetAdGroupCriterionAsync(
                new GetAdGroupCriterionRequest
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
        public virtual stt::Task<gagvr::AdGroupCriterion> GetAdGroupCriterionAsync(
            string resourceName,
            st::CancellationToken cancellationToken) => GetAdGroupCriterionAsync(
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
        public virtual gagvr::AdGroupCriterion GetAdGroupCriterion(
            string resourceName,
            gaxgrpc::CallSettings callSettings = null) => GetAdGroupCriterion(
                new GetAdGroupCriterionRequest
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
        public virtual stt::Task<gagvr::AdGroupCriterion> GetAdGroupCriterionAsync(
            GetAdGroupCriterionRequest request,
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
        public virtual stt::Task<gagvr::AdGroupCriterion> GetAdGroupCriterionAsync(
            GetAdGroupCriterionRequest request,
            st::CancellationToken cancellationToken) => GetAdGroupCriterionAsync(
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
        public virtual gagvr::AdGroupCriterion GetAdGroupCriterion(
            GetAdGroupCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// ID of the customer whose criteria are being modified.
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
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
            string customerId,
            scg::IEnumerable<AdGroupCriterionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupCriteriaAsync(
                new MutateAdGroupCriteriaRequest
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
        /// ID of the customer whose criteria are being modified.
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
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
            string customerId,
            scg::IEnumerable<AdGroupCriterionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => MutateAdGroupCriteriaAsync(
                customerId,
                operations,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// ID of the customer whose criteria are being modified.
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
        public virtual MutateAdGroupCriteriaResponse MutateAdGroupCriteria(
            string customerId,
            scg::IEnumerable<AdGroupCriterionOperation> operations,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupCriteria(
                new MutateAdGroupCriteriaRequest
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
        /// ID of the customer whose criteria are being modified.
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
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
            string customerId,
            scg::IEnumerable<AdGroupCriterionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupCriteriaAsync(
                new MutateAdGroupCriteriaRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Operations = { gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)) },
                },
                callSettings);

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// ID of the customer whose criteria are being modified.
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
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
            string customerId,
            scg::IEnumerable<AdGroupCriterionOperation> operations,
            st::CancellationToken cancellationToken) => MutateAdGroupCriteriaAsync(
                customerId,
                operations,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// ID of the customer whose criteria are being modified.
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
        public virtual MutateAdGroupCriteriaResponse MutateAdGroupCriteria(
            string customerId,
            scg::IEnumerable<AdGroupCriterionOperation> operations,
            gaxgrpc::CallSettings callSettings = null) => MutateAdGroupCriteria(
                new MutateAdGroupCriteriaRequest
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
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
            MutateAdGroupCriteriaRequest request,
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
        public virtual stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
            MutateAdGroupCriteriaRequest request,
            st::CancellationToken cancellationToken) => MutateAdGroupCriteriaAsync(
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
        public virtual MutateAdGroupCriteriaResponse MutateAdGroupCriteria(
            MutateAdGroupCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// AdGroupCriterionService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class AdGroupCriterionServiceClientImpl : AdGroupCriterionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupCriterionRequest, gagvr::AdGroupCriterion> _callGetAdGroupCriterion;
        private readonly gaxgrpc::ApiCall<MutateAdGroupCriteriaRequest, MutateAdGroupCriteriaResponse> _callMutateAdGroupCriteria;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupCriterionService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdGroupCriterionServiceSettings"/> used within this client </param>
        public AdGroupCriterionServiceClientImpl(AdGroupCriterionService.AdGroupCriterionServiceClient grpcClient, AdGroupCriterionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupCriterionServiceSettings effectiveSettings = settings ?? AdGroupCriterionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupCriterion = clientHelper.BuildApiCall<GetAdGroupCriterionRequest, gagvr::AdGroupCriterion>(
                GrpcClient.GetAdGroupCriterionAsync, GrpcClient.GetAdGroupCriterion, effectiveSettings.GetAdGroupCriterionSettings);
            _callMutateAdGroupCriteria = clientHelper.BuildApiCall<MutateAdGroupCriteriaRequest, MutateAdGroupCriteriaResponse>(
                GrpcClient.MutateAdGroupCriteriaAsync, GrpcClient.MutateAdGroupCriteria, effectiveSettings.MutateAdGroupCriteriaSettings);
            Modify_ApiCall(ref _callGetAdGroupCriterion);
            Modify_GetAdGroupCriterionApiCall(ref _callGetAdGroupCriterion);
            Modify_ApiCall(ref _callMutateAdGroupCriteria);
            Modify_MutateAdGroupCriteriaApiCall(ref _callMutateAdGroupCriteria);
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
        partial void Modify_GetAdGroupCriterionApiCall(ref gaxgrpc::ApiCall<GetAdGroupCriterionRequest, gagvr::AdGroupCriterion> call);
        partial void Modify_MutateAdGroupCriteriaApiCall(ref gaxgrpc::ApiCall<MutateAdGroupCriteriaRequest, MutateAdGroupCriteriaResponse> call);
        partial void OnConstruction(AdGroupCriterionService.AdGroupCriterionServiceClient grpcClient, AdGroupCriterionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC AdGroupCriterionService client.
        /// </summary>
        public override AdGroupCriterionService.AdGroupCriterionServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_GetAdGroupCriterionRequest(ref GetAdGroupCriterionRequest request, ref gaxgrpc::CallSettings settings);
        partial void Modify_MutateAdGroupCriteriaRequest(ref MutateAdGroupCriteriaRequest request, ref gaxgrpc::CallSettings settings);

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
        public override stt::Task<gagvr::AdGroupCriterion> GetAdGroupCriterionAsync(
            GetAdGroupCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupCriterionRequest(ref request, ref callSettings);
            return _callGetAdGroupCriterion.Async(request, callSettings);
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
        public override gagvr::AdGroupCriterion GetAdGroupCriterion(
            GetAdGroupCriterionRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupCriterionRequest(ref request, ref callSettings);
            return _callGetAdGroupCriterion.Sync(request, callSettings);
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
        public override stt::Task<MutateAdGroupCriteriaResponse> MutateAdGroupCriteriaAsync(
            MutateAdGroupCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupCriteriaRequest(ref request, ref callSettings);
            return _callMutateAdGroupCriteria.Async(request, callSettings);
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
        public override MutateAdGroupCriteriaResponse MutateAdGroupCriteria(
            MutateAdGroupCriteriaRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupCriteriaRequest(ref request, ref callSettings);
            return _callMutateAdGroupCriteria.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

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
    /// Settings for a <see cref="ConversionUploadServiceClient"/>.
    /// </summary>
    public sealed partial class ConversionUploadServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ConversionUploadServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ConversionUploadServiceSettings"/>.
        /// </returns>
        public static ConversionUploadServiceSettings GetDefault() => new ConversionUploadServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionUploadServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionUploadServiceSettings() { }

        private ConversionUploadServiceSettings(ConversionUploadServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UploadClickConversionsSettings = existing.UploadClickConversionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionUploadServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ConversionUploadServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ConversionUploadServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ConversionUploadServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ConversionUploadServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ConversionUploadServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ConversionUploadServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ConversionUploadServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ConversionUploadServiceClient"/> RPC methods is defined as:
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
        /// <c>ConversionUploadServiceClient.UploadClickConversions</c> and <c>ConversionUploadServiceClient.UploadClickConversionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConversionUploadServiceClient.UploadClickConversions</c> and
        /// <c>ConversionUploadServiceClient.UploadClickConversionsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UploadClickConversionsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ConversionUploadServiceSettings"/> object.</returns>
        public ConversionUploadServiceSettings Clone() => new ConversionUploadServiceSettings(this);
    }

    /// <summary>
    /// ConversionUploadService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ConversionUploadServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionUploadService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default ConversionUploadService scopes.
        /// </summary>
        /// <remarks>
        /// The default ConversionUploadService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversionUploadServiceClient"/>, applying defaults for all unspecified settings,
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
        /// ConversionUploadServiceClient client = await ConversionUploadServiceClient.CreateAsync();
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
        ///     ConversionUploadServiceClient.DefaultEndpoint.Host, ConversionUploadServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ConversionUploadServiceClient client = ConversionUploadServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConversionUploadServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ConversionUploadServiceClient"/>.</returns>
        public static async stt::Task<ConversionUploadServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ConversionUploadServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ConversionUploadServiceClient"/>, applying defaults for all unspecified settings,
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
        /// ConversionUploadServiceClient client = ConversionUploadServiceClient.Create();
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
        ///     ConversionUploadServiceClient.DefaultEndpoint.Host, ConversionUploadServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ConversionUploadServiceClient client = ConversionUploadServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConversionUploadServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionUploadServiceClient"/>.</returns>
        public static ConversionUploadServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ConversionUploadServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ConversionUploadServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ConversionUploadServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionUploadServiceClient"/>.</returns>
        public static ConversionUploadServiceClient Create(grpccore::Channel channel, ConversionUploadServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ConversionUploadServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ConversionUploadServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionUploadServiceClient"/>.</returns>
        public static ConversionUploadServiceClient Create(grpccore::CallInvoker callInvoker, ConversionUploadServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionUploadService.ConversionUploadServiceClient grpcClient = new ConversionUploadService.ConversionUploadServiceClient(callInvoker);
            return new ConversionUploadServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ConversionUploadServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ConversionUploadServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ConversionUploadServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ConversionUploadServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ConversionUploadService client.
        /// </summary>
        public virtual ConversionUploadService.ConversionUploadServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// The conversions that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// This should always be set to true.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(
            string customerId,
            scg::IEnumerable<ClickConversion> conversions,
            bool? partialFailure,
            gaxgrpc::CallSettings callSettings = null) => UploadClickConversionsAsync(
                new UploadClickConversionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Conversions = { gax::GaxPreconditions.CheckNotNull(conversions, nameof(conversions)) },
                    PartialFailure = partialFailure ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// The conversions that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// This should always be set to true.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(
            string customerId,
            scg::IEnumerable<ClickConversion> conversions,
            bool? partialFailure,
            st::CancellationToken cancellationToken) => UploadClickConversionsAsync(
                customerId,
                conversions,
                partialFailure,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// The conversions that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// This should always be set to true.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UploadClickConversionsResponse UploadClickConversions(
            string customerId,
            scg::IEnumerable<ClickConversion> conversions,
            bool? partialFailure,
            gaxgrpc::CallSettings callSettings = null) => UploadClickConversions(
                new UploadClickConversionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Conversions = { gax::GaxPreconditions.CheckNotNull(conversions, nameof(conversions)) },
                    PartialFailure = partialFailure ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// The conversions that are being uploaded.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(
            string customerId,
            scg::IEnumerable<ClickConversion> conversions,
            gaxgrpc::CallSettings callSettings = null) => UploadClickConversionsAsync(
                new UploadClickConversionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Conversions = { gax::GaxPreconditions.CheckNotNull(conversions, nameof(conversions)) },
                },
                callSettings);

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// The conversions that are being uploaded.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(
            string customerId,
            scg::IEnumerable<ClickConversion> conversions,
            st::CancellationToken cancellationToken) => UploadClickConversionsAsync(
                customerId,
                conversions,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="customerId">
        /// The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// The conversions that are being uploaded.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UploadClickConversionsResponse UploadClickConversions(
            string customerId,
            scg::IEnumerable<ClickConversion> conversions,
            gaxgrpc::CallSettings callSettings = null) => UploadClickConversions(
                new UploadClickConversionsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    Conversions = { gax::GaxPreconditions.CheckNotNull(conversions, nameof(conversions)) },
                },
                callSettings);

        /// <summary>
        /// Processes the given click conversions.
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
        public virtual stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(
            UploadClickConversionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Processes the given click conversions.
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
        public virtual stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(
            UploadClickConversionsRequest request,
            st::CancellationToken cancellationToken) => UploadClickConversionsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes the given click conversions.
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
        public virtual UploadClickConversionsResponse UploadClickConversions(
            UploadClickConversionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ConversionUploadService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ConversionUploadServiceClientImpl : ConversionUploadServiceClient
    {
        private readonly gaxgrpc::ApiCall<UploadClickConversionsRequest, UploadClickConversionsResponse> _callUploadClickConversions;

        /// <summary>
        /// Constructs a client wrapper for the ConversionUploadService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConversionUploadServiceSettings"/> used within this client </param>
        public ConversionUploadServiceClientImpl(ConversionUploadService.ConversionUploadServiceClient grpcClient, ConversionUploadServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ConversionUploadServiceSettings effectiveSettings = settings ?? ConversionUploadServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callUploadClickConversions = clientHelper.BuildApiCall<UploadClickConversionsRequest, UploadClickConversionsResponse>(
                GrpcClient.UploadClickConversionsAsync, GrpcClient.UploadClickConversions, effectiveSettings.UploadClickConversionsSettings);
            Modify_ApiCall(ref _callUploadClickConversions);
            Modify_UploadClickConversionsApiCall(ref _callUploadClickConversions);
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
        partial void Modify_UploadClickConversionsApiCall(ref gaxgrpc::ApiCall<UploadClickConversionsRequest, UploadClickConversionsResponse> call);
        partial void OnConstruction(ConversionUploadService.ConversionUploadServiceClient grpcClient, ConversionUploadServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ConversionUploadService client.
        /// </summary>
        public override ConversionUploadService.ConversionUploadServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_UploadClickConversionsRequest(ref UploadClickConversionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Processes the given click conversions.
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
        public override stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(
            UploadClickConversionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadClickConversionsRequest(ref request, ref callSettings);
            return _callUploadClickConversions.Async(request, callSettings);
        }

        /// <summary>
        /// Processes the given click conversions.
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
        public override UploadClickConversionsResponse UploadClickConversions(
            UploadClickConversionsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadClickConversionsRequest(ref request, ref callSettings);
            return _callUploadClickConversions.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

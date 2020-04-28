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

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>
    /// Settings for a <see cref="ConversionAdjustmentUploadServiceClient"/>.
    /// </summary>
    public sealed partial class ConversionAdjustmentUploadServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ConversionAdjustmentUploadServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ConversionAdjustmentUploadServiceSettings"/>.
        /// </returns>
        public static ConversionAdjustmentUploadServiceSettings GetDefault() => new ConversionAdjustmentUploadServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionAdjustmentUploadServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionAdjustmentUploadServiceSettings() { }

        private ConversionAdjustmentUploadServiceSettings(ConversionAdjustmentUploadServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UploadConversionAdjustmentsSettings = existing.UploadConversionAdjustmentsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionAdjustmentUploadServiceSettings existing);

        /// <summary>
        /// The filter specifying which RPC <see cref="grpccore::StatusCode"/>s are eligible for retry
        /// for "Idempotent" <see cref="ConversionAdjustmentUploadServiceClient"/> RPC methods.
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
        /// for "NonIdempotent" <see cref="ConversionAdjustmentUploadServiceClient"/> RPC methods.
        /// </summary>
        /// <remarks>
        /// There are no RPC <see cref="grpccore::StatusCode"/>s eligible for retry for "NonIdempotent" RPC methods.
        /// </remarks>
        public static sys::Predicate<grpccore::RpcException> NonIdempotentRetryFilter { get; } =
            gaxgrpc::RetrySettings.FilterForStatusCodes();

        /// <summary>
        /// "Default" retry backoff for <see cref="ConversionAdjustmentUploadServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" retry backoff for <see cref="ConversionAdjustmentUploadServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" retry backoff for <see cref="ConversionAdjustmentUploadServiceClient"/> RPC methods is defined as:
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
        /// "Default" timeout backoff for <see cref="ConversionAdjustmentUploadServiceClient"/> RPC methods.
        /// </summary>
        /// <returns>
        /// The "Default" timeout backoff for <see cref="ConversionAdjustmentUploadServiceClient"/> RPC methods.
        /// </returns>
        /// <remarks>
        /// The "Default" timeout backoff for <see cref="ConversionAdjustmentUploadServiceClient"/> RPC methods is defined as:
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
        /// <c>ConversionAdjustmentUploadServiceClient.UploadConversionAdjustments</c> and <c>ConversionAdjustmentUploadServiceClient.UploadConversionAdjustmentsAsync</c>.
        /// </summary>
        /// <remarks>
        /// The default <c>ConversionAdjustmentUploadServiceClient.UploadConversionAdjustments</c> and
        /// <c>ConversionAdjustmentUploadServiceClient.UploadConversionAdjustmentsAsync</c> <see cref="gaxgrpc::RetrySettings"/> are:
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
        public gaxgrpc::CallSettings UploadConversionAdjustmentsSettings { get; set; } = gaxgrpc::CallSettings.FromCallTiming(
            gaxgrpc::CallTiming.FromRetry(new gaxgrpc::RetrySettings(
                retryBackoff: GetDefaultRetryBackoff(),
                timeoutBackoff: GetDefaultTimeoutBackoff(),
                totalExpiration: gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000)),
                retryFilter: NonIdempotentRetryFilter
            )));

        /// <summary>
        /// Creates a deep clone of this object, with all the same property values.
        /// </summary>
        /// <returns>A deep clone of this <see cref="ConversionAdjustmentUploadServiceSettings"/> object.</returns>
        public ConversionAdjustmentUploadServiceSettings Clone() => new ConversionAdjustmentUploadServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversionAdjustmentUploadServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class ConversionAdjustmentUploadServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversionAdjustmentUploadServiceClient>
    {
        /// <summary>
        /// The settings to use for RPCs, or null for the default settings.
        /// </summary>
        public ConversionAdjustmentUploadServiceSettings Settings { get; set; }

        /// <inheritdoc/>
        public override ConversionAdjustmentUploadServiceClient Build()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversionAdjustmentUploadServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        public override async stt::Task<ConversionAdjustmentUploadServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversionAdjustmentUploadServiceClient.Create(callInvoker, Settings);
        }

        /// <inheritdoc />
        protected override gaxgrpc::ServiceEndpoint GetDefaultEndpoint() => ConversionAdjustmentUploadServiceClient.DefaultEndpoint;

        /// <inheritdoc />
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ConversionAdjustmentUploadServiceClient.DefaultScopes;

        /// <inheritdoc />
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversionAdjustmentUploadServiceClient.ChannelPool;
    }

    /// <summary>
    /// ConversionAdjustmentUploadService client wrapper, for convenient use.
    /// </summary>
    public abstract partial class ConversionAdjustmentUploadServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionAdjustmentUploadService service, which is a host of "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static gaxgrpc::ServiceEndpoint DefaultEndpoint { get; } = new gaxgrpc::ServiceEndpoint("googleads.googleapis.com", 443);

        /// <summary>
        /// The default ConversionAdjustmentUploadService scopes.
        /// </summary>
        /// <remarks>
        /// The default ConversionAdjustmentUploadService scopes are:
        /// <list type="bullet">
        /// </list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] {
        });

        private static readonly gaxgrpc::ChannelPool s_channelPool = new gaxgrpc::ChannelPool(DefaultScopes);

        internal static gaxgrpc::ChannelPool ChannelPool => s_channelPool;

        /// <summary>
        /// Asynchronously creates a <see cref="ConversionAdjustmentUploadServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ConversionAdjustmentUploadServiceClient client = await ConversionAdjustmentUploadServiceClient.CreateAsync();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ConversionAdjustmentUploadServiceClient.DefaultEndpoint.Host, ConversionAdjustmentUploadServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ConversionAdjustmentUploadServiceClient client = ConversionAdjustmentUploadServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// await channel.ShutdownAsync();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConversionAdjustmentUploadServiceSettings"/>.</param>
        /// <returns>The task representing the created <see cref="ConversionAdjustmentUploadServiceClient"/>.</returns>
        public static async stt::Task<ConversionAdjustmentUploadServiceClient> CreateAsync(gaxgrpc::ServiceEndpoint endpoint = null, ConversionAdjustmentUploadServiceSettings settings = null)
        {
            grpccore::Channel channel = await s_channelPool.GetChannelAsync(endpoint ?? DefaultEndpoint).ConfigureAwait(false);
            return Create(channel, settings);
        }

        /// <summary>
        /// Synchronously creates a <see cref="ConversionAdjustmentUploadServiceClient"/>, applying defaults for all unspecified settings,
        /// and creating a channel connecting to the given endpoint with application default credentials where
        /// necessary. See the example for how to use custom credentials.
        /// </summary>
        /// <example>
        /// This sample shows how to create a client using default credentials:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// ...
        /// // When running on Google Cloud Platform this will use the project Compute Credential.
        /// // Or set the GOOGLE_APPLICATION_CREDENTIALS environment variable to the path of a JSON
        /// // credential file to use that credential.
        /// ConversionAdjustmentUploadServiceClient client = ConversionAdjustmentUploadServiceClient.Create();
        /// </code>
        /// This sample shows how to create a client using credentials loaded from a JSON file:
        /// <code>
        /// using Google.Ads.GoogleAds.V3.Services;
        /// using Google.Apis.Auth.OAuth2;
        /// using Grpc.Auth;
        /// using Grpc.Core;
        /// ...
        /// GoogleCredential cred = GoogleCredential.FromFile("/path/to/credentials.json");
        /// Channel channel = new Channel(
        ///     ConversionAdjustmentUploadServiceClient.DefaultEndpoint.Host, ConversionAdjustmentUploadServiceClient.DefaultEndpoint.Port, cred.ToChannelCredentials());
        /// ConversionAdjustmentUploadServiceClient client = ConversionAdjustmentUploadServiceClient.Create(channel);
        /// ...
        /// // Shutdown the channel when it is no longer required.
        /// channel.ShutdownAsync().Wait();
        /// </code>
        /// </example>
        /// <param name="endpoint">Optional <see cref="gaxgrpc::ServiceEndpoint"/>.</param>
        /// <param name="settings">Optional <see cref="ConversionAdjustmentUploadServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionAdjustmentUploadServiceClient"/>.</returns>
        public static ConversionAdjustmentUploadServiceClient Create(gaxgrpc::ServiceEndpoint endpoint = null, ConversionAdjustmentUploadServiceSettings settings = null)
        {
            grpccore::Channel channel = s_channelPool.GetChannel(endpoint ?? DefaultEndpoint);
            return Create(channel, settings);
        }

        /// <summary>
        /// Creates a <see cref="ConversionAdjustmentUploadServiceClient"/> which uses the specified channel for remote operations.
        /// </summary>
        /// <param name="channel">The <see cref="grpccore::Channel"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ConversionAdjustmentUploadServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionAdjustmentUploadServiceClient"/>.</returns>
        public static ConversionAdjustmentUploadServiceClient Create(grpccore::Channel channel, ConversionAdjustmentUploadServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(channel, nameof(channel));
            return Create(new grpccore::DefaultCallInvoker(channel), settings);
        }

        /// <summary>
        /// Creates a <see cref="ConversionAdjustmentUploadServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.</param>
        /// <param name="settings">Optional <see cref="ConversionAdjustmentUploadServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionAdjustmentUploadServiceClient"/>.</returns>
        public static ConversionAdjustmentUploadServiceClient Create(grpccore::CallInvoker callInvoker, ConversionAdjustmentUploadServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpccore::Interceptors.Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpccore::Interceptors.CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient grpcClient = new ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient(callInvoker);
            return new ConversionAdjustmentUploadServiceClientImpl(grpcClient, settings);
        }

        /// <summary>
        /// Shuts down any channels automatically created by <see cref="Create(gaxgrpc::ServiceEndpoint, ConversionAdjustmentUploadServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ConversionAdjustmentUploadServiceSettings)"/>. Channels which weren't automatically
        /// created are not affected.
        /// </summary>
        /// <remarks>After calling this method, further calls to <see cref="Create(gaxgrpc::ServiceEndpoint, ConversionAdjustmentUploadServiceSettings)"/>
        /// and <see cref="CreateAsync(gaxgrpc::ServiceEndpoint, ConversionAdjustmentUploadServiceSettings)"/> will create new channels, which could
        /// in turn be shut down by another call to this method.</remarks>
        /// <returns>A task representing the asynchronous shutdown operation.</returns>
        public static stt::Task ShutdownDefaultChannelsAsync() => s_channelPool.ShutdownChannelsAsync();

        /// <summary>
        /// The underlying gRPC ConversionAdjustmentUploadService client.
        /// </summary>
        public virtual ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient GrpcClient
        {
            get { throw new sys::NotImplementedException(); }
        }

        /// <summary>
        /// Processes the given conversion adjustments.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversionAdjustments">
        /// Required. The conversion adjustments that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried out
        /// in one transaction if and only if they are all valid. This should always be
        /// set to true.
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
        public virtual stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(
            string customerId,
            scg::IEnumerable<ConversionAdjustment> conversionAdjustments,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => UploadConversionAdjustmentsAsync(
                new UploadConversionAdjustmentsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    ConversionAdjustments = { gax::GaxPreconditions.CheckNotNull(conversionAdjustments, nameof(conversionAdjustments)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Processes the given conversion adjustments.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversionAdjustments">
        /// Required. The conversion adjustments that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried out
        /// in one transaction if and only if they are all valid. This should always be
        /// set to true.
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
        public virtual stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(
            string customerId,
            scg::IEnumerable<ConversionAdjustment> conversionAdjustments,
            bool? partialFailure,
            bool? validateOnly,
            st::CancellationToken cancellationToken) => UploadConversionAdjustmentsAsync(
                customerId,
                conversionAdjustments,
                partialFailure,
                validateOnly,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes the given conversion adjustments.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversionAdjustments">
        /// Required. The conversion adjustments that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried out
        /// in one transaction if and only if they are all valid. This should always be
        /// set to true.
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
        public virtual UploadConversionAdjustmentsResponse UploadConversionAdjustments(
            string customerId,
            scg::IEnumerable<ConversionAdjustment> conversionAdjustments,
            bool? partialFailure,
            bool? validateOnly,
            gaxgrpc::CallSettings callSettings = null) => UploadConversionAdjustments(
                new UploadConversionAdjustmentsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    ConversionAdjustments = { gax::GaxPreconditions.CheckNotNull(conversionAdjustments, nameof(conversionAdjustments)) },
                    PartialFailure = partialFailure ?? false, // Optional
                    ValidateOnly = validateOnly ?? false, // Optional
                },
                callSettings);

        /// <summary>
        /// Processes the given conversion adjustments.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversionAdjustments">
        /// Required. The conversion adjustments that are being uploaded.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(
            string customerId,
            scg::IEnumerable<ConversionAdjustment> conversionAdjustments,
            gaxgrpc::CallSettings callSettings = null) => UploadConversionAdjustmentsAsync(
                new UploadConversionAdjustmentsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    ConversionAdjustments = { gax::GaxPreconditions.CheckNotNull(conversionAdjustments, nameof(conversionAdjustments)) },
                },
                callSettings);

        /// <summary>
        /// Processes the given conversion adjustments.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversionAdjustments">
        /// Required. The conversion adjustments that are being uploaded.
        /// </param>
        /// <param name="cancellationToken">
        /// A <see cref="st::CancellationToken"/> to use for this RPC.
        /// </param>
        /// <returns>
        /// A Task containing the RPC response.
        /// </returns>
        public virtual stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(
            string customerId,
            scg::IEnumerable<ConversionAdjustment> conversionAdjustments,
            st::CancellationToken cancellationToken) => UploadConversionAdjustmentsAsync(
                customerId,
                conversionAdjustments,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes the given conversion adjustments.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversionAdjustments">
        /// Required. The conversion adjustments that are being uploaded.
        /// </param>
        /// <param name="callSettings">
        /// If not null, applies overrides to this RPC call.
        /// </param>
        /// <returns>
        /// The RPC response.
        /// </returns>
        public virtual UploadConversionAdjustmentsResponse UploadConversionAdjustments(
            string customerId,
            scg::IEnumerable<ConversionAdjustment> conversionAdjustments,
            gaxgrpc::CallSettings callSettings = null) => UploadConversionAdjustments(
                new UploadConversionAdjustmentsRequest
                {
                    CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                    ConversionAdjustments = { gax::GaxPreconditions.CheckNotNull(conversionAdjustments, nameof(conversionAdjustments)) },
                },
                callSettings);

        /// <summary>
        /// Processes the given conversion adjustments.
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
        public virtual stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(
            UploadConversionAdjustmentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

        /// <summary>
        /// Processes the given conversion adjustments.
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
        public virtual stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(
            UploadConversionAdjustmentsRequest request,
            st::CancellationToken cancellationToken) => UploadConversionAdjustmentsAsync(
                request,
                gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes the given conversion adjustments.
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
        public virtual UploadConversionAdjustmentsResponse UploadConversionAdjustments(
            UploadConversionAdjustmentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            throw new sys::NotImplementedException();
        }

    }

    /// <summary>
    /// ConversionAdjustmentUploadService client wrapper implementation, for convenient use.
    /// </summary>
    public sealed partial class ConversionAdjustmentUploadServiceClientImpl : ConversionAdjustmentUploadServiceClient
    {
        private readonly gaxgrpc::ApiCall<UploadConversionAdjustmentsRequest, UploadConversionAdjustmentsResponse> _callUploadConversionAdjustments;

        /// <summary>
        /// Constructs a client wrapper for the ConversionAdjustmentUploadService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ConversionAdjustmentUploadServiceSettings"/> used within this client </param>
        public ConversionAdjustmentUploadServiceClientImpl(ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient grpcClient, ConversionAdjustmentUploadServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ConversionAdjustmentUploadServiceSettings effectiveSettings = settings ?? ConversionAdjustmentUploadServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callUploadConversionAdjustments = clientHelper.BuildApiCall<UploadConversionAdjustmentsRequest, UploadConversionAdjustmentsResponse>(
                GrpcClient.UploadConversionAdjustmentsAsync, GrpcClient.UploadConversionAdjustments, effectiveSettings.UploadConversionAdjustmentsSettings)
                .WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callUploadConversionAdjustments);
            Modify_UploadConversionAdjustmentsApiCall(ref _callUploadConversionAdjustments);
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
        partial void Modify_UploadConversionAdjustmentsApiCall(ref gaxgrpc::ApiCall<UploadConversionAdjustmentsRequest, UploadConversionAdjustmentsResponse> call);
        partial void OnConstruction(ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient grpcClient, ConversionAdjustmentUploadServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>
        /// The underlying gRPC ConversionAdjustmentUploadService client.
        /// </summary>
        public override ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient GrpcClient { get; }

        // Partial methods called on each request.
        // Allows per-RPC-call modification to the request and CallSettings objects,
        // before the underlying RPC is performed.
        partial void Modify_UploadConversionAdjustmentsRequest(ref UploadConversionAdjustmentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Processes the given conversion adjustments.
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
        public override stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(
            UploadConversionAdjustmentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadConversionAdjustmentsRequest(ref request, ref callSettings);
            return _callUploadConversionAdjustments.Async(request, callSettings);
        }

        /// <summary>
        /// Processes the given conversion adjustments.
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
        public override UploadConversionAdjustmentsResponse UploadConversionAdjustments(
            UploadConversionAdjustmentsRequest request,
            gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadConversionAdjustmentsRequest(ref request, ref callSettings);
            return _callUploadConversionAdjustments.Sync(request, callSettings);
        }

    }

    // Partial classes to enable page-streaming


}

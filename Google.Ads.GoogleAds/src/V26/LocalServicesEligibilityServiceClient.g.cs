// Copyright 2026 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V26.Services
{
    /// <summary>Settings for <see cref="LocalServicesEligibilityServiceClient"/> instances.</summary>
    public sealed partial class LocalServicesEligibilityServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LocalServicesEligibilityServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LocalServicesEligibilityServiceSettings"/>.</returns>
        public static LocalServicesEligibilityServiceSettings GetDefault() => new LocalServicesEligibilityServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="LocalServicesEligibilityServiceSettings"/> object with default settings.
        /// </summary>
        public LocalServicesEligibilityServiceSettings()
        {
        }

        private LocalServicesEligibilityServiceSettings(LocalServicesEligibilityServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CheckLocalServicesEligibilitySettings = existing.CheckLocalServicesEligibilitySettings;
            OnCopy(existing);
        }

        partial void OnCopy(LocalServicesEligibilityServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LocalServicesEligibilityServiceClient.CheckLocalServicesEligibility</c> and
        /// <c>LocalServicesEligibilityServiceClient.CheckLocalServicesEligibilityAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CheckLocalServicesEligibilitySettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LocalServicesEligibilityServiceSettings"/> object.</returns>
        public LocalServicesEligibilityServiceSettings Clone() => new LocalServicesEligibilityServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LocalServicesEligibilityServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class LocalServicesEligibilityServiceClientBuilder : gaxgrpc::ClientBuilderBase<LocalServicesEligibilityServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LocalServicesEligibilityServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public LocalServicesEligibilityServiceClientBuilder() : base(LocalServicesEligibilityServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref LocalServicesEligibilityServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LocalServicesEligibilityServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LocalServicesEligibilityServiceClient Build()
        {
            LocalServicesEligibilityServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LocalServicesEligibilityServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LocalServicesEligibilityServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LocalServicesEligibilityServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LocalServicesEligibilityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<LocalServicesEligibilityServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LocalServicesEligibilityServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LocalServicesEligibilityServiceClient.ChannelPool;
    }

    /// <summary>LocalServicesEligibilityService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service allows eligibility checking and discovery of category/job type
    /// details for Local Services.
    /// </remarks>
    public abstract partial class LocalServicesEligibilityServiceClient
    {
        /// <summary>
        /// The default endpoint for the LocalServicesEligibilityService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default LocalServicesEligibilityService scopes.</summary>
        /// <remarks>
        /// The default LocalServicesEligibilityService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(LocalServicesEligibilityService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="LocalServicesEligibilityServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="LocalServicesEligibilityServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LocalServicesEligibilityServiceClient"/>.</returns>
        public static stt::Task<LocalServicesEligibilityServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LocalServicesEligibilityServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LocalServicesEligibilityServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="LocalServicesEligibilityServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LocalServicesEligibilityServiceClient"/>.</returns>
        public static LocalServicesEligibilityServiceClient Create() =>
            new LocalServicesEligibilityServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LocalServicesEligibilityServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LocalServicesEligibilityServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="LocalServicesEligibilityServiceClient"/>.</returns>
        internal static LocalServicesEligibilityServiceClient Create(grpccore::CallInvoker callInvoker, LocalServicesEligibilityServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LocalServicesEligibilityService.LocalServicesEligibilityServiceClient grpcClient = new LocalServicesEligibilityService.LocalServicesEligibilityServiceClient(callInvoker);
            return new LocalServicesEligibilityServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC LocalServicesEligibilityService client</summary>
        public virtual LocalServicesEligibilityService.LocalServicesEligibilityServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Local Services eligibility status and valid categories for a
        /// given Customer and GBP Listing ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckLocalServicesEligibilityResponse CheckLocalServicesEligibility(CheckLocalServicesEligibilityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Local Services eligibility status and valid categories for a
        /// given Customer and GBP Listing ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckLocalServicesEligibilityResponse> CheckLocalServicesEligibilityAsync(CheckLocalServicesEligibilityRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Local Services eligibility status and valid categories for a
        /// given Customer and GBP Listing ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckLocalServicesEligibilityResponse> CheckLocalServicesEligibilityAsync(CheckLocalServicesEligibilityRequest request, st::CancellationToken cancellationToken) =>
            CheckLocalServicesEligibilityAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Local Services eligibility status and valid categories for a
        /// given Customer and GBP Listing ID.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose eligibility is being checked.
        /// </param>
        /// <param name="listingId">
        /// Required. The Google Business Profile listing ID to check eligibility for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CheckLocalServicesEligibilityResponse CheckLocalServicesEligibility(string customerId, string listingId, gaxgrpc::CallSettings callSettings = null) =>
            CheckLocalServicesEligibility(new CheckLocalServicesEligibilityRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ListingId = gax::GaxPreconditions.CheckNotNullOrEmpty(listingId, nameof(listingId)),
            }, callSettings);

        /// <summary>
        /// Returns the Local Services eligibility status and valid categories for a
        /// given Customer and GBP Listing ID.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose eligibility is being checked.
        /// </param>
        /// <param name="listingId">
        /// Required. The Google Business Profile listing ID to check eligibility for.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckLocalServicesEligibilityResponse> CheckLocalServicesEligibilityAsync(string customerId, string listingId, gaxgrpc::CallSettings callSettings = null) =>
            CheckLocalServicesEligibilityAsync(new CheckLocalServicesEligibilityRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ListingId = gax::GaxPreconditions.CheckNotNullOrEmpty(listingId, nameof(listingId)),
            }, callSettings);

        /// <summary>
        /// Returns the Local Services eligibility status and valid categories for a
        /// given Customer and GBP Listing ID.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose eligibility is being checked.
        /// </param>
        /// <param name="listingId">
        /// Required. The Google Business Profile listing ID to check eligibility for.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CheckLocalServicesEligibilityResponse> CheckLocalServicesEligibilityAsync(string customerId, string listingId, st::CancellationToken cancellationToken) =>
            CheckLocalServicesEligibilityAsync(customerId, listingId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LocalServicesEligibilityService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service allows eligibility checking and discovery of category/job type
    /// details for Local Services.
    /// </remarks>
    public sealed partial class LocalServicesEligibilityServiceClientImpl : LocalServicesEligibilityServiceClient
    {
        private readonly gaxgrpc::ApiCall<CheckLocalServicesEligibilityRequest, CheckLocalServicesEligibilityResponse> _callCheckLocalServicesEligibility;

        /// <summary>
        /// Constructs a client wrapper for the LocalServicesEligibilityService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="LocalServicesEligibilityServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public LocalServicesEligibilityServiceClientImpl(LocalServicesEligibilityService.LocalServicesEligibilityServiceClient grpcClient, LocalServicesEligibilityServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            LocalServicesEligibilityServiceSettings effectiveSettings = settings ?? LocalServicesEligibilityServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCheckLocalServicesEligibility = clientHelper.BuildApiCall<CheckLocalServicesEligibilityRequest, CheckLocalServicesEligibilityResponse>("CheckLocalServicesEligibility", grpcClient.CheckLocalServicesEligibilityAsync, grpcClient.CheckLocalServicesEligibility, effectiveSettings.CheckLocalServicesEligibilitySettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callCheckLocalServicesEligibility);
            Modify_CheckLocalServicesEligibilityApiCall(ref _callCheckLocalServicesEligibility);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CheckLocalServicesEligibilityApiCall(ref gaxgrpc::ApiCall<CheckLocalServicesEligibilityRequest, CheckLocalServicesEligibilityResponse> call);

        partial void OnConstruction(LocalServicesEligibilityService.LocalServicesEligibilityServiceClient grpcClient, LocalServicesEligibilityServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LocalServicesEligibilityService client</summary>
        public override LocalServicesEligibilityService.LocalServicesEligibilityServiceClient GrpcClient { get; }

        partial void Modify_CheckLocalServicesEligibilityRequest(ref CheckLocalServicesEligibilityRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the Local Services eligibility status and valid categories for a
        /// given Customer and GBP Listing ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CheckLocalServicesEligibilityResponse CheckLocalServicesEligibility(CheckLocalServicesEligibilityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckLocalServicesEligibilityRequest(ref request, ref callSettings);
            return _callCheckLocalServicesEligibility.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the Local Services eligibility status and valid categories for a
        /// given Customer and GBP Listing ID.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CheckLocalServicesEligibilityResponse> CheckLocalServicesEligibilityAsync(CheckLocalServicesEligibilityRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CheckLocalServicesEligibilityRequest(ref request, ref callSettings);
            return _callCheckLocalServicesEligibility.Async(request, callSettings);
        }
    }
}

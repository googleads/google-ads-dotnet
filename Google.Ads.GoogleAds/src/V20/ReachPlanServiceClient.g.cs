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

namespace Google.Ads.GoogleAds.V20.Services
{
    /// <summary>Settings for <see cref="ReachPlanServiceClient"/> instances.</summary>
    public sealed partial class ReachPlanServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ReachPlanServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ReachPlanServiceSettings"/>.</returns>
        public static ReachPlanServiceSettings GetDefault() => new ReachPlanServiceSettings();

        /// <summary>Constructs a new <see cref="ReachPlanServiceSettings"/> object with default settings.</summary>
        public ReachPlanServiceSettings()
        {
        }

        private ReachPlanServiceSettings(ReachPlanServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateConversionRatesSettings = existing.GenerateConversionRatesSettings;
            ListPlannableLocationsSettings = existing.ListPlannableLocationsSettings;
            ListPlannableProductsSettings = existing.ListPlannableProductsSettings;
            GenerateReachForecastSettings = existing.GenerateReachForecastSettings;
            ListPlannableUserListsSettings = existing.ListPlannableUserListsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ReachPlanServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.GenerateConversionRates</c> and
        /// <c>ReachPlanServiceClient.GenerateConversionRatesAsync</c>.
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
        public gaxgrpc::CallSettings GenerateConversionRatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.ListPlannableLocations</c> and
        /// <c>ReachPlanServiceClient.ListPlannableLocationsAsync</c>.
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
        public gaxgrpc::CallSettings ListPlannableLocationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.ListPlannableProducts</c> and <c>ReachPlanServiceClient.ListPlannableProductsAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ListPlannableProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.GenerateReachForecast</c> and <c>ReachPlanServiceClient.GenerateReachForecastAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GenerateReachForecastSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ReachPlanServiceClient.ListPlannableUserLists</c> and
        /// <c>ReachPlanServiceClient.ListPlannableUserListsAsync</c>.
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
        public gaxgrpc::CallSettings ListPlannableUserListsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ReachPlanServiceSettings"/> object.</returns>
        public ReachPlanServiceSettings Clone() => new ReachPlanServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ReachPlanServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class ReachPlanServiceClientBuilder : gaxgrpc::ClientBuilderBase<ReachPlanServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ReachPlanServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ReachPlanServiceClientBuilder() : base(ReachPlanServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ReachPlanServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ReachPlanServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ReachPlanServiceClient Build()
        {
            ReachPlanServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ReachPlanServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ReachPlanServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ReachPlanServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ReachPlanServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ReachPlanServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ReachPlanServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ReachPlanServiceClient.ChannelPool;
    }

    /// <summary>ReachPlanService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Reach Plan Service gives users information about audience size that can
    /// be reached through advertisement on YouTube. In particular,
    /// GenerateReachForecast provides estimated number of people of specified
    /// demographics that can be reached by an ad in a given market by a campaign of
    /// certain duration with a defined budget.
    /// </remarks>
    public abstract partial class ReachPlanServiceClient
    {
        /// <summary>
        /// The default endpoint for the ReachPlanService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ReachPlanService scopes.</summary>
        /// <remarks>
        /// The default ReachPlanService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ReachPlanService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ReachPlanServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReachPlanServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ReachPlanServiceClient"/>.</returns>
        public static stt::Task<ReachPlanServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ReachPlanServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ReachPlanServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ReachPlanServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ReachPlanServiceClient"/>.</returns>
        public static ReachPlanServiceClient Create() => new ReachPlanServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ReachPlanServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ReachPlanServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ReachPlanServiceClient"/>.</returns>
        internal static ReachPlanServiceClient Create(grpccore::CallInvoker callInvoker, ReachPlanServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ReachPlanService.ReachPlanServiceClient grpcClient = new ReachPlanService.ReachPlanServiceClient(callInvoker);
            return new ReachPlanServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ReachPlanService client</summary>
        public virtual ReachPlanService.ReachPlanServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a collection of conversion rate suggestions for supported plannable
        /// products.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateConversionRatesResponse GenerateConversionRates(GenerateConversionRatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a collection of conversion rate suggestions for supported plannable
        /// products.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConversionRatesResponse> GenerateConversionRatesAsync(GenerateConversionRatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a collection of conversion rate suggestions for supported plannable
        /// products.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConversionRatesResponse> GenerateConversionRatesAsync(GenerateConversionRatesRequest request, st::CancellationToken cancellationToken) =>
            GenerateConversionRatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a collection of conversion rate suggestions for supported plannable
        /// products.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer. A conversion rate based on the historical
        /// data of this customer may be suggested.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateConversionRatesResponse GenerateConversionRates(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            GenerateConversionRates(new GenerateConversionRatesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Returns a collection of conversion rate suggestions for supported plannable
        /// products.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer. A conversion rate based on the historical
        /// data of this customer may be suggested.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConversionRatesResponse> GenerateConversionRatesAsync(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            GenerateConversionRatesAsync(new GenerateConversionRatesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Returns a collection of conversion rate suggestions for supported plannable
        /// products.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer. A conversion rate based on the historical
        /// data of this customer may be suggested.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateConversionRatesResponse> GenerateConversionRatesAsync(string customerId, st::CancellationToken cancellationToken) =>
            GenerateConversionRatesAsync(customerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of plannable locations (for example, countries).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPlannableLocationsResponse ListPlannableLocations(ListPlannableLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of plannable locations (for example, countries).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableLocationsResponse> ListPlannableLocationsAsync(ListPlannableLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of plannable locations (for example, countries).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableLocationsResponse> ListPlannableLocationsAsync(ListPlannableLocationsRequest request, st::CancellationToken cancellationToken) =>
            ListPlannableLocationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPlannableProductsResponse ListPlannableProducts(ListPlannableProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(ListPlannableProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(ListPlannableProductsRequest request, st::CancellationToken cancellationToken) =>
            ListPlannableProductsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="plannableLocationId">
        /// Required. The ID of the selected location for planning. To list the
        /// available plannable location IDs use
        /// [ReachPlanService.ListPlannableLocations][google.ads.googleads.v20.services.ReachPlanService.ListPlannableLocations].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPlannableProductsResponse ListPlannableProducts(string plannableLocationId, gaxgrpc::CallSettings callSettings = null) =>
            ListPlannableProducts(new ListPlannableProductsRequest
            {
                PlannableLocationId = gax::GaxPreconditions.CheckNotNullOrEmpty(plannableLocationId, nameof(plannableLocationId)),
            }, callSettings);

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="plannableLocationId">
        /// Required. The ID of the selected location for planning. To list the
        /// available plannable location IDs use
        /// [ReachPlanService.ListPlannableLocations][google.ads.googleads.v20.services.ReachPlanService.ListPlannableLocations].
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(string plannableLocationId, gaxgrpc::CallSettings callSettings = null) =>
            ListPlannableProductsAsync(new ListPlannableProductsRequest
            {
                PlannableLocationId = gax::GaxPreconditions.CheckNotNullOrEmpty(plannableLocationId, nameof(plannableLocationId)),
            }, callSettings);

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="plannableLocationId">
        /// Required. The ID of the selected location for planning. To list the
        /// available plannable location IDs use
        /// [ReachPlanService.ListPlannableLocations][google.ads.googleads.v20.services.ReachPlanService.ListPlannableLocations].
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(string plannableLocationId, st::CancellationToken cancellationToken) =>
            ListPlannableProductsAsync(plannableLocationId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateReachForecastResponse GenerateReachForecast(GenerateReachForecastRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(GenerateReachForecastRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(GenerateReachForecastRequest request, st::CancellationToken cancellationToken) =>
            GenerateReachForecastAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="campaignDuration">
        /// Required. Campaign duration.
        /// </param>
        /// <param name="plannedProducts">
        /// Required. The products to be forecast.
        /// The max number of allowed planned products is 15.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateReachForecastResponse GenerateReachForecast(string customerId, CampaignDuration campaignDuration, scg::IEnumerable<PlannedProduct> plannedProducts, gaxgrpc::CallSettings callSettings = null) =>
            GenerateReachForecast(new GenerateReachForecastRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                CampaignDuration = gax::GaxPreconditions.CheckNotNull(campaignDuration, nameof(campaignDuration)),
                PlannedProducts =
                {
                    gax::GaxPreconditions.CheckNotNull(plannedProducts, nameof(plannedProducts)),
                },
            }, callSettings);

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="campaignDuration">
        /// Required. Campaign duration.
        /// </param>
        /// <param name="plannedProducts">
        /// Required. The products to be forecast.
        /// The max number of allowed planned products is 15.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(string customerId, CampaignDuration campaignDuration, scg::IEnumerable<PlannedProduct> plannedProducts, gaxgrpc::CallSettings callSettings = null) =>
            GenerateReachForecastAsync(new GenerateReachForecastRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                CampaignDuration = gax::GaxPreconditions.CheckNotNull(campaignDuration, nameof(campaignDuration)),
                PlannedProducts =
                {
                    gax::GaxPreconditions.CheckNotNull(plannedProducts, nameof(plannedProducts)),
                },
            }, callSettings);

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="campaignDuration">
        /// Required. Campaign duration.
        /// </param>
        /// <param name="plannedProducts">
        /// Required. The products to be forecast.
        /// The max number of allowed planned products is 15.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(string customerId, CampaignDuration campaignDuration, scg::IEnumerable<PlannedProduct> plannedProducts, st::CancellationToken cancellationToken) =>
            GenerateReachForecastAsync(customerId, campaignDuration, plannedProducts, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of plannable user lists with their plannable status.
        /// User lists may not be plannable for a number of reasons, including:
        /// - They are less than 10 days old.
        /// - They have a membership lifespan that is less than 30 days
        /// - They have less than 10,000 or more than 700,000 users.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPlannableUserListsResponse ListPlannableUserLists(ListPlannableUserListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of plannable user lists with their plannable status.
        /// User lists may not be plannable for a number of reasons, including:
        /// - They are less than 10 days old.
        /// - They have a membership lifespan that is less than 30 days
        /// - They have less than 10,000 or more than 700,000 users.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableUserListsResponse> ListPlannableUserListsAsync(ListPlannableUserListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of plannable user lists with their plannable status.
        /// User lists may not be plannable for a number of reasons, including:
        /// - They are less than 10 days old.
        /// - They have a membership lifespan that is less than 30 days
        /// - They have less than 10,000 or more than 700,000 users.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableUserListsResponse> ListPlannableUserListsAsync(ListPlannableUserListsRequest request, st::CancellationToken cancellationToken) =>
            ListPlannableUserListsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of plannable user lists with their plannable status.
        /// User lists may not be plannable for a number of reasons, including:
        /// - They are less than 10 days old.
        /// - They have a membership lifespan that is less than 30 days
        /// - They have less than 10,000 or more than 700,000 users.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListPlannableUserListsResponse ListPlannableUserLists(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            ListPlannableUserLists(new ListPlannableUserListsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Returns the list of plannable user lists with their plannable status.
        /// User lists may not be plannable for a number of reasons, including:
        /// - They are less than 10 days old.
        /// - They have a membership lifespan that is less than 30 days
        /// - They have less than 10,000 or more than 700,000 users.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableUserListsResponse> ListPlannableUserListsAsync(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            ListPlannableUserListsAsync(new ListPlannableUserListsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Returns the list of plannable user lists with their plannable status.
        /// User lists may not be plannable for a number of reasons, including:
        /// - They are less than 10 days old.
        /// - They have a membership lifespan that is less than 30 days
        /// - They have less than 10,000 or more than 700,000 users.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListPlannableUserListsResponse> ListPlannableUserListsAsync(string customerId, st::CancellationToken cancellationToken) =>
            ListPlannableUserListsAsync(customerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ReachPlanService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Reach Plan Service gives users information about audience size that can
    /// be reached through advertisement on YouTube. In particular,
    /// GenerateReachForecast provides estimated number of people of specified
    /// demographics that can be reached by an ad in a given market by a campaign of
    /// certain duration with a defined budget.
    /// </remarks>
    public sealed partial class ReachPlanServiceClientImpl : ReachPlanServiceClient
    {
        private readonly gaxgrpc::ApiCall<GenerateConversionRatesRequest, GenerateConversionRatesResponse> _callGenerateConversionRates;

        private readonly gaxgrpc::ApiCall<ListPlannableLocationsRequest, ListPlannableLocationsResponse> _callListPlannableLocations;

        private readonly gaxgrpc::ApiCall<ListPlannableProductsRequest, ListPlannableProductsResponse> _callListPlannableProducts;

        private readonly gaxgrpc::ApiCall<GenerateReachForecastRequest, GenerateReachForecastResponse> _callGenerateReachForecast;

        private readonly gaxgrpc::ApiCall<ListPlannableUserListsRequest, ListPlannableUserListsResponse> _callListPlannableUserLists;

        /// <summary>
        /// Constructs a client wrapper for the ReachPlanService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ReachPlanServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ReachPlanServiceClientImpl(ReachPlanService.ReachPlanServiceClient grpcClient, ReachPlanServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ReachPlanServiceSettings effectiveSettings = settings ?? ReachPlanServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callGenerateConversionRates = clientHelper.BuildApiCall<GenerateConversionRatesRequest, GenerateConversionRatesResponse>("GenerateConversionRates", grpcClient.GenerateConversionRatesAsync, grpcClient.GenerateConversionRates, effectiveSettings.GenerateConversionRatesSettings);
            Modify_ApiCall(ref _callGenerateConversionRates);
            Modify_GenerateConversionRatesApiCall(ref _callGenerateConversionRates);
            _callListPlannableLocations = clientHelper.BuildApiCall<ListPlannableLocationsRequest, ListPlannableLocationsResponse>("ListPlannableLocations", grpcClient.ListPlannableLocationsAsync, grpcClient.ListPlannableLocations, effectiveSettings.ListPlannableLocationsSettings);
            Modify_ApiCall(ref _callListPlannableLocations);
            Modify_ListPlannableLocationsApiCall(ref _callListPlannableLocations);
            _callListPlannableProducts = clientHelper.BuildApiCall<ListPlannableProductsRequest, ListPlannableProductsResponse>("ListPlannableProducts", grpcClient.ListPlannableProductsAsync, grpcClient.ListPlannableProducts, effectiveSettings.ListPlannableProductsSettings);
            Modify_ApiCall(ref _callListPlannableProducts);
            Modify_ListPlannableProductsApiCall(ref _callListPlannableProducts);
            _callGenerateReachForecast = clientHelper.BuildApiCall<GenerateReachForecastRequest, GenerateReachForecastResponse>("GenerateReachForecast", grpcClient.GenerateReachForecastAsync, grpcClient.GenerateReachForecast, effectiveSettings.GenerateReachForecastSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateReachForecast);
            Modify_GenerateReachForecastApiCall(ref _callGenerateReachForecast);
            _callListPlannableUserLists = clientHelper.BuildApiCall<ListPlannableUserListsRequest, ListPlannableUserListsResponse>("ListPlannableUserLists", grpcClient.ListPlannableUserListsAsync, grpcClient.ListPlannableUserLists, effectiveSettings.ListPlannableUserListsSettings);
            Modify_ApiCall(ref _callListPlannableUserLists);
            Modify_ListPlannableUserListsApiCall(ref _callListPlannableUserLists);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateConversionRatesApiCall(ref gaxgrpc::ApiCall<GenerateConversionRatesRequest, GenerateConversionRatesResponse> call);

        partial void Modify_ListPlannableLocationsApiCall(ref gaxgrpc::ApiCall<ListPlannableLocationsRequest, ListPlannableLocationsResponse> call);

        partial void Modify_ListPlannableProductsApiCall(ref gaxgrpc::ApiCall<ListPlannableProductsRequest, ListPlannableProductsResponse> call);

        partial void Modify_GenerateReachForecastApiCall(ref gaxgrpc::ApiCall<GenerateReachForecastRequest, GenerateReachForecastResponse> call);

        partial void Modify_ListPlannableUserListsApiCall(ref gaxgrpc::ApiCall<ListPlannableUserListsRequest, ListPlannableUserListsResponse> call);

        partial void OnConstruction(ReachPlanService.ReachPlanServiceClient grpcClient, ReachPlanServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ReachPlanService client</summary>
        public override ReachPlanService.ReachPlanServiceClient GrpcClient { get; }

        partial void Modify_GenerateConversionRatesRequest(ref GenerateConversionRatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPlannableLocationsRequest(ref ListPlannableLocationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPlannableProductsRequest(ref ListPlannableProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateReachForecastRequest(ref GenerateReachForecastRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListPlannableUserListsRequest(ref ListPlannableUserListsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a collection of conversion rate suggestions for supported plannable
        /// products.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateConversionRatesResponse GenerateConversionRates(GenerateConversionRatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConversionRatesRequest(ref request, ref callSettings);
            return _callGenerateConversionRates.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a collection of conversion rate suggestions for supported plannable
        /// products.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateConversionRatesResponse> GenerateConversionRatesAsync(GenerateConversionRatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateConversionRatesRequest(ref request, ref callSettings);
            return _callGenerateConversionRates.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of plannable locations (for example, countries).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListPlannableLocationsResponse ListPlannableLocations(ListPlannableLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableLocationsRequest(ref request, ref callSettings);
            return _callListPlannableLocations.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of plannable locations (for example, countries).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListPlannableLocationsResponse> ListPlannableLocationsAsync(ListPlannableLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableLocationsRequest(ref request, ref callSettings);
            return _callListPlannableLocations.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListPlannableProductsResponse ListPlannableProducts(ListPlannableProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableProductsRequest(ref request, ref callSettings);
            return _callListPlannableProducts.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of per-location plannable YouTube ad formats with allowed
        /// targeting.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListPlannableProductsResponse> ListPlannableProductsAsync(ListPlannableProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableProductsRequest(ref request, ref callSettings);
            return _callListPlannableProducts.Async(request, callSettings);
        }

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateReachForecastResponse GenerateReachForecast(GenerateReachForecastRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateReachForecastRequest(ref request, ref callSettings);
            return _callGenerateReachForecast.Sync(request, callSettings);
        }

        /// <summary>
        /// Generates a reach forecast for a given targeting / product mix.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateReachForecastResponse> GenerateReachForecastAsync(GenerateReachForecastRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateReachForecastRequest(ref request, ref callSettings);
            return _callGenerateReachForecast.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of plannable user lists with their plannable status.
        /// User lists may not be plannable for a number of reasons, including:
        /// - They are less than 10 days old.
        /// - They have a membership lifespan that is less than 30 days
        /// - They have less than 10,000 or more than 700,000 users.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListPlannableUserListsResponse ListPlannableUserLists(ListPlannableUserListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableUserListsRequest(ref request, ref callSettings);
            return _callListPlannableUserLists.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of plannable user lists with their plannable status.
        /// User lists may not be plannable for a number of reasons, including:
        /// - They are less than 10 days old.
        /// - They have a membership lifespan that is less than 30 days
        /// - They have less than 10,000 or more than 700,000 users.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [ReachPlanError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListPlannableUserListsResponse> ListPlannableUserListsAsync(ListPlannableUserListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListPlannableUserListsRequest(ref request, ref callSettings);
            return _callListPlannableUserLists.Async(request, callSettings);
        }
    }
}

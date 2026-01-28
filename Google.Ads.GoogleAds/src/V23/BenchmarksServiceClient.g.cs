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
using gagvc = Google.Ads.GoogleAds.V23.Common;
using gagve = Google.Ads.GoogleAds.V23.Enums;
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

namespace Google.Ads.GoogleAds.V23.Services
{
    /// <summary>Settings for <see cref="BenchmarksServiceClient"/> instances.</summary>
    public sealed partial class BenchmarksServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BenchmarksServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BenchmarksServiceSettings"/>.</returns>
        public static BenchmarksServiceSettings GetDefault() => new BenchmarksServiceSettings();

        /// <summary>Constructs a new <see cref="BenchmarksServiceSettings"/> object with default settings.</summary>
        public BenchmarksServiceSettings()
        {
        }

        private BenchmarksServiceSettings(BenchmarksServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListBenchmarksAvailableDatesSettings = existing.ListBenchmarksAvailableDatesSettings;
            ListBenchmarksLocationsSettings = existing.ListBenchmarksLocationsSettings;
            ListBenchmarksProductsSettings = existing.ListBenchmarksProductsSettings;
            ListBenchmarksSourcesSettings = existing.ListBenchmarksSourcesSettings;
            GenerateBenchmarksMetricsSettings = existing.GenerateBenchmarksMetricsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BenchmarksServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BenchmarksServiceClient.ListBenchmarksAvailableDates</c> and
        /// <c>BenchmarksServiceClient.ListBenchmarksAvailableDatesAsync</c>.
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
        public gaxgrpc::CallSettings ListBenchmarksAvailableDatesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BenchmarksServiceClient.ListBenchmarksLocations</c> and
        /// <c>BenchmarksServiceClient.ListBenchmarksLocationsAsync</c>.
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
        public gaxgrpc::CallSettings ListBenchmarksLocationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BenchmarksServiceClient.ListBenchmarksProducts</c> and
        /// <c>BenchmarksServiceClient.ListBenchmarksProductsAsync</c>.
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
        public gaxgrpc::CallSettings ListBenchmarksProductsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BenchmarksServiceClient.ListBenchmarksSources</c> and
        /// <c>BenchmarksServiceClient.ListBenchmarksSourcesAsync</c>.
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
        public gaxgrpc::CallSettings ListBenchmarksSourcesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BenchmarksServiceClient.GenerateBenchmarksMetrics</c> and
        /// <c>BenchmarksServiceClient.GenerateBenchmarksMetricsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateBenchmarksMetricsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BenchmarksServiceSettings"/> object.</returns>
        public BenchmarksServiceSettings Clone() => new BenchmarksServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BenchmarksServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class BenchmarksServiceClientBuilder : gaxgrpc::ClientBuilderBase<BenchmarksServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BenchmarksServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BenchmarksServiceClientBuilder() : base(BenchmarksServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BenchmarksServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BenchmarksServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BenchmarksServiceClient Build()
        {
            BenchmarksServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BenchmarksServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BenchmarksServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BenchmarksServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BenchmarksServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<BenchmarksServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BenchmarksServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BenchmarksServiceClient.ChannelPool;
    }

    /// <summary>BenchmarksService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// BenchmarksService helps users compare YouTube advertisement data against
    /// industry benchmarks. Accessible to allowlisted customers only.
    /// </remarks>
    public abstract partial class BenchmarksServiceClient
    {
        /// <summary>
        /// The default endpoint for the BenchmarksService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default BenchmarksService scopes.</summary>
        /// <remarks>
        /// The default BenchmarksService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BenchmarksService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BenchmarksServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BenchmarksServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BenchmarksServiceClient"/>.</returns>
        public static stt::Task<BenchmarksServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BenchmarksServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BenchmarksServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BenchmarksServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BenchmarksServiceClient"/>.</returns>
        public static BenchmarksServiceClient Create() => new BenchmarksServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BenchmarksServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BenchmarksServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BenchmarksServiceClient"/>.</returns>
        internal static BenchmarksServiceClient Create(grpccore::CallInvoker callInvoker, BenchmarksServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BenchmarksService.BenchmarksServiceClient grpcClient = new BenchmarksService.BenchmarksServiceClient(callInvoker);
            return new BenchmarksServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BenchmarksService client</summary>
        public virtual BenchmarksService.BenchmarksServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a date range that supports benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListBenchmarksAvailableDatesResponse ListBenchmarksAvailableDates(ListBenchmarksAvailableDatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a date range that supports benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBenchmarksAvailableDatesResponse> ListBenchmarksAvailableDatesAsync(ListBenchmarksAvailableDatesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a date range that supports benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBenchmarksAvailableDatesResponse> ListBenchmarksAvailableDatesAsync(ListBenchmarksAvailableDatesRequest request, st::CancellationToken cancellationToken) =>
            ListBenchmarksAvailableDatesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of locations that support benchmarks (for example,
        /// countries).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListBenchmarksLocationsResponse ListBenchmarksLocations(ListBenchmarksLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of locations that support benchmarks (for example,
        /// countries).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBenchmarksLocationsResponse> ListBenchmarksLocationsAsync(ListBenchmarksLocationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of locations that support benchmarks (for example,
        /// countries).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBenchmarksLocationsResponse> ListBenchmarksLocationsAsync(ListBenchmarksLocationsRequest request, st::CancellationToken cancellationToken) =>
            ListBenchmarksLocationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of products that supports benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListBenchmarksProductsResponse ListBenchmarksProducts(ListBenchmarksProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of products that supports benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBenchmarksProductsResponse> ListBenchmarksProductsAsync(ListBenchmarksProductsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of products that supports benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBenchmarksProductsResponse> ListBenchmarksProductsAsync(ListBenchmarksProductsRequest request, st::CancellationToken cancellationToken) =>
            ListBenchmarksProductsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of benchmarks sources (for example, Industry Verticals).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListBenchmarksSourcesResponse ListBenchmarksSources(ListBenchmarksSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of benchmarks sources (for example, Industry Verticals).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBenchmarksSourcesResponse> ListBenchmarksSourcesAsync(ListBenchmarksSourcesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the list of benchmarks sources (for example, Industry Verticals).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBenchmarksSourcesResponse> ListBenchmarksSourcesAsync(ListBenchmarksSourcesRequest request, st::CancellationToken cancellationToken) =>
            ListBenchmarksSourcesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the list of benchmarks sources (for example, Industry Verticals).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="benchmarksSources">
        /// Required. The types of benchmarks sources to be returned (for example,
        /// INDUSTRY_VERTICAL).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListBenchmarksSourcesResponse ListBenchmarksSources(scg::IEnumerable<gagve::BenchmarksSourceTypeEnum.Types.BenchmarksSourceType> benchmarksSources, gaxgrpc::CallSettings callSettings = null) =>
            ListBenchmarksSources(new ListBenchmarksSourcesRequest
            {
                BenchmarksSources =
                {
                    gax::GaxPreconditions.CheckNotNull(benchmarksSources, nameof(benchmarksSources)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the list of benchmarks sources (for example, Industry Verticals).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="benchmarksSources">
        /// Required. The types of benchmarks sources to be returned (for example,
        /// INDUSTRY_VERTICAL).
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBenchmarksSourcesResponse> ListBenchmarksSourcesAsync(scg::IEnumerable<gagve::BenchmarksSourceTypeEnum.Types.BenchmarksSourceType> benchmarksSources, gaxgrpc::CallSettings callSettings = null) =>
            ListBenchmarksSourcesAsync(new ListBenchmarksSourcesRequest
            {
                BenchmarksSources =
                {
                    gax::GaxPreconditions.CheckNotNull(benchmarksSources, nameof(benchmarksSources)),
                },
            }, callSettings);

        /// <summary>
        /// Returns the list of benchmarks sources (for example, Industry Verticals).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="benchmarksSources">
        /// Required. The types of benchmarks sources to be returned (for example,
        /// INDUSTRY_VERTICAL).
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListBenchmarksSourcesResponse> ListBenchmarksSourcesAsync(scg::IEnumerable<gagve::BenchmarksSourceTypeEnum.Types.BenchmarksSourceType> benchmarksSources, st::CancellationToken cancellationToken) =>
            ListBenchmarksSourcesAsync(benchmarksSources, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns YouTube advertisement metrics for the given client against industry
        /// benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BenchmarksError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateBenchmarksMetricsResponse GenerateBenchmarksMetrics(GenerateBenchmarksMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns YouTube advertisement metrics for the given client against industry
        /// benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BenchmarksError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateBenchmarksMetricsResponse> GenerateBenchmarksMetricsAsync(GenerateBenchmarksMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns YouTube advertisement metrics for the given client against industry
        /// benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BenchmarksError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateBenchmarksMetricsResponse> GenerateBenchmarksMetricsAsync(GenerateBenchmarksMetricsRequest request, st::CancellationToken cancellationToken) =>
            GenerateBenchmarksMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns YouTube advertisement metrics for the given client against industry
        /// benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BenchmarksError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer. Supply a client customer ID to generate
        /// metrics for the customer. A manager account customer ID will not return
        /// customer metrics since it does not have any associated direct ad campaigns.
        /// </param>
        /// <param name="location">
        /// Required. The location to generate benchmarks metrics for.
        /// </param>
        /// <param name="benchmarksSource">
        /// Required. The source used to generate benchmarks metrics for.
        /// </param>
        /// <param name="productFilter">
        /// Required. The products to aggregate metrics over. Product filter settings
        /// support a list of product IDs or a list of marketing objectives.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateBenchmarksMetricsResponse GenerateBenchmarksMetrics(string customerId, gagvc::LocationInfo location, BenchmarksSource benchmarksSource, ProductFilter productFilter, gaxgrpc::CallSettings callSettings = null) =>
            GenerateBenchmarksMetrics(new GenerateBenchmarksMetricsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Location = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
                BenchmarksSource = gax::GaxPreconditions.CheckNotNull(benchmarksSource, nameof(benchmarksSource)),
                ProductFilter = gax::GaxPreconditions.CheckNotNull(productFilter, nameof(productFilter)),
            }, callSettings);

        /// <summary>
        /// Returns YouTube advertisement metrics for the given client against industry
        /// benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BenchmarksError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer. Supply a client customer ID to generate
        /// metrics for the customer. A manager account customer ID will not return
        /// customer metrics since it does not have any associated direct ad campaigns.
        /// </param>
        /// <param name="location">
        /// Required. The location to generate benchmarks metrics for.
        /// </param>
        /// <param name="benchmarksSource">
        /// Required. The source used to generate benchmarks metrics for.
        /// </param>
        /// <param name="productFilter">
        /// Required. The products to aggregate metrics over. Product filter settings
        /// support a list of product IDs or a list of marketing objectives.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateBenchmarksMetricsResponse> GenerateBenchmarksMetricsAsync(string customerId, gagvc::LocationInfo location, BenchmarksSource benchmarksSource, ProductFilter productFilter, gaxgrpc::CallSettings callSettings = null) =>
            GenerateBenchmarksMetricsAsync(new GenerateBenchmarksMetricsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Location = gax::GaxPreconditions.CheckNotNull(location, nameof(location)),
                BenchmarksSource = gax::GaxPreconditions.CheckNotNull(benchmarksSource, nameof(benchmarksSource)),
                ProductFilter = gax::GaxPreconditions.CheckNotNull(productFilter, nameof(productFilter)),
            }, callSettings);

        /// <summary>
        /// Returns YouTube advertisement metrics for the given client against industry
        /// benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BenchmarksError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer. Supply a client customer ID to generate
        /// metrics for the customer. A manager account customer ID will not return
        /// customer metrics since it does not have any associated direct ad campaigns.
        /// </param>
        /// <param name="location">
        /// Required. The location to generate benchmarks metrics for.
        /// </param>
        /// <param name="benchmarksSource">
        /// Required. The source used to generate benchmarks metrics for.
        /// </param>
        /// <param name="productFilter">
        /// Required. The products to aggregate metrics over. Product filter settings
        /// support a list of product IDs or a list of marketing objectives.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateBenchmarksMetricsResponse> GenerateBenchmarksMetricsAsync(string customerId, gagvc::LocationInfo location, BenchmarksSource benchmarksSource, ProductFilter productFilter, st::CancellationToken cancellationToken) =>
            GenerateBenchmarksMetricsAsync(customerId, location, benchmarksSource, productFilter, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BenchmarksService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// BenchmarksService helps users compare YouTube advertisement data against
    /// industry benchmarks. Accessible to allowlisted customers only.
    /// </remarks>
    public sealed partial class BenchmarksServiceClientImpl : BenchmarksServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListBenchmarksAvailableDatesRequest, ListBenchmarksAvailableDatesResponse> _callListBenchmarksAvailableDates;

        private readonly gaxgrpc::ApiCall<ListBenchmarksLocationsRequest, ListBenchmarksLocationsResponse> _callListBenchmarksLocations;

        private readonly gaxgrpc::ApiCall<ListBenchmarksProductsRequest, ListBenchmarksProductsResponse> _callListBenchmarksProducts;

        private readonly gaxgrpc::ApiCall<ListBenchmarksSourcesRequest, ListBenchmarksSourcesResponse> _callListBenchmarksSources;

        private readonly gaxgrpc::ApiCall<GenerateBenchmarksMetricsRequest, GenerateBenchmarksMetricsResponse> _callGenerateBenchmarksMetrics;

        /// <summary>
        /// Constructs a client wrapper for the BenchmarksService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BenchmarksServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BenchmarksServiceClientImpl(BenchmarksService.BenchmarksServiceClient grpcClient, BenchmarksServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BenchmarksServiceSettings effectiveSettings = settings ?? BenchmarksServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callListBenchmarksAvailableDates = clientHelper.BuildApiCall<ListBenchmarksAvailableDatesRequest, ListBenchmarksAvailableDatesResponse>("ListBenchmarksAvailableDates", grpcClient.ListBenchmarksAvailableDatesAsync, grpcClient.ListBenchmarksAvailableDates, effectiveSettings.ListBenchmarksAvailableDatesSettings);
            Modify_ApiCall(ref _callListBenchmarksAvailableDates);
            Modify_ListBenchmarksAvailableDatesApiCall(ref _callListBenchmarksAvailableDates);
            _callListBenchmarksLocations = clientHelper.BuildApiCall<ListBenchmarksLocationsRequest, ListBenchmarksLocationsResponse>("ListBenchmarksLocations", grpcClient.ListBenchmarksLocationsAsync, grpcClient.ListBenchmarksLocations, effectiveSettings.ListBenchmarksLocationsSettings);
            Modify_ApiCall(ref _callListBenchmarksLocations);
            Modify_ListBenchmarksLocationsApiCall(ref _callListBenchmarksLocations);
            _callListBenchmarksProducts = clientHelper.BuildApiCall<ListBenchmarksProductsRequest, ListBenchmarksProductsResponse>("ListBenchmarksProducts", grpcClient.ListBenchmarksProductsAsync, grpcClient.ListBenchmarksProducts, effectiveSettings.ListBenchmarksProductsSettings);
            Modify_ApiCall(ref _callListBenchmarksProducts);
            Modify_ListBenchmarksProductsApiCall(ref _callListBenchmarksProducts);
            _callListBenchmarksSources = clientHelper.BuildApiCall<ListBenchmarksSourcesRequest, ListBenchmarksSourcesResponse>("ListBenchmarksSources", grpcClient.ListBenchmarksSourcesAsync, grpcClient.ListBenchmarksSources, effectiveSettings.ListBenchmarksSourcesSettings);
            Modify_ApiCall(ref _callListBenchmarksSources);
            Modify_ListBenchmarksSourcesApiCall(ref _callListBenchmarksSources);
            _callGenerateBenchmarksMetrics = clientHelper.BuildApiCall<GenerateBenchmarksMetricsRequest, GenerateBenchmarksMetricsResponse>("GenerateBenchmarksMetrics", grpcClient.GenerateBenchmarksMetricsAsync, grpcClient.GenerateBenchmarksMetrics, effectiveSettings.GenerateBenchmarksMetricsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateBenchmarksMetrics);
            Modify_GenerateBenchmarksMetricsApiCall(ref _callGenerateBenchmarksMetrics);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListBenchmarksAvailableDatesApiCall(ref gaxgrpc::ApiCall<ListBenchmarksAvailableDatesRequest, ListBenchmarksAvailableDatesResponse> call);

        partial void Modify_ListBenchmarksLocationsApiCall(ref gaxgrpc::ApiCall<ListBenchmarksLocationsRequest, ListBenchmarksLocationsResponse> call);

        partial void Modify_ListBenchmarksProductsApiCall(ref gaxgrpc::ApiCall<ListBenchmarksProductsRequest, ListBenchmarksProductsResponse> call);

        partial void Modify_ListBenchmarksSourcesApiCall(ref gaxgrpc::ApiCall<ListBenchmarksSourcesRequest, ListBenchmarksSourcesResponse> call);

        partial void Modify_GenerateBenchmarksMetricsApiCall(ref gaxgrpc::ApiCall<GenerateBenchmarksMetricsRequest, GenerateBenchmarksMetricsResponse> call);

        partial void OnConstruction(BenchmarksService.BenchmarksServiceClient grpcClient, BenchmarksServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BenchmarksService client</summary>
        public override BenchmarksService.BenchmarksServiceClient GrpcClient { get; }

        partial void Modify_ListBenchmarksAvailableDatesRequest(ref ListBenchmarksAvailableDatesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBenchmarksLocationsRequest(ref ListBenchmarksLocationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBenchmarksProductsRequest(ref ListBenchmarksProductsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBenchmarksSourcesRequest(ref ListBenchmarksSourcesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateBenchmarksMetricsRequest(ref GenerateBenchmarksMetricsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a date range that supports benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListBenchmarksAvailableDatesResponse ListBenchmarksAvailableDates(ListBenchmarksAvailableDatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBenchmarksAvailableDatesRequest(ref request, ref callSettings);
            return _callListBenchmarksAvailableDates.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a date range that supports benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListBenchmarksAvailableDatesResponse> ListBenchmarksAvailableDatesAsync(ListBenchmarksAvailableDatesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBenchmarksAvailableDatesRequest(ref request, ref callSettings);
            return _callListBenchmarksAvailableDates.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of locations that support benchmarks (for example,
        /// countries).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListBenchmarksLocationsResponse ListBenchmarksLocations(ListBenchmarksLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBenchmarksLocationsRequest(ref request, ref callSettings);
            return _callListBenchmarksLocations.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of locations that support benchmarks (for example,
        /// countries).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListBenchmarksLocationsResponse> ListBenchmarksLocationsAsync(ListBenchmarksLocationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBenchmarksLocationsRequest(ref request, ref callSettings);
            return _callListBenchmarksLocations.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of products that supports benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListBenchmarksProductsResponse ListBenchmarksProducts(ListBenchmarksProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBenchmarksProductsRequest(ref request, ref callSettings);
            return _callListBenchmarksProducts.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of products that supports benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListBenchmarksProductsResponse> ListBenchmarksProductsAsync(ListBenchmarksProductsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBenchmarksProductsRequest(ref request, ref callSettings);
            return _callListBenchmarksProducts.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the list of benchmarks sources (for example, Industry Verticals).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override ListBenchmarksSourcesResponse ListBenchmarksSources(ListBenchmarksSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBenchmarksSourcesRequest(ref request, ref callSettings);
            return _callListBenchmarksSources.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the list of benchmarks sources (for example, Industry Verticals).
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<ListBenchmarksSourcesResponse> ListBenchmarksSourcesAsync(ListBenchmarksSourcesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBenchmarksSourcesRequest(ref request, ref callSettings);
            return _callListBenchmarksSources.Async(request, callSettings);
        }

        /// <summary>
        /// Returns YouTube advertisement metrics for the given client against industry
        /// benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BenchmarksError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateBenchmarksMetricsResponse GenerateBenchmarksMetrics(GenerateBenchmarksMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateBenchmarksMetricsRequest(ref request, ref callSettings);
            return _callGenerateBenchmarksMetrics.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns YouTube advertisement metrics for the given client against industry
        /// benchmarks.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BenchmarksError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateBenchmarksMetricsResponse> GenerateBenchmarksMetricsAsync(GenerateBenchmarksMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateBenchmarksMetricsRequest(ref request, ref callSettings);
            return _callGenerateBenchmarksMetrics.Async(request, callSettings);
        }
    }
}

// Copyright 2023 Google LLC
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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V14.Services
{
    /// <summary>Settings for <see cref="KeywordPlanIdeaServiceClient"/> instances.</summary>
    public sealed partial class KeywordPlanIdeaServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KeywordPlanIdeaServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KeywordPlanIdeaServiceSettings"/>.</returns>
        public static KeywordPlanIdeaServiceSettings GetDefault() => new KeywordPlanIdeaServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanIdeaServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanIdeaServiceSettings()
        {
        }

        private KeywordPlanIdeaServiceSettings(KeywordPlanIdeaServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateKeywordIdeasSettings = existing.GenerateKeywordIdeasSettings;
            GenerateKeywordHistoricalMetricsSettings = existing.GenerateKeywordHistoricalMetricsSettings;
            GenerateAdGroupThemesSettings = existing.GenerateAdGroupThemesSettings;
            GenerateKeywordForecastMetricsSettings = existing.GenerateKeywordForecastMetricsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanIdeaServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanIdeaServiceClient.GenerateKeywordIdeas</c> and
        /// <c>KeywordPlanIdeaServiceClient.GenerateKeywordIdeasAsync</c>.
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
        public gaxgrpc::CallSettings GenerateKeywordIdeasSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanIdeaServiceClient.GenerateKeywordHistoricalMetrics</c> and
        /// <c>KeywordPlanIdeaServiceClient.GenerateKeywordHistoricalMetricsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateKeywordHistoricalMetricsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanIdeaServiceClient.GenerateAdGroupThemes</c> and
        /// <c>KeywordPlanIdeaServiceClient.GenerateAdGroupThemesAsync</c>.
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
        public gaxgrpc::CallSettings GenerateAdGroupThemesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanIdeaServiceClient.GenerateKeywordForecastMetrics</c> and
        /// <c>KeywordPlanIdeaServiceClient.GenerateKeywordForecastMetricsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateKeywordForecastMetricsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanIdeaServiceSettings"/> object.</returns>
        public KeywordPlanIdeaServiceSettings Clone() => new KeywordPlanIdeaServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanIdeaServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class KeywordPlanIdeaServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanIdeaServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeywordPlanIdeaServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public KeywordPlanIdeaServiceClientBuilder() : base(KeywordPlanIdeaServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref KeywordPlanIdeaServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeywordPlanIdeaServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeywordPlanIdeaServiceClient Build()
        {
            KeywordPlanIdeaServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeywordPlanIdeaServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeywordPlanIdeaServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeywordPlanIdeaServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanIdeaServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<KeywordPlanIdeaServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanIdeaServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanIdeaServiceClient.ChannelPool;
    }

    /// <summary>KeywordPlanIdeaService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to generate keyword ideas.
    /// </remarks>
    public abstract partial class KeywordPlanIdeaServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanIdeaService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default KeywordPlanIdeaService scopes.</summary>
        /// <remarks>
        /// The default KeywordPlanIdeaService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(KeywordPlanIdeaService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanIdeaServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanIdeaServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeywordPlanIdeaServiceClient"/>.</returns>
        public static stt::Task<KeywordPlanIdeaServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeywordPlanIdeaServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanIdeaServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanIdeaServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KeywordPlanIdeaServiceClient"/>.</returns>
        public static KeywordPlanIdeaServiceClient Create() => new KeywordPlanIdeaServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeywordPlanIdeaServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeywordPlanIdeaServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="KeywordPlanIdeaServiceClient"/>.</returns>
        internal static KeywordPlanIdeaServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanIdeaServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanIdeaService.KeywordPlanIdeaServiceClient grpcClient = new KeywordPlanIdeaService.KeywordPlanIdeaServiceClient(callInvoker);
            return new KeywordPlanIdeaServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC KeywordPlanIdeaService client</summary>
        public virtual KeywordPlanIdeaService.KeywordPlanIdeaServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of keyword ideas.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanIdeaError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GenerateKeywordIdeaResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult> GenerateKeywordIdeas(GenerateKeywordIdeasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of keyword ideas.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanIdeaError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GenerateKeywordIdeaResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult> GenerateKeywordIdeasAsync(GenerateKeywordIdeasRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of keyword historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateKeywordHistoricalMetricsResponse GenerateKeywordHistoricalMetrics(GenerateKeywordHistoricalMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of keyword historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateKeywordHistoricalMetricsResponse> GenerateKeywordHistoricalMetricsAsync(GenerateKeywordHistoricalMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of keyword historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateKeywordHistoricalMetricsResponse> GenerateKeywordHistoricalMetricsAsync(GenerateKeywordHistoricalMetricsRequest request, st::CancellationToken cancellationToken) =>
            GenerateKeywordHistoricalMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a list of suggested AdGroups and suggested modifications
        /// (text, match type) for the given keywords.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateAdGroupThemesResponse GenerateAdGroupThemes(GenerateAdGroupThemesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of suggested AdGroups and suggested modifications
        /// (text, match type) for the given keywords.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAdGroupThemesResponse> GenerateAdGroupThemesAsync(GenerateAdGroupThemesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a list of suggested AdGroups and suggested modifications
        /// (text, match type) for the given keywords.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateAdGroupThemesResponse> GenerateAdGroupThemesAsync(GenerateAdGroupThemesRequest request, st::CancellationToken cancellationToken) =>
            GenerateAdGroupThemesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns metrics (such as impressions, clicks, total cost) of a keyword
        /// forecast for the given campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateKeywordForecastMetricsResponse GenerateKeywordForecastMetrics(GenerateKeywordForecastMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metrics (such as impressions, clicks, total cost) of a keyword
        /// forecast for the given campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateKeywordForecastMetricsResponse> GenerateKeywordForecastMetricsAsync(GenerateKeywordForecastMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns metrics (such as impressions, clicks, total cost) of a keyword
        /// forecast for the given campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateKeywordForecastMetricsResponse> GenerateKeywordForecastMetricsAsync(GenerateKeywordForecastMetricsRequest request, st::CancellationToken cancellationToken) =>
            GenerateKeywordForecastMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>KeywordPlanIdeaService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to generate keyword ideas.
    /// </remarks>
    public sealed partial class KeywordPlanIdeaServiceClientImpl : KeywordPlanIdeaServiceClient
    {
        private readonly gaxgrpc::ApiCall<GenerateKeywordIdeasRequest, GenerateKeywordIdeaResponse> _callGenerateKeywordIdeas;

        private readonly gaxgrpc::ApiCall<GenerateKeywordHistoricalMetricsRequest, GenerateKeywordHistoricalMetricsResponse> _callGenerateKeywordHistoricalMetrics;

        private readonly gaxgrpc::ApiCall<GenerateAdGroupThemesRequest, GenerateAdGroupThemesResponse> _callGenerateAdGroupThemes;

        private readonly gaxgrpc::ApiCall<GenerateKeywordForecastMetricsRequest, GenerateKeywordForecastMetricsResponse> _callGenerateKeywordForecastMetrics;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanIdeaService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="KeywordPlanIdeaServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public KeywordPlanIdeaServiceClientImpl(KeywordPlanIdeaService.KeywordPlanIdeaServiceClient grpcClient, KeywordPlanIdeaServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            KeywordPlanIdeaServiceSettings effectiveSettings = settings ?? KeywordPlanIdeaServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callGenerateKeywordIdeas = clientHelper.BuildApiCall<GenerateKeywordIdeasRequest, GenerateKeywordIdeaResponse>("GenerateKeywordIdeas", grpcClient.GenerateKeywordIdeasAsync, grpcClient.GenerateKeywordIdeas, effectiveSettings.GenerateKeywordIdeasSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateKeywordIdeas);
            Modify_GenerateKeywordIdeasApiCall(ref _callGenerateKeywordIdeas);
            _callGenerateKeywordHistoricalMetrics = clientHelper.BuildApiCall<GenerateKeywordHistoricalMetricsRequest, GenerateKeywordHistoricalMetricsResponse>("GenerateKeywordHistoricalMetrics", grpcClient.GenerateKeywordHistoricalMetricsAsync, grpcClient.GenerateKeywordHistoricalMetrics, effectiveSettings.GenerateKeywordHistoricalMetricsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateKeywordHistoricalMetrics);
            Modify_GenerateKeywordHistoricalMetricsApiCall(ref _callGenerateKeywordHistoricalMetrics);
            _callGenerateAdGroupThemes = clientHelper.BuildApiCall<GenerateAdGroupThemesRequest, GenerateAdGroupThemesResponse>("GenerateAdGroupThemes", grpcClient.GenerateAdGroupThemesAsync, grpcClient.GenerateAdGroupThemes, effectiveSettings.GenerateAdGroupThemesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateAdGroupThemes);
            Modify_GenerateAdGroupThemesApiCall(ref _callGenerateAdGroupThemes);
            _callGenerateKeywordForecastMetrics = clientHelper.BuildApiCall<GenerateKeywordForecastMetricsRequest, GenerateKeywordForecastMetricsResponse>("GenerateKeywordForecastMetrics", grpcClient.GenerateKeywordForecastMetricsAsync, grpcClient.GenerateKeywordForecastMetrics, effectiveSettings.GenerateKeywordForecastMetricsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateKeywordForecastMetrics);
            Modify_GenerateKeywordForecastMetricsApiCall(ref _callGenerateKeywordForecastMetrics);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateKeywordIdeasApiCall(ref gaxgrpc::ApiCall<GenerateKeywordIdeasRequest, GenerateKeywordIdeaResponse> call);

        partial void Modify_GenerateKeywordHistoricalMetricsApiCall(ref gaxgrpc::ApiCall<GenerateKeywordHistoricalMetricsRequest, GenerateKeywordHistoricalMetricsResponse> call);

        partial void Modify_GenerateAdGroupThemesApiCall(ref gaxgrpc::ApiCall<GenerateAdGroupThemesRequest, GenerateAdGroupThemesResponse> call);

        partial void Modify_GenerateKeywordForecastMetricsApiCall(ref gaxgrpc::ApiCall<GenerateKeywordForecastMetricsRequest, GenerateKeywordForecastMetricsResponse> call);

        partial void OnConstruction(KeywordPlanIdeaService.KeywordPlanIdeaServiceClient grpcClient, KeywordPlanIdeaServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeywordPlanIdeaService client</summary>
        public override KeywordPlanIdeaService.KeywordPlanIdeaServiceClient GrpcClient { get; }

        partial void Modify_GenerateKeywordIdeasRequest(ref GenerateKeywordIdeasRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateKeywordHistoricalMetricsRequest(ref GenerateKeywordHistoricalMetricsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateAdGroupThemesRequest(ref GenerateAdGroupThemesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateKeywordForecastMetricsRequest(ref GenerateKeywordForecastMetricsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns a list of keyword ideas.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanIdeaError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GenerateKeywordIdeaResult"/> resources.</returns>
        public override gax::PagedEnumerable<GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult> GenerateKeywordIdeas(GenerateKeywordIdeasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateKeywordIdeasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<GenerateKeywordIdeasRequest, GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult>(_callGenerateKeywordIdeas, request, callSettings);
        }

        /// <summary>
        /// Returns a list of keyword ideas.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanIdeaError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GenerateKeywordIdeaResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult> GenerateKeywordIdeasAsync(GenerateKeywordIdeasRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateKeywordIdeasRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<GenerateKeywordIdeasRequest, GenerateKeywordIdeaResponse, GenerateKeywordIdeaResult>(_callGenerateKeywordIdeas, request, callSettings);
        }

        /// <summary>
        /// Returns a list of keyword historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateKeywordHistoricalMetricsResponse GenerateKeywordHistoricalMetrics(GenerateKeywordHistoricalMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateKeywordHistoricalMetricsRequest(ref request, ref callSettings);
            return _callGenerateKeywordHistoricalMetrics.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of keyword historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateKeywordHistoricalMetricsResponse> GenerateKeywordHistoricalMetricsAsync(GenerateKeywordHistoricalMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateKeywordHistoricalMetricsRequest(ref request, ref callSettings);
            return _callGenerateKeywordHistoricalMetrics.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a list of suggested AdGroups and suggested modifications
        /// (text, match type) for the given keywords.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateAdGroupThemesResponse GenerateAdGroupThemes(GenerateAdGroupThemesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAdGroupThemesRequest(ref request, ref callSettings);
            return _callGenerateAdGroupThemes.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a list of suggested AdGroups and suggested modifications
        /// (text, match type) for the given keywords.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateAdGroupThemesResponse> GenerateAdGroupThemesAsync(GenerateAdGroupThemesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateAdGroupThemesRequest(ref request, ref callSettings);
            return _callGenerateAdGroupThemes.Async(request, callSettings);
        }

        /// <summary>
        /// Returns metrics (such as impressions, clicks, total cost) of a keyword
        /// forecast for the given campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateKeywordForecastMetricsResponse GenerateKeywordForecastMetrics(GenerateKeywordForecastMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateKeywordForecastMetricsRequest(ref request, ref callSettings);
            return _callGenerateKeywordForecastMetrics.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns metrics (such as impressions, clicks, total cost) of a keyword
        /// forecast for the given campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateKeywordForecastMetricsResponse> GenerateKeywordForecastMetricsAsync(GenerateKeywordForecastMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateKeywordForecastMetricsRequest(ref request, ref callSettings);
            return _callGenerateKeywordForecastMetrics.Async(request, callSettings);
        }
    }

    public partial class GenerateKeywordIdeasRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class GenerateKeywordIdeaResponse : gaxgrpc::IPageResponse<GenerateKeywordIdeaResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GenerateKeywordIdeaResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

// Copyright 2021 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V9.Services
{
    /// <summary>Settings for <see cref="KeywordPlanServiceClient"/> instances.</summary>
    public sealed partial class KeywordPlanServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KeywordPlanServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KeywordPlanServiceSettings"/>.</returns>
        public static KeywordPlanServiceSettings GetDefault() => new KeywordPlanServiceSettings();

        /// <summary>Constructs a new <see cref="KeywordPlanServiceSettings"/> object with default settings.</summary>
        public KeywordPlanServiceSettings()
        {
        }

        private KeywordPlanServiceSettings(KeywordPlanServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetKeywordPlanSettings = existing.GetKeywordPlanSettings;
            MutateKeywordPlansSettings = existing.MutateKeywordPlansSettings;
            GenerateForecastCurveSettings = existing.GenerateForecastCurveSettings;
            GenerateForecastTimeSeriesSettings = existing.GenerateForecastTimeSeriesSettings;
            GenerateForecastMetricsSettings = existing.GenerateForecastMetricsSettings;
            GenerateHistoricalMetricsSettings = existing.GenerateHistoricalMetricsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanServiceClient.GetKeywordPlan</c> and <c>KeywordPlanServiceClient.GetKeywordPlanAsync</c>.
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
        public gaxgrpc::CallSettings GetKeywordPlanSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanServiceClient.MutateKeywordPlans</c> and <c>KeywordPlanServiceClient.MutateKeywordPlansAsync</c>
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
        public gaxgrpc::CallSettings MutateKeywordPlansSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanServiceClient.GenerateForecastCurve</c> and
        /// <c>KeywordPlanServiceClient.GenerateForecastCurveAsync</c>.
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
        public gaxgrpc::CallSettings GenerateForecastCurveSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanServiceClient.GenerateForecastTimeSeries</c> and
        /// <c>KeywordPlanServiceClient.GenerateForecastTimeSeriesAsync</c>.
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
        public gaxgrpc::CallSettings GenerateForecastTimeSeriesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanServiceClient.GenerateForecastMetrics</c> and
        /// <c>KeywordPlanServiceClient.GenerateForecastMetricsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateForecastMetricsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanServiceClient.GenerateHistoricalMetrics</c> and
        /// <c>KeywordPlanServiceClient.GenerateHistoricalMetricsAsync</c>.
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
        public gaxgrpc::CallSettings GenerateHistoricalMetricsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanServiceSettings"/> object.</returns>
        public KeywordPlanServiceSettings Clone() => new KeywordPlanServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class KeywordPlanServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeywordPlanServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public KeywordPlanServiceClientBuilder()
        {
            UseJwtAccessWithScopes = KeywordPlanServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref KeywordPlanServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeywordPlanServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeywordPlanServiceClient Build()
        {
            KeywordPlanServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeywordPlanServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeywordPlanServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeywordPlanServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<KeywordPlanServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => KeywordPlanServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => KeywordPlanServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>KeywordPlanService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage keyword plans.
    /// </remarks>
    public abstract partial class KeywordPlanServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default KeywordPlanService scopes.</summary>
        /// <remarks>
        /// The default KeywordPlanService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="KeywordPlanServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeywordPlanServiceClient"/>.</returns>
        public static stt::Task<KeywordPlanServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeywordPlanServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="KeywordPlanServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="KeywordPlanServiceClient"/>.</returns>
        public static KeywordPlanServiceClient Create() => new KeywordPlanServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeywordPlanServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeywordPlanServiceSettings"/>.</param>
        /// <returns>The created <see cref="KeywordPlanServiceClient"/>.</returns>
        internal static KeywordPlanServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanService.KeywordPlanServiceClient grpcClient = new KeywordPlanService.KeywordPlanServiceClient(callInvoker);
            return new KeywordPlanServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC KeywordPlanService client</summary>
        public virtual KeywordPlanService.KeywordPlanServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested plan in full detail.
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
        public virtual gagvr::KeywordPlan GetKeywordPlan(GetKeywordPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested plan in full detail.
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
        public virtual stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(GetKeywordPlanRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested plan in full detail.
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
        public virtual stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(GetKeywordPlanRequest request, st::CancellationToken cancellationToken) =>
            GetKeywordPlanAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested plan in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlan GetKeywordPlan(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlan(new GetKeywordPlanRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanAsync(new GetKeywordPlanRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested plan in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::KeywordPlan GetKeywordPlan(gagvr::KeywordPlanName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlan(new GetKeywordPlanRequest
            {
                ResourceNameAsKeywordPlanName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(gagvr::KeywordPlanName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetKeywordPlanAsync(new GetKeywordPlanRequest
            {
                ResourceNameAsKeywordPlanName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested plan in full detail.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the plan to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(gagvr::KeywordPlanName resourceName, st::CancellationToken cancellationToken) =>
            GetKeywordPlanAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlansResponse MutateKeywordPlans(MutateKeywordPlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(MutateKeywordPlansRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(MutateKeywordPlansRequest request, st::CancellationToken cancellationToken) =>
            MutateKeywordPlansAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose keyword plans are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual keyword plans.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlansResponse MutateKeywordPlans(string customerId, scg::IEnumerable<KeywordPlanOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlans(new MutateKeywordPlansRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose keyword plans are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual keyword plans.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(string customerId, scg::IEnumerable<KeywordPlanOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlansAsync(new MutateKeywordPlansRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose keyword plans are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual keyword plans.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(string customerId, scg::IEnumerable<KeywordPlanOperation> operations, st::CancellationToken cancellationToken) =>
            MutateKeywordPlansAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateForecastCurveResponse GenerateForecastCurve(GenerateForecastCurveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastCurveResponse> GenerateForecastCurveAsync(GenerateForecastCurveRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastCurveResponse> GenerateForecastCurveAsync(GenerateForecastCurveRequest request, st::CancellationToken cancellationToken) =>
            GenerateForecastCurveAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateForecastCurveResponse GenerateForecastCurve(string keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastCurve(new GenerateForecastCurveRequest
            {
                KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastCurveResponse> GenerateForecastCurveAsync(string keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastCurveAsync(new GenerateForecastCurveRequest
            {
                KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastCurveResponse> GenerateForecastCurveAsync(string keywordPlan, st::CancellationToken cancellationToken) =>
            GenerateForecastCurveAsync(keywordPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateForecastCurveResponse GenerateForecastCurve(gagvr::KeywordPlanName keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastCurve(new GenerateForecastCurveRequest
            {
                KeywordPlanAsKeywordPlanName = gax::GaxPreconditions.CheckNotNull(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastCurveResponse> GenerateForecastCurveAsync(gagvr::KeywordPlanName keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastCurveAsync(new GenerateForecastCurveRequest
            {
                KeywordPlanAsKeywordPlanName = gax::GaxPreconditions.CheckNotNull(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastCurveResponse> GenerateForecastCurveAsync(gagvr::KeywordPlanName keywordPlan, st::CancellationToken cancellationToken) =>
            GenerateForecastCurveAsync(keywordPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateForecastTimeSeriesResponse GenerateForecastTimeSeries(GenerateForecastTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastTimeSeriesResponse> GenerateForecastTimeSeriesAsync(GenerateForecastTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastTimeSeriesResponse> GenerateForecastTimeSeriesAsync(GenerateForecastTimeSeriesRequest request, st::CancellationToken cancellationToken) =>
            GenerateForecastTimeSeriesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateForecastTimeSeriesResponse GenerateForecastTimeSeries(string keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastTimeSeries(new GenerateForecastTimeSeriesRequest
            {
                KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastTimeSeriesResponse> GenerateForecastTimeSeriesAsync(string keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastTimeSeriesAsync(new GenerateForecastTimeSeriesRequest
            {
                KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastTimeSeriesResponse> GenerateForecastTimeSeriesAsync(string keywordPlan, st::CancellationToken cancellationToken) =>
            GenerateForecastTimeSeriesAsync(keywordPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateForecastTimeSeriesResponse GenerateForecastTimeSeries(gagvr::KeywordPlanName keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastTimeSeries(new GenerateForecastTimeSeriesRequest
            {
                KeywordPlanAsKeywordPlanName = gax::GaxPreconditions.CheckNotNull(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastTimeSeriesResponse> GenerateForecastTimeSeriesAsync(gagvr::KeywordPlanName keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastTimeSeriesAsync(new GenerateForecastTimeSeriesRequest
            {
                KeywordPlanAsKeywordPlanName = gax::GaxPreconditions.CheckNotNull(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastTimeSeriesResponse> GenerateForecastTimeSeriesAsync(gagvr::KeywordPlanName keywordPlan, st::CancellationToken cancellationToken) =>
            GenerateForecastTimeSeriesAsync(keywordPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateForecastMetricsResponse GenerateForecastMetrics(GenerateForecastMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(GenerateForecastMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(GenerateForecastMetricsRequest request, st::CancellationToken cancellationToken) =>
            GenerateForecastMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateForecastMetricsResponse GenerateForecastMetrics(string keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastMetrics(new GenerateForecastMetricsRequest
            {
                KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(string keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastMetricsAsync(new GenerateForecastMetricsRequest
            {
                KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(string keywordPlan, st::CancellationToken cancellationToken) =>
            GenerateForecastMetricsAsync(keywordPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateForecastMetricsResponse GenerateForecastMetrics(gagvr::KeywordPlanName keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastMetrics(new GenerateForecastMetricsRequest
            {
                KeywordPlanAsKeywordPlanName = gax::GaxPreconditions.CheckNotNull(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(gagvr::KeywordPlanName keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateForecastMetricsAsync(new GenerateForecastMetricsRequest
            {
                KeywordPlanAsKeywordPlanName = gax::GaxPreconditions.CheckNotNull(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan to be forecasted.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(gagvr::KeywordPlanName keywordPlan, st::CancellationToken cancellationToken) =>
            GenerateForecastMetricsAsync(keywordPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateHistoricalMetricsResponse GenerateHistoricalMetrics(GenerateHistoricalMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(GenerateHistoricalMetricsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(GenerateHistoricalMetricsRequest request, st::CancellationToken cancellationToken) =>
            GenerateHistoricalMetricsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan of which historical metrics are
        /// requested.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateHistoricalMetricsResponse GenerateHistoricalMetrics(string keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateHistoricalMetrics(new GenerateHistoricalMetricsRequest
            {
                KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan of which historical metrics are
        /// requested.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(string keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateHistoricalMetricsAsync(new GenerateHistoricalMetricsRequest
            {
                KeywordPlan = gax::GaxPreconditions.CheckNotNullOrEmpty(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan of which historical metrics are
        /// requested.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(string keywordPlan, st::CancellationToken cancellationToken) =>
            GenerateHistoricalMetricsAsync(keywordPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan of which historical metrics are
        /// requested.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateHistoricalMetricsResponse GenerateHistoricalMetrics(gagvr::KeywordPlanName keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateHistoricalMetrics(new GenerateHistoricalMetricsRequest
            {
                KeywordPlanAsKeywordPlanName = gax::GaxPreconditions.CheckNotNull(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan of which historical metrics are
        /// requested.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(gagvr::KeywordPlanName keywordPlan, gaxgrpc::CallSettings callSettings = null) =>
            GenerateHistoricalMetricsAsync(new GenerateHistoricalMetricsRequest
            {
                KeywordPlanAsKeywordPlanName = gax::GaxPreconditions.CheckNotNull(keywordPlan, nameof(keywordPlan)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="keywordPlan">
        /// Required. The resource name of the keyword plan of which historical metrics are
        /// requested.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(gagvr::KeywordPlanName keywordPlan, st::CancellationToken cancellationToken) =>
            GenerateHistoricalMetricsAsync(keywordPlan, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>KeywordPlanService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage keyword plans.
    /// </remarks>
    public sealed partial class KeywordPlanServiceClientImpl : KeywordPlanServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetKeywordPlanRequest, gagvr::KeywordPlan> _callGetKeywordPlan;

        private readonly gaxgrpc::ApiCall<MutateKeywordPlansRequest, MutateKeywordPlansResponse> _callMutateKeywordPlans;

        private readonly gaxgrpc::ApiCall<GenerateForecastCurveRequest, GenerateForecastCurveResponse> _callGenerateForecastCurve;

        private readonly gaxgrpc::ApiCall<GenerateForecastTimeSeriesRequest, GenerateForecastTimeSeriesResponse> _callGenerateForecastTimeSeries;

        private readonly gaxgrpc::ApiCall<GenerateForecastMetricsRequest, GenerateForecastMetricsResponse> _callGenerateForecastMetrics;

        private readonly gaxgrpc::ApiCall<GenerateHistoricalMetricsRequest, GenerateHistoricalMetricsResponse> _callGenerateHistoricalMetrics;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="KeywordPlanServiceSettings"/> used within this client.</param>
        public KeywordPlanServiceClientImpl(KeywordPlanService.KeywordPlanServiceClient grpcClient, KeywordPlanServiceSettings settings)
        {
            GrpcClient = grpcClient;
            KeywordPlanServiceSettings effectiveSettings = settings ?? KeywordPlanServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetKeywordPlan = clientHelper.BuildApiCall<GetKeywordPlanRequest, gagvr::KeywordPlan>(grpcClient.GetKeywordPlanAsync, grpcClient.GetKeywordPlan, effectiveSettings.GetKeywordPlanSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetKeywordPlan);
            Modify_GetKeywordPlanApiCall(ref _callGetKeywordPlan);
            _callMutateKeywordPlans = clientHelper.BuildApiCall<MutateKeywordPlansRequest, MutateKeywordPlansResponse>(grpcClient.MutateKeywordPlansAsync, grpcClient.MutateKeywordPlans, effectiveSettings.MutateKeywordPlansSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateKeywordPlans);
            Modify_MutateKeywordPlansApiCall(ref _callMutateKeywordPlans);
            _callGenerateForecastCurve = clientHelper.BuildApiCall<GenerateForecastCurveRequest, GenerateForecastCurveResponse>(grpcClient.GenerateForecastCurveAsync, grpcClient.GenerateForecastCurve, effectiveSettings.GenerateForecastCurveSettings).WithGoogleRequestParam("keyword_plan", request => request.KeywordPlan);
            Modify_ApiCall(ref _callGenerateForecastCurve);
            Modify_GenerateForecastCurveApiCall(ref _callGenerateForecastCurve);
            _callGenerateForecastTimeSeries = clientHelper.BuildApiCall<GenerateForecastTimeSeriesRequest, GenerateForecastTimeSeriesResponse>(grpcClient.GenerateForecastTimeSeriesAsync, grpcClient.GenerateForecastTimeSeries, effectiveSettings.GenerateForecastTimeSeriesSettings).WithGoogleRequestParam("keyword_plan", request => request.KeywordPlan);
            Modify_ApiCall(ref _callGenerateForecastTimeSeries);
            Modify_GenerateForecastTimeSeriesApiCall(ref _callGenerateForecastTimeSeries);
            _callGenerateForecastMetrics = clientHelper.BuildApiCall<GenerateForecastMetricsRequest, GenerateForecastMetricsResponse>(grpcClient.GenerateForecastMetricsAsync, grpcClient.GenerateForecastMetrics, effectiveSettings.GenerateForecastMetricsSettings).WithGoogleRequestParam("keyword_plan", request => request.KeywordPlan);
            Modify_ApiCall(ref _callGenerateForecastMetrics);
            Modify_GenerateForecastMetricsApiCall(ref _callGenerateForecastMetrics);
            _callGenerateHistoricalMetrics = clientHelper.BuildApiCall<GenerateHistoricalMetricsRequest, GenerateHistoricalMetricsResponse>(grpcClient.GenerateHistoricalMetricsAsync, grpcClient.GenerateHistoricalMetrics, effectiveSettings.GenerateHistoricalMetricsSettings).WithGoogleRequestParam("keyword_plan", request => request.KeywordPlan);
            Modify_ApiCall(ref _callGenerateHistoricalMetrics);
            Modify_GenerateHistoricalMetricsApiCall(ref _callGenerateHistoricalMetrics);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetKeywordPlanApiCall(ref gaxgrpc::ApiCall<GetKeywordPlanRequest, gagvr::KeywordPlan> call);

        partial void Modify_MutateKeywordPlansApiCall(ref gaxgrpc::ApiCall<MutateKeywordPlansRequest, MutateKeywordPlansResponse> call);

        partial void Modify_GenerateForecastCurveApiCall(ref gaxgrpc::ApiCall<GenerateForecastCurveRequest, GenerateForecastCurveResponse> call);

        partial void Modify_GenerateForecastTimeSeriesApiCall(ref gaxgrpc::ApiCall<GenerateForecastTimeSeriesRequest, GenerateForecastTimeSeriesResponse> call);

        partial void Modify_GenerateForecastMetricsApiCall(ref gaxgrpc::ApiCall<GenerateForecastMetricsRequest, GenerateForecastMetricsResponse> call);

        partial void Modify_GenerateHistoricalMetricsApiCall(ref gaxgrpc::ApiCall<GenerateHistoricalMetricsRequest, GenerateHistoricalMetricsResponse> call);

        partial void OnConstruction(KeywordPlanService.KeywordPlanServiceClient grpcClient, KeywordPlanServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeywordPlanService client</summary>
        public override KeywordPlanService.KeywordPlanServiceClient GrpcClient { get; }

        partial void Modify_GetKeywordPlanRequest(ref GetKeywordPlanRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateKeywordPlansRequest(ref MutateKeywordPlansRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateForecastCurveRequest(ref GenerateForecastCurveRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateForecastTimeSeriesRequest(ref GenerateForecastTimeSeriesRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateForecastMetricsRequest(ref GenerateForecastMetricsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GenerateHistoricalMetricsRequest(ref GenerateHistoricalMetricsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested plan in full detail.
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
        public override gagvr::KeywordPlan GetKeywordPlan(GetKeywordPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanRequest(ref request, ref callSettings);
            return _callGetKeywordPlan.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested plan in full detail.
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
        public override stt::Task<gagvr::KeywordPlan> GetKeywordPlanAsync(GetKeywordPlanRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetKeywordPlanRequest(ref request, ref callSettings);
            return _callGetKeywordPlan.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateKeywordPlansResponse MutateKeywordPlans(MutateKeywordPlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlansRequest(ref request, ref callSettings);
            return _callMutateKeywordPlans.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes keyword plans. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateKeywordPlansResponse> MutateKeywordPlansAsync(MutateKeywordPlansRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlansRequest(ref request, ref callSettings);
            return _callMutateKeywordPlans.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateForecastCurveResponse GenerateForecastCurve(GenerateForecastCurveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateForecastCurveRequest(ref request, ref callSettings);
            return _callGenerateForecastCurve.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan forecast curve.
        /// Only the bidding strategy is considered for generating forecast curve.
        /// The bidding strategy value specified in the plan is ignored.
        /// 
        /// To generate a forecast at a value specified in the plan, use
        /// KeywordPlanService.GenerateForecastMetrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateForecastCurveResponse> GenerateForecastCurveAsync(GenerateForecastCurveRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateForecastCurveRequest(ref request, ref callSettings);
            return _callGenerateForecastCurve.Async(request, callSettings);
        }

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateForecastTimeSeriesResponse GenerateForecastTimeSeries(GenerateForecastTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateForecastTimeSeriesRequest(ref request, ref callSettings);
            return _callGenerateForecastTimeSeries.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns a forecast in the form of a time series for the Keyword Plan over
        /// the next 52 weeks.
        /// (1) Forecasts closer to the current date are generally more accurate than
        /// further out.
        /// 
        /// (2) The forecast reflects seasonal trends using current and
        /// prior traffic patterns. The forecast period of the plan is ignored.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateForecastTimeSeriesResponse> GenerateForecastTimeSeriesAsync(GenerateForecastTimeSeriesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateForecastTimeSeriesRequest(ref request, ref callSettings);
            return _callGenerateForecastTimeSeries.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateForecastMetricsResponse GenerateForecastMetrics(GenerateForecastMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateForecastMetricsRequest(ref request, ref callSettings);
            return _callGenerateForecastMetrics.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan forecasts.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateForecastMetricsResponse> GenerateForecastMetricsAsync(GenerateForecastMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateForecastMetricsRequest(ref request, ref callSettings);
            return _callGenerateForecastMetrics.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GenerateHistoricalMetricsResponse GenerateHistoricalMetrics(GenerateHistoricalMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateHistoricalMetricsRequest(ref request, ref callSettings);
            return _callGenerateHistoricalMetrics.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Keyword Plan historical metrics.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GenerateHistoricalMetricsResponse> GenerateHistoricalMetricsAsync(GenerateHistoricalMetricsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateHistoricalMetricsRequest(ref request, ref callSettings);
            return _callGenerateHistoricalMetrics.Async(request, callSettings);
        }
    }
}

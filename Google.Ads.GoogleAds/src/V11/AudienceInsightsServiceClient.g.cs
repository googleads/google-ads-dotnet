// Copyright 2022 Google LLC
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

using gagve = Google.Ads.GoogleAds.V11.Enums;
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

namespace Google.Ads.GoogleAds.V11.Services
{
    /// <summary>Settings for <see cref="AudienceInsightsServiceClient"/> instances.</summary>
    public sealed partial class AudienceInsightsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AudienceInsightsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AudienceInsightsServiceSettings"/>.</returns>
        public static AudienceInsightsServiceSettings GetDefault() => new AudienceInsightsServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AudienceInsightsServiceSettings"/> object with default settings.
        /// </summary>
        public AudienceInsightsServiceSettings()
        {
        }

        private AudienceInsightsServiceSettings(AudienceInsightsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GenerateInsightsFinderReportSettings = existing.GenerateInsightsFinderReportSettings;
            ListAudienceInsightsAttributesSettings = existing.ListAudienceInsightsAttributesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AudienceInsightsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AudienceInsightsServiceClient.GenerateInsightsFinderReport</c> and
        /// <c>AudienceInsightsServiceClient.GenerateInsightsFinderReportAsync</c>.
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
        public gaxgrpc::CallSettings GenerateInsightsFinderReportSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AudienceInsightsServiceClient.ListAudienceInsightsAttributes</c> and
        /// <c>AudienceInsightsServiceClient.ListAudienceInsightsAttributesAsync</c>.
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
        public gaxgrpc::CallSettings ListAudienceInsightsAttributesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AudienceInsightsServiceSettings"/> object.</returns>
        public AudienceInsightsServiceSettings Clone() => new AudienceInsightsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AudienceInsightsServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AudienceInsightsServiceClientBuilder : gaxgrpc::ClientBuilderBase<AudienceInsightsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AudienceInsightsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AudienceInsightsServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AudienceInsightsServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AudienceInsightsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AudienceInsightsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AudienceInsightsServiceClient Build()
        {
            AudienceInsightsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AudienceInsightsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AudienceInsightsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AudienceInsightsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AudienceInsightsServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AudienceInsightsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AudienceInsightsServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AudienceInsightsServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AudienceInsightsServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AudienceInsightsServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AudienceInsightsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Audience Insights Service helps users find information about groups of
    /// people and how they can be reached with Google Ads.
    /// </remarks>
    public abstract partial class AudienceInsightsServiceClient
    {
        /// <summary>
        /// The default endpoint for the AudienceInsightsService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AudienceInsightsService scopes.</summary>
        /// <remarks>
        /// The default AudienceInsightsService scopes are:
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
        /// Asynchronously creates a <see cref="AudienceInsightsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AudienceInsightsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AudienceInsightsServiceClient"/>.</returns>
        public static stt::Task<AudienceInsightsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AudienceInsightsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AudienceInsightsServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AudienceInsightsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AudienceInsightsServiceClient"/>.</returns>
        public static AudienceInsightsServiceClient Create() => new AudienceInsightsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AudienceInsightsServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AudienceInsightsServiceSettings"/>.</param>
        /// <returns>The created <see cref="AudienceInsightsServiceClient"/>.</returns>
        internal static AudienceInsightsServiceClient Create(grpccore::CallInvoker callInvoker, AudienceInsightsServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AudienceInsightsService.AudienceInsightsServiceClient grpcClient = new AudienceInsightsService.AudienceInsightsServiceClient(callInvoker);
            return new AudienceInsightsServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AudienceInsightsService client</summary>
        public virtual AudienceInsightsService.AudienceInsightsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a saved report that can be viewed in the Insights Finder tool.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public virtual GenerateInsightsFinderReportResponse GenerateInsightsFinderReport(GenerateInsightsFinderReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a saved report that can be viewed in the Insights Finder tool.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public virtual stt::Task<GenerateInsightsFinderReportResponse> GenerateInsightsFinderReportAsync(GenerateInsightsFinderReportRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a saved report that can be viewed in the Insights Finder tool.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public virtual stt::Task<GenerateInsightsFinderReportResponse> GenerateInsightsFinderReportAsync(GenerateInsightsFinderReportRequest request, st::CancellationToken cancellationToken) =>
            GenerateInsightsFinderReportAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a saved report that can be viewed in the Insights Finder tool.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="baselineAudience">
        /// Required. A baseline audience for this report, typically all people in a region.
        /// </param>
        /// <param name="specificAudience">
        /// Required. The specific audience of interest for this report.  The insights in the
        /// report will be based on attributes more prevalent in this audience than
        /// in the report's baseline audience.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GenerateInsightsFinderReportResponse GenerateInsightsFinderReport(string customerId, BasicInsightsAudience baselineAudience, BasicInsightsAudience specificAudience, gaxgrpc::CallSettings callSettings = null) =>
            GenerateInsightsFinderReport(new GenerateInsightsFinderReportRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                BaselineAudience = gax::GaxPreconditions.CheckNotNull(baselineAudience, nameof(baselineAudience)),
                SpecificAudience = gax::GaxPreconditions.CheckNotNull(specificAudience, nameof(specificAudience)),
            }, callSettings);

        /// <summary>
        /// Creates a saved report that can be viewed in the Insights Finder tool.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="baselineAudience">
        /// Required. A baseline audience for this report, typically all people in a region.
        /// </param>
        /// <param name="specificAudience">
        /// Required. The specific audience of interest for this report.  The insights in the
        /// report will be based on attributes more prevalent in this audience than
        /// in the report's baseline audience.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateInsightsFinderReportResponse> GenerateInsightsFinderReportAsync(string customerId, BasicInsightsAudience baselineAudience, BasicInsightsAudience specificAudience, gaxgrpc::CallSettings callSettings = null) =>
            GenerateInsightsFinderReportAsync(new GenerateInsightsFinderReportRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                BaselineAudience = gax::GaxPreconditions.CheckNotNull(baselineAudience, nameof(baselineAudience)),
                SpecificAudience = gax::GaxPreconditions.CheckNotNull(specificAudience, nameof(specificAudience)),
            }, callSettings);

        /// <summary>
        /// Creates a saved report that can be viewed in the Insights Finder tool.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="baselineAudience">
        /// Required. A baseline audience for this report, typically all people in a region.
        /// </param>
        /// <param name="specificAudience">
        /// Required. The specific audience of interest for this report.  The insights in the
        /// report will be based on attributes more prevalent in this audience than
        /// in the report's baseline audience.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GenerateInsightsFinderReportResponse> GenerateInsightsFinderReportAsync(string customerId, BasicInsightsAudience baselineAudience, BasicInsightsAudience specificAudience, st::CancellationToken cancellationToken) =>
            GenerateInsightsFinderReportAsync(customerId, baselineAudience, specificAudience, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches for audience attributes that can be used to generate insights.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public virtual ListAudienceInsightsAttributesResponse ListAudienceInsightsAttributes(ListAudienceInsightsAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for audience attributes that can be used to generate insights.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public virtual stt::Task<ListAudienceInsightsAttributesResponse> ListAudienceInsightsAttributesAsync(ListAudienceInsightsAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Searches for audience attributes that can be used to generate insights.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public virtual stt::Task<ListAudienceInsightsAttributesResponse> ListAudienceInsightsAttributesAsync(ListAudienceInsightsAttributesRequest request, st::CancellationToken cancellationToken) =>
            ListAudienceInsightsAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Searches for audience attributes that can be used to generate insights.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="dimensions">
        /// Required. The types of attributes to be returned.
        /// </param>
        /// <param name="queryText">
        /// Required. A free text query.  Attributes matching or related to this string will be
        /// returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListAudienceInsightsAttributesResponse ListAudienceInsightsAttributes(string customerId, scg::IEnumerable<gagve::AudienceInsightsDimensionEnum.Types.AudienceInsightsDimension> dimensions, string queryText, gaxgrpc::CallSettings callSettings = null) =>
            ListAudienceInsightsAttributes(new ListAudienceInsightsAttributesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Dimensions =
                {
                    gax::GaxPreconditions.CheckNotNull(dimensions, nameof(dimensions)),
                },
                QueryText = gax::GaxPreconditions.CheckNotNullOrEmpty(queryText, nameof(queryText)),
            }, callSettings);

        /// <summary>
        /// Searches for audience attributes that can be used to generate insights.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="dimensions">
        /// Required. The types of attributes to be returned.
        /// </param>
        /// <param name="queryText">
        /// Required. A free text query.  Attributes matching or related to this string will be
        /// returned.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListAudienceInsightsAttributesResponse> ListAudienceInsightsAttributesAsync(string customerId, scg::IEnumerable<gagve::AudienceInsightsDimensionEnum.Types.AudienceInsightsDimension> dimensions, string queryText, gaxgrpc::CallSettings callSettings = null) =>
            ListAudienceInsightsAttributesAsync(new ListAudienceInsightsAttributesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Dimensions =
                {
                    gax::GaxPreconditions.CheckNotNull(dimensions, nameof(dimensions)),
                },
                QueryText = gax::GaxPreconditions.CheckNotNullOrEmpty(queryText, nameof(queryText)),
            }, callSettings);

        /// <summary>
        /// Searches for audience attributes that can be used to generate insights.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="dimensions">
        /// Required. The types of attributes to be returned.
        /// </param>
        /// <param name="queryText">
        /// Required. A free text query.  Attributes matching or related to this string will be
        /// returned.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListAudienceInsightsAttributesResponse> ListAudienceInsightsAttributesAsync(string customerId, scg::IEnumerable<gagve::AudienceInsightsDimensionEnum.Types.AudienceInsightsDimension> dimensions, string queryText, st::CancellationToken cancellationToken) =>
            ListAudienceInsightsAttributesAsync(customerId, dimensions, queryText, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AudienceInsightsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Audience Insights Service helps users find information about groups of
    /// people and how they can be reached with Google Ads.
    /// </remarks>
    public sealed partial class AudienceInsightsServiceClientImpl : AudienceInsightsServiceClient
    {
        private readonly gaxgrpc::ApiCall<GenerateInsightsFinderReportRequest, GenerateInsightsFinderReportResponse> _callGenerateInsightsFinderReport;

        private readonly gaxgrpc::ApiCall<ListAudienceInsightsAttributesRequest, ListAudienceInsightsAttributesResponse> _callListAudienceInsightsAttributes;

        /// <summary>
        /// Constructs a client wrapper for the AudienceInsightsService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AudienceInsightsServiceSettings"/> used within this client.
        /// </param>
        public AudienceInsightsServiceClientImpl(AudienceInsightsService.AudienceInsightsServiceClient grpcClient, AudienceInsightsServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AudienceInsightsServiceSettings effectiveSettings = settings ?? AudienceInsightsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGenerateInsightsFinderReport = clientHelper.BuildApiCall<GenerateInsightsFinderReportRequest, GenerateInsightsFinderReportResponse>(grpcClient.GenerateInsightsFinderReportAsync, grpcClient.GenerateInsightsFinderReport, effectiveSettings.GenerateInsightsFinderReportSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callGenerateInsightsFinderReport);
            Modify_GenerateInsightsFinderReportApiCall(ref _callGenerateInsightsFinderReport);
            _callListAudienceInsightsAttributes = clientHelper.BuildApiCall<ListAudienceInsightsAttributesRequest, ListAudienceInsightsAttributesResponse>(grpcClient.ListAudienceInsightsAttributesAsync, grpcClient.ListAudienceInsightsAttributes, effectiveSettings.ListAudienceInsightsAttributesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callListAudienceInsightsAttributes);
            Modify_ListAudienceInsightsAttributesApiCall(ref _callListAudienceInsightsAttributes);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GenerateInsightsFinderReportApiCall(ref gaxgrpc::ApiCall<GenerateInsightsFinderReportRequest, GenerateInsightsFinderReportResponse> call);

        partial void Modify_ListAudienceInsightsAttributesApiCall(ref gaxgrpc::ApiCall<ListAudienceInsightsAttributesRequest, ListAudienceInsightsAttributesResponse> call);

        partial void OnConstruction(AudienceInsightsService.AudienceInsightsServiceClient grpcClient, AudienceInsightsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AudienceInsightsService client</summary>
        public override AudienceInsightsService.AudienceInsightsServiceClient GrpcClient { get; }

        partial void Modify_GenerateInsightsFinderReportRequest(ref GenerateInsightsFinderReportRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListAudienceInsightsAttributesRequest(ref ListAudienceInsightsAttributesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a saved report that can be viewed in the Insights Finder tool.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public override GenerateInsightsFinderReportResponse GenerateInsightsFinderReport(GenerateInsightsFinderReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateInsightsFinderReportRequest(ref request, ref callSettings);
            return _callGenerateInsightsFinderReport.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a saved report that can be viewed in the Insights Finder tool.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public override stt::Task<GenerateInsightsFinderReportResponse> GenerateInsightsFinderReportAsync(GenerateInsightsFinderReportRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GenerateInsightsFinderReportRequest(ref request, ref callSettings);
            return _callGenerateInsightsFinderReport.Async(request, callSettings);
        }

        /// <summary>
        /// Searches for audience attributes that can be used to generate insights.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public override ListAudienceInsightsAttributesResponse ListAudienceInsightsAttributes(ListAudienceInsightsAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAudienceInsightsAttributesRequest(ref request, ref callSettings);
            return _callListAudienceInsightsAttributes.Sync(request, callSettings);
        }

        /// <summary>
        /// Searches for audience attributes that can be used to generate insights.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
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
        public override stt::Task<ListAudienceInsightsAttributesResponse> ListAudienceInsightsAttributesAsync(ListAudienceInsightsAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListAudienceInsightsAttributesRequest(ref request, ref callSettings);
            return _callListAudienceInsightsAttributes.Async(request, callSettings);
        }
    }
}

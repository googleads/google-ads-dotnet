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

namespace Google.Ads.GoogleAds.V22.Services
{
    /// <summary>Settings for <see cref="SmartCampaignSuggestServiceClient"/> instances.</summary>
    public sealed partial class SmartCampaignSuggestServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SmartCampaignSuggestServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SmartCampaignSuggestServiceSettings"/>.</returns>
        public static SmartCampaignSuggestServiceSettings GetDefault() => new SmartCampaignSuggestServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SmartCampaignSuggestServiceSettings"/> object with default settings.
        /// </summary>
        public SmartCampaignSuggestServiceSettings()
        {
        }

        private SmartCampaignSuggestServiceSettings(SmartCampaignSuggestServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SuggestSmartCampaignBudgetOptionsSettings = existing.SuggestSmartCampaignBudgetOptionsSettings;
            SuggestSmartCampaignAdSettings = existing.SuggestSmartCampaignAdSettings;
            SuggestKeywordThemesSettings = existing.SuggestKeywordThemesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SmartCampaignSuggestServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartCampaignSuggestServiceClient.SuggestSmartCampaignBudgetOptions</c> and
        /// <c>SmartCampaignSuggestServiceClient.SuggestSmartCampaignBudgetOptionsAsync</c>.
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
        public gaxgrpc::CallSettings SuggestSmartCampaignBudgetOptionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartCampaignSuggestServiceClient.SuggestSmartCampaignAd</c> and
        /// <c>SmartCampaignSuggestServiceClient.SuggestSmartCampaignAdAsync</c>.
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
        public gaxgrpc::CallSettings SuggestSmartCampaignAdSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SmartCampaignSuggestServiceClient.SuggestKeywordThemes</c> and
        /// <c>SmartCampaignSuggestServiceClient.SuggestKeywordThemesAsync</c>.
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
        public gaxgrpc::CallSettings SuggestKeywordThemesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SmartCampaignSuggestServiceSettings"/> object.</returns>
        public SmartCampaignSuggestServiceSettings Clone() => new SmartCampaignSuggestServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SmartCampaignSuggestServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class SmartCampaignSuggestServiceClientBuilder : gaxgrpc::ClientBuilderBase<SmartCampaignSuggestServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SmartCampaignSuggestServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SmartCampaignSuggestServiceClientBuilder() : base(SmartCampaignSuggestServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref SmartCampaignSuggestServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SmartCampaignSuggestServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SmartCampaignSuggestServiceClient Build()
        {
            SmartCampaignSuggestServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SmartCampaignSuggestServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SmartCampaignSuggestServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SmartCampaignSuggestServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SmartCampaignSuggestServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<SmartCampaignSuggestServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SmartCampaignSuggestServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SmartCampaignSuggestServiceClient.ChannelPool;
    }

    /// <summary>SmartCampaignSuggestService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to get suggestions for Smart Campaigns.
    /// </remarks>
    public abstract partial class SmartCampaignSuggestServiceClient
    {
        /// <summary>
        /// The default endpoint for the SmartCampaignSuggestService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default SmartCampaignSuggestService scopes.</summary>
        /// <remarks>
        /// The default SmartCampaignSuggestService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(SmartCampaignSuggestService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="SmartCampaignSuggestServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SmartCampaignSuggestServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SmartCampaignSuggestServiceClient"/>.</returns>
        public static stt::Task<SmartCampaignSuggestServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SmartCampaignSuggestServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SmartCampaignSuggestServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="SmartCampaignSuggestServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SmartCampaignSuggestServiceClient"/>.</returns>
        public static SmartCampaignSuggestServiceClient Create() => new SmartCampaignSuggestServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SmartCampaignSuggestServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SmartCampaignSuggestServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="SmartCampaignSuggestServiceClient"/>.</returns>
        internal static SmartCampaignSuggestServiceClient Create(grpccore::CallInvoker callInvoker, SmartCampaignSuggestServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SmartCampaignSuggestService.SmartCampaignSuggestServiceClient grpcClient = new SmartCampaignSuggestService.SmartCampaignSuggestServiceClient(callInvoker);
            return new SmartCampaignSuggestServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC SmartCampaignSuggestService client</summary>
        public virtual SmartCampaignSuggestService.SmartCampaignSuggestServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns BudgetOption suggestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestSmartCampaignBudgetOptionsResponse SuggestSmartCampaignBudgetOptions(SuggestSmartCampaignBudgetOptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns BudgetOption suggestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartCampaignBudgetOptionsResponse> SuggestSmartCampaignBudgetOptionsAsync(SuggestSmartCampaignBudgetOptionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns BudgetOption suggestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartCampaignBudgetOptionsResponse> SuggestSmartCampaignBudgetOptionsAsync(SuggestSmartCampaignBudgetOptionsRequest request, st::CancellationToken cancellationToken) =>
            SuggestSmartCampaignBudgetOptionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Suggests a Smart campaign ad compatible with the Ad family of resources,
        /// based on data points such as targeting and the business to advertise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestSmartCampaignAdResponse SuggestSmartCampaignAd(SuggestSmartCampaignAdRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suggests a Smart campaign ad compatible with the Ad family of resources,
        /// based on data points such as targeting and the business to advertise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartCampaignAdResponse> SuggestSmartCampaignAdAsync(SuggestSmartCampaignAdRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suggests a Smart campaign ad compatible with the Ad family of resources,
        /// based on data points such as targeting and the business to advertise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartCampaignAdResponse> SuggestSmartCampaignAdAsync(SuggestSmartCampaignAdRequest request, st::CancellationToken cancellationToken) =>
            SuggestSmartCampaignAdAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Suggests a Smart campaign ad compatible with the Ad family of resources,
        /// based on data points such as targeting and the business to advertise.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="suggestionInfo">
        /// Required. Inputs used to suggest a Smart campaign ad.
        /// Required fields: final_url, language_code, keyword_themes.
        /// Optional but recommended fields to improve the quality of the suggestion:
        /// business_setting and geo_target.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestSmartCampaignAdResponse SuggestSmartCampaignAd(string customerId, SmartCampaignSuggestionInfo suggestionInfo, gaxgrpc::CallSettings callSettings = null) =>
            SuggestSmartCampaignAd(new SuggestSmartCampaignAdRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                SuggestionInfo = gax::GaxPreconditions.CheckNotNull(suggestionInfo, nameof(suggestionInfo)),
            }, callSettings);

        /// <summary>
        /// Suggests a Smart campaign ad compatible with the Ad family of resources,
        /// based on data points such as targeting and the business to advertise.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="suggestionInfo">
        /// Required. Inputs used to suggest a Smart campaign ad.
        /// Required fields: final_url, language_code, keyword_themes.
        /// Optional but recommended fields to improve the quality of the suggestion:
        /// business_setting and geo_target.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartCampaignAdResponse> SuggestSmartCampaignAdAsync(string customerId, SmartCampaignSuggestionInfo suggestionInfo, gaxgrpc::CallSettings callSettings = null) =>
            SuggestSmartCampaignAdAsync(new SuggestSmartCampaignAdRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                SuggestionInfo = gax::GaxPreconditions.CheckNotNull(suggestionInfo, nameof(suggestionInfo)),
            }, callSettings);

        /// <summary>
        /// Suggests a Smart campaign ad compatible with the Ad family of resources,
        /// based on data points such as targeting and the business to advertise.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="suggestionInfo">
        /// Required. Inputs used to suggest a Smart campaign ad.
        /// Required fields: final_url, language_code, keyword_themes.
        /// Optional but recommended fields to improve the quality of the suggestion:
        /// business_setting and geo_target.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestSmartCampaignAdResponse> SuggestSmartCampaignAdAsync(string customerId, SmartCampaignSuggestionInfo suggestionInfo, st::CancellationToken cancellationToken) =>
            SuggestSmartCampaignAdAsync(customerId, suggestionInfo, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Suggests keyword themes to advertise on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestKeywordThemesResponse SuggestKeywordThemes(SuggestKeywordThemesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suggests keyword themes to advertise on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestKeywordThemesResponse> SuggestKeywordThemesAsync(SuggestKeywordThemesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Suggests keyword themes to advertise on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestKeywordThemesResponse> SuggestKeywordThemesAsync(SuggestKeywordThemesRequest request, st::CancellationToken cancellationToken) =>
            SuggestKeywordThemesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Suggests keyword themes to advertise on.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="suggestionInfo">
        /// Required. Information to get keyword theme suggestions.
        /// Required fields:
        /// 
        /// * suggestion_info.final_url
        /// * suggestion_info.language_code
        /// * suggestion_info.geo_target
        /// 
        /// Recommended fields:
        /// 
        /// * suggestion_info.business_setting
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual SuggestKeywordThemesResponse SuggestKeywordThemes(string customerId, SmartCampaignSuggestionInfo suggestionInfo, gaxgrpc::CallSettings callSettings = null) =>
            SuggestKeywordThemes(new SuggestKeywordThemesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                SuggestionInfo = gax::GaxPreconditions.CheckNotNull(suggestionInfo, nameof(suggestionInfo)),
            }, callSettings);

        /// <summary>
        /// Suggests keyword themes to advertise on.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="suggestionInfo">
        /// Required. Information to get keyword theme suggestions.
        /// Required fields:
        /// 
        /// * suggestion_info.final_url
        /// * suggestion_info.language_code
        /// * suggestion_info.geo_target
        /// 
        /// Recommended fields:
        /// 
        /// * suggestion_info.business_setting
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestKeywordThemesResponse> SuggestKeywordThemesAsync(string customerId, SmartCampaignSuggestionInfo suggestionInfo, gaxgrpc::CallSettings callSettings = null) =>
            SuggestKeywordThemesAsync(new SuggestKeywordThemesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                SuggestionInfo = gax::GaxPreconditions.CheckNotNull(suggestionInfo, nameof(suggestionInfo)),
            }, callSettings);

        /// <summary>
        /// Suggests keyword themes to advertise on.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer.
        /// </param>
        /// <param name="suggestionInfo">
        /// Required. Information to get keyword theme suggestions.
        /// Required fields:
        /// 
        /// * suggestion_info.final_url
        /// * suggestion_info.language_code
        /// * suggestion_info.geo_target
        /// 
        /// Recommended fields:
        /// 
        /// * suggestion_info.business_setting
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<SuggestKeywordThemesResponse> SuggestKeywordThemesAsync(string customerId, SmartCampaignSuggestionInfo suggestionInfo, st::CancellationToken cancellationToken) =>
            SuggestKeywordThemesAsync(customerId, suggestionInfo, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SmartCampaignSuggestService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to get suggestions for Smart Campaigns.
    /// </remarks>
    public sealed partial class SmartCampaignSuggestServiceClientImpl : SmartCampaignSuggestServiceClient
    {
        private readonly gaxgrpc::ApiCall<SuggestSmartCampaignBudgetOptionsRequest, SuggestSmartCampaignBudgetOptionsResponse> _callSuggestSmartCampaignBudgetOptions;

        private readonly gaxgrpc::ApiCall<SuggestSmartCampaignAdRequest, SuggestSmartCampaignAdResponse> _callSuggestSmartCampaignAd;

        private readonly gaxgrpc::ApiCall<SuggestKeywordThemesRequest, SuggestKeywordThemesResponse> _callSuggestKeywordThemes;

        /// <summary>
        /// Constructs a client wrapper for the SmartCampaignSuggestService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SmartCampaignSuggestServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public SmartCampaignSuggestServiceClientImpl(SmartCampaignSuggestService.SmartCampaignSuggestServiceClient grpcClient, SmartCampaignSuggestServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            SmartCampaignSuggestServiceSettings effectiveSettings = settings ?? SmartCampaignSuggestServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSuggestSmartCampaignBudgetOptions = clientHelper.BuildApiCall<SuggestSmartCampaignBudgetOptionsRequest, SuggestSmartCampaignBudgetOptionsResponse>("SuggestSmartCampaignBudgetOptions", grpcClient.SuggestSmartCampaignBudgetOptionsAsync, grpcClient.SuggestSmartCampaignBudgetOptions, effectiveSettings.SuggestSmartCampaignBudgetOptionsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callSuggestSmartCampaignBudgetOptions);
            Modify_SuggestSmartCampaignBudgetOptionsApiCall(ref _callSuggestSmartCampaignBudgetOptions);
            _callSuggestSmartCampaignAd = clientHelper.BuildApiCall<SuggestSmartCampaignAdRequest, SuggestSmartCampaignAdResponse>("SuggestSmartCampaignAd", grpcClient.SuggestSmartCampaignAdAsync, grpcClient.SuggestSmartCampaignAd, effectiveSettings.SuggestSmartCampaignAdSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callSuggestSmartCampaignAd);
            Modify_SuggestSmartCampaignAdApiCall(ref _callSuggestSmartCampaignAd);
            _callSuggestKeywordThemes = clientHelper.BuildApiCall<SuggestKeywordThemesRequest, SuggestKeywordThemesResponse>("SuggestKeywordThemes", grpcClient.SuggestKeywordThemesAsync, grpcClient.SuggestKeywordThemes, effectiveSettings.SuggestKeywordThemesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callSuggestKeywordThemes);
            Modify_SuggestKeywordThemesApiCall(ref _callSuggestKeywordThemes);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SuggestSmartCampaignBudgetOptionsApiCall(ref gaxgrpc::ApiCall<SuggestSmartCampaignBudgetOptionsRequest, SuggestSmartCampaignBudgetOptionsResponse> call);

        partial void Modify_SuggestSmartCampaignAdApiCall(ref gaxgrpc::ApiCall<SuggestSmartCampaignAdRequest, SuggestSmartCampaignAdResponse> call);

        partial void Modify_SuggestKeywordThemesApiCall(ref gaxgrpc::ApiCall<SuggestKeywordThemesRequest, SuggestKeywordThemesResponse> call);

        partial void OnConstruction(SmartCampaignSuggestService.SmartCampaignSuggestServiceClient grpcClient, SmartCampaignSuggestServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SmartCampaignSuggestService client</summary>
        public override SmartCampaignSuggestService.SmartCampaignSuggestServiceClient GrpcClient { get; }

        partial void Modify_SuggestSmartCampaignBudgetOptionsRequest(ref SuggestSmartCampaignBudgetOptionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuggestSmartCampaignAdRequest(ref SuggestSmartCampaignAdRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SuggestKeywordThemesRequest(ref SuggestKeywordThemesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns BudgetOption suggestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestSmartCampaignBudgetOptionsResponse SuggestSmartCampaignBudgetOptions(SuggestSmartCampaignBudgetOptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestSmartCampaignBudgetOptionsRequest(ref request, ref callSettings);
            return _callSuggestSmartCampaignBudgetOptions.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns BudgetOption suggestions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestSmartCampaignBudgetOptionsResponse> SuggestSmartCampaignBudgetOptionsAsync(SuggestSmartCampaignBudgetOptionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestSmartCampaignBudgetOptionsRequest(ref request, ref callSettings);
            return _callSuggestSmartCampaignBudgetOptions.Async(request, callSettings);
        }

        /// <summary>
        /// Suggests a Smart campaign ad compatible with the Ad family of resources,
        /// based on data points such as targeting and the business to advertise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestSmartCampaignAdResponse SuggestSmartCampaignAd(SuggestSmartCampaignAdRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestSmartCampaignAdRequest(ref request, ref callSettings);
            return _callSuggestSmartCampaignAd.Sync(request, callSettings);
        }

        /// <summary>
        /// Suggests a Smart campaign ad compatible with the Ad family of resources,
        /// based on data points such as targeting and the business to advertise.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestSmartCampaignAdResponse> SuggestSmartCampaignAdAsync(SuggestSmartCampaignAdRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestSmartCampaignAdRequest(ref request, ref callSettings);
            return _callSuggestSmartCampaignAd.Async(request, callSettings);
        }

        /// <summary>
        /// Suggests keyword themes to advertise on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override SuggestKeywordThemesResponse SuggestKeywordThemes(SuggestKeywordThemesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestKeywordThemesRequest(ref request, ref callSettings);
            return _callSuggestKeywordThemes.Sync(request, callSettings);
        }

        /// <summary>
        /// Suggests keyword themes to advertise on.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<SuggestKeywordThemesResponse> SuggestKeywordThemesAsync(SuggestKeywordThemesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SuggestKeywordThemesRequest(ref request, ref callSettings);
            return _callSuggestKeywordThemes.Async(request, callSettings);
        }
    }
}

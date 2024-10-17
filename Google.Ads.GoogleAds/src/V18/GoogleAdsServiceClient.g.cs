// Copyright 2024 Google LLC
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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V18.Services
{
    /// <summary>Settings for <see cref="GoogleAdsServiceClient"/> instances.</summary>
    public sealed partial class GoogleAdsServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="GoogleAdsServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="GoogleAdsServiceSettings"/>.</returns>
        public static GoogleAdsServiceSettings GetDefault() => new GoogleAdsServiceSettings();

        /// <summary>Constructs a new <see cref="GoogleAdsServiceSettings"/> object with default settings.</summary>
        public GoogleAdsServiceSettings()
        {
        }

        private GoogleAdsServiceSettings(GoogleAdsServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            SearchSettings = existing.SearchSettings;
            SearchStreamSettings = existing.SearchStreamSettings;
            MutateSettings = existing.MutateSettings;
            OnCopy(existing);
        }

        partial void OnCopy(GoogleAdsServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GoogleAdsServiceClient.Search</c> and <c>GoogleAdsServiceClient.SearchAsync</c>.
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
        public gaxgrpc::CallSettings SearchSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GoogleAdsServiceClient.SearchStream</c> and <c>GoogleAdsServiceClient.SearchStreamAsync</c>.
        /// </summary>
        /// <remarks>Timeout: 14400 seconds.</remarks>
        public gaxgrpc::CallSettings SearchStreamSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>GoogleAdsServiceClient.Mutate</c> and <c>GoogleAdsServiceClient.MutateAsync</c>.
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
        public gaxgrpc::CallSettings MutateSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="GoogleAdsServiceSettings"/> object.</returns>
        public GoogleAdsServiceSettings Clone() => new GoogleAdsServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="GoogleAdsServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class GoogleAdsServiceClientBuilder : gaxgrpc::ClientBuilderBase<GoogleAdsServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public GoogleAdsServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public GoogleAdsServiceClientBuilder() : base(GoogleAdsServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref GoogleAdsServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<GoogleAdsServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override GoogleAdsServiceClient Build()
        {
            GoogleAdsServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<GoogleAdsServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<GoogleAdsServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private GoogleAdsServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return GoogleAdsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<GoogleAdsServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return GoogleAdsServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => GoogleAdsServiceClient.ChannelPool;
    }

    /// <summary>GoogleAdsService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch data and metrics across resources.
    /// </remarks>
    public abstract partial class GoogleAdsServiceClient
    {
        /// <summary>
        /// The default endpoint for the GoogleAdsService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default GoogleAdsService scopes.</summary>
        /// <remarks>
        /// The default GoogleAdsService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(GoogleAdsService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="GoogleAdsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GoogleAdsServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="GoogleAdsServiceClient"/>.</returns>
        public static stt::Task<GoogleAdsServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new GoogleAdsServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="GoogleAdsServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="GoogleAdsServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="GoogleAdsServiceClient"/>.</returns>
        public static GoogleAdsServiceClient Create() => new GoogleAdsServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="GoogleAdsServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="GoogleAdsServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="GoogleAdsServiceClient"/>.</returns>
        internal static GoogleAdsServiceClient Create(grpccore::CallInvoker callInvoker, GoogleAdsServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            GoogleAdsService.GoogleAdsServiceClient grpcClient = new GoogleAdsService.GoogleAdsServiceClient(callInvoker);
            return new GoogleAdsServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC GoogleAdsService client</summary>
        public virtual GoogleAdsService.GoogleAdsServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all rows that match the search query.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ChangeEventError]()
        /// [ChangeStatusError]()
        /// [ClickViewError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QueryError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GoogleAdsRow"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> Search(SearchGoogleAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all rows that match the search query.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ChangeEventError]()
        /// [ChangeStatusError]()
        /// [ClickViewError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QueryError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleAdsRow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> SearchAsync(SearchGoogleAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all rows that match the search query.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ChangeEventError]()
        /// [ChangeStatusError]()
        /// [ClickViewError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QueryError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being queried.
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GoogleAdsRow"/> resources.</returns>
        public virtual gax::PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> Search(string customerId, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return Search(request, callSettings);
        }

        /// <summary>
        /// Returns all rows that match the search query.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ChangeEventError]()
        /// [ChangeStatusError]()
        /// [ClickViewError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QueryError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being queried.
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleAdsRow"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> SearchAsync(string customerId, string query, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            SearchGoogleAdsRequest request = new SearchGoogleAdsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return SearchAsync(request, callSettings);
        }

        /// <summary>
        /// Server streaming methods for <see cref="SearchStream(SearchGoogleAdsStreamRequest,gaxgrpc::CallSettings)"/>.
        /// </summary>
        public abstract partial class SearchStreamStream : gaxgrpc::ServerStreamingBase<SearchGoogleAdsStreamResponse>
        {
        }

        /// <summary>
        /// Returns all rows that match the search stream query.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ChangeEventError]()
        /// [ChangeStatusError]()
        /// [ClickViewError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QueryError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SearchStreamStream SearchStream(SearchGoogleAdsStreamRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all rows that match the search stream query.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ChangeEventError]()
        /// [ChangeStatusError]()
        /// [ClickViewError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QueryError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being queried.
        /// </param>
        /// <param name="query">
        /// Required. The query string.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public virtual SearchStreamStream SearchStream(string customerId, string query, gaxgrpc::CallSettings callSettings = null) =>
            SearchStream(new SearchGoogleAdsStreamRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Query = gax::GaxPreconditions.CheckNotNullOrEmpty(query, nameof(query)),
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        /// 
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        /// 
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        /// 
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        /// 
        /// ## Atomic Transaction Benefits
        /// 
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the chosen state directly, or the request
        /// fails and you can retry.
        /// 
        /// ## Temp Resource Names
        /// 
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        /// 
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        /// 
        /// Note:
        /// 
        /// - Resources must be created with a temp name before the name can be reused.
        /// For example, the previous CampaignBudget+Campaign example would fail if
        /// the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        /// types differ.
        /// 
        /// ## Latency
        /// 
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdGroupCriterionError]()
        /// [AdGroupError]()
        /// [AssetError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [CampaignBudgetError]()
        /// [CampaignCriterionError]()
        /// [CampaignError]()
        /// [CampaignExperimentError]()
        /// [CampaignSharedSetError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [ConversionActionError]()
        /// [CriterionError]()
        /// [CustomerFeedError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [ExtensionFeedItemError]()
        /// [ExtensionSettingError]()
        /// [FeedAttributeReferenceError]()
        /// [FeedError]()
        /// [FeedItemError]()
        /// [FeedItemSetError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupKeywordError]()
        /// [KeywordPlanCampaignError]()
        /// [KeywordPlanError]()
        /// [LabelError]()
        /// [ListOperationError]()
        /// [MediaUploadError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// [UserListError]()
        /// [YoutubeVideoRegistrationError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateGoogleAdsResponse Mutate(MutateGoogleAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        /// 
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        /// 
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        /// 
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        /// 
        /// ## Atomic Transaction Benefits
        /// 
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the chosen state directly, or the request
        /// fails and you can retry.
        /// 
        /// ## Temp Resource Names
        /// 
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        /// 
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        /// 
        /// Note:
        /// 
        /// - Resources must be created with a temp name before the name can be reused.
        /// For example, the previous CampaignBudget+Campaign example would fail if
        /// the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        /// types differ.
        /// 
        /// ## Latency
        /// 
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdGroupCriterionError]()
        /// [AdGroupError]()
        /// [AssetError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [CampaignBudgetError]()
        /// [CampaignCriterionError]()
        /// [CampaignError]()
        /// [CampaignExperimentError]()
        /// [CampaignSharedSetError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [ConversionActionError]()
        /// [CriterionError]()
        /// [CustomerFeedError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [ExtensionFeedItemError]()
        /// [ExtensionSettingError]()
        /// [FeedAttributeReferenceError]()
        /// [FeedError]()
        /// [FeedItemError]()
        /// [FeedItemSetError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupKeywordError]()
        /// [KeywordPlanCampaignError]()
        /// [KeywordPlanError]()
        /// [LabelError]()
        /// [ListOperationError]()
        /// [MediaUploadError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// [UserListError]()
        /// [YoutubeVideoRegistrationError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(MutateGoogleAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        /// 
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        /// 
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        /// 
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        /// 
        /// ## Atomic Transaction Benefits
        /// 
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the chosen state directly, or the request
        /// fails and you can retry.
        /// 
        /// ## Temp Resource Names
        /// 
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        /// 
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        /// 
        /// Note:
        /// 
        /// - Resources must be created with a temp name before the name can be reused.
        /// For example, the previous CampaignBudget+Campaign example would fail if
        /// the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        /// types differ.
        /// 
        /// ## Latency
        /// 
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdGroupCriterionError]()
        /// [AdGroupError]()
        /// [AssetError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [CampaignBudgetError]()
        /// [CampaignCriterionError]()
        /// [CampaignError]()
        /// [CampaignExperimentError]()
        /// [CampaignSharedSetError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [ConversionActionError]()
        /// [CriterionError]()
        /// [CustomerFeedError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [ExtensionFeedItemError]()
        /// [ExtensionSettingError]()
        /// [FeedAttributeReferenceError]()
        /// [FeedError]()
        /// [FeedItemError]()
        /// [FeedItemSetError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupKeywordError]()
        /// [KeywordPlanCampaignError]()
        /// [KeywordPlanError]()
        /// [LabelError]()
        /// [ListOperationError]()
        /// [MediaUploadError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// [UserListError]()
        /// [YoutubeVideoRegistrationError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(MutateGoogleAdsRequest request, st::CancellationToken cancellationToken) =>
            MutateAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        /// 
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        /// 
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        /// 
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        /// 
        /// ## Atomic Transaction Benefits
        /// 
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the chosen state directly, or the request
        /// fails and you can retry.
        /// 
        /// ## Temp Resource Names
        /// 
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        /// 
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        /// 
        /// Note:
        /// 
        /// - Resources must be created with a temp name before the name can be reused.
        /// For example, the previous CampaignBudget+Campaign example would fail if
        /// the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        /// types differ.
        /// 
        /// ## Latency
        /// 
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdGroupCriterionError]()
        /// [AdGroupError]()
        /// [AssetError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [CampaignBudgetError]()
        /// [CampaignCriterionError]()
        /// [CampaignError]()
        /// [CampaignExperimentError]()
        /// [CampaignSharedSetError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [ConversionActionError]()
        /// [CriterionError]()
        /// [CustomerFeedError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [ExtensionFeedItemError]()
        /// [ExtensionSettingError]()
        /// [FeedAttributeReferenceError]()
        /// [FeedError]()
        /// [FeedItemError]()
        /// [FeedItemSetError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupKeywordError]()
        /// [KeywordPlanCampaignError]()
        /// [KeywordPlanError]()
        /// [LabelError]()
        /// [ListOperationError]()
        /// [MediaUploadError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// [UserListError]()
        /// [YoutubeVideoRegistrationError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose resources are being modified.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of operations to perform on individual resources.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateGoogleAdsResponse Mutate(string customerId, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            Mutate(new MutateGoogleAdsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        /// 
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        /// 
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        /// 
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        /// 
        /// ## Atomic Transaction Benefits
        /// 
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the chosen state directly, or the request
        /// fails and you can retry.
        /// 
        /// ## Temp Resource Names
        /// 
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        /// 
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        /// 
        /// Note:
        /// 
        /// - Resources must be created with a temp name before the name can be reused.
        /// For example, the previous CampaignBudget+Campaign example would fail if
        /// the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        /// types differ.
        /// 
        /// ## Latency
        /// 
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdGroupCriterionError]()
        /// [AdGroupError]()
        /// [AssetError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [CampaignBudgetError]()
        /// [CampaignCriterionError]()
        /// [CampaignError]()
        /// [CampaignExperimentError]()
        /// [CampaignSharedSetError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [ConversionActionError]()
        /// [CriterionError]()
        /// [CustomerFeedError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [ExtensionFeedItemError]()
        /// [ExtensionSettingError]()
        /// [FeedAttributeReferenceError]()
        /// [FeedError]()
        /// [FeedItemError]()
        /// [FeedItemSetError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupKeywordError]()
        /// [KeywordPlanCampaignError]()
        /// [KeywordPlanError]()
        /// [LabelError]()
        /// [ListOperationError]()
        /// [MediaUploadError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// [UserListError]()
        /// [YoutubeVideoRegistrationError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose resources are being modified.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of operations to perform on individual resources.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(string customerId, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAsync(new MutateGoogleAdsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        /// 
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        /// 
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        /// 
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        /// 
        /// ## Atomic Transaction Benefits
        /// 
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the chosen state directly, or the request
        /// fails and you can retry.
        /// 
        /// ## Temp Resource Names
        /// 
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        /// 
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        /// 
        /// Note:
        /// 
        /// - Resources must be created with a temp name before the name can be reused.
        /// For example, the previous CampaignBudget+Campaign example would fail if
        /// the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        /// types differ.
        /// 
        /// ## Latency
        /// 
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdGroupCriterionError]()
        /// [AdGroupError]()
        /// [AssetError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [CampaignBudgetError]()
        /// [CampaignCriterionError]()
        /// [CampaignError]()
        /// [CampaignExperimentError]()
        /// [CampaignSharedSetError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [ConversionActionError]()
        /// [CriterionError]()
        /// [CustomerFeedError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [ExtensionFeedItemError]()
        /// [ExtensionSettingError]()
        /// [FeedAttributeReferenceError]()
        /// [FeedError]()
        /// [FeedItemError]()
        /// [FeedItemSetError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupKeywordError]()
        /// [KeywordPlanCampaignError]()
        /// [KeywordPlanError]()
        /// [LabelError]()
        /// [ListOperationError]()
        /// [MediaUploadError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// [UserListError]()
        /// [YoutubeVideoRegistrationError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose resources are being modified.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of operations to perform on individual resources.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateGoogleAdsResponse> MutateAsync(string customerId, scg::IEnumerable<MutateOperation> mutateOperations, st::CancellationToken cancellationToken) =>
            MutateAsync(customerId, mutateOperations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>GoogleAdsService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch data and metrics across resources.
    /// </remarks>
    public sealed partial class GoogleAdsServiceClientImpl : GoogleAdsServiceClient
    {
        private readonly gaxgrpc::ApiCall<SearchGoogleAdsRequest, SearchGoogleAdsResponse> _callSearch;

        private readonly gaxgrpc::ApiServerStreamingCall<SearchGoogleAdsStreamRequest, SearchGoogleAdsStreamResponse> _callSearchStream;

        private readonly gaxgrpc::ApiCall<MutateGoogleAdsRequest, MutateGoogleAdsResponse> _callMutate;

        /// <summary>
        /// Constructs a client wrapper for the GoogleAdsService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="GoogleAdsServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public GoogleAdsServiceClientImpl(GoogleAdsService.GoogleAdsServiceClient grpcClient, GoogleAdsServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            GoogleAdsServiceSettings effectiveSettings = settings ?? GoogleAdsServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callSearch = clientHelper.BuildApiCall<SearchGoogleAdsRequest, SearchGoogleAdsResponse>("Search", grpcClient.SearchAsync, grpcClient.Search, effectiveSettings.SearchSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callSearch);
            Modify_SearchApiCall(ref _callSearch);
            _callSearchStream = clientHelper.BuildApiCall<SearchGoogleAdsStreamRequest, SearchGoogleAdsStreamResponse>("SearchStream", grpcClient.SearchStream, effectiveSettings.SearchStreamSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callSearchStream);
            Modify_SearchStreamApiCall(ref _callSearchStream);
            _callMutate = clientHelper.BuildApiCall<MutateGoogleAdsRequest, MutateGoogleAdsResponse>("Mutate", grpcClient.MutateAsync, grpcClient.Mutate, effectiveSettings.MutateSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutate);
            Modify_MutateApiCall(ref _callMutate);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiServerStreamingCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_SearchApiCall(ref gaxgrpc::ApiCall<SearchGoogleAdsRequest, SearchGoogleAdsResponse> call);

        partial void Modify_SearchStreamApiCall(ref gaxgrpc::ApiServerStreamingCall<SearchGoogleAdsStreamRequest, SearchGoogleAdsStreamResponse> call);

        partial void Modify_MutateApiCall(ref gaxgrpc::ApiCall<MutateGoogleAdsRequest, MutateGoogleAdsResponse> call);

        partial void OnConstruction(GoogleAdsService.GoogleAdsServiceClient grpcClient, GoogleAdsServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC GoogleAdsService client</summary>
        public override GoogleAdsService.GoogleAdsServiceClient GrpcClient { get; }

        partial void Modify_SearchGoogleAdsRequest(ref SearchGoogleAdsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_SearchGoogleAdsStreamRequest(ref SearchGoogleAdsStreamRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateGoogleAdsRequest(ref MutateGoogleAdsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns all rows that match the search query.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ChangeEventError]()
        /// [ChangeStatusError]()
        /// [ClickViewError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QueryError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="GoogleAdsRow"/> resources.</returns>
        public override gax::PagedEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> Search(SearchGoogleAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGoogleAdsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<SearchGoogleAdsRequest, SearchGoogleAdsResponse, GoogleAdsRow>(_callSearch, request, callSettings);
        }

        /// <summary>
        /// Returns all rows that match the search query.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ChangeEventError]()
        /// [ChangeStatusError]()
        /// [ClickViewError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QueryError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="GoogleAdsRow"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<SearchGoogleAdsResponse, GoogleAdsRow> SearchAsync(SearchGoogleAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGoogleAdsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<SearchGoogleAdsRequest, SearchGoogleAdsResponse, GoogleAdsRow>(_callSearch, request, callSettings);
        }

        internal sealed partial class SearchStreamStreamImpl : SearchStreamStream
        {
            /// <summary>Construct the server streaming method for <c>SearchStream</c>.</summary>
            /// <param name="call">The underlying gRPC server streaming call.</param>
            public SearchStreamStreamImpl(grpccore::AsyncServerStreamingCall<SearchGoogleAdsStreamResponse> call) => GrpcCall = call;

            public override grpccore::AsyncServerStreamingCall<SearchGoogleAdsStreamResponse> GrpcCall { get; }
        }

        /// <summary>
        /// Returns all rows that match the search stream query.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ChangeEventError]()
        /// [ChangeStatusError]()
        /// [ClickViewError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QueryError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The server stream.</returns>
        public override GoogleAdsServiceClient.SearchStreamStream SearchStream(SearchGoogleAdsStreamRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_SearchGoogleAdsStreamRequest(ref request, ref callSettings);
            return new SearchStreamStreamImpl(_callSearchStream.Call(request, callSettings));
        }

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        /// 
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        /// 
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        /// 
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        /// 
        /// ## Atomic Transaction Benefits
        /// 
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the chosen state directly, or the request
        /// fails and you can retry.
        /// 
        /// ## Temp Resource Names
        /// 
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        /// 
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        /// 
        /// Note:
        /// 
        /// - Resources must be created with a temp name before the name can be reused.
        /// For example, the previous CampaignBudget+Campaign example would fail if
        /// the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        /// types differ.
        /// 
        /// ## Latency
        /// 
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdGroupCriterionError]()
        /// [AdGroupError]()
        /// [AssetError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [CampaignBudgetError]()
        /// [CampaignCriterionError]()
        /// [CampaignError]()
        /// [CampaignExperimentError]()
        /// [CampaignSharedSetError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [ConversionActionError]()
        /// [CriterionError]()
        /// [CustomerFeedError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [ExtensionFeedItemError]()
        /// [ExtensionSettingError]()
        /// [FeedAttributeReferenceError]()
        /// [FeedError]()
        /// [FeedItemError]()
        /// [FeedItemSetError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupKeywordError]()
        /// [KeywordPlanCampaignError]()
        /// [KeywordPlanError]()
        /// [LabelError]()
        /// [ListOperationError]()
        /// [MediaUploadError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// [UserListError]()
        /// [YoutubeVideoRegistrationError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateGoogleAdsResponse Mutate(MutateGoogleAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateGoogleAdsRequest(ref request, ref callSettings);
            return _callMutate.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes resources. This method supports atomic
        /// transactions with multiple types of resources. For example, you can
        /// atomically create a campaign and a campaign budget, or perform up to
        /// thousands of mutates atomically.
        /// 
        /// This method is essentially a wrapper around a series of mutate methods. The
        /// only features it offers over calling those methods directly are:
        /// 
        /// - Atomic transactions
        /// - Temp resource names (described below)
        /// - Somewhat reduced latency over making a series of mutate calls
        /// 
        /// Note: Only resources that support atomic transactions are included, so this
        /// method can't replace all calls to individual services.
        /// 
        /// ## Atomic Transaction Benefits
        /// 
        /// Atomicity makes error handling much easier. If you're making a series of
        /// changes and one fails, it can leave your account in an inconsistent state.
        /// With atomicity, you either reach the chosen state directly, or the request
        /// fails and you can retry.
        /// 
        /// ## Temp Resource Names
        /// 
        /// Temp resource names are a special type of resource name used to create a
        /// resource and reference that resource in the same request. For example, if a
        /// campaign budget is created with `resource_name` equal to
        /// `customers/123/campaignBudgets/-1`, that resource name can be reused in
        /// the `Campaign.budget` field in the same request. That way, the two
        /// resources are created and linked atomically.
        /// 
        /// To create a temp resource name, put a negative number in the part of the
        /// name that the server would normally allocate.
        /// 
        /// Note:
        /// 
        /// - Resources must be created with a temp name before the name can be reused.
        /// For example, the previous CampaignBudget+Campaign example would fail if
        /// the mutate order was reversed.
        /// - Temp names are not remembered across requests.
        /// - There's no limit to the number of temp names in a request.
        /// - Each temp name must use a unique negative number, even if the resource
        /// types differ.
        /// 
        /// ## Latency
        /// 
        /// It's important to group mutates by resource type or the request may time
        /// out and fail. Latency is roughly equal to a series of calls to individual
        /// mutate methods, where each change in resource type is a new call. For
        /// example, mutating 10 campaigns then 10 ad groups is like 2 calls, while
        /// mutating 1 campaign, 1 ad group, 1 campaign, 1 ad group is like 4 calls.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdGroupCriterionError]()
        /// [AdGroupError]()
        /// [AssetError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [CampaignBudgetError]()
        /// [CampaignCriterionError]()
        /// [CampaignError]()
        /// [CampaignExperimentError]()
        /// [CampaignSharedSetError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
        /// [ConversionActionError]()
        /// [CriterionError]()
        /// [CustomerFeedError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [ExtensionFeedItemError]()
        /// [ExtensionSettingError]()
        /// [FeedAttributeReferenceError]()
        /// [FeedError]()
        /// [FeedItemError]()
        /// [FeedItemSetError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupKeywordError]()
        /// [KeywordPlanCampaignError]()
        /// [KeywordPlanError]()
        /// [LabelError]()
        /// [ListOperationError]()
        /// [MediaUploadError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// [UserListError]()
        /// [YoutubeVideoRegistrationError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateGoogleAdsResponse> MutateAsync(MutateGoogleAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateGoogleAdsRequest(ref request, ref callSettings);
            return _callMutate.Async(request, callSettings);
        }
    }

    public partial class SearchGoogleAdsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class SearchGoogleAdsResponse : gaxgrpc::IPageResponse<GoogleAdsRow>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<GoogleAdsRow> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }
}

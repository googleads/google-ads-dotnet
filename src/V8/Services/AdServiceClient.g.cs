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

using gagvr = Google.Ads.GoogleAds.V8.Resources;
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

namespace Google.Ads.GoogleAds.V8.Services
{
    /// <summary>Settings for <see cref="AdServiceClient"/> instances.</summary>
    public sealed partial class AdServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdServiceSettings"/>.</returns>
        public static AdServiceSettings GetDefault() => new AdServiceSettings();

        /// <summary>Constructs a new <see cref="AdServiceSettings"/> object with default settings.</summary>
        public AdServiceSettings()
        {
        }

        private AdServiceSettings(AdServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdSettings = existing.GetAdSettings;
            MutateAdsSettings = existing.MutateAdsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AdServiceClient.GetAd</c>
        /// and <c>AdServiceClient.GetAdAsync</c>.
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
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>AdServiceClient.MutateAds</c>
        ///  and <c>AdServiceClient.MutateAdsAsync</c>.
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
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAdsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdServiceSettings"/> object.</returns>
        public AdServiceSettings Clone() => new AdServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    internal sealed partial class AdServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdServiceClientBuilder()
        {
            UseJwtAccessWithScopes = AdServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref AdServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdServiceClient Build()
        {
            AdServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ads.
    /// </remarks>
    public abstract partial class AdServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdService service, which is a host of "googleads.googleapis.com" and a port of
        /// 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdService scopes.</summary>
        /// <remarks>
        /// The default AdService scopes are:
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
        /// Asynchronously creates a <see cref="AdServiceClient"/> using the default credentials, endpoint and settings.
        /// To specify custom credentials or other settings, use <see cref="AdServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdServiceClient"/>.</returns>
        public static stt::Task<AdServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdServiceClient"/> using the default credentials, endpoint and settings. 
        /// To specify custom credentials or other settings, use <see cref="AdServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdServiceClient"/>.</returns>
        public static AdServiceClient Create() => new AdServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdServiceClient"/>.</returns>
        internal static AdServiceClient Create(grpccore::CallInvoker callInvoker, AdServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdService.AdServiceClient grpcClient = new AdService.AdServiceClient(callInvoker);
            return new AdServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdService client</summary>
        public virtual AdService.AdServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad in full detail.
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
        public virtual gagvr::Ad GetAd(GetAdRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad in full detail.
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
        public virtual stt::Task<gagvr::Ad> GetAdAsync(GetAdRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad in full detail.
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
        public virtual stt::Task<gagvr::Ad> GetAdAsync(GetAdRequest request, st::CancellationToken cancellationToken) =>
            GetAdAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad in full detail.
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
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Ad GetAd(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAd(new GetAdRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad in full detail.
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
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Ad> GetAdAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdAsync(new GetAdRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad in full detail.
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
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Ad> GetAdAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad in full detail.
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
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Ad GetAd(gagvr::AdName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAd(new GetAdRequest
            {
                ResourceNameAsAdName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad in full detail.
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
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Ad> GetAdAsync(gagvr::AdName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdAsync(new GetAdRequest
            {
                ResourceNameAsAdName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad in full detail.
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
        /// Required. The resource name of the ad to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Ad> GetAdAsync(gagvr::AdName resourceName, st::CancellationToken cancellationToken) =>
            GetAdAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates ads. Operation statuses are returned. Updating ads is not supported
        /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FeedAttributeReferenceError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MediaBundleError]()
        /// [MediaFileError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdsResponse MutateAds(MutateAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates ads. Operation statuses are returned. Updating ads is not supported
        /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FeedAttributeReferenceError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MediaBundleError]()
        /// [MediaFileError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdsResponse> MutateAdsAsync(MutateAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates ads. Operation statuses are returned. Updating ads is not supported
        /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FeedAttributeReferenceError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MediaBundleError]()
        /// [MediaFileError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdsResponse> MutateAdsAsync(MutateAdsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates ads. Operation statuses are returned. Updating ads is not supported
        /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FeedAttributeReferenceError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MediaBundleError]()
        /// [MediaFileError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ads are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ads.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdsResponse MutateAds(string customerId, scg::IEnumerable<AdOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAds(new MutateAdsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Updates ads. Operation statuses are returned. Updating ads is not supported
        /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FeedAttributeReferenceError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MediaBundleError]()
        /// [MediaFileError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ads are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ads.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdsResponse> MutateAdsAsync(string customerId, scg::IEnumerable<AdOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdsAsync(new MutateAdsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Updates ads. Operation statuses are returned. Updating ads is not supported
        /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FeedAttributeReferenceError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MediaBundleError]()
        /// [MediaFileError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ads are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ads.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdsResponse> MutateAdsAsync(string customerId, scg::IEnumerable<AdOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ads.
    /// </remarks>
    public sealed partial class AdServiceClientImpl : AdServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdRequest, gagvr::Ad> _callGetAd;

        private readonly gaxgrpc::ApiCall<MutateAdsRequest, MutateAdsResponse> _callMutateAds;

        /// <summary>
        /// Constructs a client wrapper for the AdService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdServiceSettings"/> used within this client.</param>
        public AdServiceClientImpl(AdService.AdServiceClient grpcClient, AdServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdServiceSettings effectiveSettings = settings ?? AdServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAd = clientHelper.BuildApiCall<GetAdRequest, gagvr::Ad>(grpcClient.GetAdAsync, grpcClient.GetAd, effectiveSettings.GetAdSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAd);
            Modify_GetAdApiCall(ref _callGetAd);
            _callMutateAds = clientHelper.BuildApiCall<MutateAdsRequest, MutateAdsResponse>(grpcClient.MutateAdsAsync, grpcClient.MutateAds, effectiveSettings.MutateAdsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAds);
            Modify_MutateAdsApiCall(ref _callMutateAds);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdApiCall(ref gaxgrpc::ApiCall<GetAdRequest, gagvr::Ad> call);

        partial void Modify_MutateAdsApiCall(ref gaxgrpc::ApiCall<MutateAdsRequest, MutateAdsResponse> call);

        partial void OnConstruction(AdService.AdServiceClient grpcClient, AdServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdService client</summary>
        public override AdService.AdServiceClient GrpcClient { get; }

        partial void Modify_GetAdRequest(ref GetAdRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateAdsRequest(ref MutateAdsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad in full detail.
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
        public override gagvr::Ad GetAd(GetAdRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdRequest(ref request, ref callSettings);
            return _callGetAd.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad in full detail.
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
        public override stt::Task<gagvr::Ad> GetAdAsync(GetAdRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdRequest(ref request, ref callSettings);
            return _callGetAd.Async(request, callSettings);
        }

        /// <summary>
        /// Updates ads. Operation statuses are returned. Updating ads is not supported
        /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FeedAttributeReferenceError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MediaBundleError]()
        /// [MediaFileError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdsResponse MutateAds(MutateAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdsRequest(ref request, ref callSettings);
            return _callMutateAds.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates ads. Operation statuses are returned. Updating ads is not supported
        /// for TextAd, ExpandedDynamicSearchAd, GmailAd and ImageAd.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FeedAttributeReferenceError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [FunctionError]()
        /// [FunctionParsingError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [ImageError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MediaBundleError]()
        /// [MediaFileError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdsResponse> MutateAdsAsync(MutateAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdsRequest(ref request, ref callSettings);
            return _callMutateAds.Async(request, callSettings);
        }
    }
}

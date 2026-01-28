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
using gagvr = Google.Ads.GoogleAds.V23.Resources;
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
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.GoogleAds.V23.Services
{
    /// <summary>Settings for <see cref="AdGroupAdServiceClient"/> instances.</summary>
    public sealed partial class AdGroupAdServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupAdServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupAdServiceSettings"/>.</returns>
        public static AdGroupAdServiceSettings GetDefault() => new AdGroupAdServiceSettings();

        /// <summary>Constructs a new <see cref="AdGroupAdServiceSettings"/> object with default settings.</summary>
        public AdGroupAdServiceSettings()
        {
        }

        private AdGroupAdServiceSettings(AdGroupAdServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAdGroupAdsSettings = existing.MutateAdGroupAdsSettings;
            RemoveAutomaticallyCreatedAssetsSettings = existing.RemoveAutomaticallyCreatedAssetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupAdServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAdServiceClient.MutateAdGroupAds</c> and <c>AdGroupAdServiceClient.MutateAdGroupAdsAsync</c>.
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
        public gaxgrpc::CallSettings MutateAdGroupAdsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAdServiceClient.RemoveAutomaticallyCreatedAssets</c> and
        /// <c>AdGroupAdServiceClient.RemoveAutomaticallyCreatedAssetsAsync</c>.
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
        public gaxgrpc::CallSettings RemoveAutomaticallyCreatedAssetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupAdServiceSettings"/> object.</returns>
        public AdGroupAdServiceSettings Clone() => new AdGroupAdServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupAdServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class AdGroupAdServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupAdServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupAdServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdGroupAdServiceClientBuilder() : base(AdGroupAdServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdGroupAdServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupAdServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupAdServiceClient Build()
        {
            AdGroupAdServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupAdServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupAdServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupAdServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupAdServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdGroupAdServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupAdServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupAdServiceClient.ChannelPool;
    }

    /// <summary>AdGroupAdService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ads in an ad group.
    /// </remarks>
    public abstract partial class AdGroupAdServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupAdService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupAdService scopes.</summary>
        /// <remarks>
        /// The default AdGroupAdService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdGroupAdService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupAdServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdGroupAdServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupAdServiceClient"/>.</returns>
        public static stt::Task<AdGroupAdServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupAdServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupAdServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdGroupAdServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupAdServiceClient"/>.</returns>
        public static AdGroupAdServiceClient Create() => new AdGroupAdServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupAdServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupAdServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdGroupAdServiceClient"/>.</returns>
        internal static AdGroupAdServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupAdServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupAdService.AdGroupAdServiceClient grpcClient = new AdGroupAdService.AdGroupAdServiceClient(callInvoker);
            return new AdGroupAdServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdGroupAdService client</summary>
        public virtual AdGroupAdService.AdGroupAdServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
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
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyValidationParameterError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupAdsResponse MutateAdGroupAds(MutateAdGroupAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
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
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyValidationParameterError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(MutateAdGroupAdsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
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
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyValidationParameterError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(MutateAdGroupAdsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupAdsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
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
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyValidationParameterError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
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
        public virtual MutateAdGroupAdsResponse MutateAdGroupAds(string customerId, scg::IEnumerable<AdGroupAdOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupAds(new MutateAdGroupAdsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
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
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyValidationParameterError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
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
        public virtual stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(string customerId, scg::IEnumerable<AdGroupAdOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupAdsAsync(new MutateAdGroupAdsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
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
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyValidationParameterError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
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
        public virtual stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(string customerId, scg::IEnumerable<AdGroupAdOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupAdsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RemoveAutomaticallyCreatedAssets(RemoveAutomaticallyCreatedAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveAutomaticallyCreatedAssetsAsync(RemoveAutomaticallyCreatedAssetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveAutomaticallyCreatedAssetsAsync(RemoveAutomaticallyCreatedAssetsRequest request, st::CancellationToken cancellationToken) =>
            RemoveAutomaticallyCreatedAssetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="adGroupAd">
        /// Required. The resource name of the AdGroupAd from which to remove
        /// automatically created assets.
        /// </param>
        /// <param name="assetsWithFieldType">
        /// Required. List of assets with field type to be removed from the AdGroupAd.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RemoveAutomaticallyCreatedAssets(string adGroupAd, scg::IEnumerable<AssetsWithFieldType> assetsWithFieldType, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAutomaticallyCreatedAssets(new RemoveAutomaticallyCreatedAssetsRequest
            {
                AdGroupAd = gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAd, nameof(adGroupAd)),
                AssetsWithFieldType =
                {
                    gax::GaxPreconditions.CheckNotNull(assetsWithFieldType, nameof(assetsWithFieldType)),
                },
            }, callSettings);

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="adGroupAd">
        /// Required. The resource name of the AdGroupAd from which to remove
        /// automatically created assets.
        /// </param>
        /// <param name="assetsWithFieldType">
        /// Required. List of assets with field type to be removed from the AdGroupAd.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveAutomaticallyCreatedAssetsAsync(string adGroupAd, scg::IEnumerable<AssetsWithFieldType> assetsWithFieldType, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAutomaticallyCreatedAssetsAsync(new RemoveAutomaticallyCreatedAssetsRequest
            {
                AdGroupAd = gax::GaxPreconditions.CheckNotNullOrEmpty(adGroupAd, nameof(adGroupAd)),
                AssetsWithFieldType =
                {
                    gax::GaxPreconditions.CheckNotNull(assetsWithFieldType, nameof(assetsWithFieldType)),
                },
            }, callSettings);

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="adGroupAd">
        /// Required. The resource name of the AdGroupAd from which to remove
        /// automatically created assets.
        /// </param>
        /// <param name="assetsWithFieldType">
        /// Required. List of assets with field type to be removed from the AdGroupAd.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveAutomaticallyCreatedAssetsAsync(string adGroupAd, scg::IEnumerable<AssetsWithFieldType> assetsWithFieldType, st::CancellationToken cancellationToken) =>
            RemoveAutomaticallyCreatedAssetsAsync(adGroupAd, assetsWithFieldType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="adGroupAd">
        /// Required. The resource name of the AdGroupAd from which to remove
        /// automatically created assets.
        /// </param>
        /// <param name="assetsWithFieldType">
        /// Required. List of assets with field type to be removed from the AdGroupAd.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void RemoveAutomaticallyCreatedAssets(gagvr::AdGroupAdName adGroupAd, scg::IEnumerable<AssetsWithFieldType> assetsWithFieldType, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAutomaticallyCreatedAssets(new RemoveAutomaticallyCreatedAssetsRequest
            {
                AdGroupAdAsAdGroupAdName = gax::GaxPreconditions.CheckNotNull(adGroupAd, nameof(adGroupAd)),
                AssetsWithFieldType =
                {
                    gax::GaxPreconditions.CheckNotNull(assetsWithFieldType, nameof(assetsWithFieldType)),
                },
            }, callSettings);

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="adGroupAd">
        /// Required. The resource name of the AdGroupAd from which to remove
        /// automatically created assets.
        /// </param>
        /// <param name="assetsWithFieldType">
        /// Required. List of assets with field type to be removed from the AdGroupAd.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveAutomaticallyCreatedAssetsAsync(gagvr::AdGroupAdName adGroupAd, scg::IEnumerable<AssetsWithFieldType> assetsWithFieldType, gaxgrpc::CallSettings callSettings = null) =>
            RemoveAutomaticallyCreatedAssetsAsync(new RemoveAutomaticallyCreatedAssetsRequest
            {
                AdGroupAdAsAdGroupAdName = gax::GaxPreconditions.CheckNotNull(adGroupAd, nameof(adGroupAd)),
                AssetsWithFieldType =
                {
                    gax::GaxPreconditions.CheckNotNull(assetsWithFieldType, nameof(assetsWithFieldType)),
                },
            }, callSettings);

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="adGroupAd">
        /// Required. The resource name of the AdGroupAd from which to remove
        /// automatically created assets.
        /// </param>
        /// <param name="assetsWithFieldType">
        /// Required. List of assets with field type to be removed from the AdGroupAd.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task RemoveAutomaticallyCreatedAssetsAsync(gagvr::AdGroupAdName adGroupAd, scg::IEnumerable<AssetsWithFieldType> assetsWithFieldType, st::CancellationToken cancellationToken) =>
            RemoveAutomaticallyCreatedAssetsAsync(adGroupAd, assetsWithFieldType, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupAdService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ads in an ad group.
    /// </remarks>
    public sealed partial class AdGroupAdServiceClientImpl : AdGroupAdServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAdGroupAdsRequest, MutateAdGroupAdsResponse> _callMutateAdGroupAds;

        private readonly gaxgrpc::ApiCall<RemoveAutomaticallyCreatedAssetsRequest, wkt::Empty> _callRemoveAutomaticallyCreatedAssets;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupAdService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdGroupAdServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdGroupAdServiceClientImpl(AdGroupAdService.AdGroupAdServiceClient grpcClient, AdGroupAdServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdGroupAdServiceSettings effectiveSettings = settings ?? AdGroupAdServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateAdGroupAds = clientHelper.BuildApiCall<MutateAdGroupAdsRequest, MutateAdGroupAdsResponse>("MutateAdGroupAds", grpcClient.MutateAdGroupAdsAsync, grpcClient.MutateAdGroupAds, effectiveSettings.MutateAdGroupAdsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupAds);
            Modify_MutateAdGroupAdsApiCall(ref _callMutateAdGroupAds);
            _callRemoveAutomaticallyCreatedAssets = clientHelper.BuildApiCall<RemoveAutomaticallyCreatedAssetsRequest, wkt::Empty>("RemoveAutomaticallyCreatedAssets", grpcClient.RemoveAutomaticallyCreatedAssetsAsync, grpcClient.RemoveAutomaticallyCreatedAssets, effectiveSettings.RemoveAutomaticallyCreatedAssetsSettings).WithGoogleRequestParam("ad_group_ad", request => request.AdGroupAd);
            Modify_ApiCall(ref _callRemoveAutomaticallyCreatedAssets);
            Modify_RemoveAutomaticallyCreatedAssetsApiCall(ref _callRemoveAutomaticallyCreatedAssets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAdGroupAdsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupAdsRequest, MutateAdGroupAdsResponse> call);

        partial void Modify_RemoveAutomaticallyCreatedAssetsApiCall(ref gaxgrpc::ApiCall<RemoveAutomaticallyCreatedAssetsRequest, wkt::Empty> call);

        partial void OnConstruction(AdGroupAdService.AdGroupAdServiceClient grpcClient, AdGroupAdServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupAdService client</summary>
        public override AdGroupAdService.AdGroupAdServiceClient GrpcClient { get; }

        partial void Modify_MutateAdGroupAdsRequest(ref MutateAdGroupAdsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveAutomaticallyCreatedAssetsRequest(ref RemoveAutomaticallyCreatedAssetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
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
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyValidationParameterError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupAdsResponse MutateAdGroupAds(MutateAdGroupAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAdsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAds.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ads. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdCustomizerError]()
        /// [AdError]()
        /// [AdGroupAdError]()
        /// [AdSharingError]()
        /// [AdxError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [ContextError]()
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
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [PolicyFindingError]()
        /// [PolicyValidationParameterError]()
        /// [PolicyViolationError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupAdsResponse> MutateAdGroupAdsAsync(MutateAdGroupAdsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAdsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAds.Async(request, callSettings);
        }

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void RemoveAutomaticallyCreatedAssets(RemoveAutomaticallyCreatedAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAutomaticallyCreatedAssetsRequest(ref request, ref callSettings);
            _callRemoveAutomaticallyCreatedAssets.Sync(request, callSettings);
        }

        /// <summary>
        /// Remove automatically created assets from an ad.
        /// 
        /// List of thrown errors:
        /// [AdError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [AutomaticallyCreatedAssetRemovalError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task RemoveAutomaticallyCreatedAssetsAsync(RemoveAutomaticallyCreatedAssetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveAutomaticallyCreatedAssetsRequest(ref request, ref callSettings);
            return _callRemoveAutomaticallyCreatedAssets.Async(request, callSettings);
        }
    }
}

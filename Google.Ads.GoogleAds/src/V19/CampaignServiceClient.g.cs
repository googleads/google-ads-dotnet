// Copyright 2025 Google LLC
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

namespace Google.Ads.GoogleAds.V19.Services
{
    /// <summary>Settings for <see cref="CampaignServiceClient"/> instances.</summary>
    public sealed partial class CampaignServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignServiceSettings"/>.</returns>
        public static CampaignServiceSettings GetDefault() => new CampaignServiceSettings();

        /// <summary>Constructs a new <see cref="CampaignServiceSettings"/> object with default settings.</summary>
        public CampaignServiceSettings()
        {
        }

        private CampaignServiceSettings(CampaignServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCampaignsSettings = existing.MutateCampaignsSettings;
            EnablePMaxBrandGuidelinesSettings = existing.EnablePMaxBrandGuidelinesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignServiceClient.MutateCampaigns</c> and <c>CampaignServiceClient.MutateCampaignsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCampaignsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignServiceClient.EnablePMaxBrandGuidelines</c> and
        /// <c>CampaignServiceClient.EnablePMaxBrandGuidelinesAsync</c>.
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
        public gaxgrpc::CallSettings EnablePMaxBrandGuidelinesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignServiceSettings"/> object.</returns>
        public CampaignServiceSettings Clone() => new CampaignServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class CampaignServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignServiceClientBuilder() : base(CampaignServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CampaignServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignServiceClient Build()
        {
            CampaignServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CampaignServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignServiceClient.ChannelPool;
    }

    /// <summary>CampaignService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaigns.
    /// </remarks>
    public abstract partial class CampaignServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignService scopes.</summary>
        /// <remarks>
        /// The default CampaignService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CampaignService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CampaignServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignServiceClient"/>.</returns>
        public static stt::Task<CampaignServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="CampaignServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignServiceClient"/>.</returns>
        public static CampaignServiceClient Create() => new CampaignServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CampaignServiceClient"/>.</returns>
        internal static CampaignServiceClient Create(grpccore::CallInvoker callInvoker, CampaignServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignService.CampaignServiceClient grpcClient = new CampaignService.CampaignServiceClient(callInvoker);
            return new CampaignServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CampaignService client</summary>
        public virtual CampaignService.CampaignServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CampaignBudgetError]()
        /// [CampaignError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotAllowlistedError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RegionCodeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignsResponse MutateCampaigns(MutateCampaignsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CampaignBudgetError]()
        /// [CampaignError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotAllowlistedError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RegionCodeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(MutateCampaignsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CampaignBudgetError]()
        /// [CampaignError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotAllowlistedError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RegionCodeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(MutateCampaignsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CampaignBudgetError]()
        /// [CampaignError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotAllowlistedError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RegionCodeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaigns are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaigns.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignsResponse MutateCampaigns(string customerId, scg::IEnumerable<CampaignOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaigns(new MutateCampaignsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CampaignBudgetError]()
        /// [CampaignError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotAllowlistedError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RegionCodeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaigns are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaigns.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(string customerId, scg::IEnumerable<CampaignOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignsAsync(new MutateCampaignsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CampaignBudgetError]()
        /// [CampaignError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotAllowlistedError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RegionCodeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaigns are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaigns.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(string customerId, scg::IEnumerable<CampaignOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables Brand Guidelines for Performance Max campaigns.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthorizationError]()
        /// [BrandGuidelinesMigrationError]()
        /// [CampaignError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EnablePMaxBrandGuidelinesResponse EnablePMaxBrandGuidelines(EnablePMaxBrandGuidelinesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables Brand Guidelines for Performance Max campaigns.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthorizationError]()
        /// [BrandGuidelinesMigrationError]()
        /// [CampaignError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EnablePMaxBrandGuidelinesResponse> EnablePMaxBrandGuidelinesAsync(EnablePMaxBrandGuidelinesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Enables Brand Guidelines for Performance Max campaigns.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthorizationError]()
        /// [BrandGuidelinesMigrationError]()
        /// [CampaignError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EnablePMaxBrandGuidelinesResponse> EnablePMaxBrandGuidelinesAsync(EnablePMaxBrandGuidelinesRequest request, st::CancellationToken cancellationToken) =>
            EnablePMaxBrandGuidelinesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Enables Brand Guidelines for Performance Max campaigns.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthorizationError]()
        /// [BrandGuidelinesMigrationError]()
        /// [CampaignError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaigns are being enabled.
        /// </param>
        /// <param name="operations">
        /// Required. The list of individual campaign operations. A maximum of 10
        /// enable operations can be executed in a request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual EnablePMaxBrandGuidelinesResponse EnablePMaxBrandGuidelines(string customerId, scg::IEnumerable<EnableOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            EnablePMaxBrandGuidelines(new EnablePMaxBrandGuidelinesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Enables Brand Guidelines for Performance Max campaigns.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthorizationError]()
        /// [BrandGuidelinesMigrationError]()
        /// [CampaignError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaigns are being enabled.
        /// </param>
        /// <param name="operations">
        /// Required. The list of individual campaign operations. A maximum of 10
        /// enable operations can be executed in a request.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EnablePMaxBrandGuidelinesResponse> EnablePMaxBrandGuidelinesAsync(string customerId, scg::IEnumerable<EnableOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            EnablePMaxBrandGuidelinesAsync(new EnablePMaxBrandGuidelinesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Enables Brand Guidelines for Performance Max campaigns.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthorizationError]()
        /// [BrandGuidelinesMigrationError]()
        /// [CampaignError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaigns are being enabled.
        /// </param>
        /// <param name="operations">
        /// Required. The list of individual campaign operations. A maximum of 10
        /// enable operations can be executed in a request.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<EnablePMaxBrandGuidelinesResponse> EnablePMaxBrandGuidelinesAsync(string customerId, scg::IEnumerable<EnableOperation> operations, st::CancellationToken cancellationToken) =>
            EnablePMaxBrandGuidelinesAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaigns.
    /// </remarks>
    public sealed partial class CampaignServiceClientImpl : CampaignServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCampaignsRequest, MutateCampaignsResponse> _callMutateCampaigns;

        private readonly gaxgrpc::ApiCall<EnablePMaxBrandGuidelinesRequest, EnablePMaxBrandGuidelinesResponse> _callEnablePMaxBrandGuidelines;

        /// <summary>
        /// Constructs a client wrapper for the CampaignService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CampaignServiceClientImpl(CampaignService.CampaignServiceClient grpcClient, CampaignServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CampaignServiceSettings effectiveSettings = settings ?? CampaignServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCampaigns = clientHelper.BuildApiCall<MutateCampaignsRequest, MutateCampaignsResponse>("MutateCampaigns", grpcClient.MutateCampaignsAsync, grpcClient.MutateCampaigns, effectiveSettings.MutateCampaignsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaigns);
            Modify_MutateCampaignsApiCall(ref _callMutateCampaigns);
            _callEnablePMaxBrandGuidelines = clientHelper.BuildApiCall<EnablePMaxBrandGuidelinesRequest, EnablePMaxBrandGuidelinesResponse>("EnablePMaxBrandGuidelines", grpcClient.EnablePMaxBrandGuidelinesAsync, grpcClient.EnablePMaxBrandGuidelines, effectiveSettings.EnablePMaxBrandGuidelinesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callEnablePMaxBrandGuidelines);
            Modify_EnablePMaxBrandGuidelinesApiCall(ref _callEnablePMaxBrandGuidelines);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCampaignsApiCall(ref gaxgrpc::ApiCall<MutateCampaignsRequest, MutateCampaignsResponse> call);

        partial void Modify_EnablePMaxBrandGuidelinesApiCall(ref gaxgrpc::ApiCall<EnablePMaxBrandGuidelinesRequest, EnablePMaxBrandGuidelinesResponse> call);

        partial void OnConstruction(CampaignService.CampaignServiceClient grpcClient, CampaignServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignService client</summary>
        public override CampaignService.CampaignServiceClient GrpcClient { get; }

        partial void Modify_MutateCampaignsRequest(ref MutateCampaignsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EnablePMaxBrandGuidelinesRequest(ref EnablePMaxBrandGuidelinesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CampaignBudgetError]()
        /// [CampaignError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotAllowlistedError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RegionCodeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignsResponse MutateCampaigns(MutateCampaignsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignsRequest(ref request, ref callSettings);
            return _callMutateCampaigns.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaigns. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AdxError]()
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BiddingError]()
        /// [BiddingStrategyError]()
        /// [CampaignBudgetError]()
        /// [CampaignError]()
        /// [ContextError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [ListOperationError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotAllowlistedError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperationAccessDeniedError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RegionCodeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SettingError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// [UrlFieldError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignsResponse> MutateCampaignsAsync(MutateCampaignsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignsRequest(ref request, ref callSettings);
            return _callMutateCampaigns.Async(request, callSettings);
        }

        /// <summary>
        /// Enables Brand Guidelines for Performance Max campaigns.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthorizationError]()
        /// [BrandGuidelinesMigrationError]()
        /// [CampaignError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override EnablePMaxBrandGuidelinesResponse EnablePMaxBrandGuidelines(EnablePMaxBrandGuidelinesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnablePMaxBrandGuidelinesRequest(ref request, ref callSettings);
            return _callEnablePMaxBrandGuidelines.Sync(request, callSettings);
        }

        /// <summary>
        /// Enables Brand Guidelines for Performance Max campaigns.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AssetError]()
        /// [AssetLinkError]()
        /// [AuthorizationError]()
        /// [BrandGuidelinesMigrationError]()
        /// [CampaignError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<EnablePMaxBrandGuidelinesResponse> EnablePMaxBrandGuidelinesAsync(EnablePMaxBrandGuidelinesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EnablePMaxBrandGuidelinesRequest(ref request, ref callSettings);
            return _callEnablePMaxBrandGuidelines.Async(request, callSettings);
        }
    }
}

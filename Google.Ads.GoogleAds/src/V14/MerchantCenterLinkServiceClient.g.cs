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
using gagvr = Google.Ads.GoogleAds.V14.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V14.Services
{
    /// <summary>Settings for <see cref="MerchantCenterLinkServiceClient"/> instances.</summary>
    public sealed partial class MerchantCenterLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MerchantCenterLinkServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MerchantCenterLinkServiceSettings"/>.</returns>
        public static MerchantCenterLinkServiceSettings GetDefault() => new MerchantCenterLinkServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="MerchantCenterLinkServiceSettings"/> object with default settings.
        /// </summary>
        public MerchantCenterLinkServiceSettings()
        {
        }

        private MerchantCenterLinkServiceSettings(MerchantCenterLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            ListMerchantCenterLinksSettings = existing.ListMerchantCenterLinksSettings;
            GetMerchantCenterLinkSettings = existing.GetMerchantCenterLinkSettings;
            MutateMerchantCenterLinkSettings = existing.MutateMerchantCenterLinkSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MerchantCenterLinkServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MerchantCenterLinkServiceClient.ListMerchantCenterLinks</c> and
        /// <c>MerchantCenterLinkServiceClient.ListMerchantCenterLinksAsync</c>.
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
        public gaxgrpc::CallSettings ListMerchantCenterLinksSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MerchantCenterLinkServiceClient.GetMerchantCenterLink</c> and
        /// <c>MerchantCenterLinkServiceClient.GetMerchantCenterLinkAsync</c>.
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
        public gaxgrpc::CallSettings GetMerchantCenterLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MerchantCenterLinkServiceClient.MutateMerchantCenterLink</c> and
        /// <c>MerchantCenterLinkServiceClient.MutateMerchantCenterLinkAsync</c>.
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
        public gaxgrpc::CallSettings MutateMerchantCenterLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MerchantCenterLinkServiceSettings"/> object.</returns>
        public MerchantCenterLinkServiceSettings Clone() => new MerchantCenterLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MerchantCenterLinkServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class MerchantCenterLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<MerchantCenterLinkServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MerchantCenterLinkServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public MerchantCenterLinkServiceClientBuilder() : base(MerchantCenterLinkServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref MerchantCenterLinkServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MerchantCenterLinkServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MerchantCenterLinkServiceClient Build()
        {
            MerchantCenterLinkServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MerchantCenterLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MerchantCenterLinkServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MerchantCenterLinkServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MerchantCenterLinkServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<MerchantCenterLinkServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MerchantCenterLinkServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MerchantCenterLinkServiceClient.ChannelPool;
    }

    /// <summary>MerchantCenterLinkService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of links between Google Ads and Google
    /// Merchant Center.
    /// </remarks>
    public abstract partial class MerchantCenterLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the MerchantCenterLinkService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default MerchantCenterLinkService scopes.</summary>
        /// <remarks>
        /// The default MerchantCenterLinkService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(MerchantCenterLinkService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="MerchantCenterLinkServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MerchantCenterLinkServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MerchantCenterLinkServiceClient"/>.</returns>
        public static stt::Task<MerchantCenterLinkServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MerchantCenterLinkServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MerchantCenterLinkServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="MerchantCenterLinkServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MerchantCenterLinkServiceClient"/>.</returns>
        public static MerchantCenterLinkServiceClient Create() => new MerchantCenterLinkServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MerchantCenterLinkServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MerchantCenterLinkServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="MerchantCenterLinkServiceClient"/>.</returns>
        internal static MerchantCenterLinkServiceClient Create(grpccore::CallInvoker callInvoker, MerchantCenterLinkServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MerchantCenterLinkService.MerchantCenterLinkServiceClient grpcClient = new MerchantCenterLinkService.MerchantCenterLinkServiceClient(callInvoker);
            return new MerchantCenterLinkServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC MerchantCenterLinkService client</summary>
        public virtual MerchantCenterLinkService.MerchantCenterLinkServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        public virtual ListMerchantCenterLinksResponse ListMerchantCenterLinks(ListMerchantCenterLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        public virtual stt::Task<ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(ListMerchantCenterLinksRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        public virtual stt::Task<ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(ListMerchantCenterLinksRequest request, st::CancellationToken cancellationToken) =>
            ListMerchantCenterLinksAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        /// Required. The ID of the customer onto which to apply the Merchant Center
        /// link list operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual ListMerchantCenterLinksResponse ListMerchantCenterLinks(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            ListMerchantCenterLinks(new ListMerchantCenterLinksRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        /// Required. The ID of the customer onto which to apply the Merchant Center
        /// link list operation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            ListMerchantCenterLinksAsync(new ListMerchantCenterLinksRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        /// Required. The ID of the customer onto which to apply the Merchant Center
        /// link list operation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(string customerId, st::CancellationToken cancellationToken) =>
            ListMerchantCenterLinksAsync(customerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        public virtual gagvr::MerchantCenterLink GetMerchantCenterLink(GetMerchantCenterLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        public virtual stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(GetMerchantCenterLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        public virtual stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(GetMerchantCenterLinkRequest request, st::CancellationToken cancellationToken) =>
            GetMerchantCenterLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        /// Required. Resource name of the Merchant Center link.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MerchantCenterLink GetMerchantCenterLink(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMerchantCenterLink(new GetMerchantCenterLinkRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        /// Required. Resource name of the Merchant Center link.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMerchantCenterLinkAsync(new GetMerchantCenterLinkRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        /// Required. Resource name of the Merchant Center link.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetMerchantCenterLinkAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        /// Required. Resource name of the Merchant Center link.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MerchantCenterLink GetMerchantCenterLink(gagvr::MerchantCenterLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMerchantCenterLink(new GetMerchantCenterLinkRequest
            {
                ResourceNameAsMerchantCenterLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        /// Required. Resource name of the Merchant Center link.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(gagvr::MerchantCenterLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMerchantCenterLinkAsync(new GetMerchantCenterLinkRequest
            {
                ResourceNameAsMerchantCenterLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        /// Required. Resource name of the Merchant Center link.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(gagvr::MerchantCenterLinkName resourceName, st::CancellationToken cancellationToken) =>
            GetMerchantCenterLinkAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateMerchantCenterLinkResponse MutateMerchantCenterLink(MutateMerchantCenterLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(MutateMerchantCenterLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(MutateMerchantCenterLinkRequest request, st::CancellationToken cancellationToken) =>
            MutateMerchantCenterLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the link
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateMerchantCenterLinkResponse MutateMerchantCenterLink(string customerId, MerchantCenterLinkOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateMerchantCenterLink(new MutateMerchantCenterLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the link
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(string customerId, MerchantCenterLinkOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateMerchantCenterLinkAsync(new MutateMerchantCenterLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the link
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(string customerId, MerchantCenterLinkOperation operation, st::CancellationToken cancellationToken) =>
            MutateMerchantCenterLinkAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MerchantCenterLinkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of links between Google Ads and Google
    /// Merchant Center.
    /// </remarks>
    public sealed partial class MerchantCenterLinkServiceClientImpl : MerchantCenterLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<ListMerchantCenterLinksRequest, ListMerchantCenterLinksResponse> _callListMerchantCenterLinks;

        private readonly gaxgrpc::ApiCall<GetMerchantCenterLinkRequest, gagvr::MerchantCenterLink> _callGetMerchantCenterLink;

        private readonly gaxgrpc::ApiCall<MutateMerchantCenterLinkRequest, MutateMerchantCenterLinkResponse> _callMutateMerchantCenterLink;

        /// <summary>
        /// Constructs a client wrapper for the MerchantCenterLinkService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="MerchantCenterLinkServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public MerchantCenterLinkServiceClientImpl(MerchantCenterLinkService.MerchantCenterLinkServiceClient grpcClient, MerchantCenterLinkServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            MerchantCenterLinkServiceSettings effectiveSettings = settings ?? MerchantCenterLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callListMerchantCenterLinks = clientHelper.BuildApiCall<ListMerchantCenterLinksRequest, ListMerchantCenterLinksResponse>("ListMerchantCenterLinks", grpcClient.ListMerchantCenterLinksAsync, grpcClient.ListMerchantCenterLinks, effectiveSettings.ListMerchantCenterLinksSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callListMerchantCenterLinks);
            Modify_ListMerchantCenterLinksApiCall(ref _callListMerchantCenterLinks);
            _callGetMerchantCenterLink = clientHelper.BuildApiCall<GetMerchantCenterLinkRequest, gagvr::MerchantCenterLink>("GetMerchantCenterLink", grpcClient.GetMerchantCenterLinkAsync, grpcClient.GetMerchantCenterLink, effectiveSettings.GetMerchantCenterLinkSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetMerchantCenterLink);
            Modify_GetMerchantCenterLinkApiCall(ref _callGetMerchantCenterLink);
            _callMutateMerchantCenterLink = clientHelper.BuildApiCall<MutateMerchantCenterLinkRequest, MutateMerchantCenterLinkResponse>("MutateMerchantCenterLink", grpcClient.MutateMerchantCenterLinkAsync, grpcClient.MutateMerchantCenterLink, effectiveSettings.MutateMerchantCenterLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateMerchantCenterLink);
            Modify_MutateMerchantCenterLinkApiCall(ref _callMutateMerchantCenterLink);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_ListMerchantCenterLinksApiCall(ref gaxgrpc::ApiCall<ListMerchantCenterLinksRequest, ListMerchantCenterLinksResponse> call);

        partial void Modify_GetMerchantCenterLinkApiCall(ref gaxgrpc::ApiCall<GetMerchantCenterLinkRequest, gagvr::MerchantCenterLink> call);

        partial void Modify_MutateMerchantCenterLinkApiCall(ref gaxgrpc::ApiCall<MutateMerchantCenterLinkRequest, MutateMerchantCenterLinkResponse> call);

        partial void OnConstruction(MerchantCenterLinkService.MerchantCenterLinkServiceClient grpcClient, MerchantCenterLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MerchantCenterLinkService client</summary>
        public override MerchantCenterLinkService.MerchantCenterLinkServiceClient GrpcClient { get; }

        partial void Modify_ListMerchantCenterLinksRequest(ref ListMerchantCenterLinksRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMerchantCenterLinkRequest(ref GetMerchantCenterLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateMerchantCenterLinkRequest(ref MutateMerchantCenterLinkRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        public override ListMerchantCenterLinksResponse ListMerchantCenterLinks(ListMerchantCenterLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMerchantCenterLinksRequest(ref request, ref callSettings);
            return _callListMerchantCenterLinks.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns Merchant Center links available for this customer.
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
        public override stt::Task<ListMerchantCenterLinksResponse> ListMerchantCenterLinksAsync(ListMerchantCenterLinksRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMerchantCenterLinksRequest(ref request, ref callSettings);
            return _callListMerchantCenterLinks.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        public override gagvr::MerchantCenterLink GetMerchantCenterLink(GetMerchantCenterLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMerchantCenterLinkRequest(ref request, ref callSettings);
            return _callGetMerchantCenterLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the Merchant Center link in full detail.
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
        public override stt::Task<gagvr::MerchantCenterLink> GetMerchantCenterLinkAsync(GetMerchantCenterLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMerchantCenterLinkRequest(ref request, ref callSettings);
            return _callGetMerchantCenterLink.Async(request, callSettings);
        }

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateMerchantCenterLinkResponse MutateMerchantCenterLink(MutateMerchantCenterLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateMerchantCenterLinkRequest(ref request, ref callSettings);
            return _callMutateMerchantCenterLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates status or removes a Merchant Center link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateMerchantCenterLinkResponse> MutateMerchantCenterLinkAsync(MutateMerchantCenterLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateMerchantCenterLinkRequest(ref request, ref callSettings);
            return _callMutateMerchantCenterLink.Async(request, callSettings);
        }
    }
}

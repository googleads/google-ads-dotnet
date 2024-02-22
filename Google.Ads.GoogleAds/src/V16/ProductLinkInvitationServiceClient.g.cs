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
using gagve = Google.Ads.GoogleAds.V16.Enums;
using gagvr = Google.Ads.GoogleAds.V16.Resources;
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

namespace Google.Ads.GoogleAds.V16.Services
{
    /// <summary>Settings for <see cref="ProductLinkInvitationServiceClient"/> instances.</summary>
    public sealed partial class ProductLinkInvitationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProductLinkInvitationServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProductLinkInvitationServiceSettings"/>.</returns>
        public static ProductLinkInvitationServiceSettings GetDefault() => new ProductLinkInvitationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ProductLinkInvitationServiceSettings"/> object with default settings.
        /// </summary>
        public ProductLinkInvitationServiceSettings()
        {
        }

        private ProductLinkInvitationServiceSettings(ProductLinkInvitationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateProductLinkInvitationSettings = existing.CreateProductLinkInvitationSettings;
            UpdateProductLinkInvitationSettings = existing.UpdateProductLinkInvitationSettings;
            RemoveProductLinkInvitationSettings = existing.RemoveProductLinkInvitationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProductLinkInvitationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductLinkInvitationServiceClient.CreateProductLinkInvitation</c> and
        /// <c>ProductLinkInvitationServiceClient.CreateProductLinkInvitationAsync</c>.
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
        public gaxgrpc::CallSettings CreateProductLinkInvitationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductLinkInvitationServiceClient.UpdateProductLinkInvitation</c> and
        /// <c>ProductLinkInvitationServiceClient.UpdateProductLinkInvitationAsync</c>.
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
        public gaxgrpc::CallSettings UpdateProductLinkInvitationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductLinkInvitationServiceClient.RemoveProductLinkInvitation</c> and
        /// <c>ProductLinkInvitationServiceClient.RemoveProductLinkInvitationAsync</c>.
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
        public gaxgrpc::CallSettings RemoveProductLinkInvitationSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProductLinkInvitationServiceSettings"/> object.</returns>
        public ProductLinkInvitationServiceSettings Clone() => new ProductLinkInvitationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProductLinkInvitationServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class ProductLinkInvitationServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProductLinkInvitationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProductLinkInvitationServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProductLinkInvitationServiceClientBuilder() : base(ProductLinkInvitationServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProductLinkInvitationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProductLinkInvitationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProductLinkInvitationServiceClient Build()
        {
            ProductLinkInvitationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProductLinkInvitationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProductLinkInvitationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProductLinkInvitationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProductLinkInvitationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProductLinkInvitationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProductLinkInvitationServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProductLinkInvitationServiceClient.ChannelPool;
    }

    /// <summary>ProductLinkInvitationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of product link invitations from Google Ads
    /// accounts to other accounts.
    /// </remarks>
    public abstract partial class ProductLinkInvitationServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProductLinkInvitationService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ProductLinkInvitationService scopes.</summary>
        /// <remarks>
        /// The default ProductLinkInvitationService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProductLinkInvitationService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductLinkInvitationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ProductLinkInvitationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProductLinkInvitationServiceClient"/>.</returns>
        public static stt::Task<ProductLinkInvitationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProductLinkInvitationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProductLinkInvitationServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ProductLinkInvitationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProductLinkInvitationServiceClient"/>.</returns>
        public static ProductLinkInvitationServiceClient Create() => new ProductLinkInvitationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProductLinkInvitationServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProductLinkInvitationServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProductLinkInvitationServiceClient"/>.</returns>
        internal static ProductLinkInvitationServiceClient Create(grpccore::CallInvoker callInvoker, ProductLinkInvitationServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductLinkInvitationService.ProductLinkInvitationServiceClient grpcClient = new ProductLinkInvitationService.ProductLinkInvitationServiceClient(callInvoker);
            return new ProductLinkInvitationServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProductLinkInvitationService client</summary>
        public virtual ProductLinkInvitationService.ProductLinkInvitationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateProductLinkInvitationResponse CreateProductLinkInvitation(CreateProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateProductLinkInvitationResponse> CreateProductLinkInvitationAsync(CreateProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateProductLinkInvitationResponse> CreateProductLinkInvitationAsync(CreateProductLinkInvitationRequest request, st::CancellationToken cancellationToken) =>
            CreateProductLinkInvitationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="productLinkInvitation">
        /// Required. The product link invitation to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateProductLinkInvitationResponse CreateProductLinkInvitation(string customerId, gagvr::ProductLinkInvitation productLinkInvitation, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductLinkInvitation(new CreateProductLinkInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ProductLinkInvitation = gax::GaxPreconditions.CheckNotNull(productLinkInvitation, nameof(productLinkInvitation)),
            }, callSettings);

        /// <summary>
        /// Creates a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="productLinkInvitation">
        /// Required. The product link invitation to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateProductLinkInvitationResponse> CreateProductLinkInvitationAsync(string customerId, gagvr::ProductLinkInvitation productLinkInvitation, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductLinkInvitationAsync(new CreateProductLinkInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ProductLinkInvitation = gax::GaxPreconditions.CheckNotNull(productLinkInvitation, nameof(productLinkInvitation)),
            }, callSettings);

        /// <summary>
        /// Creates a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="productLinkInvitation">
        /// Required. The product link invitation to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateProductLinkInvitationResponse> CreateProductLinkInvitationAsync(string customerId, gagvr::ProductLinkInvitation productLinkInvitation, st::CancellationToken cancellationToken) =>
            CreateProductLinkInvitationAsync(customerId, productLinkInvitation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateProductLinkInvitationResponse UpdateProductLinkInvitation(UpdateProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateProductLinkInvitationResponse> UpdateProductLinkInvitationAsync(UpdateProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateProductLinkInvitationResponse> UpdateProductLinkInvitationAsync(UpdateProductLinkInvitationRequest request, st::CancellationToken cancellationToken) =>
            UpdateProductLinkInvitationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="productLinkInvitationStatus">
        /// Required. The product link invitation to be created.
        /// </param>
        /// <param name="resourceName">
        /// Required. Resource name of the product link invitation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateProductLinkInvitationResponse UpdateProductLinkInvitation(string customerId, gagve::ProductLinkInvitationStatusEnum.Types.ProductLinkInvitationStatus productLinkInvitationStatus, string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProductLinkInvitation(new UpdateProductLinkInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ProductLinkInvitationStatus = productLinkInvitationStatus,
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="productLinkInvitationStatus">
        /// Required. The product link invitation to be created.
        /// </param>
        /// <param name="resourceName">
        /// Required. Resource name of the product link invitation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateProductLinkInvitationResponse> UpdateProductLinkInvitationAsync(string customerId, gagve::ProductLinkInvitationStatusEnum.Types.ProductLinkInvitationStatus productLinkInvitationStatus, string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProductLinkInvitationAsync(new UpdateProductLinkInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ProductLinkInvitationStatus = productLinkInvitationStatus,
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="productLinkInvitationStatus">
        /// Required. The product link invitation to be created.
        /// </param>
        /// <param name="resourceName">
        /// Required. Resource name of the product link invitation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateProductLinkInvitationResponse> UpdateProductLinkInvitationAsync(string customerId, gagve::ProductLinkInvitationStatusEnum.Types.ProductLinkInvitationStatus productLinkInvitationStatus, string resourceName, st::CancellationToken cancellationToken) =>
            UpdateProductLinkInvitationAsync(customerId, productLinkInvitationStatus, resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="productLinkInvitationStatus">
        /// Required. The product link invitation to be created.
        /// </param>
        /// <param name="resourceName">
        /// Required. Resource name of the product link invitation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UpdateProductLinkInvitationResponse UpdateProductLinkInvitation(string customerId, gagve::ProductLinkInvitationStatusEnum.Types.ProductLinkInvitationStatus productLinkInvitationStatus, gagvr::ProductLinkInvitationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProductLinkInvitation(new UpdateProductLinkInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ProductLinkInvitationStatus = productLinkInvitationStatus,
                ResourceNameAsProductLinkInvitationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="productLinkInvitationStatus">
        /// Required. The product link invitation to be created.
        /// </param>
        /// <param name="resourceName">
        /// Required. Resource name of the product link invitation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateProductLinkInvitationResponse> UpdateProductLinkInvitationAsync(string customerId, gagve::ProductLinkInvitationStatusEnum.Types.ProductLinkInvitationStatus productLinkInvitationStatus, gagvr::ProductLinkInvitationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            UpdateProductLinkInvitationAsync(new UpdateProductLinkInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ProductLinkInvitationStatus = productLinkInvitationStatus,
                ResourceNameAsProductLinkInvitationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="productLinkInvitationStatus">
        /// Required. The product link invitation to be created.
        /// </param>
        /// <param name="resourceName">
        /// Required. Resource name of the product link invitation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UpdateProductLinkInvitationResponse> UpdateProductLinkInvitationAsync(string customerId, gagve::ProductLinkInvitationStatusEnum.Types.ProductLinkInvitationStatus productLinkInvitationStatus, gagvr::ProductLinkInvitationName resourceName, st::CancellationToken cancellationToken) =>
            UpdateProductLinkInvitationAsync(customerId, productLinkInvitationStatus, resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveProductLinkInvitationResponse RemoveProductLinkInvitation(RemoveProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkInvitationResponse> RemoveProductLinkInvitationAsync(RemoveProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkInvitationResponse> RemoveProductLinkInvitationAsync(RemoveProductLinkInvitationRequest request, st::CancellationToken cancellationToken) =>
            RemoveProductLinkInvitationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the product link invitation being removed.
        /// </param>
        /// <param name="resourceName">
        /// Required. The resource name of the product link invitation being removed.
        /// expected, in this format:
        /// 
        /// ` `
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveProductLinkInvitationResponse RemoveProductLinkInvitation(string customerId, string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductLinkInvitation(new RemoveProductLinkInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the product link invitation being removed.
        /// </param>
        /// <param name="resourceName">
        /// Required. The resource name of the product link invitation being removed.
        /// expected, in this format:
        /// 
        /// ` `
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkInvitationResponse> RemoveProductLinkInvitationAsync(string customerId, string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductLinkInvitationAsync(new RemoveProductLinkInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the product link invitation being removed.
        /// </param>
        /// <param name="resourceName">
        /// Required. The resource name of the product link invitation being removed.
        /// expected, in this format:
        /// 
        /// ` `
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkInvitationResponse> RemoveProductLinkInvitationAsync(string customerId, string resourceName, st::CancellationToken cancellationToken) =>
            RemoveProductLinkInvitationAsync(customerId, resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the product link invitation being removed.
        /// </param>
        /// <param name="resourceName">
        /// Required. The resource name of the product link invitation being removed.
        /// expected, in this format:
        /// 
        /// ` `
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveProductLinkInvitationResponse RemoveProductLinkInvitation(string customerId, gagvr::ProductLinkInvitationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductLinkInvitation(new RemoveProductLinkInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceNameAsProductLinkInvitationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the product link invitation being removed.
        /// </param>
        /// <param name="resourceName">
        /// Required. The resource name of the product link invitation being removed.
        /// expected, in this format:
        /// 
        /// ` `
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkInvitationResponse> RemoveProductLinkInvitationAsync(string customerId, gagvr::ProductLinkInvitationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductLinkInvitationAsync(new RemoveProductLinkInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceNameAsProductLinkInvitationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the product link invitation being removed.
        /// </param>
        /// <param name="resourceName">
        /// Required. The resource name of the product link invitation being removed.
        /// expected, in this format:
        /// 
        /// ` `
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkInvitationResponse> RemoveProductLinkInvitationAsync(string customerId, gagvr::ProductLinkInvitationName resourceName, st::CancellationToken cancellationToken) =>
            RemoveProductLinkInvitationAsync(customerId, resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProductLinkInvitationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of product link invitations from Google Ads
    /// accounts to other accounts.
    /// </remarks>
    public sealed partial class ProductLinkInvitationServiceClientImpl : ProductLinkInvitationServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateProductLinkInvitationRequest, CreateProductLinkInvitationResponse> _callCreateProductLinkInvitation;

        private readonly gaxgrpc::ApiCall<UpdateProductLinkInvitationRequest, UpdateProductLinkInvitationResponse> _callUpdateProductLinkInvitation;

        private readonly gaxgrpc::ApiCall<RemoveProductLinkInvitationRequest, RemoveProductLinkInvitationResponse> _callRemoveProductLinkInvitation;

        /// <summary>
        /// Constructs a client wrapper for the ProductLinkInvitationService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ProductLinkInvitationServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProductLinkInvitationServiceClientImpl(ProductLinkInvitationService.ProductLinkInvitationServiceClient grpcClient, ProductLinkInvitationServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProductLinkInvitationServiceSettings effectiveSettings = settings ?? ProductLinkInvitationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callCreateProductLinkInvitation = clientHelper.BuildApiCall<CreateProductLinkInvitationRequest, CreateProductLinkInvitationResponse>("CreateProductLinkInvitation", grpcClient.CreateProductLinkInvitationAsync, grpcClient.CreateProductLinkInvitation, effectiveSettings.CreateProductLinkInvitationSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callCreateProductLinkInvitation);
            Modify_CreateProductLinkInvitationApiCall(ref _callCreateProductLinkInvitation);
            _callUpdateProductLinkInvitation = clientHelper.BuildApiCall<UpdateProductLinkInvitationRequest, UpdateProductLinkInvitationResponse>("UpdateProductLinkInvitation", grpcClient.UpdateProductLinkInvitationAsync, grpcClient.UpdateProductLinkInvitation, effectiveSettings.UpdateProductLinkInvitationSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callUpdateProductLinkInvitation);
            Modify_UpdateProductLinkInvitationApiCall(ref _callUpdateProductLinkInvitation);
            _callRemoveProductLinkInvitation = clientHelper.BuildApiCall<RemoveProductLinkInvitationRequest, RemoveProductLinkInvitationResponse>("RemoveProductLinkInvitation", grpcClient.RemoveProductLinkInvitationAsync, grpcClient.RemoveProductLinkInvitation, effectiveSettings.RemoveProductLinkInvitationSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callRemoveProductLinkInvitation);
            Modify_RemoveProductLinkInvitationApiCall(ref _callRemoveProductLinkInvitation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateProductLinkInvitationApiCall(ref gaxgrpc::ApiCall<CreateProductLinkInvitationRequest, CreateProductLinkInvitationResponse> call);

        partial void Modify_UpdateProductLinkInvitationApiCall(ref gaxgrpc::ApiCall<UpdateProductLinkInvitationRequest, UpdateProductLinkInvitationResponse> call);

        partial void Modify_RemoveProductLinkInvitationApiCall(ref gaxgrpc::ApiCall<RemoveProductLinkInvitationRequest, RemoveProductLinkInvitationResponse> call);

        partial void OnConstruction(ProductLinkInvitationService.ProductLinkInvitationServiceClient grpcClient, ProductLinkInvitationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProductLinkInvitationService client</summary>
        public override ProductLinkInvitationService.ProductLinkInvitationServiceClient GrpcClient { get; }

        partial void Modify_CreateProductLinkInvitationRequest(ref CreateProductLinkInvitationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UpdateProductLinkInvitationRequest(ref UpdateProductLinkInvitationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveProductLinkInvitationRequest(ref RemoveProductLinkInvitationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreateProductLinkInvitationResponse CreateProductLinkInvitation(CreateProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductLinkInvitationRequest(ref request, ref callSettings);
            return _callCreateProductLinkInvitation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreateProductLinkInvitationResponse> CreateProductLinkInvitationAsync(CreateProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductLinkInvitationRequest(ref request, ref callSettings);
            return _callCreateProductLinkInvitation.Async(request, callSettings);
        }

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UpdateProductLinkInvitationResponse UpdateProductLinkInvitation(UpdateProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductLinkInvitationRequest(ref request, ref callSettings);
            return _callUpdateProductLinkInvitation.Sync(request, callSettings);
        }

        /// <summary>
        /// Update a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UpdateProductLinkInvitationResponse> UpdateProductLinkInvitationAsync(UpdateProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UpdateProductLinkInvitationRequest(ref request, ref callSettings);
            return _callUpdateProductLinkInvitation.Async(request, callSettings);
        }

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveProductLinkInvitationResponse RemoveProductLinkInvitation(RemoveProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveProductLinkInvitationRequest(ref request, ref callSettings);
            return _callRemoveProductLinkInvitation.Sync(request, callSettings);
        }

        /// <summary>
        /// Remove a product link invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveProductLinkInvitationResponse> RemoveProductLinkInvitationAsync(RemoveProductLinkInvitationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveProductLinkInvitationRequest(ref request, ref callSettings);
            return _callRemoveProductLinkInvitation.Async(request, callSettings);
        }
    }
}

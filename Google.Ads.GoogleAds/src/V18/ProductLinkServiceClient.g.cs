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
using gagvr = Google.Ads.GoogleAds.V18.Resources;
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

namespace Google.Ads.GoogleAds.V18.Services
{
    /// <summary>Settings for <see cref="ProductLinkServiceClient"/> instances.</summary>
    public sealed partial class ProductLinkServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProductLinkServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProductLinkServiceSettings"/>.</returns>
        public static ProductLinkServiceSettings GetDefault() => new ProductLinkServiceSettings();

        /// <summary>Constructs a new <see cref="ProductLinkServiceSettings"/> object with default settings.</summary>
        public ProductLinkServiceSettings()
        {
        }

        private ProductLinkServiceSettings(ProductLinkServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateProductLinkSettings = existing.CreateProductLinkSettings;
            RemoveProductLinkSettings = existing.RemoveProductLinkSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProductLinkServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductLinkServiceClient.CreateProductLink</c> and <c>ProductLinkServiceClient.CreateProductLinkAsync</c>
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
        public gaxgrpc::CallSettings CreateProductLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductLinkServiceClient.RemoveProductLink</c> and <c>ProductLinkServiceClient.RemoveProductLinkAsync</c>
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
        public gaxgrpc::CallSettings RemoveProductLinkSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProductLinkServiceSettings"/> object.</returns>
        public ProductLinkServiceSettings Clone() => new ProductLinkServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProductLinkServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class ProductLinkServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProductLinkServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProductLinkServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ProductLinkServiceClientBuilder() : base(ProductLinkServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ProductLinkServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProductLinkServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProductLinkServiceClient Build()
        {
            ProductLinkServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProductLinkServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProductLinkServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProductLinkServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProductLinkServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ProductLinkServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProductLinkServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProductLinkServiceClient.ChannelPool;
    }

    /// <summary>ProductLinkService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of links between  a Google
    /// Ads customer and another product.
    /// </remarks>
    public abstract partial class ProductLinkServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProductLinkService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ProductLinkService scopes.</summary>
        /// <remarks>
        /// The default ProductLinkService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ProductLinkService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductLinkServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProductLinkServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProductLinkServiceClient"/>.</returns>
        public static stt::Task<ProductLinkServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProductLinkServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProductLinkServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ProductLinkServiceClientBuilder"/>
        /// .
        /// </summary>
        /// <returns>The created <see cref="ProductLinkServiceClient"/>.</returns>
        public static ProductLinkServiceClient Create() => new ProductLinkServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProductLinkServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProductLinkServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ProductLinkServiceClient"/>.</returns>
        internal static ProductLinkServiceClient Create(grpccore::CallInvoker callInvoker, ProductLinkServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductLinkService.ProductLinkServiceClient grpcClient = new ProductLinkService.ProductLinkServiceClient(callInvoker);
            return new ProductLinkServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ProductLinkService client</summary>
        public virtual ProductLinkService.ProductLinkServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateProductLinkResponse CreateProductLink(CreateProductLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateProductLinkResponse> CreateProductLinkAsync(CreateProductLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateProductLinkResponse> CreateProductLinkAsync(CreateProductLinkRequest request, st::CancellationToken cancellationToken) =>
            CreateProductLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the product link is created.
        /// </param>
        /// <param name="productLink">
        /// Required. The product link to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateProductLinkResponse CreateProductLink(string customerId, gagvr::ProductLink productLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductLink(new CreateProductLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ProductLink = gax::GaxPreconditions.CheckNotNull(productLink, nameof(productLink)),
            }, callSettings);

        /// <summary>
        /// Creates a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the product link is created.
        /// </param>
        /// <param name="productLink">
        /// Required. The product link to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateProductLinkResponse> CreateProductLinkAsync(string customerId, gagvr::ProductLink productLink, gaxgrpc::CallSettings callSettings = null) =>
            CreateProductLinkAsync(new CreateProductLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ProductLink = gax::GaxPreconditions.CheckNotNull(productLink, nameof(productLink)),
            }, callSettings);

        /// <summary>
        /// Creates a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which the product link is created.
        /// </param>
        /// <param name="productLink">
        /// Required. The product link to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateProductLinkResponse> CreateProductLinkAsync(string customerId, gagvr::ProductLink productLink, st::CancellationToken cancellationToken) =>
            CreateProductLinkAsync(customerId, productLink, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveProductLinkResponse RemoveProductLink(RemoveProductLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkResponse> RemoveProductLinkAsync(RemoveProductLinkRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkResponse> RemoveProductLinkAsync(RemoveProductLinkRequest request, st::CancellationToken cancellationToken) =>
            RemoveProductLinkAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="resourceName">
        /// Required. Remove operation: A resource name for the product link to remove
        /// is expected, in this format:
        /// 
        /// `customers/{customer_id}/productLinks/{product_link_id} `
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveProductLinkResponse RemoveProductLink(string customerId, string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductLink(new RemoveProductLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="resourceName">
        /// Required. Remove operation: A resource name for the product link to remove
        /// is expected, in this format:
        /// 
        /// `customers/{customer_id}/productLinks/{product_link_id} `
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkResponse> RemoveProductLinkAsync(string customerId, string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductLinkAsync(new RemoveProductLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="resourceName">
        /// Required. Remove operation: A resource name for the product link to remove
        /// is expected, in this format:
        /// 
        /// `customers/{customer_id}/productLinks/{product_link_id} `
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkResponse> RemoveProductLinkAsync(string customerId, string resourceName, st::CancellationToken cancellationToken) =>
            RemoveProductLinkAsync(customerId, resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="resourceName">
        /// Required. Remove operation: A resource name for the product link to remove
        /// is expected, in this format:
        /// 
        /// `customers/{customer_id}/productLinks/{product_link_id} `
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveProductLinkResponse RemoveProductLink(string customerId, gagvr::ProductLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductLink(new RemoveProductLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceNameAsProductLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="resourceName">
        /// Required. Remove operation: A resource name for the product link to remove
        /// is expected, in this format:
        /// 
        /// `customers/{customer_id}/productLinks/{product_link_id} `
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkResponse> RemoveProductLinkAsync(string customerId, gagvr::ProductLinkName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RemoveProductLinkAsync(new RemoveProductLinkRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ResourceNameAsProductLinkName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer being modified.
        /// </param>
        /// <param name="resourceName">
        /// Required. Remove operation: A resource name for the product link to remove
        /// is expected, in this format:
        /// 
        /// `customers/{customer_id}/productLinks/{product_link_id} `
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveProductLinkResponse> RemoveProductLinkAsync(string customerId, gagvr::ProductLinkName resourceName, st::CancellationToken cancellationToken) =>
            RemoveProductLinkAsync(customerId, resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProductLinkService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service allows management of links between  a Google
    /// Ads customer and another product.
    /// </remarks>
    public sealed partial class ProductLinkServiceClientImpl : ProductLinkServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateProductLinkRequest, CreateProductLinkResponse> _callCreateProductLink;

        private readonly gaxgrpc::ApiCall<RemoveProductLinkRequest, RemoveProductLinkResponse> _callRemoveProductLink;

        /// <summary>
        /// Constructs a client wrapper for the ProductLinkService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ProductLinkServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ProductLinkServiceClientImpl(ProductLinkService.ProductLinkServiceClient grpcClient, ProductLinkServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ProductLinkServiceSettings effectiveSettings = settings ?? ProductLinkServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callCreateProductLink = clientHelper.BuildApiCall<CreateProductLinkRequest, CreateProductLinkResponse>("CreateProductLink", grpcClient.CreateProductLinkAsync, grpcClient.CreateProductLink, effectiveSettings.CreateProductLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callCreateProductLink);
            Modify_CreateProductLinkApiCall(ref _callCreateProductLink);
            _callRemoveProductLink = clientHelper.BuildApiCall<RemoveProductLinkRequest, RemoveProductLinkResponse>("RemoveProductLink", grpcClient.RemoveProductLinkAsync, grpcClient.RemoveProductLink, effectiveSettings.RemoveProductLinkSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callRemoveProductLink);
            Modify_RemoveProductLinkApiCall(ref _callRemoveProductLink);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateProductLinkApiCall(ref gaxgrpc::ApiCall<CreateProductLinkRequest, CreateProductLinkResponse> call);

        partial void Modify_RemoveProductLinkApiCall(ref gaxgrpc::ApiCall<RemoveProductLinkRequest, RemoveProductLinkResponse> call);

        partial void OnConstruction(ProductLinkService.ProductLinkServiceClient grpcClient, ProductLinkServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProductLinkService client</summary>
        public override ProductLinkService.ProductLinkServiceClient GrpcClient { get; }

        partial void Modify_CreateProductLinkRequest(ref CreateProductLinkRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RemoveProductLinkRequest(ref RemoveProductLinkRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreateProductLinkResponse CreateProductLink(CreateProductLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductLinkRequest(ref request, ref callSettings);
            return _callCreateProductLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreateProductLinkResponse> CreateProductLinkAsync(CreateProductLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateProductLinkRequest(ref request, ref callSettings);
            return _callCreateProductLink.Async(request, callSettings);
        }

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveProductLinkResponse RemoveProductLink(RemoveProductLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveProductLinkRequest(ref request, ref callSettings);
            return _callRemoveProductLink.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes a product link.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveProductLinkResponse> RemoveProductLinkAsync(RemoveProductLinkRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveProductLinkRequest(ref request, ref callSettings);
            return _callRemoveProductLink.Async(request, callSettings);
        }
    }
}

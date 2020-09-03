// Copyright 2020 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V3.Resources;
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

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>Settings for <see cref="ProductBiddingCategoryConstantServiceClient"/> instances.</summary>
    public sealed partial class ProductBiddingCategoryConstantServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ProductBiddingCategoryConstantServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="ProductBiddingCategoryConstantServiceSettings"/>.
        /// </returns>
        public static ProductBiddingCategoryConstantServiceSettings GetDefault() =>
            new ProductBiddingCategoryConstantServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ProductBiddingCategoryConstantServiceSettings"/> object with default settings.
        /// </summary>
        public ProductBiddingCategoryConstantServiceSettings()
        {
        }

        private ProductBiddingCategoryConstantServiceSettings(ProductBiddingCategoryConstantServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProductBiddingCategoryConstantSettings = existing.GetProductBiddingCategoryConstantSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProductBiddingCategoryConstantServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductBiddingCategoryConstantServiceClient.GetProductBiddingCategoryConstant</c> and
        /// <c>ProductBiddingCategoryConstantServiceClient.GetProductBiddingCategoryConstantAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProductBiddingCategoryConstantSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProductBiddingCategoryConstantServiceSettings"/> object.</returns>
        public ProductBiddingCategoryConstantServiceSettings Clone() =>
            new ProductBiddingCategoryConstantServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProductBiddingCategoryConstantServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class ProductBiddingCategoryConstantServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProductBiddingCategoryConstantServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProductBiddingCategoryConstantServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ProductBiddingCategoryConstantServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProductBiddingCategoryConstantServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProductBiddingCategoryConstantServiceClient Build()
        {
            ProductBiddingCategoryConstantServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProductBiddingCategoryConstantServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProductBiddingCategoryConstantServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProductBiddingCategoryConstantServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProductBiddingCategoryConstantServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ProductBiddingCategoryConstantServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProductBiddingCategoryConstantServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ProductBiddingCategoryConstantServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            ProductBiddingCategoryConstantServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProductBiddingCategoryConstantServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ProductBiddingCategoryConstantService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Product Bidding Categories.
    /// </remarks>
    public abstract partial class ProductBiddingCategoryConstantServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProductBiddingCategoryConstantService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ProductBiddingCategoryConstantService scopes.</summary>
        /// <remarks>The default ProductBiddingCategoryConstantService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductBiddingCategoryConstantServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ProductBiddingCategoryConstantServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="ProductBiddingCategoryConstantServiceClient"/>.
        /// </returns>
        public static stt::Task<ProductBiddingCategoryConstantServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProductBiddingCategoryConstantServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProductBiddingCategoryConstantServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ProductBiddingCategoryConstantServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProductBiddingCategoryConstantServiceClient"/>.</returns>
        public static ProductBiddingCategoryConstantServiceClient Create() =>
            new ProductBiddingCategoryConstantServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProductBiddingCategoryConstantServiceClient"/> which uses the specified call invoker
        /// for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProductBiddingCategoryConstantServiceSettings"/>.</param>
        /// <returns>The created <see cref="ProductBiddingCategoryConstantServiceClient"/>.</returns>
        internal static ProductBiddingCategoryConstantServiceClient Create(grpccore::CallInvoker callInvoker, ProductBiddingCategoryConstantServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient grpcClient = new ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient(callInvoker);
            return new ProductBiddingCategoryConstantServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ProductBiddingCategoryConstantService client</summary>
        public virtual ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ProductBiddingCategoryConstant GetProductBiddingCategoryConstant(GetProductBiddingCategoryConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductBiddingCategoryConstant> GetProductBiddingCategoryConstantAsync(GetProductBiddingCategoryConstantRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductBiddingCategoryConstant> GetProductBiddingCategoryConstantAsync(GetProductBiddingCategoryConstantRequest request, st::CancellationToken cancellationToken) =>
            GetProductBiddingCategoryConstantAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Product Bidding Category to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ProductBiddingCategoryConstant GetProductBiddingCategoryConstant(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetProductBiddingCategoryConstant(new GetProductBiddingCategoryConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Product Bidding Category to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductBiddingCategoryConstant> GetProductBiddingCategoryConstantAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetProductBiddingCategoryConstantAsync(new GetProductBiddingCategoryConstantRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Product Bidding Category to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductBiddingCategoryConstant> GetProductBiddingCategoryConstantAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetProductBiddingCategoryConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Product Bidding Category to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ProductBiddingCategoryConstant GetProductBiddingCategoryConstant(gagvr::ProductBiddingCategoryConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetProductBiddingCategoryConstant(new GetProductBiddingCategoryConstantRequest
            {
                ResourceNameAsProductBiddingCategoryConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Product Bidding Category to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductBiddingCategoryConstant> GetProductBiddingCategoryConstantAsync(gagvr::ProductBiddingCategoryConstantName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetProductBiddingCategoryConstantAsync(new GetProductBiddingCategoryConstantRequest
            {
                ResourceNameAsProductBiddingCategoryConstantName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the Product Bidding Category to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductBiddingCategoryConstant> GetProductBiddingCategoryConstantAsync(gagvr::ProductBiddingCategoryConstantName resourceName, st::CancellationToken cancellationToken) =>
            GetProductBiddingCategoryConstantAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProductBiddingCategoryConstantService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Product Bidding Categories.
    /// </remarks>
    public sealed partial class ProductBiddingCategoryConstantServiceClientImpl : ProductBiddingCategoryConstantServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetProductBiddingCategoryConstantRequest, gagvr::ProductBiddingCategoryConstant> _callGetProductBiddingCategoryConstant;

        /// <summary>
        /// Constructs a client wrapper for the ProductBiddingCategoryConstantService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ProductBiddingCategoryConstantServiceSettings"/> used within this client.
        /// </param>
        public ProductBiddingCategoryConstantServiceClientImpl(ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient grpcClient, ProductBiddingCategoryConstantServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ProductBiddingCategoryConstantServiceSettings effectiveSettings = settings ?? ProductBiddingCategoryConstantServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetProductBiddingCategoryConstant = clientHelper.BuildApiCall<GetProductBiddingCategoryConstantRequest, gagvr::ProductBiddingCategoryConstant>(grpcClient.GetProductBiddingCategoryConstantAsync, grpcClient.GetProductBiddingCategoryConstant, effectiveSettings.GetProductBiddingCategoryConstantSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetProductBiddingCategoryConstant);
            Modify_GetProductBiddingCategoryConstantApiCall(ref _callGetProductBiddingCategoryConstant);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProductBiddingCategoryConstantApiCall(ref gaxgrpc::ApiCall<GetProductBiddingCategoryConstantRequest, gagvr::ProductBiddingCategoryConstant> call);

        partial void OnConstruction(ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient grpcClient, ProductBiddingCategoryConstantServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProductBiddingCategoryConstantService client</summary>
        public override ProductBiddingCategoryConstantService.ProductBiddingCategoryConstantServiceClient GrpcClient { get; }

        partial void Modify_GetProductBiddingCategoryConstantRequest(ref GetProductBiddingCategoryConstantRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::ProductBiddingCategoryConstant GetProductBiddingCategoryConstant(GetProductBiddingCategoryConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductBiddingCategoryConstantRequest(ref request, ref callSettings);
            return _callGetProductBiddingCategoryConstant.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested Product Bidding Category in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::ProductBiddingCategoryConstant> GetProductBiddingCategoryConstantAsync(GetProductBiddingCategoryConstantRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductBiddingCategoryConstantRequest(ref request, ref callSettings);
            return _callGetProductBiddingCategoryConstant.Async(request, callSettings);
        }
    }
}

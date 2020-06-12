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

using gagvr = Google.Ads.GoogleAds.V2.Resources;
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

namespace Google.Ads.GoogleAds.V2.Services
{
    /// <summary>Settings for <see cref="ProductGroupViewServiceClient"/> instances.</summary>
    public sealed partial class ProductGroupViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ProductGroupViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ProductGroupViewServiceSettings"/>.</returns>
        public static ProductGroupViewServiceSettings GetDefault() => new ProductGroupViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ProductGroupViewServiceSettings"/> object with default settings.
        /// </summary>
        public ProductGroupViewServiceSettings()
        {
        }

        private ProductGroupViewServiceSettings(ProductGroupViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetProductGroupViewSettings = existing.GetProductGroupViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ProductGroupViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ProductGroupViewServiceClient.GetProductGroupView</c> and
        /// <c>ProductGroupViewServiceClient.GetProductGroupViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetProductGroupViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ProductGroupViewServiceSettings"/> object.</returns>
        public ProductGroupViewServiceSettings Clone() => new ProductGroupViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ProductGroupViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ProductGroupViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<ProductGroupViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ProductGroupViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ProductGroupViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ProductGroupViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ProductGroupViewServiceClient Build()
        {
            ProductGroupViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ProductGroupViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ProductGroupViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ProductGroupViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ProductGroupViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ProductGroupViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ProductGroupViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ProductGroupViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ProductGroupViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ProductGroupViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ProductGroupViewService client wrapper, for convenient use.</summary>
    public abstract partial class ProductGroupViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the ProductGroupViewService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ProductGroupViewService scopes.</summary>
        /// <remarks>The default ProductGroupViewService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ProductGroupViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ProductGroupViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ProductGroupViewServiceClient"/>.</returns>
        public static stt::Task<ProductGroupViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ProductGroupViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ProductGroupViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ProductGroupViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ProductGroupViewServiceClient"/>.</returns>
        public static ProductGroupViewServiceClient Create() => new ProductGroupViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ProductGroupViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ProductGroupViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="ProductGroupViewServiceClient"/>.</returns>
        internal static ProductGroupViewServiceClient Create(grpccore::CallInvoker callInvoker, ProductGroupViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ProductGroupViewService.ProductGroupViewServiceClient grpcClient = new ProductGroupViewService.ProductGroupViewServiceClient(callInvoker);
            return new ProductGroupViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ProductGroupViewService client</summary>
        public virtual ProductGroupViewService.ProductGroupViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ProductGroupView GetProductGroupView(GetProductGroupViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductGroupView> GetProductGroupViewAsync(GetProductGroupViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductGroupView> GetProductGroupViewAsync(GetProductGroupViewRequest request, st::CancellationToken cancellationToken) =>
            GetProductGroupViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the product group view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ProductGroupView GetProductGroupView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetProductGroupView(new GetProductGroupViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the product group view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductGroupView> GetProductGroupViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetProductGroupViewAsync(new GetProductGroupViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the product group view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductGroupView> GetProductGroupViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetProductGroupViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the product group view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ProductGroupView GetProductGroupView(gagvr::ProductGroupViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetProductGroupView(new GetProductGroupViewRequest
            {
                ResourceNameAsProductGroupViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the product group view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductGroupView> GetProductGroupViewAsync(gagvr::ProductGroupViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetProductGroupViewAsync(new GetProductGroupViewRequest
            {
                ResourceNameAsProductGroupViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the product group view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ProductGroupView> GetProductGroupViewAsync(gagvr::ProductGroupViewName resourceName, st::CancellationToken cancellationToken) =>
            GetProductGroupViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ProductGroupViewService client wrapper implementation, for convenient use.</summary>
    public sealed partial class ProductGroupViewServiceClientImpl : ProductGroupViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetProductGroupViewRequest, gagvr::ProductGroupView> _callGetProductGroupView;

        /// <summary>
        /// Constructs a client wrapper for the ProductGroupViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ProductGroupViewServiceSettings"/> used within this client.
        /// </param>
        public ProductGroupViewServiceClientImpl(ProductGroupViewService.ProductGroupViewServiceClient grpcClient, ProductGroupViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ProductGroupViewServiceSettings effectiveSettings = settings ?? ProductGroupViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetProductGroupView = clientHelper.BuildApiCall<GetProductGroupViewRequest, gagvr::ProductGroupView>(grpcClient.GetProductGroupViewAsync, grpcClient.GetProductGroupView, effectiveSettings.GetProductGroupViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetProductGroupView);
            Modify_GetProductGroupViewApiCall(ref _callGetProductGroupView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetProductGroupViewApiCall(ref gaxgrpc::ApiCall<GetProductGroupViewRequest, gagvr::ProductGroupView> call);

        partial void OnConstruction(ProductGroupViewService.ProductGroupViewServiceClient grpcClient, ProductGroupViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ProductGroupViewService client</summary>
        public override ProductGroupViewService.ProductGroupViewServiceClient GrpcClient { get; }

        partial void Modify_GetProductGroupViewRequest(ref GetProductGroupViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::ProductGroupView GetProductGroupView(GetProductGroupViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductGroupViewRequest(ref request, ref callSettings);
            return _callGetProductGroupView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested product group view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::ProductGroupView> GetProductGroupViewAsync(GetProductGroupViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetProductGroupViewRequest(ref request, ref callSettings);
            return _callGetProductGroupView.Async(request, callSettings);
        }
    }
}

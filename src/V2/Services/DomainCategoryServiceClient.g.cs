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
    /// <summary>Settings for <see cref="DomainCategoryServiceClient"/> instances.</summary>
    public sealed partial class DomainCategoryServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="DomainCategoryServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="DomainCategoryServiceSettings"/>.</returns>
        public static DomainCategoryServiceSettings GetDefault() => new DomainCategoryServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="DomainCategoryServiceSettings"/> object with default settings.
        /// </summary>
        public DomainCategoryServiceSettings()
        {
        }

        private DomainCategoryServiceSettings(DomainCategoryServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetDomainCategorySettings = existing.GetDomainCategorySettings;
            OnCopy(existing);
        }

        partial void OnCopy(DomainCategoryServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>DomainCategoryServiceClient.GetDomainCategory</c> and
        /// <c>DomainCategoryServiceClient.GetDomainCategoryAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetDomainCategorySettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="DomainCategoryServiceSettings"/> object.</returns>
        public DomainCategoryServiceSettings Clone() => new DomainCategoryServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="DomainCategoryServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class DomainCategoryServiceClientBuilder : gaxgrpc::ClientBuilderBase<DomainCategoryServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public DomainCategoryServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref DomainCategoryServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<DomainCategoryServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override DomainCategoryServiceClient Build()
        {
            DomainCategoryServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<DomainCategoryServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<DomainCategoryServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private DomainCategoryServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return DomainCategoryServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<DomainCategoryServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return DomainCategoryServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => DomainCategoryServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => DomainCategoryServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => DomainCategoryServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>DomainCategoryService client wrapper, for convenient use.</summary>
    public abstract partial class DomainCategoryServiceClient
    {
        /// <summary>
        /// The default endpoint for the DomainCategoryService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default DomainCategoryService scopes.</summary>
        /// <remarks>The default DomainCategoryService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="DomainCategoryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DomainCategoryServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="DomainCategoryServiceClient"/>.</returns>
        public static stt::Task<DomainCategoryServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new DomainCategoryServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="DomainCategoryServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="DomainCategoryServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="DomainCategoryServiceClient"/>.</returns>
        public static DomainCategoryServiceClient Create() => new DomainCategoryServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="DomainCategoryServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="DomainCategoryServiceSettings"/>.</param>
        /// <returns>The created <see cref="DomainCategoryServiceClient"/>.</returns>
        internal static DomainCategoryServiceClient Create(grpccore::CallInvoker callInvoker, DomainCategoryServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            DomainCategoryService.DomainCategoryServiceClient grpcClient = new DomainCategoryService.DomainCategoryServiceClient(callInvoker);
            return new DomainCategoryServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC DomainCategoryService client</summary>
        public virtual DomainCategoryService.DomainCategoryServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DomainCategory GetDomainCategory(GetDomainCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DomainCategory> GetDomainCategoryAsync(GetDomainCategoryRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DomainCategory> GetDomainCategoryAsync(GetDomainCategoryRequest request, st::CancellationToken cancellationToken) =>
            GetDomainCategoryAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the domain category to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DomainCategory GetDomainCategory(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDomainCategory(new GetDomainCategoryRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the domain category to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DomainCategory> GetDomainCategoryAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDomainCategoryAsync(new GetDomainCategoryRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the domain category to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DomainCategory> GetDomainCategoryAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetDomainCategoryAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the domain category to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::DomainCategory GetDomainCategory(gagvr::DomainCategoryName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDomainCategory(new GetDomainCategoryRequest
            {
                ResourceNameAsDomainCategoryName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the domain category to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DomainCategory> GetDomainCategoryAsync(gagvr::DomainCategoryName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetDomainCategoryAsync(new GetDomainCategoryRequest
            {
                ResourceNameAsDomainCategoryName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the domain category to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::DomainCategory> GetDomainCategoryAsync(gagvr::DomainCategoryName resourceName, st::CancellationToken cancellationToken) =>
            GetDomainCategoryAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>DomainCategoryService client wrapper implementation, for convenient use.</summary>
    public sealed partial class DomainCategoryServiceClientImpl : DomainCategoryServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetDomainCategoryRequest, gagvr::DomainCategory> _callGetDomainCategory;

        /// <summary>
        /// Constructs a client wrapper for the DomainCategoryService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="DomainCategoryServiceSettings"/> used within this client.</param>
        public DomainCategoryServiceClientImpl(DomainCategoryService.DomainCategoryServiceClient grpcClient, DomainCategoryServiceSettings settings)
        {
            GrpcClient = grpcClient;
            DomainCategoryServiceSettings effectiveSettings = settings ?? DomainCategoryServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetDomainCategory = clientHelper.BuildApiCall<GetDomainCategoryRequest, gagvr::DomainCategory>(grpcClient.GetDomainCategoryAsync, grpcClient.GetDomainCategory, effectiveSettings.GetDomainCategorySettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetDomainCategory);
            Modify_GetDomainCategoryApiCall(ref _callGetDomainCategory);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetDomainCategoryApiCall(ref gaxgrpc::ApiCall<GetDomainCategoryRequest, gagvr::DomainCategory> call);

        partial void OnConstruction(DomainCategoryService.DomainCategoryServiceClient grpcClient, DomainCategoryServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC DomainCategoryService client</summary>
        public override DomainCategoryService.DomainCategoryServiceClient GrpcClient { get; }

        partial void Modify_GetDomainCategoryRequest(ref GetDomainCategoryRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::DomainCategory GetDomainCategory(GetDomainCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDomainCategoryRequest(ref request, ref callSettings);
            return _callGetDomainCategory.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested domain category.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::DomainCategory> GetDomainCategoryAsync(GetDomainCategoryRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetDomainCategoryRequest(ref request, ref callSettings);
            return _callGetDomainCategory.Async(request, callSettings);
        }
    }
}

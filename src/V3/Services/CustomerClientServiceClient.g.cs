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
    /// <summary>Settings for <see cref="CustomerClientServiceClient"/> instances.</summary>
    public sealed partial class CustomerClientServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerClientServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerClientServiceSettings"/>.</returns>
        public static CustomerClientServiceSettings GetDefault() => new CustomerClientServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerClientServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerClientServiceSettings()
        {
        }

        private CustomerClientServiceSettings(CustomerClientServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerClientSettings = existing.GetCustomerClientSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerClientServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerClientServiceClient.GetCustomerClient</c> and
        /// <c>CustomerClientServiceClient.GetCustomerClientAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomerClientSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerClientServiceSettings"/> object.</returns>
        public CustomerClientServiceSettings Clone() => new CustomerClientServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerClientServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class CustomerClientServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerClientServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerClientServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CustomerClientServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerClientServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerClientServiceClient Build()
        {
            CustomerClientServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerClientServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerClientServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerClientServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerClientServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CustomerClientServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerClientServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CustomerClientServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CustomerClientServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerClientServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CustomerClientService client wrapper, for convenient use.</summary>
    public abstract partial class CustomerClientServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerClientService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerClientService scopes.</summary>
        /// <remarks>The default CustomerClientService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerClientServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerClientServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerClientServiceClient"/>.</returns>
        public static stt::Task<CustomerClientServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerClientServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerClientServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerClientServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerClientServiceClient"/>.</returns>
        public static CustomerClientServiceClient Create() => new CustomerClientServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerClientServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerClientServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerClientServiceClient"/>.</returns>
        internal static CustomerClientServiceClient Create(grpccore::CallInvoker callInvoker, CustomerClientServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerClientService.CustomerClientServiceClient grpcClient = new CustomerClientService.CustomerClientServiceClient(callInvoker);
            return new CustomerClientServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CustomerClientService client</summary>
        public virtual CustomerClientService.CustomerClientServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerClient GetCustomerClient(GetCustomerClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerClient> GetCustomerClientAsync(GetCustomerClientRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerClient> GetCustomerClientAsync(GetCustomerClientRequest request, st::CancellationToken cancellationToken) =>
            GetCustomerClientAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the client to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerClient GetCustomerClient(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerClient(new GetCustomerClientRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the client to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerClient> GetCustomerClientAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerClientAsync(new GetCustomerClientRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the client to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerClient> GetCustomerClientAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerClientAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the client to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerClient GetCustomerClient(gagvr::CustomerClientName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerClient(new GetCustomerClientRequest
            {
                ResourceNameAsCustomerClientName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the client to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerClient> GetCustomerClientAsync(gagvr::CustomerClientName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerClientAsync(new GetCustomerClientRequest
            {
                ResourceNameAsCustomerClientName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the client to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerClient> GetCustomerClientAsync(gagvr::CustomerClientName resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerClientAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerClientService client wrapper implementation, for convenient use.</summary>
    public sealed partial class CustomerClientServiceClientImpl : CustomerClientServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerClientRequest, gagvr::CustomerClient> _callGetCustomerClient;

        /// <summary>
        /// Constructs a client wrapper for the CustomerClientService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomerClientServiceSettings"/> used within this client.</param>
        public CustomerClientServiceClientImpl(CustomerClientService.CustomerClientServiceClient grpcClient, CustomerClientServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerClientServiceSettings effectiveSettings = settings ?? CustomerClientServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomerClient = clientHelper.BuildApiCall<GetCustomerClientRequest, gagvr::CustomerClient>(grpcClient.GetCustomerClientAsync, grpcClient.GetCustomerClient, effectiveSettings.GetCustomerClientSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCustomerClient);
            Modify_GetCustomerClientApiCall(ref _callGetCustomerClient);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomerClientApiCall(ref gaxgrpc::ApiCall<GetCustomerClientRequest, gagvr::CustomerClient> call);

        partial void OnConstruction(CustomerClientService.CustomerClientServiceClient grpcClient, CustomerClientServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerClientService client</summary>
        public override CustomerClientService.CustomerClientServiceClient GrpcClient { get; }

        partial void Modify_GetCustomerClientRequest(ref GetCustomerClientRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CustomerClient GetCustomerClient(GetCustomerClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerClientRequest(ref request, ref callSettings);
            return _callGetCustomerClient.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested client in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CustomerClient> GetCustomerClientAsync(GetCustomerClientRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerClientRequest(ref request, ref callSettings);
            return _callGetCustomerClient.Async(request, callSettings);
        }
    }
}

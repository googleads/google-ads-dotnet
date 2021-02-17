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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
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

namespace Google.Ads.GoogleAds.V5.Services
{
    /// <summary>Settings for <see cref="UserLocationViewServiceClient"/> instances.</summary>
    public sealed partial class UserLocationViewServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserLocationViewServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserLocationViewServiceSettings"/>.</returns>
        public static UserLocationViewServiceSettings GetDefault() => new UserLocationViewServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="UserLocationViewServiceSettings"/> object with default settings.
        /// </summary>
        public UserLocationViewServiceSettings()
        {
        }

        private UserLocationViewServiceSettings(UserLocationViewServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetUserLocationViewSettings = existing.GetUserLocationViewSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserLocationViewServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserLocationViewServiceClient.GetUserLocationView</c> and
        /// <c>UserLocationViewServiceClient.GetUserLocationViewAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserLocationViewSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserLocationViewServiceSettings"/> object.</returns>
        public UserLocationViewServiceSettings Clone() => new UserLocationViewServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserLocationViewServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class UserLocationViewServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserLocationViewServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserLocationViewServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref UserLocationViewServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserLocationViewServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserLocationViewServiceClient Build()
        {
            UserLocationViewServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserLocationViewServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserLocationViewServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserLocationViewServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserLocationViewServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<UserLocationViewServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserLocationViewServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => UserLocationViewServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => UserLocationViewServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserLocationViewServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>UserLocationViewService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage user location views.
    /// </remarks>
    public abstract partial class UserLocationViewServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserLocationViewService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default UserLocationViewService scopes.</summary>
        /// <remarks>
        /// The default UserLocationViewService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="UserLocationViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="UserLocationViewServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserLocationViewServiceClient"/>.</returns>
        public static stt::Task<UserLocationViewServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserLocationViewServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserLocationViewServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="UserLocationViewServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserLocationViewServiceClient"/>.</returns>
        public static UserLocationViewServiceClient Create() => new UserLocationViewServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserLocationViewServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserLocationViewServiceSettings"/>.</param>
        /// <returns>The created <see cref="UserLocationViewServiceClient"/>.</returns>
        internal static UserLocationViewServiceClient Create(grpccore::CallInvoker callInvoker, UserLocationViewServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserLocationViewService.UserLocationViewServiceClient grpcClient = new UserLocationViewService.UserLocationViewServiceClient(callInvoker);
            return new UserLocationViewServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC UserLocationViewService client</summary>
        public virtual UserLocationViewService.UserLocationViewServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::UserLocationView GetUserLocationView(GetUserLocationViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserLocationView> GetUserLocationViewAsync(GetUserLocationViewRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserLocationView> GetUserLocationViewAsync(GetUserLocationViewRequest request, st::CancellationToken cancellationToken) =>
            GetUserLocationViewAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user location view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::UserLocationView GetUserLocationView(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserLocationView(new GetUserLocationViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user location view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserLocationView> GetUserLocationViewAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserLocationViewAsync(new GetUserLocationViewRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user location view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserLocationView> GetUserLocationViewAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetUserLocationViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user location view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::UserLocationView GetUserLocationView(gagvr::UserLocationViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserLocationView(new GetUserLocationViewRequest
            {
                ResourceNameAsUserLocationViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user location view to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserLocationView> GetUserLocationViewAsync(gagvr::UserLocationViewName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserLocationViewAsync(new GetUserLocationViewRequest
            {
                ResourceNameAsUserLocationViewName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user location view to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserLocationView> GetUserLocationViewAsync(gagvr::UserLocationViewName resourceName, st::CancellationToken cancellationToken) =>
            GetUserLocationViewAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserLocationViewService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage user location views.
    /// </remarks>
    public sealed partial class UserLocationViewServiceClientImpl : UserLocationViewServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetUserLocationViewRequest, gagvr::UserLocationView> _callGetUserLocationView;

        /// <summary>
        /// Constructs a client wrapper for the UserLocationViewService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="UserLocationViewServiceSettings"/> used within this client.
        /// </param>
        public UserLocationViewServiceClientImpl(UserLocationViewService.UserLocationViewServiceClient grpcClient, UserLocationViewServiceSettings settings)
        {
            GrpcClient = grpcClient;
            UserLocationViewServiceSettings effectiveSettings = settings ?? UserLocationViewServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetUserLocationView = clientHelper.BuildApiCall<GetUserLocationViewRequest, gagvr::UserLocationView>(grpcClient.GetUserLocationViewAsync, grpcClient.GetUserLocationView, effectiveSettings.GetUserLocationViewSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetUserLocationView);
            Modify_GetUserLocationViewApiCall(ref _callGetUserLocationView);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetUserLocationViewApiCall(ref gaxgrpc::ApiCall<GetUserLocationViewRequest, gagvr::UserLocationView> call);

        partial void OnConstruction(UserLocationViewService.UserLocationViewServiceClient grpcClient, UserLocationViewServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserLocationViewService client</summary>
        public override UserLocationViewService.UserLocationViewServiceClient GrpcClient { get; }

        partial void Modify_GetUserLocationViewRequest(ref GetUserLocationViewRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::UserLocationView GetUserLocationView(GetUserLocationViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserLocationViewRequest(ref request, ref callSettings);
            return _callGetUserLocationView.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested user location view in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::UserLocationView> GetUserLocationViewAsync(GetUserLocationViewRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserLocationViewRequest(ref request, ref callSettings);
            return _callGetUserLocationView.Async(request, callSettings);
        }
    }
}

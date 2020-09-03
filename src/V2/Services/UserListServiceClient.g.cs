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
    /// <summary>Settings for <see cref="UserListServiceClient"/> instances.</summary>
    public sealed partial class UserListServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserListServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserListServiceSettings"/>.</returns>
        public static UserListServiceSettings GetDefault() => new UserListServiceSettings();

        /// <summary>Constructs a new <see cref="UserListServiceSettings"/> object with default settings.</summary>
        public UserListServiceSettings()
        {
        }

        private UserListServiceSettings(UserListServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetUserListSettings = existing.GetUserListSettings;
            MutateUserListsSettings = existing.MutateUserListsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserListServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListServiceClient.GetUserList</c> and <c>UserListServiceClient.GetUserListAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserListSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListServiceClient.MutateUserLists</c> and <c>UserListServiceClient.MutateUserListsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateUserListsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserListServiceSettings"/> object.</returns>
        public UserListServiceSettings Clone() => new UserListServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserListServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class UserListServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserListServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserListServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref UserListServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserListServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserListServiceClient Build()
        {
            UserListServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserListServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserListServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserListServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserListServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<UserListServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserListServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => UserListServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => UserListServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserListServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>UserListService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage user lists.
    /// </remarks>
    public abstract partial class UserListServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserListService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default UserListService scopes.</summary>
        /// <remarks>The default UserListService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="UserListServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserListServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserListServiceClient"/>.</returns>
        public static stt::Task<UserListServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserListServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserListServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserListServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserListServiceClient"/>.</returns>
        public static UserListServiceClient Create() => new UserListServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserListServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserListServiceSettings"/>.</param>
        /// <returns>The created <see cref="UserListServiceClient"/>.</returns>
        internal static UserListServiceClient Create(grpccore::CallInvoker callInvoker, UserListServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserListService.UserListServiceClient grpcClient = new UserListService.UserListServiceClient(callInvoker);
            return new UserListServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC UserListService client</summary>
        public virtual UserListService.UserListServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::UserList GetUserList(GetUserListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserList> GetUserListAsync(GetUserListRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserList> GetUserListAsync(GetUserListRequest request, st::CancellationToken cancellationToken) =>
            GetUserListAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user list to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::UserList GetUserList(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserList(new GetUserListRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user list to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserList> GetUserListAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListAsync(new GetUserListRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user list to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserList> GetUserListAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetUserListAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user list to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::UserList GetUserList(gagvr::UserListName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserList(new GetUserListRequest
            {
                ResourceNameAsUserListName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user list to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserList> GetUserListAsync(gagvr::UserListName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserListAsync(new GetUserListRequest
            {
                ResourceNameAsUserListName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the user list to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserList> GetUserListAsync(gagvr::UserListName resourceName, st::CancellationToken cancellationToken) =>
            GetUserListAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates user lists. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateUserListsResponse MutateUserLists(MutateUserListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates user lists. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateUserListsResponse> MutateUserListsAsync(MutateUserListsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates user lists. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateUserListsResponse> MutateUserListsAsync(MutateUserListsRequest request, st::CancellationToken cancellationToken) =>
            MutateUserListsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates user lists. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose user lists are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual user lists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateUserListsResponse MutateUserLists(string customerId, scg::IEnumerable<UserListOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateUserLists(new MutateUserListsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates user lists. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose user lists are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual user lists.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateUserListsResponse> MutateUserListsAsync(string customerId, scg::IEnumerable<UserListOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateUserListsAsync(new MutateUserListsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates user lists. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose user lists are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual user lists.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateUserListsResponse> MutateUserListsAsync(string customerId, scg::IEnumerable<UserListOperation> operations, st::CancellationToken cancellationToken) =>
            MutateUserListsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserListService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage user lists.
    /// </remarks>
    public sealed partial class UserListServiceClientImpl : UserListServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetUserListRequest, gagvr::UserList> _callGetUserList;

        private readonly gaxgrpc::ApiCall<MutateUserListsRequest, MutateUserListsResponse> _callMutateUserLists;

        /// <summary>
        /// Constructs a client wrapper for the UserListService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserListServiceSettings"/> used within this client.</param>
        public UserListServiceClientImpl(UserListService.UserListServiceClient grpcClient, UserListServiceSettings settings)
        {
            GrpcClient = grpcClient;
            UserListServiceSettings effectiveSettings = settings ?? UserListServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetUserList = clientHelper.BuildApiCall<GetUserListRequest, gagvr::UserList>(grpcClient.GetUserListAsync, grpcClient.GetUserList, effectiveSettings.GetUserListSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetUserList);
            Modify_GetUserListApiCall(ref _callGetUserList);
            _callMutateUserLists = clientHelper.BuildApiCall<MutateUserListsRequest, MutateUserListsResponse>(grpcClient.MutateUserListsAsync, grpcClient.MutateUserLists, effectiveSettings.MutateUserListsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateUserLists);
            Modify_MutateUserListsApiCall(ref _callMutateUserLists);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetUserListApiCall(ref gaxgrpc::ApiCall<GetUserListRequest, gagvr::UserList> call);

        partial void Modify_MutateUserListsApiCall(ref gaxgrpc::ApiCall<MutateUserListsRequest, MutateUserListsResponse> call);

        partial void OnConstruction(UserListService.UserListServiceClient grpcClient, UserListServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserListService client</summary>
        public override UserListService.UserListServiceClient GrpcClient { get; }

        partial void Modify_GetUserListRequest(ref GetUserListRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateUserListsRequest(ref MutateUserListsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::UserList GetUserList(GetUserListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserListRequest(ref request, ref callSettings);
            return _callGetUserList.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested user list.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::UserList> GetUserListAsync(GetUserListRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserListRequest(ref request, ref callSettings);
            return _callGetUserList.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates user lists. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateUserListsResponse MutateUserLists(MutateUserListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateUserListsRequest(ref request, ref callSettings);
            return _callMutateUserLists.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates user lists. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateUserListsResponse> MutateUserListsAsync(MutateUserListsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateUserListsRequest(ref request, ref callSettings);
            return _callMutateUserLists.Async(request, callSettings);
        }
    }
}

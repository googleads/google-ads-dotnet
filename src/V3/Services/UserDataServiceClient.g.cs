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
    /// <summary>Settings for <see cref="UserDataServiceClient"/> instances.</summary>
    public sealed partial class UserDataServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserDataServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserDataServiceSettings"/>.</returns>
        public static UserDataServiceSettings GetDefault() => new UserDataServiceSettings();

        /// <summary>Constructs a new <see cref="UserDataServiceSettings"/> object with default settings.</summary>
        public UserDataServiceSettings()
        {
        }

        private UserDataServiceSettings(UserDataServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UploadUserDataSettings = existing.UploadUserDataSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserDataServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserDataServiceClient.UploadUserData</c> and <c>UserDataServiceClient.UploadUserDataAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UploadUserDataSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserDataServiceSettings"/> object.</returns>
        public UserDataServiceSettings Clone() => new UserDataServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserDataServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class UserDataServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserDataServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserDataServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref UserDataServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserDataServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserDataServiceClient Build()
        {
            UserDataServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserDataServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserDataServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserDataServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserDataServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<UserDataServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserDataServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => UserDataServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => UserDataServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserDataServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>UserDataService client wrapper, for convenient use.</summary>
    public abstract partial class UserDataServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserDataService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default UserDataService scopes.</summary>
        /// <remarks>The default UserDataService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="UserDataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserDataServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserDataServiceClient"/>.</returns>
        public static stt::Task<UserDataServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserDataServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserDataServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="UserDataServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserDataServiceClient"/>.</returns>
        public static UserDataServiceClient Create() => new UserDataServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserDataServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserDataServiceSettings"/>.</param>
        /// <returns>The created <see cref="UserDataServiceClient"/>.</returns>
        internal static UserDataServiceClient Create(grpccore::CallInvoker callInvoker, UserDataServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserDataService.UserDataServiceClient grpcClient = new UserDataService.UserDataServiceClient(callInvoker);
            return new UserDataServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC UserDataService client</summary>
        public virtual UserDataService.UserDataServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads the given user data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadUserDataResponse UploadUserData(UploadUserDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads the given user data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadUserDataResponse> UploadUserDataAsync(UploadUserDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads the given user data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadUserDataResponse> UploadUserDataAsync(UploadUserDataRequest request, st::CancellationToken cancellationToken) =>
            UploadUserDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserDataService client wrapper implementation, for convenient use.</summary>
    public sealed partial class UserDataServiceClientImpl : UserDataServiceClient
    {
        private readonly gaxgrpc::ApiCall<UploadUserDataRequest, UploadUserDataResponse> _callUploadUserData;

        /// <summary>
        /// Constructs a client wrapper for the UserDataService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserDataServiceSettings"/> used within this client.</param>
        public UserDataServiceClientImpl(UserDataService.UserDataServiceClient grpcClient, UserDataServiceSettings settings)
        {
            GrpcClient = grpcClient;
            UserDataServiceSettings effectiveSettings = settings ?? UserDataServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callUploadUserData = clientHelper.BuildApiCall<UploadUserDataRequest, UploadUserDataResponse>(grpcClient.UploadUserDataAsync, grpcClient.UploadUserData, effectiveSettings.UploadUserDataSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callUploadUserData);
            Modify_UploadUserDataApiCall(ref _callUploadUserData);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UploadUserDataApiCall(ref gaxgrpc::ApiCall<UploadUserDataRequest, UploadUserDataResponse> call);

        partial void OnConstruction(UserDataService.UserDataServiceClient grpcClient, UserDataServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserDataService client</summary>
        public override UserDataService.UserDataServiceClient GrpcClient { get; }

        partial void Modify_UploadUserDataRequest(ref UploadUserDataRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Uploads the given user data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UploadUserDataResponse UploadUserData(UploadUserDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadUserDataRequest(ref request, ref callSettings);
            return _callUploadUserData.Sync(request, callSettings);
        }

        /// <summary>
        /// Uploads the given user data.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UploadUserDataResponse> UploadUserDataAsync(UploadUserDataRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadUserDataRequest(ref request, ref callSettings);
            return _callUploadUserData.Async(request, callSettings);
        }
    }
}

// Copyright 2021 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V7.Resources;
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

namespace Google.Ads.GoogleAds.V7.Services
{
    /// <summary>Settings for <see cref="UserInterestServiceClient"/> instances.</summary>
    public sealed partial class UserInterestServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserInterestServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserInterestServiceSettings"/>.</returns>
        public static UserInterestServiceSettings GetDefault() => new UserInterestServiceSettings();

        /// <summary>Constructs a new <see cref="UserInterestServiceSettings"/> object with default settings.</summary>
        public UserInterestServiceSettings()
        {
        }

        private UserInterestServiceSettings(UserInterestServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetUserInterestSettings = existing.GetUserInterestSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserInterestServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserInterestServiceClient.GetUserInterest</c> and <c>UserInterestServiceClient.GetUserInterestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetUserInterestSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserInterestServiceSettings"/> object.</returns>
        public UserInterestServiceSettings Clone() => new UserInterestServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserInterestServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class UserInterestServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserInterestServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserInterestServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref UserInterestServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserInterestServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserInterestServiceClient Build()
        {
            UserInterestServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserInterestServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserInterestServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserInterestServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserInterestServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<UserInterestServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserInterestServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => UserInterestServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => UserInterestServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserInterestServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>UserInterestService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Google Ads User Interest.
    /// </remarks>
    public abstract partial class UserInterestServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserInterestService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default UserInterestService scopes.</summary>
        /// <remarks>
        /// The default UserInterestService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="UserInterestServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="UserInterestServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserInterestServiceClient"/>.</returns>
        public static stt::Task<UserInterestServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserInterestServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserInterestServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="UserInterestServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserInterestServiceClient"/>.</returns>
        public static UserInterestServiceClient Create() => new UserInterestServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserInterestServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserInterestServiceSettings"/>.</param>
        /// <returns>The created <see cref="UserInterestServiceClient"/>.</returns>
        internal static UserInterestServiceClient Create(grpccore::CallInvoker callInvoker, UserInterestServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserInterestService.UserInterestServiceClient grpcClient = new UserInterestService.UserInterestServiceClient(callInvoker);
            return new UserInterestServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC UserInterestService client</summary>
        public virtual UserInterestService.UserInterestServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested user interest in full detail
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
        public virtual gagvr::UserInterest GetUserInterest(GetUserInterestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested user interest in full detail
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
        public virtual stt::Task<gagvr::UserInterest> GetUserInterestAsync(GetUserInterestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested user interest in full detail
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
        public virtual stt::Task<gagvr::UserInterest> GetUserInterestAsync(GetUserInterestRequest request, st::CancellationToken cancellationToken) =>
            GetUserInterestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested user interest in full detail
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
        /// Required. Resource name of the UserInterest to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::UserInterest GetUserInterest(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserInterest(new GetUserInterestRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user interest in full detail
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
        /// Required. Resource name of the UserInterest to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserInterest> GetUserInterestAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserInterestAsync(new GetUserInterestRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user interest in full detail
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
        /// Required. Resource name of the UserInterest to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserInterest> GetUserInterestAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetUserInterestAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested user interest in full detail
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
        /// Required. Resource name of the UserInterest to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::UserInterest GetUserInterest(gagvr::UserInterestName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserInterest(new GetUserInterestRequest
            {
                ResourceNameAsUserInterestName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user interest in full detail
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
        /// Required. Resource name of the UserInterest to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserInterest> GetUserInterestAsync(gagvr::UserInterestName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetUserInterestAsync(new GetUserInterestRequest
            {
                ResourceNameAsUserInterestName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested user interest in full detail
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
        /// Required. Resource name of the UserInterest to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::UserInterest> GetUserInterestAsync(gagvr::UserInterestName resourceName, st::CancellationToken cancellationToken) =>
            GetUserInterestAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserInterestService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to fetch Google Ads User Interest.
    /// </remarks>
    public sealed partial class UserInterestServiceClientImpl : UserInterestServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetUserInterestRequest, gagvr::UserInterest> _callGetUserInterest;

        /// <summary>
        /// Constructs a client wrapper for the UserInterestService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserInterestServiceSettings"/> used within this client.</param>
        public UserInterestServiceClientImpl(UserInterestService.UserInterestServiceClient grpcClient, UserInterestServiceSettings settings)
        {
            GrpcClient = grpcClient;
            UserInterestServiceSettings effectiveSettings = settings ?? UserInterestServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetUserInterest = clientHelper.BuildApiCall<GetUserInterestRequest, gagvr::UserInterest>(grpcClient.GetUserInterestAsync, grpcClient.GetUserInterest, effectiveSettings.GetUserInterestSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetUserInterest);
            Modify_GetUserInterestApiCall(ref _callGetUserInterest);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetUserInterestApiCall(ref gaxgrpc::ApiCall<GetUserInterestRequest, gagvr::UserInterest> call);

        partial void OnConstruction(UserInterestService.UserInterestServiceClient grpcClient, UserInterestServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserInterestService client</summary>
        public override UserInterestService.UserInterestServiceClient GrpcClient { get; }

        partial void Modify_GetUserInterestRequest(ref GetUserInterestRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested user interest in full detail
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
        public override gagvr::UserInterest GetUserInterest(GetUserInterestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserInterestRequest(ref request, ref callSettings);
            return _callGetUserInterest.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested user interest in full detail
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
        public override stt::Task<gagvr::UserInterest> GetUserInterestAsync(GetUserInterestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetUserInterestRequest(ref request, ref callSettings);
            return _callGetUserInterest.Async(request, callSettings);
        }
    }
}

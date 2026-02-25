// Copyright 2026 Google LLC
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

namespace Google.Ads.GoogleAds.V20.Services
{
    /// <summary>Settings for <see cref="UserListCustomerTypeServiceClient"/> instances.</summary>
    public sealed partial class UserListCustomerTypeServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="UserListCustomerTypeServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="UserListCustomerTypeServiceSettings"/>.</returns>
        public static UserListCustomerTypeServiceSettings GetDefault() => new UserListCustomerTypeServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="UserListCustomerTypeServiceSettings"/> object with default settings.
        /// </summary>
        public UserListCustomerTypeServiceSettings()
        {
        }

        private UserListCustomerTypeServiceSettings(UserListCustomerTypeServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateUserListCustomerTypesSettings = existing.MutateUserListCustomerTypesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(UserListCustomerTypeServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>UserListCustomerTypeServiceClient.MutateUserListCustomerTypes</c> and
        /// <c>UserListCustomerTypeServiceClient.MutateUserListCustomerTypesAsync</c>.
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
        public gaxgrpc::CallSettings MutateUserListCustomerTypesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserListCustomerTypeServiceSettings"/> object.</returns>
        public UserListCustomerTypeServiceSettings Clone() => new UserListCustomerTypeServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserListCustomerTypeServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class UserListCustomerTypeServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserListCustomerTypeServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserListCustomerTypeServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UserListCustomerTypeServiceClientBuilder() : base(UserListCustomerTypeServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref UserListCustomerTypeServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<UserListCustomerTypeServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override UserListCustomerTypeServiceClient Build()
        {
            UserListCustomerTypeServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<UserListCustomerTypeServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<UserListCustomerTypeServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private UserListCustomerTypeServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return UserListCustomerTypeServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<UserListCustomerTypeServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserListCustomerTypeServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserListCustomerTypeServiceClient.ChannelPool;
    }

    /// <summary>UserListCustomerTypeService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage user list customer types.
    /// </remarks>
    public abstract partial class UserListCustomerTypeServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserListCustomerTypeService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default UserListCustomerTypeService scopes.</summary>
        /// <remarks>
        /// The default UserListCustomerTypeService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UserListCustomerTypeService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="UserListCustomerTypeServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="UserListCustomerTypeServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="UserListCustomerTypeServiceClient"/>.</returns>
        public static stt::Task<UserListCustomerTypeServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new UserListCustomerTypeServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="UserListCustomerTypeServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="UserListCustomerTypeServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="UserListCustomerTypeServiceClient"/>.</returns>
        public static UserListCustomerTypeServiceClient Create() => new UserListCustomerTypeServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="UserListCustomerTypeServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="UserListCustomerTypeServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UserListCustomerTypeServiceClient"/>.</returns>
        internal static UserListCustomerTypeServiceClient Create(grpccore::CallInvoker callInvoker, UserListCustomerTypeServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserListCustomerTypeService.UserListCustomerTypeServiceClient grpcClient = new UserListCustomerTypeService.UserListCustomerTypeServiceClient(callInvoker);
            return new UserListCustomerTypeServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC UserListCustomerTypeService client</summary>
        public virtual UserListCustomerTypeService.UserListCustomerTypeServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Attach or remove user list customer types. Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [UserListCustomerTypeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateUserListCustomerTypesResponse MutateUserListCustomerTypes(MutateUserListCustomerTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attach or remove user list customer types. Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [UserListCustomerTypeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateUserListCustomerTypesResponse> MutateUserListCustomerTypesAsync(MutateUserListCustomerTypesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Attach or remove user list customer types. Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [UserListCustomerTypeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateUserListCustomerTypesResponse> MutateUserListCustomerTypesAsync(MutateUserListCustomerTypesRequest request, st::CancellationToken cancellationToken) =>
            MutateUserListCustomerTypesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Attach or remove user list customer types. Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [UserListCustomerTypeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose user list customer types are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on the user list customer
        /// types.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateUserListCustomerTypesResponse MutateUserListCustomerTypes(string customerId, scg::IEnumerable<UserListCustomerTypeOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateUserListCustomerTypes(new MutateUserListCustomerTypesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Attach or remove user list customer types. Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [UserListCustomerTypeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose user list customer types are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on the user list customer
        /// types.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateUserListCustomerTypesResponse> MutateUserListCustomerTypesAsync(string customerId, scg::IEnumerable<UserListCustomerTypeOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateUserListCustomerTypesAsync(new MutateUserListCustomerTypesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Attach or remove user list customer types. Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [UserListCustomerTypeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose user list customer types are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on the user list customer
        /// types.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateUserListCustomerTypesResponse> MutateUserListCustomerTypesAsync(string customerId, scg::IEnumerable<UserListCustomerTypeOperation> operations, st::CancellationToken cancellationToken) =>
            MutateUserListCustomerTypesAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserListCustomerTypeService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage user list customer types.
    /// </remarks>
    public sealed partial class UserListCustomerTypeServiceClientImpl : UserListCustomerTypeServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateUserListCustomerTypesRequest, MutateUserListCustomerTypesResponse> _callMutateUserListCustomerTypes;

        /// <summary>
        /// Constructs a client wrapper for the UserListCustomerTypeService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="UserListCustomerTypeServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UserListCustomerTypeServiceClientImpl(UserListCustomerTypeService.UserListCustomerTypeServiceClient grpcClient, UserListCustomerTypeServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UserListCustomerTypeServiceSettings effectiveSettings = settings ?? UserListCustomerTypeServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateUserListCustomerTypes = clientHelper.BuildApiCall<MutateUserListCustomerTypesRequest, MutateUserListCustomerTypesResponse>("MutateUserListCustomerTypes", grpcClient.MutateUserListCustomerTypesAsync, grpcClient.MutateUserListCustomerTypes, effectiveSettings.MutateUserListCustomerTypesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateUserListCustomerTypes);
            Modify_MutateUserListCustomerTypesApiCall(ref _callMutateUserListCustomerTypes);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateUserListCustomerTypesApiCall(ref gaxgrpc::ApiCall<MutateUserListCustomerTypesRequest, MutateUserListCustomerTypesResponse> call);

        partial void OnConstruction(UserListCustomerTypeService.UserListCustomerTypeServiceClient grpcClient, UserListCustomerTypeServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC UserListCustomerTypeService client</summary>
        public override UserListCustomerTypeService.UserListCustomerTypeServiceClient GrpcClient { get; }

        partial void Modify_MutateUserListCustomerTypesRequest(ref MutateUserListCustomerTypesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Attach or remove user list customer types. Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [UserListCustomerTypeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateUserListCustomerTypesResponse MutateUserListCustomerTypes(MutateUserListCustomerTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateUserListCustomerTypesRequest(ref request, ref callSettings);
            return _callMutateUserListCustomerTypes.Sync(request, callSettings);
        }

        /// <summary>
        /// Attach or remove user list customer types. Operation statuses
        /// are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [UserListCustomerTypeError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateUserListCustomerTypesResponse> MutateUserListCustomerTypesAsync(MutateUserListCustomerTypesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateUserListCustomerTypesRequest(ref request, ref callSettings);
            return _callMutateUserListCustomerTypes.Async(request, callSettings);
        }
    }
}

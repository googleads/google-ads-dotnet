// Copyright 2023 Google LLC
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
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V13.Services
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
        public gaxgrpc::CallSettings UploadUserDataSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="UserDataServiceSettings"/> object.</returns>
        public UserDataServiceSettings Clone() => new UserDataServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="UserDataServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class UserDataServiceClientBuilder : gaxgrpc::ClientBuilderBase<UserDataServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public UserDataServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public UserDataServiceClientBuilder() : base(UserDataServiceClient.ServiceMetadata)
        {
        }

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
            return UserDataServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<UserDataServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return UserDataServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => UserDataServiceClient.ChannelPool;
    }

    /// <summary>UserDataService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage user data uploads.
    /// Any uploads made to a Customer Match list through this service will be
    /// eligible for matching as per the customer matching process. See
    /// https://support.google.com/google-ads/answer/7474263. However, the uploads
    /// made through this service will not be visible under the 'Segment members'
    /// section for the Customer Match List in the Google Ads UI.
    /// </remarks>
    public abstract partial class UserDataServiceClient
    {
        /// <summary>
        /// The default endpoint for the UserDataService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default UserDataService scopes.</summary>
        /// <remarks>
        /// The default UserDataService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(UserDataService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

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
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="UserDataServiceClient"/>.</returns>
        internal static UserDataServiceClient Create(grpccore::CallInvoker callInvoker, UserDataServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            UserDataService.UserDataServiceClient grpcClient = new UserDataService.UserDataServiceClient(callInvoker);
            return new UserDataServiceClientImpl(grpcClient, settings, logger);
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
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OfflineUserDataJobError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UserDataError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadUserDataResponse UploadUserData(UploadUserDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads the given user data.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OfflineUserDataJobError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UserDataError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadUserDataResponse> UploadUserDataAsync(UploadUserDataRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Uploads the given user data.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OfflineUserDataJobError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UserDataError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadUserDataResponse> UploadUserDataAsync(UploadUserDataRequest request, st::CancellationToken cancellationToken) =>
            UploadUserDataAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>UserDataService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage user data uploads.
    /// Any uploads made to a Customer Match list through this service will be
    /// eligible for matching as per the customer matching process. See
    /// https://support.google.com/google-ads/answer/7474263. However, the uploads
    /// made through this service will not be visible under the 'Segment members'
    /// section for the Customer Match List in the Google Ads UI.
    /// </remarks>
    public sealed partial class UserDataServiceClientImpl : UserDataServiceClient
    {
        private readonly gaxgrpc::ApiCall<UploadUserDataRequest, UploadUserDataResponse> _callUploadUserData;

        /// <summary>
        /// Constructs a client wrapper for the UserDataService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="UserDataServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public UserDataServiceClientImpl(UserDataService.UserDataServiceClient grpcClient, UserDataServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            UserDataServiceSettings effectiveSettings = settings ?? UserDataServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callUploadUserData = clientHelper.BuildApiCall<UploadUserDataRequest, UploadUserDataResponse>("UploadUserData", grpcClient.UploadUserDataAsync, grpcClient.UploadUserData, effectiveSettings.UploadUserDataSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
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
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OfflineUserDataJobError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UserDataError]()
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
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CollectionSizeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [OfflineUserDataJobError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [UserDataError]()
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

// Copyright 2024 Google LLC
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

namespace Google.Ads.GoogleAds.V16.Services
{
    /// <summary>Settings for <see cref="KeywordPlanAdGroupServiceClient"/> instances.</summary>
    public sealed partial class KeywordPlanAdGroupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="KeywordPlanAdGroupServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="KeywordPlanAdGroupServiceSettings"/>.</returns>
        public static KeywordPlanAdGroupServiceSettings GetDefault() => new KeywordPlanAdGroupServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="KeywordPlanAdGroupServiceSettings"/> object with default settings.
        /// </summary>
        public KeywordPlanAdGroupServiceSettings()
        {
        }

        private KeywordPlanAdGroupServiceSettings(KeywordPlanAdGroupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateKeywordPlanAdGroupsSettings = existing.MutateKeywordPlanAdGroupsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(KeywordPlanAdGroupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>KeywordPlanAdGroupServiceClient.MutateKeywordPlanAdGroups</c> and
        /// <c>KeywordPlanAdGroupServiceClient.MutateKeywordPlanAdGroupsAsync</c>.
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
        public gaxgrpc::CallSettings MutateKeywordPlanAdGroupsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="KeywordPlanAdGroupServiceSettings"/> object.</returns>
        public KeywordPlanAdGroupServiceSettings Clone() => new KeywordPlanAdGroupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="KeywordPlanAdGroupServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class KeywordPlanAdGroupServiceClientBuilder : gaxgrpc::ClientBuilderBase<KeywordPlanAdGroupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public KeywordPlanAdGroupServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public KeywordPlanAdGroupServiceClientBuilder() : base(KeywordPlanAdGroupServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref KeywordPlanAdGroupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<KeywordPlanAdGroupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override KeywordPlanAdGroupServiceClient Build()
        {
            KeywordPlanAdGroupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<KeywordPlanAdGroupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<KeywordPlanAdGroupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private KeywordPlanAdGroupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return KeywordPlanAdGroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<KeywordPlanAdGroupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return KeywordPlanAdGroupServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => KeywordPlanAdGroupServiceClient.ChannelPool;
    }

    /// <summary>KeywordPlanAdGroupService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Keyword Plan ad groups.
    /// </remarks>
    public abstract partial class KeywordPlanAdGroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the KeywordPlanAdGroupService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default KeywordPlanAdGroupService scopes.</summary>
        /// <remarks>
        /// The default KeywordPlanAdGroupService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(KeywordPlanAdGroupService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="KeywordPlanAdGroupServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanAdGroupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="KeywordPlanAdGroupServiceClient"/>.</returns>
        public static stt::Task<KeywordPlanAdGroupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new KeywordPlanAdGroupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="KeywordPlanAdGroupServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="KeywordPlanAdGroupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="KeywordPlanAdGroupServiceClient"/>.</returns>
        public static KeywordPlanAdGroupServiceClient Create() => new KeywordPlanAdGroupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="KeywordPlanAdGroupServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="KeywordPlanAdGroupServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="KeywordPlanAdGroupServiceClient"/>.</returns>
        internal static KeywordPlanAdGroupServiceClient Create(grpccore::CallInvoker callInvoker, KeywordPlanAdGroupServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient grpcClient = new KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient(callInvoker);
            return new KeywordPlanAdGroupServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC KeywordPlanAdGroupService client</summary>
        public virtual KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanAdGroupsResponse MutateKeywordPlanAdGroups(MutateKeywordPlanAdGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(MutateKeywordPlanAdGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(MutateKeywordPlanAdGroupsRequest request, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanAdGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan ad groups are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan ad
        /// groups.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateKeywordPlanAdGroupsResponse MutateKeywordPlanAdGroups(string customerId, scg::IEnumerable<KeywordPlanAdGroupOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanAdGroups(new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan ad groups are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan ad
        /// groups.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(string customerId, scg::IEnumerable<KeywordPlanAdGroupOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateKeywordPlanAdGroupsAsync(new MutateKeywordPlanAdGroupsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose Keyword Plan ad groups are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual Keyword Plan ad
        /// groups.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(string customerId, scg::IEnumerable<KeywordPlanAdGroupOperation> operations, st::CancellationToken cancellationToken) =>
            MutateKeywordPlanAdGroupsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>KeywordPlanAdGroupService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage Keyword Plan ad groups.
    /// </remarks>
    public sealed partial class KeywordPlanAdGroupServiceClientImpl : KeywordPlanAdGroupServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateKeywordPlanAdGroupsRequest, MutateKeywordPlanAdGroupsResponse> _callMutateKeywordPlanAdGroups;

        /// <summary>
        /// Constructs a client wrapper for the KeywordPlanAdGroupService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="KeywordPlanAdGroupServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public KeywordPlanAdGroupServiceClientImpl(KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient grpcClient, KeywordPlanAdGroupServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            KeywordPlanAdGroupServiceSettings effectiveSettings = settings ?? KeywordPlanAdGroupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateKeywordPlanAdGroups = clientHelper.BuildApiCall<MutateKeywordPlanAdGroupsRequest, MutateKeywordPlanAdGroupsResponse>("MutateKeywordPlanAdGroups", grpcClient.MutateKeywordPlanAdGroupsAsync, grpcClient.MutateKeywordPlanAdGroups, effectiveSettings.MutateKeywordPlanAdGroupsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateKeywordPlanAdGroups);
            Modify_MutateKeywordPlanAdGroupsApiCall(ref _callMutateKeywordPlanAdGroups);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateKeywordPlanAdGroupsApiCall(ref gaxgrpc::ApiCall<MutateKeywordPlanAdGroupsRequest, MutateKeywordPlanAdGroupsResponse> call);

        partial void OnConstruction(KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient grpcClient, KeywordPlanAdGroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC KeywordPlanAdGroupService client</summary>
        public override KeywordPlanAdGroupService.KeywordPlanAdGroupServiceClient GrpcClient { get; }

        partial void Modify_MutateKeywordPlanAdGroupsRequest(ref MutateKeywordPlanAdGroupsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateKeywordPlanAdGroupsResponse MutateKeywordPlanAdGroups(MutateKeywordPlanAdGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanAdGroupsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanAdGroups.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes Keyword Plan ad groups. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [KeywordPlanAdGroupError]()
        /// [KeywordPlanError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateKeywordPlanAdGroupsResponse> MutateKeywordPlanAdGroupsAsync(MutateKeywordPlanAdGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateKeywordPlanAdGroupsRequest(ref request, ref callSettings);
            return _callMutateKeywordPlanAdGroups.Async(request, callSettings);
        }
    }
}

// Copyright 2022 Google LLC
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

namespace Google.Ads.GoogleAds.V11.Services
{
    /// <summary>Settings for <see cref="SharedSetServiceClient"/> instances.</summary>
    public sealed partial class SharedSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SharedSetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SharedSetServiceSettings"/>.</returns>
        public static SharedSetServiceSettings GetDefault() => new SharedSetServiceSettings();

        /// <summary>Constructs a new <see cref="SharedSetServiceSettings"/> object with default settings.</summary>
        public SharedSetServiceSettings()
        {
        }

        private SharedSetServiceSettings(SharedSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateSharedSetsSettings = existing.MutateSharedSetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SharedSetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SharedSetServiceClient.MutateSharedSets</c> and <c>SharedSetServiceClient.MutateSharedSetsAsync</c>.
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
        public gaxgrpc::CallSettings MutateSharedSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SharedSetServiceSettings"/> object.</returns>
        public SharedSetServiceSettings Clone() => new SharedSetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SharedSetServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class SharedSetServiceClientBuilder : gaxgrpc::ClientBuilderBase<SharedSetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SharedSetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public SharedSetServiceClientBuilder()
        {
            UseJwtAccessWithScopes = SharedSetServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref SharedSetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SharedSetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SharedSetServiceClient Build()
        {
            SharedSetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SharedSetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SharedSetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SharedSetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SharedSetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<SharedSetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SharedSetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => SharedSetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SharedSetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SharedSetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>SharedSetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage shared sets.
    /// </remarks>
    public abstract partial class SharedSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the SharedSetService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default SharedSetService scopes.</summary>
        /// <remarks>
        /// The default SharedSetService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="SharedSetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SharedSetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SharedSetServiceClient"/>.</returns>
        public static stt::Task<SharedSetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SharedSetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SharedSetServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="SharedSetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SharedSetServiceClient"/>.</returns>
        public static SharedSetServiceClient Create() => new SharedSetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SharedSetServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SharedSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="SharedSetServiceClient"/>.</returns>
        internal static SharedSetServiceClient Create(grpccore::CallInvoker callInvoker, SharedSetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SharedSetService.SharedSetServiceClient grpcClient = new SharedSetService.SharedSetServiceClient(callInvoker);
            return new SharedSetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC SharedSetService client</summary>
        public virtual SharedSetService.SharedSetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateSharedSetsResponse MutateSharedSets(MutateSharedSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(MutateSharedSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(MutateSharedSetsRequest request, st::CancellationToken cancellationToken) =>
            MutateSharedSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual shared sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateSharedSetsResponse MutateSharedSets(string customerId, scg::IEnumerable<SharedSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateSharedSets(new MutateSharedSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual shared sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(string customerId, scg::IEnumerable<SharedSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateSharedSetsAsync(new MutateSharedSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose shared sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual shared sets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(string customerId, scg::IEnumerable<SharedSetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateSharedSetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SharedSetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage shared sets.
    /// </remarks>
    public sealed partial class SharedSetServiceClientImpl : SharedSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateSharedSetsRequest, MutateSharedSetsResponse> _callMutateSharedSets;

        /// <summary>
        /// Constructs a client wrapper for the SharedSetService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="SharedSetServiceSettings"/> used within this client.</param>
        public SharedSetServiceClientImpl(SharedSetService.SharedSetServiceClient grpcClient, SharedSetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SharedSetServiceSettings effectiveSettings = settings ?? SharedSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callMutateSharedSets = clientHelper.BuildApiCall<MutateSharedSetsRequest, MutateSharedSetsResponse>(grpcClient.MutateSharedSetsAsync, grpcClient.MutateSharedSets, effectiveSettings.MutateSharedSetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateSharedSets);
            Modify_MutateSharedSetsApiCall(ref _callMutateSharedSets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateSharedSetsApiCall(ref gaxgrpc::ApiCall<MutateSharedSetsRequest, MutateSharedSetsResponse> call);

        partial void OnConstruction(SharedSetService.SharedSetServiceClient grpcClient, SharedSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SharedSetService client</summary>
        public override SharedSetService.SharedSetServiceClient GrpcClient { get; }

        partial void Modify_MutateSharedSetsRequest(ref MutateSharedSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateSharedSetsResponse MutateSharedSets(MutateSharedSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateSharedSetsRequest(ref request, ref callSettings);
            return _callMutateSharedSets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes shared sets. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DistinctError]()
        /// [FieldError]()
        /// [FieldMaskError]()
        /// [HeaderError]()
        /// [IdError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [NewResourceCreationError]()
        /// [NotEmptyError]()
        /// [NullError]()
        /// [OperatorError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// [SharedSetError]()
        /// [SizeLimitError]()
        /// [StringFormatError]()
        /// [StringLengthError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateSharedSetsResponse> MutateSharedSetsAsync(MutateSharedSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateSharedSetsRequest(ref request, ref callSettings);
            return _callMutateSharedSets.Async(request, callSettings);
        }
    }
}

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

using gagvr = Google.Ads.GoogleAds.V4.Resources;
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

namespace Google.Ads.GoogleAds.V4.Services
{
    /// <summary>Settings for <see cref="SharedCriterionServiceClient"/> instances.</summary>
    public sealed partial class SharedCriterionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="SharedCriterionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="SharedCriterionServiceSettings"/>.</returns>
        public static SharedCriterionServiceSettings GetDefault() => new SharedCriterionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="SharedCriterionServiceSettings"/> object with default settings.
        /// </summary>
        public SharedCriterionServiceSettings()
        {
        }

        private SharedCriterionServiceSettings(SharedCriterionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetSharedCriterionSettings = existing.GetSharedCriterionSettings;
            MutateSharedCriteriaSettings = existing.MutateSharedCriteriaSettings;
            OnCopy(existing);
        }

        partial void OnCopy(SharedCriterionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SharedCriterionServiceClient.GetSharedCriterion</c> and
        /// <c>SharedCriterionServiceClient.GetSharedCriterionAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetSharedCriterionSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>SharedCriterionServiceClient.MutateSharedCriteria</c> and
        /// <c>SharedCriterionServiceClient.MutateSharedCriteriaAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateSharedCriteriaSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="SharedCriterionServiceSettings"/> object.</returns>
        public SharedCriterionServiceSettings Clone() => new SharedCriterionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="SharedCriterionServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class SharedCriterionServiceClientBuilder : gaxgrpc::ClientBuilderBase<SharedCriterionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public SharedCriterionServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref SharedCriterionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<SharedCriterionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override SharedCriterionServiceClient Build()
        {
            SharedCriterionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<SharedCriterionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<SharedCriterionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private SharedCriterionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return SharedCriterionServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<SharedCriterionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return SharedCriterionServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => SharedCriterionServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => SharedCriterionServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => SharedCriterionServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>SharedCriterionService client wrapper, for convenient use.</summary>
    public abstract partial class SharedCriterionServiceClient
    {
        /// <summary>
        /// The default endpoint for the SharedCriterionService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default SharedCriterionService scopes.</summary>
        /// <remarks>The default SharedCriterionService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="SharedCriterionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SharedCriterionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="SharedCriterionServiceClient"/>.</returns>
        public static stt::Task<SharedCriterionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new SharedCriterionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="SharedCriterionServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="SharedCriterionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="SharedCriterionServiceClient"/>.</returns>
        public static SharedCriterionServiceClient Create() => new SharedCriterionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="SharedCriterionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="SharedCriterionServiceSettings"/>.</param>
        /// <returns>The created <see cref="SharedCriterionServiceClient"/>.</returns>
        internal static SharedCriterionServiceClient Create(grpccore::CallInvoker callInvoker, SharedCriterionServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            SharedCriterionService.SharedCriterionServiceClient grpcClient = new SharedCriterionService.SharedCriterionServiceClient(callInvoker);
            return new SharedCriterionServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC SharedCriterionService client</summary>
        public virtual SharedCriterionService.SharedCriterionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SharedCriterion GetSharedCriterion(GetSharedCriterionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SharedCriterion> GetSharedCriterionAsync(GetSharedCriterionRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SharedCriterion> GetSharedCriterionAsync(GetSharedCriterionRequest request, st::CancellationToken cancellationToken) =>
            GetSharedCriterionAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the shared criterion to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SharedCriterion GetSharedCriterion(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedCriterion(new GetSharedCriterionRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the shared criterion to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SharedCriterion> GetSharedCriterionAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedCriterionAsync(new GetSharedCriterionRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the shared criterion to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SharedCriterion> GetSharedCriterionAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetSharedCriterionAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the shared criterion to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::SharedCriterion GetSharedCriterion(gagvr::SharedCriterionName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedCriterion(new GetSharedCriterionRequest
            {
                ResourceNameAsSharedCriterionName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the shared criterion to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SharedCriterion> GetSharedCriterionAsync(gagvr::SharedCriterionName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetSharedCriterionAsync(new GetSharedCriterionRequest
            {
                ResourceNameAsSharedCriterionName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the shared criterion to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::SharedCriterion> GetSharedCriterionAsync(gagvr::SharedCriterionName resourceName, st::CancellationToken cancellationToken) =>
            GetSharedCriterionAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes shared criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateSharedCriteriaResponse MutateSharedCriteria(MutateSharedCriteriaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes shared criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSharedCriteriaResponse> MutateSharedCriteriaAsync(MutateSharedCriteriaRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes shared criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSharedCriteriaResponse> MutateSharedCriteriaAsync(MutateSharedCriteriaRequest request, st::CancellationToken cancellationToken) =>
            MutateSharedCriteriaAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes shared criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose shared criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual shared criteria.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateSharedCriteriaResponse MutateSharedCriteria(string customerId, scg::IEnumerable<SharedCriterionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateSharedCriteria(new MutateSharedCriteriaRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes shared criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose shared criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual shared criteria.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSharedCriteriaResponse> MutateSharedCriteriaAsync(string customerId, scg::IEnumerable<SharedCriterionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateSharedCriteriaAsync(new MutateSharedCriteriaRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or removes shared criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose shared criteria are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual shared criteria.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateSharedCriteriaResponse> MutateSharedCriteriaAsync(string customerId, scg::IEnumerable<SharedCriterionOperation> operations, st::CancellationToken cancellationToken) =>
            MutateSharedCriteriaAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>SharedCriterionService client wrapper implementation, for convenient use.</summary>
    public sealed partial class SharedCriterionServiceClientImpl : SharedCriterionServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetSharedCriterionRequest, gagvr::SharedCriterion> _callGetSharedCriterion;

        private readonly gaxgrpc::ApiCall<MutateSharedCriteriaRequest, MutateSharedCriteriaResponse> _callMutateSharedCriteria;

        /// <summary>
        /// Constructs a client wrapper for the SharedCriterionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="SharedCriterionServiceSettings"/> used within this client.
        /// </param>
        public SharedCriterionServiceClientImpl(SharedCriterionService.SharedCriterionServiceClient grpcClient, SharedCriterionServiceSettings settings)
        {
            GrpcClient = grpcClient;
            SharedCriterionServiceSettings effectiveSettings = settings ?? SharedCriterionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetSharedCriterion = clientHelper.BuildApiCall<GetSharedCriterionRequest, gagvr::SharedCriterion>(grpcClient.GetSharedCriterionAsync, grpcClient.GetSharedCriterion, effectiveSettings.GetSharedCriterionSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetSharedCriterion);
            Modify_GetSharedCriterionApiCall(ref _callGetSharedCriterion);
            _callMutateSharedCriteria = clientHelper.BuildApiCall<MutateSharedCriteriaRequest, MutateSharedCriteriaResponse>(grpcClient.MutateSharedCriteriaAsync, grpcClient.MutateSharedCriteria, effectiveSettings.MutateSharedCriteriaSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateSharedCriteria);
            Modify_MutateSharedCriteriaApiCall(ref _callMutateSharedCriteria);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetSharedCriterionApiCall(ref gaxgrpc::ApiCall<GetSharedCriterionRequest, gagvr::SharedCriterion> call);

        partial void Modify_MutateSharedCriteriaApiCall(ref gaxgrpc::ApiCall<MutateSharedCriteriaRequest, MutateSharedCriteriaResponse> call);

        partial void OnConstruction(SharedCriterionService.SharedCriterionServiceClient grpcClient, SharedCriterionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC SharedCriterionService client</summary>
        public override SharedCriterionService.SharedCriterionServiceClient GrpcClient { get; }

        partial void Modify_GetSharedCriterionRequest(ref GetSharedCriterionRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateSharedCriteriaRequest(ref MutateSharedCriteriaRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::SharedCriterion GetSharedCriterion(GetSharedCriterionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSharedCriterionRequest(ref request, ref callSettings);
            return _callGetSharedCriterion.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested shared criterion in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::SharedCriterion> GetSharedCriterionAsync(GetSharedCriterionRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetSharedCriterionRequest(ref request, ref callSettings);
            return _callGetSharedCriterion.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or removes shared criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateSharedCriteriaResponse MutateSharedCriteria(MutateSharedCriteriaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateSharedCriteriaRequest(ref request, ref callSettings);
            return _callMutateSharedCriteria.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes shared criteria. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateSharedCriteriaResponse> MutateSharedCriteriaAsync(MutateSharedCriteriaRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateSharedCriteriaRequest(ref request, ref callSettings);
            return _callMutateSharedCriteria.Async(request, callSettings);
        }
    }
}

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

using gagvr = Google.Ads.GoogleAds.V6.Resources;
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

namespace Google.Ads.GoogleAds.V6.Services
{
    /// <summary>Settings for <see cref="CustomInterestServiceClient"/> instances.</summary>
    public sealed partial class CustomInterestServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomInterestServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomInterestServiceSettings"/>.</returns>
        public static CustomInterestServiceSettings GetDefault() => new CustomInterestServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomInterestServiceSettings"/> object with default settings.
        /// </summary>
        public CustomInterestServiceSettings()
        {
        }

        private CustomInterestServiceSettings(CustomInterestServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomInterestSettings = existing.GetCustomInterestSettings;
            MutateCustomInterestsSettings = existing.MutateCustomInterestsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomInterestServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomInterestServiceClient.GetCustomInterest</c> and
        /// <c>CustomInterestServiceClient.GetCustomInterestAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomInterestSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomInterestServiceClient.MutateCustomInterests</c> and
        /// <c>CustomInterestServiceClient.MutateCustomInterestsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCustomInterestsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomInterestServiceSettings"/> object.</returns>
        public CustomInterestServiceSettings Clone() => new CustomInterestServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomInterestServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomInterestServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomInterestServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomInterestServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CustomInterestServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomInterestServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomInterestServiceClient Build()
        {
            CustomInterestServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomInterestServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomInterestServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomInterestServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomInterestServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CustomInterestServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomInterestServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CustomInterestServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CustomInterestServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomInterestServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CustomInterestService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage custom interests.
    /// </remarks>
    public abstract partial class CustomInterestServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomInterestService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomInterestService scopes.</summary>
        /// <remarks>
        /// The default CustomInterestService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomInterestServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomInterestServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomInterestServiceClient"/>.</returns>
        public static stt::Task<CustomInterestServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomInterestServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomInterestServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomInterestServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomInterestServiceClient"/>.</returns>
        public static CustomInterestServiceClient Create() => new CustomInterestServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomInterestServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomInterestServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomInterestServiceClient"/>.</returns>
        internal static CustomInterestServiceClient Create(grpccore::CallInvoker callInvoker, CustomInterestServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomInterestService.CustomInterestServiceClient grpcClient = new CustomInterestService.CustomInterestServiceClient(callInvoker);
            return new CustomInterestServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CustomInterestService client</summary>
        public virtual CustomInterestService.CustomInterestServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomInterest GetCustomInterest(GetCustomInterestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomInterest> GetCustomInterestAsync(GetCustomInterestRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomInterest> GetCustomInterestAsync(GetCustomInterestRequest request, st::CancellationToken cancellationToken) =>
            GetCustomInterestAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the custom interest to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomInterest GetCustomInterest(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomInterest(new GetCustomInterestRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the custom interest to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomInterest> GetCustomInterestAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomInterestAsync(new GetCustomInterestRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the custom interest to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomInterest> GetCustomInterestAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCustomInterestAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the custom interest to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomInterest GetCustomInterest(gagvr::CustomInterestName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomInterest(new GetCustomInterestRequest
            {
                ResourceNameAsCustomInterestName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the custom interest to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomInterest> GetCustomInterestAsync(gagvr::CustomInterestName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomInterestAsync(new GetCustomInterestRequest
            {
                ResourceNameAsCustomInterestName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the custom interest to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomInterest> GetCustomInterestAsync(gagvr::CustomInterestName resourceName, st::CancellationToken cancellationToken) =>
            GetCustomInterestAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates custom interests. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomInterestsResponse MutateCustomInterests(MutateCustomInterestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates custom interests. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomInterestsResponse> MutateCustomInterestsAsync(MutateCustomInterestsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or updates custom interests. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomInterestsResponse> MutateCustomInterestsAsync(MutateCustomInterestsRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomInterestsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or updates custom interests. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom interests are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual custom interests.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomInterestsResponse MutateCustomInterests(string customerId, scg::IEnumerable<CustomInterestOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomInterests(new MutateCustomInterestsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates custom interests. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom interests are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual custom interests.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomInterestsResponse> MutateCustomInterestsAsync(string customerId, scg::IEnumerable<CustomInterestOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomInterestsAsync(new MutateCustomInterestsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates or updates custom interests. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom interests are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual custom interests.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomInterestsResponse> MutateCustomInterestsAsync(string customerId, scg::IEnumerable<CustomInterestOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomInterestsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomInterestService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage custom interests.
    /// </remarks>
    public sealed partial class CustomInterestServiceClientImpl : CustomInterestServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomInterestRequest, gagvr::CustomInterest> _callGetCustomInterest;

        private readonly gaxgrpc::ApiCall<MutateCustomInterestsRequest, MutateCustomInterestsResponse> _callMutateCustomInterests;

        /// <summary>
        /// Constructs a client wrapper for the CustomInterestService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CustomInterestServiceSettings"/> used within this client.</param>
        public CustomInterestServiceClientImpl(CustomInterestService.CustomInterestServiceClient grpcClient, CustomInterestServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomInterestServiceSettings effectiveSettings = settings ?? CustomInterestServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomInterest = clientHelper.BuildApiCall<GetCustomInterestRequest, gagvr::CustomInterest>(grpcClient.GetCustomInterestAsync, grpcClient.GetCustomInterest, effectiveSettings.GetCustomInterestSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCustomInterest);
            Modify_GetCustomInterestApiCall(ref _callGetCustomInterest);
            _callMutateCustomInterests = clientHelper.BuildApiCall<MutateCustomInterestsRequest, MutateCustomInterestsResponse>(grpcClient.MutateCustomInterestsAsync, grpcClient.MutateCustomInterests, effectiveSettings.MutateCustomInterestsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomInterests);
            Modify_MutateCustomInterestsApiCall(ref _callMutateCustomInterests);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomInterestApiCall(ref gaxgrpc::ApiCall<GetCustomInterestRequest, gagvr::CustomInterest> call);

        partial void Modify_MutateCustomInterestsApiCall(ref gaxgrpc::ApiCall<MutateCustomInterestsRequest, MutateCustomInterestsResponse> call);

        partial void OnConstruction(CustomInterestService.CustomInterestServiceClient grpcClient, CustomInterestServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomInterestService client</summary>
        public override CustomInterestService.CustomInterestServiceClient GrpcClient { get; }

        partial void Modify_GetCustomInterestRequest(ref GetCustomInterestRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCustomInterestsRequest(ref MutateCustomInterestsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CustomInterest GetCustomInterest(GetCustomInterestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomInterestRequest(ref request, ref callSettings);
            return _callGetCustomInterest.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested custom interest in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CustomInterest> GetCustomInterestAsync(GetCustomInterestRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomInterestRequest(ref request, ref callSettings);
            return _callGetCustomInterest.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or updates custom interests. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomInterestsResponse MutateCustomInterests(MutateCustomInterestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomInterestsRequest(ref request, ref callSettings);
            return _callMutateCustomInterests.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or updates custom interests. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomInterestsResponse> MutateCustomInterestsAsync(MutateCustomInterestsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomInterestsRequest(ref request, ref callSettings);
            return _callMutateCustomInterests.Async(request, callSettings);
        }
    }
}

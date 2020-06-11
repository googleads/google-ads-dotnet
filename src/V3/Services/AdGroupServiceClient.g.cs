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

using gagvr = Google.Ads.GoogleAds.V3.Resources;
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
    /// <summary>Settings for <see cref="AdGroupServiceClient"/> instances.</summary>
    public sealed partial class AdGroupServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupServiceSettings"/>.</returns>
        public static AdGroupServiceSettings GetDefault() => new AdGroupServiceSettings();

        /// <summary>Constructs a new <see cref="AdGroupServiceSettings"/> object with default settings.</summary>
        public AdGroupServiceSettings()
        {
        }

        private AdGroupServiceSettings(AdGroupServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupSettings = existing.GetAdGroupSettings;
            MutateAdGroupsSettings = existing.MutateAdGroupsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupServiceClient.GetAdGroup</c> and <c>AdGroupServiceClient.GetAdGroupAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupServiceClient.MutateAdGroups</c> and <c>AdGroupServiceClient.MutateAdGroupsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAdGroupsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupServiceSettings"/> object.</returns>
        public AdGroupServiceSettings Clone() => new AdGroupServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class AdGroupServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupServiceClient Build()
        {
            AdGroupServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdGroupServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupService client wrapper, for convenient use.</summary>
    public abstract partial class AdGroupServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupService scopes.</summary>
        /// <remarks>The default AdGroupService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdGroupServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupServiceClient"/>.</returns>
        public static stt::Task<AdGroupServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="AdGroupServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupServiceClient"/>.</returns>
        public static AdGroupServiceClient Create() => new AdGroupServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupServiceClient"/>.</returns>
        internal static AdGroupServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupService.AdGroupServiceClient grpcClient = new AdGroupService.AdGroupServiceClient(callInvoker);
            return new AdGroupServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupService client</summary>
        public virtual AdGroupService.AdGroupServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroup GetAdGroup(GetAdGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroup> GetAdGroupAsync(GetAdGroupRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroup> GetAdGroupAsync(GetAdGroupRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroup GetAdGroup(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroup(new GetAdGroupRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroup> GetAdGroupAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAsync(new GetAdGroupRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroup> GetAdGroupAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroup GetAdGroup(gagvr::AdGroupName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroup(new GetAdGroupRequest
            {
                ResourceNameAsAdGroupName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroup> GetAdGroupAsync(gagvr::AdGroupName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAsync(new GetAdGroupRequest
            {
                ResourceNameAsAdGroupName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroup> GetAdGroupAsync(gagvr::AdGroupName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ad groups. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupsResponse MutateAdGroups(MutateAdGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad groups. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupsResponse> MutateAdGroupsAsync(MutateAdGroupsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes ad groups. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupsResponse> MutateAdGroupsAsync(MutateAdGroupsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes ad groups. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad groups are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad groups.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupsResponse MutateAdGroups(string customerId, scg::IEnumerable<AdGroupOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroups(new MutateAdGroupsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad groups. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad groups are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad groups.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupsResponse> MutateAdGroupsAsync(string customerId, scg::IEnumerable<AdGroupOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupsAsync(new MutateAdGroupsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes ad groups. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad groups are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad groups.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupsResponse> MutateAdGroupsAsync(string customerId, scg::IEnumerable<AdGroupOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupService client wrapper implementation, for convenient use.</summary>
    public sealed partial class AdGroupServiceClientImpl : AdGroupServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupRequest, gagvr::AdGroup> _callGetAdGroup;

        private readonly gaxgrpc::ApiCall<MutateAdGroupsRequest, MutateAdGroupsResponse> _callMutateAdGroups;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdGroupServiceSettings"/> used within this client.</param>
        public AdGroupServiceClientImpl(AdGroupService.AdGroupServiceClient grpcClient, AdGroupServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupServiceSettings effectiveSettings = settings ?? AdGroupServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroup = clientHelper.BuildApiCall<GetAdGroupRequest, gagvr::AdGroup>(grpcClient.GetAdGroupAsync, grpcClient.GetAdGroup, effectiveSettings.GetAdGroupSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroup);
            Modify_GetAdGroupApiCall(ref _callGetAdGroup);
            _callMutateAdGroups = clientHelper.BuildApiCall<MutateAdGroupsRequest, MutateAdGroupsResponse>(grpcClient.MutateAdGroupsAsync, grpcClient.MutateAdGroups, effectiveSettings.MutateAdGroupsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroups);
            Modify_MutateAdGroupsApiCall(ref _callMutateAdGroups);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupApiCall(ref gaxgrpc::ApiCall<GetAdGroupRequest, gagvr::AdGroup> call);

        partial void Modify_MutateAdGroupsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupsRequest, MutateAdGroupsResponse> call);

        partial void OnConstruction(AdGroupService.AdGroupServiceClient grpcClient, AdGroupServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupService client</summary>
        public override AdGroupService.AdGroupServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupRequest(ref GetAdGroupRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateAdGroupsRequest(ref MutateAdGroupsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroup GetAdGroup(GetAdGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupRequest(ref request, ref callSettings);
            return _callGetAdGroup.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroup> GetAdGroupAsync(GetAdGroupRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupRequest(ref request, ref callSettings);
            return _callGetAdGroup.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ad groups. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupsResponse MutateAdGroups(MutateAdGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupsRequest(ref request, ref callSettings);
            return _callMutateAdGroups.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes ad groups. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupsResponse> MutateAdGroupsAsync(MutateAdGroupsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupsRequest(ref request, ref callSettings);
            return _callMutateAdGroups.Async(request, callSettings);
        }
    }
}

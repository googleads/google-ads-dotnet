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
    /// <summary>Settings for <see cref="AdGroupCriterionLabelServiceClient"/> instances.</summary>
    public sealed partial class AdGroupCriterionLabelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupCriterionLabelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupCriterionLabelServiceSettings"/>.</returns>
        public static AdGroupCriterionLabelServiceSettings GetDefault() => new AdGroupCriterionLabelServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupCriterionLabelServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupCriterionLabelServiceSettings()
        {
        }

        private AdGroupCriterionLabelServiceSettings(AdGroupCriterionLabelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupCriterionLabelSettings = existing.GetAdGroupCriterionLabelSettings;
            MutateAdGroupCriterionLabelsSettings = existing.MutateAdGroupCriterionLabelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupCriterionLabelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupCriterionLabelServiceClient.GetAdGroupCriterionLabel</c> and
        /// <c>AdGroupCriterionLabelServiceClient.GetAdGroupCriterionLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupCriterionLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupCriterionLabelServiceClient.MutateAdGroupCriterionLabels</c> and
        /// <c>AdGroupCriterionLabelServiceClient.MutateAdGroupCriterionLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAdGroupCriterionLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupCriterionLabelServiceSettings"/> object.</returns>
        public AdGroupCriterionLabelServiceSettings Clone() => new AdGroupCriterionLabelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupCriterionLabelServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class AdGroupCriterionLabelServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupCriterionLabelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupCriterionLabelServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupCriterionLabelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupCriterionLabelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupCriterionLabelServiceClient Build()
        {
            AdGroupCriterionLabelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupCriterionLabelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupCriterionLabelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupCriterionLabelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupCriterionLabelServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupCriterionLabelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupCriterionLabelServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupCriterionLabelServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdGroupCriterionLabelServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupCriterionLabelServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupCriterionLabelService client wrapper, for convenient use.</summary>
    public abstract partial class AdGroupCriterionLabelServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupCriterionLabelService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupCriterionLabelService scopes.</summary>
        /// <remarks>The default AdGroupCriterionLabelService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupCriterionLabelServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupCriterionLabelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupCriterionLabelServiceClient"/>.</returns>
        public static stt::Task<AdGroupCriterionLabelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupCriterionLabelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupCriterionLabelServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupCriterionLabelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupCriterionLabelServiceClient"/>.</returns>
        public static AdGroupCriterionLabelServiceClient Create() => new AdGroupCriterionLabelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupCriterionLabelServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupCriterionLabelServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupCriterionLabelServiceClient"/>.</returns>
        internal static AdGroupCriterionLabelServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupCriterionLabelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient grpcClient = new AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient(callInvoker);
            return new AdGroupCriterionLabelServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupCriterionLabelService client</summary>
        public virtual AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupCriterionLabel GetAdGroupCriterionLabel(GetAdGroupCriterionLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionLabel> GetAdGroupCriterionLabelAsync(GetAdGroupCriterionLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionLabel> GetAdGroupCriterionLabelAsync(GetAdGroupCriterionLabelRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupCriterionLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupCriterionLabel GetAdGroupCriterionLabel(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupCriterionLabel(new GetAdGroupCriterionLabelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionLabel> GetAdGroupCriterionLabelAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupCriterionLabelAsync(new GetAdGroupCriterionLabelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion label to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionLabel> GetAdGroupCriterionLabelAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupCriterionLabelAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupCriterionLabel GetAdGroupCriterionLabel(gagvr::AdGroupCriterionLabelName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupCriterionLabel(new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionLabel> GetAdGroupCriterionLabelAsync(gagvr::AdGroupCriterionLabelName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupCriterionLabelAsync(new GetAdGroupCriterionLabelRequest
            {
                ResourceNameAsAdGroupCriterionLabelName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group criterion label to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupCriterionLabel> GetAdGroupCriterionLabelAsync(gagvr::AdGroupCriterionLabelName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupCriterionLabelAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes ad group criterion labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupCriterionLabelsResponse MutateAdGroupCriterionLabels(MutateAdGroupCriterionLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes ad group criterion labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriterionLabelsResponse> MutateAdGroupCriterionLabelsAsync(MutateAdGroupCriterionLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes ad group criterion labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriterionLabelsResponse> MutateAdGroupCriterionLabelsAsync(MutateAdGroupCriterionLabelsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupCriterionLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes ad group criterion labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group criterion labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on ad group criterion labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupCriterionLabelsResponse MutateAdGroupCriterionLabels(string customerId, scg::IEnumerable<AdGroupCriterionLabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupCriterionLabels(new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates and removes ad group criterion labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group criterion labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on ad group criterion labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriterionLabelsResponse> MutateAdGroupCriterionLabelsAsync(string customerId, scg::IEnumerable<AdGroupCriterionLabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupCriterionLabelsAsync(new MutateAdGroupCriterionLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates and removes ad group criterion labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group criterion labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on ad group criterion labels.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriterionLabelsResponse> MutateAdGroupCriterionLabelsAsync(string customerId, scg::IEnumerable<AdGroupCriterionLabelOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupCriterionLabelsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupCriterionLabelService client wrapper implementation, for convenient use.</summary>
    public sealed partial class AdGroupCriterionLabelServiceClientImpl : AdGroupCriterionLabelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupCriterionLabelRequest, gagvr::AdGroupCriterionLabel> _callGetAdGroupCriterionLabel;

        private readonly gaxgrpc::ApiCall<MutateAdGroupCriterionLabelsRequest, MutateAdGroupCriterionLabelsResponse> _callMutateAdGroupCriterionLabels;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupCriterionLabelService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdGroupCriterionLabelServiceSettings"/> used within this client.
        /// </param>
        public AdGroupCriterionLabelServiceClientImpl(AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient grpcClient, AdGroupCriterionLabelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupCriterionLabelServiceSettings effectiveSettings = settings ?? AdGroupCriterionLabelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupCriterionLabel = clientHelper.BuildApiCall<GetAdGroupCriterionLabelRequest, gagvr::AdGroupCriterionLabel>(grpcClient.GetAdGroupCriterionLabelAsync, grpcClient.GetAdGroupCriterionLabel, effectiveSettings.GetAdGroupCriterionLabelSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupCriterionLabel);
            Modify_GetAdGroupCriterionLabelApiCall(ref _callGetAdGroupCriterionLabel);
            _callMutateAdGroupCriterionLabels = clientHelper.BuildApiCall<MutateAdGroupCriterionLabelsRequest, MutateAdGroupCriterionLabelsResponse>(grpcClient.MutateAdGroupCriterionLabelsAsync, grpcClient.MutateAdGroupCriterionLabels, effectiveSettings.MutateAdGroupCriterionLabelsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupCriterionLabels);
            Modify_MutateAdGroupCriterionLabelsApiCall(ref _callMutateAdGroupCriterionLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupCriterionLabelApiCall(ref gaxgrpc::ApiCall<GetAdGroupCriterionLabelRequest, gagvr::AdGroupCriterionLabel> call);

        partial void Modify_MutateAdGroupCriterionLabelsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupCriterionLabelsRequest, MutateAdGroupCriterionLabelsResponse> call);

        partial void OnConstruction(AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient grpcClient, AdGroupCriterionLabelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupCriterionLabelService client</summary>
        public override AdGroupCriterionLabelService.AdGroupCriterionLabelServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupCriterionLabelRequest(ref GetAdGroupCriterionLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateAdGroupCriterionLabelsRequest(ref MutateAdGroupCriterionLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroupCriterionLabel GetAdGroupCriterionLabel(GetAdGroupCriterionLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupCriterionLabelRequest(ref request, ref callSettings);
            return _callGetAdGroupCriterionLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group criterion label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroupCriterionLabel> GetAdGroupCriterionLabelAsync(GetAdGroupCriterionLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupCriterionLabelRequest(ref request, ref callSettings);
            return _callGetAdGroupCriterionLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and removes ad group criterion labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupCriterionLabelsResponse MutateAdGroupCriterionLabels(MutateAdGroupCriterionLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupCriterionLabelsRequest(ref request, ref callSettings);
            return _callMutateAdGroupCriterionLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and removes ad group criterion labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupCriterionLabelsResponse> MutateAdGroupCriterionLabelsAsync(MutateAdGroupCriterionLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupCriterionLabelsRequest(ref request, ref callSettings);
            return _callMutateAdGroupCriterionLabels.Async(request, callSettings);
        }
    }
}

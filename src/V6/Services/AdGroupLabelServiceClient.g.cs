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
    /// <summary>Settings for <see cref="AdGroupLabelServiceClient"/> instances.</summary>
    public sealed partial class AdGroupLabelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupLabelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupLabelServiceSettings"/>.</returns>
        public static AdGroupLabelServiceSettings GetDefault() => new AdGroupLabelServiceSettings();

        /// <summary>Constructs a new <see cref="AdGroupLabelServiceSettings"/> object with default settings.</summary>
        public AdGroupLabelServiceSettings()
        {
        }

        private AdGroupLabelServiceSettings(AdGroupLabelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupLabelSettings = existing.GetAdGroupLabelSettings;
            MutateAdGroupLabelsSettings = existing.MutateAdGroupLabelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupLabelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupLabelServiceClient.GetAdGroupLabel</c> and <c>AdGroupLabelServiceClient.GetAdGroupLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupLabelServiceClient.MutateAdGroupLabels</c> and
        /// <c>AdGroupLabelServiceClient.MutateAdGroupLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAdGroupLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupLabelServiceSettings"/> object.</returns>
        public AdGroupLabelServiceSettings Clone() => new AdGroupLabelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupLabelServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AdGroupLabelServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupLabelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupLabelServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupLabelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupLabelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupLabelServiceClient Build()
        {
            AdGroupLabelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupLabelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupLabelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupLabelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupLabelServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupLabelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupLabelServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupLabelServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdGroupLabelServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupLabelServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupLabelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage labels on ad groups.
    /// </remarks>
    public abstract partial class AdGroupLabelServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupLabelService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupLabelService scopes.</summary>
        /// <remarks>
        /// The default AdGroupLabelService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupLabelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupLabelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupLabelServiceClient"/>.</returns>
        public static stt::Task<AdGroupLabelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupLabelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupLabelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupLabelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupLabelServiceClient"/>.</returns>
        public static AdGroupLabelServiceClient Create() => new AdGroupLabelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupLabelServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupLabelServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupLabelServiceClient"/>.</returns>
        internal static AdGroupLabelServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupLabelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupLabelService.AdGroupLabelServiceClient grpcClient = new AdGroupLabelService.AdGroupLabelServiceClient(callInvoker);
            return new AdGroupLabelServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupLabelService client</summary>
        public virtual AdGroupLabelService.AdGroupLabelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupLabel GetAdGroupLabel(GetAdGroupLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupLabel> GetAdGroupLabelAsync(GetAdGroupLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupLabel> GetAdGroupLabelAsync(GetAdGroupLabelRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupLabel GetAdGroupLabel(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupLabel(new GetAdGroupLabelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupLabel> GetAdGroupLabelAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupLabelAsync(new GetAdGroupLabelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group label to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupLabel> GetAdGroupLabelAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupLabelAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupLabel GetAdGroupLabel(gagvr::AdGroupLabelName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupLabel(new GetAdGroupLabelRequest
            {
                ResourceNameAsAdGroupLabelName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupLabel> GetAdGroupLabelAsync(gagvr::AdGroupLabelName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupLabelAsync(new GetAdGroupLabelRequest
            {
                ResourceNameAsAdGroupLabelName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group label to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupLabel> GetAdGroupLabelAsync(gagvr::AdGroupLabelName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupLabelAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes ad group labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupLabelsResponse MutateAdGroupLabels(MutateAdGroupLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes ad group labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupLabelsResponse> MutateAdGroupLabelsAsync(MutateAdGroupLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes ad group labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupLabelsResponse> MutateAdGroupLabelsAsync(MutateAdGroupLabelsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes ad group labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on ad group labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupLabelsResponse MutateAdGroupLabels(string customerId, scg::IEnumerable<AdGroupLabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupLabels(new MutateAdGroupLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates and removes ad group labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on ad group labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupLabelsResponse> MutateAdGroupLabelsAsync(string customerId, scg::IEnumerable<AdGroupLabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupLabelsAsync(new MutateAdGroupLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates and removes ad group labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on ad group labels.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupLabelsResponse> MutateAdGroupLabelsAsync(string customerId, scg::IEnumerable<AdGroupLabelOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupLabelsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupLabelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage labels on ad groups.
    /// </remarks>
    public sealed partial class AdGroupLabelServiceClientImpl : AdGroupLabelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupLabelRequest, gagvr::AdGroupLabel> _callGetAdGroupLabel;

        private readonly gaxgrpc::ApiCall<MutateAdGroupLabelsRequest, MutateAdGroupLabelsResponse> _callMutateAdGroupLabels;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupLabelService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdGroupLabelServiceSettings"/> used within this client.</param>
        public AdGroupLabelServiceClientImpl(AdGroupLabelService.AdGroupLabelServiceClient grpcClient, AdGroupLabelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupLabelServiceSettings effectiveSettings = settings ?? AdGroupLabelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupLabel = clientHelper.BuildApiCall<GetAdGroupLabelRequest, gagvr::AdGroupLabel>(grpcClient.GetAdGroupLabelAsync, grpcClient.GetAdGroupLabel, effectiveSettings.GetAdGroupLabelSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupLabel);
            Modify_GetAdGroupLabelApiCall(ref _callGetAdGroupLabel);
            _callMutateAdGroupLabels = clientHelper.BuildApiCall<MutateAdGroupLabelsRequest, MutateAdGroupLabelsResponse>(grpcClient.MutateAdGroupLabelsAsync, grpcClient.MutateAdGroupLabels, effectiveSettings.MutateAdGroupLabelsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupLabels);
            Modify_MutateAdGroupLabelsApiCall(ref _callMutateAdGroupLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupLabelApiCall(ref gaxgrpc::ApiCall<GetAdGroupLabelRequest, gagvr::AdGroupLabel> call);

        partial void Modify_MutateAdGroupLabelsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupLabelsRequest, MutateAdGroupLabelsResponse> call);

        partial void OnConstruction(AdGroupLabelService.AdGroupLabelServiceClient grpcClient, AdGroupLabelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupLabelService client</summary>
        public override AdGroupLabelService.AdGroupLabelServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupLabelRequest(ref GetAdGroupLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateAdGroupLabelsRequest(ref MutateAdGroupLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroupLabel GetAdGroupLabel(GetAdGroupLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupLabelRequest(ref request, ref callSettings);
            return _callGetAdGroupLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroupLabel> GetAdGroupLabelAsync(GetAdGroupLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupLabelRequest(ref request, ref callSettings);
            return _callGetAdGroupLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and removes ad group labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupLabelsResponse MutateAdGroupLabels(MutateAdGroupLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupLabelsRequest(ref request, ref callSettings);
            return _callMutateAdGroupLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and removes ad group labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupLabelsResponse> MutateAdGroupLabelsAsync(MutateAdGroupLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupLabelsRequest(ref request, ref callSettings);
            return _callMutateAdGroupLabels.Async(request, callSettings);
        }
    }
}

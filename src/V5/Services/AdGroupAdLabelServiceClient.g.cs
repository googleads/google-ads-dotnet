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

using gagvr = Google.Ads.GoogleAds.V5.Resources;
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

namespace Google.Ads.GoogleAds.V5.Services
{
    /// <summary>Settings for <see cref="AdGroupAdLabelServiceClient"/> instances.</summary>
    public sealed partial class AdGroupAdLabelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="AdGroupAdLabelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="AdGroupAdLabelServiceSettings"/>.</returns>
        public static AdGroupAdLabelServiceSettings GetDefault() => new AdGroupAdLabelServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupAdLabelServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupAdLabelServiceSettings()
        {
        }

        private AdGroupAdLabelServiceSettings(AdGroupAdLabelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetAdGroupAdLabelSettings = existing.GetAdGroupAdLabelSettings;
            MutateAdGroupAdLabelsSettings = existing.MutateAdGroupAdLabelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupAdLabelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAdLabelServiceClient.GetAdGroupAdLabel</c> and
        /// <c>AdGroupAdLabelServiceClient.GetAdGroupAdLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetAdGroupAdLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupAdLabelServiceClient.MutateAdGroupAdLabels</c> and
        /// <c>AdGroupAdLabelServiceClient.MutateAdGroupAdLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateAdGroupAdLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupAdLabelServiceSettings"/> object.</returns>
        public AdGroupAdLabelServiceSettings Clone() => new AdGroupAdLabelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupAdLabelServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class AdGroupAdLabelServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupAdLabelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupAdLabelServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref AdGroupAdLabelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupAdLabelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupAdLabelServiceClient Build()
        {
            AdGroupAdLabelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupAdLabelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupAdLabelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupAdLabelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupAdLabelServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<AdGroupAdLabelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupAdLabelServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => AdGroupAdLabelServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => AdGroupAdLabelServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupAdLabelServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>AdGroupAdLabelService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage labels on ad group ads.
    /// </remarks>
    public abstract partial class AdGroupAdLabelServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupAdLabelService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupAdLabelService scopes.</summary>
        /// <remarks>
        /// The default AdGroupAdLabelService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupAdLabelServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupAdLabelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupAdLabelServiceClient"/>.</returns>
        public static stt::Task<AdGroupAdLabelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupAdLabelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupAdLabelServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupAdLabelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupAdLabelServiceClient"/>.</returns>
        public static AdGroupAdLabelServiceClient Create() => new AdGroupAdLabelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupAdLabelServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupAdLabelServiceSettings"/>.</param>
        /// <returns>The created <see cref="AdGroupAdLabelServiceClient"/>.</returns>
        internal static AdGroupAdLabelServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupAdLabelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupAdLabelService.AdGroupAdLabelServiceClient grpcClient = new AdGroupAdLabelService.AdGroupAdLabelServiceClient(callInvoker);
            return new AdGroupAdLabelServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC AdGroupAdLabelService client</summary>
        public virtual AdGroupAdLabelService.AdGroupAdLabelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAdLabel GetAdGroupAdLabel(GetAdGroupAdLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(GetAdGroupAdLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(GetAdGroupAdLabelRequest request, st::CancellationToken cancellationToken) =>
            GetAdGroupAdLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAdLabel GetAdGroupAdLabel(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAdLabel(new GetAdGroupAdLabelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAdLabelAsync(new GetAdGroupAdLabelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad label to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAdLabelAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::AdGroupAdLabel GetAdGroupAdLabel(gagvr::AdGroupAdLabelName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAdLabel(new GetAdGroupAdLabelRequest
            {
                ResourceNameAsAdGroupAdLabelName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(gagvr::AdGroupAdLabelName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetAdGroupAdLabelAsync(new GetAdGroupAdLabelRequest
            {
                ResourceNameAsAdGroupAdLabelName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the ad group ad label to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(gagvr::AdGroupAdLabelName resourceName, st::CancellationToken cancellationToken) =>
            GetAdGroupAdLabelAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupAdLabelsResponse MutateAdGroupAdLabels(MutateAdGroupAdLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(MutateAdGroupAdLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(MutateAdGroupAdLabelsRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupAdLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group ad labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on ad group ad labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupAdLabelsResponse MutateAdGroupAdLabels(string customerId, scg::IEnumerable<AdGroupAdLabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupAdLabels(new MutateAdGroupAdLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group ad labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on ad group ad labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(string customerId, scg::IEnumerable<AdGroupAdLabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupAdLabelsAsync(new MutateAdGroupAdLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose ad group ad labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on ad group ad labels.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(string customerId, scg::IEnumerable<AdGroupAdLabelOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupAdLabelsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupAdLabelService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage labels on ad group ads.
    /// </remarks>
    public sealed partial class AdGroupAdLabelServiceClientImpl : AdGroupAdLabelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetAdGroupAdLabelRequest, gagvr::AdGroupAdLabel> _callGetAdGroupAdLabel;

        private readonly gaxgrpc::ApiCall<MutateAdGroupAdLabelsRequest, MutateAdGroupAdLabelsResponse> _callMutateAdGroupAdLabels;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupAdLabelService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="AdGroupAdLabelServiceSettings"/> used within this client.</param>
        public AdGroupAdLabelServiceClientImpl(AdGroupAdLabelService.AdGroupAdLabelServiceClient grpcClient, AdGroupAdLabelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            AdGroupAdLabelServiceSettings effectiveSettings = settings ?? AdGroupAdLabelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetAdGroupAdLabel = clientHelper.BuildApiCall<GetAdGroupAdLabelRequest, gagvr::AdGroupAdLabel>(grpcClient.GetAdGroupAdLabelAsync, grpcClient.GetAdGroupAdLabel, effectiveSettings.GetAdGroupAdLabelSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetAdGroupAdLabel);
            Modify_GetAdGroupAdLabelApiCall(ref _callGetAdGroupAdLabel);
            _callMutateAdGroupAdLabels = clientHelper.BuildApiCall<MutateAdGroupAdLabelsRequest, MutateAdGroupAdLabelsResponse>(grpcClient.MutateAdGroupAdLabelsAsync, grpcClient.MutateAdGroupAdLabels, effectiveSettings.MutateAdGroupAdLabelsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupAdLabels);
            Modify_MutateAdGroupAdLabelsApiCall(ref _callMutateAdGroupAdLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetAdGroupAdLabelApiCall(ref gaxgrpc::ApiCall<GetAdGroupAdLabelRequest, gagvr::AdGroupAdLabel> call);

        partial void Modify_MutateAdGroupAdLabelsApiCall(ref gaxgrpc::ApiCall<MutateAdGroupAdLabelsRequest, MutateAdGroupAdLabelsResponse> call);

        partial void OnConstruction(AdGroupAdLabelService.AdGroupAdLabelServiceClient grpcClient, AdGroupAdLabelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupAdLabelService client</summary>
        public override AdGroupAdLabelService.AdGroupAdLabelServiceClient GrpcClient { get; }

        partial void Modify_GetAdGroupAdLabelRequest(ref GetAdGroupAdLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateAdGroupAdLabelsRequest(ref MutateAdGroupAdLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::AdGroupAdLabel GetAdGroupAdLabel(GetAdGroupAdLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAdLabelRequest(ref request, ref callSettings);
            return _callGetAdGroupAdLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested ad group ad label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::AdGroupAdLabel> GetAdGroupAdLabelAsync(GetAdGroupAdLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetAdGroupAdLabelRequest(ref request, ref callSettings);
            return _callGetAdGroupAdLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupAdLabelsResponse MutateAdGroupAdLabels(MutateAdGroupAdLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAdLabelsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAdLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates and removes ad group ad labels.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupAdLabelsResponse> MutateAdGroupAdLabelsAsync(MutateAdGroupAdLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupAdLabelsRequest(ref request, ref callSettings);
            return _callMutateAdGroupAdLabels.Async(request, callSettings);
        }
    }
}

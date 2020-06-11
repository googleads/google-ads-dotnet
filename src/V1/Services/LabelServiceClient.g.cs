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

using gagvr = Google.Ads.GoogleAds.V1.Resources;
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

namespace Google.Ads.GoogleAds.V1.Services
{
    /// <summary>Settings for <see cref="LabelServiceClient"/> instances.</summary>
    public sealed partial class LabelServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="LabelServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="LabelServiceSettings"/>.</returns>
        public static LabelServiceSettings GetDefault() => new LabelServiceSettings();

        /// <summary>Constructs a new <see cref="LabelServiceSettings"/> object with default settings.</summary>
        public LabelServiceSettings()
        {
        }

        private LabelServiceSettings(LabelServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetLabelSettings = existing.GetLabelSettings;
            MutateLabelsSettings = existing.MutateLabelsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(LabelServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to <c>LabelServiceClient.GetLabel</c>
        ///  and <c>LabelServiceClient.GetLabelAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetLabelSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>LabelServiceClient.MutateLabels</c> and <c>LabelServiceClient.MutateLabelsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateLabelsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="LabelServiceSettings"/> object.</returns>
        public LabelServiceSettings Clone() => new LabelServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="LabelServiceClient"/> to provide simple configuration of credentials, endpoint etc.
    /// </summary>
    public sealed partial class LabelServiceClientBuilder : gaxgrpc::ClientBuilderBase<LabelServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public LabelServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref LabelServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<LabelServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override LabelServiceClient Build()
        {
            LabelServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<LabelServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<LabelServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private LabelServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return LabelServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<LabelServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return LabelServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => LabelServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => LabelServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => LabelServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>LabelService client wrapper, for convenient use.</summary>
    public abstract partial class LabelServiceClient
    {
        /// <summary>
        /// The default endpoint for the LabelService service, which is a host of "googleads.googleapis.com" and a port
        /// of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default LabelService scopes.</summary>
        /// <remarks>The default LabelService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="LabelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LabelServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="LabelServiceClient"/>.</returns>
        public static stt::Task<LabelServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new LabelServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="LabelServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="LabelServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="LabelServiceClient"/>.</returns>
        public static LabelServiceClient Create() => new LabelServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="LabelServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="LabelServiceSettings"/>.</param>
        /// <returns>The created <see cref="LabelServiceClient"/>.</returns>
        internal static LabelServiceClient Create(grpccore::CallInvoker callInvoker, LabelServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            LabelService.LabelServiceClient grpcClient = new LabelService.LabelServiceClient(callInvoker);
            return new LabelServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC LabelService client</summary>
        public virtual LabelService.LabelServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Label GetLabel(GetLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Label> GetLabelAsync(GetLabelRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Label> GetLabelAsync(GetLabelRequest request, st::CancellationToken cancellationToken) =>
            GetLabelAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Label GetLabel(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLabel(new GetLabelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Label> GetLabelAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLabelAsync(new GetLabelRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the label to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Label> GetLabelAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetLabelAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::Label GetLabel(gagvr::LabelName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLabel(new GetLabelRequest
            {
                ResourceNameAsLabelName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the label to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Label> GetLabelAsync(gagvr::LabelName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetLabelAsync(new GetLabelRequest
            {
                ResourceNameAsLabelName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the label to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::Label> GetLabelAsync(gagvr::LabelName resourceName, st::CancellationToken cancellationToken) =>
            GetLabelAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes labels. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateLabelsResponse MutateLabels(MutateLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes labels. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateLabelsResponse> MutateLabelsAsync(MutateLabelsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes labels. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateLabelsResponse> MutateLabelsAsync(MutateLabelsRequest request, st::CancellationToken cancellationToken) =>
            MutateLabelsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes labels. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateLabelsResponse MutateLabels(string customerId, scg::IEnumerable<LabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateLabels(new MutateLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes labels. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on labels.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateLabelsResponse> MutateLabelsAsync(string customerId, scg::IEnumerable<LabelOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateLabelsAsync(new MutateLabelsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes labels. Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose labels are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on labels.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateLabelsResponse> MutateLabelsAsync(string customerId, scg::IEnumerable<LabelOperation> operations, st::CancellationToken cancellationToken) =>
            MutateLabelsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>LabelService client wrapper implementation, for convenient use.</summary>
    public sealed partial class LabelServiceClientImpl : LabelServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetLabelRequest, gagvr::Label> _callGetLabel;

        private readonly gaxgrpc::ApiCall<MutateLabelsRequest, MutateLabelsResponse> _callMutateLabels;

        /// <summary>
        /// Constructs a client wrapper for the LabelService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="LabelServiceSettings"/> used within this client.</param>
        public LabelServiceClientImpl(LabelService.LabelServiceClient grpcClient, LabelServiceSettings settings)
        {
            GrpcClient = grpcClient;
            LabelServiceSettings effectiveSettings = settings ?? LabelServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetLabel = clientHelper.BuildApiCall<GetLabelRequest, gagvr::Label>(grpcClient.GetLabelAsync, grpcClient.GetLabel, effectiveSettings.GetLabelSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetLabel);
            Modify_GetLabelApiCall(ref _callGetLabel);
            _callMutateLabels = clientHelper.BuildApiCall<MutateLabelsRequest, MutateLabelsResponse>(grpcClient.MutateLabelsAsync, grpcClient.MutateLabels, effectiveSettings.MutateLabelsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateLabels);
            Modify_MutateLabelsApiCall(ref _callMutateLabels);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetLabelApiCall(ref gaxgrpc::ApiCall<GetLabelRequest, gagvr::Label> call);

        partial void Modify_MutateLabelsApiCall(ref gaxgrpc::ApiCall<MutateLabelsRequest, MutateLabelsResponse> call);

        partial void OnConstruction(LabelService.LabelServiceClient grpcClient, LabelServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC LabelService client</summary>
        public override LabelService.LabelServiceClient GrpcClient { get; }

        partial void Modify_GetLabelRequest(ref GetLabelRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateLabelsRequest(ref MutateLabelsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::Label GetLabel(GetLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLabelRequest(ref request, ref callSettings);
            return _callGetLabel.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested label in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::Label> GetLabelAsync(GetLabelRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetLabelRequest(ref request, ref callSettings);
            return _callGetLabel.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes labels. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateLabelsResponse MutateLabels(MutateLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateLabelsRequest(ref request, ref callSettings);
            return _callMutateLabels.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes labels. Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateLabelsResponse> MutateLabelsAsync(MutateLabelsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateLabelsRequest(ref request, ref callSettings);
            return _callMutateLabels.Async(request, callSettings);
        }
    }
}

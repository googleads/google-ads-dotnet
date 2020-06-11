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
    /// <summary>Settings for <see cref="ConversionUploadServiceClient"/> instances.</summary>
    public sealed partial class ConversionUploadServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversionUploadServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversionUploadServiceSettings"/>.</returns>
        public static ConversionUploadServiceSettings GetDefault() => new ConversionUploadServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionUploadServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionUploadServiceSettings()
        {
        }

        private ConversionUploadServiceSettings(ConversionUploadServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UploadClickConversionsSettings = existing.UploadClickConversionsSettings;
            UploadCallConversionsSettings = existing.UploadCallConversionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionUploadServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionUploadServiceClient.UploadClickConversions</c> and
        /// <c>ConversionUploadServiceClient.UploadClickConversionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UploadClickConversionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionUploadServiceClient.UploadCallConversions</c> and
        /// <c>ConversionUploadServiceClient.UploadCallConversionsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings UploadCallConversionsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversionUploadServiceSettings"/> object.</returns>
        public ConversionUploadServiceSettings Clone() => new ConversionUploadServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversionUploadServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class ConversionUploadServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversionUploadServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversionUploadServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref ConversionUploadServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversionUploadServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversionUploadServiceClient Build()
        {
            ConversionUploadServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversionUploadServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversionUploadServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversionUploadServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversionUploadServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ConversionUploadServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversionUploadServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ConversionUploadServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ConversionUploadServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversionUploadServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ConversionUploadService client wrapper, for convenient use.</summary>
    public abstract partial class ConversionUploadServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionUploadService service, which is a host of "googleads.googleapis.com"
        /// and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ConversionUploadService scopes.</summary>
        /// <remarks>The default ConversionUploadService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversionUploadServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionUploadServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversionUploadServiceClient"/>.</returns>
        public static stt::Task<ConversionUploadServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversionUploadServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversionUploadServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionUploadServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversionUploadServiceClient"/>.</returns>
        public static ConversionUploadServiceClient Create() => new ConversionUploadServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversionUploadServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversionUploadServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionUploadServiceClient"/>.</returns>
        internal static ConversionUploadServiceClient Create(grpccore::CallInvoker callInvoker, ConversionUploadServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionUploadService.ConversionUploadServiceClient grpcClient = new ConversionUploadService.ConversionUploadServiceClient(callInvoker);
            return new ConversionUploadServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ConversionUploadService client</summary>
        public virtual ConversionUploadService.ConversionUploadServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadClickConversionsResponse UploadClickConversions(UploadClickConversionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(UploadClickConversionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(UploadClickConversionsRequest request, st::CancellationToken cancellationToken) =>
            UploadClickConversionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// Required. The conversions that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// This should always be set to true.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadClickConversionsResponse UploadClickConversions(string customerId, scg::IEnumerable<ClickConversion> conversions, bool partialFailure, gaxgrpc::CallSettings callSettings = null) =>
            UploadClickConversions(new UploadClickConversionsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Conversions =
                {
                    gax::GaxPreconditions.CheckNotNull(conversions, nameof(conversions)),
                },
                PartialFailure = partialFailure,
            }, callSettings);

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// Required. The conversions that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// This should always be set to true.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(string customerId, scg::IEnumerable<ClickConversion> conversions, bool partialFailure, gaxgrpc::CallSettings callSettings = null) =>
            UploadClickConversionsAsync(new UploadClickConversionsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Conversions =
                {
                    gax::GaxPreconditions.CheckNotNull(conversions, nameof(conversions)),
                },
                PartialFailure = partialFailure,
            }, callSettings);

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// Required. The conversions that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// This should always be set to true.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(string customerId, scg::IEnumerable<ClickConversion> conversions, bool partialFailure, st::CancellationToken cancellationToken) =>
            UploadClickConversionsAsync(customerId, conversions, partialFailure, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes the given call conversions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadCallConversionsResponse UploadCallConversions(UploadCallConversionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes the given call conversions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadCallConversionsResponse> UploadCallConversionsAsync(UploadCallConversionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes the given call conversions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadCallConversionsResponse> UploadCallConversionsAsync(UploadCallConversionsRequest request, st::CancellationToken cancellationToken) =>
            UploadCallConversionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes the given call conversions.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// Required. The conversions that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// This should always be set to true.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadCallConversionsResponse UploadCallConversions(string customerId, scg::IEnumerable<CallConversion> conversions, bool partialFailure, gaxgrpc::CallSettings callSettings = null) =>
            UploadCallConversions(new UploadCallConversionsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Conversions =
                {
                    gax::GaxPreconditions.CheckNotNull(conversions, nameof(conversions)),
                },
                PartialFailure = partialFailure,
            }, callSettings);

        /// <summary>
        /// Processes the given call conversions.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// Required. The conversions that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// This should always be set to true.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadCallConversionsResponse> UploadCallConversionsAsync(string customerId, scg::IEnumerable<CallConversion> conversions, bool partialFailure, gaxgrpc::CallSettings callSettings = null) =>
            UploadCallConversionsAsync(new UploadCallConversionsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Conversions =
                {
                    gax::GaxPreconditions.CheckNotNull(conversions, nameof(conversions)),
                },
                PartialFailure = partialFailure,
            }, callSettings);

        /// <summary>
        /// Processes the given call conversions.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversions">
        /// Required. The conversions that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// This should always be set to true.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadCallConversionsResponse> UploadCallConversionsAsync(string customerId, scg::IEnumerable<CallConversion> conversions, bool partialFailure, st::CancellationToken cancellationToken) =>
            UploadCallConversionsAsync(customerId, conversions, partialFailure, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConversionUploadService client wrapper implementation, for convenient use.</summary>
    public sealed partial class ConversionUploadServiceClientImpl : ConversionUploadServiceClient
    {
        private readonly gaxgrpc::ApiCall<UploadClickConversionsRequest, UploadClickConversionsResponse> _callUploadClickConversions;

        private readonly gaxgrpc::ApiCall<UploadCallConversionsRequest, UploadCallConversionsResponse> _callUploadCallConversions;

        /// <summary>
        /// Constructs a client wrapper for the ConversionUploadService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConversionUploadServiceSettings"/> used within this client.
        /// </param>
        public ConversionUploadServiceClientImpl(ConversionUploadService.ConversionUploadServiceClient grpcClient, ConversionUploadServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ConversionUploadServiceSettings effectiveSettings = settings ?? ConversionUploadServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callUploadClickConversions = clientHelper.BuildApiCall<UploadClickConversionsRequest, UploadClickConversionsResponse>(grpcClient.UploadClickConversionsAsync, grpcClient.UploadClickConversions, effectiveSettings.UploadClickConversionsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callUploadClickConversions);
            Modify_UploadClickConversionsApiCall(ref _callUploadClickConversions);
            _callUploadCallConversions = clientHelper.BuildApiCall<UploadCallConversionsRequest, UploadCallConversionsResponse>(grpcClient.UploadCallConversionsAsync, grpcClient.UploadCallConversions, effectiveSettings.UploadCallConversionsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callUploadCallConversions);
            Modify_UploadCallConversionsApiCall(ref _callUploadCallConversions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UploadClickConversionsApiCall(ref gaxgrpc::ApiCall<UploadClickConversionsRequest, UploadClickConversionsResponse> call);

        partial void Modify_UploadCallConversionsApiCall(ref gaxgrpc::ApiCall<UploadCallConversionsRequest, UploadCallConversionsResponse> call);

        partial void OnConstruction(ConversionUploadService.ConversionUploadServiceClient grpcClient, ConversionUploadServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversionUploadService client</summary>
        public override ConversionUploadService.ConversionUploadServiceClient GrpcClient { get; }

        partial void Modify_UploadClickConversionsRequest(ref UploadClickConversionsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_UploadCallConversionsRequest(ref UploadCallConversionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UploadClickConversionsResponse UploadClickConversions(UploadClickConversionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadClickConversionsRequest(ref request, ref callSettings);
            return _callUploadClickConversions.Sync(request, callSettings);
        }

        /// <summary>
        /// Processes the given click conversions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UploadClickConversionsResponse> UploadClickConversionsAsync(UploadClickConversionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadClickConversionsRequest(ref request, ref callSettings);
            return _callUploadClickConversions.Async(request, callSettings);
        }

        /// <summary>
        /// Processes the given call conversions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UploadCallConversionsResponse UploadCallConversions(UploadCallConversionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadCallConversionsRequest(ref request, ref callSettings);
            return _callUploadCallConversions.Sync(request, callSettings);
        }

        /// <summary>
        /// Processes the given call conversions.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UploadCallConversionsResponse> UploadCallConversionsAsync(UploadCallConversionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadCallConversionsRequest(ref request, ref callSettings);
            return _callUploadCallConversions.Async(request, callSettings);
        }
    }
}

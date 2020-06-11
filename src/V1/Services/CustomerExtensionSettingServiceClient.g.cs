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
    /// <summary>Settings for <see cref="CustomerExtensionSettingServiceClient"/> instances.</summary>
    public sealed partial class CustomerExtensionSettingServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomerExtensionSettingServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomerExtensionSettingServiceSettings"/>.</returns>
        public static CustomerExtensionSettingServiceSettings GetDefault() => new CustomerExtensionSettingServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerExtensionSettingServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerExtensionSettingServiceSettings()
        {
        }

        private CustomerExtensionSettingServiceSettings(CustomerExtensionSettingServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerExtensionSettingSettings = existing.GetCustomerExtensionSettingSettings;
            MutateCustomerExtensionSettingsSettings = existing.MutateCustomerExtensionSettingsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerExtensionSettingServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerExtensionSettingServiceClient.GetCustomerExtensionSetting</c> and
        /// <c>CustomerExtensionSettingServiceClient.GetCustomerExtensionSettingAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomerExtensionSettingSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerExtensionSettingServiceClient.MutateCustomerExtensionSettings</c> and
        /// <c>CustomerExtensionSettingServiceClient.MutateCustomerExtensionSettingsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCustomerExtensionSettingsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerExtensionSettingServiceSettings"/> object.</returns>
        public CustomerExtensionSettingServiceSettings Clone() => new CustomerExtensionSettingServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerExtensionSettingServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    public sealed partial class CustomerExtensionSettingServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerExtensionSettingServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerExtensionSettingServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CustomerExtensionSettingServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerExtensionSettingServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerExtensionSettingServiceClient Build()
        {
            CustomerExtensionSettingServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerExtensionSettingServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerExtensionSettingServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerExtensionSettingServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerExtensionSettingServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CustomerExtensionSettingServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerExtensionSettingServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CustomerExtensionSettingServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            CustomerExtensionSettingServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerExtensionSettingServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CustomerExtensionSettingService client wrapper, for convenient use.</summary>
    public abstract partial class CustomerExtensionSettingServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerExtensionSettingService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerExtensionSettingService scopes.</summary>
        /// <remarks>The default CustomerExtensionSettingService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerExtensionSettingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerExtensionSettingServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomerExtensionSettingServiceClient"/>.</returns>
        public static stt::Task<CustomerExtensionSettingServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerExtensionSettingServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerExtensionSettingServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerExtensionSettingServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerExtensionSettingServiceClient"/>.</returns>
        public static CustomerExtensionSettingServiceClient Create() =>
            new CustomerExtensionSettingServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerExtensionSettingServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerExtensionSettingServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerExtensionSettingServiceClient"/>.</returns>
        internal static CustomerExtensionSettingServiceClient Create(grpccore::CallInvoker callInvoker, CustomerExtensionSettingServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerExtensionSettingService.CustomerExtensionSettingServiceClient grpcClient = new CustomerExtensionSettingService.CustomerExtensionSettingServiceClient(callInvoker);
            return new CustomerExtensionSettingServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CustomerExtensionSettingService client</summary>
        public virtual CustomerExtensionSettingService.CustomerExtensionSettingServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerExtensionSetting GetCustomerExtensionSetting(GetCustomerExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerExtensionSetting> GetCustomerExtensionSettingAsync(GetCustomerExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerExtensionSetting> GetCustomerExtensionSettingAsync(GetCustomerExtensionSettingRequest request, st::CancellationToken cancellationToken) =>
            GetCustomerExtensionSettingAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerExtensionSetting GetCustomerExtensionSetting(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerExtensionSetting(new GetCustomerExtensionSettingRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerExtensionSetting> GetCustomerExtensionSettingAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerExtensionSettingAsync(new GetCustomerExtensionSettingRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer extension setting to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerExtensionSetting> GetCustomerExtensionSettingAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerExtensionSettingAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerExtensionSetting GetCustomerExtensionSetting(gagvr::CustomerExtensionSettingName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerExtensionSetting(new GetCustomerExtensionSettingRequest
            {
                ResourceNameAsCustomerExtensionSettingName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer extension setting to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerExtensionSetting> GetCustomerExtensionSettingAsync(gagvr::CustomerExtensionSettingName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerExtensionSettingAsync(new GetCustomerExtensionSettingRequest
            {
                ResourceNameAsCustomerExtensionSettingName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the customer extension setting to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerExtensionSetting> GetCustomerExtensionSettingAsync(gagvr::CustomerExtensionSettingName resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerExtensionSettingAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes customer extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerExtensionSettingsResponse MutateCustomerExtensionSettings(MutateCustomerExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes customer extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerExtensionSettingsResponse> MutateCustomerExtensionSettingsAsync(MutateCustomerExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes customer extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerExtensionSettingsResponse> MutateCustomerExtensionSettingsAsync(MutateCustomerExtensionSettingsRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerExtensionSettingsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes customer extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer extension settings are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer extension
        /// settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerExtensionSettingsResponse MutateCustomerExtensionSettings(string customerId, scg::IEnumerable<CustomerExtensionSettingOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerExtensionSettings(new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes customer extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer extension settings are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer extension
        /// settings.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerExtensionSettingsResponse> MutateCustomerExtensionSettingsAsync(string customerId, scg::IEnumerable<CustomerExtensionSettingOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerExtensionSettingsAsync(new MutateCustomerExtensionSettingsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes customer extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customer extension settings are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customer extension
        /// settings.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerExtensionSettingsResponse> MutateCustomerExtensionSettingsAsync(string customerId, scg::IEnumerable<CustomerExtensionSettingOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomerExtensionSettingsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerExtensionSettingService client wrapper implementation, for convenient use.</summary>
    public sealed partial class CustomerExtensionSettingServiceClientImpl : CustomerExtensionSettingServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerExtensionSettingRequest, gagvr::CustomerExtensionSetting> _callGetCustomerExtensionSetting;

        private readonly gaxgrpc::ApiCall<MutateCustomerExtensionSettingsRequest, MutateCustomerExtensionSettingsResponse> _callMutateCustomerExtensionSettings;

        /// <summary>
        /// Constructs a client wrapper for the CustomerExtensionSettingService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerExtensionSettingServiceSettings"/> used within this client.
        /// </param>
        public CustomerExtensionSettingServiceClientImpl(CustomerExtensionSettingService.CustomerExtensionSettingServiceClient grpcClient, CustomerExtensionSettingServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerExtensionSettingServiceSettings effectiveSettings = settings ?? CustomerExtensionSettingServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomerExtensionSetting = clientHelper.BuildApiCall<GetCustomerExtensionSettingRequest, gagvr::CustomerExtensionSetting>(grpcClient.GetCustomerExtensionSettingAsync, grpcClient.GetCustomerExtensionSetting, effectiveSettings.GetCustomerExtensionSettingSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCustomerExtensionSetting);
            Modify_GetCustomerExtensionSettingApiCall(ref _callGetCustomerExtensionSetting);
            _callMutateCustomerExtensionSettings = clientHelper.BuildApiCall<MutateCustomerExtensionSettingsRequest, MutateCustomerExtensionSettingsResponse>(grpcClient.MutateCustomerExtensionSettingsAsync, grpcClient.MutateCustomerExtensionSettings, effectiveSettings.MutateCustomerExtensionSettingsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerExtensionSettings);
            Modify_MutateCustomerExtensionSettingsApiCall(ref _callMutateCustomerExtensionSettings);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomerExtensionSettingApiCall(ref gaxgrpc::ApiCall<GetCustomerExtensionSettingRequest, gagvr::CustomerExtensionSetting> call);

        partial void Modify_MutateCustomerExtensionSettingsApiCall(ref gaxgrpc::ApiCall<MutateCustomerExtensionSettingsRequest, MutateCustomerExtensionSettingsResponse> call);

        partial void OnConstruction(CustomerExtensionSettingService.CustomerExtensionSettingServiceClient grpcClient, CustomerExtensionSettingServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerExtensionSettingService client</summary>
        public override CustomerExtensionSettingService.CustomerExtensionSettingServiceClient GrpcClient { get; }

        partial void Modify_GetCustomerExtensionSettingRequest(ref GetCustomerExtensionSettingRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCustomerExtensionSettingsRequest(ref MutateCustomerExtensionSettingsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CustomerExtensionSetting GetCustomerExtensionSetting(GetCustomerExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerExtensionSettingRequest(ref request, ref callSettings);
            return _callGetCustomerExtensionSetting.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested customer extension setting in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CustomerExtensionSetting> GetCustomerExtensionSettingAsync(GetCustomerExtensionSettingRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerExtensionSettingRequest(ref request, ref callSettings);
            return _callGetCustomerExtensionSetting.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes customer extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerExtensionSettingsResponse MutateCustomerExtensionSettings(MutateCustomerExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerExtensionSettingsRequest(ref request, ref callSettings);
            return _callMutateCustomerExtensionSettings.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes customer extension settings. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerExtensionSettingsResponse> MutateCustomerExtensionSettingsAsync(MutateCustomerExtensionSettingsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerExtensionSettingsRequest(ref request, ref callSettings);
            return _callMutateCustomerExtensionSettings.Async(request, callSettings);
        }
    }
}

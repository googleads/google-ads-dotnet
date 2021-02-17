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
    /// <summary>Settings for <see cref="CustomerUserAccessInvitationServiceClient"/> instances.</summary>
    public sealed partial class CustomerUserAccessInvitationServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="CustomerUserAccessInvitationServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="CustomerUserAccessInvitationServiceSettings"/>.</returns>
        public static CustomerUserAccessInvitationServiceSettings GetDefault() =>
            new CustomerUserAccessInvitationServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomerUserAccessInvitationServiceSettings"/> object with default settings.
        /// </summary>
        public CustomerUserAccessInvitationServiceSettings()
        {
        }

        private CustomerUserAccessInvitationServiceSettings(CustomerUserAccessInvitationServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCustomerUserAccessInvitationSettings = existing.GetCustomerUserAccessInvitationSettings;
            MutateCustomerUserAccessInvitationSettings = existing.MutateCustomerUserAccessInvitationSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomerUserAccessInvitationServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerUserAccessInvitationServiceClient.GetCustomerUserAccessInvitation</c> and
        /// <c>CustomerUserAccessInvitationServiceClient.GetCustomerUserAccessInvitationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetCustomerUserAccessInvitationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomerUserAccessInvitationServiceClient.MutateCustomerUserAccessInvitation</c> and
        /// <c>CustomerUserAccessInvitationServiceClient.MutateCustomerUserAccessInvitationAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateCustomerUserAccessInvitationSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomerUserAccessInvitationServiceSettings"/> object.</returns>
        public CustomerUserAccessInvitationServiceSettings Clone() => new CustomerUserAccessInvitationServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomerUserAccessInvitationServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class CustomerUserAccessInvitationServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomerUserAccessInvitationServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomerUserAccessInvitationServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref CustomerUserAccessInvitationServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomerUserAccessInvitationServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomerUserAccessInvitationServiceClient Build()
        {
            CustomerUserAccessInvitationServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomerUserAccessInvitationServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomerUserAccessInvitationServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomerUserAccessInvitationServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomerUserAccessInvitationServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CustomerUserAccessInvitationServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomerUserAccessInvitationServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CustomerUserAccessInvitationServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            CustomerUserAccessInvitationServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomerUserAccessInvitationServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CustomerUserAccessInvitationService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// This service manages the access invitation extended to users for a given
    /// customer.
    /// </remarks>
    public abstract partial class CustomerUserAccessInvitationServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomerUserAccessInvitationService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomerUserAccessInvitationService scopes.</summary>
        /// <remarks>
        /// The default CustomerUserAccessInvitationService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomerUserAccessInvitationServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerUserAccessInvitationServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="CustomerUserAccessInvitationServiceClient"/>.
        /// </returns>
        public static stt::Task<CustomerUserAccessInvitationServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomerUserAccessInvitationServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomerUserAccessInvitationServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomerUserAccessInvitationServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomerUserAccessInvitationServiceClient"/>.</returns>
        public static CustomerUserAccessInvitationServiceClient Create() =>
            new CustomerUserAccessInvitationServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomerUserAccessInvitationServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomerUserAccessInvitationServiceSettings"/>.</param>
        /// <returns>The created <see cref="CustomerUserAccessInvitationServiceClient"/>.</returns>
        internal static CustomerUserAccessInvitationServiceClient Create(grpccore::CallInvoker callInvoker, CustomerUserAccessInvitationServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient grpcClient = new CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient(callInvoker);
            return new CustomerUserAccessInvitationServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CustomerUserAccessInvitationService client</summary>
        public virtual CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerUserAccessInvitation GetCustomerUserAccessInvitation(GetCustomerUserAccessInvitationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerUserAccessInvitation> GetCustomerUserAccessInvitationAsync(GetCustomerUserAccessInvitationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerUserAccessInvitation> GetCustomerUserAccessInvitationAsync(GetCustomerUserAccessInvitationRequest request, st::CancellationToken cancellationToken) =>
            GetCustomerUserAccessInvitationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the access invitation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerUserAccessInvitation GetCustomerUserAccessInvitation(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerUserAccessInvitation(new GetCustomerUserAccessInvitationRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the access invitation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerUserAccessInvitation> GetCustomerUserAccessInvitationAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerUserAccessInvitationAsync(new GetCustomerUserAccessInvitationRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the access invitation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerUserAccessInvitation> GetCustomerUserAccessInvitationAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerUserAccessInvitationAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the access invitation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CustomerUserAccessInvitation GetCustomerUserAccessInvitation(gagvr::CustomerUserAccessInvitationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerUserAccessInvitation(new GetCustomerUserAccessInvitationRequest
            {
                ResourceNameAsCustomerUserAccessInvitationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the access invitation.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerUserAccessInvitation> GetCustomerUserAccessInvitationAsync(gagvr::CustomerUserAccessInvitationName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCustomerUserAccessInvitationAsync(new GetCustomerUserAccessInvitationRequest
            {
                ResourceNameAsCustomerUserAccessInvitationName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="resourceName">
        /// Required. Resource name of the access invitation.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CustomerUserAccessInvitation> GetCustomerUserAccessInvitationAsync(gagvr::CustomerUserAccessInvitationName resourceName, st::CancellationToken cancellationToken) =>
            GetCustomerUserAccessInvitationAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes an access invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerUserAccessInvitationResponse MutateCustomerUserAccessInvitation(MutateCustomerUserAccessInvitationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes an access invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerUserAccessInvitationResponse> MutateCustomerUserAccessInvitationAsync(MutateCustomerUserAccessInvitationRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates or removes an access invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerUserAccessInvitationResponse> MutateCustomerUserAccessInvitationAsync(MutateCustomerUserAccessInvitationRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomerUserAccessInvitationAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates or removes an access invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose access invitation is being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the access invitation
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomerUserAccessInvitationResponse MutateCustomerUserAccessInvitation(string customerId, CustomerUserAccessInvitationOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerUserAccessInvitation(new MutateCustomerUserAccessInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates or removes an access invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose access invitation is being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the access invitation
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerUserAccessInvitationResponse> MutateCustomerUserAccessInvitationAsync(string customerId, CustomerUserAccessInvitationOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomerUserAccessInvitationAsync(new MutateCustomerUserAccessInvitationRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Creates or removes an access invitation.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose access invitation is being modified.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on the access invitation
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomerUserAccessInvitationResponse> MutateCustomerUserAccessInvitationAsync(string customerId, CustomerUserAccessInvitationOperation operation, st::CancellationToken cancellationToken) =>
            MutateCustomerUserAccessInvitationAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomerUserAccessInvitationService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// This service manages the access invitation extended to users for a given
    /// customer.
    /// </remarks>
    public sealed partial class CustomerUserAccessInvitationServiceClientImpl : CustomerUserAccessInvitationServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCustomerUserAccessInvitationRequest, gagvr::CustomerUserAccessInvitation> _callGetCustomerUserAccessInvitation;

        private readonly gaxgrpc::ApiCall<MutateCustomerUserAccessInvitationRequest, MutateCustomerUserAccessInvitationResponse> _callMutateCustomerUserAccessInvitation;

        /// <summary>
        /// Constructs a client wrapper for the CustomerUserAccessInvitationService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomerUserAccessInvitationServiceSettings"/> used within this client.
        /// </param>
        public CustomerUserAccessInvitationServiceClientImpl(CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient grpcClient, CustomerUserAccessInvitationServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CustomerUserAccessInvitationServiceSettings effectiveSettings = settings ?? CustomerUserAccessInvitationServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetCustomerUserAccessInvitation = clientHelper.BuildApiCall<GetCustomerUserAccessInvitationRequest, gagvr::CustomerUserAccessInvitation>(grpcClient.GetCustomerUserAccessInvitationAsync, grpcClient.GetCustomerUserAccessInvitation, effectiveSettings.GetCustomerUserAccessInvitationSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCustomerUserAccessInvitation);
            Modify_GetCustomerUserAccessInvitationApiCall(ref _callGetCustomerUserAccessInvitation);
            _callMutateCustomerUserAccessInvitation = clientHelper.BuildApiCall<MutateCustomerUserAccessInvitationRequest, MutateCustomerUserAccessInvitationResponse>(grpcClient.MutateCustomerUserAccessInvitationAsync, grpcClient.MutateCustomerUserAccessInvitation, effectiveSettings.MutateCustomerUserAccessInvitationSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomerUserAccessInvitation);
            Modify_MutateCustomerUserAccessInvitationApiCall(ref _callMutateCustomerUserAccessInvitation);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCustomerUserAccessInvitationApiCall(ref gaxgrpc::ApiCall<GetCustomerUserAccessInvitationRequest, gagvr::CustomerUserAccessInvitation> call);

        partial void Modify_MutateCustomerUserAccessInvitationApiCall(ref gaxgrpc::ApiCall<MutateCustomerUserAccessInvitationRequest, MutateCustomerUserAccessInvitationResponse> call);

        partial void OnConstruction(CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient grpcClient, CustomerUserAccessInvitationServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomerUserAccessInvitationService client</summary>
        public override CustomerUserAccessInvitationService.CustomerUserAccessInvitationServiceClient GrpcClient { get; }

        partial void Modify_GetCustomerUserAccessInvitationRequest(ref GetCustomerUserAccessInvitationRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCustomerUserAccessInvitationRequest(ref MutateCustomerUserAccessInvitationRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::CustomerUserAccessInvitation GetCustomerUserAccessInvitation(GetCustomerUserAccessInvitationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerUserAccessInvitationRequest(ref request, ref callSettings);
            return _callGetCustomerUserAccessInvitation.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested access invitation in full detail.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CustomerUserAccessInvitation> GetCustomerUserAccessInvitationAsync(GetCustomerUserAccessInvitationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCustomerUserAccessInvitationRequest(ref request, ref callSettings);
            return _callGetCustomerUserAccessInvitation.Async(request, callSettings);
        }

        /// <summary>
        /// Creates or removes an access invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomerUserAccessInvitationResponse MutateCustomerUserAccessInvitation(MutateCustomerUserAccessInvitationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerUserAccessInvitationRequest(ref request, ref callSettings);
            return _callMutateCustomerUserAccessInvitation.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates or removes an access invitation.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomerUserAccessInvitationResponse> MutateCustomerUserAccessInvitationAsync(MutateCustomerUserAccessInvitationRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomerUserAccessInvitationRequest(ref request, ref callSettings);
            return _callMutateCustomerUserAccessInvitation.Async(request, callSettings);
        }
    }
}

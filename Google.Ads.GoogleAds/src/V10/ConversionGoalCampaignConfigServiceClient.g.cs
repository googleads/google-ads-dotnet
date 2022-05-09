// Copyright 2022 Google LLC
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

namespace Google.Ads.GoogleAds.V10.Services
{
    /// <summary>Settings for <see cref="ConversionGoalCampaignConfigServiceClient"/> instances.</summary>
    public sealed partial class ConversionGoalCampaignConfigServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ConversionGoalCampaignConfigServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="ConversionGoalCampaignConfigServiceSettings"/>.</returns>
        public static ConversionGoalCampaignConfigServiceSettings GetDefault() =>
            new ConversionGoalCampaignConfigServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionGoalCampaignConfigServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionGoalCampaignConfigServiceSettings()
        {
        }

        private ConversionGoalCampaignConfigServiceSettings(ConversionGoalCampaignConfigServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateConversionGoalCampaignConfigsSettings = existing.MutateConversionGoalCampaignConfigsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionGoalCampaignConfigServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionGoalCampaignConfigServiceClient.MutateConversionGoalCampaignConfigs</c> and
        /// <c>ConversionGoalCampaignConfigServiceClient.MutateConversionGoalCampaignConfigsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>Initial retry delay: 5000 milliseconds.</description></item>
        /// <item><description>Retry delay multiplier: 1.3</description></item>
        /// <item><description>Retry maximum delay: 60000 milliseconds.</description></item>
        /// <item><description>Maximum attempts: Unlimited</description></item>
        /// <item>
        /// <description>
        /// Retriable status codes: <see cref="grpccore::StatusCode.Unavailable"/>,
        /// <see cref="grpccore::StatusCode.DeadlineExceeded"/>.
        /// </description>
        /// </item>
        /// <item><description>Timeout: 14400 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateConversionGoalCampaignConfigsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversionGoalCampaignConfigServiceSettings"/> object.</returns>
        public ConversionGoalCampaignConfigServiceSettings Clone() => new ConversionGoalCampaignConfigServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversionGoalCampaignConfigServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class ConversionGoalCampaignConfigServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversionGoalCampaignConfigServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversionGoalCampaignConfigServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversionGoalCampaignConfigServiceClientBuilder()
        {
            UseJwtAccessWithScopes = ConversionGoalCampaignConfigServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ConversionGoalCampaignConfigServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversionGoalCampaignConfigServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversionGoalCampaignConfigServiceClient Build()
        {
            ConversionGoalCampaignConfigServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversionGoalCampaignConfigServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversionGoalCampaignConfigServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversionGoalCampaignConfigServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversionGoalCampaignConfigServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ConversionGoalCampaignConfigServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversionGoalCampaignConfigServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ConversionGoalCampaignConfigServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            ConversionGoalCampaignConfigServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversionGoalCampaignConfigServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ConversionGoalCampaignConfigService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage conversion goal campaign config.
    /// </remarks>
    public abstract partial class ConversionGoalCampaignConfigServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionGoalCampaignConfigService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ConversionGoalCampaignConfigService scopes.</summary>
        /// <remarks>
        /// The default ConversionGoalCampaignConfigService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes, UseJwtAccessWithScopes);

        internal static bool UseJwtAccessWithScopes
        {
            get
            {
                bool useJwtAccessWithScopes = true;
                MaybeUseJwtAccessWithScopes(ref useJwtAccessWithScopes);
                return useJwtAccessWithScopes;
            }
        }

        static partial void MaybeUseJwtAccessWithScopes(ref bool useJwtAccessWithScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversionGoalCampaignConfigServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionGoalCampaignConfigServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="ConversionGoalCampaignConfigServiceClient"/>.
        /// </returns>
        public static stt::Task<ConversionGoalCampaignConfigServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversionGoalCampaignConfigServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversionGoalCampaignConfigServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionGoalCampaignConfigServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversionGoalCampaignConfigServiceClient"/>.</returns>
        public static ConversionGoalCampaignConfigServiceClient Create() =>
            new ConversionGoalCampaignConfigServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversionGoalCampaignConfigServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversionGoalCampaignConfigServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionGoalCampaignConfigServiceClient"/>.</returns>
        internal static ConversionGoalCampaignConfigServiceClient Create(grpccore::CallInvoker callInvoker, ConversionGoalCampaignConfigServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient grpcClient = new ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient(callInvoker);
            return new ConversionGoalCampaignConfigServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ConversionGoalCampaignConfigService client</summary>
        public virtual ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes conversion goal campaign config. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateConversionGoalCampaignConfigsResponse MutateConversionGoalCampaignConfigs(MutateConversionGoalCampaignConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes conversion goal campaign config. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionGoalCampaignConfigsResponse> MutateConversionGoalCampaignConfigsAsync(MutateConversionGoalCampaignConfigsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes conversion goal campaign config. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionGoalCampaignConfigsResponse> MutateConversionGoalCampaignConfigsAsync(MutateConversionGoalCampaignConfigsRequest request, st::CancellationToken cancellationToken) =>
            MutateConversionGoalCampaignConfigsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes conversion goal campaign config. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom conversion goals are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion goal campaign
        /// config.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateConversionGoalCampaignConfigsResponse MutateConversionGoalCampaignConfigs(string customerId, scg::IEnumerable<ConversionGoalCampaignConfigOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateConversionGoalCampaignConfigs(new MutateConversionGoalCampaignConfigsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes conversion goal campaign config. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom conversion goals are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion goal campaign
        /// config.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionGoalCampaignConfigsResponse> MutateConversionGoalCampaignConfigsAsync(string customerId, scg::IEnumerable<ConversionGoalCampaignConfigOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateConversionGoalCampaignConfigsAsync(new MutateConversionGoalCampaignConfigsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes conversion goal campaign config. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom conversion goals are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion goal campaign
        /// config.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionGoalCampaignConfigsResponse> MutateConversionGoalCampaignConfigsAsync(string customerId, scg::IEnumerable<ConversionGoalCampaignConfigOperation> operations, st::CancellationToken cancellationToken) =>
            MutateConversionGoalCampaignConfigsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConversionGoalCampaignConfigService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage conversion goal campaign config.
    /// </remarks>
    public sealed partial class ConversionGoalCampaignConfigServiceClientImpl : ConversionGoalCampaignConfigServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateConversionGoalCampaignConfigsRequest, MutateConversionGoalCampaignConfigsResponse> _callMutateConversionGoalCampaignConfigs;

        /// <summary>
        /// Constructs a client wrapper for the ConversionGoalCampaignConfigService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConversionGoalCampaignConfigServiceSettings"/> used within this client.
        /// </param>
        public ConversionGoalCampaignConfigServiceClientImpl(ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient grpcClient, ConversionGoalCampaignConfigServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ConversionGoalCampaignConfigServiceSettings effectiveSettings = settings ?? ConversionGoalCampaignConfigServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callMutateConversionGoalCampaignConfigs = clientHelper.BuildApiCall<MutateConversionGoalCampaignConfigsRequest, MutateConversionGoalCampaignConfigsResponse>(grpcClient.MutateConversionGoalCampaignConfigsAsync, grpcClient.MutateConversionGoalCampaignConfigs, effectiveSettings.MutateConversionGoalCampaignConfigsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateConversionGoalCampaignConfigs);
            Modify_MutateConversionGoalCampaignConfigsApiCall(ref _callMutateConversionGoalCampaignConfigs);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateConversionGoalCampaignConfigsApiCall(ref gaxgrpc::ApiCall<MutateConversionGoalCampaignConfigsRequest, MutateConversionGoalCampaignConfigsResponse> call);

        partial void OnConstruction(ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient grpcClient, ConversionGoalCampaignConfigServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversionGoalCampaignConfigService client</summary>
        public override ConversionGoalCampaignConfigService.ConversionGoalCampaignConfigServiceClient GrpcClient { get; }

        partial void Modify_MutateConversionGoalCampaignConfigsRequest(ref MutateConversionGoalCampaignConfigsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes conversion goal campaign config. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateConversionGoalCampaignConfigsResponse MutateConversionGoalCampaignConfigs(MutateConversionGoalCampaignConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionGoalCampaignConfigsRequest(ref request, ref callSettings);
            return _callMutateConversionGoalCampaignConfigs.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes conversion goal campaign config. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateConversionGoalCampaignConfigsResponse> MutateConversionGoalCampaignConfigsAsync(MutateConversionGoalCampaignConfigsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionGoalCampaignConfigsRequest(ref request, ref callSettings);
            return _callMutateConversionGoalCampaignConfigs.Async(request, callSettings);
        }
    }
}

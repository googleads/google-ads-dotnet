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

using gagvr = Google.Ads.GoogleAds.V9.Resources;
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

namespace Google.Ads.GoogleAds.V9.Services
{
    /// <summary>Settings for <see cref="ConversionValueRuleSetServiceClient"/> instances.</summary>
    public sealed partial class ConversionValueRuleSetServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversionValueRuleSetServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversionValueRuleSetServiceSettings"/>.</returns>
        public static ConversionValueRuleSetServiceSettings GetDefault() => new ConversionValueRuleSetServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionValueRuleSetServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionValueRuleSetServiceSettings()
        {
        }

        private ConversionValueRuleSetServiceSettings(ConversionValueRuleSetServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetConversionValueRuleSetSettings = existing.GetConversionValueRuleSetSettings;
            MutateConversionValueRuleSetsSettings = existing.MutateConversionValueRuleSetsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionValueRuleSetServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionValueRuleSetServiceClient.GetConversionValueRuleSet</c> and
        /// <c>ConversionValueRuleSetServiceClient.GetConversionValueRuleSetAsync</c>.
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
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetConversionValueRuleSetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionValueRuleSetServiceClient.MutateConversionValueRuleSets</c> and
        /// <c>ConversionValueRuleSetServiceClient.MutateConversionValueRuleSetsAsync</c>.
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
        /// <item><description>Timeout: 3600 seconds.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings MutateConversionValueRuleSetsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(3600000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversionValueRuleSetServiceSettings"/> object.</returns>
        public ConversionValueRuleSetServiceSettings Clone() => new ConversionValueRuleSetServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversionValueRuleSetServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class ConversionValueRuleSetServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversionValueRuleSetServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversionValueRuleSetServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversionValueRuleSetServiceClientBuilder()
        {
            UseJwtAccessWithScopes = ConversionValueRuleSetServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ConversionValueRuleSetServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversionValueRuleSetServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversionValueRuleSetServiceClient Build()
        {
            ConversionValueRuleSetServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversionValueRuleSetServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversionValueRuleSetServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversionValueRuleSetServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversionValueRuleSetServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ConversionValueRuleSetServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversionValueRuleSetServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ConversionValueRuleSetServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() =>
            ConversionValueRuleSetServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversionValueRuleSetServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ConversionValueRuleSetService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage conversion value rule sets.
    /// </remarks>
    public abstract partial class ConversionValueRuleSetServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionValueRuleSetService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ConversionValueRuleSetService scopes.</summary>
        /// <remarks>
        /// The default ConversionValueRuleSetService scopes are:
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
        /// Asynchronously creates a <see cref="ConversionValueRuleSetServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionValueRuleSetServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversionValueRuleSetServiceClient"/>.</returns>
        public static stt::Task<ConversionValueRuleSetServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversionValueRuleSetServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversionValueRuleSetServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionValueRuleSetServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversionValueRuleSetServiceClient"/>.</returns>
        public static ConversionValueRuleSetServiceClient Create() =>
            new ConversionValueRuleSetServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversionValueRuleSetServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversionValueRuleSetServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionValueRuleSetServiceClient"/>.</returns>
        internal static ConversionValueRuleSetServiceClient Create(grpccore::CallInvoker callInvoker, ConversionValueRuleSetServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionValueRuleSetService.ConversionValueRuleSetServiceClient grpcClient = new ConversionValueRuleSetService.ConversionValueRuleSetServiceClient(callInvoker);
            return new ConversionValueRuleSetServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ConversionValueRuleSetService client</summary>
        public virtual ConversionValueRuleSetService.ConversionValueRuleSetServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ConversionValueRuleSet GetConversionValueRuleSet(GetConversionValueRuleSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionValueRuleSet> GetConversionValueRuleSetAsync(GetConversionValueRuleSetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionValueRuleSet> GetConversionValueRuleSetAsync(GetConversionValueRuleSetRequest request, st::CancellationToken cancellationToken) =>
            GetConversionValueRuleSetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion value rule set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ConversionValueRuleSet GetConversionValueRuleSet(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionValueRuleSet(new GetConversionValueRuleSetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion value rule set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionValueRuleSet> GetConversionValueRuleSetAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionValueRuleSetAsync(new GetConversionValueRuleSetRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion value rule set to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionValueRuleSet> GetConversionValueRuleSetAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetConversionValueRuleSetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion value rule set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::ConversionValueRuleSet GetConversionValueRuleSet(gagvr::ConversionValueRuleSetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionValueRuleSet(new GetConversionValueRuleSetRequest
            {
                ResourceNameAsConversionValueRuleSetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion value rule set to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionValueRuleSet> GetConversionValueRuleSetAsync(gagvr::ConversionValueRuleSetName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetConversionValueRuleSetAsync(new GetConversionValueRuleSetRequest
            {
                ResourceNameAsConversionValueRuleSetName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the conversion value rule set to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::ConversionValueRuleSet> GetConversionValueRuleSetAsync(gagvr::ConversionValueRuleSetName resourceName, st::CancellationToken cancellationToken) =>
            GetConversionValueRuleSetAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes conversion value rule sets. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateConversionValueRuleSetsResponse MutateConversionValueRuleSets(MutateConversionValueRuleSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes conversion value rule sets. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionValueRuleSetsResponse> MutateConversionValueRuleSetsAsync(MutateConversionValueRuleSetsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes conversion value rule sets. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionValueRuleSetsResponse> MutateConversionValueRuleSetsAsync(MutateConversionValueRuleSetsRequest request, st::CancellationToken cancellationToken) =>
            MutateConversionValueRuleSetsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes conversion value rule sets. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion value rule sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion value rule sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateConversionValueRuleSetsResponse MutateConversionValueRuleSets(string customerId, scg::IEnumerable<ConversionValueRuleSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateConversionValueRuleSets(new MutateConversionValueRuleSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes conversion value rule sets. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion value rule sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion value rule sets.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionValueRuleSetsResponse> MutateConversionValueRuleSetsAsync(string customerId, scg::IEnumerable<ConversionValueRuleSetOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateConversionValueRuleSetsAsync(new MutateConversionValueRuleSetsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes conversion value rule sets. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion value rule sets are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion value rule sets.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionValueRuleSetsResponse> MutateConversionValueRuleSetsAsync(string customerId, scg::IEnumerable<ConversionValueRuleSetOperation> operations, st::CancellationToken cancellationToken) =>
            MutateConversionValueRuleSetsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConversionValueRuleSetService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage conversion value rule sets.
    /// </remarks>
    public sealed partial class ConversionValueRuleSetServiceClientImpl : ConversionValueRuleSetServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetConversionValueRuleSetRequest, gagvr::ConversionValueRuleSet> _callGetConversionValueRuleSet;

        private readonly gaxgrpc::ApiCall<MutateConversionValueRuleSetsRequest, MutateConversionValueRuleSetsResponse> _callMutateConversionValueRuleSets;

        /// <summary>
        /// Constructs a client wrapper for the ConversionValueRuleSetService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConversionValueRuleSetServiceSettings"/> used within this client.
        /// </param>
        public ConversionValueRuleSetServiceClientImpl(ConversionValueRuleSetService.ConversionValueRuleSetServiceClient grpcClient, ConversionValueRuleSetServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ConversionValueRuleSetServiceSettings effectiveSettings = settings ?? ConversionValueRuleSetServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callGetConversionValueRuleSet = clientHelper.BuildApiCall<GetConversionValueRuleSetRequest, gagvr::ConversionValueRuleSet>(grpcClient.GetConversionValueRuleSetAsync, grpcClient.GetConversionValueRuleSet, effectiveSettings.GetConversionValueRuleSetSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetConversionValueRuleSet);
            Modify_GetConversionValueRuleSetApiCall(ref _callGetConversionValueRuleSet);
            _callMutateConversionValueRuleSets = clientHelper.BuildApiCall<MutateConversionValueRuleSetsRequest, MutateConversionValueRuleSetsResponse>(grpcClient.MutateConversionValueRuleSetsAsync, grpcClient.MutateConversionValueRuleSets, effectiveSettings.MutateConversionValueRuleSetsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateConversionValueRuleSets);
            Modify_MutateConversionValueRuleSetsApiCall(ref _callMutateConversionValueRuleSets);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetConversionValueRuleSetApiCall(ref gaxgrpc::ApiCall<GetConversionValueRuleSetRequest, gagvr::ConversionValueRuleSet> call);

        partial void Modify_MutateConversionValueRuleSetsApiCall(ref gaxgrpc::ApiCall<MutateConversionValueRuleSetsRequest, MutateConversionValueRuleSetsResponse> call);

        partial void OnConstruction(ConversionValueRuleSetService.ConversionValueRuleSetServiceClient grpcClient, ConversionValueRuleSetServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversionValueRuleSetService client</summary>
        public override ConversionValueRuleSetService.ConversionValueRuleSetServiceClient GrpcClient { get; }

        partial void Modify_GetConversionValueRuleSetRequest(ref GetConversionValueRuleSetRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateConversionValueRuleSetsRequest(ref MutateConversionValueRuleSetsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::ConversionValueRuleSet GetConversionValueRuleSet(GetConversionValueRuleSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionValueRuleSetRequest(ref request, ref callSettings);
            return _callGetConversionValueRuleSet.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested conversion value rule set.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::ConversionValueRuleSet> GetConversionValueRuleSetAsync(GetConversionValueRuleSetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetConversionValueRuleSetRequest(ref request, ref callSettings);
            return _callGetConversionValueRuleSet.Async(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes conversion value rule sets. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateConversionValueRuleSetsResponse MutateConversionValueRuleSets(MutateConversionValueRuleSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionValueRuleSetsRequest(ref request, ref callSettings);
            return _callMutateConversionValueRuleSets.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes conversion value rule sets. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateConversionValueRuleSetsResponse> MutateConversionValueRuleSetsAsync(MutateConversionValueRuleSetsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionValueRuleSetsRequest(ref request, ref callSettings);
            return _callMutateConversionValueRuleSets.Async(request, callSettings);
        }
    }
}

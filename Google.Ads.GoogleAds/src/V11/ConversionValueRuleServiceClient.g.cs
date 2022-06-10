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

namespace Google.Ads.GoogleAds.V11.Services
{
    /// <summary>Settings for <see cref="ConversionValueRuleServiceClient"/> instances.</summary>
    public sealed partial class ConversionValueRuleServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ConversionValueRuleServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ConversionValueRuleServiceSettings"/>.</returns>
        public static ConversionValueRuleServiceSettings GetDefault() => new ConversionValueRuleServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionValueRuleServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionValueRuleServiceSettings()
        {
        }

        private ConversionValueRuleServiceSettings(ConversionValueRuleServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateConversionValueRulesSettings = existing.MutateConversionValueRulesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionValueRuleServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionValueRuleServiceClient.MutateConversionValueRules</c> and
        /// <c>ConversionValueRuleServiceClient.MutateConversionValueRulesAsync</c>.
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
        public gaxgrpc::CallSettings MutateConversionValueRulesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversionValueRuleServiceSettings"/> object.</returns>
        public ConversionValueRuleServiceSettings Clone() => new ConversionValueRuleServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversionValueRuleServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class ConversionValueRuleServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversionValueRuleServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversionValueRuleServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversionValueRuleServiceClientBuilder()
        {
            UseJwtAccessWithScopes = ConversionValueRuleServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref ConversionValueRuleServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversionValueRuleServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversionValueRuleServiceClient Build()
        {
            ConversionValueRuleServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversionValueRuleServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversionValueRuleServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversionValueRuleServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversionValueRuleServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<ConversionValueRuleServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversionValueRuleServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => ConversionValueRuleServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => ConversionValueRuleServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversionValueRuleServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>ConversionValueRuleService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage conversion value rules.
    /// </remarks>
    public abstract partial class ConversionValueRuleServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionValueRuleService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ConversionValueRuleService scopes.</summary>
        /// <remarks>
        /// The default ConversionValueRuleService scopes are:
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
        /// Asynchronously creates a <see cref="ConversionValueRuleServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionValueRuleServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversionValueRuleServiceClient"/>.</returns>
        public static stt::Task<ConversionValueRuleServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversionValueRuleServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversionValueRuleServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionValueRuleServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversionValueRuleServiceClient"/>.</returns>
        public static ConversionValueRuleServiceClient Create() => new ConversionValueRuleServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversionValueRuleServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversionValueRuleServiceSettings"/>.</param>
        /// <returns>The created <see cref="ConversionValueRuleServiceClient"/>.</returns>
        internal static ConversionValueRuleServiceClient Create(grpccore::CallInvoker callInvoker, ConversionValueRuleServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionValueRuleService.ConversionValueRuleServiceClient grpcClient = new ConversionValueRuleService.ConversionValueRuleServiceClient(callInvoker);
            return new ConversionValueRuleServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC ConversionValueRuleService client</summary>
        public virtual ConversionValueRuleService.ConversionValueRuleServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes conversion value rules. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateConversionValueRulesResponse MutateConversionValueRules(MutateConversionValueRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes conversion value rules. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionValueRulesResponse> MutateConversionValueRulesAsync(MutateConversionValueRulesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes conversion value rules. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionValueRulesResponse> MutateConversionValueRulesAsync(MutateConversionValueRulesRequest request, st::CancellationToken cancellationToken) =>
            MutateConversionValueRulesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes conversion value rules. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion value rules are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion value rules.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateConversionValueRulesResponse MutateConversionValueRules(string customerId, scg::IEnumerable<ConversionValueRuleOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateConversionValueRules(new MutateConversionValueRulesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes conversion value rules. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion value rules are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion value rules.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionValueRulesResponse> MutateConversionValueRulesAsync(string customerId, scg::IEnumerable<ConversionValueRuleOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateConversionValueRulesAsync(new MutateConversionValueRulesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes conversion value rules. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose conversion value rules are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual conversion value rules.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateConversionValueRulesResponse> MutateConversionValueRulesAsync(string customerId, scg::IEnumerable<ConversionValueRuleOperation> operations, st::CancellationToken cancellationToken) =>
            MutateConversionValueRulesAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConversionValueRuleService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage conversion value rules.
    /// </remarks>
    public sealed partial class ConversionValueRuleServiceClientImpl : ConversionValueRuleServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateConversionValueRulesRequest, MutateConversionValueRulesResponse> _callMutateConversionValueRules;

        /// <summary>
        /// Constructs a client wrapper for the ConversionValueRuleService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConversionValueRuleServiceSettings"/> used within this client.
        /// </param>
        public ConversionValueRuleServiceClientImpl(ConversionValueRuleService.ConversionValueRuleServiceClient grpcClient, ConversionValueRuleServiceSettings settings)
        {
            GrpcClient = grpcClient;
            ConversionValueRuleServiceSettings effectiveSettings = settings ?? ConversionValueRuleServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            _callMutateConversionValueRules = clientHelper.BuildApiCall<MutateConversionValueRulesRequest, MutateConversionValueRulesResponse>(grpcClient.MutateConversionValueRulesAsync, grpcClient.MutateConversionValueRules, effectiveSettings.MutateConversionValueRulesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateConversionValueRules);
            Modify_MutateConversionValueRulesApiCall(ref _callMutateConversionValueRules);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateConversionValueRulesApiCall(ref gaxgrpc::ApiCall<MutateConversionValueRulesRequest, MutateConversionValueRulesResponse> call);

        partial void OnConstruction(ConversionValueRuleService.ConversionValueRuleServiceClient grpcClient, ConversionValueRuleServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversionValueRuleService client</summary>
        public override ConversionValueRuleService.ConversionValueRuleServiceClient GrpcClient { get; }

        partial void Modify_MutateConversionValueRulesRequest(ref MutateConversionValueRulesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes conversion value rules. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateConversionValueRulesResponse MutateConversionValueRules(MutateConversionValueRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionValueRulesRequest(ref request, ref callSettings);
            return _callMutateConversionValueRules.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes conversion value rules. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateConversionValueRulesResponse> MutateConversionValueRulesAsync(MutateConversionValueRulesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateConversionValueRulesRequest(ref request, ref callSettings);
            return _callMutateConversionValueRules.Async(request, callSettings);
        }
    }
}

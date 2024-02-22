// Copyright 2024 Google LLC
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

#pragma warning disable CS8981
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using proto = Google.Protobuf;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V16.Services
{
    /// <summary>Settings for <see cref="AdGroupCriterionCustomizerServiceClient"/> instances.</summary>
    public sealed partial class AdGroupCriterionCustomizerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AdGroupCriterionCustomizerServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="AdGroupCriterionCustomizerServiceSettings"/>.</returns>
        public static AdGroupCriterionCustomizerServiceSettings GetDefault() =>
            new AdGroupCriterionCustomizerServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AdGroupCriterionCustomizerServiceSettings"/> object with default settings.
        /// </summary>
        public AdGroupCriterionCustomizerServiceSettings()
        {
        }

        private AdGroupCriterionCustomizerServiceSettings(AdGroupCriterionCustomizerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateAdGroupCriterionCustomizersSettings = existing.MutateAdGroupCriterionCustomizersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AdGroupCriterionCustomizerServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AdGroupCriterionCustomizerServiceClient.MutateAdGroupCriterionCustomizers</c> and
        /// <c>AdGroupCriterionCustomizerServiceClient.MutateAdGroupCriterionCustomizersAsync</c>.
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
        public gaxgrpc::CallSettings MutateAdGroupCriterionCustomizersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="AdGroupCriterionCustomizerServiceSettings"/> object.</returns>
        public AdGroupCriterionCustomizerServiceSettings Clone() => new AdGroupCriterionCustomizerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AdGroupCriterionCustomizerServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class AdGroupCriterionCustomizerServiceClientBuilder : gaxgrpc::ClientBuilderBase<AdGroupCriterionCustomizerServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AdGroupCriterionCustomizerServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AdGroupCriterionCustomizerServiceClientBuilder() : base(AdGroupCriterionCustomizerServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AdGroupCriterionCustomizerServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AdGroupCriterionCustomizerServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AdGroupCriterionCustomizerServiceClient Build()
        {
            AdGroupCriterionCustomizerServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AdGroupCriterionCustomizerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AdGroupCriterionCustomizerServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AdGroupCriterionCustomizerServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AdGroupCriterionCustomizerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AdGroupCriterionCustomizerServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AdGroupCriterionCustomizerServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => AdGroupCriterionCustomizerServiceClient.ChannelPool;
    }

    /// <summary>AdGroupCriterionCustomizerService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group criterion customizer
    /// </remarks>
    public abstract partial class AdGroupCriterionCustomizerServiceClient
    {
        /// <summary>
        /// The default endpoint for the AdGroupCriterionCustomizerService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AdGroupCriterionCustomizerService scopes.</summary>
        /// <remarks>
        /// The default AdGroupCriterionCustomizerService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AdGroupCriterionCustomizerService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AdGroupCriterionCustomizerServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupCriterionCustomizerServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="AdGroupCriterionCustomizerServiceClient"/>.</returns>
        public static stt::Task<AdGroupCriterionCustomizerServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AdGroupCriterionCustomizerServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AdGroupCriterionCustomizerServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AdGroupCriterionCustomizerServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AdGroupCriterionCustomizerServiceClient"/>.</returns>
        public static AdGroupCriterionCustomizerServiceClient Create() =>
            new AdGroupCriterionCustomizerServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AdGroupCriterionCustomizerServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AdGroupCriterionCustomizerServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AdGroupCriterionCustomizerServiceClient"/>.</returns>
        internal static AdGroupCriterionCustomizerServiceClient Create(grpccore::CallInvoker callInvoker, AdGroupCriterionCustomizerServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient grpcClient = new AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient(callInvoker);
            return new AdGroupCriterionCustomizerServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AdGroupCriterionCustomizerService client</summary>
        public virtual AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes ad group criterion customizers. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupCriterionCustomizersResponse MutateAdGroupCriterionCustomizers(MutateAdGroupCriterionCustomizersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes ad group criterion customizers. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriterionCustomizersResponse> MutateAdGroupCriterionCustomizersAsync(MutateAdGroupCriterionCustomizersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes ad group criterion customizers. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriterionCustomizersResponse> MutateAdGroupCriterionCustomizersAsync(MutateAdGroupCriterionCustomizersRequest request, st::CancellationToken cancellationToken) =>
            MutateAdGroupCriterionCustomizersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes ad group criterion customizers. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group criterion customizers are
        /// being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group
        /// criterion customizers.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateAdGroupCriterionCustomizersResponse MutateAdGroupCriterionCustomizers(string customerId, scg::IEnumerable<AdGroupCriterionCustomizerOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupCriterionCustomizers(new MutateAdGroupCriterionCustomizersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes ad group criterion customizers. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group criterion customizers are
        /// being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group
        /// criterion customizers.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriterionCustomizersResponse> MutateAdGroupCriterionCustomizersAsync(string customerId, scg::IEnumerable<AdGroupCriterionCustomizerOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateAdGroupCriterionCustomizersAsync(new MutateAdGroupCriterionCustomizersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes ad group criterion customizers. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose ad group criterion customizers are
        /// being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual ad group
        /// criterion customizers.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateAdGroupCriterionCustomizersResponse> MutateAdGroupCriterionCustomizersAsync(string customerId, scg::IEnumerable<AdGroupCriterionCustomizerOperation> operations, st::CancellationToken cancellationToken) =>
            MutateAdGroupCriterionCustomizersAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AdGroupCriterionCustomizerService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage ad group criterion customizer
    /// </remarks>
    public sealed partial class AdGroupCriterionCustomizerServiceClientImpl : AdGroupCriterionCustomizerServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateAdGroupCriterionCustomizersRequest, MutateAdGroupCriterionCustomizersResponse> _callMutateAdGroupCriterionCustomizers;

        /// <summary>
        /// Constructs a client wrapper for the AdGroupCriterionCustomizerService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AdGroupCriterionCustomizerServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AdGroupCriterionCustomizerServiceClientImpl(AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient grpcClient, AdGroupCriterionCustomizerServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AdGroupCriterionCustomizerServiceSettings effectiveSettings = settings ?? AdGroupCriterionCustomizerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateAdGroupCriterionCustomizers = clientHelper.BuildApiCall<MutateAdGroupCriterionCustomizersRequest, MutateAdGroupCriterionCustomizersResponse>("MutateAdGroupCriterionCustomizers", grpcClient.MutateAdGroupCriterionCustomizersAsync, grpcClient.MutateAdGroupCriterionCustomizers, effectiveSettings.MutateAdGroupCriterionCustomizersSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateAdGroupCriterionCustomizers);
            Modify_MutateAdGroupCriterionCustomizersApiCall(ref _callMutateAdGroupCriterionCustomizers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateAdGroupCriterionCustomizersApiCall(ref gaxgrpc::ApiCall<MutateAdGroupCriterionCustomizersRequest, MutateAdGroupCriterionCustomizersResponse> call);

        partial void OnConstruction(AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient grpcClient, AdGroupCriterionCustomizerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AdGroupCriterionCustomizerService client</summary>
        public override AdGroupCriterionCustomizerService.AdGroupCriterionCustomizerServiceClient GrpcClient { get; }

        partial void Modify_MutateAdGroupCriterionCustomizersRequest(ref MutateAdGroupCriterionCustomizersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes ad group criterion customizers. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateAdGroupCriterionCustomizersResponse MutateAdGroupCriterionCustomizers(MutateAdGroupCriterionCustomizersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupCriterionCustomizersRequest(ref request, ref callSettings);
            return _callMutateAdGroupCriterionCustomizers.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes ad group criterion customizers. Operation
        /// statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateAdGroupCriterionCustomizersResponse> MutateAdGroupCriterionCustomizersAsync(MutateAdGroupCriterionCustomizersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateAdGroupCriterionCustomizersRequest(ref request, ref callSettings);
            return _callMutateAdGroupCriterionCustomizers.Async(request, callSettings);
        }
    }
}

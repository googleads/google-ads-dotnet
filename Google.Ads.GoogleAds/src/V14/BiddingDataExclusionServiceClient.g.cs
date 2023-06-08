// Copyright 2023 Google LLC
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

namespace Google.Ads.GoogleAds.V14.Services
{
    /// <summary>Settings for <see cref="BiddingDataExclusionServiceClient"/> instances.</summary>
    public sealed partial class BiddingDataExclusionServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BiddingDataExclusionServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BiddingDataExclusionServiceSettings"/>.</returns>
        public static BiddingDataExclusionServiceSettings GetDefault() => new BiddingDataExclusionServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BiddingDataExclusionServiceSettings"/> object with default settings.
        /// </summary>
        public BiddingDataExclusionServiceSettings()
        {
        }

        private BiddingDataExclusionServiceSettings(BiddingDataExclusionServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateBiddingDataExclusionsSettings = existing.MutateBiddingDataExclusionsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BiddingDataExclusionServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BiddingDataExclusionServiceClient.MutateBiddingDataExclusions</c> and
        /// <c>BiddingDataExclusionServiceClient.MutateBiddingDataExclusionsAsync</c>.
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
        public gaxgrpc::CallSettings MutateBiddingDataExclusionsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BiddingDataExclusionServiceSettings"/> object.</returns>
        public BiddingDataExclusionServiceSettings Clone() => new BiddingDataExclusionServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BiddingDataExclusionServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class BiddingDataExclusionServiceClientBuilder : gaxgrpc::ClientBuilderBase<BiddingDataExclusionServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BiddingDataExclusionServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BiddingDataExclusionServiceClientBuilder() : base(BiddingDataExclusionServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BiddingDataExclusionServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BiddingDataExclusionServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BiddingDataExclusionServiceClient Build()
        {
            BiddingDataExclusionServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BiddingDataExclusionServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BiddingDataExclusionServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BiddingDataExclusionServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BiddingDataExclusionServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<BiddingDataExclusionServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BiddingDataExclusionServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BiddingDataExclusionServiceClient.ChannelPool;
    }

    /// <summary>BiddingDataExclusionService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage bidding data exclusions.
    /// </remarks>
    public abstract partial class BiddingDataExclusionServiceClient
    {
        /// <summary>
        /// The default endpoint for the BiddingDataExclusionService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default BiddingDataExclusionService scopes.</summary>
        /// <remarks>
        /// The default BiddingDataExclusionService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BiddingDataExclusionService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BiddingDataExclusionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BiddingDataExclusionServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BiddingDataExclusionServiceClient"/>.</returns>
        public static stt::Task<BiddingDataExclusionServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BiddingDataExclusionServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BiddingDataExclusionServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BiddingDataExclusionServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BiddingDataExclusionServiceClient"/>.</returns>
        public static BiddingDataExclusionServiceClient Create() => new BiddingDataExclusionServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BiddingDataExclusionServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BiddingDataExclusionServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BiddingDataExclusionServiceClient"/>.</returns>
        internal static BiddingDataExclusionServiceClient Create(grpccore::CallInvoker callInvoker, BiddingDataExclusionServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BiddingDataExclusionService.BiddingDataExclusionServiceClient grpcClient = new BiddingDataExclusionService.BiddingDataExclusionServiceClient(callInvoker);
            return new BiddingDataExclusionServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BiddingDataExclusionService client</summary>
        public virtual BiddingDataExclusionService.BiddingDataExclusionServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes data exclusions.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBiddingDataExclusionsResponse MutateBiddingDataExclusions(MutateBiddingDataExclusionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes data exclusions.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingDataExclusionsResponse> MutateBiddingDataExclusionsAsync(MutateBiddingDataExclusionsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes data exclusions.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingDataExclusionsResponse> MutateBiddingDataExclusionsAsync(MutateBiddingDataExclusionsRequest request, st::CancellationToken cancellationToken) =>
            MutateBiddingDataExclusionsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes data exclusions.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose data exclusions are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual data exclusions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBiddingDataExclusionsResponse MutateBiddingDataExclusions(string customerId, scg::IEnumerable<BiddingDataExclusionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateBiddingDataExclusions(new MutateBiddingDataExclusionsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes data exclusions.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose data exclusions are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual data exclusions.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingDataExclusionsResponse> MutateBiddingDataExclusionsAsync(string customerId, scg::IEnumerable<BiddingDataExclusionOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateBiddingDataExclusionsAsync(new MutateBiddingDataExclusionsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes data exclusions.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose data exclusions are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual data exclusions.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingDataExclusionsResponse> MutateBiddingDataExclusionsAsync(string customerId, scg::IEnumerable<BiddingDataExclusionOperation> operations, st::CancellationToken cancellationToken) =>
            MutateBiddingDataExclusionsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BiddingDataExclusionService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage bidding data exclusions.
    /// </remarks>
    public sealed partial class BiddingDataExclusionServiceClientImpl : BiddingDataExclusionServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateBiddingDataExclusionsRequest, MutateBiddingDataExclusionsResponse> _callMutateBiddingDataExclusions;

        /// <summary>
        /// Constructs a client wrapper for the BiddingDataExclusionService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BiddingDataExclusionServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BiddingDataExclusionServiceClientImpl(BiddingDataExclusionService.BiddingDataExclusionServiceClient grpcClient, BiddingDataExclusionServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BiddingDataExclusionServiceSettings effectiveSettings = settings ?? BiddingDataExclusionServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateBiddingDataExclusions = clientHelper.BuildApiCall<MutateBiddingDataExclusionsRequest, MutateBiddingDataExclusionsResponse>("MutateBiddingDataExclusions", grpcClient.MutateBiddingDataExclusionsAsync, grpcClient.MutateBiddingDataExclusions, effectiveSettings.MutateBiddingDataExclusionsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateBiddingDataExclusions);
            Modify_MutateBiddingDataExclusionsApiCall(ref _callMutateBiddingDataExclusions);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateBiddingDataExclusionsApiCall(ref gaxgrpc::ApiCall<MutateBiddingDataExclusionsRequest, MutateBiddingDataExclusionsResponse> call);

        partial void OnConstruction(BiddingDataExclusionService.BiddingDataExclusionServiceClient grpcClient, BiddingDataExclusionServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BiddingDataExclusionService client</summary>
        public override BiddingDataExclusionService.BiddingDataExclusionServiceClient GrpcClient { get; }

        partial void Modify_MutateBiddingDataExclusionsRequest(ref MutateBiddingDataExclusionsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes data exclusions.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateBiddingDataExclusionsResponse MutateBiddingDataExclusions(MutateBiddingDataExclusionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBiddingDataExclusionsRequest(ref request, ref callSettings);
            return _callMutateBiddingDataExclusions.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes data exclusions.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateBiddingDataExclusionsResponse> MutateBiddingDataExclusionsAsync(MutateBiddingDataExclusionsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBiddingDataExclusionsRequest(ref request, ref callSettings);
            return _callMutateBiddingDataExclusions.Async(request, callSettings);
        }
    }
}

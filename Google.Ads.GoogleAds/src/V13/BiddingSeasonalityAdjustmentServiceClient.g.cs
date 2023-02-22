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

namespace Google.Ads.GoogleAds.V13.Services
{
    /// <summary>Settings for <see cref="BiddingSeasonalityAdjustmentServiceClient"/> instances.</summary>
    public sealed partial class BiddingSeasonalityAdjustmentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="BiddingSeasonalityAdjustmentServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="BiddingSeasonalityAdjustmentServiceSettings"/>.</returns>
        public static BiddingSeasonalityAdjustmentServiceSettings GetDefault() =>
            new BiddingSeasonalityAdjustmentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="BiddingSeasonalityAdjustmentServiceSettings"/> object with default settings.
        /// </summary>
        public BiddingSeasonalityAdjustmentServiceSettings()
        {
        }

        private BiddingSeasonalityAdjustmentServiceSettings(BiddingSeasonalityAdjustmentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateBiddingSeasonalityAdjustmentsSettings = existing.MutateBiddingSeasonalityAdjustmentsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BiddingSeasonalityAdjustmentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BiddingSeasonalityAdjustmentServiceClient.MutateBiddingSeasonalityAdjustments</c> and
        /// <c>BiddingSeasonalityAdjustmentServiceClient.MutateBiddingSeasonalityAdjustmentsAsync</c>.
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
        public gaxgrpc::CallSettings MutateBiddingSeasonalityAdjustmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BiddingSeasonalityAdjustmentServiceSettings"/> object.</returns>
        public BiddingSeasonalityAdjustmentServiceSettings Clone() => new BiddingSeasonalityAdjustmentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BiddingSeasonalityAdjustmentServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class BiddingSeasonalityAdjustmentServiceClientBuilder : gaxgrpc::ClientBuilderBase<BiddingSeasonalityAdjustmentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BiddingSeasonalityAdjustmentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BiddingSeasonalityAdjustmentServiceClientBuilder() : base(BiddingSeasonalityAdjustmentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BiddingSeasonalityAdjustmentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BiddingSeasonalityAdjustmentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BiddingSeasonalityAdjustmentServiceClient Build()
        {
            BiddingSeasonalityAdjustmentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BiddingSeasonalityAdjustmentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BiddingSeasonalityAdjustmentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BiddingSeasonalityAdjustmentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BiddingSeasonalityAdjustmentServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<BiddingSeasonalityAdjustmentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BiddingSeasonalityAdjustmentServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BiddingSeasonalityAdjustmentServiceClient.ChannelPool;
    }

    /// <summary>BiddingSeasonalityAdjustmentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage bidding seasonality adjustments.
    /// </remarks>
    public abstract partial class BiddingSeasonalityAdjustmentServiceClient
    {
        /// <summary>
        /// The default endpoint for the BiddingSeasonalityAdjustmentService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default BiddingSeasonalityAdjustmentService scopes.</summary>
        /// <remarks>
        /// The default BiddingSeasonalityAdjustmentService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BiddingSeasonalityAdjustmentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BiddingSeasonalityAdjustmentServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BiddingSeasonalityAdjustmentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="BiddingSeasonalityAdjustmentServiceClient"/>.
        /// </returns>
        public static stt::Task<BiddingSeasonalityAdjustmentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BiddingSeasonalityAdjustmentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BiddingSeasonalityAdjustmentServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="BiddingSeasonalityAdjustmentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BiddingSeasonalityAdjustmentServiceClient"/>.</returns>
        public static BiddingSeasonalityAdjustmentServiceClient Create() =>
            new BiddingSeasonalityAdjustmentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BiddingSeasonalityAdjustmentServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BiddingSeasonalityAdjustmentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BiddingSeasonalityAdjustmentServiceClient"/>.</returns>
        internal static BiddingSeasonalityAdjustmentServiceClient Create(grpccore::CallInvoker callInvoker, BiddingSeasonalityAdjustmentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient grpcClient = new BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient(callInvoker);
            return new BiddingSeasonalityAdjustmentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BiddingSeasonalityAdjustmentService client</summary>
        public virtual BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes seasonality adjustments.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBiddingSeasonalityAdjustmentsResponse MutateBiddingSeasonalityAdjustments(MutateBiddingSeasonalityAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes seasonality adjustments.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingSeasonalityAdjustmentsResponse> MutateBiddingSeasonalityAdjustmentsAsync(MutateBiddingSeasonalityAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes seasonality adjustments.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingSeasonalityAdjustmentsResponse> MutateBiddingSeasonalityAdjustmentsAsync(MutateBiddingSeasonalityAdjustmentsRequest request, st::CancellationToken cancellationToken) =>
            MutateBiddingSeasonalityAdjustmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes seasonality adjustments.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose seasonality adjustments are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual seasonality
        /// adjustments.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBiddingSeasonalityAdjustmentsResponse MutateBiddingSeasonalityAdjustments(string customerId, scg::IEnumerable<BiddingSeasonalityAdjustmentOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateBiddingSeasonalityAdjustments(new MutateBiddingSeasonalityAdjustmentsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes seasonality adjustments.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose seasonality adjustments are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual seasonality
        /// adjustments.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingSeasonalityAdjustmentsResponse> MutateBiddingSeasonalityAdjustmentsAsync(string customerId, scg::IEnumerable<BiddingSeasonalityAdjustmentOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateBiddingSeasonalityAdjustmentsAsync(new MutateBiddingSeasonalityAdjustmentsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes seasonality adjustments.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. ID of the customer whose seasonality adjustments are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual seasonality
        /// adjustments.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBiddingSeasonalityAdjustmentsResponse> MutateBiddingSeasonalityAdjustmentsAsync(string customerId, scg::IEnumerable<BiddingSeasonalityAdjustmentOperation> operations, st::CancellationToken cancellationToken) =>
            MutateBiddingSeasonalityAdjustmentsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BiddingSeasonalityAdjustmentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage bidding seasonality adjustments.
    /// </remarks>
    public sealed partial class BiddingSeasonalityAdjustmentServiceClientImpl : BiddingSeasonalityAdjustmentServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateBiddingSeasonalityAdjustmentsRequest, MutateBiddingSeasonalityAdjustmentsResponse> _callMutateBiddingSeasonalityAdjustments;

        /// <summary>
        /// Constructs a client wrapper for the BiddingSeasonalityAdjustmentService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="BiddingSeasonalityAdjustmentServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BiddingSeasonalityAdjustmentServiceClientImpl(BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient grpcClient, BiddingSeasonalityAdjustmentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BiddingSeasonalityAdjustmentServiceSettings effectiveSettings = settings ?? BiddingSeasonalityAdjustmentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateBiddingSeasonalityAdjustments = clientHelper.BuildApiCall<MutateBiddingSeasonalityAdjustmentsRequest, MutateBiddingSeasonalityAdjustmentsResponse>("MutateBiddingSeasonalityAdjustments", grpcClient.MutateBiddingSeasonalityAdjustmentsAsync, grpcClient.MutateBiddingSeasonalityAdjustments, effectiveSettings.MutateBiddingSeasonalityAdjustmentsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateBiddingSeasonalityAdjustments);
            Modify_MutateBiddingSeasonalityAdjustmentsApiCall(ref _callMutateBiddingSeasonalityAdjustments);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateBiddingSeasonalityAdjustmentsApiCall(ref gaxgrpc::ApiCall<MutateBiddingSeasonalityAdjustmentsRequest, MutateBiddingSeasonalityAdjustmentsResponse> call);

        partial void OnConstruction(BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient grpcClient, BiddingSeasonalityAdjustmentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BiddingSeasonalityAdjustmentService client</summary>
        public override BiddingSeasonalityAdjustmentService.BiddingSeasonalityAdjustmentServiceClient GrpcClient { get; }

        partial void Modify_MutateBiddingSeasonalityAdjustmentsRequest(ref MutateBiddingSeasonalityAdjustmentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes seasonality adjustments.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateBiddingSeasonalityAdjustmentsResponse MutateBiddingSeasonalityAdjustments(MutateBiddingSeasonalityAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBiddingSeasonalityAdjustmentsRequest(ref request, ref callSettings);
            return _callMutateBiddingSeasonalityAdjustments.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes seasonality adjustments.
        /// Operation statuses are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateBiddingSeasonalityAdjustmentsResponse> MutateBiddingSeasonalityAdjustmentsAsync(MutateBiddingSeasonalityAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBiddingSeasonalityAdjustmentsRequest(ref request, ref callSettings);
            return _callMutateBiddingSeasonalityAdjustments.Async(request, callSettings);
        }
    }
}

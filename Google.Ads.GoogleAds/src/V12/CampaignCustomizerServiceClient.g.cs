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

namespace Google.Ads.GoogleAds.V12.Services
{
    /// <summary>Settings for <see cref="CampaignCustomizerServiceClient"/> instances.</summary>
    public sealed partial class CampaignCustomizerServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignCustomizerServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignCustomizerServiceSettings"/>.</returns>
        public static CampaignCustomizerServiceSettings GetDefault() => new CampaignCustomizerServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignCustomizerServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignCustomizerServiceSettings()
        {
        }

        private CampaignCustomizerServiceSettings(CampaignCustomizerServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCampaignCustomizersSettings = existing.MutateCampaignCustomizersSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignCustomizerServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignCustomizerServiceClient.MutateCampaignCustomizers</c> and
        /// <c>CampaignCustomizerServiceClient.MutateCampaignCustomizersAsync</c>.
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
        public gaxgrpc::CallSettings MutateCampaignCustomizersSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignCustomizerServiceSettings"/> object.</returns>
        public CampaignCustomizerServiceSettings Clone() => new CampaignCustomizerServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignCustomizerServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CampaignCustomizerServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignCustomizerServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignCustomizerServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignCustomizerServiceClientBuilder() : base(CampaignCustomizerServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CampaignCustomizerServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignCustomizerServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignCustomizerServiceClient Build()
        {
            CampaignCustomizerServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignCustomizerServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignCustomizerServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignCustomizerServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignCustomizerServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<CampaignCustomizerServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignCustomizerServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignCustomizerServiceClient.ChannelPool;
    }

    /// <summary>CampaignCustomizerService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign customizer
    /// </remarks>
    public abstract partial class CampaignCustomizerServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignCustomizerService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignCustomizerService scopes.</summary>
        /// <remarks>
        /// The default CampaignCustomizerService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CampaignCustomizerService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignCustomizerServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignCustomizerServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignCustomizerServiceClient"/>.</returns>
        public static stt::Task<CampaignCustomizerServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignCustomizerServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignCustomizerServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignCustomizerServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignCustomizerServiceClient"/>.</returns>
        public static CampaignCustomizerServiceClient Create() => new CampaignCustomizerServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignCustomizerServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignCustomizerServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CampaignCustomizerServiceClient"/>.</returns>
        internal static CampaignCustomizerServiceClient Create(grpccore::CallInvoker callInvoker, CampaignCustomizerServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignCustomizerService.CampaignCustomizerServiceClient grpcClient = new CampaignCustomizerService.CampaignCustomizerServiceClient(callInvoker);
            return new CampaignCustomizerServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CampaignCustomizerService client</summary>
        public virtual CampaignCustomizerService.CampaignCustomizerServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes campaign customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignCustomizersResponse MutateCampaignCustomizers(MutateCampaignCustomizersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes campaign customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignCustomizersResponse> MutateCampaignCustomizersAsync(MutateCampaignCustomizersRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes campaign customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignCustomizersResponse> MutateCampaignCustomizersAsync(MutateCampaignCustomizersRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignCustomizersAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes campaign customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign customizers are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign customizers.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignCustomizersResponse MutateCampaignCustomizers(string customerId, scg::IEnumerable<CampaignCustomizerOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignCustomizers(new MutateCampaignCustomizersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes campaign customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign customizers are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign customizers.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignCustomizersResponse> MutateCampaignCustomizersAsync(string customerId, scg::IEnumerable<CampaignCustomizerOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignCustomizersAsync(new MutateCampaignCustomizersRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes campaign customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign customizers are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign customizers.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignCustomizersResponse> MutateCampaignCustomizersAsync(string customerId, scg::IEnumerable<CampaignCustomizerOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignCustomizersAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignCustomizerService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign customizer
    /// </remarks>
    public sealed partial class CampaignCustomizerServiceClientImpl : CampaignCustomizerServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCampaignCustomizersRequest, MutateCampaignCustomizersResponse> _callMutateCampaignCustomizers;

        /// <summary>
        /// Constructs a client wrapper for the CampaignCustomizerService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignCustomizerServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CampaignCustomizerServiceClientImpl(CampaignCustomizerService.CampaignCustomizerServiceClient grpcClient, CampaignCustomizerServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CampaignCustomizerServiceSettings effectiveSettings = settings ?? CampaignCustomizerServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateCampaignCustomizers = clientHelper.BuildApiCall<MutateCampaignCustomizersRequest, MutateCampaignCustomizersResponse>("MutateCampaignCustomizers", grpcClient.MutateCampaignCustomizersAsync, grpcClient.MutateCampaignCustomizers, effectiveSettings.MutateCampaignCustomizersSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignCustomizers);
            Modify_MutateCampaignCustomizersApiCall(ref _callMutateCampaignCustomizers);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCampaignCustomizersApiCall(ref gaxgrpc::ApiCall<MutateCampaignCustomizersRequest, MutateCampaignCustomizersResponse> call);

        partial void OnConstruction(CampaignCustomizerService.CampaignCustomizerServiceClient grpcClient, CampaignCustomizerServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignCustomizerService client</summary>
        public override CampaignCustomizerService.CampaignCustomizerServiceClient GrpcClient { get; }

        partial void Modify_MutateCampaignCustomizersRequest(ref MutateCampaignCustomizersRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes campaign customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignCustomizersResponse MutateCampaignCustomizers(MutateCampaignCustomizersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignCustomizersRequest(ref request, ref callSettings);
            return _callMutateCampaignCustomizers.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes campaign customizers. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignCustomizersResponse> MutateCampaignCustomizersAsync(MutateCampaignCustomizersRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignCustomizersRequest(ref request, ref callSettings);
            return _callMutateCampaignCustomizers.Async(request, callSettings);
        }
    }
}

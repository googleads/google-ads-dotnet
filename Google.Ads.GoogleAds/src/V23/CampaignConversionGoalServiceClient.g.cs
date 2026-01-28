// Copyright 2026 Google LLC
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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V23.Services
{
    /// <summary>Settings for <see cref="CampaignConversionGoalServiceClient"/> instances.</summary>
    public sealed partial class CampaignConversionGoalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignConversionGoalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignConversionGoalServiceSettings"/>.</returns>
        public static CampaignConversionGoalServiceSettings GetDefault() => new CampaignConversionGoalServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignConversionGoalServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignConversionGoalServiceSettings()
        {
        }

        private CampaignConversionGoalServiceSettings(CampaignConversionGoalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCampaignConversionGoalsSettings = existing.MutateCampaignConversionGoalsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignConversionGoalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignConversionGoalServiceClient.MutateCampaignConversionGoals</c> and
        /// <c>CampaignConversionGoalServiceClient.MutateCampaignConversionGoalsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCampaignConversionGoalsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignConversionGoalServiceSettings"/> object.</returns>
        public CampaignConversionGoalServiceSettings Clone() => new CampaignConversionGoalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignConversionGoalServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class CampaignConversionGoalServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignConversionGoalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignConversionGoalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignConversionGoalServiceClientBuilder() : base(CampaignConversionGoalServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CampaignConversionGoalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignConversionGoalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignConversionGoalServiceClient Build()
        {
            CampaignConversionGoalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignConversionGoalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignConversionGoalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignConversionGoalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignConversionGoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CampaignConversionGoalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignConversionGoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignConversionGoalServiceClient.ChannelPool;
    }

    /// <summary>CampaignConversionGoalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign conversion goal.
    /// </remarks>
    public abstract partial class CampaignConversionGoalServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignConversionGoalService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignConversionGoalService scopes.</summary>
        /// <remarks>
        /// The default CampaignConversionGoalService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CampaignConversionGoalService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignConversionGoalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignConversionGoalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignConversionGoalServiceClient"/>.</returns>
        public static stt::Task<CampaignConversionGoalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignConversionGoalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignConversionGoalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignConversionGoalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignConversionGoalServiceClient"/>.</returns>
        public static CampaignConversionGoalServiceClient Create() =>
            new CampaignConversionGoalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignConversionGoalServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignConversionGoalServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CampaignConversionGoalServiceClient"/>.</returns>
        internal static CampaignConversionGoalServiceClient Create(grpccore::CallInvoker callInvoker, CampaignConversionGoalServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignConversionGoalService.CampaignConversionGoalServiceClient grpcClient = new CampaignConversionGoalService.CampaignConversionGoalServiceClient(callInvoker);
            return new CampaignConversionGoalServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CampaignConversionGoalService client</summary>
        public virtual CampaignConversionGoalService.CampaignConversionGoalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes campaign conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignConversionGoalsResponse MutateCampaignConversionGoals(MutateCampaignConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes campaign conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignConversionGoalsResponse> MutateCampaignConversionGoalsAsync(MutateCampaignConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes campaign conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignConversionGoalsResponse> MutateCampaignConversionGoalsAsync(MutateCampaignConversionGoalsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignConversionGoalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes campaign conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign conversion goals are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign
        /// conversion goal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignConversionGoalsResponse MutateCampaignConversionGoals(string customerId, scg::IEnumerable<CampaignConversionGoalOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignConversionGoals(new MutateCampaignConversionGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes campaign conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign conversion goals are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign
        /// conversion goal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignConversionGoalsResponse> MutateCampaignConversionGoalsAsync(string customerId, scg::IEnumerable<CampaignConversionGoalOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignConversionGoalsAsync(new MutateCampaignConversionGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes campaign conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign conversion goals are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign
        /// conversion goal.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignConversionGoalsResponse> MutateCampaignConversionGoalsAsync(string customerId, scg::IEnumerable<CampaignConversionGoalOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignConversionGoalsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CampaignConversionGoalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign conversion goal.
    /// </remarks>
    public sealed partial class CampaignConversionGoalServiceClientImpl : CampaignConversionGoalServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCampaignConversionGoalsRequest, MutateCampaignConversionGoalsResponse> _callMutateCampaignConversionGoals;

        /// <summary>
        /// Constructs a client wrapper for the CampaignConversionGoalService service, with the specified gRPC client
        /// and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignConversionGoalServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CampaignConversionGoalServiceClientImpl(CampaignConversionGoalService.CampaignConversionGoalServiceClient grpcClient, CampaignConversionGoalServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CampaignConversionGoalServiceSettings effectiveSettings = settings ?? CampaignConversionGoalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCampaignConversionGoals = clientHelper.BuildApiCall<MutateCampaignConversionGoalsRequest, MutateCampaignConversionGoalsResponse>("MutateCampaignConversionGoals", grpcClient.MutateCampaignConversionGoalsAsync, grpcClient.MutateCampaignConversionGoals, effectiveSettings.MutateCampaignConversionGoalsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignConversionGoals);
            Modify_MutateCampaignConversionGoalsApiCall(ref _callMutateCampaignConversionGoals);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCampaignConversionGoalsApiCall(ref gaxgrpc::ApiCall<MutateCampaignConversionGoalsRequest, MutateCampaignConversionGoalsResponse> call);

        partial void OnConstruction(CampaignConversionGoalService.CampaignConversionGoalServiceClient grpcClient, CampaignConversionGoalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignConversionGoalService client</summary>
        public override CampaignConversionGoalService.CampaignConversionGoalServiceClient GrpcClient { get; }

        partial void Modify_MutateCampaignConversionGoalsRequest(ref MutateCampaignConversionGoalsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes campaign conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignConversionGoalsResponse MutateCampaignConversionGoals(MutateCampaignConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignConversionGoalsRequest(ref request, ref callSettings);
            return _callMutateCampaignConversionGoals.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes campaign conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignConversionGoalsResponse> MutateCampaignConversionGoalsAsync(MutateCampaignConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignConversionGoalsRequest(ref request, ref callSettings);
            return _callMutateCampaignConversionGoals.Async(request, callSettings);
        }
    }
}

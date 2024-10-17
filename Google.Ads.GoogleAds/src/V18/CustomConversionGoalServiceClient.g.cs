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
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;

namespace Google.Ads.GoogleAds.V18.Services
{
    /// <summary>Settings for <see cref="CustomConversionGoalServiceClient"/> instances.</summary>
    public sealed partial class CustomConversionGoalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomConversionGoalServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomConversionGoalServiceSettings"/>.</returns>
        public static CustomConversionGoalServiceSettings GetDefault() => new CustomConversionGoalServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomConversionGoalServiceSettings"/> object with default settings.
        /// </summary>
        public CustomConversionGoalServiceSettings()
        {
        }

        private CustomConversionGoalServiceSettings(CustomConversionGoalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomConversionGoalsSettings = existing.MutateCustomConversionGoalsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomConversionGoalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomConversionGoalServiceClient.MutateCustomConversionGoals</c> and
        /// <c>CustomConversionGoalServiceClient.MutateCustomConversionGoalsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomConversionGoalsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomConversionGoalServiceSettings"/> object.</returns>
        public CustomConversionGoalServiceSettings Clone() => new CustomConversionGoalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomConversionGoalServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class CustomConversionGoalServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomConversionGoalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomConversionGoalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomConversionGoalServiceClientBuilder() : base(CustomConversionGoalServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomConversionGoalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomConversionGoalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomConversionGoalServiceClient Build()
        {
            CustomConversionGoalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomConversionGoalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomConversionGoalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomConversionGoalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomConversionGoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CustomConversionGoalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomConversionGoalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomConversionGoalServiceClient.ChannelPool;
    }

    /// <summary>CustomConversionGoalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage custom conversion goal.
    /// </remarks>
    public abstract partial class CustomConversionGoalServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomConversionGoalService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomConversionGoalService scopes.</summary>
        /// <remarks>
        /// The default CustomConversionGoalService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomConversionGoalService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomConversionGoalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomConversionGoalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomConversionGoalServiceClient"/>.</returns>
        public static stt::Task<CustomConversionGoalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomConversionGoalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomConversionGoalServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomConversionGoalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomConversionGoalServiceClient"/>.</returns>
        public static CustomConversionGoalServiceClient Create() => new CustomConversionGoalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomConversionGoalServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomConversionGoalServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomConversionGoalServiceClient"/>.</returns>
        internal static CustomConversionGoalServiceClient Create(grpccore::CallInvoker callInvoker, CustomConversionGoalServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomConversionGoalService.CustomConversionGoalServiceClient grpcClient = new CustomConversionGoalService.CustomConversionGoalServiceClient(callInvoker);
            return new CustomConversionGoalServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomConversionGoalService client</summary>
        public virtual CustomConversionGoalService.CustomConversionGoalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes custom conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomConversionGoalsResponse MutateCustomConversionGoals(MutateCustomConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes custom conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomConversionGoalsResponse> MutateCustomConversionGoalsAsync(MutateCustomConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes custom conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomConversionGoalsResponse> MutateCustomConversionGoalsAsync(MutateCustomConversionGoalsRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomConversionGoalsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes custom conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom conversion goals are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual custom conversion
        /// goal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomConversionGoalsResponse MutateCustomConversionGoals(string customerId, scg::IEnumerable<CustomConversionGoalOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomConversionGoals(new MutateCustomConversionGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes custom conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom conversion goals are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual custom conversion
        /// goal.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomConversionGoalsResponse> MutateCustomConversionGoalsAsync(string customerId, scg::IEnumerable<CustomConversionGoalOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomConversionGoalsAsync(new MutateCustomConversionGoalsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes custom conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose custom conversion goals are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual custom conversion
        /// goal.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomConversionGoalsResponse> MutateCustomConversionGoalsAsync(string customerId, scg::IEnumerable<CustomConversionGoalOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomConversionGoalsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomConversionGoalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage custom conversion goal.
    /// </remarks>
    public sealed partial class CustomConversionGoalServiceClientImpl : CustomConversionGoalServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomConversionGoalsRequest, MutateCustomConversionGoalsResponse> _callMutateCustomConversionGoals;

        /// <summary>
        /// Constructs a client wrapper for the CustomConversionGoalService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomConversionGoalServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomConversionGoalServiceClientImpl(CustomConversionGoalService.CustomConversionGoalServiceClient grpcClient, CustomConversionGoalServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomConversionGoalServiceSettings effectiveSettings = settings ?? CustomConversionGoalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callMutateCustomConversionGoals = clientHelper.BuildApiCall<MutateCustomConversionGoalsRequest, MutateCustomConversionGoalsResponse>("MutateCustomConversionGoals", grpcClient.MutateCustomConversionGoalsAsync, grpcClient.MutateCustomConversionGoals, effectiveSettings.MutateCustomConversionGoalsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomConversionGoals);
            Modify_MutateCustomConversionGoalsApiCall(ref _callMutateCustomConversionGoals);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomConversionGoalsApiCall(ref gaxgrpc::ApiCall<MutateCustomConversionGoalsRequest, MutateCustomConversionGoalsResponse> call);

        partial void OnConstruction(CustomConversionGoalService.CustomConversionGoalServiceClient grpcClient, CustomConversionGoalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomConversionGoalService client</summary>
        public override CustomConversionGoalService.CustomConversionGoalServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomConversionGoalsRequest(ref MutateCustomConversionGoalsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes custom conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomConversionGoalsResponse MutateCustomConversionGoals(MutateCustomConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomConversionGoalsRequest(ref request, ref callSettings);
            return _callMutateCustomConversionGoals.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes custom conversion goals. Operation statuses
        /// are returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomConversionGoalsResponse> MutateCustomConversionGoalsAsync(MutateCustomConversionGoalsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomConversionGoalsRequest(ref request, ref callSettings);
            return _callMutateCustomConversionGoals.Async(request, callSettings);
        }
    }
}

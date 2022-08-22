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

namespace Google.Ads.GoogleAds.V11.Services
{
    /// <summary>Settings for <see cref="ExperimentArmServiceClient"/> instances.</summary>
    public sealed partial class ExperimentArmServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExperimentArmServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExperimentArmServiceSettings"/>.</returns>
        public static ExperimentArmServiceSettings GetDefault() => new ExperimentArmServiceSettings();

        /// <summary>Constructs a new <see cref="ExperimentArmServiceSettings"/> object with default settings.</summary>
        public ExperimentArmServiceSettings()
        {
        }

        private ExperimentArmServiceSettings(ExperimentArmServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateExperimentArmsSettings = existing.MutateExperimentArmsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ExperimentArmServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentArmServiceClient.MutateExperimentArms</c> and
        /// <c>ExperimentArmServiceClient.MutateExperimentArmsAsync</c>.
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
        public gaxgrpc::CallSettings MutateExperimentArmsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExperimentArmServiceSettings"/> object.</returns>
        public ExperimentArmServiceSettings Clone() => new ExperimentArmServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExperimentArmServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class ExperimentArmServiceClientBuilder : gaxgrpc::ClientBuilderBase<ExperimentArmServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExperimentArmServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ExperimentArmServiceClientBuilder() : base(ExperimentArmServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ExperimentArmServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExperimentArmServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExperimentArmServiceClient Build()
        {
            ExperimentArmServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExperimentArmServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExperimentArmServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExperimentArmServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExperimentArmServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<ExperimentArmServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExperimentArmServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExperimentArmServiceClient.ChannelPool;
    }

    /// <summary>ExperimentArmService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage experiment arms.
    /// </remarks>
    public abstract partial class ExperimentArmServiceClient
    {
        /// <summary>
        /// The default endpoint for the ExperimentArmService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ExperimentArmService scopes.</summary>
        /// <remarks>
        /// The default ExperimentArmService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ExperimentArmService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ExperimentArmServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="ExperimentArmServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExperimentArmServiceClient"/>.</returns>
        public static stt::Task<ExperimentArmServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExperimentArmServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExperimentArmServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="ExperimentArmServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExperimentArmServiceClient"/>.</returns>
        public static ExperimentArmServiceClient Create() => new ExperimentArmServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExperimentArmServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExperimentArmServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ExperimentArmServiceClient"/>.</returns>
        internal static ExperimentArmServiceClient Create(grpccore::CallInvoker callInvoker, ExperimentArmServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ExperimentArmService.ExperimentArmServiceClient grpcClient = new ExperimentArmService.ExperimentArmServiceClient(callInvoker);
            return new ExperimentArmServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ExperimentArmService client</summary>
        public virtual ExperimentArmService.ExperimentArmServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes experiment arms. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentArmError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateExperimentArmsResponse MutateExperimentArms(MutateExperimentArmsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes experiment arms. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentArmError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExperimentArmsResponse> MutateExperimentArmsAsync(MutateExperimentArmsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes experiment arms. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentArmError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExperimentArmsResponse> MutateExperimentArmsAsync(MutateExperimentArmsRequest request, st::CancellationToken cancellationToken) =>
            MutateExperimentArmsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes experiment arms. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentArmError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual experiment arm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateExperimentArmsResponse MutateExperimentArms(string customerId, scg::IEnumerable<ExperimentArmOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateExperimentArms(new MutateExperimentArmsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes experiment arms. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentArmError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual experiment arm.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExperimentArmsResponse> MutateExperimentArmsAsync(string customerId, scg::IEnumerable<ExperimentArmOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateExperimentArmsAsync(new MutateExperimentArmsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes experiment arms. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentArmError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual experiment arm.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExperimentArmsResponse> MutateExperimentArmsAsync(string customerId, scg::IEnumerable<ExperimentArmOperation> operations, st::CancellationToken cancellationToken) =>
            MutateExperimentArmsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ExperimentArmService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage experiment arms.
    /// </remarks>
    public sealed partial class ExperimentArmServiceClientImpl : ExperimentArmServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateExperimentArmsRequest, MutateExperimentArmsResponse> _callMutateExperimentArms;

        /// <summary>
        /// Constructs a client wrapper for the ExperimentArmService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ExperimentArmServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ExperimentArmServiceClientImpl(ExperimentArmService.ExperimentArmServiceClient grpcClient, ExperimentArmServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ExperimentArmServiceSettings effectiveSettings = settings ?? ExperimentArmServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateExperimentArms = clientHelper.BuildApiCall<MutateExperimentArmsRequest, MutateExperimentArmsResponse>("MutateExperimentArms", grpcClient.MutateExperimentArmsAsync, grpcClient.MutateExperimentArms, effectiveSettings.MutateExperimentArmsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateExperimentArms);
            Modify_MutateExperimentArmsApiCall(ref _callMutateExperimentArms);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateExperimentArmsApiCall(ref gaxgrpc::ApiCall<MutateExperimentArmsRequest, MutateExperimentArmsResponse> call);

        partial void OnConstruction(ExperimentArmService.ExperimentArmServiceClient grpcClient, ExperimentArmServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ExperimentArmService client</summary>
        public override ExperimentArmService.ExperimentArmServiceClient GrpcClient { get; }

        partial void Modify_MutateExperimentArmsRequest(ref MutateExperimentArmsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes experiment arms. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentArmError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateExperimentArmsResponse MutateExperimentArms(MutateExperimentArmsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateExperimentArmsRequest(ref request, ref callSettings);
            return _callMutateExperimentArms.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes experiment arms. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentArmError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateExperimentArmsResponse> MutateExperimentArmsAsync(MutateExperimentArmsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateExperimentArmsRequest(ref request, ref callSettings);
            return _callMutateExperimentArms.Async(request, callSettings);
        }
    }
}

// Copyright 2025 Google LLC
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
using gagvr = Google.Ads.GoogleAds.V22.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using lro = Google.LongRunning;
using mel = Microsoft.Extensions.Logging;
using proto = Google.Protobuf;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;
using sys = System;
using wkt = Google.Protobuf.WellKnownTypes;

namespace Google.Ads.GoogleAds.V22.Services
{
    /// <summary>Settings for <see cref="ExperimentServiceClient"/> instances.</summary>
    public sealed partial class ExperimentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="ExperimentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="ExperimentServiceSettings"/>.</returns>
        public static ExperimentServiceSettings GetDefault() => new ExperimentServiceSettings();

        /// <summary>Constructs a new <see cref="ExperimentServiceSettings"/> object with default settings.</summary>
        public ExperimentServiceSettings()
        {
        }

        private ExperimentServiceSettings(ExperimentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateExperimentsSettings = existing.MutateExperimentsSettings;
            EndExperimentSettings = existing.EndExperimentSettings;
            ListExperimentAsyncErrorsSettings = existing.ListExperimentAsyncErrorsSettings;
            GraduateExperimentSettings = existing.GraduateExperimentSettings;
            ScheduleExperimentSettings = existing.ScheduleExperimentSettings;
            ScheduleExperimentOperationsSettings = existing.ScheduleExperimentOperationsSettings.Clone();
            PromoteExperimentSettings = existing.PromoteExperimentSettings;
            PromoteExperimentOperationsSettings = existing.PromoteExperimentOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(ExperimentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentServiceClient.MutateExperiments</c> and <c>ExperimentServiceClient.MutateExperimentsAsync</c>.
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
        public gaxgrpc::CallSettings MutateExperimentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentServiceClient.EndExperiment</c> and <c>ExperimentServiceClient.EndExperimentAsync</c>.
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
        public gaxgrpc::CallSettings EndExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentServiceClient.ListExperimentAsyncErrors</c> and
        /// <c>ExperimentServiceClient.ListExperimentAsyncErrorsAsync</c>.
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
        public gaxgrpc::CallSettings ListExperimentAsyncErrorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentServiceClient.GraduateExperiment</c> and <c>ExperimentServiceClient.GraduateExperimentAsync</c>
        /// .
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
        public gaxgrpc::CallSettings GraduateExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentServiceClient.ScheduleExperiment</c> and <c>ExperimentServiceClient.ScheduleExperimentAsync</c>
        /// .
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
        public gaxgrpc::CallSettings ScheduleExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ExperimentServiceClient.ScheduleExperiment</c> and
        /// <c>ExperimentServiceClient.ScheduleExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings ScheduleExperimentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ExperimentServiceClient.PromoteExperiment</c> and <c>ExperimentServiceClient.PromoteExperimentAsync</c>.
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
        public gaxgrpc::CallSettings PromoteExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>ExperimentServiceClient.PromoteExperiment</c> and
        /// <c>ExperimentServiceClient.PromoteExperimentAsync</c>.
        /// </summary>
        /// <remarks>
        /// Uses default <see cref="gax::PollSettings"/> of:
        /// <list type="bullet">
        /// <item><description>Initial delay: 20 seconds.</description></item>
        /// <item><description>Delay multiplier: 1.5</description></item>
        /// <item><description>Maximum delay: 45 seconds.</description></item>
        /// <item><description>Total timeout: 24 hours.</description></item>
        /// </list>
        /// </remarks>
        public lro::OperationsSettings PromoteExperimentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ExperimentServiceSettings"/> object.</returns>
        public ExperimentServiceSettings Clone() => new ExperimentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ExperimentServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class ExperimentServiceClientBuilder : gaxgrpc::ClientBuilderBase<ExperimentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ExperimentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ExperimentServiceClientBuilder() : base(ExperimentServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ExperimentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ExperimentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ExperimentServiceClient Build()
        {
            ExperimentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ExperimentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ExperimentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ExperimentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ExperimentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<ExperimentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ExperimentServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ExperimentServiceClient.ChannelPool;
    }

    /// <summary>ExperimentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage experiments.
    /// </remarks>
    public abstract partial class ExperimentServiceClient
    {
        /// <summary>
        /// The default endpoint for the ExperimentService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ExperimentService scopes.</summary>
        /// <remarks>
        /// The default ExperimentService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ExperimentService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ExperimentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ExperimentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ExperimentServiceClient"/>.</returns>
        public static stt::Task<ExperimentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ExperimentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ExperimentServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="ExperimentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ExperimentServiceClient"/>.</returns>
        public static ExperimentServiceClient Create() => new ExperimentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ExperimentServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ExperimentServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ExperimentServiceClient"/>.</returns>
        internal static ExperimentServiceClient Create(grpccore::CallInvoker callInvoker, ExperimentServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ExperimentService.ExperimentServiceClient grpcClient = new ExperimentService.ExperimentServiceClient(callInvoker);
            return new ExperimentServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ExperimentService client</summary>
        public virtual ExperimentService.ExperimentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateExperimentsResponse MutateExperiments(MutateExperimentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExperimentsResponse> MutateExperimentsAsync(MutateExperimentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExperimentsResponse> MutateExperimentsAsync(MutateExperimentsRequest request, st::CancellationToken cancellationToken) =>
            MutateExperimentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual experiments.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateExperimentsResponse MutateExperiments(string customerId, scg::IEnumerable<ExperimentOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateExperiments(new MutateExperimentsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual experiments.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExperimentsResponse> MutateExperimentsAsync(string customerId, scg::IEnumerable<ExperimentOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateExperimentsAsync(new MutateExperimentsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual experiments.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateExperimentsResponse> MutateExperimentsAsync(string customerId, scg::IEnumerable<ExperimentOperation> operations, st::CancellationToken cancellationToken) =>
            MutateExperimentsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EndExperiment(EndExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndExperimentAsync(EndExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndExperimentAsync(EndExperimentRequest request, st::CancellationToken cancellationToken) =>
            EndExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EndExperiment(string experiment, gaxgrpc::CallSettings callSettings = null) =>
            EndExperiment(new EndExperimentRequest
            {
                Experiment = gax::GaxPreconditions.CheckNotNullOrEmpty(experiment, nameof(experiment)),
            }, callSettings);

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndExperimentAsync(string experiment, gaxgrpc::CallSettings callSettings = null) =>
            EndExperimentAsync(new EndExperimentRequest
            {
                Experiment = gax::GaxPreconditions.CheckNotNullOrEmpty(experiment, nameof(experiment)),
            }, callSettings);

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndExperimentAsync(string experiment, st::CancellationToken cancellationToken) =>
            EndExperimentAsync(experiment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EndExperiment(gagvr::ExperimentName experiment, gaxgrpc::CallSettings callSettings = null) =>
            EndExperiment(new EndExperimentRequest
            {
                ExperimentAsExperimentName = gax::GaxPreconditions.CheckNotNull(experiment, nameof(experiment)),
            }, callSettings);

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndExperimentAsync(gagvr::ExperimentName experiment, gaxgrpc::CallSettings callSettings = null) =>
            EndExperimentAsync(new EndExperimentRequest
            {
                ExperimentAsExperimentName = gax::GaxPreconditions.CheckNotNull(experiment, nameof(experiment)),
            }, callSettings);

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndExperimentAsync(gagvr::ExperimentName experiment, st::CancellationToken cancellationToken) =>
            EndExperimentAsync(experiment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all errors that occurred during the last Experiment update (either
        /// scheduling or promotion).
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExperimentAsyncErrorsResponse, gr::Status> ListExperimentAsyncErrors(ListExperimentAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all errors that occurred during the last Experiment update (either
        /// scheduling or promotion).
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExperimentAsyncErrorsResponse, gr::Status> ListExperimentAsyncErrorsAsync(ListExperimentAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all errors that occurred during the last Experiment update (either
        /// scheduling or promotion).
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The name of the experiment from which to retrieve the async
        /// errors.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExperimentAsyncErrorsResponse, gr::Status> ListExperimentAsyncErrors(string resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExperimentAsyncErrorsRequest request = new ListExperimentAsyncErrorsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExperimentAsyncErrors(request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during the last Experiment update (either
        /// scheduling or promotion).
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The name of the experiment from which to retrieve the async
        /// errors.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExperimentAsyncErrorsResponse, gr::Status> ListExperimentAsyncErrorsAsync(string resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExperimentAsyncErrorsRequest request = new ListExperimentAsyncErrorsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExperimentAsyncErrorsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during the last Experiment update (either
        /// scheduling or promotion).
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The name of the experiment from which to retrieve the async
        /// errors.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListExperimentAsyncErrorsResponse, gr::Status> ListExperimentAsyncErrors(gagvr::ExperimentName resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExperimentAsyncErrorsRequest request = new ListExperimentAsyncErrorsRequest
            {
                ResourceNameAsExperimentName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExperimentAsyncErrors(request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during the last Experiment update (either
        /// scheduling or promotion).
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The name of the experiment from which to retrieve the async
        /// errors.
        /// </param>
        /// <param name="pageToken">
        /// The token returned from the previous request. A value of <c>null</c> or an empty string retrieves the first
        /// page.
        /// </param>
        /// <param name="pageSize">
        /// The size of page to request. The response will not be larger than this, but may be smaller. A value of
        /// <c>null</c> or <c>0</c> uses a server-defined page size.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gr::Status"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListExperimentAsyncErrorsResponse, gr::Status> ListExperimentAsyncErrorsAsync(gagvr::ExperimentName resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListExperimentAsyncErrorsRequest request = new ListExperimentAsyncErrorsRequest
            {
                ResourceNameAsExperimentName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListExperimentAsyncErrorsAsync(request, callSettings);
        }

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void GraduateExperiment(GraduateExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task GraduateExperimentAsync(GraduateExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task GraduateExperimentAsync(GraduateExperimentRequest request, st::CancellationToken cancellationToken) =>
            GraduateExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The experiment to be graduated.
        /// </param>
        /// <param name="campaignBudgetMappings">
        /// Required. List of campaign budget mappings for graduation. Each campaign
        /// that appears here will graduate, and will be assigned a new budget that is
        /// paired with it in the mapping. The maximum size is one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void GraduateExperiment(string experiment, scg::IEnumerable<CampaignBudgetMapping> campaignBudgetMappings, gaxgrpc::CallSettings callSettings = null) =>
            GraduateExperiment(new GraduateExperimentRequest
            {
                Experiment = gax::GaxPreconditions.CheckNotNullOrEmpty(experiment, nameof(experiment)),
                CampaignBudgetMappings =
                {
                    gax::GaxPreconditions.CheckNotNull(campaignBudgetMappings, nameof(campaignBudgetMappings)),
                },
            }, callSettings);

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The experiment to be graduated.
        /// </param>
        /// <param name="campaignBudgetMappings">
        /// Required. List of campaign budget mappings for graduation. Each campaign
        /// that appears here will graduate, and will be assigned a new budget that is
        /// paired with it in the mapping. The maximum size is one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task GraduateExperimentAsync(string experiment, scg::IEnumerable<CampaignBudgetMapping> campaignBudgetMappings, gaxgrpc::CallSettings callSettings = null) =>
            GraduateExperimentAsync(new GraduateExperimentRequest
            {
                Experiment = gax::GaxPreconditions.CheckNotNullOrEmpty(experiment, nameof(experiment)),
                CampaignBudgetMappings =
                {
                    gax::GaxPreconditions.CheckNotNull(campaignBudgetMappings, nameof(campaignBudgetMappings)),
                },
            }, callSettings);

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The experiment to be graduated.
        /// </param>
        /// <param name="campaignBudgetMappings">
        /// Required. List of campaign budget mappings for graduation. Each campaign
        /// that appears here will graduate, and will be assigned a new budget that is
        /// paired with it in the mapping. The maximum size is one.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task GraduateExperimentAsync(string experiment, scg::IEnumerable<CampaignBudgetMapping> campaignBudgetMappings, st::CancellationToken cancellationToken) =>
            GraduateExperimentAsync(experiment, campaignBudgetMappings, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The experiment to be graduated.
        /// </param>
        /// <param name="campaignBudgetMappings">
        /// Required. List of campaign budget mappings for graduation. Each campaign
        /// that appears here will graduate, and will be assigned a new budget that is
        /// paired with it in the mapping. The maximum size is one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void GraduateExperiment(gagvr::ExperimentName experiment, scg::IEnumerable<CampaignBudgetMapping> campaignBudgetMappings, gaxgrpc::CallSettings callSettings = null) =>
            GraduateExperiment(new GraduateExperimentRequest
            {
                ExperimentAsExperimentName = gax::GaxPreconditions.CheckNotNull(experiment, nameof(experiment)),
                CampaignBudgetMappings =
                {
                    gax::GaxPreconditions.CheckNotNull(campaignBudgetMappings, nameof(campaignBudgetMappings)),
                },
            }, callSettings);

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The experiment to be graduated.
        /// </param>
        /// <param name="campaignBudgetMappings">
        /// Required. List of campaign budget mappings for graduation. Each campaign
        /// that appears here will graduate, and will be assigned a new budget that is
        /// paired with it in the mapping. The maximum size is one.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task GraduateExperimentAsync(gagvr::ExperimentName experiment, scg::IEnumerable<CampaignBudgetMapping> campaignBudgetMappings, gaxgrpc::CallSettings callSettings = null) =>
            GraduateExperimentAsync(new GraduateExperimentRequest
            {
                ExperimentAsExperimentName = gax::GaxPreconditions.CheckNotNull(experiment, nameof(experiment)),
                CampaignBudgetMappings =
                {
                    gax::GaxPreconditions.CheckNotNull(campaignBudgetMappings, nameof(campaignBudgetMappings)),
                },
            }, callSettings);

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="experiment">
        /// Required. The experiment to be graduated.
        /// </param>
        /// <param name="campaignBudgetMappings">
        /// Required. List of campaign budget mappings for graduation. Each campaign
        /// that appears here will graduate, and will be assigned a new budget that is
        /// paired with it in the mapping. The maximum size is one.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task GraduateExperimentAsync(gagvr::ExperimentName experiment, scg::IEnumerable<CampaignBudgetMapping> campaignBudgetMappings, st::CancellationToken cancellationToken) =>
            GraduateExperimentAsync(experiment, campaignBudgetMappings, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ScheduleExperimentMetadata> ScheduleExperiment(ScheduleExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ScheduleExperimentMetadata>> ScheduleExperimentAsync(ScheduleExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ScheduleExperimentMetadata>> ScheduleExperimentAsync(ScheduleExperimentRequest request, st::CancellationToken cancellationToken) =>
            ScheduleExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>ScheduleExperiment</c>.</summary>
        public virtual lro::OperationsClient ScheduleExperimentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>ScheduleExperiment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, ScheduleExperimentMetadata> PollOnceScheduleExperiment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ScheduleExperimentMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ScheduleExperimentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>ScheduleExperiment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ScheduleExperimentMetadata>> PollOnceScheduleExperimentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, ScheduleExperimentMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), ScheduleExperimentOperationsClient, callSettings);

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The scheduled experiment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ScheduleExperimentMetadata> ScheduleExperiment(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleExperiment(new ScheduleExperimentRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The scheduled experiment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ScheduleExperimentMetadata>> ScheduleExperimentAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleExperimentAsync(new ScheduleExperimentRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The scheduled experiment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ScheduleExperimentMetadata>> ScheduleExperimentAsync(string resourceName, st::CancellationToken cancellationToken) =>
            ScheduleExperimentAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The scheduled experiment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, ScheduleExperimentMetadata> ScheduleExperiment(gagvr::ExperimentName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleExperiment(new ScheduleExperimentRequest
            {
                ResourceNameAsExperimentName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The scheduled experiment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ScheduleExperimentMetadata>> ScheduleExperimentAsync(gagvr::ExperimentName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            ScheduleExperimentAsync(new ScheduleExperimentRequest
            {
                ResourceNameAsExperimentName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The scheduled experiment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, ScheduleExperimentMetadata>> ScheduleExperimentAsync(gagvr::ExperimentName resourceName, st::CancellationToken cancellationToken) =>
            ScheduleExperimentAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, PromoteExperimentMetadata> PromoteExperiment(PromoteExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, PromoteExperimentMetadata>> PromoteExperimentAsync(PromoteExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, PromoteExperimentMetadata>> PromoteExperimentAsync(PromoteExperimentRequest request, st::CancellationToken cancellationToken) =>
            PromoteExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PromoteExperiment</c>.</summary>
        public virtual lro::OperationsClient PromoteExperimentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PromoteExperiment</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, PromoteExperimentMetadata> PollOncePromoteExperiment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, PromoteExperimentMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteExperimentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PromoteExperiment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, PromoteExperimentMetadata>> PollOncePromoteExperimentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, PromoteExperimentMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteExperimentOperationsClient, callSettings);

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the experiment to promote.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, PromoteExperimentMetadata> PromoteExperiment(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            PromoteExperiment(new PromoteExperimentRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the experiment to promote.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, PromoteExperimentMetadata>> PromoteExperimentAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            PromoteExperimentAsync(new PromoteExperimentRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the experiment to promote.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, PromoteExperimentMetadata>> PromoteExperimentAsync(string resourceName, st::CancellationToken cancellationToken) =>
            PromoteExperimentAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the experiment to promote.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, PromoteExperimentMetadata> PromoteExperiment(gagvr::ExperimentName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            PromoteExperiment(new PromoteExperimentRequest
            {
                ResourceNameAsExperimentName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the experiment to promote.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, PromoteExperimentMetadata>> PromoteExperimentAsync(gagvr::ExperimentName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            PromoteExperimentAsync(new PromoteExperimentRequest
            {
                ResourceNameAsExperimentName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the experiment to promote.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, PromoteExperimentMetadata>> PromoteExperimentAsync(gagvr::ExperimentName resourceName, st::CancellationToken cancellationToken) =>
            PromoteExperimentAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ExperimentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage experiments.
    /// </remarks>
    public sealed partial class ExperimentServiceClientImpl : ExperimentServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateExperimentsRequest, MutateExperimentsResponse> _callMutateExperiments;

        private readonly gaxgrpc::ApiCall<EndExperimentRequest, wkt::Empty> _callEndExperiment;

        private readonly gaxgrpc::ApiCall<ListExperimentAsyncErrorsRequest, ListExperimentAsyncErrorsResponse> _callListExperimentAsyncErrors;

        private readonly gaxgrpc::ApiCall<GraduateExperimentRequest, wkt::Empty> _callGraduateExperiment;

        private readonly gaxgrpc::ApiCall<ScheduleExperimentRequest, lro::Operation> _callScheduleExperiment;

        private readonly gaxgrpc::ApiCall<PromoteExperimentRequest, lro::Operation> _callPromoteExperiment;

        /// <summary>
        /// Constructs a client wrapper for the ExperimentService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="ExperimentServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ExperimentServiceClientImpl(ExperimentService.ExperimentServiceClient grpcClient, ExperimentServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ExperimentServiceSettings effectiveSettings = settings ?? ExperimentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            ScheduleExperimentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.ScheduleExperimentOperationsSettings, logger);
            PromoteExperimentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PromoteExperimentOperationsSettings, logger);
            _callMutateExperiments = clientHelper.BuildApiCall<MutateExperimentsRequest, MutateExperimentsResponse>("MutateExperiments", grpcClient.MutateExperimentsAsync, grpcClient.MutateExperiments, effectiveSettings.MutateExperimentsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateExperiments);
            Modify_MutateExperimentsApiCall(ref _callMutateExperiments);
            _callEndExperiment = clientHelper.BuildApiCall<EndExperimentRequest, wkt::Empty>("EndExperiment", grpcClient.EndExperimentAsync, grpcClient.EndExperiment, effectiveSettings.EndExperimentSettings).WithGoogleRequestParam("experiment", request => request.Experiment);
            Modify_ApiCall(ref _callEndExperiment);
            Modify_EndExperimentApiCall(ref _callEndExperiment);
            _callListExperimentAsyncErrors = clientHelper.BuildApiCall<ListExperimentAsyncErrorsRequest, ListExperimentAsyncErrorsResponse>("ListExperimentAsyncErrors", grpcClient.ListExperimentAsyncErrorsAsync, grpcClient.ListExperimentAsyncErrors, effectiveSettings.ListExperimentAsyncErrorsSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callListExperimentAsyncErrors);
            Modify_ListExperimentAsyncErrorsApiCall(ref _callListExperimentAsyncErrors);
            _callGraduateExperiment = clientHelper.BuildApiCall<GraduateExperimentRequest, wkt::Empty>("GraduateExperiment", grpcClient.GraduateExperimentAsync, grpcClient.GraduateExperiment, effectiveSettings.GraduateExperimentSettings).WithGoogleRequestParam("experiment", request => request.Experiment);
            Modify_ApiCall(ref _callGraduateExperiment);
            Modify_GraduateExperimentApiCall(ref _callGraduateExperiment);
            _callScheduleExperiment = clientHelper.BuildApiCall<ScheduleExperimentRequest, lro::Operation>("ScheduleExperiment", grpcClient.ScheduleExperimentAsync, grpcClient.ScheduleExperiment, effectiveSettings.ScheduleExperimentSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callScheduleExperiment);
            Modify_ScheduleExperimentApiCall(ref _callScheduleExperiment);
            _callPromoteExperiment = clientHelper.BuildApiCall<PromoteExperimentRequest, lro::Operation>("PromoteExperiment", grpcClient.PromoteExperimentAsync, grpcClient.PromoteExperiment, effectiveSettings.PromoteExperimentSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callPromoteExperiment);
            Modify_PromoteExperimentApiCall(ref _callPromoteExperiment);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateExperimentsApiCall(ref gaxgrpc::ApiCall<MutateExperimentsRequest, MutateExperimentsResponse> call);

        partial void Modify_EndExperimentApiCall(ref gaxgrpc::ApiCall<EndExperimentRequest, wkt::Empty> call);

        partial void Modify_ListExperimentAsyncErrorsApiCall(ref gaxgrpc::ApiCall<ListExperimentAsyncErrorsRequest, ListExperimentAsyncErrorsResponse> call);

        partial void Modify_GraduateExperimentApiCall(ref gaxgrpc::ApiCall<GraduateExperimentRequest, wkt::Empty> call);

        partial void Modify_ScheduleExperimentApiCall(ref gaxgrpc::ApiCall<ScheduleExperimentRequest, lro::Operation> call);

        partial void Modify_PromoteExperimentApiCall(ref gaxgrpc::ApiCall<PromoteExperimentRequest, lro::Operation> call);

        partial void OnConstruction(ExperimentService.ExperimentServiceClient grpcClient, ExperimentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ExperimentService client</summary>
        public override ExperimentService.ExperimentServiceClient GrpcClient { get; }

        partial void Modify_MutateExperimentsRequest(ref MutateExperimentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EndExperimentRequest(ref EndExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListExperimentAsyncErrorsRequest(ref ListExperimentAsyncErrorsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GraduateExperimentRequest(ref GraduateExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ScheduleExperimentRequest(ref ScheduleExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PromoteExperimentRequest(ref PromoteExperimentRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateExperimentsResponse MutateExperiments(MutateExperimentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateExperimentsRequest(ref request, ref callSettings);
            return _callMutateExperiments.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateExperimentsResponse> MutateExperimentsAsync(MutateExperimentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateExperimentsRequest(ref request, ref callSettings);
            return _callMutateExperiments.Async(request, callSettings);
        }

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void EndExperiment(EndExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EndExperimentRequest(ref request, ref callSettings);
            _callEndExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Immediately ends an experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task EndExperimentAsync(EndExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EndExperimentRequest(ref request, ref callSettings);
            return _callEndExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during the last Experiment update (either
        /// scheduling or promotion).
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="gr::Status"/> resources.</returns>
        public override gax::PagedEnumerable<ListExperimentAsyncErrorsResponse, gr::Status> ListExperimentAsyncErrors(ListExperimentAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExperimentAsyncErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::AdsPagedEnumerable<ListExperimentAsyncErrorsRequest, ListExperimentAsyncErrorsResponse, gr::Status>(_callListExperimentAsyncErrors, request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during the last Experiment update (either
        /// scheduling or promotion).
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="gr::Status"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListExperimentAsyncErrorsResponse, gr::Status> ListExperimentAsyncErrorsAsync(ListExperimentAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListExperimentAsyncErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::AdsPagedAsyncEnumerable<ListExperimentAsyncErrorsRequest, ListExperimentAsyncErrorsResponse, gr::Status>(_callListExperimentAsyncErrors, request, callSettings);
        }

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void GraduateExperiment(GraduateExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GraduateExperimentRequest(ref request, ref callSettings);
            _callGraduateExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Graduates an experiment to a full campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task GraduateExperimentAsync(GraduateExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GraduateExperimentRequest(ref request, ref callSettings);
            return _callGraduateExperiment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>ScheduleExperiment</c>.</summary>
        public override lro::OperationsClient ScheduleExperimentOperationsClient { get; }

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, ScheduleExperimentMetadata> ScheduleExperiment(ScheduleExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ScheduleExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ScheduleExperimentMetadata>(_callScheduleExperiment.Sync(request, callSettings), ScheduleExperimentOperationsClient);
        }

        /// <summary>
        /// Schedule an experiment. The in design campaign
        /// will be converted into a real campaign (called the experiment campaign)
        /// that will begin serving ads if successfully created.
        /// 
        /// The experiment is scheduled immediately with status INITIALIZING.
        /// This method returns a long running operation that tracks the forking of the
        /// in design campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [DatabaseError]()
        /// [DateError]()
        /// [DateRangeError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RangeError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, ScheduleExperimentMetadata>> ScheduleExperimentAsync(ScheduleExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ScheduleExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, ScheduleExperimentMetadata>(await _callScheduleExperiment.Async(request, callSettings).ConfigureAwait(false), ScheduleExperimentOperationsClient);
        }

        /// <summary>The long-running operations client for <c>PromoteExperiment</c>.</summary>
        public override lro::OperationsClient PromoteExperimentOperationsClient { get; }

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, PromoteExperimentMetadata> PromoteExperiment(PromoteExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, PromoteExperimentMetadata>(_callPromoteExperiment.Sync(request, callSettings), PromoteExperimentOperationsClient);
        }

        /// <summary>
        /// Promotes the trial campaign thus applying changes in the trial campaign
        /// to the base campaign.
        /// This method returns a long running operation that tracks the promotion of
        /// the experiment campaign. If it fails, a list of errors can be retrieved
        /// using the ListExperimentAsyncErrors method. The operation's
        /// metadata will be a string containing the resource name of the created
        /// experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, PromoteExperimentMetadata>> PromoteExperimentAsync(PromoteExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, PromoteExperimentMetadata>(await _callPromoteExperiment.Async(request, callSettings).ConfigureAwait(false), PromoteExperimentOperationsClient);
        }
    }

    public partial class ListExperimentAsyncErrorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListExperimentAsyncErrorsResponse : gaxgrpc::IPageResponse<gr::Status>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<gr::Status> GetEnumerator() => Errors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class ExperimentService
    {
        public partial class ExperimentServiceClient
        {
            /// <summary>
            /// Creates a new instance of <see cref="lro::Operations.OperationsClient"/> using the same call invoker as
            /// this client.
            /// </summary>
            /// <returns>A new Operations client for the same target as this client.</returns>
            public virtual lro::Operations.OperationsClient CreateOperationsClient() =>
                new lro::Operations.OperationsClient(CallInvoker);
        }
    }
}

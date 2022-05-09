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
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using gr = Google.Rpc;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V9.Services
{
    /// <summary>Settings for <see cref="CampaignExperimentServiceClient"/> instances.</summary>
    public sealed partial class CampaignExperimentServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignExperimentServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignExperimentServiceSettings"/>.</returns>
        public static CampaignExperimentServiceSettings GetDefault() => new CampaignExperimentServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CampaignExperimentServiceSettings"/> object with default settings.
        /// </summary>
        public CampaignExperimentServiceSettings()
        {
        }

        private CampaignExperimentServiceSettings(CampaignExperimentServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            GetCampaignExperimentSettings = existing.GetCampaignExperimentSettings;
            CreateCampaignExperimentSettings = existing.CreateCampaignExperimentSettings;
            CreateCampaignExperimentOperationsSettings = existing.CreateCampaignExperimentOperationsSettings.Clone();
            MutateCampaignExperimentsSettings = existing.MutateCampaignExperimentsSettings;
            GraduateCampaignExperimentSettings = existing.GraduateCampaignExperimentSettings;
            PromoteCampaignExperimentSettings = existing.PromoteCampaignExperimentSettings;
            PromoteCampaignExperimentOperationsSettings = existing.PromoteCampaignExperimentOperationsSettings.Clone();
            EndCampaignExperimentSettings = existing.EndCampaignExperimentSettings;
            ListCampaignExperimentAsyncErrorsSettings = existing.ListCampaignExperimentAsyncErrorsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignExperimentServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.GetCampaignExperiment</c> and
        /// <c>CampaignExperimentServiceClient.GetCampaignExperimentAsync</c>.
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
        public gaxgrpc::CallSettings GetCampaignExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.CreateCampaignExperiment</c> and
        /// <c>CampaignExperimentServiceClient.CreateCampaignExperimentAsync</c>.
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
        public gaxgrpc::CallSettings CreateCampaignExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CampaignExperimentServiceClient.CreateCampaignExperiment</c>
        /// and <c>CampaignExperimentServiceClient.CreateCampaignExperimentAsync</c>.
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
        public lro::OperationsSettings CreateCampaignExperimentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.MutateCampaignExperiments</c> and
        /// <c>CampaignExperimentServiceClient.MutateCampaignExperimentsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCampaignExperimentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.GraduateCampaignExperiment</c> and
        /// <c>CampaignExperimentServiceClient.GraduateCampaignExperimentAsync</c>.
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
        public gaxgrpc::CallSettings GraduateCampaignExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.PromoteCampaignExperiment</c> and
        /// <c>CampaignExperimentServiceClient.PromoteCampaignExperimentAsync</c>.
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
        public gaxgrpc::CallSettings PromoteCampaignExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CampaignExperimentServiceClient.PromoteCampaignExperiment</c>
        ///  and <c>CampaignExperimentServiceClient.PromoteCampaignExperimentAsync</c>.
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
        public lro::OperationsSettings PromoteCampaignExperimentOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.EndCampaignExperiment</c> and
        /// <c>CampaignExperimentServiceClient.EndCampaignExperimentAsync</c>.
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
        public gaxgrpc::CallSettings EndCampaignExperimentSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignExperimentServiceClient.ListCampaignExperimentAsyncErrors</c> and
        /// <c>CampaignExperimentServiceClient.ListCampaignExperimentAsyncErrorsAsync</c>.
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
        public gaxgrpc::CallSettings ListCampaignExperimentAsyncErrorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignExperimentServiceSettings"/> object.</returns>
        public CampaignExperimentServiceSettings Clone() => new CampaignExperimentServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignExperimentServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CampaignExperimentServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignExperimentServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignExperimentServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignExperimentServiceClientBuilder()
        {
            UseJwtAccessWithScopes = CampaignExperimentServiceClient.UseJwtAccessWithScopes;
        }

        partial void InterceptBuild(ref CampaignExperimentServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignExperimentServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignExperimentServiceClient Build()
        {
            CampaignExperimentServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignExperimentServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignExperimentServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignExperimentServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignExperimentServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<CampaignExperimentServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignExperimentServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => CampaignExperimentServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => CampaignExperimentServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignExperimentServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>CampaignExperimentService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// CampaignExperimentService manages the life cycle of campaign experiments.
    /// It is used to create new experiments from drafts, modify experiment
    /// properties, promote changes in an experiment back to its base campaign,
    /// graduate experiments into new stand-alone campaigns, and to remove an
    /// experiment.
    /// 
    /// An experiment consists of two variants or arms - the base campaign and the
    /// experiment campaign, directing a fixed share of traffic to each arm.
    /// A campaign experiment is created from a draft of changes to the base campaign
    /// and will be a snapshot of changes in the draft at the time of creation.
    /// </remarks>
    public abstract partial class CampaignExperimentServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignExperimentService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignExperimentService scopes.</summary>
        /// <remarks>
        /// The default CampaignExperimentService scopes are:
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
        /// Asynchronously creates a <see cref="CampaignExperimentServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignExperimentServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignExperimentServiceClient"/>.</returns>
        public static stt::Task<CampaignExperimentServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignExperimentServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignExperimentServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignExperimentServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignExperimentServiceClient"/>.</returns>
        public static CampaignExperimentServiceClient Create() => new CampaignExperimentServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignExperimentServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignExperimentServiceSettings"/>.</param>
        /// <returns>The created <see cref="CampaignExperimentServiceClient"/>.</returns>
        internal static CampaignExperimentServiceClient Create(grpccore::CallInvoker callInvoker, CampaignExperimentServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignExperimentService.CampaignExperimentServiceClient grpcClient = new CampaignExperimentService.CampaignExperimentServiceClient(callInvoker);
            return new CampaignExperimentServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC CampaignExperimentService client</summary>
        public virtual CampaignExperimentService.CampaignExperimentServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignExperiment GetCampaignExperiment(GetCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(GetCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(GetCampaignExperimentRequest request, st::CancellationToken cancellationToken) =>
            GetCampaignExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// Required. The resource name of the campaign experiment to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignExperiment GetCampaignExperiment(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignExperiment(new GetCampaignExperimentRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// Required. The resource name of the campaign experiment to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignExperimentAsync(new GetCampaignExperimentRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// Required. The resource name of the campaign experiment to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignExperimentAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// Required. The resource name of the campaign experiment to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::CampaignExperiment GetCampaignExperiment(gagvr::CampaignExperimentName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignExperiment(new GetCampaignExperimentRequest
            {
                ResourceNameAsCampaignExperimentName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// Required. The resource name of the campaign experiment to fetch.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(gagvr::CampaignExperimentName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetCampaignExperimentAsync(new GetCampaignExperimentRequest
            {
                ResourceNameAsCampaignExperimentName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// Required. The resource name of the campaign experiment to fetch.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(gagvr::CampaignExperimentName resourceName, st::CancellationToken cancellationToken) =>
            GetCampaignExperimentAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        /// 
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
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
        public virtual lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata> CreateCampaignExperiment(CreateCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        /// 
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
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
        public virtual stt::Task<lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(CreateCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        /// 
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
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
        public virtual stt::Task<lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(CreateCampaignExperimentRequest request, st::CancellationToken cancellationToken) =>
            CreateCampaignExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>CreateCampaignExperiment</c>.</summary>
        public virtual lro::OperationsClient CreateCampaignExperimentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCampaignExperiment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata> PollOnceCreateCampaignExperiment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCampaignExperimentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>CreateCampaignExperiment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata>> PollOnceCreateCampaignExperimentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), CreateCampaignExperimentOperationsClient, callSettings);

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        /// 
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
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
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign experiment is being created.
        /// </param>
        /// <param name="campaignExperiment">
        /// Required. The campaign experiment to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata> CreateCampaignExperiment(string customerId, gagvr::CampaignExperiment campaignExperiment, gaxgrpc::CallSettings callSettings = null) =>
            CreateCampaignExperiment(new CreateCampaignExperimentRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                CampaignExperiment = gax::GaxPreconditions.CheckNotNull(campaignExperiment, nameof(campaignExperiment)),
            }, callSettings);

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        /// 
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
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
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign experiment is being created.
        /// </param>
        /// <param name="campaignExperiment">
        /// Required. The campaign experiment to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(string customerId, gagvr::CampaignExperiment campaignExperiment, gaxgrpc::CallSettings callSettings = null) =>
            CreateCampaignExperimentAsync(new CreateCampaignExperimentRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                CampaignExperiment = gax::GaxPreconditions.CheckNotNull(campaignExperiment, nameof(campaignExperiment)),
            }, callSettings);

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        /// 
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
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
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign experiment is being created.
        /// </param>
        /// <param name="campaignExperiment">
        /// Required. The campaign experiment to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(string customerId, gagvr::CampaignExperiment campaignExperiment, st::CancellationToken cancellationToken) =>
            CreateCampaignExperimentAsync(customerId, campaignExperiment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignExperimentsResponse MutateCampaignExperiments(MutateCampaignExperimentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(MutateCampaignExperimentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(MutateCampaignExperimentsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignExperimentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign experiments.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignExperimentsResponse MutateCampaignExperiments(string customerId, scg::IEnumerable<CampaignExperimentOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignExperiments(new MutateCampaignExperimentsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign experiments.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(string customerId, scg::IEnumerable<CampaignExperimentOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignExperimentsAsync(new MutateCampaignExperimentsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign experiments are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign experiments.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(string customerId, scg::IEnumerable<CampaignExperimentOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignExperimentsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GraduateCampaignExperimentResponse GraduateCampaignExperiment(GraduateCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GraduateCampaignExperimentResponse> GraduateCampaignExperimentAsync(GraduateCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GraduateCampaignExperimentResponse> GraduateCampaignExperimentAsync(GraduateCampaignExperimentRequest request, st::CancellationToken cancellationToken) =>
            GraduateCampaignExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignExperiment">
        /// Required. The resource name of the campaign experiment to graduate.
        /// </param>
        /// <param name="campaignBudget">
        /// Required. Resource name of the budget to attach to the campaign graduated from the
        /// experiment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual GraduateCampaignExperimentResponse GraduateCampaignExperiment(string campaignExperiment, string campaignBudget, gaxgrpc::CallSettings callSettings = null) =>
            GraduateCampaignExperiment(new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
                CampaignBudget = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignBudget, nameof(campaignBudget)),
            }, callSettings);

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignExperiment">
        /// Required. The resource name of the campaign experiment to graduate.
        /// </param>
        /// <param name="campaignBudget">
        /// Required. Resource name of the budget to attach to the campaign graduated from the
        /// experiment.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GraduateCampaignExperimentResponse> GraduateCampaignExperimentAsync(string campaignExperiment, string campaignBudget, gaxgrpc::CallSettings callSettings = null) =>
            GraduateCampaignExperimentAsync(new GraduateCampaignExperimentRequest
            {
                CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
                CampaignBudget = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignBudget, nameof(campaignBudget)),
            }, callSettings);

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignExperiment">
        /// Required. The resource name of the campaign experiment to graduate.
        /// </param>
        /// <param name="campaignBudget">
        /// Required. Resource name of the budget to attach to the campaign graduated from the
        /// experiment.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<GraduateCampaignExperimentResponse> GraduateCampaignExperimentAsync(string campaignExperiment, string campaignBudget, st::CancellationToken cancellationToken) =>
            GraduateCampaignExperimentAsync(campaignExperiment, campaignBudget, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        /// 
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
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
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> PromoteCampaignExperiment(PromoteCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        /// 
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
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
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignExperimentAsync(PromoteCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        /// 
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
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
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignExperimentAsync(PromoteCampaignExperimentRequest request, st::CancellationToken cancellationToken) =>
            PromoteCampaignExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PromoteCampaignExperiment</c>.</summary>
        public virtual lro::OperationsClient PromoteCampaignExperimentOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PromoteCampaignExperiment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> PollOncePromoteCampaignExperiment(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Empty>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteCampaignExperimentOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PromoteCampaignExperiment</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PollOncePromoteCampaignExperimentAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Empty>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteCampaignExperimentOperationsClient, callSettings);

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        /// 
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignExperiment">
        /// Required. The resource name of the campaign experiment to promote.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> PromoteCampaignExperiment(string campaignExperiment, gaxgrpc::CallSettings callSettings = null) =>
            PromoteCampaignExperiment(new PromoteCampaignExperimentRequest
            {
                CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
            }, callSettings);

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        /// 
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignExperiment">
        /// Required. The resource name of the campaign experiment to promote.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignExperimentAsync(string campaignExperiment, gaxgrpc::CallSettings callSettings = null) =>
            PromoteCampaignExperimentAsync(new PromoteCampaignExperimentRequest
            {
                CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
            }, callSettings);

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        /// 
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignExperiment">
        /// Required. The resource name of the campaign experiment to promote.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignExperimentAsync(string campaignExperiment, st::CancellationToken cancellationToken) =>
            PromoteCampaignExperimentAsync(campaignExperiment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EndCampaignExperiment(EndCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndCampaignExperimentAsync(EndCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndCampaignExperimentAsync(EndCampaignExperimentRequest request, st::CancellationToken cancellationToken) =>
            EndCampaignExperimentAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignExperiment">
        /// Required. The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual void EndCampaignExperiment(string campaignExperiment, gaxgrpc::CallSettings callSettings = null) =>
            EndCampaignExperiment(new EndCampaignExperimentRequest
            {
                CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
            }, callSettings);

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignExperiment">
        /// Required. The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndCampaignExperimentAsync(string campaignExperiment, gaxgrpc::CallSettings callSettings = null) =>
            EndCampaignExperimentAsync(new EndCampaignExperimentRequest
            {
                CampaignExperiment = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignExperiment, nameof(campaignExperiment)),
            }, callSettings);

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignExperiment">
        /// Required. The resource name of the campaign experiment to end.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task EndCampaignExperimentAsync(string campaignExperiment, st::CancellationToken cancellationToken) =>
            EndCampaignExperimentAsync(campaignExperiment, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
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
        public virtual gax::PagedEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrors(ListCampaignExperimentAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
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
        public virtual gax::PagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrorsAsync(ListCampaignExperimentAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
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
        /// Required. The name of the campaign experiment from which to retrieve the async
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
        public virtual gax::PagedEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrors(string resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCampaignExperimentAsyncErrors(new ListCampaignExperimentAsyncErrorsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
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
        /// Required. The name of the campaign experiment from which to retrieve the async
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
        public virtual gax::PagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrorsAsync(string resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCampaignExperimentAsyncErrorsAsync(new ListCampaignExperimentAsyncErrorsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
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
        /// Required. The name of the campaign experiment from which to retrieve the async
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
        public virtual gax::PagedEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrors(gagvr::CampaignExperimentName resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCampaignExperimentAsyncErrors(new ListCampaignExperimentAsyncErrorsRequest
            {
                ResourceNameAsCampaignExperimentName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
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
        /// Required. The name of the campaign experiment from which to retrieve the async
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
        public virtual gax::PagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrorsAsync(gagvr::CampaignExperimentName resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListCampaignExperimentAsyncErrorsAsync(new ListCampaignExperimentAsyncErrorsRequest
            {
                ResourceNameAsCampaignExperimentName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);
    }

    /// <summary>CampaignExperimentService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// CampaignExperimentService manages the life cycle of campaign experiments.
    /// It is used to create new experiments from drafts, modify experiment
    /// properties, promote changes in an experiment back to its base campaign,
    /// graduate experiments into new stand-alone campaigns, and to remove an
    /// experiment.
    /// 
    /// An experiment consists of two variants or arms - the base campaign and the
    /// experiment campaign, directing a fixed share of traffic to each arm.
    /// A campaign experiment is created from a draft of changes to the base campaign
    /// and will be a snapshot of changes in the draft at the time of creation.
    /// </remarks>
    public sealed partial class CampaignExperimentServiceClientImpl : CampaignExperimentServiceClient
    {
        private readonly gaxgrpc::ApiCall<GetCampaignExperimentRequest, gagvr::CampaignExperiment> _callGetCampaignExperiment;

        private readonly gaxgrpc::ApiCall<CreateCampaignExperimentRequest, lro::Operation> _callCreateCampaignExperiment;

        private readonly gaxgrpc::ApiCall<MutateCampaignExperimentsRequest, MutateCampaignExperimentsResponse> _callMutateCampaignExperiments;

        private readonly gaxgrpc::ApiCall<GraduateCampaignExperimentRequest, GraduateCampaignExperimentResponse> _callGraduateCampaignExperiment;

        private readonly gaxgrpc::ApiCall<PromoteCampaignExperimentRequest, lro::Operation> _callPromoteCampaignExperiment;

        private readonly gaxgrpc::ApiCall<EndCampaignExperimentRequest, wkt::Empty> _callEndCampaignExperiment;

        private readonly gaxgrpc::ApiCall<ListCampaignExperimentAsyncErrorsRequest, ListCampaignExperimentAsyncErrorsResponse> _callListCampaignExperimentAsyncErrors;

        /// <summary>
        /// Constructs a client wrapper for the CampaignExperimentService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CampaignExperimentServiceSettings"/> used within this client.
        /// </param>
        public CampaignExperimentServiceClientImpl(CampaignExperimentService.CampaignExperimentServiceClient grpcClient, CampaignExperimentServiceSettings settings)
        {
            GrpcClient = grpcClient;
            CampaignExperimentServiceSettings effectiveSettings = settings ?? CampaignExperimentServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            CreateCampaignExperimentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.CreateCampaignExperimentOperationsSettings);
            PromoteCampaignExperimentOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PromoteCampaignExperimentOperationsSettings);
            _callGetCampaignExperiment = clientHelper.BuildApiCall<GetCampaignExperimentRequest, gagvr::CampaignExperiment>(grpcClient.GetCampaignExperimentAsync, grpcClient.GetCampaignExperiment, effectiveSettings.GetCampaignExperimentSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetCampaignExperiment);
            Modify_GetCampaignExperimentApiCall(ref _callGetCampaignExperiment);
            _callCreateCampaignExperiment = clientHelper.BuildApiCall<CreateCampaignExperimentRequest, lro::Operation>(grpcClient.CreateCampaignExperimentAsync, grpcClient.CreateCampaignExperiment, effectiveSettings.CreateCampaignExperimentSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callCreateCampaignExperiment);
            Modify_CreateCampaignExperimentApiCall(ref _callCreateCampaignExperiment);
            _callMutateCampaignExperiments = clientHelper.BuildApiCall<MutateCampaignExperimentsRequest, MutateCampaignExperimentsResponse>(grpcClient.MutateCampaignExperimentsAsync, grpcClient.MutateCampaignExperiments, effectiveSettings.MutateCampaignExperimentsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignExperiments);
            Modify_MutateCampaignExperimentsApiCall(ref _callMutateCampaignExperiments);
            _callGraduateCampaignExperiment = clientHelper.BuildApiCall<GraduateCampaignExperimentRequest, GraduateCampaignExperimentResponse>(grpcClient.GraduateCampaignExperimentAsync, grpcClient.GraduateCampaignExperiment, effectiveSettings.GraduateCampaignExperimentSettings).WithGoogleRequestParam("campaign_experiment", request => request.CampaignExperiment);
            Modify_ApiCall(ref _callGraduateCampaignExperiment);
            Modify_GraduateCampaignExperimentApiCall(ref _callGraduateCampaignExperiment);
            _callPromoteCampaignExperiment = clientHelper.BuildApiCall<PromoteCampaignExperimentRequest, lro::Operation>(grpcClient.PromoteCampaignExperimentAsync, grpcClient.PromoteCampaignExperiment, effectiveSettings.PromoteCampaignExperimentSettings).WithGoogleRequestParam("campaign_experiment", request => request.CampaignExperiment);
            Modify_ApiCall(ref _callPromoteCampaignExperiment);
            Modify_PromoteCampaignExperimentApiCall(ref _callPromoteCampaignExperiment);
            _callEndCampaignExperiment = clientHelper.BuildApiCall<EndCampaignExperimentRequest, wkt::Empty>(grpcClient.EndCampaignExperimentAsync, grpcClient.EndCampaignExperiment, effectiveSettings.EndCampaignExperimentSettings).WithGoogleRequestParam("campaign_experiment", request => request.CampaignExperiment);
            Modify_ApiCall(ref _callEndCampaignExperiment);
            Modify_EndCampaignExperimentApiCall(ref _callEndCampaignExperiment);
            _callListCampaignExperimentAsyncErrors = clientHelper.BuildApiCall<ListCampaignExperimentAsyncErrorsRequest, ListCampaignExperimentAsyncErrorsResponse>(grpcClient.ListCampaignExperimentAsyncErrorsAsync, grpcClient.ListCampaignExperimentAsyncErrors, effectiveSettings.ListCampaignExperimentAsyncErrorsSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callListCampaignExperimentAsyncErrors);
            Modify_ListCampaignExperimentAsyncErrorsApiCall(ref _callListCampaignExperimentAsyncErrors);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_GetCampaignExperimentApiCall(ref gaxgrpc::ApiCall<GetCampaignExperimentRequest, gagvr::CampaignExperiment> call);

        partial void Modify_CreateCampaignExperimentApiCall(ref gaxgrpc::ApiCall<CreateCampaignExperimentRequest, lro::Operation> call);

        partial void Modify_MutateCampaignExperimentsApiCall(ref gaxgrpc::ApiCall<MutateCampaignExperimentsRequest, MutateCampaignExperimentsResponse> call);

        partial void Modify_GraduateCampaignExperimentApiCall(ref gaxgrpc::ApiCall<GraduateCampaignExperimentRequest, GraduateCampaignExperimentResponse> call);

        partial void Modify_PromoteCampaignExperimentApiCall(ref gaxgrpc::ApiCall<PromoteCampaignExperimentRequest, lro::Operation> call);

        partial void Modify_EndCampaignExperimentApiCall(ref gaxgrpc::ApiCall<EndCampaignExperimentRequest, wkt::Empty> call);

        partial void Modify_ListCampaignExperimentAsyncErrorsApiCall(ref gaxgrpc::ApiCall<ListCampaignExperimentAsyncErrorsRequest, ListCampaignExperimentAsyncErrorsResponse> call);

        partial void OnConstruction(CampaignExperimentService.CampaignExperimentServiceClient grpcClient, CampaignExperimentServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignExperimentService client</summary>
        public override CampaignExperimentService.CampaignExperimentServiceClient GrpcClient { get; }

        partial void Modify_GetCampaignExperimentRequest(ref GetCampaignExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_CreateCampaignExperimentRequest(ref CreateCampaignExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_MutateCampaignExperimentsRequest(ref MutateCampaignExperimentsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GraduateCampaignExperimentRequest(ref GraduateCampaignExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PromoteCampaignExperimentRequest(ref PromoteCampaignExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_EndCampaignExperimentRequest(ref EndCampaignExperimentRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCampaignExperimentAsyncErrorsRequest(ref ListCampaignExperimentAsyncErrorsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// <returns>The RPC response.</returns>
        public override gagvr::CampaignExperiment GetCampaignExperiment(GetCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignExperimentRequest(ref request, ref callSettings);
            return _callGetCampaignExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the requested campaign experiment in full detail.
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
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::CampaignExperiment> GetCampaignExperimentAsync(GetCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetCampaignExperimentRequest(ref request, ref callSettings);
            return _callGetCampaignExperiment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>CreateCampaignExperiment</c>.</summary>
        public override lro::OperationsClient CreateCampaignExperimentOperationsClient { get; }

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        /// 
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
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
        public override lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata> CreateCampaignExperiment(CreateCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCampaignExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata>(_callCreateCampaignExperiment.Sync(request, callSettings), CreateCampaignExperimentOperationsClient);
        }

        /// <summary>
        /// Creates a campaign experiment based on a campaign draft. The draft campaign
        /// will be forked into a real campaign (called the experiment campaign) that
        /// will begin serving ads if successfully created.
        /// 
        /// The campaign experiment is created immediately with status INITIALIZING.
        /// This method return a long running operation that tracks the forking of the
        /// draft campaign. If the forking fails, a list of errors can be retrieved
        /// using the ListCampaignExperimentAsyncErrors method. The operation's
        /// metadata will be a StringValue containing the resource name of the created
        /// campaign experiment.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
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
        public override async stt::Task<lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata>> CreateCampaignExperimentAsync(CreateCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateCampaignExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, CreateCampaignExperimentMetadata>(await _callCreateCampaignExperiment.Async(request, callSettings).ConfigureAwait(false), CreateCampaignExperimentOperationsClient);
        }

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignExperimentsResponse MutateCampaignExperiments(MutateCampaignExperimentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignExperimentsRequest(ref request, ref callSettings);
            return _callMutateCampaignExperiments.Sync(request, callSettings);
        }

        /// <summary>
        /// Updates campaign experiments. Operation statuses are returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignExperimentsResponse> MutateCampaignExperimentsAsync(MutateCampaignExperimentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignExperimentsRequest(ref request, ref callSettings);
            return _callMutateCampaignExperiments.Async(request, callSettings);
        }

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override GraduateCampaignExperimentResponse GraduateCampaignExperiment(GraduateCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GraduateCampaignExperimentRequest(ref request, ref callSettings);
            return _callGraduateCampaignExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Graduates a campaign experiment to a full campaign. The base and experiment
        /// campaigns will start running independently with their own budgets.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<GraduateCampaignExperimentResponse> GraduateCampaignExperimentAsync(GraduateCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GraduateCampaignExperimentRequest(ref request, ref callSettings);
            return _callGraduateCampaignExperiment.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>PromoteCampaignExperiment</c>.</summary>
        public override lro::OperationsClient PromoteCampaignExperimentOperationsClient { get; }

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        /// 
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
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
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Empty> PromoteCampaignExperiment(PromoteCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteCampaignExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Empty>(_callPromoteCampaignExperiment.Sync(request, callSettings), PromoteCampaignExperimentOperationsClient);
        }

        /// <summary>
        /// Promotes the changes in a experiment campaign back to the base campaign.
        /// 
        /// The campaign experiment is updated immediately with status PROMOTING.
        /// This method return a long running operation that tracks the promoting of
        /// the experiment campaign. If the promoting fails, a list of errors can be
        /// retrieved using the ListCampaignExperimentAsyncErrors method.
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
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignExperimentAsync(PromoteCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteCampaignExperimentRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Empty>(await _callPromoteCampaignExperiment.Async(request, callSettings).ConfigureAwait(false), PromoteCampaignExperimentOperationsClient);
        }

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override void EndCampaignExperiment(EndCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EndCampaignExperimentRequest(ref request, ref callSettings);
            _callEndCampaignExperiment.Sync(request, callSettings);
        }

        /// <summary>
        /// Immediately ends a campaign experiment, changing the experiment's scheduled
        /// end date and without waiting for end of day. End date is updated to be the
        /// time of the request.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignExperimentError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task EndCampaignExperimentAsync(EndCampaignExperimentRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_EndCampaignExperimentRequest(ref request, ref callSettings);
            return _callEndCampaignExperiment.Async(request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
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
        public override gax::PagedEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrors(ListCampaignExperimentAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCampaignExperimentAsyncErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListCampaignExperimentAsyncErrorsRequest, ListCampaignExperimentAsyncErrorsResponse, gr::Status>(_callListCampaignExperimentAsyncErrors, request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignExperiment create or
        /// promote (whichever occurred last).
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
        public override gax::PagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsResponse, gr::Status> ListCampaignExperimentAsyncErrorsAsync(ListCampaignExperimentAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCampaignExperimentAsyncErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListCampaignExperimentAsyncErrorsRequest, ListCampaignExperimentAsyncErrorsResponse, gr::Status>(_callListCampaignExperimentAsyncErrors, request, callSettings);
        }
    }

    public partial class ListCampaignExperimentAsyncErrorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCampaignExperimentAsyncErrorsResponse : gaxgrpc::IPageResponse<gr::Status>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<gr::Status> GetEnumerator() => Errors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CampaignExperimentService
    {
        public partial class CampaignExperimentServiceClient
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

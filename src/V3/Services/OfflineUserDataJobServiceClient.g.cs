// Copyright 2020 Google LLC
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

using gagvr = Google.Ads.GoogleAds.V3.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using gaxgrpccore = Google.Api.Gax.Grpc.GrpcCore;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using sys = System;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>Settings for <see cref="OfflineUserDataJobServiceClient"/> instances.</summary>
    public sealed partial class OfflineUserDataJobServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="OfflineUserDataJobServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="OfflineUserDataJobServiceSettings"/>.</returns>
        public static OfflineUserDataJobServiceSettings GetDefault() => new OfflineUserDataJobServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="OfflineUserDataJobServiceSettings"/> object with default settings.
        /// </summary>
        public OfflineUserDataJobServiceSettings()
        {
        }

        private OfflineUserDataJobServiceSettings(OfflineUserDataJobServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateOfflineUserDataJobSettings = existing.CreateOfflineUserDataJobSettings;
            GetOfflineUserDataJobSettings = existing.GetOfflineUserDataJobSettings;
            AddOfflineUserDataJobOperationsSettings = existing.AddOfflineUserDataJobOperationsSettings;
            RunOfflineUserDataJobSettings = existing.RunOfflineUserDataJobSettings;
            RunOfflineUserDataJobOperationsSettings = existing.RunOfflineUserDataJobOperationsSettings.Clone();
            OnCopy(existing);
        }

        partial void OnCopy(OfflineUserDataJobServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OfflineUserDataJobServiceClient.CreateOfflineUserDataJob</c> and
        /// <c>OfflineUserDataJobServiceClient.CreateOfflineUserDataJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateOfflineUserDataJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OfflineUserDataJobServiceClient.GetOfflineUserDataJob</c> and
        /// <c>OfflineUserDataJobServiceClient.GetOfflineUserDataJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetOfflineUserDataJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OfflineUserDataJobServiceClient.AddOfflineUserDataJobOperations</c> and
        /// <c>OfflineUserDataJobServiceClient.AddOfflineUserDataJobOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddOfflineUserDataJobOperationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>OfflineUserDataJobServiceClient.RunOfflineUserDataJob</c> and
        /// <c>OfflineUserDataJobServiceClient.RunOfflineUserDataJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunOfflineUserDataJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>OfflineUserDataJobServiceClient.RunOfflineUserDataJob</c>
        /// and <c>OfflineUserDataJobServiceClient.RunOfflineUserDataJobAsync</c>.
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
        public lro::OperationsSettings RunOfflineUserDataJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="OfflineUserDataJobServiceSettings"/> object.</returns>
        public OfflineUserDataJobServiceSettings Clone() => new OfflineUserDataJobServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="OfflineUserDataJobServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    public sealed partial class OfflineUserDataJobServiceClientBuilder : gaxgrpc::ClientBuilderBase<OfflineUserDataJobServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public OfflineUserDataJobServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref OfflineUserDataJobServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<OfflineUserDataJobServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override OfflineUserDataJobServiceClient Build()
        {
            OfflineUserDataJobServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<OfflineUserDataJobServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<OfflineUserDataJobServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private OfflineUserDataJobServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return OfflineUserDataJobServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<OfflineUserDataJobServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return OfflineUserDataJobServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => OfflineUserDataJobServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => OfflineUserDataJobServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => OfflineUserDataJobServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>OfflineUserDataJobService client wrapper, for convenient use.</summary>
    public abstract partial class OfflineUserDataJobServiceClient
    {
        /// <summary>
        /// The default endpoint for the OfflineUserDataJobService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default OfflineUserDataJobService scopes.</summary>
        /// <remarks>The default OfflineUserDataJobService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="OfflineUserDataJobServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OfflineUserDataJobServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="OfflineUserDataJobServiceClient"/>.</returns>
        public static stt::Task<OfflineUserDataJobServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new OfflineUserDataJobServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="OfflineUserDataJobServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="OfflineUserDataJobServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="OfflineUserDataJobServiceClient"/>.</returns>
        public static OfflineUserDataJobServiceClient Create() => new OfflineUserDataJobServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="OfflineUserDataJobServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="OfflineUserDataJobServiceSettings"/>.</param>
        /// <returns>The created <see cref="OfflineUserDataJobServiceClient"/>.</returns>
        internal static OfflineUserDataJobServiceClient Create(grpccore::CallInvoker callInvoker, OfflineUserDataJobServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            OfflineUserDataJobService.OfflineUserDataJobServiceClient grpcClient = new OfflineUserDataJobService.OfflineUserDataJobServiceClient(callInvoker);
            return new OfflineUserDataJobServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC OfflineUserDataJobService client</summary>
        public virtual OfflineUserDataJobService.OfflineUserDataJobServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateOfflineUserDataJobResponse CreateOfflineUserDataJob(CreateOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(CreateOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(CreateOfflineUserDataJobRequest request, st::CancellationToken cancellationToken) =>
            CreateOfflineUserDataJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create an offline user data job.
        /// </param>
        /// <param name="job">
        /// Required. The offline user data job to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateOfflineUserDataJobResponse CreateOfflineUserDataJob(string customerId, gagvr::OfflineUserDataJob job, gaxgrpc::CallSettings callSettings = null) =>
            CreateOfflineUserDataJob(new CreateOfflineUserDataJobRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create an offline user data job.
        /// </param>
        /// <param name="job">
        /// Required. The offline user data job to be created.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(string customerId, gagvr::OfflineUserDataJob job, gaxgrpc::CallSettings callSettings = null) =>
            CreateOfflineUserDataJobAsync(new CreateOfflineUserDataJobRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Job = gax::GaxPreconditions.CheckNotNull(job, nameof(job)),
            }, callSettings);

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create an offline user data job.
        /// </param>
        /// <param name="job">
        /// Required. The offline user data job to be created.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(string customerId, gagvr::OfflineUserDataJob job, st::CancellationToken cancellationToken) =>
            CreateOfflineUserDataJobAsync(customerId, job, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::OfflineUserDataJob GetOfflineUserDataJob(GetOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(GetOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(GetOfflineUserDataJobRequest request, st::CancellationToken cancellationToken) =>
            GetOfflineUserDataJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::OfflineUserDataJob GetOfflineUserDataJob(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetOfflineUserDataJob(new GetOfflineUserDataJobRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetOfflineUserDataJobAsync(new GetOfflineUserDataJobRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetOfflineUserDataJobAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::OfflineUserDataJob GetOfflineUserDataJob(gagvr::OfflineUserDataJobName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetOfflineUserDataJob(new GetOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(gagvr::OfflineUserDataJobName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetOfflineUserDataJobAsync(new GetOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(gagvr::OfflineUserDataJobName resourceName, st::CancellationToken cancellationToken) =>
            GetOfflineUserDataJobAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddOfflineUserDataJobOperationsResponse AddOfflineUserDataJobOperations(AddOfflineUserDataJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(AddOfflineUserDataJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(AddOfflineUserDataJobOperationsRequest request, st::CancellationToken cancellationToken) =>
            AddOfflineUserDataJobOperationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to be done.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddOfflineUserDataJobOperationsResponse AddOfflineUserDataJobOperations(string resourceName, scg::IEnumerable<OfflineUserDataJobOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            AddOfflineUserDataJobOperations(new AddOfflineUserDataJobOperationsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to be done.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(string resourceName, scg::IEnumerable<OfflineUserDataJobOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            AddOfflineUserDataJobOperationsAsync(new AddOfflineUserDataJobOperationsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to be done.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(string resourceName, scg::IEnumerable<OfflineUserDataJobOperation> operations, st::CancellationToken cancellationToken) =>
            AddOfflineUserDataJobOperationsAsync(resourceName, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to be done.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddOfflineUserDataJobOperationsResponse AddOfflineUserDataJobOperations(gagvr::OfflineUserDataJobName resourceName, scg::IEnumerable<OfflineUserDataJobOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            AddOfflineUserDataJobOperations(new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to be done.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(gagvr::OfflineUserDataJobName resourceName, scg::IEnumerable<OfflineUserDataJobOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            AddOfflineUserDataJobOperationsAsync(new AddOfflineUserDataJobOperationsRequest
            {
                ResourceNameAsOfflineUserDataJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to be done.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(gagvr::OfflineUserDataJobName resourceName, scg::IEnumerable<OfflineUserDataJobOperation> operations, st::CancellationToken cancellationToken) =>
            AddOfflineUserDataJobOperationsAsync(resourceName, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> RunOfflineUserDataJob(RunOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> RunOfflineUserDataJobAsync(RunOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> RunOfflineUserDataJobAsync(RunOfflineUserDataJobRequest request, st::CancellationToken cancellationToken) =>
            RunOfflineUserDataJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunOfflineUserDataJob</c>.</summary>
        public virtual lro::OperationsClient RunOfflineUserDataJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunOfflineUserDataJob</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> PollOnceRunOfflineUserDataJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Empty>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunOfflineUserDataJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunOfflineUserDataJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PollOnceRunOfflineUserDataJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Empty>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunOfflineUserDataJobOperationsClient, callSettings);

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> RunOfflineUserDataJob(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunOfflineUserDataJob(new RunOfflineUserDataJobRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> RunOfflineUserDataJobAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunOfflineUserDataJobAsync(new RunOfflineUserDataJobRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to run.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> RunOfflineUserDataJobAsync(string resourceName, st::CancellationToken cancellationToken) =>
            RunOfflineUserDataJobAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> RunOfflineUserDataJob(gagvr::OfflineUserDataJobName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunOfflineUserDataJob(new RunOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> RunOfflineUserDataJobAsync(gagvr::OfflineUserDataJobName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunOfflineUserDataJobAsync(new RunOfflineUserDataJobRequest
            {
                ResourceNameAsOfflineUserDataJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the OfflineUserDataJob to run.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> RunOfflineUserDataJobAsync(gagvr::OfflineUserDataJobName resourceName, st::CancellationToken cancellationToken) =>
            RunOfflineUserDataJobAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>OfflineUserDataJobService client wrapper implementation, for convenient use.</summary>
    public sealed partial class OfflineUserDataJobServiceClientImpl : OfflineUserDataJobServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateOfflineUserDataJobRequest, CreateOfflineUserDataJobResponse> _callCreateOfflineUserDataJob;

        private readonly gaxgrpc::ApiCall<GetOfflineUserDataJobRequest, gagvr::OfflineUserDataJob> _callGetOfflineUserDataJob;

        private readonly gaxgrpc::ApiCall<AddOfflineUserDataJobOperationsRequest, AddOfflineUserDataJobOperationsResponse> _callAddOfflineUserDataJobOperations;

        private readonly gaxgrpc::ApiCall<RunOfflineUserDataJobRequest, lro::Operation> _callRunOfflineUserDataJob;

        /// <summary>
        /// Constructs a client wrapper for the OfflineUserDataJobService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="OfflineUserDataJobServiceSettings"/> used within this client.
        /// </param>
        public OfflineUserDataJobServiceClientImpl(OfflineUserDataJobService.OfflineUserDataJobServiceClient grpcClient, OfflineUserDataJobServiceSettings settings)
        {
            GrpcClient = grpcClient;
            OfflineUserDataJobServiceSettings effectiveSettings = settings ?? OfflineUserDataJobServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            RunOfflineUserDataJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunOfflineUserDataJobOperationsSettings);
            _callCreateOfflineUserDataJob = clientHelper.BuildApiCall<CreateOfflineUserDataJobRequest, CreateOfflineUserDataJobResponse>(grpcClient.CreateOfflineUserDataJobAsync, grpcClient.CreateOfflineUserDataJob, effectiveSettings.CreateOfflineUserDataJobSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callCreateOfflineUserDataJob);
            Modify_CreateOfflineUserDataJobApiCall(ref _callCreateOfflineUserDataJob);
            _callGetOfflineUserDataJob = clientHelper.BuildApiCall<GetOfflineUserDataJobRequest, gagvr::OfflineUserDataJob>(grpcClient.GetOfflineUserDataJobAsync, grpcClient.GetOfflineUserDataJob, effectiveSettings.GetOfflineUserDataJobSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetOfflineUserDataJob);
            Modify_GetOfflineUserDataJobApiCall(ref _callGetOfflineUserDataJob);
            _callAddOfflineUserDataJobOperations = clientHelper.BuildApiCall<AddOfflineUserDataJobOperationsRequest, AddOfflineUserDataJobOperationsResponse>(grpcClient.AddOfflineUserDataJobOperationsAsync, grpcClient.AddOfflineUserDataJobOperations, effectiveSettings.AddOfflineUserDataJobOperationsSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callAddOfflineUserDataJobOperations);
            Modify_AddOfflineUserDataJobOperationsApiCall(ref _callAddOfflineUserDataJobOperations);
            _callRunOfflineUserDataJob = clientHelper.BuildApiCall<RunOfflineUserDataJobRequest, lro::Operation>(grpcClient.RunOfflineUserDataJobAsync, grpcClient.RunOfflineUserDataJob, effectiveSettings.RunOfflineUserDataJobSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callRunOfflineUserDataJob);
            Modify_RunOfflineUserDataJobApiCall(ref _callRunOfflineUserDataJob);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateOfflineUserDataJobApiCall(ref gaxgrpc::ApiCall<CreateOfflineUserDataJobRequest, CreateOfflineUserDataJobResponse> call);

        partial void Modify_GetOfflineUserDataJobApiCall(ref gaxgrpc::ApiCall<GetOfflineUserDataJobRequest, gagvr::OfflineUserDataJob> call);

        partial void Modify_AddOfflineUserDataJobOperationsApiCall(ref gaxgrpc::ApiCall<AddOfflineUserDataJobOperationsRequest, AddOfflineUserDataJobOperationsResponse> call);

        partial void Modify_RunOfflineUserDataJobApiCall(ref gaxgrpc::ApiCall<RunOfflineUserDataJobRequest, lro::Operation> call);

        partial void OnConstruction(OfflineUserDataJobService.OfflineUserDataJobServiceClient grpcClient, OfflineUserDataJobServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC OfflineUserDataJobService client</summary>
        public override OfflineUserDataJobService.OfflineUserDataJobServiceClient GrpcClient { get; }

        partial void Modify_CreateOfflineUserDataJobRequest(ref CreateOfflineUserDataJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetOfflineUserDataJobRequest(ref GetOfflineUserDataJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddOfflineUserDataJobOperationsRequest(ref AddOfflineUserDataJobOperationsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunOfflineUserDataJobRequest(ref RunOfflineUserDataJobRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreateOfflineUserDataJobResponse CreateOfflineUserDataJob(CreateOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOfflineUserDataJobRequest(ref request, ref callSettings);
            return _callCreateOfflineUserDataJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates an offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreateOfflineUserDataJobResponse> CreateOfflineUserDataJobAsync(CreateOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateOfflineUserDataJobRequest(ref request, ref callSettings);
            return _callCreateOfflineUserDataJob.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::OfflineUserDataJob GetOfflineUserDataJob(GetOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOfflineUserDataJobRequest(ref request, ref callSettings);
            return _callGetOfflineUserDataJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::OfflineUserDataJob> GetOfflineUserDataJobAsync(GetOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetOfflineUserDataJobRequest(ref request, ref callSettings);
            return _callGetOfflineUserDataJob.Async(request, callSettings);
        }

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AddOfflineUserDataJobOperationsResponse AddOfflineUserDataJobOperations(AddOfflineUserDataJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddOfflineUserDataJobOperationsRequest(ref request, ref callSettings);
            return _callAddOfflineUserDataJobOperations.Sync(request, callSettings);
        }

        /// <summary>
        /// Adds operations to the offline user data job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AddOfflineUserDataJobOperationsResponse> AddOfflineUserDataJobOperationsAsync(AddOfflineUserDataJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddOfflineUserDataJobOperationsRequest(ref request, ref callSettings);
            return _callAddOfflineUserDataJobOperations.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RunOfflineUserDataJob</c>.</summary>
        public override lro::OperationsClient RunOfflineUserDataJobOperationsClient { get; }

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Empty> RunOfflineUserDataJob(RunOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunOfflineUserDataJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Empty>(_callRunOfflineUserDataJob.Sync(request, callSettings), RunOfflineUserDataJobOperationsClient);
        }

        /// <summary>
        /// Runs the offline user data job.
        /// 
        /// When finished, the long running operation will contain the processing
        /// result or failure information, if any.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> RunOfflineUserDataJobAsync(RunOfflineUserDataJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunOfflineUserDataJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Empty>(await _callRunOfflineUserDataJob.Async(request, callSettings).ConfigureAwait(false), RunOfflineUserDataJobOperationsClient);
        }
    }

    public static partial class OfflineUserDataJobService
    {
        public partial class OfflineUserDataJobServiceClient
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

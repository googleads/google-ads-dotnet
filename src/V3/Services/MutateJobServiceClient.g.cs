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
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V3.Services
{
    /// <summary>Settings for <see cref="MutateJobServiceClient"/> instances.</summary>
    public sealed partial class MutateJobServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="MutateJobServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="MutateJobServiceSettings"/>.</returns>
        public static MutateJobServiceSettings GetDefault() => new MutateJobServiceSettings();

        /// <summary>Constructs a new <see cref="MutateJobServiceSettings"/> object with default settings.</summary>
        public MutateJobServiceSettings()
        {
        }

        private MutateJobServiceSettings(MutateJobServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            CreateMutateJobSettings = existing.CreateMutateJobSettings;
            GetMutateJobSettings = existing.GetMutateJobSettings;
            ListMutateJobResultsSettings = existing.ListMutateJobResultsSettings;
            RunMutateJobSettings = existing.RunMutateJobSettings;
            RunMutateJobOperationsSettings = existing.RunMutateJobOperationsSettings.Clone();
            AddMutateJobOperationsSettings = existing.AddMutateJobOperationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(MutateJobServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MutateJobServiceClient.CreateMutateJob</c> and <c>MutateJobServiceClient.CreateMutateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings CreateMutateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MutateJobServiceClient.GetMutateJob</c> and <c>MutateJobServiceClient.GetMutateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings GetMutateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MutateJobServiceClient.ListMutateJobResults</c> and <c>MutateJobServiceClient.ListMutateJobResultsAsync</c>
        /// .
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings ListMutateJobResultsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MutateJobServiceClient.RunMutateJob</c> and <c>MutateJobServiceClient.RunMutateJobAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings RunMutateJobSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>
        /// Long Running Operation settings for calls to <c>MutateJobServiceClient.RunMutateJob</c> and
        /// <c>MutateJobServiceClient.RunMutateJobAsync</c>.
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
        public lro::OperationsSettings RunMutateJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>MutateJobServiceClient.AddMutateJobOperations</c> and
        /// <c>MutateJobServiceClient.AddMutateJobOperationsAsync</c>.
        /// </summary>
        /// <remarks>
        /// <list type="bullet">
        /// <item><description>This call will not be retried.</description></item>
        /// <item><description>No timeout is applied.</description></item>
        /// </list>
        /// </remarks>
        public gaxgrpc::CallSettings AddMutateJobOperationsSettings { get; set; } = gaxgrpc::CallSettings.FromExpiration(gax::Expiration.None);

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="MutateJobServiceSettings"/> object.</returns>
        public MutateJobServiceSettings Clone() => new MutateJobServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="MutateJobServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    public sealed partial class MutateJobServiceClientBuilder : gaxgrpc::ClientBuilderBase<MutateJobServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public MutateJobServiceSettings Settings { get; set; }

        partial void InterceptBuild(ref MutateJobServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<MutateJobServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override MutateJobServiceClient Build()
        {
            MutateJobServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<MutateJobServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<MutateJobServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private MutateJobServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return MutateJobServiceClient.Create(callInvoker, Settings);
        }

        private async stt::Task<MutateJobServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return MutateJobServiceClient.Create(callInvoker, Settings);
        }

        /// <summary>Returns the endpoint for this builder type, used if no endpoint is otherwise specified.</summary>
        protected override string GetDefaultEndpoint() => MutateJobServiceClient.DefaultEndpoint;

        /// <summary>
        /// Returns the default scopes for this builder type, used if no scopes are otherwise specified.
        /// </summary>
        protected override scg::IReadOnlyList<string> GetDefaultScopes() => MutateJobServiceClient.DefaultScopes;

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => MutateJobServiceClient.ChannelPool;

        /// <summary>Returns the default <see cref="gaxgrpc::GrpcAdapter"/>to use if not otherwise specified.</summary>
        protected override gaxgrpc::GrpcAdapter DefaultGrpcAdapter => gaxgrpccore::GrpcCoreAdapter.Instance;
    }

    /// <summary>MutateJobService client wrapper, for convenient use.</summary>
    public abstract partial class MutateJobServiceClient
    {
        /// <summary>
        /// The default endpoint for the MutateJobService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default MutateJobService scopes.</summary>
        /// <remarks>The default MutateJobService scopes are:<list type="bullet"></list></remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[] { });

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(DefaultScopes);

        /// <summary>
        /// Asynchronously creates a <see cref="MutateJobServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MutateJobServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="MutateJobServiceClient"/>.</returns>
        public static stt::Task<MutateJobServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new MutateJobServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="MutateJobServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="MutateJobServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="MutateJobServiceClient"/>.</returns>
        public static MutateJobServiceClient Create() => new MutateJobServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="MutateJobServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="MutateJobServiceSettings"/>.</param>
        /// <returns>The created <see cref="MutateJobServiceClient"/>.</returns>
        internal static MutateJobServiceClient Create(grpccore::CallInvoker callInvoker, MutateJobServiceSettings settings = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            MutateJobService.MutateJobServiceClient grpcClient = new MutateJobService.MutateJobServiceClient(callInvoker);
            return new MutateJobServiceClientImpl(grpcClient, settings);
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

        /// <summary>The underlying gRPC MutateJobService client</summary>
        public virtual MutateJobService.MutateJobServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateMutateJobResponse CreateMutateJob(CreateMutateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateMutateJobResponse> CreateMutateJobAsync(CreateMutateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateMutateJobResponse> CreateMutateJobAsync(CreateMutateJobRequest request, st::CancellationToken cancellationToken) =>
            CreateMutateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create a mutate job.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual CreateMutateJobResponse CreateMutateJob(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMutateJob(new CreateMutateJobRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create a mutate job.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateMutateJobResponse> CreateMutateJobAsync(string customerId, gaxgrpc::CallSettings callSettings = null) =>
            CreateMutateJobAsync(new CreateMutateJobRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
            }, callSettings);

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create a mutate job.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<CreateMutateJobResponse> CreateMutateJobAsync(string customerId, st::CancellationToken cancellationToken) =>
            CreateMutateJobAsync(customerId, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MutateJob GetMutateJob(GetMutateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MutateJob> GetMutateJobAsync(GetMutateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MutateJob> GetMutateJobAsync(GetMutateJobRequest request, st::CancellationToken cancellationToken) =>
            GetMutateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MutateJob GetMutateJob(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMutateJob(new GetMutateJobRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MutateJob> GetMutateJobAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMutateJobAsync(new GetMutateJobRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MutateJob> GetMutateJobAsync(string resourceName, st::CancellationToken cancellationToken) =>
            GetMutateJobAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual gagvr::MutateJob GetMutateJob(gagvr::MutateJobName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMutateJob(new GetMutateJobRequest
            {
                ResourceNameAsMutateJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to get.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MutateJob> GetMutateJobAsync(gagvr::MutateJobName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            GetMutateJobAsync(new GetMutateJobRequest
            {
                ResourceNameAsMutateJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to get.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<gagvr::MutateJob> GetMutateJobAsync(gagvr::MutateJobName resourceName, st::CancellationToken cancellationToken) =>
            GetMutateJobAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MutateJobResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResults(ListMutateJobResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MutateJobResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResultsAsync(ListMutateJobResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob whose results are being listed.
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
        /// <returns>A pageable sequence of <see cref="MutateJobResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResults(string resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMutateJobResults(new ListMutateJobResultsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob whose results are being listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MutateJobResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResultsAsync(string resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMutateJobResultsAsync(new ListMutateJobResultsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob whose results are being listed.
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
        /// <returns>A pageable sequence of <see cref="MutateJobResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResults(gagvr::MutateJobName resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMutateJobResults(new ListMutateJobResultsRequest
            {
                ResourceNameAsMutateJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob whose results are being listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="MutateJobResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResultsAsync(gagvr::MutateJobName resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListMutateJobResultsAsync(new ListMutateJobResultsRequest
            {
                ResourceNameAsMutateJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata> RunMutateJob(RunMutateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(RunMutateJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(RunMutateJobRequest request, st::CancellationToken cancellationToken) =>
            RunMutateJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunMutateJob</c>.</summary>
        public virtual lro::OperationsClient RunMutateJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunMutateJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata> PollOnceRunMutateJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunMutateJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunMutateJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> PollOnceRunMutateJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunMutateJobOperationsClient, callSettings);

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata> RunMutateJob(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunMutateJob(new RunMutateJobRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunMutateJobAsync(new RunMutateJobRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to run.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(string resourceName, st::CancellationToken cancellationToken) =>
            RunMutateJobAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata> RunMutateJob(gagvr::MutateJobName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunMutateJob(new RunMutateJobRequest
            {
                ResourceNameAsMutateJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(gagvr::MutateJobName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunMutateJobAsync(new RunMutateJobRequest
            {
                ResourceNameAsMutateJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob to run.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(gagvr::MutateJobName resourceName, st::CancellationToken cancellationToken) =>
            RunMutateJobAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddMutateJobOperationsResponse AddMutateJobOperations(AddMutateJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(AddMutateJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(AddMutateJobOperationsRequest request, st::CancellationToken cancellationToken) =>
            AddMutateJobOperationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddMutateJobOperations request for a MutateJob should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddMutateJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddMutateJobOperationsResponse AddMutateJobOperations(string resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddMutateJobOperations(new AddMutateJobOperationsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                SequenceToken = sequenceToken ?? "",
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddMutateJobOperations request for a MutateJob should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddMutateJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(string resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddMutateJobOperationsAsync(new AddMutateJobOperationsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                SequenceToken = sequenceToken ?? "",
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddMutateJobOperations request for a MutateJob should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddMutateJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(string resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, st::CancellationToken cancellationToken) =>
            AddMutateJobOperationsAsync(resourceName, sequenceToken, mutateOperations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddMutateJobOperations request for a MutateJob should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddMutateJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddMutateJobOperationsResponse AddMutateJobOperations(gagvr::MutateJobName resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddMutateJobOperations(new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                SequenceToken = sequenceToken ?? "",
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddMutateJobOperations request for a MutateJob should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddMutateJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(gagvr::MutateJobName resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddMutateJobOperationsAsync(new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                SequenceToken = sequenceToken ?? "",
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddMutateJobOperations request for a MutateJob should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddMutateJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(gagvr::MutateJobName resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, st::CancellationToken cancellationToken) =>
            AddMutateJobOperationsAsync(resourceName, sequenceToken, mutateOperations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddMutateJobOperationsResponse AddMutateJobOperations(string resourceName, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddMutateJobOperations(new AddMutateJobOperationsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(string resourceName, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddMutateJobOperationsAsync(new AddMutateJobOperationsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(string resourceName, scg::IEnumerable<MutateOperation> mutateOperations, st::CancellationToken cancellationToken) =>
            AddMutateJobOperationsAsync(resourceName, mutateOperations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddMutateJobOperationsResponse AddMutateJobOperations(gagvr::MutateJobName resourceName, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddMutateJobOperations(new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(gagvr::MutateJobName resourceName, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddMutateJobOperationsAsync(new AddMutateJobOperationsRequest
            {
                ResourceNameAsMutateJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the MutateJob.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this MutateJob. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(gagvr::MutateJobName resourceName, scg::IEnumerable<MutateOperation> mutateOperations, st::CancellationToken cancellationToken) =>
            AddMutateJobOperationsAsync(resourceName, mutateOperations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>MutateJobService client wrapper implementation, for convenient use.</summary>
    public sealed partial class MutateJobServiceClientImpl : MutateJobServiceClient
    {
        private readonly gaxgrpc::ApiCall<CreateMutateJobRequest, CreateMutateJobResponse> _callCreateMutateJob;

        private readonly gaxgrpc::ApiCall<GetMutateJobRequest, gagvr::MutateJob> _callGetMutateJob;

        private readonly gaxgrpc::ApiCall<ListMutateJobResultsRequest, ListMutateJobResultsResponse> _callListMutateJobResults;

        private readonly gaxgrpc::ApiCall<RunMutateJobRequest, lro::Operation> _callRunMutateJob;

        private readonly gaxgrpc::ApiCall<AddMutateJobOperationsRequest, AddMutateJobOperationsResponse> _callAddMutateJobOperations;

        /// <summary>
        /// Constructs a client wrapper for the MutateJobService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="MutateJobServiceSettings"/> used within this client.</param>
        public MutateJobServiceClientImpl(MutateJobService.MutateJobServiceClient grpcClient, MutateJobServiceSettings settings)
        {
            GrpcClient = grpcClient;
            MutateJobServiceSettings effectiveSettings = settings ?? MutateJobServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings);
            RunMutateJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunMutateJobOperationsSettings);
            _callCreateMutateJob = clientHelper.BuildApiCall<CreateMutateJobRequest, CreateMutateJobResponse>(grpcClient.CreateMutateJobAsync, grpcClient.CreateMutateJob, effectiveSettings.CreateMutateJobSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callCreateMutateJob);
            Modify_CreateMutateJobApiCall(ref _callCreateMutateJob);
            _callGetMutateJob = clientHelper.BuildApiCall<GetMutateJobRequest, gagvr::MutateJob>(grpcClient.GetMutateJobAsync, grpcClient.GetMutateJob, effectiveSettings.GetMutateJobSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callGetMutateJob);
            Modify_GetMutateJobApiCall(ref _callGetMutateJob);
            _callListMutateJobResults = clientHelper.BuildApiCall<ListMutateJobResultsRequest, ListMutateJobResultsResponse>(grpcClient.ListMutateJobResultsAsync, grpcClient.ListMutateJobResults, effectiveSettings.ListMutateJobResultsSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callListMutateJobResults);
            Modify_ListMutateJobResultsApiCall(ref _callListMutateJobResults);
            _callRunMutateJob = clientHelper.BuildApiCall<RunMutateJobRequest, lro::Operation>(grpcClient.RunMutateJobAsync, grpcClient.RunMutateJob, effectiveSettings.RunMutateJobSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callRunMutateJob);
            Modify_RunMutateJobApiCall(ref _callRunMutateJob);
            _callAddMutateJobOperations = clientHelper.BuildApiCall<AddMutateJobOperationsRequest, AddMutateJobOperationsResponse>(grpcClient.AddMutateJobOperationsAsync, grpcClient.AddMutateJobOperations, effectiveSettings.AddMutateJobOperationsSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callAddMutateJobOperations);
            Modify_AddMutateJobOperationsApiCall(ref _callAddMutateJobOperations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_CreateMutateJobApiCall(ref gaxgrpc::ApiCall<CreateMutateJobRequest, CreateMutateJobResponse> call);

        partial void Modify_GetMutateJobApiCall(ref gaxgrpc::ApiCall<GetMutateJobRequest, gagvr::MutateJob> call);

        partial void Modify_ListMutateJobResultsApiCall(ref gaxgrpc::ApiCall<ListMutateJobResultsRequest, ListMutateJobResultsResponse> call);

        partial void Modify_RunMutateJobApiCall(ref gaxgrpc::ApiCall<RunMutateJobRequest, lro::Operation> call);

        partial void Modify_AddMutateJobOperationsApiCall(ref gaxgrpc::ApiCall<AddMutateJobOperationsRequest, AddMutateJobOperationsResponse> call);

        partial void OnConstruction(MutateJobService.MutateJobServiceClient grpcClient, MutateJobServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC MutateJobService client</summary>
        public override MutateJobService.MutateJobServiceClient GrpcClient { get; }

        partial void Modify_CreateMutateJobRequest(ref CreateMutateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_GetMutateJobRequest(ref GetMutateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListMutateJobResultsRequest(ref ListMutateJobResultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunMutateJobRequest(ref RunMutateJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddMutateJobOperationsRequest(ref AddMutateJobOperationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override CreateMutateJobResponse CreateMutateJob(CreateMutateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMutateJobRequest(ref request, ref callSettings);
            return _callCreateMutateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates a mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<CreateMutateJobResponse> CreateMutateJobAsync(CreateMutateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_CreateMutateJobRequest(ref request, ref callSettings);
            return _callCreateMutateJob.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override gagvr::MutateJob GetMutateJob(GetMutateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMutateJobRequest(ref request, ref callSettings);
            return _callGetMutateJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Returns the mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<gagvr::MutateJob> GetMutateJobAsync(GetMutateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_GetMutateJobRequest(ref request, ref callSettings);
            return _callGetMutateJob.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="MutateJobResult"/> resources.</returns>
        public override gax::PagedEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResults(ListMutateJobResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMutateJobResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListMutateJobResultsRequest, ListMutateJobResultsResponse, MutateJobResult>(_callListMutateJobResults, request, callSettings);
        }

        /// <summary>
        /// Returns the results of the mutate job. The job must be done.
        /// Supports standard list paging.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="MutateJobResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListMutateJobResultsResponse, MutateJobResult> ListMutateJobResultsAsync(ListMutateJobResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListMutateJobResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListMutateJobResultsRequest, ListMutateJobResultsResponse, MutateJobResult>(_callListMutateJobResults, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RunMutateJob</c>.</summary>
        public override lro::OperationsClient RunMutateJobOperationsClient { get; }

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata> RunMutateJob(RunMutateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunMutateJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>(_callRunMutateJob.Sync(request, callSettings), RunMutateJobOperationsClient);
        }

        /// <summary>
        /// Runs the mutate job.
        /// 
        /// The Operation.metadata field type is MutateJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListMutateJobResults to get the results of the job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>> RunMutateJobAsync(RunMutateJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunMutateJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, gagvr::MutateJob.Types.MutateJobMetadata>(await _callRunMutateJob.Async(request, callSettings).ConfigureAwait(false), RunMutateJobOperationsClient);
        }

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AddMutateJobOperationsResponse AddMutateJobOperations(AddMutateJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddMutateJobOperationsRequest(ref request, ref callSettings);
            return _callAddMutateJobOperations.Sync(request, callSettings);
        }

        /// <summary>
        /// Add operations to the mutate job.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AddMutateJobOperationsResponse> AddMutateJobOperationsAsync(AddMutateJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddMutateJobOperationsRequest(ref request, ref callSettings);
            return _callAddMutateJobOperations.Async(request, callSettings);
        }
    }

    public partial class ListMutateJobResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListMutateJobResultsResponse : gaxgrpc::IPageResponse<MutateJobResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<MutateJobResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class MutateJobService
    {
        public partial class MutateJobServiceClient
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

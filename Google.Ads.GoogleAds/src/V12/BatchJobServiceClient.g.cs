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
using gagvr = Google.Ads.GoogleAds.V12.Resources;
using gax = Google.Api.Gax;
using gaxgrpc = Google.Api.Gax.Grpc;
using lro = Google.LongRunning;
using proto = Google.Protobuf;
using wkt = Google.Protobuf.WellKnownTypes;
using grpccore = Grpc.Core;
using grpcinter = Grpc.Core.Interceptors;
using mel = Microsoft.Extensions.Logging;
using sys = System;
using sc = System.Collections;
using scg = System.Collections.Generic;
using sco = System.Collections.ObjectModel;
using st = System.Threading;
using stt = System.Threading.Tasks;

namespace Google.Ads.GoogleAds.V12.Services
{
    /// <summary>Settings for <see cref="BatchJobServiceClient"/> instances.</summary>
    public sealed partial class BatchJobServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="BatchJobServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="BatchJobServiceSettings"/>.</returns>
        public static BatchJobServiceSettings GetDefault() => new BatchJobServiceSettings();

        /// <summary>Constructs a new <see cref="BatchJobServiceSettings"/> object with default settings.</summary>
        public BatchJobServiceSettings()
        {
        }

        private BatchJobServiceSettings(BatchJobServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateBatchJobSettings = existing.MutateBatchJobSettings;
            ListBatchJobResultsSettings = existing.ListBatchJobResultsSettings;
            RunBatchJobSettings = existing.RunBatchJobSettings;
            RunBatchJobOperationsSettings = existing.RunBatchJobOperationsSettings.Clone();
            AddBatchJobOperationsSettings = existing.AddBatchJobOperationsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(BatchJobServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchJobServiceClient.MutateBatchJob</c> and <c>BatchJobServiceClient.MutateBatchJobAsync</c>.
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
        public gaxgrpc::CallSettings MutateBatchJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchJobServiceClient.ListBatchJobResults</c> and <c>BatchJobServiceClient.ListBatchJobResultsAsync</c>.
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
        public gaxgrpc::CallSettings ListBatchJobResultsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchJobServiceClient.RunBatchJob</c> and <c>BatchJobServiceClient.RunBatchJobAsync</c>.
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
        public gaxgrpc::CallSettings RunBatchJobSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>BatchJobServiceClient.RunBatchJob</c> and
        /// <c>BatchJobServiceClient.RunBatchJobAsync</c>.
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
        public lro::OperationsSettings RunBatchJobOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>BatchJobServiceClient.AddBatchJobOperations</c> and <c>BatchJobServiceClient.AddBatchJobOperationsAsync</c>
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
        public gaxgrpc::CallSettings AddBatchJobOperationsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="BatchJobServiceSettings"/> object.</returns>
        public BatchJobServiceSettings Clone() => new BatchJobServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="BatchJobServiceClient"/> to provide simple configuration of credentials, endpoint
    /// etc.
    /// </summary>
    internal sealed partial class BatchJobServiceClientBuilder : gaxgrpc::ClientBuilderBase<BatchJobServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public BatchJobServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public BatchJobServiceClientBuilder() : base(BatchJobServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref BatchJobServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<BatchJobServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override BatchJobServiceClient Build()
        {
            BatchJobServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<BatchJobServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<BatchJobServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private BatchJobServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return BatchJobServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<BatchJobServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return BatchJobServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => BatchJobServiceClient.ChannelPool;
    }

    /// <summary>BatchJobService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage batch jobs.
    /// </remarks>
    public abstract partial class BatchJobServiceClient
    {
        /// <summary>
        /// The default endpoint for the BatchJobService service, which is a host of "googleads.googleapis.com" and a
        /// port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default BatchJobService scopes.</summary>
        /// <remarks>
        /// The default BatchJobService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(BatchJobService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="BatchJobServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BatchJobServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="BatchJobServiceClient"/>.</returns>
        public static stt::Task<BatchJobServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new BatchJobServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="BatchJobServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use <see cref="BatchJobServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="BatchJobServiceClient"/>.</returns>
        public static BatchJobServiceClient Create() => new BatchJobServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="BatchJobServiceClient"/> which uses the specified call invoker for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="BatchJobServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="BatchJobServiceClient"/>.</returns>
        internal static BatchJobServiceClient Create(grpccore::CallInvoker callInvoker, BatchJobServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            BatchJobService.BatchJobServiceClient grpcClient = new BatchJobService.BatchJobServiceClient(callInvoker);
            return new BatchJobServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC BatchJobService client</summary>
        public virtual BatchJobService.BatchJobServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBatchJobResponse MutateBatchJob(MutateBatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBatchJobResponse> MutateBatchJobAsync(MutateBatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Mutates a batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBatchJobResponse> MutateBatchJobAsync(MutateBatchJobRequest request, st::CancellationToken cancellationToken) =>
            MutateBatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Mutates a batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create a batch job.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on an individual batch job.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateBatchJobResponse MutateBatchJob(string customerId, BatchJobOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateBatchJob(new MutateBatchJobRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Mutates a batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create a batch job.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on an individual batch job.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBatchJobResponse> MutateBatchJobAsync(string customerId, BatchJobOperation operation, gaxgrpc::CallSettings callSettings = null) =>
            MutateBatchJobAsync(new MutateBatchJobRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operation = gax::GaxPreconditions.CheckNotNull(operation, nameof(operation)),
            }, callSettings);

        /// <summary>
        /// Mutates a batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer for which to create a batch job.
        /// </param>
        /// <param name="operation">
        /// Required. The operation to perform on an individual batch job.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateBatchJobResponse> MutateBatchJobAsync(string customerId, BatchJobOperation operation, st::CancellationToken cancellationToken) =>
            MutateBatchJobAsync(customerId, operation, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns the results of the batch job. The job must be done.
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BatchJobResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBatchJobResultsResponse, BatchJobResult> ListBatchJobResults(ListBatchJobResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the results of the batch job. The job must be done.
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BatchJobResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBatchJobResultsResponse, BatchJobResult> ListBatchJobResultsAsync(ListBatchJobResultsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns the results of the batch job. The job must be done.
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job whose results are being listed.
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
        /// <returns>A pageable sequence of <see cref="BatchJobResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBatchJobResultsResponse, BatchJobResult> ListBatchJobResults(string resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBatchJobResults(new ListBatchJobResultsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the results of the batch job. The job must be done.
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job whose results are being listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BatchJobResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBatchJobResultsResponse, BatchJobResult> ListBatchJobResultsAsync(string resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBatchJobResultsAsync(new ListBatchJobResultsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the results of the batch job. The job must be done.
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job whose results are being listed.
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
        /// <returns>A pageable sequence of <see cref="BatchJobResult"/> resources.</returns>
        public virtual gax::PagedEnumerable<ListBatchJobResultsResponse, BatchJobResult> ListBatchJobResults(gagvr::BatchJobName resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBatchJobResults(new ListBatchJobResultsRequest
            {
                ResourceNameAsBatchJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Returns the results of the batch job. The job must be done.
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job whose results are being listed.
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
        /// <returns>A pageable asynchronous sequence of <see cref="BatchJobResult"/> resources.</returns>
        public virtual gax::PagedAsyncEnumerable<ListBatchJobResultsResponse, BatchJobResult> ListBatchJobResultsAsync(gagvr::BatchJobName resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null) =>
            ListBatchJobResultsAsync(new ListBatchJobResultsRequest
            {
                ResourceNameAsBatchJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                PageToken = pageToken ?? "",
                PageSize = pageSize ?? 0,
            }, callSettings);

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata> RunBatchJob(RunBatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>> RunBatchJobAsync(RunBatchJobRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>> RunBatchJobAsync(RunBatchJobRequest request, st::CancellationToken cancellationToken) =>
            RunBatchJobAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>RunBatchJob</c>.</summary>
        public virtual lro::OperationsClient RunBatchJobOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>RunBatchJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata> PollOnceRunBatchJob(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunBatchJobOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>RunBatchJob</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>> PollOnceRunBatchJobAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), RunBatchJobOperationsClient, callSettings);

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the BatchJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata> RunBatchJob(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunBatchJob(new RunBatchJobRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the BatchJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>> RunBatchJobAsync(string resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunBatchJobAsync(new RunBatchJobRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the BatchJob to run.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>> RunBatchJobAsync(string resourceName, st::CancellationToken cancellationToken) =>
            RunBatchJobAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the BatchJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata> RunBatchJob(gagvr::BatchJobName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunBatchJob(new RunBatchJobRequest
            {
                ResourceNameAsBatchJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the BatchJob to run.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>> RunBatchJobAsync(gagvr::BatchJobName resourceName, gaxgrpc::CallSettings callSettings = null) =>
            RunBatchJobAsync(new RunBatchJobRequest
            {
                ResourceNameAsBatchJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            }, callSettings);

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the BatchJob to run.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>> RunBatchJobAsync(gagvr::BatchJobName resourceName, st::CancellationToken cancellationToken) =>
            RunBatchJobAsync(resourceName, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddBatchJobOperationsResponse AddBatchJobOperations(AddBatchJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(AddBatchJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(AddBatchJobOperationsRequest request, st::CancellationToken cancellationToken) =>
            AddBatchJobOperationsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddBatchJobOperations request for a batch job should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddBatchJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddBatchJobOperationsResponse AddBatchJobOperations(string resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddBatchJobOperations(new AddBatchJobOperationsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                SequenceToken = sequenceToken ?? "",
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddBatchJobOperations request for a batch job should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddBatchJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(string resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddBatchJobOperationsAsync(new AddBatchJobOperationsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                SequenceToken = sequenceToken ?? "",
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddBatchJobOperations request for a batch job should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddBatchJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(string resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, st::CancellationToken cancellationToken) =>
            AddBatchJobOperationsAsync(resourceName, sequenceToken, mutateOperations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddBatchJobOperations request for a batch job should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddBatchJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddBatchJobOperationsResponse AddBatchJobOperations(gagvr::BatchJobName resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddBatchJobOperations(new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                SequenceToken = sequenceToken ?? "",
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddBatchJobOperations request for a batch job should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddBatchJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(gagvr::BatchJobName resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddBatchJobOperationsAsync(new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                SequenceToken = sequenceToken ?? "",
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="sequenceToken">
        /// A token used to enforce sequencing.
        /// 
        /// The first AddBatchJobOperations request for a batch job should not set
        /// sequence_token. Subsequent requests must set sequence_token to the value of
        /// next_sequence_token received in the previous AddBatchJobOperations
        /// response.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(gagvr::BatchJobName resourceName, string sequenceToken, scg::IEnumerable<MutateOperation> mutateOperations, st::CancellationToken cancellationToken) =>
            AddBatchJobOperationsAsync(resourceName, sequenceToken, mutateOperations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddBatchJobOperationsResponse AddBatchJobOperations(string resourceName, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddBatchJobOperations(new AddBatchJobOperationsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(string resourceName, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddBatchJobOperationsAsync(new AddBatchJobOperationsRequest
            {
                ResourceName = gax::GaxPreconditions.CheckNotNullOrEmpty(resourceName, nameof(resourceName)),
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(string resourceName, scg::IEnumerable<MutateOperation> mutateOperations, st::CancellationToken cancellationToken) =>
            AddBatchJobOperationsAsync(resourceName, mutateOperations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual AddBatchJobOperationsResponse AddBatchJobOperations(gagvr::BatchJobName resourceName, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddBatchJobOperations(new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(gagvr::BatchJobName resourceName, scg::IEnumerable<MutateOperation> mutateOperations, gaxgrpc::CallSettings callSettings = null) =>
            AddBatchJobOperationsAsync(new AddBatchJobOperationsRequest
            {
                ResourceNameAsBatchJobName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
                MutateOperations =
                {
                    gax::GaxPreconditions.CheckNotNull(mutateOperations, nameof(mutateOperations)),
                },
            }, callSettings);

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="resourceName">
        /// Required. The resource name of the batch job.
        /// </param>
        /// <param name="mutateOperations">
        /// Required. The list of mutates being added.
        /// 
        /// Operations can use negative integers as temp ids to signify dependencies
        /// between entities created in this batch job. For example, a customer with
        /// id = 1234 can create a campaign and an ad group in that same campaign by
        /// creating a campaign in the first operation with the resource name
        /// explicitly set to "customers/1234/campaigns/-1", and creating an ad group
        /// in the second operation with the campaign field also set to
        /// "customers/1234/campaigns/-1".
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(gagvr::BatchJobName resourceName, scg::IEnumerable<MutateOperation> mutateOperations, st::CancellationToken cancellationToken) =>
            AddBatchJobOperationsAsync(resourceName, mutateOperations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>BatchJobService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage batch jobs.
    /// </remarks>
    public sealed partial class BatchJobServiceClientImpl : BatchJobServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateBatchJobRequest, MutateBatchJobResponse> _callMutateBatchJob;

        private readonly gaxgrpc::ApiCall<ListBatchJobResultsRequest, ListBatchJobResultsResponse> _callListBatchJobResults;

        private readonly gaxgrpc::ApiCall<RunBatchJobRequest, lro::Operation> _callRunBatchJob;

        private readonly gaxgrpc::ApiCall<AddBatchJobOperationsRequest, AddBatchJobOperationsResponse> _callAddBatchJobOperations;

        /// <summary>
        /// Constructs a client wrapper for the BatchJobService service, with the specified gRPC client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="BatchJobServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public BatchJobServiceClientImpl(BatchJobService.BatchJobServiceClient grpcClient, BatchJobServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            BatchJobServiceSettings effectiveSettings = settings ?? BatchJobServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            RunBatchJobOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.RunBatchJobOperationsSettings, logger);
            _callMutateBatchJob = clientHelper.BuildApiCall<MutateBatchJobRequest, MutateBatchJobResponse>("MutateBatchJob", grpcClient.MutateBatchJobAsync, grpcClient.MutateBatchJob, effectiveSettings.MutateBatchJobSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateBatchJob);
            Modify_MutateBatchJobApiCall(ref _callMutateBatchJob);
            _callListBatchJobResults = clientHelper.BuildApiCall<ListBatchJobResultsRequest, ListBatchJobResultsResponse>("ListBatchJobResults", grpcClient.ListBatchJobResultsAsync, grpcClient.ListBatchJobResults, effectiveSettings.ListBatchJobResultsSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callListBatchJobResults);
            Modify_ListBatchJobResultsApiCall(ref _callListBatchJobResults);
            _callRunBatchJob = clientHelper.BuildApiCall<RunBatchJobRequest, lro::Operation>("RunBatchJob", grpcClient.RunBatchJobAsync, grpcClient.RunBatchJob, effectiveSettings.RunBatchJobSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callRunBatchJob);
            Modify_RunBatchJobApiCall(ref _callRunBatchJob);
            _callAddBatchJobOperations = clientHelper.BuildApiCall<AddBatchJobOperationsRequest, AddBatchJobOperationsResponse>("AddBatchJobOperations", grpcClient.AddBatchJobOperationsAsync, grpcClient.AddBatchJobOperations, effectiveSettings.AddBatchJobOperationsSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callAddBatchJobOperations);
            Modify_AddBatchJobOperationsApiCall(ref _callAddBatchJobOperations);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateBatchJobApiCall(ref gaxgrpc::ApiCall<MutateBatchJobRequest, MutateBatchJobResponse> call);

        partial void Modify_ListBatchJobResultsApiCall(ref gaxgrpc::ApiCall<ListBatchJobResultsRequest, ListBatchJobResultsResponse> call);

        partial void Modify_RunBatchJobApiCall(ref gaxgrpc::ApiCall<RunBatchJobRequest, lro::Operation> call);

        partial void Modify_AddBatchJobOperationsApiCall(ref gaxgrpc::ApiCall<AddBatchJobOperationsRequest, AddBatchJobOperationsResponse> call);

        partial void OnConstruction(BatchJobService.BatchJobServiceClient grpcClient, BatchJobServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC BatchJobService client</summary>
        public override BatchJobService.BatchJobServiceClient GrpcClient { get; }

        partial void Modify_MutateBatchJobRequest(ref MutateBatchJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListBatchJobResultsRequest(ref ListBatchJobResultsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_RunBatchJobRequest(ref RunBatchJobRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_AddBatchJobOperationsRequest(ref AddBatchJobOperationsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Mutates a batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateBatchJobResponse MutateBatchJob(MutateBatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBatchJobRequest(ref request, ref callSettings);
            return _callMutateBatchJob.Sync(request, callSettings);
        }

        /// <summary>
        /// Mutates a batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateBatchJobResponse> MutateBatchJobAsync(MutateBatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateBatchJobRequest(ref request, ref callSettings);
            return _callMutateBatchJob.Async(request, callSettings);
        }

        /// <summary>
        /// Returns the results of the batch job. The job must be done.
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable sequence of <see cref="BatchJobResult"/> resources.</returns>
        public override gax::PagedEnumerable<ListBatchJobResultsResponse, BatchJobResult> ListBatchJobResults(ListBatchJobResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBatchJobResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedEnumerable<ListBatchJobResultsRequest, ListBatchJobResultsResponse, BatchJobResult>(_callListBatchJobResults, request, callSettings);
        }

        /// <summary>
        /// Returns the results of the batch job. The job must be done.
        /// Supports standard list paging.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A pageable asynchronous sequence of <see cref="BatchJobResult"/> resources.</returns>
        public override gax::PagedAsyncEnumerable<ListBatchJobResultsResponse, BatchJobResult> ListBatchJobResultsAsync(ListBatchJobResultsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListBatchJobResultsRequest(ref request, ref callSettings);
            return new gaxgrpc::GrpcPagedAsyncEnumerable<ListBatchJobResultsRequest, ListBatchJobResultsResponse, BatchJobResult>(_callListBatchJobResults, request, callSettings);
        }

        /// <summary>The long-running operations client for <c>RunBatchJob</c>.</summary>
        public override lro::OperationsClient RunBatchJobOperationsClient { get; }

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata> RunBatchJob(RunBatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunBatchJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>(_callRunBatchJob.Sync(request, callSettings), RunBatchJobOperationsClient);
        }

        /// <summary>
        /// Runs the batch job.
        /// 
        /// The Operation.metadata field type is BatchJobMetadata. When finished, the
        /// long running operation will not contain errors or a response. Instead, use
        /// ListBatchJobResults to get the results of the job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>> RunBatchJobAsync(RunBatchJobRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RunBatchJobRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, gagvr::BatchJob.Types.BatchJobMetadata>(await _callRunBatchJob.Async(request, callSettings).ConfigureAwait(false), RunBatchJobOperationsClient);
        }

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override AddBatchJobOperationsResponse AddBatchJobOperations(AddBatchJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddBatchJobOperationsRequest(ref request, ref callSettings);
            return _callAddBatchJobOperations.Sync(request, callSettings);
        }

        /// <summary>
        /// Add operations to the batch job.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [BatchJobError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// [ResourceCountLimitExceededError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<AddBatchJobOperationsResponse> AddBatchJobOperationsAsync(AddBatchJobOperationsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_AddBatchJobOperationsRequest(ref request, ref callSettings);
            return _callAddBatchJobOperations.Async(request, callSettings);
        }
    }

    public partial class ListBatchJobResultsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListBatchJobResultsResponse : gaxgrpc::IPageResponse<BatchJobResult>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<BatchJobResult> GetEnumerator() => Results.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class BatchJobService
    {
        public partial class BatchJobServiceClient
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

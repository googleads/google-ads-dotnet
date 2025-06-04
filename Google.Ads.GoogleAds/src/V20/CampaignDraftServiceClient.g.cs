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
using gagvr = Google.Ads.GoogleAds.V20.Resources;
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

namespace Google.Ads.GoogleAds.V20.Services
{
    /// <summary>Settings for <see cref="CampaignDraftServiceClient"/> instances.</summary>
    public sealed partial class CampaignDraftServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CampaignDraftServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CampaignDraftServiceSettings"/>.</returns>
        public static CampaignDraftServiceSettings GetDefault() => new CampaignDraftServiceSettings();

        /// <summary>Constructs a new <see cref="CampaignDraftServiceSettings"/> object with default settings.</summary>
        public CampaignDraftServiceSettings()
        {
        }

        private CampaignDraftServiceSettings(CampaignDraftServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCampaignDraftsSettings = existing.MutateCampaignDraftsSettings;
            PromoteCampaignDraftSettings = existing.PromoteCampaignDraftSettings;
            PromoteCampaignDraftOperationsSettings = existing.PromoteCampaignDraftOperationsSettings.Clone();
            ListCampaignDraftAsyncErrorsSettings = existing.ListCampaignDraftAsyncErrorsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CampaignDraftServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignDraftServiceClient.MutateCampaignDrafts</c> and
        /// <c>CampaignDraftServiceClient.MutateCampaignDraftsAsync</c>.
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
        public gaxgrpc::CallSettings MutateCampaignDraftsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignDraftServiceClient.PromoteCampaignDraft</c> and
        /// <c>CampaignDraftServiceClient.PromoteCampaignDraftAsync</c>.
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
        public gaxgrpc::CallSettings PromoteCampaignDraftSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>
        /// Long Running Operation settings for calls to <c>CampaignDraftServiceClient.PromoteCampaignDraft</c> and
        /// <c>CampaignDraftServiceClient.PromoteCampaignDraftAsync</c>.
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
        public lro::OperationsSettings PromoteCampaignDraftOperationsSettings { get; set; } = new lro::OperationsSettings
        {
            DefaultPollSettings = new gax::PollSettings(gax::Expiration.FromTimeout(sys::TimeSpan.FromHours(24)), sys::TimeSpan.FromSeconds(20), 1.5, sys::TimeSpan.FromSeconds(45)),
        };

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CampaignDraftServiceClient.ListCampaignDraftAsyncErrors</c> and
        /// <c>CampaignDraftServiceClient.ListCampaignDraftAsyncErrorsAsync</c>.
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
        public gaxgrpc::CallSettings ListCampaignDraftAsyncErrorsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CampaignDraftServiceSettings"/> object.</returns>
        public CampaignDraftServiceSettings Clone() => new CampaignDraftServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CampaignDraftServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CampaignDraftServiceClientBuilder : gaxgrpc::ClientBuilderBase<CampaignDraftServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CampaignDraftServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CampaignDraftServiceClientBuilder() : base(CampaignDraftServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CampaignDraftServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CampaignDraftServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CampaignDraftServiceClient Build()
        {
            CampaignDraftServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CampaignDraftServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CampaignDraftServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CampaignDraftServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CampaignDraftServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<CampaignDraftServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CampaignDraftServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CampaignDraftServiceClient.ChannelPool;
    }

    /// <summary>CampaignDraftService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign drafts.
    /// </remarks>
    public abstract partial class CampaignDraftServiceClient
    {
        /// <summary>
        /// The default endpoint for the CampaignDraftService service, which is a host of "googleads.googleapis.com" and
        /// a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CampaignDraftService scopes.</summary>
        /// <remarks>
        /// The default CampaignDraftService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CampaignDraftService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CampaignDraftServiceClient"/> using the default credentials, endpoint
        /// and settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignDraftServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CampaignDraftServiceClient"/>.</returns>
        public static stt::Task<CampaignDraftServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CampaignDraftServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CampaignDraftServiceClient"/> using the default credentials, endpoint and
        /// settings. To specify custom credentials or other settings, use
        /// <see cref="CampaignDraftServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CampaignDraftServiceClient"/>.</returns>
        public static CampaignDraftServiceClient Create() => new CampaignDraftServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CampaignDraftServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CampaignDraftServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CampaignDraftServiceClient"/>.</returns>
        internal static CampaignDraftServiceClient Create(grpccore::CallInvoker callInvoker, CampaignDraftServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CampaignDraftService.CampaignDraftServiceClient grpcClient = new CampaignDraftService.CampaignDraftServiceClient(callInvoker);
            return new CampaignDraftServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CampaignDraftService client</summary>
        public virtual CampaignDraftService.CampaignDraftServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignDraftsResponse MutateCampaignDrafts(MutateCampaignDraftsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(MutateCampaignDraftsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(MutateCampaignDraftsRequest request, st::CancellationToken cancellationToken) =>
            MutateCampaignDraftsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign drafts are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign drafts.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCampaignDraftsResponse MutateCampaignDrafts(string customerId, scg::IEnumerable<CampaignDraftOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignDrafts(new MutateCampaignDraftsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign drafts are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign drafts.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(string customerId, scg::IEnumerable<CampaignDraftOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCampaignDraftsAsync(new MutateCampaignDraftsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose campaign drafts are being modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual campaign drafts.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(string customerId, scg::IEnumerable<CampaignDraftOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCampaignDraftsAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> PromoteCampaignDraft(PromoteCampaignDraftRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignDraftAsync(PromoteCampaignDraftRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignDraftAsync(PromoteCampaignDraftRequest request, st::CancellationToken cancellationToken) =>
            PromoteCampaignDraftAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>The long-running operations client for <c>PromoteCampaignDraft</c>.</summary>
        public virtual lro::OperationsClient PromoteCampaignDraftOperationsClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Poll an operation once, using an <c>operationName</c> from a previous invocation of <c>PromoteCampaignDraft</c>
        /// .
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The result of polling the operation.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> PollOncePromoteCampaignDraft(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Empty>.PollOnceFromName(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteCampaignDraftOperationsClient, callSettings);

        /// <summary>
        /// Asynchronously poll an operation once, using an <c>operationName</c> from a previous invocation of
        /// <c>PromoteCampaignDraft</c>.
        /// </summary>
        /// <param name="operationName">
        /// The name of a previously invoked operation. Must not be <c>null</c> or empty.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A task representing the result of polling the operation.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PollOncePromoteCampaignDraftAsync(string operationName, gaxgrpc::CallSettings callSettings = null) =>
            lro::Operation<wkt::Empty, wkt::Empty>.PollOnceFromNameAsync(gax::GaxPreconditions.CheckNotNullOrEmpty(operationName, nameof(operationName)), PromoteCampaignDraftOperationsClient, callSettings);

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignDraft">
        /// Required. The resource name of the campaign draft to promote.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> PromoteCampaignDraft(string campaignDraft, gaxgrpc::CallSettings callSettings = null) =>
            PromoteCampaignDraft(new PromoteCampaignDraftRequest
            {
                CampaignDraft = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignDraft, nameof(campaignDraft)),
            }, callSettings);

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignDraft">
        /// Required. The resource name of the campaign draft to promote.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignDraftAsync(string campaignDraft, gaxgrpc::CallSettings callSettings = null) =>
            PromoteCampaignDraftAsync(new PromoteCampaignDraftRequest
            {
                CampaignDraft = gax::GaxPreconditions.CheckNotNullOrEmpty(campaignDraft, nameof(campaignDraft)),
            }, callSettings);

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignDraft">
        /// Required. The resource name of the campaign draft to promote.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignDraftAsync(string campaignDraft, st::CancellationToken cancellationToken) =>
            PromoteCampaignDraftAsync(campaignDraft, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignDraft">
        /// Required. The resource name of the campaign draft to promote.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual lro::Operation<wkt::Empty, wkt::Empty> PromoteCampaignDraft(gagvr::CampaignDraftName campaignDraft, gaxgrpc::CallSettings callSettings = null) =>
            PromoteCampaignDraft(new PromoteCampaignDraftRequest
            {
                CampaignDraftAsCampaignDraftName = gax::GaxPreconditions.CheckNotNull(campaignDraft, nameof(campaignDraft)),
            }, callSettings);

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignDraft">
        /// Required. The resource name of the campaign draft to promote.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignDraftAsync(gagvr::CampaignDraftName campaignDraft, gaxgrpc::CallSettings callSettings = null) =>
            PromoteCampaignDraftAsync(new PromoteCampaignDraftRequest
            {
                CampaignDraftAsCampaignDraftName = gax::GaxPreconditions.CheckNotNull(campaignDraft, nameof(campaignDraft)),
            }, callSettings);

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="campaignDraft">
        /// Required. The resource name of the campaign draft to promote.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignDraftAsync(gagvr::CampaignDraftName campaignDraft, st::CancellationToken cancellationToken) =>
            PromoteCampaignDraftAsync(campaignDraft, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        public virtual gax::PagedEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrors(ListCampaignDraftAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        public virtual gax::PagedAsyncEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrorsAsync(ListCampaignDraftAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        /// Required. The name of the campaign draft from which to retrieve the async
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
        public virtual gax::PagedEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrors(string resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCampaignDraftAsyncErrorsRequest request = new ListCampaignDraftAsyncErrorsRequest
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
            return ListCampaignDraftAsyncErrors(request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        /// Required. The name of the campaign draft from which to retrieve the async
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
        public virtual gax::PagedAsyncEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrorsAsync(string resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCampaignDraftAsyncErrorsRequest request = new ListCampaignDraftAsyncErrorsRequest
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
            return ListCampaignDraftAsyncErrorsAsync(request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        /// Required. The name of the campaign draft from which to retrieve the async
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
        public virtual gax::PagedEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrors(gagvr::CampaignDraftName resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCampaignDraftAsyncErrorsRequest request = new ListCampaignDraftAsyncErrorsRequest
            {
                ResourceNameAsCampaignDraftName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCampaignDraftAsyncErrors(request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        /// Required. The name of the campaign draft from which to retrieve the async
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
        public virtual gax::PagedAsyncEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrorsAsync(gagvr::CampaignDraftName resourceName, string pageToken = null, int? pageSize = null, gaxgrpc::CallSettings callSettings = null)
        {
            ListCampaignDraftAsyncErrorsRequest request = new ListCampaignDraftAsyncErrorsRequest
            {
                ResourceNameAsCampaignDraftName = gax::GaxPreconditions.CheckNotNull(resourceName, nameof(resourceName)),
            };
            if (pageToken != null)
            {
                request.PageToken = pageToken;
            }
            if (pageSize != null)
            {
                request.PageSize = pageSize.Value;
            }
            return ListCampaignDraftAsyncErrorsAsync(request, callSettings);
        }
    }

    /// <summary>CampaignDraftService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage campaign drafts.
    /// </remarks>
    public sealed partial class CampaignDraftServiceClientImpl : CampaignDraftServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCampaignDraftsRequest, MutateCampaignDraftsResponse> _callMutateCampaignDrafts;

        private readonly gaxgrpc::ApiCall<PromoteCampaignDraftRequest, lro::Operation> _callPromoteCampaignDraft;

        private readonly gaxgrpc::ApiCall<ListCampaignDraftAsyncErrorsRequest, ListCampaignDraftAsyncErrorsResponse> _callListCampaignDraftAsyncErrors;

        /// <summary>
        /// Constructs a client wrapper for the CampaignDraftService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">The base <see cref="CampaignDraftServiceSettings"/> used within this client.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CampaignDraftServiceClientImpl(CampaignDraftService.CampaignDraftServiceClient grpcClient, CampaignDraftServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CampaignDraftServiceSettings effectiveSettings = settings ?? CampaignDraftServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            PromoteCampaignDraftOperationsClient = new lro::OperationsClientImpl(grpcClient.CreateOperationsClient(), effectiveSettings.PromoteCampaignDraftOperationsSettings, logger);
            _callMutateCampaignDrafts = clientHelper.BuildApiCall<MutateCampaignDraftsRequest, MutateCampaignDraftsResponse>("MutateCampaignDrafts", grpcClient.MutateCampaignDraftsAsync, grpcClient.MutateCampaignDrafts, effectiveSettings.MutateCampaignDraftsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCampaignDrafts);
            Modify_MutateCampaignDraftsApiCall(ref _callMutateCampaignDrafts);
            _callPromoteCampaignDraft = clientHelper.BuildApiCall<PromoteCampaignDraftRequest, lro::Operation>("PromoteCampaignDraft", grpcClient.PromoteCampaignDraftAsync, grpcClient.PromoteCampaignDraft, effectiveSettings.PromoteCampaignDraftSettings).WithGoogleRequestParam("campaign_draft", request => request.CampaignDraft);
            Modify_ApiCall(ref _callPromoteCampaignDraft);
            Modify_PromoteCampaignDraftApiCall(ref _callPromoteCampaignDraft);
            _callListCampaignDraftAsyncErrors = clientHelper.BuildApiCall<ListCampaignDraftAsyncErrorsRequest, ListCampaignDraftAsyncErrorsResponse>("ListCampaignDraftAsyncErrors", grpcClient.ListCampaignDraftAsyncErrorsAsync, grpcClient.ListCampaignDraftAsyncErrors, effectiveSettings.ListCampaignDraftAsyncErrorsSettings).WithGoogleRequestParam("resource_name", request => request.ResourceName);
            Modify_ApiCall(ref _callListCampaignDraftAsyncErrors);
            Modify_ListCampaignDraftAsyncErrorsApiCall(ref _callListCampaignDraftAsyncErrors);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCampaignDraftsApiCall(ref gaxgrpc::ApiCall<MutateCampaignDraftsRequest, MutateCampaignDraftsResponse> call);

        partial void Modify_PromoteCampaignDraftApiCall(ref gaxgrpc::ApiCall<PromoteCampaignDraftRequest, lro::Operation> call);

        partial void Modify_ListCampaignDraftAsyncErrorsApiCall(ref gaxgrpc::ApiCall<ListCampaignDraftAsyncErrorsRequest, ListCampaignDraftAsyncErrorsResponse> call);

        partial void OnConstruction(CampaignDraftService.CampaignDraftServiceClient grpcClient, CampaignDraftServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CampaignDraftService client</summary>
        public override CampaignDraftService.CampaignDraftServiceClient GrpcClient { get; }

        partial void Modify_MutateCampaignDraftsRequest(ref MutateCampaignDraftsRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_PromoteCampaignDraftRequest(ref PromoteCampaignDraftRequest request, ref gaxgrpc::CallSettings settings);

        partial void Modify_ListCampaignDraftAsyncErrorsRequest(ref ListCampaignDraftAsyncErrorsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCampaignDraftsResponse MutateCampaignDrafts(MutateCampaignDraftsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignDraftsRequest(ref request, ref callSettings);
            return _callMutateCampaignDrafts.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates, or removes campaign drafts. Operation statuses are
        /// returned.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [DatabaseError]()
        /// [FieldError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCampaignDraftsResponse> MutateCampaignDraftsAsync(MutateCampaignDraftsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCampaignDraftsRequest(ref request, ref callSettings);
            return _callMutateCampaignDrafts.Async(request, callSettings);
        }

        /// <summary>The long-running operations client for <c>PromoteCampaignDraft</c>.</summary>
        public override lro::OperationsClient PromoteCampaignDraftOperationsClient { get; }

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override lro::Operation<wkt::Empty, wkt::Empty> PromoteCampaignDraft(PromoteCampaignDraftRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteCampaignDraftRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Empty>(_callPromoteCampaignDraft.Sync(request, callSettings), PromoteCampaignDraftOperationsClient);
        }

        /// <summary>
        /// Promotes the changes in a draft back to the base campaign.
        /// 
        /// This method returns a Long Running Operation (LRO) indicating if the
        /// Promote is done. Use [Operations.GetOperation] to poll the LRO until it
        /// is done. Only a done status is returned in the response. See the status
        /// in the Campaign Draft resource to determine if the promotion was
        /// successful. If the LRO failed, use
        /// [CampaignDraftService.ListCampaignDraftAsyncErrors][google.ads.googleads.v20.services.CampaignDraftService.ListCampaignDraftAsyncErrors]
        /// to view the list of error reasons.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [CampaignDraftError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override async stt::Task<lro::Operation<wkt::Empty, wkt::Empty>> PromoteCampaignDraftAsync(PromoteCampaignDraftRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_PromoteCampaignDraftRequest(ref request, ref callSettings);
            return new lro::Operation<wkt::Empty, wkt::Empty>(await _callPromoteCampaignDraft.Async(request, callSettings).ConfigureAwait(false), PromoteCampaignDraftOperationsClient);
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        public override gax::PagedEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrors(ListCampaignDraftAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCampaignDraftAsyncErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::AdsPagedEnumerable<ListCampaignDraftAsyncErrorsRequest, ListCampaignDraftAsyncErrorsResponse, gr::Status>(_callListCampaignDraftAsyncErrors, request, callSettings);
        }

        /// <summary>
        /// Returns all errors that occurred during CampaignDraft promote. Throws an
        /// error if called before campaign draft is promoted.
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
        public override gax::PagedAsyncEnumerable<ListCampaignDraftAsyncErrorsResponse, gr::Status> ListCampaignDraftAsyncErrorsAsync(ListCampaignDraftAsyncErrorsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_ListCampaignDraftAsyncErrorsRequest(ref request, ref callSettings);
            return new gaxgrpc::AdsPagedAsyncEnumerable<ListCampaignDraftAsyncErrorsRequest, ListCampaignDraftAsyncErrorsResponse, gr::Status>(_callListCampaignDraftAsyncErrors, request, callSettings);
        }
    }

    public partial class ListCampaignDraftAsyncErrorsRequest : gaxgrpc::IPageRequest
    {
    }

    public partial class ListCampaignDraftAsyncErrorsResponse : gaxgrpc::IPageResponse<gr::Status>
    {
        /// <summary>Returns an enumerator that iterates through the resources in this response.</summary>
        public scg::IEnumerator<gr::Status> GetEnumerator() => Errors.GetEnumerator();

        sc::IEnumerator sc::IEnumerable.GetEnumerator() => GetEnumerator();
    }

    public static partial class CampaignDraftService
    {
        public partial class CampaignDraftServiceClient
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

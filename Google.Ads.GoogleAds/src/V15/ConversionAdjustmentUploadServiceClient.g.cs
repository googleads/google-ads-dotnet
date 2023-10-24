// Copyright 2023 Google LLC
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

namespace Google.Ads.GoogleAds.V15.Services
{
    /// <summary>Settings for <see cref="ConversionAdjustmentUploadServiceClient"/> instances.</summary>
    public sealed partial class ConversionAdjustmentUploadServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="ConversionAdjustmentUploadServiceSettings"/>.
        /// </summary>
        /// <returns>A new instance of the default <see cref="ConversionAdjustmentUploadServiceSettings"/>.</returns>
        public static ConversionAdjustmentUploadServiceSettings GetDefault() =>
            new ConversionAdjustmentUploadServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="ConversionAdjustmentUploadServiceSettings"/> object with default settings.
        /// </summary>
        public ConversionAdjustmentUploadServiceSettings()
        {
        }

        private ConversionAdjustmentUploadServiceSettings(ConversionAdjustmentUploadServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            UploadConversionAdjustmentsSettings = existing.UploadConversionAdjustmentsSettings;
            OnCopy(existing);
        }

        partial void OnCopy(ConversionAdjustmentUploadServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>ConversionAdjustmentUploadServiceClient.UploadConversionAdjustments</c> and
        /// <c>ConversionAdjustmentUploadServiceClient.UploadConversionAdjustmentsAsync</c>.
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
        public gaxgrpc::CallSettings UploadConversionAdjustmentsSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="ConversionAdjustmentUploadServiceSettings"/> object.</returns>
        public ConversionAdjustmentUploadServiceSettings Clone() => new ConversionAdjustmentUploadServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="ConversionAdjustmentUploadServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class ConversionAdjustmentUploadServiceClientBuilder : gaxgrpc::ClientBuilderBase<ConversionAdjustmentUploadServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public ConversionAdjustmentUploadServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public ConversionAdjustmentUploadServiceClientBuilder() : base(ConversionAdjustmentUploadServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref ConversionAdjustmentUploadServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<ConversionAdjustmentUploadServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override ConversionAdjustmentUploadServiceClient Build()
        {
            ConversionAdjustmentUploadServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<ConversionAdjustmentUploadServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<ConversionAdjustmentUploadServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private ConversionAdjustmentUploadServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return ConversionAdjustmentUploadServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<ConversionAdjustmentUploadServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return ConversionAdjustmentUploadServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => ConversionAdjustmentUploadServiceClient.ChannelPool;
    }

    /// <summary>ConversionAdjustmentUploadService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to upload conversion adjustments.
    /// </remarks>
    public abstract partial class ConversionAdjustmentUploadServiceClient
    {
        /// <summary>
        /// The default endpoint for the ConversionAdjustmentUploadService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default ConversionAdjustmentUploadService scopes.</summary>
        /// <remarks>
        /// The default ConversionAdjustmentUploadService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(ConversionAdjustmentUploadService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="ConversionAdjustmentUploadServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionAdjustmentUploadServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="ConversionAdjustmentUploadServiceClient"/>.</returns>
        public static stt::Task<ConversionAdjustmentUploadServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new ConversionAdjustmentUploadServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="ConversionAdjustmentUploadServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="ConversionAdjustmentUploadServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="ConversionAdjustmentUploadServiceClient"/>.</returns>
        public static ConversionAdjustmentUploadServiceClient Create() =>
            new ConversionAdjustmentUploadServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="ConversionAdjustmentUploadServiceClient"/> which uses the specified call invoker for
        /// remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="ConversionAdjustmentUploadServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="ConversionAdjustmentUploadServiceClient"/>.</returns>
        internal static ConversionAdjustmentUploadServiceClient Create(grpccore::CallInvoker callInvoker, ConversionAdjustmentUploadServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient grpcClient = new ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient(callInvoker);
            return new ConversionAdjustmentUploadServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC ConversionAdjustmentUploadService client</summary>
        public virtual ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Processes the given conversion adjustments.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadConversionAdjustmentsResponse UploadConversionAdjustments(UploadConversionAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes the given conversion adjustments.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(UploadConversionAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Processes the given conversion adjustments.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(UploadConversionAdjustmentsRequest request, st::CancellationToken cancellationToken) =>
            UploadConversionAdjustmentsAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Processes the given conversion adjustments.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversionAdjustments">
        /// Required. The conversion adjustments that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried out
        /// in one transaction if and only if they are all valid. This should always be
        /// set to true.
        /// See
        /// https://developers.google.com/google-ads/api/docs/best-practices/partial-failures
        /// for more information about partial failure.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual UploadConversionAdjustmentsResponse UploadConversionAdjustments(string customerId, scg::IEnumerable<ConversionAdjustment> conversionAdjustments, bool partialFailure, gaxgrpc::CallSettings callSettings = null) =>
            UploadConversionAdjustments(new UploadConversionAdjustmentsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ConversionAdjustments =
                {
                    gax::GaxPreconditions.CheckNotNull(conversionAdjustments, nameof(conversionAdjustments)),
                },
                PartialFailure = partialFailure,
            }, callSettings);

        /// <summary>
        /// Processes the given conversion adjustments.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversionAdjustments">
        /// Required. The conversion adjustments that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried out
        /// in one transaction if and only if they are all valid. This should always be
        /// set to true.
        /// See
        /// https://developers.google.com/google-ads/api/docs/best-practices/partial-failures
        /// for more information about partial failure.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(string customerId, scg::IEnumerable<ConversionAdjustment> conversionAdjustments, bool partialFailure, gaxgrpc::CallSettings callSettings = null) =>
            UploadConversionAdjustmentsAsync(new UploadConversionAdjustmentsRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                ConversionAdjustments =
                {
                    gax::GaxPreconditions.CheckNotNull(conversionAdjustments, nameof(conversionAdjustments)),
                },
                PartialFailure = partialFailure,
            }, callSettings);

        /// <summary>
        /// Processes the given conversion adjustments.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer performing the upload.
        /// </param>
        /// <param name="conversionAdjustments">
        /// Required. The conversion adjustments that are being uploaded.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried out
        /// in one transaction if and only if they are all valid. This should always be
        /// set to true.
        /// See
        /// https://developers.google.com/google-ads/api/docs/best-practices/partial-failures
        /// for more information about partial failure.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(string customerId, scg::IEnumerable<ConversionAdjustment> conversionAdjustments, bool partialFailure, st::CancellationToken cancellationToken) =>
            UploadConversionAdjustmentsAsync(customerId, conversionAdjustments, partialFailure, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>ConversionAdjustmentUploadService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to upload conversion adjustments.
    /// </remarks>
    public sealed partial class ConversionAdjustmentUploadServiceClientImpl : ConversionAdjustmentUploadServiceClient
    {
        private readonly gaxgrpc::ApiCall<UploadConversionAdjustmentsRequest, UploadConversionAdjustmentsResponse> _callUploadConversionAdjustments;

        /// <summary>
        /// Constructs a client wrapper for the ConversionAdjustmentUploadService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="ConversionAdjustmentUploadServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public ConversionAdjustmentUploadServiceClientImpl(ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient grpcClient, ConversionAdjustmentUploadServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            ConversionAdjustmentUploadServiceSettings effectiveSettings = settings ?? ConversionAdjustmentUploadServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callUploadConversionAdjustments = clientHelper.BuildApiCall<UploadConversionAdjustmentsRequest, UploadConversionAdjustmentsResponse>("UploadConversionAdjustments", grpcClient.UploadConversionAdjustmentsAsync, grpcClient.UploadConversionAdjustments, effectiveSettings.UploadConversionAdjustmentsSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callUploadConversionAdjustments);
            Modify_UploadConversionAdjustmentsApiCall(ref _callUploadConversionAdjustments);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_UploadConversionAdjustmentsApiCall(ref gaxgrpc::ApiCall<UploadConversionAdjustmentsRequest, UploadConversionAdjustmentsResponse> call);

        partial void OnConstruction(ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient grpcClient, ConversionAdjustmentUploadServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC ConversionAdjustmentUploadService client</summary>
        public override ConversionAdjustmentUploadService.ConversionAdjustmentUploadServiceClient GrpcClient { get; }

        partial void Modify_UploadConversionAdjustmentsRequest(ref UploadConversionAdjustmentsRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Processes the given conversion adjustments.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override UploadConversionAdjustmentsResponse UploadConversionAdjustments(UploadConversionAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadConversionAdjustmentsRequest(ref request, ref callSettings);
            return _callUploadConversionAdjustments.Sync(request, callSettings);
        }

        /// <summary>
        /// Processes the given conversion adjustments.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [HeaderError]()
        /// [InternalError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<UploadConversionAdjustmentsResponse> UploadConversionAdjustmentsAsync(UploadConversionAdjustmentsRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_UploadConversionAdjustmentsRequest(ref request, ref callSettings);
            return _callUploadConversionAdjustments.Async(request, callSettings);
        }
    }
}

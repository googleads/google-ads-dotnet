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

namespace Google.Ads.GoogleAds.V21.Services
{
    /// <summary>Settings for <see cref="AutomaticallyCreatedAssetRemovalServiceClient"/> instances.</summary>
    public sealed partial class AutomaticallyCreatedAssetRemovalServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>
        /// Get a new instance of the default <see cref="AutomaticallyCreatedAssetRemovalServiceSettings"/>.
        /// </summary>
        /// <returns>
        /// A new instance of the default <see cref="AutomaticallyCreatedAssetRemovalServiceSettings"/>.
        /// </returns>
        public static AutomaticallyCreatedAssetRemovalServiceSettings GetDefault() =>
            new AutomaticallyCreatedAssetRemovalServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="AutomaticallyCreatedAssetRemovalServiceSettings"/> object with default settings.
        /// </summary>
        public AutomaticallyCreatedAssetRemovalServiceSettings()
        {
        }

        private AutomaticallyCreatedAssetRemovalServiceSettings(AutomaticallyCreatedAssetRemovalServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            RemoveCampaignAutomaticallyCreatedAssetSettings = existing.RemoveCampaignAutomaticallyCreatedAssetSettings;
            OnCopy(existing);
        }

        partial void OnCopy(AutomaticallyCreatedAssetRemovalServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>AutomaticallyCreatedAssetRemovalServiceClient.RemoveCampaignAutomaticallyCreatedAsset</c> and
        /// <c>AutomaticallyCreatedAssetRemovalServiceClient.RemoveCampaignAutomaticallyCreatedAssetAsync</c>.
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
        public gaxgrpc::CallSettings RemoveCampaignAutomaticallyCreatedAssetSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>
        /// A deep clone of this <see cref="AutomaticallyCreatedAssetRemovalServiceSettings"/> object.
        /// </returns>
        public AutomaticallyCreatedAssetRemovalServiceSettings Clone() =>
            new AutomaticallyCreatedAssetRemovalServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="AutomaticallyCreatedAssetRemovalServiceClient"/> to provide simple configuration of
    /// credentials, endpoint etc.
    /// </summary>
    internal sealed partial class AutomaticallyCreatedAssetRemovalServiceClientBuilder : gaxgrpc::ClientBuilderBase<AutomaticallyCreatedAssetRemovalServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public AutomaticallyCreatedAssetRemovalServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public AutomaticallyCreatedAssetRemovalServiceClientBuilder() : base(AutomaticallyCreatedAssetRemovalServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref AutomaticallyCreatedAssetRemovalServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<AutomaticallyCreatedAssetRemovalServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override AutomaticallyCreatedAssetRemovalServiceClient Build()
        {
            AutomaticallyCreatedAssetRemovalServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<AutomaticallyCreatedAssetRemovalServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<AutomaticallyCreatedAssetRemovalServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private AutomaticallyCreatedAssetRemovalServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return AutomaticallyCreatedAssetRemovalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        private async stt::Task<AutomaticallyCreatedAssetRemovalServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return AutomaticallyCreatedAssetRemovalServiceClient.Create(callInvoker, GetEffectiveSettings(Settings?.Clone()), Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() =>
            AutomaticallyCreatedAssetRemovalServiceClient.ChannelPool;
    }

    /// <summary>AutomaticallyCreatedAssetRemovalService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to remove automatically created assets.
    /// </remarks>
    public abstract partial class AutomaticallyCreatedAssetRemovalServiceClient
    {
        /// <summary>
        /// The default endpoint for the AutomaticallyCreatedAssetRemovalService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default AutomaticallyCreatedAssetRemovalService scopes.</summary>
        /// <remarks>
        /// The default AutomaticallyCreatedAssetRemovalService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(AutomaticallyCreatedAssetRemovalService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="AutomaticallyCreatedAssetRemovalServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AutomaticallyCreatedAssetRemovalServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>
        /// The task representing the created <see cref="AutomaticallyCreatedAssetRemovalServiceClient"/>.
        /// </returns>
        public static stt::Task<AutomaticallyCreatedAssetRemovalServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new AutomaticallyCreatedAssetRemovalServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="AutomaticallyCreatedAssetRemovalServiceClient"/> using the default
        /// credentials, endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="AutomaticallyCreatedAssetRemovalServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="AutomaticallyCreatedAssetRemovalServiceClient"/>.</returns>
        public static AutomaticallyCreatedAssetRemovalServiceClient Create() =>
            new AutomaticallyCreatedAssetRemovalServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="AutomaticallyCreatedAssetRemovalServiceClient"/> which uses the specified call invoker
        /// for remote operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="AutomaticallyCreatedAssetRemovalServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="AutomaticallyCreatedAssetRemovalServiceClient"/>.</returns>
        internal static AutomaticallyCreatedAssetRemovalServiceClient Create(grpccore::CallInvoker callInvoker, AutomaticallyCreatedAssetRemovalServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            AutomaticallyCreatedAssetRemovalService.AutomaticallyCreatedAssetRemovalServiceClient grpcClient = new AutomaticallyCreatedAssetRemovalService.AutomaticallyCreatedAssetRemovalServiceClient(callInvoker);
            return new AutomaticallyCreatedAssetRemovalServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC AutomaticallyCreatedAssetRemovalService client</summary>
        public virtual AutomaticallyCreatedAssetRemovalService.AutomaticallyCreatedAssetRemovalServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Removes automatically created assets from a campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveCampaignAutomaticallyCreatedAssetResponse RemoveCampaignAutomaticallyCreatedAsset(RemoveCampaignAutomaticallyCreatedAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes automatically created assets from a campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveCampaignAutomaticallyCreatedAssetResponse> RemoveCampaignAutomaticallyCreatedAssetAsync(RemoveCampaignAutomaticallyCreatedAssetRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Removes automatically created assets from a campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveCampaignAutomaticallyCreatedAssetResponse> RemoveCampaignAutomaticallyCreatedAssetAsync(RemoveCampaignAutomaticallyCreatedAssetRequest request, st::CancellationToken cancellationToken) =>
            RemoveCampaignAutomaticallyCreatedAssetAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Removes automatically created assets from a campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose assets are being removed.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual RemoveCampaignAutomaticallyCreatedAssetResponse RemoveCampaignAutomaticallyCreatedAsset(string customerId, scg::IEnumerable<RemoveCampaignAutomaticallyCreatedAssetOperation> operations, bool partialFailure, gaxgrpc::CallSettings callSettings = null) =>
            RemoveCampaignAutomaticallyCreatedAsset(new RemoveCampaignAutomaticallyCreatedAssetRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
                PartialFailure = partialFailure,
            }, callSettings);

        /// <summary>
        /// Removes automatically created assets from a campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose assets are being removed.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveCampaignAutomaticallyCreatedAssetResponse> RemoveCampaignAutomaticallyCreatedAssetAsync(string customerId, scg::IEnumerable<RemoveCampaignAutomaticallyCreatedAssetOperation> operations, bool partialFailure, gaxgrpc::CallSettings callSettings = null) =>
            RemoveCampaignAutomaticallyCreatedAssetAsync(new RemoveCampaignAutomaticallyCreatedAssetRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
                PartialFailure = partialFailure,
            }, callSettings);

        /// <summary>
        /// Removes automatically created assets from a campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose assets are being removed.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations.
        /// </param>
        /// <param name="partialFailure">
        /// Required. If true, successful operations will be carried out and invalid
        /// operations will return errors. If false, all operations will be carried
        /// out in one transaction if and only if they are all valid.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<RemoveCampaignAutomaticallyCreatedAssetResponse> RemoveCampaignAutomaticallyCreatedAssetAsync(string customerId, scg::IEnumerable<RemoveCampaignAutomaticallyCreatedAssetOperation> operations, bool partialFailure, st::CancellationToken cancellationToken) =>
            RemoveCampaignAutomaticallyCreatedAssetAsync(customerId, operations, partialFailure, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>AutomaticallyCreatedAssetRemovalService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to remove automatically created assets.
    /// </remarks>
    public sealed partial class AutomaticallyCreatedAssetRemovalServiceClientImpl : AutomaticallyCreatedAssetRemovalServiceClient
    {
        private readonly gaxgrpc::ApiCall<RemoveCampaignAutomaticallyCreatedAssetRequest, RemoveCampaignAutomaticallyCreatedAssetResponse> _callRemoveCampaignAutomaticallyCreatedAsset;

        /// <summary>
        /// Constructs a client wrapper for the AutomaticallyCreatedAssetRemovalService service, with the specified gRPC
        /// client and settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="AutomaticallyCreatedAssetRemovalServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public AutomaticallyCreatedAssetRemovalServiceClientImpl(AutomaticallyCreatedAssetRemovalService.AutomaticallyCreatedAssetRemovalServiceClient grpcClient, AutomaticallyCreatedAssetRemovalServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            AutomaticallyCreatedAssetRemovalServiceSettings effectiveSettings = settings ?? AutomaticallyCreatedAssetRemovalServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(new gaxgrpc::ClientHelper.Options
            {
                Settings = effectiveSettings,
                Logger = logger,
            });
            _callRemoveCampaignAutomaticallyCreatedAsset = clientHelper.BuildApiCall<RemoveCampaignAutomaticallyCreatedAssetRequest, RemoveCampaignAutomaticallyCreatedAssetResponse>("RemoveCampaignAutomaticallyCreatedAsset", grpcClient.RemoveCampaignAutomaticallyCreatedAssetAsync, grpcClient.RemoveCampaignAutomaticallyCreatedAsset, effectiveSettings.RemoveCampaignAutomaticallyCreatedAssetSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callRemoveCampaignAutomaticallyCreatedAsset);
            Modify_RemoveCampaignAutomaticallyCreatedAssetApiCall(ref _callRemoveCampaignAutomaticallyCreatedAsset);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_RemoveCampaignAutomaticallyCreatedAssetApiCall(ref gaxgrpc::ApiCall<RemoveCampaignAutomaticallyCreatedAssetRequest, RemoveCampaignAutomaticallyCreatedAssetResponse> call);

        partial void OnConstruction(AutomaticallyCreatedAssetRemovalService.AutomaticallyCreatedAssetRemovalServiceClient grpcClient, AutomaticallyCreatedAssetRemovalServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC AutomaticallyCreatedAssetRemovalService client</summary>
        public override AutomaticallyCreatedAssetRemovalService.AutomaticallyCreatedAssetRemovalServiceClient GrpcClient { get; }

        partial void Modify_RemoveCampaignAutomaticallyCreatedAssetRequest(ref RemoveCampaignAutomaticallyCreatedAssetRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Removes automatically created assets from a campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override RemoveCampaignAutomaticallyCreatedAssetResponse RemoveCampaignAutomaticallyCreatedAsset(RemoveCampaignAutomaticallyCreatedAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveCampaignAutomaticallyCreatedAssetRequest(ref request, ref callSettings);
            return _callRemoveCampaignAutomaticallyCreatedAsset.Sync(request, callSettings);
        }

        /// <summary>
        /// Removes automatically created assets from a campaign.
        /// 
        /// List of thrown errors:
        /// [AuthenticationError]()
        /// [AuthorizationError]()
        /// [ContextError]()
        /// [FieldError]()
        /// [InternalError]()
        /// [MutateError]()
        /// [PartialFailureError]()
        /// [QuotaError]()
        /// [RequestError]()
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<RemoveCampaignAutomaticallyCreatedAssetResponse> RemoveCampaignAutomaticallyCreatedAssetAsync(RemoveCampaignAutomaticallyCreatedAssetRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_RemoveCampaignAutomaticallyCreatedAssetRequest(ref request, ref callSettings);
            return _callRemoveCampaignAutomaticallyCreatedAsset.Async(request, callSettings);
        }
    }
}

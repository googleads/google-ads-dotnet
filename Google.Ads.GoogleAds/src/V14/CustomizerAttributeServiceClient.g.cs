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

namespace Google.Ads.GoogleAds.V14.Services
{
    /// <summary>Settings for <see cref="CustomizerAttributeServiceClient"/> instances.</summary>
    public sealed partial class CustomizerAttributeServiceSettings : gaxgrpc::ServiceSettingsBase
    {
        /// <summary>Get a new instance of the default <see cref="CustomizerAttributeServiceSettings"/>.</summary>
        /// <returns>A new instance of the default <see cref="CustomizerAttributeServiceSettings"/>.</returns>
        public static CustomizerAttributeServiceSettings GetDefault() => new CustomizerAttributeServiceSettings();

        /// <summary>
        /// Constructs a new <see cref="CustomizerAttributeServiceSettings"/> object with default settings.
        /// </summary>
        public CustomizerAttributeServiceSettings()
        {
        }

        private CustomizerAttributeServiceSettings(CustomizerAttributeServiceSettings existing) : base(existing)
        {
            gax::GaxPreconditions.CheckNotNull(existing, nameof(existing));
            MutateCustomizerAttributesSettings = existing.MutateCustomizerAttributesSettings;
            OnCopy(existing);
        }

        partial void OnCopy(CustomizerAttributeServiceSettings existing);

        /// <summary>
        /// <see cref="gaxgrpc::CallSettings"/> for synchronous and asynchronous calls to
        /// <c>CustomizerAttributeServiceClient.MutateCustomizerAttributes</c> and
        /// <c>CustomizerAttributeServiceClient.MutateCustomizerAttributesAsync</c>.
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
        public gaxgrpc::CallSettings MutateCustomizerAttributesSettings { get; set; } = gaxgrpc::CallSettingsExtensions.WithRetry(gaxgrpc::CallSettings.FromExpiration(gax::Expiration.FromTimeout(sys::TimeSpan.FromMilliseconds(14400000))), gaxgrpc::RetrySettings.FromExponentialBackoff(maxAttempts: 2147483647, initialBackoff: sys::TimeSpan.FromMilliseconds(5000), maxBackoff: sys::TimeSpan.FromMilliseconds(60000), backoffMultiplier: 1.3, retryFilter: gaxgrpc::RetrySettings.FilterForStatusCodes(grpccore::StatusCode.Unavailable, grpccore::StatusCode.DeadlineExceeded)));

        /// <summary>Creates a deep clone of this object, with all the same property values.</summary>
        /// <returns>A deep clone of this <see cref="CustomizerAttributeServiceSettings"/> object.</returns>
        public CustomizerAttributeServiceSettings Clone() => new CustomizerAttributeServiceSettings(this);
    }

    /// <summary>
    /// Builder class for <see cref="CustomizerAttributeServiceClient"/> to provide simple configuration of credentials,
    /// endpoint etc.
    /// </summary>
    internal sealed partial class CustomizerAttributeServiceClientBuilder : gaxgrpc::ClientBuilderBase<CustomizerAttributeServiceClient>
    {
        /// <summary>The settings to use for RPCs, or <c>null</c> for the default settings.</summary>
        public CustomizerAttributeServiceSettings Settings { get; set; }

        /// <summary>Creates a new builder with default settings.</summary>
        public CustomizerAttributeServiceClientBuilder() : base(CustomizerAttributeServiceClient.ServiceMetadata)
        {
        }

        partial void InterceptBuild(ref CustomizerAttributeServiceClient client);

        partial void InterceptBuildAsync(st::CancellationToken cancellationToken, ref stt::Task<CustomizerAttributeServiceClient> task);

        /// <summary>Builds the resulting client.</summary>
        public override CustomizerAttributeServiceClient Build()
        {
            CustomizerAttributeServiceClient client = null;
            InterceptBuild(ref client);
            return client ?? BuildImpl();
        }

        /// <summary>Builds the resulting client asynchronously.</summary>
        public override stt::Task<CustomizerAttributeServiceClient> BuildAsync(st::CancellationToken cancellationToken = default)
        {
            stt::Task<CustomizerAttributeServiceClient> task = null;
            InterceptBuildAsync(cancellationToken, ref task);
            return task ?? BuildAsyncImpl(cancellationToken);
        }

        private CustomizerAttributeServiceClient BuildImpl()
        {
            Validate();
            grpccore::CallInvoker callInvoker = CreateCallInvoker();
            return CustomizerAttributeServiceClient.Create(callInvoker, Settings, Logger);
        }

        private async stt::Task<CustomizerAttributeServiceClient> BuildAsyncImpl(st::CancellationToken cancellationToken)
        {
            Validate();
            grpccore::CallInvoker callInvoker = await CreateCallInvokerAsync(cancellationToken).ConfigureAwait(false);
            return CustomizerAttributeServiceClient.Create(callInvoker, Settings, Logger);
        }

        /// <summary>Returns the channel pool to use when no other options are specified.</summary>
        protected override gaxgrpc::ChannelPool GetChannelPool() => CustomizerAttributeServiceClient.ChannelPool;
    }

    /// <summary>CustomizerAttributeService client wrapper, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customizer attribute
    /// </remarks>
    public abstract partial class CustomizerAttributeServiceClient
    {
        /// <summary>
        /// The default endpoint for the CustomizerAttributeService service, which is a host of
        /// "googleads.googleapis.com" and a port of 443.
        /// </summary>
        public static string DefaultEndpoint { get; } = "googleads.googleapis.com:443";

        /// <summary>The default CustomizerAttributeService scopes.</summary>
        /// <remarks>
        /// The default CustomizerAttributeService scopes are:
        /// <list type="bullet"><item><description>https://www.googleapis.com/auth/adwords</description></item></list>
        /// </remarks>
        public static scg::IReadOnlyList<string> DefaultScopes { get; } = new sco::ReadOnlyCollection<string>(new string[]
        {
            "https://www.googleapis.com/auth/adwords",
        });

        /// <summary>The service metadata associated with this client type.</summary>
        public static gaxgrpc::ServiceMetadata ServiceMetadata { get; } = new gaxgrpc::ServiceMetadata(CustomizerAttributeService.Descriptor, DefaultEndpoint, DefaultScopes, true, gax::ApiTransports.Grpc, PackageApiMetadata.ApiMetadata);

        internal static gaxgrpc::ChannelPool ChannelPool { get; } = new gaxgrpc::ChannelPool(ServiceMetadata);

        /// <summary>
        /// Asynchronously creates a <see cref="CustomizerAttributeServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomizerAttributeServiceClientBuilder"/>.
        /// </summary>
        /// <param name="cancellationToken">
        /// The <see cref="st::CancellationToken"/> to use while creating the client.
        /// </param>
        /// <returns>The task representing the created <see cref="CustomizerAttributeServiceClient"/>.</returns>
        public static stt::Task<CustomizerAttributeServiceClient> CreateAsync(st::CancellationToken cancellationToken = default) =>
            new CustomizerAttributeServiceClientBuilder().BuildAsync(cancellationToken);

        /// <summary>
        /// Synchronously creates a <see cref="CustomizerAttributeServiceClient"/> using the default credentials,
        /// endpoint and settings. To specify custom credentials or other settings, use
        /// <see cref="CustomizerAttributeServiceClientBuilder"/>.
        /// </summary>
        /// <returns>The created <see cref="CustomizerAttributeServiceClient"/>.</returns>
        public static CustomizerAttributeServiceClient Create() => new CustomizerAttributeServiceClientBuilder().Build();

        /// <summary>
        /// Creates a <see cref="CustomizerAttributeServiceClient"/> which uses the specified call invoker for remote
        /// operations.
        /// </summary>
        /// <param name="callInvoker">
        /// The <see cref="grpccore::CallInvoker"/> for remote operations. Must not be null.
        /// </param>
        /// <param name="settings">Optional <see cref="CustomizerAttributeServiceSettings"/>.</param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/>.</param>
        /// <returns>The created <see cref="CustomizerAttributeServiceClient"/>.</returns>
        internal static CustomizerAttributeServiceClient Create(grpccore::CallInvoker callInvoker, CustomizerAttributeServiceSettings settings = null, mel::ILogger logger = null)
        {
            gax::GaxPreconditions.CheckNotNull(callInvoker, nameof(callInvoker));
            grpcinter::Interceptor interceptor = settings?.Interceptor;
            if (interceptor != null)
            {
                callInvoker = grpcinter::CallInvokerExtensions.Intercept(callInvoker, interceptor);
            }
            CustomizerAttributeService.CustomizerAttributeServiceClient grpcClient = new CustomizerAttributeService.CustomizerAttributeServiceClient(callInvoker);
            return new CustomizerAttributeServiceClientImpl(grpcClient, settings, logger);
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

        /// <summary>The underlying gRPC CustomizerAttributeService client</summary>
        public virtual CustomizerAttributeService.CustomizerAttributeServiceClient GrpcClient => throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes customizer attributes. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomizerAttributesResponse MutateCustomizerAttributes(MutateCustomizerAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes customizer attributes. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomizerAttributesResponse> MutateCustomizerAttributesAsync(MutateCustomizerAttributesRequest request, gaxgrpc::CallSettings callSettings = null) =>
            throw new sys::NotImplementedException();

        /// <summary>
        /// Creates, updates or removes customizer attributes. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomizerAttributesResponse> MutateCustomizerAttributesAsync(MutateCustomizerAttributesRequest request, st::CancellationToken cancellationToken) =>
            MutateCustomizerAttributesAsync(request, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));

        /// <summary>
        /// Creates, updates or removes customizer attributes. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customizer attributes are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customizer
        /// attributes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public virtual MutateCustomizerAttributesResponse MutateCustomizerAttributes(string customerId, scg::IEnumerable<CustomizerAttributeOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomizerAttributes(new MutateCustomizerAttributesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes customizer attributes. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customizer attributes are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customizer
        /// attributes.
        /// </param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomizerAttributesResponse> MutateCustomizerAttributesAsync(string customerId, scg::IEnumerable<CustomizerAttributeOperation> operations, gaxgrpc::CallSettings callSettings = null) =>
            MutateCustomizerAttributesAsync(new MutateCustomizerAttributesRequest
            {
                CustomerId = gax::GaxPreconditions.CheckNotNullOrEmpty(customerId, nameof(customerId)),
                Operations =
                {
                    gax::GaxPreconditions.CheckNotNull(operations, nameof(operations)),
                },
            }, callSettings);

        /// <summary>
        /// Creates, updates or removes customizer attributes. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="customerId">
        /// Required. The ID of the customer whose customizer attributes are being
        /// modified.
        /// </param>
        /// <param name="operations">
        /// Required. The list of operations to perform on individual customizer
        /// attributes.
        /// </param>
        /// <param name="cancellationToken">A <see cref="st::CancellationToken"/> to use for this RPC.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public virtual stt::Task<MutateCustomizerAttributesResponse> MutateCustomizerAttributesAsync(string customerId, scg::IEnumerable<CustomizerAttributeOperation> operations, st::CancellationToken cancellationToken) =>
            MutateCustomizerAttributesAsync(customerId, operations, gaxgrpc::CallSettings.FromCancellationToken(cancellationToken));
    }

    /// <summary>CustomizerAttributeService client wrapper implementation, for convenient use.</summary>
    /// <remarks>
    /// Service to manage customizer attribute
    /// </remarks>
    public sealed partial class CustomizerAttributeServiceClientImpl : CustomizerAttributeServiceClient
    {
        private readonly gaxgrpc::ApiCall<MutateCustomizerAttributesRequest, MutateCustomizerAttributesResponse> _callMutateCustomizerAttributes;

        /// <summary>
        /// Constructs a client wrapper for the CustomizerAttributeService service, with the specified gRPC client and
        /// settings.
        /// </summary>
        /// <param name="grpcClient">The underlying gRPC client.</param>
        /// <param name="settings">
        /// The base <see cref="CustomizerAttributeServiceSettings"/> used within this client.
        /// </param>
        /// <param name="logger">Optional <see cref="mel::ILogger"/> to use within this client.</param>
        public CustomizerAttributeServiceClientImpl(CustomizerAttributeService.CustomizerAttributeServiceClient grpcClient, CustomizerAttributeServiceSettings settings, mel::ILogger logger)
        {
            GrpcClient = grpcClient;
            CustomizerAttributeServiceSettings effectiveSettings = settings ?? CustomizerAttributeServiceSettings.GetDefault();
            gaxgrpc::ClientHelper clientHelper = new gaxgrpc::ClientHelper(effectiveSettings, logger);
            _callMutateCustomizerAttributes = clientHelper.BuildApiCall<MutateCustomizerAttributesRequest, MutateCustomizerAttributesResponse>("MutateCustomizerAttributes", grpcClient.MutateCustomizerAttributesAsync, grpcClient.MutateCustomizerAttributes, effectiveSettings.MutateCustomizerAttributesSettings).WithGoogleRequestParam("customer_id", request => request.CustomerId);
            Modify_ApiCall(ref _callMutateCustomizerAttributes);
            Modify_MutateCustomizerAttributesApiCall(ref _callMutateCustomizerAttributes);
            OnConstruction(grpcClient, effectiveSettings, clientHelper);
        }

        partial void Modify_ApiCall<TRequest, TResponse>(ref gaxgrpc::ApiCall<TRequest, TResponse> call) where TRequest : class, proto::IMessage<TRequest> where TResponse : class, proto::IMessage<TResponse>;

        partial void Modify_MutateCustomizerAttributesApiCall(ref gaxgrpc::ApiCall<MutateCustomizerAttributesRequest, MutateCustomizerAttributesResponse> call);

        partial void OnConstruction(CustomizerAttributeService.CustomizerAttributeServiceClient grpcClient, CustomizerAttributeServiceSettings effectiveSettings, gaxgrpc::ClientHelper clientHelper);

        /// <summary>The underlying gRPC CustomizerAttributeService client</summary>
        public override CustomizerAttributeService.CustomizerAttributeServiceClient GrpcClient { get; }

        partial void Modify_MutateCustomizerAttributesRequest(ref MutateCustomizerAttributesRequest request, ref gaxgrpc::CallSettings settings);

        /// <summary>
        /// Creates, updates or removes customizer attributes. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>The RPC response.</returns>
        public override MutateCustomizerAttributesResponse MutateCustomizerAttributes(MutateCustomizerAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomizerAttributesRequest(ref request, ref callSettings);
            return _callMutateCustomizerAttributes.Sync(request, callSettings);
        }

        /// <summary>
        /// Creates, updates or removes customizer attributes. Operation statuses are
        /// returned.
        /// </summary>
        /// <param name="request">The request object containing all of the parameters for the API call.</param>
        /// <param name="callSettings">If not null, applies overrides to this RPC call.</param>
        /// <returns>A Task containing the RPC response.</returns>
        public override stt::Task<MutateCustomizerAttributesResponse> MutateCustomizerAttributesAsync(MutateCustomizerAttributesRequest request, gaxgrpc::CallSettings callSettings = null)
        {
            Modify_MutateCustomizerAttributesRequest(ref request, ref callSettings);
            return _callMutateCustomizerAttributes.Async(request, callSettings);
        }
    }
}
